using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Collections;
using SourceCodeGenerator.Parser;

/// <summary>
/// Summary description for AspNetMvc
/// </summary>
public class HighchartsGenerator
{
    const int PROPERTY_NESTED_LEVELS = 10; // currently max levels of nested properties is five
    const string ROOT_CLASS = "Highcharts"; // the name of the root class
    const string ROOT_NAMESPACE = "Charts"; // the name of the root class

    List<ApiItem> _apiItems; // json api mappings will be stored here
    StreamWriter _log; // general debug related txt log file
    Hashtable _typeMappings; // maps HighChart types to C# types, where possible
    Hashtable _propertyTypeMappings; // maps properties that need special type not reflected in the JSON
    Hashtable _propertyInitMappings; // maps properties that needs special initialization logic
    Hashtable _enumMappings; // maps enums values that do not complile (e.g. special characters like "-" or "/" to other types
    Hashtable _seriesMappings; // maps series names to series classes
    List<string> _lists; // a list of all List<T> properties - needs this to "Hashify" them, otherwise they will be serialized with capital letters
    List<string> _excludedProperties; // properties that do not need to be ported to the server-side wrapper
    List<string> _customProperties; // properties that need custom JSON mappings (Animation, Shadow, etc). Defined in the CodeAddOns folder.

    string AssemblyFilePath { get; set; }
    IJsonParser JsonParser { get; set; }

    public HighchartsGenerator(IJsonParser jsonParser)
    {
        _apiItems = new List<ApiItem>();
        _typeMappings = new Hashtable();
        _propertyTypeMappings = new Hashtable();
        _propertyInitMappings = new Hashtable();
        _seriesMappings = new Hashtable();
        _enumMappings = new Hashtable();
        _excludedProperties = new List<string>();
        _customProperties = new List<string>();
        _lists = new List<string>();

        JsonParser = jsonParser;
        AssemblyFilePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        InitTypeMappings();
        InitPropertyTypeMappings();
        InitPropertyInitMappings();
        InitExcludedProperties();
        InitEnumMappings();
        InitCustomProperties();
        InitSeriesMappings();
        InitLists();
    }

    public void GenerateCode()
    {
        ///ParseItems();
        _apiItems = JsonParser.Get();

        //var items = _apiItems.Where(p => p.FullName.ToLower().Contains("yaxis.opposite"));

        GenerateClass(new ApiItem { Title = ROOT_CLASS, FullName = ROOT_CLASS });
        for (int i = 0; i < PROPERTY_NESTED_LEVELS; i++)
        {
            GenerateClassesForLevel(i);
        }
    }

    /// <summary>
    /// Read all properties from the JSON documentation file and create the respective ApiItem objects in memory
    /// </summary>
    //private void ParseItems()
    //{
    //    JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
    //    jsonSerializer.MaxJsonLength = Int32.MaxValue;

    //    string jsonAPI = File.ReadAllText(Server.MapPath("~/" + ROOT_CLASS + ".json"));
    //    object[] jsonObject = jsonSerializer.Deserialize<object[]>(jsonAPI);

    //    foreach (Dictionary<string, object> item in jsonObject)
    //    {
    //        ApiItem apiItem = new ApiItem(item);

    //        // do not add deprecated properties / objects to the API items collection
    //        if (apiItem.Deprecated)
    //            continue;

    //        // hover.market.state for all plotOptions has no returnType set - needs to be fixed after JSON is updated
    //        if (apiItem.ReturnType != null && apiItem.ReturnType == "" && apiItem.IsParent == false)
    //        {
    //            continue;
    //        }

    //        if (apiItem.FullName != null && apiItem.FullName.ToLower().Contains("series<"))
    //        {
    //            string[] tab = apiItem.FullName.Split('>');
    //            string[] seriesDetails = tab[0].Split('<');
    //            string value = FirstCharToUpper(seriesDetails[1]) + FirstCharToUpper(seriesDetails[0]);
    //            string key = tab[0] + '>';

    //            if (!_seriesMappings.Contains(key))
    //                _seriesMappings[key] = value;
    //        }

    //        if (apiItem.Products != null && apiItem.Products.Any(p => p == "highcharts"))
    //        {
    //            _apiItems.Add(apiItem);
    //        }
    //    }

    //    // Customize some of the API items for functionality that cannot be inferred automatically from the JSON file
    //    ProcessApiItems();
    //}

    private void ProcessApiItems()
    {
        //AppendMissingApiItems();

        string multitypeslist = "";

        foreach (ApiItem apiItem in _apiItems)
        {
            //if (apiItem.ReturnType != null && apiItem.ReturnType.Contains("|"))
            //    multitypeslist += System.Environment.NewLine+apiItem.FullName+" : "+apiItem.ReturnType;

            //if (apiItem.FullName.ToLower().Contains("chart") && apiItem.FullName.ToLower().Contains("width"))
            //if(apiItem.FullName.ToLower().Contains("pointplacement"))
            if (apiItem.Values != null && apiItem.Values.Count > 1)
                multitypeslist += System.Environment.NewLine + apiItem.FullName + " : " + apiItem.ReturnType;

            // All events (javascript functions) should default to empty string
            if (apiItem.ReturnType != null && (apiItem.ReturnType.ToLower() == "function" || apiItem.ReturnType.ToLower() == "string|function"))
                apiItem.Defaults = "";
            if (apiItem.Title == "pointPlacement")
            {
                apiItem.IsParent = true;
                apiItem.Values = new List<string>();
            }
            if (apiItem.Title == "symbol")
            {
                apiItem.IsParent = false;
                apiItem.Values = new List<string>();
            }
            if (apiItem.Title == "trackBorderColor")
            {
                apiItem.ReturnType = "String";
            }
            if (apiItem.Title == "tickInterval")
            {
                apiItem.ReturnType = "Number";
            }
            if (apiItem.Title == "tickPosition")
            {
                apiItem.Defaults = "outside";
            }
            if (apiItem.Title == "trackBorderWidth")
            {
                apiItem.ReturnType = "Number";
            }
            if (apiItem.Title == "connectNulls")
            {
                apiItem.Defaults = "false";
            }
            if (apiItem.FullName == "lang.months")
            {
                apiItem.Defaults = "['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December']";
            }
            if (apiItem.FullName == "lang.shortMonths")
            {
                apiItem.Defaults = "['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul',  'Aug', 'Sep', 'Oct', 'Nov', 'Dec']";
            }
            if (apiItem.FullName == "rangeSelector.inputPosition")
            {
                apiItem.Defaults = "{ \"align\" : \"right\" }";
            }
            if (apiItem.Title == "Colors")
            {
                apiItem.IsParent = false;
            }

            // add Defaults to enum if they are not available in the Values list.
            AddDefaultsToEnum(apiItem);

            UpdateDefaultsForHighcharts(apiItem);
        }
    }

    //update defaults because of differences between HS i HC
    private void UpdateDefaultsForHighcharts(ApiItem apiItem)
    {
        if (apiItem.FullName == "subtitle.text")
            return;

        if (apiItem.FullName == "chart.panning")
            apiItem.Defaults = "false";

        if (apiItem.FullName == "chart.pinchType")
            apiItem.Defaults = "null";

        if (apiItem.FullName.EndsWith("title.text"))
        {
            if (apiItem.FullName.StartsWith("legend") || apiItem.FullName.StartsWith("xAxis") || apiItem.FullName.StartsWith("zAxis"))
            {
                apiItem.Defaults = "null";
                return;
            }

            if (apiItem.FullName.StartsWith("yAxis"))
            {
                apiItem.Defaults = "Values";
                return;
            }

            apiItem.Defaults = "Chart title";
        }

        if (apiItem.FullName.StartsWith("yAxis.opposite"))
            apiItem.Defaults = "false";

        if (apiItem.FullName.StartsWith("xAxis.minPadding"))
            apiItem.Defaults = "0.01";

        if (apiItem.FullName.StartsWith("xAxis.maxPadding"))
            apiItem.Defaults = "0.01";
    }

    //private void AppendMissingApiItems()
    //{
    //    _apiItems.Add(new ApiItem { FullName = "colorAxis", Title = "colorAxis", IsParent = true });
    //    _apiItems.Add(new ApiItem { FullName = "colorAxis.stops", Title = "stops", IsParent = false, ReturnType = "Array<Array>" });
    //    _apiItems.Add(new ApiItem { FullName = "colorAxis.min", Title = "min", IsParent = false, ReturnType = "Number" });
    //    _apiItems.Add(new ApiItem { FullName = "colorAxis.max", Title = "max", IsParent = false, ReturnType = "Number" });
    //    _apiItems.Add(new ApiItem { FullName = "colorAxis.startOnTick", Title = "startOnTick", IsParent = false, ReturnType = "Boolean", Defaults = "false" });
    //    _apiItems.Add(new ApiItem { FullName = "colorAxis.endOnTick", Title = "endOnTick", IsParent = false, ReturnType = "Boolean", Defaults = "false" });
    //    _apiItems.Add(new ApiItem { FullName = "colorAxis.minColor", Title = "minColor", IsParent = false, ReturnType = "String" });
    //    _apiItems.Add(new ApiItem { FullName = "colorAxis.maxColor", Title = "maxColor", IsParent = false, ReturnType = "String" });

    //}


    private void GenerateClass(ApiItem item)
    {
        string className = item.Title;
        string codeTemplate = File.ReadAllText(AssemblyFilePath + "\\CodeTemplates\\Class.tpl");
        string propertyTemplate = File.ReadAllText(AssemblyFilePath + "\\CodeTemplates\\Property.tpl");

        string properties = "";
        string defaultValues = "";
        string hashtableComparers = "";
        List<ApiItem> children;

        if (item.Title == ROOT_CLASS)
            children = FindRootChildren();
        else
            children = FindImmediateChildren(item);

        if (item.FullName.ToLower().EndsWith("zones"))
            item.FullName = item.FullName.Remove(item.FullName.Length - 5) + "Zone";

        foreach (ApiItem child in children)
        {
            //string propertyName = FirstCharToUpper(child.Title);
            string propertyName = GetPropertyName(child);

            if (string.IsNullOrEmpty(propertyName))
                continue;

            if (_excludedProperties.Contains(propertyName) && child.IsParent == false)
                continue;
            if (_excludedProperties.Contains(child.FullName))
                continue;
            if (child == item)
                continue;

            child.Parent = item.FullName;

            if (child.Values != null && child.Values.Count > 0)
            {
                GenerateEnum(child);
            }

            if (child.Parent.ToLower().Contains("highcharts") && propertyName.ToLower().Contains("series") && propertyName.Length > 6)
                continue;

            if (propertyName.ToLower().EndsWith("datalabels") && (child.Parent.ToLower().EndsWith("data") || child.Parent.ToLower().EndsWith("levels")))
                child.IsParent = true;

            string formattedProperty = FormatProperty(propertyTemplate, child);
            string formattedDefaultProperty = FormatDefaultProperty(propertyName, child);
            string formattedComparer = FormatPropertyComparer(propertyName, child);

            if (propertyName.ToLower().EndsWith("datalabels") && (child.Parent.ToLower().EndsWith("data") || child.Parent.ToLower().EndsWith("levels")))
                child.IsParent = false;

            if (formattedDefaultProperty.ToLower().Contains("datalabels") && formattedDefaultProperty.Contains("null"))
                continue;

            properties += formattedProperty;
            defaultValues += formattedDefaultProperty;
            hashtableComparers += formattedComparer;
        }

        string extendsClass = "";
        if (_seriesMappings.ContainsKey(item.FullName))
            extendsClass = ": Series";
        else
            extendsClass = ": BaseObject";

        codeTemplate = codeTemplate
                        .Replace("{HighTemplate.Namespace}", "Highsoft.Web.Mvc." + ROOT_NAMESPACE)
                        .Replace("{HighTemplate.ConstrutorInitializers}", defaultValues)
                        .Replace("{HighTemplate.Properties}", properties)
                        .Replace("{HighTemplate.HashtableInit}", hashtableComparers)
                        .Replace("{HighTemplate.ExtendsClass}", extendsClass)
                        .Replace("{HighTemplate.ClassName}", GetClassNameFromItem(item));

        string fileName = GetClassNameFromItem(item);
        try
        {
            fileName = AssemblyFilePath + "\\CodeGeneration\\" + ROOT_CLASS + "\\" + GetClassNameFromItem(item) + ".cs";
        }
        catch (Exception ex)
        {
            throw;
        }

        File.WriteAllText(fileName, codeTemplate);
    }

    private void GenerateEnum(ApiItem apiItem)
    {
        string enumTemplate = File.ReadAllText(AssemblyFilePath+"\\CodeTemplates\\Enum.tpl");
        string fileName = AssemblyFilePath + "\\CodeGeneration\\" + ROOT_CLASS + "\\Enums\\" + GetClassNameFromItem(apiItem) + ".cs";

        List<string> enumValues = new List<string>();

        string enumList = "";
        for (int i = 0; i < apiItem.Values.Count; i++)
        {
            if (apiItem.Values[i] == null)
                apiItem.Values[i] = "null";

            if (apiItem.Values[i].Contains('-'))
            {
                var tab = apiItem.Values[i].Split('-');
                apiItem.Values[i] = "";

                foreach (var item in tab)
                    apiItem.Values[i] += FirstCharToUpper(item);
            }

            if (!String.IsNullOrEmpty(apiItem.Values[i]))
            {
                string enumValue = apiItem.Values[i];
                if (_enumMappings[enumValue] != null)
                    enumValue = _enumMappings[enumValue] as string;

                if (enumValues.Contains(enumValue))
                    continue;

                enumValues.Add(enumValue);


            }
        }

        for (int i = 0; i < enumValues.Count; i++)
        {
            enumList += FirstCharToUpper(enumValues[i]);
            if (i < enumValues.Count - 1)
                enumList += ", \n\t\t";
        }

        enumTemplate = enumTemplate
                        .Replace("{HighTemplate.Namespace}", "Highsoft.Web.Mvc." + ROOT_NAMESPACE)
                        .Replace("{HighTemplate.EnumName}", GetClassNameFromItem(apiItem))
                        .Replace("{HighTemplate.EnumList}", enumList);

        File.WriteAllText(fileName, enumTemplate);
    }

    private void AddDefaultsToEnum(ApiItem apiItem)
    {
        // only do that for verified enums
        if (apiItem.Values != null && apiItem.Values.Count > 0)
        {
            bool defaultMatched = false;
            foreach (string value in apiItem.Values)
            {
                if (value == apiItem.Defaults ||
                     "\"" + value + "\"" == apiItem.Defaults ||
                    (value == null && apiItem.Defaults == "null"))
                {
                    defaultMatched = true;
                    if (apiItem.Defaults != null)
                        apiItem.Defaults = apiItem.Defaults.Replace("\"", "");
                    break;
                }
            }

            // TitleVerticalAlign / SubTitleVerticalAlign have defaults set to " " and only Top, Center and Bottom as options
            string defaults = apiItem.Defaults;
            if (defaults == " " || defaults == "" || defaults == "''")
                apiItem.Defaults = apiItem.Values[0];
            else if (!defaultMatched)
                apiItem.Values.Insert(0, defaults);
        }

        if (apiItem.FullName == "chart.type" || (apiItem.FullName.StartsWith("series<") && apiItem.FullName.EndsWith(">.type")))
        {
            apiItem.Values.Add("bar");
            apiItem.Values.Add("heatmap");
            apiItem.Values.Add("pyramid");
            apiItem.Values.Add("polygon");
            apiItem.Values.Add("treemap");
            apiItem.Values.Add("solidgauge");

            apiItem.Values.Add("Bellcurve");
            apiItem.Values.Add("Bullet");
            apiItem.Values.Add("Histogram");
            apiItem.Values.Add("Pareto");
            apiItem.Values.Add("Sankey");
            apiItem.Values.Add("Scatter3d");
            apiItem.Values.Add("Streamgraph");
            apiItem.Values.Add("Sunburst");
            apiItem.Values.Add("Tilemap");
            apiItem.Values.Add("Variablepie");
            apiItem.Values.Add("Variwide");
            apiItem.Values.Add("Vector");
            apiItem.Values.Add("Windbarb");
            apiItem.Values.Add("Wordcloud");
            apiItem.Values.Add("Xrange");
        }
    }

    private string GetDefaultValueForEnum(ApiItem item)
    {
        string defaultValue = item.Defaults;
        if (String.IsNullOrEmpty(defaultValue))
        {
            defaultValue = item.Values[0];
        }
        if (_enumMappings[defaultValue] != null)
            defaultValue = _enumMappings[defaultValue] as string;

        if (defaultValue.Contains('-'))
        {
            var tab = defaultValue.Split('-');
            defaultValue = "";

            foreach (var t in tab)
                defaultValue += FirstCharToUpper(t);
        }

        return String.Format("{0}.{1}", GetClassNameFromItem(item), FirstCharToUpper(defaultValue));
    }

    private string GetClassNameFromItem(ApiItem item)
    {
        string[] parts = item.FullName.Split('.');
        string result = "";

        foreach (string part in parts)
        {
            string formattedPart = part;
            if (_seriesMappings[part] != null)
                formattedPart = (string)_seriesMappings[part];
            result += FirstCharToUpper(formattedPart);
        }

        return result;
    }

    private string GetPropertyName(ApiItem item)
    {
        string result = item.Title;
        if (_seriesMappings[result] != null)
        {
            result = (string)_seriesMappings[result];
        }

        if (string.IsNullOrEmpty(result))
            return null;
        //if (string.IsNullOrWhiteSpace(result))
        //    throw new Exception("empty series mapping result");

        return FirstCharToUpper(result);
    }

    private string FormatProperty(string propertyTemplate, ApiItem child)
    {
        string propertyName = GetPropertyName(child);
        string returnType = GetPropertyReturnType(child, propertyName);

        if (child.Values != null && child.Values.Count > 0)
            returnType = GetClassNameFromItem(child);

        if (propertyName == "PointDescriptionThreshold")
        {
            returnType = "long?";
            child.Description = "<p>When a series contains more points than this, we no longer expose information about individual points to screen readers.</p><p>Set to <code>null</code> to disable.</p>";
        }

        if (propertyName == "FillColor")
            returnType = "object";

        if (propertyName == "Data" && child.Parent.ToLower() == "highcharts")
            returnType = "Data";

        if (propertyName == "Height" && child.Parent.ToLower() == "chart")
            returnType = "double?";

        if (propertyName == "Margin" && child.Parent.ToLower() != "chart")
            returnType = "double?";

        if (propertyName == "Margin" && child.Parent.ToLower() == "chart")
            returnType = "double[]";

        return propertyTemplate
         .Replace("{HighTemplate.Name}", propertyName)
         .Replace("{HighTemplate.Type}", returnType)
         .Replace("{HighTemplate.Comment}", child.Description
                                             .Replace("\r", "")
                                             .Replace("\t", "")
                                             .Replace("\n", ""));
    }

    private string GetPropertyReturnType(ApiItem child, string propertyName)
    {
        string returnType = child.IsParent ? propertyName : child.ReturnType;

        if (propertyName.ToLower() == "data" && child.Parent != null)
        {
            string result = child.Parent;
            if (_seriesMappings[result] != null)
            {
                result = (string)_seriesMappings[result];
            }
            else
            {
                if (result.Contains('.'))
                {
                    var tab = result.Split('.');
                    result = "";

                    foreach (var item in tab)
                        result += FirstCharToUpper(item);
                }
                else
                    result = FirstCharToUpper(result);
            }
            return "List<" + result + "Data" + ">";
        }

        if (child.Parent != ROOT_CLASS && (child.Title.ToLower() == "xaxis" || child.Title.ToLower() == "yaxis"))
            return "string";

        if (_propertyTypeMappings[child.FullName] != null)
            return _propertyTypeMappings[child.FullName].ToString();
        if (_propertyTypeMappings[child.Title] != null)
            return _propertyTypeMappings[child.Title].ToString();
        if (_propertyTypeMappings[propertyName] != null)
            return _propertyTypeMappings[propertyName].ToString();

        if (returnType != null)
            if (_typeMappings[returnType] != null)
                return _typeMappings[returnType].ToString();

        if (child.ReturnType == "Array" && child.Title == "zones")
            returnType = string.Format("List<{0}>", GetClassNameFromItem(child).Replace("Zones", "Zone"));
        else
        if (child.IsParent)
            returnType = GetClassNameFromItem(child);
        else
        {
            if (returnType == "Boolean|Object")
                returnType = "object";
        }

        if (returnType.EndsWith("DataDataLabels"))
            returnType = returnType.Replace("DataData", "Data");

        if (returnType.EndsWith("LevelsDataLabels"))
            returnType = returnType.Replace("LevelsData", "Data");



        return returnType;
    }

    private string FormatDefaultProperty(string propertyName, ApiItem child)
    {
        return String.Format("{0} = {1} = {2};\n\t\t\t", propertyName, propertyName + "_DefaultValue", MapDefaultValue(child));
    }

    private string FormatPropertyComparer(string propertyName, ApiItem child)
    {
        string simplePropertyFormat = "if ({0} != {1}) h.Add(\"{2}\",{0});\n\t\t\t";
        string listPropertyFormat = "if ({0} != {1}) h.Add(\"{2}\", HashifyList({0}));\n\t\t\t";
        string enumPropertyFormat = "if ({0} != {1}) h.Add(\"{2}\", {3}.FirstCharacterToLower({0}.ToString()));\n\t\t\t";
        string functionPropertyFormat = "if ({0} != {2}) {{ h.Add(\"{1}\",{0}); {4}.AddFunction(\"{3}\", {0}); }}  \n\t\t\t";
        string complexPropertyFormat = "if ({0}.IsDirty()) h.Add(\"{1}\",{0}.ToHashtable());\n\t\t\t";
        string customPropertyFormat = "if ({0}.IsDirty()) h.Add(\"{1}\",{0}.ToJSON());\n\t\t\t";

        //if (propertyName == "Data" && child.FullName != "data")
        //    return "";

        // fully qualified names that are collections
        if (_lists.Contains(child.Title) || _lists.Contains(child.FullName))
        {
            if (child.FullName == "Data" && child.Parent.ToLower().Contains("highcharts"))
                return String.Format(complexPropertyFormat, child.FullName, FirstCharToLower(child.FullName));

            if (child.FullName == "Data")
                return "if (Data.Any()) h.Add(\"data\",HashifyList(Data));\n\t\t\t";

            if ((child.Title.ToLower() == "xaxis" || child.Title.ToLower() == "yaxis") && child.Parent != "Highcharts")
                return String.Format(simplePropertyFormat, propertyName, propertyName + "_DefaultValue", FirstCharToLower(propertyName));

            return String.Format(listPropertyFormat, propertyName, propertyName + "_DefaultValue", FirstCharToLower(propertyName));
        }
        if (_lists.Contains(propertyName))
        {
            if (propertyName == "Data" && child.Parent.ToLower().Contains("highcharts"))
                return String.Format(complexPropertyFormat, propertyName, FirstCharToLower(propertyName));

            if (propertyName == "Data")
                return "if (Data.Any()) h.Add(\"data\",HashifyList(Data));\n\t\t\t";

            if (propertyName == "Stops")
                return "if (Stops.Any()) h.Add(\"stops\", GetLists(Stops));\n\t\t\t";

            return String.Format(listPropertyFormat, propertyName, propertyName + "_DefaultValue", FirstCharToLower(propertyName));
        }
        if (_propertyTypeMappings.Contains(child.Title) || _propertyTypeMappings.Contains(child.FullName))
        {
            if (child.FullName == "plotOptions.series")
                return String.Format(complexPropertyFormat, propertyName, FirstCharToLower(propertyName));

            if (child.Title.ToLower() == "series" && child.Parent == "Highcharts")
                return String.Format(listPropertyFormat, propertyName, propertyName + "_DefaultValue", FirstCharToLower(propertyName));

            if (propertyName.ToLower().Contains("pointplacement"))
                return "if (PointPlacement.IsDirty())\n\t\t\t\tif (PointPlacement.Value.HasValue)\n\t\t\t\t\th.Add(\"pointPlacement\", PointPlacement.Value);\n\t\t\t\telse\n\t\t\t\t\th.Add(\"pointPlacement\", PointPlacement.ToJSON());\n\t\t\t";

            return String.Format(simplePropertyFormat, propertyName, propertyName + "_DefaultValue", FirstCharToLower(propertyName));
        }
        // property that needs custom serialization (Animation, Shadow, etc)
        if (_customProperties.Contains(propertyName))
        {


            return String.Format(customPropertyFormat, propertyName, FirstCharToLower(propertyName));
        }
        // Enum
        if (child.Values != null && child.Values.Count > 0)
            return String.Format(enumPropertyFormat, propertyName, propertyName + "_DefaultValue", FirstCharToLower(propertyName), ROOT_CLASS);
        // Complex object with nested objects / properties
        if (child.IsParent)
        {
            if ((child.Parent == "chart.resetZoomButton" || child.Parent == "credits" || child.Parent == "noData") && propertyName == "Position")
                return "if (Position.Count > 0) h.Add(\"position\",Position);\n\t\t\t";

            if (child.ReturnType == "Array" && child.Title == "zones")
                return string.Format(listPropertyFormat, propertyName, propertyName + "_DefaultValue", FirstCharToLower(propertyName));

            return String.Format(complexPropertyFormat, propertyName, FirstCharToLower(propertyName));
        }
        // Event (javascript function)
        if (child.ReturnType != null && (child.ReturnType.ToLower() == "function" || child.ReturnType.ToLower() == "string|function"))
            return String.Format(functionPropertyFormat, propertyName, FirstCharToLower(propertyName), propertyName + "_DefaultValue", GetClassNameFromItem(child) + "." + FirstCharToLower(propertyName), ROOT_CLASS);
        // Just a property
        else
        {
            if (propertyName == "PointDescriptionThreshold")
                return "if (PointDescriptionThreshold != PointDescriptionThreshold_DefaultValue)\n\t\t\t{\n\t\t\t\tif (PointDescriptionThreshold != null)\n\t\t\t\t\th.Add(\"pointDescriptionThreshold\", PointDescriptionThreshold);\n\t\t\t\telse\n\t\t\t\t\th.Add(\"pointDescriptionThreshold\", false);\n\t\t\t}\n\t\t\t";

            if (propertyName == "Shadow")
                return String.Format(complexPropertyFormat, propertyName, FirstCharToLower(propertyName));

            return String.Format(simplePropertyFormat, propertyName, propertyName + "_DefaultValue", FirstCharToLower(propertyName));
        }
    }

    private void GenerateClassesForLevel(int level)
    {
        foreach (ApiItem item in _apiItems)
        {
            //if (item.FullName.ToLower().Contains("boxplot") || item.Title.ToLower().Contains("boxplot"))
            //{
            //    if (item.FullName.ToLower().Contains("datalabels") || item.Title.ToLower().Contains("datalabels"))
            //    {
            //        item.IsParent = true;
            //    }
            //}

            if (item.Parents.Count == level && item.IsParent)
            {
                GenerateClass(item);
            }
        }
    }

    private List<ApiItem> FindImmediateChildren(ApiItem rootItem)
    {
        List<ApiItem> children = new List<ApiItem>();

        foreach (ApiItem item in _apiItems)
        {
            int lastIndex = item.FullName.LastIndexOf('.');
            string parent = item.FullName;

            if (lastIndex > 0)
                parent = item.FullName.Substring(0, lastIndex);

            if (parent == rootItem.FullName)
            {
                children.Add(item);
            }
        }

        return children;
    }

    private List<ApiItem> FindRootChildren()
    {
        List<ApiItem> children = new List<ApiItem>();
        foreach (ApiItem item in _apiItems)
        {
            if (item.Parent == null)
            {
                children.Add(item);
            }
        }

        return children;
    }

    private void InitEnumMappings()
    {
        _enumMappings.Add("triangle-down", "triangledown");
        _enumMappings.Add("image/png", "imagepng");
        _enumMappings.Add("image/jpeg", "imagejpeg");
        _enumMappings.Add("application/pdf", "applicationpdf");
        _enumMappings.Add("image/svg+xml", "imagesvgxml");
    }

    private void InitTypeMappings()
    {
        _typeMappings.Add("String", "string");
        _typeMappings.Add("Text", "string");
        _typeMappings.Add("Number", "double?");
        _typeMappings.Add("Boolean", "bool?");
        //_typeMappings.Add("Boolean|Object", "object");
        _typeMappings.Add("function", "string");
        _typeMappings.Add("function|null", "string");
        _typeMappings.Add("String|Function", "string");
        _typeMappings.Add("String|Object", "string");
        _typeMappings.Add("Color", "string");
        _typeMappings.Add("CSSObject", "Hashtable");
        _typeMappings.Add("Number|String", "string");
        _typeMappings.Add("String|Number", "string");
        _typeMappings.Add("String|undefined", "string");
        _typeMappings.Add("String|null", "string");
        _typeMappings.Add("String|HTMLElement", "string");
        _typeMappings.Add("Array.<Color>", "List<string>");
        _typeMappings.Add("Array.<String>", "List<string>");
        _typeMappings.Add("Array.<String>;", "List<string>");
        _typeMappings.Add("Array.<Number>", "List<double>");
        _typeMappings.Add("Array.<Array.<Mixed>>", "List<List<object>>");
        _typeMappings.Add("Array.<Object>", "List<object>");
    }

    private void InitPropertyTypeMappings()
    {
        _propertyTypeMappings.Add("shadow", "Shadow");
        _propertyTypeMappings.Add("plotShadow", "Shadow");
        _propertyTypeMappings.Add("animation", "Animation");
        _propertyTypeMappings.Add("pointPlacement", "PointPlacement");
        _propertyTypeMappings.Add("center", "string[]");
        _propertyTypeMappings.Add("margin", "string[]");
        _propertyTypeMappings.Add("position", "Hashtable");
        _propertyTypeMappings.Add("dateTimeLabelFormats", "Hashtable");
        _propertyTypeMappings.Add("inputPosition", "Hashtable");
        _propertyTypeMappings.Add("attr", "Hashtable");
        //_propertyTypeMappings.Add("style", "Hashtable");
        _propertyTypeMappings.Add("inputStyle", "Hashtable");
        _propertyTypeMappings.Add("labelStyle", "Hashtable");
        _propertyTypeMappings.Add("stack", "string");
        _propertyTypeMappings.Add("symbol", "string");
        _propertyTypeMappings.Add("trackBorderColor", "string");
        //_propertyTypeMappings.Add("background", "List<Background>");
        _propertyTypeMappings.Add("menuItems", "List<MenuItem>");
        _propertyTypeMappings.Add("crosshairs", "List<Crosshair>");
        _propertyTypeMappings.Add("stops", "List<Stop>");
        _propertyTypeMappings.Add("renderTo", "string");
        _propertyTypeMappings.Add("series", "List<Series>");
        _propertyTypeMappings.Add("drilldown.series", "List<Series>");
        _propertyTypeMappings.Add("xAxis", "List<XAxis>");
        _propertyTypeMappings.Add("yAxis", "List<YAxis>");
        _propertyTypeMappings.Add("yAxis.plotBands", "List<YAxisPlotBands>");
        _propertyTypeMappings.Add("yAxis.plotLines", "List<YAxisPlotLines>");
        _propertyTypeMappings.Add("yAxis.plotBands.label.style", "Hashtable");
        _propertyTypeMappings.Add("xAxis.plotBands", "List<XAxisPlotBands>");
        _propertyTypeMappings.Add("xAxis.plotLines", "List<XAxisPlotLines>");
        _propertyTypeMappings.Add("xAxis.plotBands.label.style", "Hashtable");
        _propertyTypeMappings.Add("series<treemap>.levels", "List<TreemapSeriesLevels>");
        _propertyTypeMappings.Add("pane.background", "List<PaneBackground>");
        _propertyTypeMappings.Add("plotOptions.series", "PlotOptionsSeries");
        _propertyTypeMappings.Add("annotations", "List<Annotations>");
        _propertyTypeMappings.Add("annotations.labels", "List<AnnotationsLabels>");
        _propertyTypeMappings.Add("annotations.shapes", "List<AnnotationsShapes>");
        _propertyTypeMappings.Add("colorAxis.dataClasses", "List<ColorAxisDataClasses>");
    }

    private void InitPropertyInitMappings()
    {
        _propertyInitMappings.Add("shadow", "new Shadow() { Enabled = false }");
        _propertyInitMappings.Add("plotShadow", "new Shadow() { Enabled = false }");
        _propertyInitMappings.Add("animation", "new Animation() { Enabled = true }");
        _propertyInitMappings.Add("pointPlacement", "new PointPlacement()");
        _propertyInitMappings.Add("crosshairs", "new List<Crosshair>()");
        _propertyInitMappings.Add("menuItems", "new List<MenuItem>()");
        //_propertyInitMappings.Add("Symbol", "new Symbol()");
        _propertyInitMappings.Add("colors", "new List<string>()");
        _propertyInitMappings.Add("center", "new string[] { \"50%\", \"50%\" }");
        _propertyInitMappings.Add("margin", "new string[] {}");
        _propertyInitMappings.Add("position", "new Hashtable()");
        _propertyInitMappings.Add("dateTimeLabelFormats", "new Hashtable()");
        _propertyInitMappings.Add("inputPosition", "new Hashtable()");
        //_propertyInitMappings.Add("style", "new Hashtable()");
        _propertyInitMappings.Add("inputStyle", "new Hashtable()");
        _propertyInitMappings.Add("labelStyle", "new Hashtable()");
        _propertyInitMappings.Add("columns", "new List<List<Object>>()");
        _propertyInitMappings.Add("rows", "new List<List<object>>()");
        _propertyInitMappings.Add("seriesMapping", "new List<object>()");
        _propertyInitMappings.Add("keys", "new List<string>()");
        _propertyInitMappings.Add("series", "new List<Series>()");
        _propertyInitMappings.Add("xAxis", "new List<XAxis>()");
        _propertyInitMappings.Add("yAxis", "new List<YAxis>()");
        _propertyInitMappings.Add("yAxis.plotLines", "new List<YAxisPlotLines>()");
        _propertyInitMappings.Add("yAxis.plotBands", "new List<YAxisPlotBands>()");
        _propertyInitMappings.Add("yAxis.plotBands.label.style", "new Hashtable()");
        _propertyInitMappings.Add("xAxis.plotLines", "new List<XAxisPlotLines>()");
        _propertyInitMappings.Add("xAxis.plotBands", "new List<XAxisPlotBands>()");
        _propertyInitMappings.Add("xAxis.plotBands.label.style", "new Hashtable()");
        _propertyInitMappings.Add("series<treemap>.levels", "new List<TreemapSeriesLevels>()");
        _propertyInitMappings.Add("pane.background", "new List<PaneBackground>()");
        _propertyInitMappings.Add("plotOptions.series", "new PlotOptionsSeries()");
        _propertyInitMappings.Add("annotations", "new List<Annotations>()");
        _propertyInitMappings.Add("annotations.labels", "new List<AnnotationsLabels>()");
        _propertyInitMappings.Add("annotations.shapes", "new List<AnnotationsShapes>()");
        _propertyInitMappings.Add("colorAxis.dataClasses", "new List<ColorAxisDataClasses>()");
    }

    private void InitLists()
    {
        _lists.Add("pane.background");
        _lists.Add("MenuItem");
        //_lists.Add("Crosshair");
        _lists.Add("Data");
        _lists.Add("Stops");
        _lists.Add("xAxis");
        _lists.Add("yAxis");
        _lists.Add("yAxis.plotBands");
        _lists.Add("yAxis.plotLines");
        _lists.Add("xAxis.plotBands");
        _lists.Add("xAxis.plotLines");
        _lists.Add("series<treemap>.levels");
        _lists.Add("annotations");
        _lists.Add("annotations.labels");
        _lists.Add("annotations.shapes");
        _lists.Add("colorAxis.dataClasses");
    }

    private void InitSeriesMappings()
    {
        _seriesMappings.Add("series<ad>", "AdSeries");
        _seriesMappings.Add("series<area>", "AreaSeries");
        _seriesMappings.Add("series<arearange>", "ArearangeSeries");
        _seriesMappings.Add("series<areaspline>", "AreasplineSeries");
        _seriesMappings.Add("series<areasplinerange>", "AreasplinerangeSeries");
        _seriesMappings.Add("series<bar>", "BarSeries");
        _seriesMappings.Add("series<boxplot>", "BoxplotSeries");
        _seriesMappings.Add("series<bubble>", "BubbleSeries");
        _seriesMappings.Add("series<column>", "ColumnSeries");
        _seriesMappings.Add("series<columnrange>", "ColumnrangeSeries");
        _seriesMappings.Add("series<errorbar>", "ErrorbarSeries");
        _seriesMappings.Add("series<funnel>", "FunnelSeries");
        _seriesMappings.Add("series<gauge>", "GaugeSeries");
        _seriesMappings.Add("series<heatmap>", "HeatmapSeries");
        _seriesMappings.Add("series<line>", "LineSeries");
        _seriesMappings.Add("series<pie>", "PieSeries");
        _seriesMappings.Add("series<polygon>", "PolygonSeries");
        _seriesMappings.Add("series<pyramid>", "PyramidSeries");
        _seriesMappings.Add("series<scatter>", "ScatterSeries");
        _seriesMappings.Add("series<solidgauge>", "SolidgaugeSeries");
        _seriesMappings.Add("series<spline>", "SplineSeries");
        _seriesMappings.Add("series<treemap>", "TreemapSeries");
        _seriesMappings.Add("series<waterfall>", "WaterfallSeries");

        // Highstock specific
        _seriesMappings.Add("series<flags>", "FlagsSeries");
        _seriesMappings.Add("series<candlestick>", "CandleStickSeries");
        _seriesMappings.Add("series<ohlc>", "OhlcSeries");


    }

    private void InitExcludedProperties()
    {
        _excludedProperties.Add("BaseSeries");
        _excludedProperties.Add("Spacing");
        _excludedProperties.Add("Date");
        _excludedProperties.Add("Units");
        _excludedProperties.Add("plotOptions.scatter.tooltip");
        _excludedProperties.Add("plotOptions.polygon.tooltip");
        _excludedProperties.Add("series<polygon>.tooltip");
        _excludedProperties.Add("series<scatter>.tooltip");

    }

    private void InitCustomProperties()
    {
        _customProperties.Add("Animation");
        _customProperties.Add("PlotShadow");
        _customProperties.Add("PointPlacement");
        //_customProperties.Add("Symbol");
    }

    private static string FirstCharToUpper(string input)
    {
        if (String.IsNullOrEmpty(input))
            throw new ArgumentException("String is empty");

        return input.First().ToString().ToUpper() + input.Substring(1);
    }

    private static string FirstCharToLower(string input)
    {
        if (String.IsNullOrEmpty(input))
            throw new ArgumentException("String is empty");

        return input.First().ToString().ToLower() + input.Substring(1);
    }


    public string MapDefaultValue(ApiItem item)
    {
        string defaults = item.Defaults;

        if (item.Defaults == "\n")
            return "null";

        if (item.Title.ToLower() == "data" && item.Parent != null)
        {
            if (item.Parent.ToLower() == "highcharts")
                return "new Data()";

            string result = item.Parent;
            if (_seriesMappings[result] != null)
            {
                result = (string)_seriesMappings[result];
            }
            else
            {
                if (result.Contains('.'))
                {
                    var tab = result.Split('.');
                    result = "";

                    foreach (var t in tab)
                        result += FirstCharToUpper(t);
                }
                else
                {
                    result = FirstCharToUpper(result);
                }
            }
            return "new List<" + result + "Data" + ">()";//null;
        }

        if (item.Title.ToLower() == "fillcolor")
            return "null";

        //if (item.Title.ToLower() == "background" && item.Parent.ToLower() == "pane")
        //    return "new List<Background>()";

        if (item.Title.ToLower() == "enabled" && item.Parent.ToLower() == "series<treemap>.datalabels")
            return "null";

        if (item.Title.ToLower() == "fillcolor")
            return "null";

        if (item.Title.ToLower() == "height" && item.Parent.ToLower() == "chart")
            return "null";

        if (item.Title.ToLower() == "margin" && item.Parent.ToLower() != "chart")
            return "null";

        if (item.Title.ToLower() == "margin" && item.Parent.ToLower() == "chart")
            return "new double[]{}";

        if (item.Title.ToLower() == "stops")
            return "new List<Stop>()";

        //if (item.Title.ToLower().Contains("datalabels") && item.Parent.ToLower().EndsWith("data"))
        //    item.IsParent = true;

        if (_propertyInitMappings[item.FullName] != null)
        {
            defaults = _propertyInitMappings[item.FullName].ToString();
        }
        else if (_propertyInitMappings[item.Title] != null)
        {
            defaults = _propertyInitMappings[item.Title].ToString();
        }

        if (item.Values != null && item.Values.Count > 0)
        {
            return GetDefaultValueForEnum(item);
        }

        if (!item.IsParent)
        {
            if ((item.Title.ToLower() == "xaxis" || item.Title.ToLower() == "yaxis") && item.Parent == null)
                return defaults;

            if (item.Title.ToLower() == "position")
                return defaults;

            if (item.FullName.EndsWith("data.x") || item.FullName.EndsWith("data.y"))
            {
                return "double.MinValue";
            }
            if (item.ReturnType.ToLower() == "function" || item.ReturnType.ToLower() == "string|function")
                return "\"\"";

            if ((item.Title.ToLower() == "xaxis" || item.Title.ToLower() == "yaxis") && item.Parent != null)
                defaults = "";

            if (!String.IsNullOrEmpty(item.Defaults))
            {
                if (item.ReturnType == "String" ||
                    item.ReturnType == "Color" ||
                    item.ReturnType == "String|Number" ||
                    item.ReturnType == "Number|String")
                {
                    return '"' + defaults.Replace("\"", "'") + '"';
                }
                if (item.ReturnType.StartsWith("Array.<String>")) // thereis Array<String>; ending with ; in Highstock
                {
                    return "new List<string> " + item.Defaults
                                        .Replace("'", "\"")
                                        .Replace("[", "{")
                                        .Replace("]", "}");
                }
                if (item.ReturnType == "Array.<Number>")
                {
                    return "new List<double> " + item.Defaults
                                        .Replace("[", "{")
                                        .Replace("]", "}");
                }
                if ((_propertyTypeMappings[item.Title] != null &&
                    _propertyTypeMappings[item.Title].ToString() == "Hashtable") ||
                    (_typeMappings[(item.ReturnType)] != null &&
                    _typeMappings[(item.ReturnType)].ToString() == "Hashtable"))
                {
                    string result = "new Hashtable" + "{" + item.Defaults
                                                        .Replace(",", "},{")
                                                        .Replace(";", "},{")
                                                        .Replace(":", ",") + "}";
                    if (item.Title == "position")
                        result = result.Replace("0", "\"0\"");



                    return result;
                }
                if (defaults == "undefined")
                {
                    return "null";
                }
            }
            else
            {
                if (item.ReturnType == "Number")
                    return "null";
            }

            if (defaults == "")
                return "\"\"";
            if (defaults == null)
                return "null";
        }
        else
        {
            //return String.Format("new {0}()", FirstCharToUpper(item.Title));
            if (_propertyInitMappings[item.FullName] != null)
            {
                return _propertyInitMappings[item.FullName].ToString();
            }
            if (_propertyInitMappings[item.Title] != null)
            {
                return _propertyInitMappings[item.Title].ToString();
            }

            //if (item.Title.ToLower().Contains("datalabels") && item.Parent.ToLower().EndsWith("data"))
            //    item.IsParent = false;

            if (item.ReturnType == "Array" && item.Title == "zones")
                return string.Format("new List<{0}>()", GetClassNameFromItem(item).Replace("Zones", "Zone"));

            if (item.FullName.ToLower().Contains("data.datalabels"))
                item.FullName = item.FullName.Replace("data.", "");

            if (item.FullName.ToLower().Contains("levels.datalabels"))
                item.FullName = item.FullName.Replace("levels.", "");

            return String.Format("new {0}()", GetClassNameFromItem(item));

        }

        return defaults;
    }
}
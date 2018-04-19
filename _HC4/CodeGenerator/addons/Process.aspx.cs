using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addons_Process : System.Web.UI.Page
{
    const int PROPERTY_NESTED_LEVELS = 10; // currently max levels of nested properties is five
    const string ROOT_CLASS = "ECharts"; // the name of the root class
    const string ROOT_NAMESPACE = "Charts"; // the name of the root class

    List<AddOnApiItem> _allItems = new List<AddOnApiItem>();
    StreamWriter _log; // general debug related txt log file
    Hashtable _typeMappings; // maps HighChart types to C# types, where possible
    Hashtable _propertyTypeMappings; // maps properties that need special type not reflected in the JSON
    Hashtable _propertyInitMappings; // maps properties that needs special initialization logic
    Hashtable _enumMappings; // maps enums values that do not complile (e.g. special characters like "-" or "/" to other types
    Hashtable _seriesMappings; // maps series names to series classes
    List<string> _lists; // a list of all List<T> properties - needs this to "Hashify" them, otherwise they will be serialized with capital letters
    List<string> _excludedProperties; // properties that do not need to be ported to the server-side wrapper
    List<string> _customProperties; // properties that need custom JSON mappings (Animation, Shadow, etc). Defined in the CodeAddOns folder.

    protected void Page_Load(object sender, EventArgs e)
    {
        InitAll();

        string jsonAPI = File.ReadAllText(Server.MapPath("~/addons/api.txt"));
        var converter = new ExpandoObjectConverter();
        dynamic apiItems = JsonConvert.DeserializeObject<ExpandoObject>(jsonAPI, converter);

        ProcessItem(apiItems.definitions, null);

        foreach (AddOnApiItem item in _allItems)
        {
            log.Text += String.Format("{0} : {1} : {2} <br/>",
                                            item.Title,
                                            item.ReturnType,
                                            item.FullName);
        }

        GenerateClass(new AddOnApiItem { Title = ROOT_CLASS, FullName = ROOT_CLASS });
        for (int i = 0; i < PROPERTY_NESTED_LEVELS; i++)
        {
            GenerateClassesForLevel(i);
        }
    }

    private void InitAll()
    {
        _typeMappings = new Hashtable();
        _propertyTypeMappings = new Hashtable();
        _propertyInitMappings = new Hashtable();
        _seriesMappings = new Hashtable();
        _enumMappings = new Hashtable();
        _excludedProperties = new List<string>();
        _customProperties = new List<string>();
        _lists = new List<string>();        

        InitTypeMappings();
        InitPropertyTypeMappings();
        InitPropertyInitMappings();
        InitExcludedProperties();
        InitEnumMappings();
        InitCustomProperties();
        InitSeriesMappings();
        InitLists();
    }
    

    private void ProcessItem(ExpandoObject item, string parent)
    {
        foreach (KeyValuePair<string, object> childItem in item)
        {
            AddOnApiItem apiItem = new AddOnApiItem(childItem, parent);
            _allItems.Add(apiItem);

            if (apiItem.IsParent)
            {
                ProcessItem(((ExpandoObject)apiItem.ChildNode), apiItem.Title);
            }
        }
       
    }

    private void GenerateClass(AddOnApiItem item)
    {
        string className = item.Title;
        string codeTemplate = File.ReadAllText(Server.MapPath("~/CodeTemplates/Class.tpl"));
        string propertyTemplate = File.ReadAllText(Server.MapPath("~/CodeTemplates/Property.tpl"));

        string properties = "";
        string defaultValues = "";
        string hashtableComparers = "";
        List<AddOnApiItem> children;

        if (item.Title == ROOT_CLASS)
            children = FindRootChildren();
        else
            children = FindImmediateChildren(item);

        foreach (AddOnApiItem child in children)
        {
            //string propertyName = FirstCharToUpper(child.Title);
            string propertyName = GetPropertyName(child);
            if (_excludedProperties.Contains(propertyName) && child.IsParent == false)
                continue;
            if (_excludedProperties.Contains(child.FullName))
                continue;
            if (child == item)
                continue;

            if (child.Values != null && child.Values.Count > 0)
            {
                GenerateEnum(child);
            }

            string formattedProperty = FormatProperty(propertyTemplate, child);
            string formattedDefaultProperty = FormatDefaultProperty(propertyName, child);
            string formattedComparer = FormatPropertyComparer(propertyName, child);

            properties += formattedProperty;
            defaultValues += formattedDefaultProperty;
            hashtableComparers += formattedComparer;
        }

        string extendsClass = "";
        if (_seriesMappings.ContainsKey(item.Title))
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

        string fileName = Server.MapPath("~/CodeGeneration/" + ROOT_CLASS + "/" + GetClassNameFromItem(item) + ".cs");

        File.WriteAllText(fileName, codeTemplate);
    }

    private void GenerateEnum(AddOnApiItem apiItem)
    {
        string enumTemplate = File.ReadAllText(Server.MapPath("~/CodeTemplates/Enum.tpl"));
        string fileName = Server.MapPath("~/CodeGeneration/" + ROOT_CLASS + "/Enums/" + GetClassNameFromItem(apiItem) + ".cs");

        string enumList = "";
        for (int i = 0; i < apiItem.Values.Count; i++)
        {
            if (apiItem.Values[i] == null)
                apiItem.Values[i] = "null";


            if (!String.IsNullOrEmpty(apiItem.Values[i]))
            {
                string enumValue = apiItem.Values[i];
                if (_enumMappings[enumValue] != null)
                    enumValue = _enumMappings[enumValue] as string;

                enumList += FirstCharToUpper(enumValue);
                if (i < apiItem.Values.Count - 1)
                    enumList += ", \n\t\t";
            }
        }

        enumTemplate = enumTemplate
                        .Replace("{HighTemplate.Namespace}", "Highsoft.Web.Mvc." + ROOT_NAMESPACE)
                        .Replace("{HighTemplate.EnumName}", GetClassNameFromItem(apiItem))
                        .Replace("{HighTemplate.EnumList}", enumList);

        File.WriteAllText(fileName, enumTemplate);
    }

    private void AddDefaultsToEnum(AddOnApiItem apiItem)
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

        // For some reason bar is missing from the chart and series types in the JSON - possibly omission
        if (apiItem.FullName == "chart.type" ||
            apiItem.FullName == "series.type" ||
            apiItem.FullName == "series<bar>.type" ||
            apiItem.FullName == "series<heatmap>.type" ||
            apiItem.FullName == "series<polygon>.type" ||
            apiItem.FullName == "series<treemap>.type" ||
            apiItem.FullName == "series<solidgauge>.type" ||
            apiItem.FullName == "series<pyramid>.type")
        {
            apiItem.Values.Add("bar");
            apiItem.Values.Add("heatmap");
            apiItem.Values.Add("pyramid");
            apiItem.Values.Add("polygon");
            apiItem.Values.Add("treemap");
            apiItem.Values.Add("solidgauge");
        }
    }

    private string GetDefaultValueForEnum(AddOnApiItem item)
    {
        string defaultValue = item.Defaults;
        if (String.IsNullOrEmpty(defaultValue))
        {
            defaultValue = item.Values[0];
        }
        if (_enumMappings[defaultValue] != null)
            defaultValue = _enumMappings[defaultValue] as string;

        return String.Format("{0}.{1}", GetClassNameFromItem(item), FirstCharToUpper(defaultValue));
    }

    private string GetClassNameFromItem(AddOnApiItem item)
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

    private string GetPropertyName(AddOnApiItem item)
    {
        string result = item.Title;
        if (_seriesMappings[result] != null)
        {
            result = (string)_seriesMappings[result];
        }

        return FirstCharToUpper(result);
    }

    private string FormatProperty(string propertyTemplate, AddOnApiItem child)
    {
        string propertyName = GetPropertyName(child);
        string returnType = GetPropertyReturnType(child, propertyName);

        if (child.Values != null && child.Values.Count > 0)
            returnType = GetClassNameFromItem(child);

        return propertyTemplate
         .Replace("{HighTemplate.Name}", propertyName)
         .Replace("{HighTemplate.Type}", returnType)
         .Replace("{HighTemplate.Comment}", child.Description
                                             .Replace("\r", "")
                                             .Replace("\t", "")
                                             .Replace("\n", ""));
    }

    private string GetPropertyReturnType(AddOnApiItem child, string propertyName)
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
                result = FirstCharToUpper(result);
            return "List<" + result + "Data" + ">";
        }

        if (_propertyTypeMappings[child.FullName] != null)
            return _propertyTypeMappings[child.FullName].ToString();
        if (_propertyTypeMappings[propertyName] != null)
            return _propertyTypeMappings[propertyName].ToString();
        if (_typeMappings[returnType] != null)
            return _typeMappings[returnType].ToString();

        if (child.IsParent)
            returnType = GetClassNameFromItem(child);

        return returnType;
    }

    private string FormatDefaultProperty(string propertyName, AddOnApiItem child)
    {
        return String.Format("{0} = {1} = {2};\n\t\t\t", propertyName, propertyName + "_DefaultValue", MapDefaultValue(child));
    }

    private string FormatPropertyComparer(string propertyName, AddOnApiItem child)
    {
        string simplePropertyFormat = "if ({0} != {1}) h.Add(\"{2}\",{0});\n\t\t\t";
        string listPropertyFormat = "if ({0} != {1}) h.Add(\"{2}\", HashifyList({0}));\n\t\t\t";
        string enumPropertyFormat = "if ({0} != {1}) h.Add(\"{2}\", {3}.FirstCharacterToLower({0}.ToString()));\n\t\t\t";
        string functionPropertyFormat = "if ({0} != {2}) {{ h.Add(\"{1}\",{0}); {4}.AddFunction(\"{3}\", {0}); }}  \n\t\t\t";
        string complexPropertyFormat = "if ({0}.IsDirty()) h.Add(\"{1}\",{0}.ToHashtable());\n\t\t\t";
        string customPropertyFormat = "if ({0}.IsDirty()) h.Add(\"{1}\",{0}.ToJSON());\n\t\t\t";

        if (propertyName == "Data" && child.FullName != "data")
            return "";

        // fully qualified names that are collections
        if (_lists.Contains(child.FullName))
            return String.Format(listPropertyFormat, propertyName, propertyName + "_DefaultValue", FirstCharToLower(propertyName));
        if (_lists.Contains(propertyName))
            return String.Format(listPropertyFormat, propertyName, propertyName + "_DefaultValue", FirstCharToLower(propertyName));
        if (_propertyTypeMappings.Contains(child.FullName))
            return String.Format(simplePropertyFormat, propertyName, propertyName + "_DefaultValue", FirstCharToLower(propertyName));
        // property that needs custom serialization (Animation, Shadow, etc)
        if (_customProperties.Contains(propertyName))
            return String.Format(customPropertyFormat, propertyName, FirstCharToLower(propertyName));
        // Enum
        if (child.Values != null && child.Values.Count > 0)
            return String.Format(enumPropertyFormat, propertyName, propertyName + "_DefaultValue", FirstCharToLower(propertyName), ROOT_CLASS);
        // Complex object with nested objects / properties
        if (child.IsParent)
            return String.Format(complexPropertyFormat, propertyName, FirstCharToLower(propertyName));
        // Event (javascript function)
        if (child.ReturnType != null && (child.ReturnType == "Function" || child.ReturnType == "String|Function"))
            return String.Format(functionPropertyFormat, propertyName, FirstCharToLower(propertyName), propertyName + "_DefaultValue", GetClassNameFromItem(child) + "." + FirstCharToLower(propertyName), ROOT_CLASS);
        // Just a property
        else
            return String.Format(simplePropertyFormat, propertyName, propertyName + "_DefaultValue", FirstCharToLower(propertyName));
    }

    private void GenerateClassesForLevel(int level)
    {
        foreach (AddOnApiItem item in _allItems)
        {
            var count = item.FullName.Count(x => x == '.');
            if (count == level && item.IsParent)
            {
                GenerateClass(item);
            }
        }
    }

    private List<AddOnApiItem> FindImmediateChildren(AddOnApiItem rootItem)
    {
        List<AddOnApiItem> children = new List<AddOnApiItem>();

        foreach (AddOnApiItem item in _allItems)
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

    private List<AddOnApiItem> FindRootChildren()
    {
        List<AddOnApiItem> children = new List<AddOnApiItem>();
        foreach (AddOnApiItem item in _allItems)
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
        _typeMappings.Add("Function", "string");
        _typeMappings.Add("String|Function", "string");
        _typeMappings.Add("Color", "string");
        _typeMappings.Add("CSSObject", "NameValueCollection");
        _typeMappings.Add("Number|String", "string");
        _typeMappings.Add("String|Number", "string");
        _typeMappings.Add("String|HTMLElement", "string");
        _typeMappings.Add("Array<Color>", "List<string>");
        _typeMappings.Add("Array<String>", "List<string>");
        _typeMappings.Add("Array<String>;", "List<string>");
        _typeMappings.Add("Array<Number>", "List<double>");
        _typeMappings.Add("Array<Array<Mixed>>", "List<List<object>>");
        _typeMappings.Add("Array<Object>", "List<object>");
    }

    private void InitPropertyTypeMappings()
    {
        _propertyTypeMappings.Add("Shadow", "Shadow");
        _propertyTypeMappings.Add("PlotShadow", "Shadow");
        _propertyTypeMappings.Add("Animation", "Animation");
        _propertyTypeMappings.Add("PointPlacement", "PointPlacement");
        _propertyTypeMappings.Add("Center", "new string[]");
        _propertyTypeMappings.Add("Margin", "new string[]");
        _propertyTypeMappings.Add("Position", "NameValueCollection");
        _propertyTypeMappings.Add("DateTimeLabelFormats", "NameValueCollection");
        _propertyTypeMappings.Add("InputPosition", "NameValueCollection");
        _propertyTypeMappings.Add("Attr", "NameValueCollection");
        _propertyTypeMappings.Add("Style", "NameValueCollection");
        _propertyTypeMappings.Add("InputStyle", "NameValueCollection");
        _propertyTypeMappings.Add("LabelStyle", "NameValueCollection");
        _propertyTypeMappings.Add("Stack", "string");
        _propertyTypeMappings.Add("Symbol", "string");
        _propertyTypeMappings.Add("TrackBorderColor", "string");
        _propertyTypeMappings.Add("Background", "List<Background>");
        _propertyTypeMappings.Add("MenuItems", "List<MenuItem>");
        _propertyTypeMappings.Add("Crosshairs", "List<Crosshair>");
        _propertyTypeMappings.Add("Stops", "List<Stop>");
        _propertyTypeMappings.Add("RenderTo", "string");
        _propertyTypeMappings.Add("series", "List<Series>");
        _propertyTypeMappings.Add("drilldown.series", "List<Series>");
        _propertyTypeMappings.Add("xAxis", "List<XAxis>");
        _propertyTypeMappings.Add("yAxis", "List<YAxis>");
        _propertyTypeMappings.Add("yAxis.plotBands", "List<YAxisPlotBands>");
        _propertyTypeMappings.Add("yAxis.plotLines", "List<YAxisPlotLines>");
        _propertyTypeMappings.Add("yAxis.plotBands.label.style", "NameValueCollection");
        _propertyTypeMappings.Add("xAxis.plotBands", "List<XAxisPlotBands>");
        _propertyTypeMappings.Add("xAxis.plotLines", "List<XAxisPlotLines>");
        _propertyTypeMappings.Add("xAxis.plotBands.label.style", "NameValueCollection");
        _propertyTypeMappings.Add("series<treemap>.levels", "List<TreemapSeriesLevels>");
    }

    private void InitPropertyInitMappings()
    {
        _propertyInitMappings.Add("Shadow", "new Shadow() { Enabled = false }");
        _propertyInitMappings.Add("PlotShadow", "new Shadow() { Enabled = false }");
        _propertyInitMappings.Add("Animation", "new Animation() { Enabled = true }");
        _propertyInitMappings.Add("PointPlacement", "new PointPlacement()");
        _propertyInitMappings.Add("Crosshairs", "new List<Crosshair>()");
        _propertyInitMappings.Add("MenuItems", "new List<MenuItem>()");
        //_propertyInitMappings.Add("Symbol", "new Symbol()");
        _propertyInitMappings.Add("Colors", "new List<string>()");
        _propertyInitMappings.Add("Center", "new string[] { null, null }");
        _propertyInitMappings.Add("Margin", "new string[] {}");
        _propertyInitMappings.Add("Position", "new NameValueCollection()");
        _propertyInitMappings.Add("DateTimeLabelFormats", "new NameValueCollection()");
        _propertyInitMappings.Add("InputPosition", "new NameValueCollection()");
        _propertyInitMappings.Add("Style", "new NameValueCollection()");
        _propertyInitMappings.Add("InputStyle", "new NameValueCollection()");
        _propertyInitMappings.Add("LabelStyle", "new NameValueCollection()");
        _propertyInitMappings.Add("Columns", "new List<List<Object>>()");
        _propertyInitMappings.Add("Rows", "new List<List<object>>()");
        _propertyInitMappings.Add("SeriesMapping", "new List<object>()");
        _propertyInitMappings.Add("Keys", "new List<string>()");
        _propertyInitMappings.Add("series", "new List<Series>()");
        _propertyInitMappings.Add("xAxis", "new List<XAxis>()");
        _propertyInitMappings.Add("yAxis", "new List<YAxis>()");
        _propertyInitMappings.Add("yAxis.plotLines", "new List<YAxisPlotLines>()");
        _propertyInitMappings.Add("yAxis.plotBands", "new List<YAxisPlotBands>()");
        _propertyInitMappings.Add("yAxis.plotBands.label.style", "new NameValueCollection()");
        _propertyInitMappings.Add("xAxis.plotLines", "new List<XAxisPlotLines>()");
        _propertyInitMappings.Add("xAxis.plotBands", "new List<XAxisPlotBands>()");
        _propertyInitMappings.Add("xAxis.plotBands.label.style", "new NameValueCollection()");
        _propertyInitMappings.Add("series<treemap>.levels", "new List<TreemapSeriesLevels>()");
    }

    private void InitLists()
    {
        _lists.Add("Background");
        _lists.Add("MenuItem");
        _lists.Add("Crosshair");
        _lists.Add("Stops");
        _lists.Add("xAxis");
        _lists.Add("yAxis");
        _lists.Add("yAxis.plotBands");
        _lists.Add("yAxis.plotLines");
        _lists.Add("xAxis.plotBands");
        _lists.Add("xAxis.plotLines");
        _lists.Add("series<treemap>.levels");
    }

    private void InitSeriesMappings()
    {
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


    public string MapDefaultValue(AddOnApiItem item)
    {
        string defaults = item.Defaults;

        if (item.Title.ToLower() == "data" && item.Parent != null)
        {
            string result = item.Parent;
            if (_seriesMappings[result] != null)
            {
                result = (string)_seriesMappings[result];
            }
            else
                result = FirstCharToUpper(result);
            return "new List<" + result + "Data" + ">()";
        }

        if (_propertyInitMappings[item.FullName] != null)
        {
            defaults = _propertyInitMappings[item.FullName].ToString();
        }
        else if (_propertyInitMappings[FirstCharToUpper(item.Title)] != null)
        {
            defaults = _propertyInitMappings[FirstCharToUpper(item.Title)].ToString();
        }

        if (item.Values != null && item.Values.Count > 0)
        {
            return GetDefaultValueForEnum(item);
        }

        if (!item.IsParent)
        {
            if (item.FullName.EndsWith("data.x") || item.FullName.EndsWith("data.y"))
            {
                return "double.MinValue";
            }
            if (item.ReturnType == "Function" || item.ReturnType == "String|Function")
                return "\"\"";

            if (!String.IsNullOrEmpty(item.Defaults))
            {
                if (item.ReturnType == "String" ||
                    item.ReturnType == "Color" ||
                    item.ReturnType == "String|Number" ||
                    item.ReturnType == "Number|String")
                {
                    return '"' + defaults.Replace("\"", "'") + '"';
                }
                if (item.ReturnType.StartsWith("Array<String>")) // thereis Array<String>; ending with ; in Highstock
                {
                    return "new List<string> " + item.Defaults
                                        .Replace("'", "\"")
                                        .Replace("[", "{")
                                        .Replace("]", "}");
                }
                if (item.ReturnType == "Array<Number>")
                {
                    return "new List<double> " + item.Defaults
                                        .Replace("[", "{")
                                        .Replace("]", "}");
                }
                if ((_propertyTypeMappings[FirstCharToUpper(item.Title)] != null &&
                    _propertyTypeMappings[FirstCharToUpper(item.Title)].ToString() == "NameValueCollection") ||
                    (_typeMappings[(item.ReturnType)] != null &&
                    _typeMappings[(item.ReturnType)].ToString() == "NameValueCollection"))
                {
                    string result = "new NameValueCollection" + "{" + item.Defaults
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
            if (_propertyInitMappings[FirstCharToUpper(item.Title)] != null)
            {
                return _propertyInitMappings[FirstCharToUpper(item.Title)].ToString();
            }
            return String.Format("new {0}()", GetClassNameFromItem(item));

        }

        return defaults;
    }






    public class AddOnApiItem
    {
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Parent { get; set; }
        public bool IsParent { get; set; }
        public string ReturnType { get; set; }
        public string Description { get; set; }
        public string Defaults { get; set; }
        public List<string> Values { get; set; }
        public bool Deprecated { get; set; }
        public ExpandoObject ChildNode { get; set; }

        public AddOnApiItem()
        {
            IsParent = false;
            Parent = null;
        }

        public AddOnApiItem(KeyValuePair<string, object> item, string parent)
            : this()
        {
            Title = item.Key;
            FullName = parent == null ? item.Key : parent + "." + item.Key;
            Parent = parent;
            Deprecated = false;
            IsParent = false;
            Description = "";
            Defaults = "";
            Values = new List<string>();
            ReturnType = "";


            foreach (KeyValuePair<string, object> property in (ExpandoObject)item.Value)
            {
                if (property.Key == "type")
                {
                    ReturnType = property.Value as string;
                    if (ReturnType == null)
                        ReturnType = "string";
                }
                if (property.Key == "descriptionEN")
                    Description = property.Value == null ? "" : property.Value as string;
                if (property.Key == "default")
                    Defaults = property.Value as string;
                if (property.Key == "applicable")
                    Values = property.Value as List<string>;
                if (property.Key == "properties")
                {
                    IsParent = true;
                    ChildNode = (ExpandoObject) property.Value;
                }
            }
        }
    }
}
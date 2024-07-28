using SourceCodeGenerator.Enums;
using SourceCodeGenerator.Parser;
using SourceCodeGenerator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceCodeGenerator.Generators
{
    public class HighchartsGenerator : Generator
    {
        protected override string RootClass { get { return "Highcharts"; } } // the name of the root class
        const string MAIN_FIELD_NAME = "highcharts";
        const string ROOT_NAMESPACE = "Charts"; // the name of the root class

        public HighchartsGenerator(IJsonParser jsonParser, IJsonParser previousVersionJsonParser, IFileService fileService, IMultiplicationService multiplicationService, IComparisonService comparisonService) 
            :base(jsonParser, previousVersionJsonParser, fileService, multiplicationService, comparisonService)
        {
        }

        public override void GenerateCode(bool isNETStandard)
        {
            IsNETStandard = isNETStandard;
            FileService.PrepareFolder(RootClass);
            _apiItems = JsonParser.Get();
            _previousVersionApiItems = PreviousVersionJsonParser.Get();

            Console.WriteLine("Comparing current version to previous version");
            ComparisonService.SetValuesFromFile(@"Logs\hc_updated.log");
            ComparisonService.Compare(_apiItems, _previousVersionApiItems);
            ComparisonService.SaveChanges(@"Logs\hc_result_values.log", @"Logs\hc_old_values.log", @"Logs\hc_not_in_updated.log", FileService);

            ProcessApiItems(_apiItems);
            _apiItems = MultiplyObjects(_apiItems);

            var root = new ApiItem { Title = RootClass, FullName = RootClass };
            GenerateClass(root, GetChildren(root));
            GenerateClassesForLevel(_apiItems);
        }

        protected override void ProcessApiItems(IList<ApiItem> items)
        {
            foreach (ApiItem apiItem in items)
            {
                // All events (javascript functions) should default to empty string
                if (apiItem.ReturnType != null && (apiItem.ReturnType.ToLower() == "function" || apiItem.ReturnType.ToLower() == "string|function"))
                    apiItem.Defaults = "";
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
                if (apiItem.Title.Equals("position") && !apiItem.FullName.EndsWith("dataLabels.position"))
                    apiItem.Values.Clear();

                // add Defaults to enum if they are not available in the Values list.
                AddDefaultsToEnum(apiItem);

                if (apiItem.Children.Any())
                    ProcessApiItems(apiItem.Children);

                if (apiItem.FullName == "series.venn.states" || apiItem.FullName == "series.columnpyramid.states")
                    apiItem.Children.Clear();
            }
        }

        protected override void GenerateClass(ApiItem item, List<ApiItem> children)
        {
            string codeTemplate = FileService.GetClassTemplate(Product.Highcharts);
            string propertyTemplate = item.FullName.ToLower().Equals("series") ? FileService.GetSeriesPropertyTemplate() : FileService.GetPropertyTemplate();

            string properties = "";
            string hashtableComparers = "";

            if (item.FullName.ToLower().EndsWith("zones"))
                item.FullName = item.FullName.Remove(item.FullName.Length - 5) + "Zone";

            if (item.FullName.Equals("plotOptions.dependencywheel.dataLabels.textPath"))
                if (!children.Any(p => p.Title.ToLower().Equals("enabled")))
                    children.Add(new ApiItem { Title = "enabled", FullName = item.FullName + ".enabled", IsParent = true, Defaults = "false", 
                        ParentFullName = item.FullName, ReturnType = "Boolean" 
                    });


            foreach (ApiItem child in children.GroupBy(p => p.FullName + p.Suffix).Select(group => group.FirstOrDefault()).OrderBy(q => q.FullName))
            {
                string propertyName = GetPropertyName(child);

                if (string.IsNullOrEmpty(propertyName))
                    continue;

                if (_excludedProperties.Contains(propertyName) && child.IsParent == false)
                    continue;
                if (_excludedProperties.Contains(child.FullName))
                    continue;
                if (child == item)
                    continue;

                //remove after bug fix
                if (child.FullName == "plotOptions.funnel.dataLabels.style")
                    child.Extends.Add("plotOptions.series.dataLabels.style");

                child.ParentFullName = item.FullName;

                if (child.Values != null && child.Values.Count > 0)
                {
                    GenerateEnum(child);
                }

                if (child.ParentFullName.ToLower().Contains("highcharts") && propertyName.ToLower().Contains("series") && propertyName.Length > 6)
                    continue;

                if (propertyName.ToLower().EndsWith("datalabels") && (child.ParentFullName.ToLower().EndsWith("data") || child.ParentFullName.ToLower().EndsWith("levels")))
                    child.IsParent = true;

                if (child.FullName.ToLower().Contains("labels.style.") || child.FullName.ToLower().Contains("credits.style.") || child.FullName.ToLower().Contains("title.style.") || child.FullName.ToLower().Contains("labels.items.style.")
                    || child.FullName.ToLower().Contains("legend.itemHiddenStyle.") || child.FullName.ToLower().Contains("legend.itemHoverStyle."))
                    child.IsParent = true;

                if (item.FullName.ToLower().StartsWith("series.") && item.FullName.Split('.').Length == 2 &&
                    (child.FullName.EndsWith("id") || child.FullName.EndsWith("index") || child.FullName.EndsWith("legendIndex") || child.FullName.EndsWith("name")
                     || child.FullName.EndsWith("stack") || child.FullName.EndsWith("xAxis") || child.FullName.EndsWith("yAxis") || child.FullName.EndsWith("zIndex")))
                    propertyTemplate = FileService.GetSeriesInheritedPropertyTemplate();
                else
                    propertyTemplate = item.FullName.ToLower().Equals("series") ? FileService.GetSeriesPropertyTemplate() : FileService.GetPropertyTemplate();


                string formattedProperty = string.Empty;
                string formattedComparer = string.Empty;
                if (!((child.FullName.ToLower().StartsWith("series") && child.FullName.ToLower().EndsWith("type") && child.FullName.Split('.').Length == 3) || child.FullName.ToLower().Equals("series.type")))
                {
                    if (child.FullName.ToLower().Equals("series.type"))
                        continue;

                    formattedProperty = FormatProperty(propertyTemplate, child);
                    formattedComparer = FormatPropertyComparer(propertyName, child);
                }
                else
                    formattedComparer = "h.Add(\"type\",\"" + GetClassNameFromItem(item).ToLower().Replace("series", "") + "\");\r\n\t\t\t";

                if (propertyName.ToLower().EndsWith("datalabels") && (child.ParentFullName.ToLower().EndsWith("data") || child.ParentFullName.ToLower().EndsWith("levels")))
                    child.IsParent = false;

                properties += formattedProperty;
                hashtableComparers += formattedComparer;
            }

            hashtableComparers += CustomFieldsService.GetCopyLogic();

            string className = GetClassNameFromItem(item);
            string extendsClass = "";

            if (className.EndsWith("Series") && item.Parent?.FullName == "series")
                extendsClass = ": Series";
            else
                extendsClass = ": BaseObject";

            codeTemplate = codeTemplate
                            .Replace("{HighTemplate.Namespace}", "Highsoft.Web.Mvc." + ROOT_NAMESPACE)
                            .Replace("{HighTemplate.Properties}", properties)
                            .Replace("{HighTemplate.HashtableInit}", hashtableComparers)
                            .Replace("{HighTemplate.ExtendsClass}", extendsClass)
                            .Replace("{HighTemplate.ClassName}", className);

            FileService.SaveClass(RootClass, className, codeTemplate);
        }

        protected override void GenerateEnum(ApiItem apiItem)
        {
            string enumTemplate = FileService.GetEnumTemplate();
            List<string> enumValues = new List<string>();

            string enumList = "";
            for (int i = 0; i < apiItem.Values.Count; i++)
            {
                if (apiItem.Values[i] == null)
                    apiItem.Values[i] = "null";

                apiItem.Values[i] = apiItem.Values[i].Replace("'", "");

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

            FileService.SaveEnum(RootClass, GetClassNameFromItem(apiItem), enumTemplate);
        }

        protected override void AddDefaultsToEnum(ApiItem apiItem)
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

                apiItem.Values.Insert(0, "null");
            }

            if ((apiItem.FullName.Contains("series") && apiItem.FullName.Contains("type")) || apiItem.FullName == "chart.type" || (apiItem.FullName.StartsWith("series<") && apiItem.FullName.EndsWith(">.type")))
            {
                apiItem.Values.Add("null");
                apiItem.Values.Add("abands");
                apiItem.Values.Add("ad");
                apiItem.Values.Add("ao");
                apiItem.Values.Add("apo");
                apiItem.Values.Add("arcdiagram");
                apiItem.Values.Add("area");
                apiItem.Values.Add("arearange");
                apiItem.Values.Add("areaspline");
                apiItem.Values.Add("areasplinerange");
                apiItem.Values.Add("aroon");
                apiItem.Values.Add("aroonoscillator");
                apiItem.Values.Add("atr");
                apiItem.Values.Add("bar");
                apiItem.Values.Add("bb");
                apiItem.Values.Add("bellcurve");
                apiItem.Values.Add("boxplot");
                apiItem.Values.Add("bubble");
                apiItem.Values.Add("bullet");
                apiItem.Values.Add("candlestick");
                apiItem.Values.Add("cci");
                apiItem.Values.Add("chaikin");
                apiItem.Values.Add("cmf");
                apiItem.Values.Add("cmo");
                apiItem.Values.Add("column");
                apiItem.Values.Add("columnpyramid");
                apiItem.Values.Add("columnrange");
                apiItem.Values.Add("cylinder");
                apiItem.Values.Add("dema");
                apiItem.Values.Add("disparityindex");
                apiItem.Values.Add("dmi");
                apiItem.Values.Add("dependencywheel");
                apiItem.Values.Add("dpo");
                apiItem.Values.Add("dumbbell");
                apiItem.Values.Add("ema");
                apiItem.Values.Add("errorbar");
                apiItem.Values.Add("flags");
                apiItem.Values.Add("funnel");
                apiItem.Values.Add("funnel3d");
                apiItem.Values.Add("gantt");
                apiItem.Values.Add("gauge");
                apiItem.Values.Add("heikinashi");
                apiItem.Values.Add("heatmap");
                apiItem.Values.Add("histogram");
                apiItem.Values.Add("hlc");
                apiItem.Values.Add("hollowcandlestick");
                apiItem.Values.Add("id");
                apiItem.Values.Add("ikh");
                apiItem.Values.Add("index");
                apiItem.Values.Add("item");
                apiItem.Values.Add("keltnerchannels");
                apiItem.Values.Add("klinger");
                apiItem.Values.Add("legendindex");
                apiItem.Values.Add("line");
                apiItem.Values.Add("linearregression");
                apiItem.Values.Add("linearregressionagle");
                apiItem.Values.Add("linearregressionintercept");
                apiItem.Values.Add("linearregressionslope");
                apiItem.Values.Add("lollipop");
                apiItem.Values.Add("macd");
                apiItem.Values.Add("map");
                apiItem.Values.Add("mapData");
                apiItem.Values.Add("mapbubble");
                apiItem.Values.Add("mapline");
                apiItem.Values.Add("mappoint");
                apiItem.Values.Add("mfi");
                apiItem.Values.Add("momentum");
                apiItem.Values.Add("name");
                apiItem.Values.Add("natr");
                apiItem.Values.Add("networkgraph");
                apiItem.Values.Add("obv");
                apiItem.Values.Add("ohlc");
                apiItem.Values.Add("organization");
                apiItem.Values.Add("packedbubble");
                apiItem.Values.Add("pareto");
                apiItem.Values.Add("pc");
                apiItem.Values.Add("pie");
                apiItem.Values.Add("pivotpoints");
                apiItem.Values.Add("polygon");
                apiItem.Values.Add("ppo");
                apiItem.Values.Add("priceenvelopes");
                apiItem.Values.Add("psar");
                apiItem.Values.Add("pyramid");
                apiItem.Values.Add("pyramid3d");
                apiItem.Values.Add("roc");
                apiItem.Values.Add("rsi");
                apiItem.Values.Add("sankey");
                apiItem.Values.Add("scatter");
                apiItem.Values.Add("scatter3d");
                apiItem.Values.Add("slowstochastic");
                apiItem.Values.Add("sma");
                apiItem.Values.Add("solidgauge");
                apiItem.Values.Add("spline");
                apiItem.Values.Add("stack");
                apiItem.Values.Add("stochastic");
                apiItem.Values.Add("streamgraph");
                apiItem.Values.Add("sunburst");
                apiItem.Values.Add("supertrend");
                apiItem.Values.Add("tema");
                apiItem.Values.Add("tilemap");
                apiItem.Values.Add("timeline");
                apiItem.Values.Add("treemap");
                apiItem.Values.Add("trendline");
                apiItem.Values.Add("trix");
                apiItem.Values.Add("variablepie");
                apiItem.Values.Add("variwide");
                apiItem.Values.Add("vbp");
                apiItem.Values.Add("vector");
                apiItem.Values.Add("venn");
                apiItem.Values.Add("vwap");
                apiItem.Values.Add("waterfall");
                apiItem.Values.Add("williamsr");
                apiItem.Values.Add("windbarb");
                apiItem.Values.Add("wma");
                apiItem.Values.Add("wordcloud");
                apiItem.Values.Add("xrange");
                apiItem.Values.Add("zigzag");


                //apiItem.Values.Add("bar");
                //apiItem.Values.Add("heatmap");
                //apiItem.Values.Add("pyramid");
                //apiItem.Values.Add("polygon");
                //apiItem.Values.Add("treemap");
                //apiItem.Values.Add("solidgauge");

                //apiItem.Values.Add("Bellcurve");
                //apiItem.Values.Add("Bullet");
                //apiItem.Values.Add("Histogram");
                //apiItem.Values.Add("Pareto");
                //apiItem.Values.Add("Sankey");
                //apiItem.Values.Add("Scatter3d");
                //apiItem.Values.Add("Streamgraph");
                //apiItem.Values.Add("Sunburst");
                //apiItem.Values.Add("Tilemap");
                //apiItem.Values.Add("Variablepie");
                //apiItem.Values.Add("Variwide");
                //apiItem.Values.Add("Vector");
                //apiItem.Values.Add("Windbarb");
                //apiItem.Values.Add("Wordcloud");
                //apiItem.Values.Add("Xrange");
                ////since v7
                //apiItem.Values.Add("Networkgraph");
                //apiItem.Values.Add("Packedbubble");
                //apiItem.Values.Add("Cylinder");
                //apiItem.Values.Add("Venn");
                //apiItem.Values.Add("Columnpyramid");
            }
        }

        protected override string GetClassNameFromItem(ApiItem item)
        {
            string[] parts = item.FullName.Split('.');
            StringBuilder result = new StringBuilder();

            if (item.ParentFullName == RootClass)
                result.Append(FirstCharToUpper(item.Title));
            else
                foreach (string part in parts)
                {
                    if (result.ToString() == "Series")
                        result.Insert(0, FirstCharToUpper(part));
                    else
                        result.Append(FirstCharToUpper(part));
                }

            if (parts.Length > 1)
            {
                string seriesName = string.Join(".", new string[] { parts[0], parts[1] });
                if (_seriesMappings[seriesName] != null)
                {
                    result.Clear();
                    seriesName = (string)_seriesMappings[seriesName];
                    result.Append(seriesName);

                    for (int i = 2; i < parts.Length; i++)
                    {
                        result.Append(FirstCharToUpper(parts[i]));
                    }
                }
            }

            result = result.Replace('-', '_');
            result = result.Replace("DataDataLabels", "DataLabels");
            result = result.Replace("LevelsDataLabels", "DataLabels");

            return result.ToString();
        }

        protected override string GetPropertyName(ApiItem item)
        {
            string result = item.Title;

            if (_seriesMappings[result] != null)
            {
                result = (string)_seriesMappings[result];
            }

            if (string.IsNullOrEmpty(result))
                return null;

            result = string.Empty;
            foreach (var part in item.Title.Split('-'))
                result += FirstCharToUpper(part);

            result = result + item.Suffix;
            result = result.Replace('-', '_');

            return result;
        }

        protected override string FormatProperty(string propertyTemplate, ApiItem child)
        {
            string propertyName = GetPropertyName(child);
            string returnType = GetPropertyReturnType(child, propertyName);

            if ((child.ReturnType == "string" || child.ReturnType == "String" || child.ReturnType == TypeService.CSSType) && child.Values != null && child.Values.Any())
                returnType = GetClassNameFromItem(child);

            if (propertyName == "PointDescriptionThreshold")
            {
                returnType = "long?";
                child.Description = "<p>When a series contains more points than this, we no longer expose information about individual points to screen readers.</p><p>Set to <code>null</code> to disable.</p>";
            }

            if (propertyName == "FillColor")
                returnType = "Object";

            if (propertyName == "Data" && child.ParentFullName.ToLower() == "highcharts")
                returnType = "Data";

            if (propertyName == "Margin" && child.ParentFullName.ToLower() != "chart")
                returnType = "double?";

            if (propertyName == "Margin" && child.ParentFullName.ToLower() == "chart")
                returnType = "double[]";

            return propertyTemplate
             .Replace("{HighTemplate.Name}", propertyName)
             .Replace("{HighTemplate.Type}", returnType)
             .Replace("{HighTemplate.Comment}", child.Description
                                                 .Replace("\r", "")
                                                 .Replace("\t", "")
                                                 .Replace("\n", ""));
        }

        protected override string GetPropertyReturnType(ApiItem child, string propertyName)
        {
            string returnType = child.ReturnType;
            var nameAndSuffix = FirstCharToLower(GetPropertyName(child));

            if (propertyName.ToLower() == "data" && child.ParentFullName != null)
                return "List<" + GetClassNameFromItem(child) + ">";

            if (child.ParentFullName != RootClass && (nameAndSuffix.ToLower() == "xaxis" || nameAndSuffix.ToLower() == "yaxis"))
                return "string";

            if (
                child.FullName.EndsWith("states.hover") ||
                child.FullName.EndsWith("states.inactive") ||
                child.FullName.EndsWith("states.normal") ||
                child.FullName.EndsWith("states.select") ||
                child.FullName.EndsWith("states.hover.halo") ||
                child.FullName.EndsWith("states.inactive.halo") ||
                child.FullName.EndsWith("states.normal.halo") ||
                child.FullName.EndsWith("states.select.halo") ||
                child.FullName.EndsWith("exporting.buttons"))
                return GetClassNameFromItem(child);


            if (_propertyTypeMappings[child.FullName] != null)
                return _propertyTypeMappings[child.FullName].ToString();
            if (_propertyTypeMappings[nameAndSuffix] != null)
                return _propertyTypeMappings[nameAndSuffix].ToString();
            if (_propertyTypeMappings[propertyName] != null)
                return _propertyTypeMappings[propertyName].ToString();

            if (!string.IsNullOrEmpty(returnType))
                if (_typeMappings[returnType] != null && !child.FullName.Contains("dashStyle"))
                    return _typeMappings[returnType].ToString();

            if (child.ReturnType == "Array.<*>" && child.Title == "zones")
                returnType = string.Format("List<{0}>", GetClassNameFromItem(child).Replace("Zones", "Zone"));
            else
                if (child.Children.Any() || child.Extends.Any() || child.Values.Any())
                returnType = GetClassNameFromItem(child);


            if (returnType.EndsWith("DataDataLabels"))
                returnType = returnType.Replace("DataData", "Data");

            if (returnType.EndsWith("LevelsDataLabels"))
                returnType = returnType.Replace("LevelsData", "Data");

            if (string.IsNullOrWhiteSpace(returnType))
                returnType = "string";

            return returnType;
        }

        protected override string FormatPropertyComparer(string propertyName, ApiItem child)
        {
            string simplePropertyFormat = "if ({0} != null) h.Add(\"{2}\",{0});\n\t\t\t";
            string listPropertyFormat = "if ({0} != null) h.Add(\"{2}\", HashifyList(" + MAIN_FIELD_NAME + ",{0}));\n\t\t\t";
            string enumPropertyFormat = "if ({0} != {1}.Null) h.Add(\"{2}\", {3}.FirstCharacterToLower({0}.ToString()));\n\t\t\t";
            string functionPropertyFormat = "if ({0} != null) {{ h.Add(\"{1}\",{0}); {4}.AddFunction(\"{3}\", {0}); }}  \n\t\t\t";
            string complexPropertyFormat = "if ({0} != null) h.Add(\"{1}\",{0}.ToHashtable(" + MAIN_FIELD_NAME + "));\n\t\t\t";

            // fully qualified names that are collections
            if (_lists.Contains(child.Title) || _lists.Contains(child.FullName))
            {
                if (child.FullName == "Data")
                    return "if (Data != null) h.Add(\"data\",HashifyList(" + MAIN_FIELD_NAME + ",Data));\n\t\t\t";

                if ((child.Title.ToLower() == "xaxis" || child.Title.ToLower() == "yaxis") && child.ParentFullName != "Highcharts")
                    return String.Format(simplePropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));

                if (child.Title == "colors")
                    return String.Format(simplePropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));

                return String.Format(listPropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));
            }
            if (_lists.Contains(propertyName))
            {
                if (propertyName == "Data" && child.ParentFullName.ToLower().Contains("highcharts"))
                    return String.Format(complexPropertyFormat, propertyName, GetJSName(propertyName, child.Suffix));

                if (propertyName == "Data")
                    return "if (Data != null) h.Add(\"data\",HashifyList(" + MAIN_FIELD_NAME + ",Data));\n\t\t\t";

                if (propertyName == "Stops")
                    return "if (Stops != null) h.Add(\"stops\", GetLists(Stops));\n\t\t\t";

                return String.Format(listPropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));
            }

            if (_propertyTypeMappings.Contains(child.Title) || _propertyTypeMappings.Contains(child.FullName))
            {
                if (child.FullName == "lang.accessibility.series")
                    return String.Format(complexPropertyFormat, propertyName, GetJSName(propertyName, child.Suffix));

                if (child.FullName == "plotOptions.series" || propertyName == "Animation")
                    return String.Format(complexPropertyFormat, propertyName, GetJSName(propertyName, child.Suffix));

                if ((child.Title.Equals("shadow") || child.Title.Equals("plotShadow")) && child.ReturnType.Equals("Object"))
                    return String.Format(complexPropertyFormat, propertyName, GetJSName(propertyName, child.Suffix));

                if (child.Title.ToLower() == "series" && child.ParentFullName == "Highcharts")
                    return String.Format(listPropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));

                return String.Format(simplePropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));
            }

            // Enum
            if (child.ReturnType.Equals(TypeService.EnumType) || ((child.ReturnType == "string" || child.ReturnType == "String" || child.ReturnType == TypeService.CSSType) && child.Values != null && child.Values.Count > 0))
                return String.Format(enumPropertyFormat, propertyName, GetClassNameFromItem(child), GetJSName(propertyName, child.Suffix), MAIN_FIELD_NAME);
            // Complex object with nested objects / properties
            if (child.IsParent)
            {
                if (child.ReturnType == "Array.<*>" && child.Title == "zones")
                    return string.Format(listPropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));

                if ((child.Children.Any() || child.Extends.Any()) && !child.FullName.EndsWith("drilldown.activeDataLabelStyle"))// && child.ReturnType.ToLower() == "object")
                    return String.Format(complexPropertyFormat, propertyName, GetJSName(propertyName, child.Suffix));

                // Event (javascript function)
                if (child.ReturnType != null && (child.ReturnType.ToLower() == "function" || child.ReturnType.ToLower() == "string|function"))
                    return String.Format(functionPropertyFormat, propertyName, GetJSName(propertyName, child.Suffix), propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix), MAIN_FIELD_NAME);
                // Just a property
                else
                {
                    if (propertyName == "PointDescriptionThreshold")
                        return "if (PointDescriptionThreshold != PointDescriptionThreshold_DefaultValue)\n\t\t\t{\n\t\t\t\tif (PointDescriptionThreshold != null)\n\t\t\t\t\th.Add(\"pointDescriptionThreshold\", PointDescriptionThreshold);\n\t\t\t\telse\n\t\t\t\t\th.Add(\"pointDescriptionThreshold\", false);\n\t\t\t}\n\t\t\t";

                    if (propertyName == "Shadow" ||
                        (child.FullName.EndsWith("states.hover") || child.FullName.EndsWith("states.inactive") || child.FullName.EndsWith("states.normal") || child.FullName.EndsWith("states.select")))
                        return String.Format(complexPropertyFormat, propertyName, GetJSName(propertyName, child.Suffix));

                
                    return String.Format(simplePropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));
                }
            }
            else
            {
                return String.Format(complexPropertyFormat, propertyName, GetJSName(propertyName, child.Suffix));
            }
        }

        protected override void InitEnumMappings()
        {
            _enumMappings.Add("triangle-down", "triangledown");
            _enumMappings.Add("image/png", "imagepng");
            _enumMappings.Add("image/jpeg", "imagejpeg");
            _enumMappings.Add("application/pdf", "applicationpdf");
            _enumMappings.Add("image/svg+xml", "imagesvgxml");
        }
        protected override void InitTypeMappings()
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
            _typeMappings.Add("Array.<color>", "List<string>");
            _typeMappings.Add("Array.<String>", "List<string>");
            _typeMappings.Add("Array.<string>", "List<string>");
            _typeMappings.Add("Array.<Number>", "List<double>");
            _typeMappings.Add("Array.<number>", "List<double>");
            _typeMappings.Add("Array.<Array.<Mixed>>", "List<List<object>>");
            _typeMappings.Add("Array.<Object>", "List<object>");
            _typeMappings.Add("Array.<object>", "List<object>");
            _typeMappings.Add("Mixed", "double?");
            _typeMappings.Add("Array.<Highcharts.ColorString>", "List<string>");
            _typeMappings.Add("Array.<Array.<*>>", "List<List<Object>>");
            _typeMappings.Add("Array.<Array.<Highcharts.DataValueType>>", "List<List<string>>");
            _typeMappings.Add("Array.<Highcharts.DefsOptions>", "List<object>");

        }
        protected override void InitPropertyTypeMappings()
        {
            _propertyTypeMappings.Add("shadow", "Shadow");
            _propertyTypeMappings.Add("plotShadow", "Shadow");
            _propertyTypeMappings.Add("animation", "Animation");
            _propertyTypeMappings.Add("center", "string[]");
            _propertyTypeMappings.Add("margin", "string[]");
            //_propertyTypeMappings.Add("position", "Hashtable");
            _propertyTypeMappings.Add("dateTimeLabelFormats", "Hashtable");
            _propertyTypeMappings.Add("inputPosition", "Hashtable");
            _propertyTypeMappings.Add("attr", "Hashtable");
            ////_propertyTypeMappings.Add("style", "Hashtable");
            _propertyTypeMappings.Add("inputStyle", "Hashtable");
            _propertyTypeMappings.Add("labelStyle", "Hashtable");
            _propertyTypeMappings.Add("stack", "string");
            _propertyTypeMappings.Add("symbol", "string");
            _propertyTypeMappings.Add("trackBorderColor", "string");
            ////_propertyTypeMappings.Add("background", "List<Background>");
            _propertyTypeMappings.Add("menuItems", "List<MenuItem>");
            _propertyTypeMappings.Add("crosshairs", "List<Crosshair>");
            _propertyTypeMappings.Add("stops", "List<Stop>");
            //_propertyTypeMappings.Add("renderTo", "string");
            _propertyTypeMappings.Add("lang.accessibility.series", "LangAccessibilitySeries");
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
            _propertyTypeMappings.Add("zAxis.plotBands", "List<ZAxisPlotBands>");
            _propertyTypeMappings.Add("zAxis.plotLines", "List<ZAxisPlotLines>");
            _propertyTypeMappings.Add("zAxis.plotBands.label.style", "Hashtable");
            _propertyTypeMappings.Add("xAxis.breaks", "List<XAxisBreaks>");
            _propertyTypeMappings.Add("yAxis.breaks", "List<YAxisBreaks>");
            _propertyTypeMappings.Add("series<treemap>.levels", "List<TreemapSeriesLevels>");
            _propertyTypeMappings.Add("pane.background", "List<PaneBackground>");
            _propertyTypeMappings.Add("plotOptions.series", "PlotOptionsSeries");
            _propertyTypeMappings.Add("annotations", "List<Annotations>");
            _propertyTypeMappings.Add("annotations.labels", "List<AnnotationsLabels>");
            _propertyTypeMappings.Add("annotations.shapes", "List<AnnotationsShapes>");
            _propertyTypeMappings.Add("colorAxis.dataClasses", "List<ColorAxisDataClasses>");
            _propertyTypeMappings.Add("annotations.shapes.points", "List<AnnotationsShapesPoint>");
            _propertyTypeMappings.Add("attributes", "Object");
            _propertyTypeMappings.Add("defs.markers", "Object");
            _propertyTypeMappings.Add("drilldown.drillUpButton.theme", "Object");
            _propertyTypeMappings.Add("exporting.menuItemDefinitions", "Object");
            _propertyTypeMappings.Add("exporting.chartOptions", "Object");
            _propertyTypeMappings.Add("exporting.formAttributes", "Object");
            _propertyTypeMappings.Add("responsive.rules.chartOptions", "Object");
            _propertyTypeMappings.Add("xAxis.plotBands.events", "Object");
            _propertyTypeMappings.Add("xAxis.plotLines.events", "Object");
            _propertyTypeMappings.Add("yAxis.plotBands.events", "Object");
            _propertyTypeMappings.Add("yAxis.plotLines.events", "Object");
            _propertyTypeMappings.Add("zAxis.plotBands.events", "Object");
            _propertyTypeMappings.Add("zAxis.plotLines.events", "Object");
            _propertyTypeMappings.Add("xAxis.plotLines.label.style", "Hashtable");
            _propertyTypeMappings.Add("yAxis.plotLines.label.style", "Hashtable");
            _propertyTypeMappings.Add("zAxis.plotLines.label.style", "Hashtable");
            _propertyTypeMappings.Add("global.Date", "Object");
            _propertyTypeMappings.Add("labels.items", "List<LabelsItems>");
            _propertyTypeMappings.Add("plotOptions.sunburst.levels", "List<PlotOptionsSunburstLevels>");
            _propertyTypeMappings.Add("plotOptions.treemap.levels", "List<PlotOptionsTreemapLevels>");
            //_propertyTypeMappings.Add("pane.background.backgroundColor", "string");
            _propertyTypeMappings.Add("responsive.rules", "List<ResponsiveRules>");
            _propertyTypeMappings.Add("series.treemap.levels", "List<TreemapSeriesLevels>");
            _propertyTypeMappings.Add("series.sunburst.levels", "List<SunburstSeriesLevels>");
            _propertyTypeMappings.Add("series.sankey.nodes", "List<SankeySeriesNodes>");
            _propertyTypeMappings.Add("time.Date", "DateTime");
            _propertyTypeMappings.Add("defs", "Object");
            _propertyTypeMappings.Add("labels.items.style", "Hashtable");
            _propertyTypeMappings.Add("boxesToAvoid", "List<object>");
            _propertyTypeMappings.Add("colors", "List<string>");
            _propertyTypeMappings.Add("data.columns", "List<List<string>>");
            _propertyTypeMappings.Add("data.rows", "List<List<string>>");
            _propertyTypeMappings.Add("chart.options3d.axisLabelPosition", "string");
            _propertyTypeMappings.Add("initialPositions", "double?");
            //_propertyTypeMappings.Add("position3d", "string");
            _propertyTypeMappings.Add("data.seriesMapping", "List<List<double?>>");
            _propertyTypeMappings.Add("tickWidth", "double?");
            _propertyTypeMappings.Add("style", "Hashtable");
            _propertyTypeMappings.Add("series.columnpyramid.states", "Hashtable");
            _propertyTypeMappings.Add("series.dependencywheel.levels.states", "Hashtable");
            _propertyTypeMappings.Add("series.organization.levels.states", "Hashtable");
            _propertyTypeMappings.Add("series.sankey.levels.states", "Hashtable");
            _propertyTypeMappings.Add("plotOptions.dependencywheel.levels.states", "Hashtable");
            _propertyTypeMappings.Add("plotOptions.organization.levels.states", "Hashtable");
            _propertyTypeMappings.Add("plotOptions.sankey.levels.states", "Hashtable");

            _propertyTypeMappings.Add("legend.bubbleLegend.ranges.value", "double?");
            _propertyTypeMappings.Add("plotOptions.sunburst.levels.dataLabels", "Hashtable");
            _propertyTypeMappings.Add("series.pyramid3d.data", "List<Hashtable>");
            _propertyTypeMappings.Add("defs.arrow.children", "List<object>");

            _propertyTypeMappings.Add("series.organization.nodes", "List<OrganizationSeriesNodes>");

        }

        protected override void InitLists()
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
            _lists.Add("zAxis.plotBands");
            _lists.Add("zAxis.plotLines");
            _lists.Add("xAxis.breaks");
            _lists.Add("yAxis.breaks");
            _lists.Add("series<treemap>.levels");
            _lists.Add("annotations");
            _lists.Add("annotations.labels");
            _lists.Add("annotations.shapes");
            _lists.Add("annotations.shapes.points");
            _lists.Add("colorAxis.dataClasses");
            _lists.Add("Highcharts.colors");
            //_lists.Add("xAxis.tickPositions");
            _lists.Add("labels.items");
            _lists.Add("plotOptions.sunburst.levels");
            _lists.Add("plotOptions.treemap.levels");
            _lists.Add("responsive.rules");
            _lists.Add("series.treemap.levels");
            _lists.Add("series.sunburst.levels");
            _lists.Add("series.sankey.nodes");
            _lists.Add("exporting.buttons.contextButton.menuItems");
            _lists.Add("series.organization.nodes");
        }
        protected override void InitSeriesMappings()
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
            _seriesMappings.Add("series<lollipop>", "Lollipop");
            _seriesMappings.Add("series<line>", "LineSeries");
            _seriesMappings.Add("series<pie>", "PieSeries");
            _seriesMappings.Add("series<polygon>", "PolygonSeries");
            _seriesMappings.Add("series<pyramid>", "PyramidSeries");
            _seriesMappings.Add("series<scatter>", "ScatterSeries");
            _seriesMappings.Add("series<solidgauge>", "SolidgaugeSeries");
            _seriesMappings.Add("series<spline>", "SplineSeries");
            _seriesMappings.Add("series<treemap>", "TreemapSeries");
            _seriesMappings.Add("series<waterfall>", "WaterfallSeries");
            _seriesMappings.Add("series<wordcloud>", "WordcloudSeries");

            // Highstock specific
            _seriesMappings.Add("series<flags>", "FlagsSeries");
            _seriesMappings.Add("series<candlestick>", "CandleStickSeries");
            _seriesMappings.Add("series<ohlc>", "OhlcSeries");


        }
        protected override void InitExcludedProperties()
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
    }
}
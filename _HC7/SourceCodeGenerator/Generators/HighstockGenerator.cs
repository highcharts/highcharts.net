using SourceCodeGenerator.Enums;
using SourceCodeGenerator.Parser;
using SourceCodeGenerator.Services;
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
using System.Text;


namespace SourceCodeGenerator.Generators
{
    public class HighstockGenerator : Generator
    {
        protected override string RootClass { get { return "Highstock"; } } // the name of the root class
        const string ROOT_NAMESPACE = "Stocks"; // the name of the root class
        const string MAIN_FIELD_NAME = "highstock";

        public HighstockGenerator(IJsonParser jsonParser, IJsonParser previousVersionJsonParser, IFileService fileService, IMultiplicationService multiplicationService, IComparisonService comparisonService)
            : base(jsonParser, previousVersionJsonParser, fileService, multiplicationService, comparisonService)
        {
        }

        public override void GenerateCode(bool isNETStandard)
        {
            IsNETStandard = isNETStandard;
            FileService.PrepareFolder(RootClass);
            _apiItems = JsonParser.Get();
            _previousVersionApiItems = PreviousVersionJsonParser.Get();

            Console.WriteLine("Comparing current version to previous version");
            ComparisonService.SetValuesFromFile(@"Logs\hs_updated.log");
            ComparisonService.Compare(_apiItems, _previousVersionApiItems);
            ComparisonService.SaveChanges(@"Logs\hs_result_values.log", @"Logs\hs_old_values.log", @"Logs\hs_not_in_updated.log", FileService);

            ProcessApiItems(_apiItems);
            _apiItems = MultiplyObjects(_apiItems);

            var root = new ApiItem { Title = RootClass, FullName = RootClass };
            GenerateClass(root, GetChildren(root));
            GenerateClassesForLevel(_apiItems);
        }

        protected override void ProcessApiItems(IList<ApiItem> items)
        {
            //AppendMissingApiItems();

            string multitypeslist = "";

            foreach (ApiItem apiItem in items)
            {
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
                if (apiItem.Title.Equals("position") && !apiItem.FullName.EndsWith("dataLabels.position"))
                    apiItem.Values.Clear();

                // add Defaults to enum if they are not available in the Values list.
                AddDefaultsToEnum(apiItem);

                UpdateDefaultsForHighcharts(apiItem);

                if (apiItem.Children.Any())
                    ProcessApiItems(apiItem.Children);
            }
        }

        protected override void UpdateDefaultsForHighcharts(ApiItem apiItem)
        {
            if (apiItem.FullName == "subtitle.text")
                return;

            if (apiItem.FullName == "chart.panning")
                apiItem.Defaults = "false";

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

            if (apiItem.FullName.StartsWith("xAxis.minPadding"))
                apiItem.Defaults = "0.01";

            if (apiItem.FullName.StartsWith("xAxis.maxPadding"))
                apiItem.Defaults = "0.01";
        }

        protected override void GenerateClass(ApiItem item, List<ApiItem> children)
        {
            //do not generate class for NavigatorSeries (and children), because there should be Series
            if (item.FullName.Contains("navigator.series"))
                return;

            string codeTemplate = FileService.GetClassTemplate(Product.Highstock);
            string propertyTemplate = item.FullName.ToLower().Equals("series") ? FileService.GetSeriesPropertyTemplate() : FileService.GetPropertyTemplate();

            string properties = "";
            string defaultValues = "";
            string hashtableComparers = "";

            if (item.FullName.Equals("annotations.crookedLine") || item.FullName.Equals("annotations.elliottWave") || item.FullName.Equals("annotations.fibonacci") || item.FullName.Equals("annotations.infinityLine") || item.FullName.Equals("annotations.pitchfork") || item.FullName.Equals("annotations.lineShapes") || item.FullName.Equals("annotations.tunnel") || item.FullName.Equals("annotations.measure") || item.FullName.Equals("annotations.verticalLine"))
                children = item.Children.Where(p => p.FullName.Contains("controlPointOptions") || p.FullName.Contains("labelOptions") || p.FullName.Contains("shapeOptions") || p.FullName.Contains("typeOptions")).ToList();

            if (item.FullName.Contains("annotations.crookedLine") || item.FullName.Contains("annotations.elliottWave") || item.FullName.Contains("annotations.fibonacci") || item.FullName.Contains("annotations.infinityLine") || item.FullName.Contains("annotations.pitchfork") || item.FullName.Contains("annotations.lineShapes") || item.FullName.Contains("annotations.tunnel") || item.FullName.Contains("annotations.measure") || item.FullName.Contains("annotations.verticalLine"))
                if (!item.FullName.Equals("annotations.tunnel.typeOptions.heightControlPoint") &&
                    !item.FullName.Equals("annotations.crookedLine.controlPointOptions.events") &&
                    !item.FullName.Equals("annotations.elliottWave.controlPointOptions.events") &&
                    !item.FullName.Equals("annotations.fibonacci.controlPointOptions.events") &&
                    !item.FullName.Equals("annotations.infinityLine.controlPointOptions.events") &&
                    !item.FullName.Equals("annotations.measure.controlPointOptions.events") &&
                    !item.FullName.Equals("annotations.pitchfork.controlPointOptions.events") &&
                    !item.FullName.Equals("annotations.tunnel.controlPointOptions.events") &&
                    !item.FullName.Equals("annotations.tunnel.typeOptions.heightControlPoint.events") &&
                    (item.FullName.EndsWith("draggable") || item.FullName.EndsWith("events") ||
                    item.FullName.EndsWith("shapes") || item.FullName.EndsWith("visible") || item.FullName.EndsWith("zIndex")))
                    return;

            if (item.FullName.Equals("annotations.crookedLine.typeOptions") || item.FullName.Equals("annotations.elliottWave.typeOptions"))
                children = item.Children.Where(p => !p.FullName.Contains("labels")).ToList();

            if (item.FullName.Equals("annotations.measure.controlPointOptions"))
                children = item.Children.Where(p => p.FullName.Contains("events")).ToList();

            if (item.FullName.Equals("annotations.verticalLine.typeOptions.label"))
                children = item.Children.Where(p => !p.FullName.Contains("point")).ToList();

            if (item.FullName.Equals("series.packedbubble"))
                children = item.Children.Where(p => !p.FullName.Contains("marker")).ToList();

            if (item.FullName.Equals("annotations.measure.controlPointOptions.style") || item.FullName.Equals("series.columnpyramid.states") || item.FullName.Equals("series.packedbubble.marker") || item.FullName.Equals("series.packedbubble.marker") || item.FullName.Equals("annotations.measure.typeOptions.label.style")
                || item.FullName.Equals("drilldown.activeDataLabelStyle") || item.FullName.Equals("legend.itemCheckboxStyle"))
                return;



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

                child.ParentFullName = item.FullName;

                if (child.Values != null && child.Values.Count > 0)
                {
                    GenerateEnum(child);
                }

                if (child.ParentFullName.ToLower().Contains("highstock") && propertyName.ToLower().Contains("series") && propertyName.Length > 6)
                    continue;

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
                string formattedDefaultProperty = string.Empty;
                string formattedComparer = string.Empty;
                if (!(child.FullName.ToLower().StartsWith("series") && child.FullName.Split('.').Length == 3 && child.FullName.ToLower().EndsWith("type")))
                {
                    if (child.FullName.ToLower().Equals("series.type"))
                        continue;

                    formattedProperty = FormatProperty(propertyTemplate, child);
                    formattedDefaultProperty = FormatDefaultProperty(propertyName, child);
                    formattedComparer = FormatPropertyComparer(propertyName, child);
                }
                else
                    formattedComparer = "h.Add(\"type\",\"" + GetClassNameFromItem(item).ToLower().Replace("series", "") + "\");\r\n\t\t\t";

                properties += formattedProperty;
                defaultValues += formattedDefaultProperty;
                hashtableComparers += formattedComparer;
            }

            string className = GetClassNameFromItem(item);

            properties += CustomFieldsService.GetProperty();
            defaultValues += CustomFieldsService.GetInit();
            hashtableComparers += CustomFieldsService.GetCopyLogic();

            string extendsClass = "";

            if (className.EndsWith("Series") && item.Parent?.FullName == "series")
                extendsClass = ": Series";
            else
                extendsClass = ": BaseObject";

            codeTemplate = codeTemplate
                            .Replace("{HighTemplate.Namespace}", "Highsoft.Web.Mvc." + ROOT_NAMESPACE)
                            .Replace("{HighTemplate.ConstrutorInitializers}", defaultValues)
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

                if (apiItem.Values[i] == "0")
                    apiItem.Values[i] = "Min = 0";
                else
                if (apiItem.Values[i] == "100")
                    apiItem.Values[i] = "Max = 100";

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
            }

            if ((apiItem.FullName.Contains("series") && apiItem.FullName.Contains("type")) || apiItem.FullName == "chart.type" || (apiItem.FullName.StartsWith("series<") && apiItem.FullName.EndsWith(">.type")))
            {
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

                //apiItem.Values.Add("Candlestick");
                //apiItem.Values.Add("Flags");
                //apiItem.Values.Add("Ohlc");
                //apiItem.Values.Add("Ad");
                //apiItem.Values.Add("Atr");
                //apiItem.Values.Add("Bb");
                //apiItem.Values.Add("Cci");
                //apiItem.Values.Add("Cmf");
                //apiItem.Values.Add("Ema");
                //apiItem.Values.Add("Macd");
                //apiItem.Values.Add("Mfi");
                //apiItem.Values.Add("Momentum");
                //apiItem.Values.Add("Pivotpoints");
                //apiItem.Values.Add("Priceenvelopes");
                //apiItem.Values.Add("Psar");
                //apiItem.Values.Add("Roc");
                //apiItem.Values.Add("Rsi");
                //apiItem.Values.Add("Sma");
                //apiItem.Values.Add("Stochastic");
                //apiItem.Values.Add("Vbp");
                //apiItem.Values.Add("Vwap");
                //apiItem.Values.Add("Wma");
                //apiItem.Values.Add("Zigzag");

                ////since v7
                //apiItem.Values.Add("Networkgraph");
                //apiItem.Values.Add("Packedbubble");
                //apiItem.Values.Add("Cylinder");
                //apiItem.Values.Add("Venn");
                //apiItem.Values.Add("Columnpyramid");

                //apiItem.Values.Add("Abands");
                //apiItem.Values.Add("Ao");
                //apiItem.Values.Add("Apo");
                //apiItem.Values.Add("Aroonoscillator");
                //apiItem.Values.Add("Aroon");
                //apiItem.Values.Add("Chaikin");
                //apiItem.Values.Add("Dema");
                //apiItem.Values.Add("Dpo");
                //apiItem.Values.Add("Keltnerchannels");
                //apiItem.Values.Add("Linearregressionangle");
                //apiItem.Values.Add("Natr");
                //apiItem.Values.Add("Packedbubble");
                //apiItem.Values.Add("Pc");
                //apiItem.Values.Add("Ppo");
                //apiItem.Values.Add("Supertrend");
                //apiItem.Values.Add("Tema");
                //apiItem.Values.Add("Trix");
                //apiItem.Values.Add("Williamsr");

                apiItem.Values.Add("abands");
                apiItem.Values.Add("ad");
                apiItem.Values.Add("ao");
                apiItem.Values.Add("apo");
                apiItem.Values.Add("area");
                apiItem.Values.Add("arearange");
                apiItem.Values.Add("areaspline");
                apiItem.Values.Add("areasplinerange");
                apiItem.Values.Add("aroon");
                apiItem.Values.Add("aroonoscillator");
                apiItem.Values.Add("atr");
                apiItem.Values.Add("bar");
                apiItem.Values.Add("bb");
                apiItem.Values.Add("belicurve");
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
                apiItem.Values.Add("linearregressionangle");
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
            }
        }

        protected override string GetDefaultValueForEnum(ApiItem item)
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

            if (defaultValue == "0")
                defaultValue = "Min";

            if (defaultValue == "100")
                defaultValue = "Max";

            return String.Format("{0}.{1}", GetClassNameFromItem(item), FirstCharToUpper(defaultValue));
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

            if (child.Values != null && child.Values.Any())
                returnType = GetClassNameFromItem(child);

            if ((child.Children.Any() || child.Extends.Any()) && _lists.Contains(child.FullName))
                returnType = "List<" + GetClassNameFromItem(child) + ">";

            if (propertyName == "PointDescriptionThreshold")
            {
                returnType = "long?";
                child.Description = "<p>When a series contains more points than this, we no longer expose information about individual points to screen readers.</p><p>Set to <code>null</code> to disable.</p>";
            }

            if (propertyName == "FillColor")
                returnType = "object";

            if (propertyName == "Data" && child.ParentFullName.ToLower() == "highstock")
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
                child.FullName.EndsWith("exporting.buttons") ||
                (child.FullName.StartsWith("annotations") && child.FullName.EndsWith("background")))
                return GetClassNameFromItem(child);

            //if (child.ParentFullName.EndsWith("navigation.bindings"))
            //    return "Hashtable";

            if (_propertyTypeMappings[child.FullName] != null)
                return _propertyTypeMappings[child.FullName].ToString();
            if (_propertyTypeMappings[nameAndSuffix] != null)
                return _propertyTypeMappings[nameAndSuffix].ToString();
            if (_propertyTypeMappings[propertyName] != null)
                return _propertyTypeMappings[propertyName].ToString();

            if (!string.IsNullOrEmpty(returnType))
                if (_typeMappings[returnType] != null)
                    return _typeMappings[returnType].ToString();

            if (child.ReturnType == "Array.<*>" && child.Title == "zones")
                returnType = string.Format("List<{0}>", GetClassNameFromItem(child));//.Replace("Zones", "Zone"));
            else
                if (child.Children.Any() || child.Extends.Any())
                returnType = GetClassNameFromItem(child);

            if (returnType.EndsWith("DataDataLabels"))
                returnType = returnType.Replace("DataData", "Data");

            if (returnType.EndsWith("LevelsDataLabels"))
                returnType = returnType.Replace("LevelsData", "Data");

            return returnType;
        }

        protected override string FormatDefaultProperty(string propertyName, ApiItem child)
        {
            return String.Format("{0} = {1} = {2};\n\t\t\t", propertyName, propertyName + "_DefaultValue", MapDefaultValue(child));
        }

        protected override string FormatPropertyComparer(string propertyName, ApiItem child)
        {
            string simplePropertyFormat = "if ({0} != {1}) h.Add(\"{2}\",{0});\n\t\t\t";
            string listPropertyFormat = "if ({0} != {1}) h.Add(\"{2}\", HashifyList(" + MAIN_FIELD_NAME + ",{0}));\n\t\t\t";
            string enumPropertyFormat = "if ({0} != {1}) h.Add(\"{2}\", {3}.FirstCharacterToLower({0}.ToString()));\n\t\t\t";
            string functionPropertyFormat = "if ({0} != {2}) {{ h.Add(\"{1}\",{0}); {4}.AddFunction(\"{3}\", {0}); }}  \n\t\t\t";
            string complexPropertyFormat = "if ({0}.IsDirty(" + MAIN_FIELD_NAME + ")) h.Add(\"{1}\",{0}.ToHashtable(" + MAIN_FIELD_NAME + "));\n\t\t\t";
            string customPropertyFormat = "if ({0}.IsDirty(" + MAIN_FIELD_NAME + ")) h.Add(\"{1}\",{0}.ToJSON(" + MAIN_FIELD_NAME + "));\n\t\t\t";

            // fully qualified names that are collections
            if (_lists.Contains(child.Title) || _lists.Contains(child.FullName))
            {
                if (child.FullName == "Data")
                    return "if (Data.Any()) h.Add(\"data\",HashifyList(" + MAIN_FIELD_NAME + ",Data));\n\t\t\t";

                if ((child.Title.ToLower() == "xaxis" || child.Title.ToLower() == "yaxis") && child.ParentFullName != "Highstock")
                    return String.Format(simplePropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));

                if (child.Title == "colors")
                    return String.Format(simplePropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));

                return String.Format(listPropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));
            }
            if (_lists.Contains(propertyName))
            {
                if (propertyName == "Data" && child.ParentFullName.ToLower().Contains("highstock"))
                    return String.Format(complexPropertyFormat, propertyName, GetJSName(propertyName, child.Suffix));

                if (propertyName == "Data")
                    return "if (Data.Any()) h.Add(\"data\",HashifyList(" + MAIN_FIELD_NAME + ",Data));\n\t\t\t";

                return String.Format(listPropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));
            }

            // property that needs custom serialization (Animation, Shadow, etc)
            if (_customProperties.Contains(propertyName))
            {
                return String.Format(customPropertyFormat, propertyName, GetJSName(propertyName, child.Suffix));
            }

            if (_propertyTypeMappings.Contains(child.Title) || _propertyTypeMappings.Contains(child.FullName))
            {
                if (child.FullName == "lang.accessibility.series")
                    return String.Format(complexPropertyFormat, propertyName, GetJSName(propertyName, child.Suffix));

                if (child.FullName == "plotOptions.series" || child.FullName == "navigator.series")
                    return String.Format(complexPropertyFormat, propertyName, GetJSName(propertyName, child.Suffix));

                if ((child.Title.Equals("shadow") || child.Title.Equals("plotShadow")) && child.ReturnType.Equals("Object"))
                    return String.Format(complexPropertyFormat, propertyName, GetJSName(propertyName, child.Suffix));

                if (child.Title.ToLower() == "series" && child.ParentFullName == "Highstock")
                    return String.Format(listPropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));

                if (propertyName.ToLower().Contains("pointplacement"))
                    return "if (PointPlacement.IsDirty(highstock))\n\t\t\t\tif (PointPlacement.Value.HasValue)\n\t\t\t\t\th.Add(\"pointPlacement\", PointPlacement.Value);\n\t\t\t\telse\n\t\t\t\t\th.Add(\"pointPlacement\", PointPlacement.ToJSON(highstock));\n\t\t\t";

                return String.Format(simplePropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));
            }

            // Enum
            if (child.ReturnType.Equals(TypeService.EnumType) || (child.Values != null && child.Values.Count > 0))
                return String.Format(enumPropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix), MAIN_FIELD_NAME);
            // Complex object with nested objects / properties
            if (child.IsParent)
            {
                if (child.ReturnType == "Array.<*>" && child.Title == "zones")
                    return string.Format(listPropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));

                if ((child.Children.Any() || child.Extends.Any())
                    && !child.FullName.Equals("navigation.bindings.ellipseAnnotation") && !child.FullName.Equals("navigation.bindings.fullScreen")
                    && !child.FullName.Equals("navigation.bindings.saveChart") && !child.FullName.Equals("navigation.bindings.seriesTypeHLC")
                    && !child.FullName.Equals("navigation.bindings.timeCycles"))
                    return String.Format(complexPropertyFormat, propertyName, FirstCharToLower(propertyName));

                // Event (javascript function)
                if (child.ReturnType != null && (child.ReturnType.ToLower() == "function" || child.ReturnType.ToLower() == "string|function"))
                    return String.Format(functionPropertyFormat, propertyName, GetJSName(propertyName, child.Suffix), propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix), MAIN_FIELD_NAME);
                // Just a property
                else
                {
                    if (propertyName == "PointDescriptionThreshold")
                        return "if (PointDescriptionThreshold != PointDescriptionThreshold_DefaultValue)\n\t\t\t{\n\t\t\t\tif (PointDescriptionThreshold != null)\n\t\t\t\t\th.Add(\"pointDescriptionThreshold\", PointDescriptionThreshold);\n\t\t\t\telse\n\t\t\t\t\th.Add(\"pointDescriptionThreshold\", false);\n\t\t\t}\n\t\t\t";

                    if (propertyName == "Shadow")
                        return String.Format(complexPropertyFormat, propertyName, GetJSName(propertyName, child.Suffix));

                    return String.Format(simplePropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));
                }
            }
            else
            {
                if (child.Children.Any() || child.Extends.Any())
                    return String.Format(complexPropertyFormat, propertyName, FirstCharToLower(propertyName));

                return String.Format(simplePropertyFormat, propertyName, propertyName + "_DefaultValue", GetJSName(propertyName, child.Suffix));
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
            _typeMappings.Add("Array.<Array.<Highcharts.DataValueType>>", "List<List<string>>");
            _typeMappings.Add("Array.<Highcharts.DefsOptions>", "List<object>");
        }
        protected override void InitPropertyTypeMappings()
        {
            _propertyTypeMappings.Add("shadow", "Shadow");
            _propertyTypeMappings.Add("plotShadow", "Shadow");
            _propertyTypeMappings.Add("animation", "Animation");
            _propertyTypeMappings.Add("pointPlacement", "PointPlacement");
            _propertyTypeMappings.Add("center", "string[]");
            _propertyTypeMappings.Add("margin", "string[]");
            _propertyTypeMappings.Add("dateTimeLabelFormats", "Hashtable");
            _propertyTypeMappings.Add("inputPosition", "Hashtable");
            _propertyTypeMappings.Add("attr", "Hashtable");
            _propertyTypeMappings.Add("inputStyle", "Hashtable");
            _propertyTypeMappings.Add("labelStyle", "Hashtable");
            _propertyTypeMappings.Add("stack", "string");
            _propertyTypeMappings.Add("symbol", "string");
            _propertyTypeMappings.Add("trackBorderColor", "string");
            _propertyTypeMappings.Add("menuItems", "List<MenuItem>");
            _propertyTypeMappings.Add("crosshairs", "List<Crosshair>");
            _propertyTypeMappings.Add("stops", "List<Stop>");
            _propertyTypeMappings.Add("renderTo", "string");
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
            _propertyTypeMappings.Add("series<treemap>.levels", "List<TreemapSeriesLevels>");
            _propertyTypeMappings.Add("pane.background", "List<PaneBackground>");
            _propertyTypeMappings.Add("plotOptions.series", "PlotOptionsSeries");
            _propertyTypeMappings.Add("annotations", "List<Annotations>");
            _propertyTypeMappings.Add("annotations.labels", "List<AnnotationsLabels>");
            _propertyTypeMappings.Add("annotations.shapes", "List<AnnotationsShapes>");
            _propertyTypeMappings.Add("colorAxis.dataClasses", "List<ColorAxisDataClasses>");
            _propertyTypeMappings.Add("annotations.shapes.points", "List<AnnotationsShapesPoints>");
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
            _propertyTypeMappings.Add("responsive.rules", "List<ResponsiveRules>");
            _propertyTypeMappings.Add("series.treemap.levels", "List<TreemapSeriesLevels>");
            _propertyTypeMappings.Add("series.sunburst.levels", "List<SunburstSeriesLevels>");
            _propertyTypeMappings.Add("series.sankey.nodes", "List<SankeySeriesNodes>");
            _propertyTypeMappings.Add("yAxis.resize.controlledAxis.next", "List<string>");
            _propertyTypeMappings.Add("yAxis.resize.controlledAxis.prev", "List<string>");
            _propertyTypeMappings.Add("navigator.handles.symbols", "List<string>");
            _propertyTypeMappings.Add("navigator.xAxis.plotLines.events", "Object");
            _propertyTypeMappings.Add("navigator.yAxis.plotLines.events", "Object");
            _propertyTypeMappings.Add("navigator.xAxis.plotBands.events", "Object");
            _propertyTypeMappings.Add("navigator.xAxis.plotBands.label.style", "Hashtable");
            _propertyTypeMappings.Add("navigator.xAxis.plotLines.label.style", "Hashtable");
            _propertyTypeMappings.Add("navigator.yAxis.plotLines.label.style", "Hashtable");
            _propertyTypeMappings.Add("time.Date", "Object");
            _propertyTypeMappings.Add("rangeSelector.buttons", "List<RangeSelectorButton>");
            _propertyTypeMappings.Add("navigator.xAxis.plotLines", "List<NavigatorXAxisPlotLines>");
            _propertyTypeMappings.Add("navigator.xAxis.plotBands", "List<NavigatorXAxisPlotBands>");
            _propertyTypeMappings.Add("navigator.yAxis.plotLines", "List<NavigatorYAxisPlotLines>");
            _propertyTypeMappings.Add("navigator.yAxis.plotBands", "List<NavigatorYAxisPlotBands>");
            _propertyTypeMappings.Add("navigator.series", "Series");
            _propertyTypeMappings.Add("plotOptions.arearange.threshold", "Object");
            _propertyTypeMappings.Add("plotOptions.stochastic.params.periods", "List<int>");
            _propertyTypeMappings.Add("labels.items.style", "Hashtable");
            _propertyTypeMappings.Add("boxesToAvoid", "List<object>");
            _propertyTypeMappings.Add("colors", "List<string>");
            _propertyTypeMappings.Add("data.columns", "List<List<string>>");
            _propertyTypeMappings.Add("data.rows", "List<List<string>>");
            _propertyTypeMappings.Add("chart.options3d.axisLabelPosition", "string");
            _propertyTypeMappings.Add("initialPositions", "double?");
            _propertyTypeMappings.Add("position3d", "string");
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
            _propertyTypeMappings.Add("plotOptions.sunburst.dataLabels", "Hashtable");
            _propertyTypeMappings.Add("plotOptions.sunburst.levels.dataLabels", "Hashtable");
            _propertyTypeMappings.Add("series.pyramid3d.data", "List<Hashtable>");
            _propertyTypeMappings.Add("plotOptions.pie.dataLabels", "Hashtable");
            _propertyTypeMappings.Add("plotOptions.item.dataLabels", "Hashtable");
            _propertyTypeMappings.Add("plotOptions.pyramid.dataLabels", "Hashtable");
            _propertyTypeMappings.Add("plotOptions.variablepie.dataLabels", "Hashtable");
            _propertyTypeMappings.Add("stockTools.gui.buttons", "List<string>");

            _propertyTypeMappings.Add("stockTools.gui.definitions.advanced.items", "List<string>");
            _propertyTypeMappings.Add("stockTools.gui.definitions.crookedLines.items", "List<string>");
            _propertyTypeMappings.Add("stockTools.gui.definitions.flags.items", "List<string>");
            _propertyTypeMappings.Add("stockTools.gui.definitions.lines.items", "List<string>");
            _propertyTypeMappings.Add("stockTools.gui.definitions.measure.items", "List<string>");
            _propertyTypeMappings.Add("stockTools.gui.definitions.simpleShapes.items", "List<string>");
            _propertyTypeMappings.Add("stockTools.gui.definitions.typeChange.items", "List<string>");
            _propertyTypeMappings.Add("stockTools.gui.definitions.verticalLabels.items", "List<string>");
            _propertyTypeMappings.Add("stockTools.gui.definitions.zoomChange.items", "List<string>");

            _propertyTypeMappings.Add("annotations.measure.typeOptions.label.style", "Hashtable");
            _propertyTypeMappings.Add("drilldown.activeDataLabelStyle", "Hashtable");
            _propertyTypeMappings.Add("legend.itemCheckboxStyle", "Hashtable");
            _propertyTypeMappings.Add("defs.arrow.children", "List<object>");
            _propertyTypeMappings.Add("plotOptions.slowstochastic.params.periods", "List<double?>");

        }
        protected override void InitPropertyInitMappings()
        {
            _propertyInitMappings.Add("shadow", "new Shadow()");
            _propertyInitMappings.Add("plotShadow", "new Shadow()");
            _propertyInitMappings.Add("animation", "new Animation() { Enabled = true }");
            _propertyInitMappings.Add("pointPlacement", "new PointPlacement()");
            _propertyInitMappings.Add("crosshairs", "new List<Crosshair>()");
            _propertyInitMappings.Add("menuItems", "new List<MenuItem>()");
            _propertyInitMappings.Add("colors", "new List<string>()");
            _propertyInitMappings.Add("center", "new string[] { \"50%\", \"50%\" }");
            _propertyInitMappings.Add("margin", "new string[] {}");
            _propertyInitMappings.Add("dateTimeLabelFormats", "new Hashtable()");
            _propertyInitMappings.Add("inputPosition", "new Hashtable()");
            _propertyInitMappings.Add("inputStyle", "new Hashtable()");
            _propertyInitMappings.Add("labelStyle", "new Hashtable()");
            _propertyInitMappings.Add("columns", "new List<List<string>>()");
            _propertyInitMappings.Add("rows", "new List<List<string>>()");
            _propertyInitMappings.Add("seriesMapping", "new List<object>()");
            _propertyInitMappings.Add("keys", "new List<string>()");
            _propertyInitMappings.Add("lang.accessibility.series", "new LangAccessibilitySeries()");
            _propertyInitMappings.Add("series", "new List<Series>()");
            _propertyInitMappings.Add("xAxis", "new List<XAxis>()");
            _propertyInitMappings.Add("yAxis", "new List<YAxis>()");
            _propertyInitMappings.Add("yAxis.plotLines", "new List<YAxisPlotLines>()");
            _propertyInitMappings.Add("yAxis.plotBands", "new List<YAxisPlotBands>()");
            _propertyInitMappings.Add("yAxis.plotBands.label.style", "new Hashtable()");
            _propertyInitMappings.Add("xAxis.plotLines", "new List<XAxisPlotLines>()");
            _propertyInitMappings.Add("xAxis.plotBands", "new List<XAxisPlotBands>()");
            _propertyInitMappings.Add("xAxis.plotBands.label.style", "new Hashtable()");
            _propertyInitMappings.Add("zAxis.plotLines", "new List<ZAxisPlotLines>()");
            _propertyInitMappings.Add("zAxis.plotBands", "new List<ZAxisPlotBands>()");
            _propertyInitMappings.Add("zAxis.plotBands.label.style", "new Hashtable()");
            _propertyInitMappings.Add("series<treemap>.levels", "new List<TreemapSeriesLevels>()");
            _propertyInitMappings.Add("pane.background", "new List<PaneBackground>()");
            _propertyInitMappings.Add("plotOptions.series", "new PlotOptionsSeries()");
            _propertyInitMappings.Add("annotations", "new List<Annotations>()");
            _propertyInitMappings.Add("annotations.labels", "new List<AnnotationsLabels>()");
            _propertyInitMappings.Add("annotations.shapes", "new List<AnnotationsShapes>()");
            _propertyInitMappings.Add("colorAxis.dataClasses", "new List<ColorAxisDataClasses>()");
            _propertyInitMappings.Add("annotations.shapes.points", "new List<AnnotationsShapesPoints>()");
            _propertyInitMappings.Add("attributes", "null");
            _propertyInitMappings.Add("defs.markers", "null");
            _propertyInitMappings.Add("drilldown.drillUpButton.theme", "null");
            _propertyInitMappings.Add("exporting.menuItemDefinitions", "null");
            _propertyInitMappings.Add("exporting.chartOptions", "null");
            _propertyInitMappings.Add("exporting.formAttributes", "null");
            _propertyInitMappings.Add("responsive.rules.chartOptions", "null");
            _propertyInitMappings.Add("xAxis.plotBands.events", "null");
            _propertyInitMappings.Add("xAxis.plotLines.events", "null");
            _propertyInitMappings.Add("yAxis.plotBands.events", "null");
            _propertyInitMappings.Add("yAxis.plotLines.events", "null");
            _propertyInitMappings.Add("zAxis.plotBands.events", "null");
            _propertyInitMappings.Add("zAxis.plotLines.events", "null");
            _propertyInitMappings.Add("xAxis.plotLines.label.style", "new Hashtable()");
            _propertyInitMappings.Add("yAxis.plotLines.label.style", "new Hashtable()");
            _propertyInitMappings.Add("zAxis.plotLines.label.style", "new Hashtable()");
            _propertyInitMappings.Add("xAxis.tickPositions", "new List<double>()");
            _propertyInitMappings.Add("yAxis.tickPositions", "new List<double>()");
            _propertyInitMappings.Add("zAxis.tickPositions", "new List<double>()");
            _propertyInitMappings.Add("chart.parallelAxes.tickPositions", "new List<double>()");
            _propertyInitMappings.Add("colorAxis.tickPositions", "new List<double>()");
            _propertyInitMappings.Add("global.Date", "null");
            _propertyInitMappings.Add("boxesToAvoid", "new List<object>()");
            _propertyInitMappings.Add("labels.items", "new List<LabelsItems>()");
            _propertyInitMappings.Add("legend.style", "new Hashtable()");
            _propertyInitMappings.Add("legend.navigation.style", "new Hashtable()");
            _propertyInitMappings.Add("noData.attr", "new Hashtable()");
            _propertyInitMappings.Add("title.style", "new Hashtable()");
            _propertyInitMappings.Add("labels.items.style", "new Hashtable()");
            _propertyInitMappings.Add("plotOptions.sunburst.levels", "new List<PlotOptionsSunburstLevels>()");
            _propertyInitMappings.Add("plotOptions.treemap.levels", "new List<PlotOptionsTreemapLevels>()");
            _propertyInitMappings.Add("lang.shortWeekdays", "new List<string>()");
            _propertyInitMappings.Add("responsive.rules", "new List<ResponsiveRules>()");
            _propertyInitMappings.Add("series.treemap.levels", "new List<TreemapSeriesLevels>()");
            _propertyInitMappings.Add("series.sunburst.levels", "new List<SunburstSeriesLevels>()");
            _propertyInitMappings.Add("series.sankey.nodes", "new List<SankeySeriesNodes>()");
            _propertyInitMappings.Add("yAxis.resize.controlledAxis.next", "new List<string>()");
            _propertyInitMappings.Add("yAxis.resize.controlledAxis.prev", "new List<string>()");
            _propertyInitMappings.Add("navigator.handles.symbols", "new List<string>()");
            _propertyInitMappings.Add("navigator.xAxis.plotLines.events", "null");
            _propertyInitMappings.Add("navigator.yAxis.plotLines.events", "null");
            _propertyInitMappings.Add("navigator.xAxis.plotBands.events", "null");
            _propertyInitMappings.Add("navigator.xAxis.plotBands.label.style", "new Hashtable()");
            _propertyInitMappings.Add("navigator.xAxis.plotLines.label.style", "new Hashtable()");
            _propertyInitMappings.Add("navigator.yAxis.plotLines.label.style", "new Hashtable()");
            _propertyInitMappings.Add("time.Date", "null");
            _propertyInitMappings.Add("rangeSelector.buttons", "new List<RangeSelectorButton>()");
            _propertyInitMappings.Add("rangeSelector.inputBoxStyle", "new Hashtable()");
            _propertyInitMappings.Add("navigator.xAxis.plotLines", "new List<NavigatorXAxisPlotLines>()");
            _propertyInitMappings.Add("navigator.xAxis.plotBands", "new List<NavigatorXAxisPlotBands>()");
            _propertyInitMappings.Add("navigator.xAxis.tickPositions", "new List<double>()");
            _propertyInitMappings.Add("navigator.yAxis.plotLines", "new List<NavigatorYAxisPlotLines>()");
            _propertyInitMappings.Add("navigator.yAxis.plotBands", "new List<NavigatorYAxisPlotBands>()");
            _propertyInitMappings.Add("navigator.yAxis.tickPositions", "new List<double>()");
            _propertyInitMappings.Add("navigator.series", "new Series()");
            _propertyInitMappings.Add("plotOptions.arearange.threshold", "null");
            _propertyInitMappings.Add("plotOptions.stochastic.params.periods", "new List<int>()");
            _propertyInitMappings.Add("autoRotation", "new List<double> {-45}");
            _propertyInitMappings.Add("categories", "new List<string>()");
            _propertyInitMappings.Add("spacing", "new List<double>()");
            _propertyInitMappings.Add("data.columns", "new List<List<string>>()");
            _propertyInitMappings.Add("chart.options3d.axisLabelPosition", "null");
            _propertyInitMappings.Add("initialPositions", "null");
            _propertyInitMappings.Add("initialPositionsRadius", "null");
            _propertyInitMappings.Add("data.seriesMapping", "new List<List<double?>>()");
            _propertyInitMappings.Add("tickWidth", "null");
            _propertyInitMappings.Add("sets", "new List<string>()");
            _propertyInitMappings.Add("style", "new Hashtable()");
            _propertyInitMappings.Add("series.columnpyramid.states", "new Hashtable()");
            _propertyInitMappings.Add("series.dependencywheel.levels.states", "new Hashtable()");
            _propertyInitMappings.Add("series.organization.levels.states", "new Hashtable()");
            _propertyInitMappings.Add("series.sankey.levels.states", "new Hashtable()");
            _propertyInitMappings.Add("plotOptions.dependencywheel.levels.states", "new Hashtable()");
            _propertyInitMappings.Add("plotOptions.organization.levels.states", "new Hashtable()");
            _propertyInitMappings.Add("plotOptions.sankey.levels.states", "new Hashtable()");
            _propertyInitMappings.Add("plotOptions.apo.params.periods", "new List<double>()");
            _propertyInitMappings.Add("plotOptions.chaikin.params.periods", "new List<double>()");
            _propertyInitMappings.Add("plotOptions.ppo.params.periods", "new List<double>()");

            _propertyInitMappings.Add("legend.bubbleLegend.ranges.value", "null");
            _propertyInitMappings.Add("plotOptions.sunburst.dataLabels", "new Hashtable()");
            _propertyInitMappings.Add("plotOptions.sunburst.levels.dataLabels", "new Hashtable()");
            _propertyInitMappings.Add("series.pyramid3d.data", "new List<Hashtable()>");
            _propertyInitMappings.Add("plotOptions.item.rows", "null");
            _propertyInitMappings.Add("series.item.rows", "null");
            _propertyInitMappings.Add("initialPositionRadius", "null");
            _propertyInitMappings.Add("accessibility.customComponents", "new object()");
            _propertyInitMappings.Add("plotOptions.pie.dataLabels", "new Hashtable()");
            _propertyInitMappings.Add("plotOptions.item.dataLabels", "new Hashtable()");
            _propertyInitMappings.Add("plotOptions.pyramid.dataLabels", "new Hashtable()");
            _propertyInitMappings.Add("plotOptions.variablepie.dataLabels", "new Hashtable()");
            _propertyInitMappings.Add("pane.background.backgroundColor", "new object()");
            _propertyInitMappings.Add("stockTools.gui.buttons", "new List<string>()");

            _propertyInitMappings.Add("stockTools.gui.definitions.advanced.items", "new List<string>()");
            _propertyInitMappings.Add("stockTools.gui.definitions.crookedLines.items", "new List<string>()");
            _propertyInitMappings.Add("stockTools.gui.definitions.flags.items", "new List<string>()");
            _propertyInitMappings.Add("stockTools.gui.definitions.lines.items", "new List<string>()");
            _propertyInitMappings.Add("stockTools.gui.definitions.measure.items", "new List<string>()");
            _propertyInitMappings.Add("stockTools.gui.definitions.simpleShapes.items", "new List<string>()");
            _propertyInitMappings.Add("stockTools.gui.definitions.typeChange.items", "new List<string>()");
            _propertyInitMappings.Add("stockTools.gui.definitions.verticalLabels.items", "new List<string>()");
            _propertyInitMappings.Add("stockTools.gui.definitions.zoomChange.items", "new List<string>()");

            _propertyInitMappings.Add("annotations.measure.typeOptions.label.style", "new Hashtable()");
            _propertyInitMappings.Add("drilldown.activeDataLabelStyle", "new Hashtable()");
            _propertyInitMappings.Add("legend.itemCheckboxStyle", "new Hashtable()");
            _propertyInitMappings.Add("defs.arrow.children", "new List<object>()");
            _propertyInitMappings.Add("accessibility.keyboardNavigation.order", "new List<string>()");
            _propertyInitMappings.Add("zoomEnabled", "null");
            _propertyInitMappings.Add("accessibility.highContrastTheme", "new Object()");
            _propertyInitMappings.Add("plotOptions.slowstochastic.params.periods", "new List<double?>{14,3,3}");
            _propertyInitMappings.Add("annotations.fibonacci.typeOptions.backgroundColors", "new List<string>()");
            _propertyInitMappings.Add("annotations.fibonacci.typeOptions.lineColors", "new List<string>()");
        }
        protected override void InitLists()
        {
            _lists.Add("pane.background");
            _lists.Add("MenuItem");
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
            _lists.Add("series<treemap>.levels");
            _lists.Add("annotations");
            _lists.Add("annotations.labels");
            _lists.Add("annotations.shapes");
            _lists.Add("annotations.shapes.points");
            _lists.Add("colorAxis.dataClasses");
            _lists.Add("Highstock.colors");
            _lists.Add("labels.items");
            _lists.Add("plotOptions.sunburst.levels");
            _lists.Add("plotOptions.treemap.levels");
            _lists.Add("responsive.rules");
            _lists.Add("series.treemap.levels");
            _lists.Add("series.sunburst.levels");
            _lists.Add("series.sankey.nodes");
            _lists.Add("chart.parallelAxes.resize.controlledAxis.next");
            _lists.Add("chart.parallelAxes.resize.controlledAxis.prev");
            _lists.Add("navigator.handles.symbols");
            _lists.Add("rangeSelector.buttons");
            _lists.Add("navigator.xAxis.plotBands");
            _lists.Add("navigator.xAxis.plotLines");
            _lists.Add("navigator.yAxis.plotBands");
            _lists.Add("navigator.yAxis.plotLines");
            _lists.Add("drilldown.series");
            _lists.Add("exporting.buttons.contextButton.menuItems");
            _lists.Add("annotations.crookedLine.typeOptions.points");
            _lists.Add("annotations.elliottWave.typeOptions.points");
            _lists.Add("annotations.fibonacci.typeOptions.points");
            _lists.Add("annotations.infinityLine.typeOptions.points");
            _lists.Add("annotations.measure.typeOptions.points");
            _lists.Add("annotations.pitchfork.typeOptions.points");
            _lists.Add("annotations.tunnel.typeOptions.points");
            _lists.Add("annotations.verticalLine.typeOptions.points");
        }
        protected override void InitSeriesMappings()
        {
            _seriesMappings.Add("series.candlestick", "CandleStickSeries");
            _seriesMappings.Add("rangeSelector.buttons", "RangeSelectorButton");
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
        protected override void InitCustomProperties()
        {
            _customProperties.Add("Animation");
        }

        protected override string MapDefaultValue(ApiItem item)
        {
            string defaults;

            if (string.IsNullOrWhiteSpace(item.Defaults))
                defaults = item.Defaults;
            else
                defaults = item.Defaults.Replace('\\', ' ').Replace('\'', ' ');

            var nameAndSuffix = FirstCharToLower(GetPropertyName(item));

            if (item.Defaults == "\n")
                return "null";

            if (nameAndSuffix == "data" && item.ParentFullName != null)
            {
                if (item.ParentFullName.ToLower() == "highstock")
                    return "new Data()";

                return "new List<" + GetClassNameFromItem(item) + ">()";
            }

            if (nameAndSuffix == "fillcolor")
                return "null";

            if (nameAndSuffix == "enabled" && item.ParentFullName.ToLower() == "series<treemap>.datalabels")
                return "null";

            if (nameAndSuffix == "fillcolor")
                return "null";

            if (nameAndSuffix == "height" && item.ParentFullName.ToLower() == "chart")
                return "null";

            if (nameAndSuffix == "margin" && item.ParentFullName.ToLower() != "chart")
                return "null";

            if (nameAndSuffix == "margin" && item.ParentFullName.ToLower() == "chart")
                return "new double[]{}";

            if (nameAndSuffix == "stops")
                return "new List<Stop>()";

            if ((nameAndSuffix == "xAxis" || nameAndSuffix == "yAxis") && item.ParentFullName != RootClass)
                return "\"\"";

            if (_propertyInitMappings[item.FullName] != null)
            {
                return _propertyInitMappings[item.FullName].ToString();
            }
            else if (_propertyInitMappings[nameAndSuffix] != null)
            {
                return _propertyInitMappings[nameAndSuffix].ToString();
            }

            if (item.ReturnType.Equals(TypeService.EnumType) || (item.Values != null && item.Values.Any()))
            {
                return GetDefaultValueForEnum(item);
            }

            if (item.FullName.EndsWith("data.x") || item.FullName.EndsWith("data.y"))
            {
                return "double.MinValue";
            }
            if (item.ReturnType.ToLower() == "function" || item.ReturnType.ToLower() == "string|function")
                return "\"\"";

            if (item.ReturnType == "Array.<*>" && item.Title == "zones")
                return string.Format("new List<{0}>()", GetClassNameFromItem(item));//.Replace("Zones", "Zone"));

            if ((item.Children.Any() || item.Extends.Any()) && _lists.Contains(item.FullName))
                return string.Format("new List<{0}>()", GetClassNameFromItem(item));

            if (item.FullName.ToLower().Contains("data.datalabels"))
                item.FullName = item.FullName.Replace("data.", "");

            if (item.FullName.ToLower().Contains("levels.datalabels"))
                item.FullName = item.FullName.Replace("levels.", "");

            if (item.Children.Any() || item.Extends.Any())
                return String.Format("new {0}()", GetClassNameFromItem(item));

            if (item.ReturnType == "Object")
                return "null";

            if (item.ReturnType.Contains(TypeService.CSSType))
                item.Defaults = "css";

            if (!String.IsNullOrEmpty(item.Defaults))
            {
                if (item.ReturnType == "String" ||
                    item.ReturnType == "Color" ||
                    item.ReturnType == "String|Number" ||
                    item.ReturnType == "Number|String")
                {
                    return '"' + defaults.Replace("\"", "'") + '"';
                }
                if (item.ReturnType.StartsWith("Array.<String>") || item.ReturnType.StartsWith("Array.<string>")) // thereis Array<String>; ending with ; in Highstock
                {
                    if (item.ParentFullName == "lang")
                        return "new List<string> " + item.Defaults
                                            .Replace("'", "\"")
                                            .Replace("[", "{")
                                            .Replace("]", "}");

                    return "new List<string>()";
                }
                if (item.ReturnType == "Array.<Number>")
                {
                    return "new List<double> " + item.Defaults
                                        .Replace("[", "{")
                                        .Replace("]", "}");
                }
                if ((_propertyTypeMappings[nameAndSuffix] != null &&
                    _propertyTypeMappings[nameAndSuffix].ToString() == "Hashtable") ||
                    (_typeMappings[(item.ReturnType)] != null &&
                    _typeMappings[(item.ReturnType)].ToString() == "Hashtable"))
                {
                    string result = "new Hashtable()";
                    if (nameAndSuffix == "position")
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
                if (item.ReturnType == "Number" || item.ReturnType == "Boolean")
                    return "null";
            }

            if (defaults == "")
                return "\"\"";
            if (defaults == null)
                return "null";
            if (defaults == "[]")
                return "{}";

            if (item.ReturnType == "Number")
            {
                int conversionResult;
                bool success = int.TryParse(defaults, out conversionResult);

                if (!success)
                    return "null";
            }

            return defaults;
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using Highsoft.Web.Mvc.Charts;
using System.Reflection;

namespace Highsoft.Web.Mvc.Charts.Rendering
{
    public class HighchartsRenderer
    {
        private Highcharts _chart;

        public HighchartsRenderer(Highcharts chart)
        {
            _chart = chart;
        }

        public string RenderHtml(bool addContainer = true)
        {
            return GetResponse(LicenseVerifier.Check(), addContainer);
        }

        public string GetJavascript()
        {
            var licenseType = LicenseVerifier.Check();

            string message = "";

            if (licenseType == 0)
                message = "<div style=\"background:yellow\">Incorrect serial key. I'm working in trial mode now.</div>";

            if (licenseType == -1 || licenseType == 0) //trial
                if (DateTime.Now > CompiledOn.CompilationDate.AddDays(30))
                {
                    message += "This is a trial version of Highcharts for ASP.NET MVC which has expired.<br> Please contact sales@highsoft.com with any questions.";
                    return message;
                }

            return GetCreateChartJavascript();
        }

        public string GetJavascriptFunction(string functionName)
        {
            var licenseType = LicenseVerifier.Check();

            string message = "";

            if (licenseType == 0)
                message = "<div style=\"background:yellow\">Incorrect serial key. I'm working in trial mode now.</div>";

            if (licenseType == -1 || licenseType == 0) //trial
                if (DateTime.Now > CompiledOn.CompilationDate.AddDays(30))
                {
                    message += "This is a trial version of Highcharts for ASP.NET MVC which has expired.<br> Please contact sales@highsoft.com with any questions.";
                    return message;
                }

            return GetCreateChartJavascriptFunction(functionName);
        }

        private string GetResponse(int licenseType, bool addContainer)
        {
            string message = "";

            if (licenseType == 0)
                message = "<div style=\"background:yellow\">Incorrect serial key. I'm working in trial mode now.</div>";

            if (licenseType == -1 || licenseType == 0) //trial
                if (DateTime.Now > CompiledOn.CompilationDate.AddDays(30))
                {
                    message += "This is a trial version of Highcharts for ASP.NET MVC which has expired.<br> Please contact sales@highsoft.com with any questions.";
                    return message;
                }

            return message + GetStartupJavascript(addContainer);
        }

        private string GetJsonResponse(int licenseType)
        {
            string message = "";

            if (licenseType == -1 || licenseType == 0) //trial
                if (DateTime.Now > CompiledOn.CompilationDate.AddDays(30))
                {
                    message += "Message:\"This is a trial version of Highcharts for ASP.NET MVC which has expired. Please contact sales@highsoft.com with any questions.\"";
                    return "{"+message+"}";
                }

            return GetStartupOptions();
        }

        private string GetCreateChartJavascript()
        {
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(_chart.ID))
                _chart.Chart.RenderTo = _chart.ID;

            sb.Append("<script type='text/javascript'>");
            sb.Append($"var ChartOptions = {GetStartupOptions()};");
            sb.Append($"new Highcharts.chart(\"{_chart.Chart.RenderTo}\",ChartOptions);");

            sb.Append("</script>");
            return sb.ToString();
        }

        private string GetCreateChartJavascriptFunction(string functionName)
        {
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(_chart.ID))
                _chart.Chart.RenderTo = _chart.ID;
           
            sb.Append("<script type='text/javascript'>");

            sb.Append($"function {functionName}() {{");
            sb.Append($"var ChartOptions = {GetStartupOptions()};");
            sb.Append($"new Highcharts.chart(\"{_chart.Chart.RenderTo}\",ChartOptions);");
            sb.Append("}");
            
            sb.Append("</script>");
            return sb.ToString();
        }

        private string GetStartupJavascript(bool addContainer)
        {
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(_chart.ID))
                _chart.Chart.RenderTo = _chart.ID;

            if(addContainer)
                sb.AppendFormat("<div id='{0}' style='height:{1};min-width:{2};clear:both;margin: 0 auto;'></div>", _chart.Chart.RenderTo, _chart.Chart.Height.ToString(), _chart.Chart.Width.ToString());

            sb.Append("<script type='text/javascript'>");
            
            sb.Append($"if (document.addEventListener) {{document.addEventListener(\"DOMContentLoaded\", function() {{createChart{_chart.Chart.RenderTo}();}});}} else if (document.attachEvent) {{document.attachEvent(\"onreadystatechange\", function(){{if (document.readyState === \"complete\"){{document.detachEvent(\"onreadystatechange\", arguments.callee);createChart{_chart.Chart.RenderTo}();}}}});}}");

            sb.Append($"function createChart{_chart.Chart.RenderTo}() {{");//s3
            sb.Append($"var ChartOptions = {GetStartupOptions()};");//s3
            sb.Append($"new Highcharts.chart(\"{_chart.Chart.RenderTo}\",ChartOptions);");//s3
            sb.Append("}");//s3

            sb.Append("</script>");
            return sb.ToString();            
        }

        public string GetJsonOptions()
        {
            return GetJsonResponse(LicenseVerifier.Check());
        }

        private string GetStartupOptions()
        {            
            StringBuilder sb = new StringBuilder();            
            RenderChartSettings(sb);
            return sb.ToString();
        }

        private void RenderChartSettings(StringBuilder s)
        {            
            Hashtable options = _chart.ToHashtable();

            List<Hashtable> series = new List<Hashtable>();
            List<Hashtable> drilldownSeries = new List<Hashtable>();

            if (_chart.Series != null)
                series = SeriesToHashtables(_chart.Series);
            if (_chart.Drilldown.Series != null)
                drilldownSeries = SeriesToHashtables(_chart.Drilldown.Series);

            if (series.Count > 0)
            {
                options["series"] = series;
            }
            if (drilldownSeries.Count > 0)
            {
                Hashtable drilldown = options["drilldown"] as Hashtable;
                drilldown["series"] = drilldownSeries;
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;
            string json = serializer.Serialize(options);
            var functions = Highcharts.functions;

            foreach (string key in functions.Keys)
            {
                string value = (string)functions[key];
                string realKey = key.Split('.')[1];
                string matchedString = String.Format("\"{0}\":\"{1}\"", realKey, value);
                string replacementstring = String.Format("\"{0}\":{1}", realKey, value);
                json = json.Replace(matchedString, replacementstring);
            }

            s.Append(json);
        }

        private List<Hashtable> SeriesToHashtables(List<Series>  listOfSeries)
        {
            List<Hashtable> results = new List<Hashtable>();


            foreach (Series series in listOfSeries)
            {
                List<object> dataList = new List<object>();
                Hashtable seriesHashtable = new Hashtable();

                if (series is LineSeries)
                {
                    LineSeries lineSeries = series as LineSeries;

                    //List<LineSeriesData> seriesData = lineSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    lineSeries.Type = LineSeriesType.Line;

                    seriesHashtable = lineSeries.ToHashtable();
                }
                if (series is SplineSeries)
                {
                    SplineSeries splineSeries = series as SplineSeries;

                    //List<SplineSeriesData> seriesData = splineSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    splineSeries.Type = SplineSeriesType.Spline;

                    seriesHashtable = splineSeries.ToHashtable();
                }
                if (series is AreaSeries)
                {
                    AreaSeries areaSeries = series as AreaSeries;

                    //List<AreaSeriesData> seriesData = areaSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    areaSeries.Type = AreaSeriesType.Area;

                    seriesHashtable = areaSeries.ToHashtable();
                }
                if (series is AreasplineSeries)
                {
                    AreasplineSeries areaSeries = series as AreasplineSeries;

                    //List<AreasplineSeriesData> seriesData = areaSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    areaSeries.Type = AreasplineSeriesType.Areaspline;

                    seriesHashtable = areaSeries.ToHashtable();
                }
                if (series is ArearangeSeries)
                {
                    ArearangeSeries areaSeries = series as ArearangeSeries;

                    //List<ArearangeSeriesData> seriesData = areaSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    areaSeries.Type = ArearangeSeriesType.Arearange;

                    seriesHashtable = areaSeries.ToHashtable();
                }
                if (series is ColumnrangeSeries)
                {
                    ColumnrangeSeries columnSeries = series as ColumnrangeSeries;

                    //List<ColumnrangeSeriesData> seriesData = columnSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    columnSeries.Type = ColumnrangeSeriesType.Columnrange;

                    seriesHashtable = columnSeries.ToHashtable();
                }
                if (series is BarSeries)
                {
                    BarSeries barSeries = series as BarSeries;

                    //List<BarSeriesData> seriesData = barSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    barSeries.Type = BarSeriesType.Bar;

                    seriesHashtable = barSeries.ToHashtable();
                }
                if (series is ColumnSeries)
                {
                    ColumnSeries columnSeries = series as ColumnSeries;

                    //List<ColumnSeriesData> seriesData = columnSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    columnSeries.Type = ColumnSeriesType.Column;

                    seriesHashtable = columnSeries.ToHashtable();
                }
                if (series is PieSeries)
                {
                    PieSeries pieSeries = series as PieSeries;

                    //List<PieSeriesData> seriesData = pieSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    pieSeries.Type = PieSeriesType.Pie;

                    seriesHashtable = pieSeries.ToHashtable();
                }
                if (series is ScatterSeries)
                {
                    ScatterSeries scatterSeries = series as ScatterSeries;

                    //List<ScatterSeriesData> seriesData = scatterSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    scatterSeries.Type = ScatterSeriesType.Scatter;

                    seriesHashtable = scatterSeries.ToHashtable();
                }
                if (series is BubbleSeries)
                {
                    BubbleSeries bubbleSeries = series as BubbleSeries;

                    //List<BubbleSeriesData> seriesData = bubbleSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    bubbleSeries.Type = BubbleSeriesType.Bubble;

                    seriesHashtable = bubbleSeries.ToHashtable();
                }
                if (series is GaugeSeries)
                {
                    GaugeSeries gaugeSeries = series as GaugeSeries;

                    //List<GaugeSeriesData> seriesData = gaugeSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    gaugeSeries.Type = GaugeSeriesType.Gauge;

                    seriesHashtable = gaugeSeries.ToHashtable();
                }
                if (series is SolidgaugeSeries)
                {
                    SolidgaugeSeries SolidgaugeSeries = series as SolidgaugeSeries;

                    //List<SolidgaugeSeriesData> seriesData = SolidgaugeSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    SolidgaugeSeries.Type = SolidgaugeSeriesType.Solidgauge;

                    seriesHashtable = SolidgaugeSeries.ToHashtable();
                }
                if (series is HeatmapSeries)
                {
                    HeatmapSeries heatMapSeries = series as HeatmapSeries;

                    //List<HeatmapSeriesData> seriesData = heatMapSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    heatMapSeries.Type = HeatmapSeriesType.Heatmap;

                    seriesHashtable = heatMapSeries.ToHashtable();
                }
                if (series is BoxplotSeries)
                {
                    BoxplotSeries boxPlotSeries = series as BoxplotSeries;

                    //List<BoxplotSeriesData> seriesData = boxPlotSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    boxPlotSeries.Type = BoxplotSeriesType.Boxplot;

                    seriesHashtable = boxPlotSeries.ToHashtable();
                }
                if (series is ErrorbarSeries)
                {
                    ErrorbarSeries errorBarSeries = series as ErrorbarSeries;

                    //List<ErrorbarSeriesData> seriesData = errorBarSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    errorBarSeries.Type = ErrorbarSeriesType.Errorbar;

                    seriesHashtable = errorBarSeries.ToHashtable();
                }
                if (series is FunnelSeries)
                {
                    FunnelSeries funnelSeries = series as FunnelSeries;

                    //List<FunnelSeriesData> seriesData = funnelSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    funnelSeries.Type = FunnelSeriesType.Funnel;

                    seriesHashtable = funnelSeries.ToHashtable();
                }
                if (series is PyramidSeries)
                {
                    PyramidSeries pyramidSeries = series as PyramidSeries;

                    //List<PyramidSeriesData> seriesData = pyramidSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    pyramidSeries.Type = PyramidSeriesType.Pyramid;

                    seriesHashtable = pyramidSeries.ToHashtable();
                }
                if (series is WaterfallSeries)
                {
                    WaterfallSeries waterfallSeries = series as WaterfallSeries;

                    //List<WaterfallSeriesData> seriesData = waterfallSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    waterfallSeries.Type = WaterfallSeriesType.Waterfall;

                    seriesHashtable = waterfallSeries.ToHashtable();
                }
                if (series is PolygonSeries)
                {
                    PolygonSeries polygonSeries = series as PolygonSeries;

                    //List<PolygonSeriesData> seriesData = polygonSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    polygonSeries.Type = PolygonSeriesType.Polygon;

                    seriesHashtable = polygonSeries.ToHashtable();
                }
                if (series is TreemapSeries)
                {
                    TreemapSeries treemapSeries = series as TreemapSeries;

                    //List<TreemapSeriesData> seriesData = treemapSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    treemapSeries.Type = TreemapSeriesType.Treemap;

                    seriesHashtable = treemapSeries.ToHashtable();
                }
                //since 6.0
                if (series is AreasplinerangeSeries)
                {
                    AreasplinerangeSeries areasplinerangeSeries = series as AreasplinerangeSeries;
                    areasplinerangeSeries.Type = AreasplinerangeSeriesType.Areasplinerange;
                    seriesHashtable = areasplinerangeSeries.ToHashtable();
                }

                if (series is BellcurveSeries)
                {
                    BellcurveSeries bellcurveSeries = series as BellcurveSeries;
                    bellcurveSeries.Type = BellcurveSeriesType.Bellcurve;
                    seriesHashtable = bellcurveSeries.ToHashtable();
                }

                if (series is BulletSeries)
                {
                    BulletSeries bulletSeries = series as BulletSeries;
                    bulletSeries.Type = BulletSeriesType.Bullet;
                    seriesHashtable = bulletSeries.ToHashtable();
                }

                if (series is HistogramSeries)
                {
                    HistogramSeries histogramSeries = series as HistogramSeries;
                    histogramSeries.Type = HistogramSeriesType.Histogram;
                    seriesHashtable = histogramSeries.ToHashtable();
                }

                if (series is ParetoSeries)
                {
                    ParetoSeries paretoSeries = series as ParetoSeries;
                    paretoSeries.Type = ParetoSeriesType.Pareto;
                    seriesHashtable = paretoSeries.ToHashtable();
                }

                if (series is SankeySeries)
                {
                    SankeySeries sankeySeries = series as SankeySeries;
                    sankeySeries.Type = SankeySeriesType.Sankey;
                    seriesHashtable = sankeySeries.ToHashtable();
                }

                if (series is Scatter3dSeries)
                {
                    Scatter3dSeries scatter3dSeries = series as Scatter3dSeries;
                    scatter3dSeries.Type = Scatter3dSeriesType.Scatter3d;
                    seriesHashtable = scatter3dSeries.ToHashtable();
                }

                if (series is StreamgraphSeries)
                {
                    StreamgraphSeries streamgraphSeries = series as StreamgraphSeries;
                    streamgraphSeries.Type = StreamgraphSeriesType.Streamgraph;
                    seriesHashtable = streamgraphSeries.ToHashtable();
                }

                if (series is SunburstSeries)
                {
                    SunburstSeries sunburstSeries = series as SunburstSeries;
                    sunburstSeries.Type = SunburstSeriesType.Sunburst;
                    seriesHashtable = sunburstSeries.ToHashtable();
                }

                if (series is TilemapSeries)
                {
                    TilemapSeries tilemapSeries = series as TilemapSeries;
                    tilemapSeries.Type = TilemapSeriesType.Tilemap;
                    seriesHashtable = tilemapSeries.ToHashtable();
                }

                if (series is VariablepieSeries)
                {
                    VariablepieSeries variablepieSeries = series as VariablepieSeries;
                    variablepieSeries.Type = VariablepieSeriesType.Variablepie;
                    seriesHashtable = variablepieSeries.ToHashtable();
                }

                if (series is VariwideSeries)
                {
                    VariwideSeries variwideSeries = series as VariwideSeries;
                    variwideSeries.Type = VariwideSeriesType.Variwide;
                    seriesHashtable = variwideSeries.ToHashtable();
                }

                if (series is VectorSeries)
                {
                    VectorSeries vectorSeries = series as VectorSeries;
                    vectorSeries.Type = VectorSeriesType.Vector;
                    seriesHashtable = vectorSeries.ToHashtable();
                }

                if (series is WindbarbSeries)
                {
                    WindbarbSeries windbarbSeries = series as WindbarbSeries;
                    windbarbSeries.Type = WindbarbSeriesType.Windbarb;
                    seriesHashtable = windbarbSeries.ToHashtable();
                }

                if (series is WordcloudSeries)
                {
                    WordcloudSeries wordcloudSeries = series as WordcloudSeries;
                    wordcloudSeries.Type = WordcloudSeriesType.Wordcloud;
                    seriesHashtable = wordcloudSeries.ToHashtable();
                }

                if (series is XrangeSeries)
                {
                    XrangeSeries xrangeSeries = series as XrangeSeries;
                    xrangeSeries.Type = XrangeSeriesType.Xrange;
                    seriesHashtable = xrangeSeries.ToHashtable();
                }
                //seriesHashtable.Add("data", dataList);
                results.Add(seriesHashtable);
            }

            return results;
        }
    }
}

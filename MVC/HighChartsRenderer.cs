using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using Highsoft.Web.Mvc;

namespace Highsoft.Web.Mvc.Rendering
{
    public class HighchartsRenderer
    {
        private Highcharts _chart;

        public HighchartsRenderer(Highcharts chart)
        {
            _chart = chart;
        }

        public string RenderHtml()
        {   
            return GetStartupJavascript();
        }

        public string GetStartupJavascript()
        {
            StringBuilder sb = new StringBuilder();

            _chart.Chart.RenderTo = _chart.ID;

            sb.AppendFormat("<div id='{0}' style='height:{1};min-width:{2};clear:both;margin: 0 auto;'></div>", _chart.ID, _chart.Chart.Height.ToString(), _chart.Chart.Width.ToString());
            sb.Append("<script type='text/javascript'>");
            sb.AppendFormat("var {0};", _chart.ID);
            sb.Append("jQuery(document).ready(function() {");
            sb.AppendFormat("var {0}ChartOptions = {1};", _chart.ID, GetStartupOptions());
            sb.AppendFormat("{0} = new Highcharts.Chart({0}ChartOptions);", _chart.ID);
            sb.Append("});");            
            sb.Append("</script>");
            return sb.ToString();            
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
            List<Hashtable> series = SeriesToHashtables(_chart.Series);
            List<Hashtable> drilldownSeries = SeriesToHashtables(_chart.Drilldown.Series);

            if (series.Count > 0)
            {
                options["series"] = series;
            }
            if (drilldownSeries.Count > 0)
            {
                Hashtable drilldown = options["drilldown"] as Hashtable;
                drilldown["series"] = drilldownSeries;
            }

            string json = new JavaScriptSerializer().Serialize(options);
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

                    List<LineSeriesData> seriesData = lineSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    lineSeries.Type = LineSeriesType.Line;

                    seriesHashtable = lineSeries.ToHashtable();
                }
                if (series is SplineSeries)
                {
                    SplineSeries splineSeries = series as SplineSeries;

                    List<SplineSeriesData> seriesData = splineSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    splineSeries.Type = SplineSeriesType.Spline;

                    seriesHashtable = splineSeries.ToHashtable();
                }
                if (series is AreaSeries)
                {
                    AreaSeries areaSeries = series as AreaSeries;

                    List<AreaSeriesData> seriesData = areaSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    areaSeries.Type = AreaSeriesType.Area;

                    seriesHashtable = areaSeries.ToHashtable();
                }
                if (series is AreasplineSeries)
                {
                    AreasplineSeries areaSeries = series as AreasplineSeries;

                    List<AreasplineSeriesData> seriesData = areaSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    areaSeries.Type = AreasplineSeriesType.Areaspline;

                    seriesHashtable = areaSeries.ToHashtable();
                }
                if (series is ArearangeSeries)
                {
                    ArearangeSeries areaSeries = series as ArearangeSeries;

                    List<ArearangeSeriesData> seriesData = areaSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    areaSeries.Type = ArearangeSeriesType.Arearange;

                    seriesHashtable = areaSeries.ToHashtable();
                }
                if (series is ColumnrangeSeries)
                {
                    ColumnrangeSeries columnSeries = series as ColumnrangeSeries;

                    List<ColumnrangeSeriesData> seriesData = columnSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    columnSeries.Type = ColumnrangeSeriesType.Columnrange;

                    seriesHashtable = columnSeries.ToHashtable();
                }
                if (series is BarSeries)
                {
                    BarSeries barSeries = series as BarSeries;

                    List<BarSeriesData> seriesData = barSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    barSeries.Type = BarSeriesType.Bar;

                    seriesHashtable = barSeries.ToHashtable();
                }
                if (series is ColumnSeries)
                {
                    ColumnSeries columnSeries = series as ColumnSeries;

                    List<ColumnSeriesData> seriesData = columnSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    columnSeries.Type = ColumnSeriesType.Column;

                    seriesHashtable = columnSeries.ToHashtable();
                }
                if (series is PieSeries)
                {
                    PieSeries pieSeries = series as PieSeries;

                    List<PieSeriesData> seriesData = pieSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    pieSeries.Type = PieSeriesType.Pie;

                    seriesHashtable = pieSeries.ToHashtable();
                }
                if (series is ScatterSeries)
                {
                    ScatterSeries scatterSeries = series as ScatterSeries;

                    List<ScatterSeriesData> seriesData = scatterSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    scatterSeries.Type = ScatterSeriesType.Scatter;

                    seriesHashtable = scatterSeries.ToHashtable();
                }
                if (series is BubbleSeries)
                {
                    BubbleSeries bubbleSeries = series as BubbleSeries;

                    List<BubbleSeriesData> seriesData = bubbleSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    bubbleSeries.Type = BubbleSeriesType.Bubble;

                    seriesHashtable = bubbleSeries.ToHashtable();
                }
                if (series is GaugeSeries)
                {
                    GaugeSeries gaugeSeries = series as GaugeSeries;

                    List<GaugeSeriesData> seriesData = gaugeSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    gaugeSeries.Type = GaugeSeriesType.Gauge;

                    seriesHashtable = gaugeSeries.ToHashtable();
                }
                if (series is HeatmapSeries)
                {
                    HeatmapSeries heatMapSeries = series as HeatmapSeries;

                    List<HeatmapSeriesData> seriesData = heatMapSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    heatMapSeries.Type = HeatmapSeriesType.Heatmap;

                    seriesHashtable = heatMapSeries.ToHashtable();
                }
                if (series is BoxplotSeries)
                {
                    BoxplotSeries boxPlotSeries = series as BoxplotSeries;

                    List<BoxplotSeriesData> seriesData = boxPlotSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    boxPlotSeries.Type = BoxplotSeriesType.Boxplot;

                    seriesHashtable = boxPlotSeries.ToHashtable();
                }
                if (series is ErrorbarSeries)
                {
                    ErrorbarSeries errorBarSeries = series as ErrorbarSeries;

                    List<ErrorbarSeriesData> seriesData = errorBarSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    errorBarSeries.Type = ErrorbarSeriesType.Errorbar;

                    seriesHashtable = errorBarSeries.ToHashtable();
                }
                if (series is FunnelSeries)
                {
                    FunnelSeries funnelSeries = series as FunnelSeries;

                    List<FunnelSeriesData> seriesData = funnelSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    funnelSeries.Type = FunnelSeriesType.Funnel;

                    seriesHashtable = funnelSeries.ToHashtable();
                }
                if (series is PyramidSeries)
                {
                    PyramidSeries pyramidSeries = series as PyramidSeries;

                    List<PyramidSeriesData> seriesData = pyramidSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    pyramidSeries.Type = PyramidSeriesType.Pyramid;

                    seriesHashtable = pyramidSeries.ToHashtable();
                }
                if (series is WaterfallSeries)
                {
                    WaterfallSeries waterfallSeries = series as WaterfallSeries;

                    List<WaterfallSeriesData> seriesData = waterfallSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    waterfallSeries.Type = WaterfallSeriesType.Waterfall;

                    seriesHashtable = waterfallSeries.ToHashtable();
                }
                if (series is PolygonSeries)
                {
                    PolygonSeries polygonSeries = series as PolygonSeries;

                    List<PolygonSeriesData> seriesData = polygonSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    polygonSeries.Type = PolygonSeriesType.Polygon;

                    seriesHashtable = polygonSeries.ToHashtable();
                }
                if (series is TreemapSeries)
                {
                    TreemapSeries treemapSeries = series as TreemapSeries;

                    List<TreemapSeriesData> seriesData = treemapSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    treemapSeries.Type = TreemapSeriesType.Treemap;

                    seriesHashtable = treemapSeries.ToHashtable();
                }

                seriesHashtable.Add("data", dataList);
                results.Add(seriesHashtable);
            }

            return results;
        }
    }
}

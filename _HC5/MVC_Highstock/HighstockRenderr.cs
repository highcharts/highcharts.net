using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using Highsoft.Web.Mvc.Stocks;

namespace Highsoft.Web.Mvc.Stocks.Rendering
{
    public class HighstockRenderer
    {
        private Highstock _chart;

        public HighstockRenderer(Highstock chart)
        {
            _chart = chart;
        }

        public string RenderHtml()
        {
            int licenseType = LicenseVerifier.Check();
            string message = "";

            if (licenseType == 0)
                message = "<div style=\"background:yellow\">Incorrect serial key. I'm working in trial mode now.</div>";

            if (licenseType == -1 || licenseType == 0) //trial
                if (DateTime.Now > CompiledOn.CompilationDate.AddDays(30))
                {
                    message += "This is a trial version of Highstock for ASP.NET MVC which has expired.<br> Please contact sales@highsoft.com with any questions.";
                    return message;
                }

            return message + GetStartupJavascript();
        }

        public string GetStartupJavascript()
        {
            StringBuilder sb = new StringBuilder();

            _chart.Chart.RenderTo = _chart.ID;

            sb.AppendFormat("<div id='{0}' style='height:{1};min-width:{2};clear:both;margin: 0 auto;'></div>", _chart.ID, _chart.Chart.Height.ToString(), _chart.Chart.Width.ToString());
            sb.Append("<script type='text/javascript'>");
            sb.AppendFormat("var {0};", _chart.ID);
            sb.Append("jQuery(document).ready(function() {");
            //sb.AppendFormat("var {0}ChartOptions = {1};", _chart.ID, GetStartupOptions());
            //sb.AppendFormat("{0} = new Highstock.Chart({0}ChartOptions);", _chart.ID);
            sb.AppendFormat("var {0}ChartOptions = {1};", _chart.ID, GetStartupOptions());
            sb.AppendFormat("$('#{0}').highcharts('StockChart', {0}ChartOptions);", _chart.ID);
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

            List<Hashtable> series = new List<Hashtable>();
            List<Hashtable> drilldownSeries = new List<Hashtable>();

            if (_chart.Series != null)
                series = SeriesToHashtables(_chart.Series);
            
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
            var functions = Highstock.functions;

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
                if (series is AreasplinerangeSeries)
                {
                    AreasplinerangeSeries areaSeries = series as AreasplinerangeSeries;

                    List<AreasplinerangeSeriesData> seriesData = areaSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    areaSeries.Type = AreasplinerangeSeriesType.Areasplinerange;

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
                if (series is ColumnSeries)
                {
                    ColumnSeries columnSeries = series as ColumnSeries;

                    List<ColumnSeriesData> seriesData = columnSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    columnSeries.Type = ColumnSeriesType.Column;

                    seriesHashtable = columnSeries.ToHashtable();
                }
                if (series is ScatterSeries)
                {
                    ScatterSeries scatterSeries = series as ScatterSeries;

                    List<ScatterSeriesData> seriesData = scatterSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    scatterSeries.Type = ScatterSeriesType.Scatter;

                    seriesHashtable = scatterSeries.ToHashtable();
                }
                if (series is PolygonSeries)
                {
                    PolygonSeries polygonSeries = series as PolygonSeries;

                    List<PolygonSeriesData> seriesData = polygonSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    polygonSeries.Type = PolygonSeriesType.Polygon;

                    seriesHashtable = polygonSeries.ToHashtable();
                }
                if (series is CandleStickSeries)
                {
                    CandleStickSeries candleStickSeries = series as CandleStickSeries;

                    List<CandleStickSeriesData> seriesData = candleStickSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    candleStickSeries.Type = CandleStickSeriesType.Candlestick;

                    seriesHashtable = candleStickSeries.ToHashtable();
                }
                if (series is FlagsSeries)
                {
                    FlagsSeries flagsSeries = series as FlagsSeries;

                    List<FlagsSeriesData> seriesData = flagsSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    flagsSeries.Type = FlagsSeriesType.Flags;

                    seriesHashtable = flagsSeries.ToHashtable();
                }
                if (series is OhlcSeries)
                {
                    OhlcSeries OhlcSeries = series as OhlcSeries;

                    List<OhlcSeriesData> seriesData = OhlcSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    OhlcSeries.Type = OhlcSeriesType.Ohlc;

                    seriesHashtable = OhlcSeries.ToHashtable();
                }

                seriesHashtable.Add("data", dataList);
                results.Add(seriesHashtable);
            }

            return results;
        }
    }
}

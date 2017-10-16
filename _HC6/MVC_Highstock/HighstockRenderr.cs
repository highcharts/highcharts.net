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
                    message += "This is a trial version of Highstock for ASP.NET MVC which has expired.<br> Please contact sales@highsoft.com with any questions.";
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
                    message += "This is a trial version of Highstock for ASP.NET MVC which has expired.<br> Please contact sales@highsoft.com with any questions.";
                    return message;
                }

            return GetStartupJavascriptFunction(functionName);
        }

        private string GetResponse(int licenseType, bool addContainer)
        {
            string message = "";

            if (licenseType == 0)
                message = "<div style=\"background:yellow\">Incorrect serial key. I'm working in trial mode now.</div>";

            if (licenseType == -1 || licenseType == 0) //trial
                if (DateTime.Now > CompiledOn.CompilationDate.AddDays(30))
                {
                    message += "This is a trial version of Highstock for ASP.NET MVC which has expired.<br> Please contact sales@highsoft.com with any questions.";
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
                    message += "Message:\"This is a trial version of Highstock for ASP.NET MVC which has expired. Please contact sales@highsoft.com with any questions.\"";
                    return "{" + message + "}";
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

        public string GetJsonOptions()
        {
            return GetJsonResponse(LicenseVerifier.Check());
        }

        private string GetStartupJavascriptFunction(string functionName)
        {
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(_chart.ID))
                _chart.Chart.RenderTo = _chart.ID;

            sb.Append("<script type='text/javascript'>");

            sb.Append($"function {functionName}() {{");
            sb.Append($"var ChartOptions = {GetStartupOptions()};");
            sb.Append($"new Highcharts.StockChart(\"{_chart.Chart.RenderTo}\",ChartOptions);");
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

            sb.Append($"if (document.addEventListener) {{document.addEventListener(\"DOMContentLoaded\", function() {{createChart{_chart.Chart.RenderTo}();}});}} else if (document.attachEvent) {{document.attachEvent(\"onreadystatechange\", function(){{if (document.readyState === \"complete\"){{document.detachEvent(\"onreadystatechange\", arguments.callee);createChart{_chart.ID}();}}}});}}");
            
            sb.Append($"function createChart{_chart.Chart.RenderTo}() {{");//s3
            sb.Append($"var ChartOptions = {GetStartupOptions()};");//s3
            sb.Append($"new Highcharts.StockChart(\"{_chart.Chart.RenderTo}\",ChartOptions);");//s3
            sb.Append("}");//s3

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

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;
            string json = serializer.Serialize(options);
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
                    if (series.ToHashtable().ContainsKey("data"))
                    {
                        seriesHashtable = series.ToHashtable();
                        results.Add(seriesHashtable);
                        continue;
                    }
                    
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
                if (series is AreasplinerangeSeries)
                {
                    AreasplinerangeSeries areaSeries = series as AreasplinerangeSeries;

                    //List<AreasplinerangeSeriesData> seriesData = areaSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    areaSeries.Type = AreasplinerangeSeriesType.Areasplinerange;

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
                if (series is ColumnSeries)
                {
                    ColumnSeries columnSeries = series as ColumnSeries;

                    //List<ColumnSeriesData> seriesData = columnSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    columnSeries.Type = ColumnSeriesType.Column;

                    seriesHashtable = columnSeries.ToHashtable();
                }
                if (series is ScatterSeries)
                {
                    ScatterSeries scatterSeries = series as ScatterSeries;

                    //List<ScatterSeriesData> seriesData = scatterSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    scatterSeries.Type = ScatterSeriesType.Scatter;

                    seriesHashtable = scatterSeries.ToHashtable();
                }
                if (series is PolygonSeries)
                {
                    PolygonSeries polygonSeries = series as PolygonSeries;

                    //List<PolygonSeriesData> seriesData = polygonSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    polygonSeries.Type = PolygonSeriesType.Polygon;

                    seriesHashtable = polygonSeries.ToHashtable();
                }
                if (series is CandleStickSeries)
                {
                    CandleStickSeries candleStickSeries = series as CandleStickSeries;

                    //List<CandleStickSeriesData> seriesData = candleStickSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    candleStickSeries.Type = CandleStickSeriesType.Candlestick;

                    seriesHashtable = candleStickSeries.ToHashtable();
                }
                if (series is FlagsSeries)
                {
                    FlagsSeries flagsSeries = series as FlagsSeries;

                    //List<FlagsSeriesData> seriesData = flagsSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    flagsSeries.Type = FlagsSeriesType.Flags;

                    seriesHashtable = flagsSeries.ToHashtable();
                }
                if (series is OhlcSeries)
                {
                    OhlcSeries OhlcSeries = series as OhlcSeries;

                    //List<OhlcSeriesData> seriesData = OhlcSeries.Data;
                    //seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    OhlcSeries.Type = OhlcSeriesType.Ohlc;

                    seriesHashtable = OhlcSeries.ToHashtable();
                }

                // new since version 6.0
                if (series is AdSeries)
                {
                    AdSeries adSeries = series as AdSeries;
                    adSeries.Type = AdSeriesType.Ad;
                    seriesHashtable = adSeries.ToHashtable();
                }

                if (series is AtrSeries)
                {
                    AtrSeries atrSeries = series as AtrSeries;
                    atrSeries.Type = AtrSeriesType.Atr;
                    seriesHashtable = atrSeries.ToHashtable();
                }

                if (series is BbSeries)
                {
                    BbSeries bbSeries = series as BbSeries;
                    bbSeries.Type = BbSeriesType.Bb;
                    seriesHashtable = bbSeries.ToHashtable();
                }

                if (series is CciSeries)
                {
                    CciSeries cciSeries = series as CciSeries;
                    cciSeries.Type = CciSeriesType.Cci;
                    seriesHashtable = cciSeries.ToHashtable();
                }

                if (series is CmfSeries)
                {
                    CmfSeries cmfSeries = series as CmfSeries;
                    cmfSeries.Type = CmfSeriesType.Cmf;
                    seriesHashtable = cmfSeries.ToHashtable();
                }

                if (series is EmaSeries)
                {
                    EmaSeries emaSeries = series as EmaSeries;
                    emaSeries.Type = EmaSeriesType.Ema;
                    seriesHashtable = emaSeries.ToHashtable();
                }

                if (series is MacdSeries)
                {
                    MacdSeries macdSeries = series as MacdSeries;
                    macdSeries.Type = MacdSeriesType.Macd;
                    seriesHashtable = macdSeries.ToHashtable();
                }

                if (series is MfiSeries)
                {
                    MfiSeries mfiSeries = series as MfiSeries;
                    mfiSeries.Type = MfiSeriesType.Mfi;
                    seriesHashtable = mfiSeries.ToHashtable();
                }

                if (series is MomentumSeries)
                {
                    MomentumSeries momentumSeries = series as MomentumSeries;
                    momentumSeries.Type = MomentumSeriesType.Momentum;
                    seriesHashtable = momentumSeries.ToHashtable();
                }

                if (series is PivotpointsSeries)
                {
                    PivotpointsSeries pivotpointsSeries = series as PivotpointsSeries;
                    pivotpointsSeries.Type = PivotpointsSeriesType.Pivotpoints;
                    seriesHashtable = pivotpointsSeries.ToHashtable();
                }

                if (series is PriceenvelopesSeries)
                {
                    PriceenvelopesSeries priceenvelopesSeries = series as PriceenvelopesSeries;
                    priceenvelopesSeries.Type = PriceenvelopesSeriesType.Priceenvelopes;
                    seriesHashtable = priceenvelopesSeries.ToHashtable();
                }

                if (series is PsarSeries)
                {
                    PsarSeries psarSeries = series as PsarSeries;
                    psarSeries.Type = PsarSeriesType.Psar;
                    seriesHashtable = psarSeries.ToHashtable();
                }

                if (series is RocSeries)
                {
                    RocSeries rocSeries = series as RocSeries;
                    rocSeries.Type = RocSeriesType.Roc;
                    seriesHashtable = rocSeries.ToHashtable();
                }

                if (series is RsiSeries)
                {
                    RsiSeries rsiSeries = series as RsiSeries;
                    rsiSeries.Type = RsiSeriesType.Rsi;
                    seriesHashtable = rsiSeries.ToHashtable();
                }

                if (series is SmaSeries)
                {
                    SmaSeries smaSeries = series as SmaSeries;
                    smaSeries.Type = SmaSeriesType.Sma;
                    seriesHashtable = smaSeries.ToHashtable();
                }

                if (series is StochasticSeries)
                {
                    StochasticSeries stochasticSeries = series as StochasticSeries;
                    stochasticSeries.Type = StochasticSeriesType.Stochastic;
                    seriesHashtable = stochasticSeries.ToHashtable();
                }

                if (series is StreamgraphSeries)
                {
                    StreamgraphSeries streamgraphSeries = series as StreamgraphSeries;
                    streamgraphSeries.Type = StreamgraphSeriesType.Streamgraph;
                    seriesHashtable = streamgraphSeries.ToHashtable();
                }

                if (series is VbpSeries)
                {
                    VbpSeries vbpSeries = series as VbpSeries;
                    vbpSeries.Type = VbpSeriesType.Vbp;
                    seriesHashtable = vbpSeries.ToHashtable();
                }

                if (series is VectorSeries)
                {
                    VectorSeries vectorSeries = series as VectorSeries;
                    vectorSeries.Type = VectorSeriesType.Vector;
                    seriesHashtable = vectorSeries.ToHashtable();
                }

                if (series is VwapSeries)
                {
                    VwapSeries vwapSeries = series as VwapSeries;
                    vwapSeries.Type = VwapSeriesType.Vwap;
                    seriesHashtable = vwapSeries.ToHashtable();
                }

                if (series is WindbarbSeries)
                {
                    WindbarbSeries windbarbSeries = series as WindbarbSeries;
                    windbarbSeries.Type = WindbarbSeriesType.Windbarb;
                    seriesHashtable = windbarbSeries.ToHashtable();
                }

                if (series is WmaSeries)
                {
                    WmaSeries wmaSeries = series as WmaSeries;
                    wmaSeries.Type = WmaSeriesType.Wma;
                    seriesHashtable = wmaSeries.ToHashtable();
                }

                if (series is XrangeSeries)
                {
                    XrangeSeries xrangeSeries = series as XrangeSeries;
                    xrangeSeries.Type = XrangeSeriesType.Xrange;
                    seriesHashtable = xrangeSeries.ToHashtable();
                }

                if (series is ZigzagSeries)
                {
                    ZigzagSeries zigzagSeries = series as ZigzagSeries;
                    zigzagSeries.Type = ZigzagSeriesType.Ohlc;
                    seriesHashtable = zigzagSeries.ToHashtable();
                }

                //seriesHashtable.Add("data", dataList);
                results.Add(seriesHashtable);
            }

            return results;
        }
    }
}

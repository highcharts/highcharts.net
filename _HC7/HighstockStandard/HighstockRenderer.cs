using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Highsoft.Web.Mvc.Stocks;

namespace Highsoft.Web.Mvc.Stocks.Rendering
{
    public class HighstockRenderer
    {
        private Highstock _chart;
        private readonly string _SerialKey;
        private bool _IsNetCore;

        public HighstockRenderer() { }

        public HighstockRenderer(Highstock chart, string key = null, bool isNETCore = false)
        {
            _chart = chart;
            _SerialKey = key;
            _IsNetCore = isNETCore;
        }

        public string RenderHtml(bool addContainer = true)
        {
            return GetResponse(LicenseVerifier.Check(_IsNetCore, _SerialKey), addContainer);
        }

        public string GetJavascript()
        {
            var licenseType = LicenseVerifier.Check(_IsNetCore, _SerialKey);

            if (licenseType == SerialKey.Missing)
                return "<div style=\"background:yellow\">Licence key is missing. Please click a link below, share your email address and we will send you a trial-key.<br><a href=\"https://www.highcharts.com/dotnet-registration/\">Click here to get a trial-key</a></div>";

            if (licenseType == SerialKey.Invalid)
                return "<div style=\"background:yellow\">Licence key is incorrect. Please check your licence-key again or contact us at support@highcharts.com</div>";

            if (licenseType == SerialKey.Trial14DaysBeforeEndValid)
                return "<div style=\"background:yellow\">Trial-key will expire in 14 days. Please share your opinion about our wrapper and you will receive an unlimited serial key.<br><a href=\"https://www.highcharts.com/dotnet-license/\">Click here for 1-minute survey</a></div>";

            if (licenseType == SerialKey.TrialExpired)
                return "<div style=\"background:yellow\">Trial-key has expired. Please share your opinion about our wrapper and you will receive an unlimited serial key.<br><a href=\"https://www.highcharts.com/dotnet-license/\">Click here for 1-minute survey</a></div>";

            return GetCreateChartJavascript();
        }

        public string GetJavascriptFunction(string functionName)
        {
            var licenseType = LicenseVerifier.Check(_IsNetCore, _SerialKey);

            if (licenseType == SerialKey.Missing)
                return "<div style=\"background:yellow\">Licence key is missing. Please click a link below, share your email address and we will send you a trial-key.<br><a href=\"https://www.highcharts.com/dotnet-registration/\">Click here to get a trial-key</a></div>";

            if (licenseType == SerialKey.Invalid)
                return "<div style=\"background:yellow\">Licence key is incorrect. Please check your licence-key again or contact us at support@highcharts.com</div>";

            if (licenseType == SerialKey.Trial14DaysBeforeEndValid)
                return "<div style=\"background:yellow\">Trial-key will expire in 14 days. Please share your opinion about our wrapper and you will receive an unlimited serial key.<br><a href=\"https://www.highcharts.com/dotnet-license/\">Click here for 1-minute survey</a></div>";

            if (licenseType == SerialKey.TrialExpired)
                return "<div style=\"background:yellow\">Trial-key has expired. Please share your opinion about our wrapper and you will receive an unlimited serial key.<br><a href=\"https://www.highcharts.com/dotnet-license/\">Click here for 1-minute survey</a></div>";

            return GetStartupJavascriptFunction(functionName);
        }

        public string SetOptions(Global global = null, Lang lang = null)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script type='text/javascript'>");
            sb.Append("Highstock.setOptions(");

            Hashtable options = new Hashtable();

            if (global != null && global.IsDirty())
                options.Add("global", global.ToHashtable());

            if (lang != null && lang.IsDirty())
                options.Add("lang", lang.ToHashtable());

            sb.Append(JsonConvert.SerializeObject(options));
            sb.Append(");</script>");
            return sb.ToString();
        }

        private string GetResponse(SerialKey licenseType, bool addContainer)
        {
            if (licenseType == SerialKey.Missing)
                return "<div style=\"background:yellow\">Licence key is missing. Please click a link below, share your email address and we will send you a trial-key.<br><a href=\"https://www.highcharts.com/dotnet-registration/\">Click here to get a trial-key</a></div>";

            if (licenseType == SerialKey.Invalid)
                return "<div style=\"background:yellow\">Licence key is incorrect. Please check your licence-key again or contact us at support@highcharts.com</div>";

            if (licenseType == SerialKey.Trial14DaysBeforeEndValid)
                return "<div style=\"background:yellow\">Trial-key will expire in 14 days. Please share your opinion about our wrapper and you will receive an unlimited serial key.<br><a href=\"https://www.highcharts.com/dotnet-license/\">Click here for 1-minute survey</a></div>";

            if (licenseType == SerialKey.TrialExpired)
                return "<div style=\"background:yellow\">Trial-key has expired. Please share your opinion about our wrapper and you will receive an unlimited serial key.<br><a href=\"https://www.highcharts.com/dotnet-license/\">Click here for 1-minute survey</a></div>";

            return GetStartupJavascript(addContainer);
        }

        private string GetJsonResponse(SerialKey licenseType)
        {
            if (licenseType == SerialKey.Missing)
                return "{Message:\"Licence key is missing. Please click a link below, share your email address and we will send you a trial-key.<br><a href=\"https://www.highcharts.com/dotnet-registration/\">Click here to get a trial-key</a>\"}";

            if (licenseType == SerialKey.Invalid)
                return "{Message:\"Licence key is incorrect. Please check your licence-key again or contact us at support@highcharts.com\"}";

            if (licenseType == SerialKey.Trial14DaysBeforeEndValid)
                return "{Message:\"Trial-key will expire in 14 days. Please share your opinion about our wrapper and you will receive an unlimited serial key.<br><a href=\"https://www.highcharts.com/dotnet-license/\">Click here for 1-minute survey</a>\"}";

            if (licenseType == SerialKey.TrialExpired)
                return "{Message:\"Trial-key has expired. Please share your opinion about our wrapper and you will receive an unlimited serial key.<br><a href=\"https://www.highcharts.com/dotnet-license/\">Click here for 1-minute survey</a>\"}";

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
            return GetJsonResponse(LicenseVerifier.Check(_IsNetCore, _SerialKey));
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

            string json = JsonConvert.SerializeObject(options);
            var functions = Highstock.functions;

            foreach (string key in functions.Keys)
            {
                string value = (string)functions[key];
                string realKey = key.Split('.')[1];
                string matchedString = String.Format("\"{0}\":\"{1}\"", realKey, value);
                matchedString = matchedString.Replace("'", "\\u0027");
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
                    zigzagSeries.Type = ZigzagSeriesType.Zigzag;
                    seriesHashtable = zigzagSeries.ToHashtable();
                }

                //since v7.0
                if (series is ColumnpyramidSeries)
                {
                    ColumnpyramidSeries columnpyramidSeries = series as ColumnpyramidSeries;
                    columnpyramidSeries.Type = ColumnpyramidSeriesType.Columnpyramid;
                    seriesHashtable = columnpyramidSeries.ToHashtable();
                }

                if (series is AbandsSeries)
                {
                    AbandsSeries abandsSeries = series as AbandsSeries;
                    abandsSeries.Type = AbandsSeriesType.Abands;
                    seriesHashtable = abandsSeries.ToHashtable();
                }

                if (series is AoSeries)
                {
                    AoSeries aoSeries = series as AoSeries;
                    aoSeries.Type = AoSeriesType.Ao;
                    seriesHashtable = aoSeries.ToHashtable();
                }

                if (series is ApoSeries)
                {
                    ApoSeries apoSeries = series as ApoSeries;
                    apoSeries.Type = ApoSeriesType.Apo;
                    seriesHashtable = apoSeries.ToHashtable();
                }

                if (series is AroonoscillatorSeries)
                {
                    AroonoscillatorSeries aroonoscillatorSeries = series as AroonoscillatorSeries;
                    aroonoscillatorSeries.Type = AroonoscillatorSeriesType.Aroonoscillator;
                    seriesHashtable = aroonoscillatorSeries.ToHashtable();
                }

                if (series is AroonSeries)
                {
                    AroonSeries aroonSeries = series as AroonSeries;
                    aroonSeries.Type = AroonSeriesType.Aroon;
                    seriesHashtable = aroonSeries.ToHashtable();
                }

                if (series is ChaikinSeries)
                {
                    ChaikinSeries chaikinSeries = series as ChaikinSeries;
                    chaikinSeries.Type = ChaikinSeriesType.Chaikin;
                    seriesHashtable = chaikinSeries.ToHashtable();
                }

                if (series is DemaSeries)
                {
                    DemaSeries demaSeries = series as DemaSeries;
                    demaSeries.Type = DemaSeriesType.Dema;
                    seriesHashtable = demaSeries.ToHashtable();
                }

                if (series is DpoSeries)
                {
                    DpoSeries dpoSeries = series as DpoSeries;
                    dpoSeries.Type = DpoSeriesType.Dpo;
                    seriesHashtable = dpoSeries.ToHashtable();
                }

                if (series is KeltnerchannelsSeries)
                {
                    KeltnerchannelsSeries KeltnerchannelsSeries = series as KeltnerchannelsSeries;
                    KeltnerchannelsSeries.Type = KeltnerchannelsSeriesType.Keltnerchannels;
                    seriesHashtable = KeltnerchannelsSeries.ToHashtable();
                }

                if (series is LinearregressionangleSeries)
                {
                    LinearregressionangleSeries linearregressionangleSeries = series as LinearregressionangleSeries;
                    linearregressionangleSeries.Type = LinearregressionangleSeriesType.Linearregressionangle;
                    seriesHashtable = linearregressionangleSeries.ToHashtable();
                }

                if (series is NatrSeries)
                {
                    NatrSeries natrSeries = series as NatrSeries;
                    natrSeries.Type = NatrSeriesType.Natr;
                    seriesHashtable = natrSeries.ToHashtable();
                }

                if (series is PackedbubbleSeries)
                {
                    PackedbubbleSeries packedbubbleSeries = series as PackedbubbleSeries;
                    packedbubbleSeries.Type = TypeSeries.Packedbubble;
                    seriesHashtable = packedbubbleSeries.ToHashtable();
                }

                if (series is PcSeries)
                {
                    PcSeries abandsSeries = series as PcSeries;
                    abandsSeries.Type = PcSeriesType.Pc;
                    seriesHashtable = abandsSeries.ToHashtable();
                }

                if (series is PpoSeries)
                {
                    PpoSeries ppoSeries = series as PpoSeries;
                    ppoSeries.Type = PpoSeriesType.Abands;
                    seriesHashtable = ppoSeries.ToHashtable();
                }

                if (series is SupertrendSeries)
                {
                    SupertrendSeries supertrendSeries = series as SupertrendSeries;
                    supertrendSeries.Type = SupertrendSeriesType.Supertrend;
                    seriesHashtable = supertrendSeries.ToHashtable();
                }

                if (series is TemaSeries)
                {
                    TemaSeries temaSeries = series as TemaSeries;
                    temaSeries.Type = TemaSeriesType.Tema;
                    seriesHashtable = temaSeries.ToHashtable();
                }

                if (series is TrixSeries)
                {
                    TrixSeries trixSeries = series as TrixSeries;
                    trixSeries.Type = TrixSeriesType.Trix;
                    seriesHashtable = trixSeries.ToHashtable();
                }

                if (series is WilliamsrSeries)
                {
                    WilliamsrSeries williamsrSeries = series as WilliamsrSeries;
                    williamsrSeries.Type = WilliamsrSeriesType.Williamsr;
                    seriesHashtable = williamsrSeries.ToHashtable();
                }
                //seriesHashtable.Add("data", dataList);
                results.Add(seriesHashtable);
            }

            return results;
        }
    }
}

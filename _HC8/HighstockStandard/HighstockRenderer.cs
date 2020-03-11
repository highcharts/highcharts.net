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

        public HighstockRenderer() { }

        public HighstockRenderer(Highstock chart)
        {
            _chart = chart;            
        }

        public string RenderHtml(bool addContainer = true)
        {
            return GetResponse(addContainer);
        }

        public string GetJavascript()
        {
            return GetCreateChartJavascript();
        }

        public string GetJavascriptFunction(string functionName)
        {
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

        private string GetResponse(bool addContainer)
        {
            return GetStartupJavascript(addContainer);
        }

        private string GetJsonResponse()
        {
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
            return GetJsonResponse();
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
                //matchedString = matchedString.Replace("'", "\\u0027");
                string replacementstring = String.Format("\"{0}\":{1}", realKey, value);
                json = json.Replace(matchedString, replacementstring);
            }

            s.Append(json);
        }

        private List<Hashtable> SeriesToHashtables(List<Series>  listOfSeries)
        {
            List<Hashtable> results = new List<Hashtable>();

            foreach (Series series in listOfSeries)
                results.Add(series.ToHashtable());

            return results;
        }
    }
}

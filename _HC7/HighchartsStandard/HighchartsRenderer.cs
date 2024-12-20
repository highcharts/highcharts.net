﻿using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Highsoft.Web.Mvc.Charts;
using System.Reflection;

namespace Highsoft.Web.Mvc.Charts.Rendering
{
    public class HighchartsRenderer
    {
        private Highcharts _chart;

        public HighchartsRenderer() { }

        public HighchartsRenderer(Highcharts chart)
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
            return GetCreateChartJavascriptFunction(functionName);
        }

        public string SetOptions(Global global = null, Lang lang = null)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script type='text/javascript'>");
            sb.Append("Highcharts.setOptions(");

            Hashtable options = new Hashtable();

            if (global != null)
                options.Add("global", global.ToHashtable(_chart));

            if (lang != null)
                options.Add("lang", lang.ToHashtable(_chart));

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
                if (_chart.Chart != null)
                    _chart.Chart.RenderTo = _chart.ID;
                else
                    _chart.Chart = new Chart { RenderTo = _chart.ID };

            sb.Append("<script type='text/javascript'>");
            sb.Append($"var ChartOptions = {GetStartupOptions()};");
            sb.Append($"Highcharts.chart(\"{_chart.Chart.RenderTo}\",ChartOptions);");

            sb.Append("</script>");
            return sb.ToString();
        }

        private string GetCreateChartJavascriptFunction(string functionName)
        {
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(_chart.ID))
                if (_chart.Chart != null)
                    _chart.Chart.RenderTo = _chart.ID;
                else
                    _chart.Chart = new Chart { RenderTo = _chart.ID };
           
            sb.Append("<script type='text/javascript'>");

            sb.Append($"function {functionName}() {{");
            sb.Append($"var ChartOptions = {GetStartupOptions()};");
            sb.Append($"Highcharts.chart(\"{_chart.Chart.RenderTo}\",ChartOptions);");
            sb.Append("}");
            
            sb.Append("</script>");
            return sb.ToString();
        }

        private string GetStartupJavascript(bool addContainer)
        {
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(_chart.ID))
                if (_chart.Chart != null)
                    _chart.Chart.RenderTo = _chart.ID;
                else
                    _chart.Chart = new Chart { RenderTo = _chart.ID };

            if (addContainer)
                sb.AppendFormat("<div id='{0}' style='height:{1};min-width:{2};clear:both;margin: 0 auto;'></div>", _chart.Chart.RenderTo, GetChartHeight(), GetChartWidth());

            sb.Append("<script type='text/javascript'>");
            
            sb.Append($"if (document.addEventListener) {{document.addEventListener(\"DOMContentLoaded\", function() {{createChart{_chart.Chart.RenderTo}();}});}} else if (document.attachEvent) {{document.attachEvent(\"onreadystatechange\", function(){{if (document.readyState === \"complete\"){{document.detachEvent(\"onreadystatechange\", arguments.callee);createChart{_chart.Chart.RenderTo}();}}}});}}");

            sb.Append($"function createChart{_chart.Chart.RenderTo}() {{");//s3
            sb.Append($"var ChartOptions = {GetStartupOptions()};");//s3
            sb.Append($"Highcharts.chart(\"{_chart.Chart.RenderTo}\",ChartOptions);");//s3
            sb.Append("}");//s3

            sb.Append("</script>");
            return sb.ToString();            
        }

        public string GetJsonOptions()
        {
            return GetJsonResponse();
        }

        public string GetJsonOptionsForBlazor()
        {
            return JsonConvert.SerializeObject(_chart.ToHashtable(_chart));
        }

        private string GetStartupOptions()
        {            
            StringBuilder sb = new StringBuilder();            
            RenderChartSettings(sb);
            return sb.ToString();
        }

        private void RenderChartSettings(StringBuilder s)
        {            
            Hashtable options = _chart.ToHashtable(_chart);
            string json = JsonConvert.SerializeObject(options);
            var functions = _chart.functions;
            List<string> keysToRemove = new List<string>();

            foreach (string key in functions.Keys)
            {
                string value = JsonConvert.SerializeObject(functions[key]);
                string realKey = key.Split('.')[1];
                string matchedString = String.Format("\"{0}\":{1}", realKey, value);
                //matchedString = matchedString.Replace("'", "\\u0027");

                if (json.Contains(matchedString))
                {
                    string replacementstring = String.Format("\"{0}\":{1}", realKey, value.Remove(value.Length - 1, 1).Remove(0, 1));

                    if (matchedString.Contains("animation") || matchedString.Contains("pointPlacement"))
                        replacementstring = replacementstring.Replace("\\", "");

                    json = json.Replace(matchedString, replacementstring);
                    keysToRemove.Add(key);
                }
            }

            foreach (var key in keysToRemove)
                _chart.functions.Remove(key);

            keysToRemove.Clear();

            s.Append(json);
        }

        private List<Hashtable> SeriesToHashtables(List<Series>  listOfSeries)
        {
            List<Hashtable> results = new List<Hashtable>(); 

            foreach (var series in listOfSeries)
                results.Add(series.ToHashtable(_chart));

            return results;
        }

        private string GetChartHeight()
        {
            if (string.IsNullOrEmpty(_chart.Chart.Height))
                if (_chart.Chart.HeightNumber == null)
                    return string.Empty;
                else
                    return _chart.Chart.HeightNumber.ToString();
            else
                return _chart.Chart.Height;
        }

        private string GetChartWidth()
        {
            if (string.IsNullOrEmpty(_chart.Chart.Width))
                if (_chart.Chart.WidthNumber == null)
                    return string.Empty;
                else
                    return _chart.Chart.WidthNumber.ToString();
            else
                return _chart.Chart.Width;
        }
    }
}

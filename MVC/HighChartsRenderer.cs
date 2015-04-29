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

            sb.AppendFormat("<div id='{0}' style='height:{1};min-width:{2};clear:both;margin: 0 auto;'></div>", _chart.ID, _chart.Chart.Height.ToString(), _chart.Chart.Width.ToString());
            sb.Append("<script type='text/javascript'>");
            sb.Append("jQuery(document).ready(function() {");
            sb.AppendFormat("$('#{0}').highcharts(", _chart.ID);
            sb.Append(GetStartupOptions());
            sb.Append(");");
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
            List<Hashtable> results = new List<Hashtable>();            

            foreach (Series series in _chart.Series)
            {
                Hashtable seriesHashtable = series.ToHashtable();
                List<double?> dataList = new List<double?>();
                foreach (SeriesData data in series.Data)
                {
                   
                }
                seriesHashtable.Add("data", dataList);

                results.Add(seriesHashtable);
            }

            if (results.Count > 0)
            {                
                options.Add("series", results);
            }


            string json = new JavaScriptSerializer().Serialize(options);
            var functions = Highcharts.functions;

            foreach (string key in functions.Keys)
            {
                string value = (string)functions[key];
                string matchedString = String.Format("\"{0}\":\"{1}\"", key, value);
                string replacementstring = String.Format("\"{0}\":{1}", key, value);
                json = json.Replace(matchedString, replacementstring);
            }

            s.Append(json);
        }        
    }
}

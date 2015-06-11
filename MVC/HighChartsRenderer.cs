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
            sb.Append("jQuery(document).ready(function() {");
            sb.AppendFormat("var {0}ChartOptions = {1};", _chart.ID, GetStartupOptions());
            sb.AppendFormat("window.{0} = new Highcharts.Chart({0}ChartOptions);", _chart.ID);
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
                List<object> dataList = new List<object>();

                if (series is LineSeries)
                {                    
                    List<LineSeriesData> seriesData = ((LineSeries) series).Data;

                    foreach (LineSeriesData data in seriesData)
                    {
                        var dataPoint = new double?[2];
                        dataPoint[0] = data.X;
                        dataPoint[1] = data.Y;
                        dataList.Add(dataPoint);
                    }
                }
                if (series is AreaSeries)
                {
                    List<AreaSeriesData> seriesData = ((AreaSeries)series).Data;

                    foreach (AreaSeriesData data in seriesData)
                    {
                        var dataPoint = new double?[2];
                        dataPoint[0] = data.X;
                        dataPoint[1] = data.Y;
                        dataList.Add(dataPoint);
                    }
                }
                if (series is SplineSeries)
                {
                    List<SplineSeriesData> seriesData = ((SplineSeries)series).Data;

                    foreach (SplineSeriesData data in seriesData)
                    {
                        var dataPoint = new double?[2];
                        dataPoint[0] = data.X;
                        dataPoint[1] = data.Y;
                        dataList.Add(dataPoint);
                    }
                }
                if (series is BarSeries)
                {
                    List<BarSeriesData> seriesData = ((BarSeries)series).Data;

                    foreach (BarSeriesData data in seriesData)
                    {
                        var dataPoint = new double?[2];
                        dataPoint[0] = data.X;
                        dataPoint[1] = data.Y;
                        dataList.Add(dataPoint);
                    }
                }
                if (series is ColumnSeries)
                {
                    List<ColumnSeriesData> seriesData = ((ColumnSeries)series).Data;

                    foreach (ColumnSeriesData data in seriesData)
                    {
                        var dataPoint = new double?[2];
                        dataPoint[0] = data.X;
                        dataPoint[1] = data.Y;
                        dataList.Add(dataPoint);
                    }
                }

                seriesHashtable.Add("data", dataList);
                results.Add(seriesHashtable);
            }

            if (results.Count > 0)
            {
                options["series"] = results;
                //options.Add("series", results);
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
    }
}

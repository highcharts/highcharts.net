using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using Highsoft.Web.Mvc.Maps;

namespace Highsoft.Web.Mvc.Maps.Rendering
{
    public class HighmapsRenderer
    {
        private Highmaps _map;

        public HighmapsRenderer(Highmaps map)
        {
            _map = map;
        }

        public string RenderHtml()
        {            
            #if (LICENSED == false)
            if (DateTime.Now > CompiledOn.CompilationDate.AddDays(30))
            {
                return "This is a trial version of Highcharts for ASP.NET MVC which has expired.<br> Please contact sales@highsoft.com with any questions.";
               
            }
            #endif
            return GetStartupJavascript();
        }

        private string GetStartupJavascript()
        {
            StringBuilder sb = new StringBuilder();

            _map.Chart.RenderTo = _map.ID;

            sb.AppendFormat("<div id='{0}' style='height:{1};min-width:{2};clear:both;margin: 0 auto;'></div>", _map.ID, _map.Chart.Height.ToString(), _map.Chart.Width.ToString());
            sb.Append("<script type='text/javascript'>");
            sb.AppendFormat("var {0};", _map.ID);
            sb.Append("jQuery(document).ready(function() {");
            sb.AppendFormat("var {0}ChartOptions = {1};", _map.ID, GetStartupOptions());
            sb.AppendFormat("{0} = new Highcharts.Chart({0}ChartOptions);", _map.ID);
            sb.Append("});");            
            sb.Append("</script>");
            return sb.ToString();            
        }

        private string GetStartupOptions()
        {            
            StringBuilder sb = new StringBuilder();            
            RenderMapSettings(sb);
            return sb.ToString();
        }

        private void RenderMapSettings(StringBuilder s)
        {            
            Hashtable options = _map.ToHashtable();

            List<Hashtable> series = new List<Hashtable>();
            List<Hashtable> drilldownSeries = new List<Hashtable>();

            if (_map.Series != null)
                series = SeriesToHashtables(_map.Series);
            if (_map.Drilldown.Series != null)
                drilldownSeries = SeriesToHashtables(_map.Drilldown.Series);

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
            var functions = Highmaps.functions;

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

                
                if (series is HeatmapSeries)
                {
                    HeatmapSeries heatMapSeries = series as HeatmapSeries;

                    List<HeatmapSeriesData> seriesData = heatMapSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    heatMapSeries.Type = HeatmapSeriesType.Heatmap;

                    seriesHashtable = heatMapSeries.ToHashtable();
                }


                if (series is MapBubbleSeries)
                {
                    MapBubbleSeries mapBubbleSeries = series as MapBubbleSeries;

                    List<MapBubbleSeriesData> seriesData = mapBubbleSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    mapBubbleSeries.Type = MapBubbleSeriesType.Mapbubble;

                    seriesHashtable = mapBubbleSeries.ToHashtable();
                }


                if (series is MapLineSeries)
                {
                    MapLineSeries mapLineSeries = series as MapLineSeries;

                    List<MapLineSeriesData> seriesData = mapLineSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    mapLineSeries.Type = MapLineSeriesType.Mapline;

                    seriesHashtable = mapLineSeries.ToHashtable();
                }

                if (series is MapPointSeries)
                {
                    MapPointSeries mapPointSeries = series as MapPointSeries;

                    List<MapPointSeriesData> seriesData = mapPointSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    mapPointSeries.Type = MapPointSeriesType.Mappoint;

                    seriesHashtable = mapPointSeries.ToHashtable();
                }

                if (series is MapSeries)
                {
                    MapSeries mapSeries = series as MapSeries;

                    List<MapSeriesData> seriesData = mapSeries.Data;
                    seriesData.ForEach(data => dataList.Add(data.ToHashtable()));
                    mapSeries.Type = MapSeriesType.Map;

                    seriesHashtable = mapSeries.ToHashtable();
                }

               

                seriesHashtable.Add("data", dataList);
                results.Add(seriesHashtable);
            }

            return results;
        }
    }
}

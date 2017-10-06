using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;


namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult Heatmap()
        {
            List<HeatmapSeriesData> data = new List<HeatmapSeriesData>();
            //data.Add(new HeatmapSeriesData { X = 0, Y = 0, Value = 10 });
            //data.Add(new HeatmapSeriesData { X = 0, Y = 1, Value = 19 });
            //data.Add(new HeatmapSeriesData { X = 0, Y = 2, Value = 8 });
            //data.Add(new HeatmapSeriesData { X = 0, Y = 3, Value = 24 });
            //data.Add(new HeatmapSeriesData { X = 0, Y = 4, Value = 67 });
            //data.Add(new HeatmapSeriesData { X = 1, Y = 4, Value = 92 });
            //data.Add(new HeatmapSeriesData { X = 1, Y = 1, Value = 58 });
            //data.Add(new HeatmapSeriesData { X = 1, Y = 2, Value = 78 });
            //data.Add(new HeatmapSeriesData { X = 1, Y = 3, Value = 117 });
            //data.Add(new HeatmapSeriesData { X = 1, Y = 4, Value = 48 });
            //data.Add(new HeatmapSeriesData { X = 2, Y = 0, Value = 35 });
            //data.Add(new HeatmapSeriesData { X = 2, Y = 1, Value = 15 });
            //data.Add(new HeatmapSeriesData { X = 2, Y = 2, Value = 123 });
            //data.Add(new HeatmapSeriesData { X = 2, Y = 3, Value = 64 });
            //data.Add(new HeatmapSeriesData { X = 2, Y = 4, Value = 52 });
            //data.Add(new HeatmapSeriesData { X = 3, Y = 0, Value = 72 });
            //data.Add(new HeatmapSeriesData { X = 3, Y = 1, Value = 132 });
            //data.Add(new HeatmapSeriesData { X = 3, Y = 2, Value = 114 });
            //data.Add(new HeatmapSeriesData { X = 3, Y = 3, Value = 19 });
            //data.Add(new HeatmapSeriesData { X = 3, Y = 4, Value = 16 });
            //data.Add(new HeatmapSeriesData { X = 4, Y = 0, Value = 38 });
            //data.Add(new HeatmapSeriesData { X = 4, Y = 1, Value = 5 });
            //data.Add(new HeatmapSeriesData { X = 4, Y = 2, Value = 8 });
            //data.Add(new HeatmapSeriesData { X = 4, Y = 3, Value = 117 });
            //data.Add(new HeatmapSeriesData { X = 4, Y = 4, Value = 115 });
            //data.Add(new HeatmapSeriesData { X = 5, Y = 0, Value = 88 });
            //data.Add(new HeatmapSeriesData { X = 5, Y = 1, Value = 32 });
            //data.Add(new HeatmapSeriesData { X = 5, Y = 2, Value = 12 });
            //data.Add(new HeatmapSeriesData { X = 5, Y = 3, Value = 6 });
            //data.Add(new HeatmapSeriesData { X = 5, Y = 4, Value = 120 });
            //data.Add(new HeatmapSeriesData { X = 6, Y = 0, Value = 13 });
            //data.Add(new HeatmapSeriesData { X = 6, Y = 1, Value = 44 });
            //data.Add(new HeatmapSeriesData { X = 6, Y = 4, Value = 88 });
            //data.Add(new HeatmapSeriesData { X = 6, Y = 3, Value = 98 });
            //data.Add(new HeatmapSeriesData { X = 6, Y = 4, Value = 96 });
            //data.Add(new HeatmapSeriesData { X = 7, Y = 0, Value = 31 });
            //data.Add(new HeatmapSeriesData { X = 7, Y = 1, Value = 1 });
            //data.Add(new HeatmapSeriesData { X = 7, Y = 2, Value = 82 });
            //data.Add(new HeatmapSeriesData { X = 7, Y = 3, Value = 32 });
            //data.Add(new HeatmapSeriesData { X = 7, Y = 4, Value = 30 });
            //data.Add(new HeatmapSeriesData { X = 8, Y = 0, Value = 85 });
            //data.Add(new HeatmapSeriesData { X = 8, Y = 1, Value = 97 });
            //data.Add(new HeatmapSeriesData { X = 8, Y = 2, Value = 123 });
            //data.Add(new HeatmapSeriesData { X = 8, Y = 3, Value = 64 });
            //data.Add(new HeatmapSeriesData { X = 8, Y = 4, Value = 84 });
            //data.Add(new HeatmapSeriesData { X = 9, Y = 0, Value = 47 });
            //data.Add(new HeatmapSeriesData { X = 9, Y = 1, Value = 114 });
            //data.Add(new HeatmapSeriesData { X = 9, Y = 2, Value = 31 });
            //data.Add(new HeatmapSeriesData { X = 9, Y = 3, Value = 48 });
            //data.Add(new HeatmapSeriesData { X = 9, Y = 4, Value = 91 });

            ViewData["heatMapData"] = data;

            return View();
        }
    }
}

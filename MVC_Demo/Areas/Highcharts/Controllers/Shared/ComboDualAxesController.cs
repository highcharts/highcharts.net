using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Highcharts;


namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult ComboDualAxes()
        {
            List<double?> rainValues = new List<double?> { 49.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 };
            List<double?> temperatureValues = new List<double?> { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 };

            List<ColumnSeriesData> rainData = new List<ColumnSeriesData>();            
            List<SplineSeriesData> temperatureData = new List<SplineSeriesData>();
            
            rainValues.ForEach(p => rainData.Add(new ColumnSeriesData { Y = p }));
            temperatureValues.ForEach(p => temperatureData.Add(new SplineSeriesData { Y = p }));

            ViewData["rainData"] = rainData;
            ViewData["temperatureData"] = temperatureData;            

            return View();
        }
    }
}

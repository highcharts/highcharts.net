using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highcharts.Web.Mvc;


namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult LineLog()
        {
            List<double> logValues = new List<double> { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            List<LineSeriesData> logData = new List<LineSeriesData>();

            logValues.ForEach(p => logData.Add(new LineSeriesData { Y = p }));

            ViewData["logData"] = logData;

            return View();
        }        
    }
}

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
        public ActionResult Polygon()
        { 
            List<ScatterSeriesData> observationData = new List<ScatterSeriesData>();

            

            Random r = new Random();
            for (int i = 0; i < 250; i++)
            {
                double x = r.Next(151, 176);
                double y = r.Next(51, 104);
                observationData.Add(new ScatterSeriesData { X = x, Y = y });
            }

            ViewData["observationData"] = observationData;

            return View();
        }      
    }
}
                
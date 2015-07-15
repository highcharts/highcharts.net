using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc;


namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult GaugeSpeedometer()
        {
            List<GaugeSeriesData> gaugeData = new List<GaugeSeriesData>();
            gaugeData.Add(new GaugeSeriesData { Y = 80 });
            
            ViewData["gaugeData"] = gaugeData;

            return View();
        }
    }
}

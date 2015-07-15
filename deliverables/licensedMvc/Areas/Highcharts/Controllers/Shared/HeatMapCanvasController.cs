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
        public double DateUTC(DateTime date)
        {
            DateTime d1 = new DateTime(1970, 1, 1);
            DateTime d2 = date.ToUniversalTime();
            TimeSpan ts = new TimeSpan(d2.Ticks - d1.Ticks);

            return ts.TotalMilliseconds;
        }

        public ActionResult HeatMapCanvas()
        {
            ViewData["minDate"] = DateUTC(new DateTime(2013, 1, 1));
            ViewData["maxDate"] = DateUTC(new DateTime(2014, 1, 1));

            return View();
        }
    }
}

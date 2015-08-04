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
        public ActionResult Index()
        {
            return View();
        }

        public double MilliTimeStamp(DateTime theDate)
        {
            DateTime d1 = new DateTime(1970, 1, 1);
            DateTime d2 = theDate.ToUniversalTime();
            TimeSpan ts = new TimeSpan(d2.Ticks - d1.Ticks);

            return ts.TotalMilliseconds;
        }

    }
}

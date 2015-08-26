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
        public ActionResult SplinePlotBands()
        {
            List<double> hValues = new List<double> { 4.3, 5.1, 4.3, 5.2, 5.4, 4.7, 3.5, 4.1, 5.6, 7.4, 6.9, 7.1,
                7.9, 7.9, 7.5, 6.7, 7.7, 7.7, 7.4, 7.0, 7.1, 5.8, 5.9, 7.4,
                8.2, 8.5, 9.4, 8.1, 10.9, 10.4, 10.9, 12.4, 12.1, 9.5, 7.5,
                7.1, 7.5, 8.1, 6.8, 3.4, 2.1, 1.9, 2.8, 2.9, 1.3, 4.4, 4.2,
                3.0, 3.0 };
            List<double> vValues = new List<double> {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.1, 0.0, 0.3, 0.0,
                0.0, 0.4, 0.0, 0.1, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                0.0, 0.6, 1.2, 1.7, 0.7, 2.9, 4.1, 2.6, 3.7, 3.9, 1.7, 2.3,
                3.0, 3.3, 4.8, 5.0, 4.8, 5.0, 3.2, 2.0, 0.9, 0.4, 0.3, 0.5, 0.4 };

            List<SplineSeriesData> hData = new List<SplineSeriesData>();
            List<SplineSeriesData> vData = new List<SplineSeriesData>();

            hValues.ForEach(p => hData.Add(new SplineSeriesData { Y = p }));
            vValues.ForEach(p => vData.Add(new SplineSeriesData { Y = p }));

            ViewBag.DateUTC = MilliTimeStamp(new System.DateTime(2009, 1, 1, 0, 0, 0));

            ViewData["hData"] = hData;
            ViewData["vData"] = vData;

            return View();
        }
    }
}

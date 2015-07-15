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
        public ActionResult AreaStacked()
        {
            List<double?> asiaValues = new List<double?> { 502, 635, 809, 947, 1402, 3634, 5268 };
            List<double?> africaValues = new List<double?> { 106, 107, 111, 133, 221, 767, 1766 };
            List<double?> europeValues = new List<double?> { 163, 203, 276, 408, 547, 729, 628 };
            List<double?> americaValues = new List<double?> { 18, 31, 54, 156, 339, 818, 1201 };
            List<double?> oceaniaValues = new List<double?> { 2, 2, 2, 6, 13, 30, 46 };

            List<AreaSeriesData> asiaData = new List<AreaSeriesData>();
            List<AreaSeriesData> africaData = new List<AreaSeriesData>();
            List<AreaSeriesData> europeData = new List<AreaSeriesData>();
            List<AreaSeriesData> americaData = new List<AreaSeriesData>();
            List<AreaSeriesData> oceaniaData = new List<AreaSeriesData>();

            asiaValues.ForEach(p => asiaData.Add(new AreaSeriesData { Y = p }));
            africaValues.ForEach(p => africaData.Add(new AreaSeriesData { Y = p }));
            europeValues.ForEach(p => europeData.Add(new AreaSeriesData { Y = p }));
            americaValues.ForEach(p => americaData.Add(new AreaSeriesData { Y = p }));
            oceaniaValues.ForEach(p => oceaniaData.Add(new AreaSeriesData { Y = p }));

            ViewData["asiaData"] = asiaData;
            ViewData["africaData"] = africaData;
            ViewData["europeData"] = europeData;
            ViewData["americaData"] = americaData;
            ViewData["oceaniaData"] = oceaniaData;

            return View();
        }
    }
}

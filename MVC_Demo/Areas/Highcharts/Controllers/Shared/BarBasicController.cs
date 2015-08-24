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
        public ActionResult BarBasic()
        {
            List<double?> year1800Values = new List<double?> { 107, 31, 635, 203, 2 };
            List<double?> year1900Values = new List<double?> { 133, 156, 947, 408, 6 };
            List<double?> year2008Values = new List<double?> { 973, 914, 4054, 732, 34 };

            List<BarSeriesData> year1800Data = new List<BarSeriesData>();
            List<BarSeriesData> year1900Data = new List<BarSeriesData>();
            List<BarSeriesData> year2008Data = new List<BarSeriesData>();

            year1800Values.ForEach(p => year1800Data.Add(new BarSeriesData { Y = p }));
            year1900Values.ForEach(p => year1900Data.Add(new BarSeriesData { Y = p }));
            year2008Values.ForEach(p => year2008Data.Add(new BarSeriesData { Y = p }));

            ViewData["year1800Data"] = year1800Data;
            ViewData["year1900Data"] = year1900Data;
            ViewData["year2008Data"] = year2008Data;

            return View();
        }

    }
}

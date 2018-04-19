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
        public ActionResult BarStacked()
        {
            List<double?> johnValues = new List<double?> { 5, 3, 4, 7, 2 };
            List<double?> janeValues = new List<double?> { 2, -2, -3, 2, 1 };
            List<double?> joeValues = new List<double?> { 3, 4, 4, -2, 5 };

            List<BarSeriesData> johnData = new List<BarSeriesData>();
            List<BarSeriesData> janeData = new List<BarSeriesData>();
            List<BarSeriesData> joeData = new List<BarSeriesData>();

            johnValues.ForEach(p => johnData.Add(new BarSeriesData { Y = p }));
            janeValues.ForEach(p => janeData.Add(new BarSeriesData { Y = p }));
            joeValues.ForEach(p => joeData.Add(new BarSeriesData { Y = p }));

            ViewData["johnData"] = johnData;
            ViewData["janeData"] = janeData;
            ViewData["joeData"] = joeData;

            return View();
        }
    }
}

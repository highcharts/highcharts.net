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
        public ActionResult AreaNegative()
        {
            List<double?> johnValues = new List<double?> { 5, 3, 4, 7, 2 };
            List<double?> janeValues = new List<double?> { 2, -2, -3, 2, 1 };
            List<double?> joeValues = new List<double?> { 3, 4, 4, -2, 5 };

            List<AreaSeriesData> johnData = new List<AreaSeriesData>();
            List<AreaSeriesData> janeData = new List<AreaSeriesData>();
            List<AreaSeriesData> joeData = new List<AreaSeriesData>();

            johnValues.ForEach(p => johnData.Add(new AreaSeriesData { Y = p }));
            janeValues.ForEach(p => janeData.Add(new AreaSeriesData { Y = p }));
            joeValues.ForEach(p => joeData.Add(new AreaSeriesData { Y = p }));

            ViewData["johnData"] = johnData;
            ViewData["janeData"] = janeData;
            ViewData["joeData"] = joeData;

            return View();
        }
    }
}

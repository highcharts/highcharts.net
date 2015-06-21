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
        public ActionResult AreaMissing()
        {
            List<double?> johnValues = new List<double?> {0, 1, 4, 4, 5, 2, 3, 7 };
            List<double?> janeValues = new List<double?> {1, 0, 3, null, 3, 1, 2, 1 };

            List<AreaSeriesData> johnData = new List<AreaSeriesData>();
            List<AreaSeriesData> janeData = new List<AreaSeriesData>();

            johnValues.ForEach(p => johnData.Add(new AreaSeriesData { Y = p }));
            janeValues.ForEach(p => janeData.Add(new AreaSeriesData { Y = p }));

            ViewData["johnData"] = johnData;
            ViewData["janeData"] = janeData;

            

            return View();
        }      
    }
}

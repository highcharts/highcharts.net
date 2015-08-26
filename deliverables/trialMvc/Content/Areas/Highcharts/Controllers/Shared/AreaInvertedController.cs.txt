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
        public ActionResult AreaInverted()
        {
            List<double?> johnValues = new List<double?> { 3, 4, 3, 5, 4, 10, 12 };
            List<double?> janeValues = new List<double?> { 1, 3, 4, 3, 3, 5, 4 };

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

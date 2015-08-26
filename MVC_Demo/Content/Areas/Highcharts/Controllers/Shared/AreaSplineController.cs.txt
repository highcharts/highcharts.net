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
        public ActionResult AreaSpline()
        {
            List<double?> johnValues = new List<double?> { 3, 4, 3, 5, 4, 10, 12 };
            List<double?> janeValues = new List<double?> { 1, 3, 4, 3, 3, 5, 4 };

            List<AreasplineSeriesData> johnData = new List<AreasplineSeriesData>();
            List<AreasplineSeriesData> janeData = new List<AreasplineSeriesData>();

            johnValues.ForEach(p => johnData.Add(new AreasplineSeriesData { Y = p }));
            janeValues.ForEach(p => janeData.Add(new AreasplineSeriesData { Y = p }));

            ViewData["johnData"] = johnData;
            ViewData["janeData"] = janeData;            

            return View();
        }      
    }
}

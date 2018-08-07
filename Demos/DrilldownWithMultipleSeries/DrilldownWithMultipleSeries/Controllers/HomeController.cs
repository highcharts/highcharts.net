using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;
using System.Web.Script.Serialization;

namespace DrilldownWithMultipleSeries.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ColumnSeriesData data = new ColumnSeriesData { Name = "Cars", Y = 4, Drilldown = "true" };
            List<ColumnSeriesData> things = new List<ColumnSeriesData> { data };
            ViewData["Things"] = things;


            ColumnSeriesData d1 = new ColumnSeriesData { Name = "Toyota", Y = 1};
            ColumnSeriesData d2 = new ColumnSeriesData { Name = "Volkswagen", Y = 2 };
            ColumnSeriesData d3 = new ColumnSeriesData { Name = "Opel", Y = 5 };
            ColumnSeries ds = new ColumnSeries { Name = "Cars", Color = "#bada55", Data = new List<ColumnSeriesData> { d1, d2, d3 } };

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            


            ViewData["ds"] = javaScriptSerializer.Serialize(ds);


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
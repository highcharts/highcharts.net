using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;

namespace CustomFieldsSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<PieSeriesData> pieData = new List<PieSeriesData>();

            pieData.Add(new PieSeriesData { Name = "FireFox", Y = 45.0 });
            pieData.Add(new PieSeriesData { Name = "IE", Y = 26.8 });
            pieData.Add(new PieSeriesData { Name = "Chrome", Y = 12.8, Sliced = true, Selected = true });
            pieData.Add(new PieSeriesData { Name = "Safari", Y = 8.5 });
            pieData.Add(new PieSeriesData { Name = "Opera", Y = 6.2 });
            pieData.Add(new PieSeriesData { Name = "Others", Y = 0.7 });

            pieData[0].CustomFields.Add("expected", 37);
            pieData[0].CustomFields.Add("result", "success!");

            ViewData["pieData"] = pieData;

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
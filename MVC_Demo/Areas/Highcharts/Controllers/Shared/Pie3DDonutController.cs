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
        public ActionResult Pie3DDonut()
        {
            List<PieSeriesData> pieData = new List<PieSeriesData>();

            pieData.Add(new PieSeriesData { Name = "Bananas", Y = 8 });
            pieData.Add(new PieSeriesData { Name = "Kiwi", Y = 3 });
            pieData.Add(new PieSeriesData { Name = "Mixed Nuts", Y = 1 });
            pieData.Add(new PieSeriesData { Name = "Oranges", Y = 6 });
            pieData.Add(new PieSeriesData { Name = "Apples", Y = 8 });
            pieData.Add(new PieSeriesData { Name = "Pears", Y = 4 });
            pieData.Add(new PieSeriesData { Name = "Cleamentines", Y = 4 });
            pieData.Add(new PieSeriesData { Name = "Reddish (bag)", Y = 1 });
            pieData.Add(new PieSeriesData { Name = "Grapes (bunch)", Y = 1 });

            ViewData["pieData"] = pieData;

            return View();
        }
    }
}

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
        public ActionResult Column3DNullValues()
        {
            List<double?> chartValues = new List<double?> { 2, 3, null, 4, 0, 5, 1, 4, 6, 3 };
            List<ColumnSeriesData> chartData = new List<ColumnSeriesData>();

            chartValues.ForEach(p => chartData.Add(new ColumnSeriesData { Y = p }));

            ViewData["chartData"] = chartData;          

            return View();
        }
    }
}

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
        public ActionResult Column3DInteractive()
        {
            List<double> chartValues = new List<double> { 29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 };
            List<ColumnSeriesData> chartData = new List<ColumnSeriesData>();

            chartValues.ForEach(p => chartData.Add(new ColumnSeriesData { Y = p }));

            ViewData["chartData"] = chartData;          

            return View();
        }
    }
}

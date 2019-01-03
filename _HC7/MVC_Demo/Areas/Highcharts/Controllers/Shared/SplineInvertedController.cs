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
        public ActionResult SplineInverted()
        {
            List<double> xValues = new List<double> { 0, 10, 20, 30, 40, 50, 60, 70, 80 };
            List<double> yValues = new List<double> { 15, -50, -56.5, -46.5, -22.1, -2.5, -27.7, -55.7, -76.5 };
            List<SplineSeriesData> tempData = new List<SplineSeriesData>();

            for (int i = 0; i < xValues.Count; i++)
            {
                SplineSeriesData seriesData = new SplineSeriesData { X = xValues[i], Y = yValues[i] };
                tempData.Add(seriesData);
            }

            ViewData["tempData"] = tempData;

            return View();
        }        
    }
}

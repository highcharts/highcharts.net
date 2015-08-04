using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highcharts.Web.Mvc;


namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult SplineSymbols()
        {
            List<double> tokyoValues = new List<double> { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 };
            List<double> londonValues = new List<double> { 3.9, 4.2, 5.7, 8.5, 11.9, 15.2, 17.0, 16.6, 14.2, 10.3, 6.6, 4.8 };
            List<SplineSeriesData> tokyoData = new List<SplineSeriesData>();
            List<SplineSeriesData> londonData = new List<SplineSeriesData>();

            foreach (double value in tokyoValues)
            {
                SplineSeriesData data = new SplineSeriesData();
                data.Y = value;
                if (value == 26.5)
                {
                    data.Marker.Symbol = "url(http://www.highcharts.com/demo/gfx/sun.png)";
                }

                tokyoData.Add(data);
            }

            foreach (double value in londonValues)
            {
                SplineSeriesData data = new SplineSeriesData();
                data.Y = value;
                if (value == 3.9)
                {
                    data.Marker.Symbol = "url(http://www.highcharts.com/demo/gfx/snow.png)";
                }

                londonData.Add(data);
            }

            ViewData["tokyoData"] = tokyoData;
            ViewData["londonData"] = londonData;

            return View();
        }   
    }
}

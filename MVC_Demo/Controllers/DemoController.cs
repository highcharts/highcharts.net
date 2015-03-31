using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/

        public ActionResult Index()
        {
            List<double> tokyoValues = new List<double> { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 };
            List<double> nyValues = new List<double> { -0.2, 0.8, 5.7, 11.3, 17.0, 22.0, 24.8, 24.1, 20.1, 14.1, 8.6, 2.5 };
            List<double> vikValues = new List<double> { -20, 11.8, 15.7, 21.3, 7.0, 21.0, 34.8, 25.1, 21.1, 15.1, 9.6, 1.5 };
            List<SeriesData> tokyoData = new List<SeriesData>();
            List<SeriesData> nyData = new List<SeriesData>();
            List<SeriesData> vikData = new List<SeriesData>();

            foreach (double value in tokyoValues)
            {
                tokyoData.Add(new SeriesData { Y = value });
            }
            foreach (double value in nyValues)
            {
                nyData.Add(new SeriesData { Y = value });
            }
            foreach (double value in vikValues)
            {
                vikData.Add(new SeriesData { Y = value });
            }

            ViewData["tokyoData"] = tokyoData;
            ViewData["nyData"] = nyData;
            ViewData["vikData"] = vikData;

            return View();
        }      

    }
}

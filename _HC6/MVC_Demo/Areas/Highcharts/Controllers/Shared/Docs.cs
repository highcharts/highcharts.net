﻿using Highsoft.Web.Mvc.Charts;
using System.Collections.Generic;
using System.Web.Mvc;


namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult ServerSideRequirements()
        {
            return View();
        }

        public ActionResult ClientSideRequirements()
        {
            return View();
        }

        //public ActionResult Installation()
        //{
        //    return View();
        //}

        public ActionResult VS()
        {
            return View();
        }

        public ActionResult IDE()
        {
            return View();
        }
        public ActionResult FirstChart0()
        {
            return View();
        }
        public ActionResult FirstChart1()
        {
            return View();
        }

        public ActionResult FirstChart2()
        {
            return View();
        }

        public ActionResult FirstChart3()
        {
            return View();
        }

        public ActionResult FirstChart4()
        {
            return View();
        }

        public ActionResult FirstChart5()
        {
            return View();
        }

        public ActionResult FirstChart6()
        {
            return View();
        }

        public ActionResult License()
        {
            return View();
        }
        public ActionResult WFFirstChart0()
        {
            return View();
        }
        public ActionResult WFFirstChart1()
        {
            return View();
        }

        public ActionResult WFFirstChart2()
        {
            return View();
        }

        public ActionResult WFFirstChart3()
        {
            return View();
        }

        public ActionResult WFFirstChart4()
        {
            return View();
        }

        public ActionResult WFFirstChart5()
        {
            return View();
        }

        public ActionResult Demo1()
        {
            List<double?> usaValues = new List<double?> {
                null, null, null, null, null, 6, 11, 32, 110, 235, 369, 640,
                1005, 1436, 2063, 3057, 4618, 6444, 9822, 15468, 20434, 24126,
                27387, 29459, 31056, 31982, 32040, 31233, 29224, 27342, 26662,
                26956, 27912, 28999, 28965, 27826, 25579, 25722, 24826, 24605,
                24304, 23464, 23708, 24099, 24357, 24237, 24401, 24344, 23586,
                22380, 21004, 17287, 14747, 13076, 12555, 12144, 11009, 10950,
                10871, 10824, 10577, 10527, 10475, 10421, 10358, 10295, 10104 };
            List<double?> russiaValues = new List<double?> {
                null, null, null, null, null, null, null, null, null, null,
                5, 25, 50, 120, 150, 200, 426, 660, 869, 1060, 1605, 2471, 3322,
                4238, 5221, 6129, 7089, 8339, 9399, 10538, 11643, 13092, 14478,
                15915, 17385, 19055, 21205, 23044, 25393, 27935, 30062, 32049,
                33952, 35804, 37431, 39197, 45000, 43000, 41000, 39000, 37000,
                35000, 33000, 31000, 29000, 27000, 25000, 24000, 23000, 22000,
                21000, 20000, 19000, 18000, 18000, 17000, 16000 };
            List<AreaSeriesData> usaData = new List<AreaSeriesData>();
            List<AreaSeriesData> russiaData = new List<AreaSeriesData>();

            usaValues.ForEach(p => usaData.Add(new AreaSeriesData { Y = p }));
            russiaValues.ForEach(p => russiaData.Add(new AreaSeriesData { Y = p }));

            ViewData["usaData"] = usaData;
            ViewData["russiaData"] = russiaData;

            return PartialView();
        }
    }
}


//namespace MVC_Demo.Areas.Highcharts.Controllers.Docs
//{
//    public class Docs : Controller
//    {
//        //
//        // GET: /Highcharts/ServerSideRequirements/

//        public ActionResult ServerSideRequirements()
//        {
//            return View();
//        }

//    }
//}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc;

namespace MVC_Demo.Areas.Highcharts.Controllers.Demo
{
    public class DemoController : Controller
    {
        public ActionResult Index(string id)
        {
            id = String.IsNullOrEmpty(id) ? id = "default.svg" : String.Format("{0}.png", id);

            ViewData["theme"] = id;
            return View();
        }

        public ActionResult Gallery(string demo)
        {
            ViewBag.Demo = demo;
            return View();
        }

        public ActionResult DarkUnica()
        {
            return RedirectToAction("Index", new { id = "dark-unica" });
        }

        public ActionResult LineBasic()
        {
            List<double> tokyoValues = new List<double> { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 };
            List<double> nyValues = new List<double> { -0.2, 0.8, 5.7, 11.3, 17.0, 22.0, 24.8, 24.1, 20.1, 14.1, 8.6, 2.5 };
            List<double> berlinValues = new List<double> { -0.9, 0.6, 3.5, 8.4, 13.5, 17.0, 18.6, 17.9, 14.3, 9.0, 3.9, 1.0 };
            List<double> londonValues = new List<double> { 3.9, 4.2, 5.7, 8.5, 11.9, 15.2, 17.0, 16.6, 14.2, 10.3, 6.6, 4.8 };
            List<LineSeriesData> tokyoData = new List<LineSeriesData>();
            List<LineSeriesData> nyData = new List<LineSeriesData>();
            List<LineSeriesData> berlinData = new List<LineSeriesData>();
            List<LineSeriesData> londonData = new List<LineSeriesData>();

            foreach (double value in tokyoValues)
            {
                tokyoData.Add(new LineSeriesData { Y = value });
            }
            foreach (double value in nyValues)
            {
                nyData.Add(new LineSeriesData { Y = value });
            }
            foreach (double value in berlinValues)
            {
                berlinData.Add(new LineSeriesData { Y = value });
            }
            foreach (double value in londonValues)
            {
                londonData.Add(new LineSeriesData { Y = value });
            }


            ViewData["tokyoData"] = tokyoData;
            ViewData["nyData"] = nyData;
            ViewData["berlinData"] = berlinData;
            ViewData["londonData"] = londonData;

            return View();
        }

        public ActionResult LineLabels()
        {
            List<double> tokyoValues = new List<double> { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 };
            List<double> nyValues = new List<double> { -0.2, 0.8, 5.7, 11.3, 17.0, 22.0, 24.8, 24.1, 20.1, 14.1, 8.6, 2.5 };
            List<double> berlinValues = new List<double> { -0.9, 0.6, 3.5, 8.4, 13.5, 17.0, 18.6, 17.9, 14.3, 9.0, 3.9, 1.0 };
            List<double> londonValues = new List<double> { 3.9, 4.2, 5.7, 8.5, 11.9, 15.2, 17.0, 16.6, 14.2, 10.3, 6.6, 4.8 };
            List<LineSeriesData> tokyoData = new List<LineSeriesData>();
            List<LineSeriesData> nyData = new List<LineSeriesData>();
            List<LineSeriesData> berlinData = new List<LineSeriesData>();
            List<LineSeriesData> londonData = new List<LineSeriesData>();

            foreach (double value in tokyoValues)
            {
                tokyoData.Add(new LineSeriesData { Y = value });
            }
            foreach (double value in nyValues)
            {
                nyData.Add(new LineSeriesData { Y = value });
            }
            foreach (double value in berlinValues)
            {
                berlinData.Add(new LineSeriesData { Y = value });
            }
            foreach (double value in londonValues)
            {
                londonData.Add(new LineSeriesData { Y = value });
            }


            ViewData["tokyoData"] = tokyoData;
            ViewData["nyData"] = nyData;
            ViewData["berlinData"] = berlinData;
            ViewData["londonData"] = londonData;

            return View();
        }

        public ActionResult LineLog()
        {
            List<double> logValues = new List<double> { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            List<LineSeriesData> logData = new List<LineSeriesData>();

            logValues.ForEach(p => logData.Add(new LineSeriesData { Y = p }));

            ViewData["logData"] = logData;

            return View();
        }

        public ActionResult SplineInverted()
        {
            List<double> logValues = new List<double> { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            List<LineSeriesData> logData = new List<LineSeriesData>();

            logValues.ForEach(p => logData.Add(new LineSeriesData { Y = p }));

            ViewData["logData"] = logData;

            return View();
        } 

    }
}
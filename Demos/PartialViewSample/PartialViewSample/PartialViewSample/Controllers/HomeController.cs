﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;

namespace PartialViewSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<double> tokyoValues = new List<double> { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 };
            List<double> nyValues = new List<double> { -0.2, 0.8, 5.7, 11.3, 17.0, 22.0, 24.8, 24.1, 20.1, 14.1, 8.6, 2.5 };
            List<double> berlinValues = new List<double> { -0.9, 0.6, 3.5, 8.4, 13.5, 17.0, 18.6, 17.9, 14.3, 9.0, 3.9, 1.0 };
            List<double> londonValues = new List<double> { 3.9, 4.2, 5.7, 8.5, 11.9, 15.2, 17.0, 16.6, 14.2, 10.3, 6.6, 4.8 };
            List<LineSeriesData> tokyoData = new List<LineSeriesData>();
            List<LineSeriesData> nyData = new List<LineSeriesData>();
            List<LineSeriesData> berlinData = new List<LineSeriesData>();
            List<LineSeriesData> londonData = new List<LineSeriesData>();

            tokyoValues.ForEach(p => tokyoData.Add(new LineSeriesData { Y = p }));
            nyValues.ForEach(p => nyData.Add(new LineSeriesData { Y = p }));
            berlinValues.ForEach(p => berlinData.Add(new LineSeriesData { Y = p }));
            londonValues.ForEach(p => londonData.Add(new LineSeriesData { Y = p }));

            ViewData["tokyo"] = tokyoData;
            ViewData["ny"] = nyData;
            ViewData["berlin"] = berlinData;
            ViewData["london"] = londonData;

            

            return View();
        }

        public ActionResult Sample()
        {
            List<double> tokyoValues = new List<double> { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 };
            List<double> nyValues = new List<double> { -0.2, 0.8, 5.7, 11.3, 17.0, 22.0, 24.8, 24.1, 20.1, 14.1, 8.6, 2.5 };
            List<double> berlinValues = new List<double> { -0.9, 0.6, 3.5, 8.4, 13.5, 17.0, 18.6, 17.9, 14.3, 9.0, 3.9, 1.0 };
            List<double> londonValues = new List<double> { 3.9, 4.2, 5.7, 8.5, 11.9, 15.2, 17.0, 16.6, 14.2, 10.3, 6.6, 4.8 };
            List<LineSeriesData> tokyoData = new List<LineSeriesData>();
            List<LineSeriesData> nyData = new List<LineSeriesData>();
            List<LineSeriesData> berlinData = new List<LineSeriesData>();
            List<LineSeriesData> londonData = new List<LineSeriesData>();

            tokyoValues.ForEach(p => tokyoData.Add(new LineSeriesData { Y = p }));
            nyValues.ForEach(p => nyData.Add(new LineSeriesData { Y = p }));
            berlinValues.ForEach(p => berlinData.Add(new LineSeriesData { Y = p }));
            londonValues.ForEach(p => londonData.Add(new LineSeriesData { Y = p }));

            ViewData["tokyo2"] = tokyoData;
            ViewData["ny2"] = nyData;
            ViewData["berlin2"] = berlinData;
            ViewData["london2"] = londonData;

            List<ColumnSeriesData> tokyoDataC = new List<ColumnSeriesData>();
            tokyoValues.ForEach(p => tokyoDataC.Add(new ColumnSeriesData { Y = p }));
            ViewData["tokyoC"] = tokyoData;

            return PartialView();
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
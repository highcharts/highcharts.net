﻿using Highsoft.Web.Mvc.Stocks;
using HighstockMVC.DataSource;
using HighstockMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HighstockMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<AreaSeriesData> appleData = new List<AreaSeriesData>();

            foreach (CompanyData data in DataReceiver.GetJSON("Apple"))
            {
                appleData.Add(new AreaSeriesData
                {
                    X = Convert.ToDouble(data.Date),
                    Y = Convert.ToDouble(data.Value)
                });
            }

            ViewBag.AppleData = appleData.OrderBy(o => o.X).ToList();

            object fillColor = new
            {
                linearGradient = new { x1 = 0, y1 = 0, x2 = 0, y2 = 1 },
                stops = new List<object> { new List<object> { "0", "#7cb5ec" }, new List<object> { "1", "rgba(124,181,236,0)" } }
            };

            ViewBag.fillColor = fillColor;

            return View(ViewBag);
        }
    }
}
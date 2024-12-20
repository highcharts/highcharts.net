﻿using Highsoft.Web.Mvc.Stocks;
using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Areas.Highstock.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult Ohlc()
        {
            List<OhlcSeriesData> appleData = new List<OhlcSeriesData>();
            List<LineSeriesData> navigatorData = new List<LineSeriesData>();

            foreach (var data in DataReceiver.GetCandlestickData())
            {
                appleData.Add(new OhlcSeriesData
                {
                    X = Convert.ToDouble(data.Date),
                    High = Convert.ToDouble(data.High),
                    Low = Convert.ToDouble(data.Low),
                    Open = Convert.ToDouble(data.Open),
                    Close = Convert.ToDouble(data.Close)
                });

                navigatorData.Add(new LineSeriesData
                {
                    X = Convert.ToDouble(data.Date),
                    Y = Convert.ToDouble(data.Close)
                });
            }

            ViewBag.AppleData = appleData.OrderBy(o => o.X).ToList();
            ViewBag.NavigatorData = navigatorData.OrderBy(o => o.X).ToList();

            return View(ViewBag);
        }

    }
}

﻿using Highsoft.Web.Mvc.Stocks;
using MVC_Demo.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Areas.Highstock.Controllers.Shared
{
    

    public partial class SharedController : Controller
    {
        public ActionResult CandleStick()
        {
            List<CandleStickSeriesData> appleData = new List<CandleStickSeriesData>();
            List<AreasplineSeriesData> navigatorData = new List<AreasplineSeriesData>();

            foreach (CandlestickVolume data in DataReceiver.GetJSONCandlestickVolumes())
            {
                appleData.Add(new CandleStickSeriesData
                {
                    X = Convert.ToDouble(data.Date),
                    High = Convert.ToDouble(data.High),
                    Low = Convert.ToDouble(data.Low),
                    Open = Convert.ToDouble(data.Open),
                    Close = Convert.ToDouble(data.Close)
                });

                navigatorData.Add(new AreasplineSeriesData
                {
                    X = Convert.ToDouble(data.Date),
                    Y = Convert.ToDouble(data.Open)
                });
            }

            ViewBag.AppleData = appleData.OrderBy(o => o.X).ToList();
            ViewBag.NavigatorData = navigatorData.OrderBy(o => o.X).ToList();

            return View(ViewBag);
        }
    }
}
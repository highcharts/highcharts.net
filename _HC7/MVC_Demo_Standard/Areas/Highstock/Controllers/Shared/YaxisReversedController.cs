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
        public ActionResult YaxisReversed()
        {   
            List<AreaSeriesData> appleData = new List<AreaSeriesData>();

                foreach (PointData data in DataReceiver.GetMicrosoftData())
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
                linearGradient = new { x1 = 0, y1 = 1, x2 = 0, y2 = 0 },
                stops = new List<object> { new List<object> { "0", "#7cb5ec" }, new List<object> { "1", "rgba(124,181,236,0)" } }
            };

            ViewBag.fillColor = fillColor;

            return View(ViewBag);
        }       

    }
}

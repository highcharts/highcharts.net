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
        public ActionResult Column()
        {   
            List<ColumnSeriesData> appleData = new List<ColumnSeriesData>();

            foreach (PointData data in DataReceiver.GetAppleData())
                {
                    appleData.Add(new ColumnSeriesData
                    {
                        X = Convert.ToDouble(data.Date),
                        Y = Convert.ToDouble(data.Value)
                    });
                }

            ViewBag.AppleData = appleData.OrderBy(o => o.X).ToList();

            return View(ViewBag);
        }       

    }
}

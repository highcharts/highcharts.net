﻿using Highsoft.Web.Mvc.Stocks;
using MVC_Highstock_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_Highstock_Demo.Areas.Highstock.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult IntradayAreaBreaks()
        {
            List<AreaSeriesData> intradayData = new List<AreaSeriesData>();

            using (var db = new HighstockDataEntities())
            {
                foreach (Intraday data in db.Intradays)
                {
                        intradayData.Add(new AreaSeriesData
                            {                                
                                Y = Convert.ToDouble(data.High),
                                X = Convert.ToDouble(data.Date)
                            }
                        );
                }
            }

            ViewBag.IntradayData = intradayData.OrderBy(o => o.X).ToList();

            return View(ViewBag);
        }      

    }
}
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
        public ActionResult FlagsPlacement()
        {
            List<LineSeriesData> currencyData = new List<LineSeriesData>();
            double? lastDate;
            int days = 86400000; // milliseconds in a day

            using (var db = new ChartDataEntities())
            {
                foreach (Flag flag in db.Flags)
                {
                    currencyData.Add(new LineSeriesData
                    {
                        Y = Convert.ToDouble(flag.Value),
                        X = Convert.ToDouble(flag.Date)
                    }
                    );
                }

                lastDate = db.Flags.ToList().Last().Date;
            }

            ViewBag.CurrencyData = currencyData.OrderBy(o => o.X).ToList();


            List<FlagsSeriesData> onSeriesData = new List<FlagsSeriesData>();
            onSeriesData.Add(new FlagsSeriesData
                            {
                                X = lastDate - 5 * days,
                                Title = "On Series 1"                                
                            }
            );
            onSeriesData.Add(new FlagsSeriesData
            {
                X = lastDate - 10 * days,
                Title = "On Series 2"
            }
           );

            List<FlagsSeriesData> onAxisData = new List<FlagsSeriesData>();
            onAxisData.Add(new FlagsSeriesData
            {
                X = lastDate - 5 * days,
                Title = "On Axis 1"
            }
            );
            onAxisData.Add(new FlagsSeriesData
            {
                X = lastDate - 10 * days,
                Title = "On Axis 2"
            }
           );

          

            ViewBag.OnSeriesData = onSeriesData;
            ViewBag.OnAxisData = onAxisData;

            return View(ViewBag);
        } 

    }
}
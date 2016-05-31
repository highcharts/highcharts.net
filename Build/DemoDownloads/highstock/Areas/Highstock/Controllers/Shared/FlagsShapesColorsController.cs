using Highsoft.Web.Mvc.Stocks;
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
        public ActionResult FlagsShapesColors()
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


            List<FlagsSeriesData> aData = new List<FlagsSeriesData>();
            aData.Add(new FlagsSeriesData
                            {
                                X = lastDate - 5 * days,
                                Title = "A"                                
                            }
            );
            aData.Add(new FlagsSeriesData
                            {
                                X = lastDate - 20 * days,
                                Title = "A"
                            }
           );

            List<FlagsSeriesData> bData = new List<FlagsSeriesData>();
            bData.Add(new FlagsSeriesData
            {
                X = lastDate - 10 * days,
                Title = "A"
            }
            );
            bData.Add(new FlagsSeriesData
            {
                X = lastDate - 15 * days,
                Title = "A"
            }
           );

            List<FlagsSeriesData> cData = new List<FlagsSeriesData>();
            cData.Add(new FlagsSeriesData
            {
                X = lastDate - 13 * days,
                Title = "A"
            }
            );
            cData.Add(new FlagsSeriesData
            {
                X = lastDate - 23 * days,
                Title = "A"
            }
           );

            ViewBag.AData = aData;
            ViewBag.BData = bData;
            ViewBag.CData = cData;


            return View(ViewBag);
        } 

    }
}

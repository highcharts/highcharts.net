using Highsoft.Web.Mvc.Stocks;
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
        public ActionResult IntradayCandlestick()
        {
            List<CandleStickSeriesData> intradayData = new List<CandleStickSeriesData>();

            using (var db = new HighstockDataEntities())
            {
                foreach (Intraday data in db.Intradays)
                {
                    intradayData.Add(new CandleStickSeriesData
                            {
                                Open = Convert.ToDouble(data.Open),
                                Close = Convert.ToDouble(data.Close),
                                High = Convert.ToDouble(data.High),
                                Low = Convert.ToDouble(data.Low),
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

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
        public ActionResult IntradayCandlestick()
        {
            List<CandleStickSeriesData> intradayData = new List<CandleStickSeriesData>();
            List<LineSeriesData> navigatorData = new List<LineSeriesData>();

            foreach (Intraday data in GetList_Intradays())
            {
                intradayData.Add(new CandleStickSeriesData
                {
                    Open = Convert.ToDouble(data.Open),
                    Close = Convert.ToDouble(data.Close),
                    High = Convert.ToDouble(data.High),
                    Low = Convert.ToDouble(data.Low),
                    X = Convert.ToDouble(data.Date)
                });
            }
            
            foreach (var item in intradayData)
                navigatorData.Add(new LineSeriesData() { Y = item.Close, X = item.X });

            ViewBag.IntradayData = intradayData.OrderBy(o => o.X).ToList();
            ViewBag.NavigatorData = navigatorData.OrderBy(o => o.X).ToList();
            return View(ViewBag);
        }

    }
}

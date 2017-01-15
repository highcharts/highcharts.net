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
        public ActionResult IntradayBreaks()
        {
            List<AreaSeriesData> intradayData = new List<AreaSeriesData>();

                foreach (Intraday data in GetList_Intradays())
                {
                        intradayData.Add(new AreaSeriesData
                            {                                
                                Y = Convert.ToDouble(data.High),
                                X = Convert.ToDouble(data.Date)
                            }
                        );
                }

            ViewBag.IntradayData = intradayData.OrderBy(o => o.X).ToList();

            ViewBag.From = DateToUTC(new DateTime(2011, 9, 6, 16, 0, 0));
            ViewBag.To = DateToUTC(new DateTime(2011, 9, 7, 8, 0, 0));

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

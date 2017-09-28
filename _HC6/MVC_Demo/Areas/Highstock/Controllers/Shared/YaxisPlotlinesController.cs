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
        public ActionResult YaxisPlotlines()
        {
            List<LineSeriesData> currencyData = new List<LineSeriesData>();
            double? minRate = 0;
            double? maxRate = 1;

            List<FlagData> flags = DataReceiver.GetJSONFlags();
            foreach (FlagData flag in flags)
            {
                currencyData.Add(new LineSeriesData
                {
                    Y = Convert.ToDouble(flag.Value),
                    X = Convert.ToDouble(flag.Date)
                }
                );
            }

            minRate = flags.Min(f => f.Value);
            maxRate = flags.Max(f => f.Value);

            ViewBag.Min = minRate;
            ViewBag.Max = maxRate;
            ViewBag.CurrencyData = currencyData.OrderBy(o => o.X).ToList();

            return View(ViewBag);
        }
    }
}

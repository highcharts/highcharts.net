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
        public ActionResult Arearange()
        {
            List<ArearangeSeriesData> appleData = new List<ArearangeSeriesData>();
            List<LineSeriesData> navigatorData = new List<LineSeriesData>();

            foreach (RangeData data in DataReceiver.GetJSONRange())//("Apple"))
            {
                appleData.Add(new ArearangeSeriesData
                {
                    X = Convert.ToDouble(data.X),
                    High = Convert.ToDouble(data.High),
                    Low = Convert.ToDouble(data.Low)
                });

                navigatorData.Add(new LineSeriesData
                {
                    X = Convert.ToDouble(data.X),
                    Y = Convert.ToDouble(data.High)
                });
            }

            ViewBag.AppleData = appleData.OrderBy(o => o.X).ToList();
            ViewBag.NavigatorData = navigatorData.OrderBy(o => o.X).ToList();

            return View(ViewBag);
        }

    }
}

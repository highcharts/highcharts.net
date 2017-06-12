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
        public ActionResult Areasplinerange()
        {
            List<AreasplinerangeSeriesData> appleData = new List<AreasplinerangeSeriesData>();
            List<LineSeriesData> navigatorData = new List<LineSeriesData>();

            foreach (RangeData data in DataReceiver.GetJSONRange())
            {
                appleData.Add(new AreasplinerangeSeriesData
                {
                    X = data.X,
                    High = data.High,
                    Low = data.Low
                });

                navigatorData.Add(new LineSeriesData
                {
                    X = data.X,
                    Y = data.Low
                });
            }

            ViewBag.AppleData = appleData.OrderBy(o => o.X).ToList();
            ViewBag.NavigatorData = navigatorData.OrderBy(o => o.X).ToList();

            return View(ViewBag);
        }

    }
}

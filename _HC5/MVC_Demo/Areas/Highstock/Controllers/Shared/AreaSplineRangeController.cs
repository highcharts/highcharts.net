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

            foreach (CompanyData data in DataReceiver.GetJSON("Apple"))
            {
                appleData.Add(new AreasplinerangeSeriesData
                {
                    X = Convert.ToDouble(data.Date),
                    High = Convert.ToDouble(data.Value),
                    Low = Convert.ToDouble(data.Value - new Random().Next(15))
                });

                navigatorData.Add(new LineSeriesData
                {
                    X = Convert.ToDouble(data.Date),
                    Y = Convert.ToDouble(data.Value)
                });
            }

            ViewBag.AppleData = appleData.OrderBy(o => o.X).ToList();
            ViewBag.NavigatorData = navigatorData.OrderBy(o => o.X).ToList();

            return View(ViewBag);
        }

    }
}

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
        public ActionResult NavigatorDisabled()
        {
            List<LineSeriesData> appleData = new List<LineSeriesData>();

            foreach (PointData data in DataReceiver.GetMicrosoftData())
            {
                appleData.Add(new LineSeriesData
                {
                    X = Convert.ToDouble(data.Date),
                    Y = Convert.ToDouble(data.Value)
                });
            }


            ViewBag.AppleData = appleData.OrderBy(o => o.X).ToList();

            return View(ViewBag);
        }

    }
}

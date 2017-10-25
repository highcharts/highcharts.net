using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;
using MVC_Demo.Models;

namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult LineBoost()
        {
            List<LineSeriesData> list = new List<LineSeriesData>();

            foreach (var item in DataReceiver.GetDataForLineBoost(400000))
                list.Add(new LineSeriesData { X = item.X, Y = item.Y });

            ViewData["data"] = list;

            return View();
        }

    }
}

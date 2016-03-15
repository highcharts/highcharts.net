using Highsoft.Web.Mvc.Stocks;
using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MVC_Demo.Areas.Highstock.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult DataGrouping()
        {
            List<LineSeriesData> temperatureData = new List<LineSeriesData>();

            using (var db = new HighstockDataEntities())
            {
                foreach (DataGrouping data in db.DataGroupings)
                {
                    temperatureData.Add(new LineSeriesData
                    {                       
                        Y = Convert.ToDouble(data.Value)
                    });
                }
            }

            ViewBag.TemperatureData = temperatureData.OrderBy(o => o.Y).ToList();

            return View(ViewBag);
        }
    }
}

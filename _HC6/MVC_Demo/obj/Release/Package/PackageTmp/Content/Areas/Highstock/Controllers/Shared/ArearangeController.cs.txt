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

            using (var db = new HighstockDataEntities())
            {
                foreach (AppleData data in db.AppleDatas)
                {
                    appleData.Add(new ArearangeSeriesData
                    {
                        X = Convert.ToDouble(data.Date),
                        High = Convert.ToDouble(data.Value),
                        Low = Convert.ToDouble(data.Value - new Random().Next(15))
                    });
                }
            }

            ViewBag.AppleData = appleData.OrderBy(o => o.X).ToList();

            return View(ViewBag);
        }       

    }
}

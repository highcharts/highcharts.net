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
        public ActionResult YAxisReversed()
        {   
            List<AreaSeriesData> appleData = new List<AreaSeriesData>();

            using (var db = new HighstockDataEntities())
            {
                foreach (AppleData data in db.AppleDatas)
                {
                    appleData.Add(new AreaSeriesData
                    {
                        X = Convert.ToDouble(data.Date),
                        Y = Convert.ToDouble(data.Value)
                    });
                }
            }

            ViewBag.AppleData = appleData.OrderBy(o => o.X).ToList();

            return View(ViewBag);
        }       

    }
}

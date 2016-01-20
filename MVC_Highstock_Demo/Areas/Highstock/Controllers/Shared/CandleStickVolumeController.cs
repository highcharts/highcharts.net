using Highsoft.Web.Mvc.Stocks;
using MVC_Highstock_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_Highstock_Demo.Areas.Highstock.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult CandleStickVolume()
        {
            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://www.highcharts.com/samples/data/jsonp.php?filename=aapl-ohlcv.json");
            }

            json = json.Substring(json.IndexOf('[') + 1);
            json = json.Substring(json.IndexOf('[') + 1);

            while (json.Length > 10)
            {
                string entity = json.Substring(0, json.IndexOf("]") - 1);

                json = json.
            }
            


            using (var db = new HighstockDataEntities())
            {
               //json.json = json

                //db.CandlestickVolumes.Add(
                //    new CandlestickVolume
                //    {
                //    }
                //);
            }

            

            return View();
        }

    }
}

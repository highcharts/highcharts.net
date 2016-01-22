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

            using (var db = new HighstockDataEntities())
            {
                while (true)
                {
                    if (json.IndexOf('[') == -1) 
                        break;
                
                    string entity = json.Substring(0, json.IndexOf(']'));
                    string[] values = entity.Split(',');

                    db.CandlestickVolumes.Add(
                        new CandlestickVolume
                        {
                             Date = Convert.ToInt32( values[0] ),
                             Open = Convert.ToInt32(values[1]),
                             High = Convert.ToInt32(values[2]),
                             Low = Convert.ToInt32(values[3]),
                             Close = Convert.ToInt32(values[4]),
                             
                        }
                    );

                    

                    json = json.Substring(json.IndexOf('[') + 1);
                }

                db.SaveChanges();
            }

            
               //json.json = json

                //db.CandlestickVolumes.Add(
                //    new CandlestickVolume
                //    {
                //    }
                //);
            //}

            

            return View();
        }

    }
}

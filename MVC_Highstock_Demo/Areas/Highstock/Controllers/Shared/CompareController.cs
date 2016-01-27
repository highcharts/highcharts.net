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
        public ActionResult Compare()
        {
            //CompareJsonDataToDatabase();
            
            //ViewData["appleData"] = appleData;

            return View();
        }

        private void CompareJsonDataToDatabase()
        {
            string[] urls = {
                                "https://www.highcharts.com/samples/data/jsonp.php?filename=msft-c.json&callback=",
                                "https://www.highcharts.com/samples/data/jsonp.php?filename=aapl-c.json&callback=",
                                "https://www.highcharts.com/samples/data/jsonp.php?filename=goog-c.json&callback="
                             };

            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(urls[0]);
            }

            json = json.Substring(json.IndexOf('[') + 1);
            json = json.Substring(json.IndexOf('[') + 1);

            using (var db = new HighstockDataEntities1())
            {
                while (true)
                {
                    if (json.IndexOf('[') == -1)
                        break;

                    string entity = json.Substring(0, json.IndexOf(']'));
                    string[] values = entity.Split(',');

                    db.AppleDatas.Add(
                        new AppleData
                        {
                            Date = Convert.ToDouble(values[0]),
                            Value = Convert.ToDouble(values[1])
                        }
                    );

                    json = json.Substring(json.IndexOf('[') + 1);
                }


                db.SaveChanges();
            }
        }

    }
}

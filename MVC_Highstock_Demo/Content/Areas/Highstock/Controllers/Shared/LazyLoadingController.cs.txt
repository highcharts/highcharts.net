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
        List<double?> data = new List<double?>();

        public ActionResult LazyLoading()
        {
            LazyLoading_JsonToArray();
            List<LineSeriesData> temperatureData = new List<LineSeriesData>();  
            
            foreach (double? value in data)
            {
                temperatureData.Add(new LineSeriesData
                {                   
                    Y = value
                });
            }

            ViewBag.TemperatureData = temperatureData.OrderBy(o => o.X).ToList();
            return View(ViewBag);
        }

        private void LazyLoading_JsonToArray()
        {
            string url = "https://www.highcharts.com/samples/data/jsonp.php?filename=large-dataset.json";
            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(url);
            }

            json = json.Substring(json.IndexOf('[') + 1);

            using (var db = new HighstockDataEntities())
            {
                while (true)
                {
                    double? value = null;
                    if (json.IndexOf(',') == -1)
                        break;

                   string entity = json.Substring(0, json.IndexOf(','));

                   if (entity != "null") 
                       value = Convert.ToDouble(entity);

                   data.Add(value);                      

                    json = json.Substring(json.IndexOf(',') + 1);
                }
            }
        }


    }
}

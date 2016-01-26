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
            List<CandleStickSeriesData> appleData = new List<CandleStickSeriesData>();
            List<ColumnSeriesData> volumeData = new List<ColumnSeriesData>();

            using (var db = new HighstockDataEntities())
            {
                foreach (CandlestickVolume volume in db.CandlestickVolumes)
                {
                    appleData.Add(new CandleStickSeriesData
                                        {
                                            Open = Convert.ToDouble(volume.Open),
                                            High = Convert.ToDouble(volume.High),
                                            Low = Convert.ToDouble(volume.Low),
                                            Close = Convert.ToDouble(volume.Close),
                                            X = Convert.ToDouble(volume.Date)
                                        }
                                 );
                }
            }

            ViewBag.AppleData = appleData;

            return View(ViewBag);
        }

        private void JsonDataToDatabase()
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
                            Date = Convert.ToDecimal(values[0]),
                            Open = Convert.ToDecimal(values[1]),
                            High = Convert.ToDecimal(values[2]),
                            Low = Convert.ToDecimal(values[3]),
                            Close = Convert.ToDecimal(values[4]),
                            Volume = Convert.ToDecimal(values[5]),
                        }
                    );

                    json = json.Substring(json.IndexOf('[') + 1);
                }


                db.SaveChanges();
            }
        }

    }
}

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
            //JsonDataToDatabase();
            
            List<CandleStickSeriesData> appleData = new List<CandleStickSeriesData>();
            List<ColumnSeriesData> volumeData = new List<ColumnSeriesData>();

            using (var db = new HighstockDataEntities1())
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


                    volumeData.Add(new ColumnSeriesData
                                        {
                                            X = Convert.ToDouble(volume.Date),
                                            Y = Convert.ToDouble(volume.Volume)
                                        }
                                );
                }
            }

            ViewBag.AppleData = appleData.OrderBy(o => o.X).ToList();
            ViewBag.VolumeData = volumeData.OrderBy(o => o.X).ToList();

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

            using (var db = new HighstockDataEntities1())
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
                            Date = Convert.ToDouble(values[0]),
                            Open = Convert.ToDouble(values[1]),
                            High = Convert.ToDouble(values[2]),
                            Low = Convert.ToDouble(values[3]),
                            Close = Convert.ToDouble(values[4]),
                            Volume = Convert.ToDouble(values[5]),
                        }
                    );

                    json = json.Substring(json.IndexOf('[') + 1);
                }


                db.SaveChanges();
            }
        }

    }
}

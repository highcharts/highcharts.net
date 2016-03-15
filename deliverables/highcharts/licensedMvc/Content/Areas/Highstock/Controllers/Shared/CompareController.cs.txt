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
        public ActionResult Compare()
        {   
            List<LineSeriesData> appleData = new List<LineSeriesData>();
            List<LineSeriesData> msftData = new List<LineSeriesData>();
            List<LineSeriesData> googData = new List<LineSeriesData>();

            using (var db = new HighstockDataEntities())
            {
                foreach (AppleData data in db.AppleDatas)
                {
                    appleData.Add(new LineSeriesData
                    {
                        X = Convert.ToDouble(data.Date),
                        Y = Convert.ToDouble(data.Value)
                    });                   
                }

                foreach (MicrosoftData data in db.MicrosoftDatas)
                {
                    msftData.Add(new LineSeriesData
                    {
                        X = Convert.ToDouble(data.Date),
                        Y = Convert.ToDouble(data.Value)
                    });
                }

                foreach (GoogleData data in db.GoogleDatas)
                {
                    googData.Add(new LineSeriesData
                    {
                        X = Convert.ToDouble(data.Date),
                        Y = Convert.ToDouble(data.Value)
                    });
                }
            }

            ViewBag.AppleData = appleData.OrderBy(o => o.X).ToList();
            ViewBag.MsftData = msftData.OrderBy(o => o.X).ToList();
            ViewBag.GoogData = googData.OrderBy(o => o.X).ToList();

            return View(ViewBag);
        }

        private void CompareJsonDataToDatabase_Apple()
        {
            string url = "https://www.highcharts.com/samples/data/jsonp.php?filename=aapl-c.json&callback=";                                
            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(url);
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

        private void CompareJsonDataToDatabase_Microsoft()
        {
            string url = "https://www.highcharts.com/samples/data/jsonp.php?filename=msft-c.json&callback=";
            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(url);
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

                    db.MicrosoftDatas.Add(
                        new MicrosoftData
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


        private void CompareJsonDataToDatabase_Google()
        {
            string url = "https://www.highcharts.com/samples/data/jsonp.php?filename=goog-c.json&callback=";
            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(url);
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

                    db.GoogleDatas.Add(
                        new GoogleData
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

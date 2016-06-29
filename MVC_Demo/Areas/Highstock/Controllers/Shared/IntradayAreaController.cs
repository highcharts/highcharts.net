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
        public ActionResult IntradayArea()
        {
            List<AreaSeriesData> intradayData = new List<AreaSeriesData>();

                foreach (Intraday data in GetList_Intradays())
                {
                        intradayData.Add(new AreaSeriesData
                            {                                
                                Y = Convert.ToDouble(data.High),
                                X = Convert.ToDouble(data.Date)
                            }
                        );
                }

            ViewBag.IntradayData = intradayData.OrderBy(o => o.X).ToList();

            return View(ViewBag);
        }

        private List<Intraday> GetList_Intradays()
        {
            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://www.highcharts.com/samples/data/jsonp.php?filename=new-intraday.json&callback=?");
            }

            json = json.Substring(json.IndexOf('[') + 1);
            json = json.Substring(json.IndexOf('[') + 1);

            List<Intraday> Intradays = new List<Intraday>();
                while (true)
                {
                    if (json.IndexOf('[') == -1)
                        break;

                    string entity = json.Substring(0, json.IndexOf(']'));
                    string[] values = entity.Split(',');

                    Intradays.Add(
                        new Intraday
                        {
                            Date = Convert.ToDouble(values[0]),
                            Open = Convert.ToDouble(values[1]),
                            High = Convert.ToDouble(values[2]),
                            Low = Convert.ToDouble(values[3]),
                            Close = Convert.ToDouble(values[4])
                        }
                    );

                    json = json.Substring(json.IndexOf('[') + 1);
                }


            return Intradays;
        }

        private void IntradayArea_JsonDataToDatabase()
        {
            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://www.highcharts.com/samples/data/jsonp.php?filename=new-intraday.json&callback=?");
            }

            json = json.Substring(json.IndexOf('[') + 1);
            json = json.Substring(json.IndexOf('[') + 1);

            using (var db = new ChartDataEntities())
            {
                while (true)
                {
                    if (json.IndexOf('[') == -1)
                        break;

                    string entity = json.Substring(0, json.IndexOf(']'));
                    string[] values = entity.Split(',');

                    db.Intradays.Add(
                        new Intraday
                        {
                            Date = Convert.ToDouble(values[0]),
                            Open = Convert.ToDouble(values[1]),
                            High = Convert.ToDouble(values[2]),
                            Low = Convert.ToDouble(values[3]),
                            Close = Convert.ToDouble(values[4])
                        }
                    );

                    json = json.Substring(json.IndexOf('[') + 1);
                }


                db.SaveChanges();
            }
        }

    }
}

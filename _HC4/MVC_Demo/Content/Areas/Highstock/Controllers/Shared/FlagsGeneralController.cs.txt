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
        public ActionResult FlagsGeneral()
        {
            List<LineSeriesData> currencyData = new List<LineSeriesData>();

            using (var db = new HighstockDataEntities())
            {
                foreach (Flag flag in db.Flags)
                {
                    currencyData.Add(new LineSeriesData
                    {
                        Y = Convert.ToDouble(flag.Value),
                        X = Convert.ToDouble(flag.Date)
                    }
                    );
                }
            }

            ViewBag.CurrencyData = currencyData.OrderBy(o => o.X).ToList();

            List<FlagsSeriesData> flagsData = new List<FlagsSeriesData>();

            flagsData.Add(new FlagsSeriesData
                            {
                                X = DateToUTC(new DateTime(2015, 5, 8)),
                                Title = "c",
                                Text = "Stocks fall on Greece, rate concerns; US dollar dips"
                            }
            );

            flagsData.Add(new FlagsSeriesData
                {
                    X = DateToUTC(new DateTime(2015, 5, 12)),
                    Title = "d",
                    Text = "Zimbabwe ditches 'worthless' currency for the US dollar "
                }
            );

            flagsData.Add(new FlagsSeriesData
                {
                    X = DateToUTC(new DateTime(2015, 5, 19)),
                    Title = "e",
                    Text = "US Dollar Declines Over the Week on Rate Timeline"
                }
           );

           flagsData.Add(new FlagsSeriesData
            {
                X = DateToUTC(new DateTime(2015, 5, 26)),
                Title = "e",
                Text = "US Dollar Declines Over the Week on Rate Timeline"
            }
          );

            ViewBag.FlagsData = flagsData;

            return View(ViewBag);
        }

        private void FlagsGeneral_JsonDataToDatabase()
        {
            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("http://www.highcharts.com/samples/data/jsonp.php?filename=usdeur.json&callback=?");
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

                    string year = values[0].Substring( values[0].IndexOf("(") + 1 , 4);
                    string month = values[1];
                    string day = values[2].Substring(0, values[2].IndexOf(")"));
                    string value = values[3];

                    try
                    {

                        DateTime date = new DateTime(Convert.ToInt16(year), Convert.ToInt16(month), Convert.ToInt16(day));

                        db.Flags.Add(
                                new Flag
                                {
                                    Date = DateToUTC(date),
                                    Value = Convert.ToDouble(value)
                                }
                            );
                    }
                    catch (Exception)
                    {
                    }

                    json = json.Substring(json.IndexOf('[') + 1);
                }

                db.SaveChanges();
            }
        }

        public double DateToUTC(DateTime theDate)
        {
            DateTime d1 = new DateTime(1970, 1, 1);
            DateTime d2 = theDate.ToUniversalTime();
            TimeSpan ts = new TimeSpan(d2.Ticks - d1.Ticks);

            return ts.TotalMilliseconds;
        }

    }
}

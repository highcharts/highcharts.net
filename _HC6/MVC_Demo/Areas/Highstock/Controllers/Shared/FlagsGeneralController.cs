using Highsoft.Web.Mvc.Stocks;
using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Globalization;

namespace MVC_Demo.Areas.Highstock.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult FlagsGeneral()
        {
            List<LineSeriesData> currencyData = new List<LineSeriesData>();

            foreach (Flag flag in GetList_FlagsGeneral())
            {
                currencyData.Add(new LineSeriesData
                {
                    Y = Convert.ToDouble(flag.Value),
                    X = Convert.ToDouble(flag.Date)
                }
                );
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

        private List<Flag> GetList_FlagsGeneral()
        {
            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://cdn.rawgit.com/highcharts/highcharts/v6.0.5/samples/data/usdeur.json");
            }

            json = json.Substring(json.IndexOf('[') + 1);
            json = json.Substring(json.IndexOf('[') + 1);


            List<Flag> flags = new List<Flag>();
            
            while (true)
            {
                if (json.IndexOf('[') == -1)
                    break;

                string entity = json.Substring(0, json.IndexOf(']'));
                string[] values = entity.Split(',');

                string date = values[0];
                string value = values[1];

                try
                {
                    flags.Add(
                            new Flag
                            {
                                Date = Convert.ToDouble(date, CultureInfo.InvariantCulture),
                                Value = Convert.ToDouble(value, CultureInfo.InvariantCulture)
                            }
                        );
                }
                catch (Exception)
                {
                }

                json = json.Substring(json.IndexOf('[') + 1);
            }

            return flags;
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

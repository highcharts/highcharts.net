using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    public static class DataReceiver
    {
        public static List<CompanyData> GetJSON(string company)
        {
            string url = "";

            switch (company)
            {
                case "Apple":
                    url = "https://www.highcharts.com/samples/data/jsonp.php?filename=aapl-v.json&callback=?";
                    //url = "https://www.highcharts.com/samples/data/jsonp.php?filename=aapl-c.json&callback=";
                    break;
                case "Microsoft":
                    url = "https://www.highcharts.com/samples/data/jsonp.php?filename=msft-c.json&callback=";
                    break;
                case "Google":
                    url = "https://www.highcharts.com/samples/data/jsonp.php?filename=goog-c.json&callback=";
                    break;
                default:
                    url = "https://www.highcharts.com/samples/data/jsonp.php?filename=aapl-c.json&callback=";
                    break;
            }

            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(url);
            }

            json = json.Substring(json.IndexOf('[') + 1);
            json = json.Substring(json.IndexOf('[') + 1);

            List<CompanyData> companyDatas = new List<CompanyData>();

            while (true)
            {
                if (json.IndexOf('[') == -1)
                    break;

                string entity = json.Substring(0, json.IndexOf(']'));
                string[] values = entity.Split(',');

                companyDatas.Add(
                    new CompanyData
                    {
                        Date = Convert.ToDouble(values[0]),
                        Value = Convert.ToDouble(values[1])
                    }
                );

                json = json.Substring(json.IndexOf('[') + 1);
            }

            return companyDatas;
        }

        public static List<RangeData> GetJSONRange()
        {
            string url = "http://www.highcharts.com/samples/data/jsonp.php?filename=range.json&callback=?";
            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(url);
            }

            json = json.Substring(json.IndexOf('[') + 1);
            json = json.Substring(json.IndexOf('[') + 1);

            List<RangeData> companyDatas = new List<RangeData>();

            while (true)
            {
                if (json.IndexOf('[') == -1)
                    break;

                string entity = json.Substring(0, json.IndexOf(']'));
                string[] values = entity.Split(',');

                companyDatas.Add(
                    new RangeData
                    {
                        X = Convert.ToDouble(values[0]),
                        Low = Convert.ToDouble(values[1]),
                        High = Convert.ToDouble(values[2])
                    }
                );

                json = json.Substring(json.IndexOf('[') + 1);
            }

            return companyDatas;
        }


        public static List<CandlestickVolume> GetJSONCandlestickVolumes()
        {
            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://www.highcharts.com/samples/data/jsonp.php?filename=aapl-ohlcv.json");
            }

            json = json.Substring(json.IndexOf('[') + 1);
            json = json.Substring(json.IndexOf('[') + 1);

            List<CandlestickVolume> CandlestickVolumes = new List<CandlestickVolume>();

            while (true)
            {
                if (json.IndexOf('[') == -1)
                    break;

                string entity = json.Substring(0, json.IndexOf(']'));
                string[] values = entity.Split(',');

                CandlestickVolumes.Add(
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

            return CandlestickVolumes;
        }


        public static List<FlagData> GetJSONFlags()
        {
            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("http://www.highcharts.com/samples/data/jsonp.php?filename=usdeur.json&callback=?");
            }

            json = json.Substring(json.IndexOf('[') + 1);
            json = json.Substring(json.IndexOf('[') + 1);

            List<FlagData> flags = new List<FlagData>();
            while (true)
            {
                if (json.IndexOf('[') == -1)
                    break;

                string entity = json.Substring(0, json.IndexOf(']'));
                string[] values = entity.Split(',');

                string year = values[0].Substring(values[0].IndexOf("(") + 1, 4);
                string month = values[1];
                string day = values[2].Substring(0, values[2].IndexOf(")"));
                string value = values[3];

                try
                {
                    DateTime date = new DateTime(Convert.ToInt16(year), Convert.ToInt16(month), Convert.ToInt16(day));

                    flags.Add(
                            new FlagData
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

            return flags;
        }

        private static double DateToUTC(DateTime theDate)
        {
            DateTime d1 = new DateTime(1970, 1, 1);
            DateTime d2 = theDate.ToUniversalTime();
            TimeSpan ts = new TimeSpan(d2.Ticks - d1.Ticks);

            return ts.TotalMilliseconds;
        }
    }
}
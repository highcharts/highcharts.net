using HighstockMVC.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

namespace HighstockMVC.DataSource
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
                        Date = Convert.ToDouble(values[0], CultureInfo.InvariantCulture),
                        Value = Convert.ToDouble(values[1], CultureInfo.InvariantCulture)
                    }
                );

                json = json.Substring(json.IndexOf('[') + 1);
            }

            return companyDatas;
        }
    }
}
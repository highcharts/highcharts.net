using System;
using System.Collections.Generic;
using System.Net;
using System.Globalization;
using System.Linq;
using System.Web;
using System.IO;
using System.Threading.Tasks;
using Highsoft.Web.Mvc.Charts;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace MVC_Demo.Models
{
    public static class DataReceiver
    {
        private static readonly string AppleFile = "Apple.json";
        private static readonly string CandlestickFile = "Candlestick.json";
        private static readonly string GoogleFile = "Google.json";
        private static readonly string IntradayFile = "intraday.json";
        private static readonly string MicrosoftFile = "Microsoft.json";
        private static readonly string RangeFile = "Range.json";
        private static readonly string UsdEurFile = "usdeur.json";

        #region private methods

        private static JArray GetDataFromJson(string filepath)
        {
            using (StreamReader file = File.OpenText(HttpContext.Current.Server.MapPath(@"~/App_Data/" + @filepath)))
            using (JsonTextReader reader = new JsonTextReader(file))
                return (JArray)JToken.ReadFrom(reader);
        }

        private static IEnumerable<PointData> GetData(string filepath)
        {
            JArray json;

            try
            {
                json = GetDataFromJson(filepath);
            }
            catch (Exception)
            {
                return new List<PointData>();
            }

            return json.Select(p => new PointData { Date = Convert.ToDouble(p[0], CultureInfo.InvariantCulture), Value = Convert.ToDouble(p[1], CultureInfo.InvariantCulture) });
        }

        private static IEnumerable<RangeData> GetRangeData(string filepath)
        {
            JArray json;

            try
            {
                json = GetDataFromJson(filepath);
            }
            catch (Exception)
            {
                return new List<RangeData>();
            }

            return json.Select(p => new RangeData { X = Convert.ToDouble(p[0], CultureInfo.InvariantCulture), Low = Convert.ToDouble(p[1], CultureInfo.InvariantCulture), High = Convert.ToDouble(p[2], CultureInfo.InvariantCulture) });
        }

        private static IEnumerable<StockData> GetStockData(string filepath)
        {
            JArray json;

            try
            {
                json = GetDataFromJson(filepath);
            }
            catch (Exception)
            {
                return new List<StockData>();
            }

            return json.Select(p => new StockData { 
                Date = Convert.ToDouble(p[0], CultureInfo.InvariantCulture), 
                Open = Convert.ToDouble(p[1], CultureInfo.InvariantCulture), 
                High = Convert.ToDouble(p[2], CultureInfo.InvariantCulture),
                Low = Convert.ToDouble(p[3], CultureInfo.InvariantCulture),
                Close = Convert.ToDouble(p[4], CultureInfo.InvariantCulture),
                Volume = p.Count() == 6 ? Convert.ToDouble(p[5], CultureInfo.InvariantCulture) : 0
            });
        }

        #endregion

        #region public methods

        public static IEnumerable<PointData> GetAppleData()
        {
            return GetData(AppleFile);
        }

        public static IEnumerable<PointData> GetMicrosoftData()
        {
            return GetData(MicrosoftFile);
        }

        public static IEnumerable<PointData> GetGoogleData()
        {
            return GetData(GoogleFile);
        }

        public static IEnumerable<RangeData> GetRangeData()
        {
            return GetRangeData(RangeFile);
        }

        public static IEnumerable<StockData> GetCandlestickData()
        {
            return GetStockData(CandlestickFile);
        }

        public static IEnumerable<PointData> GetUsdEurData()
        {
            return GetData(UsdEurFile);
        }

        public static IEnumerable<StockData> GetIntradayData()
        {
            return GetStockData(IntradayFile);
        }

        #endregion




        //public static List<CompanyData> GetJSON(string company)
        //{
        //    string url = "";

        //    switch (company)
        //    {
        //        case "Apple":
        //            url = "https://www.highcharts.com/samples/data/jsonp.php?filename=aapl-v.json&callback=?";
        //            //url = "https://www.highcharts.com/samples/data/jsonp.php?filename=aapl-c.json&callback=";
        //            break;
        //        case "Microsoft":
        //            url = "https://www.highcharts.com/samples/data/jsonp.php?filename=msft-c.json&callback=";
        //            break;
        //        case "Google":
        //            url = "https://www.highcharts.com/samples/data/jsonp.php?filename=goog-c.json&callback=";
        //            break;
        //        default:
        //            url = "https://www.highcharts.com/samples/data/jsonp.php?filename=aapl-c.json&callback=";
        //            break;
        //    }

        //    string json;

        //    using (WebClient wc = new WebClient())
        //    {
        //        json = wc.DownloadString(url);
        //    }

        //    json = json.Substring(json.IndexOf('[') + 1);
        //    json = json.Substring(json.IndexOf('[') + 1);

        //    List<CompanyData> companyDatas = new List<CompanyData>();

        //    while (true)
        //    {
        //        if (json.IndexOf('[') == -1)
        //            break;

        //        string entity = json.Substring(0, json.IndexOf(']'));
        //        string[] values = entity.Split(',');

        //        companyDatas.Add(
        //            new CompanyData
        //            {
        //                Date = Convert.ToDouble(values[0], CultureInfo.InvariantCulture),
        //                Value = Convert.ToDouble(values[1], CultureInfo.InvariantCulture)
        //            }
        //        );

        //        json = json.Substring(json.IndexOf('[') + 1);
        //    }

        //    return companyDatas;
        //}

        //public static List<RangeData> GetJSONRange()
        //{
        //    string url = "https://www.highcharts.com/samples/data/jsonp.php?filename=range.json&callback=?";
        //    string json;

        //    using (WebClient wc = new WebClient())
        //    {
        //        json = wc.DownloadString(url);
        //    }

        //    json = json.Substring(json.IndexOf('[') + 1);
        //    json = json.Substring(json.IndexOf('[') + 1);

        //    List<RangeData> companyDatas = new List<RangeData>();

        //    while (true)
        //    {
        //        if (json.IndexOf('[') == -1)
        //            break;

        //        string entity = json.Substring(0, json.IndexOf(']'));
        //        string[] values = entity.Split(',');

        //        //double? tmp_X;
        //        //double? tmp_Low;
        //        //double? tmp_High;

        //        //double.TryParse(values[0], out tmp_X);

        //        companyDatas.Add(
        //            new RangeData
        //            {
        //                X = values[0].Trim() == "null" ? (double?)null : Convert.ToDouble(values[0].Trim(),CultureInfo.InvariantCulture),
        //                Low = values[1].Trim() == "null" ? (double?)null: Convert.ToDouble(values[1].Trim(), CultureInfo.InvariantCulture),
        //                High = values[2].Trim() == "null" ? (double?)null: Convert.ToDouble(values[2].Trim(), CultureInfo.InvariantCulture)
        //            }
        //        );

        //        json = json.Substring(json.IndexOf('[') + 1);
        //    }

        //    return companyDatas;
        //}


        //public static List<CandlestickVolume> GetJSONCandlestickVolumes()
        //{
        //    string json;

        //    using (WebClient wc = new WebClient())
        //    {
        //        json = wc.DownloadString("https://www.highcharts.com/samples/data/jsonp.php?filename=aapl-ohlcv.json");
        //    }

        //    json = json.Substring(json.IndexOf('[') + 1);
        //    json = json.Substring(json.IndexOf('[') + 1);

        //    List<CandlestickVolume> CandlestickVolumes = new List<CandlestickVolume>();

        //    while (true)
        //    {
        //        if (json.IndexOf('[') == -1)
        //            break;

        //        string entity = json.Substring(0, json.IndexOf(']'));
        //        string[] values = entity.Split(',');

        //        CandlestickVolumes.Add(
        //            new CandlestickVolume
        //            {
        //                Date = values[0].Trim() == "null" ? (double?)null : Convert.ToDouble(values[0].Trim(), CultureInfo.InvariantCulture),
        //                Open = values[1].Trim() == "null" ? (double?)null : Convert.ToDouble(values[1].Trim(), CultureInfo.InvariantCulture),
        //                High = values[2].Trim() == "null" ? (double?)null : Convert.ToDouble(values[2].Trim(), CultureInfo.InvariantCulture),
        //                Low = values[3].Trim() == "null" ? (double?)null : Convert.ToDouble(values[3].Trim(), CultureInfo.InvariantCulture),
        //                Close = values[4].Trim() == "null" ? (double?)null : Convert.ToDouble(values[4].Trim(), CultureInfo.InvariantCulture),
        //                Volume = values[5].Trim() == "null" ? (double?)null : Convert.ToDouble(values[5].Trim(), CultureInfo.InvariantCulture),
        //            }
        //        );

        //        json = json.Substring(json.IndexOf('[') + 1);
        //    }

        //    return CandlestickVolumes;
        //}


        //public static List<FlagData> GetJSONFlags()
        //{
        //    string json;

        //    using (WebClient wc = new WebClient())
        //    {
        //        json = wc.DownloadString("https://cdn.rawgit.com/highcharts/highcharts/v6.0.5/samples/data/usdeur.json");
        //    }

        //    json = json.Substring(json.IndexOf('[') + 1);
        //    json = json.Substring(json.IndexOf('[') + 1);

        //    List<FlagData> flags = new List<FlagData>();
        //    while (true)
        //    {
        //        if (json.IndexOf('[') == -1)
        //            break;

        //        string entity = json.Substring(0, json.IndexOf(']'));
        //        string[] values = entity.Split(',');

        //        string date = values[0];
        //        string value = values[1];

        //        try
        //        {
        //            flags.Add(
        //                    new FlagData
        //                    {
        //                        Date = Convert.ToDouble(date, CultureInfo.InvariantCulture),
        //                        Value = Convert.ToDouble(value, CultureInfo.InvariantCulture)
        //                    }
        //                );
        //        }
        //        catch (Exception)
        //        {
        //        }

        //        json = json.Substring(json.IndexOf('[') + 1);
        //    }

        //    return flags;
        //}

        public static List<AnnotationsData> GetDataForAnnotationsChart()
        {
            var results = new List<AnnotationsData>();
            HttpServerUtility server = HttpContext.Current.Server;
            try
            {
                using (StreamReader sr = new StreamReader(server.MapPath("~/App_Data/annotations.csv")))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var pair = line.Split(',');
                        results.Add(new AnnotationsData { X = Convert.ToDouble(pair[0], new CultureInfo("en-US")), Y = Convert.ToDouble(pair[1], new CultureInfo("en-US")) });
                    }
                }

                return results;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<LineSeriesData> GetDataForLineBoost(int number)
        {
            List<LineSeriesData> list = new List<LineSeriesData>(number);
            double a, b, c, spike;
            a = b = c = spike = 0;
            Random random = new Random();

            for(int i = 0; i<number; i++)
            {
                if (i % 100 == 0)
                    a = 2 * random.NextDouble();

                if (i % 1000 == 0)
                    a = 2 * random.NextDouble();

                if (i % 10000 == 0)
                    a = 2 * random.NextDouble();

                if (i % 50000 == 0)
                    spike = 10;
                else
                    spike = 0;

                list.Add(new LineSeriesData { X = i, Y = 2 * Math.Sin(i / 100) + a + b + c + spike + random.NextDouble() });
            }

            return list;
        }

        public static List<ScatterSeriesData> GetDataForScatterBoost(int number)
        {
            List<ScatterSeriesData> list = new List<ScatterSeriesData>(number);
            Random random = new Random();

            for(int i=0;i<number;i++)
            {
                list.Add(new ScatterSeriesData { X = Math.Pow(random.NextDouble(), 2) * 100, Y = Math.Pow(random.NextDouble(), 2) * 100 });
            }

            return list;
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
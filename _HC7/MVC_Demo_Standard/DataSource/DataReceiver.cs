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
        private static readonly string SunburstFile = "sunburst_data.json";
        private static readonly string GroupingFile = "large-dataset.json";

        private static readonly CultureInfo _cultureInfo = new CultureInfo("en-US");

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

        public static IEnumerable<Highsoft.Web.Mvc.Stocks.LineSeriesData> GetGroupingData()
        {
            JArray json;

            try
            {
                json = GetDataFromJson(GroupingFile);
            }
            catch (Exception)
            {
                return new List<Highsoft.Web.Mvc.Stocks.LineSeriesData>();
            }

            return json.Select(p => new Highsoft.Web.Mvc.Stocks.LineSeriesData { Y = (double?)p });
        }

        #endregion





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

        public static List<SunburstSeriesData> GetDataForSunburstChart()
        {
            var results = new List<SunburstSeriesData>();
            HttpServerUtility server = HttpContext.Current.Server;
            try
            {
                using (StreamReader sr = new StreamReader(server.MapPath("~/App_Data/sunburst_data.csv")))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var pair = line.Split(',');
                        //results.Add(new AnnotationsData { X = Convert.ToDouble(pair[0], new CultureInfo("en-US")), Y = Convert.ToDouble(pair[1], new CultureInfo("en-US")) });
                        results.Add(new SunburstSeriesData { Id = pair[0], Parent = pair[1], Name = pair[2], Value = Convert.ToDouble(pair[3], _cultureInfo) });
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
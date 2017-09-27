using Highsoft.Web.Mvc.Charts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace EnergyApplication.Services
{
    public class DataService
    {
        public static async Task<List<SplineSeriesData>> GetAsync(string path, int minValue, int maxValue)
        {
            var results = new List<SplineSeriesData>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = await sr.ReadLineAsync()) != null)
                    {
                        var pair = line.Split(',');
                        var date = DateTime.ParseExact(pair[0], "dd/MM/yyyy", null);

                        if (!IsValueInsideRange(date.Year, minValue, maxValue))
                            continue;

                        results.Add(new SplineSeriesData { X = MilliTimeStamp(date), Y = Convert.ToDouble(pair[1]) });
                    }
                }

                return results;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static double MilliTimeStamp(DateTime theDate)
        {
            DateTime d1 = new DateTime(1970, 1, 1);
            DateTime d2 = theDate.ToUniversalTime();
            TimeSpan ts = new TimeSpan(d2.Ticks - d1.Ticks);

            return ts.TotalMilliseconds;
        }

        private static bool IsValueInsideRange(int Value, int minValue, int maxValue)
        {
            return Value >= minValue && Value <= maxValue ? true : false;
        }
    }
}
using Highsoft.Web.Mvc.Charts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace EnergyApplication.Services
{
    public class DataService
    {
        public static List<SplineSeriesData> Get(string path)
        {
            var results = new List<SplineSeriesData>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var pair = line.Split(',');
                        results.Add(new SplineSeriesData { X = MilliTimeStamp(DateTime.ParseExact(pair[0],"dd/MM/yyyy",null)), Y = Convert.ToDouble(pair[1]) });
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
    }
}
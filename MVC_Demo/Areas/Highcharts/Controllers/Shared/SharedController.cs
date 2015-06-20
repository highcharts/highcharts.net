using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc;

namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AreaBasic()
        {
            List<double?> usaValues = new List<double?> {
                null, null, null, null, null, 6, 11, 32, 110, 235, 369, 640,
                1005, 1436, 2063, 3057, 4618, 6444, 9822, 15468, 20434, 24126,
                27387, 29459, 31056, 31982, 32040, 31233, 29224, 27342, 26662,
                26956, 27912, 28999, 28965, 27826, 25579, 25722, 24826, 24605,
                24304, 23464, 23708, 24099, 24357, 24237, 24401, 24344, 23586,
                22380, 21004, 17287, 14747, 13076, 12555, 12144, 11009, 10950,
                10871, 10824, 10577, 10527, 10475, 10421, 10358, 10295, 10104 };
            List<double?> russiaValues = new List<double?> {
                null, null, null, null, null, null, null, null, null, null,
                5, 25, 50, 120, 150, 200, 426, 660, 869, 1060, 1605, 2471, 3322,
                4238, 5221, 6129, 7089, 8339, 9399, 10538, 11643, 13092, 14478,
                15915, 17385, 19055, 21205, 23044, 25393, 27935, 30062, 32049,
                33952, 35804, 37431, 39197, 45000, 43000, 41000, 39000, 37000,
                35000, 33000, 31000, 29000, 27000, 25000, 24000, 23000, 22000,
                21000, 20000, 19000, 18000, 18000, 17000, 16000 };
            List<AreaSeriesData> usaData = new List<AreaSeriesData>();
            List<AreaSeriesData> russiaData = new List<AreaSeriesData>();

            usaValues.ForEach(p => usaData.Add(new AreaSeriesData { Y = p }));
            russiaValues.ForEach(p => russiaData.Add(new AreaSeriesData { Y = p }));

            ViewData["usaData"] = usaData;
            ViewData["russiaData"] = russiaData;

            return View();
        }

        public ActionResult AreaNegative()
        {
            List<double?> johnValues = new List<double?> { 5, 3, 4, 7, 2 };
            List<double?> janeValues = new List<double?> { 2, -2, -3, 2, 1 };
            List<double?> joeValues = new List<double?> { 3, 4, 4, -2, 5 };

            List<AreaSeriesData> johnData = new List<AreaSeriesData>();
            List<AreaSeriesData> janeData = new List<AreaSeriesData>();
            List<AreaSeriesData> joeData = new List<AreaSeriesData>();

            johnValues.ForEach(p => johnData.Add(new AreaSeriesData { Y = p }));
            janeValues.ForEach(p => janeData.Add(new AreaSeriesData { Y = p }));
            joeValues.ForEach(p => joeData.Add(new AreaSeriesData { Y = p }));

            ViewData["johnData"] = johnData;
            ViewData["janeData"] = janeData;
            ViewData["joeData"] = joeData;

            return View();
        }

        public ActionResult AreaStacked()
        {
            List<double?> asiaValues = new List<double?> { 502, 635, 809, 947, 1402, 3634, 5268 };
            List<double?> africaValues = new List<double?> { 106, 107, 111, 133, 221, 767, 1766 };
            List<double?> europeValues = new List<double?> { 163, 203, 276, 408, 547, 729, 628 };
            List<double?> americaValues = new List<double?> { 18, 31, 54, 156, 339, 818, 1201 };
            List<double?> oceaniaValues = new List<double?> { 2, 2, 2, 6, 13, 30, 46 };

            List<AreaSeriesData> asiaData = new List<AreaSeriesData>();
            List<AreaSeriesData> africaData = new List<AreaSeriesData>();
            List<AreaSeriesData> europeData = new List<AreaSeriesData>();
            List<AreaSeriesData> americaData = new List<AreaSeriesData>();
            List<AreaSeriesData> oceaniaData = new List<AreaSeriesData>();

            asiaValues.ForEach(p => asiaData.Add(new AreaSeriesData { Y = p }));
            africaValues.ForEach(p => africaData.Add(new AreaSeriesData { Y = p }));
            europeValues.ForEach(p => europeData.Add(new AreaSeriesData { Y = p }));
            americaValues.ForEach(p => americaData.Add(new AreaSeriesData { Y = p }));
            oceaniaValues.ForEach(p => oceaniaData.Add(new AreaSeriesData { Y = p }));

            ViewData["asiaData"] = asiaData;
            ViewData["africaData"] = africaData;
            ViewData["europeData"] = europeData;
            ViewData["americaData"] = americaData;
            ViewData["oceaniaData"] = oceaniaData;

            return View();
        }

        public ActionResult BarBasic()
        {
            List<double?> year1800Values = new List<double?> { 107, 31, 635, 203, 2 };
            List<double?> year1900Values = new List<double?> { 133, 156, 947, 408, 6 };
            List<double?> year2008Values = new List<double?> { 973, 914, 4054, 732, 34 };

            List<BarSeriesData> year1800Data = new List<BarSeriesData>();
            List<BarSeriesData> year1900Data = new List<BarSeriesData>();
            List<BarSeriesData> year2008Data = new List<BarSeriesData>();

            year1800Values.ForEach(p => year1800Data.Add(new BarSeriesData { Y = p }));
            year1900Values.ForEach(p => year1900Data.Add(new BarSeriesData { Y = p }));
            year2008Values.ForEach(p => year2008Data.Add(new BarSeriesData { Y = p }));

            ViewData["year1800Data"] = year1800Data;
            ViewData["year1900Data"] = year1900Data;
            ViewData["year2008Data"] = year2008Data;

            return View();
        }

        public ActionResult BarStacked()
        {
            List<double?> johnValues = new List<double?> { 5, 3, 4, 7, 2 };
            List<double?> janeValues = new List<double?> { 2, -2, -3, 2, 1 };
            List<double?> joeValues = new List<double?> { 3, 4, 4, -2, 5 };

            List<BarSeriesData> johnData = new List<BarSeriesData>();
            List<BarSeriesData> janeData = new List<BarSeriesData>();
            List<BarSeriesData> joeData = new List<BarSeriesData>();

            johnValues.ForEach(p => johnData.Add(new BarSeriesData { Y = p }));
            janeValues.ForEach(p => janeData.Add(new BarSeriesData { Y = p }));
            joeValues.ForEach(p => joeData.Add(new BarSeriesData { Y = p }));

            ViewData["johnData"] = johnData;
            ViewData["janeData"] = janeData;
            ViewData["joeData"] = joeData;

            return View();
        }

        public ActionResult BarNegativeStack()
        {
            List<double?> maleValues = new List<double?> {
                    -1746181, -1884428, -2089758, -2222362, -2537431, -2507081, -2443179,
                    -2664537, -3556505, -3680231, -3143062, -2721122, -2229181, -2227768,
                    -2176300, -1329968, -836804, -354784, -90569, -28367, -3878
            };
            List<double?> femaleValues = new List<double?> {
                    1656154, 1787564, 1981671, 2108575, 2403438, 2366003, 2301402, 2519874,
                    3360596, 3493473, 3050775, 2759560, 2304444, 2426504, 2568938, 1785638,
                    1447162, 1005011, 330870, 130632, 21208 
            };

            List<BarSeriesData> maleData = new List<BarSeriesData>();
            List<BarSeriesData> femaleData = new List<BarSeriesData>();

            maleValues.ForEach(p => maleData.Add(new BarSeriesData { Y = p }));
            femaleValues.ForEach(p => femaleData.Add(new BarSeriesData { Y = p }));

            ViewData["maleData"] = maleData;
            ViewData["femaleData"] = femaleData;

            return View();
        }

        public ActionResult ColumnBasic()
        {
            List<double> tokyoValues = new List<double> { 49.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 };
            List<double> nyValues = new List<double> { 83.6, 78.8, 98.5, 93.4, 106.0, 84.5, 105.0, 104.3, 91.2, 83.5, 106.6, 92.3 };
            List<double> berlinValues = new List<double> { 42.4, 33.2, 34.5, 39.7, 52.6, 75.5, 57.4, 60.4, 47.6, 39.1, 46.8, 51.1 };
            List<double> londonValues = new List<double> { 48.9, 38.8, 39.3, 41.4, 47.0, 48.3, 59.0, 59.6, 52.4, 65.2, 59.3, 51.2 };
            List<ColumnSeriesData> tokyoData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> nyData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> berlinData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> londonData = new List<ColumnSeriesData>();

            tokyoValues.ForEach(p => tokyoData.Add(new ColumnSeriesData { Y = p }));
            nyValues.ForEach(p => nyData.Add(new ColumnSeriesData { Y = p }));
            berlinValues.ForEach(p => berlinData.Add(new ColumnSeriesData { Y = p }));
            londonValues.ForEach(p => londonData.Add(new ColumnSeriesData { Y = p }));

            ViewData["tokyoData"] = tokyoData;
            ViewData["nyData"] = nyData;
            ViewData["berlinData"] = berlinData;
            ViewData["londonData"] = londonData;

            return View();
        }

        public ActionResult ColumnNegative()
        {
            List<double?> johnValues = new List<double?> { 5, 3, 4, 7, 2 };
            List<double?> janeValues = new List<double?> { 2, -2, -3, 2, 1 };
            List<double?> joeValues = new List<double?> { 3, 4, 4, -2, 5 };

            List<ColumnSeriesData> johnData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> janeData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> joeData = new List<ColumnSeriesData>();

            johnValues.ForEach(p => johnData.Add(new ColumnSeriesData { Y = p }));
            janeValues.ForEach(p => janeData.Add(new ColumnSeriesData { Y = p }));
            joeValues.ForEach(p => joeData.Add(new ColumnSeriesData { Y = p }));

            ViewData["johnData"] = johnData;
            ViewData["janeData"] = janeData;
            ViewData["joeData"] = joeData;

            return View();
        }

        public ActionResult ColumnStacked()
        {
            List<double?> johnValues = new List<double?> { 5, 3, 4, 7, 2 };
            List<double?> janeValues = new List<double?> { 2, 2, 3, 2, 1 };
            List<double?> joeValues = new List<double?> { 3, 4, 4, 2, 5 };

            List<ColumnSeriesData> johnData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> janeData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> joeData = new List<ColumnSeriesData>();

            johnValues.ForEach(p => johnData.Add(new ColumnSeriesData { Y = p }));
            janeValues.ForEach(p => janeData.Add(new ColumnSeriesData { Y = p }));
            joeValues.ForEach(p => joeData.Add(new ColumnSeriesData { Y = p }));

            ViewData["johnData"] = johnData;
            ViewData["janeData"] = janeData;
            ViewData["joeData"] = joeData;

            return View();
        }

        public ActionResult PieBasic()
        {
            List<PieSeriesData> pieData = new List<PieSeriesData>();

            pieData.Add(new PieSeriesData { Name = "FireFox", Y = 45.0 });
            pieData.Add(new PieSeriesData { Name = "IE", Y = 26.8 });
            pieData.Add(new PieSeriesData { Name = "Chrome", Y = 12.8, Sliced = true, Selected = true });
            pieData.Add(new PieSeriesData { Name = "Safari", Y = 8.5 });
            pieData.Add(new PieSeriesData { Name = "Opera", Y = 6.2 });
            pieData.Add(new PieSeriesData { Name = "Others", Y = 0.7 });

            ViewData["pieData"] = pieData;

            return View();
        }

        public ActionResult PieLegend()
        {
            List<PieSeriesData> pieData = new List<PieSeriesData>();

            pieData.Add(new PieSeriesData { Name = "FireFox", Y = 45.0 });
            pieData.Add(new PieSeriesData { Name = "IE", Y = 26.8 });
            pieData.Add(new PieSeriesData { Name = "Chrome", Y = 12.8, Sliced = true, Selected = true });
            pieData.Add(new PieSeriesData { Name = "Safari", Y = 8.5 });
            pieData.Add(new PieSeriesData { Name = "Opera", Y = 6.2 });
            pieData.Add(new PieSeriesData { Name = "Others", Y = 0.7 });

            ViewData["pieData"] = pieData;

            return View();
        }

        public ActionResult PieDonut()
        {
            List<PieSeriesData> pieData = new List<PieSeriesData>();

            pieData.Add(new PieSeriesData { Name = "FireFox", Y = 45.0 });
            pieData.Add(new PieSeriesData { Name = "IE", Y = 26.8 });
            pieData.Add(new PieSeriesData { Name = "Chrome", Y = 12.8, Sliced = true, Selected = true });
            pieData.Add(new PieSeriesData { Name = "Safari", Y = 8.5 });
            pieData.Add(new PieSeriesData { Name = "Opera", Y = 6.2 });
            pieData.Add(new PieSeriesData { Name = "Others", Y = 0.7 });

            ViewData["pieData"] = pieData;

            return View();
        }

        public double MilliTimeStamp(DateTime theDate)
        {
            DateTime d1 = new DateTime(1970, 1, 1);
            DateTime d2 = theDate.ToUniversalTime();
            TimeSpan ts = new TimeSpan(d2.Ticks - d1.Ticks);

            return ts.TotalMilliseconds;
        }

    }
}

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
        public ActionResult SplineIrregularTime()
        {
            List<SplineSeriesData> winter1 = new List<SplineSeriesData>();
            List<SplineSeriesData> winter2 = new List<SplineSeriesData>();
            List<SplineSeriesData> winter3 = new List<SplineSeriesData>();

            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 10, 27)), Y = 0 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 11, 10)), Y = 0.6 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 11, 18)), Y = 0.7 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 12, 2)), Y = 0.8 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 12, 9)), Y = 0.6 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 12, 16)), Y = 0.6 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 12, 28)), Y = 0.67 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 1, 1)), Y = 0.81 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 1, 8)), Y = 0.78 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 1, 12)), Y = 0.98 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 1, 27)), Y = 1.84 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 2, 10)), Y = 1.80 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 2, 18)), Y = 1.80 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 2, 24)), Y = 1.92 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 3, 4)), Y = 2.49 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 3, 11)), Y = 2.79 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 3, 15)), Y = 2.73 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 3, 25)), Y = 2.61 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 4, 2)), Y = 2.76 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 4, 6)), Y = 2.82 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 4, 13)), Y = 2.8 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 5, 3)), Y = 2.1 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 5, 26)), Y = 1.1 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 6, 9)), Y = 0.25 });
            winter1.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 6, 12)), Y = 0 });

            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 10, 18)), Y = 0 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 10, 26)), Y = 0.2 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 12, 1)), Y = 0.47 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 12, 11)), Y = 0.55 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 12, 25)), Y = 1.38 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 1, 1)), Y = 1.38 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 1, 15)), Y = 1.38 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 2, 1)), Y = 1.38 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 2, 8)), Y = 1.48 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 2, 21)), Y = 1.5 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 3, 12)), Y = 1.89 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 3, 25)), Y = 2.0 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 4, 4)), Y = 1.94 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 4, 9)), Y = 1.91 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 4, 13)), Y = 1.75 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 4, 19)), Y = 1.6 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 5, 25)), Y = 0.6 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 5, 31)), Y = 0.35 });
            winter2.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 6, 7)), Y = 0 });

            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 10, 9)), Y = 0 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 10, 14)), Y = 0.15 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 11, 28)), Y = 0.35 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 12, 12)), Y = 0.46 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1970, 12, 25)), Y = 1.38 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 1, 1)), Y = 0.59 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 1, 24)), Y = 0.58 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 2, 1)), Y = 0.62 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 2, 7)), Y = 0.65 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 2, 23)), Y = 0.77 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 3, 8)), Y = 0.77 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 3, 14)), Y = 0.86 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 4, 4)), Y = 0.8 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 4, 18)), Y = 0.94 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 4, 24)), Y = 0.9 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 5, 16)), Y = 0.39 });
            winter3.Add(new SplineSeriesData { X = MilliTimeStamp(new DateTime(1971, 5, 21)), Y = 0 });

            ViewData["winter1"] = winter1;
            ViewData["winter2"] = winter2;
            ViewData["winter3"] = winter3;


            return View();
        }
        
    }
}

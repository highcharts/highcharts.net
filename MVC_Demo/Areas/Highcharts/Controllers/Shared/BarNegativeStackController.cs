using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Highcharts;


namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
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
    }
}

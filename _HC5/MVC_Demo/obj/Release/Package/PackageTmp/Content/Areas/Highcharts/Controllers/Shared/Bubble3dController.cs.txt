using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;


namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult Bubble3d()
        {
            List<BubbleSeriesData> bubble1Values = new List<BubbleSeriesData>();
            List<BubbleSeriesData> bubble2Values = new List<BubbleSeriesData>();
            List<BubbleSeriesData> bubble3Values = new List<BubbleSeriesData>();

            bubble1Values.Add(new BubbleSeriesData { X = 97, Y = 36, Z = 79 });
            bubble1Values.Add(new BubbleSeriesData { X = 94, Y = 74, Z = 60 });
            bubble1Values.Add(new BubbleSeriesData { X = 68, Y = 76, Z = 58 });
            bubble1Values.Add(new BubbleSeriesData { X = 64, Y = 87, Z = 56 });
            bubble1Values.Add(new BubbleSeriesData { X = 68, Y = 27, Z = 73 });
            bubble1Values.Add(new BubbleSeriesData { X = 74, Y = 99, Z = 42 });
            bubble1Values.Add(new BubbleSeriesData { X = 7, Y = 93, Z = 87 });
            bubble1Values.Add(new BubbleSeriesData { X = 51, Y = 69, Z = 40 });
            bubble1Values.Add(new BubbleSeriesData { X = 38, Y = 23, Z = 33 });
            bubble1Values.Add(new BubbleSeriesData { X = 57, Y = 86, Z = 31 });

            bubble2Values.Add(new BubbleSeriesData { X = 25, Y = 10, Z = 87 });
            bubble2Values.Add(new BubbleSeriesData { X = 2, Y = 75, Z = 59 });
            bubble2Values.Add(new BubbleSeriesData { X = 11, Y = 54, Z = 8 });
            bubble2Values.Add(new BubbleSeriesData { X = 86, Y = 55, Z = 93 });
            bubble2Values.Add(new BubbleSeriesData { X = 5, Y = 3, Z = 58 });
            bubble2Values.Add(new BubbleSeriesData { X = 90, Y = 63, Z = 44 });
            bubble2Values.Add(new BubbleSeriesData { X = 91, Y = 33, Z = 17 });
            bubble2Values.Add(new BubbleSeriesData { X = 97, Y = 3, Z = 56 });
            bubble2Values.Add(new BubbleSeriesData { X = 15, Y = 67, Z = 48 });
            bubble2Values.Add(new BubbleSeriesData { X = 54, Y = 25, Z = 81 });

            bubble3Values.Add(new BubbleSeriesData { X = 47, Y = 47, Z = 11 });
            bubble3Values.Add(new BubbleSeriesData { X = 20, Y = 12, Z = 4 });
            bubble3Values.Add(new BubbleSeriesData { X = 6, Y = 76, Z = 91 });
            bubble3Values.Add(new BubbleSeriesData { X = 30, Y = 30, Z = 60 });
            bubble3Values.Add(new BubbleSeriesData { X = 57, Y = 98, Z = 64 });
            bubble3Values.Add(new BubbleSeriesData { X = 61, Y = 17, Z = 80 });
            bubble3Values.Add(new BubbleSeriesData { X = 83, Y = 60, Z = 13 });
            bubble3Values.Add(new BubbleSeriesData { X = 67, Y = 78, Z = 75 });
            bubble3Values.Add(new BubbleSeriesData { X = 64, Y = 12, Z = 10 });
            bubble3Values.Add(new BubbleSeriesData { X = 30, Y = 77, Z = 82 });

            ViewData["bubble1"] = bubble1Values;
            ViewData["bubble2"] = bubble2Values;
            ViewData["bubble3"] = bubble3Values;

            return View();
        }

       
    }
}

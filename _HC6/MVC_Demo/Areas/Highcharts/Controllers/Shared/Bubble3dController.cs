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
            
            bubble1Values.Add(new BubbleSeriesData { X = 9, Y = 81, Z = 63 });
            bubble1Values.Add(new BubbleSeriesData { X = 98, Y = 5, Z = 89 });
            bubble1Values.Add(new BubbleSeriesData { X = 51, Y = 50, Z = 73 });
            bubble1Values.Add(new BubbleSeriesData { X = 41, Y = 22, Z = 14 });
            bubble1Values.Add(new BubbleSeriesData { X = 58, Y = 24, Z = 20 });
            bubble1Values.Add(new BubbleSeriesData { X = 78, Y = 37, Z = 34 });
            bubble1Values.Add(new BubbleSeriesData { X = 55, Y = 56, Z = 53 });
            bubble1Values.Add(new BubbleSeriesData { X = 18, Y = 45, Z = 70 });
            bubble1Values.Add(new BubbleSeriesData { X = 42, Y = 44, Z = 28 });
            bubble1Values.Add(new BubbleSeriesData { X = 3, Y = 52, Z = 59 });
            bubble1Values.Add(new BubbleSeriesData { X = 31, Y = 18, Z = 97 });
            bubble1Values.Add(new BubbleSeriesData { X = 79, Y = 91, Z = 63 });
            bubble1Values.Add(new BubbleSeriesData { X = 93, Y = 23, Z = 23 });
            bubble1Values.Add(new BubbleSeriesData { X = 44, Y = 83, Z = 22 });

            bubble2Values.Add(new BubbleSeriesData { X = 42, Y = 38, Z = 20 });
            bubble2Values.Add(new BubbleSeriesData { X = 6, Y = 18, Z = 1 });
            bubble2Values.Add(new BubbleSeriesData { X = 1, Y = 93, Z = 55 });
            bubble2Values.Add(new BubbleSeriesData { X = 57, Y = 2, Z = 90 });
            bubble2Values.Add(new BubbleSeriesData { X = 80, Y = 76, Z = 22 });
            bubble2Values.Add(new BubbleSeriesData { X = 11, Y = 74, Z = 96 });
            bubble2Values.Add(new BubbleSeriesData { X = 88, Y = 56, Z = 10 });
            bubble2Values.Add(new BubbleSeriesData { X = 30, Y = 47, Z = 49 });
            bubble2Values.Add(new BubbleSeriesData { X = 57, Y = 62, Z = 98 });
            bubble2Values.Add(new BubbleSeriesData { X = 4, Y = 16, Z = 16 });
            bubble2Values.Add(new BubbleSeriesData { X = 46, Y = 10, Z = 11 });
            bubble2Values.Add(new BubbleSeriesData { X = 22, Y = 87, Z = 89 });
            bubble2Values.Add(new BubbleSeriesData { X = 57, Y = 91, Z = 82 });
            bubble2Values.Add(new BubbleSeriesData { X = 42, Y = 15, Z = 98 });

            ViewData["bubble1"] = bubble1Values;
            ViewData["bubble2"] = bubble2Values;

            return View();
        }

       
    }
}

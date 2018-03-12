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
        public ActionResult Scatter3d()
        {
            List<Scatter3dSeriesData> list = new List<Scatter3dSeriesData>();

            list.Add(new Scatter3dSeriesData { X = 1, Y = 6, Z = 5 });
            list.Add(new Scatter3dSeriesData { X = 8, Y = 7, Z = 9 });
            list.Add(new Scatter3dSeriesData { X = 1, Y = 3, Z = 4 });
            list.Add(new Scatter3dSeriesData { X = 4, Y = 6, Z = 8 });
            list.Add(new Scatter3dSeriesData { X = 5, Y = 7, Z = 7 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 9, Z = 6 });
            list.Add(new Scatter3dSeriesData { X = 7, Y = 0, Z = 5 });
            list.Add(new Scatter3dSeriesData { X = 2, Y = 3, Z = 3 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 9, Z = 8 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 6, Z = 5 });
            list.Add(new Scatter3dSeriesData { X = 4, Y = 9, Z = 4 });
            list.Add(new Scatter3dSeriesData { X = 2, Y = 3, Z = 3 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 9, Z = 9 });
            list.Add(new Scatter3dSeriesData { X = 0, Y = 7, Z = 0 });
            list.Add(new Scatter3dSeriesData { X = 7, Y = 7, Z = 9 });
            list.Add(new Scatter3dSeriesData { X = 7, Y = 2, Z = 9 });
            list.Add(new Scatter3dSeriesData { X = 0, Y = 6, Z = 2 });
            list.Add(new Scatter3dSeriesData { X = 4, Y = 6, Z = 7 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 7, Z = 7 });
            list.Add(new Scatter3dSeriesData { X = 0, Y = 1, Z = 7 });
            list.Add(new Scatter3dSeriesData { X = 2, Y = 8, Z = 6 });
            list.Add(new Scatter3dSeriesData { X = 2, Y = 3, Z = 7 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 4, Z = 8 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 5, Z = 9 });
            list.Add(new Scatter3dSeriesData { X = 7, Y = 9, Z = 5 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 1, Z = 7 });
            list.Add(new Scatter3dSeriesData { X = 4, Y = 4, Z = 2 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 6, Z = 2 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 1, Z = 6 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 8, Z = 5 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 6, Z = 7 });
            list.Add(new Scatter3dSeriesData { X = 4, Y = 1, Z = 1 });
            list.Add(new Scatter3dSeriesData { X = 7, Y = 2, Z = 7 });
            list.Add(new Scatter3dSeriesData { X = 7, Y = 7, Z = 0 });
            list.Add(new Scatter3dSeriesData { X = 8, Y = 8, Z = 9 });
            list.Add(new Scatter3dSeriesData { X = 9, Y = 4, Z = 1 });
            list.Add(new Scatter3dSeriesData { X = 8, Y = 3, Z = 4 });
            list.Add(new Scatter3dSeriesData { X = 9, Y = 8, Z = 9 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 5, Z = 3 });
            list.Add(new Scatter3dSeriesData { X = 0, Y = 2, Z = 4 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 0, Z = 2 });
            list.Add(new Scatter3dSeriesData { X = 2, Y = 1, Z = 3 });
            list.Add(new Scatter3dSeriesData { X = 5, Y = 8, Z = 9 });
            list.Add(new Scatter3dSeriesData { X = 2, Y = 1, Z = 1 });
            list.Add(new Scatter3dSeriesData { X = 9, Y = 7, Z = 6 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 0, Z = 2 });
            list.Add(new Scatter3dSeriesData { X = 9, Y = 9, Z = 0 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 4, Z = 8 });
            list.Add(new Scatter3dSeriesData { X = 2, Y = 6, Z = 1 });
            list.Add(new Scatter3dSeriesData { X = 8, Y = 9, Z = 2 });
            list.Add(new Scatter3dSeriesData { X = 7, Y = 6, Z = 5 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 3, Z = 1 });
            list.Add(new Scatter3dSeriesData { X = 9, Y = 3, Z = 1 });
            list.Add(new Scatter3dSeriesData { X = 8, Y = 9, Z = 3 });
            list.Add(new Scatter3dSeriesData { X = 9, Y = 1, Z = 0 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 8, Z = 7 });
            list.Add(new Scatter3dSeriesData { X = 8, Y = 0, Z = 0 });
            list.Add(new Scatter3dSeriesData { X = 4, Y = 9, Z = 7 });
            list.Add(new Scatter3dSeriesData { X = 8, Y = 6, Z = 2 });
            list.Add(new Scatter3dSeriesData { X = 4, Y = 3, Z = 0 });
            list.Add(new Scatter3dSeriesData { X = 2, Y = 3, Z = 5 });
            list.Add(new Scatter3dSeriesData { X = 9, Y = 1, Z = 4 });
            list.Add(new Scatter3dSeriesData { X = 1, Y = 1, Z = 4 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 0, Z = 2 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 1, Z = 6 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 8, Z = 8 });
            list.Add(new Scatter3dSeriesData { X = 8, Y = 8, Z = 7 });
            list.Add(new Scatter3dSeriesData { X = 5, Y = 5, Z = 0 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 9, Z = 6 });
            list.Add(new Scatter3dSeriesData { X = 5, Y = 4, Z = 3 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 8, Z = 3 });
            list.Add(new Scatter3dSeriesData { X = 0, Y = 1, Z = 5 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 7, Z = 3 });
            list.Add(new Scatter3dSeriesData { X = 8, Y = 3, Z = 2 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 8, Z = 3 });
            list.Add(new Scatter3dSeriesData { X = 2, Y = 1, Z = 6 });
            list.Add(new Scatter3dSeriesData { X = 4, Y = 6, Z = 7 });
            list.Add(new Scatter3dSeriesData { X = 8, Y = 9, Z = 9 });
            list.Add(new Scatter3dSeriesData { X = 5, Y = 4, Z = 2 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 1, Z = 3 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 9, Z = 5 });
            list.Add(new Scatter3dSeriesData { X = 4, Y = 8, Z = 2 });
            list.Add(new Scatter3dSeriesData { X = 9, Y = 7, Z = 4 });
            list.Add(new Scatter3dSeriesData { X = 5, Y = 4, Z = 2 });
            list.Add(new Scatter3dSeriesData { X = 9, Y = 6, Z = 1 });
            list.Add(new Scatter3dSeriesData { X = 2, Y = 7, Z = 3 });
            list.Add(new Scatter3dSeriesData { X = 4, Y = 5, Z = 4 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 8, Z = 1 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 4, Z = 0 });
            list.Add(new Scatter3dSeriesData { X = 2, Y = 2, Z = 6 });
            list.Add(new Scatter3dSeriesData { X = 5, Y = 1, Z = 2 });
            list.Add(new Scatter3dSeriesData { X = 9, Y = 9, Z = 7 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 9, Z = 9 });
            list.Add(new Scatter3dSeriesData { X = 8, Y = 4, Z = 3 });
            list.Add(new Scatter3dSeriesData { X = 4, Y = 1, Z = 7 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 2, Z = 5 });
            list.Add(new Scatter3dSeriesData { X = 0, Y = 4, Z = 9 });
            list.Add(new Scatter3dSeriesData { X = 3, Y = 5, Z = 9 });
            list.Add(new Scatter3dSeriesData { X = 6, Y = 9, Z = 1 });
            list.Add(new Scatter3dSeriesData { X = 1, Y = 9, Z = 2 });

            ViewData["Data"] = list;

            return View();

        }

    }
}

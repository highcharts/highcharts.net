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
        public ActionResult Combo()
        {
            List<double?> johnValues = new List<double?> { 2, 3, 5, 7, 6 };
            List<double?> janeValues = new List<double?> { 3, 2, 1, 3, 4 };
            List<double?> joeValues = new List<double?> { 4, 3, 3, 9, 0 };
            List<double?> averageValues = new List<double?> { 3, 2.67, 3, 6.33, 3.33 };


            List<ColumnSeriesData> johnData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> janeData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> joeData = new List<ColumnSeriesData>();
            List<SplineSeriesData> averageData = new List<SplineSeriesData>();
            List<PieSeriesData> pieData = new List<PieSeriesData>();

            johnValues.ForEach(p => johnData.Add(new ColumnSeriesData { Y = p }));
            janeValues.ForEach(p => janeData.Add(new ColumnSeriesData { Y = p }));
            joeValues.ForEach(p => joeData.Add(new ColumnSeriesData { Y = p }));
            averageValues.ForEach(p => averageData.Add(new SplineSeriesData { Y = p }));

            pieData.Add(new PieSeriesData { Name = "Jane", Y = 13 });
            pieData.Add(new PieSeriesData { Name = "John", Y = 23 });
            pieData.Add(new PieSeriesData { Name = "Joe", Y = 19 });


            ViewData["johnData"] = johnData;
            ViewData["janeData"] = janeData;
            ViewData["joeData"] = joeData;
            ViewData["averageData"] = averageData;
            ViewData["pieData"] = pieData;

            return View();
        }
    }
}

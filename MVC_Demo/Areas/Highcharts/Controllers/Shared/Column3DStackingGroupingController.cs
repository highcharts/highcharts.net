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
        public ActionResult Column3DStackingGrouping()
        {
            List<double?> johnValues = new List<double?> { 5, 3, 4, 7, 2 };
            List<double?> janeValues = new List<double?> { 2, 5, 6, 2, 1 };
            List<double?> joeValues = new List<double?> { 3, 4, 4, 2, 5 };
            List<double?> janetValues = new List<double?> { 3, 0, 4, 4, 3 };

            List<ColumnSeriesData> johnData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> janeData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> joeData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> janetData = new List<ColumnSeriesData>();

            johnValues.ForEach(p => johnData.Add(new ColumnSeriesData { Y = p }));
            janeValues.ForEach(p => janeData.Add(new ColumnSeriesData { Y = p }));
            joeValues.ForEach(p => joeData.Add(new ColumnSeriesData { Y = p }));
            janetValues.ForEach(p => janetData.Add(new ColumnSeriesData { Y = p }));

            ViewData["johnData"] = johnData;
            ViewData["janeData"] = janeData;
            ViewData["joeData"] = joeData;
            ViewData["janetData"] = janetData;

            return View();
        }
    }
}

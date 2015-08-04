using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highcharts.Web.Mvc;


namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult ColumnRotatedLabels()
        {
            List<ColumnSeriesData> populationData = new List<ColumnSeriesData>();

            populationData.Add(new ColumnSeriesData { Name = "Shanghai", Y = 23.7 });
            populationData.Add(new ColumnSeriesData { Name = "Lagos", Y = 16.1 });
            populationData.Add(new ColumnSeriesData { Name = "Instanbul", Y = 14.2 });
            populationData.Add(new ColumnSeriesData { Name = "Karachi", Y = 14.0 });
            populationData.Add(new ColumnSeriesData { Name = "Mumbai", Y = 12.5 });
            populationData.Add(new ColumnSeriesData { Name = "Moscow", Y = 12.1 });
            populationData.Add(new ColumnSeriesData { Name = "Sao Paulo", Y = 11.8 });
            populationData.Add(new ColumnSeriesData { Name = "Beijing", Y = 11.7 });
            populationData.Add(new ColumnSeriesData { Name = "Guangzou", Y = 11.1 });
            populationData.Add(new ColumnSeriesData { Name = "Delhi", Y = 11.1 });
            populationData.Add(new ColumnSeriesData { Name = "Shenzen", Y = 10.5 });
            populationData.Add(new ColumnSeriesData { Name = "Seoul", Y = 10.4 });
            populationData.Add(new ColumnSeriesData { Name = "Jakarta", Y = 10.0 });
            populationData.Add(new ColumnSeriesData { Name = "Kinshasa", Y = 9.3 });
            populationData.Add(new ColumnSeriesData { Name = "Tianjin", Y = 9.3 });
            populationData.Add(new ColumnSeriesData { Name = "tokyo", Y = 9.0 });
            populationData.Add(new ColumnSeriesData { Name = "Cairo", Y = 8.9 });
            populationData.Add(new ColumnSeriesData { Name = "Mexico City", Y = 8.9 });
            populationData.Add(new ColumnSeriesData { Name = "Lima", Y = 8.9 });

            ViewData["populationData"] = populationData;

            return View();
        }
    }
}

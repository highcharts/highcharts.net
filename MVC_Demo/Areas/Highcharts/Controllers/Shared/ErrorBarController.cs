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
        public ActionResult ErrorBar()
        {
            List<double?> rainfallValues = new List<double?> { 49.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 };
            List<double?> temperatureValues = new List<double?> { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 };
            
            
            List<ColumnSeriesData> rainfallData = new List<ColumnSeriesData>();
            List<ErrorbarSeriesData> rainfallErrorData = new List<ErrorbarSeriesData>();
            List<SplineSeriesData> temperatureData = new List<SplineSeriesData>();
            List<ErrorbarSeriesData> temperatureErrorData = new List<ErrorbarSeriesData>();

            rainfallValues.ForEach(p => rainfallData.Add(new ColumnSeriesData { Y = p }));
            temperatureValues.ForEach(p => temperatureData.Add(new SplineSeriesData { Y = p }));


            rainfallErrorData.Add(new ErrorbarSeriesData { Low = 48, High = 51 });
            rainfallErrorData.Add(new ErrorbarSeriesData { Low = 68, High = 73 });
            rainfallErrorData.Add(new ErrorbarSeriesData { Low = 92, High = 110 });
            rainfallErrorData.Add(new ErrorbarSeriesData { Low = 128, High = 136 });
            rainfallErrorData.Add(new ErrorbarSeriesData { Low = 140, High = 150 });
            rainfallErrorData.Add(new ErrorbarSeriesData { Low = 171, High = 179 });
            rainfallErrorData.Add(new ErrorbarSeriesData { Low = 135, High = 143 });
            rainfallErrorData.Add(new ErrorbarSeriesData { Low = 142, High = 149 });
            rainfallErrorData.Add(new ErrorbarSeriesData { Low = 204, High = 220 });
            rainfallErrorData.Add(new ErrorbarSeriesData { Low = 189, High = 199 });
            rainfallErrorData.Add(new ErrorbarSeriesData { Low = 95, High = 110 });
            rainfallErrorData.Add(new ErrorbarSeriesData { Low = 52, High = 56 });

            temperatureErrorData.Add(new ErrorbarSeriesData { Low = 6, High = 8 });
            temperatureErrorData.Add(new ErrorbarSeriesData { Low = 5.9, High = 7.6 });
            temperatureErrorData.Add(new ErrorbarSeriesData { Low = 9.4, High = 10.4 });
            temperatureErrorData.Add(new ErrorbarSeriesData { Low = 14.1, High = 15.9 });
            temperatureErrorData.Add(new ErrorbarSeriesData { Low = 10.0, High = 20.1 });
            temperatureErrorData.Add(new ErrorbarSeriesData { Low = 21.0, High = 24.0 });
            temperatureErrorData.Add(new ErrorbarSeriesData { Low = 23.2, High = 25.3 });
            temperatureErrorData.Add(new ErrorbarSeriesData { Low = 26.1, High = 27.8 });
            temperatureErrorData.Add(new ErrorbarSeriesData { Low = 23.2, High = 23.9 });
            temperatureErrorData.Add(new ErrorbarSeriesData { Low = 18.0, High = 21.1 });
            temperatureErrorData.Add(new ErrorbarSeriesData { Low = 12.9, High = 14.0 });
            temperatureErrorData.Add(new ErrorbarSeriesData { Low = 7.6, High = 10.0 });

            ViewData["rainfallData"] = rainfallData;
            ViewData["rainfallErrorData"] = rainfallErrorData;
            ViewData["temperatureData"] = temperatureData;
            ViewData["temperatureErrorData"] = temperatureErrorData;

            return View();
        }      
    }
}

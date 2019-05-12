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
        public ActionResult ColumnPlacement()
        {
            List<double> employeeValues = new List<double> { 150, 73, 20 };
            List<double> employeeOptimizedValues = new List<double> { 140, 90, 40 };
            List<double> profitValues = new List<double> { 183.6, 178.8, 198.5 };
            List<double> profitOptimizedValues = new List<double> { 203.6, 198.8, 208.5 };
            List<ColumnSeriesData> employeeData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> employeeOptimizedData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> profitData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> profitOptimizedData = new List<ColumnSeriesData>();

            employeeValues.ForEach(p => employeeData.Add(new ColumnSeriesData { Y = p }));
            employeeOptimizedValues.ForEach(p => employeeOptimizedData.Add(new ColumnSeriesData { Y = p }));
            profitValues.ForEach(p => profitData.Add(new ColumnSeriesData { Y = p }));
            profitOptimizedValues.ForEach(p => profitOptimizedData.Add(new ColumnSeriesData { Y = p }));

            ViewData["employeeData"] = employeeData;
            ViewData["employeeOptimizedData"] = employeeOptimizedData;
            ViewData["profitData"] = profitData;
            ViewData["profitOptimizedData"] = profitOptimizedData;

            return View();
        }
    }
}

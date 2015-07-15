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
        public ActionResult AreaRangeLine()
        {
            List<ArearangeSeriesData> ranges = new List<ArearangeSeriesData>();
            List<LineSeriesData> temperatures = new List<LineSeriesData>();

            ranges.Add(ValuesToRange(1246406400000, 14.3, 27.7));
            ranges.Add(ValuesToRange(1246492800000, 14.5, 27.8));
            ranges.Add(ValuesToRange(1246579200000, 15.5, 29.6));
            ranges.Add(ValuesToRange(1246665600000, 16.7, 30.7));
            ranges.Add(ValuesToRange(1246752000000, 16.5, 25.0));
            ranges.Add(ValuesToRange(1246838400000, 17.8, 25.7));
            ranges.Add(ValuesToRange(1246924800000, 13.5, 24.8));
            ranges.Add(ValuesToRange(1247011200000, 10.5, 21.4));
            ranges.Add(ValuesToRange(1247097600000, 9.2, 23.8));
            ranges.Add(ValuesToRange(1247184000000, 11.6, 21.8));
            ranges.Add(ValuesToRange(1247270400000, 10.7, 23.7));
            ranges.Add(ValuesToRange(1247356800000, 11.0, 23.3));
            ranges.Add(ValuesToRange(1247443200000, 11.6, 23.7));
            ranges.Add(ValuesToRange(1247529600000, 11.8, 20.7));
            ranges.Add(ValuesToRange(1247616000000, 12.6, 22.4));
            ranges.Add(ValuesToRange(1247702400000, 13.6, 19.6));
            ranges.Add(ValuesToRange(1247788800000, 11.4, 22.6));
            ranges.Add(ValuesToRange(1247875200000, 13.2, 25.0));
            ranges.Add(ValuesToRange(1247961600000, 14.2, 21.6));
            ranges.Add(ValuesToRange(1248048000000, 13.1, 17.1));
            ranges.Add(ValuesToRange(1248134400000, 12.2, 15.5));
            ranges.Add(ValuesToRange(1248220800000, 12.0, 20.8));
            ranges.Add(ValuesToRange(1248307200000, 12.0, 17.1));
            ranges.Add(ValuesToRange(1248393600000, 12.7, 18.3));
            ranges.Add(ValuesToRange(1248480000000, 12.4, 19.4));
            ranges.Add(ValuesToRange(1248566400000, 12.6, 19.9));
            ranges.Add(ValuesToRange(1248652800000, 11.9, 20.2));
            ranges.Add(ValuesToRange(1248739200000, 11.0, 19.3));
            ranges.Add(ValuesToRange(1248825600000, 10.8, 17.8));
            ranges.Add(ValuesToRange(1248912000000, 11.8, 18.5));
            ranges.Add(ValuesToRange(1248998400000, 10.8, 16.1));           

            temperatures.Add(ValuesToLine(1246406400000, 21.5));
            temperatures.Add(ValuesToLine(1246492800000, 22.1));
            temperatures.Add(ValuesToLine(1246579200000, 23));
            temperatures.Add(ValuesToLine(1246665600000, 23.8));
            temperatures.Add(ValuesToLine(1246752000000, 21.4));
            temperatures.Add(ValuesToLine(1246838400000, 21.3));
            temperatures.Add(ValuesToLine(1246924800000, 18.3));
            temperatures.Add(ValuesToLine(1247011200000, 15.4));
            temperatures.Add(ValuesToLine(1247097600000, 16.4));
            temperatures.Add(ValuesToLine(1247184000000, 17.7));
            temperatures.Add(ValuesToLine(1247270400000, 17.5));
            temperatures.Add(ValuesToLine(1247356800000, 17.6));
            temperatures.Add(ValuesToLine(1247443200000, 17.7));
            temperatures.Add(ValuesToLine(1247529600000, 16.8));
            temperatures.Add(ValuesToLine(1247616000000, 17.7));
            temperatures.Add(ValuesToLine(1247702400000, 16.3));
            temperatures.Add(ValuesToLine(1247788800000, 17.8));
            temperatures.Add(ValuesToLine(1247875200000, 18.1));
            temperatures.Add(ValuesToLine(1247961600000, 17.2));
            temperatures.Add(ValuesToLine(1248048000000, 14.4));
            temperatures.Add(ValuesToLine(1248134400000, 13.7));
            temperatures.Add(ValuesToLine(1248220800000, 15.7));
            temperatures.Add(ValuesToLine(1248307200000, 14.6));
            temperatures.Add(ValuesToLine(1248393600000, 15.3));
            temperatures.Add(ValuesToLine(1248480000000, 15.3));
            temperatures.Add(ValuesToLine(1248566400000, 15.8));
            temperatures.Add(ValuesToLine(1248652800000, 15.2));
            temperatures.Add(ValuesToLine(1248739200000, 14.8));
            temperatures.Add(ValuesToLine(1248825600000, 14.4));
            temperatures.Add(ValuesToLine(1248912000000, 15));
            temperatures.Add(ValuesToLine(1248998400000, 13.6));

            ViewData["rangeData"] = ranges;
            ViewData["temperatureData"] = temperatures;

            return View();
        }

        private ArearangeSeriesData ValuesToRange(double x, double low, double high)
        {
            return new ArearangeSeriesData { X = x, Low = low, High = high };
        }

        private LineSeriesData ValuesToLine(double x, double y)
        {
            return new LineSeriesData {X = x, Y = y };
        }
    }
}

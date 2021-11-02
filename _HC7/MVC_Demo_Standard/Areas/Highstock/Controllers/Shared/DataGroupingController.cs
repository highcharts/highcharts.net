using Highsoft.Web.Mvc.Stocks;
using Highsoft.Web.Mvc.Stocks.Rendering;
using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Areas.Highstock.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult DataGrouping()
        {
            var data = DataReceiver.GetGroupingData();


            var chartOptions = new Highsoft.Web.Mvc.Stocks.Highstock
            {
                Chart = new Highsoft.Web.Mvc.Stocks.Chart
                {
                    ZoomType = ChartZoomType.X
                },
                RangeSelector = new RangeSelector
                {
                    Buttons = new List<RangeSelectorButton>() { new RangeSelectorButton() { Type = "day", Count = 3, Text = "3d" }, new RangeSelectorButton() { Type = "week", Count = 1, Text = "1w" }, new RangeSelectorButton() { Type = "month", Count = 1, Text = "1m" }, new RangeSelectorButton() { Type = "month", Count = 6, Text = "6m" }, new RangeSelectorButton() { Type = "month", Count = 12, Text = "1y" } },
                    Selected = 1
                },
                YAxis = new List<YAxis>
                {
                    new YAxis
                    {
                        Title = new YAxisTitle
                        {
                            Text = "Temperature (°C)"
                        }
                    }
                },
                XAxis = new List<XAxis>
                {
                    new XAxis
                    {
                        Ordinal = false
                    }
                },
                Title = new Title
                {
                    Text = "Hourly temperatures in Vik i Sogn, Norway, 2009-2015"
                },
                Series = new List<Series>
              {
                new LineSeries
                {
                   Name = "Temperature",
                   TurboThreshold = 100000,
                   PointStart = 1230764400000,
                   PointInterval = 3600000,
                   Tooltip = new LineSeriesTooltip
                   {
                       ValueDecimals = 1,
                       ValueSuffix = "°C"
                   },
                   Data = data.ToList()
                }
            }
            };

            chartOptions.ID = "chart";
            var renderer = new HighstockRenderer(chartOptions);
            ViewData["ChartScript"] = renderer.RenderHtml();

            return View();
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;
using System.Collections.Generic;

namespace Highsoft.Web.Mvc.UnitTests
{
    [TestClass]
    public class Events
    {
        Highcharts _chart;
        HighchartsRenderer _renderer;

        [TestInitialize]
        public void Init()
        {
            _chart = new Highcharts();
            _renderer = new HighchartsRenderer(_chart);
        }

        [TestMethod]
        public void FormatterShouldRenderWithoutQuotes()
        {            
            _chart.Chart.Type = ChartType.Area;
            _chart.XAxis = new List<XAxis>();
            _chart.XAxis.Add(new XAxis());
            _chart.XAxis[0].Labels.Formatter = "formatXLabels";

            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"formatter\":formatXLabels"));            
        }

        [TestMethod]
        public void FormattersWithSameName()
        {
            _chart.Chart.Type = ChartType.Area;

            _chart.XAxis = new List<XAxis>();
            _chart.XAxis.Add(new XAxis());
            _chart.XAxis[0].Labels.Formatter = "formatXLabels";

            _chart.YAxis = new List<Highsoft.Web.Mvc.Charts.YAxis>();
            _chart.YAxis.Add(new Highsoft.Web.Mvc.Charts.YAxis());
            _chart.YAxis[0].Labels.Formatter = "formatYLabels";

            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"formatter\":formatXLabels"));
            Assert.IsTrue(json.Contains("\"formatter\":formatYLabels"));
        }
    }
}

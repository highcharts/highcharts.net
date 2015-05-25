using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Highsoft.Web.Mvc;
using Highsoft.Web.Mvc.Rendering;

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
            _chart.XAxis.Labels.Formatter = "formatXLabels";

            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"formatter\":formatXLabels"));            
        }

        [TestMethod]
        public void FormattersWithSameName()
        {
            _chart.Chart.Type = ChartType.Area;
            _chart.XAxis.Labels.Formatter = "formatXLabels";
            _chart.YAxis.Labels.Formatter = "formatYLabels";

            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"formatter\":formatXLabels"));
            Assert.IsTrue(json.Contains("\"formatter\":formatYLabels"));
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;

namespace Highsoft.Web.Mvc.UnitTests
{
    [TestClass]
    public class Chart
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
        public void TestAreaType()
        {
            _chart.Chart.SpacingLeft = 10;
            _chart.Chart.Type = ChartType.Area;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"type\":\"area\""));            
        }

        [TestMethod]
        public void TestPieType()
        {
            _chart.Chart.Type = ChartType.Pie;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"type\":\"pie\""));
        }

        [TestMethod]
        public void TestDefaultType() // should be line
        {
            string json = _renderer.RenderHtml();

            Assert.IsFalse(json.Contains("\"type\":\"line\""));
        }

        [TestMethod]
        public void TestEnumMappings() // should be line
        {
            _chart.Exporting.Type = ExportingType.Applicationpdf;
            string json = _renderer.RenderHtml();

            Assert.IsFalse(json.Contains("\"type\":\"application/pdf\""));
        }        
    }
}

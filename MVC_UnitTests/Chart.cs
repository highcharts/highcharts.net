using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Highsoft.Web.Mvc;
using Highsoft.Web.Mvc.Rendering;

namespace Highsoft.Web.Mvc.UnitTests
{
    [TestClass]
    public class Chart
    {
        Highcharts chart;
        HighchartsRenderer renderer;

        [TestInitialize]
        public void Init()
        {
            chart = new Highcharts();
            renderer = new HighchartsRenderer(chart);
        }

        [TestMethod]
        public void TestAreaType()
        {
            ///chart.Chart.Type = ChartType;
            ///
            chart.Chart.SpacingLeft = 10;
            chart.Chart.Type = ChartType.Area;
            string json = renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"type\":\"area\""));            
        }

        [TestMethod]
        public void TestPieType()
        {
            chart.Chart.Type = ChartType.Pie;
            string json = renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"type\":\"pie\""));
        }

        [TestMethod]
        public void TestDefaultType() // should be line
        {
            string json = renderer.RenderHtml();

            Assert.IsFalse(json.Contains("\"type\":\"line\""));
        }
    }
}

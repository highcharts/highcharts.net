using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HighSoft.Web.Mvc;
using HighSoft.Web.Mvc.Rendering;

namespace HighSoft.Web.Mvc.UnitTests
{
    [TestClass]
    public class Chart
    {
        HighCharts chart;
        HighChartsRenderer renderer;

        [TestInitialize]
        public void Init()
        {
            chart = new HighCharts();
            renderer = new HighChartsRenderer(chart);
        }

        [TestMethod]
        public void TestBarType()
        {
            chart.Chart.Type = "Bar";
            string json = renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"type\":\"Bar\""));            
        }

        [TestMethod]
        public void TestPieType()
        {
            chart.Chart.Type = "Pie";
            string json = renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"type\":\"Pie\""));
        }

        [TestMethod]
        public void TestDefaultType() // should be line
        {
            string json = renderer.RenderHtml();

            Assert.IsFalse(json.Contains("\"type\":\"line\""));
        }
    }
}

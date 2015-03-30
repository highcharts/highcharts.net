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
    }
}

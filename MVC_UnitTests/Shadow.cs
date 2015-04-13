using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Highsoft.Web.Mvc;
using Highsoft.Web.Mvc.Rendering;

namespace Highsoft.Web.Mvc.UnitTests
{
    [TestClass]
    public class Shadow
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
        public void TestDefault()
        {            
            string json = _renderer.RenderHtml();

            Assert.IsFalse(json.Contains("plotShadow"));
        }

        [TestMethod]
        public void TestBooleanTrue()
        {
            _chart.Chart.PlotShadow.Enabled = true;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"plotShadow\":true"));            
        }

        [TestMethod]
        public void TestOffsetX()
        {
            _chart.Chart.PlotShadow.OffsetX = 335;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"offsetX\":335"));
        }

        [TestMethod]
        public void TestOffsetY()
        {
            _chart.Chart.PlotShadow.OffsetY = -135;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"offsetY\":-135"));
        }

        [TestMethod]
        public void TestOpacity()
        {
            _chart.Chart.PlotShadow.Opacity = 0.125;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"opacity\":0.125"));
        }

        [TestMethod]
        public void TestWidth()
        {
            _chart.Chart.PlotShadow.Width = 225;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"width\":225"));
        }
    }
}

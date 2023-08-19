using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;

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
        public void TestBooleanPolarTrue()
        {
            _chart.Chart.Polar = true;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"polar\":true"));            
        }

        [TestMethod]
        public void TestAlignTicks()
        {
            _chart.Chart.AlignTicks = false;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"alignTicks\":false"));
        }

        [TestMethod]
        public void TestAlignTicksDefaultValue()
        {
            _chart.Chart.AlignTicks = true;
            string json = _renderer.RenderHtml();

            Assert.IsFalse(json.Contains("alignTicks"));
        }

        [TestMethod]
        public void TestSpacingLeft()
        {
            _chart.Chart.SpacingLeft = 335;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"spacingLeft\":335"));
        }

        [TestMethod]
        public void TestSpacingTop()
        {
            _chart.Chart.SpacingTop = -135;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"spacingTop\":-135"));
        }

        [TestMethod]
        public void TestHeight()
        {
            _chart.Chart.HeightNumber = 225;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"height\":225"));
        }

        [TestMethod]
        public void TestWidth()
        {
            _chart.Chart.Width = "225";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"width\":\"225\""));
        }

        [TestMethod]
        public void TestBorderColor()
        {
            _chart.Chart.BorderColor = "#FFFFFF";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"borderColor\":\"#FFFFFF\""));
        }

        [TestMethod]
        public void TestBackgroundColor()
        {
            _chart.Chart.BackgroundColor = "#AAAAAA";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"backgroundColor\":\"#AAAAAA\""));
        }

       
    }
}

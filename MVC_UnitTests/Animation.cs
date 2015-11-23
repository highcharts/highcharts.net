using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;

namespace Highsoft.Web.Mvc.UnitTests
{
    [TestClass]
    public class Animation
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

            Assert.IsFalse(json.Contains("animation"));
        }

        [TestMethod]
        public void TestBooleanFalse()
        {
            _chart.Chart.Animation.Enabled = false;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"animation\":false"));            
        }

        [TestMethod]
        public void TestDuration()
        {
            _chart.Chart.Animation.Duration = 775;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"duration\":775"));
        }

        [TestMethod]
        public void TestEasing()
        {
            _chart.Chart.Animation.Easing = "cube";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"easing\":\"cube\""));
        }

        
    }
}

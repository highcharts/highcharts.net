using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;

namespace Highsoft.Web.Mvc.UnitTests
{
    [TestClass]
    public class AnimationTest
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
        public void Test_IfAnimationEnableWorks_Correct()
        {
            _chart.Chart.Animation = new Animation { Enabled = true };
            var json = _renderer.RenderHtml();

            Assert.IsTrue(!json.Contains("\"animation\""));
        }

        [TestMethod]
        public void Test_IfAnimationDisableWorks_Correct()
        {
            _chart.Chart.Animation = new Animation { Enabled = false };
            var json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"animation\":false"));
        }

        [TestMethod]
        public void Test_IfAnimationDurationWorks_Correct()
        {
            _chart.Chart.Animation = new Animation { Duration = 200 };
            var json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"animation\":{\"duration\":200}"));
        }

        [TestMethod]
        public void Test_IfAnimationDeferWorks_Correct()
        {
            _chart.Chart.Animation = new Animation { Defer = 200 };
            var json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"animation\":{\"defer\":200}"));
        }

        [TestMethod]
        public void Test_IfAnimationEasingWorks_Correct()
        {
            _chart.Chart.Animation = new Animation { Easing = "easeOutBounce" };
            var json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"animation\":{\"easing\":\"easeOutBounce\"}"));
        }
    }
}

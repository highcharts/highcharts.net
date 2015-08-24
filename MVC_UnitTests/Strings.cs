using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Highcharts.Web.Mvc;
using Highcharts.Web.Mvc.Rendering;

namespace Highsoft.Web.Mvc.UnitTests
{
    [TestClass]
    public class Strings
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
        public void TestForNull()
        {
            _chart.Subtitle.Text = null;
            string json = _renderer.RenderHtml();

            Assert.IsFalse(json.Contains("\"text\":\"null\""));
            Assert.IsFalse(json.Contains("\"text\":null"));
            Assert.IsFalse(json.Contains("\"text\""));
        }

        [TestMethod]
        public void TestFrench()
        {
            _chart.Legend.LabelFormat = "Départementales à Mayotte : un électeur fraudeur pris la main dans le sac";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"labelFormat\":\"Départementales à Mayotte : un électeur fraudeur pris la main dans le sac\""));
        }

        [TestMethod]
        public void TestNorwegian()
        {
            _chart.Legend.LabelFormat = "Verksemda er ein del av næringsklynga ";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"labelFormat\":\"Verksemda er ein del av næringsklynga \""));
        }

        [TestMethod]
        public void TestJapanese()
        {
            _chart.Legend.LabelFormat = "ブラック企業 国が特別対策班";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"labelFormat\":\"ブラック企業 国が特別対策班\""));
        }

        [TestMethod]
        public void TestLegendLabelFormat()
        {
            _chart.Legend.LabelFormat = "%d";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"labelFormat\":\"%d\""));
        }

        [TestMethod]
        public void TestTitleText()
        {
            _chart.Title.Text = "Temperature";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"text\":\"Temperature\""));
        }

        [TestMethod]
        public void TestPlotOptionsAreaColor()
        {
            _chart.PlotOptions.Area.Color = "#FFAADD";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"color\":\"#FFAADD\""));
        }
    }
}

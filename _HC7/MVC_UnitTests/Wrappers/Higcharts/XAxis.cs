using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace Highsoft.Web.Mvc.UnitTests
{
    [TestClass]
    public class Xaxis
    {
        Highsoft.Web.Mvc.Charts.Highcharts _chart;
        HighchartsRenderer _renderer;
        Highsoft.Web.Mvc.Charts.XAxis _axis;

        [TestInitialize]
        public void Init()
        {
            _chart = new Highcharts();
            _renderer = new HighchartsRenderer(_chart);

            _chart.XAxis = new List<Highsoft.Web.Mvc.Charts.XAxis>();
            _chart.XAxis.Add(new Highsoft.Web.Mvc.Charts.XAxis());

            _axis = _chart.XAxis[0];
        }

        [TestMethod]
        public void TestBooleanPolarTrue()
        {
            _axis.AllowDecimals = false;            
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"allowDecimals\":false"));
        }

        [TestMethod]
        public void TestAlternateGridColor()
        {
            _axis.AlternateGridColor = "#AAAAAA";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"alternateGridColor\":\"#AAAAAA\""));
        }

        [TestMethod]
        public void TestCategories()
        {
            _axis.Categories = new List<string>();
            _axis.Categories.Add("Apples");

            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("Apples"));
        }

        [TestMethod]
        public void TestCategoriesMultiple()
        {
            _axis.Categories = new List<string>();
            _axis.Categories.Add("Apples");
            _axis.Categories.Add("Orange");
            _axis.Categories.Add("Pears");

            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("Apples"));
            Assert.IsTrue(json.Contains("Orange"));
            Assert.IsTrue(json.Contains("Pears"));
        }

        [TestMethod]
        public void TestCeiling()
        {
            _axis.Ceiling = 150;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"ceiling\":150"));
        }

        [TestMethod]
        public void TestEndOnTick()
        {
            _axis.EndOnTick = true;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"endOnTick\":true"));
        }

        [TestMethod]
        public void TestFloor()
        {
            _axis.Floor = 500;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"floor\":500"));
        }

        [TestMethod]
        public void TestGridLineColor()
        {
            _axis.GridLineColor = "#BBBBBB";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"gridLineColor\":\"#BBBBBB\""));
        }

        //[TestMethod]
        //public void TestGridLineDashStyle()
        //{
        //    _axis.GridLineDashStyle = XAxisGridLineDashStyle.LongDash;
        //    string json = _renderer.RenderHtml();

        //    Assert.IsTrue(json.Contains("longDash"));
        //}

        //[TestMethod]
        //public void TestGridLineDashStyleShortDashShot()
        //{
        //    _axis.GridLineDashStyle = XAxisGridLineDashStyle.ShortDashDot;
        //    string json = _renderer.RenderHtml();

        //    Assert.IsTrue(json.Contains("shortDashDot"));
        //}

        //[TestMethod]
        //public void TestGridLineDashStyleDot()
        //{
        //    _axis.GridLineDashStyle = XAxisGridLineDashStyle.Dot;
        //    string json = _renderer.RenderHtml();

        //    Assert.IsTrue(json.Contains("dot"));
        //}

        [TestMethod]
        public void TestGridLineWidth()
        {
            _axis.GridLineWidth = 500;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"gridLineWidth\":500"));
        }

        [TestMethod]
        public void TestGridZIndex()
        {
            _axis.GridZIndex = 500;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"gridZIndex\":500"));
        }

        [TestMethod]
        public void TestID()
        {
            _axis.Id = "Temperature";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"id\":\"Temperature\""));
        }

        [TestMethod]
        public void TestLineColor()
        {
            _axis.LineColor = "#CCDDCC";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"lineColor\":\"#CCDDCC\""));
        }

        [TestMethod]
        public void TestLineWidth()
        {
            _axis.LineWidth = 150; ;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"lineWidth\":150"));
        }

        [TestMethod]
        public void TestLinkedTo()
        {
            _axis.LinkedTo = 3; ;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"linkedTo\":3"));
        }

        [TestMethod]
        public void TestMax()
        {
            _axis.Max = 300; ;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"max\":300"));
        }

        [TestMethod]
        public void TestMin()
        {
            _axis.Min = 300; ;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"min\":300"));
        }

        [TestMethod]
        public void TestMaxPadding()
        {
            _axis.MaxPadding = 300; ;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"maxPadding\":300"));
        }

        [TestMethod]
        public void TestMinorGridLineColor()
        {
            _axis.MinorGridLineColor = "#AAAAAA"; ;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"minorGridLineColor\":\"#AAAAAA\""));
        }

        //[TestMethod]
        //public void TestMinorGridLineDashStyle()
        //{
        //    _axis.MinorGridLineDashStyle = XAxisMinorGridLineDashStyle.LongDash;
        //    string json = _renderer.RenderHtml();

        //    Assert.IsTrue(json.Contains("\"minorGridLineDashStyle\":\"longDash\""));
        //}

        //[TestMethod]
        //public void TestMinorGridLineDashStyleShortDash()
        //{
        //    _axis.MinorGridLineDashStyle = XAxisMinorGridLineDashStyle.ShortDash;
        //    string json = _renderer.RenderHtml();

        //    Assert.IsTrue(json.Contains("\"minorGridLineDashStyle\":\"shortDash\""));
        //}

        //[TestMethod]
        //public void TestMinorGridLineDashStyleDot()
        //{
        //    _axis.MinorGridLineDashStyle = XAxisMinorGridLineDashStyle.Dot;
        //    string json = _renderer.RenderHtml();

        //    Assert.IsTrue(json.Contains("\"minorGridLineDashStyle\":\"dot\""));
        //}

        [TestMethod]
        public void TestMinorGridLineWidth()
        {
            _axis.MinorGridLineWidth = 100;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"minorGridLineWidth\":100"));
        }

        [TestMethod]
        public void TestMinorTickInterval()
        {
            _axis.MinorTickIntervalNumber = 100;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"minorTickInterval\":100"));
        }

        [TestMethod]
        public void TestMinorTickLength()
        {
            _axis.MinorTickLength = 100;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"minorTickLength\":100"));
        }

        [TestMethod]
        public void TestMinorTickWidth()
        {
            _axis.MinorTickWidth = 100;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"minorTickWidth\":100"));
        }

        [TestMethod]
        public void ТеstMinPadding()
        {
            _axis.MinPadding = 100;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"minPadding\":100"));
        }

        [TestMethod]
        public void TestMinRange()
        {
            _axis.MinRange = 100;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"minRange\":100"));
        }

        [TestMethod]
        public void TestMinTickInterval()
        {
            _axis.MinTickInterval = 100;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"minTickInterval\":100"));
        }

        [TestMethod]
        public void TestOffset()
        {
            _axis.Offset = 600;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"offset\":600"));
        }

        [TestMethod]
        public void TestOpposite()
        {
            _axis.Opposite = true;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"opposite\":true"));
        }

        [TestMethod]
        public void TestReversed()
        {
            _axis.Reversed = true;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"reversed\":true"));
        }

        [TestMethod]
        public void TestShowEmpty()
        {
            _axis.ShowEmpty = false;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"showEmpty\":false"));
        }

        [TestMethod]
        public void TestShowFirstLabel()
        {
            _axis.ShowFirstLabel = false;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"showFirstLabel\":false"));
        }

        [TestMethod]
        public void TestShowLastLabel()
        {
            _axis.ShowLastLabel = false;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"showLastLabel\":false"));
        }

        [TestMethod]
        public void TestStartOfWeek()
        {
            _axis.StartOfWeek = 3;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"startOfWeek\":3"));
        }

        [TestMethod]
        public void TestStartOnTick()
        {
            _axis.StartOnTick = true;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"startOnTick\":true"));
        }

        [TestMethod]
        public void TestTickAmount()
        {
            _axis.TickAmount = 500;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"tickAmount\":500"));
        }

        [TestMethod]
        public void TestTickColor()
        {
            _axis.TickColor = "#111111";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"tickColor\":\"#111111\""));
        }

        [TestMethod]
        public void TestTickInterval()
        {
            _axis.TickInterval = 50;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"tickInterval\":50"));
        }      

        [TestMethod]
        public void TestTickLength()
        {
            _axis.TickLength = 50;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"tickLength\":50"));
        }

        [TestMethod]
        public void TestTickmarkPlacement()
        {
            _axis.TickmarkPlacement = XAxisTickmarkPlacement.On;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("on"));
        }

        [TestMethod]
        public void ТестTickWidth()
        {
            _axis.TickWidth = 500;
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"tickWidth\":500"));
        }

        [TestMethod]
        public void TestTitle()
        {
            _axis.Title = new XAxisTitle();
            _axis.Title.Text = "Temperatures";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"text\":\"Temperatures\""));
        }


        [TestMethod]
        public void TestType()
        {
            _axis.Type = "logarithmic";
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("logarithmic"));
        }

    }
}
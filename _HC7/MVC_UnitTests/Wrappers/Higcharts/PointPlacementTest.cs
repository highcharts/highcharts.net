using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;

namespace MVC_UnitTests.Wrappers.Higcharts
{
    [TestClass]
    public class PointPlacementTest
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
        public void Test_IfPointPlacementIsString_Correct()
        {
            _chart.Series = new List<Series>();
            _chart.Series.Add(new LineSeries { PointPlacement = LineSeriesPointPlacement.Between });
            var json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"pointPlacement\":\"between\""));
        }

        [TestMethod]
        public void Test_IfPointPlacementIsNumber_Correct()
        {
            _chart.Series = new List<Series>();
            _chart.Series.Add(new LineSeries { PointPlacementNumber = 0.5 });
            var json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"pointPlacement\":0.5"));
        }


    }
}

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

        [TestInitialize]
        public void Init()
        {
            _chart = new Highcharts();
            _renderer = new HighchartsRenderer(_chart);

            _chart.XAxis = new List<Highsoft.Web.Mvc.Charts.XAxis>();
            _chart.XAxis.Add(new Highsoft.Web.Mvc.Charts.XAxis());
        }

        [TestMethod]
        public void TestBooleanPolarTrue()
        {
            

            _chart.XAxis[0].AllowDecimals = false;            
            string json = _renderer.RenderHtml();

            Assert.IsTrue(json.Contains("\"allowDecimals\":false"));
        }
    }
}

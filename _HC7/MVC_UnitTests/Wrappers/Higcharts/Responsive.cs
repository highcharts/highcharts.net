using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace MVC_UnitTests.Wrappers.Higcharts
{
    [TestClass]
    public class Responsive
    {
        Highsoft.Web.Mvc.Charts.Highcharts _chart;
        HighchartsRenderer _renderer;
        Highsoft.Web.Mvc.Charts.ResponsiveRules _responsiveRules;

        [TestInitialize]
        public void Init()
        {
            _responsiveRules = new ResponsiveRules() { ChartOptions = (new Legend() { X = -15, Y = 260, Floating = true }) };
        }

        [TestMethod]
        public void ChartOptionsLowerCaseTrue()
        {
            string json = _responsiveRules.ToString();

            Assert.IsTrue(json.Contains("\"allowDecimals\":false"));
        }
    }
}

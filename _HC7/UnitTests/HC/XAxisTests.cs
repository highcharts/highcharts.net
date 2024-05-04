using System;
using System.Collections.Generic;
using Xunit;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;
using System.Collections;
using System.Globalization;
using TH = Tests.Helpers.TestHelper;
using UnitTests.HC;

namespace HC.Axes
{
    public class XAxisTests : IClassFixture<HcFixture>
    {
        protected HcFixture _fixture;

        public XAxisTests(HcFixture fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Line;
        }

        [Theory]
        [InlineData(1, 2, 3, 4)]
        [InlineData(5, 2, 30, 5)]
        public void Test_IfXAxisBreaksRenders_Correct(double breakSize, double from, double to, double repeat)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.XAxis = new List<XAxis> { new XAxis { Breaks = new List<XAxisBreaks> { new XAxisBreaks() { BreakSize = breakSize, From = from, To = to, Repeat = repeat } } } };

            var result = renderer.RenderHtml();

            //Test should be updated...
            Assert.Contains("breaks", result);
        }

        [Theory]
        [InlineData(XAxisTitleAlign.Low)]
        [InlineData(XAxisTitleAlign.High)]
        public void Test_IfXAxisTitleAlignRenders_Correct(XAxisTitleAlign titleAlign)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.XAxis = new List<XAxis> { new XAxis { Title = new XAxisTitle() { Align = titleAlign } } };

            var result = renderer.RenderHtml();

            Assert.Contains($"\"title\":{{\"align\":\"{chart.FirstCharacterToLower(titleAlign.ToString())}\"}}", result);
        }

        [Fact]
        public void Test_IfXAxisTitleAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = XAxisTitleAlign.Middle;

            chart.XAxis = new List<XAxis> { new XAxis { Title = new XAxisTitle() { Align = defaultValue } } };

            var result = renderer.RenderHtml();

            Assert.DoesNotContain("align", result);
        }
    }
}

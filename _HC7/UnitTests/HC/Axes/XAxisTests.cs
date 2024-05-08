using System;
using System.Collections.Generic;
using Xunit;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;
using System.Collections;
using System.Globalization;
using TH = Tests.Helpers.TestHelper;
using UnitTests.HC;
using Tests.Helpers;

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

            Assert.Contains("\"breaks\":[{", result);
            Assert.Contains(TH.GetPropertyString(nameof(to), to), result);
            Assert.Contains(TH.GetPropertyString(nameof(from), from), result);
            Assert.Contains(TH.GetPropertyString(nameof(breakSize), breakSize), result);
            Assert.Contains(TH.GetPropertyString(nameof(repeat), repeat), result);
        }

        [Theory]
        [InlineData(XAxisTitleAlign.Low)]
        [InlineData(XAxisTitleAlign.High)]
        public void Test_IfXAxisTitleAlignRenders_Correct(XAxisTitleAlign titleAlign)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.XAxis = new List<XAxis> { new XAxis { Title = new XAxisTitle() { Align = titleAlign } } };

            Assert.Contains($"\"title\":{{\"align\":\"{chart.FirstCharacterToLower(titleAlign.ToString())}\"}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfXAxisTitleAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = XAxisTitleAlign.Middle;

            chart.XAxis = new List<XAxis> { new XAxis { Title = new XAxisTitle() { Align = defaultValue } } };

            Assert.DoesNotContain("align", renderer.RenderHtml());
        }
    }
}

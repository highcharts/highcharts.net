using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;
using System.Collections;
using System.Globalization;
using TH = Tests.Helpers.TestHelper;
using UnitTests.HC;


namespace HC.Series
{
    public class Pyramid3dSeriesTests : IClassFixture<HcFixture>
    {
        protected HcFixture _fixture;

        public Pyramid3dSeriesTests(HcFixture fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Pyramid3d;
        }

        [Fact]
        public void Test_IfSeriesRendersType_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var series = new Pyramid3dSeries();
            chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            var result = renderer.RenderHtml();

            Assert.Contains($"\"series\":[{{\"type\":\"{_fixture.ChartType.ToString().ToLower()}\"", result);
        }

        [Theory]
        [InlineData(250)]
        public void Test_IfAnimationLimitRenders_Correct(int limit)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); 
            var series = new Pyramid3dSeries(); 
            chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((Pyramid3dSeries)chart.Series[0]).AnimationLimit = limit;

            Assert.Contains($"\"animationLimit\":{limit}.0", renderer.RenderHtml());
        }
    }
}
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
    public class ParetoSeriesTests : IClassFixture<HcFixture>
    {
        protected HcFixture _fixture;

        public ParetoSeriesTests(HcFixture fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Pareto;
        }

        [Fact]
        public void Test_IfSeriesRendersType_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var series = new ParetoSeries();
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
            var series = new ParetoSeries(); 
            chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((ParetoSeries)chart.Series[0]).AnimationLimit = limit;

            Assert.Contains($"\"animationLimit\":{limit}.0", renderer.RenderHtml());
        }
    }
}
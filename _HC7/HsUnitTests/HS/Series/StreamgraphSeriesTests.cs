using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Highsoft.Web.Mvc.Stocks;
using Highsoft.Web.Mvc.Stocks.Rendering;
using System.Collections;
using System.Globalization;
using TH = Tests.Helpers.TestHelper;
using UnitTests.HS;


namespace HS.Series
{
    public class StreamgraphSeriesTests : IClassFixture<HsFixture>
    {
        protected HsFixture _fixture;

        public StreamgraphSeriesTests(HsFixture fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Streamgraph;
        }

        [Fact]
        public void Test_IfSeriesRendersType_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var series = new StreamgraphSeries();
            chart.Chart = new Chart();  chart.Series = new List<Highsoft.Web.Mvc.Stocks.Series>(); chart.Series.Add(series);

            var result = renderer.RenderHtml();

            Assert.Contains($"\"series\":[{{\"type\":\"{_fixture.ChartType.ToString().ToLower()}\"", result);
        }

        [Theory]
        [InlineData(250)]
        public void Test_IfAnimationLimitRenders_Correct(int limit)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var series = new StreamgraphSeries();
            chart.Chart = new Chart();  chart.Series = new List<Highsoft.Web.Mvc.Stocks.Series>(); chart.Series.Add(series);

            ((StreamgraphSeries)chart.Series[0]).AnimationLimit = limit;

            Assert.Contains($"\"animationLimit\":{limit}.0", renderer.RenderHtml());
        }
    }
}
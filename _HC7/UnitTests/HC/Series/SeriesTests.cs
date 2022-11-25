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
using Newtonsoft.Json.Linq;


namespace HC.Series
{
    public class SeriesTests : IClassFixture<HcFixture>
    {
        protected HcFixture _fixture;

        public SeriesTests(HcFixture fixture)
        {
            _fixture = fixture;
            _fixture.Reset();
        }

        [Theory]
        [InlineData("SeriesId")]
        public void Test_IfIdRenders_Correct(string id)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart); var series = _fixture.Series; chart.Series.Add(series);

            chart.Series[0].Id = id;

            Assert.Contains($"\"id\":\"{id}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfIdDoesntRendersForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart); var series = _fixture.Series; chart.Series.Add(series);
            string defaultValue = string.Empty;

            chart.Series[0].Id = defaultValue;

            Assert.DoesNotContain($"\"id\":\"{defaultValue}\"", renderer.RenderHtml());
        }
        
    }
}
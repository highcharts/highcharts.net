using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;
using System.Collections.Generic;
using Xunit;


namespace UnitTests.Series
{
    public class LineSeriesTests
    {
        Highcharts _chart;
        HighchartsRenderer _renderer;
        public LineSeriesTests()
        {
            _chart = new Highcharts();
            _renderer = new HighchartsRenderer(_chart);
        }

        [Fact]
        public void XLabels_Correct()
        {
            _chart.Chart.Type = ChartType.Area;
            _chart.XAxis = new List<XAxis>();
            _chart.XAxis.Add(new XAxis());
            _chart.XAxis[0].Labels.Formatter = "formatXLabels";

            Assert.Contains("\"formatter\":formatXLabels", _renderer.RenderHtml());
        }
    }
}
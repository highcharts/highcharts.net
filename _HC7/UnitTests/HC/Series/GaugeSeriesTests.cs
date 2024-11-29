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
    public class GaugeSeriesTests : IClassFixture<HcFixture>
    {
        protected HcFixture _fixture;

        public GaugeSeriesTests(HcFixture fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Gauge;
        }

        [Fact]
        public void Test_IfSeriesRendersType_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var series = new GaugeSeries();
            chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            var result = renderer.RenderHtml();

            Assert.Contains($"\"series\":[{{\"type\":\"{_fixture.ChartType.ToString().ToLower()}\"", result);
        }

        [Fact]
        public void Test_IfAllowPointSelectRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var enabled = true;

            ((GaugeSeries)chart.Series[0]).AllowPointSelect = enabled;

            Assert.Contains($"\"allowPointSelect\":{enabled.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAnimationEnabledRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();

            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var enabled = false;

            ((GaugeSeries)chart.Series[0]).AnimationBool = enabled;

            Assert.Contains($"\"animation\":{enabled.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("ClassName")]
        public void Test_IfClassNameRenders_Correct(string className)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).ClassName = className;

            Assert.Contains($"\"className\":\"{className}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = false;

            ((GaugeSeries)chart.Series[0]).Clip = value;

            Assert.Contains($"\"clip\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#ffffff")]
        public void Test_IfColorRenders_Correct(string color)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).Color = color;

            Assert.Contains($"\"color\":\"{color.ToString().ToLower()}\"", renderer.RenderHtml());
        }

        //missing logic for GradientColorObject and PatternObject

        [Theory]
        [InlineData(1)]
        public void Test_IfColorIndexRenders_Correct(int value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).ColorIndex = value;

            Assert.Contains($"\"colorIndex\":{value}.0", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCrispRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = false;

            ((GaugeSeries)chart.Series[0]).Crisp = value;

            Assert.Contains($"\"crisp\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(GaugeSeriesCursor.Default)]
        [InlineData(GaugeSeriesCursor.Help)]
        [InlineData(GaugeSeriesCursor.Pointer)]
        [InlineData(GaugeSeriesCursor.None)]
        public void Test_IfCursorRenders_Correct(GaugeSeriesCursor cursor)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).Cursor = cursor;

            Assert.Contains($"\"cursor\":\"{cursor.ToString().ToLower()}\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("dataKey1", "dataValue1")]
        public void Test_IfCustomRenders_Correct(string key1, string value1)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var extraData = new Hashtable() { { key1, value1 } };

            ((GaugeSeries)chart.Series[0]).Custom = extraData;

            Assert.Contains($"\"custom\":{{\"{key1}\":\"{value1}\"}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomePlotOptionsDescription")]
        public void Test_IfDescriptionRenders_Correct(string description)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).Description = description;

            Assert.Contains($"\"description\":\"{description}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = false;

            ((GaugeSeries)chart.Series[0]).EnableMouseTracking = value;

            Assert.Contains($"\"enableMouseTracking\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfIncludeInDataExportFromAllRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).IncludeInDataExport = value;

            Assert.Contains($"\"includeInDataExport\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfIncludeInDataExportFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool? value = null;

            ((GaugeSeries)chart.Series[0]).IncludeInDataExport = value;

            Assert.DoesNotContain($"\"includeInDataExport\":{value}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("name", "y", "dataLabels.style.visibility", "true")]
        public void Test_IfKeysRenders_Correct(string arg1, string arg2, string arg3, string arg4)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = new List<string> { arg1, arg2, arg3, arg4 };

            ((GaugeSeries)chart.Series[0]).Keys = value;

            Assert.Contains($"\"keys\":[\"{arg1}\",\"{arg2}\",\"{arg3}\",\"{arg4}\"]", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).LineWidth = value;

            Assert.Contains($"\"lineWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(":previous")]
        [InlineData("IdAnotherSeries")]
        public void Test_IfLinkedToRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).LinkedTo = value;

            Assert.Contains($"\"linkedTo\":\"{value}\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfOpacityRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).Opacity = value;

            Assert.Contains($"\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointDescriptionFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).PointDescriptionFormatter = value;

            Assert.Contains($"\"pointDescriptionFormatter\":{value}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfPointIntervalRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).PointInterval = value;

            Assert.Contains($"\"pointInterval\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(GaugeSeriesPointIntervalUnit.Day)]
        [InlineData(GaugeSeriesPointIntervalUnit.Month)]
        [InlineData(GaugeSeriesPointIntervalUnit.Year)]
        public void Test_IfPointIntervalUnitRenders_Correct(GaugeSeriesPointIntervalUnit value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).PointIntervalUnit = value;

            Assert.Contains($"\"pointIntervalUnit\":\"{chart.FirstCharacterToLower(value.ToString())}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointIntervalUnitDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var defaultValue = GaugeSeriesPointIntervalUnit.Null;

            ((GaugeSeries)chart.Series[0]).PointIntervalUnit = defaultValue;

            Assert.DoesNotContain($"pointIntervalUnit", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        public void Test_IfPointStartRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).PointStart = value;

            Assert.Contains($"\"pointStart\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = true;

            ((GaugeSeries)chart.Series[0]).RelativeXValue = value;

            Assert.Contains($"\"relativeXValue\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = true;

            ((GaugeSeries)chart.Series[0]).Selected = value;

            Assert.Contains($"\"selected\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowCheckboxRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = true;

            ((GaugeSeries)chart.Series[0]).ShowCheckbox = value;

            Assert.Contains($"\"showCheckbox\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfShowInLegendRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).ShowInLegend = value;

            Assert.Contains($"\"showInLegend\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowInLegendDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).ShowInLegend = null;

            Assert.DoesNotContain($"showInLegend", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfSkipKeyboardNavigationRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).SkipKeyboardNavigation = value;

            Assert.Contains($"\"skipKeyboardNavigation\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSkipKeyboardNavigationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((GaugeSeries)chart.Series[0]).SkipKeyboardNavigation = null;

            Assert.DoesNotContain($"skipKeyboardNavigation", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = false;

            ((GaugeSeries)chart.Series[0]).StickyTracking = value;

            Assert.Contains($"\"stickyTracking\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new GaugeSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = false;

            ((GaugeSeries)chart.Series[0]).Visible = value;

            Assert.Contains($"\"visible\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }
    }
}
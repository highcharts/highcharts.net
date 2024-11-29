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
    public class PieSeriesTests : IClassFixture<HcFixture>
    {
        protected HcFixture _fixture;

        public PieSeriesTests(HcFixture fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Pie;
        }

        [Fact]
        public void Test_IfSeriesRendersType_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var series = new PieSeries();
            chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            var result = renderer.RenderHtml();

            Assert.Contains($"\"series\":[{{\"type\":\"{_fixture.ChartType.ToString().ToLower()}\"", result);
        }

        [Fact]
        public void Test_IfAllowPointSelectRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var enabled = true;

            ((PieSeries)chart.Series[0]).AllowPointSelect = enabled;

            Assert.Contains($"\"allowPointSelect\":{enabled.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAnimationEnabledRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();

            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var enabled = false;

            ((PieSeries)chart.Series[0]).AnimationBool = enabled;

            Assert.Contains($"\"animation\":{enabled.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("ClassName")]
        public void Test_IfClassNameRenders_Correct(string className)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).ClassName = className;

            Assert.Contains($"\"className\":\"{className}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = false;

            ((PieSeries)chart.Series[0]).Clip = value;

            Assert.Contains($"\"clip\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#ffffff")]
        public void Test_IfColorRenders_Correct(string color)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).Color = color;

            Assert.Contains($"\"color\":\"{color.ToString().ToLower()}\"", renderer.RenderHtml());
        }

        //missing logic for GradientColorObject and PatternObject

        [Theory]
        [InlineData("axisId")]
        public void Test_IfColorAxisRendersString_Correct(string id)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).ColorAxis = id;

            Assert.Contains($"\"colorAxis\":\"{id}\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void Test_IfColorAxisRendersNumber_Correct(int index)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).ColorAxisNumber = index;

            Assert.Contains($"\"colorAxis\":{index}.0", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfColorAxisRendersBool_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            ((PieSeries)chart.Series[0]).ColorAxisBool = value;

            Assert.Contains($"\"colorAxis\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1)]
        public void Test_IfColorIndexRenders_Correct(int value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).ColorIndex = value;

            Assert.Contains($"\"colorIndex\":{value}.0", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("colorValue")]
        public void Test_IfColorKeyRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).ColorKey = value;

            Assert.Contains($"\"colorKey\":\"{value}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCrispRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = false;

            ((PieSeries)chart.Series[0]).Crisp = value;

            Assert.Contains($"\"crisp\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PieSeriesCursor.Default)]
        [InlineData(PieSeriesCursor.Help)]
        [InlineData(PieSeriesCursor.Pointer)]
        [InlineData(PieSeriesCursor.None)]
        public void Test_IfCursorRenders_Correct(PieSeriesCursor cursor)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).Cursor = cursor;

            Assert.Contains($"\"cursor\":\"{cursor.ToString().ToLower()}\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("dataKey1", "dataValue1")]
        public void Test_IfCustomRenders_Correct(string key1, string value1)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var extraData = new Hashtable() { { key1, value1 } };

            ((PieSeries)chart.Series[0]).Custom = extraData;

            Assert.Contains($"\"custom\":{{\"{key1}\":\"{value1}\"}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomePlotOptionsDescription")]
        public void Test_IfDescriptionRenders_Correct(string description)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).Description = description;

            Assert.Contains($"\"description\":\"{description}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = false;

            ((PieSeries)chart.Series[0]).EnableMouseTracking = value;

            Assert.Contains($"\"enableMouseTracking\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfIncludeInDataExportFromAllRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).IncludeInDataExport = value;

            Assert.Contains($"\"includeInDataExport\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfIncludeInDataExportFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool? value = null;

            ((PieSeries)chart.Series[0]).IncludeInDataExport = value;

            Assert.DoesNotContain($"\"includeInDataExport\":{value}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("name", "y", "dataLabels.style.visibility", "true")]
        public void Test_IfKeysRenders_Correct(string arg1, string arg2, string arg3, string arg4)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = new List<string> { arg1, arg2, arg3, arg4 };

            ((PieSeries)chart.Series[0]).Keys = value;

            Assert.Contains($"\"keys\":[\"{arg1}\",\"{arg2}\",\"{arg3}\",\"{arg4}\"]", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfOpacityRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).Opacity = value;

            Assert.Contains($"\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointDescriptionFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).PointDescriptionFormatter = value;

            Assert.Contains($"\"pointDescriptionFormatter\":{value}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = true;

            ((PieSeries)chart.Series[0]).RelativeXValue = value;

            Assert.Contains($"\"relativeXValue\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = true;

            ((PieSeries)chart.Series[0]).Selected = value;

            Assert.Contains($"\"selected\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShadowBoolRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = true;

            ((PieSeries)chart.Series[0]).ShadowBool = value;

            Assert.Contains($"\"shadow\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#00ffdd", 10, 20, 30, 40)]
        [InlineData("#ffccaa", 40, 30, 20, 10)]
        public void Test_IfShadowRenders_Correct(string color, int offsetX, int offsetY, double opacity, int width)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).Shadow = new Shadow()
            {
                Color = color,
                OffsetX = offsetX,
                OffsetY = offsetY,
                Opacity = opacity,
                Width = width
            };

            var result = renderer.RenderHtml();
            Assert.Contains($"\"shadow\":", result);
            Assert.Contains($"\"offsetX\":{offsetX}", result);
            Assert.Contains($"\"width\":{width}", result);
            Assert.Contains($"\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", opacity)}", result);
            Assert.Contains($"\"offsetY\":{offsetY}", result);
            Assert.Contains($"\"color\":\"{color}\"", result);
        }

        [Fact]
        public void Test_IfShowCheckboxRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = true;

            ((PieSeries)chart.Series[0]).ShowCheckbox = value;

            Assert.Contains($"\"showCheckbox\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfShowInLegendRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).ShowInLegend = value;

            Assert.Contains($"\"showInLegend\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowInLegendDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).ShowInLegend = null;

            Assert.DoesNotContain($"showInLegend", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfSkipKeyboardNavigationRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).SkipKeyboardNavigation = value;

            Assert.Contains($"\"skipKeyboardNavigation\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSkipKeyboardNavigationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((PieSeries)chart.Series[0]).SkipKeyboardNavigation = null;

            Assert.DoesNotContain($"skipKeyboardNavigation", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = false;

            ((PieSeries)chart.Series[0]).StickyTracking = value;

            Assert.Contains($"\"stickyTracking\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new PieSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = false;

            ((PieSeries)chart.Series[0]).Visible = value;

            Assert.Contains($"\"visible\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

    }
}
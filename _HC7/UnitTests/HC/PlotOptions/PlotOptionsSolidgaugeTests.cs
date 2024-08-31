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

namespace HC.PlotOptions
{
    public class PlotOptionsSolidgaugeTests : IClassFixture<HcFixture>
    {
        protected HcFixture _fixture;

        public PlotOptionsSolidgaugeTests(HcFixture fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Solidgauge;
        }

        #region Acessibility

        [Theory]
        [InlineData("Description")]
        public void Test_IfAccessibilityDescriptionRenders_Correct(string description)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Accessibility.Description = description;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"description\":\"{description}\"}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityEnabledRenders_Correct(bool enabled)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Accessibility.Enabled = enabled;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"enabled\":{enabled.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }


        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityExposeAsGroupOnlyRenders_Correct(bool exposeAsGroupOnly)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Accessibility.ExposeAsGroupOnly = exposeAsGroupOnly;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"exposeAsGroupOnly\":{exposeAsGroupOnly.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        #region KeyboardNavigation

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityKeyboardNavigationEnabledRenders_Correct(bool enabled)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Accessibility.KeyboardNavigation.Enabled = enabled;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"keyboardNavigation\":{{\"enabled\":{enabled.ToString().ToLower()}}}}}}}}}", renderer.RenderHtml());
        }

        #endregion

        #region Point

        [Theory]
        [InlineData("%Y-%m-%d %H:%M:%S")]
        public void Test_IfAccessibilityPointDateFormatRenders_Correct(string format)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Accessibility.Point.DateFormat = format;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"dateFormat\":\"{format}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("DateFormatterFunction")]
        public void Test_IfAccessibilityPointDateFormatterRenders_Correct(string function)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Accessibility.Point.DateFormatter = function;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"dateFormatter\":{function}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(false)]
        public void Test_IfAccessibilityPointDescribeNullSetOnFalseRenders_Correct(bool describeNull)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);



            chart.PlotOptions.Solidgauge.Accessibility.Point.DescribeNull = describeNull;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"describeNull\":{describeNull.ToString().ToLower()}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        public void Test_IfAccessibilityPointDescribeNullSetOnTrueRenders_Correct(bool describeNull)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Accessibility.Point.DescribeNull = describeNull;

            Assert.DoesNotContain($"describeNull", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("FormatterFunction")]
        public void Test_IfAccessibilityPointDescriptionFormatterRenders_Correct(string function)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Accessibility.Point.DescriptionFormatter = function;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"descriptionFormatter\":{function}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(3)]
        public void Test_IfAccessibilityPointValueDecimalsRenders_Correct(int decimals)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Accessibility.Point.ValueDecimals = decimals;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valueDecimals\":{decimals}.0}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{Description}{separator}{value}")]
        public void Test_IfAccessibilityPointValueDescriptionFormatRenders_Correct(string format)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Accessibility.Point.ValueDescriptionFormat = format;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valueDescriptionFormat\":\"{format}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomePrefix")]
        public void Test_IfAccessibilityPointValuePrefixRenders_Correct(string prefix)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Accessibility.Point.ValuePrefix = prefix;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valuePrefix\":\"{prefix}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeSuffix")]
        public void Test_IfAccessibilityPointValueSufixRenders_Correct(string suffix)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Accessibility.Point.ValueSuffix = suffix;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valueSuffix\":\"{suffix}\"}}}}}}}}", renderer.RenderHtml());
        }
        #endregion

        #endregion

        [Fact]
        public void Test_IfAllowPointSelectRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var enabled = true;

            chart.PlotOptions.Solidgauge.AllowPointSelect = enabled;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"allowPointSelect\":{enabled.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAllowPointSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.AllowPointSelect = false;

            Assert.DoesNotContain("allowPointSelect", renderer.RenderHtml());
        }

        #region Animation

        [Fact]
        public void Test_IfAnimationEnabledRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Solidgauge.AnimationBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAnimationEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Solidgauge.AnimationBool = value;

            Assert.DoesNotContain("animation", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1000)]
        public void Test_IfAnimationDurationRenders_Correct(int duration)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Animation.Duration = duration;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{{\"duration\":{duration}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1000)]
        public void Test_IfAnimationDeferRenders_Correct(int defer)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Animation.Defer = defer;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{{\"defer\":{defer}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("easingFunctionName")]
        public void Test_IfAnimationEasingRenders_Correct(string easing)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Animation.Easing = easing;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{{\"easing\":\"{easing}\"}}}}}}", renderer.RenderHtml());
        }

        #endregion

        //missing borderColor
        //missing borderWidth

        [Theory]
        [InlineData("ClassName")]
        public void Test_IfClassNameRenders_Correct(string className)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.ClassName = className;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"className\":\"{className}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Solidgauge.Clip = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"clip\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Solidgauge.Clip = value;

            Assert.DoesNotContain("clip", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#ffffff")]
        public void Test_IfColorRenders_Correct(string color)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Color = color;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"color\":\"{color.ToString().ToLower()}\"}}}}", renderer.RenderHtml());
        }

        //missing logic for GradientColorObject and PatternObject

        [Theory]
        [InlineData(1)]
        public void Test_IfColorIndexRenders_Correct(int value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.ColorIndex = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"colorIndex\":{value}.0}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCrispRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Solidgauge.Crisp = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"crisp\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCrispDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Solidgauge.Crisp = value;

            Assert.DoesNotContain($"\"crisp\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSolidgaugeCursor.Default)]
        [InlineData(PlotOptionsSolidgaugeCursor.Help)]
        [InlineData(PlotOptionsSolidgaugeCursor.Pointer)]
        [InlineData(PlotOptionsSolidgaugeCursor.None)]
        public void Test_IfCursorRenders_Correct(PlotOptionsSolidgaugeCursor cursor)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Cursor = cursor;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"cursor\":\"{cursor.ToString().ToLower()}\"}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("dataKey1", "dataValue1")]
        public void Test_IfCustomRenders_Correct(string key1, string value1)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var extraData = new Hashtable() { { key1, value1 } };

            chart.PlotOptions.Solidgauge.Custom = extraData;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"custom\":{{\"{key1}\":\"{value1}\"}}}}}}", renderer.RenderHtml());
        }

        #region databaLabels

        //fix required - missing dataLabels as a list of objects (right now it is possible to have only one object)

        [Theory]
        [InlineData(PlotOptionsSolidgaugeDataLabelsAlign.Left)]
        [InlineData(PlotOptionsSolidgaugeDataLabelsAlign.Right)]
        public void Test_IfDataLabelsAlignRenders_Correct(PlotOptionsSolidgaugeDataLabelsAlign align)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Align = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"align\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSolidgaugeDataLabelsAlign.Center;

            chart.PlotOptions.Solidgauge.DataLabels.Align = defaultValue;

            Assert.DoesNotContain($"align", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAllowOverlapRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Solidgauge.DataLabels.AllowOverlap = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"allowOverlap\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAllowOverlapDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Solidgauge.DataLabels.AllowOverlap = defaultValue;

            Assert.DoesNotContain($"allowOverlap", renderer.RenderHtml());
        }

        #region Animation

        [Theory]
        [InlineData(200)]
        [InlineData(500)]
        public void Test_IfDataLabelsAnimationDeferRenders_Correct(int value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Animation.Defer = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"animation\":{{\"defer\":{value}}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAnimationDeferDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Solidgauge.DataLabels.Animation.Defer = defaultValue;

            Assert.DoesNotContain($"defer", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsBackgroundColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.BackgroundColor = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"backgroundColor\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBackgroundColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.DataLabels.BackgroundColor = defaultValue;

            Assert.DoesNotContain($"backgroundColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsBorderColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.BorderColor = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"borderColor\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.DataLabels.BorderColor = defaultValue;

            Assert.DoesNotContain($"borderColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsBorderRadiusRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.BorderRadius = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"borderRadius\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Solidgauge.DataLabels.BorderRadius = defaultValue;

            Assert.DoesNotContain($"borderRadius", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsBorderWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.BorderWidth = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"borderWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Solidgauge.DataLabels.BorderWidth = defaultValue;

            Assert.DoesNotContain($"borderWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("classA")]
        [InlineData("classB")]
        public void Test_IfDataLabelsClassNameRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.ClassName = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"className\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsClassNameDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.DataLabels.ClassName = defaultValue;

            Assert.DoesNotContain($"className", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Color = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"color\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.DataLabels.Color = defaultValue;

            Assert.DoesNotContain($"color", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsCropRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Solidgauge.DataLabels.Crop = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"crop\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsCropDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Solidgauge.DataLabels.Crop = defaultValue;

            Assert.DoesNotContain($"crop", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsDeferBoolRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Solidgauge.DataLabels.Defer = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"defer\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsDeferBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Solidgauge.DataLabels.Defer = defaultValue;

            Assert.DoesNotContain($"defer", renderer.RenderHtml());
        }

        //[Theory]
        //[InlineData(2000)]
        //[InlineData(5000)]
        //public void Test_IfDataLabelsDeferRenders_Correct(double value)
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);

        //    chart.PlotOptions.Solidgauge.DataLabels.Defer = value;

        //    Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"defer\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfDataLabelsEnabledBoolRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Solidgauge.DataLabels.Enabled = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"enabled\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsEnabledBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Solidgauge.DataLabels.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        #region Filter

        [Theory]
        [InlineData(">")]
        [InlineData("<")]
        [InlineData(">=")]
        [InlineData("<=")]
        [InlineData("==")]
        [InlineData("===")]
        public void Test_IfDataLabelsFilterOperatorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Filter.Operator = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"filter\":{{\"operator\":\"{value}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterOperatorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.DataLabels.Filter.Operator = defaultValue;

            Assert.DoesNotContain($"operator", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("percentage")]
        [InlineData("y")]
        public void Test_IfDataLabelsFilterPropertyRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Filter.Property = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"filter\":{{\"property\":\"{value}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterPropertyDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.DataLabels.Filter.Property = defaultValue;

            Assert.DoesNotContain($"property", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsFilterValueRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Filter.Value = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"filter\":{{\"value\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Solidgauge.DataLabels.Filter.Value = defaultValue;

            Assert.DoesNotContain($"value", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("{y} mm")]
        [InlineData("<{x},{y}>")]
        public void Test_IfDataLabelsFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Format = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"format\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "point.value";

            chart.PlotOptions.Solidgauge.DataLabels.Format = defaultValue;

            Assert.DoesNotContain($"format", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfDataLabelsFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Formatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"formatter\":{value}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.DataLabels.Formatter = defaultValue;

            Assert.DoesNotContain($"formatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataLabelsInsideRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Inside = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"inside\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsInsideDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Solidgauge.DataLabels.Inside = defaultValue;

            Assert.DoesNotContain($"inside", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataLabelsNullFormatBoolRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.NullFormatBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"nullFormat\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Solidgauge.DataLabels.NullFormatBool = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{y} mm")]
        [InlineData("<{x},{y}>")]
        public void Test_IfDataLabelsNullFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.NullFormat = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"nullFormat\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.DataLabels.NullFormat = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfDataLabelsNullFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.NullFormatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"nullFormatter\":{value}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.DataLabels.NullFormatter = defaultValue;

            Assert.DoesNotContain($"nullFormatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSolidgaugeDataLabelsOverflow.Allow)]
        public void Test_IfDataLabelsOverflowRenders_Correct(PlotOptionsSolidgaugeDataLabelsOverflow align)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Overflow = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"overflow\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsOverflowDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSolidgaugeDataLabelsOverflow.Justify;

            chart.PlotOptions.Solidgauge.DataLabels.Overflow = defaultValue;

            Assert.DoesNotContain($"overflow", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(50)]
        public void Test_IfDataLabelsPaddingRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Padding = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"padding\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsPaddingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 5;

            chart.PlotOptions.Solidgauge.DataLabels.Padding = defaultValue;

            Assert.DoesNotContain($"padding", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSolidgaugeDataLabelsPosition.Left)]
        [InlineData(PlotOptionsSolidgaugeDataLabelsPosition.Right)]
        public void Test_IfDataLabelsPositionRenders_Correct(PlotOptionsSolidgaugeDataLabelsPosition align)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Position = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"position\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsPositionDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSolidgaugeDataLabelsPosition.Center;

            chart.PlotOptions.Solidgauge.DataLabels.Position = defaultValue;

            Assert.DoesNotContain($"position", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(90)]
        [InlineData(180)]
        public void Test_IfDataLabelsRotationRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Rotation = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"rotation\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsRotationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Solidgauge.DataLabels.Rotation = defaultValue;

            Assert.DoesNotContain($"rotation", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsShadowBoolRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Solidgauge.DataLabels.ShadowBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"shadow\":{chart.FirstCharacterToLower(value.ToString())}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#00ffdd", 10, 20, 30, 40)]
        [InlineData("#ffccaa", 40, 30, 20, 10)]
        public void Test_IfDataLabelsShadowRenders_Correct(string color, int offsetX, int offsetY, double opacity, int width)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Shadow = new Shadow()
            {
                Color = color,
                OffsetX = offsetX,
                OffsetY = offsetY,
                Opacity = opacity,
                Width = width
            };

            var result = renderer.RenderHtml();
            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"shadow\":", result);
            Assert.Contains($"\"offsetX\":{offsetX}", result);
            Assert.Contains($"\"width\":{width}", result);
            Assert.Contains($"\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", opacity)}", result);
            Assert.Contains($"\"offsetY\":{offsetY}", result);
            Assert.Contains($"\"color\":\"{color}\"", result);
        }

        [Fact]
        public void Test_IfDataLabelsShadowBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Solidgauge.DataLabels.ShadowBool = defaultValue;

            Assert.DoesNotContain($"shadow", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("callout")]
        [InlineData("circle")]
        [InlineData("diamond")]
        [InlineData("triangle")]
        [InlineData("triangle-down")]
        public void Test_IfDataLabelsShapeRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Shape = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"shape\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsShapeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "square";

            chart.PlotOptions.Solidgauge.DataLabels.Shape = defaultValue;

            Assert.DoesNotContain($"shape", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("background", "green")]
        [InlineData("backgroundColor", "#0022ff")]
        [InlineData("border", "4px dotted blue")]
        [InlineData("color", "contrast")]
        [InlineData("cursor", "alias")]
        [InlineData("fontFamily", "Arial, Helvetica, sans-serif")]
        [InlineData("fontSize", "20px")]
        [InlineData("fontWeight", "64px")]
        [InlineData("padding", "1em 2em 2em")]
        [InlineData("position", "relative")]
        [InlineData("textAlign", "center")]
        [InlineData("textDecoration", "underline")]
        [InlineData("textOutline", "something")]
        [InlineData("textOverflow", "ellipsis")]
        [InlineData("top", "50px")]
        [InlineData("transition", "width 2s")]
        [InlineData("whiteSpace", "break-spaces")]
        public void Test_IfDataLabelsStyleStringRenders_Correct(string param1, string param1_value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "dataLabels", "style" };
            var style = new Hashtable();
            style.Add(param1, param1_value);

            chart.PlotOptions.Solidgauge.DataLabels.Style = style;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString(param1, param1_value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("borderRadius", 25)]
        [InlineData("height", 20)]
        [InlineData("lineWidth", 2)]
        [InlineData("opacity", 20)]
        [InlineData("width", 50)]
        public void Test_IfDataLabelsStyleNumberRenders_Correct(string param1, double param1_value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "dataLabels", "style" };
            var style = new Hashtable();
            style.Add(param1, param1_value);

            chart.PlotOptions.Solidgauge.DataLabels.Style = style;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString(param1, param1_value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        #region textPath

        //missing textPath.attributes - fix and set as hashtable

        [Theory]
        [InlineData(true)]
        public void Test_IfDataLabelsTextPathEnabledRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "dataLabels", "textPath" };

            chart.PlotOptions.Solidgauge.DataLabels.TextPath.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsTextPathEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = false;

            chart.PlotOptions.Solidgauge.DataLabels.TextPath.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        #endregion

        [Fact]
        public void Test_IfDataLabelsUseHTMLRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Solidgauge.DataLabels.UseHTML = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"useHTML\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsUseHTMLDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Solidgauge.DataLabels.UseHTML = defaultValue;

            Assert.DoesNotContain($"useHTML", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSolidgaugeDataLabelsVerticalAlign.Middle)]
        [InlineData(PlotOptionsSolidgaugeDataLabelsVerticalAlign.Top)]
        public void Test_IfDataLabelsVerticalAlignRenders_Correct(PlotOptionsSolidgaugeDataLabelsVerticalAlign align)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.VerticalAlign = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"verticalAlign\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsVerticalAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSolidgaugeDataLabelsVerticalAlign.Bottom;

            chart.PlotOptions.Solidgauge.DataLabels.VerticalAlign = defaultValue;

            Assert.DoesNotContain($"verticalAlign", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsXRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.X = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"x\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Solidgauge.DataLabels.X = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"x\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsYRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.Y = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"y\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Solidgauge.DataLabels.Y = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"y\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsZRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.DataLabels.ZIndex = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"zIndex\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsZDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 6;

            chart.PlotOptions.Solidgauge.DataLabels.ZIndex = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"zIndex\":", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("SomePlotOptionsDescription")]
        public void Test_IfDescriptionRenders_Correct(string description)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Description = description;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"description\":\"{description}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Solidgauge.EnableMouseTracking = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"enableMouseTracking\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Solidgauge.EnableMouseTracking = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"enableMouseTracking\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        #region events

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsAfterAnimateRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "events" };

            chart.PlotOptions.Solidgauge.Events.AfterAnimate = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("afterAnimate", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsAfterAnimateDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Events.AfterAnimate = defaultValue;

            Assert.DoesNotContain($"afterAnimate", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsCheckboxClickRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "events" };

            chart.PlotOptions.Solidgauge.Events.CheckboxClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("checkboxClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsCheckboxClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Events.CheckboxClick = defaultValue;

            Assert.DoesNotContain($"checkboxClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsClickRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "events" };

            chart.PlotOptions.Solidgauge.Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsclickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsHideRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "events" };

            chart.PlotOptions.Solidgauge.Events.Hide = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("hide", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsHideDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Events.Hide = defaultValue;

            Assert.DoesNotContain($"hide", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsLegendItemClickRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "events" };

            chart.PlotOptions.Solidgauge.Events.LegendItemClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("legendItemClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsLegendItemClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Events.LegendItemClick = defaultValue;

            Assert.DoesNotContain($"legendItemClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "events" };

            chart.PlotOptions.Solidgauge.Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "events" };

            chart.PlotOptions.Solidgauge.Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsShowRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "events" };

            chart.PlotOptions.Solidgauge.Events.Show = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("show", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsShowDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Events.Show = defaultValue;

            Assert.DoesNotContain($"show", renderer.RenderHtml());
        }

        #endregion


        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfIncludeInDataExportFromAllRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.IncludeInDataExport = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"includeInDataExport\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfIncludeInDataExportFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? value = null;

            chart.PlotOptions.Solidgauge.IncludeInDataExport = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"includeInDataExport\":{value}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("name", "y", "dataLabels.style.visibility", "true")]
        public void Test_IfKeysRenders_Correct(string arg1, string arg2, string arg3, string arg4)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = new List<string> { arg1, arg2, arg3, arg4 };

            chart.PlotOptions.Solidgauge.Keys = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"keys\":[\"{arg1}\",\"{arg2}\",\"{arg3}\",\"{arg4}\"]}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfKeysDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = new List<string>();

            chart.PlotOptions.Solidgauge.Keys = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"keys\":}}}}", renderer.RenderHtml());
        }

        #region label

        //missing boxesToAvoid

        [Fact]
        public void Test_IfLabelConnectorAllowedRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "label" };
            var value = true;

            chart.PlotOptions.Solidgauge.Label.ConnectorAllowed = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorAllowed", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorAllowedDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Solidgauge.Label.ConnectorAllowed = defaultValue;

            Assert.DoesNotContain($"connectorAllowed", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(30)]
        public void Test_IfLabelConnectorNeighbourDistanceRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "label" };

            chart.PlotOptions.Solidgauge.Label.ConnectorNeighbourDistance = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorNeighbourDistance", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorNeighbourDistanceDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 24;

            chart.PlotOptions.Solidgauge.Label.ConnectorNeighbourDistance = defaultValue;

            Assert.DoesNotContain($"connectorNeighbourDistance", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "label" };
            var value = false;

            chart.PlotOptions.Solidgauge.Label.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Solidgauge.Label.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFormat")]
        public void Test_IfLabelFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "label" };

            chart.PlotOptions.Solidgauge.Label.Format = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("format", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        /// <summary>
        /// Fix default value for Format
        /// </summary>
        /// <param name="value"></param>
        //[Fact]
        //public void Test_IfLabelFormatDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Solidgauge.Label.Format = defaultValue;

        //    Assert.DoesNotContain($"format", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("SomeFormatterFunction")]
        public void Test_IfLabelFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "label" };

            chart.PlotOptions.Solidgauge.Label.Formatter = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("formatter", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Label.Formatter = defaultValue;

            Assert.DoesNotContain($"formatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMaxFontSizeRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "label" };

            chart.PlotOptions.Solidgauge.Label.MaxFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("maxFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMaxFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Solidgauge.Label.MaxFontSize = defaultValue;

            Assert.DoesNotContain($"maxFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMinFontSizeRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "label" };

            chart.PlotOptions.Solidgauge.Label.MinFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("minFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMinFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Solidgauge.Label.MinFontSize = defaultValue;

            Assert.DoesNotContain($"minFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfLabelOnAreaRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "label" };

            chart.PlotOptions.Solidgauge.Label.OnArea = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("onArea", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelOnAreaDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Solidgauge.Label.OnArea = defaultValue;

            Assert.DoesNotContain($"onArea", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("fontWeight", "bold")]
        public void Test_IfLabelStyleRenders_Correct(string paramName, string paramValue)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "solidgauge", "label" };
            var value = new Hashtable();
            value.Add(paramName, paramValue);


            chart.PlotOptions.Solidgauge.Label.Style = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetHashtablePropertyString("style", paramName, paramValue)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        /// <summary>
        /// Fix default value for style - empty hashtable should be not rendered
        /// </summary>
        /// <param name="value"></param>
        //[Fact]
        //public void Test_IfLabelStyleDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Solidgauge.Label.Style = defaultValue;

        //    Assert.DoesNotContain($"style", renderer.RenderHtml());
        //}



        #endregion


        //fix required - Linecap should be enum (not string)
        //[Theory]
        //[InlineData(PlotOptionsSolidgaugeLinecap.Square)]
        ////missing PlotOptionsSolidgaugeLinecap.Butt ?
        //public void Test_IfLinecapRenders_Correct(PlotOptionsSolidgaugeLinecap value)
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);

        //    chart.PlotOptions.Solidgauge.Linecap = value;

        //    Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linecap\":\"{chart.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfLinecapDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = PlotOptionsSolidgaugeLinecap.Round;

        //    chart.PlotOptions.Solidgauge.Linecap = defaultValue;

        //    Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linecap\":{defaultValue.ToString().ToLower()}}}}}", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.LineWidth = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"lineWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 2;

            chart.PlotOptions.Solidgauge.LineWidth = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"lineWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", defaultValue)}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(":previous")]
        [InlineData("IdAnotherSeries")]
        public void Test_IfLinkedToRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.LinkedTo = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linkedTo\":\"{value}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLinkedToDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            string defaultValue = String.Empty;

            chart.PlotOptions.Solidgauge.LinkedTo = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linkedTo\":{defaultValue}}}}}", renderer.RenderHtml());
        }

        #region onPoint

        //fix dashStyle - should be string instead of hashtable
        //[Theory]
        //[InlineData("dot")]
        //public void Test_IfOnPointConnectorOptionsDashStyleRenders_Correct(string value)
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "onPoint", "connectorOptions" };

        //    chart.PlotOptions.Solidgauge.OnPoint.ConnectorOptions.Dashstyle = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dashstyle", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfOnPointConnectorOptionsDashStyleDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Solidgauge.DataLabels.Color = defaultValue;

        //    Assert.DoesNotContain($"color", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("red")]
        public void Test_IfOnPointConnectorOptionsStrokeRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "onPoint", "connectorOptions" };

            chart.PlotOptions.Solidgauge.OnPoint.ConnectorOptions.Stroke = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("stroke", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsStrokeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.OnPoint.ConnectorOptions.Stroke = defaultValue;

            Assert.DoesNotContain($"stroke", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointConnectorOptionsWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "onPoint", "connectorOptions" };

            chart.PlotOptions.Solidgauge.OnPoint.ConnectorOptions.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Solidgauge.OnPoint.ConnectorOptions.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("pointId")]
        public void Test_IfOnPointIdRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "onPoint" };

            chart.PlotOptions.Solidgauge.OnPoint.Id = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("id", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointIdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.OnPoint.Id = defaultValue;

            Assert.DoesNotContain($"\"id\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetXRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "onPoint", "position" };

            chart.PlotOptions.Solidgauge.OnPoint.Position.OffsetX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Solidgauge.OnPoint.Position.OffsetX = defaultValue;

            Assert.DoesNotContain($"offsetX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetYRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "onPoint", "position" };

            chart.PlotOptions.Solidgauge.OnPoint.Position.OffsetY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Solidgauge.OnPoint.Position.OffsetY = defaultValue;

            Assert.DoesNotContain($"offsetY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionXRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "onPoint", "position" };

            chart.PlotOptions.Solidgauge.OnPoint.Position.X = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("x", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Solidgauge.OnPoint.Position.X = defaultValue;

            Assert.DoesNotContain($"\"x\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionYRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "onPoint", "position" };

            chart.PlotOptions.Solidgauge.OnPoint.Position.Y = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("y", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Solidgauge.OnPoint.Position.Y = defaultValue;

            Assert.DoesNotContain($"\"y\":", renderer.RenderHtml());
        }

        #endregion


        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfOpacityRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Opacity = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOpacityDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Solidgauge.Opacity = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", defaultValue)}}}}}", renderer.RenderHtml());
        }

        #region point

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsClickRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "point", "events" };

            chart.PlotOptions.Solidgauge.Point.Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Point.Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "point", "events" };

            chart.PlotOptions.Solidgauge.Point.Events.Drag = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drag", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Point.Events.Drag = defaultValue;

            Assert.DoesNotContain($"drag", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragStartRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "point", "events" };

            chart.PlotOptions.Solidgauge.Point.Events.DragStart = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("dragStart", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragStartDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Point.Events.DragStart = defaultValue;

            Assert.DoesNotContain($"dragStart", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDropRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "point", "events" };

            chart.PlotOptions.Solidgauge.Point.Events.Drop = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drop", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDropDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Point.Events.Drop = defaultValue;

            Assert.DoesNotContain($"drop", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "point", "events" };

            chart.PlotOptions.Solidgauge.Point.Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Point.Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "point", "events" };

            chart.PlotOptions.Solidgauge.Point.Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Point.Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsRemoveRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "point", "events" };

            chart.PlotOptions.Solidgauge.Point.Events.Remove = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("remove", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsRemoveDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Point.Events.Remove = defaultValue;

            Assert.DoesNotContain($"remove", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsSelectRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "point", "events" };

            chart.PlotOptions.Solidgauge.Point.Events.Select = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("select", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Point.Events.Select = defaultValue;

            Assert.DoesNotContain($"select", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUnselectRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "point", "events" };

            chart.PlotOptions.Solidgauge.Point.Events.Unselect = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("unselect", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUnselectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Point.Events.Unselect = defaultValue;

            Assert.DoesNotContain($"unselect", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUpdateRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "point", "events" };

            chart.PlotOptions.Solidgauge.Point.Events.Update = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("update", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUpdateDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Point.Events.Update = defaultValue;

            Assert.DoesNotContain($"update", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointDescriptionFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.PointDescriptionFormatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"pointDescriptionFormatter\":{value}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointDescriptionFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.PointDescriptionFormatter = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"pointDescriptionFormatter\":{defaultValue}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfPointIntervalRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.PointInterval = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"pointInterval\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointIntervalDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Solidgauge.PointInterval = defaultValue;

            Assert.DoesNotContain($"pointInterval", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSolidgaugePointIntervalUnit.Day)]
        [InlineData(PlotOptionsSolidgaugePointIntervalUnit.Month)]
        [InlineData(PlotOptionsSolidgaugePointIntervalUnit.Year)]
        public void Test_IfPointIntervalUnitRenders_Correct(PlotOptionsSolidgaugePointIntervalUnit value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.PointIntervalUnit = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"pointIntervalUnit\":\"{chart.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointIntervalUnitDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSolidgaugePointIntervalUnit.Null;

            chart.PlotOptions.Solidgauge.PointIntervalUnit = defaultValue;

            Assert.DoesNotContain($"pointIntervalUnit", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        public void Test_IfPointStartRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.PointStart = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"pointStart\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointStartDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Solidgauge.PointStart = defaultValue;

            Assert.DoesNotContain($"pointStart", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Solidgauge.RelativeXValue = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"relativeXValue\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Solidgauge.RelativeXValue = defaultValue;

            Assert.DoesNotContain($"relativeXValue", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Solidgauge.Selected = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"selected\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Solidgauge.Selected = defaultValue;

            Assert.DoesNotContain($"selected", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowCheckboxRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Solidgauge.ShowCheckbox = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"showCheckbox\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowCheckboxDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Solidgauge.ShowCheckbox = defaultValue;

            Assert.DoesNotContain($"showCheckbox", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfShowInLegendRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.ShowInLegend = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"showInLegend\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowInLegendDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.ShowInLegend = null;

            Assert.DoesNotContain($"showInLegend", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfSkipKeyboardNavigationRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.SkipKeyboardNavigation = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"skipKeyboardNavigation\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSkipKeyboardNavigationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.SkipKeyboardNavigation = null;

            Assert.DoesNotContain($"skipKeyboardNavigation", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool value = false;

            chart.PlotOptions.Solidgauge.StickyTracking = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"stickyTracking\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Solidgauge.StickyTracking = defaultValue;

            Assert.DoesNotContain($"stickyTracking", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfThresholdRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Solidgauge.Threshold = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"threshold\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Solidgauge.Threshold = defaultValue;

            Assert.DoesNotContain($"threshold", renderer.RenderHtml());
        }

        #region tooltip

        [Theory]
        [InlineData("Clustered points2: {point.clusterPointsAmount}")]
        public void Test_IfTooltipClusterFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "tooltip" };

            chart.PlotOptions.Solidgauge.Tooltip.ClusterFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("clusterFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipClusterFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "Clustered points: {point.clusterPointsAmount}";

            chart.PlotOptions.Solidgauge.Tooltip.ClusterFormat = defaultValue;

            Assert.DoesNotContain($"clusterFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("day", "%A, %b %e, %Y")]
        [InlineData("hour", "%A, %b %e, %H:%M")]
        [InlineData("milisecond", "%A, %b %e, %H:%M:%S.%L")]
        [InlineData("minute", "%A, %b %e, %H:%M")]
        [InlineData("month", "%B %Y")]
        [InlineData("second", "%A, %b %e, %H:%M:%S")]
        [InlineData("week", "Week from %A, %b %e, %Y")]
        [InlineData("year", "%Y")]
        public void Test_IfTooltipDateTimeLabelFormatsRenders_Correct(string param, string paramValue)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "tooltip" };
            var value = new Hashtable();
            value.Add(param, paramValue);

            chart.PlotOptions.Solidgauge.Tooltip.DateTimeLabelFormats = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetHashtablePropertyString("dateTimeLabelFormats", param, paramValue)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - hashtable shouldn't be rendered if it's empty
        //[Fact]
        //public void Test_IfTooltipDateTimeLabelFormatsDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Solidgauge.Tooltip.DateTimeLabelFormats = defaultValue;

        //    Assert.DoesNotContain($"dateTimeLabelFormats", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(10)]
        public void Test_IfTooltipDistanceRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "tooltip" };

            chart.PlotOptions.Solidgauge.Tooltip.Distance = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("distance", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipDistanceDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 16;

            chart.PlotOptions.Solidgauge.Tooltip.Distance = defaultValue;

            Assert.DoesNotContain($"distance", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipFollowPointerRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "tooltip" };
            var value = true;

            chart.PlotOptions.Solidgauge.Tooltip.FollowPointer = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("followPointer", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default should be false (not null)
        //[Fact]
        //public void Test_IfTooltipFollowPointerDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = false;

        //    chart.PlotOptions.Solidgauge.Tooltip.FollowPointer = defaultValue;

        //    Assert.DoesNotContain($"followPointer", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfTooltipFollowTouchMoveRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "tooltip" };
            var value = false;

            chart.PlotOptions.Solidgauge.Tooltip.FollowTouchMove = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("followTouchMove", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default should be true (not null)
        //[Fact]
        //public void Test_IfTooltipFollowTouchMoveDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Solidgauge.Tooltip.FollowTouchMove = defaultValue;

        //    Assert.DoesNotContain($"followTouchMove", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("</table>")]
        public void Test_IfTooltipFooterFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "tooltip" };

            chart.PlotOptions.Solidgauge.Tooltip.FooterFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("footerFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipFooterFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Tooltip.FooterFormat = defaultValue;

            Assert.DoesNotContain($"footerFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("<table><tr><th colspan='2'>{point.key}</th></tr>")]
        public void Test_IfTooltipHeaderFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "tooltip" };

            chart.PlotOptions.Solidgauge.Tooltip.HeaderFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("headerFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipHeaderFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Tooltip.HeaderFormat = defaultValue;

            Assert.DoesNotContain($"headerFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{series.name}: <b>{point.y}</b><br/>")]
        public void Test_IfTooltipNullFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "tooltip" };

            chart.PlotOptions.Solidgauge.Tooltip.NullFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("nullFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipNullFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Tooltip.NullFormat = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfTooltipNullFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "tooltip" };

            chart.PlotOptions.Solidgauge.Tooltip.NullFormatter = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("nullFormatter", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipNullFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Tooltip.NullFormatter = defaultValue;

            Assert.DoesNotContain($"nullFormatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{series.name}: <b>{point.y}</b><br/>")]
        public void Test_IfTooltipPointFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "tooltip" };

            chart.PlotOptions.Solidgauge.Tooltip.PointFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("pointFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipPointFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Tooltip.PointFormat = defaultValue;

            Assert.DoesNotContain($"pointFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfTooltipPointFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "tooltip" };

            chart.PlotOptions.Solidgauge.Tooltip.PointFormatter = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("pointFormatter", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipPointFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Tooltip.PointFormatter = defaultValue;

            Assert.DoesNotContain($"pointFormatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfTooltipValueDecimalsRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "tooltip" };

            chart.PlotOptions.Solidgauge.Tooltip.ValueDecimals = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("valueDecimals", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipValueDecimalsDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Solidgauge.Tooltip.ValueDecimals = defaultValue;

            Assert.DoesNotContain($"valueDecimals", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("$")]
        public void Test_IfTooltipValuePrefixRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "tooltip" };

            chart.PlotOptions.Solidgauge.Tooltip.ValuePrefix = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("valuePrefix", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipValuePrefixDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Tooltip.ValuePrefix = defaultValue;

            Assert.DoesNotContain($"valuePrefix", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(" USD")]
        public void Test_IfTooltipValueSuffixRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "tooltip" };

            chart.PlotOptions.Solidgauge.Tooltip.ValueSuffix = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("valueSuffix", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipValueSuffixDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Tooltip.ValueSuffix = defaultValue;

            Assert.DoesNotContain($"valueSuffix", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("%Y-%m-%d")]
        public void Test_IfTooltipXDateFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "solidgauge", "tooltip" };

            chart.PlotOptions.Solidgauge.Tooltip.XDateFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("xDateFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipXDateFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Solidgauge.Tooltip.XDateFormat = defaultValue;

            Assert.DoesNotContain($"xDateFormat", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfVisibleRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool value = false;

            chart.PlotOptions.Solidgauge.Visible = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"visible\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Solidgauge.Visible = defaultValue;

            Assert.DoesNotContain($"visible", renderer.RenderHtml());
        }
    }
}

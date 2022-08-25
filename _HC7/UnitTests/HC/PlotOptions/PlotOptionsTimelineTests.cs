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
    public class PlotOptionsTimelineTests : IClassFixture<HcFixture>
    {
        protected HcFixture _fixture;

        public PlotOptionsTimelineTests(HcFixture fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Timeline;
        }

        #region Acessibility

        [Theory]
        [InlineData("Description")]
        public void Test_IfAccessibilityDescriptionRenders_Correct(string description)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Accessibility.Description = description;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"description\":\"{description}\"}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityEnabledRenders_Correct(bool enabled)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Accessibility.Enabled = enabled;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"enabled\":{enabled.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }


        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityExposeAsGroupOnlyRenders_Correct(bool exposeAsGroupOnly)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Accessibility.ExposeAsGroupOnly = exposeAsGroupOnly;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"exposeAsGroupOnly\":{exposeAsGroupOnly.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        #region KeyboardNavigation

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityKeyboardNavigationEnabledRenders_Correct(bool enabled)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Accessibility.KeyboardNavigation.Enabled = enabled;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"keyboardNavigation\":{{\"enabled\":{enabled.ToString().ToLower()}}}}}}}}}", renderer.RenderHtml());
        }

        #endregion

        #region Point

        [Theory]
        [InlineData("%Y-%m-%d %H:%M:%S")]
        public void Test_IfAccessibilityPointDateFormatRenders_Correct(string format)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Accessibility.Point.DateFormat = format;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"dateFormat\":\"{format}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("DateFormatterFunction")]
        public void Test_IfAccessibilityPointDateFormatterRenders_Correct(string function)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Accessibility.Point.DateFormatter = function;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"dateFormatter\":{function}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(false)]
        public void Test_IfAccessibilityPointDescribeNullSetOnFalseRenders_Correct(bool describeNull)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);



            chart.PlotOptions.Timeline.Accessibility.Point.DescribeNull = describeNull;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"describeNull\":{describeNull.ToString().ToLower()}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        public void Test_IfAccessibilityPointDescribeNullSetOnTrueRenders_Correct(bool describeNull)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Accessibility.Point.DescribeNull = describeNull;

            Assert.DoesNotContain($"describeNull", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("FormatterFunction")]
        public void Test_IfAccessibilityPointDescriptionFormatterRenders_Correct(string function)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Accessibility.Point.DescriptionFormatter = function;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"descriptionFormatter\":{function}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(3)]
        public void Test_IfAccessibilityPointValueDecimalsRenders_Correct(int decimals)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Accessibility.Point.ValueDecimals = decimals;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valueDecimals\":{decimals}.0}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{Description}{separator}{value}")]
        public void Test_IfAccessibilityPointValueDescriptionFormatRenders_Correct(string format)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Accessibility.Point.ValueDescriptionFormat = format;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valueDescriptionFormat\":\"{format}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomePrefix")]
        public void Test_IfAccessibilityPointValuePrefixRenders_Correct(string prefix)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Accessibility.Point.ValuePrefix = prefix;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valuePrefix\":\"{prefix}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeSuffix")]
        public void Test_IfAccessibilityPointValueSufixRenders_Correct(string suffix)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Accessibility.Point.ValueSuffix = suffix;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valueSuffix\":\"{suffix}\"}}}}}}}}", renderer.RenderHtml());
        }
        #endregion

        #endregion

        [Fact]
        public void Test_IfAllowPointSelectRenders_Correct()
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var enabled = true;

            chart.PlotOptions.Timeline.AllowPointSelect = enabled;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"allowPointSelect\":{enabled.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAllowPointSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.AllowPointSelect = false;

            Assert.DoesNotContain("allowPointSelect", renderer.RenderHtml());
        }

        #region Animation

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfAnimationEnabledRenders_Correct(bool enabled)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.AnimationBool = enabled;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{enabled.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1000)]
        public void Test_IfAnimationDurationRenders_Correct(int duration)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Animation.Duration = duration;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{{\"duration\":{duration}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1000)]
        public void Test_IfAnimationDeferRenders_Correct(int defer)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Animation.Defer = defer;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{{\"defer\":{defer}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("easingFunctionName")]
        public void Test_IfAnimationEasingRenders_Correct(string easing)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Animation.Easing = easing;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{{\"easing\":\"{easing}\"}}}}}}", renderer.RenderHtml());
        }

        #endregion

        //missing borderColor
        //missing borderWidth

        [Theory]
        [InlineData("ClassName")]
        public void Test_IfClassNameRenders_Correct(string className)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.ClassName = className;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"className\":\"{className}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipRenders_Correct()
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Timeline.Clip = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"clip\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Timeline.Clip = value;

            Assert.DoesNotContain("clip", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#ffffff")]
        public void Test_IfColorRenders_Correct(string color)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Color = color;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"color\":\"{color.ToString().ToLower()}\"}}}}", renderer.RenderHtml());
        }

        //missing logic for GradientColorObject and PatternObject

        [Theory]
        [InlineData("axisId")]
        public void Test_IfColorAxisRendersString_Correct(string id)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.ColorAxis = id;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"colorAxis\":\"{id}\"}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void Test_IfColorAxisRendersNumber_Correct(int index)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.ColorAxisNumber = index;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"colorAxis\":{index}.0}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfColorAxisRendersBool_Correct(bool value)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            chart.PlotOptions.Timeline.ColorAxisBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"colorAxis\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1)]
        public void Test_IfColorIndexRenders_Correct(int value)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.ColorIndex = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"colorIndex\":{value}.0}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("colorValue")]
        public void Test_IfColorKeyRenders_Correct(string value)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.ColorKey = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"colorKey\":\"{value}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCrispRenders_Correct()
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Timeline.Crisp = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"crisp\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCrispDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Timeline.Crisp = value;

            Assert.DoesNotContain($"\"crisp\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsTimelineCursor.Default)]
        [InlineData(PlotOptionsTimelineCursor.Help)]
        [InlineData(PlotOptionsTimelineCursor.Pointer)]
        [InlineData(PlotOptionsTimelineCursor.None)]
        public void Test_IfCursorRenders_Correct(PlotOptionsTimelineCursor cursor)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Cursor = cursor;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"cursor\":\"{cursor.ToString().ToLower()}\"}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("dataKey1", "dataValue1")]
        public void Test_IfCustomRenders_Correct(string key1, string value1)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var extraData = new Hashtable() { { key1, value1 } };

            chart.PlotOptions.Timeline.Custom = extraData;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"custom\":{{\"{key1}\":\"{value1}\"}}}}}}", renderer.RenderHtml());
        }

        #region databaLabels

        //fix required - missing dataLabels as a list of objects (right now it is possible to have only one object)

        [Theory]
        [InlineData(PlotOptionsTimelineDataLabelsAlign.Left)]
        [InlineData(PlotOptionsTimelineDataLabelsAlign.Right)]
        public void Test_IfDataLabelsAlignRenders_Correct(PlotOptionsTimelineDataLabelsAlign align)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Align = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"align\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsTimelineDataLabelsAlign.Center;

            chart.PlotOptions.Timeline.DataLabels.Align = defaultValue;

            Assert.DoesNotContain($"align", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAllowOverlapRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Timeline.DataLabels.AllowOverlap = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"allowOverlap\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAllowOverlapDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Timeline.DataLabels.AllowOverlap = defaultValue;

            Assert.DoesNotContain($"allowOverlap", renderer.RenderHtml());
        }

        #region Animation

        [Theory]
        [InlineData(200)]
        [InlineData(500)]
        public void Test_IfDataLabelsAnimationDeferRenders_Correct(int value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Animation.Defer = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"animation\":{{\"defer\":{value}}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAnimationDeferDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Timeline.DataLabels.Animation.Defer = defaultValue;

            Assert.DoesNotContain($"defer", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsBackgroundColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.BackgroundColor = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"backgroundColor\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBackgroundColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "#ffffff";

            chart.PlotOptions.Timeline.DataLabels.BackgroundColor = defaultValue;

            Assert.DoesNotContain($"backgroundColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsBorderColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.BorderColor = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"borderColor\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "#999999";

            chart.PlotOptions.Timeline.DataLabels.BorderColor = defaultValue;

            Assert.DoesNotContain($"borderColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsBorderRadiusRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.BorderRadius = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"borderRadius\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 3;

            chart.PlotOptions.Timeline.DataLabels.BorderRadius = defaultValue;

            Assert.DoesNotContain($"borderRadius", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsBorderWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.BorderWidth = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"borderWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Timeline.DataLabels.BorderWidth = defaultValue;

            Assert.DoesNotContain($"borderWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("classA")]
        [InlineData("classB")]
        public void Test_IfDataLabelsClassNameRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.ClassName = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"className\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsClassNameDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.DataLabels.ClassName = defaultValue;

            Assert.DoesNotContain($"className", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Color = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"color\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "#333333";

            chart.PlotOptions.Timeline.DataLabels.Color = defaultValue;

            Assert.DoesNotContain($"color", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsCropRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Timeline.DataLabels.Crop = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"crop\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsCropDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Timeline.DataLabels.Crop = defaultValue;

            Assert.DoesNotContain($"crop", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsDeferBoolRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Timeline.DataLabels.DeferBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"defer\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsDeferBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Timeline.DataLabels.DeferBool = defaultValue;

            Assert.DoesNotContain($"defer", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2000)]
        [InlineData(5000)]
        public void Test_IfDataLabelsDeferRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Defer = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"defer\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsEnabledBoolRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Timeline.DataLabels.Enabled = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"enabled\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsEnabledBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Timeline.DataLabels.Enabled = defaultValue;

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
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Filter.Operator = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"filter\":{{\"operator\":\"{value}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterOperatorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.DataLabels.Filter.Operator = defaultValue;

            Assert.DoesNotContain($"operator", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("percentage")]
        [InlineData("y")]
        public void Test_IfDataLabelsFilterPropertyRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Filter.Property = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"filter\":{{\"property\":\"{value}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterPropertyDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.DataLabels.Filter.Property = defaultValue;

            Assert.DoesNotContain($"property", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsFilterValueRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Filter.Value = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"filter\":{{\"value\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Timeline.DataLabels.Filter.Value = defaultValue;

            Assert.DoesNotContain($"value", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("{y} mm")]
        [InlineData("<{x},{y}>")]
        public void Test_IfDataLabelsFormatRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Format = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"format\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "point.value";

            chart.PlotOptions.Timeline.DataLabels.Format = defaultValue;

            Assert.DoesNotContain($"format", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfDataLabelsFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Formatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"formatter\":{value}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.DataLabels.Formatter = defaultValue;

            Assert.DoesNotContain($"formatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataLabelsInsideRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Inside = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"inside\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsInsideDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Timeline.DataLabels.Inside = defaultValue;

            Assert.DoesNotContain($"inside", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataLabelsNullFormatBoolRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.NullFormatBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"nullFormat\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Timeline.DataLabels.NullFormatBool = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{y} mm")]
        [InlineData("<{x},{y}>")]
        public void Test_IfDataLabelsNullFormatRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.NullFormat = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"nullFormat\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.DataLabels.NullFormat = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfDataLabelsNullFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.NullFormatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"nullFormatter\":{value}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.DataLabels.NullFormatter = defaultValue;

            Assert.DoesNotContain($"nullFormatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsTimelineDataLabelsOverflow.Allow)]
        public void Test_IfDataLabelsOverflowRenders_Correct(PlotOptionsTimelineDataLabelsOverflow align)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Overflow = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"overflow\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsOverflowDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsTimelineDataLabelsOverflow.Justify;

            chart.PlotOptions.Timeline.DataLabels.Overflow = defaultValue;

            Assert.DoesNotContain($"overflow", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(50)]
        public void Test_IfDataLabelsPaddingRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Padding = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"padding\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsPaddingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 5;

            chart.PlotOptions.Timeline.DataLabels.Padding = defaultValue;

            Assert.DoesNotContain($"padding", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsTimelineDataLabelsPosition.Left)]
        [InlineData(PlotOptionsTimelineDataLabelsPosition.Right)]
        public void Test_IfDataLabelsPositionRenders_Correct(PlotOptionsTimelineDataLabelsPosition align)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Position = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"position\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsPositionDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsTimelineDataLabelsPosition.Center;

            chart.PlotOptions.Timeline.DataLabels.Position = defaultValue;

            Assert.DoesNotContain($"position", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(90)]
        [InlineData(180)]
        public void Test_IfDataLabelsRotationRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Rotation = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"rotation\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsRotationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Timeline.DataLabels.Rotation = defaultValue;

            Assert.DoesNotContain($"rotation", renderer.RenderHtml());
        }


        //fix required - shadow should be serialized like an object (not hashtable)
        //[Theory]
        //[InlineData("#00ffdd", 10, 20, 30, 40)]
        //[InlineData("#ffccaa", 40, 30, 20, 10)]
        //public void Test_IfDataLabelsShadowRenders_Correct(string color, int offsetX, int offsetY, double opacity, int width)
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);

        //    chart.PlotOptions.Timeline.DataLabels.Shadow = new Shadow()
        //    {
        //        Color = color,
        //        OffsetX = offsetX,
        //        OffsetY = offsetY,
        //        Opacity = opacity,
        //        Width = width
        //    };

        //    var result = renderer.RenderHtml();
        //    Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"shadow\":", result);
        //    Assert.Contains($"\"offsetX\":{offsetX}", result);
        //    Assert.Contains($"\"width\":{width}", result);
        //    Assert.Contains($"\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", opacity)}", result);
        //    Assert.Contains($"\"offsetY\":{offsetY}", result);
        //    Assert.Contains($"\"color\":\"{color}\"", result);
        //}

        [Theory]
        [InlineData("callout")]
        [InlineData("circle")]
        [InlineData("diamond")]
        [InlineData("triangle")]
        [InlineData("triangle-down")]
        public void Test_IfDataLabelsShapeRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Shape = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"shape\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsShapeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "square";

            chart.PlotOptions.Timeline.DataLabels.Shape = defaultValue;

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
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dataLabels", "style" };
            var style = new Hashtable();
            style.Add(param1, param1_value);

            chart.PlotOptions.Timeline.DataLabels.Style = style;

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
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dataLabels", "style" };
            var style = new Hashtable();
            style.Add(param1, param1_value);

            chart.PlotOptions.Timeline.DataLabels.Style = style;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString(param1, param1_value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        #region textPath

        //missing textPath.attributes - fix and set as hashtable

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataLabelsTextPathEnabledRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "dataLabels", "textPath" };

            chart.PlotOptions.Timeline.DataLabels.TextPath.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsTextPathEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Timeline.DataLabels.TextPath.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        #endregion

        [Fact]
        public void Test_IfDataLabelsUseHTMLRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Timeline.DataLabels.UseHTML = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"useHTML\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsUseHTMLDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Timeline.DataLabels.UseHTML = defaultValue;

            Assert.DoesNotContain($"useHTML", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsTimelineDataLabelsVerticalAlign.Middle)]
        [InlineData(PlotOptionsTimelineDataLabelsVerticalAlign.Top)]
        public void Test_IfDataLabelsVerticalAlignRenders_Correct(PlotOptionsTimelineDataLabelsVerticalAlign align)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.VerticalAlign = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"verticalAlign\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsVerticalAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsTimelineDataLabelsVerticalAlign.Bottom;

            chart.PlotOptions.Timeline.DataLabels.VerticalAlign = defaultValue;

            Assert.DoesNotContain($"verticalAlign", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsXRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.X = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"x\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Timeline.DataLabels.X = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"x\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsYRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Y = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"y\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Timeline.DataLabels.Y = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"y\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsZRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.DataLabels.Z = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"z\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsZDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 6;

            chart.PlotOptions.Timeline.DataLabels.Z = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"z\":", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("SomePlotOptionsDescription")]
        public void Test_IfDescriptionRenders_Correct(string description)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Description = description;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"description\":\"{description}\"}}}}", renderer.RenderHtml());
        }

        #region dragDrop

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDragDropDraggableXRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "dragDrop" };

            chart.PlotOptions.Timeline.DragDrop.DraggableX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("draggableX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDraggableXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Timeline.DragDrop.DraggableX = defaultValue;

            Assert.DoesNotContain($"draggableX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDragDropDraggableYRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "dragDrop" };

            chart.PlotOptions.Timeline.DragDrop.DraggableY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("draggableY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDraggableYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Timeline.DragDrop.DraggableY = defaultValue;

            Assert.DoesNotContain($"draggableY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDragDropDragMaxXRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dragDrop" };

            chart.PlotOptions.Timeline.DragDrop.DragMaxX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dragMaxX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDragMaxXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Timeline.DragDrop.DragMaxX = defaultValue;

            Assert.DoesNotContain($"dragMaxX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDragDropDragMaxYRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dragDrop" };

            chart.PlotOptions.Timeline.DragDrop.DragMaxY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dragMaxY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDragMaxYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Timeline.DragDrop.DragMaxY = defaultValue;

            Assert.DoesNotContain($"dragMaxY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDragDropDragMinXRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dragDrop" };

            chart.PlotOptions.Timeline.DragDrop.DragMinX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dragMinX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDragMinXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Timeline.DragDrop.DragMinX = defaultValue;

            Assert.DoesNotContain($"dragMinX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDragDropDragMinYRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dragDrop" };

            chart.PlotOptions.Timeline.DragDrop.DragMinY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dragMinY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDragMinYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Timeline.DragDrop.DragMinY = defaultValue;

            Assert.DoesNotContain($"dragMinY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDragDropDragPrecisionXRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dragDrop" };


            chart.PlotOptions.Timeline.DragDrop.DragPrecisionX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dragPrecisionX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDragPrecisionXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = 0;

            chart.PlotOptions.Timeline.DragDrop.DragPrecisionX = defaultValue;

            Assert.DoesNotContain($"dragPrecisionX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDragDropDragPrecisionYRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dragDrop" };


            chart.PlotOptions.Timeline.DragDrop.DragPrecisionY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dragPrecisionY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDragPrecisionYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = 0;

            chart.PlotOptions.Timeline.DragDrop.DragPrecisionY = defaultValue;

            Assert.DoesNotContain($"dragPrecisionY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDragDropDragSensitivityRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dragDrop" };


            chart.PlotOptions.Timeline.DragDrop.DragSensitivity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dragSensitivity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDragSensitivityDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = 2;

            chart.PlotOptions.Timeline.DragDrop.DragSensitivity = defaultValue;

            Assert.DoesNotContain($"dragPrecisionY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("groupId")]
        public void Test_IfDragDropGroupByRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dragDrop" };


            chart.PlotOptions.Timeline.DragDrop.GroupBy = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("groupBy", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropGroupByDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.DragDrop.GroupBy = defaultValue;

            Assert.DoesNotContain($"groupBy", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeClassName")]
        public void Test_IfDragDropGuideBoxDefaultClassNameRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dragDrop", "guideBox", "default" };


            chart.PlotOptions.Timeline.DragDrop.GuideBox.Default.ClassName = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("className", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropGuideBoxDefaultDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "highcharts-drag-box-default";

            chart.PlotOptions.Timeline.DragDrop.GuideBox.Default.ClassName = defaultValue;

            Assert.DoesNotContain($"className", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#ff0033")]
        public void Test_IfDragDropGuideBoxDefaultColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dragDrop", "guideBox", "default" };


            chart.PlotOptions.Timeline.DragDrop.GuideBox.Default.Color = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("color", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropGuideBoxDefaultColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "rgba(0, 0, 0, 0.1)";

            chart.PlotOptions.Timeline.DragDrop.GuideBox.Default.Color = defaultValue;

            Assert.DoesNotContain($"color", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeCursorName")]
        public void Test_IfDragDropGuideBoxDefaultCursorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dragDrop", "guideBox", "default" };


            chart.PlotOptions.Timeline.DragDrop.GuideBox.Default.Cursor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("cursor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropGuideBoxDefaultCursorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "move";

            chart.PlotOptions.Timeline.DragDrop.GuideBox.Default.Cursor = defaultValue;

            Assert.DoesNotContain($"cursor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#2200ff")]
        public void Test_IfDragDropGuideBoxDefaultLineColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dragDrop", "guideBox", "default" };


            chart.PlotOptions.Timeline.DragDrop.GuideBox.Default.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropGuideBoxDefaultLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "#888";

            chart.PlotOptions.Timeline.DragDrop.GuideBox.Default.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfDragDropGuideBoxDefaultLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dragDrop", "guideBox", "default" };


            chart.PlotOptions.Timeline.DragDrop.GuideBox.Default.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropGuideBoxDefaultLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Timeline.DragDrop.GuideBox.Default.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfDragDropGuideBoxDefaultZIndexRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "dragDrop", "guideBox", "default" };


            chart.PlotOptions.Timeline.DragDrop.GuideBox.Default.ZIndex = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("zIndex", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropGuideBoxDefaultZIndexDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 900;

            chart.PlotOptions.Timeline.DragDrop.GuideBox.Default.ZIndex = defaultValue;

            Assert.DoesNotContain($"zIndex", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropLiveRedrawRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "dragDrop" };
            bool value = false;

            chart.PlotOptions.Timeline.DragDrop.LiveRedraw = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("liveRedraw", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropLiveRedrawDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool defaultValue = true;

            chart.PlotOptions.Timeline.DragDrop.LiveRedraw = defaultValue;

            Assert.DoesNotContain($"liveRedraw", renderer.RenderHtml());
        }

        #endregion

        [Fact]
        public void Test_IfEnableMouseTrackingRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Timeline.EnableMouseTracking = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"enableMouseTracking\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Timeline.EnableMouseTracking = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"enableMouseTracking\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        #region events

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsAfterAnimateRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "events" };

            chart.PlotOptions.Timeline.Events.AfterAnimate = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("afterAnimate", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsAfterAnimateDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Events.AfterAnimate = defaultValue;

            Assert.DoesNotContain($"afterAnimate", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsCheckboxClickRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "events" };

            chart.PlotOptions.Timeline.Events.CheckboxClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("checkboxClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsCheckboxClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Events.CheckboxClick = defaultValue;

            Assert.DoesNotContain($"checkboxClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsClickRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "events" };

            chart.PlotOptions.Timeline.Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsclickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsHideRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "events" };

            chart.PlotOptions.Timeline.Events.Hide = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("hide", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsHideDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Events.Hide = defaultValue;

            Assert.DoesNotContain($"hide", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsLegendItemClickRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "events" };

            chart.PlotOptions.Timeline.Events.LegendItemClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("legendItemClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsLegendItemClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Events.LegendItemClick = defaultValue;

            Assert.DoesNotContain($"legendItemClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "events" };

            chart.PlotOptions.Timeline.Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "events" };

            chart.PlotOptions.Timeline.Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsShowRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "events" };

            chart.PlotOptions.Timeline.Events.Show = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("show", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsShowDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Events.Show = defaultValue;

            Assert.DoesNotContain($"show", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfIncludeInDataExportFromAllRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.IncludeInDataExport = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"includeInDataExport\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfIncludeInDataExportFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? value = null;

            chart.PlotOptions.Timeline.IncludeInDataExport = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"includeInDataExport\":{value}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("name", "y", "dataLabels.style.visibility", "true")]
        public void Test_IfKeysRenders_Correct(string arg1, string arg2, string arg3, string arg4)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = new List<string> { arg1, arg2, arg3, arg4 };

            chart.PlotOptions.Timeline.Keys = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"keys\":[\"{arg1}\",\"{arg2}\",\"{arg3}\",\"{arg4}\"]}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfKeysDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = new List<string>();

            chart.PlotOptions.Timeline.Keys = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"keys\":}}}}", renderer.RenderHtml());
        }

        #region label

        //missing boxesToAvoid

        [Fact]
        public void Test_IfLabelConnectorAllowedRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "label" };
            var value = true;

            chart.PlotOptions.Timeline.Label.ConnectorAllowed = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorAllowed", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorAllowedDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Timeline.Label.ConnectorAllowed = defaultValue;

            Assert.DoesNotContain($"connectorAllowed", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(30)]
        public void Test_IfLabelConnectorNeighbourDistanceRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "label" };

            chart.PlotOptions.Timeline.Label.ConnectorNeighbourDistance = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorNeighbourDistance", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorNeighbourDistanceDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 24;

            chart.PlotOptions.Timeline.Label.ConnectorNeighbourDistance = defaultValue;

            Assert.DoesNotContain($"connectorNeighbourDistance", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "label" };
            var value = false;

            chart.PlotOptions.Timeline.Label.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Timeline.Label.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFormat")]
        public void Test_IfLabelFormatRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "label" };

            chart.PlotOptions.Timeline.Label.Format = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("format", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        /// <summary>
        /// Fix default value for Format
        /// </summary>
        /// <param name="value"></param>
        //[Fact]
        //public void Test_IfLabelFormatDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Timeline.Label.Format = defaultValue;

        //    Assert.DoesNotContain($"format", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("SomeFormatterFunction")]
        public void Test_IfLabelFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "label" };

            chart.PlotOptions.Timeline.Label.Formatter = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("formatter", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Label.Formatter = defaultValue;

            Assert.DoesNotContain($"formatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMaxFontSizeRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "label" };

            chart.PlotOptions.Timeline.Label.MaxFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("maxFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMaxFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Timeline.Label.MaxFontSize = defaultValue;

            Assert.DoesNotContain($"maxFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMinFontSizeRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "label" };

            chart.PlotOptions.Timeline.Label.MinFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("minFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMinFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Timeline.Label.MinFontSize = defaultValue;

            Assert.DoesNotContain($"minFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfLabelOnAreaRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "label" };

            chart.PlotOptions.Timeline.Label.OnArea = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("onArea", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelOnAreaDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Timeline.Label.OnArea = defaultValue;

            Assert.DoesNotContain($"onArea", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("fontWeight", "bold")]
        public void Test_IfLabelStyleRenders_Correct(string paramName, string paramValue)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "label" };
            var value = new Hashtable();
            value.Add(paramName, paramValue);


            chart.PlotOptions.Timeline.Label.Style = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetHashtablePropertyString("style", paramName, paramValue)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        /// <summary>
        /// Fix default value for style - empty hashtable should be not rendered
        /// </summary>
        /// <param name="value"></param>
        //[Fact]
        //public void Test_IfLabelStyleDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Timeline.Label.Style = defaultValue;

        //    Assert.DoesNotContain($"style", renderer.RenderHtml());
        //}



        #endregion


        //fix required - Linecap should be enum (not string)
        //[Theory]
        //[InlineData(PlotOptionsTimelineLinecap.Square)]
        ////missing PlotOptionsTimelineLinecap.Butt ?
        //public void Test_IfLinecapRenders_Correct(PlotOptionsTimelineLinecap value)
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);

        //    chart.PlotOptions.Timeline.Linecap = value;

        //    Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linecap\":\"{chart.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfLinecapDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = PlotOptionsTimelineLinecap.Round;

        //    chart.PlotOptions.Timeline.Linecap = defaultValue;

        //    Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linecap\":{defaultValue.ToString().ToLower()}}}}}", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.LineWidth = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"lineWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 4;

            chart.PlotOptions.Timeline.LineWidth = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"lineWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", defaultValue)}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(":previous")]
        [InlineData("IdAnotherSeries")]
        public void Test_IfLinkedToRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.LinkedTo = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linkedTo\":\"{value}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLinkedToDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            string defaultValue = String.Empty;

            chart.PlotOptions.Timeline.LinkedTo = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linkedTo\":{defaultValue}}}}}", renderer.RenderHtml());
        }

        #region marker

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfMarkerEnabledRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "marker" };

            chart.PlotOptions.Timeline.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Timeline.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "marker" };

            chart.PlotOptions.Timeline.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double defaultValue = 0;

            chart.PlotOptions.Timeline.Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "marker" };

            chart.PlotOptions.Timeline.Marker.FillColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("fillColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        /// <summary>
        /// fix that color - should be a string, patternObject and GradientObject
        /// </summary>
        /// <param name="value"></param>
        //[Fact]
        //public void Test_IfMarkerFillColorDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Timeline.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "marker" };

            chart.PlotOptions.Timeline.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = 15;

            chart.PlotOptions.Timeline.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "marker" };

            chart.PlotOptions.Timeline.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "#ffffff";

            chart.PlotOptions.Timeline.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "marker" };

            chart.PlotOptions.Timeline.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 2;

            chart.PlotOptions.Timeline.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "marker" };

            chart.PlotOptions.Timeline.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //clarification required - what is correct default value 4 or 6
        [Fact]
        public void Test_IfMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 6;

            chart.PlotOptions.Timeline.Marker.Radius = defaultValue;

            Assert.DoesNotContain($"radius", renderer.RenderHtml());
        }

        //missing States

        [Theory]
        [InlineData("circle")]
        [InlineData("diamond")]
        [InlineData("triangle")]
        [InlineData("triangle-down")]
        [InlineData("url(graphic.png)")]
        public void Test_IfMarkerSymbolRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "marker" };

            chart.PlotOptions.Timeline.Marker.Symbol = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("symbol", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerSymbolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "square";

            chart.PlotOptions.Timeline.Marker.Symbol = defaultValue;

            Assert.DoesNotContain($"symbol", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(1000)]
        public void Test_IfMarkerWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "marker" };

            chart.PlotOptions.Timeline.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Timeline.Marker.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        #endregion

        #region onPoint

        //fix dashStyle - should be string instead of hashtable
        //[Theory]
        //[InlineData("dot")]
        //public void Test_IfOnPointConnectorOptionsDashStyleRenders_Correct(string value)
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "timeline", "onPoint", "connectorOptions" };

        //    chart.PlotOptions.Timeline.OnPoint.ConnectorOptions.Dashstyle = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dashstyle", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfOnPointConnectorOptionsDashStyleDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Timeline.DataLabels.Color = defaultValue;

        //    Assert.DoesNotContain($"color", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("red")]
        public void Test_IfOnPointConnectorOptionsStrokeRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "onPoint", "connectorOptions" };

            chart.PlotOptions.Timeline.OnPoint.ConnectorOptions.Stroke = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("stroke", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsStrokeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.OnPoint.ConnectorOptions.Stroke = defaultValue;

            Assert.DoesNotContain($"stroke", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointConnectorOptionsWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "onPoint", "connectorOptions" };

            chart.PlotOptions.Timeline.OnPoint.ConnectorOptions.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Timeline.OnPoint.ConnectorOptions.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("pointId")]
        public void Test_IfOnPointIdRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "onPoint" };

            chart.PlotOptions.Timeline.OnPoint.Id = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("id", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointIdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.OnPoint.Id = defaultValue;

            Assert.DoesNotContain($"\"id\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetXRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "onPoint", "position" };

            chart.PlotOptions.Timeline.OnPoint.Position.OffsetX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Timeline.OnPoint.Position.OffsetX = defaultValue;

            Assert.DoesNotContain($"offsetX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetYRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "onPoint", "position" };

            chart.PlotOptions.Timeline.OnPoint.Position.OffsetY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Timeline.OnPoint.Position.OffsetY = defaultValue;

            Assert.DoesNotContain($"offsetY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionXRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "onPoint", "position" };

            chart.PlotOptions.Timeline.OnPoint.Position.X = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("x", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Timeline.OnPoint.Position.X = defaultValue;

            Assert.DoesNotContain($"\"x\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionYRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "onPoint", "position" };

            chart.PlotOptions.Timeline.OnPoint.Position.Y = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("y", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Timeline.OnPoint.Position.Y = defaultValue;

            Assert.DoesNotContain($"\"y\":", renderer.RenderHtml());
        }

        #endregion


        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfOpacityRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Opacity = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOpacityDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Timeline.Opacity = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", defaultValue)}}}}}", renderer.RenderHtml());
        }

        #region point

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsClickRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "point", "events" };

            chart.PlotOptions.Timeline.Point.Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Point.Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "point", "events" };

            chart.PlotOptions.Timeline.Point.Events.Drag = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drag", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Point.Events.Drag = defaultValue;

            Assert.DoesNotContain($"drag", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragStartRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "point", "events" };

            chart.PlotOptions.Timeline.Point.Events.DragStart = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("dragStart", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragStartDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Point.Events.DragStart = defaultValue;

            Assert.DoesNotContain($"dragStart", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDropRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "point", "events" };

            chart.PlotOptions.Timeline.Point.Events.Drop = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drop", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDropDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Point.Events.Drop = defaultValue;

            Assert.DoesNotContain($"drop", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "point", "events" };

            chart.PlotOptions.Timeline.Point.Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Point.Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "point", "events" };

            chart.PlotOptions.Timeline.Point.Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Point.Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsRemoveRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "point", "events" };

            chart.PlotOptions.Timeline.Point.Events.Remove = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("remove", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsRemoveDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Point.Events.Remove = defaultValue;

            Assert.DoesNotContain($"remove", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsSelectRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "point", "events" };

            chart.PlotOptions.Timeline.Point.Events.Select = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("select", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Point.Events.Select = defaultValue;

            Assert.DoesNotContain($"select", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUnselectRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "point", "events" };

            chart.PlotOptions.Timeline.Point.Events.Unselect = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("unselect", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUnselectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Point.Events.Unselect = defaultValue;

            Assert.DoesNotContain($"unselect", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUpdateRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "point", "events" };

            chart.PlotOptions.Timeline.Point.Events.Update = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("update", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUpdateDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.Point.Events.Update = defaultValue;

            Assert.DoesNotContain($"update", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointDescriptionFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.PointDescriptionFormatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"pointDescriptionFormatter\":{value}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointDescriptionFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Timeline.PointDescriptionFormatter = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"pointDescriptionFormatter\":{defaultValue}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Timeline.RelativeXValue = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"relativeXValue\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Timeline.RelativeXValue = defaultValue;

            Assert.DoesNotContain($"relativeXValue", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Timeline.Selected = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"selected\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Timeline.Selected = defaultValue;

            Assert.DoesNotContain($"selected", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShadowBoolRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Timeline.ShadowBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"shadow\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#00ffdd", 10, 20, 30, 40)]
        [InlineData("#ffccaa", 40, 30, 20, 10)]
        public void Test_IfShadowRenders_Correct(string color, int offsetX, int offsetY, double opacity, int width)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.Shadow = new Shadow()
            {
                Color = color,
                OffsetX = offsetX,
                OffsetY = offsetY,
                Opacity = opacity,
                Width = width
            };

            var result = renderer.RenderHtml();
            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"shadow\":", result);
            Assert.Contains($"\"offsetX\":{offsetX}", result);
            Assert.Contains($"\"width\":{width}", result);
            Assert.Contains($"\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", opacity)}", result);
            Assert.Contains($"\"offsetY\":{offsetY}", result);
            Assert.Contains($"\"color\":\"{color}\"", result);
        }

        [Fact]
        public void Test_IfShadowBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Timeline.ShadowBool = defaultValue;

            Assert.DoesNotContain($"shadow", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowCheckboxRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Timeline.ShowCheckbox = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"showCheckbox\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowCheckboxDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Timeline.ShowCheckbox = defaultValue;

            Assert.DoesNotContain($"showCheckbox", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowInLegendRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Timeline.ShowInLegend = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"showInLegend\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowInLegendDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Timeline.ShowInLegend = defaultValue;

            Assert.DoesNotContain($"showInLegend", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfSkipKeyboardNavigationRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.SkipKeyboardNavigation = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"skipKeyboardNavigation\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSkipKeyboardNavigationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Timeline.SkipKeyboardNavigation = null;

            Assert.DoesNotContain($"skipKeyboardNavigation", renderer.RenderHtml());
        }

        #region states

        #region hover

        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesHoverEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Timeline.States.Hover.Enabled = defaultValue;

        //    Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        //}

        #region halo

        // fix required - attributes should be hashtable (not object)
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesHoverHaloAttributesRenders_Correct(int value)
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "timeline", "states", "hover", "halo" };

        //    chart.PlotOptions.Timeline.States.Hover.Halo.Attributes = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("attributes", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfStatesHoverHaloAttributesDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Timeline.States.Hover.Animation.Duration = defaultValue;

        //    Assert.DoesNotContain($"duration", renderer.RenderHtml());
        //}

        //fix required - default value for opacity = 0.25 (not null)
        //[Fact]
        //public void Test_IfStatesHoverHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Timeline.States.Hover.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Theory]
        //[InlineData(2)]
        //[InlineData(0.5)]
        //public void Test_IfStatesHoverHaloSizeRenders_Correct(double value)
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "timeline", "states", "hover", "halo" };

        //    chart.PlotOptions.Timeline.States.Hover.Halo.Size = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("size", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Fact]
        //public void Test_IfStatesHoverHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Timeline.States.Hover.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesHoverLineWidthPlusRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "states", "hover" };

            chart.PlotOptions.Timeline.States.Hover.LineWidthPlus = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidthPlus", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default should be 1 (not null)
        //[Fact]
        //public void Test_IfStatesHoverLineWidthPlusDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    double? defaultValue = 1;

        //    chart.PlotOptions.Timeline.States.Hover.LineWidthPlus = defaultValue;

        //    Assert.DoesNotContain($"lineWidthPlus", renderer.RenderHtml());
        //}

        #region marker

        //fix required - default value should be 2
        //[Fact]
        //public void Test_IfStatesHoverMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    double defaultValue = 2;

        //    chart.PlotOptions.Timeline.Marker.EnabledThreshold = defaultValue;

        //    Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        //}

        /// <summary>
        /// fix that color - should be a string, patternObject and GradientObject
        /// </summary>
        /// <param name="value"></param>
        //[Fact]
        //public void Test_IfStatesHoverMarkerFillColorDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Timeline.States.Hover.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

       
        //missing States

        #endregion

        #endregion

        #region inactive

        #region animation
        [Theory]
        [InlineData(5)]
        public void Test_IfStatesInactiveAnimationDurationRenders_Correct(int value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "states", "inactive", "animation" };

            chart.PlotOptions.Timeline.States.Inactive.Animation.Duration = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesInactiveAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Timeline.States.Inactive.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesInactiveEnabledRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "states", "inactive" };
            var value = false;

            chart.PlotOptions.Timeline.States.Inactive.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesInactiveEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Timeline.States.Inactive.Enabled = defaultValue;

        //    Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(0.5)]
        public void Test_IfStatesInactiveOpacityRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "states", "inactive" };

            chart.PlotOptions.Timeline.States.Inactive.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default value should be 0.2 (not null)
        //[Fact]
        //public void Test_IfStatesInactiveOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.2;

        //    chart.PlotOptions.Timeline.States.Inactive.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        #region normal

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesNormalAnimationDurationRenders_Correct(int value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "states", "normal", "animation" };

            chart.PlotOptions.Timeline.States.Normal.Animation.Duration = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesNormalAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Timeline.States.Normal.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }

        //fix required - missing ..States.Normal.AnimationBool 

        #endregion

        #region select

        #region animation
        [Theory]
        [InlineData(5)]
        public void Test_IfStatesSelectAnimationDurationRenders_Correct(int value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "states", "select", "animation" };

            chart.PlotOptions.Timeline.States.Select.Animation.Duration = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Timeline.States.Select.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesSelectEnabledRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "states", "select" };
            var value = false;

            chart.PlotOptions.Timeline.States.Select.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesSelectEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Timeline.States.Select.Enabled = defaultValue;

        //    Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        //}

        #region halo

        // fix required - attributes should be hashtable (not object)
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesSelectHaloAttributesRenders_Correct(int value)
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "timeline", "states", "select", "halo" };

        //    chart.PlotOptions.Timeline.States.Select.Halo.Attributes = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("attributes", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfStatesSelectHaloAttributesDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Timeline.States.Select.Animation.Duration = defaultValue;

        //    Assert.DoesNotContain($"duration", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(2)]
        [InlineData(0.5)]
        public void Test_IfStatesSelectHaloOpacityRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "states", "select", "halo" };

            chart.PlotOptions.Timeline.States.Select.Halo.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default value for opacity = 0.25 (not null)
        //[Fact]
        //public void Test_IfStatesSelectHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Timeline.States.Select.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Theory]
        //[InlineData(2)]
        //[InlineData(0.5)]
        //public void Test_IfStatesSelectHaloSizeRenders_Correct(double value)
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "timeline", "states", "select", "halo" };

        //    chart.PlotOptions.Timeline.States.Select.Halo.Size = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("size", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Fact]
        //public void Test_IfStatesSelectHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Timeline.States.Select.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesSelectLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "states", "select" };

            chart.PlotOptions.Timeline.States.Select.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Timeline.States.Select.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesSelectLineWidthPlusRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "states", "select" };

            chart.PlotOptions.Timeline.States.Select.LineWidthPlus = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidthPlus", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default should be 1 (not null)
        //[Fact]
        //public void Test_IfStatesSelectLineWidthPlusDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    double? defaultValue = 1;

        //    chart.PlotOptions.Timeline.States.Select.LineWidthPlus = defaultValue;

        //    Assert.DoesNotContain($"lineWidthPlus", renderer.RenderHtml());
        //}

        #region marker

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfStatesSelectMarkerEnabledRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "states", "select", "marker" };

            chart.PlotOptions.Timeline.States.Select.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Timeline.States.Select.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesSelectMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "states", "select", "marker" };

            chart.PlotOptions.Timeline.States.Select.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default value should be 2
        //[Fact]
        //public void Test_IfStatesSelectMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    double defaultValue = 2;

        //    chart.PlotOptions.Timeline.Marker.EnabledThreshold = defaultValue;

        //    Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("red")]
        public void Test_IfStatesSelectMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "states", "select", "marker" };

            chart.PlotOptions.Timeline.States.Select.Marker.FillColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("fillColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        /// <summary>
        /// fix that color - should be a string, patternObject and GradientObject
        /// </summary>
        /// <param name="value"></param>
        //[Fact]
        //public void Test_IfStatesSelectMarkerFillColorDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Timeline.States.Select.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesSelectMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "states", "select", "marker" };

            chart.PlotOptions.Timeline.States.Select.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Timeline.States.Select.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfStatesSelectMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "states", "select", "marker" };

            chart.PlotOptions.Timeline.States.Select.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "#ffffff";

            chart.PlotOptions.Timeline.States.Select.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesSelectMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "states", "select", "marker" };

            chart.PlotOptions.Timeline.States.Select.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Timeline.States.Select.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesSelectMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "states", "select", "marker" };

            chart.PlotOptions.Timeline.States.Select.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 4;

            chart.PlotOptions.Timeline.States.Select.Marker.Radius = defaultValue;

            Assert.DoesNotContain($"radius", renderer.RenderHtml());
        }

        //missing States

        [Theory]
        [InlineData(5)]
        [InlineData(1000)]
        public void Test_IfStatesSelectMarkerWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "timeline", "states", "select", "marker" };

            chart.PlotOptions.Timeline.States.Select.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Timeline.States.Select.Marker.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        #endregion

        #endregion

        #endregion

        [Fact]
        public void Test_IfStickyTrackingRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Timeline.StickyTracking = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"stickyTracking\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Timeline.StickyTracking = defaultValue;

            Assert.DoesNotContain($"stickyTracking", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{series.name}: <b>{point.y}</b><br/>")]
        public void Test_IfTooltipPointFormatRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "timeline", "tooltip" };

            chart.PlotOptions.Timeline.Tooltip.PointFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("pointFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipPointFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "{point.description}";

            chart.PlotOptions.Timeline.Tooltip.PointFormat = defaultValue;

            Assert.DoesNotContain($"pointFormat", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = false;

            chart.PlotOptions.Timeline.Visible = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"visible\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Timeline.Visible = defaultValue;

            Assert.DoesNotContain($"visible", renderer.RenderHtml());
        }
    }
}

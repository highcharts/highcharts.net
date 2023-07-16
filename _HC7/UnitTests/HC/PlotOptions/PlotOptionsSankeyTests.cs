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
    public class PlotOptionsSankeyTests : IClassFixture<HcFixture>
    {
        protected HcFixture _fixture;

        public PlotOptionsSankeyTests(HcFixture fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Sankey;
        }

        #region Acessibility

        [Theory]
        [InlineData("Description")]
        public void Test_IfAccessibilityDescriptionRenders_Correct(string description)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.Accessibility.Description = description;

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

            chart.PlotOptions.Sankey.Accessibility.Enabled = enabled;

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

            chart.PlotOptions.Sankey.Accessibility.ExposeAsGroupOnly = exposeAsGroupOnly;

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

            chart.PlotOptions.Sankey.Accessibility.KeyboardNavigation.Enabled = enabled;

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

            chart.PlotOptions.Sankey.Accessibility.Point.DateFormat = format;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"dateFormat\":\"{format}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("DateFormatterFunction")]
        public void Test_IfAccessibilityPointDateFormatterRenders_Correct(string function)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.Accessibility.Point.DateFormatter = function;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"dateFormatter\":{function}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(false)]
        public void Test_IfAccessibilityPointDescribeNullSetOnFalseRenders_Correct(bool describeNull)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);



            chart.PlotOptions.Sankey.Accessibility.Point.DescribeNull = describeNull;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"describeNull\":{describeNull.ToString().ToLower()}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        public void Test_IfAccessibilityPointDescribeNullSetOnTrueRenders_Correct(bool describeNull)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.Accessibility.Point.DescribeNull = describeNull;

            Assert.DoesNotContain($"describeNull", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("FormatterFunction")]
        public void Test_IfAccessibilityPointDescriptionFormatterRenders_Correct(string function)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.Accessibility.Point.DescriptionFormatter = function;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"descriptionFormatter\":{function}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(3)]
        public void Test_IfAccessibilityPointValueDecimalsRenders_Correct(int decimals)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.Accessibility.Point.ValueDecimals = decimals;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valueDecimals\":{decimals}.0}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{Description}{separator}{value}")]
        public void Test_IfAccessibilityPointValueDescriptionFormatRenders_Correct(string format)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.Accessibility.Point.ValueDescriptionFormat = format;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valueDescriptionFormat\":\"{format}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomePrefix")]
        public void Test_IfAccessibilityPointValuePrefixRenders_Correct(string prefix)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.Accessibility.Point.ValuePrefix = prefix;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valuePrefix\":\"{prefix}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeSuffix")]
        public void Test_IfAccessibilityPointValueSufixRenders_Correct(string suffix)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.Accessibility.Point.ValueSuffix = suffix;

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

            chart.PlotOptions.Sankey.AllowPointSelect = enabled;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"allowPointSelect\":{enabled.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAllowPointSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.AllowPointSelect = false;

            Assert.DoesNotContain("allowPointSelect", renderer.RenderHtml());
        }

        #region Animation

        [Fact]
        public void Test_IfAnimationEnabledRenders_Correct()
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Sankey.AnimationBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAnimationEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Sankey.AnimationBool = value;

            Assert.DoesNotContain("animation", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1000)]
        public void Test_IfAnimationDurationRenders_Correct(int duration)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.Animation.Duration = duration;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{{\"duration\":{duration}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1000)]
        public void Test_IfAnimationDeferRenders_Correct(int defer)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.Animation.Defer = defer;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{{\"defer\":{defer}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("easingFunctionName")]
        public void Test_IfAnimationEasingRenders_Correct(string easing)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.Animation.Easing = easing;

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

            chart.PlotOptions.Sankey.ClassName = className;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"className\":\"{className}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipRenders_Correct()
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Sankey.Clip = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"clip\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Sankey.Clip = value;

            Assert.DoesNotContain("clip", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#ffffff")]
        public void Test_IfColorRenders_Correct(string color)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.Color = color;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"color\":\"{color.ToString().ToLower()}\"}}}}", renderer.RenderHtml());
        }

        //missing logic for GradientColorObject and PatternObject

        [Theory]
        [InlineData(1)]
        public void Test_IfColorIndexRenders_Correct(int value)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.ColorIndex = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"colorIndex\":{value}.0}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSankeyCursor.Default)]
        [InlineData(PlotOptionsSankeyCursor.Help)]
        [InlineData(PlotOptionsSankeyCursor.Pointer)]
        [InlineData(PlotOptionsSankeyCursor.None)]
        public void Test_IfCursorRenders_Correct(PlotOptionsSankeyCursor cursor)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.Cursor = cursor;

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

            chart.PlotOptions.Sankey.Custom = extraData;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"custom\":{{\"{key1}\":\"{value1}\"}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSankeyDashStyle.Dash)]
        [InlineData(PlotOptionsSankeyDashStyle.DashDot)]
        [InlineData(PlotOptionsSankeyDashStyle.Dot)]
        [InlineData(PlotOptionsSankeyDashStyle.LongDash)]
        [InlineData(PlotOptionsSankeyDashStyle.LongDashDot)]
        [InlineData(PlotOptionsSankeyDashStyle.LongDashDotDot)]
        [InlineData(PlotOptionsSankeyDashStyle.ShortDash)]
        [InlineData(PlotOptionsSankeyDashStyle.ShortDashDot)]
        [InlineData(PlotOptionsSankeyDashStyle.ShortDashDotDot)]
        [InlineData(PlotOptionsSankeyDashStyle.ShortDot)]
        public void Test_IfDashStyleRenders_Correct(PlotOptionsSankeyDashStyle style)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var result = style.ToString();
            var replacement = result[0].ToString().ToLower();
            result = result.Remove(0, 1);
            result = replacement + result;

            chart.PlotOptions.Sankey.DashStyle = style;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dashStyle\":\"{result}\"}}}}", renderer.RenderHtml());
        }


        #region databaLabels

        //fix required - missing dataLabels as a list of objects (right now it is possible to have only one object)

        [Theory]
        [InlineData(PlotOptionsSankeyDataLabelsAlign.Left)]
        [InlineData(PlotOptionsSankeyDataLabelsAlign.Right)]
        public void Test_IfDataLabelsAlignRenders_Correct(PlotOptionsSankeyDataLabelsAlign align)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.Align = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"align\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSankeyDataLabelsAlign.Center;

            chart.PlotOptions.Sankey.DataLabels.Align = defaultValue;

            Assert.DoesNotContain($"align", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAllowOverlapRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Sankey.DataLabels.AllowOverlap = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"allowOverlap\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAllowOverlapDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Sankey.DataLabels.AllowOverlap = defaultValue;

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

            chart.PlotOptions.Sankey.DataLabels.Animation.Defer = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"animation\":{{\"defer\":{value}}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAnimationDeferDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Sankey.DataLabels.Animation.Defer = defaultValue;

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

            chart.PlotOptions.Sankey.DataLabels.BackgroundColor = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"backgroundColor\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBackgroundColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "none";

            chart.PlotOptions.Sankey.DataLabels.BackgroundColor = defaultValue;

            Assert.DoesNotContain($"backgroundColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsBorderColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.BorderColor = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"borderColor\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.DataLabels.BorderColor = defaultValue;

            Assert.DoesNotContain($"borderColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsBorderRadiusRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.BorderRadius = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"borderRadius\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Sankey.DataLabels.BorderRadius = defaultValue;

            Assert.DoesNotContain($"borderRadius", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsBorderWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.BorderWidth = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"borderWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Sankey.DataLabels.BorderWidth = defaultValue;

            Assert.DoesNotContain($"borderWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("classA")]
        [InlineData("classB")]
        public void Test_IfDataLabelsClassNameRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.ClassName = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"className\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsClassNameDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.DataLabels.ClassName = defaultValue;

            Assert.DoesNotContain($"className", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.Color = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"color\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.DataLabels.Color = defaultValue;

            Assert.DoesNotContain($"color", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsCropRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Sankey.DataLabels.Crop = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"crop\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsCropDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Sankey.DataLabels.Crop = defaultValue;

            Assert.DoesNotContain($"crop", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsDeferBoolRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Sankey.DataLabels.Defer = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"defer\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsDeferBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Sankey.DataLabels.Defer = defaultValue;

            Assert.DoesNotContain($"defer", renderer.RenderHtml());
        }

        //[Theory]
        //[InlineData(2000)]
        //[InlineData(5000)]
        //public void Test_IfDataLabelsDeferRenders_Correct(double value)
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);

        //    chart.PlotOptions.Sankey.DataLabels.Defer = value;

        //    Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"defer\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfDataLabelsEnabledBoolRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Sankey.DataLabels.Enabled = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"enabled\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsEnabledBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Sankey.DataLabels.Enabled = defaultValue;

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

            chart.PlotOptions.Sankey.DataLabels.Filter.Operator = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"filter\":{{\"operator\":\"{value}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterOperatorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.DataLabels.Filter.Operator = defaultValue;

            Assert.DoesNotContain($"operator", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("percentage")]
        [InlineData("y")]
        public void Test_IfDataLabelsFilterPropertyRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.Filter.Property = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"filter\":{{\"property\":\"{value}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterPropertyDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.DataLabels.Filter.Property = defaultValue;

            Assert.DoesNotContain($"property", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsFilterValueRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.Filter.Value = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"filter\":{{\"value\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Sankey.DataLabels.Filter.Value = defaultValue;

            Assert.DoesNotContain($"value", renderer.RenderHtml());
        }

        #endregion

        //fix required - type should be string
        //[Theory]
        //[InlineData("{y} mm")]
        //[InlineData("<{x},{y}>")]
        //public void Test_IfDataLabelsFormatRenders_Correct(string value)
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);

        //    chart.PlotOptions.Sankey.DataLabels.Format = value;

        //    Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"format\":\"{value}\"}}}}}}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfDataLabelsFormatDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = "point.value";

        //    chart.PlotOptions.Sankey.DataLabels.Format = defaultValue;

        //    Assert.DoesNotContain($"format", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfDataLabelsFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.Formatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"formatter\":{value}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.DataLabels.Formatter = defaultValue;

            Assert.DoesNotContain($"formatter", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsInsideRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = false;

            chart.PlotOptions.Sankey.DataLabels.Inside = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"inside\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsInsideDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = true;

            chart.PlotOptions.Sankey.DataLabels.Inside = defaultValue;

            Assert.DoesNotContain($"inside", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataLabelsNullFormatBoolRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.NullFormatBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"nullFormat\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Sankey.DataLabels.NullFormatBool = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{y} mm")]
        [InlineData("<{x},{y}>")]
        public void Test_IfDataLabelsNullFormatRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.NullFormat = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"nullFormat\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.DataLabels.NullFormat = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfDataLabelsNullFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.NullFormatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"nullFormatter\":{value}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.DataLabels.NullFormatter = defaultValue;

            Assert.DoesNotContain($"nullFormatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSankeyDataLabelsOverflow.Allow)]
        public void Test_IfDataLabelsOverflowRenders_Correct(PlotOptionsSankeyDataLabelsOverflow align)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.Overflow = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"overflow\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsOverflowDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSankeyDataLabelsOverflow.Justify;

            chart.PlotOptions.Sankey.DataLabels.Overflow = defaultValue;

            Assert.DoesNotContain($"overflow", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(50)]
        public void Test_IfDataLabelsPaddingRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.Padding = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"padding\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsPaddingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 5;

            chart.PlotOptions.Sankey.DataLabels.Padding = defaultValue;

            Assert.DoesNotContain($"padding", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSankeyDataLabelsPosition.Left)]
        [InlineData(PlotOptionsSankeyDataLabelsPosition.Right)]
        public void Test_IfDataLabelsPositionRenders_Correct(PlotOptionsSankeyDataLabelsPosition align)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.Position = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"position\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsPositionDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSankeyDataLabelsPosition.Center;

            chart.PlotOptions.Sankey.DataLabels.Position = defaultValue;

            Assert.DoesNotContain($"position", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(90)]
        [InlineData(180)]
        public void Test_IfDataLabelsRotationRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.Rotation = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"rotation\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsRotationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Sankey.DataLabels.Rotation = defaultValue;

            Assert.DoesNotContain($"rotation", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsShadowBoolRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Sankey.DataLabels.ShadowBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"shadow\":{chart.FirstCharacterToLower(value.ToString())}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#00ffdd", 10, 20, 30, 40)]
        [InlineData("#ffccaa", 40, 30, 20, 10)]
        public void Test_IfDataLabelsShadowRenders_Correct(string color, int offsetX, int offsetY, double opacity, int width)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.Shadow = new Shadow()
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
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Sankey.DataLabels.ShadowBool = defaultValue;

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
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.Shape = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"shape\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsShapeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "square";

            chart.PlotOptions.Sankey.DataLabels.Shape = defaultValue;

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
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "dataLabels", "style" };
            var style = new Hashtable();
            style.Add(param1, param1_value);

            chart.PlotOptions.Sankey.DataLabels.Style = style;

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
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "dataLabels", "style" };
            var style = new Hashtable();
            style.Add(param1, param1_value);

            chart.PlotOptions.Sankey.DataLabels.Style = style;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString(param1, param1_value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        #region textPath

        //missing textPath.attributes - fix and set as hashtable

        [Theory]
        [InlineData(true)]
        public void Test_IfDataLabelsTextPathEnabledRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "dataLabels", "textPath" };

            chart.PlotOptions.Sankey.DataLabels.TextPath.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsTextPathEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = false;

            chart.PlotOptions.Sankey.DataLabels.TextPath.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        #endregion

        [Fact]
        public void Test_IfDataLabelsUseHTMLRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Sankey.DataLabels.UseHTML = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"useHTML\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsUseHTMLDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Sankey.DataLabels.UseHTML = defaultValue;

            Assert.DoesNotContain($"useHTML", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSankeyDataLabelsVerticalAlign.Middle)]
        [InlineData(PlotOptionsSankeyDataLabelsVerticalAlign.Top)]
        public void Test_IfDataLabelsVerticalAlignRenders_Correct(PlotOptionsSankeyDataLabelsVerticalAlign align)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.VerticalAlign = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"verticalAlign\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsVerticalAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSankeyDataLabelsVerticalAlign.Bottom;

            chart.PlotOptions.Sankey.DataLabels.VerticalAlign = defaultValue;

            Assert.DoesNotContain($"verticalAlign", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsXRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.X = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"x\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Sankey.DataLabels.X = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"x\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsYRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.Y = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"y\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Sankey.DataLabels.Y = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"y\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsZRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.DataLabels.ZIndex = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"zIndex\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsZDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 6;

            chart.PlotOptions.Sankey.DataLabels.ZIndex = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"zIndex\":", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("SomePlotOptionsDescription")]
        public void Test_IfDescriptionRenders_Correct(string description)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.Description = description;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"description\":\"{description}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Sankey.EnableMouseTracking = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"enableMouseTracking\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Sankey.EnableMouseTracking = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"enableMouseTracking\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        #region events

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsAfterAnimateRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "events" };

            chart.PlotOptions.Sankey.Events.AfterAnimate = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("afterAnimate", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsAfterAnimateDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Events.AfterAnimate = defaultValue;

            Assert.DoesNotContain($"afterAnimate", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsCheckboxClickRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "events" };

            chart.PlotOptions.Sankey.Events.CheckboxClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("checkboxClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsCheckboxClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Events.CheckboxClick = defaultValue;

            Assert.DoesNotContain($"checkboxClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsClickRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "events" };

            chart.PlotOptions.Sankey.Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsclickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsHideRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "events" };

            chart.PlotOptions.Sankey.Events.Hide = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("hide", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsHideDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Events.Hide = defaultValue;

            Assert.DoesNotContain($"hide", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsLegendItemClickRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "events" };

            chart.PlotOptions.Sankey.Events.LegendItemClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("legendItemClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsLegendItemClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Events.LegendItemClick = defaultValue;

            Assert.DoesNotContain($"legendItemClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "events" };

            chart.PlotOptions.Sankey.Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "events" };

            chart.PlotOptions.Sankey.Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsShowRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "events" };

            chart.PlotOptions.Sankey.Events.Show = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("show", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsShowDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Events.Show = defaultValue;

            Assert.DoesNotContain($"show", renderer.RenderHtml());
        }

        #endregion


        [Fact]
        public void Test_IfGetExtremesFromAllRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Sankey.GetExtremesFromAll = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"getExtremesFromAll\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfGetExtremesFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Sankey.GetExtremesFromAll = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"getExtremesFromAll\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfIncludeInDataExportFromAllRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.IncludeInDataExport = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"includeInDataExport\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfIncludeInDataExportFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? value = null;

            chart.PlotOptions.Sankey.IncludeInDataExport = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"includeInDataExport\":{value}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("name", "y", "dataLabels.style.visibility", "true")]
        public void Test_IfKeysRenders_Correct(string arg1, string arg2, string arg3, string arg4)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = new List<string> { arg1, arg2, arg3, arg4 };

            chart.PlotOptions.Sankey.Keys = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"keys\":[\"{arg1}\",\"{arg2}\",\"{arg3}\",\"{arg4}\"]}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfKeysDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = new List<string>();

            chart.PlotOptions.Sankey.Keys = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"keys\":}}}}", renderer.RenderHtml());
        }

        #region label

        //missing boxesToAvoid

        [Fact]
        public void Test_IfLabelConnectorAllowedRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "label" };
            var value = true;

            chart.PlotOptions.Sankey.Label.ConnectorAllowed = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorAllowed", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorAllowedDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Sankey.Label.ConnectorAllowed = defaultValue;

            Assert.DoesNotContain($"connectorAllowed", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(30)]
        public void Test_IfLabelConnectorNeighbourDistanceRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "label" };

            chart.PlotOptions.Sankey.Label.ConnectorNeighbourDistance = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorNeighbourDistance", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorNeighbourDistanceDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 24;

            chart.PlotOptions.Sankey.Label.ConnectorNeighbourDistance = defaultValue;

            Assert.DoesNotContain($"connectorNeighbourDistance", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "label" };
            var value = false;

            chart.PlotOptions.Sankey.Label.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Sankey.Label.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFormat")]
        public void Test_IfLabelFormatRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "label" };

            chart.PlotOptions.Sankey.Label.Format = value;

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

        //    chart.PlotOptions.Sankey.Label.Format = defaultValue;

        //    Assert.DoesNotContain($"format", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("SomeFormatterFunction")]
        public void Test_IfLabelFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "label" };

            chart.PlotOptions.Sankey.Label.Formatter = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("formatter", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Label.Formatter = defaultValue;

            Assert.DoesNotContain($"formatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMaxFontSizeRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "label" };

            chart.PlotOptions.Sankey.Label.MaxFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("maxFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMaxFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Sankey.Label.MaxFontSize = defaultValue;

            Assert.DoesNotContain($"maxFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMinFontSizeRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "label" };

            chart.PlotOptions.Sankey.Label.MinFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("minFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMinFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Sankey.Label.MinFontSize = defaultValue;

            Assert.DoesNotContain($"minFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfLabelOnAreaRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "label" };

            chart.PlotOptions.Sankey.Label.OnArea = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("onArea", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelOnAreaDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Sankey.Label.OnArea = defaultValue;

            Assert.DoesNotContain($"onArea", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("fontWeight", "bold")]
        public void Test_IfLabelStyleRenders_Correct(string paramName, string paramValue)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "label" };
            var value = new Hashtable();
            value.Add(paramName, paramValue);


            chart.PlotOptions.Sankey.Label.Style = value;

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

        //    chart.PlotOptions.Sankey.Label.Style = defaultValue;

        //    Assert.DoesNotContain($"style", renderer.RenderHtml());
        //}



        #endregion


        //fix required - Linecap should be enum (not string)
        //[Theory]
        //[InlineData(PlotOptionsSankeyLinecap.Square)]
        ////missing PlotOptionsSankeyLinecap.Butt ?
        //public void Test_IfLinecapRenders_Correct(PlotOptionsSankeyLinecap value)
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);

        //    chart.PlotOptions.Sankey.Linecap = value;

        //    Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linecap\":\"{chart.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfLinecapDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = PlotOptionsSankeyLinecap.Round;

        //    chart.PlotOptions.Sankey.Linecap = defaultValue;

        //    Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linecap\":{defaultValue.ToString().ToLower()}}}}}", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(":previous")]
        [InlineData("IdAnotherSeries")]
        public void Test_IfLinkedToRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.LinkedTo = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linkedTo\":\"{value}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLinkedToDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            string defaultValue = String.Empty;

            chart.PlotOptions.Sankey.LinkedTo = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linkedTo\":{defaultValue}}}}}", renderer.RenderHtml());
        }

        #region onPoint

        //fix dashStyle - should be string instead of hashtable
        //[Theory]
        //[InlineData("dot")]
        //public void Test_IfOnPointConnectorOptionsDashStyleRenders_Correct(string value)
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "sankey", "onPoint", "connectorOptions" };

        //    chart.PlotOptions.Sankey.OnPoint.ConnectorOptions.Dashstyle = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dashstyle", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfOnPointConnectorOptionsDashStyleDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Sankey.DataLabels.Color = defaultValue;

        //    Assert.DoesNotContain($"color", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("red")]
        public void Test_IfOnPointConnectorOptionsStrokeRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "onPoint", "connectorOptions" };

            chart.PlotOptions.Sankey.OnPoint.ConnectorOptions.Stroke = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("stroke", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsStrokeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.OnPoint.ConnectorOptions.Stroke = defaultValue;

            Assert.DoesNotContain($"stroke", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointConnectorOptionsWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "onPoint", "connectorOptions" };

            chart.PlotOptions.Sankey.OnPoint.ConnectorOptions.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Sankey.OnPoint.ConnectorOptions.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("pointId")]
        public void Test_IfOnPointIdRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "onPoint" };

            chart.PlotOptions.Sankey.OnPoint.Id = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("id", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointIdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.OnPoint.Id = defaultValue;

            Assert.DoesNotContain($"\"id\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetXRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "onPoint", "position" };

            chart.PlotOptions.Sankey.OnPoint.Position.OffsetX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Sankey.OnPoint.Position.OffsetX = defaultValue;

            Assert.DoesNotContain($"offsetX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetYRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "onPoint", "position" };

            chart.PlotOptions.Sankey.OnPoint.Position.OffsetY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Sankey.OnPoint.Position.OffsetY = defaultValue;

            Assert.DoesNotContain($"offsetY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionXRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "onPoint", "position" };

            chart.PlotOptions.Sankey.OnPoint.Position.X = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("x", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Sankey.OnPoint.Position.X = defaultValue;

            Assert.DoesNotContain($"\"x\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionYRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "onPoint", "position" };

            chart.PlotOptions.Sankey.OnPoint.Position.Y = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("y", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Sankey.OnPoint.Position.Y = defaultValue;

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

            chart.PlotOptions.Sankey.Opacity = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOpacityDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Sankey.Opacity = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", defaultValue)}}}}}", renderer.RenderHtml());
        }

        #region point

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsClickRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "point", "events" };

            chart.PlotOptions.Sankey.Point.Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Point.Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "point", "events" };

            chart.PlotOptions.Sankey.Point.Events.Drag = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drag", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Point.Events.Drag = defaultValue;

            Assert.DoesNotContain($"drag", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragStartRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "point", "events" };

            chart.PlotOptions.Sankey.Point.Events.DragStart = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("dragStart", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragStartDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Point.Events.DragStart = defaultValue;

            Assert.DoesNotContain($"dragStart", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDropRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "point", "events" };

            chart.PlotOptions.Sankey.Point.Events.Drop = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drop", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDropDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Point.Events.Drop = defaultValue;

            Assert.DoesNotContain($"drop", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "point", "events" };

            chart.PlotOptions.Sankey.Point.Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Point.Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "point", "events" };

            chart.PlotOptions.Sankey.Point.Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Point.Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsRemoveRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "point", "events" };

            chart.PlotOptions.Sankey.Point.Events.Remove = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("remove", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsRemoveDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Point.Events.Remove = defaultValue;

            Assert.DoesNotContain($"remove", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsSelectRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "point", "events" };

            chart.PlotOptions.Sankey.Point.Events.Select = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("select", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Point.Events.Select = defaultValue;

            Assert.DoesNotContain($"select", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUnselectRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "point", "events" };

            chart.PlotOptions.Sankey.Point.Events.Unselect = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("unselect", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUnselectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Point.Events.Unselect = defaultValue;

            Assert.DoesNotContain($"unselect", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUpdateRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "point", "events" };

            chart.PlotOptions.Sankey.Point.Events.Update = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("update", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUpdateDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.Point.Events.Update = defaultValue;

            Assert.DoesNotContain($"update", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointDescriptionFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.PointDescriptionFormatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"pointDescriptionFormatter\":{value}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointDescriptionFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Sankey.PointDescriptionFormatter = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"pointDescriptionFormatter\":{defaultValue}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Sankey.RelativeXValue = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"relativeXValue\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Sankey.RelativeXValue = defaultValue;

            Assert.DoesNotContain($"relativeXValue", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Sankey.Selected = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"selected\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Sankey.Selected = defaultValue;

            Assert.DoesNotContain($"selected", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowCheckboxRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Sankey.ShowCheckbox = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"showCheckbox\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowCheckboxDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Sankey.ShowCheckbox = defaultValue;

            Assert.DoesNotContain($"showCheckbox", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowInLegendRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Sankey.ShowInLegend = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"showInLegend\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowInLegendDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Sankey.ShowInLegend = defaultValue;

            Assert.DoesNotContain($"showInLegend", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfSkipKeyboardNavigationRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.SkipKeyboardNavigation = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"skipKeyboardNavigation\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSkipKeyboardNavigationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.SkipKeyboardNavigation = null;

            Assert.DoesNotContain($"skipKeyboardNavigation", renderer.RenderHtml());
        }

        #region states

        #region hover


        #endregion

        #region inactive

        [Theory]
        [InlineData(0.5)]
        public void Test_IfStatesInactiveOpacityRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "states", "inactive" };

            chart.PlotOptions.Sankey.States.Inactive.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default value should be 0.2 (not null)
        //[Fact]
        //public void Test_IfStatesInactiveOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.2;

        //    chart.PlotOptions.Sankey.States.Inactive.Opacity = defaultValue;

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
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "states", "normal", "animation" };

            chart.PlotOptions.Sankey.States.Normal.Animation.Duration = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesNormalAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Sankey.States.Normal.Animation.Duration = defaultValue;

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
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "states", "select", "animation" };

            chart.PlotOptions.Sankey.States.Select.Animation.Duration = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Sankey.States.Select.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesSelectEnabledRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "states", "select" };
            var value = false;

            chart.PlotOptions.Sankey.States.Select.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesSelectEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Sankey.States.Select.Enabled = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "sankey", "states", "select", "halo" };

        //    chart.PlotOptions.Sankey.States.Select.Halo.Attributes = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("attributes", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfStatesSelectHaloAttributesDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Sankey.States.Select.Animation.Duration = defaultValue;

        //    Assert.DoesNotContain($"duration", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(2)]
        [InlineData(0.5)]
        public void Test_IfStatesSelectHaloOpacityRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "states", "select", "halo" };

            chart.PlotOptions.Sankey.States.Select.Halo.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default value for opacity = 0.25 (not null)
        //[Fact]
        //public void Test_IfStatesSelectHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Sankey.States.Select.Halo.Opacity = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "sankey", "states", "select", "halo" };

        //    chart.PlotOptions.Sankey.States.Select.Halo.Size = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("size", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Fact]
        //public void Test_IfStatesSelectHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Sankey.States.Select.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesSelectLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "states", "select" };

            chart.PlotOptions.Sankey.States.Select.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Sankey.States.Select.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesSelectLineWidthPlusRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "states", "select" };

            chart.PlotOptions.Sankey.States.Select.LineWidthPlus = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidthPlus", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default should be 1 (not null)
        //[Fact]
        //public void Test_IfStatesSelectLineWidthPlusDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    double? defaultValue = 1;

        //    chart.PlotOptions.Sankey.States.Select.LineWidthPlus = defaultValue;

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
            var pathToProperty = new List<string> { "plotOptions", "sankey", "states", "select", "marker" };

            chart.PlotOptions.Sankey.States.Select.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Sankey.States.Select.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesSelectMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "states", "select", "marker" };

            chart.PlotOptions.Sankey.States.Select.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double defaultValue = 2;

            chart.PlotOptions.Sankey.States.Select.Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfStatesSelectMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "states", "select", "marker" };

            chart.PlotOptions.Sankey.States.Select.Marker.FillColor = value;

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

        //    chart.PlotOptions.Sankey.States.Select.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesSelectMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "states", "select", "marker" };

            chart.PlotOptions.Sankey.States.Select.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Sankey.States.Select.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfStatesSelectMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "states", "select", "marker" };

            chart.PlotOptions.Sankey.States.Select.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "#ffffff";

            chart.PlotOptions.Sankey.States.Select.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesSelectMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "states", "select", "marker" };

            chart.PlotOptions.Sankey.States.Select.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Sankey.States.Select.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesSelectMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "sankey", "states", "select", "marker" };

            chart.PlotOptions.Sankey.States.Select.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 4;

            chart.PlotOptions.Sankey.States.Select.Marker.Radius = defaultValue;

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
            var pathToProperty = new List<string> { "plotOptions", "sankey", "states", "select", "marker" };

            chart.PlotOptions.Sankey.States.Select.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Sankey.States.Select.Marker.Width = defaultValue;

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
            bool value = false;

            chart.PlotOptions.Sankey.StickyTracking = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"stickyTracking\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Sankey.StickyTracking = defaultValue;

            Assert.DoesNotContain($"stickyTracking", renderer.RenderHtml());
        }

        #region tooltip

        //fix required - different default value
        //[Fact]
        //public void Test_IfTooltipFollowPointerRenders_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "sankey", "tooltip" };
        //    var value = true;

        //    chart.PlotOptions.Sankey.Tooltip.FollowPointer = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("followPointer", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //fix required - default should be false (not null)
        //[Fact]
        //public void Test_IfTooltipFollowPointerDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = false;

        //    chart.PlotOptions.Sankey.Tooltip.FollowPointer = defaultValue;

        //    Assert.DoesNotContain($"followPointer", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("<table><tr><th colspan='2'>{point.key}</th></tr>")]
        public void Test_IfTooltipHeaderFormatRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "tooltip" };

            chart.PlotOptions.Sankey.Tooltip.HeaderFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("headerFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipHeaderFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "<span style='font-size: 0.8em'>{series.name}</span><br/>";

            chart.PlotOptions.Sankey.Tooltip.HeaderFormat = defaultValue;

            Assert.DoesNotContain($"headerFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{series.name}: <b>{point.y}</b><br/>")]
        public void Test_IfTooltipPointFormatRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "sankey", "tooltip" };

            chart.PlotOptions.Sankey.Tooltip.PointFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("pointFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipPointFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "{point.fromNode.name} → {point.toNode.name}: <b>{point.weight}</b><br/>";

            chart.PlotOptions.Sankey.Tooltip.PointFormat = defaultValue;

            Assert.DoesNotContain($"pointFormat", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfTurboThresholdTrackingRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Sankey.TurboThreshold = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"turboThreshold\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTurboThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1000;

            chart.PlotOptions.Sankey.TurboThreshold = defaultValue;

            Assert.DoesNotContain($"turboThreshold", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = false;

            chart.PlotOptions.Sankey.Visible = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"visible\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Sankey.Visible = defaultValue;

            Assert.DoesNotContain($"visible", renderer.RenderHtml());
        }
    }
}

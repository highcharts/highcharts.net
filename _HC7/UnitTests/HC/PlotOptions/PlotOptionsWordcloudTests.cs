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
    public class PlotOptionsWordcloudTests : IClassFixture<HcFixture>
    {
        protected HcFixture _fixture;

        public PlotOptionsWordcloudTests(HcFixture fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Wordcloud;
        }

        #region Acessibility

        [Theory]
        [InlineData("Description")]
        public void Test_IfAccessibilityDescriptionRenders_Correct(string description)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.Accessibility.Description = description;

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

            chart.PlotOptions.Wordcloud.Accessibility.Enabled = enabled;

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

            chart.PlotOptions.Wordcloud.Accessibility.ExposeAsGroupOnly = exposeAsGroupOnly;

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

            chart.PlotOptions.Wordcloud.Accessibility.KeyboardNavigation.Enabled = enabled;

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

            chart.PlotOptions.Wordcloud.Accessibility.Point.DateFormat = format;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"dateFormat\":\"{format}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("DateFormatterFunction")]
        public void Test_IfAccessibilityPointDateFormatterRenders_Correct(string function)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.Accessibility.Point.DateFormatter = function;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"dateFormatter\":{function}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(false)]
        public void Test_IfAccessibilityPointDescribeNullSetOnFalseRenders_Correct(bool describeNull)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);



            chart.PlotOptions.Wordcloud.Accessibility.Point.DescribeNull = describeNull;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"describeNull\":{describeNull.ToString().ToLower()}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        public void Test_IfAccessibilityPointDescribeNullSetOnTrueRenders_Correct(bool describeNull)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.Accessibility.Point.DescribeNull = describeNull;

            Assert.DoesNotContain($"describeNull", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("FormatterFunction")]
        public void Test_IfAccessibilityPointDescriptionFormatterRenders_Correct(string function)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.Accessibility.Point.DescriptionFormatter = function;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"descriptionFormatter\":{function}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(3)]
        public void Test_IfAccessibilityPointValueDecimalsRenders_Correct(int decimals)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.Accessibility.Point.ValueDecimals = decimals;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valueDecimals\":{decimals}.0}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{Description}{separator}{value}")]
        public void Test_IfAccessibilityPointValueDescriptionFormatRenders_Correct(string format)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.Accessibility.Point.ValueDescriptionFormat = format;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valueDescriptionFormat\":\"{format}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomePrefix")]
        public void Test_IfAccessibilityPointValuePrefixRenders_Correct(string prefix)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.Accessibility.Point.ValuePrefix = prefix;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valuePrefix\":\"{prefix}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeSuffix")]
        public void Test_IfAccessibilityPointValueSufixRenders_Correct(string suffix)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.Accessibility.Point.ValueSuffix = suffix;

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

            chart.PlotOptions.Wordcloud.AllowPointSelect = enabled;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"allowPointSelect\":{enabled.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAllowPointSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.AllowPointSelect = false;

            Assert.DoesNotContain("allowPointSelect", renderer.RenderHtml());
        }

        #region Animation

        [Theory]
        [InlineData(1000)]
        public void Test_IfAnimationDurationRenders_Correct(int duration)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.Animation.Duration = duration;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{{\"duration\":{duration}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1000)]
        public void Test_IfAnimationDeferRenders_Correct(int defer)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.Animation.Defer = defer;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{{\"defer\":{defer}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("easingFunctionName")]
        public void Test_IfAnimationEasingRenders_Correct(string easing)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.Animation.Easing = easing;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{{\"easing\":\"{easing}\"}}}}}}", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData(250)]
        public void Test_IfAnimationLimitRenders_Correct(int limit)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.AnimationLimit = limit;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animationLimit\":{limit}.0}}}}", renderer.RenderHtml());
        }

        //missing borderColor
        //missing borderWidth

        [Theory]
        [InlineData("ClassName")]
        public void Test_IfClassNameRenders_Correct(string className)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.ClassName = className;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"className\":\"{className}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipRenders_Correct()
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Wordcloud.Clip = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"clip\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Wordcloud.Clip = value;

            Assert.DoesNotContain("clip", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#ffffff")]
        public void Test_IfColorRenders_Correct(string color)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.Color = color;

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

            chart.PlotOptions.Wordcloud.ColorIndex = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"colorIndex\":{value}.0}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("colorValue")]
        public void Test_IfColorKeyRenders_Correct(string value)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.ColorKey = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"colorKey\":\"{value}\"}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsWordcloudCursor.Default)]
        [InlineData(PlotOptionsWordcloudCursor.Help)]
        [InlineData(PlotOptionsWordcloudCursor.Pointer)]
        [InlineData(PlotOptionsWordcloudCursor.None)]
        public void Test_IfCursorRenders_Correct(PlotOptionsWordcloudCursor cursor)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.Cursor = cursor;

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

            chart.PlotOptions.Wordcloud.Custom = extraData;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"custom\":{{\"{key1}\":\"{value1}\"}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsWordcloudDashStyle.Dash)]
        [InlineData(PlotOptionsWordcloudDashStyle.DashDot)]
        [InlineData(PlotOptionsWordcloudDashStyle.Dot)]
        [InlineData(PlotOptionsWordcloudDashStyle.LongDash)]
        [InlineData(PlotOptionsWordcloudDashStyle.LongDashDot)]
        [InlineData(PlotOptionsWordcloudDashStyle.LongDashDotDot)]
        [InlineData(PlotOptionsWordcloudDashStyle.ShortDash)]
        [InlineData(PlotOptionsWordcloudDashStyle.ShortDashDot)]
        [InlineData(PlotOptionsWordcloudDashStyle.ShortDashDotDot)]
        [InlineData(PlotOptionsWordcloudDashStyle.ShortDot)]
        public void Test_IfDashStyleRenders_Correct(PlotOptionsWordcloudDashStyle style)
        {
            var chart = new Highcharts();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var result = style.ToString();
            var replacement = result[0].ToString().ToLower();
            result = result.Remove(0, 1);
            result = replacement + result;

            chart.PlotOptions.Wordcloud.DashStyle = style;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dashStyle\":\"{result}\"}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomePlotOptionsDescription")]
        public void Test_IfDescriptionRenders_Correct(string description)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.Description = description;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"description\":\"{description}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Wordcloud.EnableMouseTracking = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"enableMouseTracking\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Wordcloud.EnableMouseTracking = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"enableMouseTracking\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        #region events

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsAfterAnimateRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "events" };

            chart.PlotOptions.Wordcloud.Events.AfterAnimate = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("afterAnimate", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsAfterAnimateDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Events.AfterAnimate = defaultValue;

            Assert.DoesNotContain($"afterAnimate", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsCheckboxClickRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "events" };

            chart.PlotOptions.Wordcloud.Events.CheckboxClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("checkboxClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsCheckboxClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Events.CheckboxClick = defaultValue;

            Assert.DoesNotContain($"checkboxClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsClickRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "events" };

            chart.PlotOptions.Wordcloud.Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsclickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsHideRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "events" };

            chart.PlotOptions.Wordcloud.Events.Hide = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("hide", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsHideDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Events.Hide = defaultValue;

            Assert.DoesNotContain($"hide", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsLegendItemClickRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "events" };

            chart.PlotOptions.Wordcloud.Events.LegendItemClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("legendItemClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsLegendItemClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Events.LegendItemClick = defaultValue;

            Assert.DoesNotContain($"legendItemClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "events" };

            chart.PlotOptions.Wordcloud.Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "events" };

            chart.PlotOptions.Wordcloud.Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsShowRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "events" };

            chart.PlotOptions.Wordcloud.Events.Show = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("show", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsShowDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Events.Show = defaultValue;

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

            chart.PlotOptions.Wordcloud.IncludeInDataExport = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"includeInDataExport\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfIncludeInDataExportFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? value = null;

            chart.PlotOptions.Wordcloud.IncludeInDataExport = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"includeInDataExport\":{value}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("name", "y", "dataLabels.style.visibility", "true")]
        public void Test_IfKeysRenders_Correct(string arg1, string arg2, string arg3, string arg4)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = new List<string> { arg1, arg2, arg3, arg4 };

            chart.PlotOptions.Wordcloud.Keys = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"keys\":[\"{arg1}\",\"{arg2}\",\"{arg3}\",\"{arg4}\"]}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfKeysDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = new List<string>();

            chart.PlotOptions.Wordcloud.Keys = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"keys\":}}}}", renderer.RenderHtml());
        }

        #region label

        //missing boxesToAvoid

        [Fact]
        public void Test_IfLabelConnectorAllowedRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "label" };
            var value = true;

            chart.PlotOptions.Wordcloud.Label.ConnectorAllowed = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorAllowed", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorAllowedDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Wordcloud.Label.ConnectorAllowed = defaultValue;

            Assert.DoesNotContain($"connectorAllowed", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(30)]
        public void Test_IfLabelConnectorNeighbourDistanceRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "label" };

            chart.PlotOptions.Wordcloud.Label.ConnectorNeighbourDistance = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorNeighbourDistance", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorNeighbourDistanceDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 24;

            chart.PlotOptions.Wordcloud.Label.ConnectorNeighbourDistance = defaultValue;

            Assert.DoesNotContain($"connectorNeighbourDistance", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "label" };
            var value = false;

            chart.PlotOptions.Wordcloud.Label.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Wordcloud.Label.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFormat")]
        public void Test_IfLabelFormatRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "label" };

            chart.PlotOptions.Wordcloud.Label.Format = value;

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

        //    chart.PlotOptions.Wordcloud.Label.Format = defaultValue;

        //    Assert.DoesNotContain($"format", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("SomeFormatterFunction")]
        public void Test_IfLabelFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "label" };

            chart.PlotOptions.Wordcloud.Label.Formatter = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("formatter", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Label.Formatter = defaultValue;

            Assert.DoesNotContain($"formatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMaxFontSizeRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "label" };

            chart.PlotOptions.Wordcloud.Label.MaxFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("maxFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMaxFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Wordcloud.Label.MaxFontSize = defaultValue;

            Assert.DoesNotContain($"maxFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMinFontSizeRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "label" };

            chart.PlotOptions.Wordcloud.Label.MinFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("minFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMinFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Wordcloud.Label.MinFontSize = defaultValue;

            Assert.DoesNotContain($"minFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfLabelOnAreaRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "label" };

            chart.PlotOptions.Wordcloud.Label.OnArea = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("onArea", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelOnAreaDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Wordcloud.Label.OnArea = defaultValue;

            Assert.DoesNotContain($"onArea", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("fontWeight", "bold")]
        public void Test_IfLabelStyleRenders_Correct(string paramName, string paramValue)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "label" };
            var value = new Hashtable();
            value.Add(paramName, paramValue);


            chart.PlotOptions.Wordcloud.Label.Style = value;

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

        //    chart.PlotOptions.Wordcloud.Label.Style = defaultValue;

        //    Assert.DoesNotContain($"style", renderer.RenderHtml());
        //}



        #endregion


        //fix required - Linecap should be enum (not string)
        //[Theory]
        //[InlineData(PlotOptionsWordcloudLinecap.Square)]
        ////missing PlotOptionsWordcloudLinecap.Butt ?
        //public void Test_IfLinecapRenders_Correct(PlotOptionsWordcloudLinecap value)
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);

        //    chart.PlotOptions.Wordcloud.Linecap = value;

        //    Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linecap\":\"{chart.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfLinecapDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = PlotOptionsWordcloudLinecap.Round;

        //    chart.PlotOptions.Wordcloud.Linecap = defaultValue;

        //    Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linecap\":{defaultValue.ToString().ToLower()}}}}}", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(":previous")]
        [InlineData("IdAnotherSeries")]
        public void Test_IfLinkedToRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.LinkedTo = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linkedTo\":\"{value}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLinkedToDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            string defaultValue = String.Empty;

            chart.PlotOptions.Wordcloud.LinkedTo = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "onPoint", "connectorOptions" };

        //    chart.PlotOptions.Wordcloud.OnPoint.ConnectorOptions.Dashstyle = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dashstyle", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfOnPointConnectorOptionsDashStyleDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Wordcloud.DataLabels.Color = defaultValue;

        //    Assert.DoesNotContain($"color", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("red")]
        public void Test_IfOnPointConnectorOptionsStrokeRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "onPoint", "connectorOptions" };

            chart.PlotOptions.Wordcloud.OnPoint.ConnectorOptions.Stroke = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("stroke", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsStrokeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.OnPoint.ConnectorOptions.Stroke = defaultValue;

            Assert.DoesNotContain($"stroke", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointConnectorOptionsWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "onPoint", "connectorOptions" };

            chart.PlotOptions.Wordcloud.OnPoint.ConnectorOptions.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Wordcloud.OnPoint.ConnectorOptions.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("pointId")]
        public void Test_IfOnPointIdRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "onPoint" };

            chart.PlotOptions.Wordcloud.OnPoint.Id = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("id", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointIdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.OnPoint.Id = defaultValue;

            Assert.DoesNotContain($"\"id\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetXRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "onPoint", "position" };

            chart.PlotOptions.Wordcloud.OnPoint.Position.OffsetX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Wordcloud.OnPoint.Position.OffsetX = defaultValue;

            Assert.DoesNotContain($"offsetX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetYRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "onPoint", "position" };

            chart.PlotOptions.Wordcloud.OnPoint.Position.OffsetY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Wordcloud.OnPoint.Position.OffsetY = defaultValue;

            Assert.DoesNotContain($"offsetY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionXRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "onPoint", "position" };

            chart.PlotOptions.Wordcloud.OnPoint.Position.X = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("x", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Wordcloud.OnPoint.Position.X = defaultValue;

            Assert.DoesNotContain($"\"x\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionYRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "onPoint", "position" };

            chart.PlotOptions.Wordcloud.OnPoint.Position.Y = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("y", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Wordcloud.OnPoint.Position.Y = defaultValue;

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

            chart.PlotOptions.Wordcloud.Opacity = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOpacityDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Wordcloud.Opacity = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", defaultValue)}}}}}", renderer.RenderHtml());
        }

        #region point

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsClickRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "point", "events" };

            chart.PlotOptions.Wordcloud.Point.Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Point.Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "point", "events" };

            chart.PlotOptions.Wordcloud.Point.Events.Drag = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drag", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Point.Events.Drag = defaultValue;

            Assert.DoesNotContain($"drag", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragStartRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "point", "events" };

            chart.PlotOptions.Wordcloud.Point.Events.DragStart = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("dragStart", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragStartDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Point.Events.DragStart = defaultValue;

            Assert.DoesNotContain($"dragStart", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDropRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "point", "events" };

            chart.PlotOptions.Wordcloud.Point.Events.Drop = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drop", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDropDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Point.Events.Drop = defaultValue;

            Assert.DoesNotContain($"drop", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "point", "events" };

            chart.PlotOptions.Wordcloud.Point.Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Point.Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "point", "events" };

            chart.PlotOptions.Wordcloud.Point.Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Point.Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsRemoveRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "point", "events" };

            chart.PlotOptions.Wordcloud.Point.Events.Remove = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("remove", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsRemoveDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Point.Events.Remove = defaultValue;

            Assert.DoesNotContain($"remove", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsSelectRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "point", "events" };

            chart.PlotOptions.Wordcloud.Point.Events.Select = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("select", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Point.Events.Select = defaultValue;

            Assert.DoesNotContain($"select", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUnselectRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "point", "events" };

            chart.PlotOptions.Wordcloud.Point.Events.Unselect = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("unselect", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUnselectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Point.Events.Unselect = defaultValue;

            Assert.DoesNotContain($"unselect", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUpdateRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "point", "events" };

            chart.PlotOptions.Wordcloud.Point.Events.Update = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("update", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUpdateDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.Point.Events.Update = defaultValue;

            Assert.DoesNotContain($"update", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointDescriptionFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.PointDescriptionFormatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"pointDescriptionFormatter\":{value}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointDescriptionFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Wordcloud.PointDescriptionFormatter = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"pointDescriptionFormatter\":{defaultValue}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Wordcloud.RelativeXValue = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"relativeXValue\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Wordcloud.RelativeXValue = defaultValue;

            Assert.DoesNotContain($"relativeXValue", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Wordcloud.Selected = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"selected\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Wordcloud.Selected = defaultValue;

            Assert.DoesNotContain($"selected", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowInLegendRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Wordcloud.ShowInLegend = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"showInLegend\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowInLegendDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Wordcloud.ShowInLegend = defaultValue;

            Assert.DoesNotContain($"showInLegend", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfSkipKeyboardNavigationRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.SkipKeyboardNavigation = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"skipKeyboardNavigation\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSkipKeyboardNavigationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Wordcloud.SkipKeyboardNavigation = null;

            Assert.DoesNotContain($"skipKeyboardNavigation", renderer.RenderHtml());
        }

        #region states

        #region hover

        #region animation
        [Theory]
        [InlineData(5)]
        public void Test_IfStatesHoverAnimationDurationRenders_Correct(int value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "hover", "animation" };

            chart.PlotOptions.Wordcloud.States.Hover.Animation.Duration = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Wordcloud.States.Hover.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesHoverEnabledRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "hover" };
            var value = false;

            chart.PlotOptions.Wordcloud.States.Hover.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesHoverEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Wordcloud.States.Hover.Enabled = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "hover", "halo" };

        //    chart.PlotOptions.Wordcloud.States.Hover.Halo.Attributes = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("attributes", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfStatesHoverHaloAttributesDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Wordcloud.States.Hover.Animation.Duration = defaultValue;

        //    Assert.DoesNotContain($"duration", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(2)]
        [InlineData(0.5)]
        public void Test_IfStatesHoverHaloOpacityRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "hover", "halo" };

            chart.PlotOptions.Wordcloud.States.Hover.Halo.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default value for opacity = 0.25 (not null)
        //[Fact]
        //public void Test_IfStatesHoverHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Wordcloud.States.Hover.Halo.Opacity = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "hover", "halo" };

        //    chart.PlotOptions.Wordcloud.States.Hover.Halo.Size = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("size", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Fact]
        //public void Test_IfStatesHoverHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Wordcloud.States.Hover.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesHoverLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "hover" };

            chart.PlotOptions.Wordcloud.States.Hover.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Wordcloud.States.Hover.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesHoverLineWidthPlusRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "hover" };

            chart.PlotOptions.Wordcloud.States.Hover.LineWidthPlus = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidthPlus", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default should be 1 (not null)
        //[Fact]
        //public void Test_IfStatesHoverLineWidthPlusDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    double? defaultValue = 1;

        //    chart.PlotOptions.Wordcloud.States.Hover.LineWidthPlus = defaultValue;

        //    Assert.DoesNotContain($"lineWidthPlus", renderer.RenderHtml());
        //}

        #region marker

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfStatesHoverMarkerEnabledRenders_Correct(bool value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "hover", "marker" };

            chart.PlotOptions.Wordcloud.States.Hover.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Wordcloud.States.Hover.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesHoverMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "hover", "marker" };

            chart.PlotOptions.Wordcloud.States.Hover.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double defaultValue = 2;

            chart.PlotOptions.Wordcloud.States.Hover.Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfStatesHoverMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "hover", "marker" };

            chart.PlotOptions.Wordcloud.States.Hover.Marker.FillColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("fillColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

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

        //    chart.PlotOptions.Wordcloud.States.Hover.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesHoverMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "hover", "marker" };

            chart.PlotOptions.Wordcloud.States.Hover.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Wordcloud.States.Hover.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfStatesHoverMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "hover", "marker" };

            chart.PlotOptions.Wordcloud.States.Hover.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesHoverMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "#ffffff";

            chart.PlotOptions.Wordcloud.States.Hover.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesHoverMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "hover", "marker" };

            chart.PlotOptions.Wordcloud.States.Hover.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesHoverMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Wordcloud.States.Hover.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesHoverMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "hover", "marker" };

            chart.PlotOptions.Wordcloud.States.Hover.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesHoverMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 4;

            chart.PlotOptions.Wordcloud.States.Hover.Marker.Radius = defaultValue;

            Assert.DoesNotContain($"radius", renderer.RenderHtml());
        }

        //missing States

        [Theory]
        [InlineData(5)]
        [InlineData(1000)]
        public void Test_IfStatesHoverMarkerWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "hover", "marker" };

            chart.PlotOptions.Wordcloud.States.Hover.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Wordcloud.States.Hover.Marker.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

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
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "inactive", "animation" };

            chart.PlotOptions.Wordcloud.States.Inactive.Animation.Duration = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesInactiveAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Wordcloud.States.Inactive.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesInactiveEnabledRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "inactive" };
            var value = false;

            chart.PlotOptions.Wordcloud.States.Inactive.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesInactiveEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Wordcloud.States.Inactive.Enabled = defaultValue;

        //    Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(0.5)]
        public void Test_IfStatesInactiveOpacityRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "inactive" };

            chart.PlotOptions.Wordcloud.States.Inactive.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default value should be 0.2 (not null)
        //[Fact]
        //public void Test_IfStatesInactiveOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.2;

        //    chart.PlotOptions.Wordcloud.States.Inactive.Opacity = defaultValue;

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
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "normal", "animation" };

            chart.PlotOptions.Wordcloud.States.Normal.Animation.Duration = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesNormalAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Wordcloud.States.Normal.Animation.Duration = defaultValue;

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
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "select", "animation" };

            chart.PlotOptions.Wordcloud.States.Select.Animation.Duration = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Wordcloud.States.Select.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesSelectEnabledRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "select" };
            var value = false;

            chart.PlotOptions.Wordcloud.States.Select.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesSelectEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Wordcloud.States.Select.Enabled = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "select", "halo" };

        //    chart.PlotOptions.Wordcloud.States.Select.Halo.Attributes = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("attributes", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfStatesSelectHaloAttributesDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Wordcloud.States.Select.Animation.Duration = defaultValue;

        //    Assert.DoesNotContain($"duration", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(2)]
        [InlineData(0.5)]
        public void Test_IfStatesSelectHaloOpacityRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "select", "halo" };

            chart.PlotOptions.Wordcloud.States.Select.Halo.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default value for opacity = 0.25 (not null)
        //[Fact]
        //public void Test_IfStatesSelectHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Wordcloud.States.Select.Halo.Opacity = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "select", "halo" };

        //    chart.PlotOptions.Wordcloud.States.Select.Halo.Size = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("size", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Fact]
        //public void Test_IfStatesSelectHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Wordcloud.States.Select.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesSelectLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "select" };

            chart.PlotOptions.Wordcloud.States.Select.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Wordcloud.States.Select.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesSelectLineWidthPlusRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "states", "select" };

            chart.PlotOptions.Wordcloud.States.Select.LineWidthPlus = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidthPlus", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default should be 1 (not null)
        //[Fact]
        //public void Test_IfStatesSelectLineWidthPlusDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    double? defaultValue = 1;

        //    chart.PlotOptions.Wordcloud.States.Select.LineWidthPlus = defaultValue;

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
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "select", "marker" };

            chart.PlotOptions.Wordcloud.States.Select.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Wordcloud.States.Select.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesSelectMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "select", "marker" };

            chart.PlotOptions.Wordcloud.States.Select.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double defaultValue = 2;

            chart.PlotOptions.Wordcloud.States.Select.Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfStatesSelectMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "select", "marker" };

            chart.PlotOptions.Wordcloud.States.Select.Marker.FillColor = value;

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

        //    chart.PlotOptions.Wordcloud.States.Select.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesSelectMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "select", "marker" };

            chart.PlotOptions.Wordcloud.States.Select.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Wordcloud.States.Select.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfStatesSelectMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "select", "marker" };

            chart.PlotOptions.Wordcloud.States.Select.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "#ffffff";

            chart.PlotOptions.Wordcloud.States.Select.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesSelectMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "select", "marker" };

            chart.PlotOptions.Wordcloud.States.Select.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Wordcloud.States.Select.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesSelectMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "select", "marker" };

            chart.PlotOptions.Wordcloud.States.Select.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 4;

            chart.PlotOptions.Wordcloud.States.Select.Marker.Radius = defaultValue;

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
            var pathToProperty = new List<string> { "plotOptions", "wordcloud", "states", "select", "marker" };

            chart.PlotOptions.Wordcloud.States.Select.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Wordcloud.States.Select.Marker.Width = defaultValue;

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

            chart.PlotOptions.Wordcloud.StickyTracking = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"stickyTracking\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Wordcloud.StickyTracking = defaultValue;

            Assert.DoesNotContain($"stickyTracking", renderer.RenderHtml());
        }

        #region tooltip

        [Fact]
        public void Test_IfTooltipFollowPointerRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "tooltip" };
            var value = false;

            chart.PlotOptions.Wordcloud.Tooltip.FollowPointer = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("followPointer", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default should be false (not null)
        //[Fact]
        //public void Test_IfTooltipFollowPointerDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = false;

        //    chart.PlotOptions.Wordcloud.Tooltip.FollowPointer = defaultValue;

        //    Assert.DoesNotContain($"followPointer", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("{series.name}: <b>{point.y}</b><br/>")]
        public void Test_IfTooltipPointFormatRenders_Correct(string value)
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "wordcloud", "tooltip" };

            chart.PlotOptions.Wordcloud.Tooltip.PointFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("pointFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipPointFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "<span style='color:{point.color}'>●</span> {series.name}: <b>{point.weight}</b><br/>";

            chart.PlotOptions.Wordcloud.Tooltip.PointFormat = defaultValue;

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

            chart.PlotOptions.Wordcloud.TurboThreshold = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"turboThreshold\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTurboThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1000;

            chart.PlotOptions.Wordcloud.TurboThreshold = defaultValue;

            Assert.DoesNotContain($"turboThreshold", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleRenders_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            bool value = false;

            chart.PlotOptions.Wordcloud.Visible = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"visible\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Wordcloud.Visible = defaultValue;

            Assert.DoesNotContain($"visible", renderer.RenderHtml());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Xunit;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;
using System.Globalization;
using TH = Tests.Helpers.TestHelper;
using UnitTests.HC;
using System.Drawing;

namespace HC.PlotOptions
{
    public class PlotOptionsSeriesTests : IClassFixture<HcFixture>
    {
        protected HcFixture _fixture;

        public PlotOptionsSeriesTests(HcFixture fixture)
        {
            _fixture = fixture;
        }

        #region Acessibility

        [Theory]
        [InlineData("Description")]
        public void Test_IfAccessibilityDescriptionRenders_Correct(string description)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Accessibility.Description = description;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"description\":\"{description}\"}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityEnabledRenders_Correct(bool enabled)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Accessibility.Enabled = enabled;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"enabled\":{enabled.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }


        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityExposeAsGroupOnlyRenders_Correct(bool exposeAsGroupOnly)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Accessibility.ExposeAsGroupOnly = exposeAsGroupOnly;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"exposeAsGroupOnly\":{exposeAsGroupOnly.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        #region KeyboardNavigation

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityKeyboardNavigationEnabledRenders_Correct(bool enabled)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Accessibility.KeyboardNavigation.Enabled = enabled;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"keyboardNavigation\":{{\"enabled\":{enabled.ToString().ToLower()}}}}}}}}}", renderer.RenderHtml());
        }

        #endregion

        #region Point

        [Theory]
        [InlineData("%Y-%m-%d %H:%M:%S")]
        public void Test_IfAccessibilityPointDateFormatRenders_Correct(string format)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Accessibility.Point.DateFormat = format;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"point\":{{\"dateFormat\":\"{format}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("DateFormatterFunction")]
        public void Test_IfAccessibilityPointDateFormatterRenders_Correct(string function)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Accessibility.Point.DateFormatter = function;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"point\":{{\"dateFormatter\":{function}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(false)]
        public void Test_IfAccessibilityPointDescribeNullSetOnFalseRenders_Correct(bool describeNull)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            

            chart.PlotOptions.Series.Accessibility.Point.DescribeNull = describeNull;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"point\":{{\"describeNull\":{describeNull.ToString().ToLower()}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        public void Test_IfAccessibilityPointDescribeNullSetOnTrueRenders_Correct(bool describeNull)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Accessibility.Point.DescribeNull = describeNull;

            Assert.DoesNotContain($"describeNull", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("FormatterFunction")]
        public void Test_IfAccessibilityPointDescriptionFormatterRenders_Correct(string function)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Accessibility.Point.DescriptionFormatter = function;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"point\":{{\"descriptionFormatter\":{function}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(3)]
        public void Test_IfAccessibilityPointValueDecimalsRenders_Correct(int decimals)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Accessibility.Point.ValueDecimals = decimals;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"point\":{{\"valueDecimals\":{decimals}.0}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{Description}{separator}{value}")]
        public void Test_IfAccessibilityPointValueDescriptionFormatRenders_Correct(string format)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Accessibility.Point.ValueDescriptionFormat = format;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"point\":{{\"valueDescriptionFormat\":\"{format}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomePrefix")]
        public void Test_IfAccessibilityPointValuePrefixRenders_Correct(string prefix)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Accessibility.Point.ValuePrefix = prefix;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"point\":{{\"valuePrefix\":\"{prefix}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeSuffix")]
        public void Test_IfAccessibilityPointValueSufixRenders_Correct(string suffix)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Accessibility.Point.ValueSuffix = suffix;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"point\":{{\"valueSuffix\":\"{suffix}\"}}}}}}}}", renderer.RenderHtml());
        }
        #endregion

        #endregion

        [Fact]
        public void Test_IfAllowPointSelectRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);
            var enabled = true;

            chart.PlotOptions.Series.AllowPointSelect = enabled;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"allowPointSelect\":{enabled.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAllowPointSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.AllowPointSelect = false;

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

            chart.PlotOptions.Series.AnimationBool = value;

            Assert.Contains($":{{\"animation\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAnimationEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Series.AnimationBool = value;

            Assert.DoesNotContain("animation", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1000)]
        public void Test_IfAnimationDurationRenders_Correct(int duration)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Animation.Duration = duration;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"animation\":{{\"duration\":{duration}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1000)]
        public void Test_IfAnimationDeferRenders_Correct(int defer)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Animation.Defer = defer;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"animation\":{{\"defer\":{defer}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("easingFunctionName")]
        public void Test_IfAnimationEasingRenders_Correct(string easing)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Animation.Easing = easing;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"animation\":{{\"easing\":\"{easing}\"}}}}}}", renderer.RenderHtml());
        }

        #endregion
        
        [Theory]
        [InlineData(250)]
        public void Test_IfAnimationLimitRenders_Correct(int limit)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.AnimationLimit = limit;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"animationLimit\":{limit}.0}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSeriesBoostBlending.Add)]
        [InlineData(PlotOptionsSeriesBoostBlending.Darken)]
        [InlineData(PlotOptionsSeriesBoostBlending.Multiply)]
        public void Test_IfBoostBlendingRenders_Correct(PlotOptionsSeriesBoostBlending boostBlending)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.BoostBlending = boostBlending;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"boostBlending\":\"{boostBlending.ToString().ToLower()}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfBoostBlendingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.BoostBlending = PlotOptionsSeriesBoostBlending.Undefined;

            Assert.DoesNotContain($"\"boostBlending\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2000)]
        public void Test_IfBoostThresholdRenders_Correct(int limit)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.BoostThreshold = limit;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"boostThreshold\":{limit}.0}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfBoostThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 5000;

            chart.PlotOptions.Series.BoostThreshold = defaultValue;

            Assert.DoesNotContain("boostThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("ClassName")]
        public void Test_IfClassNameRenders_Correct(string className)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.ClassName = className;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"className\":\"{className}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Series.Clip = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"clip\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Series.Clip = value;

            Assert.DoesNotContain("clip", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#ffffff")]
        public void Test_IfColorRenders_Correct(string color)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Color = color;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"color\":\"{color.ToString().ToLower()}\"}}}}", renderer.RenderHtml());
        }

        //missing logic for GradientColorObject and PatternObject

        [Theory]
        [InlineData("axisId")]
        public void Test_IfColorAxisRendersString_Correct(string id)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.ColorAxis = id;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"colorAxis\":\"{id}\"}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void Test_IfColorAxisRendersNumber_Correct(int index)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.ColorAxisNumber = index;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"colorAxis\":{index}.0}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfColorAxisRendersBool_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);
            chart.PlotOptions.Series.ColorAxisBool = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"colorAxis\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1)]
        public void Test_IfColorIndexRenders_Correct(int value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.ColorIndex = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"colorIndex\":{value}.0}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("colorValue")]
        public void Test_IfColorKeyRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.ColorKey = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"colorKey\":\"{value}\"}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfConnectEndsRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.ConnectEnds = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"connectEnds\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfConnectNullsRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Series.ConnectNulls = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"connectNulls\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfConnectNullsDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Series.ConnectNulls = value;

            Assert.DoesNotContain($"\"connectNulls\"", renderer.RenderHtml());
        }



        [Fact]
        public void Test_IfCrispRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Series.Crisp = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"crisp\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCrispDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Series.Crisp = value;

            Assert.DoesNotContain($"\"crisp\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(299)]
        public void Test_IfCropThresholdRenders_Correct(int value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.CropThreshold = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"cropThreshold\":{value}.0}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCropThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 300;

            chart.PlotOptions.Series.CropThreshold = defaultValue;

            Assert.DoesNotContain($"\"crisp\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSeriesCursor.Default)]
        [InlineData(PlotOptionsSeriesCursor.Help)]
        [InlineData(PlotOptionsSeriesCursor.Pointer)]
        [InlineData(PlotOptionsSeriesCursor.None)]
        public void Test_IfCursorRenders_Correct(PlotOptionsSeriesCursor cursor)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Cursor = cursor;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"cursor\":\"{cursor.ToString().ToLower()}\"}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("dataKey1", "dataValue1")]
        public void Test_IfCustomRenders_Correct(string key1, string value1)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            
            var renderer = new HighchartsRenderer(chart);
            var extraData = new Hashtable() { { key1, value1 } };

            chart.PlotOptions.Series.Custom = extraData;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"custom\":{{\"{key1}\":\"{value1}\"}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSeriesDashStyle.Dash)]
        [InlineData(PlotOptionsSeriesDashStyle.DashDot)]
        [InlineData(PlotOptionsSeriesDashStyle.Dot)]
        [InlineData(PlotOptionsSeriesDashStyle.LongDash)]
        [InlineData(PlotOptionsSeriesDashStyle.LongDashDot)]
        [InlineData(PlotOptionsSeriesDashStyle.LongDashDotDot)]
        [InlineData(PlotOptionsSeriesDashStyle.ShortDash)]
        [InlineData(PlotOptionsSeriesDashStyle.ShortDashDot)]
        [InlineData(PlotOptionsSeriesDashStyle.ShortDashDotDot)]
        [InlineData(PlotOptionsSeriesDashStyle.ShortDot)]
        public void Test_IfDashStyleRenders_Correct(PlotOptionsSeriesDashStyle style)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DashStyle = style;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dashStyle\":\"{chart.FirstCharacterToLower(style.ToString())}\"}}}}", renderer.RenderHtml());
        }


        #region databaLabels

        //fix required - missing dataLabels as a list of objects (right now it is possible to have only one object)

        [Theory]
        [InlineData(PlotOptionsSeriesDataLabelsAlign.Left)]
        [InlineData(PlotOptionsSeriesDataLabelsAlign.Right)]
        public void Test_IfDataLabelsAlignRenders_Correct(PlotOptionsSeriesDataLabelsAlign align)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.Align = align;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"align\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSeriesDataLabelsAlign.Center;

            chart.PlotOptions.Series.DataLabels.Align = defaultValue;

            Assert.DoesNotContain($"align", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAllowOverlapRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Series.DataLabels.AllowOverlap = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"allowOverlap\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAllowOverlapDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Series.DataLabels.AllowOverlap = defaultValue;

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

            chart.PlotOptions.Series.DataLabels.Animation.Defer = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"animation\":{{\"defer\":{value}}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAnimationDeferDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Series.DataLabels.Animation.Defer = defaultValue;

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

            chart.PlotOptions.Series.DataLabels.BackgroundColor = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"backgroundColor\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBackgroundColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.DataLabels.BackgroundColor = defaultValue;

            Assert.DoesNotContain($"backgroundColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsBorderColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.BorderColor = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"borderColor\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.DataLabels.BorderColor = defaultValue;

            Assert.DoesNotContain($"borderColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsBorderRadiusRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.BorderRadius = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"borderRadius\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Series.DataLabels.BorderRadius = defaultValue;

            Assert.DoesNotContain($"borderRadius", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsBorderWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.BorderWidth = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"borderWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Series.DataLabels.BorderWidth = defaultValue;

            Assert.DoesNotContain($"borderWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("classA")]
        [InlineData("classB")]
        public void Test_IfDataLabelsClassNameRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.ClassName = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"className\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsClassNameDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.DataLabels.ClassName = defaultValue;

            Assert.DoesNotContain($"className", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.Color = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"color\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.DataLabels.Color = defaultValue;

            Assert.DoesNotContain($"color", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsCropRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Series.DataLabels.Crop = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"crop\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsCropDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Series.DataLabels.Crop = defaultValue;

            Assert.DoesNotContain($"crop", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsDeferBoolRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Series.DataLabels.Defer = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"defer\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsDeferBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Series.DataLabels.Defer = defaultValue;

            Assert.DoesNotContain($"defer", renderer.RenderHtml());
        }

        //[Theory]
        //[InlineData(2000)]
        //[InlineData(5000)]
        //public void Test_IfDataLabelsDeferRenders_Correct(double value)
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);

        //    chart.PlotOptions.Series.DataLabels.Defer = value;

        //    Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"defer\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",","")}}}}}}}", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfDataLabelsEnabledBoolRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Series.DataLabels.Enabled = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"enabled\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsEnabledBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Series.DataLabels.Enabled = defaultValue;

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

            chart.PlotOptions.Series.DataLabels.Filter.Operator = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"filter\":{{\"operator\":\"{value}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterOperatorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.DataLabels.Filter.Operator = defaultValue;

            Assert.DoesNotContain($"operator", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("percentage")]
        [InlineData("y")]
        public void Test_IfDataLabelsFilterPropertyRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.Filter.Property = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"filter\":{{\"property\":\"{value}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterPropertyDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.DataLabels.Filter.Property = defaultValue;

            Assert.DoesNotContain($"property", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsFilterValueRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.Filter.Value = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"filter\":{{\"value\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.DataLabels.Filter.Value = defaultValue;

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

            chart.PlotOptions.Series.DataLabels.Format = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"format\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "point.value";

            chart.PlotOptions.Series.DataLabels.Format = defaultValue;

            Assert.DoesNotContain($"format", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfDataLabelsFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.Formatter = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"formatter\":{value}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.DataLabels.Formatter = defaultValue;

            Assert.DoesNotContain($"formatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataLabelsInsideRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.Inside = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"inside\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsInsideDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Series.DataLabels.Inside = defaultValue;

            Assert.DoesNotContain($"inside", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataLabelsNullFormatBoolRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.NullFormatBool = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"nullFormat\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Series.DataLabels.NullFormatBool = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{y} mm")]
        [InlineData("<{x},{y}>")]
        public void Test_IfDataLabelsNullFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.NullFormat = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"nullFormat\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.DataLabels.NullFormat = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfDataLabelsNullFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.NullFormatter = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"nullFormatter\":{value}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.DataLabels.NullFormatter = defaultValue;

            Assert.DoesNotContain($"nullFormatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSeriesDataLabelsOverflow.Allow)]
        public void Test_IfDataLabelsOverflowRenders_Correct(PlotOptionsSeriesDataLabelsOverflow align)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.Overflow = align;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"overflow\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsOverflowDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSeriesDataLabelsOverflow.Justify;

            chart.PlotOptions.Series.DataLabels.Overflow = defaultValue;

            Assert.DoesNotContain($"overflow", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(50)]
        public void Test_IfDataLabelsPaddingRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.Padding = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"padding\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsPaddingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 5;

            chart.PlotOptions.Series.DataLabels.Padding = defaultValue;

            Assert.DoesNotContain($"padding", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSeriesDataLabelsPosition.Left)]
        [InlineData(PlotOptionsSeriesDataLabelsPosition.Right)]
        public void Test_IfDataLabelsPositionRenders_Correct(PlotOptionsSeriesDataLabelsPosition align)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.Position = align;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"position\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsPositionDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSeriesDataLabelsPosition.Center;

            chart.PlotOptions.Series.DataLabels.Position = defaultValue;

            Assert.DoesNotContain($"position", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(90)]
        [InlineData(180)]
        public void Test_IfDataLabelsRotationRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.Rotation = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"rotation\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsRotationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Series.DataLabels.Rotation = defaultValue;

            Assert.DoesNotContain($"rotation", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsShadowBoolRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Series.DataLabels.ShadowBool = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"shadow\":{chart.FirstCharacterToLower(value.ToString())}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#00ffdd", 10, 20, 30, 40)]
        [InlineData("#ffccaa", 40, 30, 20, 10)]
        public void Test_IfDataLabelsShadowRenders_Correct(string color, int offsetX, int offsetY, double opacity, int width)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.Shadow = new Shadow()
            {
                Color = color,
                OffsetX = offsetX,
                OffsetY = offsetY,
                Opacity = opacity,
                Width = width
            };

            var result = renderer.RenderHtml();
            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"shadow\":", result);
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

            chart.PlotOptions.Series.DataLabels.ShadowBool = defaultValue;

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

            chart.PlotOptions.Series.DataLabels.Shape = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"shape\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsShapeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "square";

            chart.PlotOptions.Series.DataLabels.Shape = defaultValue;

            Assert.DoesNotContain($"shape", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("background", "green")]
        [InlineData("backgroundColor","#0022ff")]
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
            var pathToProperty = new List<string>() { "plotOptions", "series", "dataLabels", "style" };
            var style = new Hashtable();
            style.Add(param1, param1_value);
            
            chart.PlotOptions.Series.DataLabels.Style = style;
            
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
            var pathToProperty = new List<string>() { "plotOptions", "series", "dataLabels", "style" };
            var style = new Hashtable();
            style.Add(param1, param1_value);

            chart.PlotOptions.Series.DataLabels.Style = style;

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
            var pathToProperty = new List<string> { "plotOptions", "series", "dataLabels", "textPath" };

            chart.PlotOptions.Series.DataLabels.TextPath.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled",value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsTextPathEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = false;

            chart.PlotOptions.Series.DataLabels.TextPath.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        #endregion

        [Fact]
        public void Test_IfDataLabelsUseHTMLRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Series.DataLabels.UseHTML = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"useHTML\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsUseHTMLDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Series.DataLabels.UseHTML = defaultValue;

            Assert.DoesNotContain($"useHTML", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSeriesDataLabelsVerticalAlign.Middle)]
        [InlineData(PlotOptionsSeriesDataLabelsVerticalAlign.Top)]
        public void Test_IfDataLabelsVerticalAlignRenders_Correct(PlotOptionsSeriesDataLabelsVerticalAlign align)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.VerticalAlign = align;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"verticalAlign\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsVerticalAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSeriesDataLabelsVerticalAlign.Bottom;

            chart.PlotOptions.Series.DataLabels.VerticalAlign = defaultValue;

            Assert.DoesNotContain($"verticalAlign", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsXRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.X = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"x\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Series.DataLabels.X = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"x\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsYRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.Y = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"y\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Series.DataLabels.Y = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"y\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsZRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.DataLabels.ZIndex = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"dataLabels\":{{\"zIndex\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsZDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 6;

            chart.PlotOptions.Series.DataLabels.ZIndex = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"zIndex\":", renderer.RenderHtml());
        }

        #endregion

        #region dataSorting

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataSortingEnabledRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "dataSorting" };

            chart.PlotOptions.Series.DataSorting.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataSortingEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Series.DataSorting.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataSortingMatchByNameRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "dataSorting" };

            chart.PlotOptions.Series.DataSorting.MatchByName = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("matchByName", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataSortingMatchByNameDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Series.DataSorting.MatchByName = defaultValue;

            Assert.DoesNotContain($"matchByName", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("x")]
        [InlineData("z")]
        public void Test_IfDataSortingSortKeyRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "dataSorting"};

            chart.PlotOptions.Series.DataSorting.SortKey = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("sortKey", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataSortingSortKeyDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "y";

            chart.PlotOptions.Series.DataSorting.SortKey = defaultValue;

            Assert.DoesNotContain($"sortKey", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("SomePlotOptionsDescription")]
        public void Test_IfDescriptionRenders_Correct(string description)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Description = description;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"description\":\"{description}\"}}}}", renderer.RenderHtml());
        }

        #region dragDrop

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDragDropDraggableXRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "dragDrop" };

            chart.PlotOptions.Series.DragDrop.DraggableX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("draggableX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDraggableXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Series.DragDrop.DraggableX = defaultValue;

            Assert.DoesNotContain($"draggableX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDragDropDraggableYRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "dragDrop" };

            chart.PlotOptions.Series.DragDrop.DraggableY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("draggableY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDraggableYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Series.DragDrop.DraggableY = defaultValue;

            Assert.DoesNotContain($"draggableY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDragDropDragMaxXRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "dragDrop" };

            chart.PlotOptions.Series.DragDrop.DragMaxX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dragMaxX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDragMaxXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.DragDrop.DragMaxX = defaultValue;

            Assert.DoesNotContain($"dragMaxX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDragDropDragMaxYRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "dragDrop" };

            chart.PlotOptions.Series.DragDrop.DragMaxY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dragMaxY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDragMaxYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.DragDrop.DragMaxY = defaultValue;

            Assert.DoesNotContain($"dragMaxY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDragDropDragMinXRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "dragDrop" };

            chart.PlotOptions.Series.DragDrop.DragMinX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dragMinX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDragMinXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.DragDrop.DragMinX = defaultValue;

            Assert.DoesNotContain($"dragMinX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDragDropDragMinYRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "dragDrop" };

            chart.PlotOptions.Series.DragDrop.DragMinY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dragMinY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDragMinYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.DragDrop.DragMinY = defaultValue;

            Assert.DoesNotContain($"dragMinY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDragDropDragPrecisionXRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "dragDrop" };
            

            chart.PlotOptions.Series.DragDrop.DragPrecisionX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dragPrecisionX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDragPrecisionXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = 0;

            chart.PlotOptions.Series.DragDrop.DragPrecisionX = defaultValue;

            Assert.DoesNotContain($"dragPrecisionX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDragDropDragPrecisionYRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "dragDrop" };


            chart.PlotOptions.Series.DragDrop.DragPrecisionY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dragPrecisionY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDragPrecisionYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = 0;

            chart.PlotOptions.Series.DragDrop.DragPrecisionY = defaultValue;

            Assert.DoesNotContain($"dragPrecisionY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDragDropDragSensitivityRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "dragDrop" };


            chart.PlotOptions.Series.DragDrop.DragSensitivity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dragSensitivity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropDragSensitivityDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = 2;

            chart.PlotOptions.Series.DragDrop.DragSensitivity = defaultValue;

            Assert.DoesNotContain($"dragPrecisionY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("groupId")]
        public void Test_IfDragDropGroupByRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "dragDrop" };


            chart.PlotOptions.Series.DragDrop.GroupBy = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("groupBy", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropGroupByDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.DragDrop.GroupBy = defaultValue;

            Assert.DoesNotContain($"groupBy", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeClassName")]
        public void Test_IfDragDropGuideBoxDefaultClassNameRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "dragDrop", "guideBox", "default" };


            chart.PlotOptions.Series.DragDrop.GuideBox.Default.ClassName = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("className", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropGuideBoxDefaultDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "highcharts-drag-box-default";

            chart.PlotOptions.Series.DragDrop.GuideBox.Default.ClassName = defaultValue;

            Assert.DoesNotContain($"className", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#ff0033")]
        public void Test_IfDragDropGuideBoxDefaultColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "dragDrop", "guideBox", "default" };


            chart.PlotOptions.Series.DragDrop.GuideBox.Default.Color = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("color", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropGuideBoxDefaultColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "rgba(0, 0, 0, 0.1)";

            chart.PlotOptions.Series.DragDrop.GuideBox.Default.Color = defaultValue;

            Assert.DoesNotContain($"color", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeCursorName")]
        public void Test_IfDragDropGuideBoxDefaultCursorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "dragDrop", "guideBox", "default" };


            chart.PlotOptions.Series.DragDrop.GuideBox.Default.Cursor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("cursor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropGuideBoxDefaultCursorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "move";

            chart.PlotOptions.Series.DragDrop.GuideBox.Default.Cursor = defaultValue;

            Assert.DoesNotContain($"cursor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#2200ff")]
        public void Test_IfDragDropGuideBoxDefaultLineColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "dragDrop", "guideBox", "default" };


            chart.PlotOptions.Series.DragDrop.GuideBox.Default.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropGuideBoxDefaultLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "#888";

            chart.PlotOptions.Series.DragDrop.GuideBox.Default.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfDragDropGuideBoxDefaultLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "dragDrop", "guideBox", "default" };


            chart.PlotOptions.Series.DragDrop.GuideBox.Default.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropGuideBoxDefaultLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Series.DragDrop.GuideBox.Default.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfDragDropGuideBoxDefaultZIndexRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "dragDrop", "guideBox", "default" };


            chart.PlotOptions.Series.DragDrop.GuideBox.Default.ZIndex = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("zIndex", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropGuideBoxDefaultZIndexDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 900;

            chart.PlotOptions.Series.DragDrop.GuideBox.Default.ZIndex = defaultValue;

            Assert.DoesNotContain($"zIndex", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropLiveRedrawRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "dragDrop" };
            bool value = false;

            chart.PlotOptions.Series.DragDrop.LiveRedraw = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("liveRedraw", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDragDropLiveRedrawDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool defaultValue = true;

            chart.PlotOptions.Series.DragDrop.LiveRedraw = defaultValue;

            Assert.DoesNotContain($"liveRedraw", renderer.RenderHtml());
        }

        #endregion

        [Fact]
        public void Test_IfEnableMouseTrackingRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Series.EnableMouseTracking = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"enableMouseTracking\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Series.EnableMouseTracking = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"series\":{{\"enableMouseTracking\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        #region events

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsAfterAnimateRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "events" };

            chart.PlotOptions.Series.Events.AfterAnimate = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("afterAnimate", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsAfterAnimateDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Events.AfterAnimate = defaultValue;

            Assert.DoesNotContain($"afterAnimate", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsCheckboxClickRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "events" };

            chart.PlotOptions.Series.Events.CheckboxClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("checkboxClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsCheckboxClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Events.CheckboxClick = defaultValue;

            Assert.DoesNotContain($"checkboxClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsClickRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "events" };

            chart.PlotOptions.Series.Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsclickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsHideRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "events" };

            chart.PlotOptions.Series.Events.Hide = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("hide", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsHideDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Events.Hide = defaultValue;

            Assert.DoesNotContain($"hide", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsLegendItemClickRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "events" };

            chart.PlotOptions.Series.Events.LegendItemClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("legendItemClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsLegendItemClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Events.LegendItemClick = defaultValue;

            Assert.DoesNotContain($"legendItemClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "events" };

            chart.PlotOptions.Series.Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "events" };

            chart.PlotOptions.Series.Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsShowRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "events" };

            chart.PlotOptions.Series.Events.Show = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("show", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsShowDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Events.Show = defaultValue;

            Assert.DoesNotContain($"show", renderer.RenderHtml());
        }

        #endregion


        [Fact]
        public void Test_IfFindNearestPointByRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = PlotOptionsSeriesFindNearestPointBy.Xy;

            chart.PlotOptions.Series.FindNearestPointBy = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"findNearestPointBy\":\"{value.ToString().ToLower()}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfFindNearestPointByDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = PlotOptionsSeriesFindNearestPointBy.X;

            chart.PlotOptions.Series.FindNearestPointBy = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"series\":{{\"findNearestPointBy\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfGetExtremesFromAllRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = true;

            chart.PlotOptions.Series.GetExtremesFromAll = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"getExtremesFromAll\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfGetExtremesFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = false;

            chart.PlotOptions.Series.GetExtremesFromAll = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"series\":{{\"getExtremesFromAll\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfIncludeInDataExportFromAllRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.IncludeInDataExport = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"includeInDataExport\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfIncludeInDataExportFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? value = null;

            chart.PlotOptions.Series.IncludeInDataExport = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"series\":{{\"includeInDataExport\":{value}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("name", "y", "dataLabels.style.visibility", "true")]
        public void Test_IfKeysRenders_Correct(string arg1, string arg2, string arg3, string arg4)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = new List<string> { arg1, arg2, arg3, arg4 };

            chart.PlotOptions.Series.Keys = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"keys\":[\"{arg1}\",\"{arg2}\",\"{arg3}\",\"{arg4}\"]}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfKeysDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = new List<string>();

            chart.PlotOptions.Series.Keys = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"series\":{{\"keys\":}}}}", renderer.RenderHtml());
        }

        #region label

        //missing boxesToAvoid

        [Fact]
        public void Test_IfLabelConnectorAllowedRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "label" };
            var value = true;

            chart.PlotOptions.Series.Label.ConnectorAllowed = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorAllowed", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorAllowedDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Series.Label.ConnectorAllowed = defaultValue;

            Assert.DoesNotContain($"connectorAllowed", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(30)]
        public void Test_IfLabelConnectorNeighbourDistanceRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "label" };

            chart.PlotOptions.Series.Label.ConnectorNeighbourDistance = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorNeighbourDistance", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorNeighbourDistanceDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 24;

            chart.PlotOptions.Series.Label.ConnectorNeighbourDistance = defaultValue;

            Assert.DoesNotContain($"connectorNeighbourDistance", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "label" };
            var value = false;

            chart.PlotOptions.Series.Label.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Series.Label.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFormat")]
        public void Test_IfLabelFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "label" };

            chart.PlotOptions.Series.Label.Format = value;

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

        //    chart.PlotOptions.Series.Label.Format = defaultValue;

        //    Assert.DoesNotContain($"format", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("SomeFormatterFunction")]
        public void Test_IfLabelFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "label" };

            chart.PlotOptions.Series.Label.Formatter = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("formatter", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Label.Formatter = defaultValue;

            Assert.DoesNotContain($"formatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMaxFontSizeRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "label" };

            chart.PlotOptions.Series.Label.MaxFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("maxFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMaxFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.Label.MaxFontSize = defaultValue;

            Assert.DoesNotContain($"maxFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMinFontSizeRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "label" };

            chart.PlotOptions.Series.Label.MinFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("minFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMinFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.Label.MinFontSize = defaultValue;

            Assert.DoesNotContain($"minFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfLabelOnAreaRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "label" };

            chart.PlotOptions.Series.Label.OnArea = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("onArea", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelOnAreaDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Series.Label.OnArea = defaultValue;

            Assert.DoesNotContain($"onArea", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("fontWeight", "bold")]
        public void Test_IfLabelStyleRenders_Correct(string paramName, string paramValue)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "label" };
            var value = new Hashtable();
            value.Add(paramName, paramValue);


            chart.PlotOptions.Series.Label.Style = value;

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

        //    chart.PlotOptions.Series.Label.Style = defaultValue;

        //    Assert.DoesNotContain($"style", renderer.RenderHtml());
        //}



        #endregion

        [Theory]
        [InlineData(PlotOptionsSeriesLinecap.Square)]
        //missing PlotOptionsSeriesLinecap.Butt ?
        public void Test_IfLinecapRenders_Correct(PlotOptionsSeriesLinecap value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Linecap = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"linecap\":\"{chart.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLinecapDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSeriesLinecap.Round;

            chart.PlotOptions.Series.Linecap = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"series\":{{\"linecap\":{defaultValue.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.LineWidth = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"lineWidth\":{string.Format(new CultureInfo("en-us"),"{0:N1}",value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 2;

            chart.PlotOptions.Series.LineWidth = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"series\":{{\"lineWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", defaultValue)}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(":previous")]
        [InlineData("IdAnotherSeries")]
        public void Test_IfLinkedToRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.LinkedTo = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"linkedTo\":\"{value}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLinkedToDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            string defaultValue = String.Empty;

            chart.PlotOptions.Series.LinkedTo = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"series\":{{\"linkedTo\":{defaultValue}}}}}", renderer.RenderHtml());
        }

        #region marker

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfMarkerEnabledRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "marker" };

            chart.PlotOptions.Series.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Series.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "marker" };

            chart.PlotOptions.Series.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double defaultValue = 2;

            chart.PlotOptions.Series.Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "marker" };

            chart.PlotOptions.Series.Marker.FillColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("fillColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        /// <summary>
        /// fix that color - should be a string, patternObject and GradientObject
        /// </summary>
        /// <param name="value"></param>
        //[Fact]
        //public void Test_IfMarkerFillColorDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Series.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "marker" };

            chart.PlotOptions.Series.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "marker" };

            chart.PlotOptions.Series.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        
        [Fact]
        public void Test_IfMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "#ffffff";

            chart.PlotOptions.Series.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "marker" };

            chart.PlotOptions.Series.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Series.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "marker" };

            chart.PlotOptions.Series.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 4;

            chart.PlotOptions.Series.Marker.Radius = defaultValue;

            Assert.DoesNotContain($"radius", renderer.RenderHtml());
        }

        //missing States

        [Theory]
        [InlineData("circle")]
        [InlineData("square")]
        [InlineData("diamond")]
        [InlineData("triangle")]
        [InlineData("triangle-down")]
        [InlineData("url(graphic.png)")]
        public void Test_IfMarkerSymbolRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "marker" };

            chart.PlotOptions.Series.Marker.Symbol = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("symbol", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerSymbolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Marker.Symbol = defaultValue;

            Assert.DoesNotContain($"symbol", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(1000)]
        public void Test_IfMarkerWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "marker" };

            chart.PlotOptions.Series.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.Marker.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("#FF0000")]
        [InlineData("#0088FF")]
        public void Test_IfNegativeColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.NegativeColor = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"negativeColor\":\"{value}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfNegativeColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            string defaultValue = String.Empty;

            chart.PlotOptions.Series.NegativeColor = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"series\":{{\"negativeColor\":{defaultValue}}}}}", renderer.RenderHtml());
        }

        #region onPoint

        //fix dashStyle - should be string instead of hashtable
        //[Theory]
        //[InlineData("dot")]
        //public void Test_IfOnPointConnectorOptionsDashStyleRenders_Correct(string value)
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "series", "onPoint", "connectorOptions" };

        //    chart.PlotOptions.Series.OnPoint.ConnectorOptions.Dashstyle = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dashstyle", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfOnPointConnectorOptionsDashStyleDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Series.DataLabels.Color = defaultValue;

        //    Assert.DoesNotContain($"color", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("red")]
        public void Test_IfOnPointConnectorOptionsStrokeRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "onPoint", "connectorOptions" };

            chart.PlotOptions.Series.OnPoint.ConnectorOptions.Stroke = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("stroke", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsStrokeDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.OnPoint.ConnectorOptions.Stroke = defaultValue;

            Assert.DoesNotContain($"stroke", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointConnectorOptionsWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "onPoint", "connectorOptions" };

            chart.PlotOptions.Series.OnPoint.ConnectorOptions.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Series.OnPoint.ConnectorOptions.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("pointId")]
        public void Test_IfOnPointIdRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "onPoint" };

            chart.PlotOptions.Series.OnPoint.Id = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("id", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointIdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.OnPoint.Id = defaultValue;

            Assert.DoesNotContain($"\"id\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetXRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "onPoint", "position"};

            chart.PlotOptions.Series.OnPoint.Position.OffsetX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.OnPoint.Position.OffsetX = defaultValue;

            Assert.DoesNotContain($"offsetX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetYRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "onPoint", "position" };

            chart.PlotOptions.Series.OnPoint.Position.OffsetY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.OnPoint.Position.OffsetY = defaultValue;

            Assert.DoesNotContain($"offsetY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionXRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "onPoint", "position" };

            chart.PlotOptions.Series.OnPoint.Position.X = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("x", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointXDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.OnPoint.Position.X = defaultValue;

            Assert.DoesNotContain($"\"x\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionYRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "onPoint", "position" };

            chart.PlotOptions.Series.OnPoint.Position.Y = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("y", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointYDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.OnPoint.Position.Y = defaultValue;

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

            chart.PlotOptions.Series.Opacity = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOpacityDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Series.Opacity = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"series\":{{\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", defaultValue)}}}}}", renderer.RenderHtml());
        }

        #region point

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsClickRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "point", "events" };
            
            chart.PlotOptions.Series.Point.Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Point.Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "point", "events" };

            chart.PlotOptions.Series.Point.Events.Drag = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drag", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Point.Events.Drag = defaultValue;

            Assert.DoesNotContain($"drag", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragStartRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "point", "events" };

            chart.PlotOptions.Series.Point.Events.DragStart = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("dragStart", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragStartDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Point.Events.DragStart = defaultValue;

            Assert.DoesNotContain($"dragStart", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDropRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "point", "events" };

            chart.PlotOptions.Series.Point.Events.Drop = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drop", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDropDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Point.Events.Drop = defaultValue;

            Assert.DoesNotContain($"drop", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "point", "events" };

            chart.PlotOptions.Series.Point.Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Point.Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "point", "events" };

            chart.PlotOptions.Series.Point.Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Point.Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsRemoveRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "point", "events" };

            chart.PlotOptions.Series.Point.Events.Remove = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("remove", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsRemoveDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Point.Events.Remove = defaultValue;

            Assert.DoesNotContain($"remove", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsSelectRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "point", "events" };

            chart.PlotOptions.Series.Point.Events.Select = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("select", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Point.Events.Select = defaultValue;

            Assert.DoesNotContain($"select", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUnselectRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "point", "events" };

            chart.PlotOptions.Series.Point.Events.Unselect = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("unselect", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUnselectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Point.Events.Unselect = defaultValue;

            Assert.DoesNotContain($"unselect", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUpdateRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "point", "events" };

            chart.PlotOptions.Series.Point.Events.Update = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("update", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUpdateDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Point.Events.Update = defaultValue;

            Assert.DoesNotContain($"update", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointDescriptionFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.PointDescriptionFormatter = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"pointDescriptionFormatter\":{value}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointDescriptionFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.PointDescriptionFormatter = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"series\":{{\"pointDescriptionFormatter\":{defaultValue}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfPointIntervalRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.PointInterval = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"pointInterval\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointIntervalDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Series.PointInterval = defaultValue;

            Assert.DoesNotContain($"pointInterval", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSeriesPointIntervalUnit.Day)]
        [InlineData(PlotOptionsSeriesPointIntervalUnit.Month)]
        [InlineData(PlotOptionsSeriesPointIntervalUnit.Year)]
        public void Test_IfPointIntervalUnitRenders_Correct(PlotOptionsSeriesPointIntervalUnit value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.PointIntervalUnit = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"pointIntervalUnit\":\"{chart.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointIntervalUnitDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSeriesPointIntervalUnit.Null;

            chart.PlotOptions.Series.PointIntervalUnit = defaultValue;

            Assert.DoesNotContain($"pointIntervalUnit", renderer.RenderHtml());
        }

        //[Theory]
        //[InlineData(PointPlacementEnum.Between)]
        //[InlineData(PointPlacementEnum.On)]
        //public void Test_IfPointPlacementEnumRenders_Correct(PointPlacementEnum value)
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);

        //    chart.PlotOptions.Series.PointPlacement = new PointPlacement() { PointPlacementEnum = value };

        //    Assert.Contains($"\"plotOptions\":{{\"series\":{{\"pointPlacement\":\"{chart.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        //}

        //[Theory]
        //[InlineData(0)]
        //[InlineData(-0.5)]
        //[InlineData(0.5)]
        //public void Test_IfPointPlacementNumberRenders_Correct(double value)
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);

        //    chart.PlotOptions.Series.PointPlacement = new PointPlacement() { Value = value };

        //    Assert.Contains($"\"plotOptions\":{{\"series\":{{\"pointPlacement\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfPointPlacementDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = PointPlacementEnum.Null;

        //    chart.PlotOptions.Series.PointPlacement = new PointPlacement() { PointPlacementEnum = defaultValue };

        //    Assert.DoesNotContain($"pointPlacement", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        public void Test_IfPointStartRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.PointStart = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"pointStart\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointStartDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Series.PointStart = defaultValue;

            Assert.DoesNotContain($"pointStart", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Series.RelativeXValue = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"relativeXValue\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Series.RelativeXValue = defaultValue;

            Assert.DoesNotContain($"relativeXValue", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Series.Selected = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"selected\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Series.Selected = defaultValue;

            Assert.DoesNotContain($"selected", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShadowBoolRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Series.ShadowBool = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"shadow\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#00ffdd", 10, 20, 30, 40)]
        [InlineData("#ffccaa", 40, 30, 20, 10)]
        public void Test_IfShadowRenders_Correct(string color, int offsetX, int offsetY, double opacity, int width)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Shadow = new Shadow()
            {
                Color = color,
                OffsetX = offsetX,
                OffsetY = offsetY,
                Opacity = opacity,
                Width = width
            };

            var result = renderer.RenderHtml();
            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"shadow\":", result);
            Assert.Contains($"\"offsetX\":{offsetX}", result);
            Assert.Contains($"\"width\":{width}", result);
            Assert.Contains($"\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", opacity)}", result);
            Assert.Contains($"\"offsetY\":{offsetY}", result);
            Assert.Contains($"\"color\":\"{color}\"", result);
        }

        [Fact]
        public void Test_IfShadowBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Series.ShadowBool = defaultValue;

            Assert.DoesNotContain($"shadow", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowCheckboxRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool value = true;

            chart.PlotOptions.Series.ShowCheckbox = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"showCheckbox\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowCheckboxDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Series.ShowCheckbox = defaultValue;

            Assert.DoesNotContain($"showCheckbox", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfShowInLegendRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.ShowInLegend = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"showInLegend\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowInLegendDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.ShowInLegend = null;

            Assert.DoesNotContain($"showInLegend", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfSkipKeyboardNavigationRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.SkipKeyboardNavigation = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"skipKeyboardNavigation\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSkipKeyboardNavigationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.SkipKeyboardNavigation = null;

            Assert.DoesNotContain($"skipKeyboardNavigation", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSoftThresholdRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool value = false;

            chart.PlotOptions.Series.SoftThreshold = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"softThreshold\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSoftThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Series.SoftThreshold = defaultValue;

            Assert.DoesNotContain($"softThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSeriesStacking.Overlap)]
        [InlineData(PlotOptionsSeriesStacking.Percent)]
        [InlineData(PlotOptionsSeriesStacking.Normal)]
        [InlineData(PlotOptionsSeriesStacking.Stream)]
        public void Test_IfStackingRenders_Correct(PlotOptionsSeriesStacking value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Stacking = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"stacking\":\"{chart.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSeriesStacking.Null;

            chart.PlotOptions.Series.Stacking = defaultValue;

            Assert.DoesNotContain($"stacking", renderer.RenderHtml());
        }

        #region states

        #region hover

        #region animation
        [Theory]
        [InlineData(5)]
        public void Test_IfStatesHoverAnimationDurationRenders_Correct(int value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "states", "hover", "animation" };

            chart.PlotOptions.Series.States.Hover.Animation.Duration = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Series.States.Hover.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesHoverEnabledRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "states", "hover" };
            var value = false;

            chart.PlotOptions.Series.States.Hover.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesHoverEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Series.States.Hover.Enabled = defaultValue;

        //    Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        //}

        #region halo

        // fix required - attributes should be hashtable (not object)
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesHoverHaloAttributesRenders_Correct(int value)
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "series", "states", "hover", "halo" };

        //    chart.PlotOptions.Series.States.Hover.Halo.Attributes = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("attributes", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfStatesHoverHaloAttributesDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Series.States.Hover.Animation.Duration = defaultValue;

        //    Assert.DoesNotContain($"duration", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(2)]
        [InlineData(0.5)]
        public void Test_IfStatesHoverHaloOpacityRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "states", "hover", "halo" };

            chart.PlotOptions.Series.States.Hover.Halo.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default value for opacity = 0.25 (not null)
        //[Fact]
        //public void Test_IfStatesHoverHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Series.States.Hover.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Theory]
        //[InlineData(2)]
        //[InlineData(0.5)]
        //public void Test_IfStatesHoverHaloSizeRenders_Correct(double value)
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "series", "states", "hover", "halo" };

        //    chart.PlotOptions.Series.States.Hover.Halo.Size = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("size", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Fact]
        //public void Test_IfStatesHoverHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Series.States.Hover.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesHoverLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "states", "hover" };

            chart.PlotOptions.Series.States.Hover.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.States.Hover.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesHoverLineWidthPlusRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "states", "hover" };

            chart.PlotOptions.Series.States.Hover.LineWidthPlus = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidthPlus", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default should be 1 (not null)
        //[Fact]
        //public void Test_IfStatesHoverLineWidthPlusDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    double? defaultValue = 1;

        //    chart.PlotOptions.Series.States.Hover.LineWidthPlus = defaultValue;

        //    Assert.DoesNotContain($"lineWidthPlus", renderer.RenderHtml());
        //}

        #region marker

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfStatesHoverMarkerEnabledRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "hover", "marker" };

            chart.PlotOptions.Series.States.Hover.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Series.States.Hover.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesHoverMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "hover", "marker" };

            chart.PlotOptions.Series.States.Hover.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double defaultValue = 2;

            chart.PlotOptions.Series.States.Hover.Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfStatesHoverMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "hover", "marker" };

            chart.PlotOptions.Series.States.Hover.Marker.FillColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("fillColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        /// <summary>
        /// fix that color - should be a string, patternObject and GradientObject
        /// </summary>
        /// <param name="value"></param>
        //[Fact]
        //public void Test_IfStatesHoverMarkerFillColorDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Series.States.Hover.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesHoverMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "hover", "marker" };

            chart.PlotOptions.Series.States.Hover.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.States.Hover.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfStatesHoverMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "hover", "marker" };

            chart.PlotOptions.Series.States.Hover.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesHoverMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "#ffffff";

            chart.PlotOptions.Series.States.Hover.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesHoverMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "hover", "marker" };

            chart.PlotOptions.Series.States.Hover.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesHoverMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Series.States.Hover.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesHoverMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "hover", "marker" };

            chart.PlotOptions.Series.States.Hover.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesHoverMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 4;

            chart.PlotOptions.Series.States.Hover.Marker.Radius = defaultValue;

            Assert.DoesNotContain($"radius", renderer.RenderHtml());
        }

        //missing States

        [Theory]
        [InlineData(5)]
        [InlineData(1000)]
        public void Test_IfStatesHoverMarkerWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "hover", "marker" };

            chart.PlotOptions.Series.States.Hover.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.States.Hover.Marker.Width = defaultValue;

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
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "states", "inactive", "animation" };

            chart.PlotOptions.Series.States.Inactive.Animation.Duration = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesInactiveAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Series.States.Inactive.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesInactiveEnabledRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "states", "inactive" };
            var value = false;

            chart.PlotOptions.Series.States.Inactive.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesInactiveEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Series.States.Inactive.Enabled = defaultValue;

        //    Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(0.5)]
        public void Test_IfStatesInactiveOpacityRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "states", "inactive" };

            chart.PlotOptions.Series.States.Inactive.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default value should be 0.2 (not null)
        //[Fact]
        //public void Test_IfStatesInactiveOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.2;

        //    chart.PlotOptions.Series.States.Inactive.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        #region normal

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesNormalAnimationDurationRenders_Correct(int value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "states", "normal", "animation" };

            chart.PlotOptions.Series.States.Normal.Animation.Duration = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesNormalAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Series.States.Normal.Animation.Duration = defaultValue;

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
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "states", "select", "animation" };

            chart.PlotOptions.Series.States.Select.Animation.Duration = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Series.States.Select.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesSelectEnabledRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "states", "select" };
            var value = false;

            chart.PlotOptions.Series.States.Select.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesSelectEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Series.States.Select.Enabled = defaultValue;

        //    Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        //}

        #region halo

        // fix required - attributes should be hashtable (not object)
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesSelectHaloAttributesRenders_Correct(int value)
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "series", "states", "select", "halo" };

        //    chart.PlotOptions.Series.States.Select.Halo.Attributes = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("attributes", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfStatesSelectHaloAttributesDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Series.States.Select.Animation.Duration = defaultValue;

        //    Assert.DoesNotContain($"duration", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(2)]
        [InlineData(0.5)]
        public void Test_IfStatesSelectHaloOpacityRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "states", "select", "halo" };

            chart.PlotOptions.Series.States.Select.Halo.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default value for opacity = 0.25 (not null)
        //[Fact]
        //public void Test_IfStatesSelectHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Series.States.Select.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Theory]
        //[InlineData(2)]
        //[InlineData(0.5)]
        //public void Test_IfStatesSelectHaloSizeRenders_Correct(double value)
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "series", "states", "select", "halo" };

        //    chart.PlotOptions.Series.States.Select.Halo.Size = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("size", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Fact]
        //public void Test_IfStatesSelectHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Series.States.Select.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesSelectLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "states", "select" };

            chart.PlotOptions.Series.States.Select.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.States.Select.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesSelectLineWidthPlusRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "states", "select" };

            chart.PlotOptions.Series.States.Select.LineWidthPlus = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidthPlus", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default should be 1 (not null)
        //[Fact]
        //public void Test_IfStatesSelectLineWidthPlusDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    double? defaultValue = 1;

        //    chart.PlotOptions.Series.States.Select.LineWidthPlus = defaultValue;

        //    Assert.DoesNotContain($"lineWidthPlus", renderer.RenderHtml());
        //}

        #region marker

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfStatesSelectMarkerEnabledRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "select", "marker" };

            chart.PlotOptions.Series.States.Select.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Series.States.Select.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesSelectMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "select", "marker" };

            chart.PlotOptions.Series.States.Select.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double defaultValue = 2;

            chart.PlotOptions.Series.States.Select.Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfStatesSelectMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "select", "marker" };

            chart.PlotOptions.Series.States.Select.Marker.FillColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("fillColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        /// <summary>
        /// fix that color - should be a string, patternObject and GradientObject
        /// </summary>
        /// <param name="value"></param>
        //[Fact]
        //public void Test_IfStatesSelectMarkerFillColorDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Series.States.Select.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesSelectMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "select", "marker" };

            chart.PlotOptions.Series.States.Select.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.States.Select.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfStatesSelectMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "select", "marker" };

            chart.PlotOptions.Series.States.Select.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "#ffffff";

            chart.PlotOptions.Series.States.Select.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesSelectMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "select", "marker" };

            chart.PlotOptions.Series.States.Select.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Series.States.Select.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesSelectMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "select", "marker" };

            chart.PlotOptions.Series.States.Select.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 4;

            chart.PlotOptions.Series.States.Select.Marker.Radius = defaultValue;

            Assert.DoesNotContain($"radius", renderer.RenderHtml());
        }

        //missing States

        [Theory]
        [InlineData(5)]
        [InlineData(1000)]
        public void Test_IfStatesSelectMarkerWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "series", "states", "select", "marker" };

            chart.PlotOptions.Series.States.Select.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.States.Select.Marker.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        #endregion

        #endregion

        #endregion


        [Theory]
        [InlineData(PlotOptionsSeriesStep.Center)]
        [InlineData(PlotOptionsSeriesStep.Left)]
        [InlineData(PlotOptionsSeriesStep.Right)]
        public void Test_IfStepRenders_Correct(PlotOptionsSeriesStep value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Step = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"step\":\"{chart.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStepDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSeriesStep.Null;

            chart.PlotOptions.Series.Step = defaultValue;

            Assert.DoesNotContain($"step", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool value = false;

            chart.PlotOptions.Series.StickyTracking = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"stickyTracking\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Series.StickyTracking = defaultValue;

            Assert.DoesNotContain($"stickyTracking", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfThresholdRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.Threshold = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"threshold\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Series.Threshold = defaultValue;

            Assert.DoesNotContain($"threshold", renderer.RenderHtml());
        }

        #region tooltip

        [Theory]
        [InlineData("Clustered points: {point.otherValue}")]
        public void Test_IfTooltipClusterFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "tooltip" };

            chart.PlotOptions.Series.Tooltip.ClusterFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("clusterFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipClusterFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "Clustered points: {point.clusterPointsAmount}";

            chart.PlotOptions.Series.Tooltip.ClusterFormat = defaultValue;

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
            var pathToProperty = new List<string>() { "plotOptions", "series", "tooltip" };
            var value = new Hashtable();
            value.Add(param, paramValue);

            chart.PlotOptions.Series.Tooltip.DateTimeLabelFormats = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetHashtablePropertyString("dateTimeLabelFormats", param, paramValue)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - hashtable shouldn't be rendered if it's empty
        //[Fact]
        //public void Test_IfTooltipDateTimeLabelFormatsDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Series.Tooltip.DateTimeLabelFormats = defaultValue;

        //    Assert.DoesNotContain($"dateTimeLabelFormats", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(10)]
        public void Test_IfTooltipDistanceRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "tooltip" };

            chart.PlotOptions.Series.Tooltip.Distance = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("distance", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipDistanceDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 16;

            chart.PlotOptions.Series.Tooltip.Distance = defaultValue;

            Assert.DoesNotContain($"distance", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipFollowPointerRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "tooltip" };
            var value = true;

            chart.PlotOptions.Series.Tooltip.FollowPointer = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("followPointer", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default should be false (not null)
        //[Fact]
        //public void Test_IfTooltipFollowPointerDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = false;

        //    chart.PlotOptions.Series.Tooltip.FollowPointer = defaultValue;

        //    Assert.DoesNotContain($"followPointer", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfTooltipFollowTouchMoveRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "tooltip" };
            var value = false;

            chart.PlotOptions.Series.Tooltip.FollowTouchMove = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("followTouchMove", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default should be true (not null)
        //[Fact]
        //public void Test_IfTooltipFollowTouchMoveDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Series.Tooltip.FollowTouchMove = defaultValue;

        //    Assert.DoesNotContain($"followTouchMove", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("</table>")]
        public void Test_IfTooltipFooterFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "tooltip" };

            chart.PlotOptions.Series.Tooltip.FooterFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("footerFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipFooterFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Tooltip.FooterFormat = defaultValue;

            Assert.DoesNotContain($"footerFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("<table><tr><th colspan='2'>{point.key}</th></tr>")]
        public void Test_IfTooltipHeaderFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "tooltip" };

            chart.PlotOptions.Series.Tooltip.HeaderFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("headerFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipHeaderFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Tooltip.HeaderFormat = defaultValue;

            Assert.DoesNotContain($"headerFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{series.name}: <b>{point.y}</b><br/>")]
        public void Test_IfTooltipNullFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "tooltip" };

            chart.PlotOptions.Series.Tooltip.NullFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("nullFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipNullFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Tooltip.NullFormat = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfTooltipNullFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "tooltip" };

            chart.PlotOptions.Series.Tooltip.NullFormatter = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("nullFormatter", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipNullFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Tooltip.NullFormatter = defaultValue;

            Assert.DoesNotContain($"nullFormatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{series.name}: <b>{point.y}</b><br/>")]
        public void Test_IfTooltipPointFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "tooltip" };

            chart.PlotOptions.Series.Tooltip.PointFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("pointFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipPointFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Tooltip.PointFormat = defaultValue;

            Assert.DoesNotContain($"pointFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfTooltipPointFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "tooltip" };

            chart.PlotOptions.Series.Tooltip.PointFormatter = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("pointFormatter", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipPointFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Tooltip.PointFormatter = defaultValue;

            Assert.DoesNotContain($"pointFormatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfTooltipValueDecimalsRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "tooltip" };

            chart.PlotOptions.Series.Tooltip.ValueDecimals = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("valueDecimals", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipValueDecimalsDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Series.Tooltip.ValueDecimals = defaultValue;

            Assert.DoesNotContain($"valueDecimals", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("$")]
        public void Test_IfTooltipValuePrefixRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "tooltip" };

            chart.PlotOptions.Series.Tooltip.ValuePrefix = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("valuePrefix", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipValuePrefixDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Tooltip.ValuePrefix = defaultValue;

            Assert.DoesNotContain($"valuePrefix", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(" USD")]
        public void Test_IfTooltipValueSuffixRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "tooltip" };

            chart.PlotOptions.Series.Tooltip.ValueSuffix = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("valueSuffix", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipValueSuffixDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Tooltip.ValueSuffix = defaultValue;

            Assert.DoesNotContain($"valueSuffix", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("%Y-%m-%d")]
        public void Test_IfTooltipXDateFormatRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "tooltip" };

            chart.PlotOptions.Series.Tooltip.XDateFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("xDateFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipXDateFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Series.Tooltip.XDateFormat = defaultValue;

            Assert.DoesNotContain($"xDateFormat", renderer.RenderHtml());
        }
        #endregion

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfTurboThresholdTrackingRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);

            chart.PlotOptions.Series.TurboThreshold = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"turboThreshold\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTurboThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = 1000;

            chart.PlotOptions.Series.TurboThreshold = defaultValue;

            Assert.DoesNotContain($"turboThreshold", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            bool value = false;

            chart.PlotOptions.Series.Visible = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"visible\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Series.Visible = defaultValue;

            Assert.DoesNotContain($"visible", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZoneAxisRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var value = "x";

            chart.PlotOptions.Series.ZoneAxis = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"zoneAxis\":\"{chart.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZoneAxisDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = "y";

            chart.PlotOptions.Series.ZoneAxis = defaultValue;

            Assert.DoesNotContain($"zoneAxis", renderer.RenderHtml());
        }

        #region zones

        [Theory]
        [InlineData("CSSClassName")]
        public void Test_IfZonesClassNameRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "zones" };
            var zoneDef = new List<PlotOptionsSeriesZone> { new PlotOptionsSeriesZone { ClassName = value } };

            chart.PlotOptions.Series.Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("className", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesClassNameDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;
            var zoneDef = new List<PlotOptionsSeriesZone> { new PlotOptionsSeriesZone { ClassName = defaultValue } };

            chart.PlotOptions.Series.Zones = zoneDef;

            Assert.DoesNotContain($"className", renderer.RenderHtml());
        }


        //fix required - color exists only as a string (should be also gradient and pattern)
        [Theory]
        [InlineData("#0022ff")]
        public void Test_IfZonesColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "zones" };
            var zoneDef = new List<PlotOptionsSeriesZone> { new PlotOptionsSeriesZone { Color = value } };

            chart.PlotOptions.Series.Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("color", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = string.Empty;
            var zoneDef = new List<PlotOptionsSeriesZone> { new PlotOptionsSeriesZone { Color = defaultValue } };

            chart.PlotOptions.Series.Zones = zoneDef;

            Assert.DoesNotContain($"color", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsSeriesZonesDashStyle.Dash)]
        [InlineData(PlotOptionsSeriesZonesDashStyle.DashDot)]
        [InlineData(PlotOptionsSeriesZonesDashStyle.Dot)]
        [InlineData(PlotOptionsSeriesZonesDashStyle.LongDash)]
        [InlineData(PlotOptionsSeriesZonesDashStyle.LongDashDot)]
        [InlineData(PlotOptionsSeriesZonesDashStyle.LongDashDotDot)]
        [InlineData(PlotOptionsSeriesZonesDashStyle.ShortDash)]
        [InlineData(PlotOptionsSeriesZonesDashStyle.ShortDashDot)]
        [InlineData(PlotOptionsSeriesZonesDashStyle.ShortDashDotDot)]
        [InlineData(PlotOptionsSeriesZonesDashStyle.ShortDot)]
        [InlineData(PlotOptionsSeriesZonesDashStyle.Solid)]
        public void Test_IfZonesDashStyleRenders_Correct(PlotOptionsSeriesZonesDashStyle value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "zones" };
            var zoneDef = new List<PlotOptionsSeriesZone> { new PlotOptionsSeriesZone { DashStyle = value } };

            chart.PlotOptions.Series.Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetEnumPropertyString(chart, "dashStyle", value.ToString())}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesDashStyleDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var defaultValue = PlotOptionsSeriesZonesDashStyle.Null;
            var zoneDef = new List<PlotOptionsSeriesZone> { new PlotOptionsSeriesZone { DashStyle = defaultValue } };

            chart.PlotOptions.Series.Zones = zoneDef;

            Assert.DoesNotContain($"dashStyle", renderer.RenderHtml());
        }

        //fix required - color exists only as a string (should be also gradient and pattern)
        [Theory]
        [InlineData("#0022ff")]
        public void Test_IfZonesFillColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "zones" };
            var zoneDef = new List<PlotOptionsSeriesZone> { new PlotOptionsSeriesZone { FillColor = value } };

            chart.PlotOptions.Series.Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("fillColor", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default value for fillColor should be string.Empty (not null) 
        //[Fact]
        //public void Test_IfZonesFillColorDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highcharts(); chart.Chart = new Chart();
        //    var renderer = new HighchartsRenderer(chart);
        //    var defaultValue = string.Empty;
        //    var zoneDef = new List<PlotOptionsSeriesZone> { new PlotOptionsSeriesZone { FillColor = defaultValue } };

        //    chart.PlotOptions.Series.Zones = zoneDef;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(5000)]
        public void Test_IfZonesValueRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "series", "zones" };
            var zoneDef = new List<PlotOptionsSeriesZone> { new PlotOptionsSeriesZone { Value = value } };

            chart.PlotOptions.Series.Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("value", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            double? defaultValue = null;
            var zoneDef = new List<PlotOptionsSeriesZone> { new PlotOptionsSeriesZone { Value = defaultValue } };

            chart.PlotOptions.Series.Zones = zoneDef;

            Assert.DoesNotContain($"value", renderer.RenderHtml());
        }

        #endregion
    }
}

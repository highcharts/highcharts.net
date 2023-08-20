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

namespace HS.PlotOptions
{
    public class PlotOptionsAreaTests : IClassFixture<HsFixture>
    {
        protected HsFixture _fixture;

        public PlotOptionsAreaTests(HsFixture fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Area;
        }

        #region Acessibility

        [Theory]
        [InlineData("Description")]
        public void Test_IfAccessibilityDescriptionRenders_Correct(string description)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Accessibility.Description = description;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"description\":\"{description}\"}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityEnabledRenders_Correct(bool enabled)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Accessibility.Enabled = enabled;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"enabled\":{enabled.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }


        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityExposeAsGroupOnlyRenders_Correct(bool exposeAsGroupOnly)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Accessibility.ExposeAsGroupOnly = exposeAsGroupOnly;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"exposeAsGroupOnly\":{exposeAsGroupOnly.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        #region KeyboardNavigation

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityKeyboardNavigationEnabledRenders_Correct(bool enabled)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Accessibility.KeyboardNavigation.Enabled = enabled;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"keyboardNavigation\":{{\"enabled\":{enabled.ToString().ToLower()}}}}}}}}}", renderer.RenderHtml());
        }

        #endregion

        #region Point

        [Theory]
        [InlineData("%Y-%m-%d %H:%M:%S")]
        public void Test_IfAccessibilityPointDateFormatRenders_Correct(string format)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Accessibility.Point.DateFormat = format;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"dateFormat\":\"{format}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("DateFormatterFunction")]
        public void Test_IfAccessibilityPointDateFormatterRenders_Correct(string function)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Accessibility.Point.DateFormatter = function;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"dateFormatter\":{function}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(false)]
        public void Test_IfAccessibilityPointDescribeNullSetOnFalseRenders_Correct(bool describeNull)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);



            chart.PlotOptions.Area.Accessibility.Point.DescribeNull = describeNull;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"describeNull\":{describeNull.ToString().ToLower()}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        public void Test_IfAccessibilityPointDescribeNullSetOnTrueRenders_Correct(bool describeNull)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Accessibility.Point.DescribeNull = describeNull;

            Assert.DoesNotContain($"describeNull", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("FormatterFunction")]
        public void Test_IfAccessibilityPointDescriptionFormatterRenders_Correct(string function)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Accessibility.Point.DescriptionFormatter = function;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"descriptionFormatter\":{function}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(3)]
        public void Test_IfAccessibilityPointValueDecimalsRenders_Correct(int decimals)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Accessibility.Point.ValueDecimals = decimals;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valueDecimals\":{decimals}.0}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{Description}{separator}{value}")]
        public void Test_IfAccessibilityPointValueDescriptionFormatRenders_Correct(string format)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Accessibility.Point.ValueDescriptionFormat = format;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valueDescriptionFormat\":\"{format}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomePrefix")]
        public void Test_IfAccessibilityPointValuePrefixRenders_Correct(string prefix)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Accessibility.Point.ValuePrefix = prefix;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valuePrefix\":\"{prefix}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeSuffix")]
        public void Test_IfAccessibilityPointValueSufixRenders_Correct(string suffix)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Accessibility.Point.ValueSuffix = suffix;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valueSuffix\":\"{suffix}\"}}}}}}}}", renderer.RenderHtml());
        }
        #endregion

        #endregion

        [Fact]
        public void Test_IfAllowPointSelectRenders_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var enabled = true;

            chart.PlotOptions.Area.AllowPointSelect = enabled;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"allowPointSelect\":{enabled.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAllowPointSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.AllowPointSelect = false;

            Assert.DoesNotContain("allowPointSelect", renderer.RenderHtml());
        }

        #region Animation

        [Fact]
        public void Test_IfAnimationEnabledRenders_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var value = false;

            chart.PlotOptions.Area.AnimationBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAnimationEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Area.AnimationBool = value;

            Assert.DoesNotContain("animation", renderer.RenderHtml());
        }

        //fix required - shows up with backslash
        //[Theory]
        //[InlineData(1000)]
        //public void Test_IfAnimationDurationRenders_Correct(int duration)
        //{
        //    var chart = new Highstock();
        //    chart.Chart.Type = _fixture.ChartType;
        //    var renderer = new HighstockRenderer(chart);

        //    chart.PlotOptions.Area.Animation.Duration = duration;

        //    Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{{\"duration\":{duration}}}}}}}", renderer.RenderHtml());
        //}

        //fix required - shows up with backslash
        //[Theory]
        //[InlineData("easingFunctionName")]
        //public void Test_IfAnimationEasingRenders_Correct(string easing)
        //{
        //    var chart = new Highstock();
        //    chart.Chart.Type = _fixture.ChartType;
        //    var renderer = new HighstockRenderer(chart);

        //    chart.PlotOptions.Area.Animation.Easing = easing;

        //    Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{{\"easing\":\"{easing}\"}}}}}}", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(250)]
        public void Test_IfAnimationLimitRenders_Correct(int limit)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.AnimationLimit = limit;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animationLimit\":{limit}.0}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsAreaBoostBlending.Add)]
        [InlineData(PlotOptionsAreaBoostBlending.Darken)]
        [InlineData(PlotOptionsAreaBoostBlending.Multiply)]
        public void Test_IfBoostBlendingRenders_Correct(PlotOptionsAreaBoostBlending boostBlending)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.BoostBlending = boostBlending;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"boostBlending\":\"{boostBlending.ToString().ToLower()}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfBoostBlendingDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.BoostBlending = PlotOptionsAreaBoostBlending.Undefined;

            Assert.DoesNotContain($"\"boostBlending\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2000)]
        public void Test_IfBoostThresholdRenders_Correct(int limit)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.BoostThreshold = limit;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"boostThreshold\":{limit}.0}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfBoostThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 5000;

            chart.PlotOptions.Area.BoostThreshold = defaultValue;

            Assert.DoesNotContain("boostThreshold", renderer.RenderHtml());
        }

        //missing borderColor
        //missing borderWidth

        [Theory]
        [InlineData("ClassName")]
        public void Test_IfClassNameRenders_Correct(string className)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.ClassName = className;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"className\":\"{className}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipRenders_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var value = false;

            chart.PlotOptions.Area.Clip = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"clip\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Area.Clip = value;

            Assert.DoesNotContain("clip", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#ffffff")]
        public void Test_IfColorRenders_Correct(string color)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Color = color;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"color\":\"{color.ToString().ToLower()}\"}}}}", renderer.RenderHtml());
        }

        //missing logic for GradientColorObject and PatternObject

        [Theory]
        [InlineData(1)]
        public void Test_IfColorIndexRenders_Correct(int value)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.ColorIndex = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"colorIndex\":{value}.0}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("colorValue")]
        public void Test_IfColorKeyRenders_Correct(string value)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.ColorKey = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"colorKey\":\"{value}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfConnectNullsRenders_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Area.ConnectNulls = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"connectNulls\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfConnectNullsDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var value = false;

            chart.PlotOptions.Area.ConnectNulls = value;

            Assert.DoesNotContain($"\"connectNulls\"", renderer.RenderHtml());
        }



        [Fact]
        public void Test_IfCrispRenders_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var value = false;

            chart.PlotOptions.Area.Crisp = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"crisp\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCrispDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Area.Crisp = value;

            Assert.DoesNotContain($"\"crisp\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(299)]
        public void Test_IfCropThresholdRenders_Correct(int value)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.CropThreshold = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"cropThreshold\":{value}.0}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCropThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 300;

            chart.PlotOptions.Area.CropThreshold = defaultValue;

            Assert.DoesNotContain($"\"crisp\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsAreaCursor.Default)]
        [InlineData(PlotOptionsAreaCursor.Help)]
        [InlineData(PlotOptionsAreaCursor.Pointer)]
        [InlineData(PlotOptionsAreaCursor.None)]
        public void Test_IfCursorRenders_Correct(PlotOptionsAreaCursor cursor)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Cursor = cursor;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"cursor\":\"{cursor.ToString().ToLower()}\"}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("dataKey1", "dataValue1")]
        public void Test_IfCustomRenders_Correct(string key1, string value1)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var extraData = new Hashtable() { { key1, value1 } };

            chart.PlotOptions.Area.Custom = extraData;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"custom\":{{\"{key1}\":\"{value1}\"}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsAreaDashStyle.Dash)]
        [InlineData(PlotOptionsAreaDashStyle.DashDot)]
        [InlineData(PlotOptionsAreaDashStyle.Dot)]
        [InlineData(PlotOptionsAreaDashStyle.LongDash)]
        [InlineData(PlotOptionsAreaDashStyle.LongDashDot)]
        [InlineData(PlotOptionsAreaDashStyle.LongDashDotDot)]
        [InlineData(PlotOptionsAreaDashStyle.ShortDash)]
        [InlineData(PlotOptionsAreaDashStyle.ShortDashDot)]
        [InlineData(PlotOptionsAreaDashStyle.ShortDashDotDot)]
        [InlineData(PlotOptionsAreaDashStyle.ShortDot)]
        public void Test_IfDashStyleRenders_Correct(PlotOptionsAreaDashStyle style)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var result = style.ToString();
            var replacement = result[0].ToString().ToLower();
            result = result.Remove(0, 1);
            result = replacement + result;

            chart.PlotOptions.Area.DashStyle = style;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dashStyle\":\"{result}\"}}}}", renderer.RenderHtml());
        }


        #region databaLabels

        //fix required - missing dataLabels as a list of objects (right now it is possible to have only one object)

        [Theory]
        [InlineData(PlotOptionsAreaDataLabelsAlign.Left)]
        [InlineData(PlotOptionsAreaDataLabelsAlign.Right)]
        public void Test_IfDataLabelsAlignRenders_Correct(PlotOptionsAreaDataLabelsAlign align)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.Align = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"align\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = PlotOptionsAreaDataLabelsAlign.Center;

            chart.PlotOptions.Area.DataLabels.Align = defaultValue;

            Assert.DoesNotContain($"align", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAllowOverlapRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Area.DataLabels.AllowOverlap = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"allowOverlap\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAllowOverlapDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Area.DataLabels.AllowOverlap = defaultValue;

            Assert.DoesNotContain($"allowOverlap", renderer.RenderHtml());
        }

        #region Animation

        

        #endregion

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsBackgroundColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.BackgroundColor = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"backgroundColor\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBackgroundColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.DataLabels.BackgroundColor = defaultValue;

            Assert.DoesNotContain($"backgroundColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsBorderColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.BorderColor = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"borderColor\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.DataLabels.BorderColor = defaultValue;

            Assert.DoesNotContain($"borderColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsBorderRadiusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.BorderRadius = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"borderRadius\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Area.DataLabels.BorderRadius = defaultValue;

            Assert.DoesNotContain($"borderRadius", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsBorderWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.BorderWidth = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"borderWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Area.DataLabels.BorderWidth = defaultValue;

            Assert.DoesNotContain($"borderWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("classA")]
        [InlineData("classB")]
        public void Test_IfDataLabelsClassNameRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.ClassName = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"className\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsClassNameDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.DataLabels.ClassName = defaultValue;

            Assert.DoesNotContain($"className", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.Color = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"color\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.DataLabels.Color = defaultValue;

            Assert.DoesNotContain($"color", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsCropRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = false;

            chart.PlotOptions.Area.DataLabels.Crop = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"crop\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsCropDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Area.DataLabels.Crop = defaultValue;

            Assert.DoesNotContain($"crop", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsDeferBoolRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = false;

            chart.PlotOptions.Area.DataLabels.Defer = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"defer\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsDeferBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Area.DataLabels.Defer = defaultValue;

            Assert.DoesNotContain($"defer", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsEnabledBoolRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Area.DataLabels.Enabled = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"enabled\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsEnabledBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Area.DataLabels.Enabled = defaultValue;

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
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.Filter.Operator = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"filter\":{{\"operator\":\"{value}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterOperatorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.DataLabels.Filter.Operator = defaultValue;

            Assert.DoesNotContain($"operator", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("percentage")]
        [InlineData("y")]
        public void Test_IfDataLabelsFilterPropertyRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.Filter.Property = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"filter\":{{\"property\":\"{value}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterPropertyDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.DataLabels.Filter.Property = defaultValue;

            Assert.DoesNotContain($"property", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsFilterValueRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.Filter.Value = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"filter\":{{\"value\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Area.DataLabels.Filter.Value = defaultValue;

            Assert.DoesNotContain($"value", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("{y} mm")]
        [InlineData("<{x},{y}>")]
        public void Test_IfDataLabelsFormatRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.Format = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"format\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = "point.value";

            chart.PlotOptions.Area.DataLabels.Format = defaultValue;

            Assert.DoesNotContain($"format", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfDataLabelsFormatterRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.Formatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"formatter\":{value}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.DataLabels.Formatter = defaultValue;

            Assert.DoesNotContain($"formatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataLabelsInsideRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.Inside = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"inside\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsInsideDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Area.DataLabels.Inside = defaultValue;

            Assert.DoesNotContain($"inside", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataLabelsNullFormatBoolRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.NullFormatBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"nullFormat\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Area.DataLabels.NullFormatBool = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{y} mm")]
        [InlineData("<{x},{y}>")]
        public void Test_IfDataLabelsNullFormatRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.NullFormat = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"nullFormat\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.DataLabels.NullFormat = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfDataLabelsNullFormatterRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.NullFormatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"nullFormatter\":{value}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.DataLabels.NullFormatter = defaultValue;

            Assert.DoesNotContain($"nullFormatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsAreaDataLabelsOverflow.Allow)]
        public void Test_IfDataLabelsOverflowRenders_Correct(PlotOptionsAreaDataLabelsOverflow align)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.Overflow = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"overflow\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsOverflowDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = PlotOptionsAreaDataLabelsOverflow.Justify;

            chart.PlotOptions.Area.DataLabels.Overflow = defaultValue;

            Assert.DoesNotContain($"overflow", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(50)]
        public void Test_IfDataLabelsPaddingRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.Padding = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"padding\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsPaddingDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 5;

            chart.PlotOptions.Area.DataLabels.Padding = defaultValue;

            Assert.DoesNotContain($"padding", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsAreaDataLabelsPosition.Left)]
        [InlineData(PlotOptionsAreaDataLabelsPosition.Right)]
        public void Test_IfDataLabelsPositionRenders_Correct(PlotOptionsAreaDataLabelsPosition align)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.Position = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"position\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsPositionDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = PlotOptionsAreaDataLabelsPosition.Center;

            chart.PlotOptions.Area.DataLabels.Position = defaultValue;

            Assert.DoesNotContain($"position", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(90)]
        [InlineData(180)]
        public void Test_IfDataLabelsRotationRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.Rotation = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"rotation\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsRotationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Area.DataLabels.Rotation = defaultValue;

            Assert.DoesNotContain($"rotation", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsShadowBoolRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = true;

            chart.PlotOptions.Area.DataLabels.ShadowBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"shadow\":{chart.FirstCharacterToLower(value.ToString())}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#00ffdd", 10, 20, 30, 40)]
        [InlineData("#ffccaa", 40, 30, 20, 10)]
        public void Test_IfDataLabelsShadowRenders_Correct(string color, int offsetX, int offsetY, double opacity, int width)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.Shadow = new Shadow()
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
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Area.DataLabels.ShadowBool = defaultValue;

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
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.Shape = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"shape\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsShapeDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = "square";

            chart.PlotOptions.Area.DataLabels.Shape = defaultValue;

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
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "dataLabels", "style" };
            var style = new Hashtable();
            style.Add(param1, param1_value);

            chart.PlotOptions.Area.DataLabels.Style = style;

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
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "dataLabels", "style" };
            var style = new Hashtable();
            style.Add(param1, param1_value);

            chart.PlotOptions.Area.DataLabels.Style = style;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString(param1, param1_value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        #region textPath

        //missing textPath.attributes - fix and set as hashtable

        [Theory]
        [InlineData(true)]
        public void Test_IfDataLabelsTextPathEnabledRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "dataLabels", "textPath" };

            chart.PlotOptions.Area.DataLabels.TextPath.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsTextPathEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = false;

            chart.PlotOptions.Area.DataLabels.TextPath.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        #endregion

        [Fact]
        public void Test_IfDataLabelsUseHTMLRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Area.DataLabels.UseHTML = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"useHTML\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsUseHTMLDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Area.DataLabels.UseHTML = defaultValue;

            Assert.DoesNotContain($"useHTML", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsAreaDataLabelsVerticalAlign.Middle)]
        [InlineData(PlotOptionsAreaDataLabelsVerticalAlign.Top)]
        public void Test_IfDataLabelsVerticalAlignRenders_Correct(PlotOptionsAreaDataLabelsVerticalAlign align)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.VerticalAlign = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"verticalAlign\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsVerticalAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = PlotOptionsAreaDataLabelsVerticalAlign.Bottom;

            chart.PlotOptions.Area.DataLabels.VerticalAlign = defaultValue;

            Assert.DoesNotContain($"verticalAlign", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsXRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.X = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"x\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsXDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Area.DataLabels.X = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"x\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsYRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.Y = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"y\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsYDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Area.DataLabels.Y = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"y\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsZRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.DataLabels.ZIndex = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"zIndex\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsZDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 6;

            chart.PlotOptions.Area.DataLabels.ZIndex = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"zIndex\":", renderer.RenderHtml());
        }

        #endregion

        #region dataSorting

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataSortingEnabledRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "dataSorting" };

            chart.PlotOptions.Area.DataSorting.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataSortingEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Area.DataSorting.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataSortingMatchByNameRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "dataSorting" };

            chart.PlotOptions.Area.DataSorting.MatchByName = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("matchByName", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataSortingMatchByNameDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Area.DataSorting.MatchByName = defaultValue;

            Assert.DoesNotContain($"matchByName", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("x")]
        [InlineData("z")]
        public void Test_IfDataSortingSortKeyRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "dataSorting" };

            chart.PlotOptions.Area.DataSorting.SortKey = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("sortKey", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataSortingSortKeyDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = "y";

            chart.PlotOptions.Area.DataSorting.SortKey = defaultValue;

            Assert.DoesNotContain($"sortKey", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("SomePlotOptionsDescription")]
        public void Test_IfDescriptionRenders_Correct(string description)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Description = description;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"description\":\"{description}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = false;

            chart.PlotOptions.Area.EnableMouseTracking = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"enableMouseTracking\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Area.EnableMouseTracking = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"enableMouseTracking\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        #region events

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsAfterAnimateRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "events" };

            chart.PlotOptions.Area.Events.AfterAnimate = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("afterAnimate", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsAfterAnimateDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Events.AfterAnimate = defaultValue;

            Assert.DoesNotContain($"afterAnimate", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsCheckboxClickRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "events" };

            chart.PlotOptions.Area.Events.CheckboxClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("checkboxClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsCheckboxClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Events.CheckboxClick = defaultValue;

            Assert.DoesNotContain($"checkboxClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsClickRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "events" };

            chart.PlotOptions.Area.Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsclickDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsHideRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "events" };

            chart.PlotOptions.Area.Events.Hide = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("hide", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsHideDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Events.Hide = defaultValue;

            Assert.DoesNotContain($"hide", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsLegendItemClickRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "events" };

            chart.PlotOptions.Area.Events.LegendItemClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("legendItemClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsLegendItemClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Events.LegendItemClick = defaultValue;

            Assert.DoesNotContain($"legendItemClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "events" };

            chart.PlotOptions.Area.Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "events" };

            chart.PlotOptions.Area.Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsShowRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "events" };

            chart.PlotOptions.Area.Events.Show = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("show", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsShowDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Events.Show = defaultValue;

            Assert.DoesNotContain($"show", renderer.RenderHtml());
        }

        #endregion


        [Fact]
        public void Test_IfFindNearestPointByRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = PlotOptionsAreaFindNearestPointBy.Xy;

            chart.PlotOptions.Area.FindNearestPointBy = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"findNearestPointBy\":\"{value.ToString().ToLower()}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfFindNearestPointByDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = PlotOptionsAreaFindNearestPointBy.X;

            chart.PlotOptions.Area.FindNearestPointBy = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"findNearestPointBy\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfGetExtremesFromAllRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Area.GetExtremesFromAll = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"getExtremesFromAll\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfGetExtremesFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = false;

            chart.PlotOptions.Area.GetExtremesFromAll = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"getExtremesFromAll\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfIncludeInDataExportFromAllRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.IncludeInDataExport = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"includeInDataExport\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfIncludeInDataExportFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? value = null;

            chart.PlotOptions.Area.IncludeInDataExport = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"includeInDataExport\":{value}}}}}", renderer.RenderHtml());
        }

        #region label

        //missing boxesToAvoid

        [Fact]
        public void Test_IfLabelConnectorAllowedRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "label" };
            var value = true;

            chart.PlotOptions.Area.Label.ConnectorAllowed = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorAllowed", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorAllowedDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Area.Label.ConnectorAllowed = defaultValue;

            Assert.DoesNotContain($"connectorAllowed", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(30)]
        public void Test_IfLabelConnectorNeighbourDistanceRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "label" };

            chart.PlotOptions.Area.Label.ConnectorNeighbourDistance = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorNeighbourDistance", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorNeighbourDistanceDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 24;

            chart.PlotOptions.Area.Label.ConnectorNeighbourDistance = defaultValue;

            Assert.DoesNotContain($"connectorNeighbourDistance", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "label" };
            var value = false;

            chart.PlotOptions.Area.Label.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Area.Label.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFormat")]
        public void Test_IfLabelFormatRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "label" };

            chart.PlotOptions.Area.Label.Format = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("format", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        /// <summary>
        /// Fix default value for Format
        /// </summary>
        /// <param name="value"></param>
        //[Fact]
        //public void Test_IfLabelFormatDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Area.Label.Format = defaultValue;

        //    Assert.DoesNotContain($"format", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("SomeFormatterFunction")]
        public void Test_IfLabelFormatterRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "label" };

            chart.PlotOptions.Area.Label.Formatter = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("formatter", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Label.Formatter = defaultValue;

            Assert.DoesNotContain($"formatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMaxFontSizeRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "label" };

            chart.PlotOptions.Area.Label.MaxFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("maxFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMaxFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Area.Label.MaxFontSize = defaultValue;

            Assert.DoesNotContain($"maxFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMinFontSizeRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "label" };

            chart.PlotOptions.Area.Label.MinFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("minFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMinFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Area.Label.MinFontSize = defaultValue;

            Assert.DoesNotContain($"minFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfLabelOnAreaRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "label" };

            chart.PlotOptions.Area.Label.OnArea = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("onArea", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelOnAreaDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Area.Label.OnArea = defaultValue;

            Assert.DoesNotContain($"onArea", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("fontWeight", "bold")]
        public void Test_IfLabelStyleRenders_Correct(string paramName, string paramValue)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "label" };
            var value = new Hashtable();
            value.Add(paramName, paramValue);


            chart.PlotOptions.Area.Label.Style = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetHashtablePropertyString("style", paramName, paramValue)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        /// <summary>
        /// Fix default value for style - empty hashtable should be not rendered
        /// </summary>
        /// <param name="value"></param>
        //[Fact]
        //public void Test_IfLabelStyleDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Area.Label.Style = defaultValue;

        //    Assert.DoesNotContain($"style", renderer.RenderHtml());
        //}



        #endregion


        //fix required - Linecap should be enum (not string)
        //[Theory]
        //[InlineData(PlotOptionsAreaLinecap.Square)]
        ////missing PlotOptionsAreaLinecap.Butt ?
        //public void Test_IfLinecapRenders_Correct(PlotOptionsAreaLinecap value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);

        //    chart.PlotOptions.Area.Linecap = value;

        //    Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linecap\":\"{chart.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfLinecapDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = PlotOptionsAreaLinecap.Round;

        //    chart.PlotOptions.Area.Linecap = defaultValue;

        //    Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linecap\":{defaultValue.ToString().ToLower()}}}}}", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.LineWidth = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"lineWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Area.LineWidth = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"lineWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", defaultValue)}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(":previous")]
        [InlineData("IdAnotherSeries")]
        public void Test_IfLinkedToRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.LinkedTo = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linkedTo\":\"{value}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLinkedToDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            string defaultValue = String.Empty;

            chart.PlotOptions.Area.LinkedTo = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linkedTo\":{defaultValue}}}}}", renderer.RenderHtml());
        }

        #region marker

        [Theory]
        [InlineData(true)]
        public void Test_IfMarkerEnabledRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "marker" };

            chart.PlotOptions.Area.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = false;

            chart.PlotOptions.Area.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "marker" };

            chart.PlotOptions.Area.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double defaultValue = 2;

            chart.PlotOptions.Area.Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "marker" };

            chart.PlotOptions.Area.Marker.FillColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("fillColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        /// <summary>
        /// fix that color - should be a string, patternObject and GradientObject
        /// </summary>
        /// <param name="value"></param>
        //[Fact]
        //public void Test_IfMarkerFillColorDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Area.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "marker" };

            chart.PlotOptions.Area.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Area.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "marker" };

            chart.PlotOptions.Area.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = "#ffffff";

            chart.PlotOptions.Area.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "marker" };

            chart.PlotOptions.Area.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Area.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "marker" };

            chart.PlotOptions.Area.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 2;

            chart.PlotOptions.Area.Marker.Radius = defaultValue;

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
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "marker" };

            chart.PlotOptions.Area.Marker.Symbol = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("symbol", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerSymbolDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Marker.Symbol = defaultValue;

            Assert.DoesNotContain($"symbol", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(1000)]
        public void Test_IfMarkerWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "marker" };

            chart.PlotOptions.Area.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Area.Marker.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("#FF0000")]
        [InlineData("#0088FF")]
        public void Test_IfNegativeColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.NegativeColor = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"negativeColor\":\"{value}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfNegativeColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            string defaultValue = String.Empty;

            chart.PlotOptions.Area.NegativeColor = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"negativeColor\":{defaultValue}}}}}", renderer.RenderHtml());
        }

        #region onPoint

        //fix dashStyle - should be string instead of hashtable
        //[Theory]
        //[InlineData("dot")]
        //public void Test_IfOnPointConnectorOptionsDashStyleRenders_Correct(string value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "area", "onPoint", "connectorOptions" };

        //    chart.PlotOptions.Area.OnPoint.ConnectorOptions.Dashstyle = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dashstyle", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfOnPointConnectorOptionsDashStyleDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Area.DataLabels.Color = defaultValue;

        //    Assert.DoesNotContain($"color", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("red")]
        public void Test_IfOnPointConnectorOptionsStrokeRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "onPoint", "connectorOptions" };

            chart.PlotOptions.Area.OnPoint.ConnectorOptions.Stroke = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("stroke", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsStrokeDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.OnPoint.ConnectorOptions.Stroke = defaultValue;

            Assert.DoesNotContain($"stroke", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointConnectorOptionsWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "onPoint", "connectorOptions" };

            chart.PlotOptions.Area.OnPoint.ConnectorOptions.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Area.OnPoint.ConnectorOptions.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("pointId")]
        public void Test_IfOnPointIdRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "onPoint" };

            chart.PlotOptions.Area.OnPoint.Id = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("id", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointIdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.OnPoint.Id = defaultValue;

            Assert.DoesNotContain($"\"id\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetXRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "onPoint", "position" };

            chart.PlotOptions.Area.OnPoint.Position.OffsetX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetXDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Area.OnPoint.Position.OffsetX = defaultValue;

            Assert.DoesNotContain($"offsetX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetYRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "onPoint", "position" };

            chart.PlotOptions.Area.OnPoint.Position.OffsetY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetYDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Area.OnPoint.Position.OffsetY = defaultValue;

            Assert.DoesNotContain($"offsetY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionXRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "onPoint", "position" };

            chart.PlotOptions.Area.OnPoint.Position.X = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("x", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointXDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Area.OnPoint.Position.X = defaultValue;

            Assert.DoesNotContain($"\"x\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionYRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "onPoint", "position" };

            chart.PlotOptions.Area.OnPoint.Position.Y = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("y", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointYDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Area.OnPoint.Position.Y = defaultValue;

            Assert.DoesNotContain($"\"y\":", renderer.RenderHtml());
        }

        #endregion


        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfOpacityRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Opacity = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOpacityDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Area.Opacity = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", defaultValue)}}}}}", renderer.RenderHtml());
        }

        #region point

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsClickRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "point", "events" };

            chart.PlotOptions.Area.Point.Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Point.Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "point", "events" };

            chart.PlotOptions.Area.Point.Events.Drag = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drag", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Point.Events.Drag = defaultValue;

            Assert.DoesNotContain($"drag", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragStartRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "point", "events" };

            chart.PlotOptions.Area.Point.Events.DragStart = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("dragStart", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragStartDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Point.Events.DragStart = defaultValue;

            Assert.DoesNotContain($"dragStart", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDropRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "point", "events" };

            chart.PlotOptions.Area.Point.Events.Drop = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drop", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDropDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Point.Events.Drop = defaultValue;

            Assert.DoesNotContain($"drop", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "point", "events" };

            chart.PlotOptions.Area.Point.Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Point.Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "point", "events" };

            chart.PlotOptions.Area.Point.Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Point.Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsRemoveRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "point", "events" };

            chart.PlotOptions.Area.Point.Events.Remove = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("remove", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsRemoveDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Point.Events.Remove = defaultValue;

            Assert.DoesNotContain($"remove", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsSelectRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "point", "events" };

            chart.PlotOptions.Area.Point.Events.Select = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("select", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Point.Events.Select = defaultValue;

            Assert.DoesNotContain($"select", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUnselectRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "point", "events" };

            chart.PlotOptions.Area.Point.Events.Unselect = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("unselect", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUnselectDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Point.Events.Unselect = defaultValue;

            Assert.DoesNotContain($"unselect", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUpdateRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "point", "events" };

            chart.PlotOptions.Area.Point.Events.Update = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("update", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUpdateDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.Point.Events.Update = defaultValue;

            Assert.DoesNotContain($"update", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointDescriptionFormatterRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.PointDescriptionFormatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"pointDescriptionFormatter\":{value}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointDescriptionFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Area.PointDescriptionFormatter = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"pointDescriptionFormatter\":{defaultValue}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = true;

            chart.PlotOptions.Area.RelativeXValue = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"relativeXValue\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Area.RelativeXValue = defaultValue;

            Assert.DoesNotContain($"relativeXValue", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = true;

            chart.PlotOptions.Area.Selected = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"selected\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Area.Selected = defaultValue;

            Assert.DoesNotContain($"selected", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShadowBoolRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = true;

            chart.PlotOptions.Area.ShadowBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"shadow\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#00ffdd", 10, 20, 30, 40)]
        [InlineData("#ffccaa", 40, 30, 20, 10)]
        public void Test_IfShadowRenders_Correct(string color, int offsetX, int offsetY, double opacity, int width)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Shadow = new Shadow()
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
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Area.ShadowBool = defaultValue;

            Assert.DoesNotContain($"shadow", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowCheckboxRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = true;

            chart.PlotOptions.Area.ShowCheckbox = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"showCheckbox\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowCheckboxDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Area.ShowCheckbox = defaultValue;

            Assert.DoesNotContain($"showCheckbox", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfShowInLegendRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.ShowInLegend = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"showInLegend\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowInLegendDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.ShowInLegend = null;

            Assert.DoesNotContain($"showInLegend", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfSkipKeyboardNavigationRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.SkipKeyboardNavigation = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"skipKeyboardNavigation\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSkipKeyboardNavigationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.SkipKeyboardNavigation = null;

            Assert.DoesNotContain($"skipKeyboardNavigation", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSoftThresholdRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = false;

            chart.PlotOptions.Area.SoftThreshold = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"softThreshold\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSoftThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Area.SoftThreshold = defaultValue;

            Assert.DoesNotContain($"softThreshold", renderer.RenderHtml());
        }

        #region states

        #region hover

        #region animation
        //fix required - shows up with backslash
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesHoverAnimationDurationRenders_Correct(int value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "area", "states", "hover", "animation" };

        //    chart.PlotOptions.Area.States.Hover.Animation.Duration = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfStatesHoverAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Area.States.Hover.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesHoverEnabledRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "states", "hover" };
            var value = false;

            chart.PlotOptions.Area.States.Hover.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesHoverEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Area.States.Hover.Enabled = defaultValue;

        //    Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        //}

        #region halo

        // fix required - attributes should be hashtable (not object)
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesHoverHaloAttributesRenders_Correct(int value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "area", "states", "hover", "halo" };

        //    chart.PlotOptions.Area.States.Hover.Halo.Attributes = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("attributes", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfStatesHoverHaloAttributesDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Area.States.Hover.Animation.Duration = defaultValue;

        //    Assert.DoesNotContain($"duration", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(2)]
        [InlineData(0.5)]
        public void Test_IfStatesHoverHaloOpacityRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "states", "hover", "halo" };

            chart.PlotOptions.Area.States.Hover.Halo.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default value for opacity = 0.25 (not null)
        //[Fact]
        //public void Test_IfStatesHoverHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Area.States.Hover.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Theory]
        //[InlineData(2)]
        //[InlineData(0.5)]
        //public void Test_IfStatesHoverHaloSizeRenders_Correct(double value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "area", "states", "hover", "halo" };

        //    chart.PlotOptions.Area.States.Hover.Halo.Size = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("size", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Fact]
        //public void Test_IfStatesHoverHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Area.States.Hover.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesHoverLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "states", "hover" };

            chart.PlotOptions.Area.States.Hover.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Area.States.Hover.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesHoverLineWidthPlusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "states", "hover" };

            chart.PlotOptions.Area.States.Hover.LineWidthPlus = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidthPlus", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default should be 1 (not null)
        //[Fact]
        //public void Test_IfStatesHoverLineWidthPlusDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    double? defaultValue = 1;

        //    chart.PlotOptions.Area.States.Hover.LineWidthPlus = defaultValue;

        //    Assert.DoesNotContain($"lineWidthPlus", renderer.RenderHtml());
        //}

        #region marker

        [Theory]
        [InlineData(true)]
        public void Test_IfStatesHoverMarkerEnabledRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "hover", "marker" };

            chart.PlotOptions.Area.States.Hover.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = false;

            chart.PlotOptions.Area.States.Hover.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesHoverMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "hover", "marker" };

            chart.PlotOptions.Area.States.Hover.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double defaultValue = 2;

            chart.PlotOptions.Area.States.Hover.Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfStatesHoverMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "hover", "marker" };

            chart.PlotOptions.Area.States.Hover.Marker.FillColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("fillColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        /// <summary>
        /// fix that color - should be a string, patternObject and GradientObject
        /// </summary>
        /// <param name="value"></param>
        //[Fact]
        //public void Test_IfStatesHoverMarkerFillColorDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Area.States.Hover.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesHoverMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "hover", "marker" };

            chart.PlotOptions.Area.States.Hover.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Area.States.Hover.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfStatesHoverMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "hover", "marker" };

            chart.PlotOptions.Area.States.Hover.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesHoverMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = "#ffffff";

            chart.PlotOptions.Area.States.Hover.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesHoverMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "hover", "marker" };

            chart.PlotOptions.Area.States.Hover.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesHoverMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Area.States.Hover.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesHoverMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "hover", "marker" };

            chart.PlotOptions.Area.States.Hover.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesHoverMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 2;

            chart.PlotOptions.Area.States.Hover.Marker.Radius = defaultValue;

            Assert.DoesNotContain($"radius", renderer.RenderHtml());
        }

        //missing States

        [Theory]
        [InlineData(5)]
        [InlineData(1000)]
        public void Test_IfStatesHoverMarkerWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "hover", "marker" };

            chart.PlotOptions.Area.States.Hover.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Area.States.Hover.Marker.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        #endregion

        #endregion

        #region inactive

        #region animation
        //fix required - shows up with backslash
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesInactiveAnimationDurationRenders_Correct(int value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "area", "states", "inactive", "animation" };

        //    chart.PlotOptions.Area.States.Inactive.Animation.Duration = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfStatesInactiveAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Area.States.Inactive.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesInactiveEnabledRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "states", "inactive" };
            var value = false;

            chart.PlotOptions.Area.States.Inactive.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesInactiveEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Area.States.Inactive.Enabled = defaultValue;

        //    Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(0.5)]
        public void Test_IfStatesInactiveOpacityRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "states", "inactive" };

            chart.PlotOptions.Area.States.Inactive.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default value should be 0.2 (not null)
        //[Fact]
        //public void Test_IfStatesInactiveOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = 0.2;

        //    chart.PlotOptions.Area.States.Inactive.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        #region normal
        //fix required - shows up with backslash
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesNormalAnimationDurationRenders_Correct(int value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "area", "states", "normal", "animation" };

        //    chart.PlotOptions.Area.States.Normal.Animation.Duration = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfStatesNormalAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Area.States.Normal.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }

        //fix required - missing ..States.Normal.AnimationBool 

        #endregion

        #region select

        #region animation
        //fix required - shows up with backslash
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesSelectAnimationDurationRenders_Correct(int value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "area", "states", "select", "animation" };

        //    chart.PlotOptions.Area.States.Select.Animation.Duration = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfStatesSelectAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Area.States.Select.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesSelectEnabledRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "states", "select" };
            var value = false;

            chart.PlotOptions.Area.States.Select.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesSelectEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Area.States.Select.Enabled = defaultValue;

        //    Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        //}

        #region halo

        // fix required - attributes should be hashtable (not object)
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesSelectHaloAttributesRenders_Correct(int value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "area", "states", "select", "halo" };

        //    chart.PlotOptions.Area.States.Select.Halo.Attributes = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("attributes", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfStatesSelectHaloAttributesDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Area.States.Select.Animation.Duration = defaultValue;

        //    Assert.DoesNotContain($"duration", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(2)]
        [InlineData(0.5)]
        public void Test_IfStatesSelectHaloOpacityRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "states", "select", "halo" };

            chart.PlotOptions.Area.States.Select.Halo.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default value for opacity = 0.25 (not null)
        //[Fact]
        //public void Test_IfStatesSelectHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Area.States.Select.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Theory]
        //[InlineData(2)]
        //[InlineData(0.5)]
        //public void Test_IfStatesSelectHaloSizeRenders_Correct(double value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var pathToProperty = new List<string>() { "plotOptions", "area", "states", "select", "halo" };

        //    chart.PlotOptions.Area.States.Select.Halo.Size = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("size", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Fact]
        //public void Test_IfStatesSelectHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Area.States.Select.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesSelectLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "states", "select" };

            chart.PlotOptions.Area.States.Select.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Area.States.Select.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesSelectLineWidthPlusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "states", "select" };

            chart.PlotOptions.Area.States.Select.LineWidthPlus = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidthPlus", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default should be 1 (not null)
        //[Fact]
        //public void Test_IfStatesSelectLineWidthPlusDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    double? defaultValue = 1;

        //    chart.PlotOptions.Area.States.Select.LineWidthPlus = defaultValue;

        //    Assert.DoesNotContain($"lineWidthPlus", renderer.RenderHtml());
        //}

        #region marker

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfStatesSelectMarkerEnabledRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "select", "marker" };

            chart.PlotOptions.Area.States.Select.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Area.States.Select.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesSelectMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "select", "marker" };

            chart.PlotOptions.Area.States.Select.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double defaultValue = 2;

            chart.PlotOptions.Area.States.Select.Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfStatesSelectMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "select", "marker" };

            chart.PlotOptions.Area.States.Select.Marker.FillColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("fillColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        /// <summary>
        /// fix that color - should be a string, patternObject and GradientObject
        /// </summary>
        /// <param name="value"></param>
        //[Fact]
        //public void Test_IfStatesSelectMarkerFillColorDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Area.States.Select.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesSelectMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "select", "marker" };

            chart.PlotOptions.Area.States.Select.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Area.States.Select.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfStatesSelectMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "select", "marker" };

            chart.PlotOptions.Area.States.Select.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = "#ffffff";

            chart.PlotOptions.Area.States.Select.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesSelectMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "select", "marker" };

            chart.PlotOptions.Area.States.Select.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Area.States.Select.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesSelectMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "select", "marker" };

            chart.PlotOptions.Area.States.Select.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 4;

            chart.PlotOptions.Area.States.Select.Marker.Radius = defaultValue;

            Assert.DoesNotContain($"radius", renderer.RenderHtml());
        }

        //missing States

        [Theory]
        [InlineData(5)]
        [InlineData(1000)]
        public void Test_IfStatesSelectMarkerWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "area", "states", "select", "marker" };

            chart.PlotOptions.Area.States.Select.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Area.States.Select.Marker.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        #endregion

        #endregion

        #endregion


        [Theory]
        [InlineData(PlotOptionsAreaStep.Center)]
        [InlineData(PlotOptionsAreaStep.Left)]
        [InlineData(PlotOptionsAreaStep.Right)]
        public void Test_IfStepRenders_Correct(PlotOptionsAreaStep value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Step = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"step\":\"{chart.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStepDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = PlotOptionsAreaStep.Null;

            chart.PlotOptions.Area.Step = defaultValue;

            Assert.DoesNotContain($"step", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = false;

            chart.PlotOptions.Area.StickyTracking = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"stickyTracking\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Area.StickyTracking = defaultValue;

            Assert.DoesNotContain($"stickyTracking", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfThresholdRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.Threshold = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"threshold\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Area.Threshold = defaultValue;

            Assert.DoesNotContain($"threshold", renderer.RenderHtml());
        }

        #region tooltip

        [Theory]
        [InlineData(5)]
        public void Test_IfTooltipValueDecimalsRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "tooltip" };

            chart.PlotOptions.Area.Tooltip.ValueDecimals = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("valueDecimals", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - incorrect default value
        //[Fact]
        //public void Test_IfTooltipValueDecimalsDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    double? defaultValue = 4;

        //    chart.PlotOptions.Area.Tooltip.ValueDecimals = defaultValue;

        //    Assert.DoesNotContain($"valueDecimals", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfTurboThresholdTrackingRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Area.TurboThreshold = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"turboThreshold\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTurboThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 1000;

            chart.PlotOptions.Area.TurboThreshold = defaultValue;

            Assert.DoesNotContain($"turboThreshold", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = false;

            chart.PlotOptions.Area.Visible = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"visible\":{chart.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Area.Visible = defaultValue;

            Assert.DoesNotContain($"visible", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZoneAxisRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = "x";

            chart.PlotOptions.Area.ZoneAxis = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"zoneAxis\":\"{chart.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZoneAxisDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = "y";

            chart.PlotOptions.Area.ZoneAxis = defaultValue;

            Assert.DoesNotContain($"zoneAxis", renderer.RenderHtml());
        }

        #region zones

        [Theory]
        [InlineData("CSSClassName")]
        public void Test_IfZonesClassNameRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "zones" };
            var zoneDef = new List<PlotOptionsAreaZones> { new PlotOptionsAreaZones { ClassName = value } };

            chart.PlotOptions.Area.Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("className", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesClassNameDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;
            var zoneDef = new List<PlotOptionsAreaZones> { new PlotOptionsAreaZones { ClassName = defaultValue } };

            chart.PlotOptions.Area.Zones = zoneDef;

            Assert.DoesNotContain($"className", renderer.RenderHtml());
        }


        //fix required - color exists only as a string (should be also gradient and pattern)
        [Theory]
        [InlineData("#0022ff")]
        public void Test_IfZonesColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "zones" };
            var zoneDef = new List<PlotOptionsAreaZones> { new PlotOptionsAreaZones { Color = value } };

            chart.PlotOptions.Area.Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("color", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;
            var zoneDef = new List<PlotOptionsAreaZones> { new PlotOptionsAreaZones { Color = defaultValue } };

            chart.PlotOptions.Area.Zones = zoneDef;

            Assert.DoesNotContain($"color", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsAreaZonesDashStyle.Dash)]
        [InlineData(PlotOptionsAreaZonesDashStyle.DashDot)]
        [InlineData(PlotOptionsAreaZonesDashStyle.Dot)]
        [InlineData(PlotOptionsAreaZonesDashStyle.LongDash)]
        [InlineData(PlotOptionsAreaZonesDashStyle.LongDashDot)]
        [InlineData(PlotOptionsAreaZonesDashStyle.LongDashDotDot)]
        [InlineData(PlotOptionsAreaZonesDashStyle.ShortDash)]
        [InlineData(PlotOptionsAreaZonesDashStyle.ShortDashDot)]
        [InlineData(PlotOptionsAreaZonesDashStyle.ShortDashDotDot)]
        [InlineData(PlotOptionsAreaZonesDashStyle.ShortDot)]
        [InlineData(PlotOptionsAreaZonesDashStyle.Solid)]
        public void Test_IfZonesDashStyleRenders_Correct(PlotOptionsAreaZonesDashStyle value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "zones" };
            var zoneDef = new List<PlotOptionsAreaZones> { new PlotOptionsAreaZones { DashStyle = value } };

            chart.PlotOptions.Area.Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetEnumPropertyString(chart, "dashStyle", value.ToString())}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesDashStyleDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = PlotOptionsAreaZonesDashStyle.Null;
            var zoneDef = new List<PlotOptionsAreaZones> { new PlotOptionsAreaZones { DashStyle = defaultValue } };

            chart.PlotOptions.Area.Zones = zoneDef;

            Assert.DoesNotContain($"dashStyle", renderer.RenderHtml());
        }

        //fix required - color exists only as a string (should be also gradient and pattern)
        [Theory]
        [InlineData("#0022ff")]
        public void Test_IfZonesFillColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "zones" };
            var zoneDef = new List<PlotOptionsAreaZones> { new PlotOptionsAreaZones { FillColor = value } };

            chart.PlotOptions.Area.Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("fillColor", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default value for fillColor should be string.Empty (not null) 
        //[Fact]
        //public void Test_IfZonesFillColorDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = string.Empty;
        //    var zoneDef = new List<PlotOptionsAreaZones> { new PlotOptionsAreaZones { FillColor = defaultValue } };

        //    chart.PlotOptions.Area.Zones = zoneDef;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(5000)]
        public void Test_IfZonesValueRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "area", "zones" };
            var zoneDef = new List<PlotOptionsAreaZones> { new PlotOptionsAreaZones { Value = value } };

            chart.PlotOptions.Area.Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("value", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;
            var zoneDef = new List<PlotOptionsAreaZones> { new PlotOptionsAreaZones { Value = defaultValue } };

            chart.PlotOptions.Area.Zones = zoneDef;

            Assert.DoesNotContain($"value", renderer.RenderHtml());
        }

        #endregion
    }
}

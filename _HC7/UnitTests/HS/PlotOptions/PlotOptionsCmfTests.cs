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
    public class PlotOptionsCmfTests : IClassFixture<HsFixture>
    {
        protected HsFixture _fixture;

        public PlotOptionsCmfTests(HsFixture fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Cmf;
        }

        #region Acessibility

        [Theory]
        [InlineData("Description")]
        public void Test_IfAccessibilityDescriptionRenders_Correct(string description)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.Accessibility.Description = description;

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

            chart.PlotOptions.Cmf.Accessibility.Enabled = enabled;

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

            chart.PlotOptions.Cmf.Accessibility.ExposeAsGroupOnly = exposeAsGroupOnly;

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

            chart.PlotOptions.Cmf.Accessibility.KeyboardNavigation.Enabled = enabled;

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

            chart.PlotOptions.Cmf.Accessibility.Point.DateFormat = format;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"dateFormat\":\"{format}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("DateFormatterFunction")]
        public void Test_IfAccessibilityPointDateFormatterRenders_Correct(string function)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.Accessibility.Point.DateFormatter = function;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"dateFormatter\":{function}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(false)]
        public void Test_IfAccessibilityPointDescribeNullSetOnFalseRenders_Correct(bool describeNull)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);



            chart.PlotOptions.Cmf.Accessibility.Point.DescribeNull = describeNull;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"describeNull\":{describeNull.ToString().ToLower()}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        public void Test_IfAccessibilityPointDescribeNullSetOnTrueRenders_Correct(bool describeNull)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.Accessibility.Point.DescribeNull = describeNull;

            Assert.DoesNotContain($"describeNull", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("FormatterFunction")]
        public void Test_IfAccessibilityPointDescriptionFormatterRenders_Correct(string function)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.Accessibility.Point.DescriptionFormatter = function;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"descriptionFormatter\":{function}}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(3)]
        public void Test_IfAccessibilityPointValueDecimalsRenders_Correct(int decimals)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.Accessibility.Point.ValueDecimals = decimals;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valueDecimals\":{decimals}.0}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{Description}{separator}{value}")]
        public void Test_IfAccessibilityPointValueDescriptionFormatRenders_Correct(string format)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.Accessibility.Point.ValueDescriptionFormat = format;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valueDescriptionFormat\":\"{format}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomePrefix")]
        public void Test_IfAccessibilityPointValuePrefixRenders_Correct(string prefix)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.Accessibility.Point.ValuePrefix = prefix;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"accessibility\":{{\"point\":{{\"valuePrefix\":\"{prefix}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeSuffix")]
        public void Test_IfAccessibilityPointValueSufixRenders_Correct(string suffix)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.Accessibility.Point.ValueSuffix = suffix;

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

            chart.PlotOptions.Cmf.AllowPointSelect = enabled;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"allowPointSelect\":{enabled.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAllowPointSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.AllowPointSelect = false;

            Assert.DoesNotContain("allowPointSelect", renderer.RenderHtml());
        }

        #region Animation

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfAnimationEnabledRenders_Correct(bool enabled)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.AnimationBool = enabled;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{enabled.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        //fix required - shows up with backslash
        //[Theory]
        //[InlineData(1000)]
        //public void Test_IfAnimationDurationRenders_Correct(int duration)
        //{
        //    var chart = new Highstock();
        //    chart.Chart.Type = _fixture.ChartType;
        //    var renderer = new HighstockRenderer(chart);

        //    chart.PlotOptions.Cmf.Animation.Duration = duration;

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

        //    chart.PlotOptions.Cmf.Animation.Easing = easing;

        //    Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"animation\":{{\"easing\":\"{easing}\"}}}}}}", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(PlotOptionsCmfBoostBlending.Add)]
        [InlineData(PlotOptionsCmfBoostBlending.Darken)]
        [InlineData(PlotOptionsCmfBoostBlending.Multiply)]
        public void Test_IfBoostBlendingRenders_Correct(PlotOptionsCmfBoostBlending boostBlending)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.BoostBlending = boostBlending;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"boostBlending\":\"{boostBlending.ToString().ToLower()}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfBoostBlendingDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.BoostBlending = PlotOptionsCmfBoostBlending.Undefined;

            Assert.DoesNotContain($"\"boostBlending\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2000)]
        public void Test_IfBoostThresholdRenders_Correct(int limit)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.BoostThreshold = limit;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"boostThreshold\":{limit}.0}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfBoostThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 5000;

            chart.PlotOptions.Cmf.BoostThreshold = defaultValue;

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

            chart.PlotOptions.Cmf.ClassName = className;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"className\":\"{className}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipRenders_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var value = false;

            chart.PlotOptions.Cmf.Clip = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"clip\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Cmf.Clip = value;

            Assert.DoesNotContain("clip", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#ffffff")]
        public void Test_IfColorRenders_Correct(string color)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.Color = color;

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

            chart.PlotOptions.Cmf.ColorIndex = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"colorIndex\":{value}.0}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("colorValue")]
        public void Test_IfColorKeyRenders_Correct(string value)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.ColorKey = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"colorKey\":\"{value}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfConnectNullsRenders_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Cmf.ConnectNulls = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"connectNulls\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfConnectNullsDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var value = false;

            chart.PlotOptions.Cmf.ConnectNulls = value;

            Assert.DoesNotContain($"\"connectNulls\"", renderer.RenderHtml());
        }



        [Fact]
        public void Test_IfCrispRenders_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var value = false;

            chart.PlotOptions.Cmf.Crisp = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"crisp\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCrispDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Cmf.Crisp = value;

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

            chart.PlotOptions.Cmf.CropThreshold = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"cropThreshold\":{value}.0}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCropThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 300;

            chart.PlotOptions.Cmf.CropThreshold = defaultValue;

            Assert.DoesNotContain($"\"crisp\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsCmfCursor.Default)]
        [InlineData(PlotOptionsCmfCursor.Help)]
        [InlineData(PlotOptionsCmfCursor.Pointer)]
        [InlineData(PlotOptionsCmfCursor.None)]
        public void Test_IfCursorRenders_Correct(PlotOptionsCmfCursor cursor)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.Cursor = cursor;

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

            chart.PlotOptions.Cmf.Custom = extraData;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"custom\":{{\"{key1}\":\"{value1}\"}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsCmfDashStyle.Dash)]
        [InlineData(PlotOptionsCmfDashStyle.DashDot)]
        [InlineData(PlotOptionsCmfDashStyle.Dot)]
        [InlineData(PlotOptionsCmfDashStyle.LongDash)]
        [InlineData(PlotOptionsCmfDashStyle.LongDashDot)]
        [InlineData(PlotOptionsCmfDashStyle.LongDashDotDot)]
        [InlineData(PlotOptionsCmfDashStyle.ShortDash)]
        [InlineData(PlotOptionsCmfDashStyle.ShortDashDot)]
        [InlineData(PlotOptionsCmfDashStyle.ShortDashDotDot)]
        [InlineData(PlotOptionsCmfDashStyle.ShortDot)]
        public void Test_IfDashStyleRenders_Correct(PlotOptionsCmfDashStyle style)
        {
            var chart = new Highstock();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighstockRenderer(chart);
            var result = style.ToString();
            var replacement = result[0].ToString().ToLower();
            result = result.Remove(0, 1);
            result = replacement + result;

            chart.PlotOptions.Cmf.DashStyle = style;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dashStyle\":\"{result}\"}}}}", renderer.RenderHtml());
        }


        #region databaLabels

        //fix required - missing dataLabels as a list of objects (right now it is possible to have only one object)

        [Theory]
        [InlineData(PlotOptionsCmfDataLabelsAlign.Left)]
        [InlineData(PlotOptionsCmfDataLabelsAlign.Right)]
        public void Test_IfDataLabelsAlignRenders_Correct(PlotOptionsCmfDataLabelsAlign align)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.Align = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"align\":\"{Highstock.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = PlotOptionsCmfDataLabelsAlign.Center;

            chart.PlotOptions.Cmf.DataLabels.Align = defaultValue;

            Assert.DoesNotContain($"align", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAllowOverlapRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Cmf.DataLabels.AllowOverlap = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"allowOverlap\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAllowOverlapDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Cmf.DataLabels.AllowOverlap = defaultValue;

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

            chart.PlotOptions.Cmf.DataLabels.BackgroundColor = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"backgroundColor\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBackgroundColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.DataLabels.BackgroundColor = defaultValue;

            Assert.DoesNotContain($"backgroundColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsBorderColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.BorderColor = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"borderColor\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.DataLabels.BorderColor = defaultValue;

            Assert.DoesNotContain($"borderColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsBorderRadiusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.BorderRadius = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"borderRadius\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Cmf.DataLabels.BorderRadius = defaultValue;

            Assert.DoesNotContain($"borderRadius", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsBorderWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.BorderWidth = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"borderWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Cmf.DataLabels.BorderWidth = defaultValue;

            Assert.DoesNotContain($"borderWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("classA")]
        [InlineData("classB")]
        public void Test_IfDataLabelsClassNameRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.ClassName = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"className\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsClassNameDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.DataLabels.ClassName = defaultValue;

            Assert.DoesNotContain($"className", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.Color = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"color\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.DataLabels.Color = defaultValue;

            Assert.DoesNotContain($"color", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsCropRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = false;

            chart.PlotOptions.Cmf.DataLabels.Crop = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"crop\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsCropDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Cmf.DataLabels.Crop = defaultValue;

            Assert.DoesNotContain($"crop", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsDeferBoolRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = false;

            chart.PlotOptions.Cmf.DataLabels.DeferBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"defer\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsDeferBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Cmf.DataLabels.DeferBool = defaultValue;

            Assert.DoesNotContain($"defer", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2000)]
        [InlineData(5000)]
        public void Test_IfDataLabelsDeferRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.Defer = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"defer\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsEnabledBoolRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Cmf.DataLabels.Enabled = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"enabled\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsEnabledBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Cmf.DataLabels.Enabled = defaultValue;

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

            chart.PlotOptions.Cmf.DataLabels.Filter.Operator = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"filter\":{{\"operator\":\"{value}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterOperatorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.DataLabels.Filter.Operator = defaultValue;

            Assert.DoesNotContain($"operator", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("percentage")]
        [InlineData("y")]
        public void Test_IfDataLabelsFilterPropertyRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.Filter.Property = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"filter\":{{\"property\":\"{value}\"}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterPropertyDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.DataLabels.Filter.Property = defaultValue;

            Assert.DoesNotContain($"property", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsFilterValueRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.Filter.Value = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"filter\":{{\"value\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Cmf.DataLabels.Filter.Value = defaultValue;

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

            chart.PlotOptions.Cmf.DataLabels.Format = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"format\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = "point.value";

            chart.PlotOptions.Cmf.DataLabels.Format = defaultValue;

            Assert.DoesNotContain($"format", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfDataLabelsFormatterRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.Formatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"formatter\":{value}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.DataLabels.Formatter = defaultValue;

            Assert.DoesNotContain($"formatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataLabelsInsideRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.Inside = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"inside\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsInsideDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Cmf.DataLabels.Inside = defaultValue;

            Assert.DoesNotContain($"inside", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataLabelsNullFormatBoolRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.NullFormatBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"nullFormat\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Cmf.DataLabels.NullFormatBool = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{y} mm")]
        [InlineData("<{x},{y}>")]
        public void Test_IfDataLabelsNullFormatRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.NullFormat = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"nullFormat\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.DataLabels.NullFormat = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfDataLabelsNullFormatterRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.NullFormatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"nullFormatter\":{value}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.DataLabels.NullFormatter = defaultValue;

            Assert.DoesNotContain($"nullFormatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsCmfDataLabelsOverflow.Allow)]
        public void Test_IfDataLabelsOverflowRenders_Correct(PlotOptionsCmfDataLabelsOverflow align)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.Overflow = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"overflow\":\"{Highstock.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsOverflowDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = PlotOptionsCmfDataLabelsOverflow.Justify;

            chart.PlotOptions.Cmf.DataLabels.Overflow = defaultValue;

            Assert.DoesNotContain($"overflow", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(50)]
        public void Test_IfDataLabelsPaddingRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.Padding = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"padding\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsPaddingDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 5;

            chart.PlotOptions.Cmf.DataLabels.Padding = defaultValue;

            Assert.DoesNotContain($"padding", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsCmfDataLabelsPosition.Left)]
        [InlineData(PlotOptionsCmfDataLabelsPosition.Right)]
        public void Test_IfDataLabelsPositionRenders_Correct(PlotOptionsCmfDataLabelsPosition align)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.Position = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"position\":\"{Highstock.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsPositionDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = PlotOptionsCmfDataLabelsPosition.Center;

            chart.PlotOptions.Cmf.DataLabels.Position = defaultValue;

            Assert.DoesNotContain($"position", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(90)]
        [InlineData(180)]
        public void Test_IfDataLabelsRotationRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.Rotation = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"rotation\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsRotationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Cmf.DataLabels.Rotation = defaultValue;

            Assert.DoesNotContain($"rotation", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsShadowBoolRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = true;

            chart.PlotOptions.Cmf.DataLabels.ShadowBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"shadow\":{Highstock.FirstCharacterToLower(value.ToString())}}}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#00ffdd", 10, 20, 30, 40)]
        [InlineData("#ffccaa", 40, 30, 20, 10)]
        public void Test_IfDataLabelsShadowRenders_Correct(string color, int offsetX, int offsetY, double opacity, int width)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.Shadow = new Shadow()
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

            chart.PlotOptions.Cmf.DataLabels.ShadowBool = defaultValue;

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

            chart.PlotOptions.Cmf.DataLabels.Shape = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"shape\":\"{value}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsShapeDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = "square";

            chart.PlotOptions.Cmf.DataLabels.Shape = defaultValue;

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
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "dataLabels", "style" };
            var style = new Hashtable();
            style.Add(param1, param1_value);

            chart.PlotOptions.Cmf.DataLabels.Style = style;

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
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "dataLabels", "style" };
            var style = new Hashtable();
            style.Add(param1, param1_value);

            chart.PlotOptions.Cmf.DataLabels.Style = style;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString(param1, param1_value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        #region textPath

        //missing textPath.attributes - fix and set as hashtable

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataLabelsTextPathEnabledRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "dataLabels", "textPath" };

            chart.PlotOptions.Cmf.DataLabels.TextPath.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsTextPathEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Cmf.DataLabels.TextPath.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        #endregion

        [Fact]
        public void Test_IfDataLabelsUseHTMLRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Cmf.DataLabels.UseHTML = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"useHTML\":{value.ToString().ToLower()}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsUseHTMLDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Cmf.DataLabels.UseHTML = defaultValue;

            Assert.DoesNotContain($"useHTML", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsCmfDataLabelsVerticalAlign.Middle)]
        [InlineData(PlotOptionsCmfDataLabelsVerticalAlign.Top)]
        public void Test_IfDataLabelsVerticalAlignRenders_Correct(PlotOptionsCmfDataLabelsVerticalAlign align)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.VerticalAlign = align;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"verticalAlign\":\"{Highstock.FirstCharacterToLower(align.ToString())}\"}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsVerticalAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = PlotOptionsCmfDataLabelsVerticalAlign.Bottom;

            chart.PlotOptions.Cmf.DataLabels.VerticalAlign = defaultValue;

            Assert.DoesNotContain($"verticalAlign", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsXRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.X = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"x\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsXDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Cmf.DataLabels.X = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"x\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsYRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.Y = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"y\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsYDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Cmf.DataLabels.Y = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"y\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsZRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.DataLabels.Z = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"dataLabels\":{{\"z\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsZDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 6;

            chart.PlotOptions.Cmf.DataLabels.Z = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"z\":", renderer.RenderHtml());
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
            var pathToProperty = new List<string> { "plotOptions", "cmf", "dataSorting" };

            chart.PlotOptions.Cmf.DataSorting.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataSortingEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Cmf.DataSorting.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataSortingMatchByNameRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "dataSorting" };

            chart.PlotOptions.Cmf.DataSorting.MatchByName = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("matchByName", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataSortingMatchByNameDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Cmf.DataSorting.MatchByName = defaultValue;

            Assert.DoesNotContain($"matchByName", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("x")]
        [InlineData("z")]
        public void Test_IfDataSortingSortKeyRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "dataSorting" };

            chart.PlotOptions.Cmf.DataSorting.SortKey = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("sortKey", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataSortingSortKeyDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = "y";

            chart.PlotOptions.Cmf.DataSorting.SortKey = defaultValue;

            Assert.DoesNotContain($"sortKey", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("SomePlotOptionsDescription")]
        public void Test_IfDescriptionRenders_Correct(string description)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.Description = description;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"description\":\"{description}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = false;

            chart.PlotOptions.Cmf.EnableMouseTracking = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"enableMouseTracking\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Cmf.EnableMouseTracking = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"enableMouseTracking\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        #region events

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsAfterAnimateRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "events" };

            chart.PlotOptions.Cmf.Events.AfterAnimate = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("afterAnimate", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsAfterAnimateDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Events.AfterAnimate = defaultValue;

            Assert.DoesNotContain($"afterAnimate", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsCheckboxClickRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "events" };

            chart.PlotOptions.Cmf.Events.CheckboxClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("checkboxClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsCheckboxClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Events.CheckboxClick = defaultValue;

            Assert.DoesNotContain($"checkboxClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsClickRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "events" };

            chart.PlotOptions.Cmf.Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsclickDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsHideRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "events" };

            chart.PlotOptions.Cmf.Events.Hide = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("hide", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsHideDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Events.Hide = defaultValue;

            Assert.DoesNotContain($"hide", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsLegendItemClickRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "events" };

            chart.PlotOptions.Cmf.Events.LegendItemClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("legendItemClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsLegendItemClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Events.LegendItemClick = defaultValue;

            Assert.DoesNotContain($"legendItemClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "events" };

            chart.PlotOptions.Cmf.Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "events" };

            chart.PlotOptions.Cmf.Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsShowRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "events" };

            chart.PlotOptions.Cmf.Events.Show = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("show", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsShowDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Events.Show = defaultValue;

            Assert.DoesNotContain($"show", renderer.RenderHtml());
        }

        #endregion


        [Fact]
        public void Test_IfFindNearestPointByRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = PlotOptionsCmfFindNearestPointBy.Xy;

            chart.PlotOptions.Cmf.FindNearestPointBy = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"findNearestPointBy\":\"{value.ToString().ToLower()}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfFindNearestPointByDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = PlotOptionsCmfFindNearestPointBy.X;

            chart.PlotOptions.Cmf.FindNearestPointBy = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"findNearestPointBy\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfGetExtremesFromAllRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = true;

            chart.PlotOptions.Cmf.GetExtremesFromAll = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"getExtremesFromAll\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfGetExtremesFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = false;

            chart.PlotOptions.Cmf.GetExtremesFromAll = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"getExtremesFromAll\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfIncludeInDataExportFromAllRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.IncludeInDataExport = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"includeInDataExport\":{value.ToString().ToLower()}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfIncludeInDataExportFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? value = null;

            chart.PlotOptions.Cmf.IncludeInDataExport = value;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"includeInDataExport\":{value}}}}}", renderer.RenderHtml());
        }

        #region label

        //missing boxesToAvoid

        [Fact]
        public void Test_IfLabelConnectorAllowedRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "label" };
            var value = true;

            chart.PlotOptions.Cmf.Label.ConnectorAllowed = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorAllowed", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorAllowedDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Cmf.Label.ConnectorAllowed = defaultValue;

            Assert.DoesNotContain($"connectorAllowed", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(30)]
        public void Test_IfLabelConnectorNeighbourDistanceRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "label" };

            chart.PlotOptions.Cmf.Label.ConnectorNeighbourDistance = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorNeighbourDistance", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorNeighbourDistanceDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 24;

            chart.PlotOptions.Cmf.Label.ConnectorNeighbourDistance = defaultValue;

            Assert.DoesNotContain($"connectorNeighbourDistance", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "label" };
            var value = false;

            chart.PlotOptions.Cmf.Label.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Cmf.Label.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFormat")]
        public void Test_IfLabelFormatRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "label" };

            chart.PlotOptions.Cmf.Label.Format = value;

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

        //    chart.PlotOptions.Cmf.Label.Format = defaultValue;

        //    Assert.DoesNotContain($"format", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("SomeFormatterFunction")]
        public void Test_IfLabelFormatterRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "label" };

            chart.PlotOptions.Cmf.Label.Formatter = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("formatter", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Label.Formatter = defaultValue;

            Assert.DoesNotContain($"formatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMaxFontSizeRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "label" };

            chart.PlotOptions.Cmf.Label.MaxFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("maxFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMaxFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Cmf.Label.MaxFontSize = defaultValue;

            Assert.DoesNotContain($"maxFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMinFontSizeRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "label" };

            chart.PlotOptions.Cmf.Label.MinFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("minFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMinFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Cmf.Label.MinFontSize = defaultValue;

            Assert.DoesNotContain($"minFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfLabelOnAreaRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "label" };

            chart.PlotOptions.Cmf.Label.OnArea = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("onArea", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelOnAreaDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Cmf.Label.OnArea = defaultValue;

            Assert.DoesNotContain($"onArea", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("fontWeight", "bold")]
        public void Test_IfLabelStyleRenders_Correct(string paramName, string paramValue)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "label" };
            var value = new Hashtable();
            value.Add(paramName, paramValue);


            chart.PlotOptions.Cmf.Label.Style = value;

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

        //    chart.PlotOptions.Cmf.Label.Style = defaultValue;

        //    Assert.DoesNotContain($"style", renderer.RenderHtml());
        //}



        #endregion


        //fix required - Linecap should be enum (not string)
        //[Theory]
        //[InlineData(PlotOptionsCmfLinecap.Square)]
        ////missing PlotOptionsCmfLinecap.Butt ?
        //public void Test_IfLinecapRenders_Correct(PlotOptionsCmfLinecap value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);

        //    chart.PlotOptions.Cmf.Linecap = value;

        //    Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linecap\":\"{Highstock.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfLinecapDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = PlotOptionsCmfLinecap.Round;

        //    chart.PlotOptions.Cmf.Linecap = defaultValue;

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

            chart.PlotOptions.Cmf.LineWidth = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"lineWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 2;

            chart.PlotOptions.Cmf.LineWidth = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"lineWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", defaultValue)}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(":previous")]
        [InlineData("IdAnotherSeries")]
        public void Test_IfLinkedToRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.LinkedTo = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linkedTo\":\"{value}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLinkedToDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            string defaultValue = String.Empty;

            chart.PlotOptions.Cmf.LinkedTo = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"linkedTo\":{defaultValue}}}}}", renderer.RenderHtml());
        }

        #region marker

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfMarkerEnabledRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "marker" };

            chart.PlotOptions.Cmf.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Cmf.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "marker" };

            chart.PlotOptions.Cmf.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double defaultValue = 2;

            chart.PlotOptions.Cmf.Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "marker" };

            chart.PlotOptions.Cmf.Marker.FillColor = value;

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

        //    chart.PlotOptions.Cmf.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "marker" };

            chart.PlotOptions.Cmf.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Cmf.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "marker" };

            chart.PlotOptions.Cmf.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = "#ffffff";

            chart.PlotOptions.Cmf.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "marker" };

            chart.PlotOptions.Cmf.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Cmf.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "marker" };

            chart.PlotOptions.Cmf.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 4;

            chart.PlotOptions.Cmf.Marker.Radius = defaultValue;

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
            var pathToProperty = new List<string> { "plotOptions", "cmf", "marker" };

            chart.PlotOptions.Cmf.Marker.Symbol = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("symbol", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerSymbolDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Marker.Symbol = defaultValue;

            Assert.DoesNotContain($"symbol", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(1000)]
        public void Test_IfMarkerWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "marker" };

            chart.PlotOptions.Cmf.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Cmf.Marker.Width = defaultValue;

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

            chart.PlotOptions.Cmf.NegativeColor = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"negativeColor\":\"{value}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfNegativeColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            string defaultValue = String.Empty;

            chart.PlotOptions.Cmf.NegativeColor = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "cmf", "onPoint", "connectorOptions" };

        //    chart.PlotOptions.Cmf.OnPoint.ConnectorOptions.Dashstyle = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dashstyle", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfOnPointConnectorOptionsDashStyleDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = string.Empty;

        //    chart.PlotOptions.Cmf.DataLabels.Color = defaultValue;

        //    Assert.DoesNotContain($"color", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("red")]
        public void Test_IfOnPointConnectorOptionsStrokeRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "onPoint", "connectorOptions" };

            chart.PlotOptions.Cmf.OnPoint.ConnectorOptions.Stroke = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("stroke", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsStrokeDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.OnPoint.ConnectorOptions.Stroke = defaultValue;

            Assert.DoesNotContain($"stroke", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointConnectorOptionsWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "onPoint", "connectorOptions" };

            chart.PlotOptions.Cmf.OnPoint.ConnectorOptions.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Cmf.OnPoint.ConnectorOptions.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("pointId")]
        public void Test_IfOnPointIdRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "onPoint" };

            chart.PlotOptions.Cmf.OnPoint.Id = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("id", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointIdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.OnPoint.Id = defaultValue;

            Assert.DoesNotContain($"\"id\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetXRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "onPoint", "position" };

            chart.PlotOptions.Cmf.OnPoint.Position.OffsetX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetXDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Cmf.OnPoint.Position.OffsetX = defaultValue;

            Assert.DoesNotContain($"offsetX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetYRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "onPoint", "position" };

            chart.PlotOptions.Cmf.OnPoint.Position.OffsetY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetYDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Cmf.OnPoint.Position.OffsetY = defaultValue;

            Assert.DoesNotContain($"offsetY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionXRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "onPoint", "position" };

            chart.PlotOptions.Cmf.OnPoint.Position.X = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("x", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointXDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Cmf.OnPoint.Position.X = defaultValue;

            Assert.DoesNotContain($"\"x\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionYRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "onPoint", "position" };

            chart.PlotOptions.Cmf.OnPoint.Position.Y = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("y", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointYDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Cmf.OnPoint.Position.Y = defaultValue;

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

            chart.PlotOptions.Cmf.Opacity = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOpacityDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 1;

            chart.PlotOptions.Cmf.Opacity = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", defaultValue)}}}}}", renderer.RenderHtml());
        }

        #region point

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsClickRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "point", "events" };

            chart.PlotOptions.Cmf.Point.Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Point.Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "point", "events" };

            chart.PlotOptions.Cmf.Point.Events.Drag = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drag", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Point.Events.Drag = defaultValue;

            Assert.DoesNotContain($"drag", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragStartRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "point", "events" };

            chart.PlotOptions.Cmf.Point.Events.DragStart = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("dragStart", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragStartDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Point.Events.DragStart = defaultValue;

            Assert.DoesNotContain($"dragStart", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDropRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "point", "events" };

            chart.PlotOptions.Cmf.Point.Events.Drop = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drop", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDropDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Point.Events.Drop = defaultValue;

            Assert.DoesNotContain($"drop", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "point", "events" };

            chart.PlotOptions.Cmf.Point.Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Point.Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "point", "events" };

            chart.PlotOptions.Cmf.Point.Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Point.Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsRemoveRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "point", "events" };

            chart.PlotOptions.Cmf.Point.Events.Remove = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("remove", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsRemoveDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Point.Events.Remove = defaultValue;

            Assert.DoesNotContain($"remove", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsSelectRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "point", "events" };

            chart.PlotOptions.Cmf.Point.Events.Select = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("select", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Point.Events.Select = defaultValue;

            Assert.DoesNotContain($"select", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUnselectRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "point", "events" };

            chart.PlotOptions.Cmf.Point.Events.Unselect = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("unselect", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUnselectDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Point.Events.Unselect = defaultValue;

            Assert.DoesNotContain($"unselect", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUpdateRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "point", "events" };

            chart.PlotOptions.Cmf.Point.Events.Update = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("update", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUpdateDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.Point.Events.Update = defaultValue;

            Assert.DoesNotContain($"update", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointDescriptionFormatterRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.PointDescriptionFormatter = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"pointDescriptionFormatter\":{value}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointDescriptionFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;

            chart.PlotOptions.Cmf.PointDescriptionFormatter = defaultValue;

            Assert.DoesNotContain($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"pointDescriptionFormatter\":{defaultValue}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = true;

            chart.PlotOptions.Cmf.RelativeXValue = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"relativeXValue\":{Highstock.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Cmf.RelativeXValue = defaultValue;

            Assert.DoesNotContain($"relativeXValue", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = true;

            chart.PlotOptions.Cmf.Selected = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"selected\":{Highstock.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Cmf.Selected = defaultValue;

            Assert.DoesNotContain($"selected", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShadowBoolRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = true;

            chart.PlotOptions.Cmf.ShadowBool = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"shadow\":{Highstock.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#00ffdd", 10, 20, 30, 40)]
        [InlineData("#ffccaa", 40, 30, 20, 10)]
        public void Test_IfShadowRenders_Correct(string color, int offsetX, int offsetY, double opacity, int width)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.Shadow = new Shadow()
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

            chart.PlotOptions.Cmf.ShadowBool = defaultValue;

            Assert.DoesNotContain($"shadow", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowCheckboxRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = true;

            chart.PlotOptions.Cmf.ShowCheckbox = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"showCheckbox\":{Highstock.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowCheckboxDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = false;

            chart.PlotOptions.Cmf.ShowCheckbox = defaultValue;

            Assert.DoesNotContain($"showCheckbox", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfShowInLegendRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.ShowInLegend = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"showInLegend\":{Highstock.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowInLegendDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.ShowInLegend = null;

            Assert.DoesNotContain($"showInLegend", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfSkipKeyboardNavigationRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.SkipKeyboardNavigation = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"skipKeyboardNavigation\":{Highstock.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSkipKeyboardNavigationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.SkipKeyboardNavigation = null;

            Assert.DoesNotContain($"skipKeyboardNavigation", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSoftThresholdRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = false;

            chart.PlotOptions.Cmf.SoftThreshold = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"softThreshold\":{Highstock.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSoftThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Cmf.SoftThreshold = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "hover", "animation" };

        //    chart.PlotOptions.Cmf.States.Hover.Animation.Duration = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfStatesHoverAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Cmf.States.Hover.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesHoverEnabledRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "hover" };
            var value = false;

            chart.PlotOptions.Cmf.States.Hover.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesHoverEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Cmf.States.Hover.Enabled = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "hover", "halo" };

        //    chart.PlotOptions.Cmf.States.Hover.Halo.Attributes = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("attributes", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfStatesHoverHaloAttributesDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Cmf.States.Hover.Animation.Duration = defaultValue;

        //    Assert.DoesNotContain($"duration", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(2)]
        [InlineData(0.5)]
        public void Test_IfStatesHoverHaloOpacityRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "hover", "halo" };

            chart.PlotOptions.Cmf.States.Hover.Halo.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default value for opacity = 0.25 (not null)
        //[Fact]
        //public void Test_IfStatesHoverHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Cmf.States.Hover.Halo.Opacity = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "hover", "halo" };

        //    chart.PlotOptions.Cmf.States.Hover.Halo.Size = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("size", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Fact]
        //public void Test_IfStatesHoverHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Cmf.States.Hover.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesHoverLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "hover" };

            chart.PlotOptions.Cmf.States.Hover.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Cmf.States.Hover.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesHoverLineWidthPlusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "hover" };

            chart.PlotOptions.Cmf.States.Hover.LineWidthPlus = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidthPlus", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default should be 1 (not null)
        //[Fact]
        //public void Test_IfStatesHoverLineWidthPlusDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    double? defaultValue = 1;

        //    chart.PlotOptions.Cmf.States.Hover.LineWidthPlus = defaultValue;

        //    Assert.DoesNotContain($"lineWidthPlus", renderer.RenderHtml());
        //}

        #region marker

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfStatesHoverMarkerEnabledRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "hover", "marker" };

            chart.PlotOptions.Cmf.States.Hover.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Cmf.States.Hover.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesHoverMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "hover", "marker" };

            chart.PlotOptions.Cmf.States.Hover.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double defaultValue = 2;

            chart.PlotOptions.Cmf.States.Hover.Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfStatesHoverMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "hover", "marker" };

            chart.PlotOptions.Cmf.States.Hover.Marker.FillColor = value;

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

        //    chart.PlotOptions.Cmf.States.Hover.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesHoverMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "hover", "marker" };

            chart.PlotOptions.Cmf.States.Hover.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Cmf.States.Hover.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfStatesHoverMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "hover", "marker" };

            chart.PlotOptions.Cmf.States.Hover.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesHoverMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = "#ffffff";

            chart.PlotOptions.Cmf.States.Hover.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesHoverMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "hover", "marker" };

            chart.PlotOptions.Cmf.States.Hover.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesHoverMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Cmf.States.Hover.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesHoverMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "hover", "marker" };

            chart.PlotOptions.Cmf.States.Hover.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesHoverMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 4;

            chart.PlotOptions.Cmf.States.Hover.Marker.Radius = defaultValue;

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
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "hover", "marker" };

            chart.PlotOptions.Cmf.States.Hover.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Cmf.States.Hover.Marker.Width = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "inactive", "animation" };

        //    chart.PlotOptions.Cmf.States.Inactive.Animation.Duration = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfStatesInactiveAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Cmf.States.Inactive.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesInactiveEnabledRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "inactive" };
            var value = false;

            chart.PlotOptions.Cmf.States.Inactive.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesInactiveEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Cmf.States.Inactive.Enabled = defaultValue;

        //    Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(0.5)]
        public void Test_IfStatesInactiveOpacityRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "inactive" };

            chart.PlotOptions.Cmf.States.Inactive.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default value should be 0.2 (not null)
        //[Fact]
        //public void Test_IfStatesInactiveOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = 0.2;

        //    chart.PlotOptions.Cmf.States.Inactive.Opacity = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "normal", "animation" };

        //    chart.PlotOptions.Cmf.States.Normal.Animation.Duration = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfStatesNormalAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Cmf.States.Normal.Animation.Duration = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "select", "animation" };

        //    chart.PlotOptions.Cmf.States.Select.Animation.Duration = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfStatesSelectAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = -1;

            chart.PlotOptions.Cmf.States.Select.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesSelectEnabledRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "select" };
            var value = false;

            chart.PlotOptions.Cmf.States.Select.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesSelectEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = true;

        //    chart.PlotOptions.Cmf.States.Select.Enabled = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "select", "halo" };

        //    chart.PlotOptions.Cmf.States.Select.Halo.Attributes = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("attributes", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfStatesSelectHaloAttributesDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = new Hashtable();

        //    chart.PlotOptions.Cmf.States.Select.Animation.Duration = defaultValue;

        //    Assert.DoesNotContain($"duration", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(2)]
        [InlineData(0.5)]
        public void Test_IfStatesSelectHaloOpacityRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "select", "halo" };

            chart.PlotOptions.Cmf.States.Select.Halo.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default value for opacity = 0.25 (not null)
        //[Fact]
        //public void Test_IfStatesSelectHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Cmf.States.Select.Halo.Opacity = defaultValue;

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
        //    var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "select", "halo" };

        //    chart.PlotOptions.Cmf.States.Select.Halo.Size = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("size", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Fact]
        //public void Test_IfStatesSelectHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = 0.25;

        //    chart.PlotOptions.Cmf.States.Select.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesSelectLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "select" };

            chart.PlotOptions.Cmf.States.Select.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Cmf.States.Select.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesSelectLineWidthPlusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "states", "select" };

            chart.PlotOptions.Cmf.States.Select.LineWidthPlus = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidthPlus", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default should be 1 (not null)
        //[Fact]
        //public void Test_IfStatesSelectLineWidthPlusDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    double? defaultValue = 1;

        //    chart.PlotOptions.Cmf.States.Select.LineWidthPlus = defaultValue;

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
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "select", "marker" };

            chart.PlotOptions.Cmf.States.Select.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool? defaultValue = null;

            chart.PlotOptions.Cmf.States.Select.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesSelectMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "select", "marker" };

            chart.PlotOptions.Cmf.States.Select.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double defaultValue = 2;

            chart.PlotOptions.Cmf.States.Select.Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfStatesSelectMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "select", "marker" };

            chart.PlotOptions.Cmf.States.Select.Marker.FillColor = value;

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

        //    chart.PlotOptions.Cmf.States.Select.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesSelectMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "select", "marker" };

            chart.PlotOptions.Cmf.States.Select.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Cmf.States.Select.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfStatesSelectMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "select", "marker" };

            chart.PlotOptions.Cmf.States.Select.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = "#ffffff";

            chart.PlotOptions.Cmf.States.Select.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesSelectMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "select", "marker" };

            chart.PlotOptions.Cmf.States.Select.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Cmf.States.Select.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesSelectMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "select", "marker" };

            chart.PlotOptions.Cmf.States.Select.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 4;

            chart.PlotOptions.Cmf.States.Select.Marker.Radius = defaultValue;

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
            var pathToProperty = new List<string> { "plotOptions", "cmf", "states", "select", "marker" };

            chart.PlotOptions.Cmf.States.Select.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;

            chart.PlotOptions.Cmf.States.Select.Marker.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        #endregion

        #endregion

        #endregion


        [Theory]
        [InlineData(PlotOptionsCmfStep.Center)]
        [InlineData(PlotOptionsCmfStep.Left)]
        [InlineData(PlotOptionsCmfStep.Right)]
        public void Test_IfStepRenders_Correct(PlotOptionsCmfStep value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.Step = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"step\":\"{Highstock.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStepDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = PlotOptionsCmfStep.Null;

            chart.PlotOptions.Cmf.Step = defaultValue;

            Assert.DoesNotContain($"step", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = false;

            chart.PlotOptions.Cmf.StickyTracking = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"stickyTracking\":{Highstock.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Cmf.StickyTracking = defaultValue;

            Assert.DoesNotContain($"stickyTracking", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfThresholdRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.PlotOptions.Cmf.Threshold = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"threshold\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 0;

            chart.PlotOptions.Cmf.Threshold = defaultValue;

            Assert.DoesNotContain($"threshold", renderer.RenderHtml());
        }

        #region tooltip

        [Theory]
        [InlineData(5)]
        public void Test_IfTooltipValueDecimalsRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "tooltip" };

            chart.PlotOptions.Cmf.Tooltip.ValueDecimals = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("valueDecimals", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - incorrect default value
        //[Fact]
        //public void Test_IfTooltipValueDecimalsDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    double? defaultValue = 4;

        //    chart.PlotOptions.Cmf.Tooltip.ValueDecimals = defaultValue;

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

            chart.PlotOptions.Cmf.TurboThreshold = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"turboThreshold\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTurboThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = 1000;

            chart.PlotOptions.Cmf.TurboThreshold = defaultValue;

            Assert.DoesNotContain($"turboThreshold", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            bool value = false;

            chart.PlotOptions.Cmf.Visible = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"visible\":{Highstock.FirstCharacterToLower(value.ToString())}}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = true;

            chart.PlotOptions.Cmf.Visible = defaultValue;

            Assert.DoesNotContain($"visible", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZoneAxisRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var value = "x";

            chart.PlotOptions.Cmf.ZoneAxis = value;

            Assert.Contains($"\"plotOptions\":{{\"{_fixture.ChartType.ToString().ToLower()}\":{{\"zoneAxis\":\"{Highstock.FirstCharacterToLower(value.ToString())}\"}}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZoneAxisDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = "y";

            chart.PlotOptions.Cmf.ZoneAxis = defaultValue;

            Assert.DoesNotContain($"zoneAxis", renderer.RenderHtml());
        }

        #region zones

        [Theory]
        [InlineData("CSSClassName")]
        public void Test_IfZonesClassNameRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "zones" };
            var zoneDef = new List<PlotOptionsCmfZone> { new PlotOptionsCmfZone { ClassName = value } };

            chart.PlotOptions.Cmf.Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("className", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesClassNameDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;
            var zoneDef = new List<PlotOptionsCmfZone> { new PlotOptionsCmfZone { ClassName = defaultValue } };

            chart.PlotOptions.Cmf.Zones = zoneDef;

            Assert.DoesNotContain($"className", renderer.RenderHtml());
        }


        //fix required - color exists only as a string (should be also gradient and pattern)
        [Theory]
        [InlineData("#0022ff")]
        public void Test_IfZonesColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "zones" };
            var zoneDef = new List<PlotOptionsCmfZone> { new PlotOptionsCmfZone { Color = value } };

            chart.PlotOptions.Cmf.Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("color", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = string.Empty;
            var zoneDef = new List<PlotOptionsCmfZone> { new PlotOptionsCmfZone { Color = defaultValue } };

            chart.PlotOptions.Cmf.Zones = zoneDef;

            Assert.DoesNotContain($"color", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PlotOptionsCmfZonesDashStyle.Dash)]
        [InlineData(PlotOptionsCmfZonesDashStyle.DashDot)]
        [InlineData(PlotOptionsCmfZonesDashStyle.Dot)]
        [InlineData(PlotOptionsCmfZonesDashStyle.LongDash)]
        [InlineData(PlotOptionsCmfZonesDashStyle.LongDashDot)]
        [InlineData(PlotOptionsCmfZonesDashStyle.LongDashDotDot)]
        [InlineData(PlotOptionsCmfZonesDashStyle.ShortDash)]
        [InlineData(PlotOptionsCmfZonesDashStyle.ShortDashDot)]
        [InlineData(PlotOptionsCmfZonesDashStyle.ShortDashDotDot)]
        [InlineData(PlotOptionsCmfZonesDashStyle.ShortDot)]
        [InlineData(PlotOptionsCmfZonesDashStyle.Solid)]
        public void Test_IfZonesDashStyleRenders_Correct(PlotOptionsCmfZonesDashStyle value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "zones" };
            var zoneDef = new List<PlotOptionsCmfZone> { new PlotOptionsCmfZone { DashStyle = value } };

            chart.PlotOptions.Cmf.Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetEnumPropertyString(chart, "dashStyle", value.ToString())}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesDashStyleDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var defaultValue = PlotOptionsCmfZonesDashStyle.Null;
            var zoneDef = new List<PlotOptionsCmfZone> { new PlotOptionsCmfZone { DashStyle = defaultValue } };

            chart.PlotOptions.Cmf.Zones = zoneDef;

            Assert.DoesNotContain($"dashStyle", renderer.RenderHtml());
        }

        //fix required - color exists only as a string (should be also gradient and pattern)
        [Theory]
        [InlineData("#0022ff")]
        public void Test_IfZonesFillColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "zones" };
            var zoneDef = new List<PlotOptionsCmfZone> { new PlotOptionsCmfZone { FillColor = value } };

            chart.PlotOptions.Cmf.Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("fillColor", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default value for fillColor should be string.Empty (not null) 
        //[Fact]
        //public void Test_IfZonesFillColorDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart);
        //    var defaultValue = string.Empty;
        //    var zoneDef = new List<PlotOptionsCmfZone> { new PlotOptionsCmfZone { FillColor = defaultValue } };

        //    chart.PlotOptions.Cmf.Zones = zoneDef;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(5000)]
        public void Test_IfZonesValueRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "plotOptions", "cmf", "zones" };
            var zoneDef = new List<PlotOptionsCmfZone> { new PlotOptionsCmfZone { Value = value } };

            chart.PlotOptions.Cmf.Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("value", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            double? defaultValue = null;
            var zoneDef = new List<PlotOptionsCmfZone> { new PlotOptionsCmfZone { Value = defaultValue } };

            chart.PlotOptions.Cmf.Zones = zoneDef;

            Assert.DoesNotContain($"value", renderer.RenderHtml());
        }

        #endregion
    }
}

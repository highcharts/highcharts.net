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


namespace HS.Series
{
    public class PriceenvelopesSeriesTests : IClassFixture<HsFixture>
    {
        protected HsFixture _fixture;

        public PriceenvelopesSeriesTests(HsFixture fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Priceenvelopes;
        }

        [Fact]
        public void Test_IfSeriesRendersType_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var series = new PriceenvelopesSeries();
            chart.Series.Add(series);

            var result = renderer.RenderHtml();

            Assert.Contains($"\"series\":[{{\"type\":\"{_fixture.ChartType.ToString().ToLower()}\"", result);
        }

        //Specific for Series



        //From plotOptions

        #region Acessibility

        [Theory]
        [InlineData("Description")]
        public void Test_IfAccessibilityDescriptionRenders_Correct(string description)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var series = new PriceenvelopesSeries();
            chart.Series.Add(series);


            ((PriceenvelopesSeries)chart.Series[0]).Accessibility.Description = description;
            var result = renderer.RenderHtml();

            //Assert.Contains($"\"series\":[{{", result);
            //Assert.Contains($"\"type\":\"{_fixture.ChartType.ToString().ToLower()}\"", result);
            Assert.Contains($"\"accessibility\":{{\"description\":\"{description}\"}}", result);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityEnabledRenders_Correct(bool enabled)
        {
            var chart = new Highstock();

            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Accessibility.Enabled = enabled;

            Assert.Contains($"\"accessibility\":{{\"enabled\":{enabled.ToString().ToLower()}}}", renderer.RenderHtml());
        }


        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityExposeAsGroupOnlyRenders_Correct(bool exposeAsGroupOnly)
        {
            var chart = new Highstock();

            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Accessibility.ExposeAsGroupOnly = exposeAsGroupOnly;

            Assert.Contains($"\"accessibility\":{{\"exposeAsGroupOnly\":{exposeAsGroupOnly.ToString().ToLower()}}}", renderer.RenderHtml());
        }

        #region KeyboardNavigation

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityKeyboardNavigationEnabledRenders_Correct(bool enabled)
        {
            var chart = new Highstock();

            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Accessibility.KeyboardNavigation.Enabled = enabled;

            Assert.Contains($"\"accessibility\":{{\"keyboardNavigation\":{{\"enabled\":{enabled.ToString().ToLower()}", renderer.RenderHtml());
        }

        #endregion

        #region Point

        [Theory]
        [InlineData("%Y-%m-%d %H:%M:%S")]
        public void Test_IfAccessibilityPointDateFormatRenders_Correct(string format)
        {
            var chart = new Highstock();

            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Accessibility.Point.DateFormat = format;

            Assert.Contains($"\"accessibility\":{{\"point\":{{\"dateFormat\":\"{format}\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("DateFormatterFunction")]
        public void Test_IfAccessibilityPointDateFormatterRenders_Correct(string function)
        {
            var chart = new Highstock();

            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Accessibility.Point.DateFormatter = function;

            Assert.Contains($"\"accessibility\":{{\"point\":{{\"dateFormatter\":{function}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(false)]
        public void Test_IfAccessibilityPointDescribeNullSetOnFalseRenders_Correct(bool describeNull)
        {
            var chart = new Highstock();

            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);



            ((PriceenvelopesSeries)chart.Series[0]).Accessibility.Point.DescribeNull = describeNull;

            Assert.Contains($"\"accessibility\":{{\"point\":{{\"describeNull\":{describeNull.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        public void Test_IfAccessibilityPointDescribeNullSetOnTrueRenders_Correct(bool describeNull)
        {
            var chart = new Highstock();

            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Accessibility.Point.DescribeNull = describeNull;

            Assert.DoesNotContain($"describeNull", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("FormatterFunction")]
        public void Test_IfAccessibilityPointDescriptionFormatterRenders_Correct(string function)
        {
            var chart = new Highstock();

            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Accessibility.Point.DescriptionFormatter = function;

            Assert.Contains($"\"accessibility\":{{\"point\":{{\"descriptionFormatter\":{function}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(3)]
        public void Test_IfAccessibilityPointValueDecimalsRenders_Correct(int decimals)
        {
            var chart = new Highstock();

            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Accessibility.Point.ValueDecimals = decimals;

            Assert.Contains($"\"accessibility\":{{\"point\":{{\"valueDecimals\":{decimals}.0", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{Description}{separator}{value}")]
        public void Test_IfAccessibilityPointValueDescriptionFormatRenders_Correct(string format)
        {
            var chart = new Highstock();

            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Accessibility.Point.ValueDescriptionFormat = format;

            Assert.Contains($"\"accessibility\":{{\"point\":{{\"valueDescriptionFormat\":\"{format}\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomePrefix")]
        public void Test_IfAccessibilityPointValuePrefixRenders_Correct(string prefix)
        {
            var chart = new Highstock();

            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Accessibility.Point.ValuePrefix = prefix;

            Assert.Contains($"\"accessibility\":{{\"point\":{{\"valuePrefix\":\"{prefix}\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeSuffix")]
        public void Test_IfAccessibilityPointValueSufixRenders_Correct(string suffix)
        {
            var chart = new Highstock();

            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Accessibility.Point.ValueSuffix = suffix;

            Assert.Contains($"\"accessibility\":{{\"point\":{{\"valueSuffix\":\"{suffix}\"", renderer.RenderHtml());
        }
        #endregion

        #endregion

        [Fact]
        public void Test_IfAllowPointSelectRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var enabled = true;

            ((PriceenvelopesSeries)chart.Series[0]).AllowPointSelect = enabled;

            Assert.Contains($"\"allowPointSelect\":{enabled.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAllowPointSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).AllowPointSelect = false;

            Assert.DoesNotContain("allowPointSelect", renderer.RenderHtml());
        }

        #region Animation

        [Fact]
        public void Test_IfAnimationEnabledRenders_Correct()
        {
            var chart = new Highstock();

            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var enabled = false;

            ((PriceenvelopesSeries)chart.Series[0]).AnimationBool = enabled;

            Assert.Contains($"\"animation\":{enabled.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAnimationEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();

            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var enabled = true;

            ((PriceenvelopesSeries)chart.Series[0]).AnimationBool = enabled;

            Assert.DoesNotContain("animation", renderer.RenderHtml());
        }

        //fix required - extra slashes in result string
        //[Theory]
        //[InlineData(1000)]
        //public void Test_IfAnimationDurationRenders_Correct(int duration)
        //{
        //    var chart = new Highstock();

        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

        //    ((PriceenvelopesSeries)chart.Series[0]).Animation.Duration = duration;

        //    Assert.Contains($"\"animation\":{{\"duration\":{duration}}}", renderer.RenderHtml());
        //}

        //clarification required - defer is missing in HS API
        //[Theory]
        //[InlineData(1000)]
        //public void Test_IfAnimationDeferRenders_Correct(int defer)
        //{
        //    var chart = new Highstock();

        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

        //    ((PriceenvelopesSeries)chart.Series[0]).Animation.Defer = defer;

        //    Assert.Contains($"\"animation\":{{\"defer\":{defer}}}", renderer.RenderHtml());
        //}

        //fix required - extra slashes in result string
        //[Theory]
        //[InlineData("easingFunctionName")]
        //public void Test_IfAnimationEasingRenders_Correct(string easing)
        //{
        //    var chart = new Highstock();

        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

        //    ((PriceenvelopesSeries)chart.Series[0]).Animation.Easing = easing;

        //    Assert.Contains($"\"animation\":{{\"easing\":\"{easing}\"}}", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(250)]
        public void Test_IfAnimationLimitRenders_Correct(int limit)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var series = new PriceenvelopesSeries();
            chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).AnimationLimit = limit;

            Assert.Contains($"\"animationLimit\":{limit}.0", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PriceenvelopesSeriesBoostBlending.Add)]
        [InlineData(PriceenvelopesSeriesBoostBlending.Darken)]
        [InlineData(PriceenvelopesSeriesBoostBlending.Multiply)]
        public void Test_IfBoostBlendingRenders_Correct(PriceenvelopesSeriesBoostBlending boostBlending)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).BoostBlending = boostBlending;

            Assert.Contains($"\"boostBlending\":\"{boostBlending.ToString().ToLower()}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfBoostBlendingDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).BoostBlending = PriceenvelopesSeriesBoostBlending.Undefined;

            Assert.DoesNotContain($"\"boostBlending\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2000)]
        public void Test_IfBoostThresholdRenders_Correct(int limit)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).BoostThreshold = limit;

            Assert.Contains($"\"boostThreshold\":{limit}.0", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfBoostThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 5000;

            ((PriceenvelopesSeries)chart.Series[0]).BoostThreshold = defaultValue;

            Assert.DoesNotContain("boostThreshold", renderer.RenderHtml());
        }

        //missing borderColor
        //missing borderWidth

        [Theory]
        [InlineData("ClassName")]
        public void Test_IfClassNameRenders_Correct(string className)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).ClassName = className;

            Assert.Contains($"\"className\":\"{className}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = false;

            ((PriceenvelopesSeries)chart.Series[0]).Clip = value;

            Assert.Contains($"\"clip\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = true;

            ((PriceenvelopesSeries)chart.Series[0]).Clip = value;

            Assert.DoesNotContain("clip", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#ffffff")]
        public void Test_IfColorRenders_Correct(string color)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Color = color;

            Assert.Contains($"\"color\":\"{color.ToString().ToLower()}\"", renderer.RenderHtml());
        }

        //missing logic for GradientColorObject and PatternObject

        [Theory]
        [InlineData(1)]
        public void Test_IfColorIndexRenders_Correct(int value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).ColorIndex = value;

            Assert.Contains($"\"colorIndex\":{value}.0", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("colorValue")]
        public void Test_IfColorKeyRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).ColorKey = value;

            Assert.Contains($"\"colorKey\":\"{value}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfConnectNullsRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = true;

            ((PriceenvelopesSeries)chart.Series[0]).ConnectNulls = value;

            Assert.Contains($"\"connectNulls\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfConnectNullsDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = false;

            ((PriceenvelopesSeries)chart.Series[0]).ConnectNulls = value;

            Assert.DoesNotContain($"\"connectNulls\"", renderer.RenderHtml());
        }



        [Fact]
        public void Test_IfCrispRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = false;

            ((PriceenvelopesSeries)chart.Series[0]).Crisp = value;

            Assert.Contains($"\"crisp\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCrispDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = true;

            ((PriceenvelopesSeries)chart.Series[0]).Crisp = value;

            Assert.DoesNotContain($"\"crisp\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(299)]
        public void Test_IfCropThresholdRenders_Correct(int value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).CropThreshold = value;

            Assert.Contains($"\"cropThreshold\":{value}.0", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCropThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 300;

            ((PriceenvelopesSeries)chart.Series[0]).CropThreshold = defaultValue;

            Assert.DoesNotContain($"\"crisp\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PriceenvelopesSeriesCursor.Default)]
        [InlineData(PriceenvelopesSeriesCursor.Help)]
        [InlineData(PriceenvelopesSeriesCursor.Pointer)]
        [InlineData(PriceenvelopesSeriesCursor.None)]
        public void Test_IfCursorRenders_Correct(PriceenvelopesSeriesCursor cursor)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Cursor = cursor;

            Assert.Contains($"\"cursor\":\"{cursor.ToString().ToLower()}\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("dataKey1", "dataValue1")]
        public void Test_IfCustomRenders_Correct(string key1, string value1)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var extraData = new Hashtable() { { key1, value1 } };

            ((PriceenvelopesSeries)chart.Series[0]).Custom = extraData;

            Assert.Contains($"\"custom\":{{\"{key1}\":\"{value1}\"}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PriceenvelopesSeriesDashStyle.Dash)]
        [InlineData(PriceenvelopesSeriesDashStyle.DashDot)]
        [InlineData(PriceenvelopesSeriesDashStyle.Dot)]
        [InlineData(PriceenvelopesSeriesDashStyle.LongDash)]
        [InlineData(PriceenvelopesSeriesDashStyle.LongDashDot)]
        [InlineData(PriceenvelopesSeriesDashStyle.LongDashDotDot)]
        [InlineData(PriceenvelopesSeriesDashStyle.ShortDash)]
        [InlineData(PriceenvelopesSeriesDashStyle.ShortDashDot)]
        [InlineData(PriceenvelopesSeriesDashStyle.ShortDashDotDot)]
        [InlineData(PriceenvelopesSeriesDashStyle.ShortDot)]
        public void Test_IfDashStyleRenders_Correct(PriceenvelopesSeriesDashStyle style)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var result = style.ToString();
            var replacement = result[0].ToString().ToLower();
            result = result.Remove(0, 1);
            result = replacement + result;

            ((PriceenvelopesSeries)chart.Series[0]).DashStyle = style;

            Assert.Contains($"\"dashStyle\":\"{result}\"", renderer.RenderHtml());
        }


        #region databaLabels

        //fix required - missing dataLabels as a list of objects (right now it is possible to have only one object)

        [Theory]
        [InlineData(PriceenvelopesSeriesDataLabelsAlign.Left)]
        [InlineData(PriceenvelopesSeriesDataLabelsAlign.Right)]
        public void Test_IfDataLabelsAlignRenders_Correct(PriceenvelopesSeriesDataLabelsAlign align)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Align = align;

            Assert.Contains($"\"dataLabels\":{{\"align\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = PriceenvelopesSeriesDataLabelsAlign.Center;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Align = defaultValue;

            Assert.DoesNotContain($"align", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAllowOverlapRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = true;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.AllowOverlap = value;

            Assert.Contains($"\"dataLabels\":{{\"allowOverlap\":{value.ToString().ToLower()}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsAllowOverlapDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = false;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.AllowOverlap = defaultValue;

            Assert.DoesNotContain($"allowOverlap", renderer.RenderHtml());
        }

        #region Animation

        //clarification required - property missing in API
        //[Theory]
        //[InlineData(200)]
        //[InlineData(500)]
        //public void Test_IfDataLabelsAnimationDeferRenders_Correct(int value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

        //    ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Animation.Defer = value;

        //    Assert.Contains($"\"dataLabels\":{{\"animation\":{{\"defer\":{value}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfDataLabelsAnimationDeferDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = -1;

        //    ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Animation.Defer = defaultValue;

        //    Assert.DoesNotContain($"defer", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsBackgroundColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.BackgroundColor = value;

            Assert.Contains($"\"dataLabels\":{{\"backgroundColor\":\"{value}\"}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBackgroundColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.BackgroundColor = defaultValue;

            Assert.DoesNotContain($"backgroundColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsBorderColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.BorderColor = value;

            Assert.Contains($"\"dataLabels\":{{\"borderColor\":\"{value}\"}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.BorderColor = defaultValue;

            Assert.DoesNotContain($"borderColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsBorderRadiusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.BorderRadius = value;

            Assert.Contains($"\"dataLabels\":{{\"borderRadius\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 0;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.BorderRadius = defaultValue;

            Assert.DoesNotContain($"borderRadius", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsBorderWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.BorderWidth = value;

            Assert.Contains($"\"dataLabels\":{{\"borderWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsBorderWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 0;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.BorderWidth = defaultValue;

            Assert.DoesNotContain($"borderWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("classA")]
        [InlineData("classB")]
        public void Test_IfDataLabelsClassNameRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.ClassName = value;

            Assert.Contains($"\"dataLabels\":{{\"className\":\"{value}\"}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsClassNameDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.ClassName = defaultValue;

            Assert.DoesNotContain($"className", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0022ff")]
        [InlineData("#ff00aa")]
        public void Test_IfDataLabelsColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Color = value;

            Assert.Contains($"\"dataLabels\":{{\"color\":\"{value}\"}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Color = defaultValue;

            Assert.DoesNotContain($"color", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsCropRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = false;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Crop = value;

            Assert.Contains($"\"dataLabels\":{{\"crop\":{value.ToString().ToLower()}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsCropDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = true;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Crop = defaultValue;

            Assert.DoesNotContain($"crop", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsDeferBoolRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = false;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Defer = value;

            Assert.Contains($"\"dataLabels\":{{\"defer\":{value.ToString().ToLower()}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsDeferBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = true;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Defer = defaultValue;

            Assert.DoesNotContain($"defer", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsDeferRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = false;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Defer = value;

            Assert.Contains($"\"dataLabels\":{{\"defer\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsEnabledBoolRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = true;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Enabled = value;

            Assert.Contains($"\"dataLabels\":{{\"enabled\":{value.ToString().ToLower()}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsEnabledBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = false;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Enabled = defaultValue;

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
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Filter.Operator = value;

            Assert.Contains($"\"dataLabels\":{{\"filter\":{{\"operator\":\"{value}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterOperatorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Filter.Operator = defaultValue;

            Assert.DoesNotContain($"operator", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("percentage")]
        [InlineData("y")]
        public void Test_IfDataLabelsFilterPropertyRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Filter.Property = value;

            Assert.Contains($"\"dataLabels\":{{\"filter\":{{\"property\":\"{value}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterPropertyDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Filter.Property = defaultValue;

            Assert.DoesNotContain($"property", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfDataLabelsFilterValueRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Filter.Value = value;

            Assert.Contains($"\"dataLabels\":{{\"filter\":{{\"value\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFilterValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Filter.Value = defaultValue;

            Assert.DoesNotContain($"value", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("{y} mm")]
        [InlineData("<{x},{y}>")]
        public void Test_IfDataLabelsFormatRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Format = value;

            Assert.Contains($"\"dataLabels\":{{\"format\":\"{value}\"}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = "point.value";

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Format = defaultValue;

            Assert.DoesNotContain($"format", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfDataLabelsFormatterRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Formatter = value;

            Assert.Contains($"\"dataLabels\":{{\"formatter\":{value}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Formatter = defaultValue;

            Assert.DoesNotContain($"formatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataLabelsInsideRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Inside = value;

            Assert.Contains($"\"dataLabels\":{{\"inside\":{value.ToString().ToLower()}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsInsideDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Inside = defaultValue;

            Assert.DoesNotContain($"inside", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataLabelsNullFormatBoolRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.NullFormatBool = value;

            Assert.Contains($"\"dataLabels\":{{\"nullFormat\":{value.ToString().ToLower()}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.NullFormatBool = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{y} mm")]
        [InlineData("<{x},{y}>")]
        public void Test_IfDataLabelsNullFormatRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.NullFormat = value;

            Assert.Contains($"\"dataLabels\":{{\"nullFormat\":\"{value}\"}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.NullFormat = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfDataLabelsNullFormatterRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.NullFormatter = value;

            Assert.Contains($"\"dataLabels\":{{\"nullFormatter\":{value}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsNullFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.NullFormatter = defaultValue;

            Assert.DoesNotContain($"nullFormatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PriceenvelopesSeriesDataLabelsOverflow.Allow)]
        public void Test_IfDataLabelsOverflowRenders_Correct(PriceenvelopesSeriesDataLabelsOverflow align)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Overflow = align;

            Assert.Contains($"\"dataLabels\":{{\"overflow\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsOverflowDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = PriceenvelopesSeriesDataLabelsOverflow.Justify;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Overflow = defaultValue;

            Assert.DoesNotContain($"overflow", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(50)]
        public void Test_IfDataLabelsPaddingRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Padding = value;

            Assert.Contains($"\"dataLabels\":{{\"padding\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsPaddingDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 5;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Padding = defaultValue;

            Assert.DoesNotContain($"padding", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PriceenvelopesSeriesDataLabelsPosition.Left)]
        [InlineData(PriceenvelopesSeriesDataLabelsPosition.Right)]
        public void Test_IfDataLabelsPositionRenders_Correct(PriceenvelopesSeriesDataLabelsPosition align)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Position = align;

            Assert.Contains($"\"dataLabels\":{{\"position\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsPositionDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = PriceenvelopesSeriesDataLabelsPosition.Center;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Position = defaultValue;

            Assert.DoesNotContain($"position", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(90)]
        [InlineData(180)]
        public void Test_IfDataLabelsRotationRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Rotation = value;

            Assert.Contains($"\"dataLabels\":{{\"rotation\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsRotationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 0;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Rotation = defaultValue;

            Assert.DoesNotContain($"rotation", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsShadowBoolRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool value = true;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.ShadowBool = value;

            Assert.Contains($"\"dataLabels\":{{\"shadow\":{chart.FirstCharacterToLower(value.ToString())}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#00ffdd", 10, 20, 30, 40)]
        [InlineData("#ffccaa", 40, 30, 20, 10)]
        public void Test_IfDataLabelsShadowRenders_Correct(string color, int offsetX, int offsetY, double opacity, int width)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Shadow = new Shadow()
            {
                Color = color,
                OffsetX = offsetX,
                OffsetY = offsetY,
                Opacity = opacity,
                Width = width
            };

            var result = renderer.RenderHtml();
            Assert.Contains($"\"dataLabels\":{{\"shadow\":", result);
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
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = false;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.ShadowBool = defaultValue;

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
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Shape = value;

            Assert.Contains($"\"dataLabels\":{{\"shape\":\"{value}\"}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsShapeDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = "square";

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Shape = defaultValue;

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
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "dataLabels", "style" };
            var style = new Hashtable();
            style.Add(param1, param1_value);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Style = style;

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
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "dataLabels", "style" };
            var style = new Hashtable();
            style.Add(param1, param1_value);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Style = style;

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
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "dataLabels", "textPath" };

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.TextPath.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsTextPathEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.TextPath.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        #endregion

        [Fact]
        public void Test_IfDataLabelsUseHTMLRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = true;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.UseHTML = value;

            Assert.Contains($"\"dataLabels\":{{\"useHTML\":{value.ToString().ToLower()}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsUseHTMLDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = false;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.UseHTML = defaultValue;

            Assert.DoesNotContain($"useHTML", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PriceenvelopesSeriesDataLabelsVerticalAlign.Middle)]
        [InlineData(PriceenvelopesSeriesDataLabelsVerticalAlign.Top)]
        public void Test_IfDataLabelsVerticalAlignRenders_Correct(PriceenvelopesSeriesDataLabelsVerticalAlign align)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.VerticalAlign = align;

            Assert.Contains($"\"dataLabels\":{{\"verticalAlign\":\"{chart.FirstCharacterToLower(align.ToString())}\"}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsVerticalAlignDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = PriceenvelopesSeriesDataLabelsVerticalAlign.Bottom;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.VerticalAlign = defaultValue;

            Assert.DoesNotContain($"verticalAlign", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsXRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.X = value;

            Assert.Contains($"\"dataLabels\":{{\"x\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsXDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 0;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.X = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"x\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsYRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Y = value;

            Assert.Contains($"\"dataLabels\":{{\"y\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsYDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 0;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Y = defaultValue;

            Assert.DoesNotContain($"\"dataLabels\":{{\"y\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(50)]
        public void Test_IfDataLabelsZRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.ZIndex = value;

            Assert.Contains($"\"dataLabels\":{{\"zIndex\":{string.Format(CultureInfo.InvariantCulture, "{0:N1}", value).Replace(",", "")}}}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataLabelsZDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 6;

            ((PriceenvelopesSeries)chart.Series[0]).DataLabels.ZIndex = defaultValue;

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
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "dataSorting" };

            ((PriceenvelopesSeries)chart.Series[0]).DataSorting.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataSortingEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).DataSorting.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfDataSortingMatchByNameRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "dataSorting" };

            ((PriceenvelopesSeries)chart.Series[0]).DataSorting.MatchByName = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("matchByName", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataSortingMatchByNameDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).DataSorting.MatchByName = defaultValue;

            Assert.DoesNotContain($"matchByName", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("x")]
        [InlineData("z")]
        public void Test_IfDataSortingSortKeyRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "dataSorting" };

            ((PriceenvelopesSeries)chart.Series[0]).DataSorting.SortKey = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("sortKey", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfDataSortingSortKeyDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = "y";

            ((PriceenvelopesSeries)chart.Series[0]).DataSorting.SortKey = defaultValue;

            Assert.DoesNotContain($"sortKey", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("SomePlotOptionsDescription")]
        public void Test_IfDescriptionRenders_Correct(string description)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Description = description;

            Assert.Contains($"\"description\":\"{description}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = false;

            ((PriceenvelopesSeries)chart.Series[0]).EnableMouseTracking = value;

            Assert.Contains($"\"enableMouseTracking\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = true;

            ((PriceenvelopesSeries)chart.Series[0]).EnableMouseTracking = value;

            Assert.DoesNotContain($"\"enableMouseTracking\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        #region events

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsAfterAnimateRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Events.AfterAnimate = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("afterAnimate", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsAfterAnimateDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Events.AfterAnimate = defaultValue;

            Assert.DoesNotContain($"afterAnimate", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsCheckboxClickRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Events.CheckboxClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("checkboxClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsCheckboxClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Events.CheckboxClick = defaultValue;

            Assert.DoesNotContain($"checkboxClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsClickRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsclickDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsHideRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Events.Hide = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("hide", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsHideDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Events.Hide = defaultValue;

            Assert.DoesNotContain($"hide", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsLegendItemClickRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Events.LegendItemClick = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("legendItemClick", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsLegendItemClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Events.LegendItemClick = defaultValue;

            Assert.DoesNotContain($"legendItemClick", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfEventsShowRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Events.Show = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("show", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEventsShowDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Events.Show = defaultValue;

            Assert.DoesNotContain($"show", renderer.RenderHtml());
        }

        #endregion


        [Fact]
        public void Test_IfFindNearestPointByRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = PriceenvelopesSeriesFindNearestPointBy.Xy;

            ((PriceenvelopesSeries)chart.Series[0]).FindNearestPointBy = value;

            Assert.Contains($"\"findNearestPointBy\":\"{value.ToString().ToLower()}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfFindNearestPointByDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = PriceenvelopesSeriesFindNearestPointBy.X;

            ((PriceenvelopesSeries)chart.Series[0]).FindNearestPointBy = value;

            Assert.DoesNotContain($"\"findNearestPointBy\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfGetExtremesFromAllRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = true;

            ((PriceenvelopesSeries)chart.Series[0]).GetExtremesFromAll = value;

            Assert.Contains($"\"getExtremesFromAll\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfGetExtremesFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = false;

            ((PriceenvelopesSeries)chart.Series[0]).GetExtremesFromAll = value;

            Assert.DoesNotContain($"\"getExtremesFromAll\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfIncludeInDataExportFromAllRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).IncludeInDataExport = value;

            Assert.Contains($"\"includeInDataExport\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfIncludeInDataExportFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool? value = null;

            ((PriceenvelopesSeries)chart.Series[0]).IncludeInDataExport = value;

            Assert.DoesNotContain($"\"includeInDataExport\":{value}", renderer.RenderHtml());
        }

        #region label

        //missing boxesToAvoid

        [Fact]
        public void Test_IfLabelConnectorAllowedRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "label" };
            var value = true;

            ((PriceenvelopesSeries)chart.Series[0]).Label.ConnectorAllowed = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorAllowed", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorAllowedDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = false;

            ((PriceenvelopesSeries)chart.Series[0]).Label.ConnectorAllowed = defaultValue;

            Assert.DoesNotContain($"connectorAllowed", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(30)]
        public void Test_IfLabelConnectorNeighbourDistanceRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "label" };

            ((PriceenvelopesSeries)chart.Series[0]).Label.ConnectorNeighbourDistance = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("connectorNeighbourDistance", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelConnectorNeighbourDistanceDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 24;

            ((PriceenvelopesSeries)chart.Series[0]).Label.ConnectorNeighbourDistance = defaultValue;

            Assert.DoesNotContain($"connectorNeighbourDistance", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "label" };
            var value = false;

            ((PriceenvelopesSeries)chart.Series[0]).Label.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = true;

            ((PriceenvelopesSeries)chart.Series[0]).Label.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFormat")]
        public void Test_IfLabelFormatRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "label" };

            ((PriceenvelopesSeries)chart.Series[0]).Label.Format = value;

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
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = string.Empty;

        //    ((PriceenvelopesSeries)chart.Series[0]).Label.Format = defaultValue;

        //    Assert.DoesNotContain($"format", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("SomeFormatterFunction")]
        public void Test_IfLabelFormatterRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "label" };

            ((PriceenvelopesSeries)chart.Series[0]).Label.Formatter = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("formatter", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Label.Formatter = defaultValue;

            Assert.DoesNotContain($"formatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMaxFontSizeRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "label" };

            ((PriceenvelopesSeries)chart.Series[0]).Label.MaxFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("maxFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMaxFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).Label.MaxFontSize = defaultValue;

            Assert.DoesNotContain($"maxFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        public void Test_IfLabelMinFontSizeRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "label" };

            ((PriceenvelopesSeries)chart.Series[0]).Label.MinFontSize = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("minFontSize", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelMinFontSizeDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).Label.MinFontSize = defaultValue;

            Assert.DoesNotContain($"minFontSize", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfLabelOnAreaRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "label" };

            ((PriceenvelopesSeries)chart.Series[0]).Label.OnArea = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("onArea", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLabelOnAreaDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).Label.OnArea = defaultValue;

            Assert.DoesNotContain($"onArea", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("fontWeight", "bold")]
        public void Test_IfLabelStyleRenders_Correct(string paramName, string paramValue)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "label" };
            var value = new Hashtable();
            value.Add(paramName, paramValue);


            ((PriceenvelopesSeries)chart.Series[0]).Label.Style = value;

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
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = new Hashtable();

        //    ((PriceenvelopesSeries)chart.Series[0]).Label.Style = defaultValue;

        //    Assert.DoesNotContain($"style", renderer.RenderHtml());
        //}



        #endregion


        //fix required - Linecap should be enum (not string)
        //[Theory]
        //[InlineData(PriceenvelopesSeriesLinecap.Square)]
        ////missing PriceenvelopesSeriesLinecap.Butt ?
        //public void Test_IfLinecapRenders_Correct(PriceenvelopesSeriesLinecap value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

        //    ((PriceenvelopesSeries)chart.Series[0]).Linecap = value;

        //    Assert.Contains($"\"linecap\":\"{chart.FirstCharacterToLower(value.ToString())}\"", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfLinecapDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = PriceenvelopesSeriesLinecap.Round;

        //    ((PriceenvelopesSeries)chart.Series[0]).Linecap = defaultValue;

        //    Assert.DoesNotContain($"\"linecap\":{defaultValue.ToString().ToLower()}", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).LineWidth = value;

            Assert.Contains($"\"lineWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 1;

            ((PriceenvelopesSeries)chart.Series[0]).LineWidth = defaultValue;

            Assert.DoesNotContain($"\"lineWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", defaultValue)}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(":previous")]
        [InlineData("IdAnotherSeries")]
        public void Test_IfLinkedToRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).LinkedTo = value;

            Assert.Contains($"\"linkedTo\":\"{value}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfLinkedToDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            string defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).LinkedTo = defaultValue;

            Assert.DoesNotContain($"\"linkedTo\":{defaultValue}", renderer.RenderHtml());
        }

        #region marker

        [Theory]
        [InlineData(true)]
        public void Test_IfMarkerEnabledRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool? defaultValue = false;

            ((PriceenvelopesSeries)chart.Series[0]).Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double defaultValue = 2;

            ((PriceenvelopesSeries)chart.Series[0]).Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).Marker.FillColor = value;

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
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = string.Empty;

        //    ((PriceenvelopesSeries)chart.Series[0]).Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = "#ffffff";

            ((PriceenvelopesSeries)chart.Series[0]).Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 0;

            ((PriceenvelopesSeries)chart.Series[0]).Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 4;

            ((PriceenvelopesSeries)chart.Series[0]).Marker.Radius = defaultValue;

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
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).Marker.Symbol = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("symbol", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerSymbolDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Marker.Symbol = defaultValue;

            Assert.DoesNotContain($"symbol", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(1000)]
        public void Test_IfMarkerWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).Marker.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("#FF0000")]
        [InlineData("#0088FF")]
        public void Test_IfNegativeColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).NegativeColor = value;

            Assert.Contains($"\"negativeColor\":\"{value}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfNegativeColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            string defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).NegativeColor = defaultValue;

            Assert.DoesNotContain($"\"negativeColor\":{defaultValue}", renderer.RenderHtml());
        }

        #region onPoint

        //fix dashStyle - should be string instead of hashtable
        //[Theory]
        //[InlineData("dot")]
        //public void Test_IfOnPointConnectorOptionsDashStyleRenders_Correct(string value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var pathToProperty = new List<string>() { "onPoint", "connectorOptions" };

        //    ((PriceenvelopesSeries)chart.Series[0]).OnPoint.ConnectorOptions.Dashstyle = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("dashstyle", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfOnPointConnectorOptionsDashStyleDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = string.Empty;

        //    ((PriceenvelopesSeries)chart.Series[0]).DataLabels.Color = defaultValue;

        //    Assert.DoesNotContain($"color", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("red")]
        public void Test_IfOnPointConnectorOptionsStrokeRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "onPoint", "connectorOptions" };

            ((PriceenvelopesSeries)chart.Series[0]).OnPoint.ConnectorOptions.Stroke = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("stroke", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsStrokeDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).OnPoint.ConnectorOptions.Stroke = defaultValue;

            Assert.DoesNotContain($"stroke", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointConnectorOptionsWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "onPoint", "connectorOptions" };

            ((PriceenvelopesSeries)chart.Series[0]).OnPoint.ConnectorOptions.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointConnectorOptionsWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 1;

            ((PriceenvelopesSeries)chart.Series[0]).OnPoint.ConnectorOptions.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("pointId")]
        public void Test_IfOnPointIdRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "onPoint" };

            ((PriceenvelopesSeries)chart.Series[0]).OnPoint.Id = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("id", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointIdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).OnPoint.Id = defaultValue;

            Assert.DoesNotContain($"\"id\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetXRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "onPoint", "position" };

            ((PriceenvelopesSeries)chart.Series[0]).OnPoint.Position.OffsetX = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetX", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetXDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).OnPoint.Position.OffsetX = defaultValue;

            Assert.DoesNotContain($"offsetX", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionOffsetYRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "onPoint", "position" };

            ((PriceenvelopesSeries)chart.Series[0]).OnPoint.Position.OffsetY = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("offsetY", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointOffsetYDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).OnPoint.Position.OffsetY = defaultValue;

            Assert.DoesNotContain($"offsetY", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionXRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "onPoint", "position" };

            ((PriceenvelopesSeries)chart.Series[0]).OnPoint.Position.X = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("x", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointXDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).OnPoint.Position.X = defaultValue;

            Assert.DoesNotContain($"\"x\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfOnPointPositionYRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "onPoint", "position" };

            ((PriceenvelopesSeries)chart.Series[0]).OnPoint.Position.Y = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("y", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOnPointYDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).OnPoint.Position.Y = defaultValue;

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
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Opacity = value;

            Assert.Contains($"\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfOpacityDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 1;

            ((PriceenvelopesSeries)chart.Series[0]).Opacity = defaultValue;

            Assert.DoesNotContain($"\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", defaultValue)}", renderer.RenderHtml());
        }

        #region point

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsClickRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "point", "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.Click = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("click", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsClickDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.Click = defaultValue;

            Assert.DoesNotContain($"click", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "point", "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.Drag = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drag", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.Drag = defaultValue;

            Assert.DoesNotContain($"drag", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDragStartRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "point", "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.DragStart = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("dragStart", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDragStartDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.DragStart = defaultValue;

            Assert.DoesNotContain($"dragStart", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsDropRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "point", "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.Drop = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("drop", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsDropDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.Drop = defaultValue;

            Assert.DoesNotContain($"drop", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOutRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "point", "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.MouseOut = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOut", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOutDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.MouseOut = defaultValue;

            Assert.DoesNotContain($"mouseOut", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsMouseOverRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "point", "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.MouseOver = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("mouseOver", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsMouseOverDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.MouseOver = defaultValue;

            Assert.DoesNotContain($"mouseOver", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsRemoveRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "point", "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.Remove = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("remove", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsRemoveDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.Remove = defaultValue;

            Assert.DoesNotContain($"remove", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsSelectRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "point", "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.Select = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("select", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.Select = defaultValue;

            Assert.DoesNotContain($"select", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUnselectRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "point", "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.Unselect = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("unselect", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUnselectDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.Unselect = defaultValue;

            Assert.DoesNotContain($"unselect", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointEventsUpdateRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "point", "events" };

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.Update = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("update", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointEventsUpdateDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Point.Events.Update = defaultValue;

            Assert.DoesNotContain($"update", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointDescriptionFormatterRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).PointDescriptionFormatter = value;

            Assert.Contains($"\"pointDescriptionFormatter\":{value}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointDescriptionFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).PointDescriptionFormatter = defaultValue;

            Assert.DoesNotContain($"\"pointDescriptionFormatter\":{defaultValue}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool value = true;

            ((PriceenvelopesSeries)chart.Series[0]).RelativeXValue = value;

            Assert.Contains($"\"relativeXValue\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = false;

            ((PriceenvelopesSeries)chart.Series[0]).RelativeXValue = defaultValue;

            Assert.DoesNotContain($"relativeXValue", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool value = true;

            ((PriceenvelopesSeries)chart.Series[0]).Selected = value;

            Assert.Contains($"\"selected\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = false;

            ((PriceenvelopesSeries)chart.Series[0]).Selected = defaultValue;

            Assert.DoesNotContain($"selected", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShadowBoolRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool value = true;

            ((PriceenvelopesSeries)chart.Series[0]).ShadowBool = value;

            Assert.Contains($"\"shadow\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#00ffdd", 10, 20, 30, 40)]
        [InlineData("#ffccaa", 40, 30, 20, 10)]
        public void Test_IfShadowRenders_Correct(string color, int offsetX, int offsetY, double opacity, int width)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Shadow = new Shadow()
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
        public void Test_IfShadowBoolDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = false;

            ((PriceenvelopesSeries)chart.Series[0]).ShadowBool = defaultValue;

            Assert.DoesNotContain($"shadow", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowCheckboxRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool value = true;

            ((PriceenvelopesSeries)chart.Series[0]).ShowCheckbox = value;

            Assert.Contains($"\"showCheckbox\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowCheckboxDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = false;

            ((PriceenvelopesSeries)chart.Series[0]).ShowCheckbox = defaultValue;

            Assert.DoesNotContain($"showCheckbox", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfShowInLegendRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).ShowInLegend = value;

            Assert.Contains($"\"showInLegend\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowInLegendDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).ShowInLegend = null;

            Assert.DoesNotContain($"showInLegend", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfSkipKeyboardNavigationRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).SkipKeyboardNavigation = value;

            Assert.Contains($"\"skipKeyboardNavigation\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSkipKeyboardNavigationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).SkipKeyboardNavigation = null;

            Assert.DoesNotContain($"skipKeyboardNavigation", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSoftThresholdRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool value = false;

            ((PriceenvelopesSeries)chart.Series[0]).SoftThreshold = value;

            Assert.Contains($"\"softThreshold\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSoftThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = true;

            ((PriceenvelopesSeries)chart.Series[0]).SoftThreshold = defaultValue;

            Assert.DoesNotContain($"softThreshold", renderer.RenderHtml());
        }

        #region states

        #region hover

        #region animation
        //fix required - extra slashes in result string
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesHoverAnimationDurationRenders_Correct(int value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var pathToProperty = new List<string>() { "states", "hover", "animation" };

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Animation.Duration = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfStatesHoverAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = -1;

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesHoverEnabledRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "states", "hover" };
            var value = false;

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesHoverEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = true;

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Enabled = defaultValue;

        //    Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        //}

        #region halo

        // fix required - attributes should be hashtable (not object)
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesHoverHaloAttributesRenders_Correct(int value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var pathToProperty = new List<string>() { "states", "hover", "halo" };

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Halo.Attributes = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("attributes", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfStatesHoverHaloAttributesDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = new Hashtable();

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Animation.Duration = defaultValue;

        //    Assert.DoesNotContain($"duration", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(2)]
        [InlineData(0.5)]
        public void Test_IfStatesHoverHaloOpacityRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "states", "hover", "halo" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Halo.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default value for opacity = 0.25 (not null)
        //[Fact]
        //public void Test_IfStatesHoverHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = 0.25;

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Theory]
        //[InlineData(2)]
        //[InlineData(0.5)]
        //public void Test_IfStatesHoverHaloSizeRenders_Correct(double value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var pathToProperty = new List<string>() { "states", "hover", "halo" };

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Halo.Size = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("size", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Fact]
        //public void Test_IfStatesHoverHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = 0.25;

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesHoverLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "states", "hover" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesHoverLineWidthPlusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "states", "hover" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.LineWidthPlus = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidthPlus", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default should be 1 (not null)
        //[Fact]
        //public void Test_IfStatesHoverLineWidthPlusDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    double? defaultValue = 1;

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Hover.LineWidthPlus = defaultValue;

        //    Assert.DoesNotContain($"lineWidthPlus", renderer.RenderHtml());
        //}

        #region marker

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfStatesHoverMarkerEnabledRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "hover", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesHoverMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "hover", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double defaultValue = 2;

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfStatesHoverMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "hover", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.FillColor = value;

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
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = string.Empty;

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesHoverMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "hover", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfStatesHoverMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "hover", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesHoverMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = "#ffffff";

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesHoverMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "hover", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesHoverMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 0;

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesHoverMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "hover", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesHoverMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 4;

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.Radius = defaultValue;

            Assert.DoesNotContain($"radius", renderer.RenderHtml());
        }

        //missing States

        [Theory]
        [InlineData(5)]
        [InlineData(1000)]
        public void Test_IfStatesHoverMarkerWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "hover", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesHoverMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).States.Hover.Marker.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        #endregion

        #endregion

        #region inactive

        #region animation
        //fix required - extra slashes in result string
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesInactiveAnimationDurationRenders_Correct(int value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var pathToProperty = new List<string>() { "states", "inactive", "animation" };

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Inactive.Animation.Duration = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfStatesInactiveAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = -1;

            ((PriceenvelopesSeries)chart.Series[0]).States.Inactive.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesInactiveEnabledRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "states", "inactive" };
            var value = false;

            ((PriceenvelopesSeries)chart.Series[0]).States.Inactive.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesInactiveEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = true;

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Inactive.Enabled = defaultValue;

        //    Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(0.5)]
        public void Test_IfStatesInactiveOpacityRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "states", "inactive" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Inactive.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default value should be 0.2 (not null)
        //[Fact]
        //public void Test_IfStatesInactiveOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = 0.2;

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Inactive.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        #region normal

        //fix required - extra slashes in result string
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesNormalAnimationDurationRenders_Correct(int value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var pathToProperty = new List<string>() { "states", "normal", "animation" };

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Normal.Animation.Duration = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfStatesNormalAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = -1;

            ((PriceenvelopesSeries)chart.Series[0]).States.Normal.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }

        //fix required - missing ..States.Normal.AnimationBool 

        #endregion

        #region select

        #region animation
        //fix required - extra slashes in result string
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesSelectAnimationDurationRenders_Correct(int value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var pathToProperty = new List<string>() { "states", "select", "animation" };

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Select.Animation.Duration = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("duration", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfStatesSelectAnimationDurationDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = -1;

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Animation.Duration = defaultValue;

            Assert.DoesNotContain($"duration", renderer.RenderHtml());
        }
        #endregion

        [Fact]
        public void Test_IfStatesSelectEnabledRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "states", "select" };
            var value = false;

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Enabled = false;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix enabled for default - should be true
        //[Fact]
        //public void Test_IfStatesSelectEnabledDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = true;

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Select.Enabled = defaultValue;

        //    Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        //}

        #region halo

        // fix required - attributes should be hashtable (not object)
        //[Theory]
        //[InlineData(5)]
        //public void Test_IfStatesSelectHaloAttributesRenders_Correct(int value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var pathToProperty = new List<string>() { "states", "select", "halo" };

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Select.Halo.Attributes = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("attributes", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}

        //[Fact]
        //public void Test_IfStatesSelectHaloAttributesDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = new Hashtable();

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Select.Animation.Duration = defaultValue;

        //    Assert.DoesNotContain($"duration", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(2)]
        [InlineData(0.5)]
        public void Test_IfStatesSelectHaloOpacityRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "states", "select", "halo" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Halo.Opacity = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("opacity", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default value for opacity = 0.25 (not null)
        //[Fact]
        //public void Test_IfStatesSelectHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = 0.25;

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Select.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Theory]
        //[InlineData(2)]
        //[InlineData(0.5)]
        //public void Test_IfStatesSelectHaloSizeRenders_Correct(double value)
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var pathToProperty = new List<string>() { "states", "select", "halo" };

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Select.Halo.Size = value;

        //    Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("size", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        //}


        //fix required - size should be double and not hashtable
        //[Fact]
        //public void Test_IfStatesSelectHaloOpacityDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = 0.25;

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Select.Halo.Opacity = defaultValue;

        //    Assert.DoesNotContain($"opacity", renderer.RenderHtml());
        //}

        #endregion

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesSelectLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "states", "select" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2)]
        public void Test_IfStatesSelectLineWidthPlusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "states", "select" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.LineWidthPlus = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidthPlus", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        //fix required - default should be 1 (not null)
        //[Fact]
        //public void Test_IfStatesSelectLineWidthPlusDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    double? defaultValue = 1;

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Select.LineWidthPlus = defaultValue;

        //    Assert.DoesNotContain($"lineWidthPlus", renderer.RenderHtml());
        //}

        #region marker

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfStatesSelectMarkerEnabledRenders_Correct(bool value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "select", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.Enabled = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabled", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.Enabled = defaultValue;

            Assert.DoesNotContain($"enabled", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesSelectMarkerEnabledThresholdRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "select", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.EnabledThreshold = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("enabledThreshold", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerEnabledThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double defaultValue = 2;

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.EnabledThreshold = defaultValue;

            Assert.DoesNotContain($"enabledThreshold", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("red")]
        public void Test_IfStatesSelectMarkerFillColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "select", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.FillColor = value;

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
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = string.Empty;

        //    ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.FillColor = defaultValue;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfStatesSelectMarkerHeightRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "select", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.Height = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("height", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerHeightDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.Height = defaultValue;

            Assert.DoesNotContain($"\"height\":", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#0044ff")]
        public void Test_IfStatesSelectMarkerLineColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "select", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.LineColor = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineColor", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerLineColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = "#ffffff";

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.LineColor = defaultValue;

            Assert.DoesNotContain($"lineColor", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesSelectMarkerLineWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "select", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.LineWidth = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("lineWidth", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerLineWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 0;

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.LineWidth = defaultValue;

            Assert.DoesNotContain($"lineWidth", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfStatesSelectMarkerRadiusRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "select", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.Radius = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("radius", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }


        [Fact]
        public void Test_IfStatesSelectMarkerRadiusDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 4;

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.Radius = defaultValue;

            Assert.DoesNotContain($"radius", renderer.RenderHtml());
        }

        //missing States

        [Theory]
        [InlineData(5)]
        [InlineData(1000)]
        public void Test_IfStatesSelectMarkerWidthRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string> { "states", "select", "marker" };

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.Width = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("width", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStatesSelectMarkerWidthDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).States.Select.Marker.Width = defaultValue;

            Assert.DoesNotContain($"\"width\":", renderer.RenderHtml());
        }

        #endregion

        #endregion

        #endregion


        [Theory]
        [InlineData(PriceenvelopesSeriesStep.Center)]
        [InlineData(PriceenvelopesSeriesStep.Left)]
        [InlineData(PriceenvelopesSeriesStep.Right)]
        public void Test_IfStepRenders_Correct(PriceenvelopesSeriesStep value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Step = value;

            Assert.Contains($"\"step\":\"{chart.FirstCharacterToLower(value.ToString())}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStepDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = PriceenvelopesSeriesStep.Null;

            ((PriceenvelopesSeries)chart.Series[0]).Step = defaultValue;

            Assert.DoesNotContain($"step", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool value = false;

            ((PriceenvelopesSeries)chart.Series[0]).StickyTracking = value;

            Assert.Contains($"\"stickyTracking\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = true;

            ((PriceenvelopesSeries)chart.Series[0]).StickyTracking = defaultValue;

            Assert.DoesNotContain($"stickyTracking", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfThresholdRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).Threshold = value;

            Assert.Contains($"\"threshold\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 0;

            ((PriceenvelopesSeries)chart.Series[0]).Threshold = defaultValue;

            Assert.DoesNotContain($"threshold", renderer.RenderHtml());
        }

        #region tooltip

        [Theory]
        [InlineData("Clustered points: {point.clusterPointsAmount}")]
        public void Test_IfTooltipClusterFormatRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "tooltip" };

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.ClusterFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("clusterFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipClusterFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.ClusterFormat = defaultValue;

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
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "tooltip" };
            var value = new Hashtable();
            value.Add(param, paramValue);

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.DateTimeLabelFormats = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetHashtablePropertyString("dateTimeLabelFormats", param, paramValue)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - hashtable shouldn't be rendered if it's empty
        //[Fact]
        //public void Test_IfTooltipDateTimeLabelFormatsDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = new Hashtable();

        //    ((PriceenvelopesSeries)chart.Series[0]).Tooltip.DateTimeLabelFormats = defaultValue;

        //    Assert.DoesNotContain($"dateTimeLabelFormats", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(10)]
        public void Test_IfTooltipDistanceRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "tooltip" };

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.Distance = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("distance", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipDistanceDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 16;

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.Distance = defaultValue;

            Assert.DoesNotContain($"distance", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipFollowPointerRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "tooltip" };
            var value = true;

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.FollowPointer = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("followPointer", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default should be false (not null)
        //[Fact]
        //public void Test_IfTooltipFollowPointerDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = false;

        //    ((PriceenvelopesSeries)chart.Series[0]).Tooltip.FollowPointer = defaultValue;

        //    Assert.DoesNotContain($"followPointer", renderer.RenderHtml());
        //}

        [Fact]
        public void Test_IfTooltipFollowTouchMoveRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "tooltip" };
            var value = false;

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.FollowTouchMove = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("followTouchMove", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default should be true (not null)
        //[Fact]
        //public void Test_IfTooltipFollowTouchMoveDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = true;

        //    ((PriceenvelopesSeries)chart.Series[0]).Tooltip.FollowTouchMove = defaultValue;

        //    Assert.DoesNotContain($"followTouchMove", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData("</table>")]
        public void Test_IfTooltipFooterFormatRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "tooltip" };

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.FooterFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("footerFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipFooterFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.FooterFormat = defaultValue;

            Assert.DoesNotContain($"footerFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("<table><tr><th colspan='2'>{point.key}</th></tr>")]
        public void Test_IfTooltipHeaderFormatRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "tooltip" };

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.HeaderFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("headerFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipHeaderFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.HeaderFormat = defaultValue;

            Assert.DoesNotContain($"headerFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{series.name}: <b>{point.y}</b><br/>")]
        public void Test_IfTooltipNullFormatRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "tooltip" };

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.NullFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("nullFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipNullFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.NullFormat = defaultValue;

            Assert.DoesNotContain($"nullFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfTooltipNullFormatterRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "tooltip" };

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.NullFormatter = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("nullFormatter", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipNullFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.NullFormatter = defaultValue;

            Assert.DoesNotContain($"nullFormatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("{series.name}: <b>{point.y}</b><br/>")]
        public void Test_IfTooltipPointFormatRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "tooltip" };

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.PointFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("pointFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipPointFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.PointFormat = defaultValue;

            Assert.DoesNotContain($"pointFormat", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction()")]
        public void Test_IfTooltipPointFormatterRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "tooltip" };

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.PointFormatter = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetFunctionPropertyString("pointFormatter", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipPointFormatterDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.PointFormatter = defaultValue;

            Assert.DoesNotContain($"pointFormatter", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(5)]
        public void Test_IfTooltipValueDecimalsRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "tooltip" };

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.ValueDecimals = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("valueDecimals", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipValueDecimalsDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.ValueDecimals = defaultValue;

            Assert.DoesNotContain($"valueDecimals", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("$")]
        public void Test_IfTooltipValuePrefixRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "tooltip" };

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.ValuePrefix = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("valuePrefix", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipValuePrefixDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.ValuePrefix = defaultValue;

            Assert.DoesNotContain($"valuePrefix", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(" USD")]
        public void Test_IfTooltipValueSuffixRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "tooltip" };

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.ValueSuffix = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("valueSuffix", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipValueSuffixDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.ValueSuffix = defaultValue;

            Assert.DoesNotContain($"valueSuffix", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("%Y-%m-%d")]
        public void Test_IfTooltipXDateFormatRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "tooltip" };

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.XDateFormat = value;

            Assert.Contains($"{TH.GetJsonLeadingPath(pathToProperty)}{TH.GetPropertyString("xDateFormat", value)}{TH.GetJsonTrailingString(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTooltipXDateFormatDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;

            ((PriceenvelopesSeries)chart.Series[0]).Tooltip.XDateFormat = defaultValue;

            Assert.DoesNotContain($"xDateFormat", renderer.RenderHtml());
        }
        #endregion

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfTurboThresholdTrackingRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);

            ((PriceenvelopesSeries)chart.Series[0]).TurboThreshold = value;

            Assert.Contains($"\"turboThreshold\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfTurboThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = 1000;

            ((PriceenvelopesSeries)chart.Series[0]).TurboThreshold = defaultValue;

            Assert.DoesNotContain($"turboThreshold", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            bool value = false;

            ((PriceenvelopesSeries)chart.Series[0]).Visible = value;

            Assert.Contains($"\"visible\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = true;

            ((PriceenvelopesSeries)chart.Series[0]).Visible = defaultValue;

            Assert.DoesNotContain($"visible", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZoneAxisRenders_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var value = "x";

            ((PriceenvelopesSeries)chart.Series[0]).ZoneAxis = value;

            Assert.Contains($"\"zoneAxis\":\"{chart.FirstCharacterToLower(value.ToString())}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZoneAxisDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = "y";

            ((PriceenvelopesSeries)chart.Series[0]).ZoneAxis = defaultValue;

            Assert.DoesNotContain($"zoneAxis", renderer.RenderHtml());
        }

        #region zones

        [Theory]
        [InlineData("CSSClassName")]
        public void Test_IfZonesClassNameRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "zones" };
            var zoneDef = new List<PriceenvelopesSeriesZones> { new PriceenvelopesSeriesZones { ClassName = value } };

            ((PriceenvelopesSeries)chart.Series[0]).Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("className", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesClassNameDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;
            var zoneDef = new List<PriceenvelopesSeriesZones> { new PriceenvelopesSeriesZones { ClassName = defaultValue } };

            ((PriceenvelopesSeries)chart.Series[0]).Zones = zoneDef;

            Assert.DoesNotContain($"className", renderer.RenderHtml());
        }


        //fix required - color exists only as a string (should be also gradient and pattern)
        [Theory]
        [InlineData("#0022ff")]
        public void Test_IfZonesColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "zones" };
            var zoneDef = new List<PriceenvelopesSeriesZones> { new PriceenvelopesSeriesZones { Color = value } };

            ((PriceenvelopesSeries)chart.Series[0]).Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("color", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesColorDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = string.Empty;
            var zoneDef = new List<PriceenvelopesSeriesZones> { new PriceenvelopesSeriesZones { Color = defaultValue } };

            ((PriceenvelopesSeries)chart.Series[0]).Zones = zoneDef;

            Assert.DoesNotContain($"color", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(PriceenvelopesSeriesZonesDashStyle.Dash)]
        [InlineData(PriceenvelopesSeriesZonesDashStyle.DashDot)]
        [InlineData(PriceenvelopesSeriesZonesDashStyle.Dot)]
        [InlineData(PriceenvelopesSeriesZonesDashStyle.LongDash)]
        [InlineData(PriceenvelopesSeriesZonesDashStyle.LongDashDot)]
        [InlineData(PriceenvelopesSeriesZonesDashStyle.LongDashDotDot)]
        [InlineData(PriceenvelopesSeriesZonesDashStyle.ShortDash)]
        [InlineData(PriceenvelopesSeriesZonesDashStyle.ShortDashDot)]
        [InlineData(PriceenvelopesSeriesZonesDashStyle.ShortDashDotDot)]
        [InlineData(PriceenvelopesSeriesZonesDashStyle.ShortDot)]
        [InlineData(PriceenvelopesSeriesZonesDashStyle.Solid)]
        public void Test_IfZonesDashStyleRenders_Correct(PriceenvelopesSeriesZonesDashStyle value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "zones" };
            var zoneDef = new List<PriceenvelopesSeriesZones> { new PriceenvelopesSeriesZones { DashStyle = value } };

            ((PriceenvelopesSeries)chart.Series[0]).Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetEnumPropertyString(chart, "dashStyle", value.ToString())}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesDashStyleDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var defaultValue = PriceenvelopesSeriesZonesDashStyle.Null;
            var zoneDef = new List<PriceenvelopesSeriesZones> { new PriceenvelopesSeriesZones { DashStyle = defaultValue } };

            ((PriceenvelopesSeries)chart.Series[0]).Zones = zoneDef;

            Assert.DoesNotContain($"dashStyle", renderer.RenderHtml());
        }

        //fix required - color exists only as a string (should be also gradient and pattern)
        [Theory]
        [InlineData("#0022ff")]
        public void Test_IfZonesFillColorRenders_Correct(string value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "zones" };
            var zoneDef = new List<PriceenvelopesSeriesZones> { new PriceenvelopesSeriesZones { FillColor = value } };

            ((PriceenvelopesSeries)chart.Series[0]).Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("fillColor", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        //fix required - default value for fillColor should be string.Empty (not null) 
        //[Fact]
        //public void Test_IfZonesFillColorDoesntRenderForDefault_Correct()
        //{
        //    var chart = new Highstock();
        //    var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
        //    var defaultValue = string.Empty;
        //    var zoneDef = new List<PriceenvelopesSeriesZones> { new PriceenvelopesSeriesZones { FillColor = defaultValue } };

        //    ((PriceenvelopesSeries)chart.Series[0]).Zones = zoneDef;

        //    Assert.DoesNotContain($"fillColor", renderer.RenderHtml());
        //}

        [Theory]
        [InlineData(5)]
        [InlineData(5000)]
        public void Test_IfZonesValueRenders_Correct(double value)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            var pathToProperty = new List<string>() { "zones" };
            var zoneDef = new List<PriceenvelopesSeriesZones> { new PriceenvelopesSeriesZones { Value = value } };

            ((PriceenvelopesSeries)chart.Series[0]).Zones = zoneDef;

            Assert.Contains($"{TH.GetJsonLeadingPathForList(pathToProperty)}{TH.GetPropertyString("value", value)}{TH.GetJsonTrailingStringForList(pathToProperty)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZonesValueDoesntRenderForDefault_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart); var series = new PriceenvelopesSeries(); chart.Series.Add(series);
            double? defaultValue = null;
            var zoneDef = new List<PriceenvelopesSeriesZones> { new PriceenvelopesSeriesZones { Value = defaultValue } };

            ((PriceenvelopesSeries)chart.Series[0]).Zones = zoneDef;

            Assert.DoesNotContain($"value", renderer.RenderHtml());
        }

        #endregion
    }
}
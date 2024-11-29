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
    public class AreaSeriesTests : IClassFixture<HcFixture>
    {
        protected HcFixture _fixture;

        public AreaSeriesTests(HcFixture fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Area;
        }

        [Fact]
        public void Test_IfSeriesRendersType_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart);
            var series = new AreaSeries();
            chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

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
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); 
            var series = new AreaSeries(); 
            chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).Accessibility = new AreaSeriesAccessibility(); ((AreaSeries)chart.Series[0]).Accessibility.Description = description;
            
            Assert.Contains($"\"accessibility\":{{\"description\":\"{description}\"}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityEnabledRenders_Correct(bool enabled)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series); 

            ((AreaSeries)chart.Series[0]).Accessibility = new AreaSeriesAccessibility(); ((AreaSeries)chart.Series[0]).Accessibility.Enabled = enabled;

            Assert.Contains($"\"accessibility\":{{\"enabled\":{enabled.ToString().ToLower()}}}", renderer.RenderHtml());
        }


        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityExposeAsGroupOnlyRenders_Correct(bool exposeAsGroupOnly)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).Accessibility = new AreaSeriesAccessibility(); ((AreaSeries)chart.Series[0]).Accessibility = new AreaSeriesAccessibility(); ((AreaSeries)chart.Series[0]).Accessibility.ExposeAsGroupOnly = exposeAsGroupOnly;

            Assert.Contains($"\"accessibility\":{{\"exposeAsGroupOnly\":{exposeAsGroupOnly.ToString().ToLower()}}}", renderer.RenderHtml());
        }

        #endregion

        [Fact]
        public void Test_IfAllowPointSelectRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var enabled = true;

            ((AreaSeries)chart.Series[0]).AllowPointSelect = enabled;

            Assert.Contains($"\"allowPointSelect\":{enabled.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAllowPointSelectDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).AllowPointSelect = null;

            Assert.DoesNotContain("allowPointSelect", renderer.RenderHtml());
        }

        #region Animation

        [Fact]
        public void Test_IfAnimationEnabledRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();

            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var enabled = false;

            ((AreaSeries)chart.Series[0]).AnimationBool = enabled;

            Assert.Contains($"\"animation\":{enabled.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAnimationEnabledDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();

            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool? enabled = null;

            ((AreaSeries)chart.Series[0]).AnimationBool = enabled;

            Assert.DoesNotContain("animation", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1000)]
        public void Test_IfAnimationDurationRenders_Correct(int duration)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).Animation = new Animation();
            ((AreaSeries)chart.Series[0]).Animation.Duration = duration;

            Assert.Contains($"\"animation\":{{\"duration\":{duration}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1000)]
        public void Test_IfAnimationDeferRenders_Correct(int defer)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).Animation = new Animation();
            ((AreaSeries)chart.Series[0]).Animation.Defer = defer;

            Assert.Contains($"\"animation\":{{\"defer\":{defer}}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("easingFunctionName")]
        public void Test_IfAnimationEasingRenders_Correct(string easing)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).Animation = new Animation();
            ((AreaSeries)chart.Series[0]).Animation.Easing = easing;

            Assert.Contains($"\"animation\":{{\"easing\":\"{easing}\"}}", renderer.RenderHtml());
        }

        #endregion

        [Theory]
        [InlineData(250)]
        public void Test_IfAnimationLimitRenders_Correct(int limit)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); 
            var series = new AreaSeries(); 
            chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).AnimationLimit = limit;

            Assert.Contains($"\"animationLimit\":{limit}.0", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(AreaSeriesBoostBlending.Add)]
        [InlineData(AreaSeriesBoostBlending.Darken)]
        [InlineData(AreaSeriesBoostBlending.Multiply)]
        public void Test_IfBoostBlendingRenders_Correct(AreaSeriesBoostBlending boostBlending)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).BoostBlending = boostBlending;

            Assert.Contains($"\"boostBlending\":\"{boostBlending.ToString().ToLower()}\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(2000)]
        public void Test_IfBoostThresholdRenders_Correct(int limit)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).BoostThreshold = limit;

            Assert.Contains($"\"boostThreshold\":{limit}.0", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("ClassName")]
        public void Test_IfClassNameRenders_Correct(string className)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).ClassName = className;

            Assert.Contains($"\"className\":\"{className}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = false;

            ((AreaSeries)chart.Series[0]).Clip = value;

            Assert.Contains($"\"clip\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#ffffff")]
        public void Test_IfColorRenders_Correct(string color)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).Color = color;

            Assert.Contains($"\"color\":\"{color.ToString().ToLower()}\"", renderer.RenderHtml());
        }

        //missing logic for GradientColorObject and PatternObject

        [Theory]
        [InlineData("axisId")]
        public void Test_IfColorAxisRendersString_Correct(string id)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).ColorAxis = id;

            Assert.Contains($"\"colorAxis\":\"{id}\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void Test_IfColorAxisRendersNumber_Correct(int index)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).ColorAxisNumber = index;

            Assert.Contains($"\"colorAxis\":{index}.0", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfColorAxisRendersBool_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            ((AreaSeries)chart.Series[0]).ColorAxisBool = value;

            Assert.Contains($"\"colorAxis\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1)]
        public void Test_IfColorIndexRenders_Correct(int value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).ColorIndex = value;

            Assert.Contains($"\"colorIndex\":{value}.0", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("colorValue")]
        public void Test_IfColorKeyRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).ColorKey = value;

            Assert.Contains($"\"colorKey\":\"{value}\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfConnectEndsRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).ConnectEnds = value;

            Assert.Contains($"\"connectEnds\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfConnectNullsRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = true;

            ((AreaSeries)chart.Series[0]).ConnectNulls = value;

            Assert.Contains($"\"connectNulls\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfConnectNullsDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool? value = null;

            ((AreaSeries)chart.Series[0]).ConnectNulls = value;

            Assert.DoesNotContain($"\"connectNulls\"", renderer.RenderHtml());
        }



        [Fact]
        public void Test_IfCrispRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = false;

            ((AreaSeries)chart.Series[0]).Crisp = value;

            Assert.Contains($"\"crisp\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCrispDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool? value = null;

            ((AreaSeries)chart.Series[0]).Crisp = value;

            Assert.DoesNotContain($"\"crisp\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(299)]
        public void Test_IfCropThresholdRenders_Correct(int value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).CropThreshold = value;

            Assert.Contains($"\"cropThreshold\":{value}.0", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfCropThresholdDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var defaultValue = 300;

            ((AreaSeries)chart.Series[0]).CropThreshold = defaultValue;

            Assert.DoesNotContain($"\"crisp\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(AreaSeriesCursor.Default)]
        [InlineData(AreaSeriesCursor.Help)]
        [InlineData(AreaSeriesCursor.Pointer)]
        [InlineData(AreaSeriesCursor.None)]
        public void Test_IfCursorRenders_Correct(AreaSeriesCursor cursor)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).Cursor = cursor;

            Assert.Contains($"\"cursor\":\"{cursor.ToString().ToLower()}\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("dataKey1", "dataValue1")]
        public void Test_IfCustomRenders_Correct(string key1, string value1)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var extraData = new Hashtable() { { key1, value1 } };

            ((AreaSeries)chart.Series[0]).Custom = extraData;

            Assert.Contains($"\"custom\":{{\"{key1}\":\"{value1}\"}}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(AreaSeriesDashStyle.Dash)]
        [InlineData(AreaSeriesDashStyle.DashDot)]
        [InlineData(AreaSeriesDashStyle.Dot)]
        [InlineData(AreaSeriesDashStyle.LongDash)]
        [InlineData(AreaSeriesDashStyle.LongDashDot)]
        [InlineData(AreaSeriesDashStyle.LongDashDotDot)]
        [InlineData(AreaSeriesDashStyle.ShortDash)]
        [InlineData(AreaSeriesDashStyle.ShortDashDot)]
        [InlineData(AreaSeriesDashStyle.ShortDashDotDot)]
        [InlineData(AreaSeriesDashStyle.ShortDot)]
        public void Test_IfDashStyleRenders_Correct(AreaSeriesDashStyle style)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            chart.Chart.Type = _fixture.ChartType;
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var result = style.ToString();
            var replacement = result[0].ToString().ToLower();
            result = result.Remove(0, 1);
            result = replacement + result;

            ((AreaSeries)chart.Series[0]).DashStyle = style;

            Assert.Contains($"\"dashStyle\":\"{result}\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomePlotOptionsDescription")]
        public void Test_IfDescriptionRenders_Correct(string description)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).Description = description;

            Assert.Contains($"\"description\":\"{description}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfEnableMouseTrackingRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = false;

            ((AreaSeries)chart.Series[0]).EnableMouseTracking = value;

            Assert.Contains($"\"enableMouseTracking\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfFindNearestPointByRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = AreaSeriesFindNearestPointBy.Xy;

            ((AreaSeries)chart.Series[0]).FindNearestPointBy = value;

            Assert.Contains($"\"findNearestPointBy\":\"{value.ToString().ToLower()}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfFindNearestPointByDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = AreaSeriesFindNearestPointBy.X;

            ((AreaSeries)chart.Series[0]).FindNearestPointBy = value;

            Assert.DoesNotContain($"\"findNearestPointBy\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfGetExtremesFromAllRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = true;

            ((AreaSeries)chart.Series[0]).GetExtremesFromAll = value;

            Assert.Contains($"\"getExtremesFromAll\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfIncludeInDataExportFromAllRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).IncludeInDataExport = value;

            Assert.Contains($"\"includeInDataExport\":{value.ToString().ToLower()}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfIncludeInDataExportFromAllDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool? value = null;

            ((AreaSeries)chart.Series[0]).IncludeInDataExport = value;

            Assert.DoesNotContain($"\"includeInDataExport\":{value}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("name", "y", "dataLabels.style.visibility", "true")]
        public void Test_IfKeysRenders_Correct(string arg1, string arg2, string arg3, string arg4)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = new List<string> { arg1, arg2, arg3, arg4 };

            ((AreaSeries)chart.Series[0]).Keys = value;

            Assert.Contains($"\"keys\":[\"{arg1}\",\"{arg2}\",\"{arg3}\",\"{arg4}\"]", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void Test_IfLineWidthRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).LineWidth = value;

            Assert.Contains($"\"lineWidth\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(":previous")]
        [InlineData("IdAnotherSeries")]
        public void Test_IfLinkedToRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).LinkedTo = value;

            Assert.Contains($"\"linkedTo\":\"{value}\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#FF0000")]
        [InlineData("#0088FF")]
        public void Test_IfNegativeColorRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).NegativeColor = value;

            Assert.Contains($"\"negativeColor\":\"{value}\"", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfOpacityRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).Opacity = value;

            Assert.Contains($"\"opacity\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("SomeFunction")]
        public void Test_IfPointDescriptionFormatterRenders_Correct(string value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).PointDescriptionFormatter = value;

            Assert.Contains($"\"pointDescriptionFormatter\":{value}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfPointIntervalRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).PointInterval = value;

            Assert.Contains($"\"pointInterval\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(AreaSeriesPointIntervalUnit.Day)]
        [InlineData(AreaSeriesPointIntervalUnit.Month)]
        [InlineData(AreaSeriesPointIntervalUnit.Year)]
        public void Test_IfPointIntervalUnitRenders_Correct(AreaSeriesPointIntervalUnit value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).PointIntervalUnit = value;

            Assert.Contains($"\"pointIntervalUnit\":\"{chart.FirstCharacterToLower(value.ToString())}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfPointIntervalUnitDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var defaultValue = AreaSeriesPointIntervalUnit.Null;

            ((AreaSeries)chart.Series[0]).PointIntervalUnit = defaultValue;

            Assert.DoesNotContain($"pointIntervalUnit", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        public void Test_IfPointStartRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).PointStart = value;

            Assert.Contains($"\"pointStart\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRelativeXValueRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = true;

            ((AreaSeries)chart.Series[0]).RelativeXValue = value;

            Assert.Contains($"\"relativeXValue\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSelectedRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = true;

            ((AreaSeries)chart.Series[0]).Selected = value;

            Assert.Contains($"\"selected\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShadowBoolRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = true;

            ((AreaSeries)chart.Series[0]).ShadowBool = value;

            Assert.Contains($"\"shadow\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData("#00ffdd", 10, 20, 30, 40)]
        [InlineData("#ffccaa", 40, 30, 20, 10)]
        public void Test_IfShadowRenders_Correct(string color, int offsetX, int offsetY, double opacity, int width)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).Shadow = new Shadow()
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
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = true;

            ((AreaSeries)chart.Series[0]).ShowCheckbox = value;

            Assert.Contains($"\"showCheckbox\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfShowInLegendRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).ShowInLegend = value;

            Assert.Contains($"\"showInLegend\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfShowInLegendDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).ShowInLegend = null;

            Assert.DoesNotContain($"showInLegend", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfSkipKeyboardNavigationRenders_Correct(bool value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).SkipKeyboardNavigation = value;

            Assert.Contains($"\"skipKeyboardNavigation\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSkipKeyboardNavigationDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).SkipKeyboardNavigation = null;

            Assert.DoesNotContain($"skipKeyboardNavigation", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfSoftThresholdRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = false;

            ((AreaSeries)chart.Series[0]).SoftThreshold = value;

            Assert.Contains($"\"softThreshold\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(AreaSeriesStacking.Overlap)]
        [InlineData(AreaSeriesStacking.Percent)]
        [InlineData(AreaSeriesStacking.Normal)]
        [InlineData(AreaSeriesStacking.Stream)]
        public void Test_IfStackingRenders_Correct(AreaSeriesStacking value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).Stacking = value;

            Assert.Contains($"\"stacking\":\"{chart.FirstCharacterToLower(value.ToString())}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStackingDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var defaultValue = AreaSeriesStacking.Null;

            ((AreaSeries)chart.Series[0]).Stacking = defaultValue;

            Assert.DoesNotContain($"stacking", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(AreaSeriesStep.Center)]
        [InlineData(AreaSeriesStep.Left)]
        [InlineData(AreaSeriesStep.Right)]
        public void Test_IfStepRenders_Correct(AreaSeriesStep value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).Step = value;

            Assert.Contains($"\"step\":\"{chart.FirstCharacterToLower(value.ToString())}\"", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStepDoesntRenderForDefault_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var defaultValue = AreaSeriesStep.Null;

            ((AreaSeries)chart.Series[0]).Step = defaultValue;

            Assert.DoesNotContain($"step", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfStickyTrackingRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = false;

            ((AreaSeries)chart.Series[0]).StickyTracking = value;

            Assert.Contains($"\"stickyTracking\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfThresholdRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).Threshold = value;

            Assert.Contains($"\"threshold\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}", renderer.RenderHtml());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void Test_IfTurboThresholdTrackingRenders_Correct(double value)
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);

            ((AreaSeries)chart.Series[0]).TurboThreshold = value;

            Assert.Contains($"\"turboThreshold\":{string.Format(new CultureInfo("en-us"), "{0:N1}", value)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfVisibleRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            bool value = false;

            ((AreaSeries)chart.Series[0]).Visible = value;

            Assert.Contains($"\"visible\":{chart.FirstCharacterToLower(value.ToString())}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfZoneAxisRenders_Correct()
        {
            var chart = new Highcharts(); chart.Chart = new Chart();
            var renderer = new HighchartsRenderer(chart); var series = new AreaSeries(); chart.Series = new List<Highsoft.Web.Mvc.Charts.Series>(); chart.Series.Add(series);
            var value = "x";

            ((AreaSeries)chart.Series[0]).ZoneAxis = value;

            Assert.Contains($"\"zoneAxis\":\"{chart.FirstCharacterToLower(value.ToString())}\"", renderer.RenderHtml());
        }
    }
}
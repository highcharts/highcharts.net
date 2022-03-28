using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;

namespace UnitTests
{
    public class PlotOptionSeriesTest
    {
        //private ChartType

        Highcharts _chart;
        HighchartsRenderer _renderer;

        //private BaseObject GetPlotOption()
        //{
        //    //switch(_chart.Chart.Type)



        //    return _chart.PlotOptions.Line;
        //}

        public PlotOptionSeriesTest()
        {
            _chart = new Highcharts();
            _renderer = new HighchartsRenderer(_chart);
        }

        public PlotOptionSeriesTest(ChartType chartType) : this()
        {
            _chart.Chart.Type = chartType;
        }

        [Theory]
        [InlineData("Description")]
        public void Test_IfAccessibilityDescriptionRenders_Correct(string description)
        {
            _chart.PlotOptions.Series.Accessibility.Description = description;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"description\":\"{description}\"}}}}}}", _renderer.RenderHtml());
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityEnabledRenders_Correct(bool enabled)
        {
            _chart.PlotOptions.Series.Accessibility.Enabled = enabled;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"enabled\":{enabled.ToString().ToLower()}}}}}}}", _renderer.RenderHtml());
        }


        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityExposeAsGroupOnlyRenders_Correct(bool exposeAsGroupOnly)
        {
            _chart.PlotOptions.Series.Accessibility.ExposeAsGroupOnly = exposeAsGroupOnly;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"exposeAsGroupOnly\":{exposeAsGroupOnly.ToString().ToLower()}}}}}}}", _renderer.RenderHtml());
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Test_IfAccessibilityKeyboardNavigationEnabledRenders_Correct(bool enabled)
        {
            _chart.PlotOptions.Series.Accessibility.KeyboardNavigation.Enabled = enabled;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"keyboardNavigation\":{{\"enabled\":{enabled.ToString().ToLower()}}}}}}}}}", _renderer.RenderHtml());
        }

        [Theory]
        [InlineData("FormatterFunction")]
        public void Test_IfAccessibilityPointDescriptionFormatterRenders_Correct(string function)
        {
            _chart.PlotOptions.Series.Accessibility.Point.DescriptionFormatter = function;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"accessibility\":{{\"point\":{{\"descriptionFormatter\":{function}}}}}}}}}", _renderer.RenderHtml());
        }
        //missing tests for the rest of Point members

        [Fact]
        public void Test_IfAllowPointSelectRenders_Correct()
        {
            var enabled = true;
            _chart.PlotOptions.Series.AllowPointSelect = enabled;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"allowPointSelect\":{enabled.ToString().ToLower()}}}}}", _renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAllowPointSelectDoesntRenderForDefault_Correct()
        {
            _chart.PlotOptions.Series.AllowPointSelect = false;

            Assert.DoesNotContain("allowPointSelect", _renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfAnimationEnabledRenders_Correct()
        {
            var enabled = true;
            _chart.PlotOptions.Series.AnimationBool = enabled;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"animation\":{enabled.ToString().ToLower()}}}}}", _renderer.RenderHtml());
        }

        //Animation.Defer missing

        [Fact]
        public void Test_IfAnimationDurationRenders_Correct()
        {
            var value = 1000;
            _chart.PlotOptions.Series.Animation.Duration = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"animation\":{{\"duration\":{value}}}}}}}", _renderer.RenderHtml());
        }

        //There are other members in Animation which are not present in json file

        [Fact]
        public void Test_IfAnimationLimitRenders_Correct()
        {
            var limit = 250;
            _chart.PlotOptions.Series.AnimationLimit = limit;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"animationLimit\":{limit}}}}}", _renderer.RenderHtml());
        }

        //missing boostBlending

        [Fact]
        public void Test_IfBoostThresholdRenders_Correct()
        {
            var limit = 2000;
            _chart.PlotOptions.Series.BoostThreshold = limit;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"boostThreshold\":{limit}}}}}", _renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfBoostThresholdDoesntRenderForDefault_Correct()
        {
            var defaultValue = 5000;
            _chart.PlotOptions.Series.BoostThreshold = defaultValue;

            Assert.DoesNotContain("boostThreshold", _renderer.RenderHtml());
        }

        //missing borderColor
        //missing borderWidth

        [Fact]
        public void Test_IfClassNameRenders_Correct()
        {
            var className = "ClassName";
            _chart.PlotOptions.Series.ClassName = className;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"className\":\"{className}\"}}}}", _renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipRenders_Correct()
        {
            var value = false;
            _chart.PlotOptions.Series.Clip = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"clip\":{value.ToString().ToLower()}}}}}", _renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfClipDoesntRenderForDefault_Correct()
        {
            var value = true;
            _chart.PlotOptions.Series.Clip = value;

            Assert.DoesNotContain("clip", _renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfColorRenders_Correct()
        {
            var value = "#ffffff";
            _chart.PlotOptions.Series.Color = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"color\":\"{value.ToString().ToLower()}\"}}}}", _renderer.RenderHtml());
        }

        //missing logic for GradientColorObject and PatternObject

        [Fact]
        public void Test_IfColorAxisRendersString_Correct()
        {
            var value = "axisId";
            _chart.PlotOptions.Series.ColorAxis = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"colorAxis\":\"{value}\"}}}}", _renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfColorAxisRendersNumber_Correct()
        {
            var value = 2;
            _chart.PlotOptions.Series.ColorAxisNumber = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"colorAxis\":{value}}}}}", _renderer.RenderHtml());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Test_IfColorAxisRendersBool_Correct(bool value)
        {
            _chart.PlotOptions.Series.ColorAxisBool = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"colorAxis\":{value.ToString().ToLower()}}}}}", _renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfColorKeyRenders_Correct()
        {
            var value = "colorValue";
            _chart.PlotOptions.Series.ColorKey = value;

            Assert.Contains($"\"plotOptions\":{{\"series\":{{\"colorKey\":\"{value}\"}}}}", _renderer.RenderHtml());
        }
    }
}

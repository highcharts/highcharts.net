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
using System.Runtime.CompilerServices;

namespace HS
{
    public class HighstockTests : IClassFixture<HsFixture>
    {
        protected HsFixture _fixture;

        public HighstockTests(HsFixture fixture) 
        {
            _fixture = fixture;
        }


        #region RangeSelector


        #region DataGrouping

        [Theory]
        [InlineData("middle")]
        [InlineData("end")]
        public void Test_IfRangeSelectorButtonDataGroupingAnchorRenders_Correct(string anchor) 
        { 
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.RangeSelector.Buttons = new List<RangeSelectorButton>
            {
                new RangeSelectorButton()
                {
                    DataGrouping = new RangeSelectorButtonDataGrouping()
                    {
                        Anchor = anchor
                    }
                }
            };

            Assert.Contains($"\"dataGrouping\":{{{TH.GetPropertyString(nameof(anchor), anchor)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRangeSelectorButtonDataGroupingAnchorDoesntRender_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var anchor = "start";

            chart.RangeSelector.Buttons = new List<RangeSelectorButton>
            {
                new RangeSelectorButton()
                {
                    DataGrouping = new RangeSelectorButtonDataGrouping()
                    {
                        Anchor = anchor
                    }
                }
            };

            Assert.DoesNotContain(nameof(anchor), renderer.RenderHtml());
        }

        [Theory]
        [InlineData("approximationFunction")]
        public void Test_IfRangeSelectorButtonDataGroupingApproximationRenders_Correct(string approximation)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);

            chart.RangeSelector.Buttons = new List<RangeSelectorButton>
            {
                new RangeSelectorButton()
                {
                    DataGrouping = new RangeSelectorButtonDataGrouping()
                    {
                        Approximation = approximation
                    }
                }
            };

            Assert.Contains($"\"dataGrouping\":{{{TH.GetFunctionPropertyString(nameof(approximation), approximation)}", renderer.RenderHtml());
        }

        [Fact]
        public void Test_IfRangeSelectorButtonDataGroupingApproximationDoesntRender_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var approximation = "";

            chart.RangeSelector.Buttons = new List<RangeSelectorButton>
            {
                new RangeSelectorButton()
                {
                    DataGrouping = new RangeSelectorButtonDataGrouping()
                    {
                        Approximation = approximation
                    }
                }
            };

            Assert.DoesNotContain(nameof(approximation), renderer.RenderHtml());
        }

        //this should rather return a list of string instead of one string per time frame
        [Theory]
        [InlineData("day", "%A, %b %e, %Y")]
        [InlineData("hour", "%A, %b %e, %H:%M")]
        [InlineData("milisecond", "%A, %b %e, %H:%M:%S.%L")]
        [InlineData("minute", "%A, %b %e, %H:%M")]
        [InlineData("month", "%B %Y")]
        [InlineData("second", "%A, %b %e, %H:%M:%S")]
        [InlineData("week", "Week from %A, %b %e, %Y")]
        [InlineData("year", "%Y")]
        public void Test_IfRangeSelectorButtonDataGroupingDateTimeLabelFormatsRenders_Correct(string param, string paramValue)
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            var pathToProperty = new List<string>() { "rangeSelector", "buttons", "dataGrouping"};
            var dateTimeLabelFormats = new Hashtable() { { param, paramValue } };

            chart.RangeSelector.Buttons = new List<RangeSelectorButton>
            {
                new RangeSelectorButton()
                {
                    DataGrouping = new RangeSelectorButtonDataGrouping()
                    {
                        DateTimeLabelFormats = dateTimeLabelFormats
                    }
                }
            };

            var result = renderer.RenderHtml();

            Assert.Contains($"{TH.GetHashtablePropertyString("dateTimeLabelFormats", param, paramValue)}", result);
        }

        //fix required - hashtable shouldn't be rendered if it's empty
        [Fact]
        public void Test_IfRangeSelectorButtonDataGroupingDateTimeLabelFormatsDoesntRender_Correct()
        {
            var chart = new Highstock();
            var renderer = new HighstockRenderer(chart);
            //var dateTimeLabelFormats = new Hashtable();

            //chart.RangeSelector.Buttons = new List<RangeSelectorButton>
            //{
            //    new RangeSelectorButton()
            //    {
            //        DataGrouping = new RangeSelectorButtonDataGrouping()
            //        {
            //            DateTimeLabelFormats = dateTimeLabelFormats
            //        }
            //    }
            //};

            Assert.DoesNotContain("dateTimeLabelFormats", renderer.RenderHtml());
        }
        #endregion

        #endregion
    }
}

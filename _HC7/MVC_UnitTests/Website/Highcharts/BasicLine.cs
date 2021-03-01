using Highsoft.Web.Mvc.Charts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MVC_UnitTests.Website
{
    [TestClass]
    public class BasicLine
    {
        List<LineSeriesData> _tokyoData = new List<LineSeriesData>();
        List<LineSeriesData> _nyData = new List<LineSeriesData>();
        List<LineSeriesData> _berlinData = new List<LineSeriesData>();
        List<LineSeriesData> _londonData = new List<LineSeriesData>();

        Highcharts _highcharts;
        HighsoftNamespace _highsoft;


        [TestInitialize]
        public void TestInit()
        {
            PrepareSeries();
            _highcharts = GetHighcharts();
            _highsoft = new HighsoftNamespace();
        }

        private void PrepareSeries()
        {
            List<double> tokyoValues = new List<double> { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 };
            List<double> nyValues = new List<double> { -0.2, 0.8, 5.7, 11.3, 17.0, 22.0, 24.8, 24.1, 20.1, 14.1, 8.6, 2.5 };
            List<double> berlinValues = new List<double> { -0.9, 0.6, 3.5, 8.4, 13.5, 17.0, 18.6, 17.9, 14.3, 9.0, 3.9, 1.0 };
            List<double> londonValues = new List<double> { 3.9, 4.2, 5.7, 8.5, 11.9, 15.2, 17.0, 16.6, 14.2, 10.3, 6.6, 4.8 };

            tokyoValues.ForEach(p => _tokyoData.Add(new LineSeriesData { Y = p }));
            nyValues.ForEach(p => _nyData.Add(new LineSeriesData { Y = p }));
            berlinValues.ForEach(p => _berlinData.Add(new LineSeriesData { Y = p }));
            londonValues.ForEach(p => _londonData.Add(new LineSeriesData { Y = p }));
        }

        private Highcharts GetHighcharts()
        {
            return new Highcharts
            {
                Title = new Title
                {
                    Text = "Monthly Average Temperature",
                    X = -20
                },
                Subtitle = new Subtitle
                {
                    Text = "Source: WorldClimate.com",
                    X = -20
                },
                XAxis = new List<XAxis>
            {
                new XAxis
                {
                    Categories = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                                "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" },

                }
            },
                YAxis = new List<YAxis>
            {
                new YAxis
                {
                    Title = new YAxisTitle
                    {
                        Text = "Temperature (°C)"
                    },
                    PlotLines = new List<YAxisPlotLines>
                    {
                            new YAxisPlotLines
                        {
                            Value = 0,
                            Width = 1,
                            Color = "#808080"
                        }
                    }
                }
            },
                Tooltip = new Tooltip
                {
                    ValueSuffix = "°C"
                },
                Legend = new Legend
                {
                    Layout = LegendLayout.Vertical,
                    Align = LegendAlign.Right,
                    VerticalAlign = LegendVerticalAlign.Middle,
                    BorderWidth = 0
                },
                Series = new List<Series>
            {
                new LineSeries
                {
                    Name = "Tokyo",
                    Data = _tokyoData
                },
                new LineSeries
                {
                    Name = "NY",
                    Data = _nyData
                },
                new LineSeries
                {
                    Name = "Berlin",
                    Data = _berlinData
                },
                new LineSeries
                {
                    Name = "London",
                    Data = _londonData
                }
            }
            };
        }

        [TestMethod]
        public void Test_IfBasicLineChartRendersWithContainer_Correct()
        {
            string script = "<script type='text/javascript'>if (document.addEventListener) {document.addEventListener(\"DOMContentLoaded\", function() {createChartchart();});} else if (document.attachEvent) {document.attachEvent(\"onreadystatechange\", function(){if (document.readyState === \"complete\"){document.detachEvent(\"onreadystatechange\", arguments.callee);createChartchart();}});}function createChartchart() {var ChartOptions = {\"tooltip\":{\"valueSuffix\":\"°C\"},\"chart\":{\"renderTo\":\"chart\"},\"series\":[{\"data\":[{\"y\":7},{\"y\":6.9},{\"y\":9.5},{\"y\":14.5},{\"y\":18.2},{\"y\":21.5},{\"y\":25.2},{\"y\":26.5},{\"y\":23.3},{\"y\":18.3},{\"y\":13.9},{\"y\":9.6}],\"type\":\"line\",\"name\":\"Tokyo\"},{\"data\":[{\"y\":-0.2},{\"y\":0.8},{\"y\":5.7},{\"y\":11.3},{\"y\":17},{\"y\":22},{\"y\":24.8},{\"y\":24.1},{\"y\":20.1},{\"y\":14.1},{\"y\":8.6},{\"y\":2.5}],\"type\":\"line\",\"name\":\"NY\"},{\"data\":[{\"y\":-0.9},{\"y\":0.6},{\"y\":3.5},{\"y\":8.4},{\"y\":13.5},{\"y\":17},{\"y\":18.6},{\"y\":17.9},{\"y\":14.3},{\"y\":9},{\"y\":3.9},{\"y\":1}],\"type\":\"line\",\"name\":\"Berlin\"},{\"data\":[{\"y\":3.9},{\"y\":4.2},{\"y\":5.7},{\"y\":8.5},{\"y\":11.9},{\"y\":15.2},{\"y\":17},{\"y\":16.6},{\"y\":14.2},{\"y\":10.3},{\"y\":6.6},{\"y\":4.8}],\"type\":\"line\",\"name\":\"London\"}],\"yAxis\":[{\"plotLines\":[{\"value\":0,\"color\":\"#808080\",\"width\":1}],\"title\":{\"text\":\"Temperature (°C)\"}}],\"subtitle\":{\"text\":\"Source: WorldClimate.com\",\"x\":-20},\"title\":{\"text\":\"Monthly Average Temperature\",\"x\":-20},\"xAxis\":[{\"categories\":[\"Jan\",\"Feb\",\"Mar\",\"Apr\",\"May\",\"Jun\",\"Jul\",\"Aug\",\"Sep\",\"Oct\",\"Nov\",\"Dec\"]}],\"legend\":{\"verticalAlign\":\"middle\",\"layout\":\"vertical\",\"align\":\"right\"}};new Highcharts.chart(\"chart\",ChartOptions);}</script>";

            string result = _highsoft.GetHighcharts(_highcharts, "chart", true, null);

            string container = $"<div id='{_highcharts.Chart.RenderTo}' style='height:{_highcharts.Chart.Height};min-width:{_highcharts.Chart.Width};clear:both;margin: 0 auto;'></div>";
            string expected = container + script;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_IfBasicLineChartRendersWithContainerWithoutMethodParameters_Correct()
        {
            string script = "<script type='text/javascript'>if (document.addEventListener) {document.addEventListener(\"DOMContentLoaded\", function() {createChartchart();});} else if (document.attachEvent) {document.attachEvent(\"onreadystatechange\", function(){if (document.readyState === \"complete\"){document.detachEvent(\"onreadystatechange\", arguments.callee);createChartchart();}});}function createChartchart() {var ChartOptions = {\"tooltip\":{\"valueSuffix\":\"°C\"},\"chart\":{\"renderTo\":\"chart\"},\"series\":[{\"data\":[{\"y\":7},{\"y\":6.9},{\"y\":9.5},{\"y\":14.5},{\"y\":18.2},{\"y\":21.5},{\"y\":25.2},{\"y\":26.5},{\"y\":23.3},{\"y\":18.3},{\"y\":13.9},{\"y\":9.6}],\"type\":\"line\",\"name\":\"Tokyo\"},{\"data\":[{\"y\":-0.2},{\"y\":0.8},{\"y\":5.7},{\"y\":11.3},{\"y\":17},{\"y\":22},{\"y\":24.8},{\"y\":24.1},{\"y\":20.1},{\"y\":14.1},{\"y\":8.6},{\"y\":2.5}],\"type\":\"line\",\"name\":\"NY\"},{\"data\":[{\"y\":-0.9},{\"y\":0.6},{\"y\":3.5},{\"y\":8.4},{\"y\":13.5},{\"y\":17},{\"y\":18.6},{\"y\":17.9},{\"y\":14.3},{\"y\":9},{\"y\":3.9},{\"y\":1}],\"type\":\"line\",\"name\":\"Berlin\"},{\"data\":[{\"y\":3.9},{\"y\":4.2},{\"y\":5.7},{\"y\":8.5},{\"y\":11.9},{\"y\":15.2},{\"y\":17},{\"y\":16.6},{\"y\":14.2},{\"y\":10.3},{\"y\":6.6},{\"y\":4.8}],\"type\":\"line\",\"name\":\"London\"}],\"yAxis\":[{\"plotLines\":[{\"value\":0,\"color\":\"#808080\",\"width\":1}],\"title\":{\"text\":\"Temperature (°C)\"}}],\"subtitle\":{\"text\":\"Source: WorldClimate.com\",\"x\":-20},\"title\":{\"text\":\"Monthly Average Temperature\",\"x\":-20},\"xAxis\":[{\"categories\":[\"Jan\",\"Feb\",\"Mar\",\"Apr\",\"May\",\"Jun\",\"Jul\",\"Aug\",\"Sep\",\"Oct\",\"Nov\",\"Dec\"]}],\"legend\":{\"verticalAlign\":\"middle\",\"layout\":\"vertical\",\"align\":\"right\"}};new Highcharts.chart(\"chart\",ChartOptions);}</script>";

            string result = _highsoft.GetHighcharts(_highcharts, "chart");

            string container = $"<div id='{_highcharts.Chart.RenderTo}' style='height:{_highcharts.Chart.Height};min-width:{_highcharts.Chart.Width};clear:both;margin: 0 auto;'></div>";
            string expected = container + script;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_IfBasicLineChartRendersWithoutContainer_Correct()
        {
            string script = "<script type='text/javascript'>if (document.addEventListener) {document.addEventListener(\"DOMContentLoaded\", function() {createChartchart();});} else if (document.attachEvent) {document.attachEvent(\"onreadystatechange\", function(){if (document.readyState === \"complete\"){document.detachEvent(\"onreadystatechange\", arguments.callee);createChartchart();}});}function createChartchart() {var ChartOptions = {\"tooltip\":{\"valueSuffix\":\"°C\"},\"chart\":{\"renderTo\":\"chart\"},\"series\":[{\"data\":[{\"y\":7},{\"y\":6.9},{\"y\":9.5},{\"y\":14.5},{\"y\":18.2},{\"y\":21.5},{\"y\":25.2},{\"y\":26.5},{\"y\":23.3},{\"y\":18.3},{\"y\":13.9},{\"y\":9.6}],\"type\":\"line\",\"name\":\"Tokyo\"},{\"data\":[{\"y\":-0.2},{\"y\":0.8},{\"y\":5.7},{\"y\":11.3},{\"y\":17},{\"y\":22},{\"y\":24.8},{\"y\":24.1},{\"y\":20.1},{\"y\":14.1},{\"y\":8.6},{\"y\":2.5}],\"type\":\"line\",\"name\":\"NY\"},{\"data\":[{\"y\":-0.9},{\"y\":0.6},{\"y\":3.5},{\"y\":8.4},{\"y\":13.5},{\"y\":17},{\"y\":18.6},{\"y\":17.9},{\"y\":14.3},{\"y\":9},{\"y\":3.9},{\"y\":1}],\"type\":\"line\",\"name\":\"Berlin\"},{\"data\":[{\"y\":3.9},{\"y\":4.2},{\"y\":5.7},{\"y\":8.5},{\"y\":11.9},{\"y\":15.2},{\"y\":17},{\"y\":16.6},{\"y\":14.2},{\"y\":10.3},{\"y\":6.6},{\"y\":4.8}],\"type\":\"line\",\"name\":\"London\"}],\"yAxis\":[{\"plotLines\":[{\"value\":0,\"color\":\"#808080\",\"width\":1}],\"title\":{\"text\":\"Temperature (°C)\"}}],\"subtitle\":{\"text\":\"Source: WorldClimate.com\",\"x\":-20},\"title\":{\"text\":\"Monthly Average Temperature\",\"x\":-20},\"xAxis\":[{\"categories\":[\"Jan\",\"Feb\",\"Mar\",\"Apr\",\"May\",\"Jun\",\"Jul\",\"Aug\",\"Sep\",\"Oct\",\"Nov\",\"Dec\"]}],\"legend\":{\"verticalAlign\":\"middle\",\"layout\":\"vertical\",\"align\":\"right\"}};new Highcharts.chart(\"chart\",ChartOptions);}</script>";

            string result = _highsoft.GetHighcharts(_highcharts, "chart", false);

            Assert.AreEqual(script, result);
        }

        [TestMethod]
        public void Test_IfBasicLineChartRendersJavascriptFunction_Correct()
        {
            string functionName = "createChart";
            string renderTo = "chart";
            string script = "<script type='text/javascript'>function "+functionName+"() {var ChartOptions = {\"tooltip\":{\"valueSuffix\":\"°C\"},\"chart\":{\"renderTo\":\""+renderTo+"\"},\"series\":[{\"data\":[{\"y\":7},{\"y\":6.9},{\"y\":9.5},{\"y\":14.5},{\"y\":18.2},{\"y\":21.5},{\"y\":25.2},{\"y\":26.5},{\"y\":23.3},{\"y\":18.3},{\"y\":13.9},{\"y\":9.6}],\"type\":\"line\",\"name\":\"Tokyo\"},{\"data\":[{\"y\":-0.2},{\"y\":0.8},{\"y\":5.7},{\"y\":11.3},{\"y\":17},{\"y\":22},{\"y\":24.8},{\"y\":24.1},{\"y\":20.1},{\"y\":14.1},{\"y\":8.6},{\"y\":2.5}],\"type\":\"line\",\"name\":\"NY\"},{\"data\":[{\"y\":-0.9},{\"y\":0.6},{\"y\":3.5},{\"y\":8.4},{\"y\":13.5},{\"y\":17},{\"y\":18.6},{\"y\":17.9},{\"y\":14.3},{\"y\":9},{\"y\":3.9},{\"y\":1}],\"type\":\"line\",\"name\":\"Berlin\"},{\"data\":[{\"y\":3.9},{\"y\":4.2},{\"y\":5.7},{\"y\":8.5},{\"y\":11.9},{\"y\":15.2},{\"y\":17},{\"y\":16.6},{\"y\":14.2},{\"y\":10.3},{\"y\":6.6},{\"y\":4.8}],\"type\":\"line\",\"name\":\"London\"}],\"yAxis\":[{\"plotLines\":[{\"value\":0,\"color\":\"#808080\",\"width\":1}],\"title\":{\"text\":\"Temperature (°C)\"}}],\"subtitle\":{\"text\":\"Source: WorldClimate.com\",\"x\":-20},\"title\":{\"text\":\"Monthly Average Temperature\",\"x\":-20},\"xAxis\":[{\"categories\":[\"Jan\",\"Feb\",\"Mar\",\"Apr\",\"May\",\"Jun\",\"Jul\",\"Aug\",\"Sep\",\"Oct\",\"Nov\",\"Dec\"]}],\"legend\":{\"verticalAlign\":\"middle\",\"layout\":\"vertical\",\"align\":\"right\"}};new Highcharts.chart(\"chart\",ChartOptions);}</script>";

            string result = _highsoft.GetHighcharts(_highcharts, renderTo, false, functionName);

            Assert.AreEqual(script, result);
        }

        [TestMethod]
        public void Test_IfBasicLineChartRendersJavascriptWithoutFunction_Correct()
        {
            string renderTo = "chart";
            string script = "<script type='text/javascript'>var ChartOptions = {\"tooltip\":{\"valueSuffix\":\"°C\"},\"chart\":{\"renderTo\":\"" + renderTo + "\"},\"series\":[{\"data\":[{\"y\":7},{\"y\":6.9},{\"y\":9.5},{\"y\":14.5},{\"y\":18.2},{\"y\":21.5},{\"y\":25.2},{\"y\":26.5},{\"y\":23.3},{\"y\":18.3},{\"y\":13.9},{\"y\":9.6}],\"type\":\"line\",\"name\":\"Tokyo\"},{\"data\":[{\"y\":-0.2},{\"y\":0.8},{\"y\":5.7},{\"y\":11.3},{\"y\":17},{\"y\":22},{\"y\":24.8},{\"y\":24.1},{\"y\":20.1},{\"y\":14.1},{\"y\":8.6},{\"y\":2.5}],\"type\":\"line\",\"name\":\"NY\"},{\"data\":[{\"y\":-0.9},{\"y\":0.6},{\"y\":3.5},{\"y\":8.4},{\"y\":13.5},{\"y\":17},{\"y\":18.6},{\"y\":17.9},{\"y\":14.3},{\"y\":9},{\"y\":3.9},{\"y\":1}],\"type\":\"line\",\"name\":\"Berlin\"},{\"data\":[{\"y\":3.9},{\"y\":4.2},{\"y\":5.7},{\"y\":8.5},{\"y\":11.9},{\"y\":15.2},{\"y\":17},{\"y\":16.6},{\"y\":14.2},{\"y\":10.3},{\"y\":6.6},{\"y\":4.8}],\"type\":\"line\",\"name\":\"London\"}],\"yAxis\":[{\"plotLines\":[{\"value\":0,\"color\":\"#808080\",\"width\":1}],\"title\":{\"text\":\"Temperature (°C)\"}}],\"subtitle\":{\"text\":\"Source: WorldClimate.com\",\"x\":-20},\"title\":{\"text\":\"Monthly Average Temperature\",\"x\":-20},\"xAxis\":[{\"categories\":[\"Jan\",\"Feb\",\"Mar\",\"Apr\",\"May\",\"Jun\",\"Jul\",\"Aug\",\"Sep\",\"Oct\",\"Nov\",\"Dec\"]}],\"legend\":{\"verticalAlign\":\"middle\",\"layout\":\"vertical\",\"align\":\"right\"}};new Highcharts.chart(\"chart\",ChartOptions);</script>";

            string result = _highsoft.GetHighchartsJS(_highcharts, renderTo);

            Assert.AreEqual(script, result);
        }

        [TestMethod]
        public void Test_IfBasicLineChartRendersJson_Correct()
        {
            string renderTo = "chart";
            string json = "{\"tooltip\":{\"valueSuffix\":\"°C\"},\"series\":[{\"data\":[{\"y\":7},{\"y\":6.9},{\"y\":9.5},{\"y\":14.5},{\"y\":18.2},{\"y\":21.5},{\"y\":25.2},{\"y\":26.5},{\"y\":23.3},{\"y\":18.3},{\"y\":13.9},{\"y\":9.6}],\"type\":\"line\",\"name\":\"Tokyo\"},{\"data\":[{\"y\":-0.2},{\"y\":0.8},{\"y\":5.7},{\"y\":11.3},{\"y\":17},{\"y\":22},{\"y\":24.8},{\"y\":24.1},{\"y\":20.1},{\"y\":14.1},{\"y\":8.6},{\"y\":2.5}],\"type\":\"line\",\"name\":\"NY\"},{\"data\":[{\"y\":-0.9},{\"y\":0.6},{\"y\":3.5},{\"y\":8.4},{\"y\":13.5},{\"y\":17},{\"y\":18.6},{\"y\":17.9},{\"y\":14.3},{\"y\":9},{\"y\":3.9},{\"y\":1}],\"type\":\"line\",\"name\":\"Berlin\"},{\"data\":[{\"y\":3.9},{\"y\":4.2},{\"y\":5.7},{\"y\":8.5},{\"y\":11.9},{\"y\":15.2},{\"y\":17},{\"y\":16.6},{\"y\":14.2},{\"y\":10.3},{\"y\":6.6},{\"y\":4.8}],\"type\":\"line\",\"name\":\"London\"}],\"yAxis\":[{\"plotLines\":[{\"value\":0,\"color\":\"#808080\",\"width\":1}],\"title\":{\"text\":\"Temperature (°C)\"}}],\"subtitle\":{\"text\":\"Source: WorldClimate.com\",\"x\":-20},\"title\":{\"text\":\"Monthly Average Temperature\",\"x\":-20},\"xAxis\":[{\"categories\":[\"Jan\",\"Feb\",\"Mar\",\"Apr\",\"May\",\"Jun\",\"Jul\",\"Aug\",\"Sep\",\"Oct\",\"Nov\",\"Dec\"]}],\"legend\":{\"verticalAlign\":\"middle\",\"layout\":\"vertical\",\"align\":\"right\"}}";

            var result = _highsoft.GetJsonOptions(_highcharts);

            Assert.AreEqual(json,result);
        }
    }
}

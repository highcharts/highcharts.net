﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Highsoft.Web.Mvc.Charts;

namespace WebApplication15.Controls
{
    public partial class TestControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LiteralId.Text = GetChart();
            else
            {
                ///LiteralId.Text = GetChart("createAwasomeChart").Replace("</script>", " createAwasomeChart();</script>");

                //ClientScriptManager csm = Page.ClientScript;
                string key = "createChartKey";
                Type type = this.GetType();

                //if (csm.IsStartupScriptRegistered(key))
                //    return;

                //csm.RegisterStartupScript(type, key, GetChart("createAwasomeChart").Replace("</script>", " createAwasomeChart();</script>"), false);
                //string jsCode = 
                //ScriptManager.RegisterStartupScript(updatePanelId, updatePanelId.GetType(), key, GetChart2("createAwasomeChart").Replace("</script>", " createAwasomeChart();</script>"), false);

                ScriptManager.RegisterStartupScript(updatePanelId, updatePanelId.GetType(), key, GetChart2("createAwasomeChart"), false);


            }
        }

        //protected void ButtonId_Click(object sender, EventArgs e)
        //{
        //    LiteralId.Text = GetChart2();
        //}

        private string GetChart(string functionName = null)
        {
            List<double> tokyoValues = new List<double> { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 };
            List<double> nyValues = new List<double> { -0.2, 0.8, 5.7, 11.3, 17.0, 22.0, 24.8, 24.1, 20.1, 14.1, 8.6, 2.5 };
            List<double> berlinValues = new List<double> { -0.9, 0.6, 3.5, 8.4, 13.5, 17.0, 18.6, 17.9, 14.3, 9.0, 3.9, 1.0 };
            List<double> londonValues = new List<double> { 3.9, 4.2, 5.7, 8.5, 11.9, 15.2, 17.0, 16.6, 14.2, 10.3, 6.6, 4.8 };
            List<LineSeriesData> tokyoData = new List<LineSeriesData>();
            List<LineSeriesData> nyData = new List<LineSeriesData>();
            List<LineSeriesData> berlinData = new List<LineSeriesData>();
            List<LineSeriesData> londonData = new List<LineSeriesData>();

            tokyoValues.ForEach(p => tokyoData.Add(new LineSeriesData { Y = p }));
            nyValues.ForEach(p => nyData.Add(new LineSeriesData { Y = p }));
            berlinValues.ForEach(p => berlinData.Add(new LineSeriesData { Y = p }));
            londonValues.ForEach(p => londonData.Add(new LineSeriesData { Y = p }));

            Highcharts higcharts = new Highcharts
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
                    Data = tokyoData as List<LineSeriesData>
                },
                new LineSeries
                {
                    Name = "NY",
                    Data = nyData as List<LineSeriesData>
                },
                new LineSeries
                {
                    Name = "Berlin",
                    Data = berlinData as List<LineSeriesData>
                },
                new LineSeries
                {
                    Name = "London",
                    Data = londonData as List<LineSeriesData>
                }
            }
            };

            HighsoftNamespace Highsoft = new HighsoftNamespace();
            string result = Highsoft.GetHighcharts(higcharts, "chart1", false, functionName).ToHtmlString();

            return result;
        }

        private string GetChart2(string functionName = null)
        {
            List<double> tokyoValues = new List<double> { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 };
            List<double> nyValues = new List<double> { -0.2, 0.8, 5.7, 11.3, 17.0, 22.0, 24.8, 24.1, 20.1, 14.1, 8.6, 2.5 };
            List<double> berlinValues = new List<double> { -0.9, 0.6, 3.5, 8.4, 13.5, 17.0, 18.6, 17.9, 14.3, 9.0, 3.9, 1.0 };
            List<double> londonValues = new List<double> { 3.9, 4.2, 5.7, 8.5, 11.9, 15.2, 17.0, 16.6, 14.2, 10.3, 6.6, 4.8 };

            

            List<LineSeriesData> tokyoData = new List<LineSeriesData>();
            List<LineSeriesData> nyData = new List<LineSeriesData>();
            List<LineSeriesData> berlinData = new List<LineSeriesData>();
            List<LineSeriesData> londonData = new List<LineSeriesData>();

            tokyoValues.ForEach(p => tokyoData.Add(new LineSeriesData { Y = p -10}));
            nyValues.ForEach(p => nyData.Add(new LineSeriesData { Y = p -10}));
            berlinValues.ForEach(p => berlinData.Add(new LineSeriesData { Y = p+20 }));
            londonValues.ForEach(p => londonData.Add(new LineSeriesData { Y = p+20 }));

            Highcharts higcharts = new Highcharts
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
                    Data = tokyoData as List<LineSeriesData>
                },
                new LineSeries
                {
                    Name = "NY",
                    Data = nyData as List<LineSeriesData>
                },
                new LineSeries
                {
                    Name = "Berlin",
                    Data = berlinData as List<LineSeriesData>
                },
                new LineSeries
                {
                    Name = "London",
                    Data = londonData as List<LineSeriesData>
                }
            }
            };

            HighsoftNamespace Highsoft = new HighsoftNamespace();
            string result = Highsoft.GetHighchartsJS(higcharts, "chart1").ToHtmlString();

            return result;
        }
    }
    
}
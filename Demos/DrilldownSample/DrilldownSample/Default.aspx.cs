using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Highsoft.Web.Mvc.Charts;

namespace DrilldownSample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Highcharts highcharts = new Highcharts()
            {
                Title = new Highsoft.Web.Mvc.Charts.Title
                {
                    Text = "Basic drilldown"
                },
                XAxis = new List<XAxis>
                {
                    new XAxis
                    {
                        Type = XAxisType.Category
                    }
                },
                Legend = new Legend
                {
                    Enabled = false
                },

                PlotOptions = new PlotOptions
                {
                    Series = new PlotOptionsSeries
                    {
                        DataLabels = new PlotOptionsSeriesDataLabels
                        {
                            Enabled = true
                        }
                    }
                },

                Series = new List<Series>
                {
                    new ColumnSeries
                    {
                        Name = "Things",
                        ColorByPoint = true,
                        Data = new List<ColumnSeriesData>
                        {
                            new ColumnSeriesData
                            {
                                Name = "Animals",
                                Y = 5,
                                Drilldown = "animals"
                            }
                        }
                    }
                },

                Drilldown = new Drilldown
                {
                    Series = new List<Series>
                    {
                        new ColumnSeries
                        {
                            Id = "animals",
                            Name = "Animals",
                            Data = new List<ColumnSeriesData>
                            {
                                new ColumnSeriesData
                                {
                                    Name = "Cats",
                                    Y = 4,
                                    Drilldown = "cats"
                                },
                                new ColumnSeriesData
                                {
                                    Name = "Dogs",
                                    Y = 2
                                },
                                new ColumnSeriesData
                                {
                                    Name = "Cows",
                                    Y = 1
                                },
                                new ColumnSeriesData
                                {
                                    Name = "Sheep",
                                    Y = 2
                                },
                                new ColumnSeriesData
                                {
                                    Name = "Pigs",
                                    Y = 1
                                }
                            }
                        },
                        new ColumnSeries
                        {
                            Id = "cats",
                            Data = new List<ColumnSeriesData>
                            {
                                new ColumnSeriesData { Y = 1 },
                                new ColumnSeriesData { Y = 2 },
                                new ColumnSeriesData { Y = 3 }
                            }
                        }
                    }
                }
            };

            HighsoftNamespace hn = new HighsoftNamespace();
            string result = hn.GetHighcharts(highcharts, "container").ToHtmlString();

            ViewState["hc"] = result;
        }
    }
}
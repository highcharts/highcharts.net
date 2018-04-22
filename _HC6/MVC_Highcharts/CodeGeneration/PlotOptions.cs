using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class PlotOptions  : BaseObject
	{
		public PlotOptions()
		{
			Bellcurve = Bellcurve_DefaultValue = new PlotOptionsBellcurve();
			Series = Series_DefaultValue = new PlotOptionsSeries();
			Bullet = Bullet_DefaultValue = new PlotOptionsBullet();
			Funnel = Funnel_DefaultValue = new PlotOptionsFunnel();
			Pyramid = Pyramid_DefaultValue = new PlotOptionsPyramid();
			Histogram = Histogram_DefaultValue = new PlotOptionsHistogram();
			Pareto = Pareto_DefaultValue = new PlotOptionsPareto();
			Sankey = Sankey_DefaultValue = new PlotOptionsSankey();
			Solidgauge = Solidgauge_DefaultValue = new PlotOptionsSolidgauge();
			Streamgraph = Streamgraph_DefaultValue = new PlotOptionsStreamgraph();
			Sunburst = Sunburst_DefaultValue = new PlotOptionsSunburst();
			Tilemap = Tilemap_DefaultValue = new PlotOptionsTilemap();
			Treemap = Treemap_DefaultValue = new PlotOptionsTreemap();
			Variablepie = Variablepie_DefaultValue = new PlotOptionsVariablepie();
			Variwide = Variwide_DefaultValue = new PlotOptionsVariwide();
			Vector = Vector_DefaultValue = new PlotOptionsVector();
			Windbarb = Windbarb_DefaultValue = new PlotOptionsWindbarb();
			Wordcloud = Wordcloud_DefaultValue = new PlotOptionsWordcloud();
			Xrange = Xrange_DefaultValue = new PlotOptionsXrange();
			Area = Area_DefaultValue = new PlotOptionsArea();
			Areaspline = Areaspline_DefaultValue = new PlotOptionsAreaspline();
			Bar = Bar_DefaultValue = new PlotOptionsBar();
			Column = Column_DefaultValue = new PlotOptionsColumn();
			Pie = Pie_DefaultValue = new PlotOptionsPie();
			Scatter = Scatter_DefaultValue = new PlotOptionsScatter();
			Line = Line_DefaultValue = new PlotOptionsLine();
			Spline = Spline_DefaultValue = new PlotOptionsSpline();
			Scatter3d = Scatter3d_DefaultValue = new PlotOptionsScatter3d();
			Arearange = Arearange_DefaultValue = new PlotOptionsArearange();
			Areasplinerange = Areasplinerange_DefaultValue = new PlotOptionsAreasplinerange();
			Boxplot = Boxplot_DefaultValue = new PlotOptionsBoxplot();
			Bubble = Bubble_DefaultValue = new PlotOptionsBubble();
			Columnrange = Columnrange_DefaultValue = new PlotOptionsColumnrange();
			Errorbar = Errorbar_DefaultValue = new PlotOptionsErrorbar();
			Gauge = Gauge_DefaultValue = new PlotOptionsGauge();
			Polygon = Polygon_DefaultValue = new PlotOptionsPolygon();
			Waterfall = Waterfall_DefaultValue = new PlotOptionsWaterfall();
			Heatmap = Heatmap_DefaultValue = new PlotOptionsHeatmap();
			
		}	
		

		/// <summary>
		/// A bell curve is an areaspline series which represents the probability densityfunction of the normal distribution. It calculates mean and standarddeviation of the base series data and plots the curve according to thecalculated parameters.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `bellcurve` series are defined in [plotOptions.bellcurve](plotOptions.bellcurve).3. Options for one single series are given in[the series instance array](series.bellcurve).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        bellcurve: {            // shared options for all bellcurve series        }    },    series: [{        // specific options for this series instance        type: 'bellcurve'    }]});</pre>            
		/// </summary>
		public PlotOptionsBellcurve Bellcurve { get; set; }
		private PlotOptionsBellcurve Bellcurve_DefaultValue { get; set; }
		 

		/// <summary>
		/// General options for all series types.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `line` series are defined in [plotOptions.line](plotOptions.line).3. Options for one single series are given in[the series instance array](series.line).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        line: {            // shared options for all line series        }    },    series: [{        // specific options for this series instance        type: 'line'    }]});</pre>            
		/// </summary>
		public PlotOptionsSeries Series { get; set; }
		private PlotOptionsSeries Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// A bullet graph is a variation of a bar graph. The bullet graph featuresa single measure, compares it to a target, and displays it in the contextof qualitative ranges of performance that could be set using[plotBands](#yAxis.plotBands) on [yAxis](#yAxis).Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `bullet` series are defined in [plotOptions.bullet](plotOptions.bullet).3. Options for one single series are given in[the series instance array](series.bullet).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        bullet: {            // shared options for all bullet series        }    },    series: [{        // specific options for this series instance        type: 'bullet'    }]});</pre>            
		/// </summary>
		public PlotOptionsBullet Bullet { get; set; }
		private PlotOptionsBullet Bullet_DefaultValue { get; set; }
		 

		/// <summary>
		/// Funnel charts are a type of chart often used to visualize stages in a salesproject, where the top are the initial stages with the most clients.It requires that the modules/funnel.js file is loaded.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `funnel` series are defined in [plotOptions.funnel](plotOptions.funnel).3. Options for one single series are given in[the series instance array](series.funnel).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        funnel: {            // shared options for all funnel series        }    },    series: [{        // specific options for this series instance        type: 'funnel'    }]});</pre>            
		/// </summary>
		public PlotOptionsFunnel Funnel { get; set; }
		private PlotOptionsFunnel Funnel_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pyramid series is a special type of funnel, without neck and reversed bydefault.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `pyramid` series are defined in [plotOptions.pyramid](plotOptions.pyramid).3. Options for one single series are given in[the series instance array](series.pyramid).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        pyramid: {            // shared options for all pyramid series        }    },    series: [{        // specific options for this series instance        type: 'pyramid'    }]});</pre>            
		/// </summary>
		public PlotOptionsPyramid Pyramid { get; set; }
		private PlotOptionsPyramid Pyramid_DefaultValue { get; set; }
		 

		/// <summary>
		/// A histogram is a column series which represents the distribution of the dataset in the base series. Histogram splits data into bins and shows theirfrequencies.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `histogram` series are defined in [plotOptions.histogram](plotOptions.histogram).3. Options for one single series are given in[the series instance array](series.histogram).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        histogram: {            // shared options for all histogram series        }    },    series: [{        // specific options for this series instance        type: 'histogram'    }]});</pre>            
		/// </summary>
		public PlotOptionsHistogram Histogram { get; set; }
		private PlotOptionsHistogram Histogram_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pareto diagram is a type of chart that contains both bars and a line graph,where individual values are represented in descending order by bars,and the cumulative total is represented by the line.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `pareto` series are defined in [plotOptions.pareto](plotOptions.pareto).3. Options for one single series are given in[the series instance array](series.pareto).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        pareto: {            // shared options for all pareto series        }    },    series: [{        // specific options for this series instance        type: 'pareto'    }]});</pre>            
		/// </summary>
		public PlotOptionsPareto Pareto { get; set; }
		private PlotOptionsPareto Pareto_DefaultValue { get; set; }
		 

		/// <summary>
		/// A sankey diagram is a type of flow diagram, in which the width of thelink between two nodes is shown proportionally to the flow quantity.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `sankey` series are defined in [plotOptions.sankey](plotOptions.sankey).3. Options for one single series are given in[the series instance array](series.sankey).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        sankey: {            // shared options for all sankey series        }    },    series: [{        // specific options for this series instance        type: 'sankey'    }]});</pre>            
		/// </summary>
		public PlotOptionsSankey Sankey { get; set; }
		private PlotOptionsSankey Sankey_DefaultValue { get; set; }
		 

		/// <summary>
		/// A solid gauge is a circular gauge where the value is indicated by a filledarc, and the color of the arc may variate with the value.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `solidgauge` series are defined in [plotOptions.solidgauge](plotOptions.solidgauge).3. Options for one single series are given in[the series instance array](series.solidgauge).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        solidgauge: {            // shared options for all solidgauge series        }    },    series: [{        // specific options for this series instance        type: 'solidgauge'    }]});</pre>            
		/// </summary>
		public PlotOptionsSolidgauge Solidgauge { get; set; }
		private PlotOptionsSolidgauge Solidgauge_DefaultValue { get; set; }
		 

		/// <summary>
		/// A streamgraph is a type of stacked area graph which is displaced around acentral axis, resulting in a flowing, organic shape.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `streamgraph` series are defined in [plotOptions.streamgraph](plotOptions.streamgraph).3. Options for one single series are given in[the series instance array](series.streamgraph).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        streamgraph: {            // shared options for all streamgraph series        }    },    series: [{        // specific options for this series instance        type: 'streamgraph'    }]});</pre>            
		/// </summary>
		public PlotOptionsStreamgraph Streamgraph { get; set; }
		private PlotOptionsStreamgraph Streamgraph_DefaultValue { get; set; }
		 

		/// <summary>
		/// A Sunburst displays hierarchical data, where a level in the hierarchy isrepresented by a circle. The center represents the root node of the tree.The visualization bears a resemblance to both treemap and pie charts.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `sunburst` series are defined in [plotOptions.sunburst](plotOptions.sunburst).3. Options for one single series are given in[the series instance array](series.sunburst).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        sunburst: {            // shared options for all sunburst series        }    },    series: [{        // specific options for this series instance        type: 'sunburst'    }]});</pre>            
		/// </summary>
		public PlotOptionsSunburst Sunburst { get; set; }
		private PlotOptionsSunburst Sunburst_DefaultValue { get; set; }
		 

		/// <summary>
		/// A tilemap series is a type of heatmap where the tile shapes are configurable.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `tilemap` series are defined in [plotOptions.tilemap](plotOptions.tilemap).3. Options for one single series are given in[the series instance array](series.tilemap).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        tilemap: {            // shared options for all tilemap series        }    },    series: [{        // specific options for this series instance        type: 'tilemap'    }]});</pre>            
		/// </summary>
		public PlotOptionsTilemap Tilemap { get; set; }
		private PlotOptionsTilemap Tilemap_DefaultValue { get; set; }
		 

		/// <summary>
		/// A treemap displays hierarchical data using nested rectangles. The data can belaid out in varying ways depending on options.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `treemap` series are defined in [plotOptions.treemap](plotOptions.treemap).3. Options for one single series are given in[the series instance array](series.treemap).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        treemap: {            // shared options for all treemap series        }    },    series: [{        // specific options for this series instance        type: 'treemap'    }]});</pre>            
		/// </summary>
		public PlotOptionsTreemap Treemap { get; set; }
		private PlotOptionsTreemap Treemap_DefaultValue { get; set; }
		 

		/// <summary>
		/// A variable pie series is a two dimensional series type, where each pointrenders an Y and Z value.  Each point is drawn as a pie slice where thesize (arc) of the slice relates to the Y value and the radius of pieslice relates to the Z value. Requires `highcharts-more.js`.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `variablepie` series are defined in [plotOptions.variablepie](plotOptions.variablepie).3. Options for one single series are given in[the series instance array](series.variablepie).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        variablepie: {            // shared options for all variablepie series        }    },    series: [{        // specific options for this series instance        type: 'variablepie'    }]});</pre>            
		/// </summary>
		public PlotOptionsVariablepie Variablepie { get; set; }
		private PlotOptionsVariablepie Variablepie_DefaultValue { get; set; }
		 

		/// <summary>
		/// A variwide chart (related to marimekko chart) is a column chart with avariable width expressing a third dimension.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `variwide` series are defined in [plotOptions.variwide](plotOptions.variwide).3. Options for one single series are given in[the series instance array](series.variwide).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        variwide: {            // shared options for all variwide series        }    },    series: [{        // specific options for this series instance        type: 'variwide'    }]});</pre>            
		/// </summary>
		public PlotOptionsVariwide Variwide { get; set; }
		private PlotOptionsVariwide Variwide_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vector plot is a type of cartesian chart where each point has an X and Yposition, a length and a direction. Vectors are drawn as arrows.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `vector` series are defined in [plotOptions.vector](plotOptions.vector).3. Options for one single series are given in[the series instance array](series.vector).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        vector: {            // shared options for all vector series        }    },    series: [{        // specific options for this series instance        type: 'vector'    }]});</pre>            
		/// </summary>
		public PlotOptionsVector Vector { get; set; }
		private PlotOptionsVector Vector_DefaultValue { get; set; }
		 

		/// <summary>
		/// Wind barbs are a convenient way to represent wind speed and direction in onegraphical form. Wind direction is given by the stem direction, and wind speedby the number and shape of barbs.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `windbarb` series are defined in [plotOptions.windbarb](plotOptions.windbarb).3. Options for one single series are given in[the series instance array](series.windbarb).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        windbarb: {            // shared options for all windbarb series        }    },    series: [{        // specific options for this series instance        type: 'windbarb'    }]});</pre>            
		/// </summary>
		public PlotOptionsWindbarb Windbarb { get; set; }
		private PlotOptionsWindbarb Windbarb_DefaultValue { get; set; }
		 

		/// <summary>
		/// A word cloud is a visualization of a set of words, where the size andplacement of a word is determined by how it is weighted.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `wordcloud` series are defined in [plotOptions.wordcloud](plotOptions.wordcloud).3. Options for one single series are given in[the series instance array](series.wordcloud).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        wordcloud: {            // shared options for all wordcloud series        }    },    series: [{        // specific options for this series instance        type: 'wordcloud'    }]});</pre>            
		/// </summary>
		public PlotOptionsWordcloud Wordcloud { get; set; }
		private PlotOptionsWordcloud Wordcloud_DefaultValue { get; set; }
		 

		/// <summary>
		/// The X-range series displays ranges on the X axis, typically time intervalswith a start and end date.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `xrange` series are defined in [plotOptions.xrange](plotOptions.xrange).3. Options for one single series are given in[the series instance array](series.xrange).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        xrange: {            // shared options for all xrange series        }    },    series: [{        // specific options for this series instance        type: 'xrange'    }]});</pre>            
		/// </summary>
		public PlotOptionsXrange Xrange { get; set; }
		private PlotOptionsXrange Xrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area series type.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `area` series are defined in [plotOptions.area](plotOptions.area).3. Options for one single series are given in[the series instance array](series.area).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        area: {            // shared options for all area series        }    },    series: [{        // specific options for this series instance        type: 'area'    }]});</pre>            
		/// </summary>
		public PlotOptionsArea Area { get; set; }
		private PlotOptionsArea Area_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area spline series is an area series where the graph between the pointsis smoothed into a spline.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `areaspline` series are defined in [plotOptions.areaspline](plotOptions.areaspline).3. Options for one single series are given in[the series instance array](series.areaspline).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        areaspline: {            // shared options for all areaspline series        }    },    series: [{        // specific options for this series instance        type: 'areaspline'    }]});</pre>            
		/// </summary>
		public PlotOptionsAreaspline Areaspline { get; set; }
		private PlotOptionsAreaspline Areaspline_DefaultValue { get; set; }
		 

		/// <summary>
		/// A bar series is a special type of column series where the columns arehorizontal.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `bar` series are defined in [plotOptions.bar](plotOptions.bar).3. Options for one single series are given in[the series instance array](series.bar).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        bar: {            // shared options for all bar series        }    },    series: [{        // specific options for this series instance        type: 'bar'    }]});</pre>            
		/// </summary>
		public PlotOptionsBar Bar { get; set; }
		private PlotOptionsBar Bar_DefaultValue { get; set; }
		 

		/// <summary>
		/// Column series display one column per value along an X axis.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `column` series are defined in [plotOptions.column](plotOptions.column).3. Options for one single series are given in[the series instance array](series.column).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        column: {            // shared options for all column series        }    },    series: [{        // specific options for this series instance        type: 'column'    }]});</pre>            
		/// </summary>
		public PlotOptionsColumn Column { get; set; }
		private PlotOptionsColumn Column_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pie chart is a circular graphic which is divided into slices to illustratenumerical proportion.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `pie` series are defined in [plotOptions.pie](plotOptions.pie).3. Options for one single series are given in[the series instance array](series.pie).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        pie: {            // shared options for all pie series        }    },    series: [{        // specific options for this series instance        type: 'pie'    }]});</pre>            
		/// </summary>
		public PlotOptionsPie Pie { get; set; }
		private PlotOptionsPie Pie_DefaultValue { get; set; }
		 

		/// <summary>
		/// A scatter plot uses cartesian coordinates to display values for two variablesfor a set of data.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `scatter` series are defined in [plotOptions.scatter](plotOptions.scatter).3. Options for one single series are given in[the series instance array](series.scatter).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        scatter: {            // shared options for all scatter series        }    },    series: [{        // specific options for this series instance        type: 'scatter'    }]});</pre>            
		/// </summary>
		public PlotOptionsScatter Scatter { get; set; }
		private PlotOptionsScatter Scatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// A line series displays information as a series of data points connected bystraight line segments.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `line` series are defined in [plotOptions.line](plotOptions.line).3. Options for one single series are given in[the series instance array](series.line).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        line: {            // shared options for all line series        }    },    series: [{        // specific options for this series instance        type: 'line'    }]});</pre>            
		/// </summary>
		public PlotOptionsLine Line { get; set; }
		private PlotOptionsLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// A spline series is a special type of line series, where the segments betweenthe data points are smoothed.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `spline` series are defined in [plotOptions.spline](plotOptions.spline).3. Options for one single series are given in[the series instance array](series.spline).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        spline: {            // shared options for all spline series        }    },    series: [{        // specific options for this series instance        type: 'spline'    }]});</pre>            
		/// </summary>
		public PlotOptionsSpline Spline { get; set; }
		private PlotOptionsSpline Spline_DefaultValue { get; set; }
		 

		/// <summary>
		/// A 3D scatter plot uses x, y and z coordinates to display values for threevariables for a set of data.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `scatter3d` series are defined in [plotOptions.scatter3d](plotOptions.scatter3d).3. Options for one single series are given in[the series instance array](series.scatter3d).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        scatter3d: {            // shared options for all scatter3d series        }    },    series: [{        // specific options for this series instance        type: 'scatter3d'    }]});</pre>            
		/// </summary>
		public PlotOptionsScatter3d Scatter3d { get; set; }
		private PlotOptionsScatter3d Scatter3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area range series is a carteseian series with higher and lower valuesfor each point along an X axis, where the area between the values is shaded.Requires `highcharts-more.js`.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `arearange` series are defined in [plotOptions.arearange](plotOptions.arearange).3. Options for one single series are given in[the series instance array](series.arearange).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        arearange: {            // shared options for all arearange series        }    },    series: [{        // specific options for this series instance        type: 'arearange'    }]});</pre>            
		/// </summary>
		public PlotOptionsArearange Arearange { get; set; }
		private PlotOptionsArearange Arearange_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area spline range is a cartesian series type with higher andlower Y values along an X axis. The area inside the range is colored, andthe graph outlining the area is a smoothed spline. Requires`highcharts-more.js`.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `areasplinerange` series are defined in [plotOptions.areasplinerange](plotOptions.areasplinerange).3. Options for one single series are given in[the series instance array](series.areasplinerange).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        areasplinerange: {            // shared options for all areasplinerange series        }    },    series: [{        // specific options for this series instance        type: 'areasplinerange'    }]});</pre>            
		/// </summary>
		public PlotOptionsAreasplinerange Areasplinerange { get; set; }
		private PlotOptionsAreasplinerange Areasplinerange_DefaultValue { get; set; }
		 

		/// <summary>
		/// A box plot is a convenient way of depicting groups of data through theirfive-number summaries: the smallest observation (sample minimum), lowerquartile (Q1), median (Q2), upper quartile (Q3), and largest observation(sample maximum).Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `boxplot` series are defined in [plotOptions.boxplot](plotOptions.boxplot).3. Options for one single series are given in[the series instance array](series.boxplot).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        boxplot: {            // shared options for all boxplot series        }    },    series: [{        // specific options for this series instance        type: 'boxplot'    }]});</pre>            
		/// </summary>
		public PlotOptionsBoxplot Boxplot { get; set; }
		private PlotOptionsBoxplot Boxplot_DefaultValue { get; set; }
		 

		/// <summary>
		/// A bubble series is a three dimensional series type where each point rendersan X, Y and Z value. Each points is drawn as a bubble where the positionalong the X and Y axes mark the X and Y values, and the size of the bubblerelates to the Z value. Requires `highcharts-more.js`.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `bubble` series are defined in [plotOptions.bubble](plotOptions.bubble).3. Options for one single series are given in[the series instance array](series.bubble).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        bubble: {            // shared options for all bubble series        }    },    series: [{        // specific options for this series instance        type: 'bubble'    }]});</pre>            
		/// </summary>
		public PlotOptionsBubble Bubble { get; set; }
		private PlotOptionsBubble Bubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// The column range is a cartesian series type with higher and lowerY values along an X axis. Requires `highcharts-more.js`. To displayhorizontal bars, set [chart.inverted](#chart.inverted) to `true`.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `columnrange` series are defined in [plotOptions.columnrange](plotOptions.columnrange).3. Options for one single series are given in[the series instance array](series.columnrange).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        columnrange: {            // shared options for all columnrange series        }    },    series: [{        // specific options for this series instance        type: 'columnrange'    }]});</pre>            
		/// </summary>
		public PlotOptionsColumnrange Columnrange { get; set; }
		private PlotOptionsColumnrange Columnrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// Error bars are a graphical representation of the variability of data and areused on graphs to indicate the error, or uncertainty in a reportedmeasurement.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `errorbar` series are defined in [plotOptions.errorbar](plotOptions.errorbar).3. Options for one single series are given in[the series instance array](series.errorbar).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        errorbar: {            // shared options for all errorbar series        }    },    series: [{        // specific options for this series instance        type: 'errorbar'    }]});</pre>            
		/// </summary>
		public PlotOptionsErrorbar Errorbar { get; set; }
		private PlotOptionsErrorbar Errorbar_DefaultValue { get; set; }
		 

		/// <summary>
		/// Gauges are circular plots displaying one or more values with a dial pointingto values along the perimeter.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `gauge` series are defined in [plotOptions.gauge](plotOptions.gauge).3. Options for one single series are given in[the series instance array](series.gauge).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        gauge: {            // shared options for all gauge series        }    },    series: [{        // specific options for this series instance        type: 'gauge'    }]});</pre>            
		/// </summary>
		public PlotOptionsGauge Gauge { get; set; }
		private PlotOptionsGauge Gauge_DefaultValue { get; set; }
		 

		/// <summary>
		/// A polygon series can be used to draw any freeform shape in the cartesiancoordinate system. A fill is applied with the `color` option, andstroke is applied through `lineWidth` and `lineColor` options. Requiresthe `highcharts-more.js` file.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `polygon` series are defined in [plotOptions.polygon](plotOptions.polygon).3. Options for one single series are given in[the series instance array](series.polygon).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        polygon: {            // shared options for all polygon series        }    },    series: [{        // specific options for this series instance        type: 'polygon'    }]});</pre>            
		/// </summary>
		public PlotOptionsPolygon Polygon { get; set; }
		private PlotOptionsPolygon Polygon_DefaultValue { get; set; }
		 

		/// <summary>
		/// A waterfall chart displays sequentially introduced positive or negativevalues in cumulative columns.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `waterfall` series are defined in [plotOptions.waterfall](plotOptions.waterfall).3. Options for one single series are given in[the series instance array](series.waterfall).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        waterfall: {            // shared options for all waterfall series        }    },    series: [{        // specific options for this series instance        type: 'waterfall'    }]});</pre>            
		/// </summary>
		public PlotOptionsWaterfall Waterfall { get; set; }
		private PlotOptionsWaterfall Waterfall_DefaultValue { get; set; }
		 

		/// <summary>
		/// A heatmap is a graphical representation of data where the individual valuescontained in a matrix are represented as colors.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `heatmap` series are defined in [plotOptions.heatmap](plotOptions.heatmap).3. Options for one single series are given in[the series instance array](series.heatmap).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        heatmap: {            // shared options for all heatmap series        }    },    series: [{        // specific options for this series instance        type: 'heatmap'    }]});</pre>            
		/// </summary>
		public PlotOptionsHeatmap Heatmap { get; set; }
		private PlotOptionsHeatmap Heatmap_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Bellcurve.IsDirty()) h.Add("bellcurve",Bellcurve.ToHashtable());
			if (Series.IsDirty()) h.Add("series",Series.ToHashtable());
			if (Bullet.IsDirty()) h.Add("bullet",Bullet.ToHashtable());
			if (Funnel.IsDirty()) h.Add("funnel",Funnel.ToHashtable());
			if (Pyramid.IsDirty()) h.Add("pyramid",Pyramid.ToHashtable());
			if (Histogram.IsDirty()) h.Add("histogram",Histogram.ToHashtable());
			if (Pareto.IsDirty()) h.Add("pareto",Pareto.ToHashtable());
			if (Sankey.IsDirty()) h.Add("sankey",Sankey.ToHashtable());
			if (Solidgauge.IsDirty()) h.Add("solidgauge",Solidgauge.ToHashtable());
			if (Streamgraph.IsDirty()) h.Add("streamgraph",Streamgraph.ToHashtable());
			if (Sunburst.IsDirty()) h.Add("sunburst",Sunburst.ToHashtable());
			if (Tilemap.IsDirty()) h.Add("tilemap",Tilemap.ToHashtable());
			if (Treemap.IsDirty()) h.Add("treemap",Treemap.ToHashtable());
			if (Variablepie.IsDirty()) h.Add("variablepie",Variablepie.ToHashtable());
			if (Variwide.IsDirty()) h.Add("variwide",Variwide.ToHashtable());
			if (Vector.IsDirty()) h.Add("vector",Vector.ToHashtable());
			if (Windbarb.IsDirty()) h.Add("windbarb",Windbarb.ToHashtable());
			if (Wordcloud.IsDirty()) h.Add("wordcloud",Wordcloud.ToHashtable());
			if (Xrange.IsDirty()) h.Add("xrange",Xrange.ToHashtable());
			if (Area.IsDirty()) h.Add("area",Area.ToHashtable());
			if (Areaspline.IsDirty()) h.Add("areaspline",Areaspline.ToHashtable());
			if (Bar.IsDirty()) h.Add("bar",Bar.ToHashtable());
			if (Column.IsDirty()) h.Add("column",Column.ToHashtable());
			if (Pie.IsDirty()) h.Add("pie",Pie.ToHashtable());
			if (Scatter.IsDirty()) h.Add("scatter",Scatter.ToHashtable());
			if (Line.IsDirty()) h.Add("line",Line.ToHashtable());
			if (Spline.IsDirty()) h.Add("spline",Spline.ToHashtable());
			if (Scatter3d.IsDirty()) h.Add("scatter3d",Scatter3d.ToHashtable());
			if (Arearange.IsDirty()) h.Add("arearange",Arearange.ToHashtable());
			if (Areasplinerange.IsDirty()) h.Add("areasplinerange",Areasplinerange.ToHashtable());
			if (Boxplot.IsDirty()) h.Add("boxplot",Boxplot.ToHashtable());
			if (Bubble.IsDirty()) h.Add("bubble",Bubble.ToHashtable());
			if (Columnrange.IsDirty()) h.Add("columnrange",Columnrange.ToHashtable());
			if (Errorbar.IsDirty()) h.Add("errorbar",Errorbar.ToHashtable());
			if (Gauge.IsDirty()) h.Add("gauge",Gauge.ToHashtable());
			if (Polygon.IsDirty()) h.Add("polygon",Polygon.ToHashtable());
			if (Waterfall.IsDirty()) h.Add("waterfall",Waterfall.ToHashtable());
			if (Heatmap.IsDirty()) h.Add("heatmap",Heatmap.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}
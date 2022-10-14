using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class PlotOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptions()
		{
			Arcdiagram = Arcdiagram_DefaultValue = new PlotOptionsArcdiagram();
			Area = Area_DefaultValue = new PlotOptionsArea();
			Arearange = Arearange_DefaultValue = new PlotOptionsArearange();
			Areaspline = Areaspline_DefaultValue = new PlotOptionsAreaspline();
			Areasplinerange = Areasplinerange_DefaultValue = new PlotOptionsAreasplinerange();
			Bar = Bar_DefaultValue = new PlotOptionsBar();
			Bellcurve = Bellcurve_DefaultValue = new PlotOptionsBellcurve();
			Boxplot = Boxplot_DefaultValue = new PlotOptionsBoxplot();
			Bubble = Bubble_DefaultValue = new PlotOptionsBubble();
			Bullet = Bullet_DefaultValue = new PlotOptionsBullet();
			Column = Column_DefaultValue = new PlotOptionsColumn();
			Columnpyramid = Columnpyramid_DefaultValue = new PlotOptionsColumnpyramid();
			Columnrange = Columnrange_DefaultValue = new PlotOptionsColumnrange();
			Cylinder = Cylinder_DefaultValue = new PlotOptionsCylinder();
			Dependencywheel = Dependencywheel_DefaultValue = new PlotOptionsDependencywheel();
			Dumbbell = Dumbbell_DefaultValue = new PlotOptionsDumbbell();
			Errorbar = Errorbar_DefaultValue = new PlotOptionsErrorbar();
			Funnel = Funnel_DefaultValue = new PlotOptionsFunnel();
			Funnel3d = Funnel3d_DefaultValue = new PlotOptionsFunnel3d();
			Gauge = Gauge_DefaultValue = new PlotOptionsGauge();
			Heatmap = Heatmap_DefaultValue = new PlotOptionsHeatmap();
			Histogram = Histogram_DefaultValue = new PlotOptionsHistogram();
			Item = Item_DefaultValue = new PlotOptionsItem();
			Line = Line_DefaultValue = new PlotOptionsLine();
			Lollipop = Lollipop_DefaultValue = new PlotOptionsLollipop();
			Networkgraph = Networkgraph_DefaultValue = new PlotOptionsNetworkgraph();
			Organization = Organization_DefaultValue = new PlotOptionsOrganization();
			Packedbubble = Packedbubble_DefaultValue = new PlotOptionsPackedbubble();
			Pareto = Pareto_DefaultValue = new PlotOptionsPareto();
			Pie = Pie_DefaultValue = new PlotOptionsPie();
			Polygon = Polygon_DefaultValue = new PlotOptionsPolygon();
			Pyramid = Pyramid_DefaultValue = new PlotOptionsPyramid();
			Pyramid3d = Pyramid3d_DefaultValue = new PlotOptionsPyramid3d();
			Sankey = Sankey_DefaultValue = new PlotOptionsSankey();
			Scatter = Scatter_DefaultValue = new PlotOptionsScatter();
			Scatter3d = Scatter3d_DefaultValue = new PlotOptionsScatter3d();
			Series = Series_DefaultValue = new PlotOptionsSeries();
			Solidgauge = Solidgauge_DefaultValue = new PlotOptionsSolidgauge();
			Spline = Spline_DefaultValue = new PlotOptionsSpline();
			Streamgraph = Streamgraph_DefaultValue = new PlotOptionsStreamgraph();
			Sunburst = Sunburst_DefaultValue = new PlotOptionsSunburst();
			Tilemap = Tilemap_DefaultValue = new PlotOptionsTilemap();
			Timeline = Timeline_DefaultValue = new PlotOptionsTimeline();
			Treemap = Treemap_DefaultValue = new PlotOptionsTreemap();
			Variablepie = Variablepie_DefaultValue = new PlotOptionsVariablepie();
			Variwide = Variwide_DefaultValue = new PlotOptionsVariwide();
			Vector = Vector_DefaultValue = new PlotOptionsVector();
			Venn = Venn_DefaultValue = new PlotOptionsVenn();
			Waterfall = Waterfall_DefaultValue = new PlotOptionsWaterfall();
			Windbarb = Windbarb_DefaultValue = new PlotOptionsWindbarb();
			Wordcloud = Wordcloud_DefaultValue = new PlotOptionsWordcloud();
			Xrange = Xrange_DefaultValue = new PlotOptionsXrange();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Arc diagram series is a chart drawing style in which the vertices of the chart are positioned along a line on the Euclidean plane and the edges are drawn as a semicircle in one of the two half-planes delimited by the line, or as smooth curves formed by sequences of semicircles.In TypeScript the [type](series.arcdiagram.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `arcdiagram` series are defined in   [plotOptions.arcdiagram](plotOptions.arcdiagram).3. Options for one single series are given in   [the series instance array](series.arcdiagram).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        arcdiagram: {            // shared options for all arcdiagram series        }    },    series: [{        // specific options for this series instance        type: 'arcdiagram'    }]});```            
		/// </summary>
		public PlotOptionsArcdiagram Arcdiagram { get; set; }
		private PlotOptionsArcdiagram Arcdiagram_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area series type.In TypeScript the [type](series.area.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `area` series are defined in   [plotOptions.area](plotOptions.area).3. Options for one single series are given in   [the series instance array](series.area).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        area: {            // shared options for all area series        }    },    series: [{        // specific options for this series instance        type: 'area'    }]});```            
		/// </summary>
		public PlotOptionsArea Area { get; set; }
		private PlotOptionsArea Area_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area range series is a carteseian series with higher and lower values foreach point along an X axis, where the area between the values is shaded.In TypeScript the [type](series.arearange.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `arearange` series are defined in   [plotOptions.arearange](plotOptions.arearange).3. Options for one single series are given in   [the series instance array](series.arearange).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        arearange: {            // shared options for all arearange series        }    },    series: [{        // specific options for this series instance        type: 'arearange'    }]});```            
		/// </summary>
		public PlotOptionsArearange Arearange { get; set; }
		private PlotOptionsArearange Arearange_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area spline series is an area series where the graph between thepoints is smoothed into a spline.In TypeScript the [type](series.areaspline.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `areaspline` series are defined in   [plotOptions.areaspline](plotOptions.areaspline).3. Options for one single series are given in   [the series instance array](series.areaspline).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        areaspline: {            // shared options for all areaspline series        }    },    series: [{        // specific options for this series instance        type: 'areaspline'    }]});```            
		/// </summary>
		public PlotOptionsAreaspline Areaspline { get; set; }
		private PlotOptionsAreaspline Areaspline_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area spline range is a cartesian series type with higher andlower Y values along an X axis. The area inside the range is colored, andthe graph outlining the area is a smoothed spline.In TypeScript the [type](series.areasplinerange.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `areasplinerange` series are defined in   [plotOptions.areasplinerange](plotOptions.areasplinerange).3. Options for one single series are given in   [the series instance array](series.areasplinerange).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        areasplinerange: {            // shared options for all areasplinerange series        }    },    series: [{        // specific options for this series instance        type: 'areasplinerange'    }]});```            
		/// </summary>
		public PlotOptionsAreasplinerange Areasplinerange { get; set; }
		private PlotOptionsAreasplinerange Areasplinerange_DefaultValue { get; set; }
		 

		/// <summary>
		/// A bar series is a special type of column series where the columns arehorizontal.In TypeScript the [type](series.bar.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `bar` series are defined in   [plotOptions.bar](plotOptions.bar).3. Options for one single series are given in   [the series instance array](series.bar).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        bar: {            // shared options for all bar series        }    },    series: [{        // specific options for this series instance        type: 'bar'    }]});```            
		/// </summary>
		public PlotOptionsBar Bar { get; set; }
		private PlotOptionsBar Bar_DefaultValue { get; set; }
		 

		/// <summary>
		/// A bell curve is an areaspline series which represents the probabilitydensity function of the normal distribution. It calculates mean andstandard deviation of the base series data and plots the curve accordingto the calculated parameters.In TypeScript the [type](series.bellcurve.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `bellcurve` series are defined in   [plotOptions.bellcurve](plotOptions.bellcurve).3. Options for one single series are given in   [the series instance array](series.bellcurve).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        bellcurve: {            // shared options for all bellcurve series        }    },    series: [{        // specific options for this series instance        type: 'bellcurve'    }]});```            
		/// </summary>
		public PlotOptionsBellcurve Bellcurve { get; set; }
		private PlotOptionsBellcurve Bellcurve_DefaultValue { get; set; }
		 

		/// <summary>
		/// A box plot is a convenient way of depicting groups of data through theirfive-number summaries: the smallest observation (sample minimum), lowerquartile (Q1), median (Q2), upper quartile (Q3), and largest observation(sample maximum).In TypeScript the [type](series.boxplot.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `boxplot` series are defined in   [plotOptions.boxplot](plotOptions.boxplot).3. Options for one single series are given in   [the series instance array](series.boxplot).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        boxplot: {            // shared options for all boxplot series        }    },    series: [{        // specific options for this series instance        type: 'boxplot'    }]});```            
		/// </summary>
		public PlotOptionsBoxplot Boxplot { get; set; }
		private PlotOptionsBoxplot Boxplot_DefaultValue { get; set; }
		 

		/// <summary>
		/// A bubble series is a three dimensional series type where each pointrenders an X, Y and Z value. Each points is drawn as a bubble where theposition along the X and Y axes mark the X and Y values, and the size ofthe bubble relates to the Z value.In TypeScript the [type](series.bubble.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `bubble` series are defined in   [plotOptions.bubble](plotOptions.bubble).3. Options for one single series are given in   [the series instance array](series.bubble).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        bubble: {            // shared options for all bubble series        }    },    series: [{        // specific options for this series instance        type: 'bubble'    }]});```            
		/// </summary>
		public PlotOptionsBubble Bubble { get; set; }
		private PlotOptionsBubble Bubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// A bullet graph is a variation of a bar graph. The bullet graph featuresa single measure, compares it to a target, and displays it in the contextof qualitative ranges of performance that could be set using[plotBands](#yAxis.plotBands) on [yAxis](#yAxis).In TypeScript the [type](series.bullet.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `bullet` series are defined in   [plotOptions.bullet](plotOptions.bullet).3. Options for one single series are given in   [the series instance array](series.bullet).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        bullet: {            // shared options for all bullet series        }    },    series: [{        // specific options for this series instance        type: 'bullet'    }]});```            
		/// </summary>
		public PlotOptionsBullet Bullet { get; set; }
		private PlotOptionsBullet Bullet_DefaultValue { get; set; }
		 

		/// <summary>
		/// Column series display one column per value along an X axis.In TypeScript the [type](series.column.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `column` series are defined in   [plotOptions.column](plotOptions.column).3. Options for one single series are given in   [the series instance array](series.column).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        column: {            // shared options for all column series        }    },    series: [{        // specific options for this series instance        type: 'column'    }]});```            
		/// </summary>
		public PlotOptionsColumn Column { get; set; }
		private PlotOptionsColumn Column_DefaultValue { get; set; }
		 

		/// <summary>
		/// Column pyramid series display one pyramid per value along an X axis.To display horizontal pyramids, set [chart.inverted](#chart.inverted) to`true`.In TypeScript the [type](series.columnpyramid.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `columnpyramid` series are defined in   [plotOptions.columnpyramid](plotOptions.columnpyramid).3. Options for one single series are given in   [the series instance array](series.columnpyramid).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        columnpyramid: {            // shared options for all columnpyramid series        }    },    series: [{        // specific options for this series instance        type: 'columnpyramid'    }]});```            
		/// </summary>
		public PlotOptionsColumnpyramid Columnpyramid { get; set; }
		private PlotOptionsColumnpyramid Columnpyramid_DefaultValue { get; set; }
		 

		/// <summary>
		/// The column range is a cartesian series type with higher and lowerY values along an X axis. To display horizontal bars, set[chart.inverted](#chart.inverted) to `true`.In TypeScript the [type](series.columnrange.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `columnrange` series are defined in   [plotOptions.columnrange](plotOptions.columnrange).3. Options for one single series are given in   [the series instance array](series.columnrange).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        columnrange: {            // shared options for all columnrange series        }    },    series: [{        // specific options for this series instance        type: 'columnrange'    }]});```            
		/// </summary>
		public PlotOptionsColumnrange Columnrange { get; set; }
		private PlotOptionsColumnrange Columnrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// A cylinder graph is a variation of a 3d column graph. The cylinder graphfeatures cylindrical points.In TypeScript the [type](series.cylinder.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `cylinder` series are defined in   [plotOptions.cylinder](plotOptions.cylinder).3. Options for one single series are given in   [the series instance array](series.cylinder).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        cylinder: {            // shared options for all cylinder series        }    },    series: [{        // specific options for this series instance        type: 'cylinder'    }]});```            
		/// </summary>
		public PlotOptionsCylinder Cylinder { get; set; }
		private PlotOptionsCylinder Cylinder_DefaultValue { get; set; }
		 

		/// <summary>
		/// A dependency wheel chart is a type of flow diagram, where all nodes arelaid out in a circle, and the flow between the are drawn as link bands.In TypeScript the [type](series.dependencywheel.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `dependencywheel` series are defined in   [plotOptions.dependencywheel](plotOptions.dependencywheel).3. Options for one single series are given in   [the series instance array](series.dependencywheel).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        dependencywheel: {            // shared options for all dependencywheel series        }    },    series: [{        // specific options for this series instance        type: 'dependencywheel'    }]});```            
		/// </summary>
		public PlotOptionsDependencywheel Dependencywheel { get; set; }
		private PlotOptionsDependencywheel Dependencywheel_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dumbbell series is a cartesian series with higher and lower valuesfor each point along an X axis, connected with a line between thevalues.Requires `highcharts-more.js` and `modules/dumbbell.js`.In TypeScript the [type](series.dumbbell.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `dumbbell` series are defined in   [plotOptions.dumbbell](plotOptions.dumbbell).3. Options for one single series are given in   [the series instance array](series.dumbbell).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        dumbbell: {            // shared options for all dumbbell series        }    },    series: [{        // specific options for this series instance        type: 'dumbbell'    }]});```            
		/// </summary>
		public PlotOptionsDumbbell Dumbbell { get; set; }
		private PlotOptionsDumbbell Dumbbell_DefaultValue { get; set; }
		 

		/// <summary>
		/// Error bars are a graphical representation of the variability of data andare used on graphs to indicate the error, or uncertainty in a reportedmeasurement.In TypeScript the [type](series.errorbar.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `errorbar` series are defined in   [plotOptions.errorbar](plotOptions.errorbar).3. Options for one single series are given in   [the series instance array](series.errorbar).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        errorbar: {            // shared options for all errorbar series        }    },    series: [{        // specific options for this series instance        type: 'errorbar'    }]});```            
		/// </summary>
		public PlotOptionsErrorbar Errorbar { get; set; }
		private PlotOptionsErrorbar Errorbar_DefaultValue { get; set; }
		 

		/// <summary>
		/// Funnel charts are a type of chart often used to visualize stages in asales project, where the top are the initial stages with the mostclients. It requires that the modules/funnel.js file is loaded.In TypeScript the [type](series.funnel.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `funnel` series are defined in   [plotOptions.funnel](plotOptions.funnel).3. Options for one single series are given in   [the series instance array](series.funnel).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        funnel: {            // shared options for all funnel series        }    },    series: [{        // specific options for this series instance        type: 'funnel'    }]});```            
		/// </summary>
		public PlotOptionsFunnel Funnel { get; set; }
		private PlotOptionsFunnel Funnel_DefaultValue { get; set; }
		 

		/// <summary>
		/// A funnel3d is a 3d version of funnel series type. Funnel charts area type of chart often used to visualize stages in a sales project,where the top are the initial stages with the most clients.It requires that the `highcharts-3d.js`, `cylinder.js` and`funnel3d.js` module are loaded.In TypeScript the [type](series.funnel3d.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `funnel3d` series are defined in   [plotOptions.funnel3d](plotOptions.funnel3d).3. Options for one single series are given in   [the series instance array](series.funnel3d).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        funnel3d: {            // shared options for all funnel3d series        }    },    series: [{        // specific options for this series instance        type: 'funnel3d'    }]});```            
		/// </summary>
		public PlotOptionsFunnel3d Funnel3d { get; set; }
		private PlotOptionsFunnel3d Funnel3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// Gauges are circular plots displaying one or more values with a dialpointing to values along the perimeter.In TypeScript the [type](series.gauge.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `gauge` series are defined in   [plotOptions.gauge](plotOptions.gauge).3. Options for one single series are given in   [the series instance array](series.gauge).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        gauge: {            // shared options for all gauge series        }    },    series: [{        // specific options for this series instance        type: 'gauge'    }]});```            
		/// </summary>
		public PlotOptionsGauge Gauge { get; set; }
		private PlotOptionsGauge Gauge_DefaultValue { get; set; }
		 

		/// <summary>
		/// A heatmap is a graphical representation of data where the individualvalues contained in a matrix are represented as colors.In TypeScript the [type](series.heatmap.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `heatmap` series are defined in   [plotOptions.heatmap](plotOptions.heatmap).3. Options for one single series are given in   [the series instance array](series.heatmap).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        heatmap: {            // shared options for all heatmap series        }    },    series: [{        // specific options for this series instance        type: 'heatmap'    }]});```            
		/// </summary>
		public PlotOptionsHeatmap Heatmap { get; set; }
		private PlotOptionsHeatmap Heatmap_DefaultValue { get; set; }
		 

		/// <summary>
		/// A histogram is a column series which represents the distribution of thedata set in the base series. Histogram splits data into bins and showstheir frequencies.In TypeScript the [type](series.histogram.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `histogram` series are defined in   [plotOptions.histogram](plotOptions.histogram).3. Options for one single series are given in   [the series instance array](series.histogram).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        histogram: {            // shared options for all histogram series        }    },    series: [{        // specific options for this series instance        type: 'histogram'    }]});```            
		/// </summary>
		public PlotOptionsHistogram Histogram { get; set; }
		private PlotOptionsHistogram Histogram_DefaultValue { get; set; }
		 

		/// <summary>
		/// An item chart is an infographic chart where a number of items are laidout in either a rectangular or circular pattern. It can be used tovisualize counts within a group, or for the circular pattern, typicallya parliament.The circular layout has much in common with a pie chart. Many of the itemseries options, like `center`, `size` and data label positioning, areinherited from the pie series and don't apply for rectangular layouts.In TypeScript the [type](series.item.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `item` series are defined in   [plotOptions.item](plotOptions.item).3. Options for one single series are given in   [the series instance array](series.item).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        item: {            // shared options for all item series        }    },    series: [{        // specific options for this series instance        type: 'item'    }]});```            
		/// </summary>
		public PlotOptionsItem Item { get; set; }
		private PlotOptionsItem Item_DefaultValue { get; set; }
		 

		/// <summary>
		/// A line series displays information as a series of data points connected bystraight line segments.In TypeScript the [type](series.line.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `line` series are defined in   [plotOptions.line](plotOptions.line).3. Options for one single series are given in   [the series instance array](series.line).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        line: {            // shared options for all line series        }    },    series: [{        // specific options for this series instance        type: 'line'    }]});```            
		/// </summary>
		public PlotOptionsLine Line { get; set; }
		private PlotOptionsLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lollipop series is a carteseian series with a line anchored fromthe x axis and a dot at the end to mark the value.Requires `highcharts-more.js`, `modules/dumbbell.js` and`modules/lollipop.js`.In TypeScript the [type](series.lollipop.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `lollipop` series are defined in   [plotOptions.lollipop](plotOptions.lollipop).3. Options for one single series are given in   [the series instance array](series.lollipop).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        lollipop: {            // shared options for all lollipop series        }    },    series: [{        // specific options for this series instance        type: 'lollipop'    }]});```            
		/// </summary>
		public PlotOptionsLollipop Lollipop { get; set; }
		private PlotOptionsLollipop Lollipop_DefaultValue { get; set; }
		 

		/// <summary>
		/// A networkgraph is a type of relationship chart, where connnections(links) attracts nodes (points) and other nodes repulse each other.In TypeScript the [type](series.networkgraph.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `networkgraph` series are defined in   [plotOptions.networkgraph](plotOptions.networkgraph).3. Options for one single series are given in   [the series instance array](series.networkgraph).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        networkgraph: {            // shared options for all networkgraph series        }    },    series: [{        // specific options for this series instance        type: 'networkgraph'    }]});```            
		/// </summary>
		public PlotOptionsNetworkgraph Networkgraph { get; set; }
		private PlotOptionsNetworkgraph Networkgraph_DefaultValue { get; set; }
		 

		/// <summary>
		/// An organization chart is a diagram that shows the structure of anorganization and the relationships and relative ranks of its parts andpositions.In TypeScript the [type](series.organization.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `organization` series are defined in   [plotOptions.organization](plotOptions.organization).3. Options for one single series are given in   [the series instance array](series.organization).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        organization: {            // shared options for all organization series        }    },    series: [{        // specific options for this series instance        type: 'organization'    }]});```            
		/// </summary>
		public PlotOptionsOrganization Organization { get; set; }
		private PlotOptionsOrganization Organization_DefaultValue { get; set; }
		 

		/// <summary>
		/// A packed bubble series is a two dimensional series type, where each pointrenders a value in X, Y position. Each point is drawn as a bubblewhere the bubbles don't overlap with each other and the radiusof the bubble relates to the value.In TypeScript the [type](series.packedbubble.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `packedbubble` series are defined in   [plotOptions.packedbubble](plotOptions.packedbubble).3. Options for one single series are given in   [the series instance array](series.packedbubble).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        packedbubble: {            // shared options for all packedbubble series        }    },    series: [{        // specific options for this series instance        type: 'packedbubble'    }]});```            
		/// </summary>
		public PlotOptionsPackedbubble Packedbubble { get; set; }
		private PlotOptionsPackedbubble Packedbubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pareto diagram is a type of chart that contains both bars and a linegraph, where individual values are represented in descending order bybars, and the cumulative total is represented by the line.In TypeScript the [type](series.pareto.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `pareto` series are defined in   [plotOptions.pareto](plotOptions.pareto).3. Options for one single series are given in   [the series instance array](series.pareto).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        pareto: {            // shared options for all pareto series        }    },    series: [{        // specific options for this series instance        type: 'pareto'    }]});```            
		/// </summary>
		public PlotOptionsPareto Pareto { get; set; }
		private PlotOptionsPareto Pareto_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pie chart is a circular graphic which is divided into slices toillustrate numerical proportion.In TypeScript the [type](series.pie.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `pie` series are defined in   [plotOptions.pie](plotOptions.pie).3. Options for one single series are given in   [the series instance array](series.pie).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        pie: {            // shared options for all pie series        }    },    series: [{        // specific options for this series instance        type: 'pie'    }]});```            
		/// </summary>
		public PlotOptionsPie Pie { get; set; }
		private PlotOptionsPie Pie_DefaultValue { get; set; }
		 

		/// <summary>
		/// A polygon series can be used to draw any freeform shape in the cartesiancoordinate system. A fill is applied with the `color` option, andstroke is applied through `lineWidth` and `lineColor` options.In TypeScript the [type](series.polygon.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `polygon` series are defined in   [plotOptions.polygon](plotOptions.polygon).3. Options for one single series are given in   [the series instance array](series.polygon).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        polygon: {            // shared options for all polygon series        }    },    series: [{        // specific options for this series instance        type: 'polygon'    }]});```            
		/// </summary>
		public PlotOptionsPolygon Polygon { get; set; }
		private PlotOptionsPolygon Polygon_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pyramid series is a special type of funnel, without neck and reversedby default.In TypeScript the [type](series.pyramid.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `pyramid` series are defined in   [plotOptions.pyramid](plotOptions.pyramid).3. Options for one single series are given in   [the series instance array](series.pyramid).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        pyramid: {            // shared options for all pyramid series        }    },    series: [{        // specific options for this series instance        type: 'pyramid'    }]});```            
		/// </summary>
		public PlotOptionsPyramid Pyramid { get; set; }
		private PlotOptionsPyramid Pyramid_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pyramid3d is a 3d version of pyramid series type. Pyramid charts area type of chart often used to visualize stages in a sales project,where the top are the initial stages with the most clients.In TypeScript the [type](series.pyramid3d.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `pyramid3d` series are defined in   [plotOptions.pyramid3d](plotOptions.pyramid3d).3. Options for one single series are given in   [the series instance array](series.pyramid3d).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        pyramid3d: {            // shared options for all pyramid3d series        }    },    series: [{        // specific options for this series instance        type: 'pyramid3d'    }]});```            
		/// </summary>
		public PlotOptionsPyramid3d Pyramid3d { get; set; }
		private PlotOptionsPyramid3d Pyramid3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// A sankey diagram is a type of flow diagram, in which the width of thelink between two nodes is shown proportionally to the flow quantity.In TypeScript the [type](series.sankey.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `sankey` series are defined in   [plotOptions.sankey](plotOptions.sankey).3. Options for one single series are given in   [the series instance array](series.sankey).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        sankey: {            // shared options for all sankey series        }    },    series: [{        // specific options for this series instance        type: 'sankey'    }]});```            
		/// </summary>
		public PlotOptionsSankey Sankey { get; set; }
		private PlotOptionsSankey Sankey_DefaultValue { get; set; }
		 

		/// <summary>
		/// A scatter plot uses cartesian coordinates to display values for twovariables for a set of data.In TypeScript the [type](series.scatter.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `scatter` series are defined in   [plotOptions.scatter](plotOptions.scatter).3. Options for one single series are given in   [the series instance array](series.scatter).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        scatter: {            // shared options for all scatter series        }    },    series: [{        // specific options for this series instance        type: 'scatter'    }]});```            
		/// </summary>
		public PlotOptionsScatter Scatter { get; set; }
		private PlotOptionsScatter Scatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// A 3D scatter plot uses x, y and z coordinates to display values for threevariables for a set of data.In TypeScript the [type](series.scatter3d.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `scatter3d` series are defined in   [plotOptions.scatter3d](plotOptions.scatter3d).3. Options for one single series are given in   [the series instance array](series.scatter3d).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        scatter3d: {            // shared options for all scatter3d series        }    },    series: [{        // specific options for this series instance        type: 'scatter3d'    }]});```            
		/// </summary>
		public PlotOptionsScatter3d Scatter3d { get; set; }
		private PlotOptionsScatter3d Scatter3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// General options for all series types.In TypeScript the [type](series.line.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `line` series are defined in   [plotOptions.line](plotOptions.line).3. Options for one single series are given in   [the series instance array](series.line).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        line: {            // shared options for all line series        }    },    series: [{        // specific options for this series instance        type: 'line'    }]});```            
		/// </summary>
		public PlotOptionsSeries Series { get; set; }
		private PlotOptionsSeries Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// A solid gauge is a circular gauge where the value is indicated by a filledarc, and the color of the arc may variate with the value.In TypeScript the [type](series.solidgauge.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `solidgauge` series are defined in   [plotOptions.solidgauge](plotOptions.solidgauge).3. Options for one single series are given in   [the series instance array](series.solidgauge).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        solidgauge: {            // shared options for all solidgauge series        }    },    series: [{        // specific options for this series instance        type: 'solidgauge'    }]});```            
		/// </summary>
		public PlotOptionsSolidgauge Solidgauge { get; set; }
		private PlotOptionsSolidgauge Solidgauge_DefaultValue { get; set; }
		 

		/// <summary>
		/// A spline series is a special type of line series, where the segmentsbetween the data points are smoothed.In TypeScript the [type](series.spline.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `spline` series are defined in   [plotOptions.spline](plotOptions.spline).3. Options for one single series are given in   [the series instance array](series.spline).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        spline: {            // shared options for all spline series        }    },    series: [{        // specific options for this series instance        type: 'spline'    }]});```            
		/// </summary>
		public PlotOptionsSpline Spline { get; set; }
		private PlotOptionsSpline Spline_DefaultValue { get; set; }
		 

		/// <summary>
		/// A streamgraph is a type of stacked area graph which is displaced around acentral axis, resulting in a flowing, organic shape.In TypeScript the [type](series.streamgraph.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `streamgraph` series are defined in   [plotOptions.streamgraph](plotOptions.streamgraph).3. Options for one single series are given in   [the series instance array](series.streamgraph).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        streamgraph: {            // shared options for all streamgraph series        }    },    series: [{        // specific options for this series instance        type: 'streamgraph'    }]});```            
		/// </summary>
		public PlotOptionsStreamgraph Streamgraph { get; set; }
		private PlotOptionsStreamgraph Streamgraph_DefaultValue { get; set; }
		 

		/// <summary>
		/// A Sunburst displays hierarchical data, where a level in the hierarchy isrepresented by a circle. The center represents the root node of the tree.The visualization bears a resemblance to both treemap and pie charts.In TypeScript the [type](series.sunburst.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `sunburst` series are defined in   [plotOptions.sunburst](plotOptions.sunburst).3. Options for one single series are given in   [the series instance array](series.sunburst).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        sunburst: {            // shared options for all sunburst series        }    },    series: [{        // specific options for this series instance        type: 'sunburst'    }]});```            
		/// </summary>
		public PlotOptionsSunburst Sunburst { get; set; }
		private PlotOptionsSunburst Sunburst_DefaultValue { get; set; }
		 

		/// <summary>
		/// A tilemap series is a type of heatmap where the tile shapes areconfigurable.In TypeScript the [type](series.tilemap.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `tilemap` series are defined in   [plotOptions.tilemap](plotOptions.tilemap).3. Options for one single series are given in   [the series instance array](series.tilemap).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        tilemap: {            // shared options for all tilemap series        }    },    series: [{        // specific options for this series instance        type: 'tilemap'    }]});```            
		/// </summary>
		public PlotOptionsTilemap Tilemap { get; set; }
		private PlotOptionsTilemap Tilemap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The timeline series presents given events along a drawn line.In TypeScript the [type](series.timeline.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `timeline` series are defined in   [plotOptions.timeline](plotOptions.timeline).3. Options for one single series are given in   [the series instance array](series.timeline).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        timeline: {            // shared options for all timeline series        }    },    series: [{        // specific options for this series instance        type: 'timeline'    }]});```            
		/// </summary>
		public PlotOptionsTimeline Timeline { get; set; }
		private PlotOptionsTimeline Timeline_DefaultValue { get; set; }
		 

		/// <summary>
		/// A treemap displays hierarchical data using nested rectangles. The datacan be laid out in varying ways depending on options.In TypeScript the [type](series.treemap.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `treemap` series are defined in   [plotOptions.treemap](plotOptions.treemap).3. Options for one single series are given in   [the series instance array](series.treemap).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        treemap: {            // shared options for all treemap series        }    },    series: [{        // specific options for this series instance        type: 'treemap'    }]});```            
		/// </summary>
		public PlotOptionsTreemap Treemap { get; set; }
		private PlotOptionsTreemap Treemap_DefaultValue { get; set; }
		 

		/// <summary>
		/// A variable pie series is a two dimensional series type, where each pointrenders an Y and Z value.  Each point is drawn as a pie slice where thesize (arc) of the slice relates to the Y value and the radius of pieslice relates to the Z value.In TypeScript the [type](series.variablepie.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `variablepie` series are defined in   [plotOptions.variablepie](plotOptions.variablepie).3. Options for one single series are given in   [the series instance array](series.variablepie).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        variablepie: {            // shared options for all variablepie series        }    },    series: [{        // specific options for this series instance        type: 'variablepie'    }]});```            
		/// </summary>
		public PlotOptionsVariablepie Variablepie { get; set; }
		private PlotOptionsVariablepie Variablepie_DefaultValue { get; set; }
		 

		/// <summary>
		/// A variwide chart (related to marimekko chart) is a column chart with avariable width expressing a third dimension.In TypeScript the [type](series.variwide.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `variwide` series are defined in   [plotOptions.variwide](plotOptions.variwide).3. Options for one single series are given in   [the series instance array](series.variwide).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        variwide: {            // shared options for all variwide series        }    },    series: [{        // specific options for this series instance        type: 'variwide'    }]});```            
		/// </summary>
		public PlotOptionsVariwide Variwide { get; set; }
		private PlotOptionsVariwide Variwide_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vector plot is a type of cartesian chart where each point has an X andY position, a length and a direction. Vectors are drawn as arrows.In TypeScript the [type](series.vector.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `vector` series are defined in   [plotOptions.vector](plotOptions.vector).3. Options for one single series are given in   [the series instance array](series.vector).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        vector: {            // shared options for all vector series        }    },    series: [{        // specific options for this series instance        type: 'vector'    }]});```            
		/// </summary>
		public PlotOptionsVector Vector { get; set; }
		private PlotOptionsVector Vector_DefaultValue { get; set; }
		 

		/// <summary>
		/// A Venn diagram displays all possible logical relations between acollection of different sets. The sets are represented by circles, andthe relation between the sets are displayed by the overlap or lack ofoverlap between them. The venn diagram is a special case of Eulerdiagrams, which can also be displayed by this series type.In TypeScript the [type](series.venn.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `venn` series are defined in   [plotOptions.venn](plotOptions.venn).3. Options for one single series are given in   [the series instance array](series.venn).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        venn: {            // shared options for all venn series        }    },    series: [{        // specific options for this series instance        type: 'venn'    }]});```            
		/// </summary>
		public PlotOptionsVenn Venn { get; set; }
		private PlotOptionsVenn Venn_DefaultValue { get; set; }
		 

		/// <summary>
		/// A waterfall chart displays sequentially introduced positive or negativevalues in cumulative columns.In TypeScript the [type](series.waterfall.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `waterfall` series are defined in   [plotOptions.waterfall](plotOptions.waterfall).3. Options for one single series are given in   [the series instance array](series.waterfall).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        waterfall: {            // shared options for all waterfall series        }    },    series: [{        // specific options for this series instance        type: 'waterfall'    }]});```            
		/// </summary>
		public PlotOptionsWaterfall Waterfall { get; set; }
		private PlotOptionsWaterfall Waterfall_DefaultValue { get; set; }
		 

		/// <summary>
		/// Wind barbs are a convenient way to represent wind speed and direction inone graphical form. Wind direction is given by the stem direction, andwind speed by the number and shape of barbs.In TypeScript the [type](series.windbarb.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `windbarb` series are defined in   [plotOptions.windbarb](plotOptions.windbarb).3. Options for one single series are given in   [the series instance array](series.windbarb).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        windbarb: {            // shared options for all windbarb series        }    },    series: [{        // specific options for this series instance        type: 'windbarb'    }]});```            
		/// </summary>
		public PlotOptionsWindbarb Windbarb { get; set; }
		private PlotOptionsWindbarb Windbarb_DefaultValue { get; set; }
		 

		/// <summary>
		/// A word cloud is a visualization of a set of words, where the size andplacement of a word is determined by how it is weighted.In TypeScript the [type](series.wordcloud.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `wordcloud` series are defined in   [plotOptions.wordcloud](plotOptions.wordcloud).3. Options for one single series are given in   [the series instance array](series.wordcloud).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        wordcloud: {            // shared options for all wordcloud series        }    },    series: [{        // specific options for this series instance        type: 'wordcloud'    }]});```            
		/// </summary>
		public PlotOptionsWordcloud Wordcloud { get; set; }
		private PlotOptionsWordcloud Wordcloud_DefaultValue { get; set; }
		 

		/// <summary>
		/// The X-range series displays ranges on the X axis, typically timeintervals with a start and end date.In TypeScript the [type](series.xrange.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `xrange` series are defined in   [plotOptions.xrange](plotOptions.xrange).3. Options for one single series are given in   [the series instance array](series.xrange).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        xrange: {            // shared options for all xrange series        }    },    series: [{        // specific options for this series instance        type: 'xrange'    }]});```            
		/// </summary>
		public PlotOptionsXrange Xrange { get; set; }
		private PlotOptionsXrange Xrange_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Arcdiagram.IsDirty(highcharts)) h.Add("arcdiagram",Arcdiagram.ToHashtable(highcharts));
			if (Area.IsDirty(highcharts)) h.Add("area",Area.ToHashtable(highcharts));
			if (Arearange.IsDirty(highcharts)) h.Add("arearange",Arearange.ToHashtable(highcharts));
			if (Areaspline.IsDirty(highcharts)) h.Add("areaspline",Areaspline.ToHashtable(highcharts));
			if (Areasplinerange.IsDirty(highcharts)) h.Add("areasplinerange",Areasplinerange.ToHashtable(highcharts));
			if (Bar.IsDirty(highcharts)) h.Add("bar",Bar.ToHashtable(highcharts));
			if (Bellcurve.IsDirty(highcharts)) h.Add("bellcurve",Bellcurve.ToHashtable(highcharts));
			if (Boxplot.IsDirty(highcharts)) h.Add("boxplot",Boxplot.ToHashtable(highcharts));
			if (Bubble.IsDirty(highcharts)) h.Add("bubble",Bubble.ToHashtable(highcharts));
			if (Bullet.IsDirty(highcharts)) h.Add("bullet",Bullet.ToHashtable(highcharts));
			if (Column.IsDirty(highcharts)) h.Add("column",Column.ToHashtable(highcharts));
			if (Columnpyramid.IsDirty(highcharts)) h.Add("columnpyramid",Columnpyramid.ToHashtable(highcharts));
			if (Columnrange.IsDirty(highcharts)) h.Add("columnrange",Columnrange.ToHashtable(highcharts));
			if (Cylinder.IsDirty(highcharts)) h.Add("cylinder",Cylinder.ToHashtable(highcharts));
			if (Dependencywheel.IsDirty(highcharts)) h.Add("dependencywheel",Dependencywheel.ToHashtable(highcharts));
			if (Dumbbell.IsDirty(highcharts)) h.Add("dumbbell",Dumbbell.ToHashtable(highcharts));
			if (Errorbar.IsDirty(highcharts)) h.Add("errorbar",Errorbar.ToHashtable(highcharts));
			if (Funnel.IsDirty(highcharts)) h.Add("funnel",Funnel.ToHashtable(highcharts));
			if (Funnel3d.IsDirty(highcharts)) h.Add("funnel3d",Funnel3d.ToHashtable(highcharts));
			if (Gauge.IsDirty(highcharts)) h.Add("gauge",Gauge.ToHashtable(highcharts));
			if (Heatmap.IsDirty(highcharts)) h.Add("heatmap",Heatmap.ToHashtable(highcharts));
			if (Histogram.IsDirty(highcharts)) h.Add("histogram",Histogram.ToHashtable(highcharts));
			if (Item.IsDirty(highcharts)) h.Add("item",Item.ToHashtable(highcharts));
			if (Line.IsDirty(highcharts)) h.Add("line",Line.ToHashtable(highcharts));
			if (Lollipop.IsDirty(highcharts)) h.Add("lollipop",Lollipop.ToHashtable(highcharts));
			if (Networkgraph.IsDirty(highcharts)) h.Add("networkgraph",Networkgraph.ToHashtable(highcharts));
			if (Organization.IsDirty(highcharts)) h.Add("organization",Organization.ToHashtable(highcharts));
			if (Packedbubble.IsDirty(highcharts)) h.Add("packedbubble",Packedbubble.ToHashtable(highcharts));
			if (Pareto.IsDirty(highcharts)) h.Add("pareto",Pareto.ToHashtable(highcharts));
			if (Pie.IsDirty(highcharts)) h.Add("pie",Pie.ToHashtable(highcharts));
			if (Polygon.IsDirty(highcharts)) h.Add("polygon",Polygon.ToHashtable(highcharts));
			if (Pyramid.IsDirty(highcharts)) h.Add("pyramid",Pyramid.ToHashtable(highcharts));
			if (Pyramid3d.IsDirty(highcharts)) h.Add("pyramid3d",Pyramid3d.ToHashtable(highcharts));
			if (Sankey.IsDirty(highcharts)) h.Add("sankey",Sankey.ToHashtable(highcharts));
			if (Scatter.IsDirty(highcharts)) h.Add("scatter",Scatter.ToHashtable(highcharts));
			if (Scatter3d.IsDirty(highcharts)) h.Add("scatter3d",Scatter3d.ToHashtable(highcharts));
			if (Series.IsDirty(highcharts)) h.Add("series",Series.ToHashtable(highcharts));
			if (Solidgauge.IsDirty(highcharts)) h.Add("solidgauge",Solidgauge.ToHashtable(highcharts));
			if (Spline.IsDirty(highcharts)) h.Add("spline",Spline.ToHashtable(highcharts));
			if (Streamgraph.IsDirty(highcharts)) h.Add("streamgraph",Streamgraph.ToHashtable(highcharts));
			if (Sunburst.IsDirty(highcharts)) h.Add("sunburst",Sunburst.ToHashtable(highcharts));
			if (Tilemap.IsDirty(highcharts)) h.Add("tilemap",Tilemap.ToHashtable(highcharts));
			if (Timeline.IsDirty(highcharts)) h.Add("timeline",Timeline.ToHashtable(highcharts));
			if (Treemap.IsDirty(highcharts)) h.Add("treemap",Treemap.ToHashtable(highcharts));
			if (Variablepie.IsDirty(highcharts)) h.Add("variablepie",Variablepie.ToHashtable(highcharts));
			if (Variwide.IsDirty(highcharts)) h.Add("variwide",Variwide.ToHashtable(highcharts));
			if (Vector.IsDirty(highcharts)) h.Add("vector",Vector.ToHashtable(highcharts));
			if (Venn.IsDirty(highcharts)) h.Add("venn",Venn.ToHashtable(highcharts));
			if (Waterfall.IsDirty(highcharts)) h.Add("waterfall",Waterfall.ToHashtable(highcharts));
			if (Windbarb.IsDirty(highcharts)) h.Add("windbarb",Windbarb.ToHashtable(highcharts));
			if (Wordcloud.IsDirty(highcharts)) h.Add("wordcloud",Wordcloud.ToHashtable(highcharts));
			if (Xrange.IsDirty(highcharts)) h.Add("xrange",Xrange.ToHashtable(highcharts));
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}
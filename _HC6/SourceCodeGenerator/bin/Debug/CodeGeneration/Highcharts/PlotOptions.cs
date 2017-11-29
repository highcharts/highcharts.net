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
			Bellcurve = Bellcurve_DefaultValue = "";
			Series = Series_DefaultValue = new List<Series>();
			Bullet = Bullet_DefaultValue = "";
			Funnel = Funnel_DefaultValue = "";
			Pyramid = Pyramid_DefaultValue = "";
			Histogram = Histogram_DefaultValue = "";
			Pareto = Pareto_DefaultValue = "";
			Sankey = Sankey_DefaultValue = "";
			Solidgauge = Solidgauge_DefaultValue = "";
			Streamgraph = Streamgraph_DefaultValue = "";
			Sunburst = Sunburst_DefaultValue = "";
			Tilemap = Tilemap_DefaultValue = "";
			Treemap = Treemap_DefaultValue = "";
			Variablepie = Variablepie_DefaultValue = "";
			Variwide = Variwide_DefaultValue = "";
			Vector = Vector_DefaultValue = "";
			Windbarb = Windbarb_DefaultValue = "";
			Wordcloud = Wordcloud_DefaultValue = "";
			Xrange = Xrange_DefaultValue = "";
			Area = Area_DefaultValue = "";
			Areaspline = Areaspline_DefaultValue = "";
			Bar = Bar_DefaultValue = "";
			Column = Column_DefaultValue = "";
			Pie = Pie_DefaultValue = "";
			Scatter = Scatter_DefaultValue = "";
			Line = Line_DefaultValue = "";
			Spline = Spline_DefaultValue = "";
			Scatter3d = Scatter3d_DefaultValue = "";
			Arearange = Arearange_DefaultValue = "";
			Areasplinerange = Areasplinerange_DefaultValue = "";
			Boxplot = Boxplot_DefaultValue = "";
			Bubble = Bubble_DefaultValue = "";
			Columnrange = Columnrange_DefaultValue = "";
			Errorbar = Errorbar_DefaultValue = "";
			Gauge = Gauge_DefaultValue = "";
			Polygon = Polygon_DefaultValue = "";
			Waterfall = Waterfall_DefaultValue = "";
			Heatmap = Heatmap_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// A bell curve is an areaspline series which represents the probability densityfunction of the normal distribution. It calculates mean and standarddeviation of the base series data and plots the curve according to thecalculated parameters.
		/// </summary>
		public PlotOptionsbellcurve Bellcurve { get; set; }
		private PlotOptionsbellcurve Bellcurve_DefaultValue { get; set; }
		 

		/// <summary>
		/// General options for all series types.
		/// </summary>
		public List<Series> Series { get; set; }
		private List<Series> Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// A bullet graph is a variation of a bar graph. The bullet graph featuresa single measure, compares it to a target, and displays it in the contextof qualitative ranges of performance that could be set using[plotBands](#yAxis.plotBands) on [yAxis](#yAxis).
		/// </summary>
		public PlotOptionsbullet Bullet { get; set; }
		private PlotOptionsbullet Bullet_DefaultValue { get; set; }
		 

		/// <summary>
		/// Funnel charts are a type of chart often used to visualize stages in a sales project, where the top are the initial stages with the most clients. It requires that the modules/funnel.js file is loaded.
		/// </summary>
		public PlotOptionsfunnel Funnel { get; set; }
		private PlotOptionsfunnel Funnel_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pyramid series is a special type of funnel, without neck and reversed bydefault.
		/// </summary>
		public PlotOptionspyramid Pyramid { get; set; }
		private PlotOptionspyramid Pyramid_DefaultValue { get; set; }
		 

		/// <summary>
		/// A histogram is a column series which represents the distribution of the dataset in the base series. Histogram splits data into bins and shows their frequencies.
		/// </summary>
		public PlotOptionshistogram Histogram { get; set; }
		private PlotOptionshistogram Histogram_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pareto diagram is a type of chart that contains both bars and a line graph, where individual values are represented in descending order by bars, and the cumulative total is represented by the line.
		/// </summary>
		public PlotOptionspareto Pareto { get; set; }
		private PlotOptionspareto Pareto_DefaultValue { get; set; }
		 

		/// <summary>
		/// A sankey diagram is a type of flow diagram, in which the width of the link between two nodes is shown proportionally to the flow quantity.
		/// </summary>
		public PlotOptionssankey Sankey { get; set; }
		private PlotOptionssankey Sankey_DefaultValue { get; set; }
		 

		/// <summary>
		/// A solid gauge is a circular gauge where the value is indicated by a filledarc, and the color of the arc may variate with the value.
		/// </summary>
		public PlotOptionssolidgauge Solidgauge { get; set; }
		private PlotOptionssolidgauge Solidgauge_DefaultValue { get; set; }
		 

		/// <summary>
		/// A streamgraph is a type of stacked area graph which is displaced around acentral axis, resulting in a flowing, organic shape.
		/// </summary>
		public PlotOptionsstreamgraph Streamgraph { get; set; }
		private PlotOptionsstreamgraph Streamgraph_DefaultValue { get; set; }
		 

		/// <summary>
		/// A Sunburst displays hierarchical data, where a level in the hierarchy is represented by a circle.The center represents the root node of the tree.The visualization bears a resemblance to both treemap and pie charts.
		/// </summary>
		public PlotOptionssunburst Sunburst { get; set; }
		private PlotOptionssunburst Sunburst_DefaultValue { get; set; }
		 

		/// <summary>
		/// A tilemap series is a type of heatmap where the tile shapes are configurable.
		/// </summary>
		public PlotOptionstilemap Tilemap { get; set; }
		private PlotOptionstilemap Tilemap_DefaultValue { get; set; }
		 

		/// <summary>
		/// A treemap displays hierarchical data using nested rectangles. The data can belaid out in varying ways depending on options.
		/// </summary>
		public PlotOptionstreemap Treemap { get; set; }
		private PlotOptionstreemap Treemap_DefaultValue { get; set; }
		 

		/// <summary>
		/// A variable pie series is a two dimensional series type, where each pointrenders an Y and Z value.  Each point is drawn as a pie slice where thesize (arc) of the slice relates to the Y value and the radius of pieslice relates to the Z value. Requires `highcharts-more.js`.
		/// </summary>
		public PlotOptionsvariablepie Variablepie { get; set; }
		private PlotOptionsvariablepie Variablepie_DefaultValue { get; set; }
		 

		/// <summary>
		/// A variwide chart (related to marimekko chart) is a column chart with avariable width expressing a third dimension.
		/// </summary>
		public PlotOptionsvariwide Variwide { get; set; }
		private PlotOptionsvariwide Variwide_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vector plot is a type of cartesian chart where each point has an X and Yposition, a length and a direction. Vectors are drawn as arrows.
		/// </summary>
		public PlotOptionsvector Vector { get; set; }
		private PlotOptionsvector Vector_DefaultValue { get; set; }
		 

		/// <summary>
		/// Wind barbs are a convenient way to represent wind speed and direction in onegraphical form. Wind direction is given by the stem direction, and wind speedby the number and shape of barbs.
		/// </summary>
		public PlotOptionswindbarb Windbarb { get; set; }
		private PlotOptionswindbarb Windbarb_DefaultValue { get; set; }
		 

		/// <summary>
		/// A word cloud is a visualization of a set of words, where the size andplacement of a word is determined by how it is weighted.
		/// </summary>
		public PlotOptionswordcloud Wordcloud { get; set; }
		private PlotOptionswordcloud Wordcloud_DefaultValue { get; set; }
		 

		/// <summary>
		/// The X-range series displays ranges on the X axis, typically time intervalswith a start and end date.
		/// </summary>
		public PlotOptionsxrange Xrange { get; set; }
		private PlotOptionsxrange Xrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area series type.
		/// </summary>
		public PlotOptionsarea Area { get; set; }
		private PlotOptionsarea Area_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area spline series is an area series where the graph between the pointsis smoothed into a spline.
		/// </summary>
		public PlotOptionsareaspline Areaspline { get; set; }
		private PlotOptionsareaspline Areaspline_DefaultValue { get; set; }
		 

		/// <summary>
		/// A bar series is a special type of column series where the columns arehorizontal.
		/// </summary>
		public PlotOptionsbar Bar { get; set; }
		private PlotOptionsbar Bar_DefaultValue { get; set; }
		 

		/// <summary>
		/// Column series display one column per value along an X axis.
		/// </summary>
		public PlotOptionscolumn Column { get; set; }
		private PlotOptionscolumn Column_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pie chart is a circular graphic which is divided into slices to illustratenumerical proportion.
		/// </summary>
		public PlotOptionspie Pie { get; set; }
		private PlotOptionspie Pie_DefaultValue { get; set; }
		 

		/// <summary>
		/// A scatter plot uses cartesian coordinates to display values for two variablesfor a set of data.
		/// </summary>
		public PlotOptionsscatter Scatter { get; set; }
		private PlotOptionsscatter Scatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// A line series displays information as a series of data points connected bystraight line segments.
		/// </summary>
		public PlotOptionsline Line { get; set; }
		private PlotOptionsline Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// A spline series is a special type of line series, where the segments betweenthe data points are smoothed.
		/// </summary>
		public PlotOptionsspline Spline { get; set; }
		private PlotOptionsspline Spline_DefaultValue { get; set; }
		 

		/// <summary>
		/// A 3D scatter plot uses x, y and z coordinates to display values for threevariables for a set of data.
		/// </summary>
		public PlotOptionsscatter3d Scatter3d { get; set; }
		private PlotOptionsscatter3d Scatter3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area range series is a carteseian series with higher and lower valuesfor each point along an X axis, where the area between the values is shaded.Requires `highcharts-more.js`.
		/// </summary>
		public PlotOptionsarearange Arearange { get; set; }
		private PlotOptionsarearange Arearange_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area spline range is a cartesian series type with higher andlower Y values along an X axis. The area inside the range is colored, andthe graph outlining the area is a smoothed spline. Requires`highcharts-more.js`.
		/// </summary>
		public PlotOptionsareasplinerange Areasplinerange { get; set; }
		private PlotOptionsareasplinerange Areasplinerange_DefaultValue { get; set; }
		 

		/// <summary>
		/// A box plot is a convenient way of depicting groups of data through theirfive-number summaries: the smallest observation (sample minimum), lowerquartile (Q1), median (Q2), upper quartile (Q3), and largest observation(sample maximum).
		/// </summary>
		public PlotOptionsboxplot Boxplot { get; set; }
		private PlotOptionsboxplot Boxplot_DefaultValue { get; set; }
		 

		/// <summary>
		/// A bubble series is a three dimensional series type where each point rendersan X, Y and Z value. Each points is drawn as a bubble where the positionalong the X and Y axes mark the X and Y values, and the size of the bubblerelates to the Z value. Requires `highcharts-more.js`.
		/// </summary>
		public PlotOptionsbubble Bubble { get; set; }
		private PlotOptionsbubble Bubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// The column range is a cartesian series type with higher and lowerY values along an X axis. Requires `highcharts-more.js`. To displayhorizontal bars, set [chart.inverted](#chart.inverted) to `true`.
		/// </summary>
		public PlotOptionscolumnrange Columnrange { get; set; }
		private PlotOptionscolumnrange Columnrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// Error bars are a graphical representation of the variability of data and areused on graphs to indicate the error, or uncertainty in a reportedmeasurement.
		/// </summary>
		public PlotOptionserrorbar Errorbar { get; set; }
		private PlotOptionserrorbar Errorbar_DefaultValue { get; set; }
		 

		/// <summary>
		/// Gauges are circular plots displaying one or more values with a dial pointingto values along the perimeter.
		/// </summary>
		public PlotOptionsgauge Gauge { get; set; }
		private PlotOptionsgauge Gauge_DefaultValue { get; set; }
		 

		/// <summary>
		/// A polygon series can be used to draw any freeform shape in the cartesiancoordinate system. A fill is applied with the `color` option, andstroke is applied through `lineWidth` and `lineColor` options. Requiresthe `highcharts-more.js` file.
		/// </summary>
		public PlotOptionspolygon Polygon { get; set; }
		private PlotOptionspolygon Polygon_DefaultValue { get; set; }
		 

		/// <summary>
		/// A waterfall chart displays sequentially introduced positive or negativevalues in cumulative columns.
		/// </summary>
		public PlotOptionswaterfall Waterfall { get; set; }
		private PlotOptionswaterfall Waterfall_DefaultValue { get; set; }
		 

		/// <summary>
		/// A heatmap is a graphical representation of data where the individual valuescontained in a matrix are represented as colors.
		/// </summary>
		public PlotOptionsheatmap Heatmap { get; set; }
		private PlotOptionsheatmap Heatmap_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Bellcurve.IsDirty()) h.Add("bellcurve",Bellcurve.ToHashtable());
			if (Series != Series_DefaultValue) h.Add("series",Series);
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
			if (Areaspline != Areaspline_DefaultValue) h.Add("areaspline",Areaspline);
			if (Bar.IsDirty()) h.Add("bar",Bar.ToHashtable());
			if (Column.IsDirty()) h.Add("column",Column.ToHashtable());
			if (Pie.IsDirty()) h.Add("pie",Pie.ToHashtable());
			if (Scatter.IsDirty()) h.Add("scatter",Scatter.ToHashtable());
			if (Line.IsDirty()) h.Add("line",Line.ToHashtable());
			if (Spline != Spline_DefaultValue) h.Add("spline",Spline);
			if (Scatter3d.IsDirty()) h.Add("scatter3d",Scatter3d.ToHashtable());
			if (Arearange.IsDirty()) h.Add("arearange",Arearange.ToHashtable());
			if (Areasplinerange != Areasplinerange_DefaultValue) h.Add("areasplinerange",Areasplinerange);
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
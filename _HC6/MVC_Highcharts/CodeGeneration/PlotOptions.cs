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
			Series = Series_DefaultValue = new List<Series>();
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
		/// <p>A bell curve is an areaspline series which represents the probability densityfunction of the normal distribution. It calculates mean and standarddeviation of the base series data and plots the curve according to thecalculated parameters.</p>
		/// </summary>
		public PlotOptionsBellcurve Bellcurve { get; set; }
		private PlotOptionsBellcurve Bellcurve_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>General options for all series types.</p>
		/// </summary>
		public List<Series> Series { get; set; }
		private List<Series> Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A bullet graph is a variation of a bar graph. The bullet graph featuresa single measure, compares it to a target, and displays it in the contextof qualitative ranges of performance that could be set using<a href="#yAxis.plotBands">plotBands</a> on <a href="#yAxis">yAxis</a>.</p>
		/// </summary>
		public PlotOptionsBullet Bullet { get; set; }
		private PlotOptionsBullet Bullet_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Funnel charts are a type of chart often used to visualize stages in a sales project, where the top are the initial stages with the most clients. It requires that the modules/funnel.js file is loaded.</p>
		/// </summary>
		public PlotOptionsFunnel Funnel { get; set; }
		private PlotOptionsFunnel Funnel_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A pyramid series is a special type of funnel, without neck and reversed bydefault.</p>
		/// </summary>
		public PlotOptionsPyramid Pyramid { get; set; }
		private PlotOptionsPyramid Pyramid_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A histogram is a column series which represents the distribution of the dataset in the base series. Histogram splits data into bins and shows their frequencies.</p>
		/// </summary>
		public PlotOptionsHistogram Histogram { get; set; }
		private PlotOptionsHistogram Histogram_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A pareto diagram is a type of chart that contains both bars and a line graph, where individual values are represented in descending order by bars, and the cumulative total is represented by the line.</p>
		/// </summary>
		public PlotOptionsPareto Pareto { get; set; }
		private PlotOptionsPareto Pareto_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A sankey diagram is a type of flow diagram, in which the width of the link between two nodes is shown proportionally to the flow quantity.</p>
		/// </summary>
		public PlotOptionsSankey Sankey { get; set; }
		private PlotOptionsSankey Sankey_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A solid gauge is a circular gauge where the value is indicated by a filledarc, and the color of the arc may variate with the value.</p>
		/// </summary>
		public PlotOptionsSolidgauge Solidgauge { get; set; }
		private PlotOptionsSolidgauge Solidgauge_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A streamgraph is a type of stacked area graph which is displaced around acentral axis, resulting in a flowing, organic shape.</p>
		/// </summary>
		public PlotOptionsStreamgraph Streamgraph { get; set; }
		private PlotOptionsStreamgraph Streamgraph_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A Sunburst displays hierarchical data, where a level in the hierarchy is represented by a circle.The center represents the root node of the tree.The visualization bears a resemblance to both treemap and pie charts.</p>
		/// </summary>
		public PlotOptionsSunburst Sunburst { get; set; }
		private PlotOptionsSunburst Sunburst_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A tilemap series is a type of heatmap where the tile shapes are configurable.</p>
		/// </summary>
		public PlotOptionsTilemap Tilemap { get; set; }
		private PlotOptionsTilemap Tilemap_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A treemap displays hierarchical data using nested rectangles. The data can belaid out in varying ways depending on options.</p>
		/// </summary>
		public PlotOptionsTreemap Treemap { get; set; }
		private PlotOptionsTreemap Treemap_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A variable pie series is a two dimensional series type, where each pointrenders an Y and Z value.  Each point is drawn as a pie slice where thesize (arc) of the slice relates to the Y value and the radius of pieslice relates to the Z value. Requires <code>highcharts-more.js</code>.</p>
		/// </summary>
		public PlotOptionsVariablepie Variablepie { get; set; }
		private PlotOptionsVariablepie Variablepie_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A variwide chart (related to marimekko chart) is a column chart with avariable width expressing a third dimension.</p>
		/// </summary>
		public PlotOptionsVariwide Variwide { get; set; }
		private PlotOptionsVariwide Variwide_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A vector plot is a type of cartesian chart where each point has an X and Yposition, a length and a direction. Vectors are drawn as arrows.</p>
		/// </summary>
		public PlotOptionsVector Vector { get; set; }
		private PlotOptionsVector Vector_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Wind barbs are a convenient way to represent wind speed and direction in onegraphical form. Wind direction is given by the stem direction, and wind speedby the number and shape of barbs.</p>
		/// </summary>
		public PlotOptionsWindbarb Windbarb { get; set; }
		private PlotOptionsWindbarb Windbarb_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A word cloud is a visualization of a set of words, where the size andplacement of a word is determined by how it is weighted.</p>
		/// </summary>
		public PlotOptionsWordcloud Wordcloud { get; set; }
		private PlotOptionsWordcloud Wordcloud_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The X-range series displays ranges on the X axis, typically time intervalswith a start and end date.</p>
		/// </summary>
		public PlotOptionsXrange Xrange { get; set; }
		private PlotOptionsXrange Xrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The area series type.</p>
		/// </summary>
		public PlotOptionsArea Area { get; set; }
		private PlotOptionsArea Area_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The area spline series is an area series where the graph between the pointsis smoothed into a spline.</p>
		/// </summary>
		public PlotOptionsAreaspline Areaspline { get; set; }
		private PlotOptionsAreaspline Areaspline_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A bar series is a special type of column series where the columns arehorizontal.</p>
		/// </summary>
		public PlotOptionsBar Bar { get; set; }
		private PlotOptionsBar Bar_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Column series display one column per value along an X axis.</p>
		/// </summary>
		public PlotOptionsColumn Column { get; set; }
		private PlotOptionsColumn Column_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A pie chart is a circular graphic which is divided into slices to illustratenumerical proportion.</p>
		/// </summary>
		public PlotOptionsPie Pie { get; set; }
		private PlotOptionsPie Pie_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A scatter plot uses cartesian coordinates to display values for two variablesfor a set of data.</p>
		/// </summary>
		public PlotOptionsScatter Scatter { get; set; }
		private PlotOptionsScatter Scatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A line series displays information as a series of data points connected bystraight line segments.</p>
		/// </summary>
		public PlotOptionsLine Line { get; set; }
		private PlotOptionsLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A spline series is a special type of line series, where the segments betweenthe data points are smoothed.</p>
		/// </summary>
		public PlotOptionsSpline Spline { get; set; }
		private PlotOptionsSpline Spline_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A 3D scatter plot uses x, y and z coordinates to display values for threevariables for a set of data.</p>
		/// </summary>
		public PlotOptionsScatter3d Scatter3d { get; set; }
		private PlotOptionsScatter3d Scatter3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The area range series is a carteseian series with higher and lower valuesfor each point along an X axis, where the area between the values is shaded.Requires <code>highcharts-more.js</code>.</p>
		/// </summary>
		public PlotOptionsArearange Arearange { get; set; }
		private PlotOptionsArearange Arearange_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The area spline range is a cartesian series type with higher andlower Y values along an X axis. The area inside the range is colored, andthe graph outlining the area is a smoothed spline. Requires<code>highcharts-more.js</code>.</p>
		/// </summary>
		public PlotOptionsAreasplinerange Areasplinerange { get; set; }
		private PlotOptionsAreasplinerange Areasplinerange_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A box plot is a convenient way of depicting groups of data through theirfive-number summaries: the smallest observation (sample minimum), lowerquartile (Q1), median (Q2), upper quartile (Q3), and largest observation(sample maximum).</p>
		/// </summary>
		public PlotOptionsBoxplot Boxplot { get; set; }
		private PlotOptionsBoxplot Boxplot_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A bubble series is a three dimensional series type where each point rendersan X, Y and Z value. Each points is drawn as a bubble where the positionalong the X and Y axes mark the X and Y values, and the size of the bubblerelates to the Z value. Requires <code>highcharts-more.js</code>.</p>
		/// </summary>
		public PlotOptionsBubble Bubble { get; set; }
		private PlotOptionsBubble Bubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The column range is a cartesian series type with higher and lowerY values along an X axis. Requires <code>highcharts-more.js</code>. To displayhorizontal bars, set <a href="#chart.inverted">chart.inverted</a> to <code>true</code>.</p>
		/// </summary>
		public PlotOptionsColumnrange Columnrange { get; set; }
		private PlotOptionsColumnrange Columnrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Error bars are a graphical representation of the variability of data and areused on graphs to indicate the error, or uncertainty in a reportedmeasurement.</p>
		/// </summary>
		public PlotOptionsErrorbar Errorbar { get; set; }
		private PlotOptionsErrorbar Errorbar_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Gauges are circular plots displaying one or more values with a dial pointingto values along the perimeter.</p>
		/// </summary>
		public PlotOptionsGauge Gauge { get; set; }
		private PlotOptionsGauge Gauge_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A polygon series can be used to draw any freeform shape in the cartesiancoordinate system. A fill is applied with the <code>color</code> option, andstroke is applied through <code>lineWidth</code> and <code>lineColor</code> options. Requiresthe <code>highcharts-more.js</code> file.</p>
		/// </summary>
		public PlotOptionsPolygon Polygon { get; set; }
		private PlotOptionsPolygon Polygon_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A waterfall chart displays sequentially introduced positive or negativevalues in cumulative columns.</p>
		/// </summary>
		public PlotOptionsWaterfall Waterfall { get; set; }
		private PlotOptionsWaterfall Waterfall_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A heatmap is a graphical representation of data where the individual valuescontained in a matrix are represented as colors.</p>
		/// </summary>
		public PlotOptionsHeatmap Heatmap { get; set; }
		private PlotOptionsHeatmap Heatmap_DefaultValue { get; set; }
		  

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
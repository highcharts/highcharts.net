using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class PlotOptions  : BaseObject
	{
		public PlotOptions()
		{
			Area = Area_DefaultValue = new PlotOptionsArea();
			Arearange = Arearange_DefaultValue = new PlotOptionsArearange();
			Areaspline = Areaspline_DefaultValue = new PlotOptionsAreaspline();
			Areasplinerange = Areasplinerange_DefaultValue = new PlotOptionsAreasplinerange();
			Bar = Bar_DefaultValue = new PlotOptionsBar();
			Boxplot = Boxplot_DefaultValue = new PlotOptionsBoxplot();
			Bubble = Bubble_DefaultValue = new PlotOptionsBubble();
			Column = Column_DefaultValue = new PlotOptionsColumn();
			Columnrange = Columnrange_DefaultValue = new PlotOptionsColumnrange();
			Errorbar = Errorbar_DefaultValue = new PlotOptionsErrorbar();
			Funnel = Funnel_DefaultValue = new PlotOptionsFunnel();
			Gauge = Gauge_DefaultValue = new PlotOptionsGauge();
			Heatmap = Heatmap_DefaultValue = new PlotOptionsHeatmap();
			Line = Line_DefaultValue = new PlotOptionsLine();
			Pie = Pie_DefaultValue = new PlotOptionsPie();
			Polygon = Polygon_DefaultValue = new PlotOptionsPolygon();
			Pyramid = Pyramid_DefaultValue = new PlotOptionsPyramid();
			Scatter = Scatter_DefaultValue = new PlotOptionsScatter();
			Series = Series_DefaultValue = new PlotOptionsSeries();
			Solidgauge = Solidgauge_DefaultValue = new PlotOptionsSolidgauge();
			Spline = Spline_DefaultValue = new PlotOptionsSpline();
			Treemap = Treemap_DefaultValue = new PlotOptionsTreemap();
			Waterfall = Waterfall_DefaultValue = new PlotOptionsWaterfall();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsArea Area { get; set; }
		private PlotOptionsArea Area_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area range is a cartesian series type with higher and lower Y values along an X axis. Requires <code>highcharts-more.js</code>.
		/// </summary>
		public PlotOptionsArearange Arearange { get; set; }
		private PlotOptionsArearange Arearange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsAreaspline Areaspline { get; set; }
		private PlotOptionsAreaspline Areaspline_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area spline range is a cartesian series type with higher and lower Y values along an X axis. Requires <code>highcharts-more.js</code>.
		/// </summary>
		public PlotOptionsAreasplinerange Areasplinerange { get; set; }
		private PlotOptionsAreasplinerange Areasplinerange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBar Bar { get; set; }
		private PlotOptionsBar Bar_DefaultValue { get; set; }
		 

		/// <summary>
		/// A box plot is a convenient way of depicting groups of data through their five-number summaries: the smallest observation (sample minimum), lower quartile (Q1), median (Q2), upper quartile (Q3), and largest observation (sample maximum). 
		/// </summary>
		public PlotOptionsBoxplot Boxplot { get; set; }
		private PlotOptionsBoxplot Boxplot_DefaultValue { get; set; }
		 

		/// <summary>
		/// A bubble series is a three dimensional series type where each point renders an X, Y and Z value. Each points is drawn as a bubble where the position along the X and Y axes mark the X and Y values, and the size of the bubble relates to the Z value.
		/// </summary>
		public PlotOptionsBubble Bubble { get; set; }
		private PlotOptionsBubble Bubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsColumn Column { get; set; }
		private PlotOptionsColumn Column_DefaultValue { get; set; }
		 

		/// <summary>
		/// The column range is a cartesian series type with higher and lower Y values along an X axis. Requires <code>highcharts-more.js</code>. To display horizontal bars, set <a href="#chart.inverted">chart.inverted</a> to <code>true</code>.
		/// </summary>
		public PlotOptionsColumnrange Columnrange { get; set; }
		private PlotOptionsColumnrange Columnrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// Error bars are a graphical representation of the variability of data and are used on graphs to indicate the error, or uncertainty in a reported measurement. 
		/// </summary>
		public PlotOptionsErrorbar Errorbar { get; set; }
		private PlotOptionsErrorbar Errorbar_DefaultValue { get; set; }
		 

		/// <summary>
		/// Funnel charts are a type of chart often used to visualize stages in a sales project, where the top are the initial stages with the most clients. It requires that the <code>modules/funnel.js</code> file is loaded.
		/// </summary>
		public PlotOptionsFunnel Funnel { get; set; }
		private PlotOptionsFunnel Funnel_DefaultValue { get; set; }
		 

		/// <summary>
		/// General plotting options for the gauge series type. Requires <code>highcharts-more.js</code>
		/// </summary>
		public PlotOptionsGauge Gauge { get; set; }
		private PlotOptionsGauge Gauge_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The heatmap series type. This series type is available both in Highcharts and Highmaps.</p><p>The colors of each heat map point is usually determined by its value and controlled by settings on the <a href="#colorAxis">colorAxis</a>.</p>
		/// </summary>
		public PlotOptionsHeatmap Heatmap { get; set; }
		private PlotOptionsHeatmap Heatmap_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsLine Line { get; set; }
		private PlotOptionsLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pie chart is a circular chart divided into sectors, illustrating numerical proportion.
		/// </summary>
		public PlotOptionsPie Pie { get; set; }
		private PlotOptionsPie Pie_DefaultValue { get; set; }
		 

		/// <summary>
		/// A polygon series can be used to draw any freeform shape in the cartesian coordinate system. A fill is applied with the <code>color</code> option, and stroke is applied through <code>lineWidth</code> and <code>lineColor</code> options. Requires the <code>highcharts-more.js</code> file.
		/// </summary>
		public PlotOptionsPolygon Polygon { get; set; }
		private PlotOptionsPolygon Polygon_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pyramid chart consists of a single pyramid with item heights corresponding to each point value. Technically it is the same as a reversed funnel chart without a neck.
		/// </summary>
		public PlotOptionsPyramid Pyramid { get; set; }
		private PlotOptionsPyramid Pyramid_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsScatter Scatter { get; set; }
		private PlotOptionsScatter Scatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>General options for all series types.</p>
		/// </summary>
		public PlotOptionsSeries Series { get; set; }
		private PlotOptionsSeries Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// A gauge showing values using a filled arc with colors indicating the value. The solid gauge plots values against the <code>yAxis</code>, which is extended with some color options, <a href="#yAxis.minColor">minColor</a>, <a href="#yAxis.maxColor">maxColor</a> and <a href="#yAxis.stops">stops</a>, to control the color of the gauge itself.
		/// </summary>
		public PlotOptionsSolidgauge Solidgauge { get; set; }
		private PlotOptionsSolidgauge Solidgauge_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSpline Spline { get; set; }
		private PlotOptionsSpline Spline_DefaultValue { get; set; }
		 

		/// <summary>
		/// The size of the point shape is determined by its value relative to its siblings values.Requires the module <code>heatmap.js</code> as well, if functionality such as the <a href="http://api.highcharts.com/highmaps#colorAxis">colorAxis</a> is to be used.
		/// </summary>
		public PlotOptionsTreemap Treemap { get; set; }
		private PlotOptionsTreemap Treemap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the waterfall series type.
		/// </summary>
		public PlotOptionsWaterfall Waterfall { get; set; }
		private PlotOptionsWaterfall Waterfall_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Area.IsDirty()) h.Add("area",Area.ToHashtable());
			if (Arearange.IsDirty()) h.Add("arearange",Arearange.ToHashtable());
			if (Areaspline.IsDirty()) h.Add("areaspline",Areaspline.ToHashtable());
			if (Areasplinerange.IsDirty()) h.Add("areasplinerange",Areasplinerange.ToHashtable());
			if (Bar.IsDirty()) h.Add("bar",Bar.ToHashtable());
			if (Boxplot.IsDirty()) h.Add("boxplot",Boxplot.ToHashtable());
			if (Bubble.IsDirty()) h.Add("bubble",Bubble.ToHashtable());
			if (Column.IsDirty()) h.Add("column",Column.ToHashtable());
			if (Columnrange.IsDirty()) h.Add("columnrange",Columnrange.ToHashtable());
			if (Errorbar.IsDirty()) h.Add("errorbar",Errorbar.ToHashtable());
			if (Funnel.IsDirty()) h.Add("funnel",Funnel.ToHashtable());
			if (Gauge.IsDirty()) h.Add("gauge",Gauge.ToHashtable());
			if (Heatmap.IsDirty()) h.Add("heatmap",Heatmap.ToHashtable());
			if (Line.IsDirty()) h.Add("line",Line.ToHashtable());
			if (Pie.IsDirty()) h.Add("pie",Pie.ToHashtable());
			if (Polygon.IsDirty()) h.Add("polygon",Polygon.ToHashtable());
			if (Pyramid.IsDirty()) h.Add("pyramid",Pyramid.ToHashtable());
			if (Scatter.IsDirty()) h.Add("scatter",Scatter.ToHashtable());
			if (Solidgauge.IsDirty()) h.Add("solidgauge",Solidgauge.ToHashtable());
			if (Spline.IsDirty()) h.Add("spline",Spline.ToHashtable());
			if (Treemap.IsDirty()) h.Add("treemap",Treemap.ToHashtable());
			if (Waterfall.IsDirty()) h.Add("waterfall",Waterfall.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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
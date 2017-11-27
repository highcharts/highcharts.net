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
	public partial class Series  : BaseObject
	{
		public Series()
		{
			Bellcurve = Bellcurve_DefaultValue = null;
			Bullet = Bullet_DefaultValue = null;
			Line = Line_DefaultValue = null;
			Funnel = Funnel_DefaultValue = null;
			Pyramid = Pyramid_DefaultValue = null;
			Histogram = Histogram_DefaultValue = null;
			Pareto = Pareto_DefaultValue = null;
			Sankey = Sankey_DefaultValue = null;
			Solidgauge = Solidgauge_DefaultValue = null;
			Streamgraph = Streamgraph_DefaultValue = null;
			Sunburst = Sunburst_DefaultValue = null;
			Treemap = Treemap_DefaultValue = null;
			Tilemap = Tilemap_DefaultValue = null;
			Variablepie = Variablepie_DefaultValue = null;
			Variwide = Variwide_DefaultValue = null;
			Vector = Vector_DefaultValue = null;
			Windbarb = Windbarb_DefaultValue = null;
			Wordcloud = Wordcloud_DefaultValue = null;
			Xrange = Xrange_DefaultValue = null;
			Area = Area_DefaultValue = null;
			Areaspline = Areaspline_DefaultValue = null;
			Bar = Bar_DefaultValue = null;
			Column = Column_DefaultValue = null;
			Pie = Pie_DefaultValue = null;
			Scatter = Scatter_DefaultValue = null;
			Id = Id_DefaultValue = null;
			Index = Index_DefaultValue = null;
			LegendIndex = LegendIndex_DefaultValue = null;
			Name = Name_DefaultValue = null;
			Stack = Stack_DefaultValue = "null";
			Type = Type_DefaultValue = null;
			XAxis = XAxis_DefaultValue = "";
			YAxis = YAxis_DefaultValue = "";
			ZIndex = ZIndex_DefaultValue = null;
			Spline = Spline_DefaultValue = null;
			Scatter3d = Scatter3d_DefaultValue = null;
			Arearange = Arearange_DefaultValue = null;
			Areasplinerange = Areasplinerange_DefaultValue = null;
			Boxplot = Boxplot_DefaultValue = null;
			Bubble = Bubble_DefaultValue = null;
			Columnrange = Columnrange_DefaultValue = null;
			Errorbar = Errorbar_DefaultValue = null;
			Gauge = Gauge_DefaultValue = null;
			Polygon = Polygon_DefaultValue = null;
			Waterfall = Waterfall_DefaultValue = null;
			Heatmap = Heatmap_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// A `bellcurve` series. If the [type](#series.bellcurve.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.bellcurve](#plotOptions.bellcurve).
		/// </summary>
		public SeriesBellcurve Bellcurve { get; set; }
		private SeriesBellcurve Bellcurve_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `bullet` series. If the [type](#series.bullet.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.bullet](#plotOptions.bullet).
		/// </summary>
		public SeriesBullet Bullet { get; set; }
		private SeriesBullet Bullet_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `line` series. If the [type](#series.line.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.line](#plotOptions.line).
		/// </summary>
		public SeriesLine Line { get; set; }
		private SeriesLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `funnel` series. If the [type](#series.funnel.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.funnel](#plotOptions.funnel).
		/// </summary>
		public SeriesFunnel Funnel { get; set; }
		private SeriesFunnel Funnel_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `pyramid` series. If the [type](#series.pyramid.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.pyramid](#plotOptions.pyramid).
		/// </summary>
		public SeriesPyramid Pyramid { get; set; }
		private SeriesPyramid Pyramid_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `histogram` series. If the [type](#series.histogram.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.histogram](#plotOptions.histogram).
		/// </summary>
		public SeriesHistogram Histogram { get; set; }
		private SeriesHistogram Histogram_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `pareto` series. If the [type](#series.pareto.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.pareto](#plotOptions.pareto).
		/// </summary>
		public SeriesPareto Pareto { get; set; }
		private SeriesPareto Pareto_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `sankey` series. If the [type](#series.sankey.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.sankey](#plotOptions.sankey).
		/// </summary>
		public SeriesSankey Sankey { get; set; }
		private SeriesSankey Sankey_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `solidgauge` series. If the [type](#series.solidgauge.type) optionis not specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.solidgauge](#plotOptions.solidgauge).
		/// </summary>
		public SeriesSolidgauge Solidgauge { get; set; }
		private SeriesSolidgauge Solidgauge_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `streamgraph` series. If the [type](#series.streamgraph.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.streamgraph](#plotOptions.streamgraph).
		/// </summary>
		public SeriesStreamgraph Streamgraph { get; set; }
		private SeriesStreamgraph Streamgraph_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `sunburst` series. If the [type](#series.sunburst.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.sunburst](#plotOptions.sunburst).
		/// </summary>
		public SeriesSunburst Sunburst { get; set; }
		private SeriesSunburst Sunburst_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `treemap` series. If the [type](#series.treemap.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.treemap](#plotOptions.treemap).
		/// </summary>
		public SeriesTreemap Treemap { get; set; }
		private SeriesTreemap Treemap_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `tilemap` series. If the [type](#series.tilemap.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.tilemap](#plotOptions.tilemap).
		/// </summary>
		public SeriesTilemap Tilemap { get; set; }
		private SeriesTilemap Tilemap_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `variablepie` series. If the [type](#series.variablepie.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.variablepie](#plotOptions.variablepie).
		/// </summary>
		public SeriesVariablepie Variablepie { get; set; }
		private SeriesVariablepie Variablepie_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `variwide` series. If the [type](#series.variwide.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.variwide](#plotOptions.variwide).
		/// </summary>
		public SeriesVariwide Variwide { get; set; }
		private SeriesVariwide Variwide_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `vector` series. If the [type](#series.vector.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.vector](#plotOptions.vector).
		/// </summary>
		public SeriesVector Vector { get; set; }
		private SeriesVector Vector_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `windbarb` series. If the [type](#series.windbarb.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.windbarb](#plotOptions.windbarb).
		/// </summary>
		public SeriesWindbarb Windbarb { get; set; }
		private SeriesWindbarb Windbarb_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `wordcloud` series. If the [type](#series.wordcloud.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.wordcloud](#plotOptions.wordcloud).
		/// </summary>
		public SeriesWordcloud Wordcloud { get; set; }
		private SeriesWordcloud Wordcloud_DefaultValue { get; set; }
		 

		/// <summary>
		/// An `xrange` series. If the [type](#series.xrange.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.xrange](#plotOptions.xrange).
		/// </summary>
		public SeriesXrange Xrange { get; set; }
		private SeriesXrange Xrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `area` series. If the [type](#series.area.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.area](#plotOptions.area).
		/// </summary>
		public SeriesArea Area { get; set; }
		private SeriesArea Area_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `areaspline` series. If the [type](#series.areaspline.type) optionis not specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.areaspline](#plotOptions.areaspline).
		/// </summary>
		public SeriesAreaspline Areaspline { get; set; }
		private SeriesAreaspline Areaspline_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `bar` series. If the [type](#series.bar.type) option is not specified,it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.bar](#plotOptions.bar).
		/// </summary>
		public SeriesBar Bar { get; set; }
		private SeriesBar Bar_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `column` series. If the [type](#series.column.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.column](#plotOptions.column).
		/// </summary>
		public SeriesColumn Column { get; set; }
		private SeriesColumn Column_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `pie` series. If the [type](#series.pie.type) option is not specified,it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.pie](#plotOptions.pie).
		/// </summary>
		public SeriesPie Pie { get; set; }
		private SeriesPie Pie_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `scatter` series. If the [type](#series.scatter.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.scatter](#plotOptions.scatter).
		/// </summary>
		public SeriesScatter Scatter { get; set; }
		private SeriesScatter Scatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the series. This can be used after render time to get apointer to the series object through `chart.get()`.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// The index of the series in the chart, affecting the internal indexin the `chart.series` array, the visible Z index as well as the orderin the legend.
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// The sequential index of the series in the legend.
		/// </summary>
		public double? LegendIndex { get; set; }
		private double? LegendIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the series as shown in the legend, tooltip etc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option allows grouping series in a stacked chart. The stackoption can be a string or a number or anything else, as long as thegrouped series' stack options match each other.
		/// </summary>
		public string Stack { get; set; }
		private string Stack_DefaultValue { get; set; }
		 

		/// <summary>
		/// The type of series, for example `line` or `column`.
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple x axes, this number defines which xAxisthe particular series is connected to. It refers to either the [axisid](#xAxis.id) or the index of the axis in the xAxis array, with0 being the first.
		/// </summary>
		public string XAxis { get; set; }
		private string XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple y axes, this number defines which yAxisthe particular series is connected to. It refers to either the [axisid](#yAxis.id) or the index of the axis in the yAxis array, with0 being the first.
		/// </summary>
		public string YAxis { get; set; }
		private string YAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// Define the visual z index of the series.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `spline` series. If the [type](#series.spline.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.spline](#plotOptions.spline).
		/// </summary>
		public SeriesSpline Spline { get; set; }
		private SeriesSpline Spline_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `scatter3d` series. If the [type](#series.scatter3d.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.scatter3d](#plotOptions.scatter3d).
		/// </summary>
		public SeriesScatter3d Scatter3d { get; set; }
		private SeriesScatter3d Scatter3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `arearange` series. If the [type](#series.arearange.type) optionis not specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.arearange](#plotOptions.arearange).
		/// </summary>
		public SeriesArearange Arearange { get; set; }
		private SeriesArearange Arearange_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `areasplinerange` series. If the [type](#series.areasplinerange.type) option is not specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.areasplinerange](#plotOptions.areasplinerange).
		/// </summary>
		public SeriesAreasplinerange Areasplinerange { get; set; }
		private SeriesAreasplinerange Areasplinerange_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `boxplot` series. If the [type](#series.boxplot.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.boxplot](#plotOptions.boxplot).
		/// </summary>
		public SeriesBoxplot Boxplot { get; set; }
		private SeriesBoxplot Boxplot_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `bubble` series. If the [type](#series.bubble.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.bubble](#plotOptions.bubble).
		/// </summary>
		public SeriesBubble Bubble { get; set; }
		private SeriesBubble Bubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `columnrange` series. If the [type](#series.columnrange.type)option is not specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.columnrange](#plotOptions.columnrange).
		/// </summary>
		public SeriesColumnrange Columnrange { get; set; }
		private SeriesColumnrange Columnrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `errorbar` series. If the [type](#series.errorbar.type) optionis not specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.errorbar](#plotOptions.errorbar).
		/// </summary>
		public SeriesErrorbar Errorbar { get; set; }
		private SeriesErrorbar Errorbar_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `gauge` series. If the [type](#series.gauge.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.gauge](#plotOptions.gauge).
		/// </summary>
		public SeriesGauge Gauge { get; set; }
		private SeriesGauge Gauge_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `polygon` series. If the [type](#series.polygon.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.polygon](#plotOptions.polygon).
		/// </summary>
		public SeriesPolygon Polygon { get; set; }
		private SeriesPolygon Polygon_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `waterfall` series. If the [type](#series.waterfall.type) optionis not specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.waterfall](#plotOptions.waterfall).
		/// </summary>
		public SeriesWaterfall Waterfall { get; set; }
		private SeriesWaterfall Waterfall_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `heatmap` series. If the [type](#series.heatmap.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.heatmap](#plotOptions.heatmap).
		/// </summary>
		public SeriesHeatmap Heatmap { get; set; }
		private SeriesHeatmap Heatmap_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Bellcurve.IsDirty()) h.Add("bellcurve",Bellcurve.ToHashtable());
			if (Bullet.IsDirty()) h.Add("bullet",Bullet.ToHashtable());
			if (Line.IsDirty()) h.Add("line",Line.ToHashtable());
			if (Funnel.IsDirty()) h.Add("funnel",Funnel.ToHashtable());
			if (Pyramid.IsDirty()) h.Add("pyramid",Pyramid.ToHashtable());
			if (Histogram.IsDirty()) h.Add("histogram",Histogram.ToHashtable());
			if (Pareto.IsDirty()) h.Add("pareto",Pareto.ToHashtable());
			if (Sankey.IsDirty()) h.Add("sankey",Sankey.ToHashtable());
			if (Solidgauge.IsDirty()) h.Add("solidgauge",Solidgauge.ToHashtable());
			if (Streamgraph.IsDirty()) h.Add("streamgraph",Streamgraph.ToHashtable());
			if (Sunburst.IsDirty()) h.Add("sunburst",Sunburst.ToHashtable());
			if (Treemap.IsDirty()) h.Add("treemap",Treemap.ToHashtable());
			if (Tilemap.IsDirty()) h.Add("tilemap",Tilemap.ToHashtable());
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
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Stack != Stack_DefaultValue) h.Add("stack",Stack);
			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
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
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
	public partial class Series  : Series
	{
		public Series()
		{
			Bellcurve = Bellcurve_DefaultValue = "";
			Bullet = Bullet_DefaultValue = "";
			Line = Line_DefaultValue = "";
			Funnel = Funnel_DefaultValue = "";
			Pyramid = Pyramid_DefaultValue = "";
			Histogram = Histogram_DefaultValue = "";
			Pareto = Pareto_DefaultValue = "";
			Sankey = Sankey_DefaultValue = "";
			Solidgauge = Solidgauge_DefaultValue = "";
			Streamgraph = Streamgraph_DefaultValue = "";
			Sunburst = Sunburst_DefaultValue = "";
			Treemap = Treemap_DefaultValue = "";
			Tilemap = Tilemap_DefaultValue = "";
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
			Id = Id_DefaultValue = "";
			Index = Index_DefaultValue = null;
			LegendIndex = LegendIndex_DefaultValue = null;
			Name = Name_DefaultValue = "";
			Stack = Stack_DefaultValue = "null";
			Type = Type_DefaultValue = "";
			XAxis = XAxis_DefaultValue = "";
			YAxis = YAxis_DefaultValue = "";
			ZIndex = ZIndex_DefaultValue = null;
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
		/// A `bellcurve` series. If the [type](#series.bellcurve.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.bellcurve](#plotOptions.bellcurve).
		/// </summary>
		public BellcurveSeries Bellcurve { get; set; }
		private BellcurveSeries Bellcurve_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `bullet` series. If the [type](#series.bullet.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.bullet](#plotOptions.bullet).
		/// </summary>
		public BulletSeries Bullet { get; set; }
		private BulletSeries Bullet_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `line` series. If the [type](#series.line.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.line](#plotOptions.line).
		/// </summary>
		public LineSeries Line { get; set; }
		private LineSeries Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `funnel` series. If the [type](#series.funnel.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.funnel](#plotOptions.funnel).
		/// </summary>
		public FunnelSeries Funnel { get; set; }
		private FunnelSeries Funnel_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `pyramid` series. If the [type](#series.pyramid.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.pyramid](#plotOptions.pyramid).
		/// </summary>
		public PyramidSeries Pyramid { get; set; }
		private PyramidSeries Pyramid_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `histogram` series. If the [type](#series.histogram.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.histogram](#plotOptions.histogram).
		/// </summary>
		public HistogramSeries Histogram { get; set; }
		private HistogramSeries Histogram_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `pareto` series. If the [type](#series.pareto.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.pareto](#plotOptions.pareto).
		/// </summary>
		public ParetoSeries Pareto { get; set; }
		private ParetoSeries Pareto_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `sankey` series. If the [type](#series.sankey.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.sankey](#plotOptions.sankey).
		/// </summary>
		public SankeySeries Sankey { get; set; }
		private SankeySeries Sankey_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `solidgauge` series. If the [type](#series.solidgauge.type) optionis not specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.solidgauge](#plotOptions.solidgauge).
		/// </summary>
		public SolidgaugeSeries Solidgauge { get; set; }
		private SolidgaugeSeries Solidgauge_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `streamgraph` series. If the [type](#series.streamgraph.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.streamgraph](#plotOptions.streamgraph).
		/// </summary>
		public StreamgraphSeries Streamgraph { get; set; }
		private StreamgraphSeries Streamgraph_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `sunburst` series. If the [type](#series.sunburst.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.sunburst](#plotOptions.sunburst).
		/// </summary>
		public SunburstSeries Sunburst { get; set; }
		private SunburstSeries Sunburst_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `treemap` series. If the [type](#series.treemap.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.treemap](#plotOptions.treemap).
		/// </summary>
		public TreemapSeries Treemap { get; set; }
		private TreemapSeries Treemap_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `tilemap` series. If the [type](#series.tilemap.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.tilemap](#plotOptions.tilemap).
		/// </summary>
		public TilemapSeries Tilemap { get; set; }
		private TilemapSeries Tilemap_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `variablepie` series. If the [type](#series.variablepie.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.variablepie](#plotOptions.variablepie).
		/// </summary>
		public VariablepieSeries Variablepie { get; set; }
		private VariablepieSeries Variablepie_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `variwide` series. If the [type](#series.variwide.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.variwide](#plotOptions.variwide).
		/// </summary>
		public VariwideSeries Variwide { get; set; }
		private VariwideSeries Variwide_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `vector` series. If the [type](#series.vector.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.vector](#plotOptions.vector).
		/// </summary>
		public VectorSeries Vector { get; set; }
		private VectorSeries Vector_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `windbarb` series. If the [type](#series.windbarb.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.windbarb](#plotOptions.windbarb).
		/// </summary>
		public WindbarbSeries Windbarb { get; set; }
		private WindbarbSeries Windbarb_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `wordcloud` series. If the [type](#series.wordcloud.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.wordcloud](#plotOptions.wordcloud).
		/// </summary>
		public WordcloudSeries Wordcloud { get; set; }
		private WordcloudSeries Wordcloud_DefaultValue { get; set; }
		 

		/// <summary>
		/// An `xrange` series. If the [type](#series.xrange.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.xrange](#plotOptions.xrange).
		/// </summary>
		public XrangeSeries Xrange { get; set; }
		private XrangeSeries Xrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `area` series. If the [type](#series.area.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.area](#plotOptions.area).
		/// </summary>
		public AreaSeries Area { get; set; }
		private AreaSeries Area_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `areaspline` series. If the [type](#series.areaspline.type) optionis not specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.areaspline](#plotOptions.areaspline).
		/// </summary>
		public AreasplineSeries Areaspline { get; set; }
		private AreasplineSeries Areaspline_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `bar` series. If the [type](#series.bar.type) option is not specified,it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.bar](#plotOptions.bar).
		/// </summary>
		public BarSeries Bar { get; set; }
		private BarSeries Bar_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `column` series. If the [type](#series.column.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.column](#plotOptions.column).
		/// </summary>
		public ColumnSeries Column { get; set; }
		private ColumnSeries Column_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `pie` series. If the [type](#series.pie.type) option is not specified,it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.pie](#plotOptions.pie).
		/// </summary>
		public PieSeries Pie { get; set; }
		private PieSeries Pie_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `scatter` series. If the [type](#series.scatter.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.scatter](#plotOptions.scatter).
		/// </summary>
		public ScatterSeries Scatter { get; set; }
		private ScatterSeries Scatter_DefaultValue { get; set; }
		 

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
		public SplineSeries Spline { get; set; }
		private SplineSeries Spline_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `scatter3d` series. If the [type](#series.scatter3d.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.scatter3d](#plotOptions.scatter3d).
		/// </summary>
		public Scatter3dSeries Scatter3d { get; set; }
		private Scatter3dSeries Scatter3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `arearange` series. If the [type](#series.arearange.type) optionis not specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.arearange](#plotOptions.arearange).
		/// </summary>
		public ArearangeSeries Arearange { get; set; }
		private ArearangeSeries Arearange_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `areasplinerange` series. If the [type](#series.areasplinerange.type) option is not specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.areasplinerange](#plotOptions.areasplinerange).
		/// </summary>
		public AreasplinerangeSeries Areasplinerange { get; set; }
		private AreasplinerangeSeries Areasplinerange_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `boxplot` series. If the [type](#series.boxplot.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.boxplot](#plotOptions.boxplot).
		/// </summary>
		public BoxplotSeries Boxplot { get; set; }
		private BoxplotSeries Boxplot_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `bubble` series. If the [type](#series.bubble.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.bubble](#plotOptions.bubble).
		/// </summary>
		public BubbleSeries Bubble { get; set; }
		private BubbleSeries Bubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `columnrange` series. If the [type](#series.columnrange.type)option is not specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.columnrange](#plotOptions.columnrange).
		/// </summary>
		public ColumnrangeSeries Columnrange { get; set; }
		private ColumnrangeSeries Columnrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `errorbar` series. If the [type](#series.errorbar.type) optionis not specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.errorbar](#plotOptions.errorbar).
		/// </summary>
		public ErrorbarSeries Errorbar { get; set; }
		private ErrorbarSeries Errorbar_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `gauge` series. If the [type](#series.gauge.type) option is notspecified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.gauge](#plotOptions.gauge).
		/// </summary>
		public GaugeSeries Gauge { get; set; }
		private GaugeSeries Gauge_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `polygon` series. If the [type](#series.polygon.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.polygon](#plotOptions.polygon).
		/// </summary>
		public PolygonSeries Polygon { get; set; }
		private PolygonSeries Polygon_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `waterfall` series. If the [type](#series.waterfall.type) optionis not specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.waterfall](#plotOptions.waterfall).
		/// </summary>
		public WaterfallSeries Waterfall { get; set; }
		private WaterfallSeries Waterfall_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `heatmap` series. If the [type](#series.heatmap.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.heatmap](#plotOptions.heatmap).
		/// </summary>
		public HeatmapSeries Heatmap { get; set; }
		private HeatmapSeries Heatmap_DefaultValue { get; set; }
		  

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
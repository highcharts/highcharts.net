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
	public partial class SeriesTreemap  : BaseObject
	{
		public SeriesTreemap()
		{
			Data = Data_DefaultValue = new List<SeriesTreemapData>();
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
			BoostThreshold = BoostThreshold_DefaultValue = 5000;
			Label = Label_DefaultValue = null;
			LineWidth = LineWidth_DefaultValue = 2;
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Events = Events_DefaultValue = null;
			Point = Point_DefaultValue = null;
			CropThreshold = CropThreshold_DefaultValue = 300;
			SoftThreshold = SoftThreshold_DefaultValue = true;
			States = States_DefaultValue = null;
			StickyTracking = StickyTracking_DefaultValue = True;
			TurboThreshold = TurboThreshold_DefaultValue = 1000;
			FindNearestPointBy = FindNearestPointBy_DefaultValue = "x";
			AnimationLimit = AnimationLimit_DefaultValue = null;
			ClassName = ClassName_DefaultValue = null;
			Color = Color_DefaultValue = null;
			ColorIndex = ColorIndex_DefaultValue = null;
			ConnectNulls = ConnectNulls_DefaultValue = false;
			Cursor = Cursor_DefaultValue = null;
			DashStyle = DashStyle_DefaultValue = "Solid";
			Description = Description_DefaultValue = "undefined";
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			ExposeElementToA11y = ExposeElementToA11y_DefaultValue = null;
			GetExtremesFromAll = GetExtremesFromAll_DefaultValue = false;
			Keys = Keys_DefaultValue = new List<string>();
			Linecap = Linecap_DefaultValue = "round";
			LinkedTo = LinkedTo_DefaultValue = null;
			NegativeColor = NegativeColor_DefaultValue = "null";
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			PointInterval = PointInterval_DefaultValue = 1;
			PointIntervalUnit = PointIntervalUnit_DefaultValue = null;
			PointPlacement = PointPlacement_DefaultValue = "new PointPlacement()";
			PointStart = PointStart_DefaultValue = 0;
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShowInLegend = ShowInLegend_DefaultValue = true;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			Stacking = Stacking_DefaultValue = "null";
			Step = Step_DefaultValue = null;
			Threshold = Threshold_DefaultValue = 0;
			Visible = Visible_DefaultValue = true;
			ZoneAxis = ZoneAxis_DefaultValue = "y";
			Tooltip = Tooltip_DefaultValue = null;
			Zones = Zones_DefaultValue = null;
			ConnectEnds = ConnectEnds_DefaultValue = null;
			BorderWidth = BorderWidth_DefaultValue = 1;
			Linecap = Linecap_DefaultValue = "round";
			LineWidth = LineWidth_DefaultValue = 0;
			FindNearestPointBy = FindNearestPointBy_DefaultValue = xy;
			StickyTracking = StickyTracking_DefaultValue = false;
			ShowInLegend = ShowInLegend_DefaultValue = false;
			Tooltip = Tooltip_DefaultValue = null;
			IgnoreHiddenPoint = IgnoreHiddenPoint_DefaultValue = true;
			LayoutAlgorithm = LayoutAlgorithm_DefaultValue = "sliceAndDice";
			LayoutStartingDirection = LayoutStartingDirection_DefaultValue = "vertical";
			AlternateStartingDirection = AlternateStartingDirection_DefaultValue = false;
			LevelIsConstant = LevelIsConstant_DefaultValue = true;
			DrillUpButton = DrillUpButton_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = "#e6e6e6";
			BorderWidth = BorderWidth_DefaultValue = 1;
			Opacity = Opacity_DefaultValue = 0.15;
			States = States_DefaultValue = null;
			AllowDrillToNode = AllowDrillToNode_DefaultValue = false;
			CropThreshold = CropThreshold_DefaultValue = 300;
			InteractByLeaf = InteractByLeaf_DefaultValue = null;
			SortIndex = SortIndex_DefaultValue = null;
			Levels = Levels_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `treemap` seriestype, points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `value` options. Example: ```js data: [0, 5, 3, 5] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.treemap.turboThreshold),this option is not available. ```js    data: [{        value: 9,        name: "Point2",        color: "#00FF00"    }, {        value: 6,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesTreemapData> Data { get; set; }
		private List<SeriesTreemapData> Data_DefaultValue { get; set; }
		 

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
		 

		/// <summary>
		/// Set the point threshold for when a series should enter boost mode.Setting it to e.g. 2000 will cause the series to enter boost mode when thereare 2000 or more points in the series.To disable boosting on the series, set the `boostThreshold` to 0. Setting itto 1 will force boosting.Requires `modules/boost.js`.
		/// </summary>
		public double? BoostThreshold { get; set; }
		private double? BoostThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.The series labels currently work with series types having a`graph` or an `area`.Requires the `series-label.js` module.
		/// </summary>
		public PlotOptionsSeriesLabel Label { get; set; }
		private PlotOptionsSeriesLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel with of the graph line.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow this series' points to be selected by clicking on the graphic (columns, point markers, pie slices, map areas etc).
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allowselecting the series. The state of the checkbox is determined bythe `selected` option.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		private bool? ShowCheckbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods. Thefollowing properties are supported:<dl><dt>duration</dt><dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>A string reference to an easing function set on the `Math` object.See the _Custom easing function_ demo below.</dd></dl>Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// General event handlers for the series items. These event hooks can alsobe attached to the series at run time using the `Highcharts.addEvent`function.
		/// </summary>
		public PlotOptionsSeriesEvents Events { get; set; }
		private PlotOptionsSeriesEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public PlotOptionsSeriesPoint Point { get; set; }
		private PlotOptionsSeriesPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the series contains less points than the crop threshold, allpoints are drawn, even if the points fall outside the visible plotarea at the current zoom. The advantage of drawing all points (includingmarkers and columns), is that animation is performed on updates.On the other hand, when the series contains more points than thecrop threshold, the series data is cropped to only contain pointsthat fall within the plot area. The advantage of cropping away invisiblepoints is to increase performance on large series.
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this is true, the series will not cause the Y axis to crossthe zero plane (or [threshold](#plotOptions.series.threshold) option)unless the data actually crosses the plane.For example, if `softThreshold` is `false`, a series of 0, 1, 2,3 will make the Y axis show negative values according to the `minPadding`option. If `softThreshold` is `true`, the Y axis starts at 0.
		/// </summary>
		public bool? SoftThreshold { get; set; }
		private bool? SoftThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsSeriesStates States { get; set; }
		private PlotOptionsSeriesStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` eventon a series isn't triggered until the mouse moves over another series,or out of the plot area. When false, the `mouseOut` event on aseries is triggered when the mouse leaves the area around the series'graph or markers. This also implies the tooltip when not shared. When`stickyTracking` is false and `tooltip.shared` is false, the tooltip willbe hidden when moving the mouse between series. Defaults to true for lineand area type series, but to false for columns, pies etc.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains a data array that is longer than this, onlyone dimensional arrays of numbers, or two dimensional arrays withx and y values are allowed. Also, only the first point is tested,and the rest are assumed to be the same format. This saves expensivedata checking and indexing in long series. Set it to `0` disable.
		/// </summary>
		public double? TurboThreshold { get; set; }
		private double? TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Determines whether the series should look for the nearest pointin both dimensions or just the x-dimension when hovering the series.Defaults to `'xy'` for scatter series and `'x'` for most otherseries. If the data has duplicate x-values, it is recommended toset this to `'xy'` to allow hovering over all points.Applies only to series types using nearest neighbor search (notdirect hover) for tooltip.
		/// </summary>
		public string FindNearestPointBy { get; set; }
		private string FindNearestPointBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// For some series, there is a limit that shuts down initial animationby default when the total number of points in the chart is too high.For example, for a column chart and its derivatives, animation doesn'trun if there is more than 250 points totally. To disable this cap, set`animationLimit` to `Infinity`.
		/// </summary>
		public double? AnimationLimit { get; set; }
		private double? AnimationLimit_DefaultValue { get; set; }
		 

		/// <summary>
		/// A class name to apply to the series' graphical elements.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color of the series. In line type series it applies to theline and the point markers unless otherwise specified. In bar typeseries it applies to the bars unless a color is specified per point.The default value is pulled from the `options.colors` array.In styled mode, the color can be defined by the[colorIndex](#plotOptions.series.colorIndex) option. Also, the seriescolor can be set with the `.highcharts-series`, `.highcharts-color-{n}`,`.highcharts-{type}-series` or `.highcharts-series-{n}` class, orindividual classes given by the `className` option.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styled mode only. A specific color index to use for the series, so itsgraphic representations are given the class name `highcharts-color-{n}`.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to connect a graph line across null points, or render a gapbetween the two points on either side of the null.
		/// </summary>
		public bool? ConnectNulls { get; set; }
		private bool? ConnectNulls_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.
		/// </summary>
		public string Cursor { get; set; }
		private string Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A name for the dash style to use for the graph, or for some series typesthe outline of each shape. The value for the `dashStyle` include:*   Solid*   ShortDash*   ShortDot*   ShortDashDot*   ShortDashDotDot*   Dot*   Dash*   LongDash*   DashDot*   LongDashDot*   LongDashDotDot
		/// </summary>
		public string DashStyle { get; set; }
		private string DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Requires the Accessibility module.A description of the series to add to the screen reader informationabout the series.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// By default, series are exposed to screen readers as regions. By enablingthis option, the series element itself will be exposed in the sameway as the data points. This is useful if the series is not usedas a grouping entity in the chart, but you still want to attach adescription to the series.Requires the Accessibility module.
		/// </summary>
		public bool? ExposeElementToA11y { get; set; }
		private bool? ExposeElementToA11y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to use the Y extremes of the total chart width or only thezoomed area when zooming in on parts of the X axis. By default, theY axis adjusts to the min and max of the visible data. Cartesianseries only.
		/// </summary>
		public bool? GetExtremesFromAll { get; set; }
		private bool? GetExtremesFromAll_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line cap used for line ends and line joins on the graph.
		/// </summary>
		public string Linecap { get; set; }
		private string Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [id](#series.id) of another series to link to. Additionally,the value can be ":previous" to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color for the parts of the graph or points that are below the[threshold](#plotOptions.series.threshold).
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Same as [accessibility.pointDescriptionFormatter](#accessibility.pointDescriptionFormatter), but for an individual series. Overridesthe chart wide configuration.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// If no x values are given for the points in a series, `pointInterval`defines the interval of the x values. For example, if a series containsone value every decade starting from year 0, set `pointInterval` to`10`. In true `datetime` axes, the `pointInterval` is set inmilliseconds.It can be also be combined with `pointIntervalUnit` to draw irregulartime intervals.
		/// </summary>
		public double? PointInterval { get; set; }
		private double? PointInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// On datetime series, this allows for setting the[pointInterval](#plotOptions.series.pointInterval) to irregular time units, `day`, `month` and `year`. A day is usually the same as 24 hours,but `pointIntervalUnit` also takes the DST crossover into considerationwhen dealing with local time. Combine this option with `pointInterval`to draw weeks, quarters, 6 months, 10 years etc.
		/// </summary>
		public string PointIntervalUnit { get; set; }
		private string PointIntervalUnit_DefaultValue { get; set; }
		 

		/// <summary>
		/// Possible values: `null`, `"on"`, `"between"`.In a column chart, when pointPlacement is `"on"`, the point willnot create any padding of the X axis. In a polar column chart thismeans that the first column points directly north. If the pointPlacementis `"between"`, the columns will be laid out between ticks. Thisis useful for example for visualising an amount between two pointsin time or in a certain sector of a polar chart.Since Highcharts 3.0.2, the point placement can also be numeric,where 0 is on the axis value, -0.5 is between this value and theprevious, and 0.5 is between this value and the next. Unlike thetextual options, numeric point placement options won't affect axispadding.Note that pointPlacement needs a [pointRange](#plotOptions.series.pointRange) to work. For column series this is computed, but forline-type series it needs to be set.Defaults to `null` in cartesian charts, `"between"` in polar charts.
		/// </summary>
		public PointPlacement PointPlacement { get; set; }
		private PointPlacement PointPlacement_DefaultValue { get; set; }
		 

		/// <summary>
		/// If no x values are given for the points in a series, pointStart defineson what value to start. For example, if a series contains one yearlyvalue starting from 1945, set pointStart to 1945.
		/// </summary>
		public double? PointStart { get; set; }
		private double? PointStart_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If `showCheckbox` is true,the checkbox next to the series name in the legend will be checked for aselected series.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 the shadowcan be an object configuration containing `color`, `offsetX`, `offsetY`, `opacity` and `width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in the legend.The default value is `true` for standalone series, `false` for linkedseries.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// If set to `True`, the accessibility module will skip past the pointsin this series for keyboard navigation.
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		private bool? SkipKeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to stack the values of each series on top of each other.Possible values are `null` to disable, `"normal"` to stack by value or`"percent"`. When stacking is enabled, data must be sorted in ascendingX order. A special stacking option is with the streamgraph series type,where the stacking option is set to `"stream"`.
		/// </summary>
		public string Stacking { get; set; }
		private string Stacking_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply steps to the line. Possible values are `left`, `center`and `right`.
		/// </summary>
		public string Step { get; set; }
		private string Step_DefaultValue { get; set; }
		 

		/// <summary>
		/// The threshold, also called zero level or base level. For line typeseries this is only used in conjunction with[negativeColor](#plotOptions.series.negativeColor).
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the Axis on which the zones are applied.
		/// </summary>
		public string ZoneAxis { get; set; }
		private string ZoneAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object for the tooltip rendering of each single series.Properties are inherited from [tooltip](#tooltip), but only thefollowing properties can be defined on a series level.
		/// </summary>
		public PlotOptionsSeriesTooltip Tooltip { get; set; }
		private PlotOptionsSeriesTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining zones within a series. Zones can be applied tothe X axis, Y axis or Z axis for bubbles, according to the `zoneAxis`option.In styled mode, the color zones are styled with the `.highcharts-zone-{n}` class, or custom classed from the `className` option ([viewlive demo](http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/color-zones/)).
		/// </summary>
		public List<PlotOptionsSeriesZone> Zones { get; set; }
		private List<PlotOptionsSeriesZone> Zones_DefaultValue { get; set; }
		 

		/// <summary>
		/// Polar charts only. Whether to connect the ends of a line series plotacross the extremes.
		/// </summary>
		public bool? ConnectEnds { get; set; }
		private bool? ConnectEnds_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width of each map area.In styled mode, the border stroke width is given in the `.highcharts-point` class.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The SVG value used for the `stroke-linecap` and `stroke-linejoin`of a line graph. Round means that lines are rounded in the ends andbends.
		/// </summary>
		public string Linecap { get; set; }
		private string Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the line connecting the data points.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsScatterFindNearestPointBy FindNearestPointBy { get; set; }
		private PlotOptionsScatterFindNearestPointBy FindNearestPointBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` eventon a series isn't triggered until the mouse moves over another series,or out of the plot area. When false, the `mouseOut` event on a seriesis triggered when the mouse leaves the area around the series' graphor markers. This also implies the tooltip. When `stickyTracking`is false and `tooltip.shared` is false, the tooltip will be hiddenwhen moving the mouse between series.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this series type or specific series item in thelegend.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapTooltip Tooltip { get; set; }
		private PlotOptionsTreemapTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to ignore hidden points when the layout algorithm runs.If `false`, hidden points will leave open spaces.
		/// </summary>
		public bool? IgnoreHiddenPoint { get; set; }
		private bool? IgnoreHiddenPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option decides which algorithm is used for setting positionand dimensions of the points. Can be one of `sliceAndDice`, `stripes`, `squarified` or `strip`.
		/// </summary>
		public string LayoutAlgorithm { get; set; }
		private string LayoutAlgorithm_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines which direction the layout algorithm will start drawing. Possible values are "vertical" and "horizontal".
		/// </summary>
		public string LayoutStartingDirection { get; set; }
		private string LayoutStartingDirection_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enabling this option will make the treemap alternate the drawingdirection between vertical and horizontal. The next levels startingdirection will always be the opposite of the previous.
		/// </summary>
		public bool? AlternateStartingDirection { get; set; }
		private bool? AlternateStartingDirection_DefaultValue { get; set; }
		 

		/// <summary>
		/// Used together with the levels and allowDrillToNode options. Whenset to false the first level visible when drilling is consideredto be level one. Otherwise the level will be the same as the treestructure.
		/// </summary>
		public bool? LevelIsConstant { get; set; }
		private bool? LevelIsConstant_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the button appearing when drilling down in a treemap.
		/// </summary>
		public PlotOptionsTreemapDrillUpButton DrillUpButton { get; set; }
		private PlotOptionsTreemapDrillUpButton DrillUpButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each tree map item.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the border surrounding each tree map item.
		/// </summary>
		public PlotOptionsTreemapBorderWidth BorderWidth { get; set; }
		private PlotOptionsTreemapBorderWidth BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opacity of a point in treemap. When a point has children, thevisibility of the children is determined by the opacity.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsTreemapStates States { get; set; }
		private PlotOptionsTreemapStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// When enabled the user can click on a point which is a parent andzoom in on its children.
		/// </summary>
		public bool? AllowDrillToNode { get; set; }
		private bool? AllowDrillToNode_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the series contains less points than the crop threshold, allpoints are drawn, event if the points fall outside the visible plotarea at the current zoom. The advantage of drawing all points (includingmarkers and columns), is that animation is performed on updates.On the other hand, when the series contains more points than thecrop threshold, the series data is cropped to only contain pointsthat fall within the plot area. The advantage of cropping away invisiblepoints is to increase performance on large series.
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option decides if the user can interact with the parent nodesor just the leaf nodes. When this option is undefined, it will betrue by default. However when allowDrillToNode is true, then it willbe false by default.
		/// </summary>
		public bool? InteractByLeaf { get; set; }
		private bool? InteractByLeaf_DefaultValue { get; set; }
		 

		/// <summary>
		/// The sort index of the point inside the treemap level.
		/// </summary>
		public double? SortIndex { get; set; }
		private double? SortIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set options on specific levels. Takes precedence over series options,but not point options.
		/// </summary>
		public List<object> Levels { get; set; }
		private List<object> Levels_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Data.Any()) h.Add("data",HashifyList(Data));
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
			if (BoostThreshold != BoostThreshold_DefaultValue) h.Add("boostThreshold",BoostThreshold);
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (SoftThreshold != SoftThreshold_DefaultValue) h.Add("softThreshold",SoftThreshold);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (FindNearestPointBy != FindNearestPointBy_DefaultValue) h.Add("findNearestPointBy",FindNearestPointBy);
			if (AnimationLimit != AnimationLimit_DefaultValue) h.Add("animationLimit",AnimationLimit);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (ConnectNulls != ConnectNulls_DefaultValue) h.Add("connectNulls",ConnectNulls);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle",DashStyle);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (ExposeElementToA11y != ExposeElementToA11y_DefaultValue) h.Add("exposeElementToA11y",ExposeElementToA11y);
			if (GetExtremesFromAll != GetExtremesFromAll_DefaultValue) h.Add("getExtremesFromAll",GetExtremesFromAll);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (Linecap != Linecap_DefaultValue) h.Add("linecap",Linecap);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) h.Add("pointDescriptionFormatter",PointDescriptionFormatter);
			if (PointInterval != PointInterval_DefaultValue) h.Add("pointInterval",PointInterval);
			if (PointIntervalUnit != PointIntervalUnit_DefaultValue) h.Add("pointIntervalUnit",PointIntervalUnit);
			if (PointPlacement.IsDirty())
				if (PointPlacement.Value.HasValue)
					h.Add("pointPlacement", PointPlacement.Value);
				else
					h.Add("pointPlacement", PointPlacement.ToJSON());
			if (PointStart != PointStart_DefaultValue) h.Add("pointStart",PointStart);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Stacking != Stacking_DefaultValue) h.Add("stacking",Stacking);
			if (Step != Step_DefaultValue) h.Add("step",Step);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (Tooltip != Tooltip_DefaultValue) h.Add("tooltip",Tooltip);
			if (Zones != Zones_DefaultValue) h.Add("zones", HashifyList(Zones));
			if (ConnectEnds != ConnectEnds_DefaultValue) h.Add("connectEnds",ConnectEnds);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Linecap != Linecap_DefaultValue) h.Add("linecap",Linecap);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (FindNearestPointBy != FindNearestPointBy_DefaultValue) h.Add("findNearestPointBy",FindNearestPointBy);
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (IgnoreHiddenPoint != IgnoreHiddenPoint_DefaultValue) h.Add("ignoreHiddenPoint",IgnoreHiddenPoint);
			if (LayoutAlgorithm != LayoutAlgorithm_DefaultValue) h.Add("layoutAlgorithm",LayoutAlgorithm);
			if (LayoutStartingDirection != LayoutStartingDirection_DefaultValue) h.Add("layoutStartingDirection",LayoutStartingDirection);
			if (AlternateStartingDirection != AlternateStartingDirection_DefaultValue) h.Add("alternateStartingDirection",AlternateStartingDirection);
			if (LevelIsConstant != LevelIsConstant_DefaultValue) h.Add("levelIsConstant",LevelIsConstant);
			if (DrillUpButton.IsDirty()) h.Add("drillUpButton",DrillUpButton.ToHashtable());
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (AllowDrillToNode != AllowDrillToNode_DefaultValue) h.Add("allowDrillToNode",AllowDrillToNode);
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (InteractByLeaf != InteractByLeaf_DefaultValue) h.Add("interactByLeaf",InteractByLeaf);
			if (SortIndex != SortIndex_DefaultValue) h.Add("sortIndex",SortIndex);
			if (Levels.IsDirty()) h.Add("levels",Levels.ToHashtable());
			

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
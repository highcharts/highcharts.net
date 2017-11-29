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
	public partial class SeriesXrange  : BaseObject
	{
		public SeriesXrange()
		{
			Data = Data_DefaultValue = new List<SeriesXrangeData>();
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
			Label = Label_DefaultValue = null;
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Events = Events_DefaultValue = null;
			Point = Point_DefaultValue = null;
			States = States_DefaultValue = null;
			StickyTracking = StickyTracking_DefaultValue = True;
			TurboThreshold = TurboThreshold_DefaultValue = 1000;
			AnimationLimit = AnimationLimit_DefaultValue = null;
			ClassName = ClassName_DefaultValue = null;
			Color = Color_DefaultValue = null;
			ColorIndex = ColorIndex_DefaultValue = null;
			Cursor = Cursor_DefaultValue = null;
			Description = Description_DefaultValue = "undefined";
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			ExposeElementToA11y = ExposeElementToA11y_DefaultValue = null;
			Keys = Keys_DefaultValue = new List<string>();
			LinkedTo = LinkedTo_DefaultValue = null;
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShowInLegend = ShowInLegend_DefaultValue = true;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			Visible = Visible_DefaultValue = true;
			ZoneAxis = ZoneAxis_DefaultValue = "y";
			Tooltip = Tooltip_DefaultValue = null;
			Zones = Zones_DefaultValue = null;
			BorderWidth = BorderWidth_DefaultValue = 1;
			BorderRadius = BorderRadius_DefaultValue = 0;
			Marker = Marker_DefaultValue = true;
			PointPadding = PointPadding_DefaultValue = 0.1;
			MinPointLength = MinPointLength_DefaultValue = 0;
			States = States_DefaultValue = null;
			StickyTracking = StickyTracking_DefaultValue = False;
			Tooltip = Tooltip_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = "#ffffff";
			BorderWidth = BorderWidth_DefaultValue = 1;
			ColorByPoint = ColorByPoint_DefaultValue = false;
			Colors = Colors_DefaultValue = new List<string>();
			MaxPointWidth = MaxPointWidth_DefaultValue = null;
			PointWidth = PointWidth_DefaultValue = null;
			DataGrouping = DataGrouping_DefaultValue = null;
			GroupZPadding = GroupZPadding_DefaultValue = 1;
			ColorByPoint = ColorByPoint_DefaultValue = True;
			Tooltip = Tooltip_DefaultValue = null;
			BorderRadius = BorderRadius_DefaultValue = 3;
			PartialFill = PartialFill_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesXrangeData>();
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `xrange` series type,points can be given in the following ways:1.  An array of objects with named values. The objects are pointconfiguration objects as seen below. ```js    data: [{        x: Date.UTC(2017, 0, 1),        x2: Date.UTC(2017, 0, 3),        name: "Test",        y: 0,        color: "#00FF00"    }, {        x: Date.UTC(2017, 0, 4),        x2: Date.UTC(2017, 0, 5),        name: "Deploy",        y: 1,        color: "#FF0000"    }] ```
		/// </summary>
		public List<SeriesXrangeData> Data { get; set; }
		private List<SeriesXrangeData> Data_DefaultValue { get; set; }
		 

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
		 

		/// <summary>
		/// Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.The series labels currently work with series types having a`graph` or an `area`.Requires the `series-label.js` module.
		/// </summary>
		public PlotOptionsSeriesLabel Label { get; set; }
		private PlotOptionsSeriesLabel Label_DefaultValue { get; set; }
		 

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
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.
		/// </summary>
		public string Cursor { get; set; }
		private string Cursor_DefaultValue { get; set; }
		 

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
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [id](#series.id) of another series to link to. Additionally,the value can be ":previous" to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// Same as [accessibility.pointDescriptionFormatter](#accessibility.pointDescriptionFormatter), but for an individual series. Overridesthe chart wide configuration.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

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
		/// The border width of each map area.In styled mode, the border stroke width is given in the `.highcharts-point` class.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The corner radius of the border surrounding each column or bar.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to group non-stacked columns or to let them render independentof each other. Non-grouped columns will be laid out individuallyand overlap each other.
		/// </summary>
		public bool? Marker { get; set; }
		private bool? Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding between each column or bar, in x axis units.
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimal height for a column or width for a bar. By default,0 values are not shown. To visualize a 0 (or close to zero) point,set the minimal point length to a pixel value like 3\. In stackedcolumn charts, minPointLength might not be respected for tightlypacked values.
		/// </summary>
		public double? MinPointLength { get; set; }
		private double? MinPointLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsColumnStates States { get; set; }
		private PlotOptionsColumnStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsColumnStickyTracking StickyTracking { get; set; }
		private PlotOptionsColumnStickyTracking StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsColumnTooltip Tooltip { get; set; }
		private PlotOptionsColumnTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each column or bar.In styled mode, the border stroke can be set with the `.highcharts-point`rule.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the border surrounding each column or bar.In styled mode, the stroke width can be set with the `.highcharts-point`rule.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using automatic point colors pulled from the `options.colors`collection, this option determines whether the chart should receiveone color per series or one color per point.
		/// </summary>
		public bool? ColorByPoint { get; set; }
		private bool? ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to apply insteadof the global [colors](#colors) when [colorByPoint](#plotOptions.column.colorByPoint) is true.
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// The maximum allowed pixel width for a column, translated to the heightof a bar in a bar chart. This prevents the columns from becomingtoo wide when there is a small number of points in the chart.
		/// </summary>
		public double? MaxPointWidth { get; set; }
		private double? MaxPointWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pixel value specifying a fixed width for each column or bar. When`null`, the width is calculated from the `pointPadding` and`groupPadding`.
		/// </summary>
		public double? PointWidth { get; set; }
		private double? PointWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsColumnDataGrouping DataGrouping { get; set; }
		private PlotOptionsColumnDataGrouping DataGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// The spacing between columns on the Z Axis in a 3D chart. Requires`highcharts-3d.js`.
		/// </summary>
		public double? GroupZPadding { get; set; }
		private double? GroupZPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// In an X-range series, this option makes all points of the same Y-axiscategory the same color.
		/// </summary>
		public PlotOptionsXrangeColorByPoint ColorByPoint { get; set; }
		private PlotOptionsXrangeColorByPoint ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeTooltip Tooltip { get; set; }
		private PlotOptionsXrangeTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeBorderRadius BorderRadius { get; set; }
		private PlotOptionsXrangeBorderRadius BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// A partial fill for each point, typically used to visualize how much ofa task is performed. The partial fill object can be set either on seriesor point level.
		/// </summary>
		public PlotOptionsXrangePartialFill PartialFill { get; set; }
		private PlotOptionsXrangePartialFill PartialFill_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<SeriesXrangeData> Data { get; set; }
		private List<SeriesXrangeData> Data_DefaultValue { get; set; }
		  

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
			if (Treemap.IsDirty()) h.Add("treemap",Treemap.ToHashtable());
			if (Tilemap.IsDirty()) h.Add("tilemap",Tilemap.ToHashtable());
			if (Variablepie.IsDirty()) h.Add("variablepie",Variablepie.ToHashtable());
			if (Variwide.IsDirty()) h.Add("variwide",Variwide.ToHashtable());
			if (Vector.IsDirty()) h.Add("vector",Vector.ToHashtable());
			if (Windbarb.IsDirty()) h.Add("windbarb",Windbarb.ToHashtable());
			if (Wordcloud.IsDirty()) h.Add("wordcloud",Wordcloud.ToHashtable());
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
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (AnimationLimit != AnimationLimit_DefaultValue) h.Add("animationLimit",AnimationLimit);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (ExposeElementToA11y != ExposeElementToA11y_DefaultValue) h.Add("exposeElementToA11y",ExposeElementToA11y);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) h.Add("pointDescriptionFormatter",PointDescriptionFormatter);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (Tooltip != Tooltip_DefaultValue) h.Add("tooltip",Tooltip);
			if (Zones != Zones_DefaultValue) h.Add("zones", HashifyList(Zones));
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (Marker != Marker_DefaultValue) h.Add("marker",Marker);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (MinPointLength != MinPointLength_DefaultValue) h.Add("minPointLength",MinPointLength);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (MaxPointWidth != MaxPointWidth_DefaultValue) h.Add("maxPointWidth",MaxPointWidth);
			if (PointWidth != PointWidth_DefaultValue) h.Add("pointWidth",PointWidth);
			if (DataGrouping.IsDirty()) h.Add("dataGrouping",DataGrouping.ToHashtable());
			if (GroupZPadding != GroupZPadding_DefaultValue) h.Add("groupZPadding",GroupZPadding);
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (PartialFill.IsDirty()) h.Add("partialFill",PartialFill.ToHashtable());
			if (Data.Any()) h.Add("data",HashifyList(Data));
			

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
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
	public partial class PlotOptionsPyramid3d  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPyramid3d()
		{
			Accessibility = Accessibility_DefaultValue = new PlotOptionsPyramid3dAccessibility();
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation();
			AnimationBool = AnimationBool_DefaultValue = true;
			AnimationLimit = AnimationLimit_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = "#ffffff";
			BorderRadius = BorderRadius_DefaultValue = 3;
			BorderWidth = BorderWidth_DefaultValue = null;
			CenterInCategory = CenterInCategory_DefaultValue = false;
			ClassName = ClassName_DefaultValue = "";
			Clip = Clip_DefaultValue = true;
			Color = Color_DefaultValue = "";
			ColorByPoint = ColorByPoint_DefaultValue = false;
			ColorIndex = ColorIndex_DefaultValue = null;
			ColorKey = ColorKey_DefaultValue = "y";
			Colors = Colors_DefaultValue = new List<string>();
			Crisp = Crisp_DefaultValue = true;
			CropThreshold = CropThreshold_DefaultValue = 300;
			Cursor = Cursor_DefaultValue = PlotOptionsPyramid3dCursor.Null;
			Custom = Custom_DefaultValue = new Hashtable();
			DashStyle = DashStyle_DefaultValue = PlotOptionsPyramid3dDashStyle.Null;
			DataLabels = DataLabels_DefaultValue = new PlotOptionsPyramid3dDataLabels();
			Depth = Depth_DefaultValue = 25;
			Description = Description_DefaultValue = "";
			DragDrop = DragDrop_DefaultValue = new PlotOptionsPyramid3dDragDrop();
			EdgeColor = EdgeColor_DefaultValue = "";
			EdgeWidth = EdgeWidth_DefaultValue = 1;
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			Events = Events_DefaultValue = new PlotOptionsPyramid3dEvents();
			FindNearestPointBy = FindNearestPointBy_DefaultValue = PlotOptionsPyramid3dFindNearestPointBy.X;
			GetExtremesFromAll = GetExtremesFromAll_DefaultValue = false;
			GradientForSides = GradientForSides_DefaultValue = true;
			Grouping = Grouping_DefaultValue = true;
			GroupPadding = GroupPadding_DefaultValue = null;
			GroupZPadding = GroupZPadding_DefaultValue = 1;
			Height = Height_DefaultValue = "100%";
			HeightNumber = HeightNumber_DefaultValue = null;
			IncludeInDataExport = IncludeInDataExport_DefaultValue = null;
			Keys = Keys_DefaultValue = new List<string>();
			Label = Label_DefaultValue = new PlotOptionsPyramid3dLabel();
			LegendSymbol = LegendSymbol_DefaultValue = PlotOptionsPyramid3dLegendSymbol.Rectangle;
			LinkedTo = LinkedTo_DefaultValue = "";
			MaxPointWidth = MaxPointWidth_DefaultValue = null;
			MinPointLength = MinPointLength_DefaultValue = 0;
			NeckHeight = NeckHeight_DefaultValue = 0;
			NeckWidth = NeckWidth_DefaultValue = 0;
			NegativeColor = NegativeColor_DefaultValue = "";
			OnPoint = OnPoint_DefaultValue = new PlotOptionsPyramid3dOnPoint();
			Opacity = Opacity_DefaultValue = 1;
			Point = Point_DefaultValue = new PlotOptionsPyramid3dPoint();
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			PointInterval = PointInterval_DefaultValue = 1;
			PointIntervalUnit = PointIntervalUnit_DefaultValue = PlotOptionsPyramid3dPointIntervalUnit.Null;
			PointPadding = PointPadding_DefaultValue = null;
			PointPlacement = PointPlacement_DefaultValue = new PointPlacement();
			PointRange = PointRange_DefaultValue = 0;
			PointStart = PointStart_DefaultValue = 0;
			PointWidth = PointWidth_DefaultValue = null;
			RelativeXValue = RelativeXValue_DefaultValue = false;
			Reversed = Reversed_DefaultValue = true;
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow();
			ShadowBool = ShadowBool_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			ShowInLegend = ShowInLegend_DefaultValue = null;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			SoftThreshold = SoftThreshold_DefaultValue = true;
			Sonification = Sonification_DefaultValue = new PlotOptionsPyramid3dSonification();
			Stacking = Stacking_DefaultValue = PlotOptionsPyramid3dStacking.Null;
			States = States_DefaultValue = new PlotOptionsPyramid3dStates();
			StickyTracking = StickyTracking_DefaultValue = true;
			Threshold = Threshold_DefaultValue = 0;
			Tooltip = Tooltip_DefaultValue = new PlotOptionsPyramid3dTooltip();
			TurboThreshold = TurboThreshold_DefaultValue = 1000;
			Visible = Visible_DefaultValue = true;
			Width = Width_DefaultValue = "90%";
			WidthNumber = WidthNumber_DefaultValue = null;
			ZoneAxis = ZoneAxis_DefaultValue = "y";
			Zones = Zones_DefaultValue = new List<PlotOptionsPyramid3dZone>();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Accessibility options for a series.
		/// </summary>
		public PlotOptionsPyramid3dAccessibility Accessibility { get; set; }
		private PlotOptionsPyramid3dAccessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow this series' points to be selected by clicking on the graphic(columns, point markers, pie slices, map areas etc).The selected points can be handled by point select and unselectevents, or collectively by the [getSelectedPoints](/class-reference/Highcharts.Chart#getSelectedPoints) function.And alternative way of selecting points is through dragging.
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.- `duration`: The duration of the animation in milliseconds. (Defaults to  `1000`)- `easing`: Can be a string reference to an easing function set on  the `Math` object or a function. See the _Custom easing function_  demo below. (Defaults to `easeInOutSine`)Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.- `duration`: The duration of the animation in milliseconds. (Defaults to  `1000`)- `easing`: Can be a string reference to an easing function set on  the `Math` object or a function. See the _Custom easing function_  demo below. (Defaults to `easeInOutSine`)Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public bool? AnimationBool { get; set; }
		private bool? AnimationBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// For some series, there is a limit that shuts down animationby default when the total number of points in the chart is too high.For example, for a column chart and its derivatives, animation doesnot run if there is more than 250 points totally. To disable thiscap, set `animationLimit` to `Infinity`. This option works if animationis fired on individual points, not on a group of points like e.g. duringthe initial animation.
		/// </summary>
		public double? AnimationLimit { get; set; }
		private double? AnimationLimit_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each column or bar.In styled mode, the border stroke can be set with the`.highcharts-point` rule.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The corner radius of the border surrounding each column or bar. A numbersignifies pixels. A percentage string, like for example `50%`, signifiesa relative size. For columns this is relative to the column width, forpies it is relative to the radius and the inner radius.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the border surrounding each column or bar. Defaults to`1` when there is room for a border, but to `0` when the columns areso dense that a border would cover the next column.In styled mode, the stroke width can be set with the`.highcharts-point` rule.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// When `true`, the columns will center in the category, ignoring nullor missing points. When `false`, space will be reserved for null ormissing points.
		/// </summary>
		public bool? CenterInCategory { get; set; }
		private bool? CenterInCategory_DefaultValue { get; set; }
		 

		/// <summary>
		/// An additional class name to apply to the series' graphical elements.This option does not replace default class names of the graphicalelement. Changes to the series' color will also be reflected in achart's legend and tooltip.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Disable this option to allow series rendering in the whole plottingarea.**Note:** Clipping should be always enabled when[chart.zoomType](#chart.zoomType) is set
		/// </summary>
		public bool? Clip { get; set; }
		private bool? Clip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color of the series. In line type series it applies to theline and the point markers unless otherwise specified. In bar typeseries it applies to the bars unless a color is specified per point.The default value is pulled from the `options.colors` array.In styled mode, the color can be defined by the[colorIndex](#plotOptions.series.colorIndex) option. Also, the seriescolor can be set with the `.highcharts-series`,`.highcharts-color-{n}`, `.highcharts-{type}-series` or`.highcharts-series-{n}` class, or individual classes given by the`className` option.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using automatic point colors pulled from the global[colors](colors) or series-specific[plotOptions.column.colors](series.colors) collections, this optiondetermines whether the chart should receive one color per series orone color per point.In styled mode, the `colors` or `series.colors` arrays are notsupported, and instead this option gives the points individual colorclass names on the form `highcharts-color-{n}`.
		/// </summary>
		public bool? ColorByPoint { get; set; }
		private bool? ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styled mode only. A specific color index to use for the series, so itsgraphic representations are given the class name `highcharts-color-{n}`.Since v11, CSS variables on the form `--highcharts-color-{n}` makechanging the color scheme very convenient.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Determines what data value should be used to calculate point colorif `colorAxis` is used. Requires to set `min` and `max` if somecustom point property is used or if approximation for data groupingis set to `'sum'`.
		/// </summary>
		public string ColorKey { get; set; }
		private string ColorKey_DefaultValue { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to apply insteadof the global [colors](#colors) when [colorByPoint](#plotOptions.column.colorByPoint) is true.
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// When true, each point or column edge is rounded to its nearest pixelin order to render sharp on screen. In some cases, when there are alot of densely packed columns, this leads to visible differencein column widths or distance between columns. In these cases,setting `crisp` to `false` may look better, even though each columnis rendered blurry.
		/// </summary>
		public bool? Crisp { get; set; }
		private bool? Crisp_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the series contains less points than the crop threshold, allpoints are drawn, even if the points fall outside the visible plotarea at the current zoom. The advantage of drawing all points(including markers and columns), is that animation is performed onupdates. On the other hand, when the series contains more points thanthe crop threshold, the series data is cropped to only contain pointsthat fall within the plot area. The advantage of cropping awayinvisible points is to increase performance on large series.
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.In styled mode, the series cursor can be set with the same classesas listed under [series.color](#plotOptions.series.color).
		/// </summary>
		public PlotOptionsPyramid3dCursor Cursor { get; set; }
		private PlotOptionsPyramid3dCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customizedfunctionality. Here you can add additional data for your own eventcallbacks and formatter callbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		private Hashtable Custom_DefaultValue { get; set; }
		 

		/// <summary>
		/// Name of the dash style to use for the graph, or for some series typesthe outline of each shape.In styled mode, the[stroke dash-array](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/series-dashstyle/)can be set with the same classes as listed under[series.color](#plotOptions.series.color).
		/// </summary>
		public PlotOptionsPyramid3dDashStyle DashStyle { get; set; }
		private PlotOptionsPyramid3dDashStyle DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPyramid3dDataLabels DataLabels { get; set; }
		private PlotOptionsPyramid3dDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Depth of the columns in a 3D column chart.
		/// </summary>
		public double? Depth { get; set; }
		private double? Depth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A description of the series to add to the screen reader informationabout the series.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// The draggable-points module allows points to be moved around or modified inthe chart. In addition to the options mentioned under the `dragDrop` APIstructure, the module fires three events,[point.dragStart](plotOptions.series.point.events.dragStart),[point.drag](plotOptions.series.point.events.drag) and[point.drop](plotOptions.series.point.events.drop).
		/// </summary>
		public PlotOptionsPyramid3dDragDrop DragDrop { get; set; }
		private PlotOptionsPyramid3dDragDrop DragDrop_DefaultValue { get; set; }
		 

		/// <summary>
		/// 3D columns only. The color of the edges. Similar to `borderColor`, except itdefaults to the same color as the column.
		/// </summary>
		public string EdgeColor { get; set; }
		private string EdgeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 3D columns only. The width of the colored edges.
		/// </summary>
		public double? EdgeWidth { get; set; }
		private double? EdgeWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// General event handlers for the series items. These event hooks canalso be attached to the series at run time using the`Highcharts.addEvent` function.
		/// </summary>
		public PlotOptionsPyramid3dEvents Events { get; set; }
		private PlotOptionsPyramid3dEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Determines whether the series should look for the nearest pointin both dimensions or just the x-dimension when hovering the series.Defaults to `'xy'` for scatter series and `'x'` for most otherseries. If the data has duplicate x-values, it is recommended toset this to `'xy'` to allow hovering over all points.Applies only to series types using nearest neighbor search (notdirect hover) for tooltip.
		/// </summary>
		public PlotOptionsPyramid3dFindNearestPointBy FindNearestPointBy { get; set; }
		private PlotOptionsPyramid3dFindNearestPointBy FindNearestPointBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to use the Y extremes of the total chart width or only thezoomed area when zooming in on parts of the X axis. By default, theY axis adjusts to the min and max of the visible data. Cartesianseries only.
		/// </summary>
		public bool? GetExtremesFromAll { get; set; }
		private bool? GetExtremesFromAll_DefaultValue { get; set; }
		 

		/// <summary>
		/// By deafult sides fill is set to a gradient through this option beingset to `true`. Set to `false` to get solid color for the sides.
		/// </summary>
		public bool? GradientForSides { get; set; }
		private bool? GradientForSides_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to group non-stacked columns or to let them renderindependent of each other. Non-grouped columns will be laid outindividually and overlap each other.
		/// </summary>
		public bool? Grouping { get; set; }
		private bool? Grouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding between each value groups, in x axis units.
		/// </summary>
		public double? GroupPadding { get; set; }
		private double? GroupPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The spacing between columns on the Z Axis in a 3D chart.
		/// </summary>
		public double? GroupZPadding { get; set; }
		private double? GroupZPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the series. If it is a number it definesthe pixel height, if it is a percentage string it is the percentageof the plot area height.
		/// </summary>
		public string Height { get; set; }
		private string Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the series. If it is a number it definesthe pixel height, if it is a percentage string it is the percentageof the plot area height.
		/// </summary>
		public double? HeightNumber { get; set; }
		private double? HeightNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// When set to `false` will prevent the series data from being included inany form of data export.Since version 6.0.0 until 7.1.0 the option was existing undocumentedas `includeInCSVExport`.
		/// </summary>
		public bool? IncludeInDataExport { get; set; }
		private bool? IncludeInDataExport_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

		/// <summary>
		/// Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.The series labels currently work with series types having a`graph` or an `area`.
		/// </summary>
		public PlotOptionsPyramid3dLabel Label { get; set; }
		private PlotOptionsPyramid3dLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// What type of legend symbol to render for this series. Can be one of`lineMarker` or `rectangle`.
		/// </summary>
		public PlotOptionsPyramid3dLegendSymbol LegendSymbol { get; set; }
		private PlotOptionsPyramid3dLegendSymbol LegendSymbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [id](#series.id) of another series to link to. Additionally,the value can be ":previous" to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.If master series uses data sorting and linked series does not haveits own sorting definition, the linked series will be sorted in thesame order as the master one.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The maximum allowed pixel width for a column, translated to theheight of a bar in a bar chart. This prevents the columns frombecoming too wide when there is a small number of points in thechart.
		/// </summary>
		public double? MaxPointWidth { get; set; }
		private double? MaxPointWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimal height for a column or width for a bar. By default,0 values are not shown. To visualize a 0 (or close to zero) point,set the minimal point length to a pixel value like 3\. In stackedcolumn charts, minPointLength might not be respected for tightlypacked values.
		/// </summary>
		public double? MinPointLength { get; set; }
		private double? MinPointLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? NeckHeight { get; set; }
		private double? NeckHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? NeckWidth { get; set; }
		private double? NeckWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color for the parts of the graph or points that are below the[threshold](#plotOptions.series.threshold). Note that `zones` takesprecedence over the negative color. Using `negativeColor` isequivalent to applying a zone with value of 0.
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the _Series on point_ feature. Only `pie` and `sunburst` seriesare supported at this moment.
		/// </summary>
		public PlotOptionsPyramid3dOnPoint OnPoint { get; set; }
		private PlotOptionsPyramid3dOnPoint OnPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Opacity of a series parts: line, fill (e.g. area) and dataLabels.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public PlotOptionsPyramid3dPoint Point { get; set; }
		private PlotOptionsPyramid3dPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// Same as[accessibility.series.descriptionFormatter](#accessibility.series.descriptionFormatter),but for an individual series. Overrides the chart wide configuration.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// If no x values are given for the points in a series, `pointInterval`defines the interval of the x values. For example, if a seriescontains one value every decade starting from year 0, set`pointInterval` to `10`. In true `datetime` axes, the `pointInterval`is set in milliseconds.It can be also be combined with `pointIntervalUnit` to draw irregulartime intervals.If combined with `relativeXValue`, an x value can be set on eachpoint, and the `pointInterval` is added x times to the `pointStart`setting.Please note that this options applies to the _series data_, not theinterval of the axis ticks, which is independent.
		/// </summary>
		public double? PointInterval { get; set; }
		private double? PointInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// On datetime series, this allows for setting the[pointInterval](#plotOptions.series.pointInterval) to irregular timeunits, `day`, `month` and `year`. A day is usually the same as 24hours, but `pointIntervalUnit` also takes the DST crossover intoconsideration when dealing with local time. Combine this option with`pointInterval` to draw weeks, quarters, 6 months, 10 years etc.Please note that this options applies to the _series data_, not theinterval of the axis ticks, which is independent.
		/// </summary>
		public PlotOptionsPyramid3dPointIntervalUnit PointIntervalUnit { get; set; }
		private PlotOptionsPyramid3dPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding between each column or bar, in x axis units.
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Possible values: `"on"`, `"between"`, `number`.In a column chart, when pointPlacement is `"on"`, the point will notcreate any padding of the X axis. In a polar column chart this meansthat the first column points directly north. If the pointPlacement is`"between"`, the columns will be laid out between ticks. This isuseful for example for visualising an amount between two points intime or in a certain sector of a polar chart.Since Highcharts 3.0.2, the point placement can also be numeric,where 0 is on the axis value, -0.5 is between this value and theprevious, and 0.5 is between this value and the next. Unlike thetextual options, numeric point placement options won't affect axispadding.Note that pointPlacement needs a [pointRange](#plotOptions.series.pointRange) to work. For column series this iscomputed, but for line-type series it needs to be set.For the `xrange` series type and gantt charts, if the Y axis is acategory axis, the `pointPlacement` applies to the Y axis rather thanthe (typically datetime) X axis.Defaults to `undefined` in cartesian charts, `"between"` in polarcharts.
		/// </summary>
		public PointPlacement PointPlacement { get; set; }
		private PointPlacement PointPlacement_DefaultValue { get; set; }
		 

		/// <summary>
		/// The X axis range that each point is valid for. This determines thewidth of the column. On a categorized axis, the range will be 1by default (one category unit). On linear and datetime axes, therange will be computed as the distance between the two closest datapoints.The default `null` means it is computed automatically, but thisoption can be used to override the automatic value.This option is set by default to 1 if data sorting is enabled.
		/// </summary>
		public double? PointRange { get; set; }
		private double? PointRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// If no x values are given for the points in a series, pointStartdefines on what value to start. For example, if a series contains oneyearly value starting from 1945, set pointStart to 1945.If combined with `relativeXValue`, an x value can be set on eachpoint. The x value from the point options is multiplied by`pointInterval` and added to `pointStart` to produce a modified xvalue.
		/// </summary>
		public double? PointStart { get; set; }
		private double? PointStart_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pixel value specifying a fixed width for each column or bar point.When set to `undefined`, the width is calculated from the`pointPadding` and `groupPadding`. The width effects the dimensionthat is not based on the point value. For column series it is thehoizontal length and for bar series it is the vertical length.
		/// </summary>
		public double? PointWidth { get; set; }
		private double? PointWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// When true, X values in the data set are relative to the current`pointStart`, `pointInterval` and `pointIntervalUnit` settings. Thisallows compression of the data for datasets with irregular X values.The real X values are computed on the formula `f(x) = ax + b`, where`a` is the `pointInterval` (optionally with a time unit given by`pointIntervalUnit`), and `b` is the `pointStart`.
		/// </summary>
		public bool? RelativeXValue { get; set; }
		private bool? RelativeXValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// A reversed pyramid3d is funnel3d, but the latter supports neckrelated options: neckHeight and neckWidth
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If `showCheckbox` is true,the checkbox next to the series name in the legend will be checkedfor a selected series.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 theshadow can be an object configuration containing `color`, `offsetX`,`offsetY`, `opacity` and `width`.Note that in some cases, like stacked columns or other dense layouts, theseries may cast shadows on each other. In that case, the`chart.seriesGroupShadow` allows applying a common drop shadow to thewhole series group.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 theshadow can be an object configuration containing `color`, `offsetX`,`offsetY`, `opacity` and `width`.Note that in some cases, like stacked columns or other dense layouts, theseries may cast shadows on each other. In that case, the`chart.seriesGroupShadow` allows applying a common drop shadow to thewhole series group.
		/// </summary>
		public bool? ShadowBool { get; set; }
		private bool? ShadowBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allowselecting the series. The state of the checkbox is determined bythe `selected` option.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		private bool? ShowCheckbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in thelegend. Standalone series are shown in legend by default, and linkedseries are not. Since v7.2.0 it is possible to show series that usecolorAxis by setting this option to `true`.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// If set to `true`, the accessibility module will skip past the pointsin this series for keyboard navigation.
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		private bool? SkipKeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this is true, the series will not cause the Y axis to crossthe zero plane (or [threshold](#plotOptions.series.threshold) option)unless the data actually crosses the plane.For example, if `softThreshold` is `false`, a series of 0, 1, 2,3 will make the Y axis show negative values according to the`minPadding` option. If `softThreshold` is `true`, the Y axis startsat 0.
		/// </summary>
		public bool? SoftThreshold { get; set; }
		private bool? SoftThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sonification/audio chart options for a series.
		/// </summary>
		public PlotOptionsPyramid3dSonification Sonification { get; set; }
		private PlotOptionsPyramid3dSonification Sonification_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to stack the values of each series on top of each other.Possible values are `undefined` to disable, `"normal"` to stack byvalue or `"percent"`.When stacking is enabled, data must be sortedin ascending X order.Some stacking options are related to specific series types. In thestreamgraph series type, the stacking option is set to `"stream"`.The second one is `"overlap"`, which only applies to waterfallseries.
		/// </summary>
		public PlotOptionsPyramid3dStacking Stacking { get; set; }
		private PlotOptionsPyramid3dStacking Stacking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPyramid3dStates States { get; set; }
		private PlotOptionsPyramid3dStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` event on aseries isn't triggered until the mouse moves over another series, orout of the plot area. When false, the `mouseOut` event on a series istriggered when the mouse leaves the area around the series' graph ormarkers. This also implies the tooltip when not shared. When`stickyTracking` is false and `tooltip.shared` is false, the tooltipwill be hidden when moving the mouse between series. Defaults to truefor line and area type series, but to false for columns, pies etc.**Note:** The boost module will force this option because oftechnical limitations.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// The threshold, also called zero level or base level. For line typeseries this is only used in conjunction with[negativeColor](#plotOptions.series.negativeColor).
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object for the tooltip rendering of each singleseries. Properties are inherited from [tooltip](#tooltip), but onlythe following properties can be defined on a series level.
		/// </summary>
		public PlotOptionsPyramid3dTooltip Tooltip { get; set; }
		private PlotOptionsPyramid3dTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains a data array that is longer than this, onlyone dimensional arrays of numbers, or two dimensional arrays withx and y values are allowed. Also, only the first point is tested,and the rest are assumed to be the same format. This saves expensivedata checking and indexing in long series. Set it to `0` disable.Note:In boost mode turbo threshold is forced. Only array of numbers ortwo dimensional arrays are allowed.
		/// </summary>
		public double? TurboThreshold { get; set; }
		private double? TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// The max width of the series compared to the width of the plot area,or the pixel width if it is a number.
		/// </summary>
		public string Width { get; set; }
		private string Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// The max width of the series compared to the width of the plot area,or the pixel width if it is a number.
		/// </summary>
		public double? WidthNumber { get; set; }
		private double? WidthNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the Axis on which the zones are applied.
		/// </summary>
		public string ZoneAxis { get; set; }
		private string ZoneAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining zones within a series. Zones can be applied to theX axis, Y axis or Z axis for bubbles, according to the `zoneAxis`option. The zone definitions have to be in ascending order regardingto the value.In styled mode, the color zones are styled with the`.highcharts-zone-{n}` class, or custom classed from the `className`option([view live demo](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/color-zones/)).
		/// </summary>
		public List<PlotOptionsPyramid3dZone> Zones { get; set; }
		private List<PlotOptionsPyramid3dZone> Zones_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Accessibility.IsDirty(highcharts)) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (Animation.IsDirty(highcharts)) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (AnimationLimit != AnimationLimit_DefaultValue) h.Add("animationLimit",AnimationLimit);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (CenterInCategory != CenterInCategory_DefaultValue) h.Add("centerInCategory",CenterInCategory);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Clip != Clip_DefaultValue) h.Add("clip",Clip);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (ColorKey != ColorKey_DefaultValue) h.Add("colorKey",ColorKey);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (Crisp != Crisp_DefaultValue) h.Add("crisp",Crisp);
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (Custom != Custom_DefaultValue) h.Add("custom",Custom);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", highcharts.FirstCharacterToLower(DashStyle.ToString()));
			if (DataLabels.IsDirty(highcharts)) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (Depth != Depth_DefaultValue) h.Add("depth",Depth);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (DragDrop.IsDirty(highcharts)) h.Add("dragDrop",DragDrop.ToHashtable(highcharts));
			if (EdgeColor != EdgeColor_DefaultValue) h.Add("edgeColor",EdgeColor);
			if (EdgeWidth != EdgeWidth_DefaultValue) h.Add("edgeWidth",EdgeWidth);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events.IsDirty(highcharts)) h.Add("events",Events.ToHashtable(highcharts));
			if (FindNearestPointBy != FindNearestPointBy_DefaultValue) h.Add("findNearestPointBy", highcharts.FirstCharacterToLower(FindNearestPointBy.ToString()));
			if (GetExtremesFromAll != GetExtremesFromAll_DefaultValue) h.Add("getExtremesFromAll",GetExtremesFromAll);
			if (GradientForSides != GradientForSides_DefaultValue) h.Add("gradientForSides",GradientForSides);
			if (Grouping != Grouping_DefaultValue) h.Add("grouping",Grouping);
			if (GroupPadding != GroupPadding_DefaultValue) h.Add("groupPadding",GroupPadding);
			if (GroupZPadding != GroupZPadding_DefaultValue) h.Add("groupZPadding",GroupZPadding);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (HeightNumber != HeightNumber_DefaultValue) h.Add("height",HeightNumber);
			if (IncludeInDataExport != IncludeInDataExport_DefaultValue) h.Add("includeInDataExport",IncludeInDataExport);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (Label.IsDirty(highcharts)) h.Add("label",Label.ToHashtable(highcharts));
			if (LegendSymbol != LegendSymbol_DefaultValue) h.Add("legendSymbol", highcharts.FirstCharacterToLower(LegendSymbol.ToString()));
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (MaxPointWidth != MaxPointWidth_DefaultValue) h.Add("maxPointWidth",MaxPointWidth);
			if (MinPointLength != MinPointLength_DefaultValue) h.Add("minPointLength",MinPointLength);
			if (NeckHeight != NeckHeight_DefaultValue) h.Add("neckHeight",NeckHeight);
			if (NeckWidth != NeckWidth_DefaultValue) h.Add("neckWidth",NeckWidth);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (OnPoint.IsDirty(highcharts)) h.Add("onPoint",OnPoint.ToHashtable(highcharts));
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Point.IsDirty(highcharts)) h.Add("point",Point.ToHashtable(highcharts));
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); highcharts.AddFunction("pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (PointInterval != PointInterval_DefaultValue) h.Add("pointInterval",PointInterval);
			if (PointIntervalUnit != PointIntervalUnit_DefaultValue) h.Add("pointIntervalUnit", highcharts.FirstCharacterToLower(PointIntervalUnit.ToString()));
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (PointPlacement.IsDirty(highcharts))
				if (PointPlacement.Value.HasValue)
					h.Add("pointPlacement", PointPlacement.Value);
				else
					h.Add("pointPlacement", PointPlacement.ToJSON(highcharts));
			if (PointRange != PointRange_DefaultValue) h.Add("pointRange",PointRange);
			if (PointStart != PointStart_DefaultValue) h.Add("pointStart",PointStart);
			if (PointWidth != PointWidth_DefaultValue) h.Add("pointWidth",PointWidth);
			if (RelativeXValue != RelativeXValue_DefaultValue) h.Add("relativeXValue",RelativeXValue);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow.IsDirty(highcharts)) h.Add("shadow",Shadow.ToHashtable(highcharts));
			if (ShadowBool != ShadowBool_DefaultValue) h.Add("shadow",ShadowBool);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (SoftThreshold != SoftThreshold_DefaultValue) h.Add("softThreshold",SoftThreshold);
			if (Sonification.IsDirty(highcharts)) h.Add("sonification",Sonification.ToHashtable(highcharts));
			if (Stacking != Stacking_DefaultValue) h.Add("stacking", highcharts.FirstCharacterToLower(Stacking.ToString()));
			if (States.IsDirty(highcharts)) h.Add("states",States.ToHashtable(highcharts));
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (Tooltip.IsDirty(highcharts)) h.Add("tooltip",Tooltip.ToHashtable(highcharts));
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (WidthNumber != WidthNumber_DefaultValue) h.Add("width",WidthNumber);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (Zones != Zones_DefaultValue) h.Add("zones", HashifyList(highcharts,Zones));
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
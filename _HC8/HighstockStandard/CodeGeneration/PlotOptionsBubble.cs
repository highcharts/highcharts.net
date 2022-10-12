using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptionsBubble  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsBubble()
		{
			Accessibility = Accessibility_DefaultValue = new PlotOptionsBubbleAccessibility();
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			AnimationBool = AnimationBool_DefaultValue = null;
			AnimationLimit = AnimationLimit_DefaultValue = 250;
			BoostBlending = BoostBlending_DefaultValue = PlotOptionsBubbleBoostBlending.Undefined;
			BoostThreshold = BoostThreshold_DefaultValue = 5000;
			ClassName = ClassName_DefaultValue = "";
			Clip = Clip_DefaultValue = true;
			Color = Color_DefaultValue = "";
			ColorAxis = ColorAxis_DefaultValue = "0";
			ColorAxisNumber = ColorAxisNumber_DefaultValue = null;
			ColorAxisBool = ColorAxisBool_DefaultValue = null;
			ColorIndex = ColorIndex_DefaultValue = null;
			ColorKey = ColorKey_DefaultValue = "z";
			Compare = Compare_DefaultValue = PlotOptionsBubbleCompare.Null;
			CompareBase = CompareBase_DefaultValue = PlotOptionsBubbleCompareBase.Min;
			CompareStart = CompareStart_DefaultValue = false;
			ConnectNulls = ConnectNulls_DefaultValue = false;
			Crisp = Crisp_DefaultValue = true;
			Cumulative = Cumulative_DefaultValue = false;
			Cursor = Cursor_DefaultValue = PlotOptionsBubbleCursor.Null;
			Custom = Custom_DefaultValue = new Hashtable();
			DashStyle = DashStyle_DefaultValue = PlotOptionsBubbleDashStyle.Null;
			DataGrouping = DataGrouping_DefaultValue = new PlotOptionsBubbleDataGrouping();
			DataLabels = DataLabels_DefaultValue = new PlotOptionsBubbleDataLabels();
			DataSorting = DataSorting_DefaultValue = new PlotOptionsBubbleDataSorting();
			Description = Description_DefaultValue = "";
			DisplayNegative = DisplayNegative_DefaultValue = true;
			DragDrop = DragDrop_DefaultValue = new PlotOptionsBubbleDragDrop();
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			Events = Events_DefaultValue = new PlotOptionsBubbleEvents();
			FindNearestPointBy = FindNearestPointBy_DefaultValue = PlotOptionsBubbleFindNearestPointBy.X;
			GapSize = GapSize_DefaultValue = 0;
			GapUnit = GapUnit_DefaultValue = PlotOptionsBubbleGapUnit.Relative;
			GetExtremesFromAll = GetExtremesFromAll_DefaultValue = false;
			IncludeInDataExport = IncludeInDataExport_DefaultValue = null;
			Jitter = Jitter_DefaultValue = new PlotOptionsBubbleJitter();
			Keys = Keys_DefaultValue = new List<string>();
			Label = Label_DefaultValue = new PlotOptionsBubbleLabel();
			LastPrice = LastPrice_DefaultValue = new PlotOptionsBubbleLastPrice();
			LastVisiblePrice = LastVisiblePrice_DefaultValue = new PlotOptionsBubbleLastVisiblePrice();
			Linecap = Linecap_DefaultValue = PlotOptionsBubbleLinecap.Round;
			LineWidth = LineWidth_DefaultValue = 2;
			LinkedTo = LinkedTo_DefaultValue = "";
			Marker = Marker_DefaultValue = new PlotOptionsBubbleMarker();
			MaxSize = MaxSize_DefaultValue = "20%";
			MaxSizeNumber = MaxSizeNumber_DefaultValue = null;
			MinSize = MinSize_DefaultValue = "8";
			MinSizeNumber = MinSizeNumber_DefaultValue = null;
			NegativeColor = NegativeColor_DefaultValue = "";
			OnPoint = OnPoint_DefaultValue = new PlotOptionsBubbleOnPoint();
			Opacity = Opacity_DefaultValue = 1;
			Point = Point_DefaultValue = new PlotOptionsBubblePoint();
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			PointInterval = PointInterval_DefaultValue = 1;
			PointIntervalUnit = PointIntervalUnit_DefaultValue = PlotOptionsBubblePointIntervalUnit.Null;
			PointRange = PointRange_DefaultValue = 0;
			PointStart = PointStart_DefaultValue = 0;
			RelativeXValue = RelativeXValue_DefaultValue = false;
			Selected = Selected_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			ShowInLegend = ShowInLegend_DefaultValue = null;
			ShowInNavigator = ShowInNavigator_DefaultValue = null;
			SizeBy = SizeBy_DefaultValue = "area";
			SizeByAbsoluteValue = SizeByAbsoluteValue_DefaultValue = false;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			SoftThreshold = SoftThreshold_DefaultValue = false;
			Stacking = Stacking_DefaultValue = PlotOptionsBubbleStacking.Null;
			States = States_DefaultValue = new PlotOptionsBubbleStates();
			Step = Step_DefaultValue = PlotOptionsBubbleStep.Null;
			StickyTracking = StickyTracking_DefaultValue = true;
			Threshold = Threshold_DefaultValue = 0;
			Tooltip = Tooltip_DefaultValue = new PlotOptionsBubbleTooltip();
			TurboThreshold = TurboThreshold_DefaultValue = 0;
			Visible = Visible_DefaultValue = true;
			ZMax = ZMax_DefaultValue = null;
			ZMin = ZMin_DefaultValue = null;
			ZoneAxis = ZoneAxis_DefaultValue = "z";
			Zones = Zones_DefaultValue = new List<PlotOptionsBubbleZone>();
			ZThreshold = ZThreshold_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// Accessibility options for a series.
		/// </summary>
		public PlotOptionsBubbleAccessibility Accessibility { get; set; }
		private PlotOptionsBubbleAccessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow this series' points to be selected by clicking on the graphic(columns, point markers, pie slices, map areas etc).The selected points can be handled by point select and unselectevents, or collectively by the [getSelectedPoints](/class-reference/Highcharts.Chart#getSelectedPoints) function.And alternative way of selecting points is through dragging.
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.- `duration`: The duration of the animation in milliseconds.- `easing`: Can be a string reference to an easing function set on  the `Math` object or a function. See the _Custom easing function_  demo below.Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.- `duration`: The duration of the animation in milliseconds.- `easing`: Can be a string reference to an easing function set on  the `Math` object or a function. See the _Custom easing function_  demo below.Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public bool? AnimationBool { get; set; }
		private bool? AnimationBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// If there are more points in the series than the `animationLimit`, theanimation won't run. Animation affects overall performance anddoesn't work well with heavy data series.
		/// </summary>
		public double? AnimationLimit { get; set; }
		private double? AnimationLimit_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sets the color blending in the boost module.
		/// </summary>
		public PlotOptionsBubbleBoostBlending BoostBlending { get; set; }
		private PlotOptionsBubbleBoostBlending BoostBlending_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the point threshold for when a series should enter boost mode.Setting it to e.g. 2000 will cause the series to enter boost mode when thereare 2000 or more points in the series.To disable boosting on the series, set the `boostThreshold` to 0. Setting itto 1 will force boosting.Note that the [cropThreshold](plotOptions.series.cropThreshold) also affectsthis setting. When zooming in on a series that has fewer points than the`cropThreshold`, all points are rendered although outside the visible plotarea, and the `boostThreshold` won't take effect.
		/// </summary>
		public double? BoostThreshold { get; set; }
		private double? BoostThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// An additional class name to apply to the series' graphical elements.This option does not replace default class names of the graphicalelement.
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
		/// When using dual or multiple color axes, this number defines whichcolorAxis the particular series is connected to. It refers toeither the{@link #colorAxis.id|axis id}or the index of the axis in the colorAxis array, with 0 being thefirst. Set this option to false to prevent a series from connectingto the default color axis.Since v7.2.0 the option can also be an axis id or an axis indexinstead of a boolean flag.
		/// </summary>
		public string ColorAxis { get; set; }
		private string ColorAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple color axes, this number defines whichcolorAxis the particular series is connected to. It refers toeither the{@link #colorAxis.id|axis id}or the index of the axis in the colorAxis array, with 0 being thefirst. Set this option to false to prevent a series from connectingto the default color axis.Since v7.2.0 the option can also be an axis id or an axis indexinstead of a boolean flag.
		/// </summary>
		public double? ColorAxisNumber { get; set; }
		private double? ColorAxisNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple color axes, this number defines whichcolorAxis the particular series is connected to. It refers toeither the{@link #colorAxis.id|axis id}or the index of the axis in the colorAxis array, with 0 being thefirst. Set this option to false to prevent a series from connectingto the default color axis.Since v7.2.0 the option can also be an axis id or an axis indexinstead of a boolean flag.
		/// </summary>
		public bool? ColorAxisBool { get; set; }
		private bool? ColorAxisBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styled mode only. A specific color index to use for the series, soits graphic representations are given the class name`highcharts-color-{n}`.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ColorKey { get; set; }
		private string ColorKey_DefaultValue { get; set; }
		 

		/// <summary>
		/// Compare the values of the series against the first non-null, non-zero value in the visible range. The y axis will show percentageor absolute change depending on whether `compare` is set to `"percent"`or `"value"`. When this is applied to multiple series, it allowscomparing the development of the series against each other. Addsa `change` field to every point object.
		/// </summary>
		public PlotOptionsBubbleCompare Compare { get; set; }
		private PlotOptionsBubbleCompare Compare_DefaultValue { get; set; }
		 

		/// <summary>
		/// When [compare](#plotOptions.series.compare) is `percent`, this optiondictates whether to use 0 or 100 as the base of comparison.
		/// </summary>
		public PlotOptionsBubbleCompareBase CompareBase { get; set; }
		private PlotOptionsBubbleCompareBase CompareBase_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines if comparison should start from the first point within the visiblerange or should start from the first point **before** the range.In other words, this flag determines if first point within the visible rangewill have 0% (`compareStart=true`) or should have been already calculatedaccording to the previous point (`compareStart=false`).
		/// </summary>
		public bool? CompareStart { get; set; }
		private bool? CompareStart_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to connect a graph line across null points, or render a gapbetween the two points on either side of the null.
		/// </summary>
		public bool? ConnectNulls { get; set; }
		private bool? ConnectNulls_DefaultValue { get; set; }
		 

		/// <summary>
		/// When true, each point or column edge is rounded to its nearest pixelin order to render sharp on screen. In some cases, when there are alot of densely packed columns, this leads to visible differencein column widths or distance between columns. In these cases,setting `crisp` to `false` may look better, even though each columnis rendered blurry.
		/// </summary>
		public bool? Crisp { get; set; }
		private bool? Crisp_DefaultValue { get; set; }
		 

		/// <summary>
		/// Cumulative Sum feature replaces points' values with the following formula:`sum of all previous points' values + current point's value`.Works only for points in a visible range.Adds the `cumulativeSum` field to each point object that can be accessede.g. in the [tooltip.pointFormat](https://api.highcharts.com/highstock/tooltip.pointFormat).
		/// </summary>
		public bool? Cumulative { get; set; }
		private bool? Cumulative_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.In styled mode, the series cursor can be set with the same classesas listed under [series.color](#plotOptions.series.color).
		/// </summary>
		public PlotOptionsBubbleCursor Cursor { get; set; }
		private PlotOptionsBubbleCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customizedfunctionality. Here you can add additional data for your own eventcallbacks and formatter callbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		private Hashtable Custom_DefaultValue { get; set; }
		 

		/// <summary>
		/// Name of the dash style to use for the graph, or for some series typesthe outline of each shape.In styled mode, the[stroke dash-array](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/series-dashstyle/)can be set with the same classes as listed under[series.color](#plotOptions.series.color).
		/// </summary>
		public PlotOptionsBubbleDashStyle DashStyle { get; set; }
		private PlotOptionsBubbleDashStyle DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Data grouping is the concept of sampling the data values into largerblocks in order to ease readability and increase performance of theJavaScript charts. Highcharts Stock by default applies data grouping whenthe points become closer than a certain pixel value, determined bythe `groupPixelWidth` option.If data grouping is applied, the grouping information of groupedpoints can be read from the [Point.dataGroup](/class-reference/Highcharts.Point#dataGroup). If point options other thanthe data itself are set, for example `name` or `color` or custom properties,the grouping logic doesn't know how to group it. In this case the options ofthe first point instance are copied over to the group point. This can bealtered through a custom `approximation` callback function.
		/// </summary>
		public PlotOptionsBubbleDataGrouping DataGrouping { get; set; }
		private PlotOptionsBubbleDataGrouping DataGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleDataLabels DataLabels { get; set; }
		private PlotOptionsBubbleDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the series data sorting.
		/// </summary>
		public PlotOptionsBubbleDataSorting DataSorting { get; set; }
		private PlotOptionsBubbleDataSorting DataSorting_DefaultValue { get; set; }
		 

		/// <summary>
		/// A description of the series to add to the screen reader informationabout the series.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display negative sized bubbles. The threshold is givenby the [zThreshold](#plotOptions.bubble.zThreshold) option, and negativebubbles can be visualized by setting[negativeColor](#plotOptions.bubble.negativeColor).
		/// </summary>
		public bool? DisplayNegative { get; set; }
		private bool? DisplayNegative_DefaultValue { get; set; }
		 

		/// <summary>
		/// The draggable-points module allows points to be moved around or modified inthe chart. In addition to the options mentioned under the `dragDrop` APIstructure, the module fires three events,[point.dragStart](plotOptions.series.point.events.dragStart),[point.drag](plotOptions.series.point.events.drag) and[point.drop](plotOptions.series.point.events.drop).
		/// </summary>
		public PlotOptionsBubbleDragDrop DragDrop { get; set; }
		private PlotOptionsBubbleDragDrop DragDrop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// General event handlers for the series items. These event hooks canalso be attached to the series at run time using the`Highcharts.addEvent` function.
		/// </summary>
		public PlotOptionsBubbleEvents Events { get; set; }
		private PlotOptionsBubbleEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Determines whether the series should look for the nearest pointin both dimensions or just the x-dimension when hovering the series.Defaults to `'xy'` for scatter series and `'x'` for most otherseries. If the data has duplicate x-values, it is recommended toset this to `'xy'` to allow hovering over all points.Applies only to series types using nearest neighbor search (notdirect hover) for tooltip.
		/// </summary>
		public PlotOptionsBubbleFindNearestPointBy FindNearestPointBy { get; set; }
		private PlotOptionsBubbleFindNearestPointBy FindNearestPointBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines when to display a gap in the graph, together with the[gapUnit](plotOptions.series.gapUnit) option.In case when `dataGrouping` is enabled, points can be groupedinto a larger time span. This can make the grouped points tohave a greater distance than the absolute value of `gapSize`property, which will result in disappearing graph completely.To prevent this situation the mentioned distance betweengrouped points is used instead of previously defined`gapSize`.In practice, this option is most often used to visualize gapsin time series. In a stock chart, intraday data is availablefor daytime hours, while gaps will appear in nights andweekends.
		/// </summary>
		public double? GapSize { get; set; }
		private double? GapSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Together with [gapSize](plotOptions.series.gapSize), thisoption defines where to draw gaps in the graph.When the `gapUnit` is `"relative"` (default), a gap size of 5means that if the distance between two points is greater than5 times that of the two closest points, the graph will bebroken.When the `gapUnit` is `"value"`, the gap is based on absoluteaxis values, which on a datetime axis is milliseconds. Thisalso applies to the navigator series that inherits gapoptions from the base series.
		/// </summary>
		public PlotOptionsBubbleGapUnit GapUnit { get; set; }
		private PlotOptionsBubbleGapUnit GapUnit_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to use the Y extremes of the total chart width or only thezoomed area when zooming in on parts of the X axis. By default, theY axis adjusts to the min and max of the visible data. Cartesianseries only.
		/// </summary>
		public bool? GetExtremesFromAll { get; set; }
		private bool? GetExtremesFromAll_DefaultValue { get; set; }
		 

		/// <summary>
		/// When set to `false` will prevent the series data from being included inany form of data export.Since version 6.0.0 until 7.1.0 the option was existing undocumentedas `includeInCSVExport`.
		/// </summary>
		public bool? IncludeInDataExport { get; set; }
		private bool? IncludeInDataExport_DefaultValue { get; set; }
		 

		/// <summary>
		/// Apply a jitter effect for the rendered markers. When plottingdiscrete values, a little random noise may help telling the pointsapart. The jitter setting applies a random displacement of up to `n`axis units in either direction. So for example on a horizontal Xaxis, setting the `jitter.x` to 0.24 will render the point in arandom position between 0.24 units to the left and 0.24 units to theright of the true axis position. On a category axis, setting it to0.5 will fill up the bin and make the data appear continuous.When rendered on top of a box plot or a column series, a jitter valueof 0.24 will correspond to the underlying series' default[groupPadding](https://api.highcharts.com/highcharts/plotOptions.column.groupPadding)and [pointPadding](https://api.highcharts.com/highcharts/plotOptions.column.pointPadding)settings.
		/// </summary>
		public PlotOptionsBubbleJitter Jitter { get; set; }
		private PlotOptionsBubbleJitter Jitter_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

		/// <summary>
		/// Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.The series labels currently work with series types having a`graph` or an `area`.
		/// </summary>
		public PlotOptionsBubbleLabel Label { get; set; }
		private PlotOptionsBubbleLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line marks the last price from all points.
		/// </summary>
		public PlotOptionsBubbleLastPrice LastPrice { get; set; }
		private PlotOptionsBubbleLastPrice LastPrice_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line marks the last price from visible range of points.
		/// </summary>
		public PlotOptionsBubbleLastVisiblePrice LastVisiblePrice { get; set; }
		private PlotOptionsBubbleLastVisiblePrice LastVisiblePrice_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line cap used for line ends and line joins on the graph.
		/// </summary>
		public PlotOptionsBubbleLinecap Linecap { get; set; }
		private PlotOptionsBubbleLinecap Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel width of the graph line.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [id](#series.id) of another series to link to. Additionally,the value can be ":previous" to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.If master series uses data sorting and linked series does not haveits own sorting definition, the linked series will be sorted in thesame order as the master one.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleMarker Marker { get; set; }
		private PlotOptionsBubbleMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// Maximum bubble size. Bubbles will automatically size between the`minSize` and `maxSize` to reflect the `z` value of each bubble.Can be either pixels (when no unit is given), or a percentage ofthe smallest one of the plot width and height.
		/// </summary>
		public string MaxSize { get; set; }
		private string MaxSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Maximum bubble size. Bubbles will automatically size between the`minSize` and `maxSize` to reflect the `z` value of each bubble.Can be either pixels (when no unit is given), or a percentage ofthe smallest one of the plot width and height.
		/// </summary>
		public double? MaxSizeNumber { get; set; }
		private double? MaxSizeNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Minimum bubble size. Bubbles will automatically size between the`minSize` and `maxSize` to reflect the `z` value of each bubble.Can be either pixels (when no unit is given), or a percentage ofthe smallest one of the plot width and height.
		/// </summary>
		public string MinSize { get; set; }
		private string MinSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Minimum bubble size. Bubbles will automatically size between the`minSize` and `maxSize` to reflect the `z` value of each bubble.Can be either pixels (when no unit is given), or a percentage ofthe smallest one of the plot width and height.
		/// </summary>
		public double? MinSizeNumber { get; set; }
		private double? MinSizeNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a point's Z value is below the[zThreshold](#plotOptions.bubble.zThreshold)setting, this color is used.
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the `Series on point` feature. Only `pie` and `sunburst` seriesare supported at this moment.
		/// </summary>
		public PlotOptionsBubbleOnPoint OnPoint { get; set; }
		private PlotOptionsBubbleOnPoint OnPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Opacity of a series parts: line, fill (e.g. area) and dataLabels.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public PlotOptionsBubblePoint Point { get; set; }
		private PlotOptionsBubblePoint Point_DefaultValue { get; set; }
		 

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
		public PlotOptionsBubblePointIntervalUnit PointIntervalUnit { get; set; }
		private PlotOptionsBubblePointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of each point on the x axis. For example in a column chartwith one value each day, the pointRange would be 1 day (= 24 * 3600* 1000 milliseconds). This is normally computed automatically, butthis option can be used to override the automatic value.
		/// </summary>
		public double? PointRange { get; set; }
		private double? PointRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// If no x values are given for the points in a series, pointStartdefines on what value to start. For example, if a series contains oneyearly value starting from 1945, set pointStart to 1945.If combined with `relativeXValue`, an x value can be set on eachpoint. The x value from the point options is multiplied by`pointInterval` and added to `pointStart` to produce a modified xvalue.
		/// </summary>
		public double? PointStart { get; set; }
		private double? PointStart_DefaultValue { get; set; }
		 

		/// <summary>
		/// When true, X values in the data set are relative to the current`pointStart`, `pointInterval` and `pointIntervalUnit` settings. Thisallows compression of the data for datasets with irregular X values.The real X values are computed on the formula `f(x) = ax + b`, where`a` is the `pointInterval` (optionally with a time unit given by`pointIntervalUnit`), and `b` is the `pointStart`.
		/// </summary>
		public bool? RelativeXValue { get; set; }
		private bool? RelativeXValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If `showCheckbox` is true,the checkbox next to the series name in the legend will be checkedfor a selected series.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

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
		/// Whether or not to show the series in the navigator. Takes precedenceover [navigator.baseSeries](#navigator.baseSeries) if defined.
		/// </summary>
		public bool? ShowInNavigator { get; set; }
		private bool? ShowInNavigator_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the bubble's value should be represented by the area or thewidth of the bubble. The default, `area`, corresponds best to thehuman perception of the size of each bubble.
		/// </summary>
		public string SizeBy { get; set; }
		private string SizeBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this is true, the absolute value of z determines the size ofthe bubble. This means that with the default `zThreshold` of 0, abubble of value -1 will have the same size as a bubble of value 1,while a bubble of value 0 will have a smaller size according to`minSize`.
		/// </summary>
		public bool? SizeByAbsoluteValue { get; set; }
		private bool? SizeByAbsoluteValue_DefaultValue { get; set; }
		 

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
		/// Whether to stack the values of each series on top of each other.Possible values are `undefined` to disable, `"normal"` to stack byvalue or `"percent"`.When stacking is enabled, data must be sortedin ascending X order.Some stacking options are related to specific series types. In thestreamgraph series type, the stacking option is set to `"stream"`.The second one is `"overlap"`, which only applies to waterfallseries.
		/// </summary>
		public PlotOptionsBubbleStacking Stacking { get; set; }
		private PlotOptionsBubbleStacking Stacking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleStates States { get; set; }
		private PlotOptionsBubbleStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply steps to the line. Possible values are `left`,`center` and `right`.
		/// </summary>
		public PlotOptionsBubbleStep Step { get; set; }
		private PlotOptionsBubbleStep Step_DefaultValue { get; set; }
		 

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
		/// 
		/// </summary>
		public PlotOptionsBubbleTooltip Tooltip { get; set; }
		private PlotOptionsBubbleTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? TurboThreshold { get; set; }
		private double? TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum for the Z value range. Defaults to the highest Z valuein the data.
		/// </summary>
		public double? ZMax { get; set; }
		private double? ZMax_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum for the Z value range. Defaults to the lowest Z valuein the data.
		/// </summary>
		public double? ZMin { get; set; }
		private double? ZMin_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ZoneAxis { get; set; }
		private string ZoneAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining zones within a series. Zones can be applied to theX axis, Y axis or Z axis for bubbles, according to the `zoneAxis`option. The zone definitions have to be in ascending order regardingto the value.In styled mode, the color zones are styled with the`.highcharts-zone-{n}` class, or custom classed from the `className`option([view live demo](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/color-zones/)).
		/// </summary>
		public List<PlotOptionsBubbleZone> Zones { get; set; }
		private List<PlotOptionsBubbleZone> Zones_DefaultValue { get; set; }
		 

		/// <summary>
		/// When [displayNegative](#plotOptions.bubble.displayNegative) is `false`,bubbles with lower Z values are skipped. When `displayNegative`is `true` and a [negativeColor](#plotOptions.bubble.negativeColor)is given, points with lower Z is colored.
		/// </summary>
		public double? ZThreshold { get; set; }
		private double? ZThreshold_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Accessibility.IsDirty(ref highstock)) h.Add("accessibility",Accessibility.ToHashtable(ref highstock));
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (Animation.IsDirty(ref highstock)) h.Add("animation",Animation.ToJSON(ref highstock));
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (AnimationLimit != AnimationLimit_DefaultValue) h.Add("animationLimit",AnimationLimit);
			if (BoostBlending != BoostBlending_DefaultValue) h.Add("boostBlending", highstock.FirstCharacterToLower(BoostBlending.ToString()));
			if (BoostThreshold != BoostThreshold_DefaultValue) h.Add("boostThreshold",BoostThreshold);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Clip != Clip_DefaultValue) h.Add("clip",Clip);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorAxis != ColorAxis_DefaultValue) h.Add("colorAxis",ColorAxis);
			if (ColorAxisNumber != ColorAxisNumber_DefaultValue) h.Add("colorAxis",ColorAxisNumber);
			if (ColorAxisBool != ColorAxisBool_DefaultValue) h.Add("colorAxis",ColorAxisBool);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (ColorKey != ColorKey_DefaultValue) h.Add("colorKey",ColorKey);
			if (Compare != Compare_DefaultValue) h.Add("compare", highstock.FirstCharacterToLower(Compare.ToString()));
			if (CompareBase != CompareBase_DefaultValue) h.Add("compareBase", highstock.FirstCharacterToLower(CompareBase.ToString()));
			if (CompareStart != CompareStart_DefaultValue) h.Add("compareStart",CompareStart);
			if (ConnectNulls != ConnectNulls_DefaultValue) h.Add("connectNulls",ConnectNulls);
			if (Crisp != Crisp_DefaultValue) h.Add("crisp",Crisp);
			if (Cumulative != Cumulative_DefaultValue) h.Add("cumulative",Cumulative);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", highstock.FirstCharacterToLower(Cursor.ToString()));
			if (Custom != Custom_DefaultValue) h.Add("custom",Custom);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", highstock.FirstCharacterToLower(DashStyle.ToString()));
			if (DataGrouping.IsDirty(ref highstock)) h.Add("dataGrouping",DataGrouping.ToHashtable(ref highstock));
			if (DataLabels.IsDirty(ref highstock)) h.Add("dataLabels",DataLabels.ToHashtable(ref highstock));
			if (DataSorting.IsDirty(ref highstock)) h.Add("dataSorting",DataSorting.ToHashtable(ref highstock));
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (DisplayNegative != DisplayNegative_DefaultValue) h.Add("displayNegative",DisplayNegative);
			if (DragDrop.IsDirty(ref highstock)) h.Add("dragDrop",DragDrop.ToHashtable(ref highstock));
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events.IsDirty(ref highstock)) h.Add("events",Events.ToHashtable(ref highstock));
			if (FindNearestPointBy != FindNearestPointBy_DefaultValue) h.Add("findNearestPointBy", highstock.FirstCharacterToLower(FindNearestPointBy.ToString()));
			if (GapSize != GapSize_DefaultValue) h.Add("gapSize",GapSize);
			if (GapUnit != GapUnit_DefaultValue) h.Add("gapUnit", highstock.FirstCharacterToLower(GapUnit.ToString()));
			if (GetExtremesFromAll != GetExtremesFromAll_DefaultValue) h.Add("getExtremesFromAll",GetExtremesFromAll);
			if (IncludeInDataExport != IncludeInDataExport_DefaultValue) h.Add("includeInDataExport",IncludeInDataExport);
			if (Jitter.IsDirty(ref highstock)) h.Add("jitter",Jitter.ToHashtable(ref highstock));
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (Label.IsDirty(ref highstock)) h.Add("label",Label.ToHashtable(ref highstock));
			if (LastPrice.IsDirty(ref highstock)) h.Add("lastPrice",LastPrice.ToHashtable(ref highstock));
			if (LastVisiblePrice.IsDirty(ref highstock)) h.Add("lastVisiblePrice",LastVisiblePrice.ToHashtable(ref highstock));
			if (Linecap != Linecap_DefaultValue) h.Add("linecap", highstock.FirstCharacterToLower(Linecap.ToString()));
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (Marker.IsDirty(ref highstock)) h.Add("marker",Marker.ToHashtable(ref highstock));
			if (MaxSize != MaxSize_DefaultValue) h.Add("maxSize",MaxSize);
			if (MaxSizeNumber != MaxSizeNumber_DefaultValue) h.Add("maxSize",MaxSizeNumber);
			if (MinSize != MinSize_DefaultValue) h.Add("minSize",MinSize);
			if (MinSizeNumber != MinSizeNumber_DefaultValue) h.Add("minSize",MinSizeNumber);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (OnPoint.IsDirty(ref highstock)) h.Add("onPoint",OnPoint.ToHashtable(ref highstock));
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Point.IsDirty(ref highstock)) h.Add("point",Point.ToHashtable(ref highstock));
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); highstock.AddFunction("pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (PointInterval != PointInterval_DefaultValue) h.Add("pointInterval",PointInterval);
			if (PointIntervalUnit != PointIntervalUnit_DefaultValue) h.Add("pointIntervalUnit", highstock.FirstCharacterToLower(PointIntervalUnit.ToString()));
			if (PointRange != PointRange_DefaultValue) h.Add("pointRange",PointRange);
			if (PointStart != PointStart_DefaultValue) h.Add("pointStart",PointStart);
			if (RelativeXValue != RelativeXValue_DefaultValue) h.Add("relativeXValue",RelativeXValue);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (ShowInNavigator != ShowInNavigator_DefaultValue) h.Add("showInNavigator",ShowInNavigator);
			if (SizeBy != SizeBy_DefaultValue) h.Add("sizeBy",SizeBy);
			if (SizeByAbsoluteValue != SizeByAbsoluteValue_DefaultValue) h.Add("sizeByAbsoluteValue",SizeByAbsoluteValue);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (SoftThreshold != SoftThreshold_DefaultValue) h.Add("softThreshold",SoftThreshold);
			if (Stacking != Stacking_DefaultValue) h.Add("stacking", highstock.FirstCharacterToLower(Stacking.ToString()));
			if (States.IsDirty(ref highstock)) h.Add("states",States.ToHashtable(ref highstock));
			if (Step != Step_DefaultValue) h.Add("step", highstock.FirstCharacterToLower(Step.ToString()));
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (Tooltip.IsDirty(ref highstock)) h.Add("tooltip",Tooltip.ToHashtable(ref highstock));
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (ZMax != ZMax_DefaultValue) h.Add("zMax",ZMax);
			if (ZMin != ZMin_DefaultValue) h.Add("zMin",ZMin);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (Zones != Zones_DefaultValue) h.Add("zones", HashifyList(ref highstock,Zones));
			if (ZThreshold != ZThreshold_DefaultValue) h.Add("zThreshold",ZThreshold);
			

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}
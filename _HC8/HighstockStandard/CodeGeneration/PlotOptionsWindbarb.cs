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
	public partial class PlotOptionsWindbarb  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsWindbarb()
		{
			Accessibility = Accessibility_DefaultValue = new PlotOptionsWindbarbAccessibility();
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			AnimationBool = AnimationBool_DefaultValue = null;
			AnimationLimit = AnimationLimit_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = "#ffffff";
			BorderRadius = BorderRadius_DefaultValue = 0;
			BorderWidth = BorderWidth_DefaultValue = null;
			CenterInCategory = CenterInCategory_DefaultValue = false;
			ClassName = ClassName_DefaultValue = "";
			Clip = Clip_DefaultValue = true;
			Color = Color_DefaultValue = "";
			ColorAxis = ColorAxis_DefaultValue = "0";
			ColorAxisNumber = ColorAxisNumber_DefaultValue = null;
			ColorAxisBool = ColorAxisBool_DefaultValue = null;
			ColorByPoint = ColorByPoint_DefaultValue = false;
			ColorIndex = ColorIndex_DefaultValue = null;
			ColorKey = ColorKey_DefaultValue = "value";
			Colors = Colors_DefaultValue = new List<string>();
			Compare = Compare_DefaultValue = PlotOptionsWindbarbCompare.Null;
			CompareBase = CompareBase_DefaultValue = PlotOptionsWindbarbCompareBase.Min;
			CompareStart = CompareStart_DefaultValue = false;
			Crisp = Crisp_DefaultValue = true;
			Cumulative = Cumulative_DefaultValue = false;
			Cursor = Cursor_DefaultValue = PlotOptionsWindbarbCursor.Null;
			Custom = Custom_DefaultValue = new Hashtable();
			DataGrouping = DataGrouping_DefaultValue = new PlotOptionsWindbarbDataGrouping();
			DataLabels = DataLabels_DefaultValue = new PlotOptionsWindbarbDataLabels();
			DataSorting = DataSorting_DefaultValue = new PlotOptionsWindbarbDataSorting();
			Depth = Depth_DefaultValue = 25;
			Description = Description_DefaultValue = "";
			EdgeColor = EdgeColor_DefaultValue = "";
			EdgeWidth = EdgeWidth_DefaultValue = 1;
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			Events = Events_DefaultValue = new PlotOptionsWindbarbEvents();
			FindNearestPointBy = FindNearestPointBy_DefaultValue = PlotOptionsWindbarbFindNearestPointBy.X;
			GetExtremesFromAll = GetExtremesFromAll_DefaultValue = false;
			Grouping = Grouping_DefaultValue = true;
			GroupPadding = GroupPadding_DefaultValue = null;
			GroupZPadding = GroupZPadding_DefaultValue = 1;
			IncludeInDataExport = IncludeInDataExport_DefaultValue = null;
			Keys = Keys_DefaultValue = new List<string>();
			Label = Label_DefaultValue = new PlotOptionsWindbarbLabel();
			LastPrice = LastPrice_DefaultValue = new PlotOptionsWindbarbLastPrice();
			LastVisiblePrice = LastVisiblePrice_DefaultValue = new PlotOptionsWindbarbLastVisiblePrice();
			LineWidth = LineWidth_DefaultValue = 2;
			LinkedTo = LinkedTo_DefaultValue = "";
			MaxPointWidth = MaxPointWidth_DefaultValue = null;
			MinPointLength = MinPointLength_DefaultValue = 0;
			NegativeColor = NegativeColor_DefaultValue = "";
			OnPoint = OnPoint_DefaultValue = new PlotOptionsWindbarbOnPoint();
			OnSeries = OnSeries_DefaultValue = "";
			Opacity = Opacity_DefaultValue = 1;
			Point = Point_DefaultValue = new PlotOptionsWindbarbPoint();
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			PointInterval = PointInterval_DefaultValue = 1;
			PointIntervalUnit = PointIntervalUnit_DefaultValue = PlotOptionsWindbarbPointIntervalUnit.Null;
			PointPadding = PointPadding_DefaultValue = null;
			PointPlacement = PointPlacement_DefaultValue = new PointPlacement();
			PointRange = PointRange_DefaultValue = 0;
			PointStart = PointStart_DefaultValue = 0;
			PointWidth = PointWidth_DefaultValue = null;
			RelativeXValue = RelativeXValue_DefaultValue = false;
			Selected = Selected_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			ShowInLegend = ShowInLegend_DefaultValue = null;
			ShowInNavigator = ShowInNavigator_DefaultValue = null;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			SoftThreshold = SoftThreshold_DefaultValue = true;
			States = States_DefaultValue = new PlotOptionsWindbarbStates();
			StickyTracking = StickyTracking_DefaultValue = true;
			Threshold = Threshold_DefaultValue = 0;
			Tooltip = Tooltip_DefaultValue = new PlotOptionsWindbarbTooltip();
			TurboThreshold = TurboThreshold_DefaultValue = 1000;
			VectorLength = VectorLength_DefaultValue = 20;
			Visible = Visible_DefaultValue = true;
			XOffset = XOffset_DefaultValue = 0;
			YOffset = YOffset_DefaultValue = -20;
			ZoneAxis = ZoneAxis_DefaultValue = "y";
			Zones = Zones_DefaultValue = new List<PlotOptionsWindbarbZone>();
			
		}	
		

		/// <summary>
		/// Accessibility options for a series.
		/// </summary>
		public PlotOptionsWindbarbAccessibility Accessibility { get; set; }
		private PlotOptionsWindbarbAccessibility Accessibility_DefaultValue { get; set; }
		 

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
		/// For some series, there is a limit that shuts down initial animationby default when the total number of points in the chart is too high.For example, for a column chart and its derivatives, animation doesnot run if there is more than 250 points totally. To disable thiscap, set `animationLimit` to `Infinity`.
		/// </summary>
		public double? AnimationLimit { get; set; }
		private double? AnimationLimit_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each column or bar.In styled mode, the border stroke can be set with the`.highcharts-point` rule.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The corner radius of the border surrounding each column or bar.
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
		/// When using automatic point colors pulled from the global[colors](colors) or series-specific[plotOptions.column.colors](series.colors) collections, this optiondetermines whether the chart should receive one color per series orone color per point.In styled mode, the `colors` or `series.colors` arrays are notsupported, and instead this option gives the points individual colorclass names on the form `highcharts-color-{n}`.
		/// </summary>
		public bool? ColorByPoint { get; set; }
		private bool? ColorByPoint_DefaultValue { get; set; }
		 

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
		/// A series specific or series type specific color set to apply insteadof the global [colors](#colors) when [colorByPoint](#plotOptions.column.colorByPoint) is true.
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// Compare the values of the series against the first non-null, non-zero value in the visible range. The y axis will show percentageor absolute change depending on whether `compare` is set to `"percent"`or `"value"`. When this is applied to multiple series, it allowscomparing the development of the series against each other. Addsa `change` field to every point object.
		/// </summary>
		public PlotOptionsWindbarbCompare Compare { get; set; }
		private PlotOptionsWindbarbCompare Compare_DefaultValue { get; set; }
		 

		/// <summary>
		/// When [compare](#plotOptions.series.compare) is `percent`, this optiondictates whether to use 0 or 100 as the base of comparison.
		/// </summary>
		public PlotOptionsWindbarbCompareBase CompareBase { get; set; }
		private PlotOptionsWindbarbCompareBase CompareBase_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines if comparison should start from the first point within the visiblerange or should start from the first point **before** the range.In other words, this flag determines if first point within the visible rangewill have 0% (`compareStart=true`) or should have been already calculatedaccording to the previous point (`compareStart=false`).
		/// </summary>
		public bool? CompareStart { get; set; }
		private bool? CompareStart_DefaultValue { get; set; }
		 

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
		public PlotOptionsWindbarbCursor Cursor { get; set; }
		private PlotOptionsWindbarbCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customizedfunctionality. Here you can add additional data for your own eventcallbacks and formatter callbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		private Hashtable Custom_DefaultValue { get; set; }
		 

		/// <summary>
		/// Data grouping options for the wind barbs. In Highcharts, thisrequires the `modules/datagrouping.js` module to be loaded. InHighcharts Stock, data grouping is included.
		/// </summary>
		public PlotOptionsWindbarbDataGrouping DataGrouping { get; set; }
		private PlotOptionsWindbarbDataGrouping DataGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the series data labels, appearing next to each datapoint.Since v6.2.0, multiple data labels can be applied to each singlepoint by defining them as an array of configs.In styled mode, the data labels can be styled with the`.highcharts-data-label-box` and `.highcharts-data-label` class names([see example](https://www.highcharts.com/samples/highcharts/css/series-datalabels)).
		/// </summary>
		public PlotOptionsWindbarbDataLabels DataLabels { get; set; }
		private PlotOptionsWindbarbDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the series data sorting.
		/// </summary>
		public PlotOptionsWindbarbDataSorting DataSorting { get; set; }
		private PlotOptionsWindbarbDataSorting DataSorting_DefaultValue { get; set; }
		 

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
		public PlotOptionsWindbarbEvents Events { get; set; }
		private PlotOptionsWindbarbEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Determines whether the series should look for the nearest pointin both dimensions or just the x-dimension when hovering the series.Defaults to `'xy'` for scatter series and `'x'` for most otherseries. If the data has duplicate x-values, it is recommended toset this to `'xy'` to allow hovering over all points.Applies only to series types using nearest neighbor search (notdirect hover) for tooltip.
		/// </summary>
		public PlotOptionsWindbarbFindNearestPointBy FindNearestPointBy { get; set; }
		private PlotOptionsWindbarbFindNearestPointBy FindNearestPointBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to use the Y extremes of the total chart width or only thezoomed area when zooming in on parts of the X axis. By default, theY axis adjusts to the min and max of the visible data. Cartesianseries only.
		/// </summary>
		public bool? GetExtremesFromAll { get; set; }
		private bool? GetExtremesFromAll_DefaultValue { get; set; }
		 

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
		public PlotOptionsWindbarbLabel Label { get; set; }
		private PlotOptionsWindbarbLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line marks the last price from all points.
		/// </summary>
		public PlotOptionsWindbarbLastPrice LastPrice { get; set; }
		private PlotOptionsWindbarbLastPrice LastPrice_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line marks the last price from visible range of points.
		/// </summary>
		public PlotOptionsWindbarbLastVisiblePrice LastVisiblePrice { get; set; }
		private PlotOptionsWindbarbLastVisiblePrice LastVisiblePrice_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line width of the wind barb symbols.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

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
		/// The color for the parts of the graph or points that are below the[threshold](#plotOptions.series.threshold). Note that `zones` takesprecedence over the negative color. Using `negativeColor` isequivalent to applying a zone with value of 0.
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the `Series on point` feature. Only `pie` and `sunburst` seriesare supported at this moment.
		/// </summary>
		public PlotOptionsWindbarbOnPoint OnPoint { get; set; }
		private PlotOptionsWindbarbOnPoint OnPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// The id of another series in the chart that the wind barbs areprojected on. When `null`, the wind symbols are drawn on the X axis,but offset up or down by the `yOffset` setting.
		/// </summary>
		public string OnSeries { get; set; }
		private string OnSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// Opacity of a series parts: line, fill (e.g. area) and dataLabels.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public PlotOptionsWindbarbPoint Point { get; set; }
		private PlotOptionsWindbarbPoint Point_DefaultValue { get; set; }
		 

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
		public PlotOptionsWindbarbPointIntervalUnit PointIntervalUnit { get; set; }
		private PlotOptionsWindbarbPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }
		 

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
		/// 
		/// </summary>
		public PlotOptionsWindbarbStates States { get; set; }
		private PlotOptionsWindbarbStates States_DefaultValue { get; set; }
		 

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
		public PlotOptionsWindbarbTooltip Tooltip { get; set; }
		private PlotOptionsWindbarbTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains a data array that is longer than this, onlyone dimensional arrays of numbers, or two dimensional arrays withx and y values are allowed. Also, only the first point is tested,and the rest are assumed to be the same format. This saves expensivedata checking and indexing in long series. Set it to `0` disable.Note:In boost mode turbo threshold is forced. Only array of numbers ortwo dimensional arrays are allowed.
		/// </summary>
		public double? TurboThreshold { get; set; }
		private double? TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel length of the stems.
		/// </summary>
		public double? VectorLength { get; set; }
		private double? VectorLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal offset from the cartesian position, in pixels. When thechart is inverted, this option allows translation like[yOffset](#plotOptions.windbarb.yOffset) in non inverted charts.
		/// </summary>
		public double? XOffset { get; set; }
		private double? XOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical offset from the cartesian position, in pixels. The defaultvalue makes sure the symbols don't overlap the X axis when `onSeries`is `null`, and that they don't overlap the linked series when`onSeries` is given.
		/// </summary>
		public double? YOffset { get; set; }
		private double? YOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the Axis on which the zones are applied.
		/// </summary>
		public string ZoneAxis { get; set; }
		private string ZoneAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining zones within a series. Zones can be applied to theX axis, Y axis or Z axis for bubbles, according to the `zoneAxis`option. The zone definitions have to be in ascending order regardingto the value.In styled mode, the color zones are styled with the`.highcharts-zone-{n}` class, or custom classed from the `className`option([view live demo](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/color-zones/)).
		/// </summary>
		public List<PlotOptionsWindbarbZone> Zones { get; set; }
		private List<PlotOptionsWindbarbZone> Zones_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Accessibility.IsDirty(ref highstock)) h.Add("accessibility",Accessibility.ToHashtable(ref highstock));
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (Animation.IsDirty(ref highstock)) h.Add("animation",Animation.ToJSON(ref highstock));
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (AnimationLimit != AnimationLimit_DefaultValue) h.Add("animationLimit",AnimationLimit);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (CenterInCategory != CenterInCategory_DefaultValue) h.Add("centerInCategory",CenterInCategory);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Clip != Clip_DefaultValue) h.Add("clip",Clip);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorAxis != ColorAxis_DefaultValue) h.Add("colorAxis",ColorAxis);
			if (ColorAxisNumber != ColorAxisNumber_DefaultValue) h.Add("colorAxis",ColorAxisNumber);
			if (ColorAxisBool != ColorAxisBool_DefaultValue) h.Add("colorAxis",ColorAxisBool);
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (ColorKey != ColorKey_DefaultValue) h.Add("colorKey",ColorKey);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (Compare != Compare_DefaultValue) h.Add("compare", Highstock.FirstCharacterToLower(Compare.ToString()));
			if (CompareBase != CompareBase_DefaultValue) h.Add("compareBase", Highstock.FirstCharacterToLower(CompareBase.ToString()));
			if (CompareStart != CompareStart_DefaultValue) h.Add("compareStart",CompareStart);
			if (Crisp != Crisp_DefaultValue) h.Add("crisp",Crisp);
			if (Cumulative != Cumulative_DefaultValue) h.Add("cumulative",Cumulative);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highstock.FirstCharacterToLower(Cursor.ToString()));
			if (Custom != Custom_DefaultValue) h.Add("custom",Custom);
			if (DataGrouping.IsDirty(ref highstock)) h.Add("dataGrouping",DataGrouping.ToHashtable(ref highstock));
			if (DataLabels.IsDirty(ref highstock)) h.Add("dataLabels",DataLabels.ToHashtable(ref highstock));
			if (DataSorting.IsDirty(ref highstock)) h.Add("dataSorting",DataSorting.ToHashtable(ref highstock));
			if (Depth != Depth_DefaultValue) h.Add("depth",Depth);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EdgeColor != EdgeColor_DefaultValue) h.Add("edgeColor",EdgeColor);
			if (EdgeWidth != EdgeWidth_DefaultValue) h.Add("edgeWidth",EdgeWidth);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events.IsDirty(ref highstock)) h.Add("events",Events.ToHashtable(ref highstock));
			if (FindNearestPointBy != FindNearestPointBy_DefaultValue) h.Add("findNearestPointBy", Highstock.FirstCharacterToLower(FindNearestPointBy.ToString()));
			if (GetExtremesFromAll != GetExtremesFromAll_DefaultValue) h.Add("getExtremesFromAll",GetExtremesFromAll);
			if (Grouping != Grouping_DefaultValue) h.Add("grouping",Grouping);
			if (GroupPadding != GroupPadding_DefaultValue) h.Add("groupPadding",GroupPadding);
			if (GroupZPadding != GroupZPadding_DefaultValue) h.Add("groupZPadding",GroupZPadding);
			if (IncludeInDataExport != IncludeInDataExport_DefaultValue) h.Add("includeInDataExport",IncludeInDataExport);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (Label.IsDirty(ref highstock)) h.Add("label",Label.ToHashtable(ref highstock));
			if (LastPrice.IsDirty(ref highstock)) h.Add("lastPrice",LastPrice.ToHashtable(ref highstock));
			if (LastVisiblePrice.IsDirty(ref highstock)) h.Add("lastVisiblePrice",LastVisiblePrice.ToHashtable(ref highstock));
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (MaxPointWidth != MaxPointWidth_DefaultValue) h.Add("maxPointWidth",MaxPointWidth);
			if (MinPointLength != MinPointLength_DefaultValue) h.Add("minPointLength",MinPointLength);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (OnPoint.IsDirty(ref highstock)) h.Add("onPoint",OnPoint.ToHashtable(ref highstock));
			if (OnSeries != OnSeries_DefaultValue) h.Add("onSeries",OnSeries);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Point.IsDirty(ref highstock)) h.Add("point",Point.ToHashtable(ref highstock));
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); Highstock.AddFunction("pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (PointInterval != PointInterval_DefaultValue) h.Add("pointInterval",PointInterval);
			if (PointIntervalUnit != PointIntervalUnit_DefaultValue) h.Add("pointIntervalUnit", Highstock.FirstCharacterToLower(PointIntervalUnit.ToString()));
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (PointPlacement.IsDirty(ref highstock)) h.Add("pointPlacement",PointPlacement.ToJSON(ref highstock));
			if (PointRange != PointRange_DefaultValue) h.Add("pointRange",PointRange);
			if (PointStart != PointStart_DefaultValue) h.Add("pointStart",PointStart);
			if (PointWidth != PointWidth_DefaultValue) h.Add("pointWidth",PointWidth);
			if (RelativeXValue != RelativeXValue_DefaultValue) h.Add("relativeXValue",RelativeXValue);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (ShowInNavigator != ShowInNavigator_DefaultValue) h.Add("showInNavigator",ShowInNavigator);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (SoftThreshold != SoftThreshold_DefaultValue) h.Add("softThreshold",SoftThreshold);
			if (States.IsDirty(ref highstock)) h.Add("states",States.ToHashtable(ref highstock));
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (Tooltip.IsDirty(ref highstock)) h.Add("tooltip",Tooltip.ToHashtable(ref highstock));
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (VectorLength != VectorLength_DefaultValue) h.Add("vectorLength",VectorLength);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (XOffset != XOffset_DefaultValue) h.Add("xOffset",XOffset);
			if (YOffset != YOffset_DefaultValue) h.Add("yOffset",YOffset);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (Zones != Zones_DefaultValue) h.Add("zones", HashifyList(ref highstock,Zones));
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}
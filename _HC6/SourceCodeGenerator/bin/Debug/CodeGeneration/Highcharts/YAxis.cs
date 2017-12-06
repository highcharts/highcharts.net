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
	public partial class YAxis  : BaseObject
	{
		public YAxis()
		{
			TooltipValueFormat = TooltipValueFormat_DefaultValue = null;
			EndOnTick = EndOnTick_DefaultValue = True;
			TickPixelInterval = TickPixelInterval_DefaultValue = 72;
			ShowLastLabel = ShowLastLabel_DefaultValue = True;
			Labels = Labels_DefaultValue = "";
			MaxPadding = MaxPadding_DefaultValue = 0.05;
			MinPadding = MinPadding_DefaultValue = 0.05;
			StartOnTick = StartOnTick_DefaultValue = True;
			Title = Title_DefaultValue = "";
			StackLabels = StackLabels_DefaultValue = "";
			GridLineWidth = GridLineWidth_DefaultValue = 1;
			LineWidth = LineWidth_DefaultValue = 0;
			Opposite = Opposite_DefaultValue = false;
			LineColor = LineColor_DefaultValue = "";
			Min = Min_DefaultValue = "";
			Max = Max_DefaultValue = "";
			Angle = Angle_DefaultValue = 0;
			GridLineInterpolation = GridLineInterpolation_DefaultValue = "null";
			MaxColor = MaxColor_DefaultValue = "#003399";
			MinColor = MinColor_DefaultValue = "#e6ebf5";
			ReversedStacks = ReversedStacks_DefaultValue = true;
			Stops = Stops_DefaultValue = new List<Stop>();
			TickWidth = TickWidth_DefaultValue = 0;
			PlotBands = PlotBands_DefaultValue = new List<YAxisPlotBands>();
			PlotLines = PlotLines_DefaultValue = new List<YAxisPlotLines>();
			DateTimeLabelFormats = DateTimeLabelFormats_DefaultValue = new Hashtable();
			MinorTickLength = MinorTickLength_DefaultValue = 2;
			MinorTickPosition = MinorTickPosition_DefaultValue = outside;
			StartOfWeek = StartOfWeek_DefaultValue = 1;
			TickLength = TickLength_DefaultValue = 10;
			TickmarkPlacement = TickmarkPlacement_DefaultValue = between;
			TickPosition = TickPosition_DefaultValue = outside;
			Type = Type_DefaultValue = linear;
			MinorGridLineColor = MinorGridLineColor_DefaultValue = "#f2f2f2";
			MinorGridLineWidth = MinorGridLineWidth_DefaultValue = 1;
			MinorTickColor = MinorTickColor_DefaultValue = "#999999";
			GridLineColor = GridLineColor_DefaultValue = "#e6e6e6";
			TickColor = TickColor_DefaultValue = "#ccd6eb";
			AllowDecimals = AllowDecimals_DefaultValue = true;
			AlternateGridColor = AlternateGridColor_DefaultValue = "null";
			Breaks = Breaks_DefaultValue = "";
			Categories = Categories_DefaultValue = new List<string> null;
			Ceiling = Ceiling_DefaultValue = null;
			ClassName = ClassName_DefaultValue = "";
			Crosshair = Crosshair_DefaultValue = new YAxisCrosshair();
			Description = Description_DefaultValue = "undefined";
			Events = Events_DefaultValue = "";
			Floor = Floor_DefaultValue = null;
			GridLineDashStyle = GridLineDashStyle_DefaultValue = "Solid";
			GridZIndex = GridZIndex_DefaultValue = 1;
			Id = Id_DefaultValue = "null";
			LinkedTo = LinkedTo_DefaultValue = null;
			MaxZoom = MaxZoom_DefaultValue = null;
			MinorGridLineDashStyle = MinorGridLineDashStyle_DefaultValue = "Solid";
			MinorTickInterval = MinorTickInterval_DefaultValue = null;
			MinorTicks = MinorTicks_DefaultValue = false;
			MinorTickWidth = MinorTickWidth_DefaultValue = 0;
			MinRange = MinRange_DefaultValue = null;
			MinTickInterval = MinTickInterval_DefaultValue = null;
			Offset = Offset_DefaultValue = 0;
			Reversed = Reversed_DefaultValue = false;
			ShowEmpty = ShowEmpty_DefaultValue = true;
			ShowFirstLabel = ShowFirstLabel_DefaultValue = true;
			SoftMax = SoftMax_DefaultValue = null;
			SoftMin = SoftMin_DefaultValue = null;
			TickAmount = TickAmount_DefaultValue = null;
			TickInterval = TickInterval_DefaultValue = null;
			TickPositioner = TickPositioner_DefaultValue = "";
			TickPositions = TickPositions_DefaultValue = "";
			UniqueNames = UniqueNames_DefaultValue = true;
			Units = Units_DefaultValue = "";
			Visible = Visible_DefaultValue = true;
			
		}	
		

		/// <summary>
		/// Parallel coordinates only. Format that will be used for point.yand available in [tooltip.pointFormat](#tooltip.pointFormat) as`{point.formattedValue}`. If not set, `{point.formattedValue}`will use other options, in this order:1. [yAxis.labels.format](#yAxis.labels.format) will be used if   set2. if yAxis is a category, then category name will be displayed3. if yAxis is a datetime, then value will use the same format as   yAxis labels4. if yAxis is linear/logarithmic type, then simple value will be   used
		/// </summary>
		public YAxisTooltipValueFormat TooltipValueFormat { get; set; }
		private YAxisTooltipValueFormat TooltipValueFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisEndOnTick EndOnTick { get; set; }
		private YAxisEndOnTick EndOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisTickPixelInterval TickPixelInterval { get; set; }
		private YAxisTickPixelInterval TickPixelInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisShowLastLabel ShowLastLabel { get; set; }
		private YAxisShowLastLabel ShowLastLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisLabels Labels { get; set; }
		private YAxisLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the max value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer. This is usefulwhen you don't want the highest data value to appear on the edgeof the plot area. When the axis' `max` option is set or a max extremeis set using `axis.setExtremes()`, the maxPadding will be ignored.
		/// </summary>
		public YAxisMaxPadding MaxPadding { get; set; }
		private YAxisMaxPadding MaxPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the min value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer. This is usefulwhen you don't want the lowest data value to appear on the edgeof the plot area. When the axis' `min` option is set or a max extremeis set using `axis.setExtremes()`, the maxPadding will be ignored.
		/// </summary>
		public YAxisMinPadding MinPadding { get; set; }
		private YAxisMinPadding MinPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to start on a tick. Use this option withthe `maxPadding` option to control the axis start.
		/// </summary>
		public YAxisStartOnTick StartOnTick { get; set; }
		private YAxisStartOnTick StartOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisTitle Title { get; set; }
		private YAxisTitle Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// The stack labels show the total value for each bar in a stackedcolumn or bar chart. The label will be placed on top of positivecolumns and below negative columns. In case of an inverted columnchart or a bar chart the label is placed to the right of positivebars and to the left of negative bars.
		/// </summary>
		public YAxisStackLabels StackLabels { get; set; }
		private YAxisStackLabels StackLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisGridLineWidth GridLineWidth { get; set; }
		private YAxisGridLineWidth GridLineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisLineWidth LineWidth { get; set; }
		private YAxisLineWidth LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisOpposite Opposite { get; set; }
		private YAxisOpposite Opposite_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisLineColor LineColor { get; set; }
		private YAxisLineColor LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisMin Min { get; set; }
		private YAxisMin Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisMax Max { get; set; }
		private YAxisMax Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a polar chart, this is the angle of the Y axis in degrees, where0 is up and 90 is right. The angle determines the position of theaxis line and the labels, though the coordinate system is unaffected.
		/// </summary>
		public double? Angle { get; set; }
		private double? Angle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Polar charts only. Whether the grid lines should draw as a polygonwith straight lines between categories, or as circles. Can be either`circle` or `polygon`.
		/// </summary>
		public string GridLineInterpolation { get; set; }
		private string GridLineInterpolation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Solid gauge only. Unless [stops](#yAxis.stops) are set, the colorto represent the maximum value of the Y axis.
		/// </summary>
		public string MaxColor { get; set; }
		private string MaxColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Solid gauge only. Unless [stops](#yAxis.stops) are set, the colorto represent the minimum value of the Y axis.
		/// </summary>
		public string MinColor { get; set; }
		private string MinColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// If `true`, the first series in a stack will be drawn on top in apositive, non-reversed Y axis. If `false`, the first series is inthe base of the stack.
		/// </summary>
		public bool? ReversedStacks { get; set; }
		private bool? ReversedStacks_DefaultValue { get; set; }
		 

		/// <summary>
		/// Solid gauge series only. Color stops for the solid gauge. Use thisin cases where a linear gradient between a `minColor` and `maxColor`is not sufficient. The stops is an array of tuples, where the firstitem is a float between 0 and 1 assigning the relative position inthe gradient, and the second item is the color.For solid gauges, the Y axis also inherits the concept of [data classes](http://api.highcharts.com/highmaps#colorAxis.dataClasses) from the Highmapscolor axis.
		/// </summary>
		public List<Stop> Stops { get; set; }
		private List<Stop> Stops_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the major tick marks.
		/// </summary>
		public double? TickWidth { get; set; }
		private double? TickWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of objects defining plot bands on the Y axis.
		/// </summary>
		public List<YAxisPlotBands> PlotBands { get; set; }
		private List<YAxisPlotBands> PlotBands_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of objects representing plot lines on the X axis
		/// </summary>
		public List<YAxisPlotLines> PlotLines { get; set; }
		private List<YAxisPlotLines> PlotLines_DefaultValue { get; set; }
		 

		/// <summary>
		/// For a datetime axis, the scale will automatically adjust to theappropriate unit. This member gives the default stringrepresentations used for each unit. For intermediate values,different units may be used, for example the `day` unit can be usedon midnight and `hour` unit be used for intermediate values on thesame axis. For an overview of the replacement codes, see[dateFormat](#Highcharts.dateFormat). Defaults to:<pre>{    millisecond: '%H:%M:%S.%L',    second: '%H:%M:%S',    minute: '%H:%M',    hour: '%H:%M',    day: '%e. %b',    week: '%e. %b',    month: '%b \'%y',    year: '%Y'}</pre>
		/// </summary>
		public Hashtable DateTimeLabelFormats { get; set; }
		private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel length of the minor tick marks.
		/// </summary>
		public YAxisMinorTickLength MinorTickLength { get; set; }
		private YAxisMinorTickLength MinorTickLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the minor tick marks relative to the axis line. Can be one of `inside` and `outside`.
		/// </summary>
		public YAxisMinorTickPosition MinorTickPosition { get; set; }
		private YAxisMinorTickPosition MinorTickPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// For datetime axes, this decides where to put the tick between weeks. 0 = Sunday, 1 = Monday.
		/// </summary>
		public YAxisStartOfWeek StartOfWeek { get; set; }
		private YAxisStartOfWeek StartOfWeek_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel length of the main tick marks.
		/// </summary>
		public YAxisTickLength TickLength { get; set; }
		private YAxisTickLength TickLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// For categorized axes only. If `on` the tick mark is placed in thecenter of the category, if `between` the tick mark is placed betweencategories. The default is `between` if the `tickInterval` is 1, else `on`.
		/// </summary>
		public YAxisTickmarkPlacement TickmarkPlacement { get; set; }
		private YAxisTickmarkPlacement TickmarkPlacement_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the major tick marks relative to the axis line.Can be one of `inside` and `outside`.
		/// </summary>
		public YAxisTickPosition TickPosition { get; set; }
		private YAxisTickPosition TickPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// The type of axis. Can be one of `linear`, `logarithmic`, `datetime`or `category`. In a datetime axis, the numbers are given inmilliseconds, and tick marks are placed on appropriate values likefull hours or days. In a category axis, the [point names](#series.line.data.name) of the chart's series are usedfor categories, if not a [categories](#xAxis.categories) array isdefined.
		/// </summary>
		public YAxisType Type { get; set; }
		private YAxisType Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the minor, secondary grid lines.In styled mode, the stroke width is given in the`.highcharts-minor-grid-line` class.
		/// </summary>
		public string MinorGridLineColor { get; set; }
		private string MinorGridLineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Width of the minor, secondary grid lines.In styled mode, the stroke width is given in the`.highcharts-grid-line` class.
		/// </summary>
		public YAxisMinorGridLineWidth MinorGridLineWidth { get; set; }
		private YAxisMinorGridLineWidth MinorGridLineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color for the minor tick marks.
		/// </summary>
		public string MinorTickColor { get; set; }
		private string MinorTickColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the grid lines extending the ticks across the plot area.In styled mode, the stroke is given in the `.highcharts-grid-line`class.
		/// </summary>
		public string GridLineColor { get; set; }
		private string GridLineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color for the main tick marks.In styled mode, the stroke is given in the `.highcharts-tick`class.
		/// </summary>
		public string TickColor { get; set; }
		private string TickColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to allow decimals in this axis' ticks. When countingintegers, like persons or hits on a web page, decimals shouldbe avoided in the labels.
		/// </summary>
		public bool? AllowDecimals { get; set; }
		private bool? AllowDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using an alternate grid color, a band is painted across theplot area between every other grid line.
		/// </summary>
		public string AlternateGridColor { get; set; }
		private string AlternateGridColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining breaks in the axis, the sections defined will beleft out and all the points shifted closer to each other.
		/// </summary>
		public YAxisBreaks Breaks { get; set; }
		private YAxisBreaks Breaks_DefaultValue { get; set; }
		 

		/// <summary>
		/// If categories are present for the xAxis, names are used instead ofnumbers for that axis. Since Highcharts 3.0, categories can alsobe extracted by giving each point a [name](#series.data) and settingaxis [type](#xAxis.type) to `category`. However, if you have multipleseries, best practice remains defining the `categories` array.Example:<pre>categories: ['Apples', 'Bananas', 'Oranges']</pre>
		/// </summary>
		public List<string> Categories { get; set; }
		private List<string> Categories_DefaultValue { get; set; }
		 

		/// <summary>
		/// The highest allowed value for automatically computed axis extremes.
		/// </summary>
		public double? Ceiling { get; set; }
		private double? Ceiling_DefaultValue { get; set; }
		 

		/// <summary>
		/// A class name that opens for styling the axis by CSS, especially inHighcharts styled mode. The class name is applied to group elementsfor the grid, axis elements and labels.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Configure a crosshair that follows either the mouse pointer or thehovered point.In styled mode, the crosshairs are styled in the`.highcharts-crosshair`, `.highcharts-crosshair-thin` or`.highcharts-xaxis-category` classes.
		/// </summary>
		public bool? Crosshair { get; set; }
		private bool? Crosshair_DefaultValue { get; set; }
		 

		/// <summary>
		/// _Requires Accessibility module_Description of the axis to screen reader users.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Event handlers for the axis.
		/// </summary>
		public YAxisEvents Events { get; set; }
		private YAxisEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lowest allowed value for automatically computed axis extremes.
		/// </summary>
		public double? Floor { get; set; }
		private double? Floor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash or dot style of the grid lines. For possible values, see[this demonstration](http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/).
		/// </summary>
		public string GridLineDashStyle { get; set; }
		private string GridLineDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the grid lines.
		/// </summary>
		public double? GridZIndex { get; set; }
		private double? GridZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the axis. This can be used after render time to geta pointer to the axis object through `chart.get()`.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// Index of another axis that this axis is linked to. When an axis islinked to a master axis, it will take the same extremes asthe master, but as assigned by min or max or by setExtremes.It can be used to show additional info, or to ease reading thechart by duplicating the scales.
		/// </summary>
		public double? LinkedTo { get; set; }
		private double? LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// Deprecated. Use `minRange` instead.
		/// </summary>
		public double? MaxZoom { get; set; }
		private double? MaxZoom_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash or dot style of the minor grid lines. For possible values,see [this demonstration](http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/).
		/// </summary>
		public string MinorGridLineDashStyle { get; set; }
		private string MinorGridLineDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific tick interval in axis units for the minor ticks.On a linear axis, if `"auto"`, the minor tick interval iscalculated as a fifth of the tickInterval. If `null`, minorticks are not shown.On logarithmic axes, the unit is the power of the value. For example,setting the minorTickInterval to 1 puts one tick on each of 0.1,1, 10, 100 etc. Setting the minorTickInterval to 0.1 produces 9ticks between 1 and 10, 10 and 100 etc.If user settings dictate minor ticks to become too dense, they don'tmake sense, and will be ignored to prevent performance problems.
		/// </summary>
		public double? MinorTickInterval { get; set; }
		private double? MinorTickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable minor ticks. Unless[minorTickInterval](#xAxis.minorTickInterval) is set, the tickinterval is calculated as a fifth of the `tickInterval`.On a logarithmic axis, minor ticks are laid out based on a bestguess, attempting to enter approximately 5 minor ticks betweeneach major tick.Prior to v6.0.0, ticks were unabled in auto layout by setting`minorTickInterval` to `"auto"`.
		/// </summary>
		public bool? MinorTicks { get; set; }
		private bool? MinorTicks_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the minor tick mark.
		/// </summary>
		public double? MinorTickWidth { get; set; }
		private double? MinorTickWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum range to display on this axis. The entire axis will notbe allowed to span over a smaller interval than this. For example,for a datetime axis the main unit is milliseconds. If minRange isset to 3600000, you can't zoom in more than to one hour.The default minRange for the x axis is five times the smallestinterval between any of the data points.On a logarithmic axis, the unit for the minimum range is the power.So a minRange of 1 means that the axis can be zoomed to 10-100,100-1000, 1000-10000 etc.Note that the `minPadding`, `maxPadding`, `startOnTick` and`endOnTick` settings also affect how the extremes of the axisare computed.
		/// </summary>
		public double? MinRange { get; set; }
		private double? MinRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum tick interval allowed in axis values. For example onzooming in on an axis with daily data, this can be used to preventthe axis from showing hours. Defaults to the closest distance betweentwo points on the axis.
		/// </summary>
		public double? MinTickInterval { get; set; }
		private double? MinTickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance in pixels from the plot area to the axis line.A positive offset moves the axis with it's line, labels and ticksaway from the plot area. This is typically used when two or moreaxes are displayed on the same side of the plot. With multipleaxes the offset is dynamically adjusted to avoid collision, thiscan be overridden by setting offset explicitly.
		/// </summary>
		public double? Offset { get; set; }
		private double? Offset_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to reverse the axis so that the highest number is closestto the origin. If the chart is inverted, the x axis is reversed bydefault.
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to show the axis line and title when the axis has no data.
		/// </summary>
		public bool? ShowEmpty { get; set; }
		private bool? ShowEmpty_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to show the first tick label.
		/// </summary>
		public bool? ShowFirstLabel { get; set; }
		private bool? ShowFirstLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// A soft maximum for the axis. If the series data maximum is less thanthis, the axis will stay at this maximum, but if the series datamaximum is higher, the axis will flex to show all data.
		/// </summary>
		public double? SoftMax { get; set; }
		private double? SoftMax_DefaultValue { get; set; }
		 

		/// <summary>
		/// A soft minimum for the axis. If the series data minimum is greaterthan this, the axis will stay at this minimum, but if the seriesdata minimum is lower, the axis will flex to show all data.
		/// </summary>
		public double? SoftMin { get; set; }
		private double? SoftMin_DefaultValue { get; set; }
		 

		/// <summary>
		/// The amount of ticks to draw on the axis. This opens up for aligningthe ticks of multiple charts or panes within a chart. This optionoverrides the `tickPixelInterval` option.This option only has an effect on linear axes. Datetime, logarithmicor category axes are not affected.
		/// </summary>
		public double? TickAmount { get; set; }
		private double? TickAmount_DefaultValue { get; set; }
		 

		/// <summary>
		/// The interval of the tick marks in axis units. When `null`, the tickinterval is computed to approximately follow the [tickPixelInterval](#xAxis.tickPixelInterval) on linear and datetime axes. On categorized axes,a `null` tickInterval will default to 1, one category. Note thatdatetime axes are based on milliseconds, so for example an intervalof one day is expressed as `24 * 3600 * 1000`.On logarithmic axes, the tickInterval is based on powers, so a tickIntervalof 1 means one tick on each of 0.1, 1, 10, 100 etc. A tickIntervalof 2 means a tick of 0.1, 10, 1000 etc. A tickInterval of 0.2 putsa tick on 0.1, 0.2, 0.4, 0.6, 0.8, 1, 2, 4, 6, 8, 10, 20, 40 etc.If the tickInterval is too dense for labels to be drawn, Highchartsmay remove ticks.If the chart has multiple axes, the [alignTicks](#chart.alignTicks)option may interfere with the `tickInterval` setting.
		/// </summary>
		public double? TickInterval { get; set; }
		private double? TickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function returning array defining where the ticks arelaid out on the axis. This overrides the default behaviour of [tickPixelInterval](#xAxis.tickPixelInterval) and [tickInterval](#xAxis.tickInterval). The automatictick positions are accessible through `this.tickPositions` and canbe modified by the callback.
		/// </summary>
		public string TickPositioner { get; set; }
		private string TickPositioner_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining where the ticks are laid out on the axis. Thisoverrides the default behaviour of [tickPixelInterval](#xAxis.tickPixelInterval)and [tickInterval](#xAxis.tickInterval).
		/// </summary>
		public List<double> TickPositions { get; set; }
		private List<double> TickPositions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Applies only when the axis `type` is `category`. When `uniqueNames`is true, points are placed on the X axis according to their names.If the same point name is repeated in the same or another series,the point is placed on the same X position as other points of thesame name. When `uniqueNames` is false, the points are laid out inincreasing X positions regardless of their names, and the X axiscategory will take the name of the last point in each position.
		/// </summary>
		public bool? UniqueNames { get; set; }
		private bool? UniqueNames_DefaultValue { get; set; }
		 

		/// <summary>
		/// Datetime axis only. An array determining what time intervals theticks are allowed to fall on. Each array item is an array where thefirst value is the time unit and the second value another array ofallowed multiples. Defaults to:<pre>units: [[    'millisecond', // unit name    [1, 2, 5, 10, 20, 25, 50, 100, 200, 500] // allowed multiples], [    'second',    [1, 2, 5, 10, 15, 30]], [    'minute',    [1, 2, 5, 10, 15, 30]], [    'hour',    [1, 2, 3, 4, 6, 8, 12]], [    'day',    [1]], [    'week',    [1]], [    'month',    [1, 3, 6]], [    'year',    null]]</pre>
		/// </summary>
		public YAxisUnits Units { get; set; }
		private YAxisUnits Units_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether axis, including axis title, line, ticks and labels, shouldbe visible.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (TooltipValueFormat != TooltipValueFormat_DefaultValue) h.Add("tooltipValueFormat",TooltipValueFormat);
			if (EndOnTick != EndOnTick_DefaultValue) h.Add("endOnTick",EndOnTick);
			if (TickPixelInterval != TickPixelInterval_DefaultValue) h.Add("tickPixelInterval",TickPixelInterval);
			if (ShowLastLabel != ShowLastLabel_DefaultValue) h.Add("showLastLabel",ShowLastLabel);
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (MaxPadding != MaxPadding_DefaultValue) h.Add("maxPadding",MaxPadding);
			if (MinPadding != MinPadding_DefaultValue) h.Add("minPadding",MinPadding);
			if (StartOnTick != StartOnTick_DefaultValue) h.Add("startOnTick",StartOnTick);
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (StackLabels.IsDirty()) h.Add("stackLabels",StackLabels.ToHashtable());
			if (GridLineWidth != GridLineWidth_DefaultValue) h.Add("gridLineWidth",GridLineWidth);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Opposite != Opposite_DefaultValue) h.Add("opposite",Opposite);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (Angle != Angle_DefaultValue) h.Add("angle",Angle);
			if (GridLineInterpolation != GridLineInterpolation_DefaultValue) h.Add("gridLineInterpolation",GridLineInterpolation);
			if (MaxColor != MaxColor_DefaultValue) h.Add("maxColor",MaxColor);
			if (MinColor != MinColor_DefaultValue) h.Add("minColor",MinColor);
			if (ReversedStacks != ReversedStacks_DefaultValue) h.Add("reversedStacks",ReversedStacks);
			if (Stops.Any()) h.Add("stops", GetLists(Stops));
			if (TickWidth != TickWidth_DefaultValue) h.Add("tickWidth",TickWidth);
			if (PlotBands != PlotBands_DefaultValue) h.Add("plotBands", HashifyList(PlotBands));
			if (PlotLines != PlotLines_DefaultValue) h.Add("plotLines", HashifyList(PlotLines));
			if (DateTimeLabelFormats != DateTimeLabelFormats_DefaultValue) h.Add("dateTimeLabelFormats",DateTimeLabelFormats);
			if (MinorTickLength != MinorTickLength_DefaultValue) h.Add("minorTickLength",MinorTickLength);
			if (MinorTickPosition != MinorTickPosition_DefaultValue) h.Add("minorTickPosition",MinorTickPosition);
			if (StartOfWeek != StartOfWeek_DefaultValue) h.Add("startOfWeek",StartOfWeek);
			if (TickLength != TickLength_DefaultValue) h.Add("tickLength",TickLength);
			if (TickmarkPlacement != TickmarkPlacement_DefaultValue) h.Add("tickmarkPlacement",TickmarkPlacement);
			if (TickPosition != TickPosition_DefaultValue) h.Add("tickPosition",TickPosition);
			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (MinorGridLineColor != MinorGridLineColor_DefaultValue) h.Add("minorGridLineColor",MinorGridLineColor);
			if (MinorGridLineWidth != MinorGridLineWidth_DefaultValue) h.Add("minorGridLineWidth",MinorGridLineWidth);
			if (MinorTickColor != MinorTickColor_DefaultValue) h.Add("minorTickColor",MinorTickColor);
			if (GridLineColor != GridLineColor_DefaultValue) h.Add("gridLineColor",GridLineColor);
			if (TickColor != TickColor_DefaultValue) h.Add("tickColor",TickColor);
			if (AllowDecimals != AllowDecimals_DefaultValue) h.Add("allowDecimals",AllowDecimals);
			if (AlternateGridColor != AlternateGridColor_DefaultValue) h.Add("alternateGridColor",AlternateGridColor);
			if (Breaks.IsDirty()) h.Add("breaks",Breaks.ToHashtable());
			if (Categories != Categories_DefaultValue) h.Add("categories",Categories);
			if (Ceiling != Ceiling_DefaultValue) h.Add("ceiling",Ceiling);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Crosshair.IsDirty()) h.Add("crosshair",Crosshair.ToHashtable());
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Floor != Floor_DefaultValue) h.Add("floor",Floor);
			if (GridLineDashStyle != GridLineDashStyle_DefaultValue) h.Add("gridLineDashStyle",GridLineDashStyle);
			if (GridZIndex != GridZIndex_DefaultValue) h.Add("gridZIndex",GridZIndex);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (MaxZoom != MaxZoom_DefaultValue) h.Add("maxZoom",MaxZoom);
			if (MinorGridLineDashStyle != MinorGridLineDashStyle_DefaultValue) h.Add("minorGridLineDashStyle",MinorGridLineDashStyle);
			if (MinorTickInterval != MinorTickInterval_DefaultValue) h.Add("minorTickInterval",MinorTickInterval);
			if (MinorTicks != MinorTicks_DefaultValue) h.Add("minorTicks",MinorTicks);
			if (MinorTickWidth != MinorTickWidth_DefaultValue) h.Add("minorTickWidth",MinorTickWidth);
			if (MinRange != MinRange_DefaultValue) h.Add("minRange",MinRange);
			if (MinTickInterval != MinTickInterval_DefaultValue) h.Add("minTickInterval",MinTickInterval);
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (ShowEmpty != ShowEmpty_DefaultValue) h.Add("showEmpty",ShowEmpty);
			if (ShowFirstLabel != ShowFirstLabel_DefaultValue) h.Add("showFirstLabel",ShowFirstLabel);
			if (SoftMax != SoftMax_DefaultValue) h.Add("softMax",SoftMax);
			if (SoftMin != SoftMin_DefaultValue) h.Add("softMin",SoftMin);
			if (TickAmount != TickAmount_DefaultValue) h.Add("tickAmount",TickAmount);
			if (TickInterval != TickInterval_DefaultValue) h.Add("tickInterval",TickInterval);
			if (TickPositioner != TickPositioner_DefaultValue) h.Add("tickPositioner",TickPositioner);
			if (TickPositions != TickPositions_DefaultValue) h.Add("tickPositions",TickPositions);
			if (UniqueNames != UniqueNames_DefaultValue) h.Add("uniqueNames",UniqueNames);
			if (Units != Units_DefaultValue) h.Add("units",Units);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			

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
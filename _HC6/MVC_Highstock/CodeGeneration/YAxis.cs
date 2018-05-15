using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class YAxis  : BaseObject
	{
		public YAxis()
		{
			AlignTicks = AlignTicks_DefaultValue = true;
			AllowDecimals = AllowDecimals_DefaultValue = true;
			AlternateGridColor = AlternateGridColor_DefaultValue = "null";
			Breaks = Breaks_DefaultValue = new YAxisBreaks();
			Categories = Categories_DefaultValue = new List<string>();
			Ceiling = Ceiling_DefaultValue = null;
			ClassName = ClassName_DefaultValue = "";
			Crosshair = Crosshair_DefaultValue = new YAxisCrosshair();
			CrosshairBool = CrosshairBool_DefaultValue = null;
			DateTimeLabelFormats = DateTimeLabelFormats_DefaultValue = new Hashtable();
			Description = Description_DefaultValue = "undefined";
			EndOnTick = EndOnTick_DefaultValue = true;
			Events = Events_DefaultValue = new YAxisEvents();
			Floor = Floor_DefaultValue = null;
			GridLineColor = GridLineColor_DefaultValue = "#e6e6e6";
			GridLineDashStyle = GridLineDashStyle_DefaultValue = YAxisGridLineDashStyle.Solid;
			GridLineWidth = GridLineWidth_DefaultValue = 1;
			GridZIndex = GridZIndex_DefaultValue = 1;
			Height = Height_DefaultValue = "null";
			HeightNumber = HeightNumber_DefaultValue = null;
			Id = Id_DefaultValue = "null";
			Labels = Labels_DefaultValue = new YAxisLabels();
			LineColor = LineColor_DefaultValue = "";
			LineWidth = LineWidth_DefaultValue = 0;
			LinkedTo = LinkedTo_DefaultValue = null;
			Max = Max_DefaultValue = null;
			MaxLength = MaxLength_DefaultValue = "null";
			MaxLengthNumber = MaxLengthNumber_DefaultValue = null;
			MaxPadding = MaxPadding_DefaultValue = null;
			MaxRange = MaxRange_DefaultValue = null;
			MaxZoom = MaxZoom_DefaultValue = null;
			Min = Min_DefaultValue = null;
			MinLength = MinLength_DefaultValue = "null";
			MinLengthNumber = MinLengthNumber_DefaultValue = null;
			MinorGridLineColor = MinorGridLineColor_DefaultValue = "#f2f2f2";
			MinorGridLineDashStyle = MinorGridLineDashStyle_DefaultValue = YAxisMinorGridLineDashStyle.Solid;
			MinorGridLineWidth = MinorGridLineWidth_DefaultValue = 1;
			MinorTickColor = MinorTickColor_DefaultValue = "#999999";
			MinorTickInterval = MinorTickInterval_DefaultValue = "null";
			MinorTickIntervalNumber = MinorTickIntervalNumber_DefaultValue = null;
			MinorTickLength = MinorTickLength_DefaultValue = 2;
			MinorTickPosition = MinorTickPosition_DefaultValue = YAxisMinorTickPosition.Outside;
			MinorTicks = MinorTicks_DefaultValue = false;
			MinorTickWidth = MinorTickWidth_DefaultValue = 0;
			MinPadding = MinPadding_DefaultValue = null;
			MinRange = MinRange_DefaultValue = null;
			MinTickInterval = MinTickInterval_DefaultValue = null;
			Offset = Offset_DefaultValue = 0;
			Opposite = Opposite_DefaultValue = false;
			PlotBands = PlotBands_DefaultValue = new List<YAxisPlotBands>();
			PlotLines = PlotLines_DefaultValue = new List<YAxisPlotLines>();
			Range = Range_DefaultValue = null;
			Resize = Resize_DefaultValue = new YAxisResize();
			Reversed = Reversed_DefaultValue = false;
			ReversedStacks = ReversedStacks_DefaultValue = true;
			Scrollbar = Scrollbar_DefaultValue = new YAxisScrollbar();
			ShowEmpty = ShowEmpty_DefaultValue = true;
			ShowFirstLabel = ShowFirstLabel_DefaultValue = true;
			ShowLastLabel = ShowLastLabel_DefaultValue = true;
			SoftMax = SoftMax_DefaultValue = null;
			SoftMin = SoftMin_DefaultValue = null;
			StartOfWeek = StartOfWeek_DefaultValue = 1;
			StartOnTick = StartOnTick_DefaultValue = true;
			TickAmount = TickAmount_DefaultValue = null;
			TickColor = TickColor_DefaultValue = "#ccd6eb";
			TickInterval = TickInterval_DefaultValue = null;
			TickLength = TickLength_DefaultValue = 10;
			TickPixelInterval = TickPixelInterval_DefaultValue = 72;
			TickPosition = TickPosition_DefaultValue = YAxisTickPosition.Outside;
			TickPositioner = TickPositioner_DefaultValue = "";
			TickPositions = TickPositions_DefaultValue = new List<double>();
			TickWidth = TickWidth_DefaultValue = 0;
			Title = Title_DefaultValue = new YAxisTitle();
			TooltipValueFormat = TooltipValueFormat_DefaultValue = "undefined";
			Top = Top_DefaultValue = "null";
			TopNumber = TopNumber_DefaultValue = null;
			Visible = Visible_DefaultValue = true;
			
		}	
		

		/// <summary>
		/// When using multiple axis, the ticks of two or more opposite axeswill automatically be aligned by adding ticks to the axis or axeswith the least ticks, as if `tickAmount` were specified.This can be prevented by setting `alignTicks` to false. If the gridlines look messy, it's a good idea to hide them for the secondaryaxis by setting `gridLineWidth` to 0.If `startOnTick` or `endOnTick` in an Axis options are set to false,then the `alignTicks ` will be disabled for the Axis.Disabled for logarithmic axes.
		/// </summary>
		public bool? AlignTicks { get; set; }
		private bool? AlignTicks_DefaultValue { get; set; }
		 

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
		public YAxisCrosshair Crosshair { get; set; }
		private YAxisCrosshair Crosshair_DefaultValue { get; set; }
		 

		/// <summary>
		/// Configure a crosshair that follows either the mouse pointer or thehovered point.In styled mode, the crosshairs are styled in the`.highcharts-crosshair`, `.highcharts-crosshair-thin` or`.highcharts-xaxis-category` classes.
		/// </summary>
		public bool? CrosshairBool { get; set; }
		private bool? CrosshairBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// For a datetime axis, the scale will automatically adjust to theappropriate unit. This member gives the default stringrepresentations used for each unit. For intermediate values,different units may be used, for example the `day` unit can be usedon midnight and `hour` unit be used for intermediate values on thesame axis. For an overview of the replacement codes, see[dateFormat](#Highcharts.dateFormat). Defaults to:<pre>{    millisecond: '%H:%M:%S.%L',    second: '%H:%M:%S',    minute: '%H:%M',    hour: '%H:%M',    day: '%e. %b',    week: '%e. %b',    month: '%b \'%y',    year: '%Y'}</pre>
		/// </summary>
		public Hashtable DateTimeLabelFormats { get; set; }
		private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// _Requires Accessibility module_Description of the axis to screen reader users.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? EndOnTick { get; set; }
		private bool? EndOnTick_DefaultValue { get; set; }
		 

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
		/// Color of the grid lines extending the ticks across the plot area.In styled mode, the stroke is given in the `.highcharts-grid-line`class.
		/// </summary>
		public string GridLineColor { get; set; }
		private string GridLineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash or dot style of the grid lines. For possible values, see[this demonstration](http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/).
		/// </summary>
		public YAxisGridLineDashStyle GridLineDashStyle { get; set; }
		private YAxisGridLineDashStyle GridLineDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? GridLineWidth { get; set; }
		private double? GridLineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the grid lines.
		/// </summary>
		public double? GridZIndex { get; set; }
		private double? GridZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the Y axis. If it's a number, it is interpreted aspixels.Since Highstock 2: If it's a percentage string, it is interpretedas percentages of the total plot height.
		/// </summary>
		public string Height { get; set; }
		private string Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the Y axis. If it's a number, it is interpreted aspixels.Since Highstock 2: If it's a percentage string, it is interpretedas percentages of the total plot height.
		/// </summary>
		public double? HeightNumber { get; set; }
		private double? HeightNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the axis. This can be used after render time to geta pointer to the axis object through `chart.get()`.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisLabels Labels { get; set; }
		private YAxisLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Index of another axis that this axis is linked to. When an axis islinked to a master axis, it will take the same extremes asthe master, but as assigned by min or max or by setExtremes.It can be used to show additional info, or to ease reading thechart by duplicating the scales.
		/// </summary>
		public double? LinkedTo { get; set; }
		private double? LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Max { get; set; }
		private double? Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// Maximal size of a resizable axis. Could be set as a percentof plot area or pixel size.This feature requires the `drag-panes.js` module.
		/// </summary>
		public string MaxLength { get; set; }
		private string MaxLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// Maximal size of a resizable axis. Could be set as a percentof plot area or pixel size.This feature requires the `drag-panes.js` module.
		/// </summary>
		public double? MaxLengthNumber { get; set; }
		private double? MaxLengthNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the max value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer. This is usefulwhen you don't want the highest data value to appear on the edgeof the plot area. When the axis' `max` option is set or a max extremeis set using `axis.setExtremes()`, the maxPadding will be ignored.
		/// </summary>
		public double? MaxPadding { get; set; }
		private double? MaxPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Maximum range which can be set using the navigator's handles.Opposite of [xAxis.minRange](#xAxis.minRange).
		/// </summary>
		public double? MaxRange { get; set; }
		private double? MaxRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// Deprecated. Use `minRange` instead.
		/// </summary>
		public double? MaxZoom { get; set; }
		private double? MaxZoom_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Min { get; set; }
		private double? Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// Minimal size of a resizable axis. Could be set as a percentof plot area or pixel size.This feature requires the `drag-panes.js` module.
		/// </summary>
		public string MinLength { get; set; }
		private string MinLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// Minimal size of a resizable axis. Could be set as a percentof plot area or pixel size.This feature requires the `drag-panes.js` module.
		/// </summary>
		public double? MinLengthNumber { get; set; }
		private double? MinLengthNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the minor, secondary grid lines.In styled mode, the stroke width is given in the`.highcharts-minor-grid-line` class.
		/// </summary>
		public string MinorGridLineColor { get; set; }
		private string MinorGridLineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash or dot style of the minor grid lines. For possible values,see [this demonstration](http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/).
		/// </summary>
		public YAxisMinorGridLineDashStyle MinorGridLineDashStyle { get; set; }
		private YAxisMinorGridLineDashStyle MinorGridLineDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Width of the minor, secondary grid lines.In styled mode, the stroke width is given in the`.highcharts-grid-line` class.
		/// </summary>
		public double? MinorGridLineWidth { get; set; }
		private double? MinorGridLineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color for the minor tick marks.
		/// </summary>
		public string MinorTickColor { get; set; }
		private string MinorTickColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific tick interval in axis units for the minor ticks.On a linear axis, if `"auto"`, the minor tick interval iscalculated as a fifth of the tickInterval. If `null`, minorticks are not shown.On logarithmic axes, the unit is the power of the value. For example,setting the minorTickInterval to 1 puts one tick on each of 0.1,1, 10, 100 etc. Setting the minorTickInterval to 0.1 produces 9ticks between 1 and 10, 10 and 100 etc.If user settings dictate minor ticks to become too dense, they don'tmake sense, and will be ignored to prevent performance problems.
		/// </summary>
		public string MinorTickInterval { get; set; }
		private string MinorTickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific tick interval in axis units for the minor ticks.On a linear axis, if `"auto"`, the minor tick interval iscalculated as a fifth of the tickInterval. If `null`, minorticks are not shown.On logarithmic axes, the unit is the power of the value. For example,setting the minorTickInterval to 1 puts one tick on each of 0.1,1, 10, 100 etc. Setting the minorTickInterval to 0.1 produces 9ticks between 1 and 10, 10 and 100 etc.If user settings dictate minor ticks to become too dense, they don'tmake sense, and will be ignored to prevent performance problems.
		/// </summary>
		public double? MinorTickIntervalNumber { get; set; }
		private double? MinorTickIntervalNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel length of the minor tick marks.
		/// </summary>
		public double? MinorTickLength { get; set; }
		private double? MinorTickLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the minor tick marks relative to the axis line. Can be one of `inside` and `outside`.
		/// </summary>
		public YAxisMinorTickPosition MinorTickPosition { get; set; }
		private YAxisMinorTickPosition MinorTickPosition_DefaultValue { get; set; }
		 

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
		/// Padding of the min value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer. This is usefulwhen you don't want the lowest data value to appear on the edgeof the plot area. When the axis' `min` option is set or a max extremeis set using `axis.setExtremes()`, the maxPadding will be ignored.
		/// </summary>
		public double? MinPadding { get; set; }
		private double? MinPadding_DefaultValue { get; set; }
		 

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
		/// 
		/// </summary>
		public bool? Opposite { get; set; }
		private bool? Opposite_DefaultValue { get; set; }
		 

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
		/// The zoomed range to display when only defining one or none of `min`or `max`. For example, to show the latest month, a range of one monthcan be set.
		/// </summary>
		public double? Range { get; set; }
		private double? Range_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for axis resizing. This feature requires the`drag-panes.js` -[classic](http://code.highcharts.com/stock/modules/drag-panes.js) or[styled](http://code.highcharts.com/stock/js/modules/drag-panes.js)mode - module.
		/// </summary>
		public YAxisResize Resize { get; set; }
		private YAxisResize Resize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to reverse the axis so that the highest number is closestto the origin. If the chart is inverted, the x axis is reversed bydefault.
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// If `true`, the first series in a stack will be drawn on top in apositive, non-reversed Y axis. If `false`, the first series is inthe base of the stack.
		/// </summary>
		public bool? ReversedStacks { get; set; }
		private bool? ReversedStacks_DefaultValue { get; set; }
		 

		/// <summary>
		/// An optional scrollbar to display on the Y axis in response to limitingthe minimum an maximum of the axis values.In styled mode, all the presentational options for the scrollbarare replaced by the classes `.highcharts-scrollbar-thumb`, `.highcharts-scrollbar-arrow`, `.highcharts-scrollbar-button`, `.highcharts-scrollbar-rifles` and `.highcharts-scrollbar-track`.
		/// </summary>
		public YAxisScrollbar Scrollbar { get; set; }
		private YAxisScrollbar Scrollbar_DefaultValue { get; set; }
		 

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
		/// 
		/// </summary>
		public bool? ShowLastLabel { get; set; }
		private bool? ShowLastLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// A soft maximum for the axis. If the series data maximum is lessthan this, the axis will stay at this maximum, but if the seriesdata maximum is higher, the axis will flex to show all data.
		/// </summary>
		public double? SoftMax { get; set; }
		private double? SoftMax_DefaultValue { get; set; }
		 

		/// <summary>
		/// A soft minimum for the axis. If the series data minimum is greaterthan this, the axis will stay at this minimum, but if the seriesdata minimum is lower, the axis will flex to show all data.
		/// </summary>
		public double? SoftMin { get; set; }
		private double? SoftMin_DefaultValue { get; set; }
		 

		/// <summary>
		/// For datetime axes, this decides where to put the tick between weeks. 0 = Sunday, 1 = Monday.
		/// </summary>
		public double? StartOfWeek { get; set; }
		private double? StartOfWeek_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to start on a tick. Use this option withthe `maxPadding` option to control the axis start.
		/// </summary>
		public bool? StartOnTick { get; set; }
		private bool? StartOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// The amount of ticks to draw on the axis. This opens up for aligningthe ticks of multiple charts or panes within a chart. This optionoverrides the `tickPixelInterval` option.This option only has an effect on linear axes. Datetime, logarithmicor category axes are not affected.
		/// </summary>
		public double? TickAmount { get; set; }
		private double? TickAmount_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color for the main tick marks.In styled mode, the stroke is given in the `.highcharts-tick`class.
		/// </summary>
		public string TickColor { get; set; }
		private string TickColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The interval of the tick marks in axis units. When `null`, the tickinterval is computed to approximately follow the [tickPixelInterval](#xAxis.tickPixelInterval) on linear and datetime axes. On categorized axes,a `null` tickInterval will default to 1, one category. Note thatdatetime axes are based on milliseconds, so for example an intervalof one day is expressed as `24 * 3600 * 1000`.On logarithmic axes, the tickInterval is based on powers, so a tickIntervalof 1 means one tick on each of 0.1, 1, 10, 100 etc. A tickIntervalof 2 means a tick of 0.1, 10, 1000 etc. A tickInterval of 0.2 putsa tick on 0.1, 0.2, 0.4, 0.6, 0.8, 1, 2, 4, 6, 8, 10, 20, 40 etc.If the tickInterval is too dense for labels to be drawn, Highchartsmay remove ticks.If the chart has multiple axes, the [alignTicks](#chart.alignTicks)option may interfere with the `tickInterval` setting.
		/// </summary>
		public double? TickInterval { get; set; }
		private double? TickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel length of the main tick marks.
		/// </summary>
		public double? TickLength { get; set; }
		private double? TickLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? TickPixelInterval { get; set; }
		private double? TickPixelInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the major tick marks relative to the axis line.Can be one of `inside` and `outside`.
		/// </summary>
		public YAxisTickPosition TickPosition { get; set; }
		private YAxisTickPosition TickPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function returning array defining where the ticks arelaid out on the axis. This overrides the default behaviour of[tickPixelInterval](#xAxis.tickPixelInterval) and[tickInterval](#xAxis.tickInterval). The automatic tick positions areaccessible through `this.tickPositions` and can be modified by the callback.
		/// </summary>
		public string TickPositioner { get; set; }
		private string TickPositioner_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining where the ticks are laid out on the axis. Thisoverrides the default behaviour of [tickPixelInterval](#xAxis.tickPixelInterval)and [tickInterval](#xAxis.tickInterval).
		/// </summary>
		public List<double> TickPositions { get; set; }
		private List<double> TickPositions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the major tick marks.
		/// </summary>
		public double? TickWidth { get; set; }
		private double? TickWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisTitle Title { get; set; }
		private YAxisTitle Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// Parallel coordinates only. Format that will be used for point.yand available in [tooltip.pointFormat](#tooltip.pointFormat) as`{point.formattedValue}`. If not set, `{point.formattedValue}`will use other options, in this order:1. [yAxis.labels.format](#yAxis.labels.format) will be used if   set2. if yAxis is a category, then category name will be displayed3. if yAxis is a datetime, then value will use the same format as   yAxis labels4. if yAxis is linear/logarithmic type, then simple value will be   used
		/// </summary>
		public string TooltipValueFormat { get; set; }
		private string TooltipValueFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The top position of the Y axis. If it's a number, it is interpretedas pixel position relative to the chart.Since Highstock 2: If it's a percentage string, it is interpretedas percentages of the plot height, offset from plot area top.
		/// </summary>
		public string Top { get; set; }
		private string Top_DefaultValue { get; set; }
		 

		/// <summary>
		/// The top position of the Y axis. If it's a number, it is interpretedas pixel position relative to the chart.Since Highstock 2: If it's a percentage string, it is interpretedas percentages of the plot height, offset from plot area top.
		/// </summary>
		public double? TopNumber { get; set; }
		private double? TopNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether axis, including axis title, line, ticks and labels, shouldbe visible.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AlignTicks != AlignTicks_DefaultValue) h.Add("alignTicks",AlignTicks);
			if (AllowDecimals != AllowDecimals_DefaultValue) h.Add("allowDecimals",AllowDecimals);
			if (AlternateGridColor != AlternateGridColor_DefaultValue) h.Add("alternateGridColor",AlternateGridColor);
			if (Breaks.IsDirty()) h.Add("breaks",Breaks.ToHashtable());
			if (Categories != Categories_DefaultValue) h.Add("categories",Categories);
			if (Ceiling != Ceiling_DefaultValue) h.Add("ceiling",Ceiling);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Crosshair.IsDirty()) h.Add("crosshair",Crosshair.ToHashtable());
			if (CrosshairBool != CrosshairBool_DefaultValue) h.Add("crosshair",CrosshairBool);
			if (DateTimeLabelFormats != DateTimeLabelFormats_DefaultValue) h.Add("dateTimeLabelFormats",DateTimeLabelFormats);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EndOnTick != EndOnTick_DefaultValue) h.Add("endOnTick",EndOnTick);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Floor != Floor_DefaultValue) h.Add("floor",Floor);
			if (GridLineColor != GridLineColor_DefaultValue) h.Add("gridLineColor",GridLineColor);
			if (GridLineDashStyle != GridLineDashStyle_DefaultValue) h.Add("gridLineDashStyle", Highstock.FirstCharacterToLower(GridLineDashStyle.ToString()));
			if (GridLineWidth != GridLineWidth_DefaultValue) h.Add("gridLineWidth",GridLineWidth);
			if (GridZIndex != GridZIndex_DefaultValue) h.Add("gridZIndex",GridZIndex);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (HeightNumber != HeightNumber_DefaultValue) h.Add("height",HeightNumber);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (MaxLength != MaxLength_DefaultValue) h.Add("maxLength",MaxLength);
			if (MaxLengthNumber != MaxLengthNumber_DefaultValue) h.Add("maxLength",MaxLengthNumber);
			if (MaxPadding != MaxPadding_DefaultValue) h.Add("maxPadding",MaxPadding);
			if (MaxRange != MaxRange_DefaultValue) h.Add("maxRange",MaxRange);
			if (MaxZoom != MaxZoom_DefaultValue) h.Add("maxZoom",MaxZoom);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (MinLength != MinLength_DefaultValue) h.Add("minLength",MinLength);
			if (MinLengthNumber != MinLengthNumber_DefaultValue) h.Add("minLength",MinLengthNumber);
			if (MinorGridLineColor != MinorGridLineColor_DefaultValue) h.Add("minorGridLineColor",MinorGridLineColor);
			if (MinorGridLineDashStyle != MinorGridLineDashStyle_DefaultValue) h.Add("minorGridLineDashStyle", Highstock.FirstCharacterToLower(MinorGridLineDashStyle.ToString()));
			if (MinorGridLineWidth != MinorGridLineWidth_DefaultValue) h.Add("minorGridLineWidth",MinorGridLineWidth);
			if (MinorTickColor != MinorTickColor_DefaultValue) h.Add("minorTickColor",MinorTickColor);
			if (MinorTickInterval != MinorTickInterval_DefaultValue) h.Add("minorTickInterval",MinorTickInterval);
			if (MinorTickIntervalNumber != MinorTickIntervalNumber_DefaultValue) h.Add("minorTickInterval",MinorTickIntervalNumber);
			if (MinorTickLength != MinorTickLength_DefaultValue) h.Add("minorTickLength",MinorTickLength);
			if (MinorTickPosition != MinorTickPosition_DefaultValue) h.Add("minorTickPosition", Highstock.FirstCharacterToLower(MinorTickPosition.ToString()));
			if (MinorTicks != MinorTicks_DefaultValue) h.Add("minorTicks",MinorTicks);
			if (MinorTickWidth != MinorTickWidth_DefaultValue) h.Add("minorTickWidth",MinorTickWidth);
			if (MinPadding != MinPadding_DefaultValue) h.Add("minPadding",MinPadding);
			if (MinRange != MinRange_DefaultValue) h.Add("minRange",MinRange);
			if (MinTickInterval != MinTickInterval_DefaultValue) h.Add("minTickInterval",MinTickInterval);
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			if (Opposite != Opposite_DefaultValue) h.Add("opposite",Opposite);
			if (PlotBands != PlotBands_DefaultValue) h.Add("plotBands", HashifyList(PlotBands));
			if (PlotLines != PlotLines_DefaultValue) h.Add("plotLines", HashifyList(PlotLines));
			if (Range != Range_DefaultValue) h.Add("range",Range);
			if (Resize.IsDirty()) h.Add("resize",Resize.ToHashtable());
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (ReversedStacks != ReversedStacks_DefaultValue) h.Add("reversedStacks",ReversedStacks);
			if (Scrollbar.IsDirty()) h.Add("scrollbar",Scrollbar.ToHashtable());
			if (ShowEmpty != ShowEmpty_DefaultValue) h.Add("showEmpty",ShowEmpty);
			if (ShowFirstLabel != ShowFirstLabel_DefaultValue) h.Add("showFirstLabel",ShowFirstLabel);
			if (ShowLastLabel != ShowLastLabel_DefaultValue) h.Add("showLastLabel",ShowLastLabel);
			if (SoftMax != SoftMax_DefaultValue) h.Add("softMax",SoftMax);
			if (SoftMin != SoftMin_DefaultValue) h.Add("softMin",SoftMin);
			if (StartOfWeek != StartOfWeek_DefaultValue) h.Add("startOfWeek",StartOfWeek);
			if (StartOnTick != StartOnTick_DefaultValue) h.Add("startOnTick",StartOnTick);
			if (TickAmount != TickAmount_DefaultValue) h.Add("tickAmount",TickAmount);
			if (TickColor != TickColor_DefaultValue) h.Add("tickColor",TickColor);
			if (TickInterval != TickInterval_DefaultValue) h.Add("tickInterval",TickInterval);
			if (TickLength != TickLength_DefaultValue) h.Add("tickLength",TickLength);
			if (TickPixelInterval != TickPixelInterval_DefaultValue) h.Add("tickPixelInterval",TickPixelInterval);
			if (TickPosition != TickPosition_DefaultValue) h.Add("tickPosition", Highstock.FirstCharacterToLower(TickPosition.ToString()));
			if (TickPositioner != TickPositioner_DefaultValue) { h.Add("tickPositioner",TickPositioner); Highstock.AddFunction("YAxisTickPositioner.tickPositioner", TickPositioner); }  
			if (TickPositions != TickPositions_DefaultValue) h.Add("tickPositions",TickPositions);
			if (TickWidth != TickWidth_DefaultValue) h.Add("tickWidth",TickWidth);
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (TooltipValueFormat != TooltipValueFormat_DefaultValue) h.Add("tooltipValueFormat",TooltipValueFormat);
			if (Top != Top_DefaultValue) h.Add("top",Top);
			if (TopNumber != TopNumber_DefaultValue) h.Add("top",TopNumber);
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
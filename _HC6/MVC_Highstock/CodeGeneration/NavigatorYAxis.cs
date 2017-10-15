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
	public partial class NavigatorYAxis  : BaseObject
	{
		public NavigatorYAxis()
		{
			ClassName = ClassName_DefaultValue = "highcharts-navigator-yaxis";
			GridLineWidth = GridLineWidth_DefaultValue = null;
			StartOnTick = StartOnTick_DefaultValue = null;
			EndOnTick = EndOnTick_DefaultValue = null;
			MinPadding = MinPadding_DefaultValue = null;
			MaxPadding = MaxPadding_DefaultValue = null;
			Labels = Labels_DefaultValue = new NavigatorYAxisLabels();
			Crosshair = Crosshair_DefaultValue = new NavigatorYAxisCrosshair();
			Title = Title_DefaultValue = new NavigatorYAxisTitle();
			TickLength = TickLength_DefaultValue = null;
			TickWidth = TickWidth_DefaultValue = null;
			MinLength = MinLength_DefaultValue = "10%";
			MaxLength = MaxLength_DefaultValue = "100%";
			Resize = Resize_DefaultValue = new NavigatorYAxisResize();
			TooltipValueFormat = TooltipValueFormat_DefaultValue = "undefined";
			TickPixelInterval = TickPixelInterval_DefaultValue = null;
			ShowLastLabel = ShowLastLabel_DefaultValue = false;
			LineWidth = LineWidth_DefaultValue = 0;
			Min = Min_DefaultValue = null;
			ReversedStacks = ReversedStacks_DefaultValue = true;
			PlotBands = PlotBands_DefaultValue = new NavigatorYAxisPlotBands();
			PlotLines = PlotLines_DefaultValue = new NavigatorYAxisPlotLines();
			Opposite = Opposite_DefaultValue = true;
			SoftMax = SoftMax_DefaultValue = null;
			SoftMin = SoftMin_DefaultValue = null;
			DateTimeLabelFormats = DateTimeLabelFormats_DefaultValue = new NavigatorYAxisDateTimeLabelFormats();
			MinorTickLength = MinorTickLength_DefaultValue = 2;
			MinorTickPosition = MinorTickPosition_DefaultValue = NavigatorYAxisMinorTickPosition.Outside;
			StartOfWeek = StartOfWeek_DefaultValue = 1;
			TickPosition = TickPosition_DefaultValue = NavigatorYAxisTickPosition.Outside;
			MinorGridLineColor = MinorGridLineColor_DefaultValue = "#f2f2f2";
			MinorGridLineWidth = MinorGridLineWidth_DefaultValue = 1;
			MinorTickColor = MinorTickColor_DefaultValue = "#999999";
			LineColor = LineColor_DefaultValue = "#ccd6eb";
			GridLineColor = GridLineColor_DefaultValue = "#e6e6e6";
			TickColor = TickColor_DefaultValue = "#ccd6eb";
			Overscroll = Overscroll_DefaultValue = 0;
			AllowDecimals = AllowDecimals_DefaultValue = true;
			AlternateGridColor = AlternateGridColor_DefaultValue = "null";
			Ceiling = Ceiling_DefaultValue = null;
			Description = Description_DefaultValue = "undefined";
			Floor = Floor_DefaultValue = null;
			GridLineDashStyle = GridLineDashStyle_DefaultValue = NavigatorYAxisGridLineDashStyle.Solid;
			GridZIndex = GridZIndex_DefaultValue = 1;
			Id = Id_DefaultValue = "null";
			Max = Max_DefaultValue = null;
			MinTickInterval = MinTickInterval_DefaultValue = null;
			MinorGridLineDashStyle = MinorGridLineDashStyle_DefaultValue = NavigatorYAxisMinorGridLineDashStyle.Solid;
			MinorTickInterval = MinorTickInterval_DefaultValue = null;
			MinorTicks = MinorTicks_DefaultValue = false;
			MinorTickWidth = MinorTickWidth_DefaultValue = 0;
			Offset = Offset_DefaultValue = 0;
			Reversed = Reversed_DefaultValue = false;
			ShowFirstLabel = ShowFirstLabel_DefaultValue = true;
			TickAmount = TickAmount_DefaultValue = null;
			TickInterval = TickInterval_DefaultValue = null;
			TickPositioner = TickPositioner_DefaultValue = "";
			TickPositions = TickPositions_DefaultValue = null;
			Visible = Visible_DefaultValue = true;
			Breaks = Breaks_DefaultValue = new NavigatorYAxisBreaks();
			Events = Events_DefaultValue = new NavigatorYAxisEvents();
			
		}	
		

		/// <summary>
		/// <p>A class name that opens for styling the axis by CSS, especially inHighcharts styled mode. The class name is applied to group elementsfor the grid, axis elements and labels.</p>
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the grid lines extending the ticks across the plotarea.</p>
		/// </summary>
		public double? GridLineWidth { get; set; }
		private double? GridLineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to force the axis to start on a tick. Use this option withthe <code>maxPadding</code> option to control the axis start.</p>
		/// </summary>
		public bool? StartOnTick { get; set; }
		private bool? StartOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to force the axis to end on a tick. Use this option withthe <code>maxPadding</code> option to control the axis end.</p>
		/// </summary>
		public bool? EndOnTick { get; set; }
		private bool? EndOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Padding of the min value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer. This is usefulwhen you don&#39;t want the lowest data value to appear on the edgeof the plot area. When the axis&#39; <code>min</code> option is set or a max extremeis set using <code>axis.setExtremes()</code>, the maxPadding will be ignored.</p>
		/// </summary>
		public double? MinPadding { get; set; }
		private double? MinPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Padding of the max value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer. This is usefulwhen you don&#39;t want the highest data value to appear on the edgeof the plot area. When the axis&#39; <code>max</code> option is set or a max extremeis set using <code>axis.setExtremes()</code>, the maxPadding will be ignored.</p>
		/// </summary>
		public double? MaxPadding { get; set; }
		private double? MaxPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The axis labels show the number or category for each tick.</p>
		/// </summary>
		public NavigatorYAxisLabels Labels { get; set; }
		private NavigatorYAxisLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Configure a crosshair that follows either the mouse pointer or thehovered point.</p><p>In styled mode, the crosshairs are styled in the <code>.highcharts-crosshair</code>, <code>.highcharts-crosshair-thin</code> or <code>.highcharts-xaxis-category</code>classes.</p>
		/// </summary>
		public NavigatorYAxisCrosshair Crosshair { get; set; }
		private NavigatorYAxisCrosshair Crosshair_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The axis title, showing next to the axis line.</p>
		/// </summary>
		public NavigatorYAxisTitle Title { get; set; }
		private NavigatorYAxisTitle Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel length of the main tick marks.</p>
		/// </summary>
		public double? TickLength { get; set; }
		private double? TickLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel width of the major tick marks.</p>
		/// </summary>
		public double? TickWidth { get; set; }
		private double? TickWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Minimal size of a resizable axis. Could be set as a percentof plot area or pixel size.</p><p>This feature requires the <code>drag-panes.js</code> module.</p>
		/// </summary>
		public string MinLength { get; set; }
		private string MinLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Maximal size of a resizable axis. Could be set as a percentof plot area or pixel size.</p><p>This feature requires the <code>drag-panes.js</code> module.</p>
		/// </summary>
		public string MaxLength { get; set; }
		private string MaxLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for axis resizing for Drag Panes module.</p><p>This feature requires the <code>drag-panes.js</code> module.</p>
		/// </summary>
		public NavigatorYAxisResize Resize { get; set; }
		private NavigatorYAxisResize Resize_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Parallel coordinates only. Format that will be used for point.yand available in <a href="#tooltip.pointFormat">tooltip.pointFormat</a> as<code>{point.formattedValue}</code>. If not set, <code>{point.formattedValue}</code>will use other options, in this order:</p><ol><li><a href="#yAxis.labels.format">yAxis.labels.format</a> will be used ifset</li><li>if yAxis is a category, then category name will be displayed</li><li>if yAxis is a datetime, then value will use the same format asyAxis labels</li><li>if yAxis is linear/logarithmic type, then simple value will beused</li></ol>
		/// </summary>
		public string TooltipValueFormat { get; set; }
		private string TooltipValueFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If tickInterval is <code>null</code> this option sets the approximate pixelinterval of the tick marks. Not applicable to categorized axis.</p><p>The tick interval is also influenced by the <a href="#xAxis.minTickInterval">minTickInterval</a> option, that, by default prevents ticks from beingdenser than the data points.</p><p>Defaults to <code>72</code> for the Y axis and <code>100</code> for the X axis.</p>
		/// </summary>
		public double? TickPixelInterval { get; set; }
		private double? TickPixelInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to show the last tick label. Defaults to <code>true</code> on cartesiancharts, and <code>false</code> on polar charts.</p>
		/// </summary>
		public bool? ShowLastLabel { get; set; }
		private bool? ShowLastLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the line marking the axis itself.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The minimum value of the axis. If <code>null</code> the min value is automaticallycalculated.</p><p>If the <code>startOnTick</code> option is true (default), the <code>min</code> value mightbe rounded down.</p><p>The automatically calculated minimum value is also affected by <a href="#yAxis.floor">floor</a>, <a href="#yAxis.softMin">softMin</a>, <a href="#yAxis.minPadding">minPadding</a>,<a href="#yAxis.minRange">minRange</a> as well as <a href="#plotOptions.series.threshold">series.threshold</a> and <a href="#plotOptions.series.softThreshold">series.softThreshold</a>.</p>
		/// </summary>
		public double? Min { get; set; }
		private double? Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If <code>true</code>, the first series in a stack will be drawn on top in apositive, non-reversed Y axis. If <code>false</code>, the first series is inthe base of the stack.</p>
		/// </summary>
		public bool? ReversedStacks { get; set; }
		private bool? ReversedStacks_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array of objects defining plot bands on the Y axis.</p>
		/// </summary>
		public NavigatorYAxisPlotBands PlotBands { get; set; }
		private NavigatorYAxisPlotBands PlotBands_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array of objects representing plot lines on the X axis</p>
		/// </summary>
		public NavigatorYAxisPlotLines PlotLines { get; set; }
		private NavigatorYAxisPlotLines PlotLines_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to display the axis on the opposite side of the normal. Thenormal is on the left side for vertical axes and bottom for horizontal,so the opposite sides will be right and top respectively. In Highstock1.x, the Y axis was placed on the left side by default.</p>
		/// </summary>
		public bool? Opposite { get; set; }
		private bool? Opposite_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A soft maximum for the axis. If the series data maximum is greaterthan this, the axis will stay at this maximum, but if the seriesdata maximum is higher, the axis will flex to show all data.</p>
		/// </summary>
		public double? SoftMax { get; set; }
		private double? SoftMax_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A soft minimum for the axis. If the series data minimum is greaterthan this, the axis will stay at this minimum, but if the seriesdata minimum is lower, the axis will flex to show all data.</p>
		/// </summary>
		public double? SoftMin { get; set; }
		private double? SoftMin_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For a datetime axis, the scale will automatically adjust to theappropriate unit. This member gives the default stringrepresentations used for each unit. For intermediate values,different units may be used, for example the <code>day</code> unit can be usedon midnight and <code>hour</code> unit be used for intermediate values on thesame axis. For an overview of the replacement codes, see<a href="#Highcharts.dateFormat">dateFormat</a>. Defaults to:</p><pre>{    millisecond: '%H:%M:%S.%L',    second: '%H:%M:%S',    minute: '%H:%M',    hour: '%H:%M',    day: '%e. %b',    week: '%e. %b',    month: '%b \'%y',    year: '%Y'}</pre>
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormats DateTimeLabelFormats { get; set; }
		private NavigatorYAxisDateTimeLabelFormats DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel length of the minor tick marks.</p>
		/// </summary>
		public double? MinorTickLength { get; set; }
		private double? MinorTickLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The position of the minor tick marks relative to the axis line. Can be one of <code>inside</code> and <code>outside</code>.</p>
		/// </summary>
		public NavigatorYAxisMinorTickPosition MinorTickPosition { get; set; }
		private NavigatorYAxisMinorTickPosition MinorTickPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For datetime axes, this decides where to put the tick between weeks. 0 = Sunday, 1 = Monday.</p>
		/// </summary>
		public double? StartOfWeek { get; set; }
		private double? StartOfWeek_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The position of the major tick marks relative to the axis line. Can be one of <code>inside</code> and <code>outside</code>.</p>
		/// </summary>
		public NavigatorYAxisTickPosition TickPosition { get; set; }
		private NavigatorYAxisTickPosition TickPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Color of the minor, secondary grid lines.</p><p>In styled mode, the stroke width is given in the<code>.highcharts-minor-grid-line</code> class.</p>
		/// </summary>
		public string MinorGridLineColor { get; set; }
		private string MinorGridLineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Width of the minor, secondary grid lines.</p><p>In styled mode, the stroke width is given in the<code>.highcharts-grid-line</code> class.</p>
		/// </summary>
		public double? MinorGridLineWidth { get; set; }
		private double? MinorGridLineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Color for the minor tick marks.</p>
		/// </summary>
		public string MinorTickColor { get; set; }
		private string MinorTickColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the line marking the axis itself.</p><p>In styled mode, the line stroke is given in the<code>.highcharts-axis-line</code> or <code>.highcharts-xaxis-line</code> class.</p>
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Color of the grid lines extending the ticks across the plot area.</p><p>In styled mode, the stroke is given in the <code>.highcharts-grid-line</code>class.</p>
		/// </summary>
		public string GridLineColor { get; set; }
		private string GridLineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Color for the main tick marks.</p><p>In styled mode, the stroke is given in the <code>.highcharts-tick</code>class.</p>
		/// </summary>
		public string TickColor { get; set; }
		private string TickColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Additional range on the right side of the xAxis. Works similar to<code>xAxis.maxPadding</code>, but value is set in milliseconds. Can be set for bothmain <code>xAxis</code> and the navigator&#39;s <code>xAxis</code>.</p>
		/// </summary>
		public double? Overscroll { get; set; }
		private double? Overscroll_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to allow decimals in this axis&#39; ticks. When counting integers,like persons or hits on a web page, decimals should be avoided inthe labels.</p>
		/// </summary>
		public bool? AllowDecimals { get; set; }
		private bool? AllowDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When using an alternate grid color, a band is painted across theplot area between every other grid line.</p>
		/// </summary>
		public string AlternateGridColor { get; set; }
		private string AlternateGridColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The highest allowed value for automatically computed axis extremes.</p>
		/// </summary>
		public double? Ceiling { get; set; }
		private double? Ceiling_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p><em>Requires Accessibility module</em></p><p>Description of the axis to screen reader users.</p>
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The lowest allowed value for automatically computed axis extremes.</p>
		/// </summary>
		public double? Floor { get; set; }
		private double? Floor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The dash or dot style of the grid lines. For possible values, see<a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/">this demonstration</a>.</p>
		/// </summary>
		public NavigatorYAxisGridLineDashStyle GridLineDashStyle { get; set; }
		private NavigatorYAxisGridLineDashStyle GridLineDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The Z index of the grid lines.</p>
		/// </summary>
		public double? GridZIndex { get; set; }
		private double? GridZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An id for the axis. This can be used after render time to get a pointerto the axis object through <code>chart.get()</code>.</p>
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The maximum value of the axis. If <code>null</code>, the max value is automaticallycalculated. If the <code>endOnTick</code> option is true, the <code>max</code> value mightbe rounded up.</p><p>If a <a href="#yAxis.tickAmount">tickAmount</a> is set, the axis may be extendedbeyond the set max in order to reach the given number of ticks. Thesame may happen in a chart with multiple axes, determined by <a href="#chart">chart.alignTicks</a>, where a <code>tickAmount</code> is applied internally.</p>
		/// </summary>
		public double? Max { get; set; }
		private double? Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The minimum tick interval allowed in axis values. For example onzooming in on an axis with daily data, this can be used to preventthe axis from showing hours. Defaults to the closest distance betweentwo points on the axis.</p>
		/// </summary>
		public double? MinTickInterval { get; set; }
		private double? MinTickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The dash or dot style of the minor grid lines. For possible values,see <a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/">this demonstration</a>.</p>
		/// </summary>
		public NavigatorYAxisMinorGridLineDashStyle MinorGridLineDashStyle { get; set; }
		private NavigatorYAxisMinorGridLineDashStyle MinorGridLineDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Specific tick interval in axis units for the minor ticks. On a linear axis,if <code>&quot;auto&quot;</code>, the minor tick interval is calculated as a fifth ofthe tickInterval. If <code>null</code>, minor ticks are not shown.</p><p>On logarithmic axes, the unit is the power of the value. For example,setting the minorTickInterval to 1 puts one tick on each of 0.1,1, 10, 100 etc. Setting the minorTickInterval to 0.1 produces 9ticks between 1 and 10, 10 and 100 etc.</p><p>If user settings dictate minor ticks to become too dense, they don&#39;tmake sense, and will be ignored to prevent performance problems.</p>
		/// </summary>
		public double? MinorTickInterval { get; set; }
		private double? MinorTickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable minor ticks. Unless<a href="#xAxis.minorTickInterval">minorTickInterval</a> is set, the tick interval iscalculated as a fifth of the <code>tickInterval</code>.</p><p>On a logarithmic axis, minor ticks are laid out based on a best guess,attempting to enter approximately 5 minor ticks between each major tick.</p><p>Prior to v6.0.0, ticks were unabled in auto layout by setting<code>minorTickInterval</code> to <code>&quot;auto&quot;</code>.</p>
		/// </summary>
		public bool? MinorTicks { get; set; }
		private bool? MinorTicks_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel width of the minor tick mark.</p>
		/// </summary>
		public double? MinorTickWidth { get; set; }
		private double? MinorTickWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The distance in pixels from the plot area to the axis line. A positiveoffset moves the axis with it&#39;s line, labels and ticks away fromthe plot area. This is typically used when two or more axes are displayedon the same side of the plot. With multiple axes the offset is dynamicallyadjusted to avoid collision, this can be overridden by setting offsetexplicitly.</p>
		/// </summary>
		public double? Offset { get; set; }
		private double? Offset_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to reverse the axis so that the highest number is closestto the origin. If the chart is inverted, the x axis is reversed bydefault.</p>
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to show the first tick label.</p>
		/// </summary>
		public bool? ShowFirstLabel { get; set; }
		private bool? ShowFirstLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The amount of ticks to draw on the axis. This opens up for aligningthe ticks of multiple charts or panes within a chart. This optionoverrides the <code>tickPixelInterval</code> option.</p><p>This option only has an effect on linear axes. Datetime, logarithmicor category axes are not affected.</p>
		/// </summary>
		public double? TickAmount { get; set; }
		private double? TickAmount_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The interval of the tick marks in axis units. When <code>null</code>, the tickinterval is computed to approximately follow the <a href="#xAxis.tickPixelInterval">tickPixelInterval</a> on linear and datetime axes. On categorized axes,a <code>null</code> tickInterval will default to 1, one category. Note thatdatetime axes are based on milliseconds, so for example an intervalof one day is expressed as <code>24 * 3600 * 1000</code>.</p><p>On logarithmic axes, the tickInterval is based on powers, so a tickIntervalof 1 means one tick on each of 0.1, 1, 10, 100 etc. A tickIntervalof 2 means a tick of 0.1, 10, 1000 etc. A tickInterval of 0.2 putsa tick on 0.1, 0.2, 0.4, 0.6, 0.8, 1, 2, 4, 6, 8, 10, 20, 40 etc.</p><p>If the tickInterval is too dense for labels to be drawn, Highchartsmay remove ticks.</p><p>If the chart has multiple axes, the <a href="#chart.alignTicks">alignTicks</a>option may interfere with the <code>tickInterval</code> setting.</p>
		/// </summary>
		public double? TickInterval { get; set; }
		private double? TickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A callback function returning array defining where the ticks arelaid out on the axis. This overrides the default behaviour of <a href="#xAxis.tickPixelInterval">tickPixelInterval</a> and <a href="#xAxis.tickInterval">tickInterval</a>. The automatictick positions are accessible through <code>this.tickPositions</code> and canbe modified by the callback.</p>
		/// </summary>
		public string TickPositioner { get; set; }
		private string TickPositioner_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array defining where the ticks are laid out on the axis. Thisoverrides the default behaviour of <a href="#xAxis.tickPixelInterval">tickPixelInterval</a>and <a href="#xAxis.tickInterval">tickInterval</a>.</p>
		/// </summary>
		public List<double> TickPositions { get; set; }
		private List<double> TickPositions_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether axis, including axis title, line, ticks and labels, shouldbe visible.</p>
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array defining breaks in the axis, the sections defined will beleft out and all the points shifted closer to each other.</p>
		/// </summary>
		public NavigatorYAxisBreaks Breaks { get; set; }
		private NavigatorYAxisBreaks Breaks_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Event handlers for the axis.</p>
		/// </summary>
		public NavigatorYAxisEvents Events { get; set; }
		private NavigatorYAxisEvents Events_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (GridLineWidth != GridLineWidth_DefaultValue) h.Add("gridLineWidth",GridLineWidth);
			if (StartOnTick != StartOnTick_DefaultValue) h.Add("startOnTick",StartOnTick);
			if (EndOnTick != EndOnTick_DefaultValue) h.Add("endOnTick",EndOnTick);
			if (MinPadding != MinPadding_DefaultValue) h.Add("minPadding",MinPadding);
			if (MaxPadding != MaxPadding_DefaultValue) h.Add("maxPadding",MaxPadding);
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (Crosshair.IsDirty()) h.Add("crosshair",Crosshair.ToHashtable());
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (TickLength != TickLength_DefaultValue) h.Add("tickLength",TickLength);
			if (TickWidth != TickWidth_DefaultValue) h.Add("tickWidth",TickWidth);
			if (MinLength != MinLength_DefaultValue) h.Add("minLength",MinLength);
			if (MaxLength != MaxLength_DefaultValue) h.Add("maxLength",MaxLength);
			if (Resize.IsDirty()) h.Add("resize",Resize.ToHashtable());
			if (TooltipValueFormat != TooltipValueFormat_DefaultValue) h.Add("tooltipValueFormat",TooltipValueFormat);
			if (TickPixelInterval != TickPixelInterval_DefaultValue) h.Add("tickPixelInterval",TickPixelInterval);
			if (ShowLastLabel != ShowLastLabel_DefaultValue) h.Add("showLastLabel",ShowLastLabel);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (ReversedStacks != ReversedStacks_DefaultValue) h.Add("reversedStacks",ReversedStacks);
			if (PlotBands.IsDirty()) h.Add("plotBands",PlotBands.ToHashtable());
			if (PlotLines.IsDirty()) h.Add("plotLines",PlotLines.ToHashtable());
			if (Opposite != Opposite_DefaultValue) h.Add("opposite",Opposite);
			if (SoftMax != SoftMax_DefaultValue) h.Add("softMax",SoftMax);
			if (SoftMin != SoftMin_DefaultValue) h.Add("softMin",SoftMin);
			if (DateTimeLabelFormats.IsDirty()) h.Add("dateTimeLabelFormats",DateTimeLabelFormats.ToHashtable());
			if (MinorTickLength != MinorTickLength_DefaultValue) h.Add("minorTickLength",MinorTickLength);
			if (MinorTickPosition != MinorTickPosition_DefaultValue) h.Add("minorTickPosition", Highstock.FirstCharacterToLower(MinorTickPosition.ToString()));
			if (StartOfWeek != StartOfWeek_DefaultValue) h.Add("startOfWeek",StartOfWeek);
			if (TickPosition != TickPosition_DefaultValue) h.Add("tickPosition", Highstock.FirstCharacterToLower(TickPosition.ToString()));
			if (MinorGridLineColor != MinorGridLineColor_DefaultValue) h.Add("minorGridLineColor",MinorGridLineColor);
			if (MinorGridLineWidth != MinorGridLineWidth_DefaultValue) h.Add("minorGridLineWidth",MinorGridLineWidth);
			if (MinorTickColor != MinorTickColor_DefaultValue) h.Add("minorTickColor",MinorTickColor);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (GridLineColor != GridLineColor_DefaultValue) h.Add("gridLineColor",GridLineColor);
			if (TickColor != TickColor_DefaultValue) h.Add("tickColor",TickColor);
			if (Overscroll != Overscroll_DefaultValue) h.Add("overscroll",Overscroll);
			if (AllowDecimals != AllowDecimals_DefaultValue) h.Add("allowDecimals",AllowDecimals);
			if (AlternateGridColor != AlternateGridColor_DefaultValue) h.Add("alternateGridColor",AlternateGridColor);
			if (Ceiling != Ceiling_DefaultValue) h.Add("ceiling",Ceiling);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Floor != Floor_DefaultValue) h.Add("floor",Floor);
			if (GridLineDashStyle != GridLineDashStyle_DefaultValue) h.Add("gridLineDashStyle", Highstock.FirstCharacterToLower(GridLineDashStyle.ToString()));
			if (GridZIndex != GridZIndex_DefaultValue) h.Add("gridZIndex",GridZIndex);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (MinTickInterval != MinTickInterval_DefaultValue) h.Add("minTickInterval",MinTickInterval);
			if (MinorGridLineDashStyle != MinorGridLineDashStyle_DefaultValue) h.Add("minorGridLineDashStyle", Highstock.FirstCharacterToLower(MinorGridLineDashStyle.ToString()));
			if (MinorTickInterval != MinorTickInterval_DefaultValue) h.Add("minorTickInterval",MinorTickInterval);
			if (MinorTicks != MinorTicks_DefaultValue) h.Add("minorTicks",MinorTicks);
			if (MinorTickWidth != MinorTickWidth_DefaultValue) h.Add("minorTickWidth",MinorTickWidth);
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (ShowFirstLabel != ShowFirstLabel_DefaultValue) h.Add("showFirstLabel",ShowFirstLabel);
			if (TickAmount != TickAmount_DefaultValue) h.Add("tickAmount",TickAmount);
			if (TickInterval != TickInterval_DefaultValue) h.Add("tickInterval",TickInterval);
			if (TickPositioner != TickPositioner_DefaultValue) { h.Add("tickPositioner",TickPositioner); Highstock.AddFunction("NavigatorYAxisTickPositioner.tickPositioner", TickPositioner); }  
			if (TickPositions != TickPositions_DefaultValue) h.Add("tickPositions",TickPositions);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (Breaks.IsDirty()) h.Add("breaks",Breaks.ToHashtable());
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			

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
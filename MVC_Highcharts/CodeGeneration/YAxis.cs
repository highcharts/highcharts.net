using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highcharts.Web.Mvc
{
	public partial class YAxis  : BaseObject
	{
		public YAxis()
		{
			AllowDecimals = AllowDecimals_DefaultValue = true;
			AlternateGridColor = AlternateGridColor_DefaultValue = null;
			Breaks = Breaks_DefaultValue = new YAxisBreaks();
			Categories = Categories_DefaultValue = null;
			Ceiling = Ceiling_DefaultValue = null;
			DateTimeLabelFormats = DateTimeLabelFormats_DefaultValue = new NameValueCollection();
			EndOnTick = EndOnTick_DefaultValue = true;
			Events = Events_DefaultValue = new YAxisEvents();
			Floor = Floor_DefaultValue = null;
			GridLineColor = GridLineColor_DefaultValue = "#D8D8D8";
			GridLineDashStyle = GridLineDashStyle_DefaultValue = YAxisGridLineDashStyle.Solid;
			GridLineInterpolation = GridLineInterpolation_DefaultValue = YAxisGridLineInterpolation.Null;
			GridLineWidth = GridLineWidth_DefaultValue = 1;
			GridZIndex = GridZIndex_DefaultValue = 1;
			Id = Id_DefaultValue = null;
			Labels = Labels_DefaultValue = new YAxisLabels();
			LineColor = LineColor_DefaultValue = "#C0D0E0";
			LineWidth = LineWidth_DefaultValue = 0;
			LinkedTo = LinkedTo_DefaultValue = null;
			Max = Max_DefaultValue = null;
			MaxColor = MaxColor_DefaultValue = "#102D4C";
			MaxPadding = MaxPadding_DefaultValue = 0.05;
			Min = Min_DefaultValue = null;
			MinColor = MinColor_DefaultValue = "#EFEFFF";
			MinPadding = MinPadding_DefaultValue = 0.05;
			MinRange = MinRange_DefaultValue = null;
			MinTickInterval = MinTickInterval_DefaultValue = null;
			MinorGridLineColor = MinorGridLineColor_DefaultValue = "#E0E0E0";
			MinorGridLineDashStyle = MinorGridLineDashStyle_DefaultValue = YAxisMinorGridLineDashStyle.Solid;
			MinorGridLineWidth = MinorGridLineWidth_DefaultValue = 1;
			MinorTickColor = MinorTickColor_DefaultValue = "#A0A0A0";
			MinorTickInterval = MinorTickInterval_DefaultValue = null;
			MinorTickLength = MinorTickLength_DefaultValue = 2;
			MinorTickPosition = MinorTickPosition_DefaultValue = YAxisMinorTickPosition.Outside;
			MinorTickWidth = MinorTickWidth_DefaultValue = 0;
			Offset = Offset_DefaultValue = 0;
			Opposite = Opposite_DefaultValue = false;
			PlotBands = PlotBands_DefaultValue = new List<YAxisPlotBands>();
			PlotLines = PlotLines_DefaultValue = new List<YAxisPlotLines>();
			Reversed = Reversed_DefaultValue = false;
			ReversedStacks = ReversedStacks_DefaultValue = true;
			ShowEmpty = ShowEmpty_DefaultValue = true;
			ShowFirstLabel = ShowFirstLabel_DefaultValue = true;
			ShowLastLabel = ShowLastLabel_DefaultValue = true;
			StackLabels = StackLabels_DefaultValue = new YAxisStackLabels();
			StartOfWeek = StartOfWeek_DefaultValue = 1;
			StartOnTick = StartOnTick_DefaultValue = true;
			Stops = Stops_DefaultValue = null;
			TickAmount = TickAmount_DefaultValue = null;
			TickColor = TickColor_DefaultValue = "#C0D0E0";
			TickInterval = TickInterval_DefaultValue = null;
			TickLength = TickLength_DefaultValue = 10;
			TickPixelInterval = TickPixelInterval_DefaultValue = null;
			TickPosition = TickPosition_DefaultValue = YAxisTickPosition.Outside;
			TickPositioner = TickPositioner_DefaultValue = "";
			TickPositions = TickPositions_DefaultValue = null;
			TickWidth = TickWidth_DefaultValue = 0;
			TickmarkPlacement = TickmarkPlacement_DefaultValue = YAxisTickmarkPlacement.Null;
			Title = Title_DefaultValue = new YAxisTitle();
			Type = Type_DefaultValue = YAxisType.Linear;
			
		}	
		

		/// <summary>
		/// Whether to allow decimals in this axis' ticks. When counting integers, like persons or hits on a web page, decimals must be avoided in the axis tick labels.
		/// </summary>
		public bool? AllowDecimals { get; set; }
		private bool? AllowDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using an alternate grid color, a band is painted across the plot area between every other grid line.
		/// </summary>
		public string AlternateGridColor { get; set; }
		private string AlternateGridColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining breaks in the axis, the sections defined will be left out and all the points shifted closer to each other. Requires that the broken-axis.js module is loaded.
		/// </summary>
		public YAxisBreaks Breaks { get; set; }
		private YAxisBreaks Breaks_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If categories are present for the xAxis, names are used instead of numbers for that axis. Since Highcharts 3.0, categories can also be extracted by giving each point a <a href="#series.data">name</a> and setting axis <a href="#xAxis.type">type</a> to <code>category</code>. However, if you have multiple series, best practice remains defining the <code>categories</code> array.</p><p>Example:<pre>categories: ['Apples', 'Bananas', 'Oranges']</pre> Defaults to <code>null</code></p>
		/// </summary>
		public List<string> Categories { get; set; }
		private List<string> Categories_DefaultValue { get; set; }
		 

		/// <summary>
		/// The highest allowed value for automatically computed axis extremes.
		/// </summary>
		public double? Ceiling { get; set; }
		private double? Ceiling_DefaultValue { get; set; }
		 

		/// <summary>
		/// For a datetime axis, the scale will automatically adjust to the appropriate unit. This member gives the default string representations used for each unit. For an overview of the replacement codes, see dateFormat. Defaults to:<pre>{millisecond: '%H:%M:%S.%L',second: '%H:%M:%S',minute: '%H:%M',hour: '%H:%M',day: '%e. %b',week: '%e. %b',month: '%b \'%y',year: '%Y'}</pre>
		/// </summary>
		public NameValueCollection DateTimeLabelFormats { get; set; }
		private NameValueCollection DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to end on a tick. Use this option with the <code>maxPadding</code> option to control the axis end.
		/// </summary>
		public bool? EndOnTick { get; set; }
		private bool? EndOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisEvents Events { get; set; }
		private YAxisEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lowest allowed value for automatically computed axis extremes.
		/// </summary>
		public double? Floor { get; set; }
		private double? Floor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the grid lines extending the ticks across the plot area.
		/// </summary>
		public string GridLineColor { get; set; }
		private string GridLineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash or dot style of the grid lines. For possible values, see <a href="http://jsfiddle.net/gh/get/jquery/1.7.2/highslide-software/highcharts.com/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/">this demonstration</a>.
		/// </summary>
		public YAxisGridLineDashStyle GridLineDashStyle { get; set; }
		private YAxisGridLineDashStyle GridLineDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Polar charts only. Whether the grid lines should draw as a polygon with straight lines between categories, or as circles. Can be either <code>circle</code> or <code>polygon</code>.
		/// </summary>
		public YAxisGridLineInterpolation GridLineInterpolation { get; set; }
		private YAxisGridLineInterpolation GridLineInterpolation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the grid lines extending the ticks across the plot area.
		/// </summary>
		public double? GridLineWidth { get; set; }
		private double? GridLineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the grid lines.
		/// </summary>
		public double? GridZIndex { get; set; }
		private double? GridZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the axis. This can be used after render time to get a pointer to the axis object through <code>chart.get()</code>.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisLabels Labels { get; set; }
		private YAxisLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the line marking the axis itself.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the line marking the axis itself.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Index of another axis that this axis is linked to. When an axis is linked to a master axis, it will take the same extremes as the master, but as assigned by min or max or by setExtremes. It can be used to show additional info, or to ease reading the chart by duplicating the scales.
		/// </summary>
		public double? LinkedTo { get; set; }
		private double? LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The maximum value of the axis. If <code>null</code>, the max value is automatically calculated. If the <code>endOnTick</code> option is true, the <code>max</code> value might be rounded up. The actual maximum value is also influenced by  <a class="internal" href="#chart">chart.alignTicks</a>.
		/// </summary>
		public double? Max { get; set; }
		private double? Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// Solid gauge only. Unless <a href="#yAxis.stops">stops</a> are set, the color to represent the maximum value of the Y axis.
		/// </summary>
		public string MaxColor { get; set; }
		private string MaxColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the max value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the highest data value to appear on the edge of the plot area.
		/// </summary>
		public double? MaxPadding { get; set; }
		private double? MaxPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum value of the axis. If <code>null</code> the min value is automatically calculated. If the <code>startOnTick</code> option is true, the <code>min</code> value might be rounded down.
		/// </summary>
		public double? Min { get; set; }
		private double? Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// Solid gauge only. Unless <a href="#yAxis.stops">stops</a> are set, the color to represent the minimum value of the Y axis.
		/// </summary>
		public string MinColor { get; set; }
		private string MinColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the min value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the lowest data value to appear on the edge of the plot area.
		/// </summary>
		public double? MinPadding { get; set; }
		private double? MinPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The minimum range to display on this axis. The entire axis will not be allowed to span over a smaller interval than this. For example, for a datetime axis the main unit is milliseconds. If minRange is set to 3600000, you can't zoom in more than to one hour.</p> <p>The default minRange for the x axis is five times the smallest interval between any of the data points.</p> <p>On a logarithmic axis, the unit for the minimum range is the power. So a minRange of 1 means that the axis can be zoomed to 10-100, 100-1000, 1000-10000 etc.</p>
		/// </summary>
		public double? MinRange { get; set; }
		private double? MinRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum tick interval allowed in axis values. For example on zooming in on an axis with daily data, this can be used to prevent the axis from showing hours. Defaults to the closest distance between two points on the axis.
		/// </summary>
		public double? MinTickInterval { get; set; }
		private double? MinTickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the minor, secondary grid lines.
		/// </summary>
		public string MinorGridLineColor { get; set; }
		private string MinorGridLineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash or dot style of the minor grid lines. For possible values, see <a href="http://jsfiddle.net/gh/get/jquery/1.7.1/highslide-software/highcharts.com/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/">this demonstration</a>.
		/// </summary>
		public YAxisMinorGridLineDashStyle MinorGridLineDashStyle { get; set; }
		private YAxisMinorGridLineDashStyle MinorGridLineDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Width of the minor, secondary grid lines.
		/// </summary>
		public double? MinorGridLineWidth { get; set; }
		private double? MinorGridLineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color for the minor tick marks.
		/// </summary>
		public string MinorTickColor { get; set; }
		private string MinorTickColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Tick interval in scale units for the minor ticks. On a linear axis, if <code>"auto"</code>,  the minor tick interval is calculated as a fifth of the tickInterval. If <code>null</code>, minor ticks are not shown.</p> <p>On logarithmic axes, the unit is the power of the value. For example, setting the minorTickInterval to 1 puts one tick on each of 0.1, 1, 10, 100 etc. Setting the minorTickInterval to 0.1 produces 9 ticks between 1 and 10,  10 and 100 etc. A minorTickInterval of "auto" on a log axis results in a best guess, attempting to enter approximately 5 minor ticks between each major tick.</p><p>If user settings dictate minor ticks to become too dense, they don't make sense, and will be ignored to prevent performance problems.</a><p>On axes using <a href="#xAxis.categories">categories</a>, minor ticks are not supported.</p>
		/// </summary>
		public string MinorTickInterval { get; set; }
		private string MinorTickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel length of the minor tick marks.
		/// </summary>
		public double? MinorTickLength { get; set; }
		private double? MinorTickLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the minor tick marks relative to the axis line. Can be one of <code>inside</code> and <code>outside</code>.
		/// </summary>
		public YAxisMinorTickPosition MinorTickPosition { get; set; }
		private YAxisMinorTickPosition MinorTickPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the minor tick mark.
		/// </summary>
		public double? MinorTickWidth { get; set; }
		private double? MinorTickWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance in pixels from the plot area to the axis line. A positive offset moves the axis with it's line, labels and ticks away from the plot area. This is typically used when two or more axes are displayed on the same side of the plot.
		/// </summary>
		public double? Offset { get; set; }
		private double? Offset_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display the axis on the opposite side of the normal. The normal is on the left side for vertical axes and bottom for horizontal, so the opposite sides will be right and top respectively. This is typically used with dual or multiple axes.
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
		/// Whether to reverse the axis so that the highest number is closest to the origin. If the chart is inverted, the x axis is reversed by default.
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// If <code>true</code>, the first series in a stack will be drawn on top in a positive, non-reversed Y axis. If <code>false</code>, the first series is in the base of the stack.
		/// </summary>
		public bool? ReversedStacks { get; set; }
		private bool? ReversedStacks_DefaultValue { get; set; }
		 

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
		/// Whether to show the last tick label.
		/// </summary>
		public bool? ShowLastLabel { get; set; }
		private bool? ShowLastLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// The stack labels show the total value for each bar in a stacked column or bar chart. The label will be placed on top ofpositive columns and below negative columns. In case of an inverted column chart or a bar chart the label is placed to the right of positive bars and to the left of negative bars.
		/// </summary>
		public YAxisStackLabels StackLabels { get; set; }
		private YAxisStackLabels StackLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// For datetime axes, this decides where to put the tick between weeks. 0 = Sunday, 1 = Monday.
		/// </summary>
		public double? StartOfWeek { get; set; }
		private double? StartOfWeek_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to start on a tick. Use this option with the <code>maxPadding</code> option to control the axis start.
		/// </summary>
		public bool? StartOnTick { get; set; }
		private bool? StartOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Solid gauge series only. Color stops for the solid gauge. Use this in cases where a linear gradient between a <code>minColor</code> and <code>maxColor</code> is not sufficient. The stops is an array of tuples, where the first item is a float between 0 and 1 assigning the relative position in the gradient, and the second item is the color.</p><p>For solid gauges, the Y axis also inherits the concept of <a href="http://api.highcharts.com/highmaps#colorAxis.dataClasses">data classes</a> from the Highmaps color axis.</p>
		/// </summary>
		public List<Stop> Stops { get; set; }
		private List<Stop> Stops_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The amount of ticks to draw on the axis. This opens up for aligning the ticks of multiple charts or panes within a chart. This option overrides the <code>tickPixelInterval</code> option.</p><p>This option only has an effect on linear axes. Datetime, logarithmic or category axes are not affected.</p>
		/// </summary>
		public double? TickAmount { get; set; }
		private double? TickAmount_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color for the main tick marks.
		/// </summary>
		public string TickColor { get; set; }
		private string TickColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The interval of the tick marks in axis units. When <code>null</code>, the tick interval is computed to approximately follow the <a href="#xAxis.tickPixelInterval">tickPixelInterval</a> on linear and datetime axes. On categorized axes, a <code>null</code> tickInterval will default to 1, one category.  Note that datetime axes are based on milliseconds, so for  example an interval of one day is expressed as <code>24 * 3600 * 1000</code>.</p> <p>On logarithmic axes, the tickInterval is based on powers, so a tickInterval of 1 means one tick on each of 0.1, 1, 10, 100 etc. A tickInterval of 2 means a tick of 0.1, 10, 1000 etc. A tickInterval of 0.2 puts a tick on 0.1, 0.2, 0.4, 0.6, 0.8, 1, 2, 4, 6, 8, 10, 20, 40 etc.</p><p>If the tickInterval is too dense for labels to be drawn, Highcharts may remove ticks.</p>
		/// </summary>
		public double? TickInterval { get; set; }
		private double? TickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel length of the main tick marks.
		/// </summary>
		public double? TickLength { get; set; }
		private double? TickLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// If tickInterval is <code>null</code> this option sets the approximate pixel interval of the tick marks. Not applicable to categorized axis. Defaults to <code>72</code>  for the Y axis and <code>100</code> forthe X axis.
		/// </summary>
		public double? TickPixelInterval { get; set; }
		private double? TickPixelInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the major tick marks relative to the axis line. Can be one of <code>inside</code> and <code>outside</code>.
		/// </summary>
		public YAxisTickPosition TickPosition { get; set; }
		private YAxisTickPosition TickPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function returning array defining where the ticks are laid out on the axis. This overrides the default behaviour of <a href="#xAxis.tickPixelInterval">tickPixelInterval</a> and <a href="#xAxis.tickInterval">tickInterval</a>. The automatic tick positions are accessible through <code>this.tickPositions</code> and can be modified by the callback.
		/// </summary>
		public string TickPositioner { get; set; }
		private string TickPositioner_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining where the ticks are laid out on the axis. This overrides the default behaviour of <a href="#xAxis.tickPixelInterval">tickPixelInterval</a> and <a href="#xAxis.tickInterval">tickInterval</a>.
		/// </summary>
		public List<double> TickPositions { get; set; }
		private List<double> TickPositions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the major tick marks.
		/// </summary>
		public double? TickWidth { get; set; }
		private double? TickWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// For categorized axes only. If <code>on</code> the tick mark is placed in the center of  the category, if <code>between</code> the tick mark is placed between categories. The default is <code>between</code> if the <code>tickInterval</code> is 1, else <code>on</code>.
		/// </summary>
		public YAxisTickmarkPlacement TickmarkPlacement { get; set; }
		private YAxisTickmarkPlacement TickmarkPlacement_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisTitle Title { get; set; }
		private YAxisTitle Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// The type of axis. Can be one of <code>"linear"</code>, <code>"logarithmic"</code>, <code>"datetime"</code> or <code>"category"</code>. In a datetime axis, the numbers are given in milliseconds, and tick marks are placed on appropriate values like full hours or days. In a category axis, the <a href="#series.data">point names</a> of the chart's series are used for categories, if not a <a href="#xAxis.categories">categories</a> array is defined.
		/// </summary>
		public YAxisType Type { get; set; }
		private YAxisType Type_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllowDecimals != AllowDecimals_DefaultValue) h.Add("allowDecimals",AllowDecimals);
			if (AlternateGridColor != AlternateGridColor_DefaultValue) h.Add("alternateGridColor",AlternateGridColor);
			if (Breaks.IsDirty()) h.Add("breaks",Breaks.ToHashtable());
			if (Categories != Categories_DefaultValue) h.Add("categories",Categories);
			if (Ceiling != Ceiling_DefaultValue) h.Add("ceiling",Ceiling);
			if (DateTimeLabelFormats != DateTimeLabelFormats_DefaultValue) h.Add("dateTimeLabelFormats",DateTimeLabelFormats);
			if (EndOnTick != EndOnTick_DefaultValue) h.Add("endOnTick",EndOnTick);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Floor != Floor_DefaultValue) h.Add("floor",Floor);
			if (GridLineColor != GridLineColor_DefaultValue) h.Add("gridLineColor",GridLineColor);
			if (GridLineDashStyle != GridLineDashStyle_DefaultValue) h.Add("gridLineDashStyle", Highcharts.FirstCharacterToLower(GridLineDashStyle.ToString()));
			if (GridLineInterpolation != GridLineInterpolation_DefaultValue) h.Add("gridLineInterpolation", Highcharts.FirstCharacterToLower(GridLineInterpolation.ToString()));
			if (GridLineWidth != GridLineWidth_DefaultValue) h.Add("gridLineWidth",GridLineWidth);
			if (GridZIndex != GridZIndex_DefaultValue) h.Add("gridZIndex",GridZIndex);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (MaxColor != MaxColor_DefaultValue) h.Add("maxColor",MaxColor);
			if (MaxPadding != MaxPadding_DefaultValue) h.Add("maxPadding",MaxPadding);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (MinColor != MinColor_DefaultValue) h.Add("minColor",MinColor);
			if (MinPadding != MinPadding_DefaultValue) h.Add("minPadding",MinPadding);
			if (MinRange != MinRange_DefaultValue) h.Add("minRange",MinRange);
			if (MinTickInterval != MinTickInterval_DefaultValue) h.Add("minTickInterval",MinTickInterval);
			if (MinorGridLineColor != MinorGridLineColor_DefaultValue) h.Add("minorGridLineColor",MinorGridLineColor);
			if (MinorGridLineDashStyle != MinorGridLineDashStyle_DefaultValue) h.Add("minorGridLineDashStyle", Highcharts.FirstCharacterToLower(MinorGridLineDashStyle.ToString()));
			if (MinorGridLineWidth != MinorGridLineWidth_DefaultValue) h.Add("minorGridLineWidth",MinorGridLineWidth);
			if (MinorTickColor != MinorTickColor_DefaultValue) h.Add("minorTickColor",MinorTickColor);
			if (MinorTickInterval != MinorTickInterval_DefaultValue) h.Add("minorTickInterval",MinorTickInterval);
			if (MinorTickLength != MinorTickLength_DefaultValue) h.Add("minorTickLength",MinorTickLength);
			if (MinorTickPosition != MinorTickPosition_DefaultValue) h.Add("minorTickPosition", Highcharts.FirstCharacterToLower(MinorTickPosition.ToString()));
			if (MinorTickWidth != MinorTickWidth_DefaultValue) h.Add("minorTickWidth",MinorTickWidth);
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			if (Opposite != Opposite_DefaultValue) h.Add("opposite",Opposite);
			if (PlotBands != PlotBands_DefaultValue) h.Add("plotBands", HashifyList(PlotBands));
			if (PlotLines != PlotLines_DefaultValue) h.Add("plotLines", HashifyList(PlotLines));
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (ReversedStacks != ReversedStacks_DefaultValue) h.Add("reversedStacks",ReversedStacks);
			if (ShowEmpty != ShowEmpty_DefaultValue) h.Add("showEmpty",ShowEmpty);
			if (ShowFirstLabel != ShowFirstLabel_DefaultValue) h.Add("showFirstLabel",ShowFirstLabel);
			if (ShowLastLabel != ShowLastLabel_DefaultValue) h.Add("showLastLabel",ShowLastLabel);
			if (StackLabels.IsDirty()) h.Add("stackLabels",StackLabels.ToHashtable());
			if (StartOfWeek != StartOfWeek_DefaultValue) h.Add("startOfWeek",StartOfWeek);
			if (StartOnTick != StartOnTick_DefaultValue) h.Add("startOnTick",StartOnTick);
			if (Stops != Stops_DefaultValue) h.Add("stops", HashifyList(Stops));
			if (TickAmount != TickAmount_DefaultValue) h.Add("tickAmount",TickAmount);
			if (TickColor != TickColor_DefaultValue) h.Add("tickColor",TickColor);
			if (TickInterval != TickInterval_DefaultValue) h.Add("tickInterval",TickInterval);
			if (TickLength != TickLength_DefaultValue) h.Add("tickLength",TickLength);
			if (TickPixelInterval != TickPixelInterval_DefaultValue) h.Add("tickPixelInterval",TickPixelInterval);
			if (TickPosition != TickPosition_DefaultValue) h.Add("tickPosition", Highcharts.FirstCharacterToLower(TickPosition.ToString()));
			if (TickPositioner != TickPositioner_DefaultValue) { h.Add("tickPositioner",TickPositioner); Highcharts.AddFunction("YAxisTickPositioner.tickPositioner", TickPositioner); }  
			if (TickPositions != TickPositions_DefaultValue) h.Add("tickPositions",TickPositions);
			if (TickWidth != TickWidth_DefaultValue) h.Add("tickWidth",TickWidth);
			if (TickmarkPlacement != TickmarkPlacement_DefaultValue) h.Add("tickmarkPlacement", Highcharts.FirstCharacterToLower(TickmarkPlacement.ToString()));
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (Type != Type_DefaultValue) h.Add("type", Highcharts.FirstCharacterToLower(Type.ToString()));
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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
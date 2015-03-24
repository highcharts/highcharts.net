using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace HighSoft.Web.Mvc
{
	public partial class XAxis
	{
		public XAxis()
		{
			AllowDecimals = AllowDecimals_DefaultValue = true;
			AlternateGridColor = AlternateGridColor_DefaultValue = null;
			Categories = Categories_DefaultValue = null;
			Ceiling = Ceiling_DefaultValue = null;
			DateTimeLabelFormats = DateTimeLabelFormats_DefaultValue = null;
			EndOnTick = EndOnTick_DefaultValue = false;
			Events = Events_DefaultValue = new XAxisEvents();
			Floor = Floor_DefaultValue = null;
			GridLineColor = GridLineColor_DefaultValue = "#C0C0C0";
			GridLineDashStyle = GridLineDashStyle_DefaultValue = "Solid";
			GridLineWidth = GridLineWidth_DefaultValue = 0;
			GridZIndex = GridZIndex_DefaultValue = 1;
			Id = Id_DefaultValue = null;
			Labels = Labels_DefaultValue = new XAxisLabels();
			LineColor = LineColor_DefaultValue = "#C0D0E0";
			LineWidth = LineWidth_DefaultValue = 1;
			LinkedTo = LinkedTo_DefaultValue = null;
			Max = Max_DefaultValue = null;
			MaxPadding = MaxPadding_DefaultValue = 0.01;
			MaxZoom = MaxZoom_DefaultValue = null;
			Min = Min_DefaultValue = null;
			MinPadding = MinPadding_DefaultValue = 0.01;
			MinRange = MinRange_DefaultValue = null;
			MinTickInterval = MinTickInterval_DefaultValue = null;
			MinorGridLineColor = MinorGridLineColor_DefaultValue = "#E0E0E0";
			MinorGridLineDashStyle = MinorGridLineDashStyle_DefaultValue = "Solid";
			MinorGridLineWidth = MinorGridLineWidth_DefaultValue = 1;
			MinorTickColor = MinorTickColor_DefaultValue = "#A0A0A0";
			MinorTickInterval = MinorTickInterval_DefaultValue = null;
			MinorTickLength = MinorTickLength_DefaultValue = 2;
			MinorTickPosition = MinorTickPosition_DefaultValue = "outside";
			MinorTickWidth = MinorTickWidth_DefaultValue = 0;
			Offset = Offset_DefaultValue = 0;
			Opposite = Opposite_DefaultValue = false;
			PlotBands = PlotBands_DefaultValue = new XAxisPlotBands();
			PlotLines = PlotLines_DefaultValue = new XAxisPlotLines();
			Reversed = Reversed_DefaultValue = false;
			ShowEmpty = ShowEmpty_DefaultValue = true;
			ShowFirstLabel = ShowFirstLabel_DefaultValue = true;
			ShowLastLabel = ShowLastLabel_DefaultValue = true;
			StartOfWeek = StartOfWeek_DefaultValue = 1;
			StartOnTick = StartOnTick_DefaultValue = false;
			TickColor = TickColor_DefaultValue = "#C0D0E0";
			TickInterval = TickInterval_DefaultValue = null;
			TickLength = TickLength_DefaultValue = 10;
			TickPixelInterval = TickPixelInterval_DefaultValue = null;
			TickPosition = TickPosition_DefaultValue = "outside";
			TickPositioner = TickPositioner_DefaultValue = null;
			TickPositions = TickPositions_DefaultValue = null;
			TickWidth = TickWidth_DefaultValue = 1;
			TickmarkPlacement = TickmarkPlacement_DefaultValue = "null";
			Title = Title_DefaultValue = new XAxisTitle();
			Type = Type_DefaultValue = "linear";
			
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
		/// <p>If categories are present for the xAxis, names are used instead of numbers for that axis. Since Highcharts 3.0, categories can also be extracted by giving each point a <a href="#series.data">name</a> and setting axis <a href="#xAxis.type">type</a> to <code>"category"</code>.</p><p>Example:<pre>categories: ['Apples', 'Bananas', 'Oranges']</pre> Defaults to <code>null</code></p>
		/// </summary>
		public Array Categories { get; set; }
		private Array Categories_DefaultValue { get; set; }
		 

		/// <summary>
		/// The highest allowed value for automatically computed axis extremes.
		/// </summary>
		public double? Ceiling { get; set; }
		private double? Ceiling_DefaultValue { get; set; }
		 

		/// <summary>
		/// For a datetime axis, the scale will automatically adjust to the appropriate unit. This member gives the default string representations used for each unit. For an overview of the replacement codes, see dateFormat. Defaults to:<pre>{millisecond: '%H:%M:%S.%L',second: '%H:%M:%S',minute: '%H:%M',hour: '%H:%M',day: '%e. %b',week: '%e. %b',month: '%b \'%y',year: '%Y'}</pre>
		/// </summary>
		public Object DateTimeLabelFormats { get; set; }
		private Object DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to end on a tick. Use this option with the <code>maxPadding</code> option to control the axis end.
		/// </summary>
		public bool? EndOnTick { get; set; }
		private bool? EndOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Event handlers for the axis.
		/// </summary>
		public XAxisEvents Events { get; set; }
		private XAxisEvents Events_DefaultValue { get; set; }
		 

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
		public string GridLineDashStyle { get; set; }
		private string GridLineDashStyle_DefaultValue { get; set; }
		 

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
		/// The axis labels show the number or category for each tick.
		/// </summary>
		public XAxisLabels Labels { get; set; }
		private XAxisLabels Labels_DefaultValue { get; set; }
		 

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
		/// Padding of the max value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the highest data value to appear on the edge of the plot area. When the axis' <code>max</code> option is set or a max extreme is set using <code>axis.setExtremes()</code>, the maxPadding will be ignored.
		/// </summary>
		public double? MaxPadding { get; set; }
		private double? MaxPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Deprecated. Renamed to <code>minRange</code> as of Highcharts 2.2.
		/// </summary>
		public double? MaxZoom { get; set; }
		private double? MaxZoom_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum value of the axis. If <code>null</code> the min value is automatically calculated. If the <code>startOnTick</code> option is true, the <code>min</code> value might be rounded down.
		/// </summary>
		public double? Min { get; set; }
		private double? Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the min value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the lowest data value to appear on the edge of the plot area. When the axis' <code>min</code> option is set or a min extreme is set using <code>axis.setExtremes()</code>, the minPadding will be ignored.
		/// </summary>
		public double? MinPadding { get; set; }
		private double? MinPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The minimum range to display on this axis. The entire axis will not be allowed to span over a smaller interval than this. For example, for a datetime axis the main unit is milliseconds. If minRange is set to 3600000, you can't zoom in more than to one hour.</p> <p>The default minRange for the x axis is five times the smallest interval between any of the data points.</p> <p>On a logarithmic axis, the unit for the minimum range is the power. So a minRange of 1 means that the axis can be zoomed to 10-100, 100-1000, 1000-10000 etc.</p>
		/// </summary>
		public double? MinRange { get; set; }
		private double? MinRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum tick interval allowed in axis values. For example on zooming in on an axis with daily data, this can be used to prevent the axis from showing hours.
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
		public string MinorGridLineDashStyle { get; set; }
		private string MinorGridLineDashStyle_DefaultValue { get; set; }
		 

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
		/// <p>Tick interval in scale units for the minor ticks. On a linear axis, if <code>"auto"</code>,  the minor tick interval is calculated as a fifth of the tickInterval. If <code>null</code>, minor ticks are not shown.</p> <p>On logarithmic axes, the unit is the power of the value. For example, setting the minorTickInterval to 1 puts one tick on each of 0.1, 1, 10, 100 etc. Setting the minorTickInterval to 0.1 produces 9 ticks between 1 and 10,  10 and 100 etc. A minorTickInterval of "auto" on a log axis results in a best guess, attempting to enter approximately 5 minor ticks between each major tick.</p><p>On axes using <a href="#xAxis.categories">categories</a>, minor ticks are not supported.</p>
		/// </summary>
		public double? MinorTickInterval { get; set; }
		private double? MinorTickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel length of the minor tick marks.
		/// </summary>
		public double? MinorTickLength { get; set; }
		private double? MinorTickLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the minor tick marks relative to the axis line. Can be one of <code>inside</code> and <code>outside</code>.
		/// </summary>
		public string MinorTickPosition { get; set; }
		private string MinorTickPosition_DefaultValue { get; set; }
		 

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
		/// <p>An array of colored bands stretching across the plot area marking an interval on the axis.</p><p>In a gauge, a plot band on the Y axis (value axis) will stretch along the perimeter of the gauge.</p>
		/// </summary>
		public XAxisPlotBands PlotBands { get; set; }
		private XAxisPlotBands PlotBands_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of lines stretching across the plot area, marking a specific value on one of the axes.
		/// </summary>
		public XAxisPlotLines PlotLines { get; set; }
		private XAxisPlotLines PlotLines_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to reverse the axis so that the highest number is closest to the origin. If the chart is inverted, the x axis is reversed by default.
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
		/// Whether to show the last tick label.
		/// </summary>
		public bool? ShowLastLabel { get; set; }
		private bool? ShowLastLabel_DefaultValue { get; set; }
		 

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
		/// Color for the main tick marks.
		/// </summary>
		public string TickColor { get; set; }
		private string TickColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The interval of the tick marks in axis units. When <code>null</code>, the tick interval is computed to approximately follow the <a href="#xAxis.tickPixelInterval">tickPixelInterval</a> on linear and datetime axes. On categorized axes, a <code>null</code> tickInterval will default to 1, one category.  Note that datetime axes are based on milliseconds, so for  example an interval of one day is expressed as <code>24 * 3600 * 1000</code>.</p> <p>On logarithmic axes, the tickInterval is based on powers, so a tickInterval of 1 means one tick on each of 0.1, 1, 10, 100 etc. A tickInterval of 2 means a tick of 0.1, 10, 1000 etc. A tickInterval of 0.2 puts a tick on 0.1, 0.2, 0.4, 0.6, 0.8, 1, 2, 4, 6, 8, 10, 20, 40 etc.</p>
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
		public string TickPosition { get; set; }
		private string TickPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function returning array defining where the ticks are laid out on the axis. This overrides the default behaviour of <a href="#xAxis.tickPixelInterval">tickPixelInterval</a> and <a href="#xAxis.tickInterval">tickInterval</a>.
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
		public string TickmarkPlacement { get; set; }
		private string TickmarkPlacement_DefaultValue { get; set; }
		 

		/// <summary>
		/// The axis title, showing next to the axis line.
		/// </summary>
		public XAxisTitle Title { get; set; }
		private XAxisTitle Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// The type of axis. Can be one of <code>"linear"</code>, <code>"logarithmic"</code>, <code>"datetime"</code> or <code>"category"</code>. In a datetime axis, the numbers are given in milliseconds, and tick marks are placed on appropriate values like full hours or days. In a category axis, the <a href="#series.data">point names</a> of the chart's series are used for categories, if not a <a href="#xAxis.categories">categories</a> array is defined.
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllowDecimals != AllowDecimals_DefaultValue) h.Add("allowDecimals",AllowDecimals);
			if (AlternateGridColor != AlternateGridColor_DefaultValue) h.Add("alternateGridColor",AlternateGridColor);
			if (Categories != Categories_DefaultValue) h.Add("categories",Categories);
			if (Ceiling != Ceiling_DefaultValue) h.Add("ceiling",Ceiling);
			if (DateTimeLabelFormats != DateTimeLabelFormats_DefaultValue) h.Add("dateTimeLabelFormats",DateTimeLabelFormats);
			if (EndOnTick != EndOnTick_DefaultValue) h.Add("endOnTick",EndOnTick);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Floor != Floor_DefaultValue) h.Add("floor",Floor);
			if (GridLineColor != GridLineColor_DefaultValue) h.Add("gridLineColor",GridLineColor);
			if (GridLineDashStyle != GridLineDashStyle_DefaultValue) h.Add("gridLineDashStyle",GridLineDashStyle);
			if (GridLineWidth != GridLineWidth_DefaultValue) h.Add("gridLineWidth",GridLineWidth);
			if (GridZIndex != GridZIndex_DefaultValue) h.Add("gridZIndex",GridZIndex);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (MaxPadding != MaxPadding_DefaultValue) h.Add("maxPadding",MaxPadding);
			if (MaxZoom != MaxZoom_DefaultValue) h.Add("maxZoom",MaxZoom);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (MinPadding != MinPadding_DefaultValue) h.Add("minPadding",MinPadding);
			if (MinRange != MinRange_DefaultValue) h.Add("minRange",MinRange);
			if (MinTickInterval != MinTickInterval_DefaultValue) h.Add("minTickInterval",MinTickInterval);
			if (MinorGridLineColor != MinorGridLineColor_DefaultValue) h.Add("minorGridLineColor",MinorGridLineColor);
			if (MinorGridLineDashStyle != MinorGridLineDashStyle_DefaultValue) h.Add("minorGridLineDashStyle",MinorGridLineDashStyle);
			if (MinorGridLineWidth != MinorGridLineWidth_DefaultValue) h.Add("minorGridLineWidth",MinorGridLineWidth);
			if (MinorTickColor != MinorTickColor_DefaultValue) h.Add("minorTickColor",MinorTickColor);
			if (MinorTickInterval != MinorTickInterval_DefaultValue) h.Add("minorTickInterval",MinorTickInterval);
			if (MinorTickLength != MinorTickLength_DefaultValue) h.Add("minorTickLength",MinorTickLength);
			if (MinorTickPosition != MinorTickPosition_DefaultValue) h.Add("minorTickPosition",MinorTickPosition);
			if (MinorTickWidth != MinorTickWidth_DefaultValue) h.Add("minorTickWidth",MinorTickWidth);
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			if (Opposite != Opposite_DefaultValue) h.Add("opposite",Opposite);
			if (PlotBands.IsDirty()) h.Add("plotBands",PlotBands.ToHashtable());
			if (PlotLines.IsDirty()) h.Add("plotLines",PlotLines.ToHashtable());
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (ShowEmpty != ShowEmpty_DefaultValue) h.Add("showEmpty",ShowEmpty);
			if (ShowFirstLabel != ShowFirstLabel_DefaultValue) h.Add("showFirstLabel",ShowFirstLabel);
			if (ShowLastLabel != ShowLastLabel_DefaultValue) h.Add("showLastLabel",ShowLastLabel);
			if (StartOfWeek != StartOfWeek_DefaultValue) h.Add("startOfWeek",StartOfWeek);
			if (StartOnTick != StartOnTick_DefaultValue) h.Add("startOnTick",StartOnTick);
			if (TickColor != TickColor_DefaultValue) h.Add("tickColor",TickColor);
			if (TickInterval != TickInterval_DefaultValue) h.Add("tickInterval",TickInterval);
			if (TickLength != TickLength_DefaultValue) h.Add("tickLength",TickLength);
			if (TickPixelInterval != TickPixelInterval_DefaultValue) h.Add("tickPixelInterval",TickPixelInterval);
			if (TickPosition != TickPosition_DefaultValue) h.Add("tickPosition",TickPosition);
			if (TickPositioner != TickPositioner_DefaultValue) { h.Add("tickPositioner",TickPositioner); HighCharts.AddFunction("tickPositioner", TickPositioner); }  
			if (TickPositions != TickPositions_DefaultValue) h.Add("tickPositions",TickPositions);
			if (TickWidth != TickWidth_DefaultValue) h.Add("tickWidth",TickWidth);
			if (TickmarkPlacement != TickmarkPlacement_DefaultValue) h.Add("tickmarkPlacement",TickmarkPlacement);
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (Type != Type_DefaultValue) h.Add("type",Type);
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}
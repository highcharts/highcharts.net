using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Maps
{
	public partial class ColorAxis  : BaseObject
	{
		public ColorAxis()
		{
			ColorAxis = ColorAxis_DefaultValue = new ColorAxis();
			DataClassColor = DataClassColor_DefaultValue = ColorAxisDataClassColor.Tween;
			DataClasses = DataClasses_DefaultValue = new ColorAxisDataClasses();
			EndOnTick = EndOnTick_DefaultValue = true;
			Events = Events_DefaultValue = new ColorAxisEvents();
			GridLineColor = GridLineColor_DefaultValue = "#C0C0C0";
			GridLineDashStyle = GridLineDashStyle_DefaultValue = ColorAxisGridLineDashStyle.Solid;
			GridLineWidth = GridLineWidth_DefaultValue = 1;
			Id = Id_DefaultValue = null;
			Labels = Labels_DefaultValue = new ColorAxisLabels();
			LineColor = LineColor_DefaultValue = "#C0D0E0";
			LineWidth = LineWidth_DefaultValue = 0;
			Marker = Marker_DefaultValue = new ColorAxisMarker();
			Max = Max_DefaultValue = null;
			MaxPadding = MaxPadding_DefaultValue = 0.05;
			Min = Min_DefaultValue = null;
			MinColor = MinColor_DefaultValue = "#EFEFFF";
			MinPadding = MinPadding_DefaultValue = 0.05;
			MinorGridLineColor = MinorGridLineColor_DefaultValue = "#E0E0E0";
			MinorGridLineDashStyle = MinorGridLineDashStyle_DefaultValue = ColorAxisMinorGridLineDashStyle.Solid;
			MinorGridLineWidth = MinorGridLineWidth_DefaultValue = 1;
			MinorTickColor = MinorTickColor_DefaultValue = "#A0A0A0";
			MinorTickInterval = MinorTickInterval_DefaultValue = null;
			MinorTickLength = MinorTickLength_DefaultValue = 2;
			MinorTickPosition = MinorTickPosition_DefaultValue = ColorAxisMinorTickPosition.Outside;
			MinorTickWidth = MinorTickWidth_DefaultValue = 0;
			Reversed = Reversed_DefaultValue = "";
			ShowFirstLabel = ShowFirstLabel_DefaultValue = true;
			ShowLastLabel = ShowLastLabel_DefaultValue = true;
			StartOnTick = StartOnTick_DefaultValue = true;
			Stops = Stops_DefaultValue = null;
			TickColor = TickColor_DefaultValue = "#C0D0E0";
			TickInterval = TickInterval_DefaultValue = null;
			TickLength = TickLength_DefaultValue = 10;
			TickPixelInterval = TickPixelInterval_DefaultValue = 72;
			TickPosition = TickPosition_DefaultValue = ColorAxisTickPosition.Outside;
			TickPositioner = TickPositioner_DefaultValue = "";
			TickPositions = TickPositions_DefaultValue = null;
			TickWidth = TickWidth_DefaultValue = 0;
			Type = Type_DefaultValue = ColorAxisType.Linear;
			Stops = Stops_DefaultValue = null;
			Min = Min_DefaultValue = null;
			Max = Max_DefaultValue = null;
			StartOnTick = StartOnTick_DefaultValue = false;
			EndOnTick = EndOnTick_DefaultValue = false;
			MinColor = MinColor_DefaultValue = null;
			MaxColor = MaxColor_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>A color axis for choropleth mapping. Visually, the color axis will appear as a gradient or as separate items inside the legend, depending on whether the axis is scalar or based on data classes.</p><p>For supported color formats, see the <a href="http://www.highcharts.com/docs/chart-design-and-style/colors">docs article about colors</a>.</p><p>A scalar color axis is represented by a gradient. The colors either range between the <a href="#colorAxis.minColor">minColor</a> and the <a href="#colorAxis.maxColor">maxColor</a>, or for more fine grained control the colors can be defined in <a href="#colorAxis.stops">stops</a>. Often times, the color axis needs to be adjusted to get the right color spread for the data. In addition to stops, consider using a logarithmic <a href="#colorAxis.type">axis type</a>, or setting <a href="#colorAxis.min">min</a> and <a href="#colorAxis.max">max</a> to avoid the colors being determined by outliers.</p><p>When <a href="#colorAxis.dataClasses">dataClasses</a> are used, the ranges are subdivided into separate classes like categories based on their values. This can be used for ranges between two values, but also for a true category. However, when your data is categorized, it may be as convenient to add each category to a separate series.</p><p>See <a href="#Axis">the Axis object</a> for programmatic access to the axis.</p>
		/// </summary>
		public ColorAxis ColorAxis { get; set; }
		private ColorAxis ColorAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// Determines how to set each data class' color if no individual color is set. The default value, <code>tween</code>, computes intermediate colors between <code>minColor</code> and <code>maxColor</code>. The other possible value, <code>category</code>, pulls colors from the global or chart specific <a href="#colors">colors</a> array.
		/// </summary>
		public ColorAxisDataClassColor DataClassColor { get; set; }
		private ColorAxisDataClassColor DataClassColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data classes or ranges for the choropleth map. If none given, the color axis is scalar and values are distributed as a gradient between the minimum and maximum colors.
		/// </summary>
		public ColorAxisDataClasses DataClasses { get; set; }
		private ColorAxisDataClasses DataClasses_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to end on a tick. Use this option with the <a href="#colorAxis.maxPadding">maxPadding</a> option to control the axis end.
		/// </summary>
		public bool? EndOnTick { get; set; }
		private bool? EndOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Event handlers for the axis.
		/// </summary>
		public ColorAxisEvents Events { get; set; }
		private ColorAxisEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the grid lines extending from the axis across the gradient. 
		/// </summary>
		public string GridLineColor { get; set; }
		private string GridLineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash or dot style of the grid lines. For possible values, see <a href="http://jsfiddle.net/gh/get/jquery/1.7.2/highslide-software/highcharts.com/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/">this demonstration</a>.
		/// </summary>
		public ColorAxisGridLineDashStyle GridLineDashStyle { get; set; }
		private ColorAxisGridLineDashStyle GridLineDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the grid lines extending from the axis across the gradient of a scalar color axis.
		/// </summary>
		public double? GridLineWidth { get; set; }
		private double? GridLineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the axis. This can be used after render time to get a pointer to the axis object through <code>chart.get()</code>.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The axis labels show the number for each tick.</p><p>For more live examples on label options, see <a href="/highcharts#xAxis.labels">xAxis.labels in the Highcharts API.</p>
		/// </summary>
		public ColorAxisLabels Labels { get; set; }
		private ColorAxisLabels Labels_DefaultValue { get; set; }
		 

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
		/// The triangular marker on a scalar color axis that points to the value of the hovered area. To disable the marker, set <code>marker: null</code>.
		/// </summary>
		public ColorAxisMarker Marker { get; set; }
		private ColorAxisMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// The maximum value of the axis in terms of map point values. If <code>null</code>, the max value is automatically calculated. If the <code>endOnTick</code> option is true, the max value might be rounded up.
		/// </summary>
		public double? Max { get; set; }
		private double? Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the max value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer.
		/// </summary>
		public double? MaxPadding { get; set; }
		private double? MaxPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum value of the axis in terms of map point values. If <code>null</code>, the min value is automatically calculated. If the <code>startOnTick</code> option is true, the min value might be rounded down.
		/// </summary>
		public double? Min { get; set; }
		private double? Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color to represent the minimum of the color axis. Unless <a href="#colorAxis.dataClasses">dataClasses</a> or <a href="#colorAxis.stops">stops</a> are set, the gradient starts at this value.</p><p>If dataClasses are set, the color is based on minColor and maxColor unless a color is set for each data class, or the <a href="#colorAxis.dataClassColor">dataClassColor</a> is set.</p>
		/// </summary>
		public string MinColor { get; set; }
		private string MinColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the min value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer.
		/// </summary>
		public double? MinPadding { get; set; }
		private double? MinPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the minor, secondary grid lines.
		/// </summary>
		public string MinorGridLineColor { get; set; }
		private string MinorGridLineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash or dot style of the minor grid lines. For possible values, see <a href="http://jsfiddle.net/gh/get/jquery/1.7.1/highslide-software/highcharts.com/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/">this demonstration</a>.
		/// </summary>
		public ColorAxisMinorGridLineDashStyle MinorGridLineDashStyle { get; set; }
		private ColorAxisMinorGridLineDashStyle MinorGridLineDashStyle_DefaultValue { get; set; }
		 

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
		/// <p>Tick interval in scale units for the minor ticks. On a linear axis, if <code>"auto"</code>,  the minor tick interval is calculated as a fifth of the tickInterval. If <code>null</code>, minor ticks are not shown.</p> <p>On logarithmic axes, the unit is the power of the value. For example, setting the minorTickInterval to 1 puts one tick on each of 0.1, 1, 10, 100 etc. Setting the minorTickInterval to 0.1 produces 9 ticks between 1 and 10,  10 and 100 etc. A minorTickInterval of "auto" on a log axis results in a best guess, attempting to enter approximately 5 minor ticks between each major tick.</p><p>If user settings dictate minor ticks to become too dense, they don't make sense, and will be ignored to prevent performance problems.</a>
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
		public ColorAxisMinorTickPosition MinorTickPosition { get; set; }
		private ColorAxisMinorTickPosition MinorTickPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the minor tick mark.
		/// </summary>
		public double? MinorTickWidth { get; set; }
		private double? MinorTickWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to reverse the axis so that the highest number is closest to the origin. Defaults to <code>false</code> in a horizontal legend and <code>true</code> in a vertical legend, where the smallest value starts on top.
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// If labels are enabled, whether to show the first tick label.
		/// </summary>
		public bool? ShowFirstLabel { get; set; }
		private bool? ShowFirstLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// If labels are enabled, whether to show the last tick label.
		/// </summary>
		public bool? ShowLastLabel { get; set; }
		private bool? ShowLastLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to start on a tick. Use this option with the <code>maxPadding</code> option to control the axis start. 
		/// </summary>
		public bool? StartOnTick { get; set; }
		private bool? StartOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color stops for the gradient of a scalar color axis. Use this in cases where a linear gradient between a <code>minColor</code> and <code>maxColor</code> is not sufficient. The stops is an array of tuples, where the first item is a float between 0 and 1 assigning the relative position in the gradient, and the second item is the color. 
		/// </summary>
		public List<Stop> Stops { get; set; }
		private List<Stop> Stops_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color for the main tick marks.
		/// </summary>
		public string TickColor { get; set; }
		private string TickColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The interval of the tick marks in axis units. When <code>null</code>, the tick interval is computed to approximately follow the <code>tickPixelInterval</code>.
		/// </summary>
		public double? TickInterval { get; set; }
		private double? TickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel length of the main tick marks.
		/// </summary>
		public double? TickLength { get; set; }
		private double? TickLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// If <a href="#colorAxis.tickInterval">tickInterval</a> is <code>null</code> this option sets the approximate pixel interval of the tick marks.
		/// </summary>
		public double? TickPixelInterval { get; set; }
		private double? TickPixelInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the major tick marks relative to the axis line. Can be one of <code>inside</code> and <code>outside</code>.
		/// </summary>
		public ColorAxisTickPosition TickPosition { get; set; }
		private ColorAxisTickPosition TickPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function returning array defining where the ticks are laid out on the axis. This overrides the default behaviour of <code>tickPixelInterval</code> and <code>tickInterval</code>.
		/// </summary>
		public string TickPositioner { get; set; }
		private string TickPositioner_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining where the ticks are laid out on the axis. This overrides the default behaviour of <code>tickPixelInterval</code> and <code>tickInterval</code>.
		/// </summary>
		public List<double> TickPositions { get; set; }
		private List<double> TickPositions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the major tick marks.
		/// </summary>
		public double? TickWidth { get; set; }
		private double? TickWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The type of interpolation to use for the color axis. Can be <code>linear</code> or <code>logarithmic</code>.
		/// </summary>
		public ColorAxisType Type { get; set; }
		private ColorAxisType Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<Stop> Stops { get; set; }
		private List<Stop> Stops_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Min { get; set; }
		private double? Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Max { get; set; }
		private double? Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? StartOnTick { get; set; }
		private bool? StartOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? EndOnTick { get; set; }
		private bool? EndOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MinColor { get; set; }
		private string MinColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MaxColor { get; set; }
		private string MaxColor_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ColorAxis.IsDirty()) h.Add("colorAxis",ColorAxis.ToHashtable());
			if (DataClassColor != DataClassColor_DefaultValue) h.Add("dataClassColor", Highmaps.FirstCharacterToLower(DataClassColor.ToString()));
			if (DataClasses.IsDirty()) h.Add("dataClasses",DataClasses.ToHashtable());
			if (EndOnTick != EndOnTick_DefaultValue) h.Add("endOnTick",EndOnTick);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (GridLineColor != GridLineColor_DefaultValue) h.Add("gridLineColor",GridLineColor);
			if (GridLineDashStyle != GridLineDashStyle_DefaultValue) h.Add("gridLineDashStyle", Highmaps.FirstCharacterToLower(GridLineDashStyle.ToString()));
			if (GridLineWidth != GridLineWidth_DefaultValue) h.Add("gridLineWidth",GridLineWidth);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (MaxPadding != MaxPadding_DefaultValue) h.Add("maxPadding",MaxPadding);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (MinColor != MinColor_DefaultValue) h.Add("minColor",MinColor);
			if (MinPadding != MinPadding_DefaultValue) h.Add("minPadding",MinPadding);
			if (MinorGridLineColor != MinorGridLineColor_DefaultValue) h.Add("minorGridLineColor",MinorGridLineColor);
			if (MinorGridLineDashStyle != MinorGridLineDashStyle_DefaultValue) h.Add("minorGridLineDashStyle", Highmaps.FirstCharacterToLower(MinorGridLineDashStyle.ToString()));
			if (MinorGridLineWidth != MinorGridLineWidth_DefaultValue) h.Add("minorGridLineWidth",MinorGridLineWidth);
			if (MinorTickColor != MinorTickColor_DefaultValue) h.Add("minorTickColor",MinorTickColor);
			if (MinorTickInterval != MinorTickInterval_DefaultValue) h.Add("minorTickInterval",MinorTickInterval);
			if (MinorTickLength != MinorTickLength_DefaultValue) h.Add("minorTickLength",MinorTickLength);
			if (MinorTickPosition != MinorTickPosition_DefaultValue) h.Add("minorTickPosition", Highmaps.FirstCharacterToLower(MinorTickPosition.ToString()));
			if (MinorTickWidth != MinorTickWidth_DefaultValue) h.Add("minorTickWidth",MinorTickWidth);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (ShowFirstLabel != ShowFirstLabel_DefaultValue) h.Add("showFirstLabel",ShowFirstLabel);
			if (ShowLastLabel != ShowLastLabel_DefaultValue) h.Add("showLastLabel",ShowLastLabel);
			if (StartOnTick != StartOnTick_DefaultValue) h.Add("startOnTick",StartOnTick);
			if (Stops != Stops_DefaultValue) h.Add("stops", HashifyList(Stops));
			if (TickColor != TickColor_DefaultValue) h.Add("tickColor",TickColor);
			if (TickInterval != TickInterval_DefaultValue) h.Add("tickInterval",TickInterval);
			if (TickLength != TickLength_DefaultValue) h.Add("tickLength",TickLength);
			if (TickPixelInterval != TickPixelInterval_DefaultValue) h.Add("tickPixelInterval",TickPixelInterval);
			if (TickPosition != TickPosition_DefaultValue) h.Add("tickPosition", Highmaps.FirstCharacterToLower(TickPosition.ToString()));
			if (TickPositioner != TickPositioner_DefaultValue) { h.Add("tickPositioner",TickPositioner); Highmaps.AddFunction("ColorAxisTickPositioner.tickPositioner", TickPositioner); }  
			if (TickPositions != TickPositions_DefaultValue) h.Add("tickPositions",TickPositions);
			if (TickWidth != TickWidth_DefaultValue) h.Add("tickWidth",TickWidth);
			if (Type != Type_DefaultValue) h.Add("type", Highmaps.FirstCharacterToLower(Type.ToString()));
			if (Stops != Stops_DefaultValue) h.Add("stops", HashifyList(Stops));
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (StartOnTick != StartOnTick_DefaultValue) h.Add("startOnTick",StartOnTick);
			if (EndOnTick != EndOnTick_DefaultValue) h.Add("endOnTick",EndOnTick);
			if (MinColor != MinColor_DefaultValue) h.Add("minColor",MinColor);
			if (MaxColor != MaxColor_DefaultValue) h.Add("maxColor",MaxColor);
			

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
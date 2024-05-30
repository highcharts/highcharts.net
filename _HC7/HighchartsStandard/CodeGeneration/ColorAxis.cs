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
	public partial class ColorAxis  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColorAxis()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Accessibility options for an axis. Requires the accessibility module.
		/// </summary>
		public ColorAxisAccessibility Accessibility { get; set; }
		private ColorAxisAccessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to allow decimals on the color axis.
		/// </summary>
		public bool? AllowDecimals { get; set; }
		private bool? AllowDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a polar chart, this is the angle of the Y axis in degrees, where0 is up and 90 is right. The angle determines the position of theaxis line and the labels, though the coordinate system is unaffected.Since v8.0.0 this option is also applicable for X axis (invertedpolar).
		/// </summary>
		public double? Angle { get; set; }
		private double? Angle_DefaultValue { get; set; }
		 

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
		/// The value on a perpendicular axis where this axis should cross. Thisis typically used on mathematical plots where the axes cross at 0.When `crossing` is set, space will not be reserved at the sides ofthe chart for axis labels and title, so those may be clipped. In thiscase it is better to place the axes without the `crossing` option.
		/// </summary>
		public double? Crossing { get; set; }
		private double? Crossing_DefaultValue { get; set; }
		 

		/// <summary>
		/// Determines how to set each data class' color if no individualcolor is set. The default value, `tween`, computes intermediatecolors between `minColor` and `maxColor`. The other possiblevalue, `category`, pulls colors from the global or chart specific[colors](#colors) array.
		/// </summary>
		public ColorAxisDataClassColor DataClassColor { get; set; }
		private ColorAxisDataClassColor DataClassColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data classes or ranges for the choropleth map. Ifnone given, the color axis is scalar and values are distributedas a gradient between the minimum and maximum colors.
		/// </summary>
		public List<ColorAxisDataClasses> DataClasses { get; set; }
		private List<ColorAxisDataClasses> DataClasses_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to end on a tick. Use this option withthe [maxPadding](#colorAxis.maxPadding) option to control theaxis end.
		/// </summary>
		public bool? EndOnTick { get; set; }
		private bool? EndOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColorAxisEvents Events { get; set; }
		private ColorAxisEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lowest allowed value for automatically computed axis extremes.
		/// </summary>
		public double? Floor { get; set; }
		private double? Floor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the grid lines extending from the axis across thegradient.
		/// </summary>
		public string GridLineColor { get; set; }
		private string GridLineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash or dot style of the grid lines. For possible values, see[this demonstration](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/).
		/// </summary>
		public Hashtable GridLineDashStyle { get; set; }
		private Hashtable GridLineDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Polar charts only. Whether the grid lines should draw as a polygonwith straight lines between categories, or as circles. Can be either`circle` or `polygon`. Since v8.0.0 this option is also applicablefor X axis (inverted polar).
		/// </summary>
		public ColorAxisGridLineInterpolation GridLineInterpolation { get; set; }
		private ColorAxisGridLineInterpolation GridLineInterpolation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the grid lines extending from the axis across thegradient of a scalar color axis.
		/// </summary>
		public double? GridLineWidth { get; set; }
		private double? GridLineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the grid lines.
		/// </summary>
		public double? GridZIndex { get; set; }
		private double? GridZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the color axis. If it's a number, it is interpreted aspixels.If it's a percentage string, it is interpreted as percentages of thetotal plot height.
		/// </summary>
		public string Height { get; set; }
		private string Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the color axis. If it's a number, it is interpreted aspixels.If it's a percentage string, it is interpreted as percentages of thetotal plot height.
		/// </summary>
		public double? HeightNumber { get; set; }
		private double? HeightNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the axis. This can be used after render time to geta pointer to the axis object through `chart.get()`.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// The axis labels show the number for each tick.For more live examples on label options, see [xAxis.labels in theHighcharts API.](/highcharts#xAxis.labels)
		/// </summary>
		public ColorAxisLabels Labels { get; set; }
		private ColorAxisLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// The layout of the color axis. Can be `'horizontal'` or `'vertical'`.If none given, the color axis has the same layout as the legend.
		/// </summary>
		public string Layout { get; set; }
		private string Layout_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the line marking the axis itself.In styled mode, the line stroke is given in the`.highcharts-axis-line` or `.highcharts-xaxis-line` class.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// If there are multiple axes on the same side of the chart, the pixelmargin between the axes. Defaults to 0 on vertical axes, 15 onhorizontal axes.
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// The triangular marker on a scalar color axis that points to thevalue of the hovered area. To disable the marker, set`marker: null`.
		/// </summary>
		public ColorAxisMarker Marker { get; set; }
		private ColorAxisMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// The maximum value of the axis in terms of map point values. If`null`, the max value is automatically calculated. If the`endOnTick` option is true, the max value might be rounded up.
		/// </summary>
		public double? Max { get; set; }
		private double? Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color to represent the maximum of the color axis. Unless[dataClasses](#colorAxis.dataClasses) or[stops](#colorAxis.stops) are set, the gradient ends at thisvalue.If dataClasses are set, the color is based on minColor andmaxColor unless a color is set for each data class, or the[dataClassColor](#colorAxis.dataClassColor) is set.
		/// </summary>
		public string MaxColor { get; set; }
		private string MaxColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the max value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer.
		/// </summary>
		public double? MaxPadding { get; set; }
		private double? MaxPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum value of the axis in terms of map point values. If`null`, the min value is automatically calculated. If the`startOnTick` option is true, the min value might be roundeddown.
		/// </summary>
		public double? Min { get; set; }
		private double? Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color to represent the minimum of the color axis. Unless[dataClasses](#colorAxis.dataClasses) or[stops](#colorAxis.stops) are set, the gradient starts at thisvalue.If dataClasses are set, the color is based on minColor andmaxColor unless a color is set for each data class, or the[dataClassColor](#colorAxis.dataClassColor) is set.
		/// </summary>
		public string MinColor { get; set; }
		private string MinColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the minor, secondary grid lines.In styled mode, the stroke width is given in the`.highcharts-minor-grid-line` class.
		/// </summary>
		public string MinorGridLineColor { get; set; }
		private string MinorGridLineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash or dot style of the minor grid lines. For possible values,see [this demonstration](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/).
		/// </summary>
		public Hashtable MinorGridLineDashStyle { get; set; }
		private Hashtable MinorGridLineDashStyle_DefaultValue { get; set; }
		 

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
		/// Specific tick interval in axis units for the minor ticks. On a linearaxis, if `"auto"`, the minor tick interval is calculated as a fifthof the tickInterval. If `undefined`, minor ticks are not shown.On logarithmic axes, the unit is the power of the value. For example,setting the minorTickInterval to 1 puts one tick on each of 0.1, 1,10, 100 etc. Setting the minorTickInterval to 0.1 produces 9 ticksbetween 1 and 10, 10 and 100 etc.If user settings dictate minor ticks to become too dense, they don'tmake sense, and will be ignored to prevent performance problems.
		/// </summary>
		public string MinorTickInterval { get; set; }
		private string MinorTickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific tick interval in axis units for the minor ticks. On a linearaxis, if `"auto"`, the minor tick interval is calculated as a fifthof the tickInterval. If `undefined`, minor ticks are not shown.On logarithmic axes, the unit is the power of the value. For example,setting the minorTickInterval to 1 puts one tick on each of 0.1, 1,10, 100 etc. Setting the minorTickInterval to 0.1 produces 9 ticksbetween 1 and 10, 10 and 100 etc.If user settings dictate minor ticks to become too dense, they don'tmake sense, and will be ignored to prevent performance problems.
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
		public ColorAxisMinorTickPosition MinorTickPosition { get; set; }
		private ColorAxisMinorTickPosition MinorTickPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable minor ticks. The interval between the minor tickscan be controlled either by the[minorTicksPerMajor](#xAxis.minorTicksPerMajor) setting, or as anabsolute [minorTickInterval](#xAxis.minorTickInterval) value.On a logarithmic axis, minor ticks are laid out based on a bestguess, attempting to enter an approximate number of minor ticksbetween each major tick based on[minorTicksPerMajor](#xAxis.minorTicksPerMajor).Prior to v6.0.0, ticks were enabled in auto layout by setting`minorTickInterval` to `"auto"`.
		/// </summary>
		public bool? MinorTicks { get; set; }
		private bool? MinorTicks_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of minor ticks per major tick. Works for `linear`,`logarithmic` and `datetime` axes.
		/// </summary>
		public double? MinorTicksPerMajor { get; set; }
		private double? MinorTicksPerMajor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the minor tick mark.
		/// </summary>
		public double? MinorTickWidth { get; set; }
		private double? MinorTickWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the min value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer.
		/// </summary>
		public double? MinPadding { get; set; }
		private double? MinPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to pan axis. If `chart.panning` is enabled, the optionallows to disable panning on an individual axis.
		/// </summary>
		public bool? PanningEnabled { get; set; }
		private bool? PanningEnabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to reverse the axis so that the highest number is closestto the origin. Defaults to `false` in a horizontal legend and`true` in a vertical legend, where the smallest value starts ontop.
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to show the first tick label.
		/// </summary>
		public bool? ShowFirstLabel { get; set; }
		private bool? ShowFirstLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display the colorAxis in the legend.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to show the last tick label. Defaults to `true` on cartesiancharts, and `false` on polar charts.
		/// </summary>
		public bool? ShowLastLabel { get; set; }
		private bool? ShowLastLabel_DefaultValue { get; set; }
		 

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
		/// For datetime axes, this decides where to put the tick between weeks. 0 = Sunday, 1 = Monday.
		/// </summary>
		public double? StartOfWeek { get; set; }
		private double? StartOfWeek_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to start on a tick. Use this optionwith the `maxPadding` option to control the axis start.
		/// </summary>
		public bool? StartOnTick { get; set; }
		private bool? StartOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color stops for the gradient of a scalar color axis. Use this incases where a linear gradient between a `minColor` and `maxColor`is not sufficient. The stops is an array of tuples, where thefirst item is a float between 0 and 1 assigning the relativeposition in the gradient, and the second item is the color.
		/// </summary>
		public List<Stop> Stops { get; set; }
		private List<Stop> Stops_DefaultValue { get; set; }
		 

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
		/// The interval of the tick marks in axis units. When `null`, thetick interval is computed to approximately follow the`tickPixelInterval`.
		/// </summary>
		public double? TickInterval { get; set; }
		private double? TickInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel length of the main tick marks on the color axis.
		/// </summary>
		public double? TickLength { get; set; }
		private double? TickLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// For categorized axes only. If `on` the tick mark is placed in thecenter of the category, if `between` the tick mark is placed betweencategories. The default is `between` if the `tickInterval` is 1, else`on`. In order to render tick marks on a category axis it is necessaryto provide a [tickWidth](#xAxis.tickWidth).
		/// </summary>
		public ColorAxisTickmarkPlacement TickmarkPlacement { get; set; }
		private ColorAxisTickmarkPlacement TickmarkPlacement_DefaultValue { get; set; }
		 

		/// <summary>
		/// If [tickInterval](#colorAxis.tickInterval) is `null` this optionsets the approximate pixel interval of the tick marks.
		/// </summary>
		public double? TickPixelInterval { get; set; }
		private double? TickPixelInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the major tick marks relative to the axis line.Can be one of `inside` and `outside`.
		/// </summary>
		public ColorAxisTickPosition TickPosition { get; set; }
		private ColorAxisTickPosition TickPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function returning array defining where the ticks arelaid out on the axis. This overrides the default behaviour of[tickPixelInterval](#xAxis.tickPixelInterval) and [tickInterval](#xAxis.tickInterval). The automatic tick positions are accessiblethrough `this.tickPositions` and can be modified by the callback.
		/// </summary>
		public string TickPositioner { get; set; }
		private string TickPositioner_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining where the ticks are laid out on the axis. Thisoverrides the default behaviour of [tickPixelInterval](#xAxis.tickPixelInterval) and [tickInterval](#xAxis.tickInterval).
		/// </summary>
		public List<double> TickPositions { get; set; }
		private List<double> TickPositions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the major tick marks. Defaults to 0 on categoryaxes, otherwise 1.In styled mode, the stroke width is given in the `.highcharts-tick`class, but in order for the element to be generated on category axes,the option must be explicitly set to 1.
		/// </summary>
		public double? TickWidth { get; set; }
		private double? TickWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The type of interpolation to use for the color axis. Can be`linear` or `logarithmic`.
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// Applies only when the axis `type` is `category`. When `uniqueNames`is true, points are placed on the X axis according to their names.If the same point name is repeated in the same or another series,the point is placed on the same X position as other points of thesame name. When `uniqueNames` is false, the points are laid out inincreasing X positions regardless of their names, and the X axiscategory will take the name of the last point in each position.
		/// </summary>
		public bool? UniqueNames { get; set; }
		private bool? UniqueNames_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether axis, including axis title, line, ticks and labels, shouldbe visible.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the color axis. If it's a number, it is interpreted aspixels.If it's a percentage string, it is interpreted as percentages of thetotal plot width.
		/// </summary>
		public string Width { get; set; }
		private string Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the color axis. If it's a number, it is interpreted aspixels.If it's a percentage string, it is interpreted as percentages of thetotal plot width.
		/// </summary>
		public double? WidthNumber { get; set; }
		private double? WidthNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index for the axis group.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (AllowDecimals != null) h.Add("allowDecimals",AllowDecimals);
			if (Angle != null) h.Add("angle",Angle);
			if (Ceiling != null) h.Add("ceiling",Ceiling);
			if (ClassName != null) h.Add("className",ClassName);
			if (Crossing != null) h.Add("crossing",Crossing);
			if (DataClassColor != ColorAxisDataClassColor.Null) h.Add("dataClassColor", highcharts.FirstCharacterToLower(DataClassColor.ToString()));
			if (DataClasses != null) h.Add("dataClasses", HashifyList(highcharts,DataClasses));
			if (EndOnTick != null) h.Add("endOnTick",EndOnTick);
			if (Events != null) h.Add("events",Events.ToHashtable(highcharts));
			if (Floor != null) h.Add("floor",Floor);
			if (GridLineColor != null) h.Add("gridLineColor",GridLineColor);
			if (GridLineDashStyle != null) h.Add("gridLineDashStyle",GridLineDashStyle);
			if (GridLineInterpolation != ColorAxisGridLineInterpolation.Null) h.Add("gridLineInterpolation", highcharts.FirstCharacterToLower(GridLineInterpolation.ToString()));
			if (GridLineWidth != null) h.Add("gridLineWidth",GridLineWidth);
			if (GridZIndex != null) h.Add("gridZIndex",GridZIndex);
			if (Height != null) h.Add("height",Height);
			if (HeightNumber != null) h.Add("height",HeightNumber);
			if (Id != null) h.Add("id",Id);
			if (Labels != null) h.Add("labels",Labels.ToHashtable(highcharts));
			if (Layout != null) h.Add("layout",Layout);
			if (LineColor != null) h.Add("lineColor",LineColor);
			if (Margin != null) h.Add("margin",Margin);
			if (Marker != null) h.Add("marker",Marker.ToHashtable(highcharts));
			if (Max != null) h.Add("max",Max);
			if (MaxColor != null) h.Add("maxColor",MaxColor);
			if (MaxPadding != null) h.Add("maxPadding",MaxPadding);
			if (Min != null) h.Add("min",Min);
			if (MinColor != null) h.Add("minColor",MinColor);
			if (MinorGridLineColor != null) h.Add("minorGridLineColor",MinorGridLineColor);
			if (MinorGridLineDashStyle != null) h.Add("minorGridLineDashStyle",MinorGridLineDashStyle);
			if (MinorGridLineWidth != null) h.Add("minorGridLineWidth",MinorGridLineWidth);
			if (MinorTickColor != null) h.Add("minorTickColor",MinorTickColor);
			if (MinorTickInterval != null) h.Add("minorTickInterval",MinorTickInterval);
			if (MinorTickIntervalNumber != null) h.Add("minorTickInterval",MinorTickIntervalNumber);
			if (MinorTickLength != null) h.Add("minorTickLength",MinorTickLength);
			if (MinorTickPosition != ColorAxisMinorTickPosition.Null) h.Add("minorTickPosition", highcharts.FirstCharacterToLower(MinorTickPosition.ToString()));
			if (MinorTicks != null) h.Add("minorTicks",MinorTicks);
			if (MinorTicksPerMajor != null) h.Add("minorTicksPerMajor",MinorTicksPerMajor);
			if (MinorTickWidth != null) h.Add("minorTickWidth",MinorTickWidth);
			if (MinPadding != null) h.Add("minPadding",MinPadding);
			if (PanningEnabled != null) h.Add("panningEnabled",PanningEnabled);
			if (Reversed != null) h.Add("reversed",Reversed);
			if (ShowFirstLabel != null) h.Add("showFirstLabel",ShowFirstLabel);
			if (ShowInLegend != null) h.Add("showInLegend",ShowInLegend);
			if (ShowLastLabel != null) h.Add("showLastLabel",ShowLastLabel);
			if (SoftMax != null) h.Add("softMax",SoftMax);
			if (SoftMin != null) h.Add("softMin",SoftMin);
			if (StartOfWeek != null) h.Add("startOfWeek",StartOfWeek);
			if (StartOnTick != null) h.Add("startOnTick",StartOnTick);
			if (Stops != null) h.Add("stops", GetLists(Stops));
			if (TickAmount != null) h.Add("tickAmount",TickAmount);
			if (TickColor != null) h.Add("tickColor",TickColor);
			if (TickInterval != null) h.Add("tickInterval",TickInterval);
			if (TickLength != null) h.Add("tickLength",TickLength);
			if (TickmarkPlacement != ColorAxisTickmarkPlacement.Null) h.Add("tickmarkPlacement", highcharts.FirstCharacterToLower(TickmarkPlacement.ToString()));
			if (TickPixelInterval != null) h.Add("tickPixelInterval",TickPixelInterval);
			if (TickPosition != ColorAxisTickPosition.Null) h.Add("tickPosition", highcharts.FirstCharacterToLower(TickPosition.ToString()));
			if (TickPositioner != null) { h.Add("tickPositioner",TickPositioner); highcharts.AddFunction("tickPositioner", TickPositioner); }  
			if (TickPositions != null) h.Add("tickPositions",TickPositions);
			if (TickWidth != null) h.Add("tickWidth",TickWidth);
			if (Type != null) h.Add("type",Type);
			if (UniqueNames != null) h.Add("uniqueNames",UniqueNames);
			if (Visible != null) h.Add("visible",Visible);
			if (Width != null) h.Add("width",Width);
			if (WidthNumber != null) h.Add("width",WidthNumber);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
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
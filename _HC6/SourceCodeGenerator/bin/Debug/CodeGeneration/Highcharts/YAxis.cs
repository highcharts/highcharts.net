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
			EndOnTick = EndOnTick_DefaultValue = true;
			TickPixelInterval = TickPixelInterval_DefaultValue = 72;
			ShowLastLabel = ShowLastLabel_DefaultValue = false;
			Labels = Labels_DefaultValue = null;
			MaxPadding = MaxPadding_DefaultValue = 0.05;
			MinPadding = MinPadding_DefaultValue = 0.05;
			StartOnTick = StartOnTick_DefaultValue = true;
			Title = Title_DefaultValue = null;
			StackLabels = StackLabels_DefaultValue = null;
			GridLineWidth = GridLineWidth_DefaultValue = 1;
			LineWidth = LineWidth_DefaultValue = 0;
			Opposite = Opposite_DefaultValue = false;
			Angle = Angle_DefaultValue = 0;
			GridLineInterpolation = GridLineInterpolation_DefaultValue = "null";
			MaxColor = MaxColor_DefaultValue = "#003399";
			Min = Min_DefaultValue = null;
			MinColor = MinColor_DefaultValue = "#e6ebf5";
			ReversedStacks = ReversedStacks_DefaultValue = true;
			Stops = Stops_DefaultValue = new List<Stop>();
			TickWidth = TickWidth_DefaultValue = 0;
			PlotBands = PlotBands_DefaultValue = new List<YAxisPlotBands>();
			PlotLines = PlotLines_DefaultValue = new List<YAxisPlotLines>();
			TooltipValueFormat = TooltipValueFormat_DefaultValue = null;
			EndOnTick = EndOnTick_DefaultValue = true;
			TickPixelInterval = TickPixelInterval_DefaultValue = 72;
			ShowLastLabel = ShowLastLabel_DefaultValue = false;
			Labels = Labels_DefaultValue = "";
			X = X_DefaultValue = 0;
			Align = Align_DefaultValue = "";
			Distance = Distance_DefaultValue = -25;
			Y = Y_DefaultValue = null;
			MaxPadding = MaxPadding_DefaultValue = 0.05;
			MinPadding = MinPadding_DefaultValue = 0.05;
			StartOnTick = StartOnTick_DefaultValue = true;
			Title = Title_DefaultValue = "";
			Rotation = Rotation_DefaultValue = 270;
			Text = Text_DefaultValue = "Values";
			Margin = Margin_DefaultValue = null;
			StackLabels = StackLabels_DefaultValue = "";
			AllowOverlap = AllowOverlap_DefaultValue = False;
			Enabled = Enabled_DefaultValue = False;
			Formatter = Formatter_DefaultValue = "";
			Style = Style_DefaultValue = "";
			FontSize = FontSize_DefaultValue = 11px;
			FontWeight = FontWeight_DefaultValue = bold;
			Color = Color_DefaultValue = #000000;
			TextOutline = TextOutline_DefaultValue = 1px contrast;
			Align = Align_DefaultValue = "";
			Format = Format_DefaultValue = "{total}";
			Rotation = Rotation_DefaultValue = 0;
			TextAlign = TextAlign_DefaultValue = "";
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = "";
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			GridLineWidth = GridLineWidth_DefaultValue = 1;
			LineWidth = LineWidth_DefaultValue = 0;
			Opposite = Opposite_DefaultValue = false;
			Angle = Angle_DefaultValue = 0;
			GridLineInterpolation = GridLineInterpolation_DefaultValue = "null";
			MaxColor = MaxColor_DefaultValue = "#003399";
			Min = Min_DefaultValue = null;
			MinColor = MinColor_DefaultValue = "#e6ebf5";
			ReversedStacks = ReversedStacks_DefaultValue = true;
			Stops = Stops_DefaultValue = new List<Stop>();
			TickWidth = TickWidth_DefaultValue = 0;
			PlotBands = PlotBands_DefaultValue = new List<YAxisPlotBands>();
			InnerRadius = InnerRadius_DefaultValue = null;
			OuterRadius = OuterRadius_DefaultValue = 100%;
			Thickness = Thickness_DefaultValue = 10;
			PlotLines = PlotLines_DefaultValue = new List<YAxisPlotLines>();
			
		}	
		

		/// <summary>
		/// Parallel coordinates only. Format that will be used for point.yand available in [tooltip.pointFormat](#tooltip.pointFormat) as`{point.formattedValue}`. If not set, `{point.formattedValue}`will use other options, in this order:1. [yAxis.labels.format](#yAxis.labels.format) will be used if   set2. if yAxis is a category, then category name will be displayed3. if yAxis is a datetime, then value will use the same format as   yAxis labels4. if yAxis is linear/logarithmic type, then simple value will be   used
		/// </summary>
		public YAxisTooltipValueFormat TooltipValueFormat { get; set; }
		private YAxisTooltipValueFormat TooltipValueFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to end on a tick. Use this option withthe `maxPadding` option to control the axis end.
		/// </summary>
		public bool? EndOnTick { get; set; }
		private bool? EndOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisTickPixelInterval TickPixelInterval { get; set; }
		private YAxisTickPixelInterval TickPixelInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to show the last tick label. Defaults to `true` on cartesiancharts, and `false` on polar charts.
		/// </summary>
		public bool? ShowLastLabel { get; set; }
		private bool? ShowLastLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisLabels Labels { get; set; }
		private YAxisLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the max value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer. This is usefulwhen you don't want the highest data value to appear on the edgeof the plot area. When the axis' `max` option is set or a max extremeis set using `axis.setExtremes()`, the maxPadding will be ignored.
		/// </summary>
		public double? MaxPadding { get; set; }
		private double? MaxPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the min value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer. This is usefulwhen you don't want the lowest data value to appear on the edgeof the plot area. When the axis' `min` option is set or a max extremeis set using `axis.setExtremes()`, the maxPadding will be ignored.
		/// </summary>
		public double? MinPadding { get; set; }
		private double? MinPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to start on a tick. Use this option withthe `maxPadding` option to control the axis start.
		/// </summary>
		public bool? StartOnTick { get; set; }
		private bool? StartOnTick_DefaultValue { get; set; }
		 

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
		/// The width of the grid lines extending the ticks across the plotarea.
		/// </summary>
		public double? GridLineWidth { get; set; }
		private double? GridLineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the line marking the axis itself.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display the axis on the opposite side of the normal. Thenormal is on the left side for vertical axes and bottom for horizontal,so the opposite sides will be right and top respectively.
		/// </summary>
		public bool? Opposite { get; set; }
		private bool? Opposite_DefaultValue { get; set; }
		 

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
		/// The minimum value of the axis. If `null` the min value is automaticallycalculated.If the `startOnTick` option is true (default), the `min` value mightbe rounded down.The automatically calculated minimum value is also affected by [floor](#yAxis.floor), [softMin](#yAxis.softMin), [minPadding](#yAxis.minPadding),[minRange](#yAxis.minRange) as well as [series.threshold](#plotOptions.series.threshold) and [series.softThreshold](#plotOptions.series.softThreshold).
		/// </summary>
		public double? Min { get; set; }
		private double? Min_DefaultValue { get; set; }
		 

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
		/// Parallel coordinates only. Format that will be used for point.yand available in [tooltip.pointFormat](#tooltip.pointFormat) as`{point.formattedValue}`. If not set, `{point.formattedValue}`will use other options, in this order:1. [yAxis.labels.format](#yAxis.labels.format) will be used if   set2. if yAxis is a category, then category name will be displayed3. if yAxis is a datetime, then value will use the same format as   yAxis labels4. if yAxis is linear/logarithmic type, then simple value will be   used
		/// </summary>
		public YAxisTooltipValueFormat TooltipValueFormat { get; set; }
		private YAxisTooltipValueFormat TooltipValueFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to end on a tick. Use this option withthe `maxPadding` option to control the axis end.
		/// </summary>
		public bool? EndOnTick { get; set; }
		private bool? EndOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisTickPixelInterval TickPixelInterval { get; set; }
		private YAxisTickPixelInterval TickPixelInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to show the last tick label. Defaults to `true` on cartesiancharts, and `false` on polar charts.
		/// </summary>
		public bool? ShowLastLabel { get; set; }
		private bool? ShowLastLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisLabels Labels { get; set; }
		private YAxisLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the tick positionon the axis. Defaults to -15 for left axis, 15 for right axis.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// What part of the string the given position is anchored to. Can beone of `"left"`, `"center"` or `"right"`. The exact position alsodepends on the `labels.x` setting. Angular gauges and solid gaugesdefaults to `center`.
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Angular gauges and solid gauges only. The label's pixel distancefrom the perimeter of the plot area.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the tick positionon the axis.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the max value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer. This is usefulwhen you don't want the highest data value to appear on the edgeof the plot area. When the axis' `max` option is set or a max extremeis set using `axis.setExtremes()`, the maxPadding will be ignored.
		/// </summary>
		public double? MaxPadding { get; set; }
		private double? MaxPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding of the min value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer. This is usefulwhen you don't want the lowest data value to appear on the edgeof the plot area. When the axis' `min` option is set or a max extremeis set using `axis.setExtremes()`, the maxPadding will be ignored.
		/// </summary>
		public double? MinPadding { get; set; }
		private double? MinPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to start on a tick. Use this option withthe `maxPadding` option to control the axis start.
		/// </summary>
		public bool? StartOnTick { get; set; }
		private bool? StartOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisTitle Title { get; set; }
		private YAxisTitle Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// The rotation of the text in degrees. 0 is horizontal, 270 isvertical reading from bottom to top.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The actual text of the axis title. Horizontal texts can containHTML, but rotated texts are painted using vector techniques andmust be clean text. The Y axis title is disabled by setting the`text` option to `null`.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel distance between the axis labels and the title. Positivevalues are outside the axis line, negative are inside.
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// The stack labels show the total value for each bar in a stackedcolumn or bar chart. The label will be placed on top of positivecolumns and below negative columns. In case of an inverted columnchart or a bar chart the label is placed to the right of positivebars and to the left of negative bars.
		/// </summary>
		public YAxisStackLabels StackLabels { get; set; }
		private YAxisStackLabels StackLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow the stack labels to overlap.
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the stack total labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the label. The value isgiven by `this.total`. Defaults to:<pre>function() {    return this.total;}</pre>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the label.In styled mode, the styles are set in the`.highcharts-stack-label` class.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisFontSize FontSize { get; set; }
		private YAxisFontSize FontSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisFontWeight FontWeight { get; set; }
		private YAxisFontWeight FontWeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisColor Color { get; set; }
		private YAxisColor Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisTextOutline TextOutline { get; set; }
		private YAxisTextOutline TextOutline_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the horizontal alignment of the stack total label. Can beone of `"left"`, `"center"` or `"right"`. The default value is calculatedat runtime and depends on orientation and whether the stack is positiveor negative.
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// A [format string](http://docs.highcharts.com/#formatting) for thedata label. Available variables are the same as for `formatter`.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rotation of the labels in degrees.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text alignment for the label. While `align` determines wherethe texts anchor point is placed with regards to the stack, `textAlign`determines how the text is aligned against its anchor point. Possiblevalues are `"left"`, `"center"` and `"right"`. The default valueis calculated at runtime and depends on orientation and whether thestack is positive or negative.
		/// </summary>
		public string TextAlign { get; set; }
		private string TextAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the vertical alignment of the stack total label. Can be oneof `"top"`, `"middle"` or `"bottom"`. The default value is calculatedat runtime and depends on orientation and whether the stack is positiveor negative.
		/// </summary>
		public string VerticalAlign { get; set; }
		private string VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the left of the stackedbar. The default value is calculated at runtime and depends on orientationand whether the stack is positive or negative.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the tick positionon the axis. The default value is calculated at runtime and dependson orientation and whether the stack is positive or negative.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the grid lines extending the ticks across the plotarea.
		/// </summary>
		public double? GridLineWidth { get; set; }
		private double? GridLineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the line marking the axis itself.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display the axis on the opposite side of the normal. Thenormal is on the left side for vertical axes and bottom for horizontal,so the opposite sides will be right and top respectively.
		/// </summary>
		public bool? Opposite { get; set; }
		private bool? Opposite_DefaultValue { get; set; }
		 

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
		/// The minimum value of the axis. If `null` the min value is automaticallycalculated.If the `startOnTick` option is true (default), the `min` value mightbe rounded down.The automatically calculated minimum value is also affected by [floor](#yAxis.floor), [softMin](#yAxis.softMin), [minPadding](#yAxis.minPadding),[minRange](#yAxis.minRange) as well as [series.threshold](#plotOptions.series.threshold) and [series.softThreshold](#plotOptions.series.softThreshold).
		/// </summary>
		public double? Min { get; set; }
		private double? Min_DefaultValue { get; set; }
		 

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
		/// In a gauge chart, this option determines the inner radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.By default, the inner radius is controlled by the [thickness](#yAxis.plotBands.thickness) option.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option determines the outer radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.
		/// </summary>
		public double? OuterRadius { get; set; }
		private double? OuterRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option sets the width of the plot band stretchingalong the perimeter. It can be given as a percentage string, like`"10%"`, or as a pixel number, like `10`. The default value 10 isthe same as the default [tickLength](#yAxis.tickLength), thus makingthe plot band act as a background for the tick markers.
		/// </summary>
		public double? Thickness { get; set; }
		private double? Thickness_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of objects representing plot lines on the X axis
		/// </summary>
		public List<YAxisPlotLines> PlotLines { get; set; }
		private List<YAxisPlotLines> PlotLines_DefaultValue { get; set; }
		  

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
			if (Angle != Angle_DefaultValue) h.Add("angle",Angle);
			if (GridLineInterpolation != GridLineInterpolation_DefaultValue) h.Add("gridLineInterpolation",GridLineInterpolation);
			if (MaxColor != MaxColor_DefaultValue) h.Add("maxColor",MaxColor);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (MinColor != MinColor_DefaultValue) h.Add("minColor",MinColor);
			if (ReversedStacks != ReversedStacks_DefaultValue) h.Add("reversedStacks",ReversedStacks);
			if (Stops.Any()) h.Add("stops", GetLists(Stops));
			if (TickWidth != TickWidth_DefaultValue) h.Add("tickWidth",TickWidth);
			if (PlotBands != PlotBands_DefaultValue) h.Add("plotBands", HashifyList(PlotBands));
			if (PlotLines != PlotLines_DefaultValue) h.Add("plotLines", HashifyList(PlotLines));
			if (TooltipValueFormat != TooltipValueFormat_DefaultValue) h.Add("tooltipValueFormat",TooltipValueFormat);
			if (EndOnTick != EndOnTick_DefaultValue) h.Add("endOnTick",EndOnTick);
			if (TickPixelInterval != TickPixelInterval_DefaultValue) h.Add("tickPixelInterval",TickPixelInterval);
			if (ShowLastLabel != ShowLastLabel_DefaultValue) h.Add("showLastLabel",ShowLastLabel);
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (X != X_DefaultValue) h.Add("x",X);
			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (MaxPadding != MaxPadding_DefaultValue) h.Add("maxPadding",MaxPadding);
			if (MinPadding != MinPadding_DefaultValue) h.Add("minPadding",MinPadding);
			if (StartOnTick != StartOnTick_DefaultValue) h.Add("startOnTick",StartOnTick);
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (StackLabels.IsDirty()) h.Add("stackLabels",StackLabels.ToHashtable());
			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (FontSize != FontSize_DefaultValue) h.Add("fontSize",FontSize);
			if (FontWeight != FontWeight_DefaultValue) h.Add("fontWeight",FontWeight);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (TextOutline != TextOutline_DefaultValue) h.Add("textOutline",TextOutline);
			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (TextAlign != TextAlign_DefaultValue) h.Add("textAlign",TextAlign);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (GridLineWidth != GridLineWidth_DefaultValue) h.Add("gridLineWidth",GridLineWidth);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Opposite != Opposite_DefaultValue) h.Add("opposite",Opposite);
			if (Angle != Angle_DefaultValue) h.Add("angle",Angle);
			if (GridLineInterpolation != GridLineInterpolation_DefaultValue) h.Add("gridLineInterpolation",GridLineInterpolation);
			if (MaxColor != MaxColor_DefaultValue) h.Add("maxColor",MaxColor);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (MinColor != MinColor_DefaultValue) h.Add("minColor",MinColor);
			if (ReversedStacks != ReversedStacks_DefaultValue) h.Add("reversedStacks",ReversedStacks);
			if (Stops.Any()) h.Add("stops", GetLists(Stops));
			if (TickWidth != TickWidth_DefaultValue) h.Add("tickWidth",TickWidth);
			if (PlotBands != PlotBands_DefaultValue) h.Add("plotBands", HashifyList(PlotBands));
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (OuterRadius != OuterRadius_DefaultValue) h.Add("outerRadius",OuterRadius);
			if (Thickness != Thickness_DefaultValue) h.Add("thickness",Thickness);
			if (PlotLines != PlotLines_DefaultValue) h.Add("plotLines", HashifyList(PlotLines));
			

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
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
	public partial class ZAxis  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ZAxis()
		{
		}	
		

		/// <summary>
		/// Accessibility options for an axis. Requires the accessibility module.
		/// </summary>
		public ZAxisAccessibility Accessibility { get; set; }
		 

		/// <summary>
		/// When using multiple axis, the ticks of two or more opposite axeswill automatically be aligned by adding ticks to the axis or axeswith the least ticks, as if `tickAmount` were specified.This can be prevented by setting `alignTicks` to false. If the gridlines look messy, it's a good idea to hide them for the secondaryaxis by setting `gridLineWidth` to 0.If `startOnTick` or `endOnTick` in an Axis options are set to false,then the `alignTicks ` will be disabled for the Axis.Disabled for logarithmic axes.
		/// </summary>
		public bool? AlignTicks { get; set; }
		 

		/// <summary>
		/// Whether to allow decimals in this axis' ticks. When countingintegers, like persons or hits on a web page, decimals shouldbe avoided in the labels. By default, decimals are allowed on smallscale axes.
		/// </summary>
		public bool? AllowDecimals { get; set; }
		 

		/// <summary>
		/// When using an alternate grid color, a band is painted across theplot area between every other grid line.
		/// </summary>
		public string AlternateGridColor { get; set; }
		 

		/// <summary>
		/// In a polar chart, this is the angle of the Y axis in degrees, where0 is up and 90 is right. The angle determines the position of theaxis line and the labels, though the coordinate system is unaffected.Since v8.0.0 this option is also applicable for X axis (invertedpolar).
		/// </summary>
		public double? Angle { get; set; }
		 

		/// <summary>
		/// If categories are present for the xAxis, names are used instead ofnumbers for that axis.Since Highcharts 3.0, categories can alsobe extracted by giving each point a [name](#series.data) and settingaxis [type](#xAxis.type) to `category`. However, if you have multipleseries, best practice remains defining the `categories` array.Example: `categories: ['Apples', 'Bananas', 'Oranges']`
		/// </summary>
		public List<string> Categories { get; set; }
		 

		/// <summary>
		/// The highest allowed value for automatically computed axis extremes.
		/// </summary>
		public double? Ceiling { get; set; }
		 

		/// <summary>
		/// A class name that opens for styling the axis by CSS, especially inHighcharts styled mode. The class name is applied to group elementsfor the grid, axis elements and labels.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// The value on a perpendicular axis where this axis should cross. Thisis typically used on mathematical plots where the axes cross at 0.When `crossing` is set, space will not be reserved at the sides ofthe chart for axis labels and title, so those may be clipped. In thiscase it is better to place the axes without the `crossing` option.
		/// </summary>
		public double? Crossing { get; set; }
		 

		/// <summary>
		/// For a datetime axis, the scale will automatically adjust to theappropriate unit. This member gives the default stringrepresentations used for each unit. For intermediate values,different units may be used, for example the `day` unit can be usedon midnight and `hour` unit be used for intermediate values on thesame axis.For an overview of the replacement codes, see[dateFormat](/class-reference/Highcharts.Time#dateFormat).Defaults to:```js{    millisecond: '%H:%M:%S.%L',    second: '%H:%M:%S',    minute: '%H:%M',    hour: '%H:%M',    day: '%e. %b',    week: '%e. %b',    month: '%b \'%y',    year: '%Y'}```
		/// </summary>
		public Hashtable DateTimeLabelFormats { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to end on a tick. Use this option withthe `maxPadding` option to control the axis end.
		/// </summary>
		public bool? EndOnTick { get; set; }
		 

		/// <summary>
		/// Event handlers for the axis.
		/// </summary>
		public ZAxisEvents Events { get; set; }
		 

		/// <summary>
		/// The lowest allowed value for automatically computed axis extremes.
		/// </summary>
		public double? Floor { get; set; }
		 

		/// <summary>
		/// Color of the grid lines extending the ticks across the plot area.In styled mode, the stroke is given in the `.highcharts-grid-line`class.
		/// </summary>
		public string GridLineColor { get; set; }
		 

		/// <summary>
		/// The dash or dot style of the grid lines. For possible values, see[this demonstration](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/).
		/// </summary>
		public Hashtable GridLineDashStyle { get; set; }
		 

		/// <summary>
		/// Polar charts only. Whether the grid lines should draw as a polygonwith straight lines between categories, or as circles. Can be either`circle` or `polygon`. Since v8.0.0 this option is also applicablefor X axis (inverted polar).
		/// </summary>
		public ZAxisGridLineInterpolation GridLineInterpolation { get; set; }
		 

		/// <summary>
		/// The width of the grid lines extending the ticks across the plot area.Defaults to 1 on the Y axis and 0 on the X axis, except for 3dcharts.In styled mode, the stroke width is given in the`.highcharts-grid-line` class.
		/// </summary>
		public double? GridLineWidth { get; set; }
		 

		/// <summary>
		/// The Z index of the grid lines.
		/// </summary>
		public double? GridZIndex { get; set; }
		 

		/// <summary>
		/// An id for the axis. This can be used after render time to geta pointer to the axis object through `chart.get()`.
		/// </summary>
		public string Id { get; set; }
		 

		/// <summary>
		/// The axis labels show the number or category for each tick.Since v8.0.0: Labels are animated in categorized x-axis withupdating data if `tickInterval` and `step` is set to 1.
		/// </summary>
		public ZAxisLabels Labels { get; set; }
		 

		/// <summary>
		/// Index of another axis that this axis is linked to. When an axis islinked to a master axis, it will take the same extremes asthe master, but as assigned by min or max or by setExtremes.It can be used to show additional info, or to ease reading thechart by duplicating the scales.
		/// </summary>
		public double? LinkedTo { get; set; }
		 

		/// <summary>
		/// If there are multiple axes on the same side of the chart, the pixelmargin between the axes. Defaults to 0 on vertical axes, 15 onhorizontal axes.
		/// </summary>
		public double? Margin { get; set; }
		 

		/// <summary>
		/// The maximum value of the axis. If `null`, the max value isautomatically calculated.If the [endOnTick](#yAxis.endOnTick) option is true, the `max` valuemight be rounded up.If a [tickAmount](#yAxis.tickAmount) is set, the axis may be extendedbeyond the set max in order to reach the given number of ticks. Thesame may happen in a chart with multiple axes, determined by [chart.alignTicks](#chart), where a `tickAmount` is applied internally.
		/// </summary>
		public double? Max { get; set; }
		 

		/// <summary>
		/// Padding of the max value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer. This is usefulwhen you don't want the highest data value to appear on the edgeof the plot area. When the axis' `max` option is set or a max extremeis set using `axis.setExtremes()`, the maxPadding will be ignored.
		/// </summary>
		public double? MaxPadding { get; set; }
		 

		/// <summary>
		/// Deprecated. Use `minRange` instead.
		/// </summary>
		public double? MaxZoom { get; set; }
		 

		/// <summary>
		/// The minimum value of the axis. If `null` the min value isautomatically calculated.If the [startOnTick](#yAxis.startOnTick) option is true (default),the `min` value might be rounded down.The automatically calculated minimum value is also affected by[floor](#yAxis.floor), [softMin](#yAxis.softMin),[minPadding](#yAxis.minPadding), [minRange](#yAxis.minRange)as well as [series.threshold](#plotOptions.series.threshold)and [series.softThreshold](#plotOptions.series.softThreshold).
		/// </summary>
		public double? Min { get; set; }
		 

		/// <summary>
		/// Color of the minor, secondary grid lines.In styled mode, the stroke width is given in the`.highcharts-minor-grid-line` class.
		/// </summary>
		public string MinorGridLineColor { get; set; }
		 

		/// <summary>
		/// The dash or dot style of the minor grid lines. For possible values,see [this demonstration](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/).
		/// </summary>
		public Hashtable MinorGridLineDashStyle { get; set; }
		 

		/// <summary>
		/// Width of the minor, secondary grid lines.In styled mode, the stroke width is given in the`.highcharts-grid-line` class.
		/// </summary>
		public double? MinorGridLineWidth { get; set; }
		 

		/// <summary>
		/// Color for the minor tick marks.
		/// </summary>
		public string MinorTickColor { get; set; }
		 

		/// <summary>
		/// Specific tick interval in axis units for the minor ticks. On a linearaxis, if `"auto"`, the minor tick interval is calculated as a fifthof the tickInterval. If `undefined`, minor ticks are not shown.On logarithmic axes, the unit is the power of the value. For example,setting the minorTickInterval to 1 puts one tick on each of 0.1, 1,10, 100 etc. Setting the minorTickInterval to 0.1 produces 9 ticksbetween 1 and 10, 10 and 100 etc.If user settings dictate minor ticks to become too dense, they don'tmake sense, and will be ignored to prevent performance problems.
		/// </summary>
		public string MinorTickInterval { get; set; }
		 

		/// <summary>
		/// Specific tick interval in axis units for the minor ticks. On a linearaxis, if `"auto"`, the minor tick interval is calculated as a fifthof the tickInterval. If `undefined`, minor ticks are not shown.On logarithmic axes, the unit is the power of the value. For example,setting the minorTickInterval to 1 puts one tick on each of 0.1, 1,10, 100 etc. Setting the minorTickInterval to 0.1 produces 9 ticksbetween 1 and 10, 10 and 100 etc.If user settings dictate minor ticks to become too dense, they don'tmake sense, and will be ignored to prevent performance problems.
		/// </summary>
		public double? MinorTickIntervalNumber { get; set; }
		 

		/// <summary>
		/// The pixel length of the minor tick marks.
		/// </summary>
		public double? MinorTickLength { get; set; }
		 

		/// <summary>
		/// The position of the minor tick marks relative to the axis line. Can be one of `inside` and `outside`.
		/// </summary>
		public ZAxisMinorTickPosition MinorTickPosition { get; set; }
		 

		/// <summary>
		/// Enable or disable minor ticks. The interval between the minor tickscan be controlled either by the[minorTicksPerMajor](#xAxis.minorTicksPerMajor) setting, or as anabsolute [minorTickInterval](#xAxis.minorTickInterval) value.On a logarithmic axis, minor ticks are laid out based on a bestguess, attempting to enter an approximate number of minor ticksbetween each major tick based on[minorTicksPerMajor](#xAxis.minorTicksPerMajor).Prior to v6.0.0, ticks were enabled in auto layout by setting`minorTickInterval` to `"auto"`.
		/// </summary>
		public bool? MinorTicks { get; set; }
		 

		/// <summary>
		/// The number of minor ticks per major tick. Works for `linear`,`logarithmic` and `datetime` axes.
		/// </summary>
		public double? MinorTicksPerMajor { get; set; }
		 

		/// <summary>
		/// The pixel width of the minor tick mark.
		/// </summary>
		public double? MinorTickWidth { get; set; }
		 

		/// <summary>
		/// Padding of the min value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer. This is usefulwhen you don't want the lowest data value to appear on the edgeof the plot area. When the axis' `min` option is set or a min extremeis set using `axis.setExtremes()`, the minPadding will be ignored.
		/// </summary>
		public double? MinPadding { get; set; }
		 

		/// <summary>
		/// The minimum range to display on this axis. The entire axis will notbe allowed to span over a smaller interval than this. For example,for a datetime axis the main unit is milliseconds. If minRange isset to 3600000, you can't zoom in more than to one hour.The default minRange for the x axis is five times the smallestinterval between any of the data points.On a logarithmic axis, the unit for the minimum range is the power.So a minRange of 1 means that the axis can be zoomed to 10-100,100-1000, 1000-10000 etc.**Note**: The `minPadding`, `maxPadding`, `startOnTick` and`endOnTick` settings also affect how the extremes of the axisare computed.
		/// </summary>
		public double? MinRange { get; set; }
		 

		/// <summary>
		/// The minimum tick interval allowed in axis values. For example onzooming in on an axis with daily data, this can be used to preventthe axis from showing hours. Defaults to the closest distance betweentwo points on the axis.
		/// </summary>
		public double? MinTickInterval { get; set; }
		 

		/// <summary>
		/// The distance in pixels from the plot area to the axis line.A positive offset moves the axis with it's line, labels and ticksaway from the plot area. This is typically used when two or moreaxes are displayed on the same side of the plot. With multipleaxes the offset is dynamically adjusted to avoid collision, thiscan be overridden by setting offset explicitly.
		/// </summary>
		public double? Offset { get; set; }
		 

		/// <summary>
		/// Whether to display the axis on the opposite side of the normal. Thenormal is on the left side for vertical axes and bottom forhorizontal, so the opposite sides will be right and top respectively.This is typically used with dual or multiple axes.
		/// </summary>
		public bool? Opposite { get; set; }
		 

		/// <summary>
		/// Refers to the index in the [panes](#panes) array. Used for circulargauges and polar charts. When the option is not set then first panewill be used.
		/// </summary>
		public double? Pane { get; set; }
		 

		/// <summary>
		/// Whether to pan axis. If `chart.panning` is enabled, the optionallows to disable panning on an individual axis.
		/// </summary>
		public bool? PanningEnabled { get; set; }
		 

		/// <summary>
		/// An array of colored bands stretching across the plot area marking aninterval on the axis.In styled mode, the plot bands are styled by the `.highcharts-plot-band`class in addition to the `className` option.
		/// </summary>
		public List<ZAxisPlotBands> PlotBands { get; set; }
		 

		/// <summary>
		/// An array of lines stretching across the plot area, marking a specificvalue on one of the axes.In styled mode, the plot lines are styled by the`.highcharts-plot-line` class in addition to the `className` option.
		/// </summary>
		public List<ZAxisPlotLines> PlotLines { get; set; }
		 

		/// <summary>
		/// Whether to reverse the axis so that the highest number is closestto the origin. If the chart is inverted, the x axis is reversed bydefault.
		/// </summary>
		public bool? Reversed { get; set; }
		 

		/// <summary>
		/// This option determines how stacks should be ordered within a group.For example reversed xAxis also reverses stacks, so first seriescomes last in a group. To keep order like for non-reversed xAxisenable this option.
		/// </summary>
		public bool? ReversedStacks { get; set; }
		 

		/// <summary>
		/// Whether to show the first tick label.
		/// </summary>
		public bool? ShowFirstLabel { get; set; }
		 

		/// <summary>
		/// Whether to show the last tick label. Defaults to `true` on cartesiancharts, and `false` on polar charts.
		/// </summary>
		public bool? ShowLastLabel { get; set; }
		 

		/// <summary>
		/// A soft maximum for the axis. If the series data maximum is less thanthis, the axis will stay at this maximum, but if the series datamaximum is higher, the axis will flex to show all data.
		/// </summary>
		public double? SoftMax { get; set; }
		 

		/// <summary>
		/// A soft minimum for the axis. If the series data minimum is greaterthan this, the axis will stay at this minimum, but if the seriesdata minimum is lower, the axis will flex to show all data.
		/// </summary>
		public double? SoftMin { get; set; }
		 

		/// <summary>
		/// For datetime axes, this decides where to put the tick between weeks. 0 = Sunday, 1 = Monday.
		/// </summary>
		public double? StartOfWeek { get; set; }
		 

		/// <summary>
		/// Whether to force the axis to start on a tick. Use this option withthe `minPadding` option to control the axis start.
		/// </summary>
		public bool? StartOnTick { get; set; }
		 

		/// <summary>
		/// The amount of ticks to draw on the axis. This opens up for aligningthe ticks of multiple charts or panes within a chart. This optionoverrides the `tickPixelInterval` option.This option only has an effect on linear axes. Datetime, logarithmicor category axes are not affected.
		/// </summary>
		public double? TickAmount { get; set; }
		 

		/// <summary>
		/// Color for the main tick marks.In styled mode, the stroke is given in the `.highcharts-tick`class.
		/// </summary>
		public string TickColor { get; set; }
		 

		/// <summary>
		/// The interval of the tick marks in axis units. When `undefined`, thetick interval is computed to approximately follow the[tickPixelInterval](#xAxis.tickPixelInterval) on linear and datetimeaxes. On categorized axes, a `undefined` tickInterval will default to1, one category. Note that datetime axes are based on milliseconds,so for example an interval of one day is expressed as`24 * 3600 * 1000`.On logarithmic axes, the tickInterval is based on powers, so atickInterval of 1 means one tick on each of 0.1, 1, 10, 100 etc. AtickInterval of 2 means a tick of 0.1, 10, 1000 etc. A tickIntervalof 0.2 puts a tick on 0.1, 0.2, 0.4, 0.6, 0.8, 1, 2, 4, 6, 8, 10, 20,40 etc.If the tickInterval is too dense for labels to be drawn, Highchartsmay remove ticks.If the chart has multiple axes, the [alignTicks](#chart.alignTicks)option may interfere with the `tickInterval` setting.
		/// </summary>
		public double? TickInterval { get; set; }
		 

		/// <summary>
		/// The pixel length of the main tick marks.
		/// </summary>
		public double? TickLength { get; set; }
		 

		/// <summary>
		/// For categorized axes only. If `on` the tick mark is placed in thecenter of the category, if `between` the tick mark is placed betweencategories. The default is `between` if the `tickInterval` is 1, else`on`. In order to render tick marks on a category axis it is necessaryto provide a [tickWidth](#xAxis.tickWidth).
		/// </summary>
		public ZAxisTickmarkPlacement TickmarkPlacement { get; set; }
		 

		/// <summary>
		/// If tickInterval is `null` this option sets the approximate pixelinterval of the tick marks. Not applicable to categorized axis.The tick interval is also influenced by the [minTickInterval](#xAxis.minTickInterval) option, that, by default prevents ticks frombeing denser than the data points.
		/// </summary>
		public double? TickPixelInterval { get; set; }
		 

		/// <summary>
		/// The position of the major tick marks relative to the axis line.Can be one of `inside` and `outside`.
		/// </summary>
		public ZAxisTickPosition TickPosition { get; set; }
		 

		/// <summary>
		/// A callback function returning array defining where the ticks arelaid out on the axis. This overrides the default behaviour of[tickPixelInterval](#xAxis.tickPixelInterval) and [tickInterval](#xAxis.tickInterval). The automatic tick positions are accessiblethrough `this.tickPositions` and can be modified by the callback.
		/// </summary>
		public string TickPositioner { get; set; }
		 

		/// <summary>
		/// An array defining where the ticks are laid out on the axis. Thisoverrides the default behaviour of [tickPixelInterval](#xAxis.tickPixelInterval) and [tickInterval](#xAxis.tickInterval).
		/// </summary>
		public List<double> TickPositions { get; set; }
		 

		/// <summary>
		/// The pixel width of the major tick marks. Defaults to 0 on categoryaxes, otherwise 1.In styled mode, the stroke width is given in the `.highcharts-tick`class, but in order for the element to be generated on category axes,the option must be explicitly set to 1.
		/// </summary>
		public double? TickWidth { get; set; }
		 

		/// <summary>
		/// The axis title, showing next to the axis line.
		/// </summary>
		public ZAxisTitle Title { get; set; }
		 

		/// <summary>
		/// The type of axis. Can be one of `linear`, `logarithmic`, `datetime`or `category`. In a datetime axis, the numbers are given inmilliseconds, and tick marks are placed on appropriate values likefull hours or days. In a category axis, the[point names](#series.line.data.name) of the chart's series are usedfor categories, if not a [categories](#xAxis.categories) array isdefined.
		/// </summary>
		public string Type { get; set; }
		 

		/// <summary>
		/// Applies only when the axis `type` is `category`. When `uniqueNames`is true, points are placed on the X axis according to their names.If the same point name is repeated in the same or another series,the point is placed on the same X position as other points of thesame name. When `uniqueNames` is false, the points are laid out inincreasing X positions regardless of their names, and the X axiscategory will take the name of the last point in each position.
		/// </summary>
		public bool? UniqueNames { get; set; }
		 

		/// <summary>
		/// Whether axis, including axis title, line, ticks and labels, shouldbe visible.
		/// </summary>
		public bool? Visible { get; set; }
		 

		/// <summary>
		/// The Z index for the axis group.
		/// </summary>
		public double? ZIndex { get; set; }
		 

		/// <summary>
		/// Whether to zoom axis. If `chart.zoomType` is set, the option allowsto disable zooming on an individual axis.
		/// </summary>
		public bool? ZoomEnabled { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (AlignTicks != null) h.Add("alignTicks",AlignTicks);
			if (AllowDecimals != null) h.Add("allowDecimals",AllowDecimals);
			if (AlternateGridColor != null) h.Add("alternateGridColor",AlternateGridColor);
			if (Angle != null) h.Add("angle",Angle);
			if (Categories != null) h.Add("categories",Categories);
			if (Ceiling != null) h.Add("ceiling",Ceiling);
			if (ClassName != null) h.Add("className",ClassName);
			if (Crossing != null) h.Add("crossing",Crossing);
			if (DateTimeLabelFormats != null) h.Add("dateTimeLabelFormats",DateTimeLabelFormats);
			if (EndOnTick != null) h.Add("endOnTick",EndOnTick);
			if (Events != null) h.Add("events",Events.ToHashtable(highcharts));
			if (Floor != null) h.Add("floor",Floor);
			if (GridLineColor != null) h.Add("gridLineColor",GridLineColor);
			if (GridLineDashStyle != null) h.Add("gridLineDashStyle",GridLineDashStyle);
			if (GridLineInterpolation != ZAxisGridLineInterpolation.Null) h.Add("gridLineInterpolation", highcharts.FirstCharacterToLower(GridLineInterpolation.ToString()));
			if (GridLineWidth != null) h.Add("gridLineWidth",GridLineWidth);
			if (GridZIndex != null) h.Add("gridZIndex",GridZIndex);
			if (Id != null) h.Add("id",Id);
			if (Labels != null) h.Add("labels",Labels.ToHashtable(highcharts));
			if (LinkedTo != null) h.Add("linkedTo",LinkedTo);
			if (Margin != null) h.Add("margin",Margin);
			if (Max != null) h.Add("max",Max);
			if (MaxPadding != null) h.Add("maxPadding",MaxPadding);
			if (MaxZoom != null) h.Add("maxZoom",MaxZoom);
			if (Min != null) h.Add("min",Min);
			if (MinorGridLineColor != null) h.Add("minorGridLineColor",MinorGridLineColor);
			if (MinorGridLineDashStyle != null) h.Add("minorGridLineDashStyle",MinorGridLineDashStyle);
			if (MinorGridLineWidth != null) h.Add("minorGridLineWidth",MinorGridLineWidth);
			if (MinorTickColor != null) h.Add("minorTickColor",MinorTickColor);
			if (MinorTickInterval != null) h.Add("minorTickInterval",MinorTickInterval);
			if (MinorTickIntervalNumber != null) h.Add("minorTickInterval",MinorTickIntervalNumber);
			if (MinorTickLength != null) h.Add("minorTickLength",MinorTickLength);
			if (MinorTickPosition != ZAxisMinorTickPosition.Null) h.Add("minorTickPosition", highcharts.FirstCharacterToLower(MinorTickPosition.ToString()));
			if (MinorTicks != null) h.Add("minorTicks",MinorTicks);
			if (MinorTicksPerMajor != null) h.Add("minorTicksPerMajor",MinorTicksPerMajor);
			if (MinorTickWidth != null) h.Add("minorTickWidth",MinorTickWidth);
			if (MinPadding != null) h.Add("minPadding",MinPadding);
			if (MinRange != null) h.Add("minRange",MinRange);
			if (MinTickInterval != null) h.Add("minTickInterval",MinTickInterval);
			if (Offset != null) h.Add("offset",Offset);
			if (Opposite != null) h.Add("opposite",Opposite);
			if (Pane != null) h.Add("pane",Pane);
			if (PanningEnabled != null) h.Add("panningEnabled",PanningEnabled);
			if (PlotBands != null) h.Add("plotBands", HashifyList(highcharts,PlotBands));
			if (PlotLines != null) h.Add("plotLines", HashifyList(highcharts,PlotLines));
			if (Reversed != null) h.Add("reversed",Reversed);
			if (ReversedStacks != null) h.Add("reversedStacks",ReversedStacks);
			if (ShowFirstLabel != null) h.Add("showFirstLabel",ShowFirstLabel);
			if (ShowLastLabel != null) h.Add("showLastLabel",ShowLastLabel);
			if (SoftMax != null) h.Add("softMax",SoftMax);
			if (SoftMin != null) h.Add("softMin",SoftMin);
			if (StartOfWeek != null) h.Add("startOfWeek",StartOfWeek);
			if (StartOnTick != null) h.Add("startOnTick",StartOnTick);
			if (TickAmount != null) h.Add("tickAmount",TickAmount);
			if (TickColor != null) h.Add("tickColor",TickColor);
			if (TickInterval != null) h.Add("tickInterval",TickInterval);
			if (TickLength != null) h.Add("tickLength",TickLength);
			if (TickmarkPlacement != ZAxisTickmarkPlacement.Null) h.Add("tickmarkPlacement", highcharts.FirstCharacterToLower(TickmarkPlacement.ToString()));
			if (TickPixelInterval != null) h.Add("tickPixelInterval",TickPixelInterval);
			if (TickPosition != ZAxisTickPosition.Null) h.Add("tickPosition", highcharts.FirstCharacterToLower(TickPosition.ToString()));
			if (TickPositioner != null) { h.Add("tickPositioner",TickPositioner); highcharts.AddFunction("tickPositioner", TickPositioner); }  
			if (TickPositions != null) h.Add("tickPositions",TickPositions);
			if (TickWidth != null) h.Add("tickWidth",TickWidth);
			if (Title != null) h.Add("title",Title.ToHashtable(highcharts));
			if (Type != null) h.Add("type",Type);
			if (UniqueNames != null) h.Add("uniqueNames",UniqueNames);
			if (Visible != null) h.Add("visible",Visible);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
			if (ZoomEnabled != null) h.Add("zoomEnabled",ZoomEnabled);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}
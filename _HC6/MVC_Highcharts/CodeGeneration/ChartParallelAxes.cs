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
	public partial class ChartParallelAxes  : BaseObject
	{
		public ChartParallelAxes()
		{
			LineWidth = LineWidth_DefaultValue = null;
			Labels = Labels_DefaultValue = new ChartParallelAxesLabels();
			Offset = Offset_DefaultValue = null;
			TooltipValueFormat = TooltipValueFormat_DefaultValue = "undefined";
			EndOnTick = EndOnTick_DefaultValue = true;
			TickPixelInterval = TickPixelInterval_DefaultValue = null;
			ShowLastLabel = ShowLastLabel_DefaultValue = false;
			MaxPadding = MaxPadding_DefaultValue = 0.05;
			MinPadding = MinPadding_DefaultValue = 0.05;
			StartOnTick = StartOnTick_DefaultValue = true;
			Min = Min_DefaultValue = null;
			ReversedStacks = ReversedStacks_DefaultValue = true;
			TickWidth = TickWidth_DefaultValue = 0;
			DateTimeLabelFormats = DateTimeLabelFormats_DefaultValue = new Hashtable();
			MinorTickLength = MinorTickLength_DefaultValue = 2;
			MinorTickPosition = MinorTickPosition_DefaultValue = ChartParallelAxesMinorTickPosition.Outside;
			StartOfWeek = StartOfWeek_DefaultValue = 1;
			TickLength = TickLength_DefaultValue = 10;
			TickmarkPlacement = TickmarkPlacement_DefaultValue = ChartParallelAxesTickmarkPlacement.Null;
			TickPosition = TickPosition_DefaultValue = ChartParallelAxesTickPosition.Outside;
			Type = Type_DefaultValue = ChartParallelAxesType.Linear;
			MinorTickColor = MinorTickColor_DefaultValue = "#999999";
			LineColor = LineColor_DefaultValue = "#ccd6eb";
			TickColor = TickColor_DefaultValue = "#ccd6eb";
			AllowDecimals = AllowDecimals_DefaultValue = true;
			Categories = Categories_DefaultValue = null;
			Ceiling = Ceiling_DefaultValue = null;
			ClassName = ClassName_DefaultValue = null;
			Description = Description_DefaultValue = "undefined";
			Floor = Floor_DefaultValue = null;
			GridZIndex = GridZIndex_DefaultValue = 1;
			LinkedTo = LinkedTo_DefaultValue = null;
			Max = Max_DefaultValue = null;
			MinRange = MinRange_DefaultValue = null;
			MinTickInterval = MinTickInterval_DefaultValue = null;
			MinorTickInterval = MinorTickInterval_DefaultValue = null;
			MinorTicks = MinorTicks_DefaultValue = false;
			MinorTickWidth = MinorTickWidth_DefaultValue = 0;
			Reversed = Reversed_DefaultValue = false;
			ShowEmpty = ShowEmpty_DefaultValue = true;
			ShowFirstLabel = ShowFirstLabel_DefaultValue = true;
			TickAmount = TickAmount_DefaultValue = null;
			TickInterval = TickInterval_DefaultValue = null;
			TickPositioner = TickPositioner_DefaultValue = "";
			TickPositions = TickPositions_DefaultValue = null;
			UniqueNames = UniqueNames_DefaultValue = true;
			Visible = Visible_DefaultValue = true;
			Crosshair = Crosshair_DefaultValue = new ChartParallelAxesCrosshair();
			Events = Events_DefaultValue = new ChartParallelAxesEvents();
			
		}	
		

		/// <summary>
		/// <p>The width of the line marking the axis itself.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The axis labels show the number or category for each tick.</p>
		/// </summary>
		public ChartParallelAxesLabels Labels { get; set; }
		private ChartParallelAxesLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The distance in pixels from the plot area to the axis line. A positiveoffset moves the axis with it&#39;s line, labels and ticks away fromthe plot area. This is typically used when two or more axes are displayedon the same side of the plot. With multiple axes the offset is dynamicallyadjusted to avoid collision, this can be overridden by setting offsetexplicitly.</p>
		/// </summary>
		public double? Offset { get; set; }
		private double? Offset_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Parallel coordinates only. Format that will be used for point.yand available in <a href="#tooltip.pointFormat">tooltip.pointFormat</a> as<code>{point.formattedValue}</code>. If not set, <code>{point.formattedValue}</code>will use other options, in this order:</p><ol><li><a href="#yAxis.labels.format">yAxis.labels.format</a> will be used ifset</li><li>if yAxis is a category, then category name will be displayed</li><li>if yAxis is a datetime, then value will use the same format asyAxis labels</li><li>if yAxis is linear/logarithmic type, then simple value will beused</li></ol>
		/// </summary>
		public string TooltipValueFormat { get; set; }
		private string TooltipValueFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to force the axis to end on a tick. Use this option withthe <code>maxPadding</code> option to control the axis end.</p>
		/// </summary>
		public bool? EndOnTick { get; set; }
		private bool? EndOnTick_DefaultValue { get; set; }
		 

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
		/// <p>Padding of the max value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer. This is usefulwhen you don&#39;t want the highest data value to appear on the edgeof the plot area. When the axis&#39; <code>max</code> option is set or a max extremeis set using <code>axis.setExtremes()</code>, the maxPadding will be ignored.</p>
		/// </summary>
		public double? MaxPadding { get; set; }
		private double? MaxPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Padding of the min value relative to the length of the axis. Apadding of 0.05 will make a 100px axis 5px longer. This is usefulwhen you don&#39;t want the lowest data value to appear on the edgeof the plot area. When the axis&#39; <code>min</code> option is set or a max extremeis set using <code>axis.setExtremes()</code>, the maxPadding will be ignored.</p>
		/// </summary>
		public double? MinPadding { get; set; }
		private double? MinPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to force the axis to start on a tick. Use this option withthe <code>maxPadding</code> option to control the axis start.</p>
		/// </summary>
		public bool? StartOnTick { get; set; }
		private bool? StartOnTick_DefaultValue { get; set; }
		 

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
		/// <p>The pixel width of the major tick marks.</p>
		/// </summary>
		public double? TickWidth { get; set; }
		private double? TickWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For a datetime axis, the scale will automatically adjust to theappropriate unit. This member gives the default stringrepresentations used for each unit. For intermediate values,different units may be used, for example the <code>day</code> unit can be usedon midnight and <code>hour</code> unit be used for intermediate values on thesame axis. For an overview of the replacement codes, see<a href="#Highcharts.dateFormat">dateFormat</a>. Defaults to:</p><pre>{    millisecond: '%H:%M:%S.%L',    second: '%H:%M:%S',    minute: '%H:%M',    hour: '%H:%M',    day: '%e. %b',    week: '%e. %b',    month: '%b \'%y',    year: '%Y'}</pre>
		/// </summary>
		public Hashtable DateTimeLabelFormats { get; set; }
		private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel length of the minor tick marks.</p>
		/// </summary>
		public double? MinorTickLength { get; set; }
		private double? MinorTickLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The position of the minor tick marks relative to the axis line. Can be one of <code>inside</code> and <code>outside</code>.</p>
		/// </summary>
		public ChartParallelAxesMinorTickPosition MinorTickPosition { get; set; }
		private ChartParallelAxesMinorTickPosition MinorTickPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For datetime axes, this decides where to put the tick between weeks. 0 = Sunday, 1 = Monday.</p>
		/// </summary>
		public double? StartOfWeek { get; set; }
		private double? StartOfWeek_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel length of the main tick marks.</p>
		/// </summary>
		public double? TickLength { get; set; }
		private double? TickLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For categorized axes only. If <code>on</code> the tick mark is placed in thecenter of the category, if <code>between</code> the tick mark is placed betweencategories. The default is <code>between</code> if the <code>tickInterval</code> is 1, else <code>on</code>.</p>
		/// </summary>
		public ChartParallelAxesTickmarkPlacement TickmarkPlacement { get; set; }
		private ChartParallelAxesTickmarkPlacement TickmarkPlacement_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The position of the major tick marks relative to the axis line. Can be one of <code>inside</code> and <code>outside</code>.</p>
		/// </summary>
		public ChartParallelAxesTickPosition TickPosition { get; set; }
		private ChartParallelAxesTickPosition TickPosition_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The type of axis. Can be one of <code>linear</code>, <code>logarithmic</code>, <code>datetime</code>or <code>category</code>. In a datetime axis, the numbers are given inmilliseconds, and tick marks are placed on appropriate values likefull hours or days. In a category axis, the <a href="#series.line.data.name">point names</a> of the chart&#39;s series are usedfor categories, if not a <a href="#xAxis.categories">categories</a> array isdefined.</p>
		/// </summary>
		public ChartParallelAxesType Type { get; set; }
		private ChartParallelAxesType Type_DefaultValue { get; set; }
		 

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
		/// <p>Color for the main tick marks.</p><p>In styled mode, the stroke is given in the <code>.highcharts-tick</code>class.</p>
		/// </summary>
		public string TickColor { get; set; }
		private string TickColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to allow decimals in this axis&#39; ticks. When counting integers,like persons or hits on a web page, decimals should be avoided inthe labels.</p>
		/// </summary>
		public bool? AllowDecimals { get; set; }
		private bool? AllowDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If categories are present for the xAxis, names are used instead ofnumbers for that axis. Since Highcharts 3.0, categories can alsobe extracted by giving each point a <a href="#series.data">name</a> and settingaxis <a href="#xAxis.type">type</a> to <code>category</code>. However, if you have multipleseries, best practice remains defining the <code>categories</code> array.</p><p>Example:</p><pre>categories: ['Apples', 'Bananas', 'Oranges']</pre><p>Defaults to <code>null</code></p>
		/// </summary>
		public List<string> Categories { get; set; }
		private List<string> Categories_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The highest allowed value for automatically computed axis extremes.</p>
		/// </summary>
		public double? Ceiling { get; set; }
		private double? Ceiling_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A class name that opens for styling the axis by CSS, especially inHighcharts styled mode. The class name is applied to group elementsfor the grid, axis elements and labels.</p>
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

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
		/// <p>The Z index of the grid lines.</p>
		/// </summary>
		public double? GridZIndex { get; set; }
		private double? GridZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Index of another axis that this axis is linked to. When an axis islinked to a master axis, it will take the same extremes as the master,but as assigned by min or max or by setExtremes. It can be usedto show additional info, or to ease reading the chart by duplicatingthe scales.</p>
		/// </summary>
		public double? LinkedTo { get; set; }
		private double? LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The maximum value of the axis. If <code>null</code>, the max value is automaticallycalculated. If the <code>endOnTick</code> option is true, the <code>max</code> value mightbe rounded up.</p><p>If a <a href="#yAxis.tickAmount">tickAmount</a> is set, the axis may be extendedbeyond the set max in order to reach the given number of ticks. Thesame may happen in a chart with multiple axes, determined by <a href="#chart">chart.alignTicks</a>, where a <code>tickAmount</code> is applied internally.</p>
		/// </summary>
		public double? Max { get; set; }
		private double? Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The minimum range to display on this axis. The entire axis will notbe allowed to span over a smaller interval than this. For example,for a datetime axis the main unit is milliseconds. If minRange isset to 3600000, you can&#39;t zoom in more than to one hour.</p><p>The default minRange for the x axis is five times the smallest intervalbetween any of the data points.</p><p>On a logarithmic axis, the unit for the minimum range is the power.So a minRange of 1 means that the axis can be zoomed to 10-100,100-1000, 1000-10000 etc.</p><p>Note that the <code>minPadding</code>, <code>maxPadding</code>, <code>startOnTick</code> and <code>endOnTick</code>settings also affect how the extremes of the axis are computed.</p>
		/// </summary>
		public double? MinRange { get; set; }
		private double? MinRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The minimum tick interval allowed in axis values. For example onzooming in on an axis with daily data, this can be used to preventthe axis from showing hours. Defaults to the closest distance betweentwo points on the axis.</p>
		/// </summary>
		public double? MinTickInterval { get; set; }
		private double? MinTickInterval_DefaultValue { get; set; }
		 

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
		/// <p>Whether to reverse the axis so that the highest number is closestto the origin. If the chart is inverted, the x axis is reversed bydefault.</p>
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to show the axis line and title when the axis has no data.</p>
		/// </summary>
		public bool? ShowEmpty { get; set; }
		private bool? ShowEmpty_DefaultValue { get; set; }
		 

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
		/// <p>Applies only when the axis <code>type</code> is <code>category</code>. When <code>uniqueNames</code>is true, points are placed on the X axis according to their names.If the same point name is repeated in the same or another series,the point is placed on the same X position as other points of thesame name. When <code>uniqueNames</code> is false, the points are laid out inincreasing X positions regardless of their names, and the X axiscategory will take the name of the last point in each position.</p>
		/// </summary>
		public bool? UniqueNames { get; set; }
		private bool? UniqueNames_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether axis, including axis title, line, ticks and labels, shouldbe visible.</p>
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Configure a crosshair that follows either the mouse pointer or thehovered point.</p><p>In styled mode, the crosshairs are styled in the <code>.highcharts-crosshair</code>, <code>.highcharts-crosshair-thin</code> or <code>.highcharts-xaxis-category</code>classes.</p>
		/// </summary>
		public ChartParallelAxesCrosshair Crosshair { get; set; }
		private ChartParallelAxesCrosshair Crosshair_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Event handlers for the axis.</p>
		/// </summary>
		public ChartParallelAxesEvents Events { get; set; }
		private ChartParallelAxesEvents Events_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			if (TooltipValueFormat != TooltipValueFormat_DefaultValue) h.Add("tooltipValueFormat",TooltipValueFormat);
			if (EndOnTick != EndOnTick_DefaultValue) h.Add("endOnTick",EndOnTick);
			if (TickPixelInterval != TickPixelInterval_DefaultValue) h.Add("tickPixelInterval",TickPixelInterval);
			if (ShowLastLabel != ShowLastLabel_DefaultValue) h.Add("showLastLabel",ShowLastLabel);
			if (MaxPadding != MaxPadding_DefaultValue) h.Add("maxPadding",MaxPadding);
			if (MinPadding != MinPadding_DefaultValue) h.Add("minPadding",MinPadding);
			if (StartOnTick != StartOnTick_DefaultValue) h.Add("startOnTick",StartOnTick);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (ReversedStacks != ReversedStacks_DefaultValue) h.Add("reversedStacks",ReversedStacks);
			if (TickWidth != TickWidth_DefaultValue) h.Add("tickWidth",TickWidth);
			if (DateTimeLabelFormats != DateTimeLabelFormats_DefaultValue) h.Add("dateTimeLabelFormats",DateTimeLabelFormats);
			if (MinorTickLength != MinorTickLength_DefaultValue) h.Add("minorTickLength",MinorTickLength);
			if (MinorTickPosition != MinorTickPosition_DefaultValue) h.Add("minorTickPosition", Highcharts.FirstCharacterToLower(MinorTickPosition.ToString()));
			if (StartOfWeek != StartOfWeek_DefaultValue) h.Add("startOfWeek",StartOfWeek);
			if (TickLength != TickLength_DefaultValue) h.Add("tickLength",TickLength);
			if (TickmarkPlacement != TickmarkPlacement_DefaultValue) h.Add("tickmarkPlacement", Highcharts.FirstCharacterToLower(TickmarkPlacement.ToString()));
			if (TickPosition != TickPosition_DefaultValue) h.Add("tickPosition", Highcharts.FirstCharacterToLower(TickPosition.ToString()));
			if (Type != Type_DefaultValue) h.Add("type", Highcharts.FirstCharacterToLower(Type.ToString()));
			if (MinorTickColor != MinorTickColor_DefaultValue) h.Add("minorTickColor",MinorTickColor);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (TickColor != TickColor_DefaultValue) h.Add("tickColor",TickColor);
			if (AllowDecimals != AllowDecimals_DefaultValue) h.Add("allowDecimals",AllowDecimals);
			if (Categories != Categories_DefaultValue) h.Add("categories",Categories);
			if (Ceiling != Ceiling_DefaultValue) h.Add("ceiling",Ceiling);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Floor != Floor_DefaultValue) h.Add("floor",Floor);
			if (GridZIndex != GridZIndex_DefaultValue) h.Add("gridZIndex",GridZIndex);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (MinRange != MinRange_DefaultValue) h.Add("minRange",MinRange);
			if (MinTickInterval != MinTickInterval_DefaultValue) h.Add("minTickInterval",MinTickInterval);
			if (MinorTickInterval != MinorTickInterval_DefaultValue) h.Add("minorTickInterval",MinorTickInterval);
			if (MinorTicks != MinorTicks_DefaultValue) h.Add("minorTicks",MinorTicks);
			if (MinorTickWidth != MinorTickWidth_DefaultValue) h.Add("minorTickWidth",MinorTickWidth);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (ShowEmpty != ShowEmpty_DefaultValue) h.Add("showEmpty",ShowEmpty);
			if (ShowFirstLabel != ShowFirstLabel_DefaultValue) h.Add("showFirstLabel",ShowFirstLabel);
			if (TickAmount != TickAmount_DefaultValue) h.Add("tickAmount",TickAmount);
			if (TickInterval != TickInterval_DefaultValue) h.Add("tickInterval",TickInterval);
			if (TickPositioner != TickPositioner_DefaultValue) { h.Add("tickPositioner",TickPositioner); Highcharts.AddFunction("ChartParallelAxesTickPositioner.tickPositioner", TickPositioner); }  
			if (TickPositions != TickPositions_DefaultValue) h.Add("tickPositions",TickPositions);
			if (UniqueNames != UniqueNames_DefaultValue) h.Add("uniqueNames",UniqueNames);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (Crosshair.IsDirty()) h.Add("crosshair",Crosshair.ToHashtable());
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
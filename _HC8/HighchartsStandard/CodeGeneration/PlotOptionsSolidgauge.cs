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
	public partial class PlotOptionsSolidgauge  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSolidgauge()
		{
			Accessibility = Accessibility_DefaultValue = new PlotOptionsSolidgaugeAccessibility();
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation();
			AnimationBool = AnimationBool_DefaultValue = null;
			BoostBlending = BoostBlending_DefaultValue = PlotOptionsSolidgaugeBoostBlending.Undefined;
			ClassName = ClassName_DefaultValue = "";
			Clip = Clip_DefaultValue = true;
			Color = Color_DefaultValue = "";
			ColorAxis = ColorAxis_DefaultValue = "0";
			ColorAxisNumber = ColorAxisNumber_DefaultValue = null;
			ColorAxisBool = ColorAxisBool_DefaultValue = null;
			ColorByPoint = ColorByPoint_DefaultValue = true;
			ColorIndex = ColorIndex_DefaultValue = null;
			ColorKey = ColorKey_DefaultValue = "y";
			Crisp = Crisp_DefaultValue = true;
			Cursor = Cursor_DefaultValue = PlotOptionsSolidgaugeCursor.Null;
			Custom = Custom_DefaultValue = new Hashtable();
			DataLabels = DataLabels_DefaultValue = new PlotOptionsSolidgaugeDataLabels();
			DataSorting = DataSorting_DefaultValue = new PlotOptionsSolidgaugeDataSorting();
			Description = Description_DefaultValue = "";
			Dial = Dial_DefaultValue = new PlotOptionsSolidgaugeDial();
			DragDrop = DragDrop_DefaultValue = new PlotOptionsSolidgaugeDragDrop();
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			Events = Events_DefaultValue = new PlotOptionsSolidgaugeEvents();
			IncludeInDataExport = IncludeInDataExport_DefaultValue = null;
			InnerRadius = InnerRadius_DefaultValue = "'60%'";
			Keys = Keys_DefaultValue = new List<string>();
			Label = Label_DefaultValue = new PlotOptionsSolidgaugeLabel();
			Linecap = Linecap_DefaultValue = PlotOptionsSolidgaugeLinecap.Round;
			LineWidth = LineWidth_DefaultValue = 2;
			LinkedTo = LinkedTo_DefaultValue = "";
			OnPoint = OnPoint_DefaultValue = new PlotOptionsSolidgaugeOnPoint();
			Opacity = Opacity_DefaultValue = 1;
			Overshoot = Overshoot_DefaultValue = 0;
			Pivot = Pivot_DefaultValue = new PlotOptionsSolidgaugePivot();
			Point = Point_DefaultValue = new PlotOptionsSolidgaugePoint();
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			PointInterval = PointInterval_DefaultValue = 1;
			PointIntervalUnit = PointIntervalUnit_DefaultValue = PlotOptionsSolidgaugePointIntervalUnit.Null;
			PointStart = PointStart_DefaultValue = 0;
			Radius = Radius_DefaultValue = "'100%'";
			RelativeXValue = RelativeXValue_DefaultValue = false;
			Rounded = Rounded_DefaultValue = false;
			Selected = Selected_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			ShowInLegend = ShowInLegend_DefaultValue = null;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			StickyTracking = StickyTracking_DefaultValue = true;
			Threshold = Threshold_DefaultValue = null;
			Tooltip = Tooltip_DefaultValue = new PlotOptionsSolidgaugeTooltip();
			UseOhlcData = UseOhlcData_DefaultValue = null;
			Visible = Visible_DefaultValue = true;
			Wrap = Wrap_DefaultValue = true;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Accessibility options for a series.
		/// </summary>
		public PlotOptionsSolidgaugeAccessibility Accessibility { get; set; }
		private PlotOptionsSolidgaugeAccessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow this series' points to be selected by clicking on the graphic(columns, point markers, pie slices, map areas etc).The selected points can be handled by point select and unselectevents, or collectively by the [getSelectedPoints](/class-reference/Highcharts.Chart#getSelectedPoints) function.And alternative way of selecting points is through dragging.
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.- `duration`: The duration of the animation in milliseconds. (Defaults to  `1000`)- `easing`: Can be a string reference to an easing function set on  the `Math` object or a function. See the _Custom easing function_  demo below. (Defaults to `easeInOutSine`)Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.- `duration`: The duration of the animation in milliseconds. (Defaults to  `1000`)- `easing`: Can be a string reference to an easing function set on  the `Math` object or a function. See the _Custom easing function_  demo below. (Defaults to `easeInOutSine`)Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public bool? AnimationBool { get; set; }
		private bool? AnimationBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sets the color blending in the boost module.
		/// </summary>
		public PlotOptionsSolidgaugeBoostBlending BoostBlending { get; set; }
		private PlotOptionsSolidgaugeBoostBlending BoostBlending_DefaultValue { get; set; }
		 

		/// <summary>
		/// An additional class name to apply to the series' graphical elements.This option does not replace default class names of the graphicalelement. Changes to the series' color will also be reflected in achart's legend and tooltip.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Disable this option to allow series rendering in the whole plottingarea.**Note:** Clipping should be always enabled when[chart.zoomType](#chart.zoomType) is set
		/// </summary>
		public bool? Clip { get; set; }
		private bool? Clip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color of the series. In line type series it applies to theline and the point markers unless otherwise specified. In bar typeseries it applies to the bars unless a color is specified per point.The default value is pulled from the `options.colors` array.In styled mode, the color can be defined by the[colorIndex](#plotOptions.series.colorIndex) option. Also, the seriescolor can be set with the `.highcharts-series`,`.highcharts-color-{n}`, `.highcharts-{type}-series` or`.highcharts-series-{n}` class, or individual classes given by the`className` option.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple color axes, this number defines whichcolorAxis the particular series is connected to. It refers toeither the{@link #colorAxis.id|axis id}or the index of the axis in the colorAxis array, with 0 being thefirst. Set this option to false to prevent a series from connectingto the default color axis.Since v7.2.0 the option can also be an axis id or an axis indexinstead of a boolean flag.
		/// </summary>
		public string ColorAxis { get; set; }
		private string ColorAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple color axes, this number defines whichcolorAxis the particular series is connected to. It refers toeither the{@link #colorAxis.id|axis id}or the index of the axis in the colorAxis array, with 0 being thefirst. Set this option to false to prevent a series from connectingto the default color axis.Since v7.2.0 the option can also be an axis id or an axis indexinstead of a boolean flag.
		/// </summary>
		public double? ColorAxisNumber { get; set; }
		private double? ColorAxisNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple color axes, this number defines whichcolorAxis the particular series is connected to. It refers toeither the{@link #colorAxis.id|axis id}or the index of the axis in the colorAxis array, with 0 being thefirst. Set this option to false to prevent a series from connectingto the default color axis.Since v7.2.0 the option can also be an axis id or an axis indexinstead of a boolean flag.
		/// </summary>
		public bool? ColorAxisBool { get; set; }
		private bool? ColorAxisBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to give each point an individual color.
		/// </summary>
		public bool? ColorByPoint { get; set; }
		private bool? ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styled mode only. A specific color index to use for the series, so itsgraphic representations are given the class name `highcharts-color-{n}`.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Determines what data value should be used to calculate point colorif `colorAxis` is used. Requires to set `min` and `max` if somecustom point property is used or if approximation for data groupingis set to `'sum'`.
		/// </summary>
		public string ColorKey { get; set; }
		private string ColorKey_DefaultValue { get; set; }
		 

		/// <summary>
		/// When true, each point or column edge is rounded to its nearest pixelin order to render sharp on screen. In some cases, when there are alot of densely packed columns, this leads to visible differencein column widths or distance between columns. In these cases,setting `crisp` to `false` may look better, even though each columnis rendered blurry.
		/// </summary>
		public bool? Crisp { get; set; }
		private bool? Crisp_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.In styled mode, the series cursor can be set with the same classesas listed under [series.color](#plotOptions.series.color).
		/// </summary>
		public PlotOptionsSolidgaugeCursor Cursor { get; set; }
		private PlotOptionsSolidgaugeCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customizedfunctionality. Here you can add additional data for your own eventcallbacks and formatter callbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		private Hashtable Custom_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSolidgaugeDataLabels DataLabels { get; set; }
		private PlotOptionsSolidgaugeDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the series data sorting.
		/// </summary>
		public PlotOptionsSolidgaugeDataSorting DataSorting { get; set; }
		private PlotOptionsSolidgaugeDataSorting DataSorting_DefaultValue { get; set; }
		 

		/// <summary>
		/// A description of the series to add to the screen reader informationabout the series.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the dial or arrow pointer of the gauge.In styled mode, the dial is styled with the`.highcharts-gauge-series .highcharts-dial` rule.
		/// </summary>
		public PlotOptionsSolidgaugeDial Dial { get; set; }
		private PlotOptionsSolidgaugeDial Dial_DefaultValue { get; set; }
		 

		/// <summary>
		/// The draggable-points module allows points to be moved around or modified inthe chart. In addition to the options mentioned under the `dragDrop` APIstructure, the module fires three events,[point.dragStart](plotOptions.series.point.events.dragStart),[point.drag](plotOptions.series.point.events.drag) and[point.drop](plotOptions.series.point.events.drop).
		/// </summary>
		public PlotOptionsSolidgaugeDragDrop DragDrop { get; set; }
		private PlotOptionsSolidgaugeDragDrop DragDrop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// General event handlers for the series items. These event hooks canalso be attached to the series at run time using the`Highcharts.addEvent` function.
		/// </summary>
		public PlotOptionsSolidgaugeEvents Events { get; set; }
		private PlotOptionsSolidgaugeEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// When set to `false` will prevent the series data from being included inany form of data export.Since version 6.0.0 until 7.1.0 the option was existing undocumentedas `includeInCSVExport`.
		/// </summary>
		public bool? IncludeInDataExport { get; set; }
		private bool? IncludeInDataExport_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner radius for points in a solid gauge. Can be given only inpercentage, either as a number or a string like `"50%"`.
		/// </summary>
		public string InnerRadius { get; set; }
		private string InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

		/// <summary>
		/// Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.The series labels currently work with series types having a`graph` or an `area`.
		/// </summary>
		public PlotOptionsSolidgaugeLabel Label { get; set; }
		private PlotOptionsSolidgaugeLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the strokes of the solid gauge should be `round` or `square`.
		/// </summary>
		public PlotOptionsSolidgaugeLinecap Linecap { get; set; }
		private PlotOptionsSolidgaugeLinecap Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel width of the graph line.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [id](#series.id) of another series to link to. Additionally,the value can be ":previous" to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.If master series uses data sorting and linked series does not haveits own sorting definition, the linked series will be sorted in thesame order as the master one.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the _Series on point_ feature. Only `pie` and `sunburst` seriesare supported at this moment.
		/// </summary>
		public PlotOptionsSolidgaugeOnPoint OnPoint { get; set; }
		private PlotOptionsSolidgaugeOnPoint OnPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Opacity of a series parts: line, fill (e.g. area) and dataLabels.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow the gauge to overshoot the end of the perimeter axis by thismany degrees. Say if the gauge axis goes from 0 to 60, a value of100, or 1000, will show 5 degrees beyond the end of the axis when thisoption is set to 5.
		/// </summary>
		public double? Overshoot { get; set; }
		private double? Overshoot_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the pivot or the center point of the gauge.In styled mode, the pivot is styled with the`.highcharts-gauge-series .highcharts-pivot` rule.
		/// </summary>
		public PlotOptionsSolidgaugePivot Pivot { get; set; }
		private PlotOptionsSolidgaugePivot Pivot_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public PlotOptionsSolidgaugePoint Point { get; set; }
		private PlotOptionsSolidgaugePoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// Same as[accessibility.series.descriptionFormatter](#accessibility.series.descriptionFormatter),but for an individual series. Overrides the chart wide configuration.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// If no x values are given for the points in a series, `pointInterval`defines the interval of the x values. For example, if a seriescontains one value every decade starting from year 0, set`pointInterval` to `10`. In true `datetime` axes, the `pointInterval`is set in milliseconds.It can be also be combined with `pointIntervalUnit` to draw irregulartime intervals.If combined with `relativeXValue`, an x value can be set on eachpoint, and the `pointInterval` is added x times to the `pointStart`setting.Please note that this options applies to the _series data_, not theinterval of the axis ticks, which is independent.
		/// </summary>
		public double? PointInterval { get; set; }
		private double? PointInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// On datetime series, this allows for setting the[pointInterval](#plotOptions.series.pointInterval) to irregular timeunits, `day`, `month` and `year`. A day is usually the same as 24hours, but `pointIntervalUnit` also takes the DST crossover intoconsideration when dealing with local time. Combine this option with`pointInterval` to draw weeks, quarters, 6 months, 10 years etc.Please note that this options applies to the _series data_, not theinterval of the axis ticks, which is independent.
		/// </summary>
		public PlotOptionsSolidgaugePointIntervalUnit PointIntervalUnit { get; set; }
		private PlotOptionsSolidgaugePointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }
		 

		/// <summary>
		/// If no x values are given for the points in a series, pointStartdefines on what value to start. For example, if a series contains oneyearly value starting from 1945, set pointStart to 1945.If combined with `relativeXValue`, an x value can be set on eachpoint. The x value from the point options is multiplied by`pointInterval` and added to `pointStart` to produce a modified xvalue.
		/// </summary>
		public double? PointStart { get; set; }
		private double? PointStart_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius for points in a solid gauge. Can be given only inpercentage, either as a number or a string like `"100%"`.
		/// </summary>
		public string Radius { get; set; }
		private string Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// When true, X values in the data set are relative to the current`pointStart`, `pointInterval` and `pointIntervalUnit` settings. Thisallows compression of the data for datasets with irregular X values.The real X values are computed on the formula `f(x) = ax + b`, where`a` is the `pointInterval` (optionally with a time unit given by`pointIntervalUnit`), and `b` is the `pointStart`.
		/// </summary>
		public bool? RelativeXValue { get; set; }
		private bool? RelativeXValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to draw rounded edges on the gauge.
		/// </summary>
		public bool? Rounded { get; set; }
		private bool? Rounded_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If `showCheckbox` is true,the checkbox next to the series name in the legend will be checkedfor a selected series.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allowselecting the series. The state of the checkbox is determined bythe `selected` option.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		private bool? ShowCheckbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in thelegend. Standalone series are shown in legend by default, and linkedseries are not. Since v7.2.0 it is possible to show series that usecolorAxis by setting this option to `true`.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// If set to `true`, the accessibility module will skip past the pointsin this series for keyboard navigation.
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		private bool? SkipKeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` event on aseries isn't triggered until the mouse moves over another series, orout of the plot area. When false, the `mouseOut` event on a series istriggered when the mouse leaves the area around the series' graph ormarkers. This also implies the tooltip when not shared. When`stickyTracking` is false and `tooltip.shared` is false, the tooltipwill be hidden when moving the mouse between series. Defaults to truefor line and area type series, but to false for columns, pies etc.**Note:** The boost module will force this option because oftechnical limitations.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// The threshold or base level for the gauge.
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object for the tooltip rendering of each singleseries. Properties are inherited from [tooltip](#tooltip), but onlythe following properties can be defined on a series level.
		/// </summary>
		public PlotOptionsSolidgaugeTooltip Tooltip { get; set; }
		private PlotOptionsSolidgaugeTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The parameter allows setting line series type and use OHLC indicators.Data in OHLC format is required.
		/// </summary>
		public bool? UseOhlcData { get; set; }
		private bool? UseOhlcData_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this option is `true`, the dial will wrap around the axes.For instance, in a full-range gauge going from 0 to 360, a valueof 400 will point to 40\. When `wrap` is `false`, the dial stopsat 360.
		/// </summary>
		public bool? Wrap { get; set; }
		private bool? Wrap_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Accessibility.IsDirty(highcharts)) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (Animation.IsDirty(highcharts)) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (BoostBlending != BoostBlending_DefaultValue) h.Add("boostBlending", highcharts.FirstCharacterToLower(BoostBlending.ToString()));
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Clip != Clip_DefaultValue) h.Add("clip",Clip);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorAxis != ColorAxis_DefaultValue) h.Add("colorAxis",ColorAxis);
			if (ColorAxisNumber != ColorAxisNumber_DefaultValue) h.Add("colorAxis",ColorAxisNumber);
			if (ColorAxisBool != ColorAxisBool_DefaultValue) h.Add("colorAxis",ColorAxisBool);
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (ColorKey != ColorKey_DefaultValue) h.Add("colorKey",ColorKey);
			if (Crisp != Crisp_DefaultValue) h.Add("crisp",Crisp);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (Custom != Custom_DefaultValue) h.Add("custom",Custom);
			if (DataLabels.IsDirty(highcharts)) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (DataSorting.IsDirty(highcharts)) h.Add("dataSorting",DataSorting.ToHashtable(highcharts));
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Dial.IsDirty(highcharts)) h.Add("dial",Dial.ToHashtable(highcharts));
			if (DragDrop.IsDirty(highcharts)) h.Add("dragDrop",DragDrop.ToHashtable(highcharts));
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events.IsDirty(highcharts)) h.Add("events",Events.ToHashtable(highcharts));
			if (IncludeInDataExport != IncludeInDataExport_DefaultValue) h.Add("includeInDataExport",IncludeInDataExport);
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (Label.IsDirty(highcharts)) h.Add("label",Label.ToHashtable(highcharts));
			if (Linecap != Linecap_DefaultValue) h.Add("linecap", highcharts.FirstCharacterToLower(Linecap.ToString()));
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (OnPoint.IsDirty(highcharts)) h.Add("onPoint",OnPoint.ToHashtable(highcharts));
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Overshoot != Overshoot_DefaultValue) h.Add("overshoot",Overshoot);
			if (Pivot.IsDirty(highcharts)) h.Add("pivot",Pivot.ToHashtable(highcharts));
			if (Point.IsDirty(highcharts)) h.Add("point",Point.ToHashtable(highcharts));
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); highcharts.AddFunction("pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (PointInterval != PointInterval_DefaultValue) h.Add("pointInterval",PointInterval);
			if (PointIntervalUnit != PointIntervalUnit_DefaultValue) h.Add("pointIntervalUnit", highcharts.FirstCharacterToLower(PointIntervalUnit.ToString()));
			if (PointStart != PointStart_DefaultValue) h.Add("pointStart",PointStart);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (RelativeXValue != RelativeXValue_DefaultValue) h.Add("relativeXValue",RelativeXValue);
			if (Rounded != Rounded_DefaultValue) h.Add("rounded",Rounded);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (Tooltip.IsDirty(highcharts)) h.Add("tooltip",Tooltip.ToHashtable(highcharts));
			if (UseOhlcData != UseOhlcData_DefaultValue) h.Add("useOhlcData",UseOhlcData);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (Wrap != Wrap_DefaultValue) h.Add("wrap",Wrap);
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
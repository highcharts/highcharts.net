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
	public partial class PlotOptionsPie  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPie()
		{
			Accessibility = Accessibility_DefaultValue = new PlotOptionsPieAccessibility();
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation();
			AnimationBool = AnimationBool_DefaultValue = true;
			BorderColor = BorderColor_DefaultValue = "#ffffff";
			BorderRadius = BorderRadius_DefaultValue = null;
			BorderRadiusString = BorderRadiusString_DefaultValue = "null";
			BorderRadiusNumber = BorderRadiusNumber_DefaultValue = null;
			BorderWidth = BorderWidth_DefaultValue = 1;
			Center = Center_DefaultValue = new string[] { "50%", "50%" };
			ClassName = ClassName_DefaultValue = "";
			Clip = Clip_DefaultValue = false;
			Color = Color_DefaultValue = "#cccccc";
			ColorAxis = ColorAxis_DefaultValue = "0";
			ColorAxisNumber = ColorAxisNumber_DefaultValue = null;
			ColorAxisBool = ColorAxisBool_DefaultValue = null;
			ColorIndex = ColorIndex_DefaultValue = null;
			ColorKey = ColorKey_DefaultValue = "y";
			Colors = Colors_DefaultValue = new List<string>();
			Crisp = Crisp_DefaultValue = true;
			Cursor = Cursor_DefaultValue = PlotOptionsPieCursor.Null;
			Custom = Custom_DefaultValue = new Hashtable();
			DataLabels = DataLabels_DefaultValue = new PlotOptionsPieDataLabels();
			Depth = Depth_DefaultValue = 0;
			Description = Description_DefaultValue = "";
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			EndAngle = EndAngle_DefaultValue = null;
			Events = Events_DefaultValue = new PlotOptionsPieEvents();
			FillColor = FillColor_DefaultValue = null;
			IgnoreHiddenPoint = IgnoreHiddenPoint_DefaultValue = true;
			InactiveOtherPoints = InactiveOtherPoints_DefaultValue = new PlotOptionsPieInactiveOtherPoints();
			IncludeInDataExport = IncludeInDataExport_DefaultValue = null;
			InnerSize = InnerSize_DefaultValue = "0";
			InnerSizeNumber = InnerSizeNumber_DefaultValue = null;
			Keys = Keys_DefaultValue = new List<string>();
			LegendSymbol = LegendSymbol_DefaultValue = PlotOptionsPieLegendSymbol.Rectangle;
			Linecap = Linecap_DefaultValue = PlotOptionsPieLinecap.Round;
			MinSize = MinSize_DefaultValue = "80";
			MinSizeNumber = MinSizeNumber_DefaultValue = null;
			OnPoint = OnPoint_DefaultValue = new PlotOptionsPieOnPoint();
			Opacity = Opacity_DefaultValue = 1;
			Point = Point_DefaultValue = new PlotOptionsPiePoint();
			PointDescriptionFormat = PointDescriptionFormat_DefaultValue = "";
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			RelativeXValue = RelativeXValue_DefaultValue = false;
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow();
			ShadowBool = ShadowBool_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			ShowInLegend = ShowInLegend_DefaultValue = false;
			Size = Size_DefaultValue = "";
			SizeNumber = SizeNumber_DefaultValue = null;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			SlicedOffset = SlicedOffset_DefaultValue = 10;
			Sonification = Sonification_DefaultValue = new PlotOptionsPieSonification();
			StartAngle = StartAngle_DefaultValue = 0;
			States = States_DefaultValue = new PlotOptionsPieStates();
			StickyTracking = StickyTracking_DefaultValue = false;
			Thickness = Thickness_DefaultValue = null;
			Tooltip = Tooltip_DefaultValue = new PlotOptionsPieTooltip();
			UseOhlcData = UseOhlcData_DefaultValue = null;
			Visible = Visible_DefaultValue = true;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Accessibility options for a series.
		/// </summary>
		public PlotOptionsPieAccessibility Accessibility { get; set; }
		private PlotOptionsPieAccessibility Accessibility_DefaultValue { get; set; }
		 

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
		/// The color of the border surrounding each slice. When `null`, theborder takes the same color as the slice fill. This can be usedtogether with a `borderWidth` to fill drawing gaps created byantialiazing artefacts in borderless pies.In styled mode, the border stroke is given in the `.highcharts-point`class.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The corner radius of the border surrounding each slice. A numbersignifies pixels. A percentage string, like for example `50%`, signifiesa size relative to the radius and the inner radius.
		/// </summary>
		public Object BorderRadius { get; set; }
		private Object BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The corner radius of the border surrounding each slice. A numbersignifies pixels. A percentage string, like for example `50%`, signifiesa size relative to the radius and the inner radius.
		/// </summary>
		public string BorderRadiusString { get; set; }
		private string BorderRadiusString_DefaultValue { get; set; }
		 

		/// <summary>
		/// The corner radius of the border surrounding each slice. A numbersignifies pixels. A percentage string, like for example `50%`, signifiesa size relative to the radius and the inner radius.
		/// </summary>
		public double? BorderRadiusNumber { get; set; }
		private double? BorderRadiusNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the border surrounding each slice.When setting the border width to 0, there may be small gaps betweenthe slices due to SVG antialiasing artefacts. To work around this,keep the border width at 0.5 or 1, but set the `borderColor` to`null` instead.In styled mode, the border stroke width is given in the`.highcharts-point` class.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The center of the pie chart relative to the plot area. Can bepercentages or pixel values. The default behaviour (as of 3.0) is tocenter the pie so that all slices and data labels are within the plotarea. As a consequence, the pie may actually jump around in a chartwith dynamic values, as the data labels move. In that case, thecenter should be explicitly set, for example to `["50%", "50%"]`.
		/// </summary>
		public string[] Center { get; set; }
		private string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// An additional class name to apply to the series' graphical elements.This option does not replace default class names of the graphicalelement. Changes to the series' color will also be reflected in achart's legend and tooltip.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Clip { get; set; }
		private bool? Clip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the pie series. A pie series is represented as an emptycircle if the total sum of its values is 0. Use this property todefine the color of its border.In styled mode, the color can be defined by the[colorIndex](#plotOptions.series.colorIndex) option. Also, the seriescolor can be set with the `.highcharts-series`,`.highcharts-color-{n}`, `.highcharts-{type}-series` or`.highcharts-series-{n}` class, or individual classes given by the`className` option.
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
		/// Styled mode only. A specific color index to use for the series, so itsgraphic representations are given the class name `highcharts-color-{n}`.Since v11, CSS variables on the form `--highcharts-color-{n}` makechanging the color scheme very convenient.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Determines what data value should be used to calculate point colorif `colorAxis` is used. Requires to set `min` and `max` if somecustom point property is used or if approximation for data groupingis set to `'sum'`.
		/// </summary>
		public string ColorKey { get; set; }
		private string ColorKey_DefaultValue { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to use insteadof the global [colors](#colors).
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// When true, each point or column edge is rounded to its nearest pixelin order to render sharp on screen. In some cases, when there are alot of densely packed columns, this leads to visible differencein column widths or distance between columns. In these cases,setting `crisp` to `false` may look better, even though each columnis rendered blurry.
		/// </summary>
		public bool? Crisp { get; set; }
		private bool? Crisp_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.In styled mode, the series cursor can be set with the same classesas listed under [series.color](#plotOptions.series.color).
		/// </summary>
		public PlotOptionsPieCursor Cursor { get; set; }
		private PlotOptionsPieCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customizedfunctionality. Here you can add additional data for your own eventcallbacks and formatter callbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		private Hashtable Custom_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieDataLabels DataLabels { get; set; }
		private PlotOptionsPieDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// The thickness of a 3D pie.
		/// </summary>
		public double? Depth { get; set; }
		private double? Depth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A description of the series to add to the screen reader informationabout the series.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// The end angle of the pie in degrees where 0 is top and 90 is right.Defaults to `startAngle` plus 360.
		/// </summary>
		public double? EndAngle { get; set; }
		private double? EndAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieEvents Events { get; set; }
		private PlotOptionsPieEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// If the total sum of the pie's values is 0, the series is representedas an empty circle . The `fillColor` option defines the color of thatcircle. Use [pie.borderWidth](#plotOptions.pie.borderWidth) to setthe border thickness.
		/// </summary>
		public Object FillColor { get; set; }
		private Object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Equivalent to [chart.ignoreHiddenSeries](#chart.ignoreHiddenSeries),this option tells whether the series shall be redrawn as if thehidden point were `null`.The default value changed from `false` to `true` with Highcharts3.0.
		/// </summary>
		public bool? IgnoreHiddenPoint { get; set; }
		private bool? IgnoreHiddenPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieInactiveOtherPoints InactiveOtherPoints { get; set; }
		private PlotOptionsPieInactiveOtherPoints InactiveOtherPoints_DefaultValue { get; set; }
		 

		/// <summary>
		/// When set to `false` will prevent the series data from being included inany form of data export.Since version 6.0.0 until 7.1.0 the option was existing undocumentedas `includeInCSVExport`.
		/// </summary>
		public bool? IncludeInDataExport { get; set; }
		private bool? IncludeInDataExport_DefaultValue { get; set; }
		 

		/// <summary>
		/// The size of the inner diameter for the pie. A size greater than 0renders a donut chart. Can be a percentage or pixel value.Percentages are relative to the pie size. Pixel values are given asintegers. Setting overridden by thickness.Note: in Highcharts < 4.1.2, the percentage was relative to the plotarea, not the pie size.
		/// </summary>
		public string InnerSize { get; set; }
		private string InnerSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The size of the inner diameter for the pie. A size greater than 0renders a donut chart. Can be a percentage or pixel value.Percentages are relative to the pie size. Pixel values are given asintegers. Setting overridden by thickness.Note: in Highcharts < 4.1.2, the percentage was relative to the plotarea, not the pie size.
		/// </summary>
		public double? InnerSizeNumber { get; set; }
		private double? InnerSizeNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

		/// <summary>
		/// What type of legend symbol to render for this series. Can be one of`areaMarker`, `lineMarker` or `rectangle`.
		/// </summary>
		public PlotOptionsPieLegendSymbol LegendSymbol { get; set; }
		private PlotOptionsPieLegendSymbol LegendSymbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line cap used for line ends and line joins on the graph.
		/// </summary>
		public PlotOptionsPieLinecap Linecap { get; set; }
		private PlotOptionsPieLinecap Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum size for a pie in response to auto margins. The pie willtry to shrink to make room for data labels in side the plot area, but only to this size.
		/// </summary>
		public string MinSize { get; set; }
		private string MinSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum size for a pie in response to auto margins. The pie willtry to shrink to make room for data labels in side the plot area, but only to this size.
		/// </summary>
		public double? MinSizeNumber { get; set; }
		private double? MinSizeNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the _Series on point_ feature. Only `pie` and `sunburst` seriesare supported at this moment.
		/// </summary>
		public PlotOptionsPieOnPoint OnPoint { get; set; }
		private PlotOptionsPieOnPoint OnPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Opacity of a series parts: line, fill (e.g. area) and dataLabels.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPiePoint Point { get; set; }
		private PlotOptionsPiePoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// Same as[accessibility.point.descriptionFormat](#accessibility.point.descriptionFormat),but for an individual series. Overrides the chart wide configuration.
		/// </summary>
		public string PointDescriptionFormat { get; set; }
		private string PointDescriptionFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Same as[accessibility.series.descriptionFormatter](#accessibility.series.descriptionFormatter),but for an individual series. Overrides the chart wide configuration.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// When true, X values in the data set are relative to the current`pointStart`, `pointInterval` and `pointIntervalUnit` settings. Thisallows compression of the data for datasets with irregular X values.The real X values are computed on the formula `f(x) = ax + b`, where`a` is the `pointInterval` (optionally with a time unit given by`pointIntervalUnit`), and `b` is the `pointStart`.
		/// </summary>
		public bool? RelativeXValue { get; set; }
		private bool? RelativeXValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If `showCheckbox` is true,the checkbox next to the series name in the legend will be checkedfor a selected series.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 theshadow can be an object configuration containing `color`, `offsetX`,`offsetY`, `opacity` and `width`.Note that in some cases, like stacked columns or other dense layouts, theseries may cast shadows on each other. In that case, the`chart.seriesGroupShadow` allows applying a common drop shadow to thewhole series group.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 theshadow can be an object configuration containing `color`, `offsetX`,`offsetY`, `opacity` and `width`.Note that in some cases, like stacked columns or other dense layouts, theseries may cast shadows on each other. In that case, the`chart.seriesGroupShadow` allows applying a common drop shadow to thewhole series group.
		/// </summary>
		public bool? ShadowBool { get; set; }
		private bool? ShadowBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allowselecting the series. The state of the checkbox is determined bythe `selected` option.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		private bool? ShowCheckbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in thelegend. Since 2.1, pies are not shown in the legend by default.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// The diameter of the pie relative to the plot area. Can be apercentage or pixel value. Pixel values are given as integers. Thedefault behaviour (as of 3.0) is to scale to the plot area and giveroom for data labels within the plot area.[slicedOffset](#plotOptions.pie.slicedOffset) is also included in thedefault size calculation. As a consequence, the size of the pie mayvary when points are updated and data labels more around. In thatcase it is best to set a fixed value, for example `"75%"`.
		/// </summary>
		public string Size { get; set; }
		private string Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// The diameter of the pie relative to the plot area. Can be apercentage or pixel value. Pixel values are given as integers. Thedefault behaviour (as of 3.0) is to scale to the plot area and giveroom for data labels within the plot area.[slicedOffset](#plotOptions.pie.slicedOffset) is also included in thedefault size calculation. As a consequence, the size of the pie mayvary when points are updated and data labels more around. In thatcase it is best to set a fixed value, for example `"75%"`.
		/// </summary>
		public double? SizeNumber { get; set; }
		private double? SizeNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// If set to `true`, the accessibility module will skip past the pointsin this series for keyboard navigation.
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		private bool? SkipKeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// If a point is sliced, moved out from the center, how many pixelsshould it be moved?.
		/// </summary>
		public double? SlicedOffset { get; set; }
		private double? SlicedOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sonification/audio chart options for a series.
		/// </summary>
		public PlotOptionsPieSonification Sonification { get; set; }
		private PlotOptionsPieSonification Sonification_DefaultValue { get; set; }
		 

		/// <summary>
		/// The start angle of the pie slices in degrees where 0 is top and 90right.
		/// </summary>
		public double? StartAngle { get; set; }
		private double? StartAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieStates States { get; set; }
		private PlotOptionsPieStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` eventon a series isn't triggered until the mouse moves over anotherseries, or out of the plot area. When false, the `mouseOut` event ona series is triggered when the mouse leaves the area around theseries'  graph or markers. This also implies the tooltip. When`stickyTracking` is false and `tooltip.shared` is false, the tooltipwill be hidden when moving the mouse between series.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// Thickness describing the ring size for a donut type chart,overriding [innerSize](#plotOptions.pie.innerSize).
		/// </summary>
		public double? Thickness { get; set; }
		private double? Thickness_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieTooltip Tooltip { get; set; }
		private PlotOptionsPieTooltip Tooltip_DefaultValue { get; set; }
		 

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
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Accessibility.IsDirty(highcharts)) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (Animation.IsDirty(highcharts)) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderRadiusString != BorderRadiusString_DefaultValue) h.Add("borderRadius",BorderRadiusString);
			if (BorderRadiusNumber != BorderRadiusNumber_DefaultValue) h.Add("borderRadius",BorderRadiusNumber);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Clip != Clip_DefaultValue) h.Add("clip",Clip);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorAxis != ColorAxis_DefaultValue) h.Add("colorAxis",ColorAxis);
			if (ColorAxisNumber != ColorAxisNumber_DefaultValue) h.Add("colorAxis",ColorAxisNumber);
			if (ColorAxisBool != ColorAxisBool_DefaultValue) h.Add("colorAxis",ColorAxisBool);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (ColorKey != ColorKey_DefaultValue) h.Add("colorKey",ColorKey);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (Crisp != Crisp_DefaultValue) h.Add("crisp",Crisp);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (Custom != Custom_DefaultValue) h.Add("custom",Custom);
			if (DataLabels.IsDirty(highcharts)) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (Depth != Depth_DefaultValue) h.Add("depth",Depth);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (EndAngle != EndAngle_DefaultValue) h.Add("endAngle",EndAngle);
			if (Events.IsDirty(highcharts)) h.Add("events",Events.ToHashtable(highcharts));
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (IgnoreHiddenPoint != IgnoreHiddenPoint_DefaultValue) h.Add("ignoreHiddenPoint",IgnoreHiddenPoint);
			if (InactiveOtherPoints.IsDirty(highcharts)) h.Add("inactiveOtherPoints",InactiveOtherPoints.ToHashtable(highcharts));
			if (IncludeInDataExport != IncludeInDataExport_DefaultValue) h.Add("includeInDataExport",IncludeInDataExport);
			if (InnerSize != InnerSize_DefaultValue) h.Add("innerSize",InnerSize);
			if (InnerSizeNumber != InnerSizeNumber_DefaultValue) h.Add("innerSize",InnerSizeNumber);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (LegendSymbol != LegendSymbol_DefaultValue) h.Add("legendSymbol", highcharts.FirstCharacterToLower(LegendSymbol.ToString()));
			if (Linecap != Linecap_DefaultValue) h.Add("linecap", highcharts.FirstCharacterToLower(Linecap.ToString()));
			if (MinSize != MinSize_DefaultValue) h.Add("minSize",MinSize);
			if (MinSizeNumber != MinSizeNumber_DefaultValue) h.Add("minSize",MinSizeNumber);
			if (OnPoint.IsDirty(highcharts)) h.Add("onPoint",OnPoint.ToHashtable(highcharts));
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Point.IsDirty(highcharts)) h.Add("point",Point.ToHashtable(highcharts));
			if (PointDescriptionFormat != PointDescriptionFormat_DefaultValue) { h.Add("pointDescriptionFormat",PointDescriptionFormat); highcharts.AddFunction("pointDescriptionFormat", PointDescriptionFormat); }  
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); highcharts.AddFunction("pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (RelativeXValue != RelativeXValue_DefaultValue) h.Add("relativeXValue",RelativeXValue);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow.IsDirty(highcharts)) h.Add("shadow",Shadow.ToHashtable(highcharts));
			if (ShadowBool != ShadowBool_DefaultValue) h.Add("shadow",ShadowBool);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (SizeNumber != SizeNumber_DefaultValue) h.Add("size",SizeNumber);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (SlicedOffset != SlicedOffset_DefaultValue) h.Add("slicedOffset",SlicedOffset);
			if (Sonification.IsDirty(highcharts)) h.Add("sonification",Sonification.ToHashtable(highcharts));
			if (StartAngle != StartAngle_DefaultValue) h.Add("startAngle",StartAngle);
			if (States.IsDirty(highcharts)) h.Add("states",States.ToHashtable(highcharts));
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Thickness != Thickness_DefaultValue) h.Add("thickness",Thickness);
			if (Tooltip.IsDirty(highcharts)) h.Add("tooltip",Tooltip.ToHashtable(highcharts));
			if (UseOhlcData != UseOhlcData_DefaultValue) h.Add("useOhlcData",UseOhlcData);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
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
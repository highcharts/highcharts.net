using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptionsXrange  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsXrange()
		{
		}	
		

		/// <summary>
		/// Accessibility options for a series.
		/// </summary>
		public PlotOptionsXrangeAccessibility Accessibility { get; set; }
		 

		/// <summary>
		/// Allow this series' points to be selected by clicking on the graphic(columns, point markers, pie slices, map areas etc).The selected points can be handled by point select and unselectevents, or collectively by the [getSelectedPoints](/class-reference/Highcharts.Chart#getSelectedPoints) function.And alternative way of selecting points is through dragging.
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.- `duration`: The duration of the animation in milliseconds. (Defaults to  `1000`)- `easing`: Can be a string reference to an easing function set on  the `Math` object or a function. See the _Custom easing function_  demo below. (Defaults to `easeInOutSine`)Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.- `duration`: The duration of the animation in milliseconds. (Defaults to  `1000`)- `easing`: Can be a string reference to an easing function set on  the `Math` object or a function. See the _Custom easing function_  demo below. (Defaults to `easeInOutSine`)Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// For some series, there is a limit that shuts down animationby default when the total number of points in the chart is too high.For example, for a column chart and its derivatives, animation doesnot run if there is more than 250 points totally. To disable thiscap, set `animationLimit` to `Infinity`. This option works if animationis fired on individual points, not on a group of points like e.g. duringthe initial animation.
		/// </summary>
		public double? AnimationLimit { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each column or bar.In styled mode, the border stroke can be set with the`.highcharts-point` rule.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? BorderRadius { get; set; }
		 

		/// <summary>
		/// The corner radius of the border surrounding each column or bar. A numbersignifies pixels. A percentage string, like for example `50%`, signifiesa relative size. For columns this is relative to the column width, forpies it is relative to the radius and the inner radius.
		/// </summary>
		public string BorderRadiusString { get; set; }
		 

		/// <summary>
		/// The corner radius of the border surrounding each column or bar. A numbersignifies pixels. A percentage string, like for example `50%`, signifiesa relative size. For columns this is relative to the column width, forpies it is relative to the radius and the inner radius.
		/// </summary>
		public double? BorderRadiusNumber { get; set; }
		 

		/// <summary>
		/// The width of the border surrounding each column or bar. Defaults to`1` when there is room for a border, but to `0` when the columns areso dense that a border would cover the next column.In styled mode, the stroke width can be set with the`.highcharts-point` rule.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// When `true`, the columns will center in the category, ignoring nullor missing points. When `false`, space will be reserved for null ormissing points.
		/// </summary>
		public bool? CenterInCategory { get; set; }
		 

		/// <summary>
		/// An additional class name to apply to the series' graphical elements.This option does not replace default class names of the graphicalelement. Changes to the series' color will also be reflected in achart's legend and tooltip.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// Disable this option to allow series rendering in the whole plottingarea.**Note:** Clipping should be always enabled when[chart.zoomType](#chart.zoomType) is set
		/// </summary>
		public bool? Clip { get; set; }
		 

		/// <summary>
		/// The main color of the series. In line type series it applies to theline and the point markers unless otherwise specified. In bar typeseries it applies to the bars unless a color is specified per point.The default value is pulled from the `options.colors` array.In styled mode, the color can be defined by the[colorIndex](#plotOptions.series.colorIndex) option. Also, the seriescolor can be set with the `.highcharts-series`,`.highcharts-color-{n}`, `.highcharts-{type}-series` or`.highcharts-series-{n}` class, or individual classes given by the`className` option.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// When using dual or multiple color axes, this number defines whichcolorAxis the particular series is connected to. It refers toeither the{@link #colorAxis.id|axis id}or the index of the axis in the colorAxis array, with 0 being thefirst. Set this option to false to prevent a series from connectingto the default color axis.Since v7.2.0 the option can also be an axis id or an axis indexinstead of a boolean flag.
		/// </summary>
		public string ColorAxis { get; set; }
		 

		/// <summary>
		/// When using dual or multiple color axes, this number defines whichcolorAxis the particular series is connected to. It refers toeither the{@link #colorAxis.id|axis id}or the index of the axis in the colorAxis array, with 0 being thefirst. Set this option to false to prevent a series from connectingto the default color axis.Since v7.2.0 the option can also be an axis id or an axis indexinstead of a boolean flag.
		/// </summary>
		public double? ColorAxisNumber { get; set; }
		 

		/// <summary>
		/// When using dual or multiple color axes, this number defines whichcolorAxis the particular series is connected to. It refers toeither the{@link #colorAxis.id|axis id}or the index of the axis in the colorAxis array, with 0 being thefirst. Set this option to false to prevent a series from connectingto the default color axis.Since v7.2.0 the option can also be an axis id or an axis indexinstead of a boolean flag.
		/// </summary>
		public bool? ColorAxisBool { get; set; }
		 

		/// <summary>
		/// In an X-range series, this option makes all points of the same Y-axiscategory the same color.
		/// </summary>
		public bool? ColorByPoint { get; set; }
		 

		/// <summary>
		/// Styled mode only. A specific color index to use for the series, so itsgraphic representations are given the class name `highcharts-color-{n}`.Since v11, CSS variables on the form `--highcharts-color-{n}` makechanging the color scheme very convenient.
		/// </summary>
		public double? ColorIndex { get; set; }
		 

		/// <summary>
		/// Determines what data value should be used to calculate point colorif `colorAxis` is used. Requires to set `min` and `max` if somecustom point property is used or if approximation for data groupingis set to `'sum'`.
		/// </summary>
		public string ColorKey { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to apply insteadof the global [colors](#colors) when [colorByPoint](#plotOptions.column.colorByPoint) is true.
		/// </summary>
		public List<string> Colors { get; set; }
		 

		/// <summary>
		/// Compare the values of the series against the first non-null, non-zero value in the visible range. The y axis will show percentageor absolute change depending on whether `compare` is set to `"percent"`or `"value"`. When this is applied to multiple series, it allowscomparing the development of the series against each other. Addsa `change` field to every point object.
		/// </summary>
		public PlotOptionsXrangeCompare Compare { get; set; }
		 

		/// <summary>
		/// When [compare](#plotOptions.series.compare) is `percent`, this optiondictates whether to use 0 or 100 as the base of comparison.
		/// </summary>
		public PlotOptionsXrangeCompareBase CompareBase { get; set; }
		 

		/// <summary>
		/// Defines if comparison should start from the first point within the visiblerange or should start from the last point **before** the range.In other words, this flag determines if first point within the visible rangewill have 0% (`compareStart=true`) or should have been already calculatedaccording to the previous point (`compareStart=false`).
		/// </summary>
		public bool? CompareStart { get; set; }
		 

		/// <summary>
		/// Cumulative Sum feature replaces points' values with the following formula:`sum of all previous points' values + current point's value`.Works only for points in a visible range.Adds the `cumulativeSum` field to each point object that can be accessede.g. in the [tooltip.pointFormat](https://api.highcharts.com/highstock/tooltip.pointFormat).With `dataGrouping` enabled, default grouping approximation is set to `sum`.
		/// </summary>
		public bool? Cumulative { get; set; }
		 

		/// <summary>
		/// Defines if cumulation should start from the first point within the visiblerange or should start from the last point **before** the range.In other words, this flag determines if first point within the visible rangewill start at 0 (`cumulativeStart=true`) or should have been already calculatedaccording to the previous point (`cumulativeStart=false`).
		/// </summary>
		public bool? CumulativeStart { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.In styled mode, the series cursor can be set with the same classesas listed under [series.color](#plotOptions.series.color).
		/// </summary>
		public PlotOptionsXrangeCursor Cursor { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customizedfunctionality. Here you can add additional data for your own eventcallbacks and formatter callbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		 

		/// <summary>
		/// Name of the dash style to use for the graph, or for some series typesthe outline of each shape.In styled mode, the[stroke dash-array](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/series-dashstyle/)can be set with the same classes as listed under[series.color](#plotOptions.series.color).
		/// </summary>
		public PlotOptionsXrangeDashStyle DashStyle { get; set; }
		 

		/// <summary>
		/// Data grouping is the concept of sampling the data values into largerblocks in order to ease readability and increase performance of theJavaScript charts. Highcharts Stock by default applies data grouping whenthe points become closer than a certain pixel value, determined bythe `groupPixelWidth` option.If data grouping is applied, the grouping information of groupedpoints can be read from the [Point.dataGroup](/class-reference/Highcharts.Point#dataGroup). If point options other thanthe data itself are set, for example `name` or `color` or custom properties,the grouping logic doesn't know how to group it. In this case the options ofthe first point instance are copied over to the group point. This can bealtered through a custom `approximation` callback function.
		/// </summary>
		public PlotOptionsXrangeDataGrouping DataGrouping { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeDataLabels DataLabels { get; set; }
		 

		/// <summary>
		/// A description of the series to add to the screen reader informationabout the series.
		/// </summary>
		public string Description { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeDragDrop DragDrop { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		 

		/// <summary>
		/// General event handlers for the series items. These event hooks canalso be attached to the series at run time using the`Highcharts.addEvent` function.
		/// </summary>
		public PlotOptionsXrangeEvents Events { get; set; }
		 

		/// <summary>
		/// Whether to group non-stacked columns or to let them renderindependent of each other. Non-grouped columns will be laid outindividually and overlap each other.
		/// </summary>
		public bool? Grouping { get; set; }
		 

		/// <summary>
		/// Padding between each value groups, in x axis units.
		/// </summary>
		public double? GroupPadding { get; set; }
		 

		/// <summary>
		/// The spacing between columns on the Z Axis in a 3D chart.
		/// </summary>
		public double? GroupZPadding { get; set; }
		 

		/// <summary>
		/// Highlight only the hovered point and fade the remaining points.Scatter-type series require enabling the 'inactive' marker state andadjusting opacity. Note that this approach could affect performancewith large datasets.
		/// </summary>
		public bool? InactiveOtherPoints { get; set; }
		 

		/// <summary>
		/// When set to `false` will prevent the series data from being included inany form of data export.Since version 6.0.0 until 7.1.0 the option was existing undocumentedas `includeInCSVExport`.
		/// </summary>
		public bool? IncludeInDataExport { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		 

		/// <summary>
		/// Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.The series labels currently work with series types having a`graph` or an `area`.
		/// </summary>
		public PlotOptionsXrangeLabel Label { get; set; }
		 

		/// <summary>
		/// The line marks the last price from all points.
		/// </summary>
		public PlotOptionsXrangeLastPrice LastPrice { get; set; }
		 

		/// <summary>
		/// The line marks the last price from visible range of points.
		/// </summary>
		public PlotOptionsXrangeLastVisiblePrice LastVisiblePrice { get; set; }
		 

		/// <summary>
		/// What type of legend symbol to render for this series. Can be one of`areaMarker`, `lineMarker` or `rectangle`.
		/// </summary>
		public PlotOptionsXrangeLegendSymbol LegendSymbol { get; set; }
		 

		/// <summary>
		/// The [id](#series.id) of another series to link to. Additionally,the value can be ":previous" to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.If master series uses data sorting and linked series does not haveits own sorting definition, the linked series will be sorted in thesame order as the master one.
		/// </summary>
		public string LinkedTo { get; set; }
		 

		/// <summary>
		/// The maximum allowed pixel width for a column, translated to theheight of a bar in a bar chart. This prevents the columns frombecoming too wide when there is a small number of points in thechart.
		/// </summary>
		public double? MaxPointWidth { get; set; }
		 

		/// <summary>
		/// The minimal height for a column or width for a bar. By default,0 values are not shown. To visualize a 0 (or close to zero) point,set the minimal point length to a pixel value like 3\. In stackedcolumn charts, minPointLength might not be respected for tightlypacked values.
		/// </summary>
		public double? MinPointLength { get; set; }
		 

		/// <summary>
		/// Options for the _Series on point_ feature. Only `pie` and `sunburst` seriesare supported at this moment.
		/// </summary>
		public PlotOptionsXrangeOnPoint OnPoint { get; set; }
		 

		/// <summary>
		/// Opacity of a series parts: line, fill (e.g. area) and dataLabels.
		/// </summary>
		public double? Opacity { get; set; }
		 

		/// <summary>
		/// A partial fill for each point, typically used to visualize how muchof a task is performed. The partial fill object can be set either onseries or point level.
		/// </summary>
		public PlotOptionsXrangePartialFill PartialFill { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public PlotOptionsXrangePoint Point { get; set; }
		 

		/// <summary>
		/// Same as[accessibility.point.descriptionFormat](#accessibility.point.descriptionFormat),but for an individual series. Overrides the chart wide configuration.
		/// </summary>
		public string PointDescriptionFormat { get; set; }
		 

		/// <summary>
		/// Same as[accessibility.series.descriptionFormatter](#accessibility.series.descriptionFormatter),but for an individual series. Overrides the chart wide configuration.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		 

		/// <summary>
		/// Padding between each column or bar, in x axis units.
		/// </summary>
		public double? PointPadding { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? PointRange { get; set; }
		 

		/// <summary>
		/// A pixel value specifying a fixed width for each column or bar point.When set to `undefined`, the width is calculated from the`pointPadding` and `groupPadding`. The width effects the dimensionthat is not based on the point value. For column series it is thehorizontal length and for bar series it is the vertical length.
		/// </summary>
		public double? PointWidth { get; set; }
		 

		/// <summary>
		/// When true, X values in the data set are relative to the current`pointStart`, `pointInterval` and `pointIntervalUnit` settings. Thisallows compression of the data for datasets with irregular X values.The real X values are computed on the formula `f(x) = ax + b`, where`a` is the `pointInterval` (optionally with a time unit given by`pointIntervalUnit`), and `b` is the `pointStart`.
		/// </summary>
		public bool? RelativeXValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If `showCheckbox` is true,the checkbox next to the series name in the legend will be checkedfor a selected series.
		/// </summary>
		public bool? Selected { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 theshadow can be an object configuration containing `color`, `offsetX`,`offsetY`, `opacity` and `width`.Note that in some cases, like stacked columns or other dense layouts, theseries may cast shadows on each other. In that case, the`chart.seriesGroupShadow` allows applying a common drop shadow to thewhole series group.
		/// </summary>
		public Shadow Shadow { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 theshadow can be an object configuration containing `color`, `offsetX`,`offsetY`, `opacity` and `width`.Note that in some cases, like stacked columns or other dense layouts, theseries may cast shadows on each other. In that case, the`chart.seriesGroupShadow` allows applying a common drop shadow to thewhole series group.
		/// </summary>
		public bool? ShadowBool { get; set; }
		 

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allowselecting the series. The state of the checkbox is determined bythe `selected` option.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in thelegend. Standalone series are shown in legend by default, and linkedseries are not. Since v7.2.0 it is possible to show series that usecolorAxis by setting this option to `true`.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		 

		/// <summary>
		/// Whether or not to show the series in the navigator. Takes precedenceover [navigator.baseSeries](#navigator.baseSeries) if defined.
		/// </summary>
		public bool? ShowInNavigator { get; set; }
		 

		/// <summary>
		/// If set to `true`, the accessibility module will skip past the pointsin this series for keyboard navigation.
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		 

		/// <summary>
		/// Sonification/audio chart options for a series.
		/// </summary>
		public PlotOptionsXrangeSonification Sonification { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeStates States { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` event on aseries isn't triggered until the mouse moves over another series, orout of the plot area. When false, the `mouseOut` event on a series istriggered when the mouse leaves the area around the series' graph ormarkers. This also implies the tooltip when not shared. When`stickyTracking` is false and `tooltip.shared` is false, the tooltipwill be hidden when moving the mouse between series. Defaults to truefor line and area type series, but to false for columns, pies etc.**Note:** The boost module will force this option because oftechnical limitations.
		/// </summary>
		public bool? StickyTracking { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeTooltip Tooltip { get; set; }
		 

		/// <summary>
		/// When a series contains a `data` array that is longer than this, theSeries class looks for data configurations of plain numbers or arrays ofnumbers. The first and last valid points are checked. If found, the restof the data is assumed to be the same. This saves expensive data checkingand indexing in long series, and makes data-heavy charts render faster.Set it to `0` disable.Note:- In boost mode turbo threshold is forced. Only array of numbers or two  dimensional arrays are allowed.- In version 11.4.3 and earlier, if object configurations were passed  beyond the turbo threshold, a warning was logged in the console and the  data series didn't render.
		/// </summary>
		public double? TurboThreshold { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		 

		/// <summary>
		/// Defines the Axis on which the zones are applied.
		/// </summary>
		public string ZoneAxis { get; set; }
		 

		/// <summary>
		/// An array defining zones within a series. Zones can be applied to theX axis, Y axis or Z axis for bubbles, according to the `zoneAxis`option. The zone definitions have to be in ascending order regardingto the value.In styled mode, the color zones are styled with the`.highcharts-zone-{n}` class, or custom classed from the `className`option([view live demo](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/color-zones/)).
		/// </summary>
		public List<PlotOptionsXrangeZones> Zones { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highstock));
			if (AllowPointSelect != null) h.Add("allowPointSelect",AllowPointSelect);
			if (Animation != null) h.Add("animation",Animation);
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (AnimationLimit != null) h.Add("animationLimit",AnimationLimit);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (BorderRadiusString != null) h.Add("borderRadius",BorderRadiusString);
			if (BorderRadiusNumber != null) h.Add("borderRadius",BorderRadiusNumber);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (CenterInCategory != null) h.Add("centerInCategory",CenterInCategory);
			if (ClassName != null) h.Add("className",ClassName);
			if (Clip != null) h.Add("clip",Clip);
			if (Color != null) h.Add("color",Color);
			if (ColorAxis != null) h.Add("colorAxis",ColorAxis);
			if (ColorAxisNumber != null) h.Add("colorAxis",ColorAxisNumber);
			if (ColorAxisBool != null) h.Add("colorAxis",ColorAxisBool);
			if (ColorByPoint != null) h.Add("colorByPoint",ColorByPoint);
			if (ColorIndex != null) h.Add("colorIndex",ColorIndex);
			if (ColorKey != null) h.Add("colorKey",ColorKey);
			if (Colors != null) h.Add("colors",Colors);
			if (Compare != PlotOptionsXrangeCompare.Null) h.Add("compare", highstock.FirstCharacterToLower(Compare.ToString()));
			if (CompareBase != PlotOptionsXrangeCompareBase.Null) h.Add("compareBase", highstock.FirstCharacterToLower(CompareBase.ToString()));
			if (CompareStart != null) h.Add("compareStart",CompareStart);
			if (Cumulative != null) h.Add("cumulative",Cumulative);
			if (CumulativeStart != null) h.Add("cumulativeStart",CumulativeStart);
			if (Cursor != PlotOptionsXrangeCursor.Null) h.Add("cursor", highstock.FirstCharacterToLower(Cursor.ToString()));
			if (Custom != null) h.Add("custom",Custom);
			if (DashStyle != PlotOptionsXrangeDashStyle.Null) h.Add("dashStyle", highstock.FirstCharacterToLower(DashStyle.ToString()));
			if (DataGrouping != null) h.Add("dataGrouping",DataGrouping.ToHashtable(highstock));
			if (DataLabels != null) h.Add("dataLabels",DataLabels.ToHashtable(highstock));
			if (Description != null) h.Add("description",Description);
			if (DragDrop != null) h.Add("dragDrop",DragDrop.ToHashtable(highstock));
			if (EnableMouseTracking != null) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events != null) h.Add("events",Events.ToHashtable(highstock));
			if (Grouping != null) h.Add("grouping",Grouping);
			if (GroupPadding != null) h.Add("groupPadding",GroupPadding);
			if (GroupZPadding != null) h.Add("groupZPadding",GroupZPadding);
			if (InactiveOtherPoints != null) h.Add("inactiveOtherPoints",InactiveOtherPoints);
			if (IncludeInDataExport != null) h.Add("includeInDataExport",IncludeInDataExport);
			if (Keys != null) h.Add("keys",Keys);
			if (Label != null) h.Add("label",Label.ToHashtable(highstock));
			if (LastPrice != null) h.Add("lastPrice",LastPrice.ToHashtable(highstock));
			if (LastVisiblePrice != null) h.Add("lastVisiblePrice",LastVisiblePrice.ToHashtable(highstock));
			if (LegendSymbol != PlotOptionsXrangeLegendSymbol.Null) h.Add("legendSymbol", highstock.FirstCharacterToLower(LegendSymbol.ToString()));
			if (LinkedTo != null) h.Add("linkedTo",LinkedTo);
			if (MaxPointWidth != null) h.Add("maxPointWidth",MaxPointWidth);
			if (MinPointLength != null) h.Add("minPointLength",MinPointLength);
			if (OnPoint != null) h.Add("onPoint",OnPoint.ToHashtable(highstock));
			if (Opacity != null) h.Add("opacity",Opacity);
			if (PartialFill != null) h.Add("partialFill",PartialFill.ToHashtable(highstock));
			if (Point != null) h.Add("point",Point.ToHashtable(highstock));
			if (PointDescriptionFormat != null) { h.Add("pointDescriptionFormat",PointDescriptionFormat); highstock.AddFunction("pointDescriptionFormat", PointDescriptionFormat); }  
			if (PointDescriptionFormatter != null) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); highstock.AddFunction("pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (PointPadding != null) h.Add("pointPadding",PointPadding);
			if (PointRange != null) h.Add("pointRange",PointRange);
			if (PointWidth != null) h.Add("pointWidth",PointWidth);
			if (RelativeXValue != null) h.Add("relativeXValue",RelativeXValue);
			if (Selected != null) h.Add("selected",Selected);
			if (Shadow != null) h.Add("shadow",Shadow.ToHashtable(highstock));
			if (ShadowBool != null) h.Add("shadow",ShadowBool);
			if (ShowCheckbox != null) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != null) h.Add("showInLegend",ShowInLegend);
			if (ShowInNavigator != null) h.Add("showInNavigator",ShowInNavigator);
			if (SkipKeyboardNavigation != null) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Sonification != null) h.Add("sonification",Sonification.ToHashtable(highstock));
			if (States != null) h.Add("states",States.ToHashtable(highstock));
			if (StickyTracking != null) h.Add("stickyTracking",StickyTracking);
			if (Tooltip != null) h.Add("tooltip",Tooltip.ToHashtable(highstock));
			if (TurboThreshold != null) h.Add("turboThreshold",TurboThreshold);
			if (Visible != null) h.Add("visible",Visible);
			if (ZoneAxis != null) h.Add("zoneAxis",ZoneAxis);
			if (Zones != null) h.Add("zones", HashifyList(highstock,Zones));
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
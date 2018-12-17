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
	public partial class BoxplotSeries  : Series
	{
		public BoxplotSeries()
		{
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			AnimationBool = AnimationBool_DefaultValue = null;
			AnimationLimit = AnimationLimit_DefaultValue = null;
			BoostThreshold = BoostThreshold_DefaultValue = 5000;
			ClassName = ClassName_DefaultValue = "";
			Clip = Clip_DefaultValue = true;
			Color = Color_DefaultValue = "";
			ColorByPoint = ColorByPoint_DefaultValue = false;
			ColorIndex = ColorIndex_DefaultValue = null;
			Colors = Colors_DefaultValue = new List<string>();
			Crisp = Crisp_DefaultValue = true;
			CropThreshold = CropThreshold_DefaultValue = 300;
			Cursor = Cursor_DefaultValue = BoxplotSeriesCursor.Null;
			Data = Data_DefaultValue = new List<BoxplotSeriesData>();
			DataLabels = DataLabels_DefaultValue = new BoxplotSeriesDataLabels();
			Depth = Depth_DefaultValue = 25;
			Description = Description_DefaultValue = "";
			DragDrop = DragDrop_DefaultValue = new BoxplotSeriesDragDrop();
			EdgeColor = EdgeColor_DefaultValue = "";
			EdgeWidth = EdgeWidth_DefaultValue = 1;
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			Events = Events_DefaultValue = new BoxplotSeriesEvents();
			ExposeElementToA11y = ExposeElementToA11y_DefaultValue = null;
			FillColor = FillColor_DefaultValue = null;
			FindNearestPointBy = FindNearestPointBy_DefaultValue = BoxplotSeriesFindNearestPointBy.X;
			GetExtremesFromAll = GetExtremesFromAll_DefaultValue = false;
			Grouping = Grouping_DefaultValue = true;
			GroupPadding = GroupPadding_DefaultValue = null;
			Id = Id_DefaultValue = "";
			Index = Index_DefaultValue = null;
			Keys = Keys_DefaultValue = new List<string>();
			Label = Label_DefaultValue = new BoxplotSeriesLabel();
			LegendIndex = LegendIndex_DefaultValue = null;
			LineWidth = LineWidth_DefaultValue = 1;
			LinkedTo = LinkedTo_DefaultValue = "";
			MaxPointWidth = MaxPointWidth_DefaultValue = null;
			MedianColor = MedianColor_DefaultValue = "null";
			MedianWidth = MedianWidth_DefaultValue = 2;
			MinPointLength = MinPointLength_DefaultValue = 0;
			Name = Name_DefaultValue = "";
			NegativeColor = NegativeColor_DefaultValue = "";
			Point = Point_DefaultValue = new BoxplotSeriesPoint();
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			PointInterval = PointInterval_DefaultValue = 1;
			PointIntervalUnit = PointIntervalUnit_DefaultValue = BoxplotSeriesPointIntervalUnit.Null;
			PointPadding = PointPadding_DefaultValue = null;
			PointPlacement = PointPlacement_DefaultValue = new PointPlacement();
			PointRange = PointRange_DefaultValue = null;
			PointStart = PointStart_DefaultValue = 0;
			PointWidth = PointWidth_DefaultValue = null;
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShadowBool = ShadowBool_DefaultValue = null;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			ShowInLegend = ShowInLegend_DefaultValue = true;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			SoftThreshold = SoftThreshold_DefaultValue = true;
			StemColor = StemColor_DefaultValue = "null";
			StemDashStyle = StemDashStyle_DefaultValue = BoxplotSeriesStemDashStyle.Solid;
			StemWidth = StemWidth_DefaultValue = null;
			StickyTracking = StickyTracking_DefaultValue = true;
			Threshold = Threshold_DefaultValue = 0;
			Tooltip = Tooltip_DefaultValue = new BoxplotSeriesTooltip();
			TurboThreshold = TurboThreshold_DefaultValue = 1000;
			Type = Type_DefaultValue = BoxplotSeriesType.Null;
			Visible = Visible_DefaultValue = true;
			WhiskerColor = WhiskerColor_DefaultValue = "null";
			WhiskerLength = WhiskerLength_DefaultValue = "null";
			WhiskerLengthNumber = WhiskerLengthNumber_DefaultValue = null;
			WhiskerWidth = WhiskerWidth_DefaultValue = 2;
			XAxis = XAxis_DefaultValue = "";
			XAxisNumber = XAxisNumber_DefaultValue = null;
			YAxis = YAxis_DefaultValue = "";
			YAxisNumber = YAxisNumber_DefaultValue = null;
			ZIndex = ZIndex_DefaultValue = null;
			ZoneAxis = ZoneAxis_DefaultValue = "y";
			Zones = Zones_DefaultValue = new List<BoxplotSeriesZone>();
			
		}	
		

		/// <summary>
		/// Allow this series' points to be selected by clicking on the graphic(columns, point markers, pie slices, map areas etc).
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods. Thefollowing properties are supported:<dl><dt>duration</dt><dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>Can be a string reference to an easing function set on the `Math`object or a function. See the _Custom easing function_ demo below.</dd></dl>Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods. Thefollowing properties are supported:<dl><dt>duration</dt><dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>Can be a string reference to an easing function set on the `Math`object or a function. See the _Custom easing function_ demo below.</dd></dl>Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public bool? AnimationBool { get; set; }
		private bool? AnimationBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// For some series, there is a limit that shuts down initial animationby default when the total number of points in the chart is too high.For example, for a column chart and its derivatives, animation doesn'trun if there is more than 250 points totally. To disable this cap, set`animationLimit` to `Infinity`.
		/// </summary>
		public double? AnimationLimit { get; set; }
		private double? AnimationLimit_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the point threshold for when a series should enter boost mode.Setting it to e.g. 2000 will cause the series to enter boost mode when thereare 2000 or more points in the series.To disable boosting on the series, set the `boostThreshold` to 0. Setting itto 1 will force boosting.Requires `modules/boost.js`.
		/// </summary>
		public double? BoostThreshold { get; set; }
		private double? BoostThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// An additional class name to apply to the series' graphical elements. Thisoption does not replace default class names of the graphical element.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Disable this option to allow series rendering in the whole plottingarea.**Note:** Clipping should be always enabled when[chart.zoomType](#chart.zoomType) is set
		/// </summary>
		public bool? Clip { get; set; }
		private bool? Clip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color of the series. In line type series it applies to theline and the point markers unless otherwise specified. In bar typeseries it applies to the bars unless a color is specified per point.The default value is pulled from the `options.colors` array.In styled mode, the color can be defined by the[colorIndex](#plotOptions.series.colorIndex) option. Also, the seriescolor can be set with the `.highcharts-series`, `.highcharts-color-{n}`,`.highcharts-{type}-series` or `.highcharts-series-{n}` class, orindividual classes given by the `className` option.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using automatic point colors pulled from the global [colors](colors)or series-specific [plotOptions.column.colors](series.colors)collections, this option determines whether the chart should receiveone color per series or one color per point.In styled mode, the `colors` or `series.colors` arrays are not supported,and instead this option gives the points individual color class names onthe form `highcharts-color-{n}`.
		/// </summary>
		public bool? ColorByPoint { get; set; }
		private bool? ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styled mode only. A specific color index to use for the series, so itsgraphic representations are given the class name `highcharts-color-{n}`.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to apply insteadof the global [colors](#colors) when [colorByPoint](#plotOptions.column.colorByPoint) is true.
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// When true, each column edge is rounded to its nearest pixel in orderto render sharp on screen. In some cases, when there are a lot ofdensely packed columns, this leads to visible difference in columnwidths or distance between columns. In these cases, setting `crisp`to `false` may look better, even though each column is renderedblurry.
		/// </summary>
		public bool? Crisp { get; set; }
		private bool? Crisp_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the series contains less points than the crop threshold, allpoints are drawn, even if the points fall outside the visible plotarea at the current zoom. The advantage of drawing all points (includingmarkers and columns), is that animation is performed on updates.On the other hand, when the series contains more points than thecrop threshold, the series data is cropped to only contain pointsthat fall within the plot area. The advantage of cropping away invisiblepoints is to increase performance on large series.
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.In styled mode, the series cursor can be set with the same classesas listed under [series.color](#plotOptions.series.color).
		/// </summary>
		public BoxplotSeriesCursor Cursor { get; set; }
		private BoxplotSeriesCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `boxplot` seriestype, points can be given in the following ways:1.  An array of arrays with 6 or 5 values. In this case, the valuescorrespond to `x,low,q1,median,q3,high`. If the first value is astring, it is applied as the name of the point, and the `x` valueis inferred. The `x` value can also be omitted, in which case theinner arrays should be of length 5\. Then the `x` value is automaticallycalculated, either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 3, 0, 10, 3, 5],        [1, 7, 8, 7, 2, 9],        [2, 6, 9, 5, 1, 3]    ] ```2.  An array of objects with named values. The following snippet shows only afew settings, see the complete options set below. If the total number of datapoints exceeds the series' [turboThreshold](#series.boxplot.turboThreshold),this option is not available. ```js    data: [{        x: 1,        low: 4,        q1: 9,        median: 9,        q3: 1,        high: 10,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        low: 5,        q1: 7,        median: 3,        q3: 6,        high: 2,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<BoxplotSeriesData> Data { get; set; }
		private List<BoxplotSeriesData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the series data labels, appearing next to each data point.Since v6.2.0, multiple data labels can be applied to each single point bydefining them as an array of configs.In styled mode, the data labels can be styled with the`.highcharts-data-label-box` and `.highcharts-data-label` class names([see example](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/series-datalabels)).
		/// </summary>
		public BoxplotSeriesDataLabels DataLabels { get; set; }
		private BoxplotSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Depth of the columns in a 3D column chart. Requires `highcharts-3d.js`.
		/// </summary>
		public double? Depth { get; set; }
		private double? Depth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Requires the Accessibility module.A description of the series to add to the screen reader informationabout the series.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// The draggable-points module allows points to be moved around or modifiedin the chart. In addition to the options mentioned under the `dragDrop`API structure, the module fires three events,[point.dragStart](plotOptions.series.point.events.dragStart),[point.drag](plotOptions.series.point.events.drag) and[point.drop](plotOptions.series.point.events.drop).It requires the `modules/draggable-points.js` file to be loaded.
		/// </summary>
		public BoxplotSeriesDragDrop DragDrop { get; set; }
		private BoxplotSeriesDragDrop DragDrop_DefaultValue { get; set; }
		 

		/// <summary>
		/// 3D columns only. The color of the edges. Similar to `borderColor`, except it defaults to the same color as the column.
		/// </summary>
		public string EdgeColor { get; set; }
		private string EdgeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 3D columns only. The width of the colored edges.
		/// </summary>
		public double? EdgeWidth { get; set; }
		private double? EdgeWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// General event handlers for the series items. These event hooks can alsobe attached to the series at run time using the `Highcharts.addEvent`function.
		/// </summary>
		public BoxplotSeriesEvents Events { get; set; }
		private BoxplotSeriesEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// By default, series are exposed to screen readers as regions. By enablingthis option, the series element itself will be exposed in the sameway as the data points. This is useful if the series is not usedas a grouping entity in the chart, but you still want to attach adescription to the series.Requires the Accessibility module.
		/// </summary>
		public bool? ExposeElementToA11y { get; set; }
		private bool? ExposeElementToA11y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of the box.In styled mode, the fill color can be set with the`.highcharts-boxplot-box` class.
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Determines whether the series should look for the nearest pointin both dimensions or just the x-dimension when hovering the series.Defaults to `'xy'` for scatter series and `'x'` for most otherseries. If the data has duplicate x-values, it is recommended toset this to `'xy'` to allow hovering over all points.Applies only to series types using nearest neighbor search (notdirect hover) for tooltip.
		/// </summary>
		public BoxplotSeriesFindNearestPointBy FindNearestPointBy { get; set; }
		private BoxplotSeriesFindNearestPointBy FindNearestPointBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to use the Y extremes of the total chart width or only thezoomed area when zooming in on parts of the X axis. By default, theY axis adjusts to the min and max of the visible data. Cartesianseries only.
		/// </summary>
		public bool? GetExtremesFromAll { get; set; }
		private bool? GetExtremesFromAll_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to group non-stacked columns or to let them render independentof each other. Non-grouped columns will be laid out individuallyand overlap each other.
		/// </summary>
		public bool? Grouping { get; set; }
		private bool? Grouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding between each value groups, in x axis units.
		/// </summary>
		public double? GroupPadding { get; set; }
		private double? GroupPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the series. This can be used after render time to get a pointerto the series object through `chart.get()`.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// The index of the series in the chart, affecting the internal index in the`chart.series` array, the visible Z index as well as the order in thelegend.
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

		/// <summary>
		/// Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.The series labels currently work with series types having a`graph` or an `area`.Requires the `series-label.js` module.
		/// </summary>
		public BoxplotSeriesLabel Label { get; set; }
		private BoxplotSeriesLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// The sequential index of the series in the legend.
		/// </summary>
		public double? LegendIndex { get; set; }
		private double? LegendIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the line surrounding the box. If any of[stemWidth](#plotOptions.boxplot.stemWidth),[medianWidth](#plotOptions.boxplot.medianWidth)or [whiskerWidth](#plotOptions.boxplot.whiskerWidth) are `null`,the lineWidth also applies to these lines.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [id](#series.id) of another series to link to. Additionally,the value can be ":previous" to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The maximum allowed pixel width for a column, translated to the heightof a bar in a bar chart. This prevents the columns from becomingtoo wide when there is a small number of points in the chart.
		/// </summary>
		public double? MaxPointWidth { get; set; }
		private double? MaxPointWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the median line. If `null`, the general series colorapplies.In styled mode, the median stroke width can be set with the`.highcharts-boxplot-median` class.
		/// </summary>
		public string MedianColor { get; set; }
		private string MedianColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the median line. If `null`, the[lineWidth](#plotOptions.boxplot.lineWidth) is used.In styled mode, the median stroke width can be set with the`.highcharts-boxplot-median` class.
		/// </summary>
		public double? MedianWidth { get; set; }
		private double? MedianWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimal height for a column or width for a bar. By default,0 values are not shown. To visualize a 0 (or close to zero) point,set the minimal point length to a pixel value like 3\. In stackedcolumn charts, minPointLength might not be respected for tightlypacked values.
		/// </summary>
		public double? MinPointLength { get; set; }
		private double? MinPointLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the series as shown in the legend, tooltip etc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color for the parts of the graph or points that are below the[threshold](#plotOptions.series.threshold).
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public BoxplotSeriesPoint Point { get; set; }
		private BoxplotSeriesPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// Same as [accessibility.pointDescriptionFormatter](#accessibility.pointDescriptionFormatter), but for an individual series.Overrides the chart wide configuration.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// If no x values are given for the points in a series, `pointInterval`defines the interval of the x values. For example, if a series containsone value every decade starting from year 0, set `pointInterval` to`10`. In true `datetime` axes, the `pointInterval` is set inmilliseconds.It can be also be combined with `pointIntervalUnit` to draw irregulartime intervals.Please note that this options applies to the _series data_, not theinterval of the axis ticks, which is independent.
		/// </summary>
		public double? PointInterval { get; set; }
		private double? PointInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// On datetime series, this allows for setting the[pointInterval](#plotOptions.series.pointInterval) to irregular timeunits, `day`, `month` and `year`. A day is usually the same as 24 hours,but `pointIntervalUnit` also takes the DST crossover into considerationwhen dealing with local time. Combine this option with `pointInterval`to draw weeks, quarters, 6 months, 10 years etc.Please note that this options applies to the _series data_, not theinterval of the axis ticks, which is independent.
		/// </summary>
		public BoxplotSeriesPointIntervalUnit PointIntervalUnit { get; set; }
		private BoxplotSeriesPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding between each column or bar, in x axis units.
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Possible values: `"on"`, `"between"`, `number`.In a column chart, when pointPlacement is `"on"`, the point willnot create any padding of the X axis. In a polar column chart thismeans that the first column points directly north. If the pointPlacementis `"between"`, the columns will be laid out between ticks. Thisis useful for example for visualising an amount between two pointsin time or in a certain sector of a polar chart.Since Highcharts 3.0.2, the point placement can also be numeric,where 0 is on the axis value, -0.5 is between this value and theprevious, and 0.5 is between this value and the next. Unlike thetextual options, numeric point placement options won't affect axispadding.Note that pointPlacement needs a [pointRange](#plotOptions.series.pointRange) to work. For column series this iscomputed, but for line-type series it needs to be set.For the `xrange` series type and gantt charts, if the Y axis is acategory axis, the `pointPlacement` applies to the Y axis rather thanthe (typically datetime) X axis.Defaults to `undefined` in cartesian charts, `"between"` in polar charts.
		/// </summary>
		public PointPlacement PointPlacement { get; set; }
		private PointPlacement PointPlacement_DefaultValue { get; set; }
		 

		/// <summary>
		/// The X axis range that each point is valid for. This determines thewidth of the column. On a categorized axis, the range will be 1by default (one category unit). On linear and datetime axes, therange will be computed as the distance between the two closest datapoints.The default `null` means it is computed automatically, but this optioncan be used to override the automatic value.
		/// </summary>
		public double? PointRange { get; set; }
		private double? PointRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// If no x values are given for the points in a series, pointStart defineson what value to start. For example, if a series contains one yearlyvalue starting from 1945, set pointStart to 1945.
		/// </summary>
		public double? PointStart { get; set; }
		private double? PointStart_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pixel value specifying a fixed width for each column or bar. When`null`, the width is calculated from the `pointPadding` and`groupPadding`.
		/// </summary>
		public double? PointWidth { get; set; }
		private double? PointWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If `showCheckbox` is true,the checkbox next to the series name in the legend will be checked for aselected series.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 the shadowcan be an object configuration containing `color`, `offsetX`, `offsetY`,`opacity` and `width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 the shadowcan be an object configuration containing `color`, `offsetX`, `offsetY`,`opacity` and `width`.
		/// </summary>
		public bool? ShadowBool { get; set; }
		private bool? ShadowBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allowselecting the series. The state of the checkbox is determined bythe `selected` option.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		private bool? ShowCheckbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in the legend.The default value is `true` for standalone series, `false` for linkedseries.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// If set to `true`, the accessibility module will skip past the pointsin this series for keyboard navigation.
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		private bool? SkipKeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this is true, the series will not cause the Y axis to crossthe zero plane (or [threshold](#plotOptions.series.threshold) option)unless the data actually crosses the plane.For example, if `softThreshold` is `false`, a series of 0, 1, 2,3 will make the Y axis show negative values according to the `minPadding`option. If `softThreshold` is `true`, the Y axis starts at 0.
		/// </summary>
		public bool? SoftThreshold { get; set; }
		private bool? SoftThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the stem, the vertical line extending from the box tothe whiskers. If `null`, the series color is used.In styled mode, the stem stroke can be set with the`.highcharts-boxplot-stem` class.
		/// </summary>
		public string StemColor { get; set; }
		private string StemColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash style of the stem, the vertical line extending from thebox to the whiskers.
		/// </summary>
		public BoxplotSeriesStemDashStyle StemDashStyle { get; set; }
		private BoxplotSeriesStemDashStyle StemDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the stem, the vertical line extending from the box tothe whiskers. If `null`, the width is inherited from the[lineWidth](#plotOptions.boxplot.lineWidth) option.In styled mode, the stem stroke width can be set with the`.highcharts-boxplot-stem` class.
		/// </summary>
		public double? StemWidth { get; set; }
		private double? StemWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` eventon a series isn't triggered until the mouse moves over another series,or out of the plot area. When false, the `mouseOut` event on aseries is triggered when the mouse leaves the area around the series'graph or markers. This also implies the tooltip when not shared. When`stickyTracking` is false and `tooltip.shared` is false, the tooltip willbe hidden when moving the mouse between series. Defaults to true for lineand area type series, but to false for columns, pies etc.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// The threshold, also called zero level or base level. For line typeseries this is only used in conjunction with[negativeColor](#plotOptions.series.negativeColor).
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object for the tooltip rendering of each single series.Properties are inherited from [tooltip](#tooltip), but only thefollowing properties can be defined on a series level.
		/// </summary>
		public BoxplotSeriesTooltip Tooltip { get; set; }
		private BoxplotSeriesTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains a data array that is longer than this, onlyone dimensional arrays of numbers, or two dimensional arrays withx and y values are allowed. Also, only the first point is tested,and the rest are assumed to be the same format. This saves expensivedata checking and indexing in long series. Set it to `0` disable.
		/// </summary>
		public double? TurboThreshold { get; set; }
		private double? TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// The type of series, for example `line` or `column`. By default, theseries type is inherited from [chart.type](#chart.type), so unless thechart is a combination of series types, there is no need to set it on theseries level.
		/// </summary>
		public BoxplotSeriesType Type { get; set; }
		private BoxplotSeriesType Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the whiskers, the horizontal lines marking low and highvalues. When `null`, the general series color is used.In styled mode, the whisker stroke can be set with the`.highcharts-boxplot-whisker` class .
		/// </summary>
		public string WhiskerColor { get; set; }
		private string WhiskerColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the whiskers, the horizontal lines marking low andhigh values. It can be a numerical pixel value, or a percentagevalue of the box width. Set `0` to disable whiskers.
		/// </summary>
		public string WhiskerLength { get; set; }
		private string WhiskerLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the whiskers, the horizontal lines marking low andhigh values. It can be a numerical pixel value, or a percentagevalue of the box width. Set `0` to disable whiskers.
		/// </summary>
		public double? WhiskerLengthNumber { get; set; }
		private double? WhiskerLengthNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line width of the whiskers, the horizontal lines marking low andhigh values. When `null`, the general[lineWidth](#plotOptions.boxplot.lineWidth) applies.In styled mode, the whisker stroke width can be set with the`.highcharts-boxplot-whisker` class.
		/// </summary>
		public double? WhiskerWidth { get; set; }
		private double? WhiskerWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple x axes, this number defines which xAxis theparticular series is connected to. It refers to either the{@link #xAxis.id|axis id}or the index of the axis in the xAxis array, with 0 being the first.
		/// </summary>
		public string XAxis { get; set; }
		private string XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple x axes, this number defines which xAxis theparticular series is connected to. It refers to either the{@link #xAxis.id|axis id}or the index of the axis in the xAxis array, with 0 being the first.
		/// </summary>
		public double? XAxisNumber { get; set; }
		private double? XAxisNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple y axes, this number defines which yAxis theparticular series is connected to. It refers to either the{@link #yAxis.id|axis id}or the index of the axis in the yAxis array, with 0 being the first.
		/// </summary>
		public string YAxis { get; set; }
		private string YAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple y axes, this number defines which yAxis theparticular series is connected to. It refers to either the{@link #yAxis.id|axis id}or the index of the axis in the yAxis array, with 0 being the first.
		/// </summary>
		public double? YAxisNumber { get; set; }
		private double? YAxisNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Define the visual z index of the series.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the Axis on which the zones are applied.
		/// </summary>
		public string ZoneAxis { get; set; }
		private string ZoneAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining zones within a series. Zones can be applied tothe X axis, Y axis or Z axis for bubbles, according to the `zoneAxis`option. The zone definitions have to be in ascending order regarding tothe value.In styled mode, the color zones are styled with the`.highcharts-zone-{n}` class, or custom classed from the `className`option([view live demo](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/color-zones/)).
		/// </summary>
		public List<BoxplotSeriesZone> Zones { get; set; }
		private List<BoxplotSeriesZone> Zones_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (AnimationLimit != AnimationLimit_DefaultValue) h.Add("animationLimit",AnimationLimit);
			if (BoostThreshold != BoostThreshold_DefaultValue) h.Add("boostThreshold",BoostThreshold);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Clip != Clip_DefaultValue) h.Add("clip",Clip);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (Crisp != Crisp_DefaultValue) h.Add("crisp",Crisp);
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Depth != Depth_DefaultValue) h.Add("depth",Depth);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (DragDrop.IsDirty()) h.Add("dragDrop",DragDrop.ToHashtable());
			if (EdgeColor != EdgeColor_DefaultValue) h.Add("edgeColor",EdgeColor);
			if (EdgeWidth != EdgeWidth_DefaultValue) h.Add("edgeWidth",EdgeWidth);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (ExposeElementToA11y != ExposeElementToA11y_DefaultValue) h.Add("exposeElementToA11y",ExposeElementToA11y);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (FindNearestPointBy != FindNearestPointBy_DefaultValue) h.Add("findNearestPointBy", Highcharts.FirstCharacterToLower(FindNearestPointBy.ToString()));
			if (GetExtremesFromAll != GetExtremesFromAll_DefaultValue) h.Add("getExtremesFromAll",GetExtremesFromAll);
			if (Grouping != Grouping_DefaultValue) h.Add("grouping",Grouping);
			if (GroupPadding != GroupPadding_DefaultValue) h.Add("groupPadding",GroupPadding);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (MaxPointWidth != MaxPointWidth_DefaultValue) h.Add("maxPointWidth",MaxPointWidth);
			if (MedianColor != MedianColor_DefaultValue) h.Add("medianColor",MedianColor);
			if (MedianWidth != MedianWidth_DefaultValue) h.Add("medianWidth",MedianWidth);
			if (MinPointLength != MinPointLength_DefaultValue) h.Add("minPointLength",MinPointLength);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); Highcharts.AddFunction("BoxplotSeriesPointDescriptionFormatter.pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (PointInterval != PointInterval_DefaultValue) h.Add("pointInterval",PointInterval);
			if (PointIntervalUnit != PointIntervalUnit_DefaultValue) h.Add("pointIntervalUnit", Highcharts.FirstCharacterToLower(PointIntervalUnit.ToString()));
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (PointPlacement.IsDirty())
				if (PointPlacement.Value.HasValue)
					h.Add("pointPlacement", PointPlacement.Value);
				else
					h.Add("pointPlacement", PointPlacement.ToJSON());
			if (PointRange != PointRange_DefaultValue) h.Add("pointRange",PointRange);
			if (PointStart != PointStart_DefaultValue) h.Add("pointStart",PointStart);
			if (PointWidth != PointWidth_DefaultValue) h.Add("pointWidth",PointWidth);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShadowBool != ShadowBool_DefaultValue) h.Add("shadow",ShadowBool);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (SoftThreshold != SoftThreshold_DefaultValue) h.Add("softThreshold",SoftThreshold);
			if (StemColor != StemColor_DefaultValue) h.Add("stemColor",StemColor);
			if (StemDashStyle != StemDashStyle_DefaultValue) h.Add("stemDashStyle", Highcharts.FirstCharacterToLower(StemDashStyle.ToString()));
			if (StemWidth != StemWidth_DefaultValue) h.Add("stemWidth",StemWidth);
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (Type != Type_DefaultValue) h.Add("type", Highcharts.FirstCharacterToLower(Type.ToString()));
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (WhiskerColor != WhiskerColor_DefaultValue) h.Add("whiskerColor",WhiskerColor);
			if (WhiskerLength != WhiskerLength_DefaultValue) h.Add("whiskerLength",WhiskerLength);
			if (WhiskerLengthNumber != WhiskerLengthNumber_DefaultValue) h.Add("whiskerLength",WhiskerLengthNumber);
			if (WhiskerWidth != WhiskerWidth_DefaultValue) h.Add("whiskerWidth",WhiskerWidth);
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (XAxisNumber != XAxisNumber_DefaultValue) h.Add("xAxis",XAxisNumber);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			if (YAxisNumber != YAxisNumber_DefaultValue) h.Add("yAxis",YAxisNumber);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (Zones != Zones_DefaultValue) h.Add("zones", HashifyList(Zones));
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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
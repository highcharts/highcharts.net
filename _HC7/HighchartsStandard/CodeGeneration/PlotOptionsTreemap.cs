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
	public partial class PlotOptionsTreemap  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTreemap()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Accessibility options for a series.
		/// </summary>
		public PlotOptionsTreemapAccessibility Accessibility { get; set; }
		 

		/// <summary>
		/// When enabled the user can click on a point which is a parent andzoom in on its children. Deprecated and replaced by[allowTraversingTree](#plotOptions.treemap.allowTraversingTree).
		/// </summary>
		public bool? AllowDrillToNode { get; set; }
		 

		/// <summary>
		/// Allow this series' points to be selected by clicking on the graphic(columns, point markers, pie slices, map areas etc).The selected points can be handled by point select and unselectevents, or collectively by the [getSelectedPoints](/class-reference/Highcharts.Chart#getSelectedPoints) function.And alternative way of selecting points is through dragging.
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		 

		/// <summary>
		/// When enabled the user can click on a point which is a parent andzoom in on its children.
		/// </summary>
		public bool? AllowTraversingTree { get; set; }
		 

		/// <summary>
		/// Enabling this option will make the treemap alternate the drawingdirection between vertical and horizontal. The next levels startingdirection will always be the opposite of the previous.
		/// </summary>
		public bool? AlternateStartingDirection { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.- `duration`: The duration of the animation in milliseconds. (Defaults to  `1000`)- `easing`: Can be a string reference to an easing function set on  the `Math` object or a function. See the _Custom easing function_  demo below. (Defaults to `easeInOutSine`)Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.- `duration`: The duration of the animation in milliseconds. (Defaults to  `1000`)- `easing`: Can be a string reference to an easing function set on  the `Math` object or a function. See the _Custom easing function_  demo below. (Defaults to `easeInOutSine`)Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? AnimationLimit { get; set; }
		 

		/// <summary>
		/// Sets the color blending in the boost module.
		/// </summary>
		public PlotOptionsTreemapBoostBlending BoostBlending { get; set; }
		 

		/// <summary>
		/// Set the point threshold for when a series should enter boost mode.Setting it to e.g. 2000 will cause the series to enter boost mode when thereare 2000 or more points in the series.To disable boosting on the series, set the `boostThreshold` to 0. Setting itto 1 will force boosting.Note that the [cropThreshold](plotOptions.series.cropThreshold) also affectsthis setting. When zooming in on a series that has fewer points than the`cropThreshold`, all points are rendered although outside the visible plotarea, and the `boostThreshold` won't take effect.
		/// </summary>
		public double? BoostThreshold { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each tree map item.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// The border radius for each treemap item.
		/// </summary>
		public double? BorderRadius { get; set; }
		 

		/// <summary>
		/// The width of the border surrounding each tree map item.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// Options for the breadcrumbs, the navigation at the top leading theway up through the traversed levels.
		/// </summary>
		public PlotOptionsTreemapBreadcrumbs Breadcrumbs { get; set; }
		 

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
		/// When using automatic point colors pulled from the `options.colors`collection, this option determines whether the chart should receiveone color per series or one color per point.
		/// </summary>
		public bool? ColorByPoint { get; set; }
		 

		/// <summary>
		/// Styled mode only. A specific color index to use for the series, so itsgraphic representations are given the class name `highcharts-color-{n}`.Since v11, CSS variables on the form `--highcharts-color-{n}` makechanging the color scheme very convenient.
		/// </summary>
		public double? ColorIndex { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ColorKey { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to apply insteadof the global [colors](#colors) when[colorByPoint](#plotOptions.treemap.colorByPoint) is true.
		/// </summary>
		public List<string> Colors { get; set; }
		 

		/// <summary>
		/// When true, each point or column edge is rounded to its nearest pixelin order to render sharp on screen. In some cases, when there are alot of densely packed columns, this leads to visible differencein column widths or distance between columns. In these cases,setting `crisp` to `false` may look better, even though each columnis rendered blurry.
		/// </summary>
		public bool? Crisp { get; set; }
		 

		/// <summary>
		/// When the series contains less points than the crop threshold, allpoints are drawn, event if the points fall outside the visible plotarea at the current zoom. The advantage of drawing all points(including markers and columns), is that animation is performed onupdates. On the other hand, when the series contains more points thanthe crop threshold, the series data is cropped to only contain pointsthat fall within the plot area. The advantage of cropping awayinvisible points is to increase performance on large series.
		/// </summary>
		public double? CropThreshold { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.In styled mode, the series cursor can be set with the same classesas listed under [series.color](#plotOptions.series.color).
		/// </summary>
		public PlotOptionsTreemapCursor Cursor { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customizedfunctionality. Here you can add additional data for your own eventcallbacks and formatter callbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		 

		/// <summary>
		/// Name of the dash style to use for the graph, or for some series typesthe outline of each shape.In styled mode, the[stroke dash-array](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/series-dashstyle/)can be set with the same classes as listed under[series.color](#plotOptions.series.color).
		/// </summary>
		public PlotOptionsTreemapDashStyle DashStyle { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapDataLabels DataLabels { get; set; }
		 

		/// <summary>
		/// A description of the series to add to the screen reader informationabout the series.
		/// </summary>
		public string Description { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapEvents Events { get; set; }
		 

		/// <summary>
		/// Determines whether the series should look for the nearest pointin both dimensions or just the x-dimension when hovering the series.Defaults to `'xy'` for scatter series and `'x'` for most otherseries. If the data has duplicate x-values, it is recommended toset this to `'xy'` to allow hovering over all points.Applies only to series types using nearest neighbor search (notdirect hover) for tooltip.
		/// </summary>
		public PlotOptionsTreemapFindNearestPointBy FindNearestPointBy { get; set; }
		 

		/// <summary>
		/// Whether to use the Y extremes of the total chart width or only thezoomed area when zooming in on parts of the X axis. By default, theY axis adjusts to the min and max of the visible data. Cartesianseries only.
		/// </summary>
		public bool? GetExtremesFromAll { get; set; }
		 

		/// <summary>
		/// Whether to ignore hidden points when the layout algorithm runs.If `false`, hidden points will leave open spaces.
		/// </summary>
		public bool? IgnoreHiddenPoint { get; set; }
		 

		/// <summary>
		/// Highlight only the hovered point and fade the remaining points.Scatter-type series require enabling the 'inactive' marker state andadjusting opacity. Note that this approach could affect performancewith large datasets.
		/// </summary>
		public bool? InactiveOtherPoints { get; set; }
		 

		/// <summary>
		/// When set to `false` will prevent the series data from being included inany form of data export.Since version 6.0.0 until 7.1.0 the option was existing undocumentedas `includeInCSVExport`.
		/// </summary>
		public bool? IncludeInDataExport { get; set; }
		 

		/// <summary>
		/// This option decides if the user can interact with the parent nodesor just the leaf nodes. When this option is undefined, it will betrue by default. However when allowTraversingTree is true, then itwill be false by default.
		/// </summary>
		public bool? InteractByLeaf { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		 

		/// <summary>
		/// Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.The series labels currently work with series types having a`graph` or an `area`.
		/// </summary>
		public PlotOptionsTreemapLabel Label { get; set; }
		 

		/// <summary>
		/// This option decides which algorithm is used for setting positionand dimensions of the points.
		/// </summary>
		public PlotOptionsTreemapLayoutAlgorithm LayoutAlgorithm { get; set; }
		 

		/// <summary>
		/// Defines which direction the layout algorithm will start drawing.
		/// </summary>
		public PlotOptionsTreemapLayoutStartingDirection LayoutStartingDirection { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LegendSymbol { get; set; }
		 

		/// <summary>
		/// Used together with the levels and allowTraversingTree options. Whenset to false the first level visible to be level one, which isdynamic when traversing the tree. Otherwise the level will be thesame as the tree structure.
		/// </summary>
		public bool? LevelIsConstant { get; set; }
		 

		/// <summary>
		/// Set options on specific levels. Takes precedence over series options,but not point options.
		/// </summary>
		public List<PlotOptionsTreemapLevels> Levels { get; set; }
		 

		/// <summary>
		/// The line cap used for line ends and line joins on the graph.
		/// </summary>
		public PlotOptionsTreemapLinecap Linecap { get; set; }
		 

		/// <summary>
		/// Pixel width of the graph line.
		/// </summary>
		public double? LineWidth { get; set; }
		 

		/// <summary>
		/// The [id](#series.id) of another series to link to. Additionally,the value can be ":previous" to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.If master series uses data sorting and linked series does not haveits own sorting definition, the linked series will be sorted in thesame order as the master one.
		/// </summary>
		public string LinkedTo { get; set; }
		 

		/// <summary>
		/// The color for the parts of the graph or points that are below the[threshold](#plotOptions.series.threshold). Note that `zones` takesprecedence over the negative color. Using `negativeColor` isequivalent to applying a zone with value of 0.
		/// </summary>
		public string NegativeColor { get; set; }
		 

		/// <summary>
		/// Options for the _Series on point_ feature. Only `pie` and `sunburst` seriesare supported at this moment.
		/// </summary>
		public PlotOptionsTreemapOnPoint OnPoint { get; set; }
		 

		/// <summary>
		/// The opacity of a point in treemap. When a point has children, thevisibility of the children is determined by the opacity.
		/// </summary>
		public double? Opacity { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public PlotOptionsTreemapPoint Point { get; set; }
		 

		/// <summary>
		/// Same as[accessibility.point.descriptionFormat](#accessibility.point.descriptionFormat),but for an individual series. Overrides the chart wide configuration.
		/// </summary>
		public string PointDescriptionFormat { get; set; }
		 

		/// <summary>
		/// Same as[accessibility.series.descriptionFormatter](#accessibility.series.descriptionFormatter),but for an individual series. Overrides the chart wide configuration.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		 

		/// <summary>
		/// If no x values are given for the points in a series, `pointInterval`defines the interval of the x values. For example, if a seriescontains one value every decade starting from year 0, set`pointInterval` to `10`. In true `datetime` axes, the `pointInterval`is set in milliseconds.It can be also be combined with `pointIntervalUnit` to draw irregulartime intervals.If combined with `relativeXValue`, an x value can be set on eachpoint, and the `pointInterval` is added x times to the `pointStart`setting.Please note that this options applies to the _series data_, not theinterval of the axis ticks, which is independent.
		/// </summary>
		public double? PointInterval { get; set; }
		 

		/// <summary>
		/// On datetime series, this allows for setting the[pointInterval](#plotOptions.series.pointInterval) to irregular timeunits, `day`, `month` and `year`. A day is usually the same as 24hours, but `pointIntervalUnit` also takes the DST crossover intoconsideration when dealing with local time. Combine this option with`pointInterval` to draw weeks, quarters, 6 months, 10 years etc.Please note that this options applies to the _series data_, not theinterval of the axis ticks, which is independent.
		/// </summary>
		public PlotOptionsTreemapPointIntervalUnit PointIntervalUnit { get; set; }
		 

		/// <summary>
		/// If no x values are given for the points in a series, pointStartdefines on what value to start. For example, if a series contains oneyearly value starting from 1945, set pointStart to 1945.If combined with `relativeXValue`, an x value can be set on eachpoint. The x value from the point options is multiplied by`pointInterval` and added to `pointStart` to produce a modified xvalue.
		/// </summary>
		public double? PointStart { get; set; }
		 

		/// <summary>
		/// When true, X values in the data set are relative to the current`pointStart`, `pointInterval` and `pointIntervalUnit` settings. Thisallows compression of the data for datasets with irregular X values.The real X values are computed on the formula `f(x) = ax + b`, where`a` is the `pointInterval` (optionally with a time unit given by`pointIntervalUnit`), and `b` is the `pointStart`.
		/// </summary>
		public bool? RelativeXValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If `showCheckbox` is true,the checkbox next to the series name in the legend will be checkedfor a selected series.
		/// </summary>
		public bool? Selected { get; set; }
		 

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allowselecting the series. The state of the checkbox is determined bythe `selected` option.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		 

		/// <summary>
		/// Whether to display this series type or specific series item in thelegend.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		 

		/// <summary>
		/// If set to `true`, the accessibility module will skip past the pointsin this series for keyboard navigation.
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		 

		/// <summary>
		/// When this is true, the series will not cause the Y axis to crossthe zero plane (or [threshold](#plotOptions.series.threshold) option)unless the data actually crosses the plane.For example, if `softThreshold` is `false`, a series of 0, 1, 2,3 will make the Y axis show negative values according to the`minPadding` option. If `softThreshold` is `true`, the Y axis startsat 0.
		/// </summary>
		public bool? SoftThreshold { get; set; }
		 

		/// <summary>
		/// Sonification/audio chart options for a series.
		/// </summary>
		public PlotOptionsTreemapSonification Sonification { get; set; }
		 

		/// <summary>
		/// The sort index of the point inside the treemap level.
		/// </summary>
		public double? SortIndex { get; set; }
		 

		/// <summary>
		/// Whether to stack the values of each series on top of each other.Possible values are `undefined` to disable, `"normal"` to stack byvalue or `"percent"`.When stacking is enabled, data must be sortedin ascending X order.Some stacking options are related to specific series types. In thestreamgraph series type, the stacking option is set to `"stream"`.The second one is `"overlap"`, which only applies to waterfallseries.
		/// </summary>
		public PlotOptionsTreemapStacking Stacking { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsTreemapStates States { get; set; }
		 

		/// <summary>
		/// Whether to apply steps to the line. Possible values are `left`,`center` and `right`.
		/// </summary>
		public PlotOptionsTreemapStep Step { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` event on aseries isn't triggered until the mouse moves over another series, orout of the plot area. When false, the `mouseOut` event on a series istriggered when the mouse leaves the area around the series' graph ormarkers. This also implies the tooltip when not shared. When`stickyTracking` is false and `tooltip.shared` is false, the tooltipwill be hidden when moving the mouse between series. Defaults to truefor line and area type series, but to false for columns, pies etc.**Note:** The boost module will force this option because oftechnical limitations.
		/// </summary>
		public bool? StickyTracking { get; set; }
		 

		/// <summary>
		/// The threshold, also called zero level or base level. For line typeseries this is only used in conjunction with[negativeColor](#plotOptions.series.negativeColor).
		/// </summary>
		public double? Threshold { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapTooltip Tooltip { get; set; }
		 

		/// <summary>
		/// Options for the button appearing when traversing down in a treemap.Since v9.3.3 the `traverseUpButton` is replaced by `breadcrumbs`.
		/// </summary>
		public PlotOptionsTreemapTraverseUpButton TraverseUpButton { get; set; }
		 

		/// <summary>
		/// When a series contains a data array that is longer than this, onlyone dimensional arrays of numbers, or two dimensional arrays withx and y values are allowed. Also, only the first point is tested,and the rest are assumed to be the same format. This saves expensivedata checking and indexing in long series. Set it to `0` disable.Note:In boost mode turbo threshold is forced. Only array of numbers ortwo dimensional arrays are allowed.
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
		public List<PlotOptionsTreemapZone> Zones { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (AllowDrillToNode != null) h.Add("allowDrillToNode",AllowDrillToNode);
			if (AllowPointSelect != null) h.Add("allowPointSelect",AllowPointSelect);
			if (AllowTraversingTree != null) h.Add("allowTraversingTree",AllowTraversingTree);
			if (AlternateStartingDirection != null) h.Add("alternateStartingDirection",AlternateStartingDirection);
			if (Animation != null) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (AnimationLimit != null) h.Add("animationLimit",AnimationLimit);
			if (BoostBlending != PlotOptionsTreemapBoostBlending.Null) h.Add("boostBlending", highcharts.FirstCharacterToLower(BoostBlending.ToString()));
			if (BoostThreshold != null) h.Add("boostThreshold",BoostThreshold);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (Breadcrumbs != null) h.Add("breadcrumbs",Breadcrumbs.ToHashtable(highcharts));
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
			if (Crisp != null) h.Add("crisp",Crisp);
			if (CropThreshold != null) h.Add("cropThreshold",CropThreshold);
			if (Cursor != PlotOptionsTreemapCursor.Null) h.Add("cursor", highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (Custom != null) h.Add("custom",Custom);
			if (DashStyle != PlotOptionsTreemapDashStyle.Null) h.Add("dashStyle", highcharts.FirstCharacterToLower(DashStyle.ToString()));
			if (DataLabels != null) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (Description != null) h.Add("description",Description);
			if (EnableMouseTracking != null) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events != null) h.Add("events",Events.ToHashtable(highcharts));
			if (FindNearestPointBy != PlotOptionsTreemapFindNearestPointBy.Null) h.Add("findNearestPointBy", highcharts.FirstCharacterToLower(FindNearestPointBy.ToString()));
			if (GetExtremesFromAll != null) h.Add("getExtremesFromAll",GetExtremesFromAll);
			if (IgnoreHiddenPoint != null) h.Add("ignoreHiddenPoint",IgnoreHiddenPoint);
			if (InactiveOtherPoints != null) h.Add("inactiveOtherPoints",InactiveOtherPoints);
			if (IncludeInDataExport != null) h.Add("includeInDataExport",IncludeInDataExport);
			if (InteractByLeaf != null) h.Add("interactByLeaf",InteractByLeaf);
			if (Keys != null) h.Add("keys",Keys);
			if (Label != null) h.Add("label",Label.ToHashtable(highcharts));
			if (LayoutAlgorithm != PlotOptionsTreemapLayoutAlgorithm.Null) h.Add("layoutAlgorithm", highcharts.FirstCharacterToLower(LayoutAlgorithm.ToString()));
			if (LayoutStartingDirection != PlotOptionsTreemapLayoutStartingDirection.Null) h.Add("layoutStartingDirection", highcharts.FirstCharacterToLower(LayoutStartingDirection.ToString()));
			if (LegendSymbol != null) h.Add("legendSymbol",LegendSymbol);
			if (LevelIsConstant != null) h.Add("levelIsConstant",LevelIsConstant);
			if (Levels != null) h.Add("levels", HashifyList(highcharts,Levels));
			if (Linecap != PlotOptionsTreemapLinecap.Null) h.Add("linecap", highcharts.FirstCharacterToLower(Linecap.ToString()));
			if (LineWidth != null) h.Add("lineWidth",LineWidth);
			if (LinkedTo != null) h.Add("linkedTo",LinkedTo);
			if (NegativeColor != null) h.Add("negativeColor",NegativeColor);
			if (OnPoint != null) h.Add("onPoint",OnPoint.ToHashtable(highcharts));
			if (Opacity != null) h.Add("opacity",Opacity);
			if (Point != null) h.Add("point",Point.ToHashtable(highcharts));
			if (PointDescriptionFormat != null) { h.Add("pointDescriptionFormat",PointDescriptionFormat); highcharts.AddFunction("pointDescriptionFormat", PointDescriptionFormat); }  
			if (PointDescriptionFormatter != null) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); highcharts.AddFunction("pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (PointInterval != null) h.Add("pointInterval",PointInterval);
			if (PointIntervalUnit != PlotOptionsTreemapPointIntervalUnit.Null) h.Add("pointIntervalUnit", highcharts.FirstCharacterToLower(PointIntervalUnit.ToString()));
			if (PointStart != null) h.Add("pointStart",PointStart);
			if (RelativeXValue != null) h.Add("relativeXValue",RelativeXValue);
			if (Selected != null) h.Add("selected",Selected);
			if (ShowCheckbox != null) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != null) h.Add("showInLegend",ShowInLegend);
			if (SkipKeyboardNavigation != null) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (SoftThreshold != null) h.Add("softThreshold",SoftThreshold);
			if (Sonification != null) h.Add("sonification",Sonification.ToHashtable(highcharts));
			if (SortIndex != null) h.Add("sortIndex",SortIndex);
			if (Stacking != PlotOptionsTreemapStacking.Null) h.Add("stacking", highcharts.FirstCharacterToLower(Stacking.ToString()));
			if (States != null) h.Add("states",States.ToHashtable(highcharts));
			if (Step != PlotOptionsTreemapStep.Null) h.Add("step", highcharts.FirstCharacterToLower(Step.ToString()));
			if (StickyTracking != null) h.Add("stickyTracking",StickyTracking);
			if (Threshold != null) h.Add("threshold",Threshold);
			if (Tooltip != null) h.Add("tooltip",Tooltip.ToHashtable(highcharts));
			if (TraverseUpButton != null) h.Add("traverseUpButton",TraverseUpButton.ToHashtable(highcharts));
			if (TurboThreshold != null) h.Add("turboThreshold",TurboThreshold);
			if (Visible != null) h.Add("visible",Visible);
			if (ZoneAxis != null) h.Add("zoneAxis",ZoneAxis);
			if (Zones != null) h.Add("zones", HashifyList(highcharts,Zones));
			if (CustomFields.Count > 0)
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
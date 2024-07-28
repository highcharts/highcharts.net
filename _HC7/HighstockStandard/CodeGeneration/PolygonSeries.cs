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
	public partial class PolygonSeries  : Series
	{
		Hashtable h = new Hashtable();

		public PolygonSeries()
		{
		}	
		

		/// <summary>
		/// Accessibility options for a series.
		/// </summary>
		public PolygonSeriesAccessibility Accessibility { get; set; }
		 

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
		/// Styled mode only. A specific color index to use for the series, so itsgraphic representations are given the class name `highcharts-color-{n}`.Since v11, CSS variables on the form `--highcharts-color-{n}` makechanging the color scheme very convenient.
		/// </summary>
		public double? ColorIndex { get; set; }
		 

		/// <summary>
		/// Determines what data value should be used to calculate point colorif `colorAxis` is used. Requires to set `min` and `max` if somecustom point property is used or if approximation for data groupingis set to `'sum'`.
		/// </summary>
		public string ColorKey { get; set; }
		 

		/// <summary>
		/// Compare the values of the series against the first non-null, non-zero value in the visible range. The y axis will show percentageor absolute change depending on whether `compare` is set to `"percent"`or `"value"`. When this is applied to multiple series, it allowscomparing the development of the series against each other. Addsa `change` field to every point object.
		/// </summary>
		public PolygonSeriesCompare Compare { get; set; }
		 

		/// <summary>
		/// When [compare](#plotOptions.series.compare) is `percent`, this optiondictates whether to use 0 or 100 as the base of comparison.
		/// </summary>
		public PolygonSeriesCompareBase CompareBase { get; set; }
		 

		/// <summary>
		/// Defines if comparison should start from the first point within the visiblerange or should start from the last point **before** the range.In other words, this flag determines if first point within the visible rangewill have 0% (`compareStart=true`) or should have been already calculatedaccording to the previous point (`compareStart=false`).
		/// </summary>
		public bool? CompareStart { get; set; }
		 

		/// <summary>
		/// Whether to connect a graph line across null points, or render a gapbetween the two points on either side of the null.In stacked area chart, if `connectNulls` is set to true,null points are interpreted as 0.
		/// </summary>
		public bool? ConnectNulls { get; set; }
		 

		/// <summary>
		/// When true, each point or column edge is rounded to its nearest pixelin order to render sharp on screen. In some cases, when there are alot of densely packed columns, this leads to visible differencein column widths or distance between columns. In these cases,setting `crisp` to `false` may look better, even though each columnis rendered blurry.
		/// </summary>
		public bool? Crisp { get; set; }
		 

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
		public PolygonSeriesCursor Cursor { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customizedfunctionality. Here you can add additional data for your own eventcallbacks and formatter callbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		 

		/// <summary>
		/// Name of the dash style to use for the graph, or for some series typesthe outline of each shape.In styled mode, the[stroke dash-array](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/series-dashstyle/)can be set with the same classes as listed under[series.color](#plotOptions.series.color).
		/// </summary>
		public PolygonSeriesDashStyle DashStyle { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `polygon` seriestype, points can be given in the following ways:1. An array of numerical values. In this case, the numerical values will be   interpreted as `y` options. The `x` values will be automatically   calculated, either starting at 0 and incremented by 1, or from   `pointStart` and `pointInterval` given in the series options. If the axis   has categories, these will be used. Example:   ```js   data: [0, 5, 3, 5]   ```2. An array of arrays with 2 values. In this case, the values correspond to   `x,y`. If the first value is a string, it is applied as the name of the   point, and the `x` value is inferred.   ```js   data: [       [0, 10],       [1, 3],       [2, 1]   ]   ```3. An array of objects with named values. The following snippet shows only a   few settings, see the complete options set below. If the total number of   data points exceeds the series'   [turboThreshold](#series.polygon.turboThreshold), this option is not   available.   ```js   data: [{       x: 1,       y: 1,       name: "Point2",       color: "#00FF00"   }, {       x: 1,       y: 8,       name: "Point1",       color: "#FF00FF"   }]   ```
		/// </summary>
		public List<PolygonSeriesData> Data { get; set; }
		 

		/// <summary>
		/// Data grouping is the concept of sampling the data values into largerblocks in order to ease readability and increase performance of theJavaScript charts. Highcharts Stock by default applies data grouping whenthe points become closer than a certain pixel value, determined bythe `groupPixelWidth` option.If data grouping is applied, the grouping information of groupedpoints can be read from the [Point.dataGroup](/class-reference/Highcharts.Point#dataGroup). If point options other thanthe data itself are set, for example `name` or `color` or custom properties,the grouping logic doesn't know how to group it. In this case the options ofthe first point instance are copied over to the group point. This can bealtered through a custom `approximation` callback function.
		/// </summary>
		public PolygonSeriesDataGrouping DataGrouping { get; set; }
		 

		/// <summary>
		/// Options for the series data labels, appearing next to each datapoint.Since v6.2.0, multiple data labels can be applied to each singlepoint by defining them as an array of configs.In styled mode, the data labels can be styled with the`.highcharts-data-label-box` and `.highcharts-data-label` class names([see example](https://www.highcharts.com/samples/highcharts/css/series-datalabels)).
		/// </summary>
		public PolygonSeriesDataLabels DataLabels { get; set; }
		 

		/// <summary>
		/// Options for the series data sorting.
		/// </summary>
		public PolygonSeriesDataSorting DataSorting { get; set; }
		 

		/// <summary>
		/// A description of the series to add to the screen reader informationabout the series.
		/// </summary>
		public string Description { get; set; }
		 

		/// <summary>
		/// The draggable-points module allows points to be moved around or modified inthe chart. In addition to the options mentioned under the `dragDrop` APIstructure, the module fires three events,[point.dragStart](plotOptions.series.point.events.dragStart),[point.drag](plotOptions.series.point.events.drag) and[point.drop](plotOptions.series.point.events.drop).
		/// </summary>
		public PolygonSeriesDragDrop DragDrop { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		 

		/// <summary>
		/// General event handlers for the series items. These event hooks canalso be attached to the series at run time using the`Highcharts.addEvent` function.
		/// </summary>
		public PolygonSeriesEvents Events { get; set; }
		 

		/// <summary>
		/// Determines whether the series should look for the nearest pointin both dimensions or just the x-dimension when hovering the series.Defaults to `'xy'` for scatter series and `'x'` for most otherseries. If the data has duplicate x-values, it is recommended toset this to `'xy'` to allow hovering over all points.Applies only to series types using nearest neighbor search (notdirect hover) for tooltip.
		/// </summary>
		public PolygonSeriesFindNearestPointBy FindNearestPointBy { get; set; }
		 

		/// <summary>
		/// Defines when to display a gap in the graph, together with the[gapUnit](plotOptions.series.gapUnit) option.In case when `dataGrouping` is enabled, points can be groupedinto a larger time span. This can make the grouped points tohave a greater distance than the absolute value of `gapSize`property, which will result in disappearing graph completely.To prevent this situation the mentioned distance betweengrouped points is used instead of previously defined`gapSize`.In practice, this option is most often used to visualize gapsin time series. In a stock chart, intraday data is availablefor daytime hours, while gaps will appear in nights andweekends.
		/// </summary>
		public double? GapSize { get; set; }
		 

		/// <summary>
		/// Together with [gapSize](plotOptions.series.gapSize), thisoption defines where to draw gaps in the graph.When the `gapUnit` is `"relative"` (default), a gap size of 5means that if the distance between two points is greater than5 times that of the two closest points, the graph will bebroken.When the `gapUnit` is `"value"`, the gap is based on absoluteaxis values, which on a datetime axis is milliseconds. Thisalso applies to the navigator series that inherits gapoptions from the base series.
		/// </summary>
		public PolygonSeriesGapUnit GapUnit { get; set; }
		 

		/// <summary>
		/// Whether to use the Y extremes of the total chart width or only thezoomed area when zooming in on parts of the X axis. By default, theY axis adjusts to the min and max of the visible data. Cartesianseries only.
		/// </summary>
		public bool? GetExtremesFromAll { get; set; }
		 

		/// <summary>
		/// An id for the series. This can be used after render time to get a pointerto the series object through `chart.get()`.
		/// </summary>
		public override string Id { get; set; }
		 

		/// <summary>
		/// Highlight only the hovered point and fade the remaining points.Scatter-type series require enabling the 'inactive' marker state andadjusting opacity. Note that this approach could affect performancewith large datasets.
		/// </summary>
		public bool? InactiveOtherPoints { get; set; }
		 

		/// <summary>
		/// When set to `false` will prevent the series data from being included inany form of data export.Since version 6.0.0 until 7.1.0 the option was existing undocumentedas `includeInCSVExport`.
		/// </summary>
		public bool? IncludeInDataExport { get; set; }
		 

		/// <summary>
		/// The index of the series in the chart, affecting the internal index in the`chart.series` array, the visible Z index as well as the order in thelegend.
		/// </summary>
		public override double? Index { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		 

		/// <summary>
		/// Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.The series labels currently work with series types having a`graph` or an `area`.
		/// </summary>
		public PolygonSeriesLabel Label { get; set; }
		 

		/// <summary>
		/// The line marks the last price from all points.
		/// </summary>
		public PolygonSeriesLastPrice LastPrice { get; set; }
		 

		/// <summary>
		/// The line marks the last price from visible range of points.
		/// </summary>
		public PolygonSeriesLastVisiblePrice LastVisiblePrice { get; set; }
		 

		/// <summary>
		/// The sequential index of the series in the legend.
		/// </summary>
		public override double? LegendIndex { get; set; }
		 

		/// <summary>
		/// What type of legend symbol to render for this series. Can be one of`areaMarker`, `lineMarker` or `rectangle`.
		/// </summary>
		public PolygonSeriesLegendSymbol LegendSymbol { get; set; }
		 

		/// <summary>
		/// The line cap used for line ends and line joins on the graph.
		/// </summary>
		public PolygonSeriesLinecap Linecap { get; set; }
		 

		/// <summary>
		/// Pixel width of the graph line.
		/// </summary>
		public double? LineWidth { get; set; }
		 

		/// <summary>
		/// The [id](#series.id) of another series to link to. Additionally,the value can be ":previous" to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.If master series uses data sorting and linked series does not haveits own sorting definition, the linked series will be sorted in thesame order as the master one.
		/// </summary>
		public string LinkedTo { get; set; }
		 

		/// <summary>
		/// Options for the point markers of line and scatter-like series. Propertieslike `fillColor`, `lineColor` and `lineWidth` define the visualappearance of the markers. The `symbol` option defines the shape. Otherseries types, like column series, don't have markers, but have visualoptions on the series level instead.In styled mode, the markers can be styled with the `.highcharts-point`,`.highcharts-point-hover` and `.highcharts-point-select` class names.
		/// </summary>
		public PolygonSeriesMarker Marker { get; set; }
		 

		/// <summary>
		/// The name of the series as shown in the legend, tooltip etc.
		/// </summary>
		public override string Name { get; set; }
		 

		/// <summary>
		/// The color for the parts of the graph or points that are below the[threshold](#plotOptions.series.threshold). Note that `zones` takesprecedence over the negative color. Using `negativeColor` isequivalent to applying a zone with value of 0.
		/// </summary>
		public string NegativeColor { get; set; }
		 

		/// <summary>
		/// Options for the _Series on point_ feature. Only `pie` and `sunburst` seriesare supported at this moment.
		/// </summary>
		public PolygonSeriesOnPoint OnPoint { get; set; }
		 

		/// <summary>
		/// Opacity of a series parts: line, fill (e.g. area) and dataLabels.
		/// </summary>
		public double? Opacity { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public PolygonSeriesPoint Point { get; set; }
		 

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
		public PolygonSeriesPointIntervalUnit PointIntervalUnit { get; set; }
		 

		/// <summary>
		/// The width of each point on the x axis. For example in a column chartwith one value each day, the pointRange would be 1 day (= 24 * 3600* 1000 milliseconds). This is normally computed automatically, butthis option can be used to override the automatic value.
		/// </summary>
		public double? PointRange { get; set; }
		 

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
		public PolygonSeriesSonification Sonification { get; set; }
		 

		/// <summary>
		/// Whether to stack the values of each series on top of each other.Possible values are `undefined` to disable, `"normal"` to stack byvalue or `"percent"`.When stacking is enabled, data must be sortedin ascending X order.Some stacking options are related to specific series types. In thestreamgraph series type, the stacking option is set to `"stream"`.The second one is `"overlap"`, which only applies to waterfallseries.
		/// </summary>
		public PolygonSeriesStacking Stacking { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PolygonSeriesStates States { get; set; }
		 

		/// <summary>
		/// Whether to apply steps to the line. Possible values are `left`,`center` and `right`.
		/// </summary>
		public PolygonSeriesStep Step { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` event on aseries isn't triggered until the mouse moves over another series, orout of the plot area. When false, the `mouseOut` event on a series istriggered when the mouse leaves the area around the series' graph ormarkers. This also implies the tooltip when not shared. When`stickyTracking` is false and `tooltip.shared` is false, the tooltipwill be hidden when moving the mouse between series. Defaults to truefor line and area type series, but to false for columns, pies etc.**Note:** The boost module will force this option because oftechnical limitations.
		/// </summary>
		public bool? StickyTracking { get; set; }
		 

		/// <summary>
		/// A configuration object for the tooltip rendering of each singleseries. Properties are inherited from [tooltip](#tooltip), but onlythe following properties can be defined on a series level.
		/// </summary>
		public PolygonSeriesTooltip Tooltip { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? TrackByArea { get; set; }
		 

		/// <summary>
		/// When a series contains a `data` array that is longer than this, theSeries class looks for data configurations of plain numbers or arrays ofnumbers. The first and last valid points are checked. If found, the restof the data is assumed to be the same. This saves expensive data checkingand indexing in long series, and makes data-heavy charts render faster.Set it to `0` disable.Note:- In boost mode turbo threshold is forced. Only array of numbers or two  dimensional arrays are allowed.- In version 11.4.3 and earlier, if object configurations were passed  beyond the turbo threshold, a warning was logged in the console and the  data series didn't render.
		/// </summary>
		public double? TurboThreshold { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		 

		/// <summary>
		/// When using dual or multiple x axes, this number defines which xAxis theparticular series is connected to. It refers to either the{@link #xAxis.id|axis id}or the index of the axis in the xAxis array, with 0 being the first.
		/// </summary>
		public override string XAxis { get; set; }
		 

		/// <summary>
		/// When using dual or multiple x axes, this number defines which xAxis theparticular series is connected to. It refers to either the{@link #xAxis.id|axis id}or the index of the axis in the xAxis array, with 0 being the first.
		/// </summary>
		public override double? XAxisNumber { get; set; }
		 

		/// <summary>
		/// When using dual or multiple y axes, this number defines which yAxis theparticular series is connected to. It refers to either the{@link #yAxis.id|axis id}or the index of the axis in the yAxis array, with 0 being the first.
		/// </summary>
		public override string YAxis { get; set; }
		 

		/// <summary>
		/// When using dual or multiple y axes, this number defines which yAxis theparticular series is connected to. It refers to either the{@link #yAxis.id|axis id}or the index of the axis in the yAxis array, with 0 being the first.
		/// </summary>
		public override double? YAxisNumber { get; set; }
		 

		/// <summary>
		/// Define the visual z index of the series.
		/// </summary>
		public override double? ZIndex { get; set; }
		 

		/// <summary>
		/// Defines the Axis on which the zones are applied.
		/// </summary>
		public string ZoneAxis { get; set; }
		 

		/// <summary>
		/// An array defining zones within a series. Zones can be applied to theX axis, Y axis or Z axis for bubbles, according to the `zoneAxis`option. The zone definitions have to be in ascending order regardingto the value.In styled mode, the color zones are styled with the`.highcharts-zone-{n}` class, or custom classed from the `className`option([view live demo](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/color-zones/)).
		/// </summary>
		public List<PolygonSeriesZones> Zones { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highstock));
			if (AllowPointSelect != null) h.Add("allowPointSelect",AllowPointSelect);
			if (Animation != null) h.Add("animation",Animation);
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (AnimationLimit != null) h.Add("animationLimit",AnimationLimit);
			if (ClassName != null) h.Add("className",ClassName);
			if (Clip != null) h.Add("clip",Clip);
			if (Color != null) h.Add("color",Color);
			if (ColorAxis != null) h.Add("colorAxis",ColorAxis);
			if (ColorAxisNumber != null) h.Add("colorAxis",ColorAxisNumber);
			if (ColorAxisBool != null) h.Add("colorAxis",ColorAxisBool);
			if (ColorIndex != null) h.Add("colorIndex",ColorIndex);
			if (ColorKey != null) h.Add("colorKey",ColorKey);
			if (Compare != PolygonSeriesCompare.Null) h.Add("compare", highstock.FirstCharacterToLower(Compare.ToString()));
			if (CompareBase != PolygonSeriesCompareBase.Null) h.Add("compareBase", highstock.FirstCharacterToLower(CompareBase.ToString()));
			if (CompareStart != null) h.Add("compareStart",CompareStart);
			if (ConnectNulls != null) h.Add("connectNulls",ConnectNulls);
			if (Crisp != null) h.Add("crisp",Crisp);
			if (Cumulative != null) h.Add("cumulative",Cumulative);
			if (CumulativeStart != null) h.Add("cumulativeStart",CumulativeStart);
			if (Cursor != PolygonSeriesCursor.Null) h.Add("cursor", highstock.FirstCharacterToLower(Cursor.ToString()));
			if (Custom != null) h.Add("custom",Custom);
			if (DashStyle != PolygonSeriesDashStyle.Null) h.Add("dashStyle", highstock.FirstCharacterToLower(DashStyle.ToString()));
			if (Data != null) h.Add("data",HashifyList(highstock,Data));
			if (DataGrouping != null) h.Add("dataGrouping",DataGrouping.ToHashtable(highstock));
			if (DataLabels != null) h.Add("dataLabels",DataLabels.ToHashtable(highstock));
			if (DataSorting != null) h.Add("dataSorting",DataSorting.ToHashtable(highstock));
			if (Description != null) h.Add("description",Description);
			if (DragDrop != null) h.Add("dragDrop",DragDrop.ToHashtable(highstock));
			if (EnableMouseTracking != null) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events != null) h.Add("events",Events.ToHashtable(highstock));
			if (FindNearestPointBy != PolygonSeriesFindNearestPointBy.Null) h.Add("findNearestPointBy", highstock.FirstCharacterToLower(FindNearestPointBy.ToString()));
			if (GapSize != null) h.Add("gapSize",GapSize);
			if (GapUnit != PolygonSeriesGapUnit.Null) h.Add("gapUnit", highstock.FirstCharacterToLower(GapUnit.ToString()));
			if (GetExtremesFromAll != null) h.Add("getExtremesFromAll",GetExtremesFromAll);
			if (Id != null) h.Add("id",Id);
			if (InactiveOtherPoints != null) h.Add("inactiveOtherPoints",InactiveOtherPoints);
			if (IncludeInDataExport != null) h.Add("includeInDataExport",IncludeInDataExport);
			if (Index != null) h.Add("index",Index);
			if (Keys != null) h.Add("keys",Keys);
			if (Label != null) h.Add("label",Label.ToHashtable(highstock));
			if (LastPrice != null) h.Add("lastPrice",LastPrice.ToHashtable(highstock));
			if (LastVisiblePrice != null) h.Add("lastVisiblePrice",LastVisiblePrice.ToHashtable(highstock));
			if (LegendIndex != null) h.Add("legendIndex",LegendIndex);
			if (LegendSymbol != PolygonSeriesLegendSymbol.Null) h.Add("legendSymbol", highstock.FirstCharacterToLower(LegendSymbol.ToString()));
			if (Linecap != PolygonSeriesLinecap.Null) h.Add("linecap", highstock.FirstCharacterToLower(Linecap.ToString()));
			if (LineWidth != null) h.Add("lineWidth",LineWidth);
			if (LinkedTo != null) h.Add("linkedTo",LinkedTo);
			if (Marker != null) h.Add("marker",Marker.ToHashtable(highstock));
			if (Name != null) h.Add("name",Name);
			if (NegativeColor != null) h.Add("negativeColor",NegativeColor);
			if (OnPoint != null) h.Add("onPoint",OnPoint.ToHashtable(highstock));
			if (Opacity != null) h.Add("opacity",Opacity);
			if (Point != null) h.Add("point",Point.ToHashtable(highstock));
			if (PointDescriptionFormat != null) { h.Add("pointDescriptionFormat",PointDescriptionFormat); highstock.AddFunction("pointDescriptionFormat", PointDescriptionFormat); }  
			if (PointDescriptionFormatter != null) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); highstock.AddFunction("pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (PointInterval != null) h.Add("pointInterval",PointInterval);
			if (PointIntervalUnit != PolygonSeriesPointIntervalUnit.Null) h.Add("pointIntervalUnit", highstock.FirstCharacterToLower(PointIntervalUnit.ToString()));
			if (PointRange != null) h.Add("pointRange",PointRange);
			if (PointStart != null) h.Add("pointStart",PointStart);
			if (RelativeXValue != null) h.Add("relativeXValue",RelativeXValue);
			if (Selected != null) h.Add("selected",Selected);
			if (ShowCheckbox != null) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != null) h.Add("showInLegend",ShowInLegend);
			if (ShowInNavigator != null) h.Add("showInNavigator",ShowInNavigator);
			if (SkipKeyboardNavigation != null) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Sonification != null) h.Add("sonification",Sonification.ToHashtable(highstock));
			if (Stacking != PolygonSeriesStacking.Null) h.Add("stacking", highstock.FirstCharacterToLower(Stacking.ToString()));
			if (States != null) h.Add("states",States.ToHashtable(highstock));
			if (Step != PolygonSeriesStep.Null) h.Add("step", highstock.FirstCharacterToLower(Step.ToString()));
			if (StickyTracking != null) h.Add("stickyTracking",StickyTracking);
			if (Tooltip != null) h.Add("tooltip",Tooltip.ToHashtable(highstock));
			if (TrackByArea != null) h.Add("trackByArea",TrackByArea);
			if (TurboThreshold != null) h.Add("turboThreshold",TurboThreshold);
			h.Add("type","polygon");
			if (Visible != null) h.Add("visible",Visible);
			if (XAxis != null) h.Add("xAxis",XAxis);
			if (XAxisNumber != null) h.Add("xAxis",XAxisNumber);
			if (YAxis != null) h.Add("yAxis",YAxis);
			if (YAxisNumber != null) h.Add("yAxis",YAxisNumber);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
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
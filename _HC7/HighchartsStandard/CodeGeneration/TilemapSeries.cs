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
	public partial class TilemapSeries  : Series
	{
		Hashtable h = new Hashtable();

		public TilemapSeries()
		{
		}	
		

		/// <summary>
		/// Accessibility options for a series.
		/// </summary>
		public TilemapSeriesAccessibility Accessibility { get; set; }
		 

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
		/// The border radius for each heatmap item. The border's color andwidth can be set in marker options.
		/// </summary>
		public double? BorderRadius { get; set; }
		 

		/// <summary>
		/// The border width for each heatmap item.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

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
		/// The column size - how many X axis units each column in the heatmapshould span.
		/// </summary>
		public double? Colsize { get; set; }
		 

		/// <summary>
		/// When true, each point or column edge is rounded to its nearest pixelin order to render sharp on screen. In some cases, when there are alot of densely packed columns, this leads to visible differencein column widths or distance between columns. In these cases,setting `crisp` to `false` may look better, even though each columnis rendered blurry.
		/// </summary>
		public bool? Crisp { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.In styled mode, the series cursor can be set with the same classesas listed under [series.color](#plotOptions.series.color).
		/// </summary>
		public TilemapSeriesCursor Cursor { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customizedfunctionality. Here you can add additional data for your own eventcallbacks and formatter callbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `tilemap` seriestype, points can be given in the following ways:1. An array of arrays with 3 or 2 values. In this case, the values correspond   to `x,y,value`. If the first value is a string, it is applied as the name   of the point, and the `x` value is inferred. The `x` value can also be   omitted, in which case the inner arrays should be of length 2\. Then the   `x` value is automatically calculated, either starting at 0 and   incremented by 1, or from `pointStart` and `pointInterval` given in the   series options.   ```js   data: [       [0, 9, 7],       [1, 10, 4],       [2, 6, 3]   ]   ```2. An array of objects with named values. The objects are point configuration   objects as seen below. If the total number of data points exceeds the   series' [turboThreshold](#series.tilemap.turboThreshold), this option is   not available.   ```js   data: [{       x: 1,       y: 3,       value: 10,       name: "Point2",       color: "#00FF00"   }, {       x: 1,       y: 7,       value: 10,       name: "Point1",       color: "#FF00FF"   }]   ```Note that for some [tileShapes](#plotOptions.tilemap.tileShape) the gridcoordinates are offset.
		/// </summary>
		public List<TilemapSeriesData> Data { get; set; }
		 

		/// <summary>
		/// Options for the series data labels, appearing next to each datapoint.Since v6.2.0, multiple data labels can be applied to each singlepoint by defining them as an array of configs.In styled mode, the data labels can be styled with the`.highcharts-data-label-box` and `.highcharts-data-label` class names([see example](https://www.highcharts.com/samples/highcharts/css/series-datalabels)).
		/// </summary>
		public TilemapSeriesDataLabels DataLabels { get; set; }
		 

		/// <summary>
		/// A description of the series to add to the screen reader informationabout the series.
		/// </summary>
		public string Description { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		 

		/// <summary>
		/// General event handlers for the series items. These event hooks canalso be attached to the series at run time using the`Highcharts.addEvent` function.
		/// </summary>
		public TilemapSeriesEvents Events { get; set; }
		 

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
		/// Make the heatmap render its data points as an interpolated image.
		/// </summary>
		public bool? Interpolation { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		 

		/// <summary>
		/// Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.The series labels currently work with series types having a`graph` or an `area`.
		/// </summary>
		public TilemapSeriesLabel Label { get; set; }
		 

		/// <summary>
		/// The sequential index of the series in the legend.
		/// </summary>
		public override double? LegendIndex { get; set; }
		 

		/// <summary>
		/// What type of legend symbol to render for this series. Can be one of`areaMarker`, `lineMarker` or `rectangle`.
		/// </summary>
		public TilemapSeriesLegendSymbol LegendSymbol { get; set; }
		 

		/// <summary>
		/// The [id](#series.id) of another series to link to. Additionally,the value can be ":previous" to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.If master series uses data sorting and linked series does not haveits own sorting definition, the linked series will be sorted in thesame order as the master one.
		/// </summary>
		public string LinkedTo { get; set; }
		 

		/// <summary>
		/// The name of the series as shown in the legend, tooltip etc.
		/// </summary>
		public override string Name { get; set; }
		 

		/// <summary>
		/// The color for the parts of the graph or points that are below the[threshold](#plotOptions.series.threshold). Note that `zones` takesprecedence over the negative color. Using `negativeColor` isequivalent to applying a zone with value of 0.
		/// </summary>
		public string NegativeColor { get; set; }
		 

		/// <summary>
		/// The color applied to null points. In styled mode, a general CSS classis applied instead.
		/// </summary>
		public string NullColor { get; set; }
		 

		/// <summary>
		/// Options for the _Series on point_ feature. Only `pie` and `sunburst` seriesare supported at this moment.
		/// </summary>
		public TilemapSeriesOnPoint OnPoint { get; set; }
		 

		/// <summary>
		/// Opacity of a series parts: line, fill (e.g. area) and dataLabels.
		/// </summary>
		public double? Opacity { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public TilemapSeriesPoint Point { get; set; }
		 

		/// <summary>
		/// Same as[accessibility.point.descriptionFormat](#accessibility.point.descriptionFormat),but for an individual series. Overrides the chart wide configuration.
		/// </summary>
		public string PointDescriptionFormat { get; set; }
		 

		/// <summary>
		/// Same as[accessibility.series.descriptionFormatter](#accessibility.series.descriptionFormatter),but for an individual series. Overrides the chart wide configuration.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		 

		/// <summary>
		/// Padding between the points in the heatmap.
		/// </summary>
		public double? PointPadding { get; set; }
		 

		/// <summary>
		/// When true, X values in the data set are relative to the current`pointStart`, `pointInterval` and `pointIntervalUnit` settings. Thisallows compression of the data for datasets with irregular X values.The real X values are computed on the formula `f(x) = ax + b`, where`a` is the `pointInterval` (optionally with a time unit given by`pointIntervalUnit`), and `b` is the `pointStart`.
		/// </summary>
		public bool? RelativeXValue { get; set; }
		 

		/// <summary>
		/// The row size - how many Y axis units each heatmap row should span.
		/// </summary>
		public double? Rowsize { get; set; }
		 

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
		/// If set to `true`, the accessibility module will skip past the pointsin this series for keyboard navigation.
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		 

		/// <summary>
		/// Sonification/audio chart options for a series.
		/// </summary>
		public TilemapSeriesSonification Sonification { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public TilemapSeriesStates States { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` event on aseries isn't triggered until the mouse moves over another series, orout of the plot area. When false, the `mouseOut` event on a series istriggered when the mouse leaves the area around the series' graph ormarkers. This also implies the tooltip when not shared. When`stickyTracking` is false and `tooltip.shared` is false, the tooltipwill be hidden when moving the mouse between series. Defaults to truefor line and area type series, but to false for columns, pies etc.**Note:** The boost module will force this option because oftechnical limitations.
		/// </summary>
		public bool? StickyTracking { get; set; }
		 

		/// <summary>
		/// The shape of the tiles in the tilemap. Possible values are `hexagon`,`circle`, `diamond`, and `square`.
		/// </summary>
		public string TileShape { get; set; }
		 

		/// <summary>
		/// A configuration object for the tooltip rendering of each singleseries. Properties are inherited from [tooltip](#tooltip), but onlythe following properties can be defined on a series level.
		/// </summary>
		public TilemapSeriesTooltip Tooltip { get; set; }
		 

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
		public List<TilemapSeriesZone> Zones { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (AllowPointSelect != null) h.Add("allowPointSelect",AllowPointSelect);
			if (Animation != null) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (ClassName != null) h.Add("className",ClassName);
			if (Clip != null) h.Add("clip",Clip);
			if (Color != null) h.Add("color",Color);
			if (ColorAxis != null) h.Add("colorAxis",ColorAxis);
			if (ColorAxisNumber != null) h.Add("colorAxis",ColorAxisNumber);
			if (ColorAxisBool != null) h.Add("colorAxis",ColorAxisBool);
			if (ColorIndex != null) h.Add("colorIndex",ColorIndex);
			if (ColorKey != null) h.Add("colorKey",ColorKey);
			if (Colsize != null) h.Add("colsize",Colsize);
			if (Crisp != null) h.Add("crisp",Crisp);
			if (Cursor != TilemapSeriesCursor.Null) h.Add("cursor", highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (Custom != null) h.Add("custom",Custom);
			if (Data != null) h.Add("data",HashifyList(highcharts,Data));
			if (DataLabels != null) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (Description != null) h.Add("description",Description);
			if (EnableMouseTracking != null) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events != null) h.Add("events",Events.ToHashtable(highcharts));
			if (Id != null) h.Add("id",Id);
			if (InactiveOtherPoints != null) h.Add("inactiveOtherPoints",InactiveOtherPoints);
			if (IncludeInDataExport != null) h.Add("includeInDataExport",IncludeInDataExport);
			if (Index != null) h.Add("index",Index);
			if (Interpolation != null) h.Add("interpolation",Interpolation);
			if (Keys != null) h.Add("keys",Keys);
			if (Label != null) h.Add("label",Label.ToHashtable(highcharts));
			if (LegendIndex != null) h.Add("legendIndex",LegendIndex);
			if (LegendSymbol != TilemapSeriesLegendSymbol.Null) h.Add("legendSymbol", highcharts.FirstCharacterToLower(LegendSymbol.ToString()));
			if (LinkedTo != null) h.Add("linkedTo",LinkedTo);
			if (Name != null) h.Add("name",Name);
			if (NegativeColor != null) h.Add("negativeColor",NegativeColor);
			if (NullColor != null) h.Add("nullColor",NullColor);
			if (OnPoint != null) h.Add("onPoint",OnPoint.ToHashtable(highcharts));
			if (Opacity != null) h.Add("opacity",Opacity);
			if (Point != null) h.Add("point",Point.ToHashtable(highcharts));
			if (PointDescriptionFormat != null) { h.Add("pointDescriptionFormat",PointDescriptionFormat); highcharts.AddFunction("pointDescriptionFormat", PointDescriptionFormat); }  
			if (PointDescriptionFormatter != null) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); highcharts.AddFunction("pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (PointPadding != null) h.Add("pointPadding",PointPadding);
			if (RelativeXValue != null) h.Add("relativeXValue",RelativeXValue);
			if (Rowsize != null) h.Add("rowsize",Rowsize);
			if (Selected != null) h.Add("selected",Selected);
			if (ShowCheckbox != null) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != null) h.Add("showInLegend",ShowInLegend);
			if (SkipKeyboardNavigation != null) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Sonification != null) h.Add("sonification",Sonification.ToHashtable(highcharts));
			if (States != null) h.Add("states",States.ToHashtable(highcharts));
			if (StickyTracking != null) h.Add("stickyTracking",StickyTracking);
			if (TileShape != null) h.Add("tileShape",TileShape);
			if (Tooltip != null) h.Add("tooltip",Tooltip.ToHashtable(highcharts));
			if (TurboThreshold != null) h.Add("turboThreshold",TurboThreshold);
			h.Add("type","tilemap");
			if (Visible != null) h.Add("visible",Visible);
			if (XAxis != null) h.Add("xAxis",XAxis);
			if (XAxisNumber != null) h.Add("xAxis",XAxisNumber);
			if (YAxis != null) h.Add("yAxis",YAxis);
			if (YAxisNumber != null) h.Add("yAxis",YAxisNumber);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
			if (ZoneAxis != null) h.Add("zoneAxis",ZoneAxis);
			if (Zones != null) h.Add("zones", HashifyList(highcharts,Zones));
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
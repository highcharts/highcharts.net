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
	public partial class OrganizationSeries  : Series
	{
		Hashtable h = new Hashtable();

		public OrganizationSeries()
		{
		}	
		

		/// <summary>
		/// Accessibility options for a series.
		/// </summary>
		public OrganizationSeriesAccessibility Accessibility { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.- `duration`: The duration of the animation in milliseconds. (Defaults to  `1000`)- `easing`: Can be a string reference to an easing function set on  the `Math` object or a function. See the _Custom easing function_  demo below. (Defaults to `easeInOutSine`)Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.- `duration`: The duration of the animation in milliseconds. (Defaults to  `1000`)- `easing`: Can be a string reference to an easing function set on  the `Math` object or a function. See the _Custom easing function_  demo below. (Defaults to `easeInOutSine`)Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each column or bar.In styled mode, the border stroke can be set with the`.highcharts-point` rule.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// The border radius of the node cards.
		/// </summary>
		public double? BorderRadius { get; set; }
		 

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
		/// When using automatic point colors pulled from the global[colors](colors) or series-specific[plotOptions.column.colors](series.colors) collections, this optiondetermines whether the chart should receive one color per series orone color per point.In styled mode, the `colors` or `series.colors` arrays are notsupported, and instead this option gives the points individual colorclass names on the form `highcharts-color-{n}`.
		/// </summary>
		public bool? ColorByPoint { get; set; }
		 

		/// <summary>
		/// Styled mode only. A specific color index to use for the series, so itsgraphic representations are given the class name `highcharts-color-{n}`.Since v11, CSS variables on the form `--highcharts-color-{n}` makechanging the color scheme very convenient.
		/// </summary>
		public double? ColorIndex { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to apply insteadof the global [colors](#colors) when [colorByPoint](#plotOptions.column.colorByPoint) is true.
		/// </summary>
		public List<string> Colors { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.In styled mode, the series cursor can be set with the same classesas listed under [series.color](#plotOptions.series.color).
		/// </summary>
		public OrganizationSeriesCursor Cursor { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customizedfunctionality. Here you can add additional data for your own eventcallbacks and formatter callbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		 

		/// <summary>
		/// Name of the dash style to use for the graph, or for some series typesthe outline of each shape.In styled mode, the[stroke dash-array](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/series-dashstyle/)can be set with the same classes as listed under[series.color](#plotOptions.series.color).
		/// </summary>
		public OrganizationSeriesDashStyle DashStyle { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `organization` seriestype, points can be given in the following way:An array of objects with named values. The following snippet shows only afew settings, see the complete options set below. If the total number of datapoints exceeds the series' [turboThreshold](#series.area.turboThreshold),this option is not available. ```js    data: [{        from: 'Category1',        to: 'Category2',        weight: 2    }, {        from: 'Category1',        to: 'Category3',        weight: 5    }] ```
		/// </summary>
		public List<OrganizationSeriesData> Data { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public OrganizationSeriesDataLabels DataLabels { get; set; }
		 

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
		public OrganizationSeriesEvents Events { get; set; }
		 

		/// <summary>
		/// Whether to use the Y extremes of the total chart width or only thezoomed area when zooming in on parts of the X axis. By default, theY axis adjusts to the min and max of the visible data. Cartesianseries only.
		/// </summary>
		public bool? GetExtremesFromAll { get; set; }
		 

		/// <summary>
		/// The indentation in pixels of hanging nodes, nodes which parent has[layout](#series.organization.nodes.layout) set to `hanging`.
		/// </summary>
		public double? HangingIndent { get; set; }
		 

		/// <summary>
		/// Defines the indentation of a `hanging` layout parent's children.Possible options:- `inherit` (default): Only the first child adds the indentation,children of a child with indentation inherit the indentation.- `cumulative`: All children of a child with indentation add itsown indent. The option may cause overlapping of nodes.Then use `shrink` option:- `shrink`: Nodes shrink by the[hangingIndent](#plotOptions.organization.hangingIndent)value until they reach the[minNodeLength](#plotOptions.organization.minNodeLength).
		/// </summary>
		public string HangingIndentTranslation { get; set; }
		 

		/// <summary>
		/// Whether links connecting hanging nodes should be drawn on the leftor right side. Useful for RTL layouts.**Note:** Only effects inverted charts (vertical layout).
		/// </summary>
		public OrganizationSeriesHangingSide HangingSide { get; set; }
		 

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
		public OrganizationSeriesLabel Label { get; set; }
		 

		/// <summary>
		/// The sequential index of the series in the legend.
		/// </summary>
		public override double? LegendIndex { get; set; }
		 

		/// <summary>
		/// What type of legend symbol to render for this series. Can be one of`areaMarker`, `lineMarker` or `rectangle`.
		/// </summary>
		public OrganizationSeriesLegendSymbol LegendSymbol { get; set; }
		 

		/// <summary>
		/// Set options on specific levels. Takes precedence over series options,but not node and link options.
		/// </summary>
		public OrganizationSeriesLevels Levels { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public OrganizationSeriesLink Link { get; set; }
		 

		/// <summary>
		/// The color of the links between nodes. This option is moved to[link.color](#plotOptions.organization.link.color).
		/// </summary>
		public string LinkColor { get; set; }
		 

		/// <summary>
		/// Determines color mode for sankey links. Available options:- `from` color of the sankey link will be the same as the 'from node'- `gradient` color of the sankey link will be set to gradient betweencolors of 'from node' and 'to node'- `to` color of the sankey link will be same as the 'to node'.
		/// </summary>
		public OrganizationSeriesLinkColorMode LinkColorMode { get; set; }
		 

		/// <summary>
		/// The [id](#series.id) of another series to link to. Additionally,the value can be ":previous" to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.If master series uses data sorting and linked series does not haveits own sorting definition, the linked series will be sorted in thesame order as the master one.
		/// </summary>
		public string LinkedTo { get; set; }
		 

		/// <summary>
		/// The line width of the links connecting nodes, in pixels. This optionis now deprecated and moved to the[link.radius](#plotOptions.organization.link.lineWidth).
		/// </summary>
		public string LinkLineWidth { get; set; }
		 

		/// <summary>
		/// Opacity for the links between nodes in the sankey diagram.
		/// </summary>
		public double? LinkOpacity { get; set; }
		 

		/// <summary>
		/// Radius for the rounded corners of the links between nodes. Thisoption is now deprecated, and moved to[link.radius](#plotOptions.organization.link.radius).
		/// </summary>
		public string LinkRadius { get; set; }
		 

		/// <summary>
		/// The minimal width for a line of a sankey. By default,0 values are not shown.
		/// </summary>
		public double? MinLinkWidth { get; set; }
		 

		/// <summary>
		/// In a horizontal chart, the minimum width of the **hanging** nodesonly, in pixels. In a vertical chart, the minimum height of the**haning** nodes only, in pixels too.Note: Used only when[hangingIndentTranslation](#plotOptions.organization.hangingIndentTranslation)is set to `shrink`.
		/// </summary>
		public double? MinNodeLength { get; set; }
		 

		/// <summary>
		/// The name of the series as shown in the legend, tooltip etc.
		/// </summary>
		public override string Name { get; set; }
		 

		/// <summary>
		/// Determines which side of the chart the nodes are to be aligned to. Whenthe chart is inverted, `top` aligns to the left and `bottom` to theright.
		/// </summary>
		public OrganizationSeriesNodeAlignment NodeAlignment { get; set; }
		 

		/// <summary>
		/// The distance between nodes in a sankey diagram in the longitudinaldirection. The longitudinal direction means the direction that the chartflows - in a horizontal chart the distance is horizontal, in an invertedchart (vertical), the distance is vertical.If a number is given, it denotes pixels. If a percentage string is given,the distance is a percentage of the rendered node width. A `nodeDistance`of `100%` will render equal widths for the nodes and the gaps betweenthem.This option applies only when the `nodeWidth` option is `auto`, makingthe node width respond to the number of columns.
		/// </summary>
		public string NodeDistance { get; set; }
		 

		/// <summary>
		/// The distance between nodes in a sankey diagram in the longitudinaldirection. The longitudinal direction means the direction that the chartflows - in a horizontal chart the distance is horizontal, in an invertedchart (vertical), the distance is vertical.If a number is given, it denotes pixels. If a percentage string is given,the distance is a percentage of the rendered node width. A `nodeDistance`of `100%` will render equal widths for the nodes and the gaps betweenthem.This option applies only when the `nodeWidth` option is `auto`, makingthe node width respond to the number of columns.
		/// </summary>
		public double? NodeDistanceNumber { get; set; }
		 

		/// <summary>
		/// The padding between nodes in a sankey diagram or dependency wheel, inpixels. For sankey charts, this applies to the nodes of the same column,so vertical distance by default, or horizontal distance in an inverted(vertical) sankey.If the number of nodes is so great that it is impossible to lay them outwithin the plot area with the given `nodePadding`, they will be renderedwith a smaller padding as a strategy to avoid overflow.
		/// </summary>
		public double? NodePadding { get; set; }
		 

		/// <summary>
		/// A collection of options for the individual nodes. The nodes in an org chartare auto-generated instances of `Highcharts.Point`, but options can beapplied here and linked by the `id`.
		/// </summary>
		public List<OrganizationSeriesNodes> Nodes { get; set; }
		 

		/// <summary>
		/// The pixel width of each node in a sankey diagram or dependency wheel, orthe height in case the chart is inverted.Can be a number or a percentage string.Sankey series also support setting it to `auto`. With this setting, thenodes are sized to fill up the plot area in the longitudinal direction,regardless of the number of levels.
		/// </summary>
		public string NodeWidth { get; set; }
		 

		/// <summary>
		/// The pixel width of each node in a sankey diagram or dependency wheel, orthe height in case the chart is inverted.Can be a number or a percentage string.Sankey series also support setting it to `auto`. With this setting, thenodes are sized to fill up the plot area in the longitudinal direction,regardless of the number of levels.
		/// </summary>
		public double? NodeWidthNumber { get; set; }
		 

		/// <summary>
		/// Options for the _Series on point_ feature. Only `pie` and `sunburst` seriesare supported at this moment.
		/// </summary>
		public OrganizationSeriesOnPoint OnPoint { get; set; }
		 

		/// <summary>
		/// Opacity of a series parts: line, fill (e.g. area) and dataLabels.
		/// </summary>
		public double? Opacity { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public OrganizationSeriesPoint Point { get; set; }
		 

		/// <summary>
		/// Same as[accessibility.point.descriptionFormat](#accessibility.point.descriptionFormat),but for an individual series. Overrides the chart wide configuration.
		/// </summary>
		public string PointDescriptionFormat { get; set; }
		 

		/// <summary>
		/// Same as[accessibility.series.descriptionFormatter](#accessibility.series.descriptionFormatter),but for an individual series. Overrides the chart wide configuration.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		 

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
		/// If set to `true`, the accessibility module will skip past the pointsin this series for keyboard navigation.
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		 

		/// <summary>
		/// Sonification/audio chart options for a series.
		/// </summary>
		public OrganizationSeriesSonification Sonification { get; set; }
		 

		/// <summary>
		/// This option allows grouping series in a stacked chart. The stack optioncan be a string or anything else, as long as the grouped series' stackoptions match each other after conversion into a string.
		/// </summary>
		public override string Stack { get; set; }
		 

		/// <summary>
		/// This option allows grouping series in a stacked chart. The stack optioncan be a string or anything else, as long as the grouped series' stackoptions match each other after conversion into a string.
		/// </summary>
		public override double? StackNumber { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public OrganizationSeriesStates States { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` event on aseries isn't triggered until the mouse moves over another series, orout of the plot area. When false, the `mouseOut` event on a series istriggered when the mouse leaves the area around the series' graph ormarkers. This also implies the tooltip when not shared. When`stickyTracking` is false and `tooltip.shared` is false, the tooltipwill be hidden when moving the mouse between series. Defaults to truefor line and area type series, but to false for columns, pies etc.**Note:** The boost module will force this option because oftechnical limitations.
		/// </summary>
		public bool? StickyTracking { get; set; }
		 

		/// <summary>
		/// A configuration object for the tooltip rendering of each singleseries. Properties are inherited from [tooltip](#tooltip), but onlythe following properties can be defined on a series level.
		/// </summary>
		public OrganizationSeriesTooltip Tooltip { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (Animation != null) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (CenterInCategory != null) h.Add("centerInCategory",CenterInCategory);
			if (ClassName != null) h.Add("className",ClassName);
			if (Clip != null) h.Add("clip",Clip);
			if (Color != null) h.Add("color",Color);
			if (ColorByPoint != null) h.Add("colorByPoint",ColorByPoint);
			if (ColorIndex != null) h.Add("colorIndex",ColorIndex);
			if (Colors != null) h.Add("colors",Colors);
			if (Cursor != OrganizationSeriesCursor.Null) h.Add("cursor", highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (Custom != null) h.Add("custom",Custom);
			if (DashStyle != OrganizationSeriesDashStyle.Null) h.Add("dashStyle", highcharts.FirstCharacterToLower(DashStyle.ToString()));
			if (Data != null) h.Add("data",HashifyList(highcharts,Data));
			if (DataLabels != null) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (Description != null) h.Add("description",Description);
			if (EnableMouseTracking != null) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events != null) h.Add("events",Events.ToHashtable(highcharts));
			if (GetExtremesFromAll != null) h.Add("getExtremesFromAll",GetExtremesFromAll);
			if (HangingIndent != null) h.Add("hangingIndent",HangingIndent);
			if (HangingIndentTranslation != null) h.Add("hangingIndentTranslation",HangingIndentTranslation);
			if (HangingSide != OrganizationSeriesHangingSide.Null) h.Add("hangingSide", highcharts.FirstCharacterToLower(HangingSide.ToString()));
			if (Id != null) h.Add("id",Id);
			if (InactiveOtherPoints != null) h.Add("inactiveOtherPoints",InactiveOtherPoints);
			if (IncludeInDataExport != null) h.Add("includeInDataExport",IncludeInDataExport);
			if (Index != null) h.Add("index",Index);
			if (Keys != null) h.Add("keys",Keys);
			if (Label != null) h.Add("label",Label.ToHashtable(highcharts));
			if (LegendIndex != null) h.Add("legendIndex",LegendIndex);
			if (LegendSymbol != OrganizationSeriesLegendSymbol.Null) h.Add("legendSymbol", highcharts.FirstCharacterToLower(LegendSymbol.ToString()));
			if (Levels != null) h.Add("levels",Levels.ToHashtable(highcharts));
			if (Link != null) h.Add("link",Link.ToHashtable(highcharts));
			if (LinkColor != null) h.Add("linkColor",LinkColor);
			if (LinkColorMode != OrganizationSeriesLinkColorMode.Null) h.Add("linkColorMode", highcharts.FirstCharacterToLower(LinkColorMode.ToString()));
			if (LinkedTo != null) h.Add("linkedTo",LinkedTo);
			if (LinkLineWidth != null) h.Add("linkLineWidth",LinkLineWidth);
			if (LinkOpacity != null) h.Add("linkOpacity",LinkOpacity);
			if (LinkRadius != null) h.Add("linkRadius",LinkRadius);
			if (MinLinkWidth != null) h.Add("minLinkWidth",MinLinkWidth);
			if (MinNodeLength != null) h.Add("minNodeLength",MinNodeLength);
			if (Name != null) h.Add("name",Name);
			if (NodeAlignment != OrganizationSeriesNodeAlignment.Null) h.Add("nodeAlignment", highcharts.FirstCharacterToLower(NodeAlignment.ToString()));
			if (NodeDistance != null) h.Add("nodeDistance",NodeDistance);
			if (NodeDistanceNumber != null) h.Add("nodeDistance",NodeDistanceNumber);
			if (NodePadding != null) h.Add("nodePadding",NodePadding);
			if (Nodes != null) h.Add("nodes", HashifyList(highcharts,Nodes));
			if (NodeWidth != null) h.Add("nodeWidth",NodeWidth);
			if (NodeWidthNumber != null) h.Add("nodeWidth",NodeWidthNumber);
			if (OnPoint != null) h.Add("onPoint",OnPoint.ToHashtable(highcharts));
			if (Opacity != null) h.Add("opacity",Opacity);
			if (Point != null) h.Add("point",Point.ToHashtable(highcharts));
			if (PointDescriptionFormat != null) { h.Add("pointDescriptionFormat",PointDescriptionFormat); highcharts.AddFunction("pointDescriptionFormat", PointDescriptionFormat); }  
			if (PointDescriptionFormatter != null) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); highcharts.AddFunction("pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (RelativeXValue != null) h.Add("relativeXValue",RelativeXValue);
			if (Selected != null) h.Add("selected",Selected);
			if (ShowCheckbox != null) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != null) h.Add("showInLegend",ShowInLegend);
			if (SkipKeyboardNavigation != null) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Sonification != null) h.Add("sonification",Sonification.ToHashtable(highcharts));
			if (Stack != null) h.Add("stack",Stack);
			if (StackNumber != null) h.Add("stack",StackNumber);
			if (States != null) h.Add("states",States.ToHashtable(highcharts));
			if (StickyTracking != null) h.Add("stickyTracking",StickyTracking);
			if (Tooltip != null) h.Add("tooltip",Tooltip.ToHashtable(highcharts));
			if (TurboThreshold != null) h.Add("turboThreshold",TurboThreshold);
			h.Add("type","organization");
			if (Visible != null) h.Add("visible",Visible);
			if (XAxis != null) h.Add("xAxis",XAxis);
			if (XAxisNumber != null) h.Add("xAxis",XAxisNumber);
			if (YAxis != null) h.Add("yAxis",YAxis);
			if (YAxisNumber != null) h.Add("yAxis",YAxisNumber);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
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
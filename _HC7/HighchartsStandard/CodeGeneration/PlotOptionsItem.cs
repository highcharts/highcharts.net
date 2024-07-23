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
	public partial class PlotOptionsItem  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsItem()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Accessibility options for a series.
		/// </summary>
		public PlotOptionsItemAccessibility Accessibility { get; set; }
		 

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
		/// The corner radius of the border surrounding each slice. A numbersignifies pixels. A percentage string, like for example `50%`, signifiesa size relative to the radius and the inner radius.
		/// </summary>
		public Object BorderRadius { get; set; }
		 

		/// <summary>
		/// The corner radius of the border surrounding each slice. A numbersignifies pixels. A percentage string, like for example `50%`, signifiesa size relative to the radius and the inner radius.
		/// </summary>
		public string BorderRadiusString { get; set; }
		 

		/// <summary>
		/// The corner radius of the border surrounding each slice. A numbersignifies pixels. A percentage string, like for example `50%`, signifiesa size relative to the radius and the inner radius.
		/// </summary>
		public double? BorderRadiusNumber { get; set; }
		 

		/// <summary>
		/// The center of the pie chart relative to the plot area. Can bepercentages or pixel values. The default behaviour (as of 3.0) is tocenter the pie so that all slices and data labels are within the plotarea. As a consequence, the pie may actually jump around in a chartwith dynamic values, as the data labels move. In that case, thecenter should be explicitly set, for example to `["50%", "50%"]`.
		/// </summary>
		public string[] Center { get; set; }
		 

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
		/// A series specific or series type specific color set to use insteadof the global [colors](#colors).
		/// </summary>
		public List<string> Colors { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Crisp { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.In styled mode, the series cursor can be set with the same classesas listed under [series.color](#plotOptions.series.color).
		/// </summary>
		public PlotOptionsItemCursor Cursor { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customizedfunctionality. Here you can add additional data for your own eventcallbacks and formatter callbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		 

		/// <summary>
		/// Options for the series data labels, appearing next to each datapoint.Since v6.2.0, multiple data labels can be applied to each singlepoint by defining them as an array of configs.In styled mode, the data labels can be styled with the`.highcharts-data-label-box` and `.highcharts-data-label` class names([see example](https://www.highcharts.com/samples/highcharts/css/series-datalabels)).
		/// </summary>
		public PlotOptionsItemDataLabels DataLabels { get; set; }
		 

		/// <summary>
		/// A description of the series to add to the screen reader informationabout the series.
		/// </summary>
		public string Description { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		 

		/// <summary>
		/// In circular view, the end angle of the item layout, in degrees where0 is up.
		/// </summary>
		public double? EndAngle { get; set; }
		 

		/// <summary>
		/// General event handlers for the series items. These event hooks canalso be attached to the series at run time using the`Highcharts.addEvent` function.
		/// </summary>
		public PlotOptionsItemEvents Events { get; set; }
		 

		/// <summary>
		/// If the total sum of the pie's values is 0, the series is representedas an empty circle . The `fillColor` option defines the color of thatcircle. Use [pie.borderWidth](#plotOptions.pie.borderWidth) to setthe border thickness.
		/// </summary>
		public Object FillColor { get; set; }
		 

		/// <summary>
		/// Equivalent to [chart.ignoreHiddenSeries](#chart.ignoreHiddenSeries),this option tells whether the series shall be redrawn as if thehidden point were `null`.The default value changed from `false` to `true` with Highcharts3.0.
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
		/// In circular view, the size of the inner diameter of the circle. Canbe a percentage or pixel value. Percentages are relative to the outerperimeter. Pixel values are given as integers.If the `rows` option is set, it overrides the `innerSize` setting.
		/// </summary>
		public string InnerSize { get; set; }
		 

		/// <summary>
		/// In circular view, the size of the inner diameter of the circle. Canbe a percentage or pixel value. Percentages are relative to the outerperimeter. Pixel values are given as integers.If the `rows` option is set, it overrides the `innerSize` setting.
		/// </summary>
		public double? InnerSizeNumber { get; set; }
		 

		/// <summary>
		/// The padding between the items, given in relative size where the sizeof the item is 1.
		/// </summary>
		public double? ItemPadding { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		 

		/// <summary>
		/// The layout of the items in rectangular view. Can be either`horizontal` or `vertical`.
		/// </summary>
		public string Layout { get; set; }
		 

		/// <summary>
		/// What type of legend symbol to render for this series. Can be one of`areaMarker`, `lineMarker` or `rectangle`.
		/// </summary>
		public PlotOptionsItemLegendSymbol LegendSymbol { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsItemMarker Marker { get; set; }
		 

		/// <summary>
		/// The minimum size for a pie in response to auto margins. The pie willtry to shrink to make room for data labels in side the plot area, but only to this size.
		/// </summary>
		public string MinSize { get; set; }
		 

		/// <summary>
		/// The minimum size for a pie in response to auto margins. The pie willtry to shrink to make room for data labels in side the plot area, but only to this size.
		/// </summary>
		public double? MinSizeNumber { get; set; }
		 

		/// <summary>
		/// Options for the _Series on point_ feature. Only `pie` and `sunburst` seriesare supported at this moment.
		/// </summary>
		public PlotOptionsItemOnPoint OnPoint { get; set; }
		 

		/// <summary>
		/// Opacity of a series parts: line, fill (e.g. area) and dataLabels.
		/// </summary>
		public double? Opacity { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public PlotOptionsItemPoint Point { get; set; }
		 

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
		/// The number of rows to display in the rectangular or circular view. Ifthe `innerSize` is set, it will be overridden by the `rows` setting.
		/// </summary>
		public double? Rows { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If `showCheckbox` is true,the checkbox next to the series name in the legend will be checkedfor a selected series.
		/// </summary>
		public bool? Selected { get; set; }
		 

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allowselecting the series. The state of the checkbox is determined bythe `selected` option.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? ShowInLegend { get; set; }
		 

		/// <summary>
		/// The diameter of the pie relative to the plot area. Can be apercentage or pixel value. Pixel values are given as integers. Thedefault behaviour (as of 3.0) is to scale to the plot area and giveroom for data labels within the plot area.[slicedOffset](#plotOptions.pie.slicedOffset) is also included in thedefault size calculation. As a consequence, the size of the pie mayvary when points are updated and data labels more around. In thatcase it is best to set a fixed value, for example `"75%"`.
		/// </summary>
		public string Size { get; set; }
		 

		/// <summary>
		/// The diameter of the pie relative to the plot area. Can be apercentage or pixel value. Pixel values are given as integers. Thedefault behaviour (as of 3.0) is to scale to the plot area and giveroom for data labels within the plot area.[slicedOffset](#plotOptions.pie.slicedOffset) is also included in thedefault size calculation. As a consequence, the size of the pie mayvary when points are updated and data labels more around. In thatcase it is best to set a fixed value, for example `"75%"`.
		/// </summary>
		public double? SizeNumber { get; set; }
		 

		/// <summary>
		/// If set to `true`, the accessibility module will skip past the pointsin this series for keyboard navigation.
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		 

		/// <summary>
		/// Sonification/audio chart options for a series.
		/// </summary>
		public PlotOptionsItemSonification Sonification { get; set; }
		 

		/// <summary>
		/// In circular view, the start angle of the item layout, in degreeswhere 0 is up.
		/// </summary>
		public double? StartAngle { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsItemStates States { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` event on aseries isn't triggered until the mouse moves over another series, orout of the plot area. When false, the `mouseOut` event on a series istriggered when the mouse leaves the area around the series' graph ormarkers. This also implies the tooltip when not shared. When`stickyTracking` is false and `tooltip.shared` is false, the tooltipwill be hidden when moving the mouse between series. Defaults to truefor line and area type series, but to false for columns, pies etc.**Note:** The boost module will force this option because oftechnical limitations.
		/// </summary>
		public bool? StickyTracking { get; set; }
		 

		/// <summary>
		/// Thickness describing the ring size for a donut type chart,overriding [innerSize](#plotOptions.pie.innerSize).
		/// </summary>
		public double? Thickness { get; set; }
		 

		/// <summary>
		/// A configuration object for the tooltip rendering of each singleseries. Properties are inherited from [tooltip](#tooltip), but onlythe following properties can be defined on a series level.
		/// </summary>
		public PlotOptionsItemTooltip Tooltip { get; set; }
		 

		/// <summary>
		/// The parameter allows setting line series type and use OHLC indicators.Data in OHLC format is required.
		/// </summary>
		public bool? UseOhlcData { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (AllowPointSelect != null) h.Add("allowPointSelect",AllowPointSelect);
			if (Animation != null) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (BorderRadiusString != null) h.Add("borderRadius",BorderRadiusString);
			if (BorderRadiusNumber != null) h.Add("borderRadius",BorderRadiusNumber);
			if (Center != null) h.Add("center",Center);
			if (ClassName != null) h.Add("className",ClassName);
			if (Clip != null) h.Add("clip",Clip);
			if (Color != null) h.Add("color",Color);
			if (ColorAxis != null) h.Add("colorAxis",ColorAxis);
			if (ColorAxisNumber != null) h.Add("colorAxis",ColorAxisNumber);
			if (ColorAxisBool != null) h.Add("colorAxis",ColorAxisBool);
			if (ColorIndex != null) h.Add("colorIndex",ColorIndex);
			if (ColorKey != null) h.Add("colorKey",ColorKey);
			if (Colors != null) h.Add("colors",Colors);
			if (Crisp != null) h.Add("crisp",Crisp);
			if (Cursor != PlotOptionsItemCursor.Null) h.Add("cursor", highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (Custom != null) h.Add("custom",Custom);
			if (DataLabels != null) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (Description != null) h.Add("description",Description);
			if (EnableMouseTracking != null) h.Add("enableMouseTracking",EnableMouseTracking);
			if (EndAngle != null) h.Add("endAngle",EndAngle);
			if (Events != null) h.Add("events",Events.ToHashtable(highcharts));
			if (FillColor != null) h.Add("fillColor",FillColor);
			if (IgnoreHiddenPoint != null) h.Add("ignoreHiddenPoint",IgnoreHiddenPoint);
			if (InactiveOtherPoints != null) h.Add("inactiveOtherPoints",InactiveOtherPoints);
			if (IncludeInDataExport != null) h.Add("includeInDataExport",IncludeInDataExport);
			if (InnerSize != null) h.Add("innerSize",InnerSize);
			if (InnerSizeNumber != null) h.Add("innerSize",InnerSizeNumber);
			if (ItemPadding != null) h.Add("itemPadding",ItemPadding);
			if (Keys != null) h.Add("keys",Keys);
			if (Layout != null) h.Add("layout",Layout);
			if (LegendSymbol != PlotOptionsItemLegendSymbol.Null) h.Add("legendSymbol", highcharts.FirstCharacterToLower(LegendSymbol.ToString()));
			if (Marker != null) h.Add("marker",Marker.ToHashtable(highcharts));
			if (MinSize != null) h.Add("minSize",MinSize);
			if (MinSizeNumber != null) h.Add("minSize",MinSizeNumber);
			if (OnPoint != null) h.Add("onPoint",OnPoint.ToHashtable(highcharts));
			if (Opacity != null) h.Add("opacity",Opacity);
			if (Point != null) h.Add("point",Point.ToHashtable(highcharts));
			if (PointDescriptionFormat != null) { h.Add("pointDescriptionFormat",PointDescriptionFormat); highcharts.AddFunction("pointDescriptionFormat", PointDescriptionFormat); }  
			if (PointDescriptionFormatter != null) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); highcharts.AddFunction("pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (RelativeXValue != null) h.Add("relativeXValue",RelativeXValue);
			if (Rows != null) h.Add("rows",Rows);
			if (Selected != null) h.Add("selected",Selected);
			if (ShowCheckbox != null) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != null) h.Add("showInLegend",ShowInLegend);
			if (Size != null) h.Add("size",Size);
			if (SizeNumber != null) h.Add("size",SizeNumber);
			if (SkipKeyboardNavigation != null) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Sonification != null) h.Add("sonification",Sonification.ToHashtable(highcharts));
			if (StartAngle != null) h.Add("startAngle",StartAngle);
			if (States != null) h.Add("states",States.ToHashtable(highcharts));
			if (StickyTracking != null) h.Add("stickyTracking",StickyTracking);
			if (Thickness != null) h.Add("thickness",Thickness);
			if (Tooltip != null) h.Add("tooltip",Tooltip.ToHashtable(highcharts));
			if (UseOhlcData != null) h.Add("useOhlcData",UseOhlcData);
			if (Visible != null) h.Add("visible",Visible);
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
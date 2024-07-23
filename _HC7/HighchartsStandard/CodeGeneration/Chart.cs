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
	public partial class Chart  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Chart()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// When using multiple axes, align the thresholds. When this is true, otherticks will also be aligned.Note that for line series and some other series types, the `threshold`option is set to `null` by default. This will in turn cause their y-axisto not have a threshold. In order to avoid that, set the series`threshold` to 0 or another number.If `startOnTick` or `endOnTick` in the axis options are set to false, orif the axis is logarithmic, the threshold will not be aligned.
		/// </summary>
		public bool? AlignThresholds { get; set; }
		 

		/// <summary>
		/// When using multiple axes, the ticks of two or more opposite axeswill automatically be aligned by adding ticks to the axis or axeswith the least ticks, as if `tickAmount` were specified.This can be prevented by setting `alignTicks` to false. If the gridlines look messy, it's a good idea to hide them for the secondaryaxis by setting `gridLineWidth` to 0.If `startOnTick` or `endOnTick` in the axis options are set to false,then the `alignTicks ` will be disabled for the axis.Disabled for logarithmic axes.
		/// </summary>
		public bool? AlignTicks { get; set; }
		 

		/// <summary>
		/// By default, (because of memory and performance reasons) the chart doesnot copy the data but keeps it as a reference. In some cases, this mightresult in mutating the original data source. In order to prevent that,set that property to false. Please note that changing that might decreaseperformance, especially with bigger sets of data.
		/// </summary>
		public bool? AllowMutatingData { get; set; }
		 

		/// <summary>
		/// Set the overall animation for all chart updating. Animation can bedisabled throughout the chart by setting it to false here. It canbe overridden for each individual API method as a function parameter.The only animation not affected by this option is the initial seriesanimation, see [plotOptions.series.animation](#plotOptions.series.animation).The animation can either be set as a boolean or a configurationobject. If `true`, it will use the 'swing' jQuery easing and aduration of 500 ms. If used as a configuration object, the followingproperties are supported:- `defer`: The animation delay time in milliseconds.- `duration`: The duration of the animation in milliseconds.- `easing`: A string reference to an easing function set on the  `Math` object. See  [the easing demo](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-animation-easing/).When zooming on a series with less than 100 points, the chart redrawwill be done with animation, but in case of more data points, it isnecessary to set this option to ensure animation on zoom.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Set the overall animation for all chart updating. Animation can bedisabled throughout the chart by setting it to false here. It canbe overridden for each individual API method as a function parameter.The only animation not affected by this option is the initial seriesanimation, see [plotOptions.series.animation](#plotOptions.series.animation).The animation can either be set as a boolean or a configurationobject. If `true`, it will use the 'swing' jQuery easing and aduration of 500 ms. If used as a configuration object, the followingproperties are supported:- `defer`: The animation delay time in milliseconds.- `duration`: The duration of the animation in milliseconds.- `easing`: A string reference to an easing function set on the  `Math` object. See  [the easing demo](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-animation-easing/).When zooming on a series with less than 100 points, the chart redrawwill be done with animation, but in case of more data points, it isnecessary to set this option to ensure animation on zoom.
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// When a chart with an x and a y-axis is rendered, we first pre-render thelabels of both in order to measure them. Then, if either of the axislabels take up so much space that it significantly affects the length ofthe other axis, we repeat the process.By default we stop at two axis layout runs, but it may be that the secondrun also alter the space required by either axis, for example if itcauses the labels to rotate. In this situation, a subsequent redraw ofthe chart may cause the tick and label placement to change for apparentlyno reason.Use the `axisLayoutRuns` option to set the maximum allowed number ofrepetitions. But keep in mind that the default value of 2 is set becauseevery run costs performance time.**Note:** Changing that option to higher than the default might decreaseperformance significantly, especially with bigger sets of data.
		/// </summary>
		public double? AxisLayoutRuns { get; set; }
		 

		/// <summary>
		/// The background color or gradient for the outer chart area.
		/// </summary>
		public string BackgroundColor { get; set; }
		 

		/// <summary>
		/// The color of the outer chart border.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// The corner radius of the outer chart border.
		/// </summary>
		public double? BorderRadius { get; set; }
		 

		/// <summary>
		/// The pixel width of the outer chart border.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// A CSS class name to apply to the charts container `div`, allowingunique CSS styling for each chart.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// In styled mode, this sets how many colors the class namesshould rotate between. With ten colors, series (or points) aregiven class names like `highcharts-color-0`, `highcharts-color-1`[...] `highcharts-color-9`. The equivalent in non-styled modeis to set colors using the [colors](#colors) setting.
		/// </summary>
		public double? ColorCount { get; set; }
		 

		/// <summary>
		/// Whether to display errors on the chart. When `false`, the errors willbe shown only in the console.
		/// </summary>
		public bool? DisplayErrors { get; set; }
		 

		/// <summary>
		/// Event listeners for the chart.
		/// </summary>
		public ChartEvents Events { get; set; }
		 

		/// <summary>
		/// An explicit height for the chart. If a _number_, the height isgiven in pixels. If given a _percentage string_ (for example`'56%'`), the height is given as the percentage of the actual chartwidth. This allows for preserving the aspect ratio across responsivesizes.By default (when `null`) the height is calculated from the offsetheight of the containing element, or 400 pixels if the containingelement's height is 0.
		/// </summary>
		public string Height { get; set; }
		 

		/// <summary>
		/// An explicit height for the chart. If a _number_, the height isgiven in pixels. If given a _percentage string_ (for example`'56%'`), the height is given as the percentage of the actual chartwidth. This allows for preserving the aspect ratio across responsivesizes.By default (when `null`) the height is calculated from the offsetheight of the containing element, or 400 pixels if the containingelement's height is 0.
		/// </summary>
		public double? HeightNumber { get; set; }
		 

		/// <summary>
		/// If true, the axes will scale to the remaining visible series onceone series is hidden. If false, hiding and showing a series willnot affect the axes or the other series. For stacks, once one serieswithin the stack is hidden, the rest of the stack will close inaround it even if the axis is not affected.
		/// </summary>
		public bool? IgnoreHiddenSeries { get; set; }
		 

		/// <summary>
		/// Whether to invert the axes so that the x axis is vertical and y axisis horizontal. When `true`, the x axis is [reversed](#xAxis.reversed)by default.
		/// </summary>
		public bool? Inverted { get; set; }
		 

		/// <summary>
		/// The margin between the outer edge of the chart and the plot area.The numbers in the array designate top, right, bottom and leftrespectively. Use the options `marginTop`, `marginRight`,`marginBottom` and `marginLeft` for shorthand setting of one option.By default there is no margin. The actual space is dynamicallycalculated from the offset of axis labels, axis title, title,subtitle and legend in addition to the `spacingTop`, `spacingRight`,`spacingBottom` and `spacingLeft` options.
		/// </summary>
		public double[] Margin { get; set; }
		 

		/// <summary>
		/// The margin between the bottom outer edge of the chart and the plotarea. Use this to set a fixed pixel value for the margin as opposedto the default dynamic margin. See also `spacingBottom`.
		/// </summary>
		public double? MarginBottom { get; set; }
		 

		/// <summary>
		/// The margin between the left outer edge of the chart and the plotarea. Use this to set a fixed pixel value for the margin as opposedto the default dynamic margin. See also `spacingLeft`.
		/// </summary>
		public double? MarginLeft { get; set; }
		 

		/// <summary>
		/// The margin between the right outer edge of the chart and the plotarea. Use this to set a fixed pixel value for the margin as opposedto the default dynamic margin. See also `spacingRight`.
		/// </summary>
		public double? MarginRight { get; set; }
		 

		/// <summary>
		/// The margin between the top outer edge of the chart and the plot area.Use this to set a fixed pixel value for the margin as opposed tothe default dynamic margin. See also `spacingTop`.
		/// </summary>
		public double? MarginTop { get; set; }
		 

		/// <summary>
		/// Callback function to override the default function that formats allthe numbers in the chart. Returns a string with the formatted number.
		/// </summary>
		public string NumberFormatter { get; set; }
		 

		/// <summary>
		/// Options to render charts in 3 dimensions. This feature requires`highcharts-3d.js`, found in the download package or online at[code.highcharts.com/highcharts-3d.js](https://code.highcharts.com/highcharts-3d.js).
		/// </summary>
		public ChartOptions3d Options3d { get; set; }
		 

		/// <summary>
		/// Allows setting a key to switch between zooming and panning. Can beone of `alt`, `ctrl`, `meta` (the command key on Mac and Windowskey on Windows) or `shift`. The keys are mapped directly to the keyproperties of the click event argument (`event.altKey`,`event.ctrlKey`, `event.metaKey` and `event.shiftKey`).
		/// </summary>
		public ChartPanKey PanKey { get; set; }
		 

		/// <summary>
		/// Allow panning in a chart. Best used with [panKey](#chart.panKey)to combine zooming and panning.On touch devices, when the [tooltip.followTouchMove](#tooltip.followTouchMove) option is `true` (default), panningrequires two fingers. To allow panning with one finger, set`followTouchMove` to `false`.
		/// </summary>
		public ChartPanning Panning { get; set; }
		 

		/// <summary>
		/// Common options for all yAxes rendered in a parallel coordinates plot.This feature requires `modules/parallel-coordinates.js`.The default options are:```jsparallelAxes: {   lineWidth: 1,       // classic mode only   gridlinesWidth: 0,  // classic mode only   title: {       text: '',       reserveSpace: false   },   labels: {       x: 0,       y: 0,       align: 'center',       reserveSpace: false   },   offset: 0}```
		/// </summary>
		public ChartParallelAxes ParallelAxes { get; set; }
		 

		/// <summary>
		/// Flag to render charts as a parallel coordinates plot. In a parallelcoordinates plot (||-coords) by default all required yAxes are generatedand the legend is disabled. This feature requires`modules/parallel-coordinates.js`.
		/// </summary>
		public bool? ParallelCoordinates { get; set; }
		 

		/// <summary>
		/// Equivalent to [zoomType](#chart.zoomType), but for multitouchgestures only. By default, the `pinchType` is the same as the`zoomType` setting. However, pinching can be enabled separately insome cases, for example in stock charts where a mouse drag pans thechart, while pinching is enabled. When [tooltip.followTouchMove](#tooltip.followTouchMove) is true, pinchType only applies totwo-finger touches.
		/// </summary>
		public ChartPinchType PinchType { get; set; }
		 

		/// <summary>
		/// The background color or gradient for the plot area.
		/// </summary>
		public string PlotBackgroundColor { get; set; }
		 

		/// <summary>
		/// The URL for an image to use as the plot background. To set an imageas the background for the entire chart, set a CSS background imageto the container element. Note that for the image to be applied toexported charts, its URL needs to be accessible by the export server.
		/// </summary>
		public string PlotBackgroundImage { get; set; }
		 

		/// <summary>
		/// The color of the inner chart or plot area border.
		/// </summary>
		public string PlotBorderColor { get; set; }
		 

		/// <summary>
		/// The pixel width of the plot area border.
		/// </summary>
		public double? PlotBorderWidth { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the plot area. Requires thatplotBackgroundColor be set. The shadow can be an object configurationcontaining `color`, `offsetX`, `offsetY`, `opacity` and `width`.
		/// </summary>
		public Shadow PlotShadow { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the plot area. Requires thatplotBackgroundColor be set. The shadow can be an object configurationcontaining `color`, `offsetX`, `offsetY`, `opacity` and `width`.
		/// </summary>
		public bool? PlotShadowBool { get; set; }
		 

		/// <summary>
		/// When true, cartesian charts like line, spline, area and column aretransformed into the polar coordinate system. This produces _polarcharts_, also known as _radar charts_.
		/// </summary>
		public bool? Polar { get; set; }
		 

		/// <summary>
		/// Whether to reflow the chart to fit the width of the container divon resizing the window.
		/// </summary>
		public bool? Reflow { get; set; }
		 

		/// <summary>
		/// The HTML element where the chart will be rendered. If it is a string,the element by that id is used. The HTML element can also be passedby direct reference, or as the first argument of the chartconstructor, in which case the option is not needed.
		/// </summary>
		public string RenderTo { get; set; }
		 

		/// <summary>
		/// The button that appears after a selection zoom, allowing the userto reset zoom. This option is deprecated in favor of[zooming](#chart.zooming).
		/// </summary>
		public ChartResetZoomButton ResetZoomButton { get; set; }
		 

		/// <summary>
		/// Options for a scrollable plot area. This feature provides a minimum size forthe plot area of the chart. If the size gets smaller than this, typicallyon mobile devices, a native browser scrollbar is presented. This scrollbarprovides smooth scrolling for the contents of the plot area, whereas thetitle, legend and unaffected axes are fixed.Since v7.1.2, a scrollable plot area can be defined for either horizontal orvertical scrolling, depending on whether the `minWidth` or `minHeight`option is set.
		/// </summary>
		public ChartScrollablePlotArea ScrollablePlotArea { get; set; }
		 

		/// <summary>
		/// The background color of the marker square when selecting (zoomingin on) an area of the chart.
		/// </summary>
		public string SelectionMarkerFill { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the outer chart area. Requiresthat backgroundColor be set. The shadow can be an objectconfiguration containing `color`, `offsetX`, `offsetY`, `opacity` and`width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the outer chart area. Requiresthat backgroundColor be set. The shadow can be an objectconfiguration containing `color`, `offsetX`, `offsetY`, `opacity` and`width`.
		/// </summary>
		public bool? ShadowBool { get; set; }
		 

		/// <summary>
		/// Whether to show the axes initially. This only applies to empty chartswhere series are added dynamically, as axes are automatically addedto cartesian series.
		/// </summary>
		public bool? ShowAxes { get; set; }
		 

		/// <summary>
		/// The distance between the outer edge of the chart and the content,like title or legend, or axis title and labels if present. Thenumbers in the array designate top, right, bottom and leftrespectively. Use the options spacingTop, spacingRight, spacingBottomand spacingLeft options for shorthand setting of one option.
		/// </summary>
		public List<double> Spacing { get; set; }
		 

		/// <summary>
		/// The space between the bottom edge of the chart and the content (plotarea, axis title and labels, title, subtitle or legend in topposition).
		/// </summary>
		public double? SpacingBottom { get; set; }
		 

		/// <summary>
		/// The space between the left edge of the chart and the content (plotarea, axis title and labels, title, subtitle or legend in topposition).
		/// </summary>
		public double? SpacingLeft { get; set; }
		 

		/// <summary>
		/// The space between the right edge of the chart and the content (plotarea, axis title and labels, title, subtitle or legend in topposition).
		/// </summary>
		public double? SpacingRight { get; set; }
		 

		/// <summary>
		/// The space between the top edge of the chart and the content (plotarea, axis title and labels, title, subtitle or legend in topposition).
		/// </summary>
		public double? SpacingTop { get; set; }
		 

		/// <summary>
		/// Additional CSS styles to apply inline to the container `div` and the rootSVG.According to the CSS syntax documentation, it is recommended to quotefont family names that contain white space, digits, or punctuationcharacters other than hyphens. In such cases, wrap the fontFamilyname as follows: `fontFamily: '"Font name"'`.Since v11, the root font size is 1rem by default, and all child elementare given a relative `em` font size by default. This allows implementersto control all the chart's font sizes by only setting the root level.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// Whether to apply styled mode. When in styled mode, no presentationalattributes or CSS are applied to the chart SVG. Instead, CSS rulesare required to style the chart. The default style sheet isavailable from `https://code.highcharts.com/css/highcharts.css`.[Read more in the docs](https://www.highcharts.com/docs/chart-design-and-style/style-by-css)on what classes and variables are available.
		/// </summary>
		public bool? StyledMode { get; set; }
		 

		/// <summary>
		/// The default series type for the chart. Can be any of the chart typeslisted under [plotOptions](#plotOptions) and [series](#series) or canbe a series provided by an additional module.In TypeScript this option has no effect in sense of typing andinstead the `type` option must always be set in the series.
		/// </summary>
		public ChartType Type { get; set; }
		 

		/// <summary>
		/// An explicit width for the chart. By default (when `null`) the widthis calculated from the offset width of the containing element.
		/// </summary>
		public string Width { get; set; }
		 

		/// <summary>
		/// An explicit width for the chart. By default (when `null`) the widthis calculated from the offset width of the containing element.
		/// </summary>
		public double? WidthNumber { get; set; }
		 

		/// <summary>
		/// Chart zooming options.
		/// </summary>
		public ChartZooming Zooming { get; set; }
		 

		/// <summary>
		/// Set a key to hold when dragging to zoom the chart. This is useful toavoid zooming while moving points. Should be set different than[chart.panKey](#chart.panKey).
		/// </summary>
		public ChartZoomKey ZoomKey { get; set; }
		 

		/// <summary>
		/// Decides in what dimensions the user can zoom by dragging the mouse.Can be one of `x`, `y` or `xy`.
		/// </summary>
		public ChartZoomType ZoomType { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (AlignThresholds != null) h.Add("alignThresholds",AlignThresholds);
			if (AlignTicks != null) h.Add("alignTicks",AlignTicks);
			if (AllowMutatingData != null) h.Add("allowMutatingData",AllowMutatingData);
			if (Animation != null) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (AxisLayoutRuns != null) h.Add("axisLayoutRuns",AxisLayoutRuns);
			if (BackgroundColor != null) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (ClassName != null) h.Add("className",ClassName);
			if (ColorCount != null) h.Add("colorCount",ColorCount);
			if (DisplayErrors != null) h.Add("displayErrors",DisplayErrors);
			if (Events != null) h.Add("events",Events.ToHashtable(highcharts));
			if (Height != null) h.Add("height",Height);
			if (HeightNumber != null) h.Add("height",HeightNumber);
			if (IgnoreHiddenSeries != null) h.Add("ignoreHiddenSeries",IgnoreHiddenSeries);
			if (Inverted != null) h.Add("inverted",Inverted);
			if (Margin != null) h.Add("margin",Margin);
			if (MarginBottom != null) h.Add("marginBottom",MarginBottom);
			if (MarginLeft != null) h.Add("marginLeft",MarginLeft);
			if (MarginRight != null) h.Add("marginRight",MarginRight);
			if (MarginTop != null) h.Add("marginTop",MarginTop);
			if (NumberFormatter != null) { h.Add("numberFormatter",NumberFormatter); highcharts.AddFunction("numberFormatter", NumberFormatter); }  
			if (Options3d != null) h.Add("options3d",Options3d.ToHashtable(highcharts));
			if (PanKey != ChartPanKey.Null) h.Add("panKey", highcharts.FirstCharacterToLower(PanKey.ToString()));
			if (Panning != null) h.Add("panning",Panning.ToHashtable(highcharts));
			if (ParallelAxes != null) h.Add("parallelAxes",ParallelAxes.ToHashtable(highcharts));
			if (ParallelCoordinates != null) h.Add("parallelCoordinates",ParallelCoordinates);
			if (PinchType != ChartPinchType.Null) h.Add("pinchType", highcharts.FirstCharacterToLower(PinchType.ToString()));
			if (PlotBackgroundColor != null) h.Add("plotBackgroundColor",PlotBackgroundColor);
			if (PlotBackgroundImage != null) h.Add("plotBackgroundImage",PlotBackgroundImage);
			if (PlotBorderColor != null) h.Add("plotBorderColor",PlotBorderColor);
			if (PlotBorderWidth != null) h.Add("plotBorderWidth",PlotBorderWidth);
			if (PlotShadow != null) h.Add("plotShadow",PlotShadow.ToHashtable(highcharts));
			if (PlotShadowBool != null) h.Add("plotShadow",PlotShadowBool);
			if (Polar != null) h.Add("polar",Polar);
			if (Reflow != null) h.Add("reflow",Reflow);
			if (RenderTo != null) h.Add("renderTo",RenderTo);
			if (ResetZoomButton != null) h.Add("resetZoomButton",ResetZoomButton.ToHashtable(highcharts));
			if (ScrollablePlotArea != null) h.Add("scrollablePlotArea",ScrollablePlotArea.ToHashtable(highcharts));
			if (SelectionMarkerFill != null) h.Add("selectionMarkerFill",SelectionMarkerFill);
			if (Shadow != null) h.Add("shadow",Shadow.ToHashtable(highcharts));
			if (ShadowBool != null) h.Add("shadow",ShadowBool);
			if (ShowAxes != null) h.Add("showAxes",ShowAxes);
			if (Spacing != null) h.Add("spacing",Spacing);
			if (SpacingBottom != null) h.Add("spacingBottom",SpacingBottom);
			if (SpacingLeft != null) h.Add("spacingLeft",SpacingLeft);
			if (SpacingRight != null) h.Add("spacingRight",SpacingRight);
			if (SpacingTop != null) h.Add("spacingTop",SpacingTop);
			if (Style != null) h.Add("style",Style);
			if (StyledMode != null) h.Add("styledMode",StyledMode);
			if (Type != ChartType.Null) h.Add("type", highcharts.FirstCharacterToLower(Type.ToString()));
			if (Width != null) h.Add("width",Width);
			if (WidthNumber != null) h.Add("width",WidthNumber);
			if (Zooming != null) h.Add("zooming",Zooming.ToHashtable(highcharts));
			if (ZoomKey != ChartZoomKey.Null) h.Add("zoomKey", highcharts.FirstCharacterToLower(ZoomKey.ToString()));
			if (ZoomType != ChartZoomType.Null) h.Add("zoomType", highcharts.FirstCharacterToLower(ZoomType.ToString()));
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class Chart  : BaseObject
	{
		public Chart()
		{
			AlignTicks = AlignTicks_DefaultValue = true;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			AnimationBool = AnimationBool_DefaultValue = null;
			BackgroundColor = BackgroundColor_DefaultValue = "#ffffff";
			BorderColor = BorderColor_DefaultValue = "#335cad";
			BorderRadius = BorderRadius_DefaultValue = 0;
			BorderWidth = BorderWidth_DefaultValue = 0;
			ClassName = ClassName_DefaultValue = "";
			ColorCount = ColorCount_DefaultValue = 10;
			Description = Description_DefaultValue = "";
			DisplayErrors = DisplayErrors_DefaultValue = true;
			Events = Events_DefaultValue = new ChartEvents();
			Height = Height_DefaultValue = null;
			HeightNumber = HeightNumber_DefaultValue = null;
			IgnoreHiddenSeries = IgnoreHiddenSeries_DefaultValue = true;
			Inverted = Inverted_DefaultValue = false;
			Margin = Margin_DefaultValue = new double[]{};
			MarginBottom = MarginBottom_DefaultValue = null;
			MarginLeft = MarginLeft_DefaultValue = null;
			MarginRight = MarginRight_DefaultValue = null;
			MarginTop = MarginTop_DefaultValue = null;
			Panning = Panning_DefaultValue = false;
			PinchType = PinchType_DefaultValue = ChartPinchType.Null;
			PlotBackgroundColor = PlotBackgroundColor_DefaultValue = "";
			PlotBackgroundImage = PlotBackgroundImage_DefaultValue = "";
			PlotBorderColor = PlotBorderColor_DefaultValue = "#cccccc";
			PlotBorderWidth = PlotBorderWidth_DefaultValue = 0;
			PlotShadow = PlotShadow_DefaultValue = new Shadow() { Enabled = false };
			PlotShadowBool = PlotShadowBool_DefaultValue = null;
			Reflow = Reflow_DefaultValue = true;
			RenderTo = RenderTo_DefaultValue = "";
			ResetZoomButton = ResetZoomButton_DefaultValue = new ChartResetZoomButton();
			SelectionMarkerFill = SelectionMarkerFill_DefaultValue = "rgba(51,92,173,0.25)";
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShadowBool = ShadowBool_DefaultValue = null;
			Spacing = Spacing_DefaultValue = new List<double>();
			SpacingBottom = SpacingBottom_DefaultValue = 15;
			SpacingLeft = SpacingLeft_DefaultValue = 10;
			SpacingRight = SpacingRight_DefaultValue = 10;
			SpacingTop = SpacingTop_DefaultValue = 10;
			Style = Style_DefaultValue = new ChartStyle();
			StyledMode = StyledMode_DefaultValue = false;
			Type = Type_DefaultValue = ChartType.Null;
			TypeDescription = TypeDescription_DefaultValue = "";
			Width = Width_DefaultValue = null;
			ZoomKey = ZoomKey_DefaultValue = ChartZoomKey.Null;
			ZoomType = ZoomType_DefaultValue = ChartZoomType.Null;
			
		}	
		

		/// <summary>
		/// When using multiple axis, the ticks of two or more opposite axeswill automatically be aligned by adding ticks to the axis or axeswith the least ticks, as if `tickAmount` were specified.This can be prevented by setting `alignTicks` to false. If the gridlines look messy, it's a good idea to hide them for the secondaryaxis by setting `gridLineWidth` to 0.If `startOnTick` or `endOnTick` in an Axis options are set to false,then the `alignTicks ` will be disabled for the Axis.Disabled for logarithmic axes.
		/// </summary>
		public bool? AlignTicks { get; set; }
		private bool? AlignTicks_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the overall animation for all chart updating. Animation can bedisabled throughout the chart by setting it to false here. It canbe overridden for each individual API method as a function parameter.The only animation not affected by this option is the initial seriesanimation, see [plotOptions.series.animation](#plotOptions.series.animation).The animation can either be set as a boolean or a configurationobject. If `true`, it will use the 'swing' jQuery easing and aduration of 500 ms. If used as a configuration object, the followingproperties are supported:<dl><dt>duration</dt><dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>A string reference to an easing function set on the `Math`object. See [the easingdemo](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-animation-easing/).</dd></dl>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the overall animation for all chart updating. Animation can bedisabled throughout the chart by setting it to false here. It canbe overridden for each individual API method as a function parameter.The only animation not affected by this option is the initial seriesanimation, see [plotOptions.series.animation](#plotOptions.series.animation).The animation can either be set as a boolean or a configurationobject. If `true`, it will use the 'swing' jQuery easing and aduration of 500 ms. If used as a configuration object, the followingproperties are supported:<dl><dt>duration</dt><dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>A string reference to an easing function set on the `Math`object. See [the easingdemo](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-animation-easing/).</dd></dl>
		/// </summary>
		public bool? AnimationBool { get; set; }
		private bool? AnimationBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background color or gradient for the outer chart area.
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the outer chart border.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The corner radius of the outer chart border.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the outer chart border.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A CSS class name to apply to the charts container `div`, allowingunique CSS styling for each chart.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// In styled mode, this sets how many colors the class namesshould rotate between. With ten colors, series (or points) aregiven class names like `highcharts-color-0`, `highcharts-color-0`[...] `highcharts-color-9`. The equivalent in non-styled modeis to set colors using the [colors](#colors) setting.
		/// </summary>
		public double? ColorCount { get; set; }
		private double? ColorCount_DefaultValue { get; set; }
		 

		/// <summary>
		/// A text description of the chart.If the Accessibility module is loaded, this is included by defaultas a long description of the chart and its contents in the hiddenscreen reader information region.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display errors on the chart. When `false`, the errors willbe shown only in the console.Requires `debugger.js` module.
		/// </summary>
		public bool? DisplayErrors { get; set; }
		private bool? DisplayErrors_DefaultValue { get; set; }
		 

		/// <summary>
		/// Event listeners for the chart.
		/// </summary>
		public ChartEvents Events { get; set; }
		private ChartEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// An explicit height for the chart. If a _number_, the height isgiven in pixels. If given a _percentage string_ (for example`'56%'`), the height is given as the percentage of the actual chartwidth. This allows for preserving the aspect ratio across responsivesizes.By default (when `null`) the height is calculated from the offsetheight of the containing element, or 400 pixels if the containingelement's height is 0.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// An explicit height for the chart. If a _number_, the height isgiven in pixels. If given a _percentage string_ (for example`'56%'`), the height is given as the percentage of the actual chartwidth. This allows for preserving the aspect ratio across responsivesizes.By default (when `null`) the height is calculated from the offsetheight of the containing element, or 400 pixels if the containingelement's height is 0.
		/// </summary>
		public double? HeightNumber { get; set; }
		private double? HeightNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// If true, the axes will scale to the remaining visible series onceone series is hidden. If false, hiding and showing a series willnot affect the axes or the other series. For stacks, once one serieswithin the stack is hidden, the rest of the stack will close inaround it even if the axis is not affected.
		/// </summary>
		public bool? IgnoreHiddenSeries { get; set; }
		private bool? IgnoreHiddenSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to invert the axes so that the x axis is vertical and y axisis horizontal. When `true`, the x axis is [reversed](#xAxis.reversed)by default.
		/// </summary>
		public bool? Inverted { get; set; }
		private bool? Inverted_DefaultValue { get; set; }
		 

		/// <summary>
		/// The margin between the outer edge of the chart and the plot area.The numbers in the array designate top, right, bottom and leftrespectively. Use the options `marginTop`, `marginRight`,`marginBottom` and `marginLeft` for shorthand setting of one option.By default there is no margin. The actual space is dynamicallycalculated from the offset of axis labels, axis title, title,subtitle and legend in addition to the `spacingTop`, `spacingRight`,`spacingBottom` and `spacingLeft` options.
		/// </summary>
		public double[] Margin { get; set; }
		private double[] Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// The margin between the bottom outer edge of the chart and the plotarea. Use this to set a fixed pixel value for the margin as opposedto the default dynamic margin. See also `spacingBottom`.
		/// </summary>
		public double? MarginBottom { get; set; }
		private double? MarginBottom_DefaultValue { get; set; }
		 

		/// <summary>
		/// The margin between the left outer edge of the chart and the plotarea. Use this to set a fixed pixel value for the margin as opposedto the default dynamic margin. See also `spacingLeft`.
		/// </summary>
		public double? MarginLeft { get; set; }
		private double? MarginLeft_DefaultValue { get; set; }
		 

		/// <summary>
		/// The margin between the right outer edge of the chart and the plotarea. Use this to set a fixed pixel value for the margin as opposedto the default dynamic margin. See also `spacingRight`.
		/// </summary>
		public double? MarginRight { get; set; }
		private double? MarginRight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The margin between the top outer edge of the chart and the plot area.Use this to set a fixed pixel value for the margin as opposed tothe default dynamic margin. See also `spacingTop`.
		/// </summary>
		public double? MarginTop { get; set; }
		private double? MarginTop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow panning in a chart. Best used with [panKey](#chart.panKey)to combine zooming and panning.On touch devices, when the [tooltip.followTouchMove](#tooltip.followTouchMove) option is `true` (default), panningrequires two fingers. To allow panning with one finger, set`followTouchMove` to `false`.
		/// </summary>
		public bool? Panning { get; set; }
		private bool? Panning_DefaultValue { get; set; }
		 

		/// <summary>
		/// Equivalent to [zoomType](#chart.zoomType), but for multitouchgestures only. By default, the `pinchType` is the same as the`zoomType` setting. However, pinching can be enabled separately insome cases, for example in stock charts where a mouse drag pans thechart, while pinching is enabled. When [tooltip.followTouchMove](#tooltip.followTouchMove) is true, pinchType only applies totwo-finger touches.
		/// </summary>
		public ChartPinchType PinchType { get; set; }
		private ChartPinchType PinchType_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background color or gradient for the plot area.
		/// </summary>
		public string PlotBackgroundColor { get; set; }
		private string PlotBackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The URL for an image to use as the plot background. To set an imageas the background for the entire chart, set a CSS background imageto the container element. Note that for the image to be applied toexported charts, its URL needs to be accessible by the export server.
		/// </summary>
		public string PlotBackgroundImage { get; set; }
		private string PlotBackgroundImage_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the inner chart or plot area border.
		/// </summary>
		public string PlotBorderColor { get; set; }
		private string PlotBorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the plot area border.
		/// </summary>
		public double? PlotBorderWidth { get; set; }
		private double? PlotBorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the plot area. Requires thatplotBackgroundColor be set. The shadow can be an object configurationcontaining `color`, `offsetX`, `offsetY`, `opacity` and `width`.
		/// </summary>
		public Shadow PlotShadow { get; set; }
		private Shadow PlotShadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the plot area. Requires thatplotBackgroundColor be set. The shadow can be an object configurationcontaining `color`, `offsetX`, `offsetY`, `opacity` and `width`.
		/// </summary>
		public bool? PlotShadowBool { get; set; }
		private bool? PlotShadowBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to reflow the chart to fit the width of the container divon resizing the window.
		/// </summary>
		public bool? Reflow { get; set; }
		private bool? Reflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The HTML element where the chart will be rendered. If it is a string,the element by that id is used. The HTML element can also be passedby direct reference, or as the first argument of the chartconstructor, in which case the option is not needed.
		/// </summary>
		public string RenderTo { get; set; }
		private string RenderTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The button that appears after a selection zoom, allowing the userto reset zoom.
		/// </summary>
		public ChartResetZoomButton ResetZoomButton { get; set; }
		private ChartResetZoomButton ResetZoomButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background color of the marker square when selecting (zoomingin on) an area of the chart.
		/// </summary>
		public string SelectionMarkerFill { get; set; }
		private string SelectionMarkerFill_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the outer chart area. Requiresthat backgroundColor be set. The shadow can be an objectconfiguration containing `color`, `offsetX`, `offsetY`, `opacity` and`width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the outer chart area. Requiresthat backgroundColor be set. The shadow can be an objectconfiguration containing `color`, `offsetX`, `offsetY`, `opacity` and`width`.
		/// </summary>
		public bool? ShadowBool { get; set; }
		private bool? ShadowBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance between the outer edge of the chart and the content,like title or legend, or axis title and labels if present. Thenumbers in the array designate top, right, bottom and leftrespectively. Use the options spacingTop, spacingRight, spacingBottomand spacingLeft options for shorthand setting of one option.
		/// </summary>
		public List<double> Spacing { get; set; }
		private List<double> Spacing_DefaultValue { get; set; }
		 

		/// <summary>
		/// The space between the bottom edge of the chart and the content (plotarea, axis title and labels, title, subtitle or legend in topposition).
		/// </summary>
		public double? SpacingBottom { get; set; }
		private double? SpacingBottom_DefaultValue { get; set; }
		 

		/// <summary>
		/// The space between the left edge of the chart and the content (plotarea, axis title and labels, title, subtitle or legend in topposition).
		/// </summary>
		public double? SpacingLeft { get; set; }
		private double? SpacingLeft_DefaultValue { get; set; }
		 

		/// <summary>
		/// The space between the right edge of the chart and the content (plotarea, axis title and labels, title, subtitle or legend in topposition).
		/// </summary>
		public double? SpacingRight { get; set; }
		private double? SpacingRight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The space between the top edge of the chart and the content (plotarea, axis title and labels, title, subtitle or legend in topposition).
		/// </summary>
		public double? SpacingTop { get; set; }
		private double? SpacingTop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Additional CSS styles to apply inline to the container `div`. Notethat since the default font styles are applied in the renderer, itis ignorant of the individual chart options and must be set globally.
		/// </summary>
		public ChartStyle Style { get; set; }
		private ChartStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply styled mode. When in styled mode, no presentationalattributes or CSS are applied to the chart SVG. Instead, CSS rulesare required to style the chart. The default style sheet isavailable from `https://code.highcharts.com/css/highcharts.css`.
		/// </summary>
		public bool? StyledMode { get; set; }
		private bool? StyledMode_DefaultValue { get; set; }
		 

		/// <summary>
		/// The default series type for the chart. Can be any of the chart typeslisted under [plotOptions](#plotOptions).
		/// </summary>
		public ChartType Type { get; set; }
		private ChartType Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// A text description of the chart type.If the Accessibility module is loaded, this will be included in thedescription of the chart in the screen reader information region.Highcharts will by default attempt to guess the chart type, but formore complex charts it is recommended to specify this property forclarity.
		/// </summary>
		public string TypeDescription { get; set; }
		private string TypeDescription_DefaultValue { get; set; }
		 

		/// <summary>
		/// An explicit width for the chart. By default (when `null`) the widthis calculated from the offset width of the containing element.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set a key to hold when dragging to zoom the chart. Requires thedraggable-points module. This is useful to avoid zooming while moving points.Should be set different than [chart.panKey](#chart.panKey).
		/// </summary>
		public ChartZoomKey ZoomKey { get; set; }
		private ChartZoomKey ZoomKey_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decides in what dimensions the user can zoom by dragging the mouse.Can be one of `x`, `y` or `xy`.
		/// </summary>
		public ChartZoomType ZoomType { get; set; }
		private ChartZoomType ZoomType_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AlignTicks != AlignTicks_DefaultValue) h.Add("alignTicks",AlignTicks);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (ColorCount != ColorCount_DefaultValue) h.Add("colorCount",ColorCount);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (DisplayErrors != DisplayErrors_DefaultValue) h.Add("displayErrors",DisplayErrors);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (HeightNumber != HeightNumber_DefaultValue) h.Add("height",HeightNumber);
			if (IgnoreHiddenSeries != IgnoreHiddenSeries_DefaultValue) h.Add("ignoreHiddenSeries",IgnoreHiddenSeries);
			if (Inverted != Inverted_DefaultValue) h.Add("inverted",Inverted);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (MarginBottom != MarginBottom_DefaultValue) h.Add("marginBottom",MarginBottom);
			if (MarginLeft != MarginLeft_DefaultValue) h.Add("marginLeft",MarginLeft);
			if (MarginRight != MarginRight_DefaultValue) h.Add("marginRight",MarginRight);
			if (MarginTop != MarginTop_DefaultValue) h.Add("marginTop",MarginTop);
			if (Panning != Panning_DefaultValue) h.Add("panning",Panning);
			if (PinchType != PinchType_DefaultValue) h.Add("pinchType", Highstock.FirstCharacterToLower(PinchType.ToString()));
			if (PlotBackgroundColor != PlotBackgroundColor_DefaultValue) h.Add("plotBackgroundColor",PlotBackgroundColor);
			if (PlotBackgroundImage != PlotBackgroundImage_DefaultValue) h.Add("plotBackgroundImage",PlotBackgroundImage);
			if (PlotBorderColor != PlotBorderColor_DefaultValue) h.Add("plotBorderColor",PlotBorderColor);
			if (PlotBorderWidth != PlotBorderWidth_DefaultValue) h.Add("plotBorderWidth",PlotBorderWidth);
			if (PlotShadow != PlotShadow_DefaultValue) h.Add("plotShadow",PlotShadow);
			if (PlotShadowBool != PlotShadowBool_DefaultValue) h.Add("plotShadow",PlotShadowBool);
			if (Reflow != Reflow_DefaultValue) h.Add("reflow",Reflow);
			if (RenderTo != RenderTo_DefaultValue) h.Add("renderTo",RenderTo);
			if (ResetZoomButton.IsDirty()) h.Add("resetZoomButton",ResetZoomButton.ToHashtable());
			if (SelectionMarkerFill != SelectionMarkerFill_DefaultValue) h.Add("selectionMarkerFill",SelectionMarkerFill);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShadowBool != ShadowBool_DefaultValue) h.Add("shadow",ShadowBool);
			if (Spacing != Spacing_DefaultValue) h.Add("spacing",Spacing);
			if (SpacingBottom != SpacingBottom_DefaultValue) h.Add("spacingBottom",SpacingBottom);
			if (SpacingLeft != SpacingLeft_DefaultValue) h.Add("spacingLeft",SpacingLeft);
			if (SpacingRight != SpacingRight_DefaultValue) h.Add("spacingRight",SpacingRight);
			if (SpacingTop != SpacingTop_DefaultValue) h.Add("spacingTop",SpacingTop);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (StyledMode != StyledMode_DefaultValue) h.Add("styledMode",StyledMode);
			if (Type != Type_DefaultValue) h.Add("type", Highstock.FirstCharacterToLower(Type.ToString()));
			if (TypeDescription != TypeDescription_DefaultValue) h.Add("typeDescription",TypeDescription);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (ZoomKey != ZoomKey_DefaultValue) h.Add("zoomKey", Highstock.FirstCharacterToLower(ZoomKey.ToString()));
			if (ZoomType != ZoomType_DefaultValue) h.Add("zoomType", Highstock.FirstCharacterToLower(ZoomType.ToString()));
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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
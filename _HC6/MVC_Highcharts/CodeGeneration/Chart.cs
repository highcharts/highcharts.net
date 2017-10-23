using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class Chart  : BaseObject
	{
		public Chart()
		{
			Description = Description_DefaultValue = "undefined";
			TypeDescription = TypeDescription_DefaultValue = "undefined";
			Events = Events_DefaultValue = new ChartEvents();
			ParallelCoordinates = ParallelCoordinates_DefaultValue = null;
			ParallelAxes = ParallelAxes_DefaultValue = new ChartParallelAxes();
			BorderRadius = BorderRadius_DefaultValue = 0;
			ColorCount = ColorCount_DefaultValue = 10;
			IgnoreHiddenSeries = IgnoreHiddenSeries_DefaultValue = true;
			ResetZoomButton = ResetZoomButton_DefaultValue = new ChartResetZoomButton();
			Width = Width_DefaultValue = null;
			Height = Height_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = "#335cad";
			BackgroundColor = BackgroundColor_DefaultValue = "#FFFFFF";
			PlotBorderColor = PlotBorderColor_DefaultValue = "#cccccc";
			AlignTicks = AlignTicks_DefaultValue = true;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			ClassName = ClassName_DefaultValue = null;
			Margin = Margin_DefaultValue = new double[]{};
			MarginBottom = MarginBottom_DefaultValue = null;
			MarginLeft = MarginLeft_DefaultValue = null;
			MarginRight = MarginRight_DefaultValue = null;
			MarginTop = MarginTop_DefaultValue = null;
			PanKey = PanKey_DefaultValue = ChartPanKey.Null;
			Panning = Panning_DefaultValue = false;
			PinchType = PinchType_DefaultValue = ChartPinchType.Null;
			Inverted = Inverted_DefaultValue = false;
			BorderWidth = BorderWidth_DefaultValue = 0;
			PlotBackgroundColor = PlotBackgroundColor_DefaultValue = "null";
			PlotBackgroundImage = PlotBackgroundImage_DefaultValue = "null";
			PlotBorderWidth = PlotBorderWidth_DefaultValue = 0;
			PlotShadow = PlotShadow_DefaultValue = new Shadow() { Enabled = false };
			Polar = Polar_DefaultValue = false;
			Reflow = Reflow_DefaultValue = true;
			RenderTo = RenderTo_DefaultValue = null;
			SelectionMarkerFill = SelectionMarkerFill_DefaultValue = "rgba(51,92,173,0.25)";
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShowAxes = ShowAxes_DefaultValue = null;
			SpacingBottom = SpacingBottom_DefaultValue = 15;
			SpacingLeft = SpacingLeft_DefaultValue = 10;
			SpacingRight = SpacingRight_DefaultValue = 10;
			SpacingTop = SpacingTop_DefaultValue = 10;
			Style = Style_DefaultValue = new Hashtable{{"fontFamily","\"Lucida Grande\"},{ \"Lucida Sans Unicode\"},{ Verdana},{ Arial},{ Helvetica},{ sans-serif"},{"fontSize","12px"}};
			Type = Type_DefaultValue = ChartType.Null;
			ZoomType = ZoomType_DefaultValue = ChartZoomType.Null;
			Options3d = Options3d_DefaultValue = new ChartOptions3d();
			
		}	
		

		/// <summary>
		/// <p>A text description of the chart.</p><p>If the Accessibility module is loaded, this is included by defaultas a long description of the chart and its contents in the hiddenscreen reader information region.</p>
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A text description of the chart type.</p><p>If the Accessibility module is loaded, this will be included in thedescription of the chart in the screen reader information region.</p><p>Highcharts will by default attempt to guess the chart type, but formore complex charts it is recommended to specify this property forclarity.</p>
		/// </summary>
		public string TypeDescription { get; set; }
		private string TypeDescription_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Event listeners for the chart.</p>
		/// </summary>
		public ChartEvents Events { get; set; }
		private ChartEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Flag to render charts as a parallel coordinates plot. In a parallelcoordinates plot (||-coords) by default all required yAxes are generatedand the legend is disabled. This feature requires<code>modules/parallel-coordinates.js</code>.</p>
		/// </summary>
		public bool? ParallelCoordinates { get; set; }
		private bool? ParallelCoordinates_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Common options for all yAxes rendered in a parallel coordinates plot.This feature requires <code>modules/parallel-coordinates.js</code>.</p><p>The default options are:</p><pre>parallelAxes: {    lineWidth: 1,       // classic mode only    gridlinesWidth: 0,  // classic mode only    title: {        text: '',        reserveSpace: false    },    labels: {        x: 0,        y: 0,        align: 'center',        reserveSpace: false    },    offset: 0}</pre>
		/// </summary>
		public ChartParallelAxes ParallelAxes { get; set; }
		private ChartParallelAxes ParallelAxes_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The corner radius of the outer chart border.</p>
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>In styled mode, this sets how many colors the class namesshould rotate between. With ten colors, series (or points) aregiven class names like <code>highcharts-color-0</code>, <code>highcharts-color-0</code> [...] <code>highcharts-color-9</code>. The equivalent in non-styled modeis to set colors using the <a href="#colors">colors</a> setting.</p>
		/// </summary>
		public double? ColorCount { get; set; }
		private double? ColorCount_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If true, the axes will scale to the remaining visible series onceone series is hidden. If false, hiding and showing a series willnot affect the axes or the other series. For stacks, once one serieswithin the stack is hidden, the rest of the stack will close inaround it even if the axis is not affected.</p>
		/// </summary>
		public bool? IgnoreHiddenSeries { get; set; }
		private bool? IgnoreHiddenSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The button that appears after a selection zoom, allowing the userto reset zoom.</p>
		/// </summary>
		public ChartResetZoomButton ResetZoomButton { get; set; }
		private ChartResetZoomButton ResetZoomButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An explicit width for the chart. By default (when <code>null</code>) the widthis calculated from the offset width of the containing element.</p>
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An explicit height for the chart. If a <em>number</em>, the height isgiven in pixels. If given a <em>percentage string</em> (for example <code>&#39;56%&#39;</code>),the height is given as the percentage of the actual chart width.This allows for preserving the aspect ratio across responsivesizes.</p><p>By default (when <code>null</code>) the height is calculated from the offsetheight of the containing element, or 400 pixels if the containingelement&#39;s height is 0.</p>
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the outer chart border.</p>
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The background color or gradient for the outer chart area.</p>
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the inner chart or plot area border.</p>
		/// </summary>
		public string PlotBorderColor { get; set; }
		private string PlotBorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When using multiple axis, the ticks of two or more opposite axeswill automatically be aligned by adding ticks to the axis or axeswith the least ticks, as if <code>tickAmount</code> were specified.</p><p>This can be prevented by setting <code>alignTicks</code> to false. If the gridlines look messy, it&#39;s a good idea to hide them for the secondaryaxis by setting <code>gridLineWidth</code> to 0.</p>
		/// </summary>
		public bool? AlignTicks { get; set; }
		private bool? AlignTicks_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Set the overall animation for all chart updating. Animation can bedisabled throughout the chart by setting it to false here. It canbe overridden for each individual API method as a function parameter.The only animation not affected by this option is the initial seriesanimation, see <a href="#plotOptions.series.animation">plotOptions.series.animation</a>.</p><p>The animation can either be set as a boolean or a configurationobject. If <code>true</code>, it will use the &#39;swing&#39; jQuery easing and aduration of 500 ms. If used as a configuration object, the followingproperties are supported:</p><dl><dt>duration</dt><dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>A string reference to an easing function set on the <code>Math</code> object.See <a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-animation-easing/">the easing demo</a>.</dd></dl>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A CSS class name to apply to the charts container <code>div</code>, allowingunique CSS styling for each chart.</p>
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The margin between the outer edge of the chart and the plot area.The numbers in the array designate top, right, bottom and leftrespectively. Use the options <code>marginTop</code>, <code>marginRight</code>,<code>marginBottom</code> and <code>marginLeft</code> for shorthand setting of one option.</p><p>By default there is no margin. The actual space is dynamically calculatedfrom the offset of axis labels, axis title, title, subtitle and legendin addition to the <code>spacingTop</code>, <code>spacingRight</code>, <code>spacingBottom</code>and <code>spacingLeft</code> options.</p>
		/// </summary>
		public double[] Margin { get; set; }
		private double[] Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The margin between the bottom outer edge of the chart and the plotarea. Use this to set a fixed pixel value for the margin as opposedto the default dynamic margin. See also <code>spacingBottom</code>.</p>
		/// </summary>
		public double? MarginBottom { get; set; }
		private double? MarginBottom_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The margin between the left outer edge of the chart and the plotarea. Use this to set a fixed pixel value for the margin as opposedto the default dynamic margin. See also <code>spacingLeft</code>.</p>
		/// </summary>
		public double? MarginLeft { get; set; }
		private double? MarginLeft_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The margin between the right outer edge of the chart and the plotarea. Use this to set a fixed pixel value for the margin as opposedto the default dynamic margin. See also <code>spacingRight</code>.</p>
		/// </summary>
		public double? MarginRight { get; set; }
		private double? MarginRight_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The margin between the top outer edge of the chart and the plot area.Use this to set a fixed pixel value for the margin as opposed tothe default dynamic margin. See also <code>spacingTop</code>.</p>
		/// </summary>
		public double? MarginTop { get; set; }
		private double? MarginTop_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Allows setting a key to switch between zooming and panning. Can beone of <code>alt</code>, <code>ctrl</code>, <code>meta</code> (the command key on Mac and Windowskey on Windows) or <code>shift</code>. The keys are mapped directly to the keyproperties of the click event argument (<code>event.altKey</code>, <code>event.ctrlKey</code>,<code>event.metaKey</code> and <code>event.shiftKey</code>).</p>
		/// </summary>
		public ChartPanKey PanKey { get; set; }
		private ChartPanKey PanKey_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Allow panning in a chart. Best used with <a href="#chart.panKey">panKey</a>to combine zooming and panning.</p><p>On touch devices, when the <a href="#tooltip.followTouchMove">tooltip.followTouchMove</a>option is <code>true</code> (default), panning requires two fingers. To allowpanning with one finger, set <code>followTouchMove</code> to <code>false</code>.</p>
		/// </summary>
		public bool? Panning { get; set; }
		private bool? Panning_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Equivalent to <a href="#chart.zoomType">zoomType</a>, but for multitouch gesturesonly. By default, the <code>pinchType</code> is the same as the <code>zoomType</code> setting.However, pinching can be enabled separately in some cases, for examplein stock charts where a mouse drag pans the chart, while pinchingis enabled. When <a href="#tooltip.followTouchMove">tooltip.followTouchMove</a>is true, pinchType only applies to two-finger touches.</p>
		/// </summary>
		public ChartPinchType PinchType { get; set; }
		private ChartPinchType PinchType_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to invert the axes so that the x axis is vertical and y axisis horizontal. When <code>true</code>, the x axis is <a href="#xAxis.reversed">reversed</a>by default.</p>
		/// </summary>
		public bool? Inverted { get; set; }
		private bool? Inverted_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel width of the outer chart border.</p>
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The background color or gradient for the plot area.</p>
		/// </summary>
		public string PlotBackgroundColor { get; set; }
		private string PlotBackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The URL for an image to use as the plot background. To set an imageas the background for the entire chart, set a CSS background imageto the container element. Note that for the image to be applied toexported charts, its URL needs to be accessible by the export server.</p>
		/// </summary>
		public string PlotBackgroundImage { get; set; }
		private string PlotBackgroundImage_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel width of the plot area border.</p>
		/// </summary>
		public double? PlotBorderWidth { get; set; }
		private double? PlotBorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to apply a drop shadow to the plot area. Requires thatplotBackgroundColor be set. The shadow can be an object configurationcontaining <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.</p>
		/// </summary>
		public Shadow PlotShadow { get; set; }
		private Shadow PlotShadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When true, cartesian charts like line, spline, area and column aretransformed into the polar coordinate system. Requires <code>highcharts-more.js</code>.</p>
		/// </summary>
		public bool? Polar { get; set; }
		private bool? Polar_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to reflow the chart to fit the width of the container divon resizing the window.</p>
		/// </summary>
		public bool? Reflow { get; set; }
		private bool? Reflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The HTML element where the chart will be rendered. If it is a string,the element by that id is used. The HTML element can also be passedby direct reference, or as the first argument of the chart constructor, in which case the option is not needed.</p>
		/// </summary>
		public string RenderTo { get; set; }
		private string RenderTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The background color of the marker square when selecting (zoomingin on) an area of the chart.</p>
		/// </summary>
		public string SelectionMarkerFill { get; set; }
		private string SelectionMarkerFill_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to apply a drop shadow to the outer chart area. Requiresthat backgroundColor be set. The shadow can be an object configurationcontaining <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.</p>
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to show the axes initially. This only applies to empty chartswhere series are added dynamically, as axes are automatically addedto cartesian series.</p>
		/// </summary>
		public bool? ShowAxes { get; set; }
		private bool? ShowAxes_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The space between the bottom edge of the chart and the content (plotarea, axis title and labels, title, subtitle or legend in top position).</p>
		/// </summary>
		public double? SpacingBottom { get; set; }
		private double? SpacingBottom_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The space between the left edge of the chart and the content (plotarea, axis title and labels, title, subtitle or legend in top position).</p>
		/// </summary>
		public double? SpacingLeft { get; set; }
		private double? SpacingLeft_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The space between the right edge of the chart and the content (plotarea, axis title and labels, title, subtitle or legend in topposition).</p>
		/// </summary>
		public double? SpacingRight { get; set; }
		private double? SpacingRight_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The space between the top edge of the chart and the content (plotarea, axis title and labels, title, subtitle or legend in topposition).</p>
		/// </summary>
		public double? SpacingTop { get; set; }
		private double? SpacingTop_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Additional CSS styles to apply inline to the container <code>div</code>. Notethat since the default font styles are applied in the renderer, itis ignorant of the individual chart options and must be set globally.</p>
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The default series type for the chart. Can be any of the chart typeslisted under <a href="#plotOptions">plotOptions</a>.</p>
		/// </summary>
		public ChartType Type { get; set; }
		private ChartType Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Decides in what dimensions the user can zoom by dragging the mouse.Can be one of <code>x</code>, <code>y</code> or <code>xy</code>.</p>
		/// </summary>
		public ChartZoomType ZoomType { get; set; }
		private ChartZoomType ZoomType_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options to render charts in 3 dimensions. This feature requires<code>highcharts-3d.js</code>, found in the download package or online at<a href="http://code.highcharts.com/highcharts-3d.js">code.highcharts.com/highcharts-3d.js</a>.</p>
		/// </summary>
		public ChartOptions3d Options3d { get; set; }
		private ChartOptions3d Options3d_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (TypeDescription != TypeDescription_DefaultValue) h.Add("typeDescription",TypeDescription);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (ParallelCoordinates != ParallelCoordinates_DefaultValue) h.Add("parallelCoordinates",ParallelCoordinates);
			if (ParallelAxes.IsDirty()) h.Add("parallelAxes",ParallelAxes.ToHashtable());
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (ColorCount != ColorCount_DefaultValue) h.Add("colorCount",ColorCount);
			if (IgnoreHiddenSeries != IgnoreHiddenSeries_DefaultValue) h.Add("ignoreHiddenSeries",IgnoreHiddenSeries);
			if (ResetZoomButton.IsDirty()) h.Add("resetZoomButton",ResetZoomButton.ToHashtable());
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (PlotBorderColor != PlotBorderColor_DefaultValue) h.Add("plotBorderColor",PlotBorderColor);
			if (AlignTicks != AlignTicks_DefaultValue) h.Add("alignTicks",AlignTicks);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (MarginBottom != MarginBottom_DefaultValue) h.Add("marginBottom",MarginBottom);
			if (MarginLeft != MarginLeft_DefaultValue) h.Add("marginLeft",MarginLeft);
			if (MarginRight != MarginRight_DefaultValue) h.Add("marginRight",MarginRight);
			if (MarginTop != MarginTop_DefaultValue) h.Add("marginTop",MarginTop);
			if (PanKey != PanKey_DefaultValue) h.Add("panKey", Highcharts.FirstCharacterToLower(PanKey.ToString()));
			if (Panning != Panning_DefaultValue) h.Add("panning",Panning);
			if (PinchType != PinchType_DefaultValue) h.Add("pinchType", Highcharts.FirstCharacterToLower(PinchType.ToString()));
			if (Inverted != Inverted_DefaultValue) h.Add("inverted",Inverted);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (PlotBackgroundColor != PlotBackgroundColor_DefaultValue) h.Add("plotBackgroundColor",PlotBackgroundColor);
			if (PlotBackgroundImage != PlotBackgroundImage_DefaultValue) h.Add("plotBackgroundImage",PlotBackgroundImage);
			if (PlotBorderWidth != PlotBorderWidth_DefaultValue) h.Add("plotBorderWidth",PlotBorderWidth);
			if (PlotShadow != PlotShadow_DefaultValue) h.Add("plotShadow",PlotShadow);
			if (Polar != Polar_DefaultValue) h.Add("polar",Polar);
			if (Reflow != Reflow_DefaultValue) h.Add("reflow",Reflow);
			if (RenderTo != RenderTo_DefaultValue) h.Add("renderTo",RenderTo);
			if (SelectionMarkerFill != SelectionMarkerFill_DefaultValue) h.Add("selectionMarkerFill",SelectionMarkerFill);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShowAxes != ShowAxes_DefaultValue) h.Add("showAxes",ShowAxes);
			if (SpacingBottom != SpacingBottom_DefaultValue) h.Add("spacingBottom",SpacingBottom);
			if (SpacingLeft != SpacingLeft_DefaultValue) h.Add("spacingLeft",SpacingLeft);
			if (SpacingRight != SpacingRight_DefaultValue) h.Add("spacingRight",SpacingRight);
			if (SpacingTop != SpacingTop_DefaultValue) h.Add("spacingTop",SpacingTop);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Type != Type_DefaultValue) h.Add("type", Highcharts.FirstCharacterToLower(Type.ToString()));
			if (ZoomType != ZoomType_DefaultValue) h.Add("zoomType", Highcharts.FirstCharacterToLower(ZoomType.ToString()));
			if (Options3d.IsDirty()) h.Add("options3d",Options3d.ToHashtable());
			

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
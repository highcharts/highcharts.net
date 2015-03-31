using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class Chart
	{
		public Chart()
		{
			AlignTicks = AlignTicks_DefaultValue = true;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			BackgroundColor = BackgroundColor_DefaultValue = "#FFFFFF";
			BorderColor = BorderColor_DefaultValue = "#4572A7";
			BorderRadius = BorderRadius_DefaultValue = 0;
			BorderWidth = BorderWidth_DefaultValue = 0;
			ClassName = ClassName_DefaultValue = null;
			DefaultSeriesType = DefaultSeriesType_DefaultValue = "line";
			Events = Events_DefaultValue = new ChartEvents();
			Height = Height_DefaultValue = null;
			IgnoreHiddenSeries = IgnoreHiddenSeries_DefaultValue = true;
			Inverted = Inverted_DefaultValue = false;
			Margin = Margin_DefaultValue = null;
			MarginBottom = MarginBottom_DefaultValue = null;
			MarginLeft = MarginLeft_DefaultValue = null;
			MarginRight = MarginRight_DefaultValue = null;
			MarginTop = MarginTop_DefaultValue = null;
			Options3d = Options3d_DefaultValue = new ChartOptions3d();
			PanKey = PanKey_DefaultValue = "";
			Panning = Panning_DefaultValue = false;
			PinchType = PinchType_DefaultValue = "null";
			PlotBackgroundColor = PlotBackgroundColor_DefaultValue = null;
			PlotBackgroundImage = PlotBackgroundImage_DefaultValue = null;
			PlotBorderColor = PlotBorderColor_DefaultValue = "#C0C0C0";
			PlotBorderWidth = PlotBorderWidth_DefaultValue = 0;
			PlotShadow = PlotShadow_DefaultValue = new Shadow() { Enabled = false };
			Polar = Polar_DefaultValue = false;
			Reflow = Reflow_DefaultValue = true;
			RenderTo = RenderTo_DefaultValue = null;
			ResetZoomButton = ResetZoomButton_DefaultValue = new ChartResetZoomButton();
			SelectionMarkerFill = SelectionMarkerFill_DefaultValue = "rgba(69,114,167,0.25)";
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShowAxes = ShowAxes_DefaultValue = false;
			SpacingBottom = SpacingBottom_DefaultValue = 15;
			SpacingLeft = SpacingLeft_DefaultValue = 10;
			SpacingRight = SpacingRight_DefaultValue = 10;
			SpacingTop = SpacingTop_DefaultValue = 10;
			Style = Style_DefaultValue = new NameValueCollection{{"fontFamily","\"Lucida Grande\"},{ \"Lucida Sans Unicode\"},{ Verdana},{ Arial},{ Helvetica},{ sans-serif"},{"fontSize","12px"}};
			Type = Type_DefaultValue = "line";
			Width = Width_DefaultValue = null;
			ZoomType = ZoomType_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// When using multiple axis, the ticks of two or more opposite axes will  automatically be aligned by adding ticks to the axis or axes with the least ticks. This can be prevented by setting <code>alignTicks</code> to false. If the grid lines look messy, it's a good idea to hide them for the secondary axis by setting <code>gridLineWidth</code> to 0.
		/// </summary>
		public bool? AlignTicks { get; set; }
		private bool? AlignTicks_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Set the overall animation for all chart updating. Animation can be disabled throughout the chart by setting it to false here. It can be overridden for each individual API method as a function parameter. The only animation not affected by this option is the  initial series animation, see <a class="internal" href="#plotOptions.series.animation">plotOptions.series.animation</a>.</p>  <p>The animation can either be set as a boolean or a configuration object. If <code>true</code>, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported:  </p><dl> <dt>duration</dt> <dd>The duration of the animation in milliseconds.</dd>  <dt>easing</dt> <dd>When using jQuery as the general framework, the easing can be set to <code>linear</code> or <code>swing</code>. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See <a href="http://api.jquery.com/animate/">the jQuery docs</a>. When using  MooTools as the general framework, use the property name <code>transition</code> instead  of <code>easing</code>.</dd> </dl>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

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
		/// A CSS class name to apply to the charts container <code>div</code>, allowing unique CSS styling for each chart.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Alias of <code>type</code>.
		/// </summary>
		public string DefaultSeriesType { get; set; }
		private string DefaultSeriesType_DefaultValue { get; set; }
		 

		/// <summary>
		/// Event listeners for the chart.
		/// </summary>
		public ChartEvents Events { get; set; }
		private ChartEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// An explicit height for the chart. By default the height is calculated from the offset height of the containing element, or 400 pixels if the containing element's height is 0.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// If true, the axes will scale to the remaining visible series once one series is hidden. If false, hiding and showing a series will not affect the axes or the other series. For stacks, once one series within the stack is hidden, the rest of the stack will close in around it even if the axis is not affected.
		/// </summary>
		public bool? IgnoreHiddenSeries { get; set; }
		private bool? IgnoreHiddenSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to invert the axes so that the x axis is vertical and y axis is horizontal. When true, the x axis is reversed by default. If a bar series is present in the chart, it will be inverted automatically.
		/// </summary>
		public bool? Inverted { get; set; }
		private bool? Inverted_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The margin between the outer edge of the chart and the plot area. The numbers in the array designate top, right, bottom and left respectively. Use the options <code>marginTop</code>, <code>marginRight</code>, <code>marginBottom</code> and <code>marginLeft</code> for shorthand setting of one option.</p> <p>Since version 2.1, the margin is 0 by default. The actual space is dynamically calculated  from the offset of axis labels, axis title, title, subtitle and legend in addition to the <code>spacingTop</code>, <code>spacingRight</code>, <code>spacingBottom</code> and <code>spacingLeft</code> options.</p> Defaults to <code>[null]</code>.
		/// </summary>
		public Array Margin { get; set; }
		private Array Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// The margin between the bottom outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also <code>spacingBottom</code>.
		/// </summary>
		public double? MarginBottom { get; set; }
		private double? MarginBottom_DefaultValue { get; set; }
		 

		/// <summary>
		/// The margin between the left outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also <code>spacingLeft</code>.
		/// </summary>
		public double? MarginLeft { get; set; }
		private double? MarginLeft_DefaultValue { get; set; }
		 

		/// <summary>
		/// The margin between the right outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also <code>spacingRight</code>.
		/// </summary>
		public double? MarginRight { get; set; }
		private double? MarginRight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The margin between the top outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also <code>spacingTop</code>.
		/// </summary>
		public double? MarginTop { get; set; }
		private double? MarginTop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options to render charts in 3 dimensions. This feature requires <code>highcharts-3d.js</code>, found in the download package or online at <a href="http://code.highcharts.com/highcharts-3d.js">code.highcharts.com/highcharts-3d.js</a>.
		/// </summary>
		public ChartOptions3d Options3d { get; set; }
		private ChartOptions3d Options3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allows setting a key to switch between zooming and panning. 
		/// </summary>
		public string PanKey { get; set; }
		private string PanKey_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow panning in a chart. Best used with <a href="#chart.panKey">panKey</a> to combine zooming and panning.
		/// </summary>
		public bool? Panning { get; set; }
		private bool? Panning_DefaultValue { get; set; }
		 

		/// <summary>
		/// Equivalent to <a href="#chart.zoomType">zoomType</a>, but for multitouch gestures only. By default, the <code>pinchType</code> is the same as the <code>zoomType</code> setting. However, pinching can be enabled separately in some cases, for example in stock charts where a mouse drag pans the chart, while pinching is enabled.
		/// </summary>
		public string PinchType { get; set; }
		private string PinchType_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background color or gradient for the plot area.
		/// </summary>
		public string PlotBackgroundColor { get; set; }
		private string PlotBackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The URL for an image to use as the plot background. To set an image as the background for the entire chart, set a CSS background image to the container element. Note that for the image to be applied to exported charts, its URL needs to be accessible by the export server.
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
		/// Whether to apply a drop shadow to the plot area. Requires that plotBackgroundColor be set. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.
		/// </summary>
		public Shadow PlotShadow { get; set; }
		private Shadow PlotShadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// When true, cartesian charts like line, spline, area and column are transformed into the polar coordinate system. Requires <code>highcharts-more.js</code>.
		/// </summary>
		public bool? Polar { get; set; }
		private bool? Polar_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to reflow the chart to fit the width of the container div on resizing the window.
		/// </summary>
		public bool? Reflow { get; set; }
		private bool? Reflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The HTML element where the chart will be rendered. If it is a string, the element by that id is used. The HTML element can also be passed by direct reference.
		/// </summary>
		public string RenderTo { get; set; }
		private string RenderTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The button that appears after a selection zoom, allowing the user to reset zoom.
		/// </summary>
		public ChartResetZoomButton ResetZoomButton { get; set; }
		private ChartResetZoomButton ResetZoomButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background color of the marker square when selecting (zooming in on) an area of the chart.
		/// </summary>
		public string SelectionMarkerFill { get; set; }
		private string SelectionMarkerFill_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the outer chart area. Requires that  backgroundColor be set. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to show the axes initially. This only applies to empty charts where series are added dynamically, as axes are automatically added to cartesian series.
		/// </summary>
		public bool? ShowAxes { get; set; }
		private bool? ShowAxes_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The space between the bottom edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).</p>
		/// </summary>
		public double? SpacingBottom { get; set; }
		private double? SpacingBottom_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The space between the left edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).</p>
		/// </summary>
		public double? SpacingLeft { get; set; }
		private double? SpacingLeft_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The space between the right edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).</p>
		/// </summary>
		public double? SpacingRight { get; set; }
		private double? SpacingRight_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The space between the top edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).</p>
		/// </summary>
		public double? SpacingTop { get; set; }
		private double? SpacingTop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Additional CSS styles to apply inline to the container <code>div</code>. Note that since the default font styles are applied in the renderer, it is ignorant of the individual chart  options and must be set globally. Defaults to:<pre>style: {fontFamily: '"Lucida Grande", "Lucida Sans Unicode", Verdana, Arial, Helvetica, sans-serif', // default fontfontSize: '12px'}</pre>
		/// </summary>
		public NameValueCollection Style { get; set; }
		private NameValueCollection Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The default series type for the chart. Can be any of the chart types listed under <a href="#plotOptions">plotOptions</a>.
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// An explicit width for the chart. By default the width is calculated from the offset width of the containing element.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decides in what dimensions the user can zoom by dragging the mouse. Can be one of <code>x</code>, <code>y</code> or <code>xy</code>.
		/// </summary>
		public string ZoomType { get; set; }
		private string ZoomType_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AlignTicks != AlignTicks_DefaultValue) h.Add("alignTicks",AlignTicks);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (DefaultSeriesType != DefaultSeriesType_DefaultValue) h.Add("defaultSeriesType",DefaultSeriesType);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (IgnoreHiddenSeries != IgnoreHiddenSeries_DefaultValue) h.Add("ignoreHiddenSeries",IgnoreHiddenSeries);
			if (Inverted != Inverted_DefaultValue) h.Add("inverted",Inverted);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (MarginBottom != MarginBottom_DefaultValue) h.Add("marginBottom",MarginBottom);
			if (MarginLeft != MarginLeft_DefaultValue) h.Add("marginLeft",MarginLeft);
			if (MarginRight != MarginRight_DefaultValue) h.Add("marginRight",MarginRight);
			if (MarginTop != MarginTop_DefaultValue) h.Add("marginTop",MarginTop);
			if (Options3d.IsDirty()) h.Add("options3d",Options3d.ToHashtable());
			if (PanKey != PanKey_DefaultValue) h.Add("panKey",PanKey);
			if (Panning != Panning_DefaultValue) h.Add("panning",Panning);
			if (PinchType != PinchType_DefaultValue) h.Add("pinchType",PinchType);
			if (PlotBackgroundColor != PlotBackgroundColor_DefaultValue) h.Add("plotBackgroundColor",PlotBackgroundColor);
			if (PlotBackgroundImage != PlotBackgroundImage_DefaultValue) h.Add("plotBackgroundImage",PlotBackgroundImage);
			if (PlotBorderColor != PlotBorderColor_DefaultValue) h.Add("plotBorderColor",PlotBorderColor);
			if (PlotBorderWidth != PlotBorderWidth_DefaultValue) h.Add("plotBorderWidth",PlotBorderWidth);
			if (PlotShadow != PlotShadow_DefaultValue) h.Add("plotShadow",PlotShadow);
			if (Polar != Polar_DefaultValue) h.Add("polar",Polar);
			if (Reflow != Reflow_DefaultValue) h.Add("reflow",Reflow);
			if (RenderTo != RenderTo_DefaultValue) h.Add("renderTo",RenderTo);
			if (ResetZoomButton.IsDirty()) h.Add("resetZoomButton",ResetZoomButton.ToHashtable());
			if (SelectionMarkerFill != SelectionMarkerFill_DefaultValue) h.Add("selectionMarkerFill",SelectionMarkerFill);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShowAxes != ShowAxes_DefaultValue) h.Add("showAxes",ShowAxes);
			if (SpacingBottom != SpacingBottom_DefaultValue) h.Add("spacingBottom",SpacingBottom);
			if (SpacingLeft != SpacingLeft_DefaultValue) h.Add("spacingLeft",SpacingLeft);
			if (SpacingRight != SpacingRight_DefaultValue) h.Add("spacingRight",SpacingRight);
			if (SpacingTop != SpacingTop_DefaultValue) h.Add("spacingTop",SpacingTop);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (ZoomType != ZoomType_DefaultValue) h.Add("zoomType",ZoomType);
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}
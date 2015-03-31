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
	public partial class PlotOptionsArea
	{
		public PlotOptionsArea()
		{
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Color = Color_DefaultValue = null;
			ConnectEnds = ConnectEnds_DefaultValue = true;
			ConnectNulls = ConnectNulls_DefaultValue = false;
			CropThreshold = CropThreshold_DefaultValue = 300;
			Cursor = Cursor_DefaultValue = PlotOptionsAreaCursor.Null;
			DashStyle = DashStyle_DefaultValue = PlotOptionsAreaDashStyle.Solid;
			DataLabels = DataLabels_DefaultValue = new PlotOptionsAreaDataLabels();
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			Events = Events_DefaultValue = new PlotOptionsAreaEvents();
			FillColor = FillColor_DefaultValue = null;
			FillOpacity = FillOpacity_DefaultValue = 0.75;
			LineColor = LineColor_DefaultValue = null;
			LineWidth = LineWidth_DefaultValue = 2;
			LinkedTo = LinkedTo_DefaultValue = "";
			Marker = Marker_DefaultValue = new PlotOptionsAreaMarker();
			NegativeColor = NegativeColor_DefaultValue = "null";
			NegativeFillColor = NegativeFillColor_DefaultValue = "";
			Point = Point_DefaultValue = new PlotOptionsAreaPoint();
			PointInterval = PointInterval_DefaultValue = 1;
			PointPlacement = PointPlacement_DefaultValue = PlotOptionsAreaPointPlacement.Null;
			PointStart = PointStart_DefaultValue = 0;
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			ShowInLegend = ShowInLegend_DefaultValue = true;
			Stacking = Stacking_DefaultValue = PlotOptionsAreaStacking.Null;
			States = States_DefaultValue = new PlotOptionsAreaStates();
			Step = Step_DefaultValue = PlotOptionsAreaStep.False;
			StickyTracking = StickyTracking_DefaultValue = true;
			Threshold = Threshold_DefaultValue = 0;
			Tooltip = Tooltip_DefaultValue = new PlotOptionsAreaTooltip();
			TrackByArea = TrackByArea_DefaultValue = false;
			TurboThreshold = TurboThreshold_DefaultValue = 1000;
			Visible = Visible_DefaultValue = true;
			
		}	
		

		/// <summary>
		/// Allow this series' points to be selected by clicking on the markers, bars or pie slices.
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the initial animation when a series is displayed. The animation can also be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see <a href="#chart.animation">chart.animation</a> and the animation parameter under the API methods.The following properties are supported:</p><dl>  <dt>duration</dt>  <dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>When using jQuery as the general framework, the easing can be set to <code>linear</code> or<code>swing</code>. More easing functions are available with the use of jQuery plug-ins, most notablythe jQuery UI suite. See <a href="http://api.jquery.com/animate/">the jQuery docs</a>. When using MooTools as the general framework, use the property name <code>transition</code> instead of <code>easing</code>.</dd></dl><p>Due to poor performance, animation is disabled in old IE browsers for column charts and polar charts.</p>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified. In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the  <code>options.colors</code> array.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Polar charts only. Whether to connect the ends of a line series plot across the extremes.
		/// </summary>
		public bool? ConnectEnds { get; set; }
		private bool? ConnectEnds_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to connect a graph line across null points.
		/// </summary>
		public bool? ConnectNulls { get; set; }
		private bool? ConnectNulls_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the series contains less points than the crop threshold, all points are drawn,  event if the points fall outside the visible plot area at the current zoom. The advantage of drawing all points (including markers and columns), is that animation is performed on updates. On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area. The advantage of cropping away invisible points is to increase performance on large series.  .
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.
		/// </summary>
		public PlotOptionsAreaCursor Cursor { get; set; }
		private PlotOptionsAreaCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A name for the dash style to use for the graph. Applies only to series type having a graph, like <code>line</code>, <code>spline</code>, <code>area</code> and <code>scatter</code> in  case it has a <code>lineWidth</code>. The value for the <code>dashStyle</code> include:    <ul>    <li>Solid</li>    <li>ShortDash</li>    <li>ShortDot</li>    <li>ShortDashDot</li>    <li>ShortDashDotDot</li>    <li>Dot</li>    <li>Dash</li>    <li>LongDash</li>    <li>DashDot</li>    <li>LongDashDot</li>    <li>LongDashDotDot</li>    </ul>
		/// </summary>
		public PlotOptionsAreaDashStyle DashStyle { get; set; }
		private PlotOptionsAreaDashStyle DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsAreaDataLabels DataLabels { get; set; }
		private PlotOptionsAreaDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsAreaEvents Events { get; set; }
		private PlotOptionsAreaEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fill color or gradient for the area. When <code>null</code>, the series' <code>color</code>  is  used with the series' <code>fillOpacity</code>.
		/// </summary>
		public string FillColor { get; set; }
		private string FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fill opacity for the area.
		/// </summary>
		public double? FillOpacity { get; set; }
		private double? FillOpacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// A separate color for the graph line. By default the line takes the <code>color</code> of the series, but the lineColor setting allows setting a separate color for the line without altering the <code>fillColor</code>.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel with of the graph line.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The <a href="#series.id">id</a> of another series to link to. Additionally, the value can be ":previous" to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsAreaMarker Marker { get; set; }
		private PlotOptionsAreaMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color for the parts of the graph or points that are below the <a href="#plotOptions.series.threshold">threshold</a>.
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A separate color for the negative part of the area.
		/// </summary>
		public string NegativeFillColor { get; set; }
		private string NegativeFillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point
		/// </summary>
		public PlotOptionsAreaPoint Point { get; set; }
		private PlotOptionsAreaPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If no x values are given for the points in a series, pointInterval defines the interval of the x values. For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.</p>
		/// </summary>
		public double? PointInterval { get; set; }
		private double? PointInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Possible values: null, "on", "between".</p><p>In a column chart, when pointPlacement is "on", the point will not create any padding of the X axis. In a polar column chart this means that the first column points directly north. If the pointPlacement is "between", the columns will be laid out between ticks. This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.</p><p>Since Highcharts 3.0.2, the point placement can also be numeric, where 0 is on the axis value, -0.5 is between this value and the previous, and 0.5 is between this value and the next. Unlike the textual options, numeric point placement options won't affect axis padding.</p><p>Defaults to <code>null</code> in cartesian charts, <code>"between"</code> in polar charts.
		/// </summary>
		public PlotOptionsAreaPointPlacement PointPlacement { get; set; }
		private PlotOptionsAreaPointPlacement PointPlacement_DefaultValue { get; set; }
		 

		/// <summary>
		/// If no x values are given for the points in a series, pointStart defines on what value to start. For example, if a series contains one yearly value starting from 1945, set pointStart to 1945.
		/// </summary>
		public double? PointStart { get; set; }
		private double? PointStart_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If <code>showCheckbox</code> is true, the checkbox next to the series name will be checked for a selected series.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allow selecting the series. The state of the checkbox is determined by the <code>selected</code> option.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		private bool? ShowCheckbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in the legend. The default value is <code>true</code> for standalone series, <code>false</code> for linked series.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to stack the values of each series on top of each other. Possible values are null to disable, "normal" to stack by value or "percent".
		/// </summary>
		public PlotOptionsAreaStacking Stacking { get; set; }
		private PlotOptionsAreaStacking Stacking_DefaultValue { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsAreaStates States { get; set; }
		private PlotOptionsAreaStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply steps to the line. Possible values are <code>left</code>, <code>center</code> and <code>right</code>. Prior to 2.3.5, only <code>left</code> was supported.
		/// </summary>
		public PlotOptionsAreaStep Step { get; set; }
		private PlotOptionsAreaStep Step_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When <code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the  tooltip will be hidden when moving the mouse between series. Defaults to true for line and area type series, but to false for columns, pies etc.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Y axis value to serve as the base for the area, for distinguishing between values above and below a threshold. If <code>null</code>, the area behaves like a line series with fill between the graph and the Y axis minimum.
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level.
		/// </summary>
		public PlotOptionsAreaTooltip Tooltip { get; set; }
		private PlotOptionsAreaTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the whole area or just the line should respond to mouseover tooltips and other mouse or touch events.
		/// </summary>
		public bool? TrackByArea { get; set; }
		private bool? TrackByArea_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed. Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Set it to <code>0</code> disable.
		/// </summary>
		public double? TurboThreshold { get; set; }
		private double? TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ConnectEnds != ConnectEnds_DefaultValue) h.Add("connectEnds",ConnectEnds);
			if (ConnectNulls != ConnectNulls_DefaultValue) h.Add("connectNulls",ConnectNulls);
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor.ToString().ToLower());
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle",DashStyle.ToString().ToLower());
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (FillOpacity != FillOpacity_DefaultValue) h.Add("fillOpacity",FillOpacity);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (NegativeFillColor != NegativeFillColor_DefaultValue) h.Add("negativeFillColor",NegativeFillColor);
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (PointInterval != PointInterval_DefaultValue) h.Add("pointInterval",PointInterval);
			if (PointPlacement != PointPlacement_DefaultValue) h.Add("pointPlacement",PointPlacement.ToString().ToLower());
			if (PointStart != PointStart_DefaultValue) h.Add("pointStart",PointStart);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (Stacking != Stacking_DefaultValue) h.Add("stacking",Stacking.ToString().ToLower());
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Step != Step_DefaultValue) h.Add("step",Step.ToString().ToLower());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (TrackByArea != TrackByArea_DefaultValue) h.Add("trackByArea",TrackByArea);
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			

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
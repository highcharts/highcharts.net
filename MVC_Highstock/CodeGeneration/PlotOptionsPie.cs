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
	public partial class PlotOptionsPie  : BaseObject
	{
		public PlotOptionsPie()
		{
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			BorderColor = BorderColor_DefaultValue = "#FFFFFF";
			BorderWidth = BorderWidth_DefaultValue = 1;
			Center = Center_DefaultValue = new string[] { null, null };
			Colors = Colors_DefaultValue = new List<string>();
			Cursor = Cursor_DefaultValue = PlotOptionsPieCursor.Null;
			DataLabels = DataLabels_DefaultValue = new PlotOptionsPieDataLabels();
			Depth = Depth_DefaultValue = 0;
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			EndAngle = EndAngle_DefaultValue = null;
			Events = Events_DefaultValue = new PlotOptionsPieEvents();
			IgnoreHiddenPoint = IgnoreHiddenPoint_DefaultValue = true;
			InnerSize = InnerSize_DefaultValue = "0";
			LinkedTo = LinkedTo_DefaultValue = "";
			MinSize = MinSize_DefaultValue = 80;
			Point = Point_DefaultValue = new PlotOptionsPiePoint();
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShowInLegend = ShowInLegend_DefaultValue = false;
			Size = Size_DefaultValue = " ";
			SlicedOffset = SlicedOffset_DefaultValue = 10;
			StartAngle = StartAngle_DefaultValue = 0;
			States = States_DefaultValue = new PlotOptionsPieStates();
			StickyTracking = StickyTracking_DefaultValue = false;
			Tooltip = Tooltip_DefaultValue = new PlotOptionsPieTooltip();
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
		/// The color of the border surrounding each slice.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the border surrounding each slice.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The center of the pie chart relative to the plot area. Can be percentages or pixel values. The default behaviour (as of 3.0) is to center the pie so that all slices and data labels are within the plot area. As a consequence, the pie may actually jump around in a chart with dynamic values, as the data labels move. In that case, the center should be explicitly set, for example to <code>["50%", "50%"]</code>. 
		/// </summary>
		public new string[] Center { get; set; }
		private new string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to use instead of the global <a href="#colors">colors</a>.
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.
		/// </summary>
		public PlotOptionsPieCursor Cursor { get; set; }
		private PlotOptionsPieCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieDataLabels DataLabels { get; set; }
		private PlotOptionsPieDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// The thickness of a 3D pie. Requires <code>highcharts-3d.js</code>
		/// </summary>
		public double? Depth { get; set; }
		private double? Depth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// The end angle of the pie in degrees where 0 is top and 90 is right. Defaults to <code>startAngle</code> plus 360.
		/// </summary>
		public double? EndAngle { get; set; }
		private double? EndAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieEvents Events { get; set; }
		private PlotOptionsPieEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Equivalent to <a href="#chart.ignoreHiddenSeries">chart.ignoreHiddenSeries</a>, this option tells whether the series shall be redrawn as if the hidden point were <code>null</code>.</p><p>The default value changed from <code>false</code> to <code>true</code> with Highcharts 3.0.</p>
		/// </summary>
		public bool? IgnoreHiddenPoint { get; set; }
		private bool? IgnoreHiddenPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// The size of the inner diameter for the pie. A size greater than 0 renders a donut chart. Can be a percentage or pixel value. Percentages are relative to the size of the plot area. Pixel values are given as integers.
		/// </summary>
		public string InnerSize { get; set; }
		private string InnerSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The <a href="#series.id">id</a> of another series to link to. Additionally, the value can be ":previous" to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum size for a pie in response to auto margins. The pie will try to shrink to make room for data labels in side the plot area, but only to this size.
		/// </summary>
		public double? MinSize { get; set; }
		private double? MinSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point
		/// </summary>
		public PlotOptionsPiePoint Point { get; set; }
		private PlotOptionsPiePoint Point_DefaultValue { get; set; }
		 

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
		/// Whether to display this particular series or series type in the legend. Since 2.1, pies are not shown in the legend by default.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// The diameter of the pie relative to the plot area. Can be a percentage or pixel value. Pixel values are given as integers. The default behaviour (as of 3.0) is to scale to the plot area and give room for data labels within the plot area. As a consequence, the size of the pie may vary when points are updated and data labels more around. In that case it is best to set a fixed value, for example <code>"75%"</code>.
		/// </summary>
		public string Size { get; set; }
		private string Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// If a point is sliced, moved out from the center, how many pixels should  it be moved?.
		/// </summary>
		public double? SlicedOffset { get; set; }
		private double? SlicedOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// The start angle of the pie slices in degrees where 0 is top and 90 right. 
		/// </summary>
		public double? StartAngle { get; set; }
		private double? StartAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsPieStates States { get; set; }
		private PlotOptionsPieStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When <code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the  tooltip will be hidden when moving the mouse between series.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level.
		/// </summary>
		public PlotOptionsPieTooltip Tooltip { get; set; }
		private PlotOptionsPieTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (Animation.IsDirty()) h.Add("animation",Animation.ToJSON());
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highstock.FirstCharacterToLower(Cursor.ToString()));
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Depth != Depth_DefaultValue) h.Add("depth",Depth);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (EndAngle != EndAngle_DefaultValue) h.Add("endAngle",EndAngle);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (IgnoreHiddenPoint != IgnoreHiddenPoint_DefaultValue) h.Add("ignoreHiddenPoint",IgnoreHiddenPoint);
			if (InnerSize != InnerSize_DefaultValue) h.Add("innerSize",InnerSize);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (MinSize != MinSize_DefaultValue) h.Add("minSize",MinSize);
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (SlicedOffset != SlicedOffset_DefaultValue) h.Add("slicedOffset",SlicedOffset);
			if (StartAngle != StartAngle_DefaultValue) h.Add("startAngle",StartAngle);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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
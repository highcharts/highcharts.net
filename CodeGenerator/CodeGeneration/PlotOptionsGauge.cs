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
	public partial class PlotOptionsGauge
	{
		public PlotOptionsGauge()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Color = Color_DefaultValue = null;
			Cursor = Cursor_DefaultValue = PlotOptionsGaugeCursor.Null;
			DataLabels = DataLabels_DefaultValue = new PlotOptionsGaugeDataLabels();
			Dial = Dial_DefaultValue = new PlotOptionsGaugeDial();
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			Events = Events_DefaultValue = new PlotOptionsGaugeEvents();
			LinkedTo = LinkedTo_DefaultValue = "";
			NegativeColor = NegativeColor_DefaultValue = "null";
			Overshoot = Overshoot_DefaultValue = 0;
			Pivot = Pivot_DefaultValue = new PlotOptionsGaugePivot();
			Point = Point_DefaultValue = new PlotOptionsGaugePoint();
			Selected = Selected_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			ShowInLegend = ShowInLegend_DefaultValue = null;
			States = States_DefaultValue = new PlotOptionsGaugeStates();
			StickyTracking = StickyTracking_DefaultValue = true;
			Threshold = Threshold_DefaultValue = 0;
			Tooltip = Tooltip_DefaultValue = new PlotOptionsGaugeTooltip();
			Visible = Visible_DefaultValue = true;
			Wrap = Wrap_DefaultValue = true;
			
		}	
		

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
		/// You can set the cursor to "pointer" if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.
		/// </summary>
		public PlotOptionsGaugeCursor Cursor { get; set; }
		private PlotOptionsGaugeCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Data labels for the gauge. For gauges, the data labels are enabled by default and shown in a bordered box below the point.
		/// </summary>
		public PlotOptionsGaugeDataLabels DataLabels { get; set; }
		private PlotOptionsGaugeDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the dial or arrow pointer of the gauge.
		/// </summary>
		public PlotOptionsGaugeDial Dial { get; set; }
		private PlotOptionsGaugeDial Dial_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsGaugeEvents Events { get; set; }
		private PlotOptionsGaugeEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// The <a href="#series.id">id</a> of another series to link to. Additionally, the value can be ":previous" to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color for the parts of the graph or points that are below the <a href="#plotOptions.series.threshold">threshold</a>.
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow the dial to overshoot the end of the perimeter axis by this many degrees. Say if the gauge axis goes from 0 to 60, a value of 100, or 1000, will show 5 degrees beyond the end of the axis.
		/// </summary>
		public double? Overshoot { get; set; }
		private double? Overshoot_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the pivot or the center point of the gauge.
		/// </summary>
		public PlotOptionsGaugePivot Pivot { get; set; }
		private PlotOptionsGaugePivot Pivot_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point
		/// </summary>
		public PlotOptionsGaugePoint Point { get; set; }
		private PlotOptionsGaugePoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If <code>showCheckbox</code> is true, the checkbox next to the series name will be checked for a selected series.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allow selecting the series. The state of the checkbox is determined by the <code>selected</code> option.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		private bool? ShowCheckbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in the legend. Defaults to false for gauge series.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsGaugeStates States { get; set; }
		private PlotOptionsGaugeStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When <code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the  tooltip will be hidden when moving the mouse between series. Defaults to true for line and area type series, but to false for columns, pies etc.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// The threshold, also called zero level or base level. For line type series this is only used in conjunction with <a href="#plotOptions.series.negativeColor">negativeColor</a>.
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level.
		/// </summary>
		public PlotOptionsGaugeTooltip Tooltip { get; set; }
		private PlotOptionsGaugeTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this option is <code>true</code>, the dial will wrap around the axes. For instance, in a full-range gauge going from 0 to 360, a value of 400 will point to 40. When <code>wrap</code> is <code>false</code>, the dial stops at 360.
		/// </summary>
		public bool? Wrap { get; set; }
		private bool? Wrap_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Dial.IsDirty()) h.Add("dial",Dial.ToHashtable());
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (Overshoot != Overshoot_DefaultValue) h.Add("overshoot",Overshoot);
			if (Pivot.IsDirty()) h.Add("pivot",Pivot.ToHashtable());
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (Wrap != Wrap_DefaultValue) h.Add("wrap",Wrap);
			

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
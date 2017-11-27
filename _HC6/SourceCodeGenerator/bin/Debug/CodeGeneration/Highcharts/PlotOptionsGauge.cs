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
	public partial class PlotOptionsGauge  : BaseObject
	{
		public PlotOptionsGauge()
		{
			Dial = Dial_DefaultValue = null;
			Pivot = Pivot_DefaultValue = null;
			Tooltip = Tooltip_DefaultValue = null;
			ShowInLegend = ShowInLegend_DefaultValue = False;
			Overshoot = Overshoot_DefaultValue = 0;
			Wrap = Wrap_DefaultValue = true;
			DataLabels = DataLabels_DefaultValue = "";
			Enabled = Enabled_DefaultValue = True;
			Defer = Defer_DefaultValue = False;
			Y = Y_DefaultValue = 15;
			BorderRadius = BorderRadius_DefaultValue = 3;
			Crop = Crop_DefaultValue = False;
			VerticalAlign = VerticalAlign_DefaultValue = "top";
			ZIndex = ZIndex_DefaultValue = 2;
			BorderWidth = BorderWidth_DefaultValue = 1;
			BorderColor = BorderColor_DefaultValue = "#cccccc";
			Dial = Dial_DefaultValue = "";
			BaseLength = BaseLength_DefaultValue = "70%";
			BaseWidth = BaseWidth_DefaultValue = 3;
			Radius = Radius_DefaultValue = "80%";
			RearLength = RearLength_DefaultValue = "10%";
			TopWidth = TopWidth_DefaultValue = 1;
			BackgroundColor = BackgroundColor_DefaultValue = "#000000";
			BorderColor = BorderColor_DefaultValue = "#cccccc";
			BorderWidth = BorderWidth_DefaultValue = 0;
			Pivot = Pivot_DefaultValue = "";
			Radius = Radius_DefaultValue = 5;
			BorderWidth = BorderWidth_DefaultValue = 0;
			BorderColor = BorderColor_DefaultValue = "#cccccc";
			BackgroundColor = BackgroundColor_DefaultValue = "#000000";
			Tooltip = Tooltip_DefaultValue = "";
			HeaderFormat = HeaderFormat_DefaultValue = "";
			ShowInLegend = ShowInLegend_DefaultValue = False;
			Overshoot = Overshoot_DefaultValue = 0;
			Wrap = Wrap_DefaultValue = true;
			
		}	
		

		/// <summary>
		/// Options for the dial or arrow pointer of the gauge.In styled mode, the dial is styled with the `.highcharts-gauge-series .highcharts-dial` rule.
		/// </summary>
		public PlotOptionsGaugeDial Dial { get; set; }
		private PlotOptionsGaugeDial Dial_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the pivot or the center point of the gauge.In styled mode, the pivot is styled with the `.highcharts-gauge-series .highcharts-pivot` rule.
		/// </summary>
		public PlotOptionsGaugePivot Pivot { get; set; }
		private PlotOptionsGaugePivot Pivot_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsGaugeTooltip Tooltip { get; set; }
		private PlotOptionsGaugeTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in thelegend. Defaults to false for gauge series.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow the dial to overshoot the end of the perimeter axis by thismany degrees. Say if the gauge axis goes from 0 to 60, a value of100, or 1000, will show 5 degrees beyond the end of the axis.
		/// </summary>
		public double? Overshoot { get; set; }
		private double? Overshoot_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this option is `true`, the dial will wrap around the axes. Forinstance, in a full-range gauge going from 0 to 360, a value of 400will point to 40\. When `wrap` is `false`, the dial stops at 360.
		/// </summary>
		public bool? Wrap { get; set; }
		private bool? Wrap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Data labels for the gauge. For gauges, the data labels are enabledby default and shown in a bordered box below the point.
		/// </summary>
		public PlotOptionsGaugeDataLabels DataLabels { get; set; }
		private PlotOptionsGaugeDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the data labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsGaugeDefer Defer { get; set; }
		private PlotOptionsGaugeDefer Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the center of thegauge.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border radius in pixels for the gauge's data label.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsGaugeCrop Crop { get; set; }
		private PlotOptionsGaugeCrop Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the data label.
		/// </summary>
		public string VerticalAlign { get; set; }
		private string VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the data labels. A value of 2 display them behindthe dial.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width in pixels for the gauge data label.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the data label.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the dial or arrow pointer of the gauge.In styled mode, the dial is styled with the `.highcharts-gauge-series .highcharts-dial` rule.
		/// </summary>
		public PlotOptionsGaugeDial Dial { get; set; }
		private PlotOptionsGaugeDial Dial_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the dial's base part, relative to the total radiusor length of the dial.
		/// </summary>
		public string BaseLength { get; set; }
		private string BaseLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the base of the gauge dial. The base is the partclosest to the pivot, defined by baseLength.
		/// </summary>
		public double? BaseWidth { get; set; }
		private double? BaseWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius or length of the dial, in percentages relative to theradius of the gauge itself.
		/// </summary>
		public string Radius { get; set; }
		private string Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the dial's rear end, the part that extends out on theother side of the pivot. Relative to the dial's length.
		/// </summary>
		public string RearLength { get; set; }
		private string RearLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the top of the dial, closest to the perimeter. The pivotnarrows in from the base to the top.
		/// </summary>
		public double? TopWidth { get; set; }
		private double? TopWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background or fill color of the gauge's dial.
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color or stroke of the gauge's dial. By default, the borderWidthis 0, so this must be set in addition to a custom border color.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the gauge dial border in pixels.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the pivot or the center point of the gauge.In styled mode, the pivot is styled with the `.highcharts-gauge-series .highcharts-pivot` rule.
		/// </summary>
		public PlotOptionsGaugePivot Pivot { get; set; }
		private PlotOptionsGaugePivot Pivot_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel radius of the pivot.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border or stroke width of the pivot.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border or stroke color of the pivot. In able to change this,the borderWidth must also be set to something other than the default0.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background color or fill of the pivot.
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsGaugeTooltip Tooltip { get; set; }
		private PlotOptionsGaugeTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsGaugeHeaderFormat HeaderFormat { get; set; }
		private PlotOptionsGaugeHeaderFormat HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in thelegend. Defaults to false for gauge series.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow the dial to overshoot the end of the perimeter axis by thismany degrees. Say if the gauge axis goes from 0 to 60, a value of100, or 1000, will show 5 degrees beyond the end of the axis.
		/// </summary>
		public double? Overshoot { get; set; }
		private double? Overshoot_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this option is `true`, the dial will wrap around the axes. Forinstance, in a full-range gauge going from 0 to 360, a value of 400will point to 40\. When `wrap` is `false`, the dial stops at 360.
		/// </summary>
		public bool? Wrap { get; set; }
		private bool? Wrap_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Dial.IsDirty()) h.Add("dial",Dial.ToHashtable());
			if (Pivot.IsDirty()) h.Add("pivot",Pivot.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (Overshoot != Overshoot_DefaultValue) h.Add("overshoot",Overshoot);
			if (Wrap != Wrap_DefaultValue) h.Add("wrap",Wrap);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Dial.IsDirty()) h.Add("dial",Dial.ToHashtable());
			if (BaseLength != BaseLength_DefaultValue) h.Add("baseLength",BaseLength);
			if (BaseWidth != BaseWidth_DefaultValue) h.Add("baseWidth",BaseWidth);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (RearLength != RearLength_DefaultValue) h.Add("rearLength",RearLength);
			if (TopWidth != TopWidth_DefaultValue) h.Add("topWidth",TopWidth);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Pivot.IsDirty()) h.Add("pivot",Pivot.ToHashtable());
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (Overshoot != Overshoot_DefaultValue) h.Add("overshoot",Overshoot);
			if (Wrap != Wrap_DefaultValue) h.Add("wrap",Wrap);
			

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
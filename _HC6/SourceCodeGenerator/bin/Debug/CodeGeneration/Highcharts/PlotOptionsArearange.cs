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
	public partial class PlotOptionsArearange  : BaseObject
	{
		public PlotOptionsArearange()
		{
			LineWidth = LineWidth_DefaultValue = 1;
			Threshold = Threshold_DefaultValue = null;
			Tooltip = Tooltip_DefaultValue = null;
			TrackByArea = TrackByArea_DefaultValue = true;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			LineWidth = LineWidth_DefaultValue = 1;
			Threshold = Threshold_DefaultValue = null;
			Tooltip = Tooltip_DefaultValue = "";
			PointFormat = PointFormat_DefaultValue = <span style="color:{series.color}">●</span> {series.name}: <b>{point.low}</b> - <b>{point.high}</b><br/>;
			TrackByArea = TrackByArea_DefaultValue = true;
			DataLabels = DataLabels_DefaultValue = "";
			Align = Align_DefaultValue = "";
			VerticalAlign = VerticalAlign_DefaultValue = "";
			XLow = XLow_DefaultValue = 0;
			XHigh = XHigh_DefaultValue = 0;
			YLow = YLow_DefaultValue = 16;
			YHigh = YHigh_DefaultValue = -6;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			Align = Align_DefaultValue = "";
			VerticalAlign = VerticalAlign_DefaultValue = "";
			XLow = XLow_DefaultValue = 0;
			XHigh = XHigh_DefaultValue = 0;
			YLow = YLow_DefaultValue = 16;
			YHigh = YHigh_DefaultValue = -6;
			
		}	
		

		/// <summary>
		/// Pixel width of the arearange graph line.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsArearangeThreshold Threshold { get; set; }
		private PlotOptionsArearangeThreshold Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsArearangeTooltip Tooltip { get; set; }
		private PlotOptionsArearangeTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the whole area or just the line should respond to mouseovertooltips and other mouse or touch events.
		/// </summary>
		public bool? TrackByArea { get; set; }
		private bool? TrackByArea_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 the shadowcan be an object configuration containing `color`, `offsetX`, `offsetY`, `opacity` and `width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel width of the arearange graph line.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsArearangeThreshold Threshold { get; set; }
		private PlotOptionsArearangeThreshold Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsArearangeTooltip Tooltip { get; set; }
		private PlotOptionsArearangeTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsArearangePointFormat PointFormat { get; set; }
		private PlotOptionsArearangePointFormat PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the whole area or just the line should respond to mouseovertooltips and other mouse or touch events.
		/// </summary>
		public bool? TrackByArea { get; set; }
		private bool? TrackByArea_DefaultValue { get; set; }
		 

		/// <summary>
		/// Extended data labels for range series types. Range series data labelshave no `x` and `y` options. Instead, they have `xLow`, `xHigh`,`yLow` and `yHigh` options to allow the higher and lower data labelsets individually.
		/// </summary>
		public PlotOptionsArearangeDataLabels DataLabels { get; set; }
		private PlotOptionsArearangeDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsArearangeAlign Align { get; set; }
		private PlotOptionsArearangeAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsArearangeVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsArearangeVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// X offset of the lower data labels relative to the point value.
		/// </summary>
		public double? XLow { get; set; }
		private double? XLow_DefaultValue { get; set; }
		 

		/// <summary>
		/// X offset of the higher data labels relative to the point value.
		/// </summary>
		public double? XHigh { get; set; }
		private double? XHigh_DefaultValue { get; set; }
		 

		/// <summary>
		/// Y offset of the lower data labels relative to the point value.
		/// </summary>
		public double? YLow { get; set; }
		private double? YLow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Y offset of the higher data labels relative to the point value.
		/// </summary>
		public double? YHigh { get; set; }
		private double? YHigh_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 the shadowcan be an object configuration containing `color`, `offsetX`, `offsetY`, `opacity` and `width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsArearangeAlign Align { get; set; }
		private PlotOptionsArearangeAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsArearangeVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsArearangeVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// X offset of the lower data labels relative to the point value.
		/// </summary>
		public double? XLow { get; set; }
		private double? XLow_DefaultValue { get; set; }
		 

		/// <summary>
		/// X offset of the higher data labels relative to the point value.
		/// </summary>
		public double? XHigh { get; set; }
		private double? XHigh_DefaultValue { get; set; }
		 

		/// <summary>
		/// Y offset of the lower data labels relative to the point value.
		/// </summary>
		public double? YLow { get; set; }
		private double? YLow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Y offset of the higher data labels relative to the point value.
		/// </summary>
		public double? YHigh { get; set; }
		private double? YHigh_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (TrackByArea != TrackByArea_DefaultValue) h.Add("trackByArea",TrackByArea);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (TrackByArea != TrackByArea_DefaultValue) h.Add("trackByArea",TrackByArea);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (XLow != XLow_DefaultValue) h.Add("xLow",XLow);
			if (XHigh != XHigh_DefaultValue) h.Add("xHigh",XHigh);
			if (YLow != YLow_DefaultValue) h.Add("yLow",YLow);
			if (YHigh != YHigh_DefaultValue) h.Add("yHigh",YHigh);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (XLow != XLow_DefaultValue) h.Add("xLow",XLow);
			if (XHigh != XHigh_DefaultValue) h.Add("xHigh",XHigh);
			if (YLow != YLow_DefaultValue) h.Add("yLow",YLow);
			if (YHigh != YHigh_DefaultValue) h.Add("yHigh",YHigh);
			

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
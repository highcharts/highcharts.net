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
	public partial class PlotOptionsBoxplot  : BaseObject
	{
		public PlotOptionsBoxplot()
		{
			Threshold = Threshold_DefaultValue = null;
			Tooltip = Tooltip_DefaultValue = null;
			WhiskerLength = WhiskerLength_DefaultValue = 50%;
			FillColor = FillColor_DefaultValue = null;
			LineWidth = LineWidth_DefaultValue = 1;
			MedianWidth = MedianWidth_DefaultValue = 2;
			States = States_DefaultValue = null;
			WhiskerWidth = WhiskerWidth_DefaultValue = 2;
			MedianColor = MedianColor_DefaultValue = "null";
			StemColor = StemColor_DefaultValue = "null";
			StemDashStyle = StemDashStyle_DefaultValue = "Solid";
			StemWidth = StemWidth_DefaultValue = null;
			WhiskerColor = WhiskerColor_DefaultValue = "null";
			Threshold = Threshold_DefaultValue = "";
			Tooltip = Tooltip_DefaultValue = "";
			PointFormat = PointFormat_DefaultValue = "";
			WhiskerLength = WhiskerLength_DefaultValue = 50%;
			FillColor = FillColor_DefaultValue = null;
			LineWidth = LineWidth_DefaultValue = 1;
			MedianWidth = MedianWidth_DefaultValue = 2;
			States = States_DefaultValue = "";
			Hover = Hover_DefaultValue = "";
			Brightness = Brightness_DefaultValue = 0;
			WhiskerWidth = WhiskerWidth_DefaultValue = 2;
			MedianColor = MedianColor_DefaultValue = "null";
			StemColor = StemColor_DefaultValue = "null";
			StemDashStyle = StemDashStyle_DefaultValue = "Solid";
			StemWidth = StemWidth_DefaultValue = null;
			WhiskerColor = WhiskerColor_DefaultValue = "null";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBoxplotThreshold Threshold { get; set; }
		private PlotOptionsBoxplotThreshold Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBoxplotTooltip Tooltip { get; set; }
		private PlotOptionsBoxplotTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the whiskers, the horizontal lines marking low andhigh values. It can be a numerical pixel value, or a percentagevalue of the box width. Set `0` to disable whiskers.
		/// </summary>
		public double? WhiskerLength { get; set; }
		private double? WhiskerLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of the box.
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the line surrounding the box. If any of [stemWidth](#plotOptions.boxplot.stemWidth), [medianWidth](#plotOptions.boxplot.medianWidth)or [whiskerWidth](#plotOptions.boxplot.whiskerWidth) are `null`, the lineWidth also applies to these lines.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the median line. If `null`, the [lineWidth](#plotOptions.boxplot.lineWidth) is used.
		/// </summary>
		public double? MedianWidth { get; set; }
		private double? MedianWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBoxplotStates States { get; set; }
		private PlotOptionsBoxplotStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line width of the whiskers, the horizontal lines marking lowand high values. When `null`, the general [lineWidth](#plotOptions.boxplot.lineWidth) applies.
		/// </summary>
		public double? WhiskerWidth { get; set; }
		private double? WhiskerWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the median line. If `null`, the general series colorapplies.
		/// </summary>
		public string MedianColor { get; set; }
		private string MedianColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the stem, the vertical line extending from the box tothe whiskers. If `null`, the series color is used.
		/// </summary>
		public string StemColor { get; set; }
		private string StemColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash style of the stem, the vertical line extending from thebox to the whiskers.
		/// </summary>
		public string StemDashStyle { get; set; }
		private string StemDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the stem, the vertical line extending from the box tothe whiskers. If `null`, the width is inherited from the [lineWidth](#plotOptions.boxplot.lineWidth) option.
		/// </summary>
		public double? StemWidth { get; set; }
		private double? StemWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the whiskers, the horizontal lines marking low and highvalues. When `null`, the general series color is used.
		/// </summary>
		public string WhiskerColor { get; set; }
		private string WhiskerColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBoxplotThreshold Threshold { get; set; }
		private PlotOptionsBoxplotThreshold Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBoxplotTooltip Tooltip { get; set; }
		private PlotOptionsBoxplotTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBoxplotPointFormat PointFormat { get; set; }
		private PlotOptionsBoxplotPointFormat PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the whiskers, the horizontal lines marking low andhigh values. It can be a numerical pixel value, or a percentagevalue of the box width. Set `0` to disable whiskers.
		/// </summary>
		public double? WhiskerLength { get; set; }
		private double? WhiskerLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of the box.
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the line surrounding the box. If any of [stemWidth](#plotOptions.boxplot.stemWidth), [medianWidth](#plotOptions.boxplot.medianWidth)or [whiskerWidth](#plotOptions.boxplot.whiskerWidth) are `null`, the lineWidth also applies to these lines.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the median line. If `null`, the [lineWidth](#plotOptions.boxplot.lineWidth) is used.
		/// </summary>
		public double? MedianWidth { get; set; }
		private double? MedianWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBoxplotStates States { get; set; }
		private PlotOptionsBoxplotStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBoxplotHover Hover { get; set; }
		private PlotOptionsBoxplotHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBoxplotBrightness Brightness { get; set; }
		private PlotOptionsBoxplotBrightness Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line width of the whiskers, the horizontal lines marking lowand high values. When `null`, the general [lineWidth](#plotOptions.boxplot.lineWidth) applies.
		/// </summary>
		public double? WhiskerWidth { get; set; }
		private double? WhiskerWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the median line. If `null`, the general series colorapplies.
		/// </summary>
		public string MedianColor { get; set; }
		private string MedianColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the stem, the vertical line extending from the box tothe whiskers. If `null`, the series color is used.
		/// </summary>
		public string StemColor { get; set; }
		private string StemColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash style of the stem, the vertical line extending from thebox to the whiskers.
		/// </summary>
		public string StemDashStyle { get; set; }
		private string StemDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the stem, the vertical line extending from the box tothe whiskers. If `null`, the width is inherited from the [lineWidth](#plotOptions.boxplot.lineWidth) option.
		/// </summary>
		public double? StemWidth { get; set; }
		private double? StemWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the whiskers, the horizontal lines marking low and highvalues. When `null`, the general series color is used.
		/// </summary>
		public string WhiskerColor { get; set; }
		private string WhiskerColor_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (WhiskerLength != WhiskerLength_DefaultValue) h.Add("whiskerLength",WhiskerLength);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (MedianWidth != MedianWidth_DefaultValue) h.Add("medianWidth",MedianWidth);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (WhiskerWidth != WhiskerWidth_DefaultValue) h.Add("whiskerWidth",WhiskerWidth);
			if (MedianColor != MedianColor_DefaultValue) h.Add("medianColor",MedianColor);
			if (StemColor != StemColor_DefaultValue) h.Add("stemColor",StemColor);
			if (StemDashStyle != StemDashStyle_DefaultValue) h.Add("stemDashStyle",StemDashStyle);
			if (StemWidth != StemWidth_DefaultValue) h.Add("stemWidth",StemWidth);
			if (WhiskerColor != WhiskerColor_DefaultValue) h.Add("whiskerColor",WhiskerColor);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (WhiskerLength != WhiskerLength_DefaultValue) h.Add("whiskerLength",WhiskerLength);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (MedianWidth != MedianWidth_DefaultValue) h.Add("medianWidth",MedianWidth);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (WhiskerWidth != WhiskerWidth_DefaultValue) h.Add("whiskerWidth",WhiskerWidth);
			if (MedianColor != MedianColor_DefaultValue) h.Add("medianColor",MedianColor);
			if (StemColor != StemColor_DefaultValue) h.Add("stemColor",StemColor);
			if (StemDashStyle != StemDashStyle_DefaultValue) h.Add("stemDashStyle",StemDashStyle);
			if (StemWidth != StemWidth_DefaultValue) h.Add("stemWidth",StemWidth);
			if (WhiskerColor != WhiskerColor_DefaultValue) h.Add("whiskerColor",WhiskerColor);
			

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
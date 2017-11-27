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
	public partial class PlotOptionsHeatmap  : BaseObject
	{
		public PlotOptionsHeatmap()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			BorderWidth = BorderWidth_DefaultValue = 0;
			NullColor = NullColor_DefaultValue = "#f7f7f7";
			Tooltip = Tooltip_DefaultValue = null;
			States = States_DefaultValue = null;
			PointPadding = PointPadding_DefaultValue = 0;
			Color = Color_DefaultValue = "null";
			Colsize = Colsize_DefaultValue = 1;
			Rowsize = Rowsize_DefaultValue = 1;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			BorderWidth = BorderWidth_DefaultValue = 0;
			NullColor = NullColor_DefaultValue = "#f7f7f7";
			DataLabels = DataLabels_DefaultValue = "";
			Formatter = Formatter_DefaultValue = "";
			Inside = Inside_DefaultValue = True;
			VerticalAlign = VerticalAlign_DefaultValue = middle;
			Crop = Crop_DefaultValue = False;
			Overflow = Overflow_DefaultValue = False;
			Padding = Padding_DefaultValue = 0;
			Tooltip = Tooltip_DefaultValue = "";
			PointFormat = PointFormat_DefaultValue = {point.x}, {point.y}: {point.value}<br/>;
			States = States_DefaultValue = "";
			Normal = Normal_DefaultValue = "";
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Hover = Hover_DefaultValue = "";
			Halo = Halo_DefaultValue = False;
			Brightness = Brightness_DefaultValue = 0.2;
			PointPadding = PointPadding_DefaultValue = 0;
			Color = Color_DefaultValue = "null";
			Colsize = Colsize_DefaultValue = 1;
			Rowsize = Rowsize_DefaultValue = 1;
			
		}	
		

		/// <summary>
		/// Animation is disabled by default on the heatmap series.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width for each heat map item.
		/// </summary>
		public PlotOptionsHeatmapBorderWidth BorderWidth { get; set; }
		private PlotOptionsHeatmapBorderWidth BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color applied to null points. In styled mode, a general CSS class isapplied instead.
		/// </summary>
		public string NullColor { get; set; }
		private string NullColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapTooltip Tooltip { get; set; }
		private PlotOptionsHeatmapTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapStates States { get; set; }
		private PlotOptionsHeatmapStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding between the points in the heatmap.
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color of the series. In heat maps this color is rarely used,as we mostly use the color to denote the value of each point. Unlessoptions are set in the [colorAxis](#colorAxis), the default valueis pulled from the [options.colors](#colors) array.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The column size - how many X axis units each column in the heatmapshould span.
		/// </summary>
		public double? Colsize { get; set; }
		private double? Colsize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The row size - how many Y axis units each heatmap row should span.
		/// </summary>
		public double? Rowsize { get; set; }
		private double? Rowsize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Animation is disabled by default on the heatmap series.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width for each heat map item.
		/// </summary>
		public PlotOptionsHeatmapBorderWidth BorderWidth { get; set; }
		private PlotOptionsHeatmapBorderWidth BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color applied to null points. In styled mode, a general CSS class isapplied instead.
		/// </summary>
		public string NullColor { get; set; }
		private string NullColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapDataLabels DataLabels { get; set; }
		private PlotOptionsHeatmapDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapFormatter Formatter { get; set; }
		private PlotOptionsHeatmapFormatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapInside Inside { get; set; }
		private PlotOptionsHeatmapInside Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsHeatmapVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapCrop Crop { get; set; }
		private PlotOptionsHeatmapCrop Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapOverflow Overflow { get; set; }
		private PlotOptionsHeatmapOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapPadding Padding { get; set; }
		private PlotOptionsHeatmapPadding Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapTooltip Tooltip { get; set; }
		private PlotOptionsHeatmapTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapPointFormat PointFormat { get; set; }
		private PlotOptionsHeatmapPointFormat PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapStates States { get; set; }
		private PlotOptionsHeatmapStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapNormal Normal { get; set; }
		private PlotOptionsHeatmapNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapHover Hover { get; set; }
		private PlotOptionsHeatmapHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapHalo Halo { get; set; }
		private PlotOptionsHeatmapHalo Halo_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapBrightness Brightness { get; set; }
		private PlotOptionsHeatmapBrightness Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding between the points in the heatmap.
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color of the series. In heat maps this color is rarely used,as we mostly use the color to denote the value of each point. Unlessoptions are set in the [colorAxis](#colorAxis), the default valueis pulled from the [options.colors](#colors) array.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The column size - how many X axis units each column in the heatmapshould span.
		/// </summary>
		public double? Colsize { get; set; }
		private double? Colsize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The row size - how many Y axis units each heatmap row should span.
		/// </summary>
		public double? Rowsize { get; set; }
		private double? Rowsize_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (NullColor != NullColor_DefaultValue) h.Add("nullColor",NullColor);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Colsize != Colsize_DefaultValue) h.Add("colsize",Colsize);
			if (Rowsize != Rowsize_DefaultValue) h.Add("rowsize",Rowsize);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (NullColor != NullColor_DefaultValue) h.Add("nullColor",NullColor);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow",Overflow);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Normal.IsDirty()) h.Add("normal",Normal.ToHashtable());
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Halo != Halo_DefaultValue) h.Add("halo",Halo);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Colsize != Colsize_DefaultValue) h.Add("colsize",Colsize);
			if (Rowsize != Rowsize_DefaultValue) h.Add("rowsize",Rowsize);
			

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
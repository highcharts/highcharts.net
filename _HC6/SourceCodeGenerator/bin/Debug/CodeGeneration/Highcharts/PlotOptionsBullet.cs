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
	public partial class PlotOptionsBullet  : BaseObject
	{
		public PlotOptionsBullet()
		{
			TargetOptions = TargetOptions_DefaultValue = null;
			Tooltip = Tooltip_DefaultValue = null;
			TargetOptions = TargetOptions_DefaultValue = "";
			Width = Width_DefaultValue = 140%;
			Height = Height_DefaultValue = 3;
			BorderWidth = BorderWidth_DefaultValue = 0;
			BorderColor = BorderColor_DefaultValue = "";
			Color = Color_DefaultValue = "";
			Tooltip = Tooltip_DefaultValue = "";
			PointFormat = PointFormat_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// All options related with look and positiong of targets.
		/// </summary>
		public PlotOptionsBulletTargetOptions TargetOptions { get; set; }
		private PlotOptionsBulletTargetOptions TargetOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBulletTooltip Tooltip { get; set; }
		private PlotOptionsBulletTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// All options related with look and positiong of targets.
		/// </summary>
		public PlotOptionsBulletTargetOptions TargetOptions { get; set; }
		private PlotOptionsBulletTargetOptions TargetOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the rectangle representing the target. Could be set asa pixel value or as a percentage of a column width.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the rectangle representing the target.
		/// </summary>
		public PlotOptionsBulletHeight Height { get; set; }
		private PlotOptionsBulletHeight Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width of the rectangle representing the target.In styled mode, use class `highcharts-bullet-target` instead.
		/// </summary>
		public PlotOptionsBulletBorderWidth BorderWidth { get; set; }
		private PlotOptionsBulletBorderWidth BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color of the rectangle representing the target. Whennot set, the  point's border color is used.In styled mode, use class `highcharts-bullet-target` instead.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the rectangle representing the target. When not set,point's color (if set in point's options -[`color`](#series.bullet.data.color)) or zone of the target value(if [`zones`](#plotOptions.bullet.zones) or[`negativeColor`](#plotOptions.bullet.negativeColor) are set)or the same color as the point has is used.In styled mode, use class `highcharts-bullet-target` instead.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBulletTooltip Tooltip { get; set; }
		private PlotOptionsBulletTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBulletPointFormat PointFormat { get; set; }
		private PlotOptionsBulletPointFormat PointFormat_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (TargetOptions.IsDirty()) h.Add("targetOptions",TargetOptions.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (TargetOptions.IsDirty()) h.Add("targetOptions",TargetOptions.ToHashtable());
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			

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
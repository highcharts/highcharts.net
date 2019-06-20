using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class PlotOptionsBulletTargetOptions  : BaseObject
	{
		public PlotOptionsBulletTargetOptions()
		{
			BorderColor = BorderColor_DefaultValue = "";
			BorderWidth = BorderWidth_DefaultValue = 0;
			Color = Color_DefaultValue = "";
			Height = Height_DefaultValue = 3;
			Width = Width_DefaultValue = "140%";
			
		}	
		

		/// <summary>
		/// The border color of the rectangle representing the target. Whennot set, the  point's border color is used.In styled mode, use class `highcharts-bullet-target` instead.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width of the rectangle representing the target.In styled mode, use class `highcharts-bullet-target` instead.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the rectangle representing the target. When not set,point's color (if set in point's options -[`color`](#series.bullet.data.color)) or zone of the target value(if [`zones`](#plotOptions.bullet.zones) or[`negativeColor`](#plotOptions.bullet.negativeColor) are set)or the same color as the point has is used.In styled mode, use class `highcharts-bullet-target` instead.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the rectangle representing the target.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the rectangle representing the target. Could be setas a pixel value or as a percentage of a column width.
		/// </summary>
		public string Width { get; set; }
		private string Width_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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
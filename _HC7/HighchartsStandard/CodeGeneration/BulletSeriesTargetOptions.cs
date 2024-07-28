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
	public partial class BulletSeriesTargetOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public BulletSeriesTargetOptions()
		{
		}	
		

		/// <summary>
		/// The border color of the rectangle representing the target. Whennot set, the point's border color is used.In styled mode, use class `highcharts-bullet-target` instead.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// The border radius of the rectangle representing the target.
		/// </summary>
		public double? BorderRadius { get; set; }
		 

		/// <summary>
		/// The border width of the rectangle representing the target.In styled mode, use class `highcharts-bullet-target` instead.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// The color of the rectangle representing the target. When not set,point's color (if set in point's options -[`color`](#series.bullet.data.color)) or zone of the target value(if [`zones`](#plotOptions.bullet.zones) or[`negativeColor`](#plotOptions.bullet.negativeColor) are set)or the same color as the point has is used.In styled mode, use class `highcharts-bullet-target` instead.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// The height of the rectangle representing the target.
		/// </summary>
		public double? Height { get; set; }
		 

		/// <summary>
		/// The width of the rectangle representing the target. Could be setas a pixel value or as a percentage of a column width.
		/// </summary>
		public string Width { get; set; }
		 

		/// <summary>
		/// The width of the rectangle representing the target. Could be setas a pixel value or as a percentage of a column width.
		/// </summary>
		public double? WidthNumber { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (Color != null) h.Add("color",Color);
			if (Height != null) h.Add("height",Height);
			if (Width != null) h.Add("width",Width);
			if (WidthNumber != null) h.Add("width",WidthNumber);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}
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
	public partial class BulletSeriesDataTargetOptions  : BaseObject
	{
		public BulletSeriesDataTargetOptions()
		{
			Width = Width_DefaultValue = "140%";
			Height = Height_DefaultValue = null;
			BorderWidth = BorderWidth_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = null;
			Color = Color_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The width of the rectangle representing the target. Could be set asa pixel value or as a percentage of a column width.</p>
		/// </summary>
		public string Width { get; set; }
		private string Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The height of the rectangle representing the target.</p>
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The border width of the rectangle representing the target.</p><p>In styled mode, use class <code>highcharts-bullet-target</code> instead.</p>
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The border color of the rectangle representing the target. Whennot set, the  point&#39;s border color is used.</p><p>In styled mode, use class <code>highcharts-bullet-target</code> instead.</p>
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the rectangle representing the target. When not set,point&#39;s color (if set in point&#39;s options -<a href="#series.bullet.data.color"><code>color</code></a>) or zone of the target value(if <a href="#plotOptions.bullet.zones"><code>zones</code></a> or<a href="#plotOptions.bullet.negativeColor"><code>negativeColor</code></a> are set)or the same color as the point has is used.</p><p>In styled mode, use class <code>highcharts-bullet-target</code> instead.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			

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
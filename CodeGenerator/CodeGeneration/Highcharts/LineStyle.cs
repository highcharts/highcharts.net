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
	public partial class LineStyle  : BaseObject
	{
		public LineStyle()
		{
			Color = Color_DefaultValue = "";
			Type = Type_DefaultValue = "";
			Width = Width_DefaultValue = "";
			ShadowColor = ShadowColor_DefaultValue = rgba(0,0,0,0);
			ShadowBlur = ShadowBlur_DefaultValue = null;
			ShadowOffsetX = ShadowOffsetX_DefaultValue = null;
			ShadowOffsetY = ShadowOffsetY_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public  Color { get; set; }
		private  Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  Type { get; set; }
		private  Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  Width { get; set; }
		private  Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// applicable to the main line (in IE8+). Color of the shadow. Supports rgba.
		/// </summary>
		public color ShadowColor { get; set; }
		private color ShadowColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// applicable to the main line (in IE8+). Blur degree of the shadow. Valid values are positive.
		/// </summary>
		public number ShadowBlur { get; set; }
		private number ShadowBlur_DefaultValue { get; set; }
		 

		/// <summary>
		/// applicable to the main line (in IE8+). Horizontal offset of the shadow. Right when positive, left when negative.
		/// </summary>
		public number ShadowOffsetX { get; set; }
		private number ShadowOffsetX_DefaultValue { get; set; }
		 

		/// <summary>
		/// applicable to the main line (in IE8+). Vertical offset of the shadow. Down when positive, up when negative.
		/// </summary>
		public number ShadowOffsetY { get; set; }
		private number ShadowOffsetY_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (ShadowColor != ShadowColor_DefaultValue) h.Add("shadowColor",ShadowColor);
			if (ShadowBlur != ShadowBlur_DefaultValue) h.Add("shadowBlur",ShadowBlur);
			if (ShadowOffsetX != ShadowOffsetX_DefaultValue) h.Add("shadowOffsetX",ShadowOffsetX);
			if (ShadowOffsetY != ShadowOffsetY_DefaultValue) h.Add("shadowOffsetY",ShadowOffsetY);
			

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
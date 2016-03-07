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
	public partial class ChordStyle  : BaseObject
	{
		public ChordStyle()
		{
			Width = Width_DefaultValue = null;
			Color = Color_DefaultValue = black;
			BorderWidth = BorderWidth_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = #999;
			
		}	
		

		/// <summary>
		/// Width of bezier curve, Only available when ribbonType is false
		/// </summary>
		public number Width { get; set; }
		private number Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of bezier curve, Only available when ribbonType is false
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Border width of ribbon shape, Only available when ribbonType is true
		/// </summary>
		public number BorderWidth { get; set; }
		private number BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Border color of ribbon shape, Only available when ribbonType is true
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			

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
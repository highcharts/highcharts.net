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
	public partial class NodeStyle  : BaseObject
	{
		public NodeStyle()
		{
			Color = Color_DefaultValue = #f08c2e;
			BorderColor = BorderColor_DefaultValue = #5182ab;
			BorderWidth = BorderWidth_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// fill color.
		/// </summary>
		public color Color { get; set; }
		private color Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// stroke color.
		/// </summary>
		public color BorderColor { get; set; }
		private color BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// width of the stroke line.
		/// </summary>
		public number BorderWidth { get; set; }
		private number BorderWidth_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			

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
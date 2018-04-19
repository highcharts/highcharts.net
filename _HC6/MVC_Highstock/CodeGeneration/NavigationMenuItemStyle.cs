using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class NavigationMenuItemStyle  : BaseObject
	{
		public NavigationMenuItemStyle()
		{
			Padding = Padding_DefaultValue = "0.5em 1em";
			Background = Background_DefaultValue = "none";
			Color = Color_DefaultValue = "#333333";
			FontSize = FontSize_DefaultValue = "";
			Transition = Transition_DefaultValue = "background 250ms, color 250ms";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Background { get; set; }
		private string Background_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defaults to `14px` on touch devices and `11px` on desktop.
		/// </summary>
		public string FontSize { get; set; }
		private string FontSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Transition { get; set; }
		private string Transition_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Background != Background_DefaultValue) h.Add("background",Background);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (FontSize != FontSize_DefaultValue) h.Add("fontSize",FontSize);
			if (Transition != Transition_DefaultValue) h.Add("transition",Transition);
			

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
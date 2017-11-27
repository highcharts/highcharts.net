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
	public partial class NavigationMenuItemHoverStyle  : BaseObject
	{
		public NavigationMenuItemHoverStyle()
		{
			Background = Background_DefaultValue = #335cad;
			Color = Color_DefaultValue = #ffffff;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public NavigationMenuItemHoverStyleBackground Background { get; set; }
		private NavigationMenuItemHoverStyleBackground Background_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigationMenuItemHoverStyleColor Color { get; set; }
		private NavigationMenuItemHoverStyleColor Color_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Background != Background_DefaultValue) h.Add("background",Background);
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
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
	public partial class NavigationMenuStyle  : BaseObject
	{
		public NavigationMenuStyle()
		{
			Border = Border_DefaultValue = 1px solid #999999;
			Background = Background_DefaultValue = #ffffff;
			Padding = Padding_DefaultValue = 5px 0;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public NavigationMenuStyleBorder Border { get; set; }
		private NavigationMenuStyleBorder Border_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigationMenuStyleBackground Background { get; set; }
		private NavigationMenuStyleBackground Background_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigationMenuStylePadding Padding { get; set; }
		private NavigationMenuStylePadding Padding_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Border != Border_DefaultValue) h.Add("border",Border);
			if (Background != Background_DefaultValue) h.Add("background",Background);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			

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
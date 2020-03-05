using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class NavigationMenuStyle  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationMenuStyle()
		{
			Background = Background_DefaultValue = "#ffffff";
			Border = Border_DefaultValue = "1px solid #999999";
			Padding = Padding_DefaultValue = "5px 0";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Background { get; set; }
		private string Background_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Border { get; set; }
		private string Border_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Background != Background_DefaultValue) h.Add("background",Background);
			if (Border != Border_DefaultValue) h.Add("border",Border);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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
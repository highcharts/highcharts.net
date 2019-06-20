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
	public partial class LegendAccessibility  : BaseObject
	{
		public LegendAccessibility()
		{
			Enabled = Enabled_DefaultValue = "";
			KeyboardNavigation = KeyboardNavigation_DefaultValue = new LegendAccessibilityKeyboardNavigation();
			
		}	
		

		/// <summary>
		/// Enable accessibility support for the legend.
		/// </summary>
		public  Enabled { get; set; }
		private  Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for keyboard navigation for the legend.
		/// </summary>
		public LegendAccessibilityKeyboardNavigation KeyboardNavigation { get; set; }
		private LegendAccessibilityKeyboardNavigation KeyboardNavigation_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (KeyboardNavigation.IsDirty()) h.Add("keyboardNavigation",KeyboardNavigation.ToHashtable());
			

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
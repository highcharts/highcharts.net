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
	public partial class AccessibilityKeyboardNavigation  : BaseObject
	{
		public AccessibilityKeyboardNavigation()
		{
			Enabled = Enabled_DefaultValue = true;
			SkipNullPoints = SkipNullPoints_DefaultValue = false;
			
		}	
		

		/// <summary>
		/// Enable keyboard navigation for the chart.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Skip null points when navigating through points with the keyboard.
		/// </summary>
		public bool? SkipNullPoints { get; set; }
		private bool? SkipNullPoints_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (SkipNullPoints != SkipNullPoints_DefaultValue) h.Add("skipNullPoints",SkipNullPoints);
			

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
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class LegendAccessibility  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LegendAccessibility()
		{
		}	
		

		/// <summary>
		/// Enable accessibility support for the legend.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Options for keyboard navigation for the legend.
		/// </summary>
		public LegendAccessibilityKeyboardNavigation KeyboardNavigation { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Enabled != null) h.Add("enabled",Enabled);
			if (KeyboardNavigation != null) h.Add("keyboardNavigation",KeyboardNavigation.ToHashtable(highcharts));
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}
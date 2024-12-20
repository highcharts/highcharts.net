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
	public partial class PlotOptionsSunburstAccessibilityKeyboardNavigation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSunburstAccessibilityKeyboardNavigation()
		{
		}	
		

		/// <summary>
		/// Enable/disable keyboard navigation support for a specific series.
		/// </summary>
		public bool? Enabled { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Enabled != null) h.Add("enabled",Enabled);
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
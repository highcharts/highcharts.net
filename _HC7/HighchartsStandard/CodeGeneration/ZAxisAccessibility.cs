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
	public partial class ZAxisAccessibility  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ZAxisAccessibility()
		{
		}	
		

		/// <summary>
		/// Description for an axis to expose to screen reader users.
		/// </summary>
		public string Description { get; set; }
		 

		/// <summary>
		/// Enable axis accessibility features, including axis information in thescreen reader information region. If this is disabled on the xAxis, thex values are not exposed to screen readers for the individual data pointsby default.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Range description for an axis. Overrides the default range description.Set to empty to disable range description for this axis.
		/// </summary>
		public string RangeDescription { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Description != null) h.Add("description",Description);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (RangeDescription != null) h.Add("rangeDescription",RangeDescription);
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
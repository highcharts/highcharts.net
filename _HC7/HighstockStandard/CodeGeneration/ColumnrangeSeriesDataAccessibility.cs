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
	public partial class ColumnrangeSeriesDataAccessibility  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColumnrangeSeriesDataAccessibility()
		{
		}	
		

		/// <summary>
		/// Provide a description of the data point, announced to screen readers.
		/// </summary>
		public string Description { get; set; }
		 

		/// <summary>
		/// Set to false to disable accessibility functionality for a specific point.The point will not be included in keyboard navigation, and will not beexposed to assistive technology.
		/// </summary>
		public bool? Enabled { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Description != null) h.Add("description",Description);
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
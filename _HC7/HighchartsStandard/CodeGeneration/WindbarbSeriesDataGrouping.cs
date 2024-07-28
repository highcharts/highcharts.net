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
	public partial class WindbarbSeriesDataGrouping  : BaseObject
	{
		Hashtable h = new Hashtable();

		public WindbarbSeriesDataGrouping()
		{
		}	
		

		/// <summary>
		/// Approximation function for the data grouping. The defaultreturns an average of wind speed and a vector average directionweighted by wind speed.
		/// </summary>
		public string Approximation { get; set; }
		 

		/// <summary>
		/// Whether to enable data grouping.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// The approximate data group width.
		/// </summary>
		public double? GroupPixelWidth { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Approximation != null) h.Add("approximation",Approximation);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (GroupPixelWidth != null) h.Add("groupPixelWidth",GroupPixelWidth);
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
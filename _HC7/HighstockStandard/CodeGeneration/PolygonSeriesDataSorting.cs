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
	public partial class PolygonSeriesDataSorting  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PolygonSeriesDataSorting()
		{
		}	
		

		/// <summary>
		/// Enable or disable data sorting for the series. Use [xAxis.reversed](#xAxis.reversed) to change the sorting order.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Whether to allow matching points by name in an update. If this optionis disabled, points will be matched by order.
		/// </summary>
		public bool? MatchByName { get; set; }
		 

		/// <summary>
		/// Determines what data value should be used to sort by.
		/// </summary>
		public string SortKey { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Enabled != null) h.Add("enabled",Enabled);
			if (MatchByName != null) h.Add("matchByName",MatchByName);
			if (SortKey != null) h.Add("sortKey",SortKey);
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
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
	public partial class PlotOptionsScatterClusterZones  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsScatterClusterZones()
		{
		}	
		

		/// <summary>
		/// Styled mode only. A custom class name for the zone.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// The value where the zone starts.
		/// </summary>
		public double? From { get; set; }
		 

		/// <summary>
		/// Settings for the cluster marker belonging to the zone.
		/// </summary>
		public PlotOptionsScatterClusterZonesMarker Marker { get; set; }
		 

		/// <summary>
		/// The value where the zone ends.
		/// </summary>
		public double? To { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ClassName != null) h.Add("className",ClassName);
			if (From != null) h.Add("from",From);
			if (Marker != null) h.Add("marker",Marker.ToHashtable(highstock));
			if (To != null) h.Add("to",To);
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
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
	public partial class PlotOptionsTreemapClusterZone  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTreemapClusterZone()
		{
			ClassName = ClassName_DefaultValue = "";
			From = From_DefaultValue = null;
			Marker = Marker_DefaultValue = new PlotOptionsTreemapClusterZonesMarker();
			To = To_DefaultValue = null;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Styled mode only. A custom class name for the zone.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value where the zone starts.
		/// </summary>
		public double? From { get; set; }
		private double? From_DefaultValue { get; set; }
		 

		/// <summary>
		/// Settings for the cluster marker belonging to the zone.
		/// </summary>
		public PlotOptionsTreemapClusterZonesMarker Marker { get; set; }
		private PlotOptionsTreemapClusterZonesMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value where the zone ends.
		/// </summary>
		public double? To { get; set; }
		private double? To_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (From != From_DefaultValue) h.Add("from",From);
			if (Marker.IsDirty(highcharts)) h.Add("marker",Marker.ToHashtable(highcharts));
			if (To != To_DefaultValue) h.Add("to",To);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}
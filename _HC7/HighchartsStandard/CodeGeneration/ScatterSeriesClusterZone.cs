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
	public partial class ScatterSeriesClusterZone  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ScatterSeriesClusterZone()
		{
			
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
		public ScatterSeriesClusterZonesMarker Marker { get; set; }
		private ScatterSeriesClusterZonesMarker Marker_DefaultValue { get; set; }
		 

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

			if (ClassName != null) h.Add("className",ClassName);
			if (From != null) h.Add("from",From);
			if (Marker != null) h.Add("marker",Marker.ToHashtable(highcharts));
			if (To != null) h.Add("to",To);
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
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
	public partial class PolygonSeriesSonificationContextTracksMappingLowpass  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PolygonSeriesSonificationContextTracksMappingLowpass()
		{
			Frequency = Frequency_DefaultValue = new PolygonSeriesSonificationContextTracksMappingLowpassFrequency();
			Resonance = Resonance_DefaultValue = new PolygonSeriesSonificationContextTracksMappingLowpassResonance();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Map to filter frequency in Hertz from 1 to 20,000Hz.
		/// </summary>
		public PolygonSeriesSonificationContextTracksMappingLowpassFrequency Frequency { get; set; }
		private PolygonSeriesSonificationContextTracksMappingLowpassFrequency Frequency_DefaultValue { get; set; }
		 

		/// <summary>
		/// Map to filter resonance in dB. Can be negative to cause adip, or positive to cause a bump.
		/// </summary>
		public PolygonSeriesSonificationContextTracksMappingLowpassResonance Resonance { get; set; }
		private PolygonSeriesSonificationContextTracksMappingLowpassResonance Resonance_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Frequency.IsDirty(highcharts)) h.Add("frequency",Frequency.ToHashtable(highcharts));
			if (Resonance.IsDirty(highcharts)) h.Add("resonance",Resonance.ToHashtable(highcharts));
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
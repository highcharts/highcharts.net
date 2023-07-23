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
	public partial class WindbarbSeriesSonificationDefaultInstrumentOptionsMappingLowpass  : BaseObject
	{
		Hashtable h = new Hashtable();

		public WindbarbSeriesSonificationDefaultInstrumentOptionsMappingLowpass()
		{
			Frequency = Frequency_DefaultValue = new WindbarbSeriesSonificationDefaultInstrumentOptionsMappingLowpassFrequency();
			Resonance = Resonance_DefaultValue = new WindbarbSeriesSonificationDefaultInstrumentOptionsMappingLowpassResonance();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Map to filter frequency in Hertz from 1 to 20,000Hz.
		/// </summary>
		public WindbarbSeriesSonificationDefaultInstrumentOptionsMappingLowpassFrequency Frequency { get; set; }
		private WindbarbSeriesSonificationDefaultInstrumentOptionsMappingLowpassFrequency Frequency_DefaultValue { get; set; }
		 

		/// <summary>
		/// Map to filter resonance in dB. Can be negative to cause adip, or positive to cause a bump.
		/// </summary>
		public WindbarbSeriesSonificationDefaultInstrumentOptionsMappingLowpassResonance Resonance { get; set; }
		private WindbarbSeriesSonificationDefaultInstrumentOptionsMappingLowpassResonance Resonance_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Frequency.IsDirty(highstock)) h.Add("frequency",Frequency.ToHashtable(highstock));
			if (Resonance.IsDirty(highstock)) h.Add("resonance",Resonance.ToHashtable(highstock));
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}
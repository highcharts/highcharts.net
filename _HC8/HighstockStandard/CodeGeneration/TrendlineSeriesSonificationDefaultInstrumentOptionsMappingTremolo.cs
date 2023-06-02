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
	public partial class TrendlineSeriesSonificationDefaultInstrumentOptionsMappingTremolo  : BaseObject
	{
		Hashtable h = new Hashtable();

		public TrendlineSeriesSonificationDefaultInstrumentOptionsMappingTremolo()
		{
			Depth = Depth_DefaultValue = new TrendlineSeriesSonificationDefaultInstrumentOptionsMappingTremoloDepth();
			Speed = Speed_DefaultValue = new TrendlineSeriesSonificationDefaultInstrumentOptionsMappingTremoloSpeed();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Map to tremolo depth, from 0 to 1.This determines the intensity of the tremolo effect, howmuch the volume changes.
		/// </summary>
		public TrendlineSeriesSonificationDefaultInstrumentOptionsMappingTremoloDepth Depth { get; set; }
		private TrendlineSeriesSonificationDefaultInstrumentOptionsMappingTremoloDepth Depth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Map to tremolo speed, from 0 to 1.This determines the speed of the tremolo effect, how fastthe volume changes.
		/// </summary>
		public TrendlineSeriesSonificationDefaultInstrumentOptionsMappingTremoloSpeed Speed { get; set; }
		private TrendlineSeriesSonificationDefaultInstrumentOptionsMappingTremoloSpeed Speed_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Depth.IsDirty(highstock)) h.Add("depth",Depth.ToHashtable(highstock));
			if (Speed.IsDirty(highstock)) h.Add("speed",Speed.ToHashtable(highstock));
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
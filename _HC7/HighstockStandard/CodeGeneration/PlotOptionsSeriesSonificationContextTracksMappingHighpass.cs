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
	public partial class PlotOptionsSeriesSonificationContextTracksMappingHighpass  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSeriesSonificationContextTracksMappingHighpass()
		{
		}	
		

		/// <summary>
		/// Map to filter frequency in Hertz from 1 to 20,000Hz.
		/// </summary>
		public PlotOptionsSeriesSonificationContextTracksMappingHighpassFrequency Frequency { get; set; }
		 

		/// <summary>
		/// Map to filter resonance in dB. Can be negative to cause adip, or positive to cause a bump.
		/// </summary>
		public PlotOptionsSeriesSonificationContextTracksMappingHighpassResonance Resonance { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Frequency != null) h.Add("frequency",Frequency.ToHashtable(highstock));
			if (Resonance != null) h.Add("resonance",Resonance.ToHashtable(highstock));
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
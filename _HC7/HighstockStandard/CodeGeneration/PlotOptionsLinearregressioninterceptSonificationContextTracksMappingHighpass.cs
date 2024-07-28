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
	public partial class PlotOptionsLinearregressioninterceptSonificationContextTracksMappingHighpass  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsLinearregressioninterceptSonificationContextTracksMappingHighpass()
		{
		}	
		

		/// <summary>
		/// Map to filter frequency in Hertz from 1 to 20,000Hz.
		/// </summary>
		public PlotOptionsLinearregressioninterceptSonificationContextTracksMappingHighpassFrequency Frequency { get; set; }
		 

		/// <summary>
		/// Map to filter resonance in dB. Can be negative to cause adip, or positive to cause a bump.
		/// </summary>
		public PlotOptionsLinearregressioninterceptSonificationContextTracksMappingHighpassResonance Resonance { get; set; }
		  

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
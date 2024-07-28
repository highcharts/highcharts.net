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
	public partial class PlotOptionsSplineSonificationContextTracksMappingHighpass  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSplineSonificationContextTracksMappingHighpass()
		{
		}	
		

		/// <summary>
		/// Map to filter frequency in Hertz from 1 to 20,000Hz.
		/// </summary>
		public PlotOptionsSplineSonificationContextTracksMappingHighpassFrequency Frequency { get; set; }
		 

		/// <summary>
		/// Map to filter resonance in dB. Can be negative to cause adip, or positive to cause a bump.
		/// </summary>
		public PlotOptionsSplineSonificationContextTracksMappingHighpassResonance Resonance { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Frequency != null) h.Add("frequency",Frequency.ToHashtable(highcharts));
			if (Resonance != null) h.Add("resonance",Resonance.ToHashtable(highcharts));
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
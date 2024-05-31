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
	public partial class ArearangeSeriesSonificationDefaultInstrumentOptionsMappingPitch  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ArearangeSeriesSonificationDefaultInstrumentOptionsMappingPitch()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string MapTo { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Max { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Min { get; set; }
		 

		/// <summary>
		/// Map pitches to a musical scale. The scale is defined as anarray of semitone offsets from the root note.
		/// </summary>
		public List<double> Scale { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Within { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (MapTo != null) h.Add("mapTo",MapTo);
			if (Max != null) h.Add("max",Max);
			if (Min != null) h.Add("min",Min);
			if (Scale != null) h.Add("scale",Scale);
			if (Within != null) h.Add("within",Within);
			if (CustomFields.Count > 0)
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
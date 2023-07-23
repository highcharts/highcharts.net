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
	public partial class PlotOptionsAreasplineSonificationDefaultSpeechOptionsMappingPitch  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsAreasplineSonificationDefaultSpeechOptionsMappingPitch()
		{
			MapTo = MapTo_DefaultValue = "y";
			Max = Max_DefaultValue = "c6";
			Min = Min_DefaultValue = "c2";
			Scale = Scale_DefaultValue = new List<double>();
			Within = Within_DefaultValue = "yAxis";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string MapTo { get; set; }
		private string MapTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Max { get; set; }
		private string Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Min { get; set; }
		private string Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// Map pitches to a musical scale. The scale is defined as anarray of semitone offsets from the root note.
		/// </summary>
		public List<double> Scale { get; set; }
		private List<double> Scale_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Within { get; set; }
		private string Within_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (MapTo != MapTo_DefaultValue) h.Add("mapTo",MapTo);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (Scale != Scale_DefaultValue) h.Add("scale",Scale);
			if (Within != Within_DefaultValue) h.Add("within",Within);
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
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
	public partial class TemaSeriesSonification  : BaseObject
	{
		Hashtable h = new Hashtable();

		public TemaSeriesSonification()
		{
			ContextTracks = ContextTracks_DefaultValue = new TemaSeriesSonificationContextTracks();
			DefaultInstrumentOptions = DefaultInstrumentOptions_DefaultValue = new TemaSeriesSonificationDefaultInstrumentOptions();
			DefaultSpeechOptions = DefaultSpeechOptions_DefaultValue = new TemaSeriesSonificationDefaultSpeechOptions();
			Enabled = Enabled_DefaultValue = true;
			PointGrouping = PointGrouping_DefaultValue = new TemaSeriesSonificationPointGrouping();
			Tracks = Tracks_DefaultValue = new TemaSeriesSonificationTracks();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Context tracks for this series. Context tracks are tracks that are nottied to data points.Given as an array of instrument tracks, speech tracks, or a mix of both.
		/// </summary>
		public TemaSeriesSonificationContextTracks ContextTracks { get; set; }
		private TemaSeriesSonificationContextTracks ContextTracks_DefaultValue { get; set; }
		 

		/// <summary>
		/// Default options for all this series' instrument tracks.
		/// </summary>
		public TemaSeriesSonificationDefaultInstrumentOptions DefaultInstrumentOptions { get; set; }
		private TemaSeriesSonificationDefaultInstrumentOptions DefaultInstrumentOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Default options for all this series' speech tracks.
		/// </summary>
		public TemaSeriesSonificationDefaultSpeechOptions DefaultSpeechOptions { get; set; }
		private TemaSeriesSonificationDefaultSpeechOptions DefaultSpeechOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether or not sonification is enabled for this series.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sonification point grouping options for this series.
		/// </summary>
		public TemaSeriesSonificationPointGrouping PointGrouping { get; set; }
		private TemaSeriesSonificationPointGrouping PointGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// Tracks for this series.Given as an array of instrument tracks, speech tracks, or a mix of both.
		/// </summary>
		public TemaSeriesSonificationTracks Tracks { get; set; }
		private TemaSeriesSonificationTracks Tracks_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ContextTracks.IsDirty(highstock)) h.Add("contextTracks",ContextTracks.ToHashtable(highstock));
			if (DefaultInstrumentOptions.IsDirty(highstock)) h.Add("defaultInstrumentOptions",DefaultInstrumentOptions.ToHashtable(highstock));
			if (DefaultSpeechOptions.IsDirty(highstock)) h.Add("defaultSpeechOptions",DefaultSpeechOptions.ToHashtable(highstock));
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (PointGrouping.IsDirty(highstock)) h.Add("pointGrouping",PointGrouping.ToHashtable(highstock));
			if (Tracks.IsDirty(highstock)) h.Add("tracks",Tracks.ToHashtable(highstock));
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
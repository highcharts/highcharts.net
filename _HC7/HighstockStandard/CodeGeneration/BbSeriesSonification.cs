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
	public partial class BbSeriesSonification  : BaseObject
	{
		Hashtable h = new Hashtable();

		public BbSeriesSonification()
		{
			ContextTracks = ContextTracks_DefaultValue = new BbSeriesSonificationContextTracks();
			DefaultInstrumentOptions = DefaultInstrumentOptions_DefaultValue = new BbSeriesSonificationDefaultInstrumentOptions();
			DefaultSpeechOptions = DefaultSpeechOptions_DefaultValue = new BbSeriesSonificationDefaultSpeechOptions();
			Enabled = Enabled_DefaultValue = true;
			PointGrouping = PointGrouping_DefaultValue = new BbSeriesSonificationPointGrouping();
			Tracks = Tracks_DefaultValue = new BbSeriesSonificationTracks();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Context tracks for this series. Context tracks are tracks that are nottied to data points.Given as an array of instrument tracks, speech tracks, or a mix of both.
		/// </summary>
		public BbSeriesSonificationContextTracks ContextTracks { get; set; }
		private BbSeriesSonificationContextTracks ContextTracks_DefaultValue { get; set; }
		 

		/// <summary>
		/// Default options for all this series' instrument tracks.
		/// </summary>
		public BbSeriesSonificationDefaultInstrumentOptions DefaultInstrumentOptions { get; set; }
		private BbSeriesSonificationDefaultInstrumentOptions DefaultInstrumentOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Default options for all this series' speech tracks.
		/// </summary>
		public BbSeriesSonificationDefaultSpeechOptions DefaultSpeechOptions { get; set; }
		private BbSeriesSonificationDefaultSpeechOptions DefaultSpeechOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether or not sonification is enabled for this series.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sonification point grouping options for this series.
		/// </summary>
		public BbSeriesSonificationPointGrouping PointGrouping { get; set; }
		private BbSeriesSonificationPointGrouping PointGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// Tracks for this series.Given as an array of instrument tracks, speech tracks, or a mix of both.
		/// </summary>
		public BbSeriesSonificationTracks Tracks { get; set; }
		private BbSeriesSonificationTracks Tracks_DefaultValue { get; set; }
		 

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
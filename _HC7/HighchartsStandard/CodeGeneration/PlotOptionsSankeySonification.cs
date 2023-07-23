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
	public partial class PlotOptionsSankeySonification  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSankeySonification()
		{
			ContextTracks = ContextTracks_DefaultValue = new PlotOptionsSankeySonificationContextTracks();
			DefaultInstrumentOptions = DefaultInstrumentOptions_DefaultValue = new PlotOptionsSankeySonificationDefaultInstrumentOptions();
			DefaultSpeechOptions = DefaultSpeechOptions_DefaultValue = new PlotOptionsSankeySonificationDefaultSpeechOptions();
			Enabled = Enabled_DefaultValue = true;
			PointGrouping = PointGrouping_DefaultValue = new PlotOptionsSankeySonificationPointGrouping();
			Tracks = Tracks_DefaultValue = new PlotOptionsSankeySonificationTracks();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Context tracks for this series. Context tracks are tracks that are nottied to data points.Given as an array of instrument tracks, speech tracks, or a mix of both.
		/// </summary>
		public PlotOptionsSankeySonificationContextTracks ContextTracks { get; set; }
		private PlotOptionsSankeySonificationContextTracks ContextTracks_DefaultValue { get; set; }
		 

		/// <summary>
		/// Default options for all this series' instrument tracks.
		/// </summary>
		public PlotOptionsSankeySonificationDefaultInstrumentOptions DefaultInstrumentOptions { get; set; }
		private PlotOptionsSankeySonificationDefaultInstrumentOptions DefaultInstrumentOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Default options for all this series' speech tracks.
		/// </summary>
		public PlotOptionsSankeySonificationDefaultSpeechOptions DefaultSpeechOptions { get; set; }
		private PlotOptionsSankeySonificationDefaultSpeechOptions DefaultSpeechOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether or not sonification is enabled for this series.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sonification point grouping options for this series.
		/// </summary>
		public PlotOptionsSankeySonificationPointGrouping PointGrouping { get; set; }
		private PlotOptionsSankeySonificationPointGrouping PointGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// Tracks for this series.Given as an array of instrument tracks, speech tracks, or a mix of both.
		/// </summary>
		public PlotOptionsSankeySonificationTracks Tracks { get; set; }
		private PlotOptionsSankeySonificationTracks Tracks_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (ContextTracks.IsDirty(highcharts)) h.Add("contextTracks",ContextTracks.ToHashtable(highcharts));
			if (DefaultInstrumentOptions.IsDirty(highcharts)) h.Add("defaultInstrumentOptions",DefaultInstrumentOptions.ToHashtable(highcharts));
			if (DefaultSpeechOptions.IsDirty(highcharts)) h.Add("defaultSpeechOptions",DefaultSpeechOptions.ToHashtable(highcharts));
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (PointGrouping.IsDirty(highcharts)) h.Add("pointGrouping",PointGrouping.ToHashtable(highcharts));
			if (Tracks.IsDirty(highcharts)) h.Add("tracks",Tracks.ToHashtable(highcharts));
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
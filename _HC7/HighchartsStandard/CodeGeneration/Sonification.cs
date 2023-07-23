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
	public partial class Sonification  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Sonification()
		{
			AfterSeriesWait = AfterSeriesWait_DefaultValue = 700;
			DefaultInstrumentOptions = DefaultInstrumentOptions_DefaultValue = new SonificationDefaultInstrumentOptions();
			DefaultSpeechOptions = DefaultSpeechOptions_DefaultValue = new SonificationDefaultSpeechOptions();
			Duration = Duration_DefaultValue = 6000;
			Enabled = Enabled_DefaultValue = true;
			Events = Events_DefaultValue = new SonificationEvents();
			GlobalContextTracks = GlobalContextTracks_DefaultValue = new SonificationGlobalContextTracks();
			GlobalTracks = GlobalTracks_DefaultValue = new SonificationGlobalTracks();
			MasterVolume = MasterVolume_DefaultValue = null;
			Order = Order_DefaultValue = SonificationOrder.Sequential;
			PointGrouping = PointGrouping_DefaultValue = new SonificationPointGrouping();
			ShowCrosshair = ShowCrosshair_DefaultValue = true;
			ShowTooltip = ShowTooltip_DefaultValue = true;
			UpdateInterval = UpdateInterval_DefaultValue = 200;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The time to wait in milliseconds after each data series when playingthe series one after the other.
		/// </summary>
		public double? AfterSeriesWait { get; set; }
		private double? AfterSeriesWait_DefaultValue { get; set; }
		 

		/// <summary>
		/// Default sonification options for all instrument tracks.If specific options are also set on individual tracks or perseries, those will override these options.
		/// </summary>
		public SonificationDefaultInstrumentOptions DefaultInstrumentOptions { get; set; }
		private SonificationDefaultInstrumentOptions DefaultInstrumentOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Default sonification options for all speech tracks.If specific options are also set on individual tracks or perseries, those will override these options.
		/// </summary>
		public SonificationDefaultSpeechOptions DefaultSpeechOptions { get; set; }
		private SonificationDefaultSpeechOptions DefaultSpeechOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The total duration of the sonification, in milliseconds.
		/// </summary>
		public double? Duration { get; set; }
		private double? Duration_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable sonification functionality for the chart.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set up event handlers for the sonification
		/// </summary>
		public SonificationEvents Events { get; set; }
		private SonificationEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Context tracks to add globally, an array of either instrumenttracks, speech tracks, or a mix.Context tracks are not tied to data points, but play at a setinterval - either based on time or on prop values.
		/// </summary>
		public SonificationGlobalContextTracks GlobalContextTracks { get; set; }
		private SonificationGlobalContextTracks GlobalContextTracks_DefaultValue { get; set; }
		 

		/// <summary>
		/// Global tracks to add to every series.Defined as an array of either instrument or speech tracks,or a combination.
		/// </summary>
		public SonificationGlobalTracks GlobalTracks { get; set; }
		private SonificationGlobalTracks GlobalTracks_DefaultValue { get; set; }
		 

		/// <summary>
		/// Overall/master volume for the sonification, from 0 to 1.
		/// </summary>
		public double? MasterVolume { get; set; }
		private double? MasterVolume_DefaultValue { get; set; }
		 

		/// <summary>
		/// What order to play the data series in, either `sequential` wherethe series play individually one after the other, or `simultaneous`where the series play all at once.
		/// </summary>
		public SonificationOrder Order { get; set; }
		private SonificationOrder Order_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for grouping data points together when sonifying. Thisallows for the visual presentation to contain more points than whatis being played. If not enabled, all visible / uncropped points areplayed.
		/// </summary>
		public SonificationPointGrouping PointGrouping { get; set; }
		private SonificationPointGrouping PointGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// Show X and Y axis crosshairs (if they exist) as the chart plays.Note that if multiple tracks that play at different times try toshow the crosshairs, it can be glitchy, so it is recommended inthose cases to turn this on/off for individual tracks using the[showPlayMarker](#plotOptions.series.sonification.tracks.showPlayMarker)option.
		/// </summary>
		public bool? ShowCrosshair { get; set; }
		private bool? ShowCrosshair_DefaultValue { get; set; }
		 

		/// <summary>
		/// Show tooltip as the chart plays.Note that if multiple tracks that play at different times try toshow the tooltip, it can be glitchy, so it is recommended inthose cases to turn this on/off for individual tracks using the[showPlayMarker](#plotOptions.series.sonification.tracks.showPlayMarker)option.
		/// </summary>
		public bool? ShowTooltip { get; set; }
		private bool? ShowTooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// How long to wait between each recomputation of the sonification, ifthe chart updates rapidly. This avoids slowing down processes likepanning. Given in milliseconds.
		/// </summary>
		public double? UpdateInterval { get; set; }
		private double? UpdateInterval_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (AfterSeriesWait != AfterSeriesWait_DefaultValue) h.Add("afterSeriesWait",AfterSeriesWait);
			if (DefaultInstrumentOptions.IsDirty(highcharts)) h.Add("defaultInstrumentOptions",DefaultInstrumentOptions.ToHashtable(highcharts));
			if (DefaultSpeechOptions.IsDirty(highcharts)) h.Add("defaultSpeechOptions",DefaultSpeechOptions.ToHashtable(highcharts));
			if (Duration != Duration_DefaultValue) h.Add("duration",Duration);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Events.IsDirty(highcharts)) h.Add("events",Events.ToHashtable(highcharts));
			if (GlobalContextTracks.IsDirty(highcharts)) h.Add("globalContextTracks",GlobalContextTracks.ToHashtable(highcharts));
			if (GlobalTracks.IsDirty(highcharts)) h.Add("globalTracks",GlobalTracks.ToHashtable(highcharts));
			if (MasterVolume != MasterVolume_DefaultValue) h.Add("masterVolume",MasterVolume);
			if (Order != Order_DefaultValue) h.Add("order", highcharts.FirstCharacterToLower(Order.ToString()));
			if (PointGrouping.IsDirty(highcharts)) h.Add("pointGrouping",PointGrouping.ToHashtable(highcharts));
			if (ShowCrosshair != ShowCrosshair_DefaultValue) h.Add("showCrosshair",ShowCrosshair);
			if (ShowTooltip != ShowTooltip_DefaultValue) h.Add("showTooltip",ShowTooltip);
			if (UpdateInterval != UpdateInterval_DefaultValue) h.Add("updateInterval",UpdateInterval);
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
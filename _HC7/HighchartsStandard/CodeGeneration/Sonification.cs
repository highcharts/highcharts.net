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
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The time to wait in milliseconds after each data series when playingthe series one after the other.
		/// </summary>
		public double? AfterSeriesWait { get; set; }
		 

		/// <summary>
		/// Default sonification options for all instrument tracks.If specific options are also set on individual tracks or perseries, those will override these options.
		/// </summary>
		public SonificationDefaultInstrumentOptions DefaultInstrumentOptions { get; set; }
		 

		/// <summary>
		/// Default sonification options for all speech tracks.If specific options are also set on individual tracks or perseries, those will override these options.
		/// </summary>
		public SonificationDefaultSpeechOptions DefaultSpeechOptions { get; set; }
		 

		/// <summary>
		/// The total duration of the sonification, in milliseconds.
		/// </summary>
		public double? Duration { get; set; }
		 

		/// <summary>
		/// Enable sonification functionality for the chart.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Set up event handlers for the sonification
		/// </summary>
		public SonificationEvents Events { get; set; }
		 

		/// <summary>
		/// Context tracks to add globally, an array of either instrumenttracks, speech tracks, or a mix.Context tracks are not tied to data points, but play at a setinterval - either based on time or on prop values.
		/// </summary>
		public SonificationGlobalContextTracks GlobalContextTracks { get; set; }
		 

		/// <summary>
		/// Global tracks to add to every series.Defined as an array of either instrument or speech tracks,or a combination.
		/// </summary>
		public SonificationGlobalTracks GlobalTracks { get; set; }
		 

		/// <summary>
		/// Overall/master volume for the sonification, from 0 to 1.
		/// </summary>
		public double? MasterVolume { get; set; }
		 

		/// <summary>
		/// What order to play the data series in, either `sequential` wherethe series play individually one after the other, or `simultaneous`where the series play all at once.
		/// </summary>
		public SonificationOrder Order { get; set; }
		 

		/// <summary>
		/// Options for grouping data points together when sonifying. Thisallows for the visual presentation to contain more points than whatis being played. If not enabled, all visible / uncropped points areplayed.
		/// </summary>
		public SonificationPointGrouping PointGrouping { get; set; }
		 

		/// <summary>
		/// Show X and Y axis crosshairs (if they exist) as the chart plays.Note that if multiple tracks that play at different times try toshow the crosshairs, it can be glitchy, so it is recommended inthose cases to turn this on/off for individual tracks using the[showPlayMarker](#plotOptions.series.sonification.tracks.showPlayMarker)option.
		/// </summary>
		public bool? ShowCrosshair { get; set; }
		 

		/// <summary>
		/// Show tooltip as the chart plays.Note that if multiple tracks that play at different times try toshow the tooltip, it can be glitchy, so it is recommended inthose cases to turn this on/off for individual tracks using the[showPlayMarker](#plotOptions.series.sonification.tracks.showPlayMarker)option.
		/// </summary>
		public bool? ShowTooltip { get; set; }
		 

		/// <summary>
		/// How long to wait between each recomputation of the sonification, ifthe chart updates rapidly. This avoids slowing down processes likepanning. Given in milliseconds.
		/// </summary>
		public double? UpdateInterval { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (AfterSeriesWait != null) h.Add("afterSeriesWait",AfterSeriesWait);
			if (DefaultInstrumentOptions != null) h.Add("defaultInstrumentOptions",DefaultInstrumentOptions.ToHashtable(highcharts));
			if (DefaultSpeechOptions != null) h.Add("defaultSpeechOptions",DefaultSpeechOptions.ToHashtable(highcharts));
			if (Duration != null) h.Add("duration",Duration);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Events != null) h.Add("events",Events.ToHashtable(highcharts));
			if (GlobalContextTracks != null) h.Add("globalContextTracks",GlobalContextTracks.ToHashtable(highcharts));
			if (GlobalTracks != null) h.Add("globalTracks",GlobalTracks.ToHashtable(highcharts));
			if (MasterVolume != null) h.Add("masterVolume",MasterVolume);
			if (Order != SonificationOrder.Null) h.Add("order", highcharts.FirstCharacterToLower(Order.ToString()));
			if (PointGrouping != null) h.Add("pointGrouping",PointGrouping.ToHashtable(highcharts));
			if (ShowCrosshair != null) h.Add("showCrosshair",ShowCrosshair);
			if (ShowTooltip != null) h.Add("showTooltip",ShowTooltip);
			if (UpdateInterval != null) h.Add("updateInterval",UpdateInterval);
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
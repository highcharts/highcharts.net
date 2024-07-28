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
	public partial class PlotOptionsBarSonification  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsBarSonification()
		{
		}	
		

		/// <summary>
		/// Context tracks for this series. Context tracks are tracks that are nottied to data points.Given as an array of instrument tracks, speech tracks, or a mix of both.
		/// </summary>
		public PlotOptionsBarSonificationContextTracks ContextTracks { get; set; }
		 

		/// <summary>
		/// Default options for all this series' instrument tracks.
		/// </summary>
		public PlotOptionsBarSonificationDefaultInstrumentOptions DefaultInstrumentOptions { get; set; }
		 

		/// <summary>
		/// Default options for all this series' speech tracks.
		/// </summary>
		public PlotOptionsBarSonificationDefaultSpeechOptions DefaultSpeechOptions { get; set; }
		 

		/// <summary>
		/// Whether or not sonification is enabled for this series.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Sonification point grouping options for this series.
		/// </summary>
		public PlotOptionsBarSonificationPointGrouping PointGrouping { get; set; }
		 

		/// <summary>
		/// Tracks for this series.Given as an array of instrument tracks, speech tracks, or a mix of both.
		/// </summary>
		public PlotOptionsBarSonificationTracks Tracks { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ContextTracks != null) h.Add("contextTracks",ContextTracks.ToHashtable(highcharts));
			if (DefaultInstrumentOptions != null) h.Add("defaultInstrumentOptions",DefaultInstrumentOptions.ToHashtable(highcharts));
			if (DefaultSpeechOptions != null) h.Add("defaultSpeechOptions",DefaultSpeechOptions.ToHashtable(highcharts));
			if (Enabled != null) h.Add("enabled",Enabled);
			if (PointGrouping != null) h.Add("pointGrouping",PointGrouping.ToHashtable(highcharts));
			if (Tracks != null) h.Add("tracks",Tracks.ToHashtable(highcharts));
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
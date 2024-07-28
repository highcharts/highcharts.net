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
	public partial class PlotOptionsVectorSonification  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsVectorSonification()
		{
		}	
		

		/// <summary>
		/// Context tracks for this series. Context tracks are tracks that are nottied to data points.Given as an array of instrument tracks, speech tracks, or a mix of both.
		/// </summary>
		public PlotOptionsVectorSonificationContextTracks ContextTracks { get; set; }
		 

		/// <summary>
		/// Default options for all this series' instrument tracks.
		/// </summary>
		public PlotOptionsVectorSonificationDefaultInstrumentOptions DefaultInstrumentOptions { get; set; }
		 

		/// <summary>
		/// Default options for all this series' speech tracks.
		/// </summary>
		public PlotOptionsVectorSonificationDefaultSpeechOptions DefaultSpeechOptions { get; set; }
		 

		/// <summary>
		/// Whether or not sonification is enabled for this series.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Sonification point grouping options for this series.
		/// </summary>
		public PlotOptionsVectorSonificationPointGrouping PointGrouping { get; set; }
		 

		/// <summary>
		/// Tracks for this series.Given as an array of instrument tracks, speech tracks, or a mix of both.
		/// </summary>
		public PlotOptionsVectorSonificationTracks Tracks { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ContextTracks != null) h.Add("contextTracks",ContextTracks.ToHashtable(highstock));
			if (DefaultInstrumentOptions != null) h.Add("defaultInstrumentOptions",DefaultInstrumentOptions.ToHashtable(highstock));
			if (DefaultSpeechOptions != null) h.Add("defaultSpeechOptions",DefaultSpeechOptions.ToHashtable(highstock));
			if (Enabled != null) h.Add("enabled",Enabled);
			if (PointGrouping != null) h.Add("pointGrouping",PointGrouping.ToHashtable(highstock));
			if (Tracks != null) h.Add("tracks",Tracks.ToHashtable(highstock));
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
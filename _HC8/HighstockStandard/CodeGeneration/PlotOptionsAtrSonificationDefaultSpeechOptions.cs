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
	public partial class PlotOptionsAtrSonificationDefaultSpeechOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsAtrSonificationDefaultSpeechOptions()
		{
			ActiveWhen = ActiveWhen_DefaultValue = new PlotOptionsAtrSonificationDefaultSpeechOptionsActiveWhen();
			Language = Language_DefaultValue = "en-US";
			Mapping = Mapping_DefaultValue = new PlotOptionsAtrSonificationDefaultSpeechOptionsMapping();
			PointGrouping = PointGrouping_DefaultValue = new PlotOptionsAtrSonificationDefaultSpeechOptionsPointGrouping();
			PreferredVoice = PreferredVoice_DefaultValue = "";
			ShowPlayMarker = ShowPlayMarker_DefaultValue = true;
			Type = Type_DefaultValue = PlotOptionsAtrSonificationDefaultSpeechOptionsType.Instrument;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Define a condition for when a track should be active and not.Can either be a function callback or a configuration object.If a function is used, it should return a `boolean` for whetheror not the track should be active. The function is called foreach audio event, and receives a parameter object with `time`,and potentially `point` and `value` properties depending on thetrack. `point` is available if the audio event is related to adata point. `value` is available if the track is used as acontext track, and `valueInterval` is used.
		/// </summary>
		public PlotOptionsAtrSonificationDefaultSpeechOptionsActiveWhen ActiveWhen { get; set; }
		private PlotOptionsAtrSonificationDefaultSpeechOptionsActiveWhen ActiveWhen_DefaultValue { get; set; }
		 

		/// <summary>
		/// The language to speak in for speech tracks, as an IETF BCP 47language tag.
		/// </summary>
		public string Language { get; set; }
		private string Language_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mapping options for the audio parameters.All parameters can be either: - A string, referencing a point property to map to. - A number, setting the value of the audio parameter directly. - A callback function, returning the value programmatically. - An object defining detailed configuration of the mapping.If a function is used, it should return the desired value forthe audio parameter. The function is called for each audio eventto be played, and receives a context object parameter with`time`, and potentially `point` and `value` depending on thetrack. `point` is available if the audio event is related to adata point, and `value` is available if the track is used for acontext track using `valueInterval`.
		/// </summary>
		public PlotOptionsAtrSonificationDefaultSpeechOptionsMapping Mapping { get; set; }
		private PlotOptionsAtrSonificationDefaultSpeechOptionsMapping Mapping_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for point grouping, specifically for instrument tracks.
		/// </summary>
		public PlotOptionsAtrSonificationDefaultSpeechOptionsPointGrouping PointGrouping { get; set; }
		private PlotOptionsAtrSonificationDefaultSpeechOptionsPointGrouping PointGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// Name of the voice synthesis to prefer for speech tracks.If not available, falls back to the default voice for theselected language.Different platforms provide different voices for web speechsynthesis.
		/// </summary>
		public string PreferredVoice { get; set; }
		private string PreferredVoice_DefaultValue { get; set; }
		 

		/// <summary>
		/// Show play marker (tooltip and/or crosshair) for a track.
		/// </summary>
		public bool? ShowPlayMarker { get; set; }
		private bool? ShowPlayMarker_DefaultValue { get; set; }
		 

		/// <summary>
		/// Type of track. Always `"instrument"` for instrument tracks, and`"speech"` for speech tracks.
		/// </summary>
		public PlotOptionsAtrSonificationDefaultSpeechOptionsType Type { get; set; }
		private PlotOptionsAtrSonificationDefaultSpeechOptionsType Type_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ActiveWhen.IsDirty(highstock)) h.Add("activeWhen",ActiveWhen.ToHashtable(highstock));
			if (Language != Language_DefaultValue) h.Add("language",Language);
			if (Mapping.IsDirty(highstock)) h.Add("mapping",Mapping.ToHashtable(highstock));
			if (PointGrouping.IsDirty(highstock)) h.Add("pointGrouping",PointGrouping.ToHashtable(highstock));
			if (PreferredVoice != PreferredVoice_DefaultValue) h.Add("preferredVoice",PreferredVoice);
			if (ShowPlayMarker != ShowPlayMarker_DefaultValue) h.Add("showPlayMarker",ShowPlayMarker);
			if (Type != Type_DefaultValue) h.Add("type", highstock.FirstCharacterToLower(Type.ToString()));
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
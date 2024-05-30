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
	public partial class BoxplotSeriesSonificationDefaultSpeechOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public BoxplotSeriesSonificationDefaultSpeechOptions()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Define a condition for when a track should be active and not.Can either be a function callback or a configuration object.If a function is used, it should return a `boolean` for whetheror not the track should be active. The function is called foreach audio event, and receives a parameter object with `time`,and potentially `point` and `value` properties depending on thetrack. `point` is available if the audio event is related to adata point. `value` is available if the track is used as acontext track, and `valueInterval` is used.
		/// </summary>
		public BoxplotSeriesSonificationDefaultSpeechOptionsActiveWhen ActiveWhen { get; set; }
		private BoxplotSeriesSonificationDefaultSpeechOptionsActiveWhen ActiveWhen_DefaultValue { get; set; }
		 

		/// <summary>
		/// The language to speak in for speech tracks, as an IETF BCP 47language tag.
		/// </summary>
		public string Language { get; set; }
		private string Language_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mapping options for the audio parameters.All parameters can be either: - A string, referencing a point property to map to. - A number, setting the value of the audio parameter directly. - A callback function, returning the value programmatically. - An object defining detailed configuration of the mapping.If a function is used, it should return the desired value forthe audio parameter. The function is called for each audio eventto be played, and receives a context object parameter with`time`, and potentially `point` and `value` depending on thetrack. `point` is available if the audio event is related to adata point, and `value` is available if the track is used for acontext track using `valueInterval`.
		/// </summary>
		public BoxplotSeriesSonificationDefaultSpeechOptionsMapping Mapping { get; set; }
		private BoxplotSeriesSonificationDefaultSpeechOptionsMapping Mapping_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for point grouping, specifically for instrument tracks.
		/// </summary>
		public BoxplotSeriesSonificationDefaultSpeechOptionsPointGrouping PointGrouping { get; set; }
		private BoxplotSeriesSonificationDefaultSpeechOptionsPointGrouping PointGrouping_DefaultValue { get; set; }
		 

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
		public BoxplotSeriesSonificationDefaultSpeechOptionsType Type { get; set; }
		private BoxplotSeriesSonificationDefaultSpeechOptionsType Type_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (ActiveWhen != null) h.Add("activeWhen",ActiveWhen.ToHashtable(highcharts));
			if (Language != null) h.Add("language",Language);
			if (Mapping != null) h.Add("mapping",Mapping.ToHashtable(highcharts));
			if (PointGrouping != null) h.Add("pointGrouping",PointGrouping.ToHashtable(highcharts));
			if (PreferredVoice != null) h.Add("preferredVoice",PreferredVoice);
			if (ShowPlayMarker != null) h.Add("showPlayMarker",ShowPlayMarker);
			if (Type != BoxplotSeriesSonificationDefaultSpeechOptionsType.Null) h.Add("type", highcharts.FirstCharacterToLower(Type.ToString()));
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
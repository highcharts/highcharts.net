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
	public partial class PlotOptionsPackedbubbleSonificationDefaultInstrumentOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPackedbubbleSonificationDefaultInstrumentOptions()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Define a condition for when a track should be active and not.Can either be a function callback or a configuration object.If a function is used, it should return a `boolean` for whetheror not the track should be active. The function is called foreach audio event, and receives a parameter object with `time`,and potentially `point` and `value` properties depending on thetrack. `point` is available if the audio event is related to adata point. `value` is available if the track is used as acontext track, and `valueInterval` is used.
		/// </summary>
		public PlotOptionsPackedbubbleSonificationDefaultInstrumentOptionsActiveWhen ActiveWhen { get; set; }
		private PlotOptionsPackedbubbleSonificationDefaultInstrumentOptionsActiveWhen ActiveWhen_DefaultValue { get; set; }
		 

		/// <summary>
		/// Instrument to use for playing.Can either be a string referencing a synth preset, or it can bea synth configuration object.
		/// </summary>
		public Object Instrument { get; set; }
		private Object Instrument_DefaultValue { get; set; }
		 

		/// <summary>
		/// Instrument to use for playing.Can either be a string referencing a synth preset, or it can bea synth configuration object.
		/// </summary>
		public string InstrumentString { get; set; }
		private string InstrumentString_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mapping options for the audio parameters.All parameters can be either: - A string, referencing a point property to map to. - A number, setting the value of the audio parameter directly. - A callback function, returning the value programmatically. - An object defining detailed configuration of the mapping.If a function is used, it should return the desired value forthe audio parameter. The function is called for each audio eventto be played, and receives a context object parameter with`time`, and potentially `point` and `value` depending on thetrack. `point` is available if the audio event is related to adata point, and `value` is available if the track is used for acontext track using `valueInterval`.
		/// </summary>
		public PlotOptionsPackedbubbleSonificationDefaultInstrumentOptionsMapping Mapping { get; set; }
		private PlotOptionsPackedbubbleSonificationDefaultInstrumentOptionsMapping Mapping_DefaultValue { get; set; }
		 

		/// <summary>
		/// Name to use for a track when exporting to MIDI.By default it uses the series name if the track is related toa series.
		/// </summary>
		public string MidiName { get; set; }
		private string MidiName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for point grouping, specifically for instrument tracks.
		/// </summary>
		public PlotOptionsPackedbubbleSonificationDefaultInstrumentOptionsPointGrouping PointGrouping { get; set; }
		private PlotOptionsPackedbubbleSonificationDefaultInstrumentOptionsPointGrouping PointGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// Round pitch mapping to musical notes.If `false`, will play the exact mapped note, even if it is outof tune compared to the musical notes as defined by 440Hzstandard tuning.
		/// </summary>
		public bool? RoundToMusicalNotes { get; set; }
		private bool? RoundToMusicalNotes_DefaultValue { get; set; }
		 

		/// <summary>
		/// Show play marker (tooltip and/or crosshair) for a track.
		/// </summary>
		public bool? ShowPlayMarker { get; set; }
		private bool? ShowPlayMarker_DefaultValue { get; set; }
		 

		/// <summary>
		/// Type of track. Always `"instrument"` for instrument tracks, and`"speech"` for speech tracks.
		/// </summary>
		public PlotOptionsPackedbubbleSonificationDefaultInstrumentOptionsType Type { get; set; }
		private PlotOptionsPackedbubbleSonificationDefaultInstrumentOptionsType Type_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (ActiveWhen != null) h.Add("activeWhen",ActiveWhen.ToHashtable(highcharts));
			if (Instrument != null) h.Add("instrument",Instrument);
			if (InstrumentString != null) h.Add("instrument",InstrumentString);
			if (Mapping != null) h.Add("mapping",Mapping.ToHashtable(highcharts));
			if (MidiName != null) h.Add("midiName",MidiName);
			if (PointGrouping != null) h.Add("pointGrouping",PointGrouping.ToHashtable(highcharts));
			if (RoundToMusicalNotes != null) h.Add("roundToMusicalNotes",RoundToMusicalNotes);
			if (ShowPlayMarker != null) h.Add("showPlayMarker",ShowPlayMarker);
			if (Type != PlotOptionsPackedbubbleSonificationDefaultInstrumentOptionsType.Null) h.Add("type", highcharts.FirstCharacterToLower(Type.ToString()));
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
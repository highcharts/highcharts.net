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
	public partial class PlotOptionsCciSonificationDefaultInstrumentOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsCciSonificationDefaultInstrumentOptions()
		{
			ActiveWhen = ActiveWhen_DefaultValue = new PlotOptionsCciSonificationDefaultInstrumentOptionsActiveWhen();
			Instrument = Instrument_DefaultValue = null;
			InstrumentString = InstrumentString_DefaultValue = "null";
			Mapping = Mapping_DefaultValue = new PlotOptionsCciSonificationDefaultInstrumentOptionsMapping();
			MidiName = MidiName_DefaultValue = "";
			PointGrouping = PointGrouping_DefaultValue = new PlotOptionsCciSonificationDefaultInstrumentOptionsPointGrouping();
			RoundToMusicalNotes = RoundToMusicalNotes_DefaultValue = true;
			ShowPlayMarker = ShowPlayMarker_DefaultValue = true;
			Type = Type_DefaultValue = PlotOptionsCciSonificationDefaultInstrumentOptionsType.Instrument;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Define a condition for when a track should be active and not.Can either be a function callback or a configuration object.If a function is used, it should return a `boolean` for whetheror not the track should be active. The function is called foreach audio event, and receives a parameter object with `time`,and potentially `point` and `value` properties depending on thetrack. `point` is available if the audio event is related to adata point. `value` is available if the track is used as acontext track, and `valueInterval` is used.
		/// </summary>
		public PlotOptionsCciSonificationDefaultInstrumentOptionsActiveWhen ActiveWhen { get; set; }
		private PlotOptionsCciSonificationDefaultInstrumentOptionsActiveWhen ActiveWhen_DefaultValue { get; set; }
		 

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
		public PlotOptionsCciSonificationDefaultInstrumentOptionsMapping Mapping { get; set; }
		private PlotOptionsCciSonificationDefaultInstrumentOptionsMapping Mapping_DefaultValue { get; set; }
		 

		/// <summary>
		/// Name to use for a track when exporting to MIDI.By default it uses the series name if the track is related toa series.
		/// </summary>
		public string MidiName { get; set; }
		private string MidiName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for point grouping, specifically for instrument tracks.
		/// </summary>
		public PlotOptionsCciSonificationDefaultInstrumentOptionsPointGrouping PointGrouping { get; set; }
		private PlotOptionsCciSonificationDefaultInstrumentOptionsPointGrouping PointGrouping_DefaultValue { get; set; }
		 

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
		public PlotOptionsCciSonificationDefaultInstrumentOptionsType Type { get; set; }
		private PlotOptionsCciSonificationDefaultInstrumentOptionsType Type_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ActiveWhen.IsDirty(highstock)) h.Add("activeWhen",ActiveWhen.ToHashtable(highstock));
			if (Instrument != Instrument_DefaultValue) h.Add("instrument",Instrument);
			if (InstrumentString != InstrumentString_DefaultValue) h.Add("instrument",InstrumentString);
			if (Mapping.IsDirty(highstock)) h.Add("mapping",Mapping.ToHashtable(highstock));
			if (MidiName != MidiName_DefaultValue) h.Add("midiName",MidiName);
			if (PointGrouping.IsDirty(highstock)) h.Add("pointGrouping",PointGrouping.ToHashtable(highstock));
			if (RoundToMusicalNotes != RoundToMusicalNotes_DefaultValue) h.Add("roundToMusicalNotes",RoundToMusicalNotes);
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
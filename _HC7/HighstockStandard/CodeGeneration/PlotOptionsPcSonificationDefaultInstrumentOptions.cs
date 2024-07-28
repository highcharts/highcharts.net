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
	public partial class PlotOptionsPcSonificationDefaultInstrumentOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPcSonificationDefaultInstrumentOptions()
		{
		}	
		

		/// <summary>
		/// Define a condition for when a track should be active and not.Can either be a function callback or a configuration object.If a function is used, it should return a `boolean` for whetheror not the track should be active. The function is called foreach audio event, and receives a parameter object with `time`,and potentially `point` and `value` properties depending on thetrack. `point` is available if the audio event is related to adata point. `value` is available if the track is used as acontext track, and `valueInterval` is used.
		/// </summary>
		public PlotOptionsPcSonificationDefaultInstrumentOptionsActiveWhen ActiveWhen { get; set; }
		 

		/// <summary>
		/// Instrument to use for playing.Can either be a string referencing a synth preset, or it can bea synth configuration object.
		/// </summary>
		public Object Instrument { get; set; }
		 

		/// <summary>
		/// Instrument to use for playing.Can either be a string referencing a synth preset, or it can bea synth configuration object.
		/// </summary>
		public string InstrumentString { get; set; }
		 

		/// <summary>
		/// Mapping options for the audio parameters.All parameters can be either: - A string, referencing a point property to map to. - A number, setting the value of the audio parameter directly. - A callback function, returning the value programmatically. - An object defining detailed configuration of the mapping.If a function is used, it should return the desired value forthe audio parameter. The function is called for each audio eventto be played, and receives a context object parameter with`time`, and potentially `point` and `value` depending on thetrack. `point` is available if the audio event is related to adata point, and `value` is available if the track is used for acontext track using `valueInterval`.
		/// </summary>
		public PlotOptionsPcSonificationDefaultInstrumentOptionsMapping Mapping { get; set; }
		 

		/// <summary>
		/// Name to use for a track when exporting to MIDI.By default it uses the series name if the track is related toa series.
		/// </summary>
		public string MidiName { get; set; }
		 

		/// <summary>
		/// Options for point grouping, specifically for instrument tracks.
		/// </summary>
		public PlotOptionsPcSonificationDefaultInstrumentOptionsPointGrouping PointGrouping { get; set; }
		 

		/// <summary>
		/// Round pitch mapping to musical notes.If `false`, will play the exact mapped note, even if it is outof tune compared to the musical notes as defined by 440Hzstandard tuning.
		/// </summary>
		public bool? RoundToMusicalNotes { get; set; }
		 

		/// <summary>
		/// Show play marker (tooltip and/or crosshair) for a track.
		/// </summary>
		public bool? ShowPlayMarker { get; set; }
		 

		/// <summary>
		/// Type of track. Always `"instrument"` for instrument tracks, and`"speech"` for speech tracks.
		/// </summary>
		public PlotOptionsPcSonificationDefaultInstrumentOptionsType Type { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ActiveWhen != null) h.Add("activeWhen",ActiveWhen.ToHashtable(highstock));
			if (Instrument != null) h.Add("instrument",Instrument);
			if (InstrumentString != null) h.Add("instrument",InstrumentString);
			if (Mapping != null) h.Add("mapping",Mapping.ToHashtable(highstock));
			if (MidiName != null) h.Add("midiName",MidiName);
			if (PointGrouping != null) h.Add("pointGrouping",PointGrouping.ToHashtable(highstock));
			if (RoundToMusicalNotes != null) h.Add("roundToMusicalNotes",RoundToMusicalNotes);
			if (ShowPlayMarker != null) h.Add("showPlayMarker",ShowPlayMarker);
			if (Type != PlotOptionsPcSonificationDefaultInstrumentOptionsType.Null) h.Add("type", highstock.FirstCharacterToLower(Type.ToString()));
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
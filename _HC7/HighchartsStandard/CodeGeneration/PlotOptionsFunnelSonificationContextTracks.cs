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
	public partial class PlotOptionsFunnelSonificationContextTracks  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsFunnelSonificationContextTracks()
		{
		}	
		

		/// <summary>
		/// Define a condition for when a track should be active and not.Can either be a function callback or a configuration object.If a function is used, it should return a `boolean` for whetheror not the track should be active. The function is called foreach audio event, and receives a parameter object with `time`,and potentially `point` and `value` properties depending on thetrack. `point` is available if the audio event is related to adata point. `value` is available if the track is used as acontext track, and `valueInterval` is used.
		/// </summary>
		public PlotOptionsFunnelSonificationContextTracksActiveWhen ActiveWhen { get; set; }
		 

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
		public PlotOptionsFunnelSonificationContextTracksMapping Mapping { get; set; }
		 

		/// <summary>
		/// Name to use for a track when exporting to MIDI.By default it uses the series name if the track is related toa series.
		/// </summary>
		public string MidiName { get; set; }
		 

		/// <summary>
		/// Options for point grouping, specifically for instrument tracks.
		/// </summary>
		public PlotOptionsFunnelSonificationContextTracksPointGrouping PointGrouping { get; set; }
		 

		/// <summary>
		/// Round pitch mapping to musical notes.If `false`, will play the exact mapped note, even if it is outof tune compared to the musical notes as defined by 440Hzstandard tuning.
		/// </summary>
		public bool? RoundToMusicalNotes { get; set; }
		 

		/// <summary>
		/// Show play marker (tooltip and/or crosshair) for a track.
		/// </summary>
		public bool? ShowPlayMarker { get; set; }
		 

		/// <summary>
		/// Set a context track to play periodically every `timeInterval`milliseconds while the sonification is playing.
		/// </summary>
		public double? TimeInterval { get; set; }
		 

		/// <summary>
		/// Type of track. Always `"instrument"` for instrument tracks, and`"speech"` for speech tracks.
		/// </summary>
		public PlotOptionsFunnelSonificationContextTracksType Type { get; set; }
		 

		/// <summary>
		/// Set a context track to play periodically every `valueInterval`units of a data property `valueProp` while the sonification isplaying.For example, setting `valueProp` to `x` and `valueInterval` to 5will play the context track for every 5th X value.The context audio events will be mapped to time according to theprop value relative to the min/max values for that prop.
		/// </summary>
		public double? ValueInterval { get; set; }
		 

		/// <summary>
		/// How to map context events to time when using the `valueInterval`option.
		/// </summary>
		public PlotOptionsFunnelSonificationContextTracksValueMapFunction ValueMapFunction { get; set; }
		 

		/// <summary>
		/// The point property to play context for when using `valueInterval`.
		/// </summary>
		public string ValueProp { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ActiveWhen != null) h.Add("activeWhen",ActiveWhen.ToHashtable(highcharts));
			if (Instrument != null) h.Add("instrument",Instrument);
			if (InstrumentString != null) h.Add("instrument",InstrumentString);
			if (Mapping != null) h.Add("mapping",Mapping.ToHashtable(highcharts));
			if (MidiName != null) h.Add("midiName",MidiName);
			if (PointGrouping != null) h.Add("pointGrouping",PointGrouping.ToHashtable(highcharts));
			if (RoundToMusicalNotes != null) h.Add("roundToMusicalNotes",RoundToMusicalNotes);
			if (ShowPlayMarker != null) h.Add("showPlayMarker",ShowPlayMarker);
			if (TimeInterval != null) h.Add("timeInterval",TimeInterval);
			if (Type != PlotOptionsFunnelSonificationContextTracksType.Null) h.Add("type", highcharts.FirstCharacterToLower(Type.ToString()));
			if (ValueInterval != null) h.Add("valueInterval",ValueInterval);
			if (ValueMapFunction != PlotOptionsFunnelSonificationContextTracksValueMapFunction.Null) h.Add("valueMapFunction", highcharts.FirstCharacterToLower(ValueMapFunction.ToString()));
			if (ValueProp != null) h.Add("valueProp",ValueProp);
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
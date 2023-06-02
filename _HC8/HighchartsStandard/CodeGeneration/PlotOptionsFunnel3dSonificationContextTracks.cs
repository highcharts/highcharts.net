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
	public partial class PlotOptionsFunnel3dSonificationContextTracks  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsFunnel3dSonificationContextTracks()
		{
			ActiveWhen = ActiveWhen_DefaultValue = new PlotOptionsFunnel3dSonificationContextTracksActiveWhen();
			Instrument = Instrument_DefaultValue = null;
			InstrumentString = InstrumentString_DefaultValue = "null";
			Mapping = Mapping_DefaultValue = new PlotOptionsFunnel3dSonificationContextTracksMapping();
			MidiName = MidiName_DefaultValue = "";
			PointGrouping = PointGrouping_DefaultValue = new PlotOptionsFunnel3dSonificationContextTracksPointGrouping();
			RoundToMusicalNotes = RoundToMusicalNotes_DefaultValue = true;
			ShowPlayMarker = ShowPlayMarker_DefaultValue = true;
			TimeInterval = TimeInterval_DefaultValue = null;
			Type = Type_DefaultValue = PlotOptionsFunnel3dSonificationContextTracksType.Instrument;
			ValueInterval = ValueInterval_DefaultValue = null;
			ValueMapFunction = ValueMapFunction_DefaultValue = PlotOptionsFunnel3dSonificationContextTracksValueMapFunction.Linear;
			ValueProp = ValueProp_DefaultValue = "'x'";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Define a condition for when a track should be active and not.Can either be a function callback or a configuration object.If a function is used, it should return a `boolean` for whetheror not the track should be active. The function is called foreach audio event, and receives a parameter object with `time`,and potentially `point` and `value` properties depending on thetrack. `point` is available if the audio event is related to adata point. `value` is available if the track is used as acontext track, and `valueInterval` is used.
		/// </summary>
		public PlotOptionsFunnel3dSonificationContextTracksActiveWhen ActiveWhen { get; set; }
		private PlotOptionsFunnel3dSonificationContextTracksActiveWhen ActiveWhen_DefaultValue { get; set; }
		 

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
		public PlotOptionsFunnel3dSonificationContextTracksMapping Mapping { get; set; }
		private PlotOptionsFunnel3dSonificationContextTracksMapping Mapping_DefaultValue { get; set; }
		 

		/// <summary>
		/// Name to use for a track when exporting to MIDI.By default it uses the series name if the track is related toa series.
		/// </summary>
		public string MidiName { get; set; }
		private string MidiName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for point grouping, specifically for instrument tracks.
		/// </summary>
		public PlotOptionsFunnel3dSonificationContextTracksPointGrouping PointGrouping { get; set; }
		private PlotOptionsFunnel3dSonificationContextTracksPointGrouping PointGrouping_DefaultValue { get; set; }
		 

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
		/// Set a context track to play periodically every `timeInterval`milliseconds while the sonification is playing.
		/// </summary>
		public double? TimeInterval { get; set; }
		private double? TimeInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// Type of track. Always `"instrument"` for instrument tracks, and`"speech"` for speech tracks.
		/// </summary>
		public PlotOptionsFunnel3dSonificationContextTracksType Type { get; set; }
		private PlotOptionsFunnel3dSonificationContextTracksType Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set a context track to play periodically every `valueInterval`units of a data property `valueProp` while the sonification isplaying.For example, setting `valueProp` to `x` and `valueInterval` to 5will play the context track for every 5th X value.The context audio events will be mapped to time according to theprop value relative to the min/max values for that prop.
		/// </summary>
		public double? ValueInterval { get; set; }
		private double? ValueInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to map context events to time when using the `valueInterval`option.
		/// </summary>
		public PlotOptionsFunnel3dSonificationContextTracksValueMapFunction ValueMapFunction { get; set; }
		private PlotOptionsFunnel3dSonificationContextTracksValueMapFunction ValueMapFunction_DefaultValue { get; set; }
		 

		/// <summary>
		/// The point property to play context for when using `valueInterval`.
		/// </summary>
		public string ValueProp { get; set; }
		private string ValueProp_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (ActiveWhen.IsDirty(highcharts)) h.Add("activeWhen",ActiveWhen.ToHashtable(highcharts));
			if (Instrument != Instrument_DefaultValue) h.Add("instrument",Instrument);
			if (InstrumentString != InstrumentString_DefaultValue) h.Add("instrument",InstrumentString);
			if (Mapping.IsDirty(highcharts)) h.Add("mapping",Mapping.ToHashtable(highcharts));
			if (MidiName != MidiName_DefaultValue) h.Add("midiName",MidiName);
			if (PointGrouping.IsDirty(highcharts)) h.Add("pointGrouping",PointGrouping.ToHashtable(highcharts));
			if (RoundToMusicalNotes != RoundToMusicalNotes_DefaultValue) h.Add("roundToMusicalNotes",RoundToMusicalNotes);
			if (ShowPlayMarker != ShowPlayMarker_DefaultValue) h.Add("showPlayMarker",ShowPlayMarker);
			if (TimeInterval != TimeInterval_DefaultValue) h.Add("timeInterval",TimeInterval);
			if (Type != Type_DefaultValue) h.Add("type", highcharts.FirstCharacterToLower(Type.ToString()));
			if (ValueInterval != ValueInterval_DefaultValue) h.Add("valueInterval",ValueInterval);
			if (ValueMapFunction != ValueMapFunction_DefaultValue) h.Add("valueMapFunction", highcharts.FirstCharacterToLower(ValueMapFunction.ToString()));
			if (ValueProp != ValueProp_DefaultValue) h.Add("valueProp",ValueProp);
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
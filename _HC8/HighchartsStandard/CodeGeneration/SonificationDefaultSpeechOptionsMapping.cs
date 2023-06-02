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
	public partial class SonificationDefaultSpeechOptionsMapping  : BaseObject
	{
		Hashtable h = new Hashtable();

		public SonificationDefaultSpeechOptionsMapping()
		{
			Frequency = Frequency_DefaultValue = new SonificationDefaultSpeechOptionsMappingFrequency();
			GapBetweenNotes = GapBetweenNotes_DefaultValue = new SonificationDefaultSpeechOptionsMappingGapBetweenNotes();
			Highpass = Highpass_DefaultValue = new SonificationDefaultSpeechOptionsMappingHighpass();
			Lowpass = Lowpass_DefaultValue = new SonificationDefaultSpeechOptionsMappingLowpass();
			NoteDuration = NoteDuration_DefaultValue = new SonificationDefaultSpeechOptionsMappingNoteDuration();
			Pan = Pan_DefaultValue = new SonificationDefaultSpeechOptionsMappingPan();
			Pitch = Pitch_DefaultValue = new SonificationDefaultSpeechOptionsMappingPitch();
			PitchString = PitchString_DefaultValue = "null";
			PitchNumber = PitchNumber_DefaultValue = null;
			PlayDelay = PlayDelay_DefaultValue = new SonificationDefaultSpeechOptionsMappingPlayDelay();
			Rate = Rate_DefaultValue = new SonificationDefaultSpeechOptionsMappingRate();
			Text = Text_DefaultValue = "";
			Time = Time_DefaultValue = new SonificationDefaultSpeechOptionsMappingTime();
			TimeNumber = TimeNumber_DefaultValue = null;
			Tremolo = Tremolo_DefaultValue = new SonificationDefaultSpeechOptionsMappingTremolo();
			Volume = Volume_DefaultValue = new SonificationDefaultSpeechOptionsMappingVolume();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Frequency in Hertz of notes. Overrides pitch mapping if set.
		/// </summary>
		public SonificationDefaultSpeechOptionsMappingFrequency Frequency { get; set; }
		private SonificationDefaultSpeechOptionsMappingFrequency Frequency_DefaultValue { get; set; }
		 

		/// <summary>
		/// Gap in milliseconds between notes if pitch is mapped to anarray of notes.Can be set to a fixed value, a prop to map to, a function,or a mapping object.
		/// </summary>
		public SonificationDefaultSpeechOptionsMappingGapBetweenNotes GapBetweenNotes { get; set; }
		private SonificationDefaultSpeechOptionsMappingGapBetweenNotes GapBetweenNotes_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mapping options for the highpass filter.A highpass filter lets high frequencies through, but stopslow frequencies, making the sound thinner.
		/// </summary>
		public SonificationDefaultSpeechOptionsMappingHighpass Highpass { get; set; }
		private SonificationDefaultSpeechOptionsMappingHighpass Highpass_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mapping options for the lowpass filter.A lowpass filter lets low frequencies through, but stops highfrequencies, making the sound more dull.
		/// </summary>
		public SonificationDefaultSpeechOptionsMappingLowpass Lowpass { get; set; }
		private SonificationDefaultSpeechOptionsMappingLowpass Lowpass_DefaultValue { get; set; }
		 

		/// <summary>
		/// Note duration determines for how long a note plays, inmilliseconds.It only affects instruments that are able to playcontinuous sustained notes. Examples of these instrumentsfrom the presets include `flute`, `saxophone`, `trumpet`,`sawsynth`, `wobble`, `basic1`, `basic2`, `sine`,`sineGlide`, `triangle`, `square`, `sawtooth`, `noise`,`filteredNoise`, and `wind`.Can be set to a fixed value, a prop to map to, a function,or a mapping object.
		/// </summary>
		public SonificationDefaultSpeechOptionsMappingNoteDuration NoteDuration { get; set; }
		private SonificationDefaultSpeechOptionsMappingNoteDuration NoteDuration_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pan refers to the stereo panning position of the sound.It is defined from -1 (left) to 1 (right).By default it is mapped to `x`, making the sound move fromleft to right as the chart plays.Can be set to a fixed value, a prop to map to, a function,or a mapping object.
		/// </summary>
		public SonificationDefaultSpeechOptionsMappingPan Pan { get; set; }
		private SonificationDefaultSpeechOptionsMappingPan Pan_DefaultValue { get; set; }
		 

		/// <summary>
		/// Speech pitch (how high/low the voice is) multiplier.
		/// </summary>
		public SonificationDefaultSpeechOptionsMappingPitch Pitch { get; set; }
		private SonificationDefaultSpeechOptionsMappingPitch Pitch_DefaultValue { get; set; }
		 

		/// <summary>
		/// Speech pitch (how high/low the voice is) multiplier.
		/// </summary>
		public string PitchString { get; set; }
		private string PitchString_DefaultValue { get; set; }
		 

		/// <summary>
		/// Speech pitch (how high/low the voice is) multiplier.
		/// </summary>
		public double? PitchNumber { get; set; }
		private double? PitchNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Milliseconds to wait before playing, comes in addition tothe time determined by the `time` mapping.Can also be negative to play before the mapped time.
		/// </summary>
		public SonificationDefaultSpeechOptionsMappingPlayDelay PlayDelay { get; set; }
		private SonificationDefaultSpeechOptionsMappingPlayDelay PlayDelay_DefaultValue { get; set; }
		 

		/// <summary>
		/// Speech rate (speed) multiplier.
		/// </summary>
		public SonificationDefaultSpeechOptionsMappingRate Rate { get; set; }
		private SonificationDefaultSpeechOptionsMappingRate Rate_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text to announce for speech tracks. Can either be aformat string or a function.If it is a function, it should return the format string toannounce. The function is called for each audio event, andreceives a parameter object with `time`, and potentially`point` and `value` properties depending on the track.`point` is available if the audio event is related to a datapoint. `value` is available if the track is used as acontext track, and `valueInterval` is used.If it is a format string, in addition to normal stringcontent, format values can be accessed using bracketnotation. For example `"Value is {point.y}%"`.`time`, `point` and `value` are available to the formatstrings similarly to with functions. Nested properties canbe accessed with dot notation, for example`"Density: {point.options.custom.density}"`
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public SonificationDefaultSpeechOptionsMappingTime Time { get; set; }
		private SonificationDefaultSpeechOptionsMappingTime Time_DefaultValue { get; set; }
		 

		/// <summary>
		/// Time mapping determines what time each point plays. It isdefined as an offset in milliseconds, where 0 means itplays immediately when the chart is sonified.By default time is mapped to `x`, meaning points with thelowest `x` value plays first, and points with the highest`x` value plays last.Can be set to a fixed value, a prop to map to, a function,or a mapping object.
		/// </summary>
		public double? TimeNumber { get; set; }
		private double? TimeNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mapping options for tremolo effects.Tremolo is repeated changes of volume over time.
		/// </summary>
		public SonificationDefaultSpeechOptionsMappingTremolo Tremolo { get; set; }
		private SonificationDefaultSpeechOptionsMappingTremolo Tremolo_DefaultValue { get; set; }
		 

		/// <summary>
		/// Volume of the speech announcement.
		/// </summary>
		public SonificationDefaultSpeechOptionsMappingVolume Volume { get; set; }
		private SonificationDefaultSpeechOptionsMappingVolume Volume_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Frequency.IsDirty(highcharts)) h.Add("frequency",Frequency.ToHashtable(highcharts));
			if (GapBetweenNotes.IsDirty(highcharts)) h.Add("gapBetweenNotes",GapBetweenNotes.ToHashtable(highcharts));
			if (Highpass.IsDirty(highcharts)) h.Add("highpass",Highpass.ToHashtable(highcharts));
			if (Lowpass.IsDirty(highcharts)) h.Add("lowpass",Lowpass.ToHashtable(highcharts));
			if (NoteDuration.IsDirty(highcharts)) h.Add("noteDuration",NoteDuration.ToHashtable(highcharts));
			if (Pan.IsDirty(highcharts)) h.Add("pan",Pan.ToHashtable(highcharts));
			if (Pitch.IsDirty(highcharts)) h.Add("pitch",Pitch.ToHashtable(highcharts));
			if (PitchString != PitchString_DefaultValue) h.Add("pitch",PitchString);
			if (PitchNumber != PitchNumber_DefaultValue) h.Add("pitch",PitchNumber);
			if (PlayDelay.IsDirty(highcharts)) h.Add("playDelay",PlayDelay.ToHashtable(highcharts));
			if (Rate.IsDirty(highcharts)) h.Add("rate",Rate.ToHashtable(highcharts));
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Time.IsDirty(highcharts)) h.Add("time",Time.ToHashtable(highcharts));
			if (TimeNumber != TimeNumber_DefaultValue) h.Add("time",TimeNumber);
			if (Tremolo.IsDirty(highcharts)) h.Add("tremolo",Tremolo.ToHashtable(highcharts));
			if (Volume.IsDirty(highcharts)) h.Add("volume",Volume.ToHashtable(highcharts));
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
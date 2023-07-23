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
	public partial class PlotOptionsLineSonificationContextTracksMapping  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsLineSonificationContextTracksMapping()
		{
			Frequency = Frequency_DefaultValue = new PlotOptionsLineSonificationContextTracksMappingFrequency();
			GapBetweenNotes = GapBetweenNotes_DefaultValue = new PlotOptionsLineSonificationContextTracksMappingGapBetweenNotes();
			Highpass = Highpass_DefaultValue = new PlotOptionsLineSonificationContextTracksMappingHighpass();
			Lowpass = Lowpass_DefaultValue = new PlotOptionsLineSonificationContextTracksMappingLowpass();
			NoteDuration = NoteDuration_DefaultValue = new PlotOptionsLineSonificationContextTracksMappingNoteDuration();
			Pan = Pan_DefaultValue = new PlotOptionsLineSonificationContextTracksMappingPan();
			Pitch = Pitch_DefaultValue = new PlotOptionsLineSonificationContextTracksMappingPitch();
			PitchString = PitchString_DefaultValue = "null";
			PitchNumber = PitchNumber_DefaultValue = null;
			PlayDelay = PlayDelay_DefaultValue = new PlotOptionsLineSonificationContextTracksMappingPlayDelay();
			Time = Time_DefaultValue = "'x'";
			TimeNumber = TimeNumber_DefaultValue = null;
			Tremolo = Tremolo_DefaultValue = new PlotOptionsLineSonificationContextTracksMappingTremolo();
			Volume = Volume_DefaultValue = new PlotOptionsLineSonificationContextTracksMappingVolume();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Frequency in Hertz of notes. Overrides pitch mapping if set.
		/// </summary>
		public PlotOptionsLineSonificationContextTracksMappingFrequency Frequency { get; set; }
		private PlotOptionsLineSonificationContextTracksMappingFrequency Frequency_DefaultValue { get; set; }
		 

		/// <summary>
		/// Gap in milliseconds between notes if pitch is mapped to anarray of notes.Can be set to a fixed value, a prop to map to, a function,or a mapping object.
		/// </summary>
		public PlotOptionsLineSonificationContextTracksMappingGapBetweenNotes GapBetweenNotes { get; set; }
		private PlotOptionsLineSonificationContextTracksMappingGapBetweenNotes GapBetweenNotes_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mapping options for the highpass filter.A highpass filter lets high frequencies through, but stopslow frequencies, making the sound thinner.
		/// </summary>
		public PlotOptionsLineSonificationContextTracksMappingHighpass Highpass { get; set; }
		private PlotOptionsLineSonificationContextTracksMappingHighpass Highpass_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mapping options for the lowpass filter.A lowpass filter lets low frequencies through, but stops highfrequencies, making the sound more dull.
		/// </summary>
		public PlotOptionsLineSonificationContextTracksMappingLowpass Lowpass { get; set; }
		private PlotOptionsLineSonificationContextTracksMappingLowpass Lowpass_DefaultValue { get; set; }
		 

		/// <summary>
		/// Note duration determines for how long a note plays, inmilliseconds.It only affects instruments that are able to playcontinuous sustained notes. Examples of these instrumentsfrom the presets include `flute`, `saxophone`, `trumpet`,`sawsynth`, `wobble`, `basic1`, `basic2`, `sine`,`sineGlide`, `triangle`, `square`, `sawtooth`, `noise`,`filteredNoise`, and `wind`.Can be set to a fixed value, a prop to map to, a function,or a mapping object.
		/// </summary>
		public PlotOptionsLineSonificationContextTracksMappingNoteDuration NoteDuration { get; set; }
		private PlotOptionsLineSonificationContextTracksMappingNoteDuration NoteDuration_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pan refers to the stereo panning position of the sound.It is defined from -1 (left) to 1 (right).By default it is mapped to `x`, making the sound move fromleft to right as the chart plays.Can be set to a fixed value, a prop to map to, a function,or a mapping object.
		/// </summary>
		public PlotOptionsLineSonificationContextTracksMappingPan Pan { get; set; }
		private PlotOptionsLineSonificationContextTracksMappingPan Pan_DefaultValue { get; set; }
		 

		/// <summary>
		/// Musical pitch refers to how high or low notes are played.By default it is mapped to `y` so low `y` values are playedwith a lower pitch, and high values are played with a higherpitch.Pitch mapping has a few extra features compared to otheraudio parameters.Firstly, it accepts not only number values, but also stringvalues denoting note names. These are given in the form`<note><octave>`, for example `"c6"` or `"F#2"`.Secondly, it is possible to map pitch to an array of notes.In this case, the `[gapBetweenNotes](#sonification.defaultInstrumentOptions.mapping.gapBetweenNotes)`mapping determines the delay between these notes.Thirdly, it is possible to define a musical scale to followwhen mapping.Can be set to a fixed value, an array, a prop to map to, afunction, or a mapping object.
		/// </summary>
		public PlotOptionsLineSonificationContextTracksMappingPitch Pitch { get; set; }
		private PlotOptionsLineSonificationContextTracksMappingPitch Pitch_DefaultValue { get; set; }
		 

		/// <summary>
		/// Musical pitch refers to how high or low notes are played.By default it is mapped to `y` so low `y` values are playedwith a lower pitch, and high values are played with a higherpitch.Pitch mapping has a few extra features compared to otheraudio parameters.Firstly, it accepts not only number values, but also stringvalues denoting note names. These are given in the form`<note><octave>`, for example `"c6"` or `"F#2"`.Secondly, it is possible to map pitch to an array of notes.In this case, the `[gapBetweenNotes](#sonification.defaultInstrumentOptions.mapping.gapBetweenNotes)`mapping determines the delay between these notes.Thirdly, it is possible to define a musical scale to followwhen mapping.Can be set to a fixed value, an array, a prop to map to, afunction, or a mapping object.
		/// </summary>
		public string PitchString { get; set; }
		private string PitchString_DefaultValue { get; set; }
		 

		/// <summary>
		/// Musical pitch refers to how high or low notes are played.By default it is mapped to `y` so low `y` values are playedwith a lower pitch, and high values are played with a higherpitch.Pitch mapping has a few extra features compared to otheraudio parameters.Firstly, it accepts not only number values, but also stringvalues denoting note names. These are given in the form`<note><octave>`, for example `"c6"` or `"F#2"`.Secondly, it is possible to map pitch to an array of notes.In this case, the `[gapBetweenNotes](#sonification.defaultInstrumentOptions.mapping.gapBetweenNotes)`mapping determines the delay between these notes.Thirdly, it is possible to define a musical scale to followwhen mapping.Can be set to a fixed value, an array, a prop to map to, afunction, or a mapping object.
		/// </summary>
		public double? PitchNumber { get; set; }
		private double? PitchNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Milliseconds to wait before playing, comes in addition tothe time determined by the `time` mapping.Can also be negative to play before the mapped time.
		/// </summary>
		public PlotOptionsLineSonificationContextTracksMappingPlayDelay PlayDelay { get; set; }
		private PlotOptionsLineSonificationContextTracksMappingPlayDelay PlayDelay_DefaultValue { get; set; }
		 

		/// <summary>
		/// Time mapping determines what time each point plays. It isdefined as an offset in milliseconds, where 0 means itplays immediately when the chart is sonified.By default time is mapped to `x`, meaning points with thelowest `x` value plays first, and points with the highest`x` value plays last.Can be set to a fixed value, a prop to map to, a function,or a mapping object.
		/// </summary>
		public string Time { get; set; }
		private string Time_DefaultValue { get; set; }
		 

		/// <summary>
		/// Time mapping determines what time each point plays. It isdefined as an offset in milliseconds, where 0 means itplays immediately when the chart is sonified.By default time is mapped to `x`, meaning points with thelowest `x` value plays first, and points with the highest`x` value plays last.Can be set to a fixed value, a prop to map to, a function,or a mapping object.
		/// </summary>
		public double? TimeNumber { get; set; }
		private double? TimeNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mapping options for tremolo effects.Tremolo is repeated changes of volume over time.
		/// </summary>
		public PlotOptionsLineSonificationContextTracksMappingTremolo Tremolo { get; set; }
		private PlotOptionsLineSonificationContextTracksMappingTremolo Tremolo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The volume of notes, from 0 to 1.
		/// </summary>
		public PlotOptionsLineSonificationContextTracksMappingVolume Volume { get; set; }
		private PlotOptionsLineSonificationContextTracksMappingVolume Volume_DefaultValue { get; set; }
		 

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
			if (Time != Time_DefaultValue) h.Add("time",Time);
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
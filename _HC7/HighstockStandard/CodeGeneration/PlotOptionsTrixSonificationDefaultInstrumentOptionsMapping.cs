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
	public partial class PlotOptionsTrixSonificationDefaultInstrumentOptionsMapping  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTrixSonificationDefaultInstrumentOptionsMapping()
		{
			Frequency = Frequency_DefaultValue = new PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingFrequency();
			GapBetweenNotes = GapBetweenNotes_DefaultValue = new PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingGapBetweenNotes();
			Highpass = Highpass_DefaultValue = new PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingHighpass();
			Lowpass = Lowpass_DefaultValue = new PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingLowpass();
			NoteDuration = NoteDuration_DefaultValue = new PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingNoteDuration();
			Pan = Pan_DefaultValue = new PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingPan();
			Pitch = Pitch_DefaultValue = new PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingPitch();
			PitchString = PitchString_DefaultValue = "null";
			PitchNumber = PitchNumber_DefaultValue = null;
			PlayDelay = PlayDelay_DefaultValue = new PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingPlayDelay();
			Time = Time_DefaultValue = new PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingTime();
			TimeString = TimeString_DefaultValue = "null";
			TimeNumber = TimeNumber_DefaultValue = null;
			Tremolo = Tremolo_DefaultValue = new PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingTremolo();
			Volume = Volume_DefaultValue = new PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingVolume();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Frequency in Hertz of notes. Overrides pitch mapping if set.
		/// </summary>
		public PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingFrequency Frequency { get; set; }
		private PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingFrequency Frequency_DefaultValue { get; set; }
		 

		/// <summary>
		/// Gap in milliseconds between notes if pitch is mapped to anarray of notes.Can be set to a fixed value, a prop to map to, a function,or a mapping object.
		/// </summary>
		public PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingGapBetweenNotes GapBetweenNotes { get; set; }
		private PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingGapBetweenNotes GapBetweenNotes_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mapping options for the highpass filter.A highpass filter lets high frequencies through, but stopslow frequencies, making the sound thinner.
		/// </summary>
		public PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingHighpass Highpass { get; set; }
		private PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingHighpass Highpass_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mapping options for the lowpass filter.A lowpass filter lets low frequencies through, but stops highfrequencies, making the sound more dull.
		/// </summary>
		public PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingLowpass Lowpass { get; set; }
		private PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingLowpass Lowpass_DefaultValue { get; set; }
		 

		/// <summary>
		/// Note duration determines for how long a note plays, inmilliseconds.It only affects instruments that are able to playcontinuous sustained notes. Examples of these instrumentsfrom the presets include `flute`, `saxophone`, `trumpet`,`sawsynth`, `wobble`, `basic1`, `basic2`, `sine`,`sineGlide`, `triangle`, `square`, `sawtooth`, `noise`,`filteredNoise`, and `wind`.Can be set to a fixed value, a prop to map to, a function,or a mapping object.
		/// </summary>
		public PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingNoteDuration NoteDuration { get; set; }
		private PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingNoteDuration NoteDuration_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pan refers to the stereo panning position of the sound.It is defined from -1 (left) to 1 (right).By default it is mapped to `x`, making the sound move fromleft to right as the chart plays.Can be set to a fixed value, a prop to map to, a function,or a mapping object.
		/// </summary>
		public PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingPan Pan { get; set; }
		private PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingPan Pan_DefaultValue { get; set; }
		 

		/// <summary>
		/// Musical pitch refers to how high or low notes are played.By default it is mapped to `y` so low `y` values are playedwith a lower pitch, and high values are played with a higherpitch.Pitch mapping has a few extra features compared to otheraudio parameters.Firstly, it accepts not only number values, but also stringvalues denoting note names. These are given in the form`<note><octave>`, for example `"c6"` or `"F#2"`.Secondly, it is possible to map pitch to an array of notes.In this case, the `[gapBetweenNotes](#sonification.defaultInstrumentOptions.mapping.gapBetweenNotes)`mapping determines the delay between these notes.Thirdly, it is possible to define a musical scale to followwhen mapping.Can be set to a fixed value, an array, a prop to map to, afunction, or a mapping object.
		/// </summary>
		public PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingPitch Pitch { get; set; }
		private PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingPitch Pitch_DefaultValue { get; set; }
		 

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
		public PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingPlayDelay PlayDelay { get; set; }
		private PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingPlayDelay PlayDelay_DefaultValue { get; set; }
		 

		/// <summary>
		/// Time mapping determines what time each point plays. It isdefined as an offset in milliseconds, where 0 means itplays immediately when the chart is sonified.By default time is mapped to `x`, meaning points with thelowest `x` value plays first, and points with the highest`x` value plays last.Can be set to a fixed value, a prop to map to, a function,or a mapping object.
		/// </summary>
		public PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingTime Time { get; set; }
		private PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingTime Time_DefaultValue { get; set; }
		 

		/// <summary>
		/// Time mapping determines what time each point plays. It isdefined as an offset in milliseconds, where 0 means itplays immediately when the chart is sonified.By default time is mapped to `x`, meaning points with thelowest `x` value plays first, and points with the highest`x` value plays last.Can be set to a fixed value, a prop to map to, a function,or a mapping object.
		/// </summary>
		public string TimeString { get; set; }
		private string TimeString_DefaultValue { get; set; }
		 

		/// <summary>
		/// Time mapping determines what time each point plays. It isdefined as an offset in milliseconds, where 0 means itplays immediately when the chart is sonified.By default time is mapped to `x`, meaning points with thelowest `x` value plays first, and points with the highest`x` value plays last.Can be set to a fixed value, a prop to map to, a function,or a mapping object.
		/// </summary>
		public double? TimeNumber { get; set; }
		private double? TimeNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mapping options for tremolo effects.Tremolo is repeated changes of volume over time.
		/// </summary>
		public PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingTremolo Tremolo { get; set; }
		private PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingTremolo Tremolo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The volume of notes, from 0 to 1.
		/// </summary>
		public PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingVolume Volume { get; set; }
		private PlotOptionsTrixSonificationDefaultInstrumentOptionsMappingVolume Volume_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Frequency.IsDirty(highstock)) h.Add("frequency",Frequency.ToHashtable(highstock));
			if (GapBetweenNotes.IsDirty(highstock)) h.Add("gapBetweenNotes",GapBetweenNotes.ToHashtable(highstock));
			if (Highpass.IsDirty(highstock)) h.Add("highpass",Highpass.ToHashtable(highstock));
			if (Lowpass.IsDirty(highstock)) h.Add("lowpass",Lowpass.ToHashtable(highstock));
			if (NoteDuration.IsDirty(highstock)) h.Add("noteDuration",NoteDuration.ToHashtable(highstock));
			if (Pan.IsDirty(highstock)) h.Add("pan",Pan.ToHashtable(highstock));
			if (Pitch.IsDirty(highstock)) h.Add("pitch",Pitch.ToHashtable(highstock));
			if (PitchString != PitchString_DefaultValue) h.Add("pitch",PitchString);
			if (PitchNumber != PitchNumber_DefaultValue) h.Add("pitch",PitchNumber);
			if (PlayDelay.IsDirty(highstock)) h.Add("playDelay",PlayDelay.ToHashtable(highstock));
			if (Time.IsDirty(highstock)) h.Add("time",Time.ToHashtable(highstock));
			if (TimeString != TimeString_DefaultValue) h.Add("time",TimeString);
			if (TimeNumber != TimeNumber_DefaultValue) h.Add("time",TimeNumber);
			if (Tremolo.IsDirty(highstock)) h.Add("tremolo",Tremolo.ToHashtable(highstock));
			if (Volume.IsDirty(highstock)) h.Add("volume",Volume.ToHashtable(highstock));
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
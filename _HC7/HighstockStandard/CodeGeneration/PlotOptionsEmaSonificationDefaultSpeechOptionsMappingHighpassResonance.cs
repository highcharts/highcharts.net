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
	public partial class PlotOptionsEmaSonificationDefaultSpeechOptionsMappingHighpassResonance  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsEmaSonificationDefaultSpeechOptionsMappingHighpassResonance()
		{
			MapFunction = MapFunction_DefaultValue = PlotOptionsEmaSonificationDefaultSpeechOptionsMappingHighpassResonanceMapFunction.Linear;
			MapTo = MapTo_DefaultValue = "";
			Max = Max_DefaultValue = null;
			Min = Min_DefaultValue = null;
			Value = Value_DefaultValue = null;
			Within = Within_DefaultValue = PlotOptionsEmaSonificationDefaultSpeechOptionsMappingHighpassResonanceWithin.Chart;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// How to perform the mapping.
		/// </summary>
		public PlotOptionsEmaSonificationDefaultSpeechOptionsMappingHighpassResonanceMapFunction MapFunction { get; set; }
		private PlotOptionsEmaSonificationDefaultSpeechOptionsMappingHighpassResonanceMapFunction MapFunction_DefaultValue { get; set; }
		 

		/// <summary>
		/// A point property to map the mapping parameter to.A negative sign `-` can be placed before the property nameto make mapping inverted.
		/// </summary>
		public string MapTo { get; set; }
		private string MapTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The maximum value for the audio parameter. This is thehighest value the audio parameter will be mapped to.
		/// </summary>
		public double? Max { get; set; }
		private double? Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum value for the audio parameter. This is thelowest value the audio parameter will be mapped to.
		/// </summary>
		public double? Min { get; set; }
		private double? Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// A fixed value to use for the prop when mapping.For example, if mapping to `y`, setting value to `4` willmap as if all points had a y value of 4.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// What data values to map the parameter within.Mapping within `"series"` will make the lowest value pointin the series map to the min audio parameter value, and thehighest value will map to the max audio parameter.Mapping within `"chart"` will make the lowest value point inthe whole chart map to the min audio parameter value, andthe highest value in the whole chart will map to the maxaudio parameter.You can also map within the X or Y axis of each series.
		/// </summary>
		public PlotOptionsEmaSonificationDefaultSpeechOptionsMappingHighpassResonanceWithin Within { get; set; }
		private PlotOptionsEmaSonificationDefaultSpeechOptionsMappingHighpassResonanceWithin Within_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (MapFunction != MapFunction_DefaultValue) h.Add("mapFunction", highstock.FirstCharacterToLower(MapFunction.ToString()));
			if (MapTo != MapTo_DefaultValue) h.Add("mapTo",MapTo);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Within != Within_DefaultValue) h.Add("within", highstock.FirstCharacterToLower(Within.ToString()));
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
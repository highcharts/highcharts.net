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
	public partial class DemaSeriesSonificationTracksMappingVolume  : BaseObject
	{
		Hashtable h = new Hashtable();

		public DemaSeriesSonificationTracksMappingVolume()
		{
		}	
		

		/// <summary>
		/// How to perform the mapping.
		/// </summary>
		public DemaSeriesSonificationTracksMappingVolumeMapFunction MapFunction { get; set; }
		 

		/// <summary>
		/// A point property to map the mapping parameter to.A negative sign `-` can be placed before the property nameto make mapping inverted.
		/// </summary>
		public string MapTo { get; set; }
		 

		/// <summary>
		/// The maximum value for the audio parameter. This is thehighest value the audio parameter will be mapped to.
		/// </summary>
		public double? Max { get; set; }
		 

		/// <summary>
		/// The minimum value for the audio parameter. This is thelowest value the audio parameter will be mapped to.
		/// </summary>
		public double? Min { get; set; }
		 

		/// <summary>
		/// A fixed value to use for the prop when mapping.For example, if mapping to `y`, setting value to `4` willmap as if all points had a y value of 4.
		/// </summary>
		public double? Value { get; set; }
		 

		/// <summary>
		/// What data values to map the parameter within.Mapping within `"series"` will make the lowest value pointin the series map to the min audio parameter value, and thehighest value will map to the max audio parameter.Mapping within `"chart"` will make the lowest value point inthe whole chart map to the min audio parameter value, andthe highest value in the whole chart will map to the maxaudio parameter.You can also map within the X or Y axis of each series.
		/// </summary>
		public DemaSeriesSonificationTracksMappingVolumeWithin Within { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (MapFunction != DemaSeriesSonificationTracksMappingVolumeMapFunction.Null) h.Add("mapFunction", highstock.FirstCharacterToLower(MapFunction.ToString()));
			if (MapTo != null) h.Add("mapTo",MapTo);
			if (Max != null) h.Add("max",Max);
			if (Min != null) h.Add("min",Min);
			if (Value != null) h.Add("value",Value);
			if (Within != DemaSeriesSonificationTracksMappingVolumeWithin.Null) h.Add("within", highstock.FirstCharacterToLower(Within.ToString()));
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
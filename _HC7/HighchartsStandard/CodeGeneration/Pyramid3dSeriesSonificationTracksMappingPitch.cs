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
	public partial class Pyramid3dSeriesSonificationTracksMappingPitch  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Pyramid3dSeriesSonificationTracksMappingPitch()
		{
		}	
		

		/// <summary>
		/// How to perform the mapping.
		/// </summary>
		public Pyramid3dSeriesSonificationTracksMappingPitchMapFunction MapFunction { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MapTo { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Max { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Min { get; set; }
		 

		/// <summary>
		/// Map pitches to a musical scale. The scale is defined as anarray of semitone offsets from the root note.
		/// </summary>
		public List<double> Scale { get; set; }
		 

		/// <summary>
		/// A fixed value to use for the prop when mapping.For example, if mapping to `y`, setting value to `4` willmap as if all points had a y value of 4.
		/// </summary>
		public double? Value { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Within { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (MapFunction != Pyramid3dSeriesSonificationTracksMappingPitchMapFunction.Null) h.Add("mapFunction", highcharts.FirstCharacterToLower(MapFunction.ToString()));
			if (MapTo != null) h.Add("mapTo",MapTo);
			if (Max != null) h.Add("max",Max);
			if (Min != null) h.Add("min",Min);
			if (Scale != null) h.Add("scale",Scale);
			if (Value != null) h.Add("value",Value);
			if (Within != null) h.Add("within",Within);
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
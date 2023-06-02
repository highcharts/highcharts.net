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
	public partial class LineSeriesSonificationTracksMappingTremolo  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LineSeriesSonificationTracksMappingTremolo()
		{
			Depth = Depth_DefaultValue = new LineSeriesSonificationTracksMappingTremoloDepth();
			Speed = Speed_DefaultValue = new LineSeriesSonificationTracksMappingTremoloSpeed();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Map to tremolo depth, from 0 to 1.This determines the intensity of the tremolo effect, howmuch the volume changes.
		/// </summary>
		public LineSeriesSonificationTracksMappingTremoloDepth Depth { get; set; }
		private LineSeriesSonificationTracksMappingTremoloDepth Depth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Map to tremolo speed, from 0 to 1.This determines the speed of the tremolo effect, how fastthe volume changes.
		/// </summary>
		public LineSeriesSonificationTracksMappingTremoloSpeed Speed { get; set; }
		private LineSeriesSonificationTracksMappingTremoloSpeed Speed_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Depth.IsDirty(highcharts)) h.Add("depth",Depth.ToHashtable(highcharts));
			if (Speed.IsDirty(highcharts)) h.Add("speed",Speed.ToHashtable(highcharts));
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
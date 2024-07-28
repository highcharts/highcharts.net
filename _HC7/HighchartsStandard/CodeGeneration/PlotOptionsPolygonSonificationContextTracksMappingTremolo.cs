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
	public partial class PlotOptionsPolygonSonificationContextTracksMappingTremolo  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPolygonSonificationContextTracksMappingTremolo()
		{
		}	
		

		/// <summary>
		/// Map to tremolo depth, from 0 to 1.This determines the intensity of the tremolo effect, howmuch the volume changes.
		/// </summary>
		public PlotOptionsPolygonSonificationContextTracksMappingTremoloDepth Depth { get; set; }
		 

		/// <summary>
		/// Map to tremolo speed, from 0 to 1.This determines the speed of the tremolo effect, how fastthe volume changes.
		/// </summary>
		public PlotOptionsPolygonSonificationContextTracksMappingTremoloSpeed Speed { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Depth != null) h.Add("depth",Depth.ToHashtable(highcharts));
			if (Speed != null) h.Add("speed",Speed.ToHashtable(highcharts));
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
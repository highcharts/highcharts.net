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
	public partial class PlotOptionsColumnpyramidPoint  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsColumnpyramidPoint()
		{
			Events = Events_DefaultValue = new PlotOptionsColumnpyramidPointEvents();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Events for each single point.
		/// </summary>
		public PlotOptionsColumnpyramidPointEvents Events { get; set; }
		private PlotOptionsColumnpyramidPointEvents Events_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Events.IsDirty(ref highcharts)) h.Add("events",Events.ToHashtable(ref highcharts));
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
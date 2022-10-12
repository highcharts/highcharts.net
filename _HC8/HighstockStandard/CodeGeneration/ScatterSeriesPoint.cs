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
	public partial class ScatterSeriesPoint  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ScatterSeriesPoint()
		{
			Events = Events_DefaultValue = new ScatterSeriesPointEvents();
			
		}	
		

		/// <summary>
		/// Events for each single point.
		/// </summary>
		public ScatterSeriesPointEvents Events { get; set; }
		private ScatterSeriesPointEvents Events_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Events.IsDirty(ref highstock)) h.Add("events",Events.ToHashtable(ref highstock));
			

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
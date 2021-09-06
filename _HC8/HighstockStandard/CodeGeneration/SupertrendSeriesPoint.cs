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
	public partial class SupertrendSeriesPoint  : BaseObject
	{
		Hashtable h = new Hashtable();

		public SupertrendSeriesPoint()
		{
			Events = Events_DefaultValue = new SupertrendSeriesPointEvents();
			
		}	
		

		/// <summary>
		/// Events for each single point.
		/// </summary>
		public SupertrendSeriesPointEvents Events { get; set; }
		private SupertrendSeriesPointEvents Events_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Events.IsDirty(ref highstock)) h.Add("events",Events.ToHashtable(ref highstock));
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}
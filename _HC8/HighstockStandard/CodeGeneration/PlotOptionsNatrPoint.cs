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
	public partial class PlotOptionsNatrPoint  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsNatrPoint()
		{
			Events = Events_DefaultValue = new PlotOptionsNatrPointEvents();
			
		}	
		

		/// <summary>
		/// Events for each single point.
		/// </summary>
		public PlotOptionsNatrPointEvents Events { get; set; }
		private PlotOptionsNatrPointEvents Events_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Events.IsDirty(highstock)) h.Add("events",Events.ToHashtable(highstock));
			

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
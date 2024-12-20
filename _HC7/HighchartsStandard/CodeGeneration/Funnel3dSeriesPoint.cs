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
	public partial class Funnel3dSeriesPoint  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Funnel3dSeriesPoint()
		{
		}	
		

		/// <summary>
		/// Events for each single point.
		/// </summary>
		public Funnel3dSeriesPointEvents Events { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Events != null) h.Add("events",Events.ToHashtable(highcharts));
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
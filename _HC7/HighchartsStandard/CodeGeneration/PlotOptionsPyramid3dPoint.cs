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
	public partial class PlotOptionsPyramid3dPoint  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPyramid3dPoint()
		{
		}	
		

		/// <summary>
		/// Events for each single point.
		/// </summary>
		public PlotOptionsPyramid3dPointEvents Events { get; set; }
		  

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
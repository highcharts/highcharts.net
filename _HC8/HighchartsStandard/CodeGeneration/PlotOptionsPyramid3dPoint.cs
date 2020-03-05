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
			Events = Events_DefaultValue = new PlotOptionsPyramid3dPointEvents();
			
		}	
		

		/// <summary>
		/// Events for each single point.
		/// </summary>
		public PlotOptionsPyramid3dPointEvents Events { get; set; }
		private PlotOptionsPyramid3dPointEvents Events_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}
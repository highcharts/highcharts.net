using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class PlotOptionsAreasplinePoint 
	{
		public PlotOptionsAreasplinePoint()
		{
			Events = Events_DefaultValue = new PlotOptionsAreasplinePointEvents();
			
		}	
		

		/// <summary>
		/// Events for each single point
		/// </summary>
		public PlotOptionsAreasplinePointEvents Events { get; set; }
		private PlotOptionsAreasplinePointEvents Events_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}
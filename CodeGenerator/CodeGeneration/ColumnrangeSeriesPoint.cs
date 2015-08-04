using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highcharts.Web.Mvc
{
	public partial class ColumnrangeSeriesPoint  : BaseObject
	{
		public ColumnrangeSeriesPoint()
		{
			Events = Events_DefaultValue = new ColumnrangeSeriesPointEvents();
			
		}	
		

		/// <summary>
		/// Events for each single point
		/// </summary>
		public ColumnrangeSeriesPointEvents Events { get; set; }
		private ColumnrangeSeriesPointEvents Events_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class ZigzagSeriesIkhPoint  : BaseObject
	{
		public ZigzagSeriesIkhPoint()
		{
			Events = Events_DefaultValue = new ZigzagSeriesIkhPointEvents();
			
		}	
		

		/// <summary>
		/// <p>Events for each single point.</p>
		/// </summary>
		public ZigzagSeriesIkhPointEvents Events { get; set; }
		private ZigzagSeriesIkhPointEvents Events_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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
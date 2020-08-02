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
	public partial class AreasplinerangeSeriesMarkerStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AreasplinerangeSeriesMarkerStates()
		{
			Hover = Hover_DefaultValue = new Hashtable();
			Normal = Normal_DefaultValue = new Hashtable();
			Select = Select_DefaultValue = new Hashtable();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The hover state for a single point marker.
		/// </summary>
		public Hashtable Hover { get; set; }
		private Hashtable Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a single point marker. Currently onlyused for setting animation when returning to normal statefrom hover.
		/// </summary>
		public Hashtable Normal { get; set; }
		private Hashtable Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// The appearance of the point marker when selected. In order toallow a point to be selected, set the`series.allowPointSelect` option to true.
		/// </summary>
		public Hashtable Select { get; set; }
		private Hashtable Select_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Hover != Hover_DefaultValue) h.Add("hover",Hover);
			if (Normal != Normal_DefaultValue) h.Add("normal",Normal);
			if (Select != Select_DefaultValue) h.Add("select",Select);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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
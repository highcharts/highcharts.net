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
	public partial class NavigatorYAxisResizeControlledAxis  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigatorYAxisResizeControlledAxis()
		{
			Next = Next_DefaultValue = new List<string>();
			Prev = Prev_DefaultValue = new List<string>();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Array of axes that should move out of the way of resizingbeing done for the current axis. If not set, the next axiswill be used.
		/// </summary>
		public List<string> Next { get; set; }
		private List<string> Next_DefaultValue { get; set; }
		 

		/// <summary>
		/// Array of axes that should move with the current axiswhile resizing.
		/// </summary>
		public List<string> Prev { get; set; }
		private List<string> Prev_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Next != Next_DefaultValue) h.Add("next",Next);
			if (Prev != Prev_DefaultValue) h.Add("prev",Prev);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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
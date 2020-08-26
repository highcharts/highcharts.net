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
	public partial class NavigationAnnotationsOptionsEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationAnnotationsOptionsEvents()
		{
			Add = Add_DefaultValue = "";
			AfterUpdate = AfterUpdate_DefaultValue = "";
			Remove = Remove_DefaultValue = "";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Event callback when annotation is added to the chart.
		/// </summary>
		public string Add { get; set; }
		private string Add_DefaultValue { get; set; }
		 

		/// <summary>
		/// Event callback when annotation is updated (e.g. drag anddroppped or resized by control points).
		/// </summary>
		public string AfterUpdate { get; set; }
		private string AfterUpdate_DefaultValue { get; set; }
		 

		/// <summary>
		/// Event callback when annotation is removed from the chart.
		/// </summary>
		public string Remove { get; set; }
		private string Remove_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Add != Add_DefaultValue) { h.Add("add",Add); Highcharts.AddFunction("350cf6c3-d4cf-4692-9a0e-141e1dd2126b.add", Add); }  
			if (AfterUpdate != AfterUpdate_DefaultValue) { h.Add("afterUpdate",AfterUpdate); Highcharts.AddFunction("20d8d361-040a-4471-85a2-a8d8d63d5345.afterUpdate", AfterUpdate); }  
			if (Remove != Remove_DefaultValue) { h.Add("remove",Remove); Highcharts.AddFunction("f68ee33e-ee13-4ffa-8aa6-2846e1c071e1.remove", Remove); }  
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
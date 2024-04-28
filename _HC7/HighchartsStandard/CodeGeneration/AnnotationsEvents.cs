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
	public partial class AnnotationsEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsEvents()
		{
			Add = Add_DefaultValue = "";
			AfterUpdate = AfterUpdate_DefaultValue = "";
			Click = Click_DefaultValue = "";
			Drag = Drag_DefaultValue = "";
			Remove = Remove_DefaultValue = "";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Event callback when annotation is added to the chart.
		/// </summary>
		public string Add { get; set; }
		private string Add_DefaultValue { get; set; }
		 

		/// <summary>
		/// Event callback when annotation is updated (e.g. drag anddropped or resized by control points).
		/// </summary>
		public string AfterUpdate { get; set; }
		private string AfterUpdate_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the annotation is clicked.
		/// </summary>
		public string Click { get; set; }
		private string Click_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the annotation is dragged.
		/// </summary>
		public string Drag { get; set; }
		private string Drag_DefaultValue { get; set; }
		 

		/// <summary>
		/// Event callback when annotation is removed from the chart.
		/// </summary>
		public string Remove { get; set; }
		private string Remove_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Add != Add_DefaultValue) { h.Add("add",Add); highcharts.AddFunction("add", Add); }  
			if (AfterUpdate != AfterUpdate_DefaultValue) { h.Add("afterUpdate",AfterUpdate); highcharts.AddFunction("afterUpdate", AfterUpdate); }  
			if (Click != Click_DefaultValue) { h.Add("click",Click); highcharts.AddFunction("click", Click); }  
			if (Drag != Drag_DefaultValue) { h.Add("drag",Drag); highcharts.AddFunction("drag", Drag); }  
			if (Remove != Remove_DefaultValue) { h.Add("remove",Remove); highcharts.AddFunction("remove", Remove); }  
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}
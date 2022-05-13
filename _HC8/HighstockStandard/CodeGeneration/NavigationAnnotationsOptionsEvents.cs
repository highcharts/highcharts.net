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
	public partial class NavigationAnnotationsOptionsEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationAnnotationsOptionsEvents()
		{
			Add = Add_DefaultValue = "";
			AfterUpdate = AfterUpdate_DefaultValue = "";
			Click = Click_DefaultValue = "";
			Remove = Remove_DefaultValue = "";
			
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
		/// Fires when the annotation is clicked.
		/// </summary>
		public string Click { get; set; }
		private string Click_DefaultValue { get; set; }
		 

		/// <summary>
		/// Event callback when annotation is removed from the chart.
		/// </summary>
		public string Remove { get; set; }
		private string Remove_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Add != Add_DefaultValue) { h.Add("add",Add); Highstock.AddFunction("add", Add); }  
			if (AfterUpdate != AfterUpdate_DefaultValue) { h.Add("afterUpdate",AfterUpdate); Highstock.AddFunction("afterUpdate", AfterUpdate); }  
			if (Click != Click_DefaultValue) { h.Add("click",Click); Highstock.AddFunction("click", Click); }  
			if (Remove != Remove_DefaultValue) { h.Add("remove",Remove); Highstock.AddFunction("remove", Remove); }  
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}
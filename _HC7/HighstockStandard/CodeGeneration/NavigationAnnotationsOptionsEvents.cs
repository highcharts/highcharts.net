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
		}	
		

		/// <summary>
		/// Event callback when annotation is added to the chart.
		/// </summary>
		public string Add { get; set; }
		 

		/// <summary>
		/// Event callback when annotation is updated (e.g. drag anddropped or resized by control points).
		/// </summary>
		public string AfterUpdate { get; set; }
		 

		/// <summary>
		/// Fires when the annotation is clicked.
		/// </summary>
		public string Click { get; set; }
		 

		/// <summary>
		/// Fires when the annotation is dragged.
		/// </summary>
		public string Drag { get; set; }
		 

		/// <summary>
		/// Event callback when annotation is removed from the chart.
		/// </summary>
		public string Remove { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Add != null) { h.Add("add",Add); highstock.AddFunction("add", Add); }  
			if (AfterUpdate != null) { h.Add("afterUpdate",AfterUpdate); highstock.AddFunction("afterUpdate", AfterUpdate); }  
			if (Click != null) { h.Add("click",Click); highstock.AddFunction("click", Click); }  
			if (Drag != null) { h.Add("drag",Drag); highstock.AddFunction("drag", Drag); }  
			if (Remove != null) { h.Add("remove",Remove); highstock.AddFunction("remove", Remove); }  
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
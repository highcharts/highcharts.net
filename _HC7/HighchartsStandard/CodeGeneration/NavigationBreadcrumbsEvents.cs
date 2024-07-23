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
	public partial class NavigationBreadcrumbsEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationBreadcrumbsEvents()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Fires when clicking on the breadcrumbs button. Two arguments arepassed to the function. First breadcrumb button as an SVG element.Second is the breadcrumbs class, containing reference to the chart,series etc.```jsclick: function(button, breadcrumbs) {  console.log(button);}```Return false to stop default buttons click action.
		/// </summary>
		public string Click { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Click != null) { h.Add("click",Click); highcharts.AddFunction("click", Click); }  
			if (CustomFields.Count > 0)
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
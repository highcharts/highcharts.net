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
	public partial class PlotOptionsPiePointEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPiePointEvents()
		{
		}	
		

		/// <summary>
		/// Fires when the legend item belonging to the pie point (slice) isclicked. The `this` keyword refers to the point itself. Oneparameter, `event`, is passed to the function, containing commonevent information. The default action is to toggle the visibility ofthe point. This can be prevented by calling `event.preventDefault()`. **Note:** This option is deprecated in favor of[legend.events.itemClick](#legend.events.itemClick).
		/// </summary>
		public string LegendItemClick { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (LegendItemClick != null) { h.Add("legendItemClick",LegendItemClick); highcharts.AddFunction("legendItemClick", LegendItemClick); }  
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
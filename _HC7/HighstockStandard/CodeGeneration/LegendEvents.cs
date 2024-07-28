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
	public partial class LegendEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LegendEvents()
		{
		}	
		

		/// <summary>
		/// Fires when the legend item belonging to the series is clicked. Oneparameter, `event`, is passed to the function. The default actionis to toggle the visibility of the series, point or data class. Thiscan be prevented by returning `false` or calling`event.preventDefault()`.
		/// </summary>
		public string ItemClick { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ItemClick != null) { h.Add("itemClick",ItemClick); highstock.AddFunction("itemClick", ItemClick); }  
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
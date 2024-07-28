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
	public partial class RangeSelectorButtonEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public RangeSelectorButtonEvents()
		{
		}	
		

		/// <summary>
		/// Fires when clicking on the rangeSelector button. One parameter,event, is passed to the function, containing common eventinformation.```jsclick: function(e) {  console.log(this);}```Return false to stop default button's click action.
		/// </summary>
		public string Click { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Click != null) { h.Add("click",Click); highstock.AddFunction("click", Click); }  
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
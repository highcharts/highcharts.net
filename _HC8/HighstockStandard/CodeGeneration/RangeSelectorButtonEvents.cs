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
			Click = Click_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Fires when clicking on the rangeSelector button. One parameter,event, is passed to the function, containing common eventinformation.```jsclick: function(e) {  console.log(this);}```Return false to stop default button's click action.
		/// </summary>
		public string Click { get; set; }
		private string Click_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Click != Click_DefaultValue) { h.Add("click",Click); Highstock.AddFunction("click", Click); }  
			

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
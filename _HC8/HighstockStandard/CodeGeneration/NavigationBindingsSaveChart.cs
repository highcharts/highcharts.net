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
	public partial class NavigationBindingsSaveChart  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationBindingsSaveChart()
		{
			NoDataState = NoDataState_DefaultValue = "normal";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string NoDataState { get; set; }
		private string NoDataState_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (NoDataState != NoDataState_DefaultValue) h.Add("noDataState",NoDataState);
			

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
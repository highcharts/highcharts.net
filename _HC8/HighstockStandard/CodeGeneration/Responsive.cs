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
	public partial class Responsive  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Responsive()
		{
			Rules = Rules_DefaultValue = new List<ResponsiveRules>();
			
		}	
		

		/// <summary>
		/// A set of rules for responsive settings. The rules are executed fromthe top down.
		/// </summary>
		public List<ResponsiveRules> Rules { get; set; }
		private List<ResponsiveRules> Rules_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Rules != Rules_DefaultValue) h.Add("rules", HashifyList(highstock,Rules));
			

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}
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
		}	
		

		/// <summary>
		/// A set of rules for responsive settings. The rules are executed fromthe top down.
		/// </summary>
		public List<ResponsiveRules> Rules { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Rules != null) h.Add("rules", HashifyList(highstock,Rules));
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
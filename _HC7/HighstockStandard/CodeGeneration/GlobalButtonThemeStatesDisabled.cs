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
	public partial class GlobalButtonThemeStatesDisabled  : BaseObject
	{
		Hashtable h = new Hashtable();

		public GlobalButtonThemeStatesDisabled()
		{
		}	
		

		/// <summary>
		/// Disabled state CSS style overrides for the buttons' text
		/// </summary>
		public Hashtable Style { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Style != null) h.Add("style",Style);
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
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
	public partial class GlobalButtonThemeStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public GlobalButtonThemeStates()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Disabled state overrides for the buttons are applied inaddition to the normal state options
		/// </summary>
		public GlobalButtonThemeStatesDisabled Disabled { get; set; }
		 

		/// <summary>
		/// Hover state overrides for the buttons are applied in additionto the normal state options
		/// </summary>
		public GlobalButtonThemeStatesHover Hover { get; set; }
		 

		/// <summary>
		/// Select state overrides for the buttons are applied inaddition to the normal state options
		/// </summary>
		public GlobalButtonThemeStatesSelect Select { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Disabled != null) h.Add("disabled",Disabled.ToHashtable(highcharts));
			if (Hover != null) h.Add("hover",Hover.ToHashtable(highcharts));
			if (Select != null) h.Add("select",Select.ToHashtable(highcharts));
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
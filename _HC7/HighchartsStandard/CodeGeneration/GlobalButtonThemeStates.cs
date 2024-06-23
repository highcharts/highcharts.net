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
			Disabled = Disabled_DefaultValue = new GlobalButtonThemeStatesDisabled();
			Hover = Hover_DefaultValue = new GlobalButtonThemeStatesHover();
			Select = Select_DefaultValue = new GlobalButtonThemeStatesSelect();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Disabled state overrides for the buttons are applied inaddition to the normal state options
		/// </summary>
		public GlobalButtonThemeStatesDisabled Disabled { get; set; }
		private GlobalButtonThemeStatesDisabled Disabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Hover state overrides for the buttons are applied in additionto the normal state options
		/// </summary>
		public GlobalButtonThemeStatesHover Hover { get; set; }
		private GlobalButtonThemeStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// Select state overrides for the buttons are applied inaddition to the normal state options
		/// </summary>
		public GlobalButtonThemeStatesSelect Select { get; set; }
		private GlobalButtonThemeStatesSelect Select_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Disabled.IsDirty(highcharts)) h.Add("disabled",Disabled.ToHashtable(highcharts));
			if (Hover.IsDirty(highcharts)) h.Add("hover",Hover.ToHashtable(highcharts));
			if (Select.IsDirty(highcharts)) h.Add("select",Select.ToHashtable(highcharts));
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}
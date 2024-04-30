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
	public partial class AnnotationsMeasureTypeOptionsLabel  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsMeasureTypeOptionsLabel()
		{
			Enabled = Enabled_DefaultValue = true;
			Formatter = Formatter_DefaultValue = "";
			Style = Style_DefaultValue = new Hashtable();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Enable or disable the label text (min, max, average,bins values).Defaults to true.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Formatter function for the label text.Available data are:<table><tbody><tr><td>`this.min`</td><td>The minimum value of the points in the selectedrange.</td></tr><tr><td>`this.max`</td><td>The maximum value of the points in the selectedrange.</td></tr><tr><td>`this.average`</td><td>The average value of the points in the selectedrange.</td></tr><tr><td>`this.bins`</td><td>The amount of the points in the selected range.</td></tr></table>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the measure label.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); highstock.AddFunction("formatter", Formatter); }  
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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
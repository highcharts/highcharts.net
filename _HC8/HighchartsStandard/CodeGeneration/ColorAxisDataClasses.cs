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
	public partial class ColorAxisDataClasses  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColorAxisDataClasses()
		{
			Color = Color_DefaultValue = "";
			From = From_DefaultValue = null;
			Name = Name_DefaultValue = "";
			To = To_DefaultValue = null;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The color of each data class. If not set, the color is pulledfrom the global or chart-specific [colors](#colors) array. Instyled mode, this option is ignored. Instead, use colors definedin CSS.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The start of the value range that the data class represents,relating to the point value.The range of each `dataClass` is closed in both ends, but can beoverridden by the next `dataClass`.
		/// </summary>
		public double? From { get; set; }
		private double? From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the data class as it appears in the legend.If no name is given, it is automatically created based on the`from` and `to` values. For full programmatic control,[legend.labelFormatter](#legend.labelFormatter) can be used.In the formatter, `this.from` and `this.to` can be accessed.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// The end of the value range that the data class represents,relating to the point value.The range of each `dataClass` is closed in both ends, but can beoverridden by the next `dataClass`.
		/// </summary>
		public double? To { get; set; }
		private double? To_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (From != From_DefaultValue) h.Add("from",From);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (To != To_DefaultValue) h.Add("to",To);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}
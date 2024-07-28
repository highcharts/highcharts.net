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
		}	
		

		/// <summary>
		/// The color of each data class. If not set, the color is pulledfrom the global or chart-specific [colors](#colors) array. Instyled mode, this option is ignored. Instead, use colors definedin CSS.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// The start of the value range that the data class represents,relating to the point value.The range of each `dataClass` is closed in both ends, but can beoverridden by the next `dataClass`.
		/// </summary>
		public double? From { get; set; }
		 

		/// <summary>
		/// The name of the data class as it appears in the legend.If no name is given, it is automatically created based on the`from` and `to` values. For full programmatic control,[legend.labelFormatter](#legend.labelFormatter) can be used.In the formatter, `this.from` and `this.to` can be accessed.
		/// </summary>
		public string Name { get; set; }
		 

		/// <summary>
		/// The end of the value range that the data class represents,relating to the point value.The range of each `dataClass` is closed in both ends, but can beoverridden by the next `dataClass`.
		/// </summary>
		public double? To { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Color != null) h.Add("color",Color);
			if (From != null) h.Add("from",From);
			if (Name != null) h.Add("name",Name);
			if (To != null) h.Add("to",To);
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
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
	public partial class LangAccessibilityLegend  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityLegend()
		{
		}	
		

		/// <summary>
		/// Accessible label for individual legend items. `{itemName}` refersto the visual text in the legend for that item.
		/// </summary>
		public string LegendItem { get; set; }
		 

		/// <summary>
		/// Accessible label for the legend, for charts where there is alegend title defined. `{legendTitle}` refers to the visual textin the legend title.
		/// </summary>
		public string LegendLabel { get; set; }
		 

		/// <summary>
		/// Accessible label for the legend, for charts where there is nolegend title defined.
		/// </summary>
		public string LegendLabelNoTitle { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (LegendItem != null) h.Add("legendItem",LegendItem);
			if (LegendLabel != null) h.Add("legendLabel",LegendLabel);
			if (LegendLabelNoTitle != null) h.Add("legendLabelNoTitle",LegendLabelNoTitle);
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
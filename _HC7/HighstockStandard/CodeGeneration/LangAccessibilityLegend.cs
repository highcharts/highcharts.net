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
	public partial class LangAccessibilityLegend  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityLegend()
		{
			LegendItem = LegendItem_DefaultValue = "Show {itemName}";
			LegendLabel = LegendLabel_DefaultValue = "Chart legend: {legendTitle}";
			LegendLabelNoTitle = LegendLabelNoTitle_DefaultValue = "Toggle series visibility, {chartTitle}";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Accessible label for individual legend items. `{itemName}` refersto the visual text in the legend for that item.
		/// </summary>
		public string LegendItem { get; set; }
		private string LegendItem_DefaultValue { get; set; }
		 

		/// <summary>
		/// Accessible label for the legend, for charts where there is alegend title defined. `{legendTitle}` refers to the visual textin the legend title.
		/// </summary>
		public string LegendLabel { get; set; }
		private string LegendLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// Accessible label for the legend, for charts where there is nolegend title defined.
		/// </summary>
		public string LegendLabelNoTitle { get; set; }
		private string LegendLabelNoTitle_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (LegendItem != LegendItem_DefaultValue) h.Add("legendItem",LegendItem);
			if (LegendLabel != LegendLabel_DefaultValue) h.Add("legendLabel",LegendLabel);
			if (LegendLabelNoTitle != LegendLabelNoTitle_DefaultValue) h.Add("legendLabelNoTitle",LegendLabelNoTitle);
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
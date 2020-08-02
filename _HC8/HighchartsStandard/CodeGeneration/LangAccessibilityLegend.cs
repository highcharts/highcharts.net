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
			LegendItem = LegendItem_DefaultValue = "Toggle visibility of {itemName}";
			LegendLabel = LegendLabel_DefaultValue = "Toggle series visibility";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string LegendItem { get; set; }
		private string LegendItem_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LegendLabel { get; set; }
		private string LegendLabel_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (LegendItem != LegendItem_DefaultValue) h.Add("legendItem",LegendItem);
			if (LegendLabel != LegendLabel_DefaultValue) h.Add("legendLabel",LegendLabel);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}
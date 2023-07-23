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
	public partial class StockToolsGuiDefinitionsVerticalLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public StockToolsGuiDefinitionsVerticalLabels()
		{
			Items = Items_DefaultValue = new List<string>();
			VerticalArrow = VerticalArrow_DefaultValue = new StockToolsGuiDefinitionsVerticalLabelsVerticalArrow();
			VerticalCounter = VerticalCounter_DefaultValue = new StockToolsGuiDefinitionsVerticalLabelsVerticalCounter();
			VerticalLabel = VerticalLabel_DefaultValue = new StockToolsGuiDefinitionsVerticalLabelsVerticalLabel();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		private List<string> Items_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsVerticalLabelsVerticalArrow VerticalArrow { get; set; }
		private StockToolsGuiDefinitionsVerticalLabelsVerticalArrow VerticalArrow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsVerticalLabelsVerticalCounter VerticalCounter { get; set; }
		private StockToolsGuiDefinitionsVerticalLabelsVerticalCounter VerticalCounter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsVerticalLabelsVerticalLabel VerticalLabel { get; set; }
		private StockToolsGuiDefinitionsVerticalLabelsVerticalLabel VerticalLabel_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Items != Items_DefaultValue) h.Add("items",Items);
			if (VerticalArrow.IsDirty(highstock)) h.Add("verticalArrow",VerticalArrow.ToHashtable(highstock));
			if (VerticalCounter.IsDirty(highstock)) h.Add("verticalCounter",VerticalCounter.ToHashtable(highstock));
			if (VerticalLabel.IsDirty(highstock)) h.Add("verticalLabel",VerticalLabel.ToHashtable(highstock));
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
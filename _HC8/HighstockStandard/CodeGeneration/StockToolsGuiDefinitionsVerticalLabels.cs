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
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Items != Items_DefaultValue) h.Add("items",Items);
			if (VerticalArrow.IsDirty()) h.Add("verticalArrow",VerticalArrow.ToHashtable());
			if (VerticalCounter.IsDirty()) h.Add("verticalCounter",VerticalCounter.ToHashtable());
			if (VerticalLabel.IsDirty()) h.Add("verticalLabel",VerticalLabel.ToHashtable());
			

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
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
	public partial class StockToolsGuiDefinitionsFlags  : BaseObject
	{
		Hashtable h = new Hashtable();

		public StockToolsGuiDefinitionsFlags()
		{
			FlagCirclepin = FlagCirclepin_DefaultValue = new StockToolsGuiDefinitionsFlagsFlagCirclepin();
			FlagDiamondpin = FlagDiamondpin_DefaultValue = new StockToolsGuiDefinitionsFlagsFlagDiamondpin();
			FlagSimplepin = FlagSimplepin_DefaultValue = new StockToolsGuiDefinitionsFlagsFlagSimplepin();
			FlagSquarepin = FlagSquarepin_DefaultValue = new StockToolsGuiDefinitionsFlagsFlagSquarepin();
			Items = Items_DefaultValue = new List<string>();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsFlagsFlagCirclepin FlagCirclepin { get; set; }
		private StockToolsGuiDefinitionsFlagsFlagCirclepin FlagCirclepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsFlagsFlagDiamondpin FlagDiamondpin { get; set; }
		private StockToolsGuiDefinitionsFlagsFlagDiamondpin FlagDiamondpin_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsFlagsFlagSimplepin FlagSimplepin { get; set; }
		private StockToolsGuiDefinitionsFlagsFlagSimplepin FlagSimplepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsFlagsFlagSquarepin FlagSquarepin { get; set; }
		private StockToolsGuiDefinitionsFlagsFlagSquarepin FlagSquarepin_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		private List<string> Items_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (FlagCirclepin.IsDirty(highstock)) h.Add("flagCirclepin",FlagCirclepin.ToHashtable(highstock));
			if (FlagDiamondpin.IsDirty(highstock)) h.Add("flagDiamondpin",FlagDiamondpin.ToHashtable(highstock));
			if (FlagSimplepin.IsDirty(highstock)) h.Add("flagSimplepin",FlagSimplepin.ToHashtable(highstock));
			if (FlagSquarepin.IsDirty(highstock)) h.Add("flagSquarepin",FlagSquarepin.ToHashtable(highstock));
			if (Items != Items_DefaultValue) h.Add("items",Items);
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
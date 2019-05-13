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
	public partial class StockToolsGuiDefinitionsTypeChange  : BaseObject
	{
		public StockToolsGuiDefinitionsTypeChange()
		{
			Items = Items_DefaultValue = new List<string>();
			TypeCandlestick = TypeCandlestick_DefaultValue = new StockToolsGuiDefinitionsTypeChangeTypeCandlestick();
			TypeLine = TypeLine_DefaultValue = new StockToolsGuiDefinitionsTypeChangeTypeLine();
			TypeOHLC = TypeOHLC_DefaultValue = new StockToolsGuiDefinitionsTypeChangeTypeOHLC();
			
		}	
		

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		private List<string> Items_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsTypeChangeTypeCandlestick TypeCandlestick { get; set; }
		private StockToolsGuiDefinitionsTypeChangeTypeCandlestick TypeCandlestick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsTypeChangeTypeLine TypeLine { get; set; }
		private StockToolsGuiDefinitionsTypeChangeTypeLine TypeLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsTypeChangeTypeOHLC TypeOHLC { get; set; }
		private StockToolsGuiDefinitionsTypeChangeTypeOHLC TypeOHLC_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Items != Items_DefaultValue) h.Add("items",Items);
			if (TypeCandlestick.IsDirty()) h.Add("typeCandlestick",TypeCandlestick.ToHashtable());
			if (TypeLine.IsDirty()) h.Add("typeLine",TypeLine.ToHashtable());
			if (TypeOHLC.IsDirty()) h.Add("typeOHLC",TypeOHLC.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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
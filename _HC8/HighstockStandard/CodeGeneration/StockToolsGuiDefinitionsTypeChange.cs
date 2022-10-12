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
		Hashtable h = new Hashtable();

		public StockToolsGuiDefinitionsTypeChange()
		{
			Items = Items_DefaultValue = new List<string>();
			TypeCandlestick = TypeCandlestick_DefaultValue = new StockToolsGuiDefinitionsTypeChangeTypeCandlestick();
			TypeHeikinAshi = TypeHeikinAshi_DefaultValue = new StockToolsGuiDefinitionsTypeChangeTypeHeikinAshi();
			TypeHLC = TypeHLC_DefaultValue = new StockToolsGuiDefinitionsTypeChangeTypeHLC();
			TypeHollowCandlestick = TypeHollowCandlestick_DefaultValue = new StockToolsGuiDefinitionsTypeChangeTypeHollowCandlestick();
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
		public StockToolsGuiDefinitionsTypeChangeTypeHeikinAshi TypeHeikinAshi { get; set; }
		private StockToolsGuiDefinitionsTypeChangeTypeHeikinAshi TypeHeikinAshi_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsTypeChangeTypeHLC TypeHLC { get; set; }
		private StockToolsGuiDefinitionsTypeChangeTypeHLC TypeHLC_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsTypeChangeTypeHollowCandlestick TypeHollowCandlestick { get; set; }
		private StockToolsGuiDefinitionsTypeChangeTypeHollowCandlestick TypeHollowCandlestick_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Items != Items_DefaultValue) h.Add("items",Items);
			if (TypeCandlestick.IsDirty(ref highstock)) h.Add("typeCandlestick",TypeCandlestick.ToHashtable(ref highstock));
			if (TypeHeikinAshi.IsDirty(ref highstock)) h.Add("typeHeikinAshi",TypeHeikinAshi.ToHashtable(ref highstock));
			if (TypeHLC.IsDirty(ref highstock)) h.Add("typeHLC",TypeHLC.ToHashtable(ref highstock));
			if (TypeHollowCandlestick.IsDirty(ref highstock)) h.Add("typeHollowCandlestick",TypeHollowCandlestick.ToHashtable(ref highstock));
			if (TypeLine.IsDirty(ref highstock)) h.Add("typeLine",TypeLine.ToHashtable(ref highstock));
			if (TypeOHLC.IsDirty(ref highstock)) h.Add("typeOHLC",TypeOHLC.ToHashtable(ref highstock));
			

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
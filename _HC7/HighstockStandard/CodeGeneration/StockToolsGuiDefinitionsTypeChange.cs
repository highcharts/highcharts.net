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
		}	
		

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsTypeChangeTypeCandlestick TypeCandlestick { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsTypeChangeTypeHeikinAshi TypeHeikinAshi { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsTypeChangeTypeHLC TypeHLC { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsTypeChangeTypeHollowCandlestick TypeHollowCandlestick { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsTypeChangeTypeLine TypeLine { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsTypeChangeTypeOHLC TypeOHLC { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Items != null) h.Add("items",Items);
			if (TypeCandlestick != null) h.Add("typeCandlestick",TypeCandlestick.ToHashtable(highstock));
			if (TypeHeikinAshi != null) h.Add("typeHeikinAshi",TypeHeikinAshi.ToHashtable(highstock));
			if (TypeHLC != null) h.Add("typeHLC",TypeHLC.ToHashtable(highstock));
			if (TypeHollowCandlestick != null) h.Add("typeHollowCandlestick",TypeHollowCandlestick.ToHashtable(highstock));
			if (TypeLine != null) h.Add("typeLine",TypeLine.ToHashtable(highstock));
			if (TypeOHLC != null) h.Add("typeOHLC",TypeOHLC.ToHashtable(highstock));
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
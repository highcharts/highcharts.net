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
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (FlagCirclepin.IsDirty(ref highstock)) h.Add("flagCirclepin",FlagCirclepin.ToHashtable(ref highstock));
			if (FlagDiamondpin.IsDirty(ref highstock)) h.Add("flagDiamondpin",FlagDiamondpin.ToHashtable(ref highstock));
			if (FlagSimplepin.IsDirty(ref highstock)) h.Add("flagSimplepin",FlagSimplepin.ToHashtable(ref highstock));
			if (FlagSquarepin.IsDirty(ref highstock)) h.Add("flagSquarepin",FlagSquarepin.ToHashtable(ref highstock));
			if (Items != Items_DefaultValue) h.Add("items",Items);
			

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
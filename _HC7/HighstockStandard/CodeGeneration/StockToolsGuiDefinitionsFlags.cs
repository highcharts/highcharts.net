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
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsFlagsFlagCirclepin FlagCirclepin { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsFlagsFlagDiamondpin FlagDiamondpin { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsFlagsFlagSimplepin FlagSimplepin { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsFlagsFlagSquarepin FlagSquarepin { get; set; }
		 

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (FlagCirclepin != null) h.Add("flagCirclepin",FlagCirclepin.ToHashtable(highstock));
			if (FlagDiamondpin != null) h.Add("flagDiamondpin",FlagDiamondpin.ToHashtable(highstock));
			if (FlagSimplepin != null) h.Add("flagSimplepin",FlagSimplepin.ToHashtable(highstock));
			if (FlagSquarepin != null) h.Add("flagSquarepin",FlagSquarepin.ToHashtable(highstock));
			if (Items != null) h.Add("items",Items);
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
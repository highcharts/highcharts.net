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
	public partial class StockToolsGuiDefinitionsSeparator  : BaseObject
	{
		Hashtable h = new Hashtable();

		public StockToolsGuiDefinitionsSeparator()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string ElementType { get; set; }
		 

		/// <summary>
		/// A predefined background symbol for the button.
		/// </summary>
		public string Symbol { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ElementType != null) h.Add("elementType",ElementType);
			if (Symbol != null) h.Add("symbol",Symbol);
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
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
			ElementType = ElementType_DefaultValue = "span";
			Symbol = Symbol_DefaultValue = "separator.svg";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string ElementType { get; set; }
		private string ElementType_DefaultValue { get; set; }
		 

		/// <summary>
		/// A predefined background symbol for the button.
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ElementType != ElementType_DefaultValue) h.Add("elementType",ElementType);
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
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
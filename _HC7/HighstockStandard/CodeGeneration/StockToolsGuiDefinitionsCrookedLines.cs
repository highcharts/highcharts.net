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
	public partial class StockToolsGuiDefinitionsCrookedLines  : BaseObject
	{
		Hashtable h = new Hashtable();

		public StockToolsGuiDefinitionsCrookedLines()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsCrookedLinesCrooked3 Crooked3 { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsCrookedLinesCrooked5 Crooked5 { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsCrookedLinesElliott3 Elliott3 { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsCrookedLinesElliott5 Elliott5 { get; set; }
		 

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Crooked3 != null) h.Add("crooked3",Crooked3.ToHashtable(highstock));
			if (Crooked5 != null) h.Add("crooked5",Crooked5.ToHashtable(highstock));
			if (Elliott3 != null) h.Add("elliott3",Elliott3.ToHashtable(highstock));
			if (Elliott5 != null) h.Add("elliott5",Elliott5.ToHashtable(highstock));
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
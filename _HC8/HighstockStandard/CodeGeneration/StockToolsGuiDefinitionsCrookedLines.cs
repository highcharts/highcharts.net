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
			Crooked3 = Crooked3_DefaultValue = new StockToolsGuiDefinitionsCrookedLinesCrooked3();
			Crooked5 = Crooked5_DefaultValue = new StockToolsGuiDefinitionsCrookedLinesCrooked5();
			Elliott3 = Elliott3_DefaultValue = new StockToolsGuiDefinitionsCrookedLinesElliott3();
			Elliott5 = Elliott5_DefaultValue = new StockToolsGuiDefinitionsCrookedLinesElliott5();
			Items = Items_DefaultValue = new List<string>();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsCrookedLinesCrooked3 Crooked3 { get; set; }
		private StockToolsGuiDefinitionsCrookedLinesCrooked3 Crooked3_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsCrookedLinesCrooked5 Crooked5 { get; set; }
		private StockToolsGuiDefinitionsCrookedLinesCrooked5 Crooked5_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsCrookedLinesElliott3 Elliott3 { get; set; }
		private StockToolsGuiDefinitionsCrookedLinesElliott3 Elliott3_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsCrookedLinesElliott5 Elliott5 { get; set; }
		private StockToolsGuiDefinitionsCrookedLinesElliott5 Elliott5_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		private List<string> Items_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Crooked3.IsDirty(highstock)) h.Add("crooked3",Crooked3.ToHashtable(highstock));
			if (Crooked5.IsDirty(highstock)) h.Add("crooked5",Crooked5.ToHashtable(highstock));
			if (Elliott3.IsDirty(highstock)) h.Add("elliott3",Elliott3.ToHashtable(highstock));
			if (Elliott5.IsDirty(highstock)) h.Add("elliott5",Elliott5.ToHashtable(highstock));
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
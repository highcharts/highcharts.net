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
		public StockToolsGuiDefinitionsCrookedLines()
		{
			Crooked3 = Crooked3_DefaultValue = new StockToolsGuiDefinitionsCrookedLinesCrooked3();
			Crooked5 = Crooked5_DefaultValue = new StockToolsGuiDefinitionsCrookedLinesCrooked5();
			Elliott3 = Elliott3_DefaultValue = new StockToolsGuiDefinitionsCrookedLinesElliott3();
			Elliott5 = Elliott5_DefaultValue = new StockToolsGuiDefinitionsCrookedLinesElliott5();
			Items = Items_DefaultValue = [
   elliott3 ,
   elliott5 ,
   crooked3 ,
   crooked5 
];
			
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
		public Array Items { get; set; }
		private Array Items_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Crooked3.IsDirty()) h.Add("crooked3",Crooked3.ToHashtable());
			if (Crooked5.IsDirty()) h.Add("crooked5",Crooked5.ToHashtable());
			if (Elliott3.IsDirty()) h.Add("elliott3",Elliott3.ToHashtable());
			if (Elliott5.IsDirty()) h.Add("elliott5",Elliott5.ToHashtable());
			if (Items != Items_DefaultValue) h.Add("items",Items);
			

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
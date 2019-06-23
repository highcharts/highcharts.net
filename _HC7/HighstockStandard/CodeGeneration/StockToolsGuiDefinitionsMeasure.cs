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
	public partial class StockToolsGuiDefinitionsMeasure  : BaseObject
	{
		public StockToolsGuiDefinitionsMeasure()
		{
			Items = Items_DefaultValue = new List<string>();
			MeasureX = MeasureX_DefaultValue = new StockToolsGuiDefinitionsMeasureMeasureX();
			MeasureXY = MeasureXY_DefaultValue = new StockToolsGuiDefinitionsMeasureMeasureXY();
			MeasureY = MeasureY_DefaultValue = new StockToolsGuiDefinitionsMeasureMeasureY();
			
		}	
		

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		private List<string> Items_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsMeasureMeasureX MeasureX { get; set; }
		private StockToolsGuiDefinitionsMeasureMeasureX MeasureX_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsMeasureMeasureXY MeasureXY { get; set; }
		private StockToolsGuiDefinitionsMeasureMeasureXY MeasureXY_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsMeasureMeasureY MeasureY { get; set; }
		private StockToolsGuiDefinitionsMeasureMeasureY MeasureY_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Items != Items_DefaultValue) h.Add("items",Items);
			if (MeasureX.IsDirty()) h.Add("measureX",MeasureX.ToHashtable());
			if (MeasureXY.IsDirty()) h.Add("measureXY",MeasureXY.ToHashtable());
			if (MeasureY.IsDirty()) h.Add("measureY",MeasureY.ToHashtable());
			

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
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
		Hashtable h = new Hashtable();

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
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Items != Items_DefaultValue) h.Add("items",Items);
			if (MeasureX.IsDirty(ref highstock)) h.Add("measureX",MeasureX.ToHashtable(ref highstock));
			if (MeasureXY.IsDirty(ref highstock)) h.Add("measureXY",MeasureXY.ToHashtable(ref highstock));
			if (MeasureY.IsDirty(ref highstock)) h.Add("measureY",MeasureY.ToHashtable(ref highstock));
			

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
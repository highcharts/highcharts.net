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
		}	
		

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsMeasureMeasureX MeasureX { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsMeasureMeasureXY MeasureXY { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsMeasureMeasureY MeasureY { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Items != null) h.Add("items",Items);
			if (MeasureX != null) h.Add("measureX",MeasureX.ToHashtable(highstock));
			if (MeasureXY != null) h.Add("measureXY",MeasureXY.ToHashtable(highstock));
			if (MeasureY != null) h.Add("measureY",MeasureY.ToHashtable(highstock));
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
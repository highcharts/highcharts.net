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
	public partial class StockToolsGuiDefinitionsZoomChange  : BaseObject
	{
		Hashtable h = new Hashtable();

		public StockToolsGuiDefinitionsZoomChange()
		{
			Items = Items_DefaultValue = new List<string>();
			ZoomX = ZoomX_DefaultValue = new StockToolsGuiDefinitionsZoomChangeZoomX();
			ZoomXY = ZoomXY_DefaultValue = new StockToolsGuiDefinitionsZoomChangeZoomXY();
			ZoomY = ZoomY_DefaultValue = new StockToolsGuiDefinitionsZoomChangeZoomY();
			
		}	
		

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		private List<string> Items_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsZoomChangeZoomX ZoomX { get; set; }
		private StockToolsGuiDefinitionsZoomChangeZoomX ZoomX_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsZoomChangeZoomXY ZoomXY { get; set; }
		private StockToolsGuiDefinitionsZoomChangeZoomXY ZoomXY_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsZoomChangeZoomY ZoomY { get; set; }
		private StockToolsGuiDefinitionsZoomChangeZoomY ZoomY_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Items != Items_DefaultValue) h.Add("items",Items);
			if (ZoomX.IsDirty(highstock)) h.Add("zoomX",ZoomX.ToHashtable(highstock));
			if (ZoomXY.IsDirty(highstock)) h.Add("zoomXY",ZoomXY.ToHashtable(highstock));
			if (ZoomY.IsDirty(highstock)) h.Add("zoomY",ZoomY.ToHashtable(highstock));
			

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
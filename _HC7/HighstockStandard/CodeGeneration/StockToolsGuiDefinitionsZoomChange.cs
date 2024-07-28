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
		}	
		

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsZoomChangeZoomX ZoomX { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsZoomChangeZoomXY ZoomXY { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsZoomChangeZoomY ZoomY { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Items != null) h.Add("items",Items);
			if (ZoomX != null) h.Add("zoomX",ZoomX.ToHashtable(highstock));
			if (ZoomXY != null) h.Add("zoomXY",ZoomXY.ToHashtable(highstock));
			if (ZoomY != null) h.Add("zoomY",ZoomY.ToHashtable(highstock));
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
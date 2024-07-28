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
	public partial class StockToolsGuiDefinitionsSimpleShapes  : BaseObject
	{
		Hashtable h = new Hashtable();

		public StockToolsGuiDefinitionsSimpleShapes()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsSimpleShapesCircle Circle { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsSimpleShapesEllipse Ellipse { get; set; }
		 

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsSimpleShapesLabel Label { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsSimpleShapesRectangle Rectangle { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Circle != null) h.Add("circle",Circle.ToHashtable(highstock));
			if (Ellipse != null) h.Add("ellipse",Ellipse.ToHashtable(highstock));
			if (Items != null) h.Add("items",Items);
			if (Label != null) h.Add("label",Label.ToHashtable(highstock));
			if (Rectangle != null) h.Add("rectangle",Rectangle.ToHashtable(highstock));
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
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
			Circle = Circle_DefaultValue = new StockToolsGuiDefinitionsSimpleShapesCircle();
			Ellipse = Ellipse_DefaultValue = new StockToolsGuiDefinitionsSimpleShapesEllipse();
			Items = Items_DefaultValue = new List<string>();
			Label = Label_DefaultValue = new StockToolsGuiDefinitionsSimpleShapesLabel();
			Rectangle = Rectangle_DefaultValue = new StockToolsGuiDefinitionsSimpleShapesRectangle();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsSimpleShapesCircle Circle { get; set; }
		private StockToolsGuiDefinitionsSimpleShapesCircle Circle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsSimpleShapesEllipse Ellipse { get; set; }
		private StockToolsGuiDefinitionsSimpleShapesEllipse Ellipse_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		private List<string> Items_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsSimpleShapesLabel Label { get; set; }
		private StockToolsGuiDefinitionsSimpleShapesLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsSimpleShapesRectangle Rectangle { get; set; }
		private StockToolsGuiDefinitionsSimpleShapesRectangle Rectangle_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Circle.IsDirty(highstock)) h.Add("circle",Circle.ToHashtable(highstock));
			if (Ellipse.IsDirty(highstock)) h.Add("ellipse",Ellipse.ToHashtable(highstock));
			if (Items != Items_DefaultValue) h.Add("items",Items);
			if (Label.IsDirty(highstock)) h.Add("label",Label.ToHashtable(highstock));
			if (Rectangle.IsDirty(highstock)) h.Add("rectangle",Rectangle.ToHashtable(highstock));
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
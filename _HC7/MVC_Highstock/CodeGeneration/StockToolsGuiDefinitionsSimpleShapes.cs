using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class StockToolsGuiDefinitionsSimpleShapes  : BaseObject
	{
		public StockToolsGuiDefinitionsSimpleShapes()
		{
			Circle = Circle_DefaultValue = new StockToolsGuiDefinitionsSimpleShapesCircle();
			Items = Items_DefaultValue = new List<string>() {
  "label",
  "circle",
  "rectangle"
            };
			Label = Label_DefaultValue = new StockToolsGuiDefinitionsSimpleShapesLabel();
			Rectangle = Rectangle_DefaultValue = new StockToolsGuiDefinitionsSimpleShapesRectangle();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsSimpleShapesCircle Circle { get; set; }
		private StockToolsGuiDefinitionsSimpleShapesCircle Circle_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Circle.IsDirty()) h.Add("circle",Circle.ToHashtable());
			if (Items != Items_DefaultValue) h.Add("items",Items);
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (Rectangle.IsDirty()) h.Add("rectangle",Rectangle.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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
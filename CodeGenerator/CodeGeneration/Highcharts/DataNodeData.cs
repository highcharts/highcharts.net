using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class DataNodeData  : BaseObject
	{
		public DataNodeData()
		{
			Name = Name_DefaultValue = "";
			Label = Label_DefaultValue = "";
			Value = Value_DefaultValue = "";
			Ignore = Ignore_DefaultValue = null;
			Symbol = Symbol_DefaultValue = circle;
			SymbolSize = SymbolSize_DefaultValue = "";
			Category = Category_DefaultValue = "";
			ItemStyle = ItemStyle_DefaultValue = "";
			Initial = Initial_DefaultValue = "";
			FixX = FixX_DefaultValue = null;
			FixY = FixY_DefaultValue = null;
			Draggable = Draggable_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Name of node
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// Label name of the node, name(above) as default.
		/// </summary>
		public string Label { get; set; }
		private string Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// Value of name
		/// </summary>
		public number Value { get; set; }
		private number Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether to neglect the node.
		/// </summary>
		public boolean Ignore { get; set; }
		private boolean Ignore_DefaultValue { get; set; }
		 

		/// <summary>
		/// See series (Cartesian)
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// Size of symbol
		/// </summary>
		public string SymbolSize { get; set; }
		private string SymbolSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Category index of the node.
		/// </summary>
		public number Category { get; set; }
		private number Category_DefaultValue { get; set; }
		 

		/// <summary>
		/// see itemStyle. Notice that itemStyle in a single node of force has no nodeStyle under the normal(emphasis) option. Instead itemStyle.normal(emphasis).color|borderWidth|borderColor will be used
		/// </summary>
		public Object ItemStyle { get; set; }
		private Object ItemStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Forces to specify the initial value of the node. When not specified, it will be randomly generated within a certain range.
		/// </summary>
		public Array Initial { get; set; }
		private Array Initial_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether to fix the X-value of the node. Works with initial.
		/// </summary>
		public boolean FixX { get; set; }
		private boolean FixX_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether to fix the Y-value of the node. Works with initial.
		/// </summary>
		public boolean FixY { get; set; }
		private boolean FixY_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether the node is draggable.
		/// </summary>
		public boolean Draggable { get; set; }
		private boolean Draggable_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Label != Label_DefaultValue) h.Add("label",Label);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Ignore != Ignore_DefaultValue) h.Add("ignore",Ignore);
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (SymbolSize != SymbolSize_DefaultValue) h.Add("symbolSize",SymbolSize);
			if (Category != Category_DefaultValue) h.Add("category",Category);
			if (ItemStyle != ItemStyle_DefaultValue) h.Add("itemStyle",ItemStyle);
			if (Initial != Initial_DefaultValue) h.Add("initial",Initial);
			if (FixX != FixX_DefaultValue) h.Add("fixX",FixX);
			if (FixY != FixY_DefaultValue) h.Add("fixY",FixY);
			if (Draggable != Draggable_DefaultValue) h.Add("draggable",Draggable);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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
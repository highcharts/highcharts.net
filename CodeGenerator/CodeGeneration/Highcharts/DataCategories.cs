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
	public partial class DataCategories  : BaseObject
	{
		public DataCategories()
		{
			Name = Name_DefaultValue = "";
			Symbol = Symbol_DefaultValue = circle;
			SymbolSize = SymbolSize_DefaultValue = "";
			ItemStyle = ItemStyle_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Name of category
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

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
		/// see itemStyle. Notice that itemStyle in thecategory of force has no nodeStyle under the normal(emphasis) option. Instead itemStyle.normal(emphasis).color|borderWidth|borderColor will be used
		/// </summary>
		public Object ItemStyle { get; set; }
		private Object ItemStyle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (SymbolSize != SymbolSize_DefaultValue) h.Add("symbolSize",SymbolSize);
			if (ItemStyle != ItemStyle_DefaultValue) h.Add("itemStyle",ItemStyle);
			

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
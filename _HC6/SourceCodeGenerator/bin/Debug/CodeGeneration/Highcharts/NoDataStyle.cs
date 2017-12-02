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
	public partial class NoDataStyle  : BaseObject
	{
		public NoDataStyle()
		{
			FontWeight = FontWeight_DefaultValue = bold;
			FontSize = FontSize_DefaultValue = 12px;
			Color = Color_DefaultValue = #666666;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public NoDataStyleFontWeight FontWeight { get; set; }
		private NoDataStyleFontWeight FontWeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NoDataStyleFontSize FontSize { get; set; }
		private NoDataStyleFontSize FontSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NoDataStyleColor Color { get; set; }
		private NoDataStyleColor Color_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (FontWeight != FontWeight_DefaultValue) h.Add("fontWeight",FontWeight);
			if (FontSize != FontSize_DefaultValue) h.Add("fontSize",FontSize);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			

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
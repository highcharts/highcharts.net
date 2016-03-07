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
	public partial class LinkStyleItem  : BaseObject
	{
		public LinkStyleItem()
		{
			Type = Type_DefaultValue = line;
			Color = Color_DefaultValue = #5182ab;
			Width = Width_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// line style, can be: 'curve' | 'line'
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// color of the line
		/// </summary>
		public color Color { get; set; }
		private color Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// width of the line
		/// </summary>
		public number Width { get; set; }
		private number Width_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			

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
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
	public partial class AreaStyle  : BaseObject
	{
		public AreaStyle()
		{
			Color = Color_DefaultValue = "";
			Type = Type_DefaultValue = default;
			
		}	
		

		/// <summary>
		/// color
		/// </summary>
		public color Color { get; set; }
		private color Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fill style, currently only supports 'default' (solid fill).
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Type != Type_DefaultValue) h.Add("type",Type);
			

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
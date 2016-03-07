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
	public partial class ItemStyle  : BaseObject
	{
		public ItemStyle()
		{
			Normal = Normal_DefaultValue = "";
			Emphasis = Emphasis_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// normal item style
		/// </summary>
		public Object Normal { get; set; }
		private Object Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// emphasis item style (when hovered)
		/// </summary>
		public Object Emphasis { get; set; }
		private Object Emphasis_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Normal != Normal_DefaultValue) h.Add("normal",Normal);
			if (Emphasis != Emphasis_DefaultValue) h.Add("emphasis",Emphasis);
			

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
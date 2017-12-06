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
	public partial class LegendItemCheckboxStyle  : BaseObject
	{
		public LegendItemCheckboxStyle()
		{
			Position = Position_DefaultValue = new Hashtable();
			Width = Width_DefaultValue = 13px;
			Height = Height_DefaultValue = 13px;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Position { get; set; }
		private Hashtable Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LegendItemCheckboxStyleWidth Width { get; set; }
		private LegendItemCheckboxStyleWidth Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LegendItemCheckboxStyleHeight Height { get; set; }
		private LegendItemCheckboxStyleHeight Height_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			

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
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
	public partial class DrilldownActiveDataLabelStyle  : BaseObject
	{
		public DrilldownActiveDataLabelStyle()
		{
			Cursor = Cursor_DefaultValue = pointer;
			Color = Color_DefaultValue = "#003399";
			FontWeight = FontWeight_DefaultValue = "bold";
			TextDecoration = TextDecoration_DefaultValue = underline;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public DrilldownActiveDataLabelStyleCursor Cursor { get; set; }
		private DrilldownActiveDataLabelStyleCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FontWeight { get; set; }
		private string FontWeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public DrilldownActiveDataLabelStyleTextDecoration TextDecoration { get; set; }
		private DrilldownActiveDataLabelStyleTextDecoration TextDecoration_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (FontWeight != FontWeight_DefaultValue) h.Add("fontWeight",FontWeight);
			if (TextDecoration != TextDecoration_DefaultValue) h.Add("textDecoration",TextDecoration);
			

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
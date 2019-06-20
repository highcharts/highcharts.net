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
	public partial class DrilldownActiveDataLabelStyle  : BaseObject
	{
		public DrilldownActiveDataLabelStyle()
		{
			Color = Color_DefaultValue = "#003399";
			Color = Color_DefaultValue = "#003399";
			Cursor = Cursor_DefaultValue = "pointer";
			Cursor = Cursor_DefaultValue = "pointer";
			FontWeight = FontWeight_DefaultValue = "bold";
			FontWeight = FontWeight_DefaultValue = "bold";
			TextDecoration = TextDecoration_DefaultValue = "underline";
			TextDecoration = TextDecoration_DefaultValue = "underline";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Cursor { get; set; }
		private string Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Cursor { get; set; }
		private string Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FontWeight { get; set; }
		private string FontWeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FontWeight { get; set; }
		private string FontWeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TextDecoration { get; set; }
		private string TextDecoration_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TextDecoration { get; set; }
		private string TextDecoration_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (FontWeight != FontWeight_DefaultValue) h.Add("fontWeight",FontWeight);
			if (FontWeight != FontWeight_DefaultValue) h.Add("fontWeight",FontWeight);
			if (TextDecoration != TextDecoration_DefaultValue) h.Add("textDecoration",TextDecoration);
			if (TextDecoration != TextDecoration_DefaultValue) h.Add("textDecoration",TextDecoration);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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
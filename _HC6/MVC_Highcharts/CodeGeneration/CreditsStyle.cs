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
	public partial class CreditsStyle  : BaseObject
	{
		public CreditsStyle()
		{
			Cursor = Cursor_DefaultValue = pointer;
			Color = Color_DefaultValue = #999999;
			FontSize = FontSize_DefaultValue = 9px;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public CreditsStyleCursor Cursor { get; set; }
		private CreditsStyleCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public CreditsStyleColor Color { get; set; }
		private CreditsStyleColor Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public CreditsStyleFontSize FontSize { get; set; }
		private CreditsStyleFontSize FontSize_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (FontSize != FontSize_DefaultValue) h.Add("fontSize",FontSize);
			

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
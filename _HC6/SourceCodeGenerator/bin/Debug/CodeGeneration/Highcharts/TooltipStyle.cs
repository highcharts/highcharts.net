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
	public partial class TooltipStyle  : BaseObject
	{
		public TooltipStyle()
		{
			Color = Color_DefaultValue = "#333333";
			Cursor = Cursor_DefaultValue = "default";
			FontSize = FontSize_DefaultValue = "12px";
			PointerEvents = PointerEvents_DefaultValue = none;
			WhiteSpace = WhiteSpace_DefaultValue = nowrap;
			
		}	
		

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
		public string FontSize { get; set; }
		private string FontSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public TooltipStylePointerEvents PointerEvents { get; set; }
		private TooltipStylePointerEvents PointerEvents_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public TooltipStyleWhiteSpace WhiteSpace { get; set; }
		private TooltipStyleWhiteSpace WhiteSpace_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (FontSize != FontSize_DefaultValue) h.Add("fontSize",FontSize);
			if (PointerEvents != PointerEvents_DefaultValue) h.Add("pointerEvents",PointerEvents);
			if (WhiteSpace != WhiteSpace_DefaultValue) h.Add("whiteSpace",WhiteSpace);
			

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
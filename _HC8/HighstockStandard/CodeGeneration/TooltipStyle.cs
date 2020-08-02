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
	public partial class TooltipStyle  : BaseObject
	{
		Hashtable h = new Hashtable();

		public TooltipStyle()
		{
			Color = Color_DefaultValue = "#333333";
			Cursor = Cursor_DefaultValue = "default";
			FontSize = FontSize_DefaultValue = "12px";
			WhiteSpace = WhiteSpace_DefaultValue = "nowrap";
			
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
		public string WhiteSpace { get; set; }
		private string WhiteSpace_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (FontSize != FontSize_DefaultValue) h.Add("fontSize",FontSize);
			if (WhiteSpace != WhiteSpace_DefaultValue) h.Add("whiteSpace",WhiteSpace);
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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
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
	public partial class ChartStyle  : BaseObject
	{
		public ChartStyle()
		{
			FontFamily = FontFamily_DefaultValue = "Lucida Grande";
			FontSize = FontSize_DefaultValue = "12px";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string FontFamily { get; set; }
		private string FontFamily_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FontSize { get; set; }
		private string FontSize_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (FontFamily != FontFamily_DefaultValue) h.Add("fontFamily",FontFamily);
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
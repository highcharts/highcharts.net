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
	public partial class VariwideSeriesStatesSelect  : BaseObject
	{
		public VariwideSeriesStatesSelect()
		{
			Color = Color_DefaultValue = #cccccc;
			BorderColor = BorderColor_DefaultValue = #000000;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public VariwideSeriesStatesSelectColor Color { get; set; }
		private VariwideSeriesStatesSelectColor Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public VariwideSeriesStatesSelectBorderColor BorderColor { get; set; }
		private VariwideSeriesStatesSelectBorderColor BorderColor_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			

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
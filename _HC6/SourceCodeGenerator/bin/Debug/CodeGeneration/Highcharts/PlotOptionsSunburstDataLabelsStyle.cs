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
	public partial class PlotOptionsSunburstDataLabelsStyle  : BaseObject
	{
		public PlotOptionsSunburstDataLabelsStyle()
		{
			FontSize = FontSize_DefaultValue = 11px;
			FontWeight = FontWeight_DefaultValue = bold;
			Color = Color_DefaultValue = contrast;
			TextOutline = TextOutline_DefaultValue = 1px contrast;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstDataLabelsStyleFontSize FontSize { get; set; }
		private PlotOptionsSunburstDataLabelsStyleFontSize FontSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstDataLabelsStyleFontWeight FontWeight { get; set; }
		private PlotOptionsSunburstDataLabelsStyleFontWeight FontWeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstDataLabelsStyleColor Color { get; set; }
		private PlotOptionsSunburstDataLabelsStyleColor Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstDataLabelsStyleTextOutline TextOutline { get; set; }
		private PlotOptionsSunburstDataLabelsStyleTextOutline TextOutline_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (FontSize != FontSize_DefaultValue) h.Add("fontSize",FontSize);
			if (FontWeight != FontWeight_DefaultValue) h.Add("fontWeight",FontWeight);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (TextOutline != TextOutline_DefaultValue) h.Add("textOutline",TextOutline);
			

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
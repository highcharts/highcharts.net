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
	public partial class TextStyle  : BaseObject
	{
		public TextStyle()
		{
			Color = Color_DefaultValue = "";
			Decoration = Decoration_DefaultValue = none;
			Align = Align_DefaultValue = "";
			Baseline = Baseline_DefaultValue = "";
			FontFamily = FontFamily_DefaultValue = Arial, Verdana, sans-serif;
			FontSize = FontSize_DefaultValue = "";
			FontStyle = FontStyle_DefaultValue = normal;
			FontWeight = FontWeight_DefaultValue = normal;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public  Color { get; set; }
		private  Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// decoration. Applicable to tooltip.textStyle only.
		/// </summary>
		public string Decoration { get; set; }
		private string Decoration_DefaultValue { get; set; }
		 

		/// <summary>
		/// horizontal alignment. Valid values are: 'left' | 'right' | 'center'.
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// vertical alignment. Valid values are: 'top' | 'bottom' | 'middle'.
		/// </summary>
		public string Baseline { get; set; }
		private string Baseline_DefaultValue { get; set; }
		 

		/// <summary>
		/// font family.
		/// </summary>
		public string FontFamily { get; set; }
		private string FontFamily_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  FontSize { get; set; }
		private  FontSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// font style. Valid values are: 'normal' | 'italic' | 'oblique'.
		/// </summary>
		public string FontStyle { get; set; }
		private string FontStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// font weight. Valid values are: 'normal' | 'bold' | 'bolder' | 'lighter' | 100 | 200 |... | 900.
		/// </summary>
		public string FontWeight { get; set; }
		private string FontWeight_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Decoration != Decoration_DefaultValue) h.Add("decoration",Decoration);
			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (Baseline != Baseline_DefaultValue) h.Add("baseline",Baseline);
			if (FontFamily != FontFamily_DefaultValue) h.Add("fontFamily",FontFamily);
			if (FontSize != FontSize_DefaultValue) h.Add("fontSize",FontSize);
			if (FontStyle != FontStyle_DefaultValue) h.Add("fontStyle",FontStyle);
			if (FontWeight != FontWeight_DefaultValue) h.Add("fontWeight",FontWeight);
			

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
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
	public partial class AnnotationsVerticalLineTypeOptionsLabel  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsVerticalLineTypeOptionsLabel()
		{
			AllowOverlap = AllowOverlap_DefaultValue = true;
			BackgroundColor = BackgroundColor_DefaultValue = "none";
			BorderWidth = BorderWidth_DefaultValue = 0;
			Crop = Crop_DefaultValue = true;
			Offset = Offset_DefaultValue = -40;
			Overflow = Overflow_DefaultValue = AnnotationsVerticalLineTypeOptionsLabelOverflow.None;
			Shape = Shape_DefaultValue = "rect";
			Text = Text_DefaultValue = "{y:.2f}";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Crop { get; set; }
		private bool? Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Offset { get; set; }
		private double? Offset_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsVerticalLineTypeOptionsLabelOverflow Overflow { get; set; }
		private AnnotationsVerticalLineTypeOptionsLabelOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Shape { get; set; }
		private string Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow", highstock.FirstCharacterToLower(Overflow.ToString()));
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}
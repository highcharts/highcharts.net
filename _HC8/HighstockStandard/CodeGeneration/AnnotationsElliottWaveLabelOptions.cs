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
	public partial class AnnotationsElliottWaveLabelOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsElliottWaveLabelOptions()
		{
			Align = Align_DefaultValue = AnnotationsElliottWaveLabelOptionsAlign.Center;
			AllowOverlap = AllowOverlap_DefaultValue = true;
			BackgroundColor = BackgroundColor_DefaultValue = "none";
			BorderWidth = BorderWidth_DefaultValue = 0;
			Crop = Crop_DefaultValue = true;
			Overflow = Overflow_DefaultValue = "none";
			Type = Type_DefaultValue = "rect";
			Y = Y_DefaultValue = -5;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsElliottWaveLabelOptionsAlign Align { get; set; }
		private AnnotationsElliottWaveLabelOptionsAlign Align_DefaultValue { get; set; }
		 

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
		public string Overflow { get; set; }
		private string Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow",Overflow);
			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

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
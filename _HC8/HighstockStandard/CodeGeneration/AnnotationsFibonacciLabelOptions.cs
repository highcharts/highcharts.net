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
	public partial class AnnotationsFibonacciLabelOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsFibonacciLabelOptions()
		{
			Align = Align_DefaultValue = AnnotationsFibonacciLabelOptionsAlign.Right;
			AllowOverlap = AllowOverlap_DefaultValue = true;
			BackgroundColor = BackgroundColor_DefaultValue = "none";
			BorderWidth = BorderWidth_DefaultValue = 0;
			Crop = Crop_DefaultValue = false;
			Overflow = Overflow_DefaultValue = AnnotationsFibonacciLabelOptionsOverflow.None;
			Shape = Shape_DefaultValue = "rect";
			Style = Style_DefaultValue = new Hashtable();
			VerticalAlign = VerticalAlign_DefaultValue = AnnotationsFibonacciLabelOptionsVerticalAlign.Middle;
			Y = Y_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsFibonacciLabelOptionsAlign Align { get; set; }
		private AnnotationsFibonacciLabelOptionsAlign Align_DefaultValue { get; set; }
		 

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
		public AnnotationsFibonacciLabelOptionsOverflow Overflow { get; set; }
		private AnnotationsFibonacciLabelOptionsOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Shape { get; set; }
		private string Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsFibonacciLabelOptionsVerticalAlign VerticalAlign { get; set; }
		private AnnotationsFibonacciLabelOptionsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow", Highstock.FirstCharacterToLower(Overflow.ToString()));
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}
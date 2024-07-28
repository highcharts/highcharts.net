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
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsFibonacciLabelOptionsAlign Align { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? AllowOverlap { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BackgroundColor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Crop { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsFibonacciLabelOptionsOverflow Overflow { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Shape { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsFibonacciLabelOptionsVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Align != AnnotationsFibonacciLabelOptionsAlign.Null) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != null) h.Add("allowOverlap",AllowOverlap);
			if (BackgroundColor != null) h.Add("backgroundColor",BackgroundColor);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (Crop != null) h.Add("crop",Crop);
			if (Overflow != AnnotationsFibonacciLabelOptionsOverflow.Null) h.Add("overflow", highstock.FirstCharacterToLower(Overflow.ToString()));
			if (Shape != null) h.Add("shape",Shape);
			if (Style != null) h.Add("style",Style);
			if (VerticalAlign != AnnotationsFibonacciLabelOptionsVerticalAlign.Null) h.Add("verticalAlign", highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			if (Y != null) h.Add("y",Y);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}
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
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsElliottWaveLabelOptionsAlign Align { get; set; }
		 

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
		public AnnotationsElliottWaveLabelOptionsOverflow Overflow { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Type { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Align != AnnotationsElliottWaveLabelOptionsAlign.Null) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != null) h.Add("allowOverlap",AllowOverlap);
			if (BackgroundColor != null) h.Add("backgroundColor",BackgroundColor);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (Crop != null) h.Add("crop",Crop);
			if (Overflow != AnnotationsElliottWaveLabelOptionsOverflow.Null) h.Add("overflow", highstock.FirstCharacterToLower(Overflow.ToString()));
			if (Type != null) h.Add("type",Type);
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
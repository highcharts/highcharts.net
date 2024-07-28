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
		}	
		

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
		public double? Offset { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsVerticalLineTypeOptionsLabelOverflow Overflow { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Shape { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Text { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (AllowOverlap != null) h.Add("allowOverlap",AllowOverlap);
			if (BackgroundColor != null) h.Add("backgroundColor",BackgroundColor);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (Crop != null) h.Add("crop",Crop);
			if (Offset != null) h.Add("offset",Offset);
			if (Overflow != AnnotationsVerticalLineTypeOptionsLabelOverflow.Null) h.Add("overflow", highstock.FirstCharacterToLower(Overflow.ToString()));
			if (Shape != null) h.Add("shape",Shape);
			if (Text != null) h.Add("text",Text);
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
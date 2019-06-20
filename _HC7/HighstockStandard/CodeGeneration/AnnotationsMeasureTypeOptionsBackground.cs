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
	public partial class AnnotationsMeasureTypeOptionsBackground  : BaseObject
	{
		public AnnotationsMeasureTypeOptionsBackground()
		{
			Fill = Fill_DefaultValue = "rgba(130, 170, 255, 0.4)";
			Stroke = Stroke_DefaultValue = "";
			StrokeWidth = StrokeWidth_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// The color of the rectangle.
		/// </summary>
		public string Fill { get; set; }
		private string Fill_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of border.
		/// </summary>
		public  Stroke { get; set; }
		private  Stroke_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of border.
		/// </summary>
		public double? StrokeWidth { get; set; }
		private double? StrokeWidth_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Fill != Fill_DefaultValue) h.Add("fill",Fill);
			if (Stroke != Stroke_DefaultValue) h.Add("stroke",Stroke);
			if (StrokeWidth != StrokeWidth_DefaultValue) h.Add("strokeWidth",StrokeWidth);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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
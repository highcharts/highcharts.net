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
	public partial class AnnotationsFibonacciTimeZonesTypeOptionsLine  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsFibonacciTimeZonesTypeOptionsLine()
		{
			Stroke = Stroke_DefaultValue = " rgba(0, 0, 0, 0.75) ";
			StrokeWidth = StrokeWidth_DefaultValue = 1;
			
		}	
		

		/// <summary>
		/// The color of the lines.
		/// </summary>
		public string Stroke { get; set; }
		private string Stroke_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the lines.
		/// </summary>
		public double? StrokeWidth { get; set; }
		private double? StrokeWidth_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Stroke != Stroke_DefaultValue) h.Add("stroke",Stroke);
			if (StrokeWidth != StrokeWidth_DefaultValue) h.Add("strokeWidth",StrokeWidth);
			

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
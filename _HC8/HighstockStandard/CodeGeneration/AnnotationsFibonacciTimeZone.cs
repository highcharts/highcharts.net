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
	public partial class AnnotationsFibonacciTimeZone  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsFibonacciTimeZone()
		{
			ControlPointOptions = ControlPointOptions_DefaultValue = new AnnotationsFibonacciTimeZonesControlPointOptions();
			LabelOptions = LabelOptions_DefaultValue = new AnnotationsFibonacciTimeZonesLabelOptions();
			ShapeOptions = ShapeOptions_DefaultValue = new AnnotationsFibonacciTimeZonesShapeOptions();
			TypeOptions = TypeOptions_DefaultValue = new AnnotationsFibonacciTimeZonesTypeOptions();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsFibonacciTimeZonesControlPointOptions ControlPointOptions { get; set; }
		private AnnotationsFibonacciTimeZonesControlPointOptions ControlPointOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsFibonacciTimeZonesLabelOptions LabelOptions { get; set; }
		private AnnotationsFibonacciTimeZonesLabelOptions LabelOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsFibonacciTimeZonesShapeOptions ShapeOptions { get; set; }
		private AnnotationsFibonacciTimeZonesShapeOptions ShapeOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsFibonacciTimeZonesTypeOptions TypeOptions { get; set; }
		private AnnotationsFibonacciTimeZonesTypeOptions TypeOptions_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ControlPointOptions.IsDirty(ref highstock)) h.Add("controlPointOptions",ControlPointOptions.ToHashtable(ref highstock));
			if (LabelOptions.IsDirty(ref highstock)) h.Add("labelOptions",LabelOptions.ToHashtable(ref highstock));
			if (ShapeOptions.IsDirty(ref highstock)) h.Add("shapeOptions",ShapeOptions.ToHashtable(ref highstock));
			if (TypeOptions.IsDirty(ref highstock)) h.Add("typeOptions",TypeOptions.ToHashtable(ref highstock));
			

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
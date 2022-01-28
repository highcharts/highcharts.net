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
	public partial class NavigationAnnotationsOptionsFibonacciTimeZone  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationAnnotationsOptionsFibonacciTimeZone()
		{
			ControlPointOptions = ControlPointOptions_DefaultValue = new NavigationAnnotationsOptionsFibonacciTimeZonesControlPointOptions();
			LabelOptions = LabelOptions_DefaultValue = new NavigationAnnotationsOptionsFibonacciTimeZonesLabelOptions();
			ShapeOptions = ShapeOptions_DefaultValue = new NavigationAnnotationsOptionsFibonacciTimeZonesShapeOptions();
			TypeOptions = TypeOptions_DefaultValue = new NavigationAnnotationsOptionsFibonacciTimeZonesTypeOptions();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public NavigationAnnotationsOptionsFibonacciTimeZonesControlPointOptions ControlPointOptions { get; set; }
		private NavigationAnnotationsOptionsFibonacciTimeZonesControlPointOptions ControlPointOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigationAnnotationsOptionsFibonacciTimeZonesLabelOptions LabelOptions { get; set; }
		private NavigationAnnotationsOptionsFibonacciTimeZonesLabelOptions LabelOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigationAnnotationsOptionsFibonacciTimeZonesShapeOptions ShapeOptions { get; set; }
		private NavigationAnnotationsOptionsFibonacciTimeZonesShapeOptions ShapeOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigationAnnotationsOptionsFibonacciTimeZonesTypeOptions TypeOptions { get; set; }
		private NavigationAnnotationsOptionsFibonacciTimeZonesTypeOptions TypeOptions_DefaultValue { get; set; }
		  

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
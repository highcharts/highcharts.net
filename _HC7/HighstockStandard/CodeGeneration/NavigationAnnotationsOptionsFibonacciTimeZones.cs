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
	public partial class NavigationAnnotationsOptionsFibonacciTimeZones  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationAnnotationsOptionsFibonacciTimeZones()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public NavigationAnnotationsOptionsFibonacciTimeZonesControlPointOptions ControlPointOptions { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigationAnnotationsOptionsFibonacciTimeZonesLabelOptions LabelOptions { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigationAnnotationsOptionsFibonacciTimeZonesShapeOptions ShapeOptions { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigationAnnotationsOptionsFibonacciTimeZonesTypeOptions TypeOptions { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ControlPointOptions != null) h.Add("controlPointOptions",ControlPointOptions.ToHashtable(highstock));
			if (LabelOptions != null) h.Add("labelOptions",LabelOptions.ToHashtable(highstock));
			if (ShapeOptions != null) h.Add("shapeOptions",ShapeOptions.ToHashtable(highstock));
			if (TypeOptions != null) h.Add("typeOptions",TypeOptions.ToHashtable(highstock));
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
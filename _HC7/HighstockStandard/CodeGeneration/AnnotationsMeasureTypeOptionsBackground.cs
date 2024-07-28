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
		Hashtable h = new Hashtable();

		public AnnotationsMeasureTypeOptionsBackground()
		{
		}	
		

		/// <summary>
		/// The color of the rectangle.
		/// </summary>
		public string Fill { get; set; }
		 

		/// <summary>
		/// The color of border.
		/// </summary>
		public string Stroke { get; set; }
		 

		/// <summary>
		/// The width of border.
		/// </summary>
		public double? StrokeWidth { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Fill != null) h.Add("fill",Fill);
			if (Stroke != null) h.Add("stroke",Stroke);
			if (StrokeWidth != null) h.Add("strokeWidth",StrokeWidth);
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
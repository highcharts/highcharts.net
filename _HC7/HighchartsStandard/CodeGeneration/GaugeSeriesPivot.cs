using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class GaugeSeriesPivot  : BaseObject
	{
		Hashtable h = new Hashtable();

		public GaugeSeriesPivot()
		{
		}	
		

		/// <summary>
		/// The background color or fill of the pivot.
		/// </summary>
		public string BackgroundColor { get; set; }
		 

		/// <summary>
		/// The border or stroke color of the pivot. In able to changethis, the borderWidth must also be set to something otherthan the default 0.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// The border or stroke width of the pivot.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// The pixel radius of the pivot.
		/// </summary>
		public double? Radius { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (BackgroundColor != null) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (Radius != null) h.Add("radius",Radius);
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
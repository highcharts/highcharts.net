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
	public partial class AroonSeriesMarkerStatesSelect  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AroonSeriesMarkerStatesSelect()
		{
		}	
		

		/// <summary>
		/// Enable or disable visible feedback for selection.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// The fill color of the point marker.
		/// </summary>
		public object FillColor { get; set; }
		 

		/// <summary>
		/// The color of the point marker's outline. When`undefined`, the series' or point's color is used.
		/// </summary>
		public string LineColor { get; set; }
		 

		/// <summary>
		/// The width of the point marker's outline.
		/// </summary>
		public double? LineWidth { get; set; }
		 

		/// <summary>
		/// The radius of the point marker. In hover state, itdefaults to the normal state's radius + 2.
		/// </summary>
		public double? Radius { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Enabled != null) h.Add("enabled",Enabled);
			if (FillColor != null) h.Add("fillColor",FillColor);
			if (LineColor != null) h.Add("lineColor",LineColor);
			if (LineWidth != null) h.Add("lineWidth",LineWidth);
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
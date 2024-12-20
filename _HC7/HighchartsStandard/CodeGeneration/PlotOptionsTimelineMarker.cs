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
	public partial class PlotOptionsTimelineMarker  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTimelineMarker()
		{
		}	
		

		/// <summary>
		/// Enable or disable the point marker. If `undefined`, the markersare hidden when the data is dense, and shown for more widespreaddata points.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? EnabledThreshold { get; set; }
		 

		/// <summary>
		/// The fill color of the point marker. When `undefined`, the series'or point's color is used.
		/// </summary>
		public Object FillColor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Height { get; set; }
		 

		/// <summary>
		/// The color of the point marker's outline. When `undefined`, theseries' or point's color is used.
		/// </summary>
		public string LineColor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? LineWidth { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Radius { get; set; }
		 

		/// <summary>
		/// States for a single point marker.
		/// </summary>
		public PlotOptionsTimelineMarkerStates States { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Symbol { get; set; }
		 

		/// <summary>
		/// Image markers only. Set the image width explicitly. When usingthis option, a `height` must also be set.
		/// </summary>
		public double? Width { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Enabled != null) h.Add("enabled",Enabled);
			if (EnabledThreshold != null) h.Add("enabledThreshold",EnabledThreshold);
			if (FillColor != null) h.Add("fillColor",FillColor);
			if (Height != null) h.Add("height",Height);
			if (LineColor != null) h.Add("lineColor",LineColor);
			if (LineWidth != null) h.Add("lineWidth",LineWidth);
			if (Radius != null) h.Add("radius",Radius);
			if (States != null) h.Add("states",States.ToHashtable(highcharts));
			if (Symbol != null) h.Add("symbol",Symbol);
			if (Width != null) h.Add("width",Width);
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
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
	public partial class BbSeriesStatesSelectMarker  : BaseObject
	{
		Hashtable h = new Hashtable();

		public BbSeriesStatesSelectMarker()
		{
			Enabled = Enabled_DefaultValue = false;
			EnabledThreshold = EnabledThreshold_DefaultValue = 2;
			FillColor = FillColor_DefaultValue = "";
			Height = Height_DefaultValue = null;
			LineColor = LineColor_DefaultValue = "#ffffff";
			LineWidth = LineWidth_DefaultValue = 0;
			Radius = Radius_DefaultValue = 2;
			Width = Width_DefaultValue = null;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Enable or disable the point marker. If `undefined`, the markersare hidden when the data is dense, and shown for more widespreaddata points.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The threshold for how dense the point markers should be beforethey are hidden, given that `enabled` is not defined. The numberindicates the horizontal distance between the two closest pointsin the series, as multiples of the `marker.radius`. In otherwords, the default value of 2 means points are hidden ifoverlapping horizontally.
		/// </summary>
		public double? EnabledThreshold { get; set; }
		private double? EnabledThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of the point marker. When `undefined`, the series'or point's color is used.
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Image markers only. Set the image width explicitly. When usingthis option, a `width` must also be set.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the point marker's outline. When `undefined`, theseries' or point's color is used.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the point marker's outline.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius of the point marker.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// Image markers only. Set the image width explicitly. When usingthis option, a `height` must also be set.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (EnabledThreshold != EnabledThreshold_DefaultValue) h.Add("enabledThreshold",EnabledThreshold);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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
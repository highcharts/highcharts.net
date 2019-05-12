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
	public partial class PackedbubbleSeriesLayoutAlgorithmParentNodeOptionsMarker  : BaseObject
	{
		public PackedbubbleSeriesLayoutAlgorithmParentNodeOptionsMarker()
		{
			Enabled = Enabled_DefaultValue = null;
			EnabledThreshold = EnabledThreshold_DefaultValue = 2;
			FillColor = FillColor_DefaultValue = null;
			FillOpacity = FillOpacity_DefaultValue = 1;
			Height = Height_DefaultValue = null;
			LineColor = LineColor_DefaultValue = null;
			LineWidth = LineWidth_DefaultValue = 1;
			Radius = Radius_DefaultValue = 4;
			Symbol = Symbol_DefaultValue = "circle";
			Width = Width_DefaultValue = null;
			
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
		/// 
		/// </summary>
		public string FillColor { get; set; }
		private string FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? FillOpacity { get; set; }
		private double? FillOpacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// Image markers only. Set the image width explicitly. When usingthis option, a `width` must also be set.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Object LineColor { get; set; }
		private Object LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius of the point marker.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// Image markers only. Set the image width explicitly. When usingthis option, a `height` must also be set.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (EnabledThreshold != EnabledThreshold_DefaultValue) h.Add("enabledThreshold",EnabledThreshold);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (FillOpacity != FillOpacity_DefaultValue) h.Add("fillOpacity",FillOpacity);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			

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
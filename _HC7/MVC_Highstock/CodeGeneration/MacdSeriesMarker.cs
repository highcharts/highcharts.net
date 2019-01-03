using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class MacdSeriesMarker  : BaseObject
	{
		public MacdSeriesMarker()
		{
			Enabled = Enabled_DefaultValue = null;
			EnabledThreshold = EnabledThreshold_DefaultValue = 2;
			FillColor = FillColor_DefaultValue = "";
			Height = Height_DefaultValue = null;
			LineColor = LineColor_DefaultValue = "#ffffff";
			LineWidth = LineWidth_DefaultValue = 0;
			Radius = Radius_DefaultValue = 4;
			States = States_DefaultValue = new MacdSeriesMarkerStates();
			Symbol = Symbol_DefaultValue = "";
			Width = Width_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Enable or disable the point marker. If `undefined`, the markers arehidden when the data is dense, and shown for more widespread datapoints.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The threshold for how dense the point markers should be before theyare hidden, given that `enabled` is not defined. The number indicatesthe horizontal distance between the two closest points in the series,as multiples of the `marker.radius`. In other words, the defaultvalue of 2 means points are hidden if overlapping horizontally.
		/// </summary>
		public double? EnabledThreshold { get; set; }
		private double? EnabledThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of the point marker. When `undefined`, the series' orpoint's color is used.
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Image markers only. Set the image width explicitly. When using thisoption, a `width` must also be set.
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
		/// States for a single point marker.
		/// </summary>
		public MacdSeriesMarkerStates States { get; set; }
		private MacdSeriesMarkerStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// A predefined shape or symbol for the marker. When undefined, thesymbol is pulled from options.symbols. Other possible values are"circle", "square", "diamond", "triangle" and "triangle-down".Additionally, the URL to a graphic can be given on this form:"url(graphic.png)". Note that for the image to be applied to exportedcharts, its URL needs to be accessible by the export server.Custom callbacks for symbol path generation can also be added to`Highcharts.SVGRenderer.prototype.symbols`. The callback is thenused by its method name, as shown in the demo.
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// Image markers only. Set the image width explicitly. When using thisoption, a `height` must also be set.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (EnabledThreshold != EnabledThreshold_DefaultValue) h.Add("enabledThreshold",EnabledThreshold);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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
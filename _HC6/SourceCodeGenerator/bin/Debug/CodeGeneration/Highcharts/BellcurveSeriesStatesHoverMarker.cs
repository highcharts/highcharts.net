using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class BellcurveSeriesStatesHoverMarker  : BaseObject
	{
		public BellcurveSeriesStatesHoverMarker()
		{
			LineWidth = LineWidth_DefaultValue = 0;
			LineColor = LineColor_DefaultValue = "#ffffff";
			Radius = Radius_DefaultValue = 4;
			States = States_DefaultValue = new BellcurveSeriesStatesHoverMarkerStates();
			FillColor = FillColor_DefaultValue = null;
			Enabled = Enabled_DefaultValue = "";
			Height = Height_DefaultValue = null;
			Symbol = Symbol_DefaultValue = "null";
			Width = Width_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The width of the point marker's outline.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the point marker's outline. When `null`, the series'or point's color is used.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius of the point marker.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// States for a single point marker.
		/// </summary>
		public BellcurveSeriesStatesHoverMarkerStates States { get; set; }
		private BellcurveSeriesStatesHoverMarkerStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of the point marker. When `null`, the series' orpoint's color is used.
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the point marker. If `null`, the markers are hiddenwhen the data is dense, and shown for more widespread data points.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Image markers only. Set the image width explicitly. When using thisoption, a `width` must also be set.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// A predefined shape or symbol for the marker. When null, the symbolis pulled from options.symbols. Other possible values are "circle","square", "diamond", "triangle" and "triangle-down".Additionally, the URL to a graphic can be given on this form:"url(graphic.png)". Note that for the image to be applied to exportedcharts, its URL needs to be accessible by the export server.Custom callbacks for symbol path generation can also be added to`Highcharts.SVGRenderer.prototype.symbols`. The callback is thenused by its method name, as shown in the demo.
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

			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Height != Height_DefaultValue) h.Add("height",Height);
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
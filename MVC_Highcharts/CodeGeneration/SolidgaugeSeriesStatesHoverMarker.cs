using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highcharts.Web.Mvc
{
	public partial class SolidgaugeSeriesStatesHoverMarker  : BaseObject
	{
		public SolidgaugeSeriesStatesHoverMarker()
		{
			Enabled = Enabled_DefaultValue = true;
			FillColor = FillColor_DefaultValue = null;
			Height = Height_DefaultValue = null;
			LineColor = LineColor_DefaultValue = "#FFFFFF";
			LineWidth = LineWidth_DefaultValue = 0;
			Radius = Radius_DefaultValue = 4;
			Symbol = Symbol_DefaultValue = null;
			Width = Width_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Enable or disable the point marker.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of the point marker. When <code>null</code>, the series' or point's color is used.
		/// </summary>
		public string FillColor { get; set; }
		private string FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Image markers only. Set the image width explicitly. When using this option, a <code>width</code> must also be set.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the point marker's outline. When <code>null</code>, the series' or point's color is used.
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
		/// <p>A predefined shape or symbol for the marker. When null, the symbol is pulled from options.symbols. Other possible values are "circle", "square", "diamond", "triangle" and "triangle-down".</p><p>Additionally, the URL to a graphic can be given on this form:  "url(graphic.png)". Note that for the image to be applied to exported charts, its URL needs to be accessible by the export server.</p><p>Custom callbacks for symbol path generation can also be added to <code>Highcharts.SVGRenderer.prototype.symbols</code>. The callback is then used by its method name, as shown in the demo.</p>
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// Image markers only. Set the image width explicitly. When using this option, a <code>height</code> must also be set.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
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
				return new JavaScriptSerializer().Serialize(ToHashtable());
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
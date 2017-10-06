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
	public partial class PyramidSeriesIkhStatesSelectMarker  : BaseObject
	{
		public PyramidSeriesIkhStatesSelectMarker()
		{
			LineWidth = LineWidth_DefaultValue = 0;
			LineColor = LineColor_DefaultValue = "#ffffff";
			Radius = Radius_DefaultValue = 4;
			States = States_DefaultValue = new PyramidSeriesIkhStatesSelectMarkerStates();
			FillColor = FillColor_DefaultValue = null;
			Enabled = Enabled_DefaultValue = null;
			Height = Height_DefaultValue = null;
			Symbol = Symbol_DefaultValue = "null";
			Width = Width_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The width of the point marker&#39;s outline.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the point marker&#39;s outline. When <code>null</code>, the series&#39;or point&#39;s color is used.</p>
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The radius of the point marker.</p>
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>States for a single point marker.</p>
		/// </summary>
		public PyramidSeriesIkhStatesSelectMarkerStates States { get; set; }
		private PyramidSeriesIkhStatesSelectMarkerStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The fill color of the point marker. When <code>null</code>, the series&#39; orpoint&#39;s color is used.</p>
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the point marker. If <code>null</code>, the markers are hiddenwhen the data is dense, and shown for more widespread data points.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Image markers only. Set the image width explicitly. When using thisoption, a <code>width</code> must also be set.</p>
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A predefined shape or symbol for the marker. When null, the symbolis pulled from options.symbols. Other possible values are &quot;circle&quot;,&quot;square&quot;, &quot;diamond&quot;, &quot;triangle&quot; and &quot;triangle-down&quot;.</p><p>Additionally, the URL to a graphic can be given on this form:&quot;url(graphic.png)&quot;. Note that for the image to be applied to exportedcharts, its URL needs to be accessible by the export server.</p><p>Custom callbacks for symbol path generation can also be added to<code>Highcharts.SVGRenderer.prototype.symbols</code>. The callback is thenused by its method name, as shown in the demo.</p>
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Image markers only. Set the image width explicitly. When using thisoption, a <code>height</code> must also be set.</p>
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
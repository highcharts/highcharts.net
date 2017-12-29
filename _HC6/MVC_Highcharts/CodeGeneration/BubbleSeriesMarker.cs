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
	public partial class BubbleSeriesMarker  : BaseObject
	{
		public BubbleSeriesMarker()
		{
			Radius = Radius_DefaultValue = "";
			LineWidth = LineWidth_DefaultValue = 0;
			LineColor = LineColor_DefaultValue = "#ffffff";
			States = States_DefaultValue = new BubbleSeriesMarkerStates();
			FillColor = FillColor_DefaultValue = null;
			Symbol = Symbol_DefaultValue = "null";
			
		}	
		

		/// <summary>
		/// In bubble charts, the radius is overridden and determined based on the point's data value.
		/// </summary>
		public BubbleSeriesMarkerRadius Radius { get; set; }
		private BubbleSeriesMarkerRadius Radius_DefaultValue { get; set; }
		 

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
		/// States for a single point marker.
		/// </summary>
		public BubbleSeriesMarkerStates States { get; set; }
		private BubbleSeriesMarkerStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of the point marker. When `null`, the series' orpoint's color is used.
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A predefined shape or symbol for the marker. When null, the symbolis pulled from options.symbols. Other possible values are "circle","square", "diamond", "triangle" and "triangle-down".Additionally, the URL to a graphic can be given on this form:"url(graphic.png)". Note that for the image to be applied to exportedcharts, its URL needs to be accessible by the export server.Custom callbacks for symbol path generation can also be added to`Highcharts.SVGRenderer.prototype.symbols`. The callback is thenused by its method name, as shown in the demo.
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			

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
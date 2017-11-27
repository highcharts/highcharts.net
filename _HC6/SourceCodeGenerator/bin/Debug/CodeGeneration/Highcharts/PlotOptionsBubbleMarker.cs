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
	public partial class PlotOptionsBubbleMarker  : BaseObject
	{
		public PlotOptionsBubbleMarker()
		{
			LineColor = LineColor_DefaultValue = null;
			LineWidth = LineWidth_DefaultValue = 1;
			Radius = Radius_DefaultValue = null;
			States = States_DefaultValue = null;
			Symbol = Symbol_DefaultValue = "circle";
			LineColor = LineColor_DefaultValue = "";
			LineWidth = LineWidth_DefaultValue = 1;
			States = States_DefaultValue = "";
			Hover = Hover_DefaultValue = "";
			RadiusPlus = RadiusPlus_DefaultValue = 0;
			Symbol = Symbol_DefaultValue = "circle";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleMarkerLineColor LineColor { get; set; }
		private PlotOptionsBubbleMarkerLineColor LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleMarkerLineWidth LineWidth { get; set; }
		private PlotOptionsBubbleMarkerLineWidth LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// In bubble charts, the radius is overridden and determined based on the point's data value.
		/// </summary>
		public PlotOptionsBubbleMarkerRadius Radius { get; set; }
		private PlotOptionsBubbleMarkerRadius Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleMarkerStates States { get; set; }
		private PlotOptionsBubbleMarkerStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// A predefined shape or symbol for the marker. Possible values are"circle", "square", "diamond", "triangle" and "triangle-down".Additionally, the URL to a graphic can be given on the form`url(graphic.png)`. Note that for the image to be applied to exportedcharts, its URL needs to be accessible by the export server.Custom callbacks for symbol path generation can also be added to`Highcharts.SVGRenderer.prototype.symbols`. The callback is thenused by its method name, as shown in the demo.
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleMarkerLineColor LineColor { get; set; }
		private PlotOptionsBubbleMarkerLineColor LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleMarkerLineWidth LineWidth { get; set; }
		private PlotOptionsBubbleMarkerLineWidth LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleMarkerStates States { get; set; }
		private PlotOptionsBubbleMarkerStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleMarkerHover Hover { get; set; }
		private PlotOptionsBubbleMarkerHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleMarkerRadiusPlus RadiusPlus { get; set; }
		private PlotOptionsBubbleMarkerRadiusPlus RadiusPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// A predefined shape or symbol for the marker. Possible values are"circle", "square", "diamond", "triangle" and "triangle-down".Additionally, the URL to a graphic can be given on the form`url(graphic.png)`. Note that for the image to be applied to exportedcharts, its URL needs to be accessible by the export server.Custom callbacks for symbol path generation can also be added to`Highcharts.SVGRenderer.prototype.symbols`. The callback is thenused by its method name, as shown in the demo.
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (RadiusPlus != RadiusPlus_DefaultValue) h.Add("radiusPlus",RadiusPlus);
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
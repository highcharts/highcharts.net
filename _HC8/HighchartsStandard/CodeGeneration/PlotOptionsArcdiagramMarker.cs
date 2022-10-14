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
	public partial class PlotOptionsArcdiagramMarker  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsArcdiagramMarker()
		{
			FillColor = FillColor_DefaultValue = null;
			FillOpacity = FillOpacity_DefaultValue = 1;
			LineColor = LineColor_DefaultValue = "#ffffff";
			LineWidth = LineWidth_DefaultValue = 0;
			Radius = Radius_DefaultValue = 4;
			States = States_DefaultValue = new PlotOptionsArcdiagramMarkerStates();
			Symbol = Symbol_DefaultValue = "circle";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The fill color of the point marker. When `undefined`, the series'or point's color is used.
		/// </summary>
		public Object FillColor { get; set; }
		private Object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? FillOpacity { get; set; }
		private double? FillOpacity_DefaultValue { get; set; }
		 

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
		public PlotOptionsArcdiagramMarkerStates States { get; set; }
		private PlotOptionsArcdiagramMarkerStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (FillOpacity != FillOpacity_DefaultValue) h.Add("fillOpacity",FillOpacity);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (States.IsDirty(highcharts)) h.Add("states",States.ToHashtable(highcharts));
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}
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
	public partial class BubbleSeriesDataMarker  : BaseObject
	{
		Hashtable h = new Hashtable();

		public BubbleSeriesDataMarker()
		{
			Enabled = Enabled_DefaultValue = null;
			FillColor = FillColor_DefaultValue = "";
			LineColor = LineColor_DefaultValue = "#ffffff";
			LineWidth = LineWidth_DefaultValue = 0;
			States = States_DefaultValue = new BubbleSeriesDataMarkerStates();
			Symbol = Symbol_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Enable or disable the point marker. If `undefined`, the markersare hidden when the data is dense, and shown for more widespreaddata points.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of the point marker. When `undefined`, the series'or point's color is used.
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

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
		/// States for a single point marker.
		/// </summary>
		public BubbleSeriesDataMarkerStates States { get; set; }
		private BubbleSeriesDataMarkerStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// A predefined shape or symbol for the marker. When undefined, thesymbol is pulled from options.symbols. Other possible values are`'circle'`, `'square'`,`'diamond'`, `'triangle'` and`'triangle-down'`.Additionally, the URL to a graphic can be given on this form:`'url(graphic.png)'`. Note that for the image to be applied toexported charts, its URL needs to be accessible by the exportserver.Custom callbacks for symbol path generation can also be added to`Highcharts.SVGRenderer.prototype.symbols`. The callback is thenused by its method name, as shown in the demo.
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (States.IsDirty(highstock)) h.Add("states",States.ToHashtable(highstock));
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			

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
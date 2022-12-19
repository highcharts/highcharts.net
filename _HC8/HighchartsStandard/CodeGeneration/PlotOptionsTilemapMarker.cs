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
	public partial class PlotOptionsTilemapMarker  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTilemapMarker()
		{
			LineColor = LineColor_DefaultValue = "undefined";
			States = States_DefaultValue = new PlotOptionsTilemapMarkerStates();
			Symbol = Symbol_DefaultValue = "rect";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapMarkerStates States { get; set; }
		private PlotOptionsTilemapMarkerStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// A predefined shape or symbol for the marker. When undefined, thesymbol is pulled from options.symbols. Other possible values are`'circle'`, `'square'`,`'diamond'`, `'triangle'`,`'triangle-down'`, `'rect'`, and `'ellipse'`.Additionally, the URL to a graphic can be given on this form:`'url(graphic.png)'`. Note that for the image to be applied toexported charts, its URL needs to be accessible by the exportserver.Custom callbacks for symbol path generation can also be added to`Highcharts.SVGRenderer.prototype.symbols`. The callback is thenused by its method name, as shown in the demo.
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
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
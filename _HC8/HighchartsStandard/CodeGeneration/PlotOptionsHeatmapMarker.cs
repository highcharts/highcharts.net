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
	public partial class PlotOptionsHeatmapMarker  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsHeatmapMarker()
		{
			LineColor = LineColor_DefaultValue = "undefined";
			States = States_DefaultValue = new PlotOptionsHeatmapMarkerStates();
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
		public PlotOptionsHeatmapMarkerStates States { get; set; }
		private PlotOptionsHeatmapMarkerStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// A predefined shape or symbol for the marker. When undefined, thesymbol is pulled from options.symbols. Other possible values are`'circle'`, `'square'`,`'diamond'`, `'triangle'`,`'triangle-down'`, `'rect'`, and `'ellipse'`.Additionally, the URL to a graphic can be given on this form:`'url(graphic.png)'`. Note that for the image to be applied toexported charts, its URL needs to be accessible by the exportserver.Custom callbacks for symbol path generation can also be added to`Highcharts.SVGRenderer.prototype.symbols`. The callback is thenused by its method name, as shown in the demo.
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
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

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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
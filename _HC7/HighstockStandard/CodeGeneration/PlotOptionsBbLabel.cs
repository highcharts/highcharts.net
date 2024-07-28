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
	public partial class PlotOptionsBbLabel  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsBbLabel()
		{
		}	
		

		/// <summary>
		/// An array of boxes to avoid when laying out the labels. Eachitem has a `left`, `right`, `top` and `bottom` property.
		/// </summary>
		public List<object> BoxesToAvoid { get; set; }
		 

		/// <summary>
		/// Allow labels to be placed distant to the graph if necessary,and draw a connector line to the graph. Setting this optionto true may decrease the performance significantly, since thealgorithm with systematically search for open spaces in thewhole plot area. Visually, it may also result in a morecluttered chart, though more of the series will be labeled.
		/// </summary>
		public bool? ConnectorAllowed { get; set; }
		 

		/// <summary>
		/// If the label is closer than this to a neighbour graph, draw aconnector.
		/// </summary>
		public double? ConnectorNeighbourDistance { get; set; }
		 

		/// <summary>
		/// Enable the series label per series.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// A format string for the label, with support for a subset ofHTML. Variables are enclosed by curly brackets. Availablevariables are `name`, `options.xxx`, `color` and othermembers from the `series` object. Use this option also to seta static text for the label.
		/// </summary>
		public string Format { get; set; }
		 

		/// <summary>
		/// Callback function to format each of the series' labels. The`this` keyword refers to the series object. By default the`formatter` is undefined and the `series.name` is rendered.
		/// </summary>
		public string Formatter { get; set; }
		 

		/// <summary>
		/// For area-like series, allow the font size to vary so thatsmall areas get a smaller font size. The default applies thiseffect to area-like series but not line-like series.
		/// </summary>
		public double? MaxFontSize { get; set; }
		 

		/// <summary>
		/// For area-like series, allow the font size to vary so thatsmall areas get a smaller font size. The default applies thiseffect to area-like series but not line-like series.
		/// </summary>
		public double? MinFontSize { get; set; }
		 

		/// <summary>
		/// Draw the label on the area of an area series. By default itis drawn on the area. Set it to `false` to draw it next tothe graph instead.
		/// </summary>
		public bool? OnArea { get; set; }
		 

		/// <summary>
		/// Styles for the series label. The color defaults to the seriescolor, or a contrast color if `onArea`.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// Whether to use HTML to render the series label.
		/// </summary>
		public bool? UseHTML { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (BoxesToAvoid != null) h.Add("boxesToAvoid",BoxesToAvoid);
			if (ConnectorAllowed != null) h.Add("connectorAllowed",ConnectorAllowed);
			if (ConnectorNeighbourDistance != null) h.Add("connectorNeighbourDistance",ConnectorNeighbourDistance);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Format != null) h.Add("format",Format);
			if (Formatter != null) { h.Add("formatter",Formatter); highstock.AddFunction("formatter", Formatter); }  
			if (MaxFontSize != null) h.Add("maxFontSize",MaxFontSize);
			if (MinFontSize != null) h.Add("minFontSize",MinFontSize);
			if (OnArea != null) h.Add("onArea",OnArea);
			if (Style != null) h.Add("style",Style);
			if (UseHTML != null) h.Add("useHTML",UseHTML);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}
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
	public partial class WaterfallSeriesLabel  : BaseObject
	{
		Hashtable h = new Hashtable();

		public WaterfallSeriesLabel()
		{
			BoxesToAvoid = BoxesToAvoid_DefaultValue = new List<object>();
			ConnectorAllowed = ConnectorAllowed_DefaultValue = false;
			ConnectorNeighbourDistance = ConnectorNeighbourDistance_DefaultValue = 24;
			Enabled = Enabled_DefaultValue = true;
			Format = Format_DefaultValue = "undefined";
			Formatter = Formatter_DefaultValue = "";
			MaxFontSize = MaxFontSize_DefaultValue = null;
			MinFontSize = MinFontSize_DefaultValue = null;
			OnArea = OnArea_DefaultValue = null;
			Style = Style_DefaultValue = new Hashtable();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// An array of boxes to avoid when laying out the labels. Eachitem has a `left`, `right`, `top` and `bottom` property.
		/// </summary>
		public List<object> BoxesToAvoid { get; set; }
		private List<object> BoxesToAvoid_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow labels to be placed distant to the graph if necessary,and draw a connector line to the graph. Setting this optionto true may decrease the performance significantly, since thealgorithm with systematically search for open spaces in thewhole plot area. Visually, it may also result in a morecluttered chart, though more of the series will be labeled.
		/// </summary>
		public bool? ConnectorAllowed { get; set; }
		private bool? ConnectorAllowed_DefaultValue { get; set; }
		 

		/// <summary>
		/// If the label is closer than this to a neighbour graph, draw aconnector.
		/// </summary>
		public double? ConnectorNeighbourDistance { get; set; }
		private double? ConnectorNeighbourDistance_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable the series label per series.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// A format string for the label, with support for a subset ofHTML. Variables are enclosed by curly brackets. Availablevariables are `name`, `options.xxx`, `color` and othermembers from the `series` object. Use this option also to seta static text for the label.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback function to format each of the series' labels. The`this` keyword refers to the series object. By default the`formatter` is undefined and the `series.name` is rendered.
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// For area-like series, allow the font size to vary so thatsmall areas get a smaller font size. The default applies thiseffect to area-like series but not line-like series.
		/// </summary>
		public double? MaxFontSize { get; set; }
		private double? MaxFontSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// For area-like series, allow the font size to vary so thatsmall areas get a smaller font size. The default applies thiseffect to area-like series but not line-like series.
		/// </summary>
		public double? MinFontSize { get; set; }
		private double? MinFontSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Draw the label on the area of an area series. By default itis drawn on the area. Set it to `false` to draw it next tothe graph instead.
		/// </summary>
		public bool? OnArea { get; set; }
		private bool? OnArea_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styles for the series label. The color defaults to the seriescolor, or a contrast color if `onArea`.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (BoxesToAvoid != BoxesToAvoid_DefaultValue) h.Add("boxesToAvoid",BoxesToAvoid);
			if (ConnectorAllowed != ConnectorAllowed_DefaultValue) h.Add("connectorAllowed",ConnectorAllowed);
			if (ConnectorNeighbourDistance != ConnectorNeighbourDistance_DefaultValue) h.Add("connectorNeighbourDistance",ConnectorNeighbourDistance);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highcharts.AddFunction("formatter", Formatter); }  
			if (MaxFontSize != MaxFontSize_DefaultValue) h.Add("maxFontSize",MaxFontSize);
			if (MinFontSize != MinFontSize_DefaultValue) h.Add("minFontSize",MinFontSize);
			if (OnArea != OnArea_DefaultValue) h.Add("onArea",OnArea);
			if (Style != Style_DefaultValue) h.Add("style",Style);
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
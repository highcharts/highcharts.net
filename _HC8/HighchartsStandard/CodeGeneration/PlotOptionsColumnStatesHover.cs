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
	public partial class PlotOptionsColumnStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsColumnStatesHover()
		{
			Animation = Animation_DefaultValue = new Animation();
			BorderColor = BorderColor_DefaultValue = "";
			Brightness = Brightness_DefaultValue = new Hashtable();
			Color = Color_DefaultValue = "";
			Enabled = Enabled_DefaultValue = null;
			Halo = Halo_DefaultValue = new PlotOptionsColumnStatesHoverHalo();
			LineWidth = LineWidth_DefaultValue = null;
			LineWidthPlus = LineWidthPlus_DefaultValue = null;
			Marker = Marker_DefaultValue = new PlotOptionsColumnStatesHoverMarker();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Animation setting for hovering the graph in line-type series.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// A specific border color for the hovered point. Defaults toinherit the normal state border color.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// How much to brighten the point on interaction. Requires themain color to be defined in hex or rgb(a) format.In styled mode, the hover brightening is by default replacedwith a fill-opacity set in the `.highcharts-point:hover`rule.
		/// </summary>
		public Hashtable Brightness { get; set; }
		private Hashtable Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// A specific color for the hovered point.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable separate styles for the hovered series to visualizethat the user hovers either the series itself or the legend.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the halo appearing around the hovered point inline-type series as well as outside the hovered slice in piecharts. By default the halo is filled by the current point orseries color with an opacity of 0.25\. The halo can bedisabled by setting the `halo` option to `null`.In styled mode, the halo is styled with the`.highcharts-halo` class, with colors inherited from`.highcharts-color-{n}`.
		/// </summary>
		public PlotOptionsColumnStatesHoverHalo Halo { get; set; }
		private PlotOptionsColumnStatesHoverHalo Halo_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel width of the graph line. By default this property isundefined, and the `lineWidthPlus` property dictates how muchto increase the linewidth from normal state.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The additional line width for the graph of a hovered series.
		/// </summary>
		public double? LineWidthPlus { get; set; }
		private double? LineWidthPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// In Highcharts 1.0, the appearance of all markers belongingto the hovered series. For settings on the hover state of theindividual point, see[marker.states.hover](#plotOptions.series.marker.states.hover).
		/// </summary>
		public PlotOptionsColumnStatesHoverMarker Marker { get; set; }
		private PlotOptionsColumnStatesHoverMarker Marker_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Animation.IsDirty(highcharts)) h.Add("animation",Animation.ToHashtable(highcharts));
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Halo.IsDirty(highcharts)) h.Add("halo",Halo.ToHashtable(highcharts));
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LineWidthPlus != LineWidthPlus_DefaultValue) h.Add("lineWidthPlus",LineWidthPlus);
			if (Marker.IsDirty(highcharts)) h.Add("marker",Marker.ToHashtable(highcharts));
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
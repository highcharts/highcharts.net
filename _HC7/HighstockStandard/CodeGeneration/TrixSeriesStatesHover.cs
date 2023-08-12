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
	public partial class TrixSeriesStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public TrixSeriesStatesHover()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			AnimationBool = AnimationBool_DefaultValue = null;
			Enabled = Enabled_DefaultValue = true;
			Halo = Halo_DefaultValue = new TrixSeriesStatesHoverHalo();
			LineWidth = LineWidth_DefaultValue = null;
			LineWidthPlus = LineWidthPlus_DefaultValue = 1;
			Marker = Marker_DefaultValue = new TrixSeriesStatesHoverMarker();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Animation setting for hovering the graph in line-type series.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Animation setting for hovering the graph in line-type series.
		/// </summary>
		public bool? AnimationBool { get; set; }
		private bool? AnimationBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable separate styles for the hovered series to visualizethat the user hovers either the series itself or the legend.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the halo appearing around the hovered point inline-type series as well as outside the hovered slice in piecharts. By default the halo is filled by the current point orseries color with an opacity of 0.25\. The halo can bedisabled by setting the `halo` option to `null`.In styled mode, the halo is styled with the`.highcharts-halo` class, with colors inherited from`.highcharts-color-{n}`.
		/// </summary>
		public TrixSeriesStatesHoverHalo Halo { get; set; }
		private TrixSeriesStatesHoverHalo Halo_DefaultValue { get; set; }
		 

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
		public TrixSeriesStatesHoverMarker Marker { get; set; }
		private TrixSeriesStatesHoverMarker Marker_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Animation.IsDirty(highstock)) h.Add("animation",Animation.ToJSON(highstock));
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Halo.IsDirty(highstock)) h.Add("halo",Halo.ToHashtable(highstock));
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LineWidthPlus != LineWidthPlus_DefaultValue) h.Add("lineWidthPlus",LineWidthPlus);
			if (Marker.IsDirty(highstock)) h.Add("marker",Marker.ToHashtable(highstock));
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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
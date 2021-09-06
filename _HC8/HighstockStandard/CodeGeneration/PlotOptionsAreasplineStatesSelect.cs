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
	public partial class PlotOptionsAreasplineStatesSelect  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsAreasplineStatesSelect()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Enabled = Enabled_DefaultValue = null;
			Halo = Halo_DefaultValue = new PlotOptionsAreasplineStatesSelectHalo();
			LineWidth = LineWidth_DefaultValue = null;
			LineWidthPlus = LineWidthPlus_DefaultValue = null;
			Marker = Marker_DefaultValue = new PlotOptionsAreasplineStatesSelectMarker();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable separate styles for the hovered series to visualizethat the user hovers either the series itself or the legend.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the halo appearing around the hovered point inline-type series as well as outside the hovered slice in piecharts. By default the halo is filled by the current point orseries color with an opacity of 0.25\. The halo can bedisabled by setting the `halo` option to `null`.In styled mode, the halo is styled with the`.highcharts-halo` class, with colors inherited from`.highcharts-color-{n}`.
		/// </summary>
		public PlotOptionsAreasplineStatesSelectHalo Halo { get; set; }
		private PlotOptionsAreasplineStatesSelectHalo Halo_DefaultValue { get; set; }
		 

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
		public PlotOptionsAreasplineStatesSelectMarker Marker { get; set; }
		private PlotOptionsAreasplineStatesSelectMarker Marker_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Animation.IsDirty(ref highstock)) h.Add("animation",Animation.ToJSON(ref highstock));
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Halo.IsDirty(ref highstock)) h.Add("halo",Halo.ToHashtable(ref highstock));
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LineWidthPlus != LineWidthPlus_DefaultValue) h.Add("lineWidthPlus",LineWidthPlus);
			if (Marker.IsDirty(ref highstock)) h.Add("marker",Marker.ToHashtable(ref highstock));
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}
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
	public partial class VariwideSeriesStatesHover  : BaseObject
	{
		public VariwideSeriesStatesHover()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			AnimationBool = AnimationBool_DefaultValue = null;
			Enabled = Enabled_DefaultValue = true;
			Halo = Halo_DefaultValue = new VariwideSeriesStatesHoverHalo();
			LineWidth = LineWidth_DefaultValue = null;
			LineWidthPlus = LineWidthPlus_DefaultValue = 1;
			Marker = Marker_DefaultValue = new VariwideSeriesStatesHoverMarker();
			
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
		/// Enable separate styles for the hovered series to visualize thatthe user hovers either the series itself or the legend. .
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the halo appearing around the hovered point in line-type series as well as outside the hovered slice in pie charts.By default the halo is filled by the current point or seriescolor with an opacity of 0.25\. The halo can be disabled bysetting the `halo` option to `false`.In styled mode, the halo is styled with the `.highcharts-halo`class, with colors inherited from `.highcharts-color-{n}`.
		/// </summary>
		public VariwideSeriesStatesHoverHalo Halo { get; set; }
		private VariwideSeriesStatesHoverHalo Halo_DefaultValue { get; set; }
		 

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
		/// In Highcharts 1.0, the appearance of all markers belonging to thehovered series. For settings on the hover state of the individualpoint, see[marker.states.hover](#plotOptions.series.marker.states.hover).
		/// </summary>
		public VariwideSeriesStatesHoverMarker Marker { get; set; }
		private VariwideSeriesStatesHoverMarker Marker_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Halo.IsDirty()) h.Add("halo",Halo.ToHashtable());
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LineWidthPlus != LineWidthPlus_DefaultValue) h.Add("lineWidthPlus",LineWidthPlus);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			

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
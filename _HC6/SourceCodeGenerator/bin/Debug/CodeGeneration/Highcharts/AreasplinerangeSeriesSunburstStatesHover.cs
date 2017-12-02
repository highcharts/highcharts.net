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
	public partial class AreasplinerangeSeriesSunburstStatesHover  : BaseObject
	{
		public AreasplinerangeSeriesSunburstStatesHover()
		{
			Brightness = Brightness_DefaultValue = 0.1;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			LineWidthPlus = LineWidthPlus_DefaultValue = 1;
			Marker = Marker_DefaultValue = "";
			Halo = Halo_DefaultValue = "";
			Enabled = Enabled_DefaultValue = true;
			LineWidth = LineWidth_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// How much to brighten the point on interaction. Requires the maincolor to be defined in hex or rgb(a) format.In styled mode, the hover brightness is by default replacedby a fill-opacity given in the `.highcharts-point-hover` class.
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Animation setting for hovering the graph in line-type series.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The additional line width for the graph of a hovered series.
		/// </summary>
		public double? LineWidthPlus { get; set; }
		private double? LineWidthPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// In Highcharts 1.0, the appearance of all markers belonging tothe hovered series. For settings on the hover state of the individualpoint, see [marker.states.hover](#plotOptions.series.marker.states.hover).
		/// </summary>
		public AreasplinerangeSeriesSunburstStatesHoverMarker Marker { get; set; }
		private AreasplinerangeSeriesSunburstStatesHoverMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the halo appearing around the hovered point in line-type series as well as outside the hovered slice in pie charts.By default the halo is filled by the current point or seriescolor with an opacity of 0.25\. The halo can be disabled by settingthe `halo` option to `false`.In styled mode, the halo is styled with the `.highcharts-halo` class, with colors inherited from `.highcharts-color-{n}`.
		/// </summary>
		public AreasplinerangeSeriesSunburstStatesHoverHalo Halo { get; set; }
		private AreasplinerangeSeriesSunburstStatesHoverHalo Halo_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable separate styles for the hovered series to visualize that theuser hovers either the series itself or the legend. .
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel with of the graph line. By default this property isundefined, and the `lineWidthPlus` property dictates how muchto increase the linewidth from normal state.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (LineWidthPlus != LineWidthPlus_DefaultValue) h.Add("lineWidthPlus",LineWidthPlus);
			if (Marker != Marker_DefaultValue) h.Add("marker",Marker);
			if (Halo.IsDirty()) h.Add("halo",Halo.ToHashtable());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			

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
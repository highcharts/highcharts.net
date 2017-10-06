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
	public partial class SankeySeriesStatesHover  : BaseObject
	{
		public SankeySeriesStatesHover()
		{
			LinkOpacity = LinkOpacity_DefaultValue = null;
			Brightness = Brightness_DefaultValue = 0.1;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			BorderColor = BorderColor_DefaultValue = null;
			Color = Color_DefaultValue = "undefined";
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Enabled = Enabled_DefaultValue = true;
			LineWidthPlus = LineWidthPlus_DefaultValue = 1;
			Marker = Marker_DefaultValue = new SankeySeriesStatesHoverMarker();
			Halo = Halo_DefaultValue = new SankeySeriesStatesHoverHalo();
			LineWidth = LineWidth_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Opacity for the links between nodes in the sankey diagram inhover mode.</p>
		/// </summary>
		public double? LinkOpacity { get; set; }
		private double? LinkOpacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>How much to brighten the point on interaction. Requires the maincolor to be defined in hex or rgb(a) format.</p><p>In styled mode, the hover brightening is by default replacedwith a fill-opacity set in the <code>.highcharts-point:hover</code> rule.</p>
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A specific border color for the hovered point. Defaults toinherit the normal state border color.</p>
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A specific color for the hovered point.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Animation setting for hovering the graph in line-type series.</p>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable separate styles for the hovered series to visualize that theuser hovers either the series itself or the legend. .</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The additional line width for the graph of a hovered series.</p>
		/// </summary>
		public double? LineWidthPlus { get; set; }
		private double? LineWidthPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>In Highcharts 1.0, the appearance of all markers belonging tothe hovered series. For settings on the hover state of the individualpoint, see <a href="#plotOptions.series.marker.states.hover">marker.states.hover</a>.</p>
		/// </summary>
		public SankeySeriesStatesHoverMarker Marker { get; set; }
		private SankeySeriesStatesHoverMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the halo appearing around the hovered point in line-type series as well as outside the hovered slice in pie charts.By default the halo is filled by the current point or seriescolor with an opacity of 0.25. The halo can be disabled by settingthe <code>halo</code> option to <code>false</code>.</p><p>In styled mode, the halo is styled with the <code>.highcharts-halo</code> class, with colors inherited from <code>.highcharts-color-{n}</code>.</p>
		/// </summary>
		public SankeySeriesStatesHoverHalo Halo { get; set; }
		private SankeySeriesStatesHoverHalo Halo_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Pixel with of the graph line. By default this property isundefined, and the <code>lineWidthPlus</code> property dictates how muchto increase the linewidth from normal state.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LinkOpacity != LinkOpacity_DefaultValue) h.Add("linkOpacity",LinkOpacity);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (LineWidthPlus != LineWidthPlus_DefaultValue) h.Add("lineWidthPlus",LineWidthPlus);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (Halo.IsDirty()) h.Add("halo",Halo.ToHashtable());
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class StochasticSeriesMarkerStatesHover  : BaseObject
	{
		public StochasticSeriesMarkerStatesHover()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Enabled = Enabled_DefaultValue = true;
			RadiusPlus = RadiusPlus_DefaultValue = 2;
			LineWidthPlus = LineWidthPlus_DefaultValue = 1;
			FillColor = FillColor_DefaultValue = null;
			LineColor = LineColor_DefaultValue = "#ffffff";
			LineWidth = LineWidth_DefaultValue = 0;
			Radius = Radius_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Animation when hovering over the marker.</p>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the point marker.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The number of pixels to increase the radius of the hovered point.</p>
		/// </summary>
		public double? RadiusPlus { get; set; }
		private double? RadiusPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The additional line width for a hovered point.</p>
		/// </summary>
		public double? LineWidthPlus { get; set; }
		private double? LineWidthPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The fill color of the marker in hover state.</p>
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the point marker&#39;s outline. When <code>null</code>, theseries&#39; or point&#39;s color is used.</p>
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the point marker&#39;s outline.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The radius of the point marker. In hover state, it defaults to thenormal state&#39;s radius + 2 as per the <a href="#plotOptions.series.marker.states.hover.radiusPlus">radiusPlus</a> option.</p>
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Animation.IsDirty()) h.Add("animation",Animation.ToJSON());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (RadiusPlus != RadiusPlus_DefaultValue) h.Add("radiusPlus",RadiusPlus);
			if (LineWidthPlus != LineWidthPlus_DefaultValue) h.Add("lineWidthPlus",LineWidthPlus);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			

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
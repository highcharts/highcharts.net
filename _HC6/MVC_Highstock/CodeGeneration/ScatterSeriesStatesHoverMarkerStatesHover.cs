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
	public partial class ScatterSeriesStatesHoverMarkerStatesHover  : BaseObject
	{
		public ScatterSeriesStatesHoverMarkerStatesHover()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Enabled = Enabled_DefaultValue = true;
			RadiusPlus = RadiusPlus_DefaultValue = 2;
			LineWidthPlus = LineWidthPlus_DefaultValue = 1;
			FillColor = FillColor_DefaultValue = null;
			LineColor = LineColor_DefaultValue = "null";
			LineWidth = LineWidth_DefaultValue = null;
			Radius = Radius_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Animation when hovering over the marker.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the point marker.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of pixels to increase the radius of the hoveredpoint.
		/// </summary>
		public double? RadiusPlus { get; set; }
		private double? RadiusPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// The additional line width for a hovered point.
		/// </summary>
		public double? LineWidthPlus { get; set; }
		private double? LineWidthPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of the marker in hover state. When `null`, theseries' or point's fillColor for normal state is used.
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the point marker's outline. When `null`, theseries' or point's lineColor for normal state is used.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the point marker's outline. When `null`, theseries' or point's lineWidth for normal state is used.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius of the point marker. In hover state, it defaultsto the normal state's radius + 2 as per the [radiusPlus](#plotOptions.series.marker.states.hover.radiusPlus)option.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
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
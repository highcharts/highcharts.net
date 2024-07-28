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
	public partial class PcSeriesMarkerStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PcSeriesMarkerStatesHover()
		{
		}	
		

		/// <summary>
		/// Animation when hovering over the marker.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Animation when hovering over the marker.
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// Enable or disable the point marker.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// The fill color of the marker in hover state. When`undefined`, the series' or point's fillColor for normalstate is used.
		/// </summary>
		public object FillColor { get; set; }
		 

		/// <summary>
		/// The color of the point marker's outline. When`undefined`, the series' or point's lineColor for normalstate is used.
		/// </summary>
		public string LineColor { get; set; }
		 

		/// <summary>
		/// The width of the point marker's outline. When`undefined`, the series' or point's lineWidth for normalstate is used.
		/// </summary>
		public double? LineWidth { get; set; }
		 

		/// <summary>
		/// The additional line width for a hovered point.
		/// </summary>
		public double? LineWidthPlus { get; set; }
		 

		/// <summary>
		/// The radius of the point marker. In hover state, itdefaults to the normal state's radius + 2 as per the[radiusPlus](#plotOptions.series.marker.states.hover.radiusPlus)option.
		/// </summary>
		public double? Radius { get; set; }
		 

		/// <summary>
		/// The number of pixels to increase the radius of thehovered point.
		/// </summary>
		public double? RadiusPlus { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Animation != null) h.Add("animation",Animation);
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (FillColor != null) h.Add("fillColor",FillColor);
			if (LineColor != null) h.Add("lineColor",LineColor);
			if (LineWidth != null) h.Add("lineWidth",LineWidth);
			if (LineWidthPlus != null) h.Add("lineWidthPlus",LineWidthPlus);
			if (Radius != null) h.Add("radius",Radius);
			if (RadiusPlus != null) h.Add("radiusPlus",RadiusPlus);
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
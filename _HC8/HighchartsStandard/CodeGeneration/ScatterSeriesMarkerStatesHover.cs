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
	public partial class ScatterSeriesMarkerStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ScatterSeriesMarkerStatesHover()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Enabled = Enabled_DefaultValue = new Hashtable();
			FillColor = FillColor_DefaultValue = null;
			LineColor = LineColor_DefaultValue = "";
			LineWidth = LineWidth_DefaultValue = new Hashtable();
			LineWidthPlus = LineWidthPlus_DefaultValue = new Hashtable();
			Radius = Radius_DefaultValue = new Hashtable();
			RadiusPlus = RadiusPlus_DefaultValue = new Hashtable();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Animation when hovering over the marker.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the point marker.
		/// </summary>
		public Hashtable Enabled { get; set; }
		private Hashtable Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of the marker in hover state. When`undefined`, the series' or point's fillColor for normalstate is used.
		/// </summary>
		public Object FillColor { get; set; }
		private Object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the point marker's outline. When`undefined`, the series' or point's lineColor for normalstate is used.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the point marker's outline. When`undefined`, the series' or point's lineWidth for normalstate is used.
		/// </summary>
		public Hashtable LineWidth { get; set; }
		private Hashtable LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The additional line width for a hovered point.
		/// </summary>
		public Hashtable LineWidthPlus { get; set; }
		private Hashtable LineWidthPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius of the point marker. In hover state, itdefaults to the normal state's radius + 2 as per the[radiusPlus](#plotOptions.series.marker.states.hover.radiusPlus)option.
		/// </summary>
		public Hashtable Radius { get; set; }
		private Hashtable Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of pixels to increase the radius of thehovered point.
		/// </summary>
		public Hashtable RadiusPlus { get; set; }
		private Hashtable RadiusPlus_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LineWidthPlus != LineWidthPlus_DefaultValue) h.Add("lineWidthPlus",LineWidthPlus);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (RadiusPlus != RadiusPlus_DefaultValue) h.Add("radiusPlus",RadiusPlus);
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
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
	public partial class LegendNavigation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LegendNavigation()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The color for the active up or down arrow in the legend pagenavigation.
		/// </summary>
		public string ActiveColor { get; set; }
		private string ActiveColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to animate the pages when navigating up or down. A value of`true` applies the default navigation given in the`chart.animation` option. Additional options can be given as anobject containing values for easing and duration.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to animate the pages when navigating up or down. A value of`true` applies the default navigation given in the`chart.animation` option. Additional options can be given as anobject containing values for easing and duration.
		/// </summary>
		public bool? AnimationBool { get; set; }
		private bool? AnimationBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel size of the up and down arrows in the legend pagingnavigation.
		/// </summary>
		public double? ArrowSize { get; set; }
		private double? ArrowSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to enable the legend navigation. In most cases, disablingthe navigation results in an unwanted overflow.See also the[adapt chart to legend](https://github.com/highcharts/adapt-chart-to-legend)plugin for a solution to extend the chart height to make room forthe legend, optionally in exported charts only.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the inactive up or down arrow in the legend pagenavigation. .
		/// </summary>
		public string InactiveColor { get; set; }
		private string InactiveColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Text styles for the legend page navigation.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (ActiveColor != null) h.Add("activeColor",ActiveColor);
			if (Animation != null) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (ArrowSize != null) h.Add("arrowSize",ArrowSize);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (InactiveColor != null) h.Add("inactiveColor",InactiveColor);
			if (Style != null) h.Add("style",Style);
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
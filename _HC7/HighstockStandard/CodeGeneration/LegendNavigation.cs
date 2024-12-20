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
	public partial class LegendNavigation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LegendNavigation()
		{
		}	
		

		/// <summary>
		/// The color for the active up or down arrow in the legend pagenavigation.
		/// </summary>
		public string ActiveColor { get; set; }
		 

		/// <summary>
		/// How to animate the pages when navigating up or down. A value of`true` applies the default navigation given in the`chart.animation` option. Additional options can be given as anobject containing values for easing and duration.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// How to animate the pages when navigating up or down. A value of`true` applies the default navigation given in the`chart.animation` option. Additional options can be given as anobject containing values for easing and duration.
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// The pixel size of the up and down arrows in the legend pagingnavigation.
		/// </summary>
		public double? ArrowSize { get; set; }
		 

		/// <summary>
		/// Whether to enable the legend navigation. In most cases, disablingthe navigation results in an unwanted overflow.See also the[adapt chart to legend](https://github.com/highcharts/adapt-chart-to-legend)plugin for a solution to extend the chart height to make room forthe legend, optionally in exported charts only.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// The color of the inactive up or down arrow in the legend pagenavigation. .
		/// </summary>
		public string InactiveColor { get; set; }
		 

		/// <summary>
		/// Text styles for the legend page navigation.
		/// </summary>
		public Hashtable Style { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ActiveColor != null) h.Add("activeColor",ActiveColor);
			if (Animation != null) h.Add("animation",Animation);
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (ArrowSize != null) h.Add("arrowSize",ArrowSize);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (InactiveColor != null) h.Add("inactiveColor",InactiveColor);
			if (Style != null) h.Add("style",Style);
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
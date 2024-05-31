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
	public partial class PlotOptionsPieStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPieStatesHover()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Animation setting for hovering the graph in line-type series.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Animation setting for hovering the graph in line-type series.
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// How much to brighten the point on interaction. Requires themain color to be defined in hex or rgb(a) format.In styled mode, the hover brightness is by default replacedby a fill-opacity given in the `.highcharts-point-hover`class.
		/// </summary>
		public double? Brightness { get; set; }
		 

		/// <summary>
		/// Enable separate styles for the hovered series to visualizethat the user hovers either the series itself or the legend.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Options for the halo appearing around the hovered point inline-type series as well as outside the hovered slice in piecharts. By default the halo is filled by the current point orseries color with an opacity of 0.25\. The halo can bedisabled by setting the `halo` option to `null`.In styled mode, the halo is styled with the`.highcharts-halo` class, with colors inherited from`.highcharts-color-{n}`.
		/// </summary>
		public PlotOptionsPieStatesHoverHalo Halo { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Animation != null) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (Brightness != null) h.Add("brightness",Brightness);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Halo != null) h.Add("halo",Halo.ToHashtable(highcharts));
			if (CustomFields.Count > 0)
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
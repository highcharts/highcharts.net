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
	public partial class PlotOptionsColumnStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsColumnStatesHover()
		{
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
		/// A specific border color for the hovered point. Defaults toinherit the normal state border color.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// How much to brighten the point on interaction. Requires themain color to be defined in hex or rgb(a) format.In styled mode, the hover brightening is by default replacedwith a fill-opacity set in the `.highcharts-point:hover`rule.
		/// </summary>
		public double? Brightness { get; set; }
		 

		/// <summary>
		/// A specific color for the hovered point.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// Enable separate styles for the hovered series to visualizethat the user hovers either the series itself or the legend.
		/// </summary>
		public bool? Enabled { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Animation != null) h.Add("animation",Animation);
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (Brightness != null) h.Add("brightness",Brightness);
			if (Color != null) h.Add("color",Color);
			if (Enabled != null) h.Add("enabled",Enabled);
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
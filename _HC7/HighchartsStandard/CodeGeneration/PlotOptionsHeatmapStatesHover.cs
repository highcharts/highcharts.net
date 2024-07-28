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
	public partial class PlotOptionsHeatmapStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsHeatmapStatesHover()
		{
		}	
		

		/// <summary>
		/// How much to brighten the point on interaction. Requires themain color to be defined in hex or rgb(a) format.In styled mode, the hover brightening is by default replacedwith a fill-opacity set in the `.highcharts-point:hover`rule.
		/// </summary>
		public double? Brightness { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Brightness != null) h.Add("brightness",Brightness);
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
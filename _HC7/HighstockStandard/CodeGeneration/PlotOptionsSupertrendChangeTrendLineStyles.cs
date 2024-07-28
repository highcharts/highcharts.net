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
	public partial class PlotOptionsSupertrendChangeTrendLineStyles  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSupertrendChangeTrendLineStyles()
		{
		}	
		

		/// <summary>
		/// The dash or dot style of the grid lines. For possiblevalues, see[this demonstration](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/).
		/// </summary>
		public PlotOptionsSupertrendChangeTrendLineStylesDashStyle DashStyle { get; set; }
		 

		/// <summary>
		/// Color of the line.
		/// </summary>
		public string LineColor { get; set; }
		 

		/// <summary>
		/// Pixel width of the line.
		/// </summary>
		public double? LineWidth { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (DashStyle != PlotOptionsSupertrendChangeTrendLineStylesDashStyle.Null) h.Add("dashStyle", highstock.FirstCharacterToLower(DashStyle.ToString()));
			if (LineColor != null) h.Add("lineColor",LineColor);
			if (LineWidth != null) h.Add("lineWidth",LineWidth);
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
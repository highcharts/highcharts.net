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
	public partial class StochasticSeriesSmoothedLineStyles  : BaseObject
	{
		Hashtable h = new Hashtable();

		public StochasticSeriesSmoothedLineStyles()
		{
		}	
		

		/// <summary>
		/// Color of the line. If not set, it's inherited from[plotOptions.stochastic.color](#plotOptions.stochastic.color).
		/// </summary>
		public string LineColor { get; set; }
		 

		/// <summary>
		/// Pixel width of the line.
		/// </summary>
		public double? LineWidth { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
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
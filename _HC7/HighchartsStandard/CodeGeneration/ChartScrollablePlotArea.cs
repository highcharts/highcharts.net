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
	public partial class ChartScrollablePlotArea  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartScrollablePlotArea()
		{
		}	
		

		/// <summary>
		/// The minimum height for the plot area. If it gets smaller than this, the plotarea will become scrollable.
		/// </summary>
		public double? MinHeight { get; set; }
		 

		/// <summary>
		/// The minimum width for the plot area. If it gets smaller than this, the plotarea will become scrollable.
		/// </summary>
		public double? MinWidth { get; set; }
		 

		/// <summary>
		/// The opacity of mask applied on one of the sides of the plotarea.
		/// </summary>
		public double? Opacity { get; set; }
		 

		/// <summary>
		/// The initial scrolling position of the scrollable plot area. Ranges from 0 to1, where 0 aligns the plot area to the left and 1 aligns it to the right.Typically we would use 1 if the chart has right aligned Y axes.
		/// </summary>
		public double? ScrollPositionX { get; set; }
		 

		/// <summary>
		/// The initial scrolling position of the scrollable plot area. Ranges from 0 to1, where 0 aligns the plot area to the top and 1 aligns it to the bottom.
		/// </summary>
		public double? ScrollPositionY { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (MinHeight != null) h.Add("minHeight",MinHeight);
			if (MinWidth != null) h.Add("minWidth",MinWidth);
			if (Opacity != null) h.Add("opacity",Opacity);
			if (ScrollPositionX != null) h.Add("scrollPositionX",ScrollPositionX);
			if (ScrollPositionY != null) h.Add("scrollPositionY",ScrollPositionY);
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
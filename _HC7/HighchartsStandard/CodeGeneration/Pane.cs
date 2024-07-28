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
	public partial class Pane  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Pane()
		{
		}	
		

		/// <summary>
		/// An array of background items for the pane.
		/// </summary>
		public List<PaneBackground> Background { get; set; }
		 

		/// <summary>
		/// The center of a polar chart or angular gauge, given as an arrayof [x, y] positions. Positions can be given as integers thattransform to pixels, or as percentages of the plot area size.
		/// </summary>
		public string[] Center { get; set; }
		 

		/// <summary>
		/// The end angle of the polar X axis or gauge value axis, given indegrees where 0 is north. Defaults to [startAngle](#pane.startAngle)+ 360.
		/// </summary>
		public double? EndAngle { get; set; }
		 

		/// <summary>
		/// The inner size of the pane, either as a number defining pixels, or apercentage defining a percentage of the pane's size.
		/// </summary>
		public string InnerSize { get; set; }
		 

		/// <summary>
		/// The inner size of the pane, either as a number defining pixels, or apercentage defining a percentage of the pane's size.
		/// </summary>
		public double? InnerSizeNumber { get; set; }
		 

		/// <summary>
		/// The size of the pane, either as a number defining pixels, or apercentage defining a percentage of the available plot area (thesmallest of the plot height or plot width).
		/// </summary>
		public string Size { get; set; }
		 

		/// <summary>
		/// The size of the pane, either as a number defining pixels, or apercentage defining a percentage of the available plot area (thesmallest of the plot height or plot width).
		/// </summary>
		public double? SizeNumber { get; set; }
		 

		/// <summary>
		/// The start angle of the polar X axis or gauge axis, given in degreeswhere 0 is north. Defaults to 0.
		/// </summary>
		public double? StartAngle { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Background != null) h.Add("background", HashifyList(highcharts,Background));
			if (Center != null) h.Add("center",Center);
			if (EndAngle != null) h.Add("endAngle",EndAngle);
			if (InnerSize != null) h.Add("innerSize",InnerSize);
			if (InnerSizeNumber != null) h.Add("innerSize",InnerSizeNumber);
			if (Size != null) h.Add("size",Size);
			if (SizeNumber != null) h.Add("size",SizeNumber);
			if (StartAngle != null) h.Add("startAngle",StartAngle);
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
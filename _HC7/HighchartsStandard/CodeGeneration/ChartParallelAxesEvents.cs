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
	public partial class ChartParallelAxesEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartParallelAxesEvents()
		{
		}	
		

		/// <summary>
		/// An event fired after the breaks have rendered.
		/// </summary>
		public string AfterBreaks { get; set; }
		 

		/// <summary>
		/// As opposed to the `setExtremes` event, this event fires after thefinal min and max values are computed and corrected for `minRange`.Fires when the minimum and maximum is set for the axis, either bycalling the `.setExtremes()` method or by selecting an area in thechart. One parameter, `event`, is passed to the function, containingcommon event information.The new user set minimum and maximum values can be found by`event.min` and `event.max`. These reflect the axis minimum andmaximum in axis values. The actual data extremes are found in`event.dataMin` and `event.dataMax`.
		/// </summary>
		public string AfterSetExtremes { get; set; }
		 

		/// <summary>
		/// An event fired when a break from this axis occurs on a point.
		/// </summary>
		public string PointBreak { get; set; }
		 

		/// <summary>
		/// An event fired when a point is outside a break after zoom.
		/// </summary>
		public string PointBreakOut { get; set; }
		 

		/// <summary>
		/// An event fired when a point falls inside a break from this axis.
		/// </summary>
		public string PointInBreak { get; set; }
		 

		/// <summary>
		/// Fires when the minimum and maximum is set for the axis, either bycalling the `.setExtremes()` method or by selecting an area in thechart. One parameter, `event`, is passed to the function,containing common event information.The new user set minimum and maximum values can be found by`event.min` and `event.max`. These reflect the axis minimum andmaximum in data values. When an axis is zoomed all the way out fromthe "Reset zoom" button, `event.min` and `event.max` are null, andthe new extremes are set based on `this.dataMin` and `this.dataMax`.
		/// </summary>
		public string SetExtremes { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (AfterBreaks != null) { h.Add("afterBreaks",AfterBreaks); highcharts.AddFunction("afterBreaks", AfterBreaks); }  
			if (AfterSetExtremes != null) { h.Add("afterSetExtremes",AfterSetExtremes); highcharts.AddFunction("afterSetExtremes", AfterSetExtremes); }  
			if (PointBreak != null) { h.Add("pointBreak",PointBreak); highcharts.AddFunction("pointBreak", PointBreak); }  
			if (PointBreakOut != null) { h.Add("pointBreakOut",PointBreakOut); highcharts.AddFunction("pointBreakOut", PointBreakOut); }  
			if (PointInBreak != null) { h.Add("pointInBreak",PointInBreak); highcharts.AddFunction("pointInBreak", PointInBreak); }  
			if (SetExtremes != null) { h.Add("setExtremes",SetExtremes); highcharts.AddFunction("setExtremes", SetExtremes); }  
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
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
	public partial class ZAxisEvents  : BaseObject
	{
		public ZAxisEvents()
		{
			AfterBreaks = AfterBreaks_DefaultValue = "";
			AfterSetExtremes = AfterSetExtremes_DefaultValue = "";
			PointBreak = PointBreak_DefaultValue = "";
			PointInBreak = PointInBreak_DefaultValue = "";
			SetExtremes = SetExtremes_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// An event fired after the breaks have rendered.
		/// </summary>
		public Highcharts.AxisEventCallbackFunction AfterBreaks { get; set; }
		private Highcharts.AxisEventCallbackFunction AfterBreaks_DefaultValue { get; set; }
		 

		/// <summary>
		/// As opposed to the `setExtremes` event, this event fires after thefinal min and max values are computed and corrected for `minRange`.Fires when the minimum and maximum is set for the axis, either bycalling the `.setExtremes()` method or by selecting an area in thechart. One parameter, `event`, is passed to the function, containingcommon event information.The new user set minimum and maximum values can be found by`event.min` and `event.max`. These reflect the axis minimum andmaximum in axis values. The actual data extremes are found in`event.dataMin` and `event.dataMax`.
		/// </summary>
		public Highcharts.AxisEventCallbackFunction AfterSetExtremes { get; set; }
		private Highcharts.AxisEventCallbackFunction AfterSetExtremes_DefaultValue { get; set; }
		 

		/// <summary>
		/// An event fired when a break from this axis occurs on a point.
		/// </summary>
		public Highcharts.AxisPointBreakEventCallbackFunction PointBreak { get; set; }
		private Highcharts.AxisPointBreakEventCallbackFunction PointBreak_DefaultValue { get; set; }
		 

		/// <summary>
		/// An event fired when a point falls inside a break from this axis.
		/// </summary>
		public Highcharts.AxisPointBreakEventCallbackFunction PointInBreak { get; set; }
		private Highcharts.AxisPointBreakEventCallbackFunction PointInBreak_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the minimum and maximum is set for the axis, either bycalling the `.setExtremes()` method or by selecting an area in thechart. One parameter, `event`, is passed to the function,containing common event information.The new user set minimum and maximum values can be found by`event.min` and `event.max`. These reflect the axis minimum andmaximum in data values. When an axis is zoomed all the way out fromthe "Reset zoom" button, `event.min` and `event.max` are null, andthe new extremes are set based on `this.dataMin` and `this.dataMax`.
		/// </summary>
		public Highcharts.AxisSetExtremesEventCallbackFunction SetExtremes { get; set; }
		private Highcharts.AxisSetExtremesEventCallbackFunction SetExtremes_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AfterBreaks != AfterBreaks_DefaultValue) h.Add("afterBreaks",AfterBreaks);
			if (AfterSetExtremes != AfterSetExtremes_DefaultValue) h.Add("afterSetExtremes",AfterSetExtremes);
			if (PointBreak != PointBreak_DefaultValue) h.Add("pointBreak",PointBreak);
			if (PointInBreak != PointInBreak_DefaultValue) h.Add("pointInBreak",PointInBreak);
			if (SetExtremes != SetExtremes_DefaultValue) h.Add("setExtremes",SetExtremes);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}
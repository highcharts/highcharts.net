using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class ChartParallelAxesEvents  : BaseObject
	{
		public ChartParallelAxesEvents()
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
		public string AfterBreaks { get; set; }
		private string AfterBreaks_DefaultValue { get; set; }
		 

		/// <summary>
		/// As opposed to the `setExtremes` event, this event fires after thefinal min and max values are computed and corrected for `minRange`.Fires when the minimum and maximum is set for the axis, either bycalling the `.setExtremes()` method or by selecting an area in thechart. One parameter, `event`, is passed to the function, containingcommon event information.The new user set minimum and maximum values can be found by `event.min` and `event.max`. These reflect the axis minimum and maximumin axis values. The actual data extremes are found in `event.dataMin`and `event.dataMax`.
		/// </summary>
		public string AfterSetExtremes { get; set; }
		private string AfterSetExtremes_DefaultValue { get; set; }
		 

		/// <summary>
		/// An event fired when a break from this axis occurs on a point.
		/// </summary>
		public string PointBreak { get; set; }
		private string PointBreak_DefaultValue { get; set; }
		 

		/// <summary>
		/// An event fired when a point falls inside a break from this axis.
		/// </summary>
		public string PointInBreak { get; set; }
		private string PointInBreak_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the minimum and maximum is set for the axis, either bycalling the `.setExtremes()` method or by selecting an area in thechart. One parameter, `event`, is passed to the function,containing common event information.The new user set minimum and maximum values can be found by `event.min` and `event.max`. These reflect the axis minimum and maximumin data values. When an axis is zoomed all the way out from the "Reset zoom" button, `event.min` and `event.max` are null, andthe new extremes are set based on `this.dataMin` and `this.dataMax`.
		/// </summary>
		public string SetExtremes { get; set; }
		private string SetExtremes_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AfterBreaks != AfterBreaks_DefaultValue) { h.Add("afterBreaks",AfterBreaks); Highcharts.AddFunction("ChartParallelAxesEventsAfterBreaks.afterBreaks", AfterBreaks); }  
			if (AfterSetExtremes != AfterSetExtremes_DefaultValue) { h.Add("afterSetExtremes",AfterSetExtremes); Highcharts.AddFunction("ChartParallelAxesEventsAfterSetExtremes.afterSetExtremes", AfterSetExtremes); }  
			if (PointBreak != PointBreak_DefaultValue) { h.Add("pointBreak",PointBreak); Highcharts.AddFunction("ChartParallelAxesEventsPointBreak.pointBreak", PointBreak); }  
			if (PointInBreak != PointInBreak_DefaultValue) { h.Add("pointInBreak",PointInBreak); Highcharts.AddFunction("ChartParallelAxesEventsPointInBreak.pointInBreak", PointInBreak); }  
			if (SetExtremes != SetExtremes_DefaultValue) { h.Add("setExtremes",SetExtremes); Highcharts.AddFunction("ChartParallelAxesEventsSetExtremes.setExtremes", SetExtremes); }  
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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
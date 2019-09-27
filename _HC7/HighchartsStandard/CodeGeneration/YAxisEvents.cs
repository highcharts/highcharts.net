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
	public partial class YAxisEvents  : BaseObject
	{
		public YAxisEvents()
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
		/// As opposed to the `setExtremes` event, this event fires after thefinal min and max values are computed and corrected for `minRange`.Fires when the minimum and maximum is set for the axis, either bycalling the `.setExtremes()` method or by selecting an area in thechart. One parameter, `event`, is passed to the function, containingcommon event information.The new user set minimum and maximum values can be found by`event.min` and `event.max`. These reflect the axis minimum andmaximum in axis values. The actual data extremes are found in`event.dataMin` and `event.dataMax`.
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
		/// Fires when the minimum and maximum is set for the axis, either bycalling the `.setExtremes()` method or by selecting an area in thechart. One parameter, `event`, is passed to the function,containing common event information.The new user set minimum and maximum values can be found by`event.min` and `event.max`. These reflect the axis minimum andmaximum in data values. When an axis is zoomed all the way out fromthe "Reset zoom" button, `event.min` and `event.max` are null, andthe new extremes are set based on `this.dataMin` and `this.dataMax`.
		/// </summary>
		public string SetExtremes { get; set; }
		private string SetExtremes_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AfterBreaks != AfterBreaks_DefaultValue) { h.Add("afterBreaks",AfterBreaks); Highcharts.AddFunction("8534eccd-8a8e-42c2-9e12-70aeb89ac1b5.afterBreaks", AfterBreaks); }  
			if (AfterSetExtremes != AfterSetExtremes_DefaultValue) { h.Add("afterSetExtremes",AfterSetExtremes); Highcharts.AddFunction("f8786fc9-afa1-4992-9dcb-1dc5009a0303.afterSetExtremes", AfterSetExtremes); }  
			if (PointBreak != PointBreak_DefaultValue) { h.Add("pointBreak",PointBreak); Highcharts.AddFunction("b7790ba4-4f8b-4407-adf3-66cf7409ebcb.pointBreak", PointBreak); }  
			if (PointInBreak != PointInBreak_DefaultValue) { h.Add("pointInBreak",PointInBreak); Highcharts.AddFunction("094e697f-56ee-466d-b0bb-12c8959fdb3e.pointInBreak", PointInBreak); }  
			if (SetExtremes != SetExtremes_DefaultValue) { h.Add("setExtremes",SetExtremes); Highcharts.AddFunction("88a4327d-f1eb-43c6-a5f9-d360ea388597.setExtremes", SetExtremes); }  
			

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
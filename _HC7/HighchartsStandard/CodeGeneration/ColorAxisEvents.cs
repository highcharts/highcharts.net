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
	public partial class ColorAxisEvents  : BaseObject
	{
		public ColorAxisEvents()
		{
			AfterBreaks = AfterBreaks_DefaultValue = "";
			AfterSetExtremes = AfterSetExtremes_DefaultValue = "";
			LegendItemClick = LegendItemClick_DefaultValue = "";
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
		/// Fires when the legend item belonging to the colorAxis is clicked.One parameter, `event`, is passed to the function.
		/// </summary>
		public string LegendItemClick { get; set; }
		private string LegendItemClick_DefaultValue { get; set; }
		 

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

			if (AfterBreaks != AfterBreaks_DefaultValue) { h.Add("afterBreaks",AfterBreaks); Highcharts.AddFunction("1759acfb-e772-4fbc-9689-b893b27abf76.afterBreaks", AfterBreaks); }  
			if (AfterSetExtremes != AfterSetExtremes_DefaultValue) { h.Add("afterSetExtremes",AfterSetExtremes); Highcharts.AddFunction("938a399b-952c-41ca-a221-025e311b6b4d.afterSetExtremes", AfterSetExtremes); }  
			if (LegendItemClick != LegendItemClick_DefaultValue) { h.Add("legendItemClick",LegendItemClick); Highcharts.AddFunction("6263e5a8-df83-40e6-bdd9-823852aa0064.legendItemClick", LegendItemClick); }  
			if (PointBreak != PointBreak_DefaultValue) { h.Add("pointBreak",PointBreak); Highcharts.AddFunction("176aabc8-b6d2-44cb-bf40-830f9de98d35.pointBreak", PointBreak); }  
			if (PointInBreak != PointInBreak_DefaultValue) { h.Add("pointInBreak",PointInBreak); Highcharts.AddFunction("7b3419f9-7b96-4fc0-aa09-d31b52a965f9.pointInBreak", PointInBreak); }  
			if (SetExtremes != SetExtremes_DefaultValue) { h.Add("setExtremes",SetExtremes); Highcharts.AddFunction("2e8638e7-0f30-4d12-8873-ed8bdea036be.setExtremes", SetExtremes); }  
			

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
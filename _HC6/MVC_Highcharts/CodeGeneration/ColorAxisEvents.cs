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
	public partial class ColorAxisEvents  : BaseObject
	{
		public ColorAxisEvents()
		{
			AfterBreaks = AfterBreaks_DefaultValue = "";
			AfterSetExtremes = AfterSetExtremes_DefaultValue = "";
			PointBreak = PointBreak_DefaultValue = "";
			PointInBreak = PointInBreak_DefaultValue = "";
			SetExtremes = SetExtremes_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// <p>An event fired after the breaks have rendered.</p>
		/// </summary>
		public string AfterBreaks { get; set; }
		private string AfterBreaks_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>As opposed to the <code>setExtremes</code> event, this event fires after thefinal min and max values are computed and corrected for <code>minRange</code>.</p><p>Fires when the minimum and maximum is set for the axis, either bycalling the <code>.setExtremes()</code> method or by selecting an area in thechart. One parameter, <code>event</code>, is passed to the function, containing common event information.</p><p>The new user set minimum and maximum values can be found by <code>event.min</code> and <code>event.max</code>. These reflect the axis minimum and maximumin axis values. The actual data extremes are found in <code>event.dataMin</code>and <code>event.dataMax</code>.</p>
		/// </summary>
		public string AfterSetExtremes { get; set; }
		private string AfterSetExtremes_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An event fired when a break from this axis occurs on a point.</p>
		/// </summary>
		public string PointBreak { get; set; }
		private string PointBreak_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An event fired when a point falls inside a break from this axis.</p>
		/// </summary>
		public string PointInBreak { get; set; }
		private string PointInBreak_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the minimum and maximum is set for the axis, either bycalling the <code>.setExtremes()</code> method or by selecting an area in thechart. One parameter, <code>event</code>, is passed to the function, containing common event information.</p><p>The new user set minimum and maximum values can be found by <code>event.min</code> and <code>event.max</code>. These reflect the axis minimum and maximumin data values. When an axis is zoomed all the way out from the &quot;Resetzoom&quot; button, <code>event.min</code> and <code>event.max</code> are null, and the new extremesare set based on <code>this.dataMin</code> and <code>this.dataMax</code>.</p>
		/// </summary>
		public string SetExtremes { get; set; }
		private string SetExtremes_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AfterBreaks != AfterBreaks_DefaultValue) { h.Add("afterBreaks",AfterBreaks); Highcharts.AddFunction("ColorAxisEventsAfterBreaks.afterBreaks", AfterBreaks); }  
			if (AfterSetExtremes != AfterSetExtremes_DefaultValue) { h.Add("afterSetExtremes",AfterSetExtremes); Highcharts.AddFunction("ColorAxisEventsAfterSetExtremes.afterSetExtremes", AfterSetExtremes); }  
			if (PointBreak != PointBreak_DefaultValue) { h.Add("pointBreak",PointBreak); Highcharts.AddFunction("ColorAxisEventsPointBreak.pointBreak", PointBreak); }  
			if (PointInBreak != PointInBreak_DefaultValue) { h.Add("pointInBreak",PointInBreak); Highcharts.AddFunction("ColorAxisEventsPointInBreak.pointInBreak", PointInBreak); }  
			if (SetExtremes != SetExtremes_DefaultValue) { h.Add("setExtremes",SetExtremes); Highcharts.AddFunction("ColorAxisEventsSetExtremes.setExtremes", SetExtremes); }  
			

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
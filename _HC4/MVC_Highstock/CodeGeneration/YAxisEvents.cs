using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class YAxisEvents  : BaseObject
	{
		public YAxisEvents()
		{
			AfterSetExtremes = AfterSetExtremes_DefaultValue = "";
			SetExtremes = SetExtremes_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// As opposed to the <code>setExtremes</code> event, this event fires after the final min and max values are computed and corrected for <code>minRange</code>.
		/// </summary>
		public string AfterSetExtremes { get; set; }
		private string AfterSetExtremes_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the minimum and maximum is set for the axis, either by calling the <code>.setExtremes()</code> method or by selecting an area in the chart. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.</p><p>The new user set minimum and maximum values can be found by <code>event.min</code> and <code>event.max</code>. When an axis is zoomed all the way out from the "Reset zoom" button, <code>event.min</code> and <code>event.max</code> are null, and the new extremes are set based on <code>this.dataMin</code> and <code>this.dataMax</code>.</p>
		/// </summary>
		public string SetExtremes { get; set; }
		private string SetExtremes_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AfterSetExtremes != AfterSetExtremes_DefaultValue) { h.Add("afterSetExtremes",AfterSetExtremes); Highstock.AddFunction("YAxisEventsAfterSetExtremes.afterSetExtremes", AfterSetExtremes); }  
			if (SetExtremes != SetExtremes_DefaultValue) { h.Add("setExtremes",SetExtremes); Highstock.AddFunction("YAxisEventsSetExtremes.setExtremes", SetExtremes); }  
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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
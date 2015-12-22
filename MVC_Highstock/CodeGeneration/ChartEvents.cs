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
	public partial class ChartEvents  : BaseObject
	{
		public ChartEvents()
		{
			AddSeries = AddSeries_DefaultValue = "";
			AfterPrint = AfterPrint_DefaultValue = "";
			BeforePrint = BeforePrint_DefaultValue = "";
			Click = Click_DefaultValue = "";
			Load = Load_DefaultValue = "";
			Redraw = Redraw_DefaultValue = "";
			Selection = Selection_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Fires when a series is added to the chart after load time, using the <code>addSeries</code> method. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. Through <code>event.options</code> you can access the series options that was passed to the <code>addSeries</code>  method. Returning false prevents the series from being added.
		/// </summary>
		public string AddSeries { get; set; }
		private string AddSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires after a chart is printed through the context menu item or the <code>Chart.print</code> method. Requires the exporting module.
		/// </summary>
		public string AfterPrint { get; set; }
		private string AfterPrint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires before a chart is printed through the context menu item or the <code>Chart.print</code> method. Requires the exporting module.
		/// </summary>
		public string BeforePrint { get; set; }
		private string BeforePrint_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when clicking on the plot background. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.</p> <p>Information on the clicked spot can be found through <code>event.xAxis</code> and  <code>event.yAxis</code>, which are arrays containing the axes of each dimension and each axis' value at the clicked spot. The primary axes are <code>event.xAxis[0]</code> and <code>event.yAxis[0]</code>. Remember the unit of a datetime axis is milliseconds since 1970-01-01 00:00:00.</p><pre>click: function(e) {console.log(Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', e.xAxis[0].value), e.yAxis[0].value)}</pre>
		/// </summary>
		public string Click { get; set; }
		private string Click_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the chart is finished loading. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.</p><p>From version 2.0.4, there is also a second parameter to <code>Highcharts.Chart</code> where a callback function can be passed to be executed on chart.load.</p>
		/// </summary>
		public string Load { get; set; }
		private string Load_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the chart is redrawn, either after a call to chart.redraw() or after an axis, series or point is modified with the <code>redraw</code> option set to true. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
		/// </summary>
		public string Redraw { get; set; }
		private string Redraw_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when an area of the chart has been selected. Selection is enabled by setting the chart's zoomType. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. The default action for the  selection event is to zoom the  chart to the selected area. It can be prevented by calling  <code>event.preventDefault()</code>.</p> <p>Information on the selected area can be found through <code>event.xAxis</code> and  <code>event.yAxis</code>, which are arrays containing the axes of each dimension and each axis' min and max values. The primary axes are <code>event.xAxis[0]</code> and <code>event.yAxis[0]</code>. Remember the unit of a datetime axis is milliseconds since 1970-01-01 00:00:00.</p> <pre>selection: function(event) {// log the min and max of the primary, datetime x-axisconsole.log(Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', event.xAxis[0].min),Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', event.xAxis[0].max));// log the min and max of the y axisconsole.log(event.yAxis[0].min, event.yAxis[0].max);}</pre>
		/// </summary>
		public string Selection { get; set; }
		private string Selection_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AddSeries != AddSeries_DefaultValue) { h.Add("addSeries",AddSeries); Highstock.AddFunction("ChartEventsAddSeries.addSeries", AddSeries); }  
			if (AfterPrint != AfterPrint_DefaultValue) { h.Add("afterPrint",AfterPrint); Highstock.AddFunction("ChartEventsAfterPrint.afterPrint", AfterPrint); }  
			if (BeforePrint != BeforePrint_DefaultValue) { h.Add("beforePrint",BeforePrint); Highstock.AddFunction("ChartEventsBeforePrint.beforePrint", BeforePrint); }  
			if (Click != Click_DefaultValue) { h.Add("click",Click); Highstock.AddFunction("ChartEventsClick.click", Click); }  
			if (Load != Load_DefaultValue) { h.Add("load",Load); Highstock.AddFunction("ChartEventsLoad.load", Load); }  
			if (Redraw != Redraw_DefaultValue) { h.Add("redraw",Redraw); Highstock.AddFunction("ChartEventsRedraw.redraw", Redraw); }  
			if (Selection != Selection_DefaultValue) { h.Add("selection",Selection); Highstock.AddFunction("ChartEventsSelection.selection", Selection); }  
			

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
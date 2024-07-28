using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class ChartEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartEvents()
		{
		}	
		

		/// <summary>
		/// Fires when a series is added to the chart after load time, using the`addSeries` method. One parameter, `event`, is passed to thefunction, containing common event information. Through`event.options` you can access the series options that were passed tothe `addSeries` method. Returning false prevents the series frombeing added.
		/// </summary>
		public string AddSeries { get; set; }
		 

		/// <summary>
		/// Fires after a chart is printed through the context menu item or the`Chart.print` method.
		/// </summary>
		public string AfterPrint { get; set; }
		 

		/// <summary>
		/// Fires before a chart is printed through the context menu item orthe `Chart.print` method.
		/// </summary>
		public string BeforePrint { get; set; }
		 

		/// <summary>
		/// Fires when clicking on the plot background. One parameter, `event`,is passed to the function, containing common event information.Information on the clicked spot can be found through `event.xAxis`and `event.yAxis`, which are arrays containing the axes of eachdimension and each axis' value at the clicked spot. The primary axesare `event.xAxis[0]` and `event.yAxis[0]`. Remember the unit of adatetime axis is milliseconds since 1970-01-01 00:00:00.```jsclick: function(e) {    console.log(        Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', e.xAxis[0].value),        e.yAxis[0].value    )}```
		/// </summary>
		public string Click { get; set; }
		 

		/// <summary>
		/// Callback that fires while exporting data. This allows the modification ofdata rows before processed into the final format.
		/// </summary>
		public string ExportData { get; set; }
		 

		/// <summary>
		/// Fires when a fullscreen is closed through the context menu item,or a fullscreen is closed on the `Escape` button click,or the `Chart.fullscreen.close` method.
		/// </summary>
		public string FullscreenClose { get; set; }
		 

		/// <summary>
		/// Fires when a fullscreen is opened through the context menu item,or the `Chart.fullscreen.open` method.
		/// </summary>
		public string FullscreenOpen { get; set; }
		 

		/// <summary>
		/// Fires when the chart is finished loading. Since v4.2.2, it also waitsfor images to be loaded, for example from point markers. Oneparameter, `event`, is passed to the function, containing commonevent information.There is also a second parameter to the chart constructor where acallback function can be passed to be executed on chart.load.
		/// </summary>
		public string Load { get; set; }
		 

		/// <summary>
		/// Fires when the chart is redrawn, either after a call to`chart.redraw()` or after an axis, series or point is modified withthe `redraw` option set to `true`. One parameter, `event`, is passedto the function, containing common event information.
		/// </summary>
		public string Redraw { get; set; }
		 

		/// <summary>
		/// Fires after initial load of the chart (directly after the `load`event), and after each redraw (directly after the `redraw` event).
		/// </summary>
		public string Render { get; set; }
		 

		/// <summary>
		/// Fires when an area of the chart has been selected. Selection isenabled by setting the chart's zoomType. One parameter, `event`, ispassed to the function, containing common event information. Thedefault action for the selection event is to zoom the chart to theselected area. It can be prevented by calling`event.preventDefault()` or return false.Information on the selected area can be found through `event.xAxis`and `event.yAxis`, which are arrays containing the axes of eachdimension and each axis' min and max values. The primary axes are`event.xAxis[0]` and `event.yAxis[0]`. Remember the unit of adatetime axis is milliseconds since 1970-01-01 00:00:00.```jsselection: function(event) {    // log the min and max of the primary, datetime x-axis    console.log(        Highcharts.dateFormat(            '%Y-%m-%d %H:%M:%S',            event.xAxis[0].min        ),        Highcharts.dateFormat(            '%Y-%m-%d %H:%M:%S',            event.xAxis[0].max        )    );    // log the min and max of the y axis    console.log(event.yAxis[0].min, event.yAxis[0].max);}```
		/// </summary>
		public string Selection { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (AddSeries != null) { h.Add("addSeries",AddSeries); highstock.AddFunction("addSeries", AddSeries); }  
			if (AfterPrint != null) { h.Add("afterPrint",AfterPrint); highstock.AddFunction("afterPrint", AfterPrint); }  
			if (BeforePrint != null) { h.Add("beforePrint",BeforePrint); highstock.AddFunction("beforePrint", BeforePrint); }  
			if (Click != null) { h.Add("click",Click); highstock.AddFunction("click", Click); }  
			if (ExportData != null) { h.Add("exportData",ExportData); highstock.AddFunction("exportData", ExportData); }  
			if (FullscreenClose != null) { h.Add("fullscreenClose",FullscreenClose); highstock.AddFunction("fullscreenClose", FullscreenClose); }  
			if (FullscreenOpen != null) { h.Add("fullscreenOpen",FullscreenOpen); highstock.AddFunction("fullscreenOpen", FullscreenOpen); }  
			if (Load != null) { h.Add("load",Load); highstock.AddFunction("load", Load); }  
			if (Redraw != null) { h.Add("redraw",Redraw); highstock.AddFunction("redraw", Redraw); }  
			if (Render != null) { h.Add("render",Render); highstock.AddFunction("render", Render); }  
			if (Selection != null) { h.Add("selection",Selection); highstock.AddFunction("selection", Selection); }  
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
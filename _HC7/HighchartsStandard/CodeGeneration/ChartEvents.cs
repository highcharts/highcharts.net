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
	public partial class ChartEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartEvents()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Fires when a series is added to the chart after load time, using the`addSeries` method. One parameter, `event`, is passed to thefunction, containing common event information. Through`event.options` you can access the series options that were passed tothe `addSeries` method. Returning false prevents the series frombeing added.
		/// </summary>
		public string AddSeries { get; set; }
		private string AddSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires after a chart is printed through the context menu item or the`Chart.print` method.
		/// </summary>
		public string AfterPrint { get; set; }
		private string AfterPrint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires before a chart is printed through the context menu item orthe `Chart.print` method.
		/// </summary>
		public string BeforePrint { get; set; }
		private string BeforePrint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when clicking on the plot background. One parameter, `event`,is passed to the function, containing common event information.Information on the clicked spot can be found through `event.xAxis`and `event.yAxis`, which are arrays containing the axes of eachdimension and each axis' value at the clicked spot. The primary axesare `event.xAxis[0]` and `event.yAxis[0]`. Remember the unit of adatetime axis is milliseconds since 1970-01-01 00:00:00.```jsclick: function(e) {    console.log(        Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', e.xAxis[0].value),        e.yAxis[0].value    )}```
		/// </summary>
		public string Click { get; set; }
		private string Click_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when a drilldown point is clicked, before the new series is added. Thisevent is also utilized for async drilldown, where the seriesOptions are notadded by option, but rather loaded async. Note that when clicking a categorylabel to trigger multiple series drilldown, one `drilldown` event istriggered per point in the category.Event arguments:- `category`: If a category label was clicked, which index.- `originalEvent`: The original browser event (usually click) that triggered  the drilldown.- `point`: The originating point.- `points`: If a category label was clicked, this array holds all points  corresponding to the category.- `seriesOptions`: Options for the new series.
		/// </summary>
		public string Drilldown { get; set; }
		private string Drilldown_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when drilling up from a drilldown series.
		/// </summary>
		public string Drillup { get; set; }
		private string Drillup_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a chart with multiple drilldown series, this event fires after all theseries have been drilled up.
		/// </summary>
		public string Drillupall { get; set; }
		private string Drillupall_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback that fires while exporting data. This allows the modification ofdata rows before processed into the final format.
		/// </summary>
		public string ExportData { get; set; }
		private string ExportData_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when a fullscreen is closed through the context menu item,or a fullscreen is closed on the `Escape` button click,or the `Chart.fullscreen.close` method.
		/// </summary>
		public string FullscreenClose { get; set; }
		private string FullscreenClose_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when a fullscreen is opened through the context menu item,or the `Chart.fullscreen.open` method.
		/// </summary>
		public string FullscreenOpen { get; set; }
		private string FullscreenOpen_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the chart is finished loading. Since v4.2.2, it also waitsfor images to be loaded, for example from point markers. Oneparameter, `event`, is passed to the function, containing commonevent information.There is also a second parameter to the chart constructor where acallback function can be passed to be executed on chart.load.
		/// </summary>
		public string Load { get; set; }
		private string Load_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the chart is redrawn, either after a call to`chart.redraw()` or after an axis, series or point is modified withthe `redraw` option set to `true`. One parameter, `event`, is passedto the function, containing common event information.
		/// </summary>
		public string Redraw { get; set; }
		private string Redraw_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires after initial load of the chart (directly after the `load`event), and after each redraw (directly after the `redraw` event).
		/// </summary>
		public string Render { get; set; }
		private string Render_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when an area of the chart has been selected. Selection isenabled by setting the chart's zoomType. One parameter, `event`, ispassed to the function, containing common event information. Thedefault action for the selection event is to zoom the chart to theselected area. It can be prevented by calling`event.preventDefault()` or return false.Information on the selected area can be found through `event.xAxis`and `event.yAxis`, which are arrays containing the axes of eachdimension and each axis' min and max values. The primary axes are`event.xAxis[0]` and `event.yAxis[0]`. Remember the unit of adatetime axis is milliseconds since 1970-01-01 00:00:00.```jsselection: function(event) {    // log the min and max of the primary, datetime x-axis    console.log(        Highcharts.dateFormat(            '%Y-%m-%d %H:%M:%S',            event.xAxis[0].min        ),        Highcharts.dateFormat(            '%Y-%m-%d %H:%M:%S',            event.xAxis[0].max        )    );    // log the min and max of the y axis    console.log(event.yAxis[0].min, event.yAxis[0].max);}```
		/// </summary>
		public string Selection { get; set; }
		private string Selection_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (AddSeries != null) { h.Add("addSeries",AddSeries); highcharts.AddFunction("addSeries", AddSeries); }  
			if (AfterPrint != null) { h.Add("afterPrint",AfterPrint); highcharts.AddFunction("afterPrint", AfterPrint); }  
			if (BeforePrint != null) { h.Add("beforePrint",BeforePrint); highcharts.AddFunction("beforePrint", BeforePrint); }  
			if (Click != null) { h.Add("click",Click); highcharts.AddFunction("click", Click); }  
			if (Drilldown != null) { h.Add("drilldown",Drilldown); highcharts.AddFunction("drilldown", Drilldown); }  
			if (Drillup != null) { h.Add("drillup",Drillup); highcharts.AddFunction("drillup", Drillup); }  
			if (Drillupall != null) { h.Add("drillupall",Drillupall); highcharts.AddFunction("drillupall", Drillupall); }  
			if (ExportData != null) { h.Add("exportData",ExportData); highcharts.AddFunction("exportData", ExportData); }  
			if (FullscreenClose != null) { h.Add("fullscreenClose",FullscreenClose); highcharts.AddFunction("fullscreenClose", FullscreenClose); }  
			if (FullscreenOpen != null) { h.Add("fullscreenOpen",FullscreenOpen); highcharts.AddFunction("fullscreenOpen", FullscreenOpen); }  
			if (Load != null) { h.Add("load",Load); highcharts.AddFunction("load", Load); }  
			if (Redraw != null) { h.Add("redraw",Redraw); highcharts.AddFunction("redraw", Redraw); }  
			if (Render != null) { h.Add("render",Render); highcharts.AddFunction("render", Render); }  
			if (Selection != null) { h.Add("selection",Selection); highcharts.AddFunction("selection", Selection); }  
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}
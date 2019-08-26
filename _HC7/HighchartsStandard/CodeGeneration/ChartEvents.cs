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
		public ChartEvents()
		{
			AddSeries = AddSeries_DefaultValue = "";
			AfterPrint = AfterPrint_DefaultValue = "";
			BeforePrint = BeforePrint_DefaultValue = "";
			Click = Click_DefaultValue = "";
			Drilldown = Drilldown_DefaultValue = "";
			Drillup = Drillup_DefaultValue = "";
			Drillupall = Drillupall_DefaultValue = "";
			Load = Load_DefaultValue = "";
			Redraw = Redraw_DefaultValue = "";
			Render = Render_DefaultValue = "";
			Selection = Selection_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Fires when a series is added to the chart after load time, using the`addSeries` method. One parameter, `event`, is passed to thefunction, containing common event information. Through`event.options` you can access the series options that were passed tothe `addSeries` method. Returning false prevents the series frombeing added.
		/// </summary>
		public string AddSeries { get; set; }
		private string AddSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires after a chart is printed through the context menu item or the`Chart.print` method. Requires the exporting module.
		/// </summary>
		public string AfterPrint { get; set; }
		private string AfterPrint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires before a chart is printed through the context menu item orthe `Chart.print` method. Requires the exporting module.
		/// </summary>
		public string BeforePrint { get; set; }
		private string BeforePrint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when clicking on the plot background. One parameter, `event`,is passed to the function, containing common event information.Information on the clicked spot can be found through `event.xAxis`and `event.yAxis`, which are arrays containing the axes of eachdimension and each axis' value at the clicked spot. The primary axesare `event.xAxis[0]` and `event.yAxis[0]`. Remember the unit of adatetime axis is milliseconds since 1970-01-01 00:00:00.<pre>click: function(e) {    console.log(        Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', e.xAxis[0].value),        e.yAxis[0].value    )}</pre>
		/// </summary>
		public string Click { get; set; }
		private string Click_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when a drilldown point is clicked, before the new series is added. Thisevent is also utilized for async drilldown, where the seriesOptions are notadded by option, but rather loaded async. Note that when clicking a categorylabel to trigger multiple series drilldown, one `drilldown` event istriggered per point in the category.Event arguments:- `category`: If a category label was clicked, which index.</dd>- `originalEvent`: The original browser event (usually click) that triggered  the drilldown.- `point`: The originating point.- `points`: If a category label was clicked, this array holds all points  corresponing to the category.</dd>- `seriesOptions`: Options for the new series.
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
		/// Fires when an area of the chart has been selected. Selection isenabled by setting the chart's zoomType. One parameter, `event`, ispassed to the function, containing common event information. Thedefault action for the selection event is to zoom the chart to theselected area. It can be prevented by calling`event.preventDefault()` or return false.Information on the selected area can be found through `event.xAxis`and `event.yAxis`, which are arrays containing the axes of eachdimension and each axis' min and max values. The primary axes are`event.xAxis[0]` and `event.yAxis[0]`. Remember the unit of adatetime axis is milliseconds since 1970-01-01 00:00:00.<pre>selection: function(event) {    // log the min and max of the primary, datetime x-axis    console.log(        Highcharts.dateFormat(            '%Y-%m-%d %H:%M:%S',            event.xAxis[0].min        ),        Highcharts.dateFormat(            '%Y-%m-%d %H:%M:%S',            event.xAxis[0].max        )    );    // log the min and max of the y axis    console.log(event.yAxis[0].min, event.yAxis[0].max);}</pre>
		/// </summary>
		public string Selection { get; set; }
		private string Selection_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AddSeries != AddSeries_DefaultValue) { h.Add("addSeries",AddSeries); Highcharts.AddFunction("6a1164c7-3a12-41c5-add9-437a1f067c19.addSeries", AddSeries); }  
			if (AfterPrint != AfterPrint_DefaultValue) { h.Add("afterPrint",AfterPrint); Highcharts.AddFunction("dd123e3d-4254-4177-b7d1-8b762636f67a.afterPrint", AfterPrint); }  
			if (BeforePrint != BeforePrint_DefaultValue) { h.Add("beforePrint",BeforePrint); Highcharts.AddFunction("5c0c047d-5982-4af5-a1ea-1238ef69d0a3.beforePrint", BeforePrint); }  
			if (Click != Click_DefaultValue) { h.Add("click",Click); Highcharts.AddFunction("93b22cee-cf9d-4e24-989a-2ea353aaaef2.click", Click); }  
			if (Drilldown != Drilldown_DefaultValue) { h.Add("drilldown",Drilldown); Highcharts.AddFunction("cc23b8fa-48bb-4830-aecf-3c44e628ad7a.drilldown", Drilldown); }  
			if (Drillup != Drillup_DefaultValue) { h.Add("drillup",Drillup); Highcharts.AddFunction("9ee92f3d-6ed4-4deb-91e2-4c4766d7563a.drillup", Drillup); }  
			if (Drillupall != Drillupall_DefaultValue) { h.Add("drillupall",Drillupall); Highcharts.AddFunction("1b1f465c-4534-4d4b-86cb-35834db77393.drillupall", Drillupall); }  
			if (Load != Load_DefaultValue) { h.Add("load",Load); Highcharts.AddFunction("f342f68c-6fda-4df0-ac9b-1ee6cf0607c3.load", Load); }  
			if (Redraw != Redraw_DefaultValue) { h.Add("redraw",Redraw); Highcharts.AddFunction("d38dfad0-fb63-4a36-b12c-6857f300c030.redraw", Redraw); }  
			if (Render != Render_DefaultValue) { h.Add("render",Render); Highcharts.AddFunction("a9c531b9-f29b-4cc0-9c6a-7d0ab9c814dc.render", Render); }  
			if (Selection != Selection_DefaultValue) { h.Add("selection",Selection); Highcharts.AddFunction("ca066f10-1e07-4dd2-b5d6-c4d457e11b87.selection", Selection); }  
			

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
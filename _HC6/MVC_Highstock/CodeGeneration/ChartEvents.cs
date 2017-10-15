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
			AfterPrint = AfterPrint_DefaultValue = "";
			BeforePrint = BeforePrint_DefaultValue = "";
			AddSeries = AddSeries_DefaultValue = "";
			Click = Click_DefaultValue = "";
			Load = Load_DefaultValue = "";
			Redraw = Redraw_DefaultValue = "";
			Render = Render_DefaultValue = "";
			Selection = Selection_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// <p>Fires after a chart is printed through the context menu item or the<code>Chart.print</code> method. Requires the exporting module.</p>
		/// </summary>
		public string AfterPrint { get; set; }
		private string AfterPrint_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires before a chart is printed through the context menu item orthe <code>Chart.print</code> method. Requires the exporting module.</p>
		/// </summary>
		public string BeforePrint { get; set; }
		private string BeforePrint_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when a series is added to the chart after load time, usingthe <code>addSeries</code> method. One parameter, <code>event</code>, is passed to thefunction, containing common event information.Through <code>event.options</code> you can access the series options that waspassed to the <code>addSeries</code> method. Returning false prevents the seriesfrom being added.</p>
		/// </summary>
		public string AddSeries { get; set; }
		private string AddSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when clicking on the plot background. One parameter, <code>event</code>,is passed to the function, containing common event information.</p><p>Information on the clicked spot can be found through <code>event.xAxis</code>and <code>event.yAxis</code>, which are arrays containing the axes of each dimensionand each axis&#39; value at the clicked spot. The primary axes are <code>event.xAxis[0]</code> and <code>event.yAxis[0]</code>. Remember the unit of a datetime axisis milliseconds since 1970-01-01 00:00:00.</p><pre>click: function(e) {    console.log(        Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', e.xAxis[0].value),        e.yAxis[0].value    )}</pre>
		/// </summary>
		public string Click { get; set; }
		private string Click_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the chart is finished loading. Since v4.2.2, it also waitsfor images to be loaded, for example from point markers. One parameter,<code>event</code>, is passed to the function, containing common event information.</p><p>There is also a second parameter to the chart constructor where acallback function can be passed to be executed on chart.load.</p>
		/// </summary>
		public string Load { get; set; }
		private string Load_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the chart is redrawn, either after a call to chart.redraw()or after an axis, series or point is modified with the <code>redraw</code> optionset to true. One parameter, <code>event</code>, is passed to the function, containing common event information.</p>
		/// </summary>
		public string Redraw { get; set; }
		private string Redraw_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires after initial load of the chart (directly after the <code>load</code>event), and after each redraw (directly after the <code>redraw</code> event).</p>
		/// </summary>
		public string Render { get; set; }
		private string Render_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when an area of the chart has been selected. Selection is enabledby setting the chart&#39;s zoomType. One parameter, <code>event</code>, is passedto the function, containing common event information. The default action for the selection event is tozoom the chart to the selected area. It can be prevented by calling<code>event.preventDefault()</code>.</p><p>Information on the selected area can be found through <code>event.xAxis</code>and <code>event.yAxis</code>, which are arrays containing the axes of each dimensionand each axis&#39; min and max values. The primary axes are <code>event.xAxis[0]</code>and <code>event.yAxis[0]</code>. Remember the unit of a datetime axis is millisecondssince 1970-01-01 00:00:00.</p><pre>selection: function(event) {    // log the min and max of the primary, datetime x-axis    console.log(        Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', event.xAxis[0].min),        Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', event.xAxis[0].max)    );    // log the min and max of the y axis    console.log(event.yAxis[0].min, event.yAxis[0].max);}</pre>
		/// </summary>
		public string Selection { get; set; }
		private string Selection_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AfterPrint != AfterPrint_DefaultValue) { h.Add("afterPrint",AfterPrint); Highstock.AddFunction("ChartEventsAfterPrint.afterPrint", AfterPrint); }  
			if (BeforePrint != BeforePrint_DefaultValue) { h.Add("beforePrint",BeforePrint); Highstock.AddFunction("ChartEventsBeforePrint.beforePrint", BeforePrint); }  
			if (AddSeries != AddSeries_DefaultValue) { h.Add("addSeries",AddSeries); Highstock.AddFunction("ChartEventsAddSeries.addSeries", AddSeries); }  
			if (Click != Click_DefaultValue) { h.Add("click",Click); Highstock.AddFunction("ChartEventsClick.click", Click); }  
			if (Load != Load_DefaultValue) { h.Add("load",Load); Highstock.AddFunction("ChartEventsLoad.load", Load); }  
			if (Redraw != Redraw_DefaultValue) { h.Add("redraw",Redraw); Highstock.AddFunction("ChartEventsRedraw.redraw", Redraw); }  
			if (Render != Render_DefaultValue) { h.Add("render",Render); Highstock.AddFunction("ChartEventsRender.render", Render); }  
			if (Selection != Selection_DefaultValue) { h.Add("selection",Selection); Highstock.AddFunction("ChartEventsSelection.selection", Selection); }  
			

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
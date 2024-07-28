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
	public partial class AccessibilityScreenReaderSection  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AccessibilityScreenReaderSection()
		{
		}	
		

		/// <summary>
		/// Format for the screen reader information region after the chart.Analogous to [beforeChartFormat](#accessibility.screenReaderSection.beforeChartFormat).
		/// </summary>
		public string AfterChartFormat { get; set; }
		 

		/// <summary>
		/// A formatter function to create the HTML contents of the hiddenscreen reader information region after the chart. Analogous to[beforeChartFormatter](#accessibility.screenReaderSection.beforeChartFormatter).
		/// </summary>
		public string AfterChartFormatter { get; set; }
		 

		/// <summary>
		/// Date format to use to describe range of datetime axes.For an overview of the replacement codes, see[dateFormat](/class-reference/Highcharts.Time#dateFormat).
		/// </summary>
		public string AxisRangeDateFormat { get; set; }
		 

		/// <summary>
		/// Format for the screen reader information region before the chart.Supported HTML tags are `<h1-6>`, `<p>`, `<div>`, `<a>`, `<ul>`,`<ol>`, `<li>`, and `<button>`. Attributes are not supported,except for id on `<div>`, `<a>`, and `<button>`. Id is requiredon `<a>` and `<button>` in the format `<tag id="abcd">`. Numbers,lower- and uppercase letters, "-" and "#" are valid characters inIDs.The headingTagName is an auto-detected heading (h1-h6) thatcorresponds to the heading level below the previous heading inthe DOM.Set to empty string to remove the region altogether.
		/// </summary>
		public string BeforeChartFormat { get; set; }
		 

		/// <summary>
		/// A formatter function to create the HTML contents of the hiddenscreen reader information region before the chart. Receives oneargument, `chart`, referring to the chart object. Should return astring with the HTML content of the region. By default thisreturns an automatic description of the chart based on[beforeChartFormat](#accessibility.screenReaderSection.beforeChartFormat).
		/// </summary>
		public string BeforeChartFormatter { get; set; }
		 

		/// <summary>
		/// Function to run upon clicking the "Play as sound" button inthe screen reader region.By default Highcharts will call the `chart.sonify` function.
		/// </summary>
		public string OnPlayAsSoundClick { get; set; }
		 

		/// <summary>
		/// Function to run upon clicking the "View as Data Table" link inthe screen reader region.By default Highcharts will insert and set focus to a data tablerepresentation of the chart.
		/// </summary>
		public string OnViewDataTableClick { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (AfterChartFormat != null) h.Add("afterChartFormat",AfterChartFormat);
			if (AfterChartFormatter != null) { h.Add("afterChartFormatter",AfterChartFormatter); highcharts.AddFunction("afterChartFormatter", AfterChartFormatter); }  
			if (AxisRangeDateFormat != null) h.Add("axisRangeDateFormat",AxisRangeDateFormat);
			if (BeforeChartFormat != null) h.Add("beforeChartFormat",BeforeChartFormat);
			if (BeforeChartFormatter != null) { h.Add("beforeChartFormatter",BeforeChartFormatter); highcharts.AddFunction("beforeChartFormatter", BeforeChartFormatter); }  
			if (OnPlayAsSoundClick != null) { h.Add("onPlayAsSoundClick",OnPlayAsSoundClick); highcharts.AddFunction("onPlayAsSoundClick", OnPlayAsSoundClick); }  
			if (OnViewDataTableClick != null) { h.Add("onViewDataTableClick",OnViewDataTableClick); highcharts.AddFunction("onViewDataTableClick", OnViewDataTableClick); }  
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
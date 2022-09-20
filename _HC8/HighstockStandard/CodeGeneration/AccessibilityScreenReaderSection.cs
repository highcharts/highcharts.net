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
	public partial class AccessibilityScreenReaderSection  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AccessibilityScreenReaderSection()
		{
			AfterChartFormat = AfterChartFormat_DefaultValue = "{endOfChartMarker}";
			AfterChartFormatter = AfterChartFormatter_DefaultValue = "";
			AxisRangeDateFormat = AxisRangeDateFormat_DefaultValue = "%Y-%m-%d %H:%M:%S";
			BeforeChartFormat = BeforeChartFormat_DefaultValue = "<{headingTagName}>{chartTitle}</{headingTagName}><div>{typeDescription}</div><div>{chartSubtitle}</div><div>{chartLongdesc}</div><div>{playAsSoundButton}</div><div>{viewTableButton}</div><div>{xAxisDescription}</div><div>{yAxisDescription}</div><div>{annotationsTitle}{annotationsList}</div>";
			BeforeChartFormatter = BeforeChartFormatter_DefaultValue = "";
			OnPlayAsSoundClick = OnPlayAsSoundClick_DefaultValue = "";
			OnViewDataTableClick = OnViewDataTableClick_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Format for the screen reader information region after the chart.Analogous to [beforeChartFormat](#accessibility.screenReaderSection.beforeChartFormat).
		/// </summary>
		public string AfterChartFormat { get; set; }
		private string AfterChartFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// A formatter function to create the HTML contents of the hiddenscreen reader information region after the chart. Analogous to[beforeChartFormatter](#accessibility.screenReaderSection.beforeChartFormatter).
		/// </summary>
		public string AfterChartFormatter { get; set; }
		private string AfterChartFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Date format to use to describe range of datetime axes.For an overview of the replacement codes, see[dateFormat](/class-reference/Highcharts.Time#dateFormat).
		/// </summary>
		public string AxisRangeDateFormat { get; set; }
		private string AxisRangeDateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Format for the screen reader information region before the chart.Supported HTML tags are `<h1-6>`, `<p>`, `<div>`, `<a>`, `<ul>`,`<ol>`, `<li>`, and `<button>`. Attributes are not supported,except for id on `<div>`, `<a>`, and `<button>`. Id is requiredon `<a>` and `<button>` in the format `<tag id="abcd">`. Numbers,lower- and uppercase letters, "-" and "#" are valid characters inIDs.The headingTagName is an auto-detected heading (h1-h6) thatcorresponds to the heading level below the previous heading inthe DOM.Set to empty string to remove the region altogether.
		/// </summary>
		public string BeforeChartFormat { get; set; }
		private string BeforeChartFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// A formatter function to create the HTML contents of the hiddenscreen reader information region before the chart. Receives oneargument, `chart`, referring to the chart object. Should return astring with the HTML content of the region. By default thisreturns an automatic description of the chart based on[beforeChartFormat](#accessibility.screenReaderSection.beforeChartFormat).
		/// </summary>
		public string BeforeChartFormatter { get; set; }
		private string BeforeChartFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Function to run upon clicking the "Play as sound" button inthe screen reader region.By default Highcharts will call the `chart.sonify` function.
		/// </summary>
		public string OnPlayAsSoundClick { get; set; }
		private string OnPlayAsSoundClick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Function to run upon clicking the "View as Data Table" link inthe screen reader region.By default Highcharts will insert and set focus to a data tablerepresentation of the chart.
		/// </summary>
		public string OnViewDataTableClick { get; set; }
		private string OnViewDataTableClick_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (AfterChartFormat != AfterChartFormat_DefaultValue) h.Add("afterChartFormat",AfterChartFormat);
			if (AfterChartFormatter != AfterChartFormatter_DefaultValue) { h.Add("afterChartFormatter",AfterChartFormatter); highstock.AddFunction("afterChartFormatter", AfterChartFormatter); }  
			if (AxisRangeDateFormat != AxisRangeDateFormat_DefaultValue) h.Add("axisRangeDateFormat",AxisRangeDateFormat);
			if (BeforeChartFormat != BeforeChartFormat_DefaultValue) h.Add("beforeChartFormat",BeforeChartFormat);
			if (BeforeChartFormatter != BeforeChartFormatter_DefaultValue) { h.Add("beforeChartFormatter",BeforeChartFormatter); highstock.AddFunction("beforeChartFormatter", BeforeChartFormatter); }  
			if (OnPlayAsSoundClick != OnPlayAsSoundClick_DefaultValue) { h.Add("onPlayAsSoundClick",OnPlayAsSoundClick); highstock.AddFunction("onPlayAsSoundClick", OnPlayAsSoundClick); }  
			if (OnViewDataTableClick != OnViewDataTableClick_DefaultValue) { h.Add("onViewDataTableClick",OnViewDataTableClick); highstock.AddFunction("onViewDataTableClick", OnViewDataTableClick); }  
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}
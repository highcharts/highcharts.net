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
	public partial class LangAccessibility  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibility()
		{
		}	
		

		/// <summary>
		/// Default announcement for new data in charts. If addPoint oraddSeries is used, and only one series/point is added, the`newPointAnnounce` and `newSeriesAnnounce` strings are used.The `...Single` versions will be used if there is only one charton the page, and the `...Multiple` versions will be used if thereare multiple charts on the page. For all other new data events,the `newDataAnnounce` string will be used.
		/// </summary>
		public LangAccessibilityAnnounceNewData AnnounceNewData { get; set; }
		 

		/// <summary>
		/// Axis description format strings.
		/// </summary>
		public LangAccessibilityAxis Axis { get; set; }
		 

		/// <summary>
		/// Accessible label for the chart container HTML element.`{title}` refers to the chart title.
		/// </summary>
		public string ChartContainerLabel { get; set; }
		 

		/// <summary>
		/// Chart type description strings. This is added to the chartinformation region.If there is only a single series type used in the chart, we usethe format string for the series type, or default if missing.There is one format string for cases where there is only a singleseries in the chart, and one for multiple series of the sametype.
		/// </summary>
		public LangAccessibilityChartTypes ChartTypes { get; set; }
		 

		/// <summary>
		/// Accessible label for the chart credits.`{creditsStr}` refers to the visual text in the credits.
		/// </summary>
		public string Credits { get; set; }
		 

		/// <summary>
		/// Default title of the chart for assistive technology, for chartswithout a chart title.
		/// </summary>
		public string DefaultChartTitle { get; set; }
		 

		/// <summary>
		/// Accessible label for the drill-up button.`{buttonText}` refers to the visual text on the button.
		/// </summary>
		public string DrillUpButton { get; set; }
		 

		/// <summary>
		/// Exporting menu format strings for accessibility module.
		/// </summary>
		public LangAccessibilityExporting Exporting { get; set; }
		 

		/// <summary>
		/// Set a label on the container wrapping the SVG.
		/// </summary>
		public string GraphicContainerLabel { get; set; }
		 

		/// <summary>
		/// Language options for accessibility of the legend.
		/// </summary>
		public LangAccessibilityLegend Legend { get; set; }
		 

		/// <summary>
		/// Navigator language options for accessibility.
		/// </summary>
		public LangAccessibilityNavigator Navigator { get; set; }
		 

		/// <summary>
		/// Range selector language options for accessibility.
		/// </summary>
		public LangAccessibilityRangeSelector RangeSelector { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ResetZoomButton { get; set; }
		 

		/// <summary>
		/// Language options for the screen reader information sections addedbefore and after the charts.
		/// </summary>
		public LangAccessibilityScreenReaderSection ScreenReaderSection { get; set; }
		 

		/// <summary>
		/// Lang configuration for different series types. For more dynamiccontrol over the series element descriptions, see[accessibility.seriesDescriptionFormatter](#accessibility.seriesDescriptionFormatter).
		/// </summary>
		public LangAccessibilitySeries Series { get; set; }
		 

		/// <summary>
		/// Descriptions of lesser known series types. The relevantdescription is added to the screen reader information regionwhen these series types are used.
		/// </summary>
		public LangAccessibilitySeriesTypeDescriptions SeriesTypeDescriptions { get; set; }
		 

		/// <summary>
		/// Language options for sonification.
		/// </summary>
		public LangAccessibilitySonification Sonification { get; set; }
		 

		/// <summary>
		/// Accessible label for the chart SVG element.`{chartTitle}` refers to the chart title.
		/// </summary>
		public string SvgContainerLabel { get; set; }
		 

		/// <summary>
		/// Title element text for the chart SVG element. Leave thisempty to disable adding the title element. Browsers will displaythis content when hovering over elements in the chart. Assistivetechnology may use this element to label the chart.
		/// </summary>
		public string SvgContainerTitle { get; set; }
		 

		/// <summary>
		/// Accessibility language options for the data table.
		/// </summary>
		public LangAccessibilityTable Table { get; set; }
		 

		/// <summary>
		/// Thousands separator to use when formatting numbers for screenreaders. Note that many screen readers will not handle space as athousands separator, and will consider "11 700" as two numbers.Set to `null` to use the separator defined in[lang.thousandsSep](lang.thousandsSep).
		/// </summary>
		public string ThousandsSep { get; set; }
		 

		/// <summary>
		/// Chart and map zoom accessibility language options.
		/// </summary>
		public LangAccessibilityZoom Zoom { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (AnnounceNewData != null) h.Add("announceNewData",AnnounceNewData.ToHashtable(highcharts));
			if (Axis != null) h.Add("axis",Axis.ToHashtable(highcharts));
			if (ChartContainerLabel != null) h.Add("chartContainerLabel",ChartContainerLabel);
			if (ChartTypes != null) h.Add("chartTypes",ChartTypes.ToHashtable(highcharts));
			if (Credits != null) h.Add("credits",Credits);
			if (DefaultChartTitle != null) h.Add("defaultChartTitle",DefaultChartTitle);
			if (DrillUpButton != null) h.Add("drillUpButton",DrillUpButton);
			if (Exporting != null) h.Add("exporting",Exporting.ToHashtable(highcharts));
			if (GraphicContainerLabel != null) h.Add("graphicContainerLabel",GraphicContainerLabel);
			if (Legend != null) h.Add("legend",Legend.ToHashtable(highcharts));
			if (Navigator != null) h.Add("navigator",Navigator.ToHashtable(highcharts));
			if (RangeSelector != null) h.Add("rangeSelector",RangeSelector.ToHashtable(highcharts));
			if (ResetZoomButton != null) h.Add("resetZoomButton",ResetZoomButton);
			if (ScreenReaderSection != null) h.Add("screenReaderSection",ScreenReaderSection.ToHashtable(highcharts));
			if (Series != null) h.Add("series",Series.ToHashtable(highcharts));
			if (SeriesTypeDescriptions != null) h.Add("seriesTypeDescriptions",SeriesTypeDescriptions.ToHashtable(highcharts));
			if (Sonification != null) h.Add("sonification",Sonification.ToHashtable(highcharts));
			if (SvgContainerLabel != null) h.Add("svgContainerLabel",SvgContainerLabel);
			if (SvgContainerTitle != null) h.Add("svgContainerTitle",SvgContainerTitle);
			if (Table != null) h.Add("table",Table.ToHashtable(highcharts));
			if (ThousandsSep != null) h.Add("thousandsSep",ThousandsSep);
			if (Zoom != null) h.Add("zoom",Zoom.ToHashtable(highcharts));
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
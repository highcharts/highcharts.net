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
	public partial class Lang  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Lang()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Configure the accessibility strings in the chart. Requires the[accessibility module](https://code.highcharts.com/modules/accessibility.js)to be loaded. For a description of the module and information on itsfeatures, see[Highcharts Accessibility](https://www.highcharts.com/docs/chart-concepts/accessibility).The lang options use [Format Strings](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#format-strings)with variables that are replaced at run time. These variables should beused when available, to avoid duplicating text that is defined elsewhere.For more dynamic control over the accessibility functionality, see[accessibility.point.descriptionFormatter](#accessibility.point.descriptionFormatter),[accessibility.series.descriptionFormatter](#accessibility.series.descriptionFormatter),and[accessibility.screenReaderSection.beforeChartFormatter](#accessibility.screenReaderSection.beforeChartFormatter).
		/// </summary>
		public LangAccessibility Accessibility { get; set; }
		 

		/// <summary>
		/// Exporting module menu. The tooltip title for the context menu holdingprint and export menu items.
		/// </summary>
		public string ContextButtonTitle { get; set; }
		 

		/// <summary>
		/// The default decimal point used in the `Highcharts.numberFormat`method unless otherwise specified in the function arguments.
		/// </summary>
		public string DecimalPoint { get; set; }
		 

		/// <summary>
		/// The text for the menu item.
		/// </summary>
		public string DownloadCSV { get; set; }
		 

		/// <summary>
		/// Exporting module only. The text for the JPEG download menu item.
		/// </summary>
		public string DownloadJPEG { get; set; }
		 

		/// <summary>
		/// The text for the MIDI download menu item in the export menu.
		/// </summary>
		public string DownloadMIDI { get; set; }
		 

		/// <summary>
		/// Exporting module only. The text for the PDF download menu item.
		/// </summary>
		public string DownloadPDF { get; set; }
		 

		/// <summary>
		/// Exporting module only. The text for the PNG download menu item.
		/// </summary>
		public string DownloadPNG { get; set; }
		 

		/// <summary>
		/// Exporting module only. The text for the SVG download menu item.
		/// </summary>
		public string DownloadSVG { get; set; }
		 

		/// <summary>
		/// The text for the menu item.
		/// </summary>
		public string DownloadXLS { get; set; }
		 

		/// <summary>
		/// The text for the button that appears when drilling down, linking backto the parent series. The parent series' name is inserted for`{series.name}`.
		/// </summary>
		public string DrillUpText { get; set; }
		 

		/// <summary>
		/// Exporting module only. The text for the menu item to exit the chartfrom full screen.
		/// </summary>
		public string ExitFullscreen { get; set; }
		 

		/// <summary>
		/// The text for exported table.
		/// </summary>
		public LangExportData ExportData { get; set; }
		 

		/// <summary>
		/// Text to show when export is in progress.
		/// </summary>
		public string ExportInProgress { get; set; }
		 

		/// <summary>
		/// The text for the menu item.
		/// </summary>
		public string HideData { get; set; }
		 

		/// <summary>
		/// What to show in a date field for invalid dates. Defaults to an emptystring.
		/// </summary>
		public string InvalidDate { get; set; }
		 

		/// <summary>
		/// The loading text that appears when the chart is set into the loadingstate following a call to `chart.showLoading`.
		/// </summary>
		public string Loading { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MainBreadcrumb { get; set; }
		 

		/// <summary>
		/// An array containing the months names. Corresponds to the `%B` formatin `Highcharts.dateFormat()`.
		/// </summary>
		public List<string> Months { get; set; }
		 

		/// <summary>
		/// Configure the Popup strings in the chart. Requires the`annotations.js` or `annotations-advanced.src.js` module to beloaded.
		/// </summary>
		public LangNavigation Navigation { get; set; }
		 

		/// <summary>
		/// The text to display when the chart contains no data.
		/// </summary>
		public string NoData { get; set; }
		 

		/// <summary>
		/// The magnitude of [numericSymbols](#lang.numericSymbol) replacements.Use 10000 for Japanese, Korean and various Chinese locales, whichuse symbols for 10^4, 10^8 and 10^12.
		/// </summary>
		public double? NumericSymbolMagnitude { get; set; }
		 

		/// <summary>
		/// [Metric prefixes](https://en.wikipedia.org/wiki/Metric_prefix) usedto shorten high numbers in axis labels. Replacing any of thepositions with `null` causes the full number to be written. Setting`numericSymbols` to `undefined` disables shortening altogether.
		/// </summary>
		public List<string> NumericSymbols { get; set; }
		 

		/// <summary>
		/// The text for the Play as sound menu item in the export menu.
		/// </summary>
		public string PlayAsSound { get; set; }
		 

		/// <summary>
		/// Exporting module only. The text for the menu item to print the chart.
		/// </summary>
		public string PrintChart { get; set; }
		 

		/// <summary>
		/// The text for the label appearing when a chart is zoomed.
		/// </summary>
		public string ResetZoom { get; set; }
		 

		/// <summary>
		/// The tooltip title for the label appearing when a chart is zoomed.
		/// </summary>
		public string ResetZoomTitle { get; set; }
		 

		/// <summary>
		/// An array containing the months names in abbreviated form. Correspondsto the `%b` format in `Highcharts.dateFormat()`.
		/// </summary>
		public List<string> ShortMonths { get; set; }
		 

		/// <summary>
		/// Short week days, starting Sunday. If not specified, Highcharts usesthe first three letters of the `lang.weekdays` option.
		/// </summary>
		public List<string> ShortWeekdays { get; set; }
		 

		/// <summary>
		/// The default thousands separator used in the `Highcharts.numberFormat`method unless otherwise specified in the function arguments. Defaultsto a single space character, which is recommended in[ISO 31-0](https://en.wikipedia.org/wiki/ISO_31-0#Numbers) and worksacross Anglo-American and continental European languages.
		/// </summary>
		public string ThousandsSep { get; set; }
		 

		/// <summary>
		/// The text for the menu item.
		/// </summary>
		public string ViewData { get; set; }
		 

		/// <summary>
		/// Exporting module only. The text for the menu item to view the chartin full screen.
		/// </summary>
		public string ViewFullscreen { get; set; }
		 

		/// <summary>
		/// An array containing the weekday names.
		/// </summary>
		public List<string> Weekdays { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (ContextButtonTitle != null) h.Add("contextButtonTitle",ContextButtonTitle);
			if (DecimalPoint != null) h.Add("decimalPoint",DecimalPoint);
			if (DownloadCSV != null) h.Add("downloadCSV",DownloadCSV);
			if (DownloadJPEG != null) h.Add("downloadJPEG",DownloadJPEG);
			if (DownloadMIDI != null) h.Add("downloadMIDI",DownloadMIDI);
			if (DownloadPDF != null) h.Add("downloadPDF",DownloadPDF);
			if (DownloadPNG != null) h.Add("downloadPNG",DownloadPNG);
			if (DownloadSVG != null) h.Add("downloadSVG",DownloadSVG);
			if (DownloadXLS != null) h.Add("downloadXLS",DownloadXLS);
			if (DrillUpText != null) h.Add("drillUpText",DrillUpText);
			if (ExitFullscreen != null) h.Add("exitFullscreen",ExitFullscreen);
			if (ExportData != null) h.Add("exportData",ExportData.ToHashtable(highcharts));
			if (ExportInProgress != null) h.Add("exportInProgress",ExportInProgress);
			if (HideData != null) h.Add("hideData",HideData);
			if (InvalidDate != null) h.Add("invalidDate",InvalidDate);
			if (Loading != null) h.Add("loading",Loading);
			if (MainBreadcrumb != null) h.Add("mainBreadcrumb",MainBreadcrumb);
			if (Months != null) h.Add("months",Months);
			if (Navigation != null) h.Add("navigation",Navigation.ToHashtable(highcharts));
			if (NoData != null) h.Add("noData",NoData);
			if (NumericSymbolMagnitude != null) h.Add("numericSymbolMagnitude",NumericSymbolMagnitude);
			if (NumericSymbols != null) h.Add("numericSymbols",NumericSymbols);
			if (PlayAsSound != null) h.Add("playAsSound",PlayAsSound);
			if (PrintChart != null) h.Add("printChart",PrintChart);
			if (ResetZoom != null) h.Add("resetZoom",ResetZoom);
			if (ResetZoomTitle != null) h.Add("resetZoomTitle",ResetZoomTitle);
			if (ShortMonths != null) h.Add("shortMonths",ShortMonths);
			if (ShortWeekdays != null) h.Add("shortWeekdays",ShortWeekdays);
			if (ThousandsSep != null) h.Add("thousandsSep",ThousandsSep);
			if (ViewData != null) h.Add("viewData",ViewData);
			if (ViewFullscreen != null) h.Add("viewFullscreen",ViewFullscreen);
			if (Weekdays != null) h.Add("weekdays",Weekdays);
			if (CustomFields.Count > 0)
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
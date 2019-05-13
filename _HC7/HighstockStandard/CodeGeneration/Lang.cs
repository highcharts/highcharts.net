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
	public partial class Lang  : BaseObject
	{
		public Lang()
		{
			Accessibility = Accessibility_DefaultValue = new LangAccessibility();
			ContextButtonTitle = ContextButtonTitle_DefaultValue = "Chart context menu";
			DecimalPoint = DecimalPoint_DefaultValue = ".";
			DownloadCSV = DownloadCSV_DefaultValue = "Download CSV";
			DownloadJPEG = DownloadJPEG_DefaultValue = "Download JPEG image";
			DownloadPDF = DownloadPDF_DefaultValue = "Download PDF document";
			DownloadPNG = DownloadPNG_DefaultValue = "Download PNG image";
			DownloadSVG = DownloadSVG_DefaultValue = "Download SVG vector image";
			DownloadXLS = DownloadXLS_DefaultValue = "Download XLS";
			InvalidDate = InvalidDate_DefaultValue = "";
			Loading = Loading_DefaultValue = "Loading...";
			Months = Months_DefaultValue = new List<string> {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
			Navigation = Navigation_DefaultValue = new LangNavigation();
			NoData = NoData_DefaultValue = "No data to display";
			NumericSymbolMagnitude = NumericSymbolMagnitude_DefaultValue = 1000;
			NumericSymbols = NumericSymbols_DefaultValue = new List<string> {"k", "M", "G", "T", "P", "E"};
			OpenInCloud = OpenInCloud_DefaultValue = "Open in Highcharts Cloud";
			PrintChart = PrintChart_DefaultValue = "Print chart";
			RangeSelectorFrom = RangeSelectorFrom_DefaultValue = "From";
			RangeSelectorTo = RangeSelectorTo_DefaultValue = "To";
			RangeSelectorZoom = RangeSelectorZoom_DefaultValue = "Zoom";
			ResetZoom = ResetZoom_DefaultValue = "Reset zoom";
			ResetZoomTitle = ResetZoomTitle_DefaultValue = "Reset zoom level 1:1";
			ShortMonths = ShortMonths_DefaultValue = new List<string> {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul",  "Aug", "Sep", "Oct", "Nov", "Dec"};
			ShortWeekdays = ShortWeekdays_DefaultValue = new List<string>();
			StockTools = StockTools_DefaultValue = new LangStockTools();
			ThousandsSep = ThousandsSep_DefaultValue = "\u0020";
			ViewData = ViewData_DefaultValue = "View data table";
			ViewFullscreen = ViewFullscreen_DefaultValue = "View in full screen";
			Weekdays = Weekdays_DefaultValue = new List<string> {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday",
         "Friday", "Saturday"};
			
		}	
		

		/// <summary>
		/// Configure the accessibility strings in the chart. Requires the[accessibility module](https://code.highcharts.com/modules/accessibility.js)to be loaded. For a description of the module and information on itsfeatures, see[Highcharts Accessibility](https://www.highcharts.com/docs/chart-concepts/accessibility).For more dynamic control over the accessibility functionality, see[accessibility.pointDescriptionFormatter](#accessibility.pointDescriptionFormatter),[accessibility.seriesDescriptionFormatter](#accessibility.seriesDescriptionFormatter),and[accessibility.screenReaderSectionFormatter](#accessibility.screenReaderSectionFormatter).
		/// </summary>
		public LangAccessibility Accessibility { get; set; }
		private LangAccessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exporting module menu. The tooltip title for the context menu holdingprint and export menu items.
		/// </summary>
		public string ContextButtonTitle { get; set; }
		private string ContextButtonTitle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The default decimal point used in the `Highcharts.numberFormat`method unless otherwise specified in the function arguments.
		/// </summary>
		public string DecimalPoint { get; set; }
		private string DecimalPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Export-data module only. The text for the menu item.
		/// </summary>
		public string DownloadCSV { get; set; }
		private string DownloadCSV_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exporting module only. The text for the JPEG download menu item.
		/// </summary>
		public string DownloadJPEG { get; set; }
		private string DownloadJPEG_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exporting module only. The text for the PDF download menu item.
		/// </summary>
		public string DownloadPDF { get; set; }
		private string DownloadPDF_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exporting module only. The text for the PNG download menu item.
		/// </summary>
		public string DownloadPNG { get; set; }
		private string DownloadPNG_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exporting module only. The text for the SVG download menu item.
		/// </summary>
		public string DownloadSVG { get; set; }
		private string DownloadSVG_DefaultValue { get; set; }
		 

		/// <summary>
		/// Export-data module only. The text for the menu item.
		/// </summary>
		public string DownloadXLS { get; set; }
		private string DownloadXLS_DefaultValue { get; set; }
		 

		/// <summary>
		/// What to show in a date field for invalid dates. Defaults to an emptystring.
		/// </summary>
		public string InvalidDate { get; set; }
		private string InvalidDate_DefaultValue { get; set; }
		 

		/// <summary>
		/// The loading text that appears when the chart is set into the loadingstate following a call to `chart.showLoading`.
		/// </summary>
		public string Loading { get; set; }
		private string Loading_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array containing the months names. Corresponds to the `%B` formatin `Highcharts.dateFormat()`.
		/// </summary>
		public List<string> Months { get; set; }
		private List<string> Months_DefaultValue { get; set; }
		 

		/// <summary>
		/// Configure the Popup strings in the chart. Requires the`annotations.js` or `annotations-advanced.src.js` module to beloaded.
		/// </summary>
		public LangNavigation Navigation { get; set; }
		private LangNavigation Navigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text to display when the chart contains no data. Requires theno-data module, see [noData](#noData).
		/// </summary>
		public string NoData { get; set; }
		private string NoData_DefaultValue { get; set; }
		 

		/// <summary>
		/// The magnitude of [numericSymbols](#lang.numericSymbol) replacements.Use 10000 for Japanese, Korean and various Chinese locales, whichuse symbols for 10^4, 10^8 and 10^12.
		/// </summary>
		public double? NumericSymbolMagnitude { get; set; }
		private double? NumericSymbolMagnitude_DefaultValue { get; set; }
		 

		/// <summary>
		/// [Metric prefixes](http://en.wikipedia.org/wiki/Metric_prefix) usedto shorten high numbers in axis labels. Replacing any of thepositions with `null` causes the full number to be written. Setting`numericSymbols` to `null` disables shortening altogether.
		/// </summary>
		public List<string> NumericSymbols { get; set; }
		private List<string> NumericSymbols_DefaultValue { get; set; }
		 

		/// <summary>
		/// Export-data module only. The text for the menu item.
		/// </summary>
		public string OpenInCloud { get; set; }
		private string OpenInCloud_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exporting module only. The text for the menu item to print the chart.
		/// </summary>
		public string PrintChart { get; set; }
		private string PrintChart_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text for the label for the "from" input box in the rangeselector.
		/// </summary>
		public string RangeSelectorFrom { get; set; }
		private string RangeSelectorFrom_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text for the label for the "to" input box in the range selector.
		/// </summary>
		public string RangeSelectorTo { get; set; }
		private string RangeSelectorTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text for the label for the range selector buttons.
		/// </summary>
		public string RangeSelectorZoom { get; set; }
		private string RangeSelectorZoom_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text for the label appearing when a chart is zoomed.
		/// </summary>
		public string ResetZoom { get; set; }
		private string ResetZoom_DefaultValue { get; set; }
		 

		/// <summary>
		/// The tooltip title for the label appearing when a chart is zoomed.
		/// </summary>
		public string ResetZoomTitle { get; set; }
		private string ResetZoomTitle_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array containing the months names in abbreviated form. Correspondsto the `%b` format in `Highcharts.dateFormat()`.
		/// </summary>
		public List<string> ShortMonths { get; set; }
		private List<string> ShortMonths_DefaultValue { get; set; }
		 

		/// <summary>
		/// Short week days, starting Sunday. If not specified, Highcharts usesthe first three letters of the `lang.weekdays` option.
		/// </summary>
		public List<string> ShortWeekdays { get; set; }
		private List<string> ShortWeekdays_DefaultValue { get; set; }
		 

		/// <summary>
		/// Configure the stockTools GUI titles(hints) in the chart. Requiresthe `stock-tools.js` module to be loaded.
		/// </summary>
		public LangStockTools StockTools { get; set; }
		private LangStockTools StockTools_DefaultValue { get; set; }
		 

		/// <summary>
		/// The default thousands separator used in the `Highcharts.numberFormat`method unless otherwise specified in the function arguments. Defaultsto a single space character, which is recommended in[ISO 31-0](https://en.wikipedia.org/wiki/ISO_31-0#Numbers) and worksacross Anglo-American and continental European languages.
		/// </summary>
		public string ThousandsSep { get; set; }
		private string ThousandsSep_DefaultValue { get; set; }
		 

		/// <summary>
		/// Export-data module only. The text for the menu item.
		/// </summary>
		public string ViewData { get; set; }
		private string ViewData_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exporting module only. View the chart in full screen.
		/// </summary>
		public string ViewFullscreen { get; set; }
		private string ViewFullscreen_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array containing the weekday names.
		/// </summary>
		public List<string> Weekdays { get; set; }
		private List<string> Weekdays_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Accessibility.IsDirty()) h.Add("accessibility",Accessibility.ToHashtable());
			if (ContextButtonTitle != ContextButtonTitle_DefaultValue) h.Add("contextButtonTitle",ContextButtonTitle);
			if (DecimalPoint != DecimalPoint_DefaultValue) h.Add("decimalPoint",DecimalPoint);
			if (DownloadCSV != DownloadCSV_DefaultValue) h.Add("downloadCSV",DownloadCSV);
			if (DownloadJPEG != DownloadJPEG_DefaultValue) h.Add("downloadJPEG",DownloadJPEG);
			if (DownloadPDF != DownloadPDF_DefaultValue) h.Add("downloadPDF",DownloadPDF);
			if (DownloadPNG != DownloadPNG_DefaultValue) h.Add("downloadPNG",DownloadPNG);
			if (DownloadSVG != DownloadSVG_DefaultValue) h.Add("downloadSVG",DownloadSVG);
			if (DownloadXLS != DownloadXLS_DefaultValue) h.Add("downloadXLS",DownloadXLS);
			if (InvalidDate != InvalidDate_DefaultValue) h.Add("invalidDate",InvalidDate);
			if (Loading != Loading_DefaultValue) h.Add("loading",Loading);
			if (Months != Months_DefaultValue) h.Add("months",Months);
			if (Navigation.IsDirty()) h.Add("navigation",Navigation.ToHashtable());
			if (NoData != NoData_DefaultValue) h.Add("noData",NoData);
			if (NumericSymbolMagnitude != NumericSymbolMagnitude_DefaultValue) h.Add("numericSymbolMagnitude",NumericSymbolMagnitude);
			if (NumericSymbols != NumericSymbols_DefaultValue) h.Add("numericSymbols",NumericSymbols);
			if (OpenInCloud != OpenInCloud_DefaultValue) h.Add("openInCloud",OpenInCloud);
			if (PrintChart != PrintChart_DefaultValue) h.Add("printChart",PrintChart);
			if (RangeSelectorFrom != RangeSelectorFrom_DefaultValue) h.Add("rangeSelectorFrom",RangeSelectorFrom);
			if (RangeSelectorTo != RangeSelectorTo_DefaultValue) h.Add("rangeSelectorTo",RangeSelectorTo);
			if (RangeSelectorZoom != RangeSelectorZoom_DefaultValue) h.Add("rangeSelectorZoom",RangeSelectorZoom);
			if (ResetZoom != ResetZoom_DefaultValue) h.Add("resetZoom",ResetZoom);
			if (ResetZoomTitle != ResetZoomTitle_DefaultValue) h.Add("resetZoomTitle",ResetZoomTitle);
			if (ShortMonths != ShortMonths_DefaultValue) h.Add("shortMonths",ShortMonths);
			if (ShortWeekdays != ShortWeekdays_DefaultValue) h.Add("shortWeekdays",ShortWeekdays);
			if (StockTools.IsDirty()) h.Add("stockTools",StockTools.ToHashtable());
			if (ThousandsSep != ThousandsSep_DefaultValue) h.Add("thousandsSep",ThousandsSep);
			if (ViewData != ViewData_DefaultValue) h.Add("viewData",ViewData);
			if (ViewFullscreen != ViewFullscreen_DefaultValue) h.Add("viewFullscreen",ViewFullscreen);
			if (Weekdays != Weekdays_DefaultValue) h.Add("weekdays",Weekdays);
			

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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class Lang  : BaseObject
	{
		public Lang()
		{
			DrillUpText = DrillUpText_DefaultValue = "Back to {series.name}";
			DownloadCSV = DownloadCSV_DefaultValue = "Download CSV";
			DownloadXLS = DownloadXLS_DefaultValue = "Download XLS";
			ViewData = ViewData_DefaultValue = "View data table";
			PrintChart = PrintChart_DefaultValue = "Print chart";
			DownloadPNG = DownloadPNG_DefaultValue = "Download PNG image";
			DownloadJPEG = DownloadJPEG_DefaultValue = "Download JPEG image";
			DownloadPDF = DownloadPDF_DefaultValue = "Download PDF document";
			DownloadSVG = DownloadSVG_DefaultValue = "Download SVG vector image";
			ContextButtonTitle = ContextButtonTitle_DefaultValue = "Chart context menu";
			NoData = NoData_DefaultValue = "No data to display";
			Loading = Loading_DefaultValue = "Loading...";
			Months = Months_DefaultValue = new List<string> {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
			ShortMonths = ShortMonths_DefaultValue = new List<string> {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul",  "Aug", "Sep", "Oct", "Nov", "Dec"};
			Weekdays = Weekdays_DefaultValue = new List<string> {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday",
			DecimalPoint = DecimalPoint_DefaultValue = ".";
			NumericSymbols = NumericSymbols_DefaultValue = new List<string> { "k" , "M" , "G" , "T" , "P" , "E"};
			ResetZoom = ResetZoom_DefaultValue = "Reset zoom";
			ResetZoomTitle = ResetZoomTitle_DefaultValue = "Reset zoom level 1:1";
			ThousandsSep = ThousandsSep_DefaultValue = "";
			ShortWeekdays = ShortWeekdays_DefaultValue = "";
			InvalidDate = InvalidDate_DefaultValue = "";
			NumericSymbolMagnitude = NumericSymbolMagnitude_DefaultValue = 1000;
			
		}	
		

		/// <summary>
		/// The text for the button that appears when drilling down, linkingback to the parent series. The parent series' name is inserted for`{series.name}`.
		/// </summary>
		public string DrillUpText { get; set; }
		private string DrillUpText_DefaultValue { get; set; }
		 

		/// <summary>
		/// Export-data module only. The text for the menu item.
		/// </summary>
		public string DownloadCSV { get; set; }
		private string DownloadCSV_DefaultValue { get; set; }
		 

		/// <summary>
		/// Export-data module only. The text for the menu item.
		/// </summary>
		public string DownloadXLS { get; set; }
		private string DownloadXLS_DefaultValue { get; set; }
		 

		/// <summary>
		/// Export-data module only. The text for the menu item.
		/// </summary>
		public string ViewData { get; set; }
		private string ViewData_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exporting module only. The text for the menu item to print the chart.
		/// </summary>
		public string PrintChart { get; set; }
		private string PrintChart_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exporting module only. The text for the PNG download menu item.
		/// </summary>
		public string DownloadPNG { get; set; }
		private string DownloadPNG_DefaultValue { get; set; }
		 

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
		/// Exporting module only. The text for the SVG download menu item.
		/// </summary>
		public string DownloadSVG { get; set; }
		private string DownloadSVG_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exporting module menu. The tooltip title for the context menu holdingprint and export menu items.
		/// </summary>
		public string ContextButtonTitle { get; set; }
		private string ContextButtonTitle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text to display when the chart contains no data. Requires theno-data module, see [noData](#noData).
		/// </summary>
		public string NoData { get; set; }
		private string NoData_DefaultValue { get; set; }
		 

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
		/// An array containing the months names in abbreviated form. Correspondsto the `%b` format in `Highcharts.dateFormat()`.
		/// </summary>
		public List<string> ShortMonths { get; set; }
		private List<string> ShortMonths_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array containing the weekday names.
		/// </summary>
		public List<string> Weekdays { get; set; }
		private List<string> Weekdays_DefaultValue { get; set; }
		 

		/// <summary>
		/// The default decimal point used in the `Highcharts.numberFormat`method unless otherwise specified in the function arguments.
		/// </summary>
		public string DecimalPoint { get; set; }
		private string DecimalPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// [Metric prefixes](http://en.wikipedia.org/wiki/Metric_prefix) usedto shorten high numbers in axis labels. Replacing any of the positionswith `null` causes the full number to be written. Setting `numericSymbols`to `null` disables shortening altogether.
		/// </summary>
		public List<string> NumericSymbols { get; set; }
		private List<string> NumericSymbols_DefaultValue { get; set; }
		 

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
		/// The default thousands separator used in the `Highcharts.numberFormat`method unless otherwise specified in the function arguments. SinceHighcharts 4.1 it defaults to a single space character, which iscompatible with ISO and works across Anglo-American and continentalEuropean languages.The default is a single space.
		/// </summary>
		public string ThousandsSep { get; set; }
		private string ThousandsSep_DefaultValue { get; set; }
		 

		/// <summary>
		/// Short week days, starting Sunday. If not specified, Highcharts usesthe first three letters of the `lang.weekdays` option.
		/// </summary>
		public List<string> ShortWeekdays { get; set; }
		private List<string> ShortWeekdays_DefaultValue { get; set; }
		 

		/// <summary>
		/// What to show in a date field for invalid dates. Defaults to an emptystring.
		/// </summary>
		public string InvalidDate { get; set; }
		private string InvalidDate_DefaultValue { get; set; }
		 

		/// <summary>
		/// The magnitude of [numericSymbols](#lang.numericSymbol) replacements.Use 10000 for Japanese, Korean and various Chinese locales, whichuse symbols for 10^4, 10^8 and 10^12.
		/// </summary>
		public double? NumericSymbolMagnitude { get; set; }
		private double? NumericSymbolMagnitude_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (DrillUpText != DrillUpText_DefaultValue) h.Add("drillUpText",DrillUpText);
			if (DownloadCSV != DownloadCSV_DefaultValue) h.Add("downloadCSV",DownloadCSV);
			if (DownloadXLS != DownloadXLS_DefaultValue) h.Add("downloadXLS",DownloadXLS);
			if (ViewData != ViewData_DefaultValue) h.Add("viewData",ViewData);
			if (PrintChart != PrintChart_DefaultValue) h.Add("printChart",PrintChart);
			if (DownloadPNG != DownloadPNG_DefaultValue) h.Add("downloadPNG",DownloadPNG);
			if (DownloadJPEG != DownloadJPEG_DefaultValue) h.Add("downloadJPEG",DownloadJPEG);
			if (DownloadPDF != DownloadPDF_DefaultValue) h.Add("downloadPDF",DownloadPDF);
			if (DownloadSVG != DownloadSVG_DefaultValue) h.Add("downloadSVG",DownloadSVG);
			if (ContextButtonTitle != ContextButtonTitle_DefaultValue) h.Add("contextButtonTitle",ContextButtonTitle);
			if (NoData != NoData_DefaultValue) h.Add("noData",NoData);
			if (Loading != Loading_DefaultValue) h.Add("loading",Loading);
			if (Months != Months_DefaultValue) h.Add("months",Months);
			if (ShortMonths != ShortMonths_DefaultValue) h.Add("shortMonths",ShortMonths);
			if (Weekdays != Weekdays_DefaultValue) h.Add("weekdays",Weekdays);
			if (DecimalPoint != DecimalPoint_DefaultValue) h.Add("decimalPoint",DecimalPoint);
			if (NumericSymbols != NumericSymbols_DefaultValue) h.Add("numericSymbols",NumericSymbols);
			if (ResetZoom != ResetZoom_DefaultValue) h.Add("resetZoom",ResetZoom);
			if (ResetZoomTitle != ResetZoomTitle_DefaultValue) h.Add("resetZoomTitle",ResetZoomTitle);
			if (ThousandsSep != ThousandsSep_DefaultValue) h.Add("thousandsSep",ThousandsSep);
			if (ShortWeekdays != ShortWeekdays_DefaultValue) h.Add("shortWeekdays",ShortWeekdays);
			if (InvalidDate != InvalidDate_DefaultValue) h.Add("invalidDate",InvalidDate);
			if (NumericSymbolMagnitude != NumericSymbolMagnitude_DefaultValue) h.Add("numericSymbolMagnitude",NumericSymbolMagnitude);
			

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
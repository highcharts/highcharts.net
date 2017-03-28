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
			ContextButtonTitle = ContextButtonTitle_DefaultValue = "Chart context menu";
			DecimalPoint = DecimalPoint_DefaultValue = ".";
			DownloadJPEG = DownloadJPEG_DefaultValue = "Download JPEG image";
			DownloadPDF = DownloadPDF_DefaultValue = "Download PDF document";
			DownloadPNG = DownloadPNG_DefaultValue = "Download PNG image";
			DownloadSVG = DownloadSVG_DefaultValue = "Download SVG vector image";
			DrillUpText = DrillUpText_DefaultValue = "Back to {series.name}";
			InvalidDate = InvalidDate_DefaultValue = "";
			Loading = Loading_DefaultValue = "Loading...";
			Months = Months_DefaultValue = new List<string> {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
			NoData = NoData_DefaultValue = "No data to display";
			NumericSymbolMagnitude = NumericSymbolMagnitude_DefaultValue = 1000;
			NumericSymbols = NumericSymbols_DefaultValue = new List<string> { "k" , "M" , "G" , "T" , "P" , "E"};
			PrintChart = PrintChart_DefaultValue = "Print chart";
			ResetZoom = ResetZoom_DefaultValue = "Reset zoom";
			ResetZoomTitle = ResetZoomTitle_DefaultValue = "Reset zoom level 1:1";
			ShortMonths = ShortMonths_DefaultValue = new List<string> {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul",  "Aug", "Sep", "Oct", "Nov", "Dec"};
			ShortWeekdays = ShortWeekdays_DefaultValue = null;
			ThousandsSep = ThousandsSep_DefaultValue = " ";
			Weekdays = Weekdays_DefaultValue = new List<string> {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
			
		}	
		

		/// <summary>
		/// Exporting module menu. The tooltip title for the context menu holding print and export menu items.
		/// </summary>
		public string ContextButtonTitle { get; set; }
		private string ContextButtonTitle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The default decimal point used in the <code>Highcharts.numberFormat</code> method unless otherwise specified in the function arguments.
		/// </summary>
		public string DecimalPoint { get; set; }
		private string DecimalPoint_DefaultValue { get; set; }
		 

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
		/// The text for the button that appears when drilling down, linking back to the parent series. The parent series' name is inserted for <code>{series.name}</code>.
		/// </summary>
		public string DrillUpText { get; set; }
		private string DrillUpText_DefaultValue { get; set; }
		 

		/// <summary>
		/// What to show in a date field for invalid dates. Defaults to an empty string.
		/// </summary>
		public string InvalidDate { get; set; }
		private string InvalidDate_DefaultValue { get; set; }
		 

		/// <summary>
		/// The loading text that appears when the chart is set into the loading state following a call to <code>chart.showLoading</code>.
		/// </summary>
		public string Loading { get; set; }
		private string Loading_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array containing the months names. Corresponds to the  <code>%B</code> format in <code>Highcharts.dateFormat()</code>.
		/// </summary>
		public List<string> Months { get; set; }
		private List<string> Months_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text to display when the chart contains no data. Requires the no-data module, see <a href="#noData">noData</a>.
		/// </summary>
		public string NoData { get; set; }
		private string NoData_DefaultValue { get; set; }
		 

		/// <summary>
		/// The magnitude of <a href="#lang.numericSymbol">numericSymbols</a> replacements. Use 10000 for Japanese, Korean and various Chinese locales, which use symbols for 10^4, 10^8 and 10^12.
		/// </summary>
		public double? NumericSymbolMagnitude { get; set; }
		private double? NumericSymbolMagnitude_DefaultValue { get; set; }
		 

		/// <summary>
		/// <a href="http://en.wikipedia.org/wiki/Metric_prefix">Metric prefixes</a> used to shorten high numbers in axis labels. Replacing any of the positions with <code>null</code> causes the full number to be written. Setting <code>numericSymbols</code> to <code>null</code> disables shortening altogether.
		/// </summary>
		public List<string> NumericSymbols { get; set; }
		private List<string> NumericSymbols_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exporting module only. The text for the menu item to print the chart.
		/// </summary>
		public string PrintChart { get; set; }
		private string PrintChart_DefaultValue { get; set; }
		 

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
		/// An array containing the months names in abbreviated form. Corresponds to the  <code>%b</code> format in <code>Highcharts.dateFormat()</code>. 
		/// </summary>
		public List<string> ShortMonths { get; set; }
		private List<string> ShortMonths_DefaultValue { get; set; }
		 

		/// <summary>
		/// Short week days, starting Sunday. If not specified, Highcharts uses the first three letters of the <code>lang.weekdays</code> option.
		/// </summary>
		public List<string> ShortWeekdays { get; set; }
		private List<string> ShortWeekdays_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The default thousands separator used in the <code>Highcharts.numberFormat</code> method unless otherwise specified in the function arguments. Since Highcharts 4.1 it defaults to a single space character, which is compatible with ISO and works across Anglo-American and continental European languages.</p><p>The default is a single space.</p>
		/// </summary>
		public string ThousandsSep { get; set; }
		private string ThousandsSep_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array containing the weekday names. 
		/// </summary>
		public List<string> Weekdays { get; set; }
		private List<string> Weekdays_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ContextButtonTitle != ContextButtonTitle_DefaultValue) h.Add("contextButtonTitle",ContextButtonTitle);
			if (DecimalPoint != DecimalPoint_DefaultValue) h.Add("decimalPoint",DecimalPoint);
			if (DownloadJPEG != DownloadJPEG_DefaultValue) h.Add("downloadJPEG",DownloadJPEG);
			if (DownloadPDF != DownloadPDF_DefaultValue) h.Add("downloadPDF",DownloadPDF);
			if (DownloadPNG != DownloadPNG_DefaultValue) h.Add("downloadPNG",DownloadPNG);
			if (DownloadSVG != DownloadSVG_DefaultValue) h.Add("downloadSVG",DownloadSVG);
			if (DrillUpText != DrillUpText_DefaultValue) h.Add("drillUpText",DrillUpText);
			if (InvalidDate != InvalidDate_DefaultValue) h.Add("invalidDate",InvalidDate);
			if (Loading != Loading_DefaultValue) h.Add("loading",Loading);
			if (Months != Months_DefaultValue) h.Add("months",Months);
			if (NoData != NoData_DefaultValue) h.Add("noData",NoData);
			if (NumericSymbolMagnitude != NumericSymbolMagnitude_DefaultValue) h.Add("numericSymbolMagnitude",NumericSymbolMagnitude);
			if (NumericSymbols != NumericSymbols_DefaultValue) h.Add("numericSymbols",NumericSymbols);
			if (PrintChart != PrintChart_DefaultValue) h.Add("printChart",PrintChart);
			if (ResetZoom != ResetZoom_DefaultValue) h.Add("resetZoom",ResetZoom);
			if (ResetZoomTitle != ResetZoomTitle_DefaultValue) h.Add("resetZoomTitle",ResetZoomTitle);
			if (ShortMonths != ShortMonths_DefaultValue) h.Add("shortMonths",ShortMonths);
			if (ShortWeekdays != ShortWeekdays_DefaultValue) h.Add("shortWeekdays",ShortWeekdays);
			if (ThousandsSep != ThousandsSep_DefaultValue) h.Add("thousandsSep",ThousandsSep);
			if (Weekdays != Weekdays_DefaultValue) h.Add("weekdays",Weekdays);
			

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
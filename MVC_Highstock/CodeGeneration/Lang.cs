using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highstock.Web.Mvc
{
	public partial class Lang  : BaseObject
	{
		public Lang()
		{
			ContextButtonTitle = ContextButtonTitle_DefaultValue = "Chart context menu";
			DecimalPoint = DecimalPoint_DefaultValue = "'.'";
			DownloadJPEG = DownloadJPEG_DefaultValue = "'Download JPEG image'";
			DownloadPDF = DownloadPDF_DefaultValue = "'Download PDF document'";
			DownloadPNG = DownloadPNG_DefaultValue = "'Download PNG image'";
			DownloadSVG = DownloadSVG_DefaultValue = "'Download SVG vector image'";
			Loading = Loading_DefaultValue = "Loading...";
			Months = Months_DefaultValue = new List<string> {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
			NumericSymbols = NumericSymbols_DefaultValue = new List<string> { "k" , "M" , "G" , "T" , "P" , "E"};
			PrintChart = PrintChart_DefaultValue = "Print chart";
			RangeSelectorFrom = RangeSelectorFrom_DefaultValue = "From";
			RangeSelectorTo = RangeSelectorTo_DefaultValue = "To";
			RangeSelectorZoom = RangeSelectorZoom_DefaultValue = "Zoom";
			ResetZoom = ResetZoom_DefaultValue = "Reset zoom";
			ResetZoomTitle = ResetZoomTitle_DefaultValue = "Reset zoom level 1:1";
			ShortMonths = ShortMonths_DefaultValue = new List<string> {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul",  "Aug", "Sep", "Oct", "Nov", "Dec"};
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
		/// The loading text that appears when the chart is set into the loading state following a call to <code>chart.showLoading</code>.
		/// </summary>
		public string Loading { get; set; }
		private string Loading_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array containing the months names. Defaults to <code>['January', 'February', 'March', 'April', 'May', 'June', 'July',  'August', 'September', 'October', 'November', 'December']</code>.
		/// </summary>
		public List<string> Months { get; set; }
		private List<string> Months_DefaultValue { get; set; }
		 

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
		/// The text for the label for the "from" input box in the range selector.
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
		/// An array containing the months names in abbreviated form. Corresponds to the  <code>%b</code> format in <code>Highcharts.dateFormat()</code>. 
		/// </summary>
		public List<string> ShortMonths { get; set; }
		private List<string> ShortMonths_DefaultValue { get; set; }
		 

		/// <summary>
		/// The default thousands separator used in the <code>Highcharts.numberFormat</code> method unless otherwise specified in the function arguments. Since Highcharts 4.1 it defaults to a single space character, which is compatible with ISO and works across Anglo-American and continental European languages.
		/// </summary>
		public string ThousandsSep { get; set; }
		private string ThousandsSep_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array containing the weekday names. Defaults to <code>['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday']</code>.
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
			if (Loading != Loading_DefaultValue) h.Add("loading",Loading);
			if (Months != Months_DefaultValue) h.Add("months",Months);
			if (NumericSymbols != NumericSymbols_DefaultValue) h.Add("numericSymbols",NumericSymbols);
			if (PrintChart != PrintChart_DefaultValue) h.Add("printChart",PrintChart);
			if (RangeSelectorFrom != RangeSelectorFrom_DefaultValue) h.Add("rangeSelectorFrom",RangeSelectorFrom);
			if (RangeSelectorTo != RangeSelectorTo_DefaultValue) h.Add("rangeSelectorTo",RangeSelectorTo);
			if (RangeSelectorZoom != RangeSelectorZoom_DefaultValue) h.Add("rangeSelectorZoom",RangeSelectorZoom);
			if (ResetZoom != ResetZoom_DefaultValue) h.Add("resetZoom",ResetZoom);
			if (ResetZoomTitle != ResetZoomTitle_DefaultValue) h.Add("resetZoomTitle",ResetZoomTitle);
			if (ShortMonths != ShortMonths_DefaultValue) h.Add("shortMonths",ShortMonths);
			if (ThousandsSep != ThousandsSep_DefaultValue) h.Add("thousandsSep",ThousandsSep);
			if (Weekdays != Weekdays_DefaultValue) h.Add("weekdays",Weekdays);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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
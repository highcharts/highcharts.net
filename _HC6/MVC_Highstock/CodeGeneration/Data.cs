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
	public partial class Data  : BaseObject
	{
		public Data()
		{
			BeforeParse = BeforeParse_DefaultValue = "";
			Columns = Columns_DefaultValue = new List<List<Object>>();
			ColumnsURL = ColumnsURL_DefaultValue = "";
			Complete = Complete_DefaultValue = "";
			Csv = Csv_DefaultValue = "";
			CsvURL = CsvURL_DefaultValue = "";
			DataRefreshRate = DataRefreshRate_DefaultValue = 1;
			DateFormat = DateFormat_DefaultValue = "";
			DecimalPoint = DecimalPoint_DefaultValue = ".";
			EnablePolling = EnablePolling_DefaultValue = false;
			EndColumn = EndColumn_DefaultValue = null;
			EndRow = EndRow_DefaultValue = null;
			FirstRowAsNames = FirstRowAsNames_DefaultValue = true;
			GoogleSpreadsheetKey = GoogleSpreadsheetKey_DefaultValue = "";
			GoogleSpreadsheetWorksheet = GoogleSpreadsheetWorksheet_DefaultValue = "";
			ItemDelimiter = ItemDelimiter_DefaultValue = "";
			LineDelimiter = LineDelimiter_DefaultValue = "\n";
			Parsed = Parsed_DefaultValue = "";
			ParseDate = ParseDate_DefaultValue = "";
			Rows = Rows_DefaultValue = new List<List<object>>();
			RowsURL = RowsURL_DefaultValue = "";
			SeriesMapping = SeriesMapping_DefaultValue = new List<object>();
			StartColumn = StartColumn_DefaultValue = 0;
			StartRow = StartRow_DefaultValue = 0;
			SwitchRowsAndColumns = SwitchRowsAndColumns_DefaultValue = false;
			Table = Table_DefaultValue = "null";
			
		}	
		

		/// <summary>
		/// A callback function to modify the CSV before parsing it. Return the modifiedstring.
		/// </summary>
		public string BeforeParse { get; set; }
		private string BeforeParse_DefaultValue { get; set; }
		 

		/// <summary>
		/// A two-dimensional array representing the input data on tabular form.This input can be used when the data is already parsed, for examplefrom a grid view component. Each cell can be a string or number.If not switchRowsAndColumns is set, the columns are interpreted asseries.
		/// </summary>
		public List<List<object>> Columns { get; set; }
		private List<List<object>> Columns_DefaultValue { get; set; }
		 

		/// <summary>
		/// A URL to a remote JSON dataset, structured as a column array.Will be fetched when the chart is created using Ajax.
		/// </summary>
		public string ColumnsURL { get; set; }
		private string ColumnsURL_DefaultValue { get; set; }
		 

		/// <summary>
		/// The callback that is evaluated when the data is finished loading,optionally from an external source, and parsed. The first argumentpassed is a finished chart options object, containing the series.These options can be extended with additional options and passeddirectly to the chart constructor.
		/// </summary>
		public string Complete { get; set; }
		private string Complete_DefaultValue { get; set; }
		 

		/// <summary>
		/// A comma delimited string to be parsed. Related options are [startRow](#data.startRow), [endRow](#data.endRow), [startColumn](#data.startColumn)and [endColumn](#data.endColumn) to delimit what part of the tableis used. The [lineDelimiter](#data.lineDelimiter) and [itemDelimiter](#data.itemDelimiter) options define the CSV delimiter formats.The built-in CSV parser doesn't support all flavours of CSV, so insome cases it may be necessary to use an external CSV parser. See[this example](http://jsfiddle.net/highcharts/u59176h4/) of parsingCSV through the MIT licensed [Papa Parse](http://papaparse.com/)library.
		/// </summary>
		public string Csv { get; set; }
		private string Csv_DefaultValue { get; set; }
		 

		/// <summary>
		/// A URL to a remote CSV dataset.Will be fetched when the chart is created using Ajax.
		/// </summary>
		public string CsvURL { get; set; }
		private string CsvURL_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sets the refresh rate for data polling when importing remote dataset bysetting [data.csvURL](data.csvURL), [data.rowsURL](data.rowsURL),[data.columnsURL](data.columnsURL), or[data.googleSpreadsheetKey](data.googleSpreadsheetKey).Note that polling must be enabled by setting[data.enablePolling](data.enablePolling) to true.The value is the number of seconds between pollings.It cannot be set to less than 1 second.
		/// </summary>
		public double? DataRefreshRate { get; set; }
		private double? DataRefreshRate_DefaultValue { get; set; }
		 

		/// <summary>
		/// Which of the predefined date formats in Date.prototype.dateFormatsto use to parse date values. Defaults to a best guess based on whatformat gives valid and ordered dates.Valid options include:*   `YYYY/mm/dd`*   `dd/mm/YYYY`*   `mm/dd/YYYY`*   `dd/mm/YY`*   `mm/dd/YY`
		/// </summary>
		public string DateFormat { get; set; }
		private string DateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The decimal point used for parsing numbers in the CSV.If both this and data.delimiter is set to false, the parser willattempt to deduce the decimal point automatically.
		/// </summary>
		public string DecimalPoint { get; set; }
		private string DecimalPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables automatic refetching of remote datasets every _n_ seconds (defined bysetting [data.dataRefreshRate](data.dataRefreshRate)).Only works when either [data.csvURL](data.csvURL),[data.rowsURL](data.rowsURL), [data.columnsURL](data.columnsURL), or[data.googleSpreadsheetKey](data.googleSpreadsheetKey).
		/// </summary>
		public bool? EnablePolling { get; set; }
		private bool? EnablePolling_DefaultValue { get; set; }
		 

		/// <summary>
		/// In tabular input data, the last column (indexed by 0) to use. Defaultsto the last column containing data.
		/// </summary>
		public double? EndColumn { get; set; }
		private double? EndColumn_DefaultValue { get; set; }
		 

		/// <summary>
		/// In tabular input data, the last row (indexed by 0) to use. Defaultsto the last row containing data.
		/// </summary>
		public double? EndRow { get; set; }
		private double? EndRow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to use the first row in the data set as series names.
		/// </summary>
		public bool? FirstRowAsNames { get; set; }
		private bool? FirstRowAsNames_DefaultValue { get; set; }
		 

		/// <summary>
		/// The key for a Google Spreadsheet to load. See [general informationon GS](https://developers.google.com/gdata/samples/spreadsheet_sample).
		/// </summary>
		public string GoogleSpreadsheetKey { get; set; }
		private string GoogleSpreadsheetKey_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Google Spreadsheet worksheet to use in combination with[googleSpreadsheetKey](#data.googleSpreadsheetKey). The available id's fromyour sheet can be read from `https://spreadsheets.google.com/feeds/worksheets/{key}/public/basic`.
		/// </summary>
		public string GoogleSpreadsheetWorksheet { get; set; }
		private string GoogleSpreadsheetWorksheet_DefaultValue { get; set; }
		 

		/// <summary>
		/// Item or cell delimiter for parsing CSV. Defaults to the tab character`\t` if a tab character is found in the CSV string, if not it defaultsto `,`.If this is set to false or undefined, the parser will attempt to deducethe delimiter automatically.
		/// </summary>
		public string ItemDelimiter { get; set; }
		private string ItemDelimiter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Line delimiter for parsing CSV.
		/// </summary>
		public string LineDelimiter { get; set; }
		private string LineDelimiter_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function to access the parsed columns, the two-dimentionalinput data array directly, before they are interpreted into seriesdata and categories. Return `false` to stop completion, or call`this.complete()` to continue async.
		/// </summary>
		public string Parsed { get; set; }
		private string Parsed_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function to parse string representations of dates intoJavaScript timestamps. Should return an integer timestamp on success.
		/// </summary>
		public string ParseDate { get; set; }
		private string ParseDate_DefaultValue { get; set; }
		 

		/// <summary>
		/// The same as the columns input option, but defining rows intead ofcolumns.
		/// </summary>
		public List<List<object>> Rows { get; set; }
		private List<List<object>> Rows_DefaultValue { get; set; }
		 

		/// <summary>
		/// A URL to a remote JSON dataset, structured as a row array.Will be fetched when the chart is created using Ajax.
		/// </summary>
		public string RowsURL { get; set; }
		private string RowsURL_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array containing object with Point property names along with whatcolumn id the property should be taken from.
		/// </summary>
		public List<object> SeriesMapping { get; set; }
		private List<object> SeriesMapping_DefaultValue { get; set; }
		 

		/// <summary>
		/// In tabular input data, the first column (indexed by 0) to use.
		/// </summary>
		public double? StartColumn { get; set; }
		private double? StartColumn_DefaultValue { get; set; }
		 

		/// <summary>
		/// In tabular input data, the first row (indexed by 0) to use.
		/// </summary>
		public double? StartRow { get; set; }
		private double? StartRow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Switch rows and columns of the input data, so that `this.columns`effectively becomes the rows of the data set, and the rows are interpretedas series.
		/// </summary>
		public bool? SwitchRowsAndColumns { get; set; }
		private bool? SwitchRowsAndColumns_DefaultValue { get; set; }
		 

		/// <summary>
		/// A HTML table or the id of such to be parsed as input data. Relatedoptions are `startRow`, `endRow`, `startColumn` and `endColumn` todelimit what part of the table is used.
		/// </summary>
		public string Table { get; set; }
		private string Table_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BeforeParse != BeforeParse_DefaultValue) { h.Add("beforeParse",BeforeParse); Highstock.AddFunction("DataBeforeParse.beforeParse", BeforeParse); }  
			if (Columns != Columns_DefaultValue) h.Add("columns",Columns);
			if (ColumnsURL != ColumnsURL_DefaultValue) h.Add("columnsURL",ColumnsURL);
			if (Complete != Complete_DefaultValue) { h.Add("complete",Complete); Highstock.AddFunction("DataComplete.complete", Complete); }  
			if (Csv != Csv_DefaultValue) h.Add("csv",Csv);
			if (CsvURL != CsvURL_DefaultValue) h.Add("csvURL",CsvURL);
			if (DataRefreshRate != DataRefreshRate_DefaultValue) h.Add("dataRefreshRate",DataRefreshRate);
			if (DateFormat != DateFormat_DefaultValue) h.Add("dateFormat",DateFormat);
			if (DecimalPoint != DecimalPoint_DefaultValue) h.Add("decimalPoint",DecimalPoint);
			if (EnablePolling != EnablePolling_DefaultValue) h.Add("enablePolling",EnablePolling);
			if (EndColumn != EndColumn_DefaultValue) h.Add("endColumn",EndColumn);
			if (EndRow != EndRow_DefaultValue) h.Add("endRow",EndRow);
			if (FirstRowAsNames != FirstRowAsNames_DefaultValue) h.Add("firstRowAsNames",FirstRowAsNames);
			if (GoogleSpreadsheetKey != GoogleSpreadsheetKey_DefaultValue) h.Add("googleSpreadsheetKey",GoogleSpreadsheetKey);
			if (GoogleSpreadsheetWorksheet != GoogleSpreadsheetWorksheet_DefaultValue) h.Add("googleSpreadsheetWorksheet",GoogleSpreadsheetWorksheet);
			if (ItemDelimiter != ItemDelimiter_DefaultValue) h.Add("itemDelimiter",ItemDelimiter);
			if (LineDelimiter != LineDelimiter_DefaultValue) h.Add("lineDelimiter",LineDelimiter);
			if (Parsed != Parsed_DefaultValue) { h.Add("parsed",Parsed); Highstock.AddFunction("DataParsed.parsed", Parsed); }  
			if (ParseDate != ParseDate_DefaultValue) { h.Add("parseDate",ParseDate); Highstock.AddFunction("DataParseDate.parseDate", ParseDate); }  
			if (Rows != Rows_DefaultValue) h.Add("rows",Rows);
			if (RowsURL != RowsURL_DefaultValue) h.Add("rowsURL",RowsURL);
			if (SeriesMapping != SeriesMapping_DefaultValue) h.Add("seriesMapping",SeriesMapping);
			if (StartColumn != StartColumn_DefaultValue) h.Add("startColumn",StartColumn);
			if (StartRow != StartRow_DefaultValue) h.Add("startRow",StartRow);
			if (SwitchRowsAndColumns != SwitchRowsAndColumns_DefaultValue) h.Add("switchRowsAndColumns",SwitchRowsAndColumns);
			if (Table != Table_DefaultValue) h.Add("table",Table);
			

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
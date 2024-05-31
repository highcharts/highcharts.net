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
	public partial class Data  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Data()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// A callback function to modify the CSV before parsing it. Return the modifiedstring.
		/// </summary>
		public string BeforeParse { get; set; }
		 

		/// <summary>
		/// A two-dimensional array representing the input data on tabular form.This input can be used when the data is already parsed, for examplefrom a grid view component. Each cell can be a string or number.If not switchRowsAndColumns is set, the columns are interpreted asseries.
		/// </summary>
		public List<List<string>> Columns { get; set; }
		 

		/// <summary>
		/// A URL to a remote JSON dataset, structured as a column array.Will be fetched when the chart is created using Ajax.
		/// </summary>
		public string ColumnsURL { get; set; }
		 

		/// <summary>
		/// An array option that specifies the data type for each column in the seriesloaded within the data module.Possible values: `"string"`, `"number"`, `"float"`, `"date"`.
		/// </summary>
		public DataColumnTypes ColumnTypes { get; set; }
		 

		/// <summary>
		/// The callback that is evaluated when the data is finished loading,optionally from an external source, and parsed. The first argumentpassed is a finished chart options object, containing the series.These options can be extended with additional options and passeddirectly to the chart constructor.
		/// </summary>
		public string Complete { get; set; }
		 

		/// <summary>
		/// A comma delimited string to be parsed. Related options are [startRow](#data.startRow), [endRow](#data.endRow), [startColumn](#data.startColumn)and [endColumn](#data.endColumn) to delimit what part of the tableis used. The [lineDelimiter](#data.lineDelimiter) and [itemDelimiter](#data.itemDelimiter) options define the CSV delimiter formats.The built-in CSV parser doesn't support all flavours of CSV, so insome cases it may be necessary to use an external CSV parser. See[this example](https://jsfiddle.net/highcharts/u59176h4/) of parsingCSV through the MIT licensed [Papa Parse](http://papaparse.com/)library.
		/// </summary>
		public string Csv { get; set; }
		 

		/// <summary>
		/// An URL to a remote CSV dataset. Will be fetched when the chart is createdusing Ajax.
		/// </summary>
		public string CsvURL { get; set; }
		 

		/// <summary>
		/// Sets the refresh rate for data polling when importing remote dataset bysetting [data.csvURL](data.csvURL), [data.rowsURL](data.rowsURL),[data.columnsURL](data.columnsURL), or[data.googleSpreadsheetKey](data.googleSpreadsheetKey).Note that polling must be enabled by setting[data.enablePolling](data.enablePolling) to true.The value is the number of seconds between pollings.It cannot be set to less than 1 second.
		/// </summary>
		public double? DataRefreshRate { get; set; }
		 

		/// <summary>
		/// Which of the predefined date formats in Date.prototype.dateFormatsto use to parse date values. Defaults to a best guess based on whatformat gives valid and ordered dates. Valid options include: `YYYY/mm/dd`,`dd/mm/YYYY`, `mm/dd/YYYY`, `dd/mm/YY`, `mm/dd/YY`.
		/// </summary>
		public string DateFormat { get; set; }
		 

		/// <summary>
		/// The decimal point used for parsing numbers in the CSV.If both this and data.delimiter is set to `undefined`, the parser willattempt to deduce the decimal point automatically.
		/// </summary>
		public string DecimalPoint { get; set; }
		 

		/// <summary>
		/// Enables automatic refetching of remote datasets every _n_ seconds (defined bysetting [data.dataRefreshRate](data.dataRefreshRate)).Only works when either [data.csvURL](data.csvURL),[data.rowsURL](data.rowsURL), [data.columnsURL](data.columnsURL), or[data.googleSpreadsheetKey](data.googleSpreadsheetKey).
		/// </summary>
		public bool? EnablePolling { get; set; }
		 

		/// <summary>
		/// In tabular input data, the last column (indexed by 0) to use. Defaultsto the last column containing data.
		/// </summary>
		public double? EndColumn { get; set; }
		 

		/// <summary>
		/// In tabular input data, the last row (indexed by 0) to use. Defaultsto the last row containing data.
		/// </summary>
		public double? EndRow { get; set; }
		 

		/// <summary>
		/// Whether to use the first row in the data set as series names.
		/// </summary>
		public bool? FirstRowAsNames { get; set; }
		 

		/// <summary>
		/// The Google Spreadsheet API key required for access generated at [API Services/ Credentials](https://console.cloud.google.com/apis/credentials). See acomprehensive tutorial for setting up the key at the[Hands-On Data Visualization](https://handsondataviz.org/google-sheets-api-key.html)book website.
		/// </summary>
		public string GoogleAPIKey { get; set; }
		 

		/// <summary>
		/// The key or `spreadsheetId` value for a Google Spreadsheet to load. See[developers.google.com](https://developers.google.com/sheets/api/guides/concepts)for how to find the `spreadsheetId`.In order for Google Sheets to load, a valid [googleAPIKey](#data.googleAPIKey)must also be given.
		/// </summary>
		public string GoogleSpreadsheetKey { get; set; }
		 

		/// <summary>
		/// The Google Spreadsheet `range` to use in combination with[googleSpreadsheetKey](#data.googleSpreadsheetKey). See[developers.google.com](https://developers.google.com/sheets/api/reference/rest/v4/spreadsheets.values/get)for details.If given, it takes precedence over `startColumn`, `endColumn`, `startRow` and`endRow`.
		/// </summary>
		public string GoogleSpreadsheetRange { get; set; }
		 

		/// <summary>
		/// No longer works since v9.2.2, that uses Google Sheets API v4. Instead, usethe [googleSpreadsheetRange](#data.googleSpreadsheetRange) option to load aspecific sheet.
		/// </summary>
		public string GoogleSpreadsheetWorksheet { get; set; }
		 

		/// <summary>
		/// Item or cell delimiter for parsing CSV. Defaults to the tab character`\t` if a tab character is found in the CSV string, if not it defaultsto `,`.If this is set to false or undefined, the parser will attempt to deducethe delimiter automatically.
		/// </summary>
		public string ItemDelimiter { get; set; }
		 

		/// <summary>
		/// Line delimiter for parsing CSV.
		/// </summary>
		public string LineDelimiter { get; set; }
		 

		/// <summary>
		/// A callback function to access the parsed columns, the two-dimensionalinput data array directly, before they are interpreted into seriesdata and categories. Return `false` to stop completion, or call`this.complete()` to continue async.
		/// </summary>
		public string Parsed { get; set; }
		 

		/// <summary>
		/// A callback function to parse string representations of dates intoJavaScript timestamps. Should return an integer timestamp on success.
		/// </summary>
		public string ParseDate { get; set; }
		 

		/// <summary>
		/// The same as the columns input option, but defining rows instead ofcolumns.
		/// </summary>
		public List<List<string>> Rows { get; set; }
		 

		/// <summary>
		/// A URL to a remote JSON dataset, structured as a row array.Will be fetched when the chart is created using Ajax.
		/// </summary>
		public string RowsURL { get; set; }
		 

		/// <summary>
		/// An array containing dictionaries for each series. A dictionary exists ofPoint property names as the key and the CSV column index as the value.
		/// </summary>
		public List<List<double?>> SeriesMapping { get; set; }
		 

		/// <summary>
		/// In tabular input data, the first column (indexed by 0) to use.
		/// </summary>
		public double? StartColumn { get; set; }
		 

		/// <summary>
		/// In tabular input data, the first row (indexed by 0) to use.
		/// </summary>
		public double? StartRow { get; set; }
		 

		/// <summary>
		/// Switch rows and columns of the input data, so that `this.columns`effectively becomes the rows of the data set, and the rows are interpretedas series.
		/// </summary>
		public bool? SwitchRowsAndColumns { get; set; }
		 

		/// <summary>
		/// An HTML table or the id of such to be parsed as input data. Relatedoptions are `startRow`, `endRow`, `startColumn` and `endColumn` todelimit what part of the table is used.
		/// </summary>
		public string Table { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (BeforeParse != null) { h.Add("beforeParse",BeforeParse); highcharts.AddFunction("beforeParse", BeforeParse); }  
			if (Columns != null) h.Add("columns",Columns);
			if (ColumnsURL != null) h.Add("columnsURL",ColumnsURL);
			if (ColumnTypes != null) h.Add("columnTypes",ColumnTypes);
			if (Complete != null) { h.Add("complete",Complete); highcharts.AddFunction("complete", Complete); }  
			if (Csv != null) h.Add("csv",Csv);
			if (CsvURL != null) h.Add("csvURL",CsvURL);
			if (DataRefreshRate != null) h.Add("dataRefreshRate",DataRefreshRate);
			if (DateFormat != null) h.Add("dateFormat",DateFormat);
			if (DecimalPoint != null) h.Add("decimalPoint",DecimalPoint);
			if (EnablePolling != null) h.Add("enablePolling",EnablePolling);
			if (EndColumn != null) h.Add("endColumn",EndColumn);
			if (EndRow != null) h.Add("endRow",EndRow);
			if (FirstRowAsNames != null) h.Add("firstRowAsNames",FirstRowAsNames);
			if (GoogleAPIKey != null) h.Add("googleAPIKey",GoogleAPIKey);
			if (GoogleSpreadsheetKey != null) h.Add("googleSpreadsheetKey",GoogleSpreadsheetKey);
			if (GoogleSpreadsheetRange != null) h.Add("googleSpreadsheetRange",GoogleSpreadsheetRange);
			if (GoogleSpreadsheetWorksheet != null) h.Add("googleSpreadsheetWorksheet",GoogleSpreadsheetWorksheet);
			if (ItemDelimiter != null) h.Add("itemDelimiter",ItemDelimiter);
			if (LineDelimiter != null) h.Add("lineDelimiter",LineDelimiter);
			if (Parsed != null) { h.Add("parsed",Parsed); highcharts.AddFunction("parsed", Parsed); }  
			if (ParseDate != null) { h.Add("parseDate",ParseDate); highcharts.AddFunction("parseDate", ParseDate); }  
			if (Rows != null) h.Add("rows",Rows);
			if (RowsURL != null) h.Add("rowsURL",RowsURL);
			if (SeriesMapping != null) h.Add("seriesMapping",SeriesMapping);
			if (StartColumn != null) h.Add("startColumn",StartColumn);
			if (StartRow != null) h.Add("startRow",StartRow);
			if (SwitchRowsAndColumns != null) h.Add("switchRowsAndColumns",SwitchRowsAndColumns);
			if (Table != null) h.Add("table",Table);
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
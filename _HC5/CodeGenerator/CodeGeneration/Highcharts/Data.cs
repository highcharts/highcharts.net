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
	public partial class Data  : BaseObject
	{
		public Data()
		{
			Columns = Columns_DefaultValue = new List<List<Object>>();
			Complete = Complete_DefaultValue = "";
			Csv = Csv_DefaultValue = null;
			DateFormat = DateFormat_DefaultValue = null;
			DecimalPoint = DecimalPoint_DefaultValue = ".";
			EndColumn = EndColumn_DefaultValue = null;
			EndRow = EndRow_DefaultValue = null;
			FirstRowAsNames = FirstRowAsNames_DefaultValue = true;
			GoogleSpreadsheetKey = GoogleSpreadsheetKey_DefaultValue = "";
			GoogleSpreadsheetWorksheet = GoogleSpreadsheetWorksheet_DefaultValue = null;
			ItemDelimiter = ItemDelimiter_DefaultValue = "";
			LineDelimiter = LineDelimiter_DefaultValue = "\n";
			ParseDate = ParseDate_DefaultValue = "";
			Parsed = Parsed_DefaultValue = "";
			Rows = Rows_DefaultValue = new List<List<object>>();
			SeriesMapping = SeriesMapping_DefaultValue = new List<object>();
			StartColumn = StartColumn_DefaultValue = 0;
			StartRow = StartRow_DefaultValue = 0;
			SwitchRowsAndColumns = SwitchRowsAndColumns_DefaultValue = false;
			Table = Table_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// A two-dimensional array representing the input data on tabular form. This input can be used when the data is already parsed, for example from a grid view component. Each cell can be a string or number. If not switchRowsAndColumns is set, the columns are interpreted as series.
		/// </summary>
		public List<List<object>> Columns { get; set; }
		private List<List<object>> Columns_DefaultValue { get; set; }
		 

		/// <summary>
		/// The callback that is evaluated when the data is finished loading, optionally from an external source, and parsed. The first argument passed is a finished chart options object, containing the series. These options can be extended with additional options and passed directly to the chart constructor.
		/// </summary>
		public string Complete { get; set; }
		private string Complete_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A comma delimited string to be parsed. Related options are <a href="#data.startRow">startRow</a>, <a href="#data.endRow">endRow</a>, <a href="#data.startColumn">startColumn</a> and <a href="#data.endColumn">endColumn</a> to delimit what part of the table is used. The <a href="#data.lineDelimiter">lineDelimiter</a> and <a href="#data.itemDelimiter">itemDelimiter</a> options define the CSV delimiter formats.</p><p>The built-in CSV parser doesn't support all flavours of CSV, so in some cases it may be necessary to use an external CSV parser. See <a href="http://jsfiddle.net/highcharts/u59176h4/">this example</a> of parsing CSV through the MIT licensed <a href="http://papaparse.com/">Papa Parse</a> library.</p>
		/// </summary>
		public string Csv { get; set; }
		private string Csv_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Which of the predefined date formats in Date.prototype.dateFormats to use to parse date values. Defaults to a best guess based on what format gives valid and ordered dates.</p><p>Valid options include:<ul><li><code>YYYY-mm-dd</code></li><li><code>dd/mm/YYYY</code></li><li><code>mm/dd/YYYY</code></li><li><code>dd/mm/YY</code></li><li><code>mm/dd/YY</code></li></ul></p>
		/// </summary>
		public string DateFormat { get; set; }
		private string DateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The decimal point used for parsing numbers in the CSV.
		/// </summary>
		public string DecimalPoint { get; set; }
		private string DecimalPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// In tabular input data, the last column (indexed by 0) to use. Defaults to the last column containing data.
		/// </summary>
		public double? EndColumn { get; set; }
		private double? EndColumn_DefaultValue { get; set; }
		 

		/// <summary>
		/// In tabular input data, the last row (indexed by 0) to use. Defaults to the last row containing data.
		/// </summary>
		public double? EndRow { get; set; }
		private double? EndRow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to use the first row in the data set as series names. 
		/// </summary>
		public bool? FirstRowAsNames { get; set; }
		private bool? FirstRowAsNames_DefaultValue { get; set; }
		 

		/// <summary>
		/// The key for a Google Spreadsheet to load. See <a href="https://developers.google.com/gdata/samples/spreadsheet_sample">general information on GS</a>.
		/// </summary>
		public string GoogleSpreadsheetKey { get; set; }
		private string GoogleSpreadsheetKey_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Google Spreadsheet worksheet to use in combination with <a href="#data.googleSpreadsheetKey">googleSpreadsheetKey</a>. The available id's from your sheet can be read from <code>https://spreadsheets.google.com/feeds/worksheets/{key}/public/basic</code>
		/// </summary>
		public string GoogleSpreadsheetWorksheet { get; set; }
		private string GoogleSpreadsheetWorksheet_DefaultValue { get; set; }
		 

		/// <summary>
		/// Item or cell delimiter for parsing CSV. Defaults to the tab character <code>\t</code> if a tab character is found in the CSV string, if not it defaults to <code>,</code>.
		/// </summary>
		public string ItemDelimiter { get; set; }
		private string ItemDelimiter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Line delimiter for parsing CSV.
		/// </summary>
		public string LineDelimiter { get; set; }
		private string LineDelimiter_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function to parse string representations of dates into JavaScript timestamps. Should return an integer timestamp on success.
		/// </summary>
		public string ParseDate { get; set; }
		private string ParseDate_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function to access the parsed columns, the two-dimentional input data array directly, before they are interpreted into series data and categories. Return <code>false</code> to stop completion, or call <code>this.complete()</code> to continue async.
		/// </summary>
		public string Parsed { get; set; }
		private string Parsed_DefaultValue { get; set; }
		 

		/// <summary>
		/// The same as the columns input option, but defining rows intead of columns.
		/// </summary>
		public List<List<object>> Rows { get; set; }
		private List<List<object>> Rows_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array containing object with Point property names along with what column id the property should be taken from.
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
		/// Switch rows and columns of the input data, so that <code>this.columns</code> effectively becomes the rows of the data set, and the rows are interpreted as series.
		/// </summary>
		public bool? SwitchRowsAndColumns { get; set; }
		private bool? SwitchRowsAndColumns_DefaultValue { get; set; }
		 

		/// <summary>
		/// A HTML table or the id of such to be parsed as input data. Related options are <code>startRow</code>, <code>endRow</code>, <code>startColumn</code> and <code>endColumn</code> to delimit what part of the table is used.
		/// </summary>
		public string Table { get; set; }
		private string Table_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Columns != Columns_DefaultValue) h.Add("columns",Columns);
			if (Complete != Complete_DefaultValue) { h.Add("complete",Complete); Highcharts.AddFunction("DataComplete.complete", Complete); }  
			if (Csv != Csv_DefaultValue) h.Add("csv",Csv);
			if (DateFormat != DateFormat_DefaultValue) h.Add("dateFormat",DateFormat);
			if (DecimalPoint != DecimalPoint_DefaultValue) h.Add("decimalPoint",DecimalPoint);
			if (EndColumn != EndColumn_DefaultValue) h.Add("endColumn",EndColumn);
			if (EndRow != EndRow_DefaultValue) h.Add("endRow",EndRow);
			if (FirstRowAsNames != FirstRowAsNames_DefaultValue) h.Add("firstRowAsNames",FirstRowAsNames);
			if (GoogleSpreadsheetKey != GoogleSpreadsheetKey_DefaultValue) h.Add("googleSpreadsheetKey",GoogleSpreadsheetKey);
			if (GoogleSpreadsheetWorksheet != GoogleSpreadsheetWorksheet_DefaultValue) h.Add("googleSpreadsheetWorksheet",GoogleSpreadsheetWorksheet);
			if (ItemDelimiter != ItemDelimiter_DefaultValue) h.Add("itemDelimiter",ItemDelimiter);
			if (LineDelimiter != LineDelimiter_DefaultValue) h.Add("lineDelimiter",LineDelimiter);
			if (ParseDate != ParseDate_DefaultValue) { h.Add("parseDate",ParseDate); Highcharts.AddFunction("DataParseDate.parseDate", ParseDate); }  
			if (Parsed != Parsed_DefaultValue) { h.Add("parsed",Parsed); Highcharts.AddFunction("DataParsed.parsed", Parsed); }  
			if (Rows != Rows_DefaultValue) h.Add("rows",Rows);
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
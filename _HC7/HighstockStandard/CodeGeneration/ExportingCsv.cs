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
	public partial class ExportingCsv  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ExportingCsv()
		{
		}	
		

		/// <summary>
		/// Options for annotations in the export-data table.
		/// </summary>
		public List<Annotations> Annotations { get; set; }
		 

		/// <summary>
		/// Formatter callback for the column headers. Parameters are:- `item` - The series or axis object)- `key` -  The point key, for example y or z- `keyLength` - The amount of value keys for this item, for  example a range series has the keys `low` and `high` so the  key length is 2.If [useMultiLevelHeaders](#exporting.useMultiLevelHeaders) istrue, columnHeaderFormatter by default returns an object withcolumnTitle and topLevelColumnTitle for each key. Columns withthe same topLevelColumnTitle have their titles merged into asingle cell with colspan for table/Excel export.If `useMultiLevelHeaders` is false, or for CSV export, it returnsthe series name, followed by the key if there is more than onekey.For the axis it returns the axis title or "Category" or"DateTime" by default.Return `false` to use Highcharts' proposed header.
		/// </summary>
		public string ColumnHeaderFormatter { get; set; }
		 

		/// <summary>
		/// Which date format to use for exported dates on a datetime X axis.See `Highcharts.dateFormat`.
		/// </summary>
		public string DateFormat { get; set; }
		 

		/// <summary>
		/// Which decimal point to use for exported CSV. Defaults to the sameas the browser locale, typically `.` (English) or `,` (German,French etc).
		/// </summary>
		public string DecimalPoint { get; set; }
		 

		/// <summary>
		/// The item delimiter in the exported data. Use `;` for directexporting to Excel. Defaults to a best guess based on the browserlocale. If the locale _decimal point_ is `,`, the `itemDelimiter`defaults to `;`, otherwise the `itemDelimiter` defaults to `,`.
		/// </summary>
		public string ItemDelimiter { get; set; }
		 

		/// <summary>
		/// The line delimiter in the exported data, defaults to a newline.
		/// </summary>
		public string LineDelimiter { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Annotations != null) h.Add("annotations", HashifyList(highstock,Annotations));
			if (ColumnHeaderFormatter != null) { h.Add("columnHeaderFormatter",ColumnHeaderFormatter); highstock.AddFunction("columnHeaderFormatter", ColumnHeaderFormatter); }  
			if (DateFormat != null) h.Add("dateFormat",DateFormat);
			if (DecimalPoint != null) h.Add("decimalPoint",DecimalPoint);
			if (ItemDelimiter != null) h.Add("itemDelimiter",ItemDelimiter);
			if (LineDelimiter != null) h.Add("lineDelimiter",LineDelimiter);
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
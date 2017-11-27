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
	public partial class ExportingCsv  : BaseObject
	{
		public ExportingCsv()
		{
			ColumnHeaderFormatter = ColumnHeaderFormatter_DefaultValue = "";
			DateFormat = DateFormat_DefaultValue = %Y-%m-%d %H:%M:%S;
			ItemDelimiter = ItemDelimiter_DefaultValue = ,;
			LineDelimiter = LineDelimiter_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Formatter callback for the column headers. Parameters are:- `item` - The series or axis object)- `key` -  The point key, for example y or z- `keyLength` - The amount of value keys for this item, for  example a range series has the keys `low` and `high` so the  key length is 2.By default it returns the series name, followed by the key ifthere is more than one key. For the axis it returns the axistitle or "Category" or "DateTime" by default.Return `false` to use Highcharts' proposed header.
		/// </summary>
		public string ColumnHeaderFormatter { get; set; }
		private string ColumnHeaderFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Which date format to use for exported dates on a datetime X axis.See `Highcharts.dateFormat`.
		/// </summary>
		public ExportingCsvDateFormat DateFormat { get; set; }
		private ExportingCsvDateFormat DateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The item delimiter in the exported data. Use `;` for directexporting to Excel.
		/// </summary>
		public ExportingCsvItemDelimiter ItemDelimiter { get; set; }
		private ExportingCsvItemDelimiter ItemDelimiter_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line delimiter in the exported data, defaults to a newline.
		/// </summary>
		public ExportingCsvLineDelimiter LineDelimiter { get; set; }
		private ExportingCsvLineDelimiter LineDelimiter_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ColumnHeaderFormatter != ColumnHeaderFormatter_DefaultValue) h.Add("columnHeaderFormatter",ColumnHeaderFormatter);
			if (DateFormat != DateFormat_DefaultValue) h.Add("dateFormat",DateFormat);
			if (ItemDelimiter != ItemDelimiter_DefaultValue) h.Add("itemDelimiter",ItemDelimiter);
			if (LineDelimiter != LineDelimiter_DefaultValue) h.Add("lineDelimiter",LineDelimiter);
			

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
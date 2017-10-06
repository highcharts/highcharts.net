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
			ColumnHeaderFormatter = ColumnHeaderFormatter_DefaultValue = null;
			DateFormat = DateFormat_DefaultValue = "%Y-%m-%d %H:%M:%S";
			ItemDelimiter = ItemDelimiter_DefaultValue = ",";
			LineDelimiter = LineDelimiter_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Formatter callback for the column headers. Parameters are:</p><ul><li><code>item</code> - The series or axis object)</li><li><code>key</code> -  The point key, for example y or z</li><li><code>keyLength</code> - The amount of value keys for this item, forexample a range series has the keys <code>low</code> and <code>high</code> so thekey length is 2.</li></ul><p>By default it returns the series name, followed by the key ifthere is more than one key. For the axis it returns the axistitle or &quot;Category&quot; or &quot;DateTime&quot; by default.</p><p>Return <code>false</code> to use Highcharts&#39; proposed header.</p>
		/// </summary>
		public string ColumnHeaderFormatter { get; set; }
		private string ColumnHeaderFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Which date format to use for exported dates on a datetime X axis.See <code>Highcharts.dateFormat</code>.</p>
		/// </summary>
		public string DateFormat { get; set; }
		private string DateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The item delimiter in the exported data. Use <code>;</code> for directexporting to Excel.</p>
		/// </summary>
		public string ItemDelimiter { get; set; }
		private string ItemDelimiter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The line delimiter in the exported data, defaults to a newline.</p>
		/// </summary>
		public string LineDelimiter { get; set; }
		private string LineDelimiter_DefaultValue { get; set; }
		  

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
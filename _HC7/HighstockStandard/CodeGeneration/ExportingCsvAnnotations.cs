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
	public partial class ExportingCsvAnnotations  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ExportingCsvAnnotations()
		{
		}	
		

		/// <summary>
		/// The way to mark the separator for annotationscombined in one export-data table cell.
		/// </summary>
		public string ItemDelimiter { get; set; }
		 

		/// <summary>
		/// When several labels are assigned to a specific point,they will be displayed in one field in the table.
		/// </summary>
		public bool? Join { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ItemDelimiter != null) h.Add("itemDelimiter",ItemDelimiter);
			if (Join != null) h.Add("join",Join);
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
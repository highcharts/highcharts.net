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
	public partial class ExportingCsvAnnotations  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ExportingCsvAnnotations()
		{
			ItemDelimiter = ItemDelimiter_DefaultValue = "; ";
			Join = Join_DefaultValue = false;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The way to mark the separator for annotationscombined in one export-data table cell.
		/// </summary>
		public string ItemDelimiter { get; set; }
		private string ItemDelimiter_DefaultValue { get; set; }
		 

		/// <summary>
		/// When several labels are assigned to a specific point,they will be displayed in one field in the table.
		/// </summary>
		public bool? Join { get; set; }
		private bool? Join_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (ItemDelimiter != ItemDelimiter_DefaultValue) h.Add("itemDelimiter",ItemDelimiter);
			if (Join != Join_DefaultValue) h.Add("join",Join);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}
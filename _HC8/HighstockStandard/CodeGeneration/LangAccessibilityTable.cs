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
	public partial class LangAccessibilityTable  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityTable()
		{
			TableSummary = TableSummary_DefaultValue = "Table representation of chart.";
			ViewAsDataTableButtonText = ViewAsDataTableButtonText_DefaultValue = "View as data table, {chartTitle}";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string TableSummary { get; set; }
		private string TableSummary_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ViewAsDataTableButtonText { get; set; }
		private string ViewAsDataTableButtonText_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (TableSummary != TableSummary_DefaultValue) h.Add("tableSummary",TableSummary);
			if (ViewAsDataTableButtonText != ViewAsDataTableButtonText_DefaultValue) h.Add("viewAsDataTableButtonText",ViewAsDataTableButtonText);
			

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}
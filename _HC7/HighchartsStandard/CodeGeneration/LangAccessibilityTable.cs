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
	public partial class LangAccessibilityTable  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityTable()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string TableSummary { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ViewAsDataTableButtonText { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (TableSummary != null) h.Add("tableSummary",TableSummary);
			if (ViewAsDataTableButtonText != null) h.Add("viewAsDataTableButtonText",ViewAsDataTableButtonText);
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
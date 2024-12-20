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
	public partial class LangAccessibilityExporting  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityExporting()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string ChartMenuLabel { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MenuButtonLabel { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ChartMenuLabel != null) h.Add("chartMenuLabel",ChartMenuLabel);
			if (MenuButtonLabel != null) h.Add("menuButtonLabel",MenuButtonLabel);
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
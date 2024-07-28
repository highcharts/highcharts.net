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
	public partial class SunburstSeriesBreadcrumbsSeparator  : BaseObject
	{
		Hashtable h = new Hashtable();

		public SunburstSeriesBreadcrumbsSeparator()
		{
		}	
		

		/// <summary>
		/// CSS styles for the breadcrumbs separator.In styled mode, the breadcrumbs separators are styled by the`.highcharts-separator` rule with its different states.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Text { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Style != null) h.Add("style",Style);
			if (Text != null) h.Add("text",Text);
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
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
	public partial class ZAxisDateTimeLabelFormatsHour  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ZAxisDateTimeLabelFormatsHour()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public List<string> List { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Main { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Range { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (List != null) h.Add("list",List);
			if (Main != null) h.Add("main",Main);
			if (Range != null) h.Add("range",Range);
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
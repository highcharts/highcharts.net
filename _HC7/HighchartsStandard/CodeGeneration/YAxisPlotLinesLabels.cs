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
	public partial class YAxisPlotLinesLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public YAxisPlotLinesLabels()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Whether to hide labels that are outside the plot area.
		/// </summary>
		public bool? Clip { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Clip != null) h.Add("clip",Clip);
			if (CustomFields.Count > 0)
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
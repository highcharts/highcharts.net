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
	public partial class PlotOptionsTreegraphDataLabelsStyle  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTreegraphDataLabelsStyle()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string TextOverflow { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (TextOverflow != null) h.Add("textOverflow",TextOverflow);
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
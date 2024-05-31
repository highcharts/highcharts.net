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
	public partial class PlotOptionsXrangePartialFill  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsXrangePartialFill()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The fill color to be used for partial fills. Defaults to a darkershade of the point color.
		/// </summary>
		public string Fill { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Fill != null) h.Add("fill",Fill);
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
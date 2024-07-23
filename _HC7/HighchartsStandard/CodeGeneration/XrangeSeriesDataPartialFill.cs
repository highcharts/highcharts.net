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
	public partial class XrangeSeriesDataPartialFill  : BaseObject
	{
		Hashtable h = new Hashtable();

		public XrangeSeriesDataPartialFill()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The amount of the X-range point to be filled. Values can be 0-1 and areconverted to percentages in the default data label formatter.
		/// </summary>
		public double? Amount { get; set; }
		 

		/// <summary>
		/// The fill color to be used for partial fills. Defaults to a darker shadeof the point color.
		/// </summary>
		public string Fill { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Amount != null) h.Add("amount",Amount);
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
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
			Amount = Amount_DefaultValue = null;
			Fill = Fill_DefaultValue = "";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The amount of the X-range point to be filled. Values can be 0-1 and areconverted to percentages in the default data label formatter.
		/// </summary>
		public double? Amount { get; set; }
		private double? Amount_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color to be used for partial fills. Defaults to a darker shadeof the point color.
		/// </summary>
		public string Fill { get; set; }
		private string Fill_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Amount != Amount_DefaultValue) h.Add("amount",Amount);
			if (Fill != Fill_DefaultValue) h.Add("fill",Fill);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}
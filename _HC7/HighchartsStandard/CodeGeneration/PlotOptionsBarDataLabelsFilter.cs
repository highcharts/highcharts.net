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
	public partial class PlotOptionsBarDataLabelsFilter  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsBarDataLabelsFilter()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The operator to compare by. Can be one of `>`, `<`, `>=`, `<=`,`==`, `===`, `!=` and `!==`.
		/// </summary>
		public string Operator { get; set; }
		 

		/// <summary>
		/// The point property to filter by. Point options are passeddirectly to properties, additionally there are `y` value,`percentage` and others listed under {@link Highcharts.Point}members.
		/// </summary>
		public string Property { get; set; }
		 

		/// <summary>
		/// The value to compare against.
		/// </summary>
		public double? Value { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Operator != null) h.Add("operator",Operator);
			if (Property != null) h.Add("property",Property);
			if (Value != null) h.Add("value",Value);
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
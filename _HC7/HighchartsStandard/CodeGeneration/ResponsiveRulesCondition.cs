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
	public partial class ResponsiveRulesCondition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ResponsiveRulesCondition()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// A callback function to gain complete control on when the responsiverule applies. Return `true` if it applies. This opens for checkingagainst other metrics than the chart size, for example the documentsize or other elements.
		/// </summary>
		public string Callback { get; set; }
		 

		/// <summary>
		/// The responsive rule applies if the chart height is less than this.
		/// </summary>
		public double? MaxHeight { get; set; }
		 

		/// <summary>
		/// The responsive rule applies if the chart width is less than this.
		/// </summary>
		public double? MaxWidth { get; set; }
		 

		/// <summary>
		/// The responsive rule applies if the chart height is greater than this.
		/// </summary>
		public double? MinHeight { get; set; }
		 

		/// <summary>
		/// The responsive rule applies if the chart width is greater than this.
		/// </summary>
		public double? MinWidth { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Callback != null) { h.Add("callback",Callback); highcharts.AddFunction("callback", Callback); }  
			if (MaxHeight != null) h.Add("maxHeight",MaxHeight);
			if (MaxWidth != null) h.Add("maxWidth",MaxWidth);
			if (MinHeight != null) h.Add("minHeight",MinHeight);
			if (MinWidth != null) h.Add("minWidth",MinWidth);
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
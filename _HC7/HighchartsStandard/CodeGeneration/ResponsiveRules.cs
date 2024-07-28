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
	public partial class ResponsiveRules  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ResponsiveRules()
		{
		}	
		

		/// <summary>
		/// A full set of chart options to apply as overrides to the generalchart options. The chart options are applied when the given ruleis active.A special case is configuration objects that take arrays, for example[xAxis](#xAxis), [yAxis](#yAxis) or [series](#series). For thesecollections, an `id` option is used to map the new option set toan existing object. If an existing object of the same id is not found,the item of the same index updated. So for example, setting `chartOptions`with two series items without an `id`, will cause the existing chart'stwo series to be updated with respective options.
		/// </summary>
		public Object ChartOptions { get; set; }
		 

		/// <summary>
		/// Under which conditions the rule applies.
		/// </summary>
		public ResponsiveRulesCondition Condition { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ChartOptions != null) h.Add("chartOptions",ChartOptions);
			if (Condition != null) h.Add("condition",Condition.ToHashtable(highcharts));
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
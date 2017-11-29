using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class ResponsiveRules  : BaseObject
	{
		public ResponsiveRules()
		{
			ChartOptions = ChartOptions_DefaultValue = null;
			Condition = Condition_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// A full set of chart options to apply as overrides to the generalchart options. The chart options are applied when the given ruleis active.A special case is configuration objects that take arrays, for example[xAxis](#xAxis), [yAxis](#yAxis) or [series](#series). For thesecollections, an `id` option is used to map the new option set toan existing object. If an existing object of the same id is not found,the item of the same indexupdated. So for example, setting `chartOptions`with two series items without an `id`, will cause the existing chart'stwo series to be updated with respective options.
		/// </summary>
		public ResponsiveRulesChartOptions ChartOptions { get; set; }
		private ResponsiveRulesChartOptions ChartOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Under which conditions the rule applies.
		/// </summary>
		public ResponsiveRulesCondition Condition { get; set; }
		private ResponsiveRulesCondition Condition_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ChartOptions != ChartOptions_DefaultValue) h.Add("chartOptions",ChartOptions);
			if (Condition.IsDirty()) h.Add("condition",Condition.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}
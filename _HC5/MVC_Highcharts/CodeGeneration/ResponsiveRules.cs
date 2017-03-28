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
			ChartOptions = ChartOptions_DefaultValue = "";
			Condition = Condition_DefaultValue = new ResponsiveRulesCondition();
			
		}	
		

		/// <summary>
		/// A full set of chart options to apply as overrides to the general chart options. The chart options are applied when the given rule is active.
		/// </summary>
		public Object ChartOptions { get; set; }
		private Object ChartOptions_DefaultValue { get; set; }
		 

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
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
	public partial class PlotOptionsVectorDataLabelsFilter  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsVectorDataLabelsFilter()
		{
			Operator = Operator_DefaultValue = "";
			Property = Property_DefaultValue = "";
			Value = Value_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The operator to compare by. Can be one of `>`, `<`, `>=`, `<=`,`==`, and `===`.
		/// </summary>
		public string Operator { get; set; }
		private string Operator_DefaultValue { get; set; }
		 

		/// <summary>
		/// The point property to filter by. Point options are passeddirectly to properties, additionally there are `y` value,`percentage` and others listed under {@link Highcharts.Point}members.
		/// </summary>
		public string Property { get; set; }
		private string Property_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value to compare against.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Operator != Operator_DefaultValue) h.Add("operator",Operator);
			if (Property != Property_DefaultValue) h.Add("property",Property);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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
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
	public partial class ColumnSeriesDataLabelsFilter  : BaseObject
	{
		public ColumnSeriesDataLabelsFilter()
		{
			Property = Property_DefaultValue = "";
			Operator = Operator_DefaultValue = "";
			Value = Value_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// The point property to filter by. Point options are passed directly toproperties, additionally there are `y` value, `percentage` and otherslisted under [Point](https://api.highcharts.com/class-reference/Highcharts.Point)members.
		/// </summary>
		public string Property { get; set; }
		private string Property_DefaultValue { get; set; }
		 

		/// <summary>
		/// The operator to compare by. Can be one of `>`, `<`, `>=`, `<=`, `==`,and `===`.
		/// </summary>
		public string Operator { get; set; }
		private string Operator_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value to compare against.
		/// </summary>
		public ColumnSeriesDataLabelsFilterValue Value { get; set; }
		private ColumnSeriesDataLabelsFilterValue Value_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Property != Property_DefaultValue) h.Add("property",Property);
			if (Operator != Operator_DefaultValue) h.Add("operator",Operator);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			

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
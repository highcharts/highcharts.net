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
	public partial class BulletSeriesDataLabelsStyleTextOutlineFilter  : BaseObject
	{
		public BulletSeriesDataLabelsStyleTextOutlineFilter()
		{
			Operator = Operator_DefaultValue = "";
			Property = Property_DefaultValue = "";
			Value = Value_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Operator { get; set; }
		private string Operator_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Property { get; set; }
		private string Property_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Value { get; set; }
		private string Value_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Operator != Operator_DefaultValue) h.Add("operator",Operator);
			if (Property != Property_DefaultValue) h.Add("property",Property);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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
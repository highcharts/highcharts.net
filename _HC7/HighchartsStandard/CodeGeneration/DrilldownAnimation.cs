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
	public partial class DrilldownAnimation  : BaseObject
	{
		public DrilldownAnimation()
		{
			Duration = Duration_DefaultValue = "null";
			DurationNumber = DurationNumber_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Duration for the drilldown animation.
		/// </summary>
		public string Duration { get; set; }
		private string Duration_DefaultValue { get; set; }
		 

		/// <summary>
		/// Duration for the drilldown animation.
		/// </summary>
		public double? DurationNumber { get; set; }
		private double? DurationNumber_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Duration != Duration_DefaultValue) h.Add("duration",Duration);
			if (DurationNumber != DurationNumber_DefaultValue) h.Add("duration",DurationNumber);
			

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
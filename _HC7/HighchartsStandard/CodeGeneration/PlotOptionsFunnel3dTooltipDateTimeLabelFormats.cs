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
	public partial class PlotOptionsFunnel3dTooltipDateTimeLabelFormats  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsFunnel3dTooltipDateTimeLabelFormats()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Day { get; set; }
		private string Day_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Hour { get; set; }
		private string Hour_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Millisecond { get; set; }
		private string Millisecond_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Minute { get; set; }
		private string Minute_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Month { get; set; }
		private string Month_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Second { get; set; }
		private string Second_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Week { get; set; }
		private string Week_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Year { get; set; }
		private string Year_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Day != null) h.Add("day",Day);
			if (Hour != null) h.Add("hour",Hour);
			if (Millisecond != null) h.Add("millisecond",Millisecond);
			if (Minute != null) h.Add("minute",Minute);
			if (Month != null) h.Add("month",Month);
			if (Second != null) h.Add("second",Second);
			if (Week != null) h.Add("week",Week);
			if (Year != null) h.Add("year",Year);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}
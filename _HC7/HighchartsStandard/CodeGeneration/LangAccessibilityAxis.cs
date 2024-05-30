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
	public partial class LangAccessibilityAxis  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityAxis()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string RangeCategories { get; set; }
		private string RangeCategories_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string RangeFromTo { get; set; }
		private string RangeFromTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TimeRangeDays { get; set; }
		private string TimeRangeDays_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TimeRangeHours { get; set; }
		private string TimeRangeHours_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TimeRangeMinutes { get; set; }
		private string TimeRangeMinutes_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TimeRangeSeconds { get; set; }
		private string TimeRangeSeconds_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string XAxisDescriptionPlural { get; set; }
		private string XAxisDescriptionPlural_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string XAxisDescriptionSingular { get; set; }
		private string XAxisDescriptionSingular_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string YAxisDescriptionPlural { get; set; }
		private string YAxisDescriptionPlural_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string YAxisDescriptionSingular { get; set; }
		private string YAxisDescriptionSingular_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (RangeCategories != null) h.Add("rangeCategories",RangeCategories);
			if (RangeFromTo != null) h.Add("rangeFromTo",RangeFromTo);
			if (TimeRangeDays != null) h.Add("timeRangeDays",TimeRangeDays);
			if (TimeRangeHours != null) h.Add("timeRangeHours",TimeRangeHours);
			if (TimeRangeMinutes != null) h.Add("timeRangeMinutes",TimeRangeMinutes);
			if (TimeRangeSeconds != null) h.Add("timeRangeSeconds",TimeRangeSeconds);
			if (XAxisDescriptionPlural != null) h.Add("xAxisDescriptionPlural",XAxisDescriptionPlural);
			if (XAxisDescriptionSingular != null) h.Add("xAxisDescriptionSingular",XAxisDescriptionSingular);
			if (YAxisDescriptionPlural != null) h.Add("yAxisDescriptionPlural",YAxisDescriptionPlural);
			if (YAxisDescriptionSingular != null) h.Add("yAxisDescriptionSingular",YAxisDescriptionSingular);
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
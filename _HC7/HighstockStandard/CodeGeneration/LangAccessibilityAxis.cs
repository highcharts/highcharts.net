using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class LangAccessibilityAxis  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityAxis()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string RangeCategories { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string RangeFromTo { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TimeRangeDays { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TimeRangeHours { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TimeRangeMinutes { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TimeRangeSeconds { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string XAxisDescriptionPlural { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string XAxisDescriptionSingular { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string YAxisDescriptionPlural { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string YAxisDescriptionSingular { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
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
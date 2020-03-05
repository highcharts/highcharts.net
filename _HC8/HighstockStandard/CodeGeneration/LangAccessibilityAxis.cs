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
			RangeCategories = RangeCategories_DefaultValue = "Range: {numCategories} categories.";
			RangeFromTo = RangeFromTo_DefaultValue = "Range: {rangeFrom} to {rangeTo}.";
			TimeRangeDays = TimeRangeDays_DefaultValue = "Range: {range} days.";
			TimeRangeHours = TimeRangeHours_DefaultValue = "Range: {range} hours.";
			TimeRangeMinutes = TimeRangeMinutes_DefaultValue = "Range: {range} minutes.";
			TimeRangeSeconds = TimeRangeSeconds_DefaultValue = "Range: {range} seconds.";
			XAxisDescriptionPlural = XAxisDescriptionPlural_DefaultValue = "The chart has {numAxes} X axes displaying {#each(names, -1), }and {names[-1]}.";
			XAxisDescriptionSingular = XAxisDescriptionSingular_DefaultValue = "The chart has 1 X axis displaying {names[0]}. {ranges[0]}";
			YAxisDescriptionPlural = YAxisDescriptionPlural_DefaultValue = "The chart has {numAxes} Y axes displaying {#each(names, -1), }and {names[-1]}.";
			YAxisDescriptionSingular = YAxisDescriptionSingular_DefaultValue = "The chart has 1 Y axis displaying {names[0]}. {ranges[0]}";
			
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
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (RangeCategories != RangeCategories_DefaultValue) h.Add("rangeCategories",RangeCategories);
			if (RangeFromTo != RangeFromTo_DefaultValue) h.Add("rangeFromTo",RangeFromTo);
			if (TimeRangeDays != TimeRangeDays_DefaultValue) h.Add("timeRangeDays",TimeRangeDays);
			if (TimeRangeHours != TimeRangeHours_DefaultValue) h.Add("timeRangeHours",TimeRangeHours);
			if (TimeRangeMinutes != TimeRangeMinutes_DefaultValue) h.Add("timeRangeMinutes",TimeRangeMinutes);
			if (TimeRangeSeconds != TimeRangeSeconds_DefaultValue) h.Add("timeRangeSeconds",TimeRangeSeconds);
			if (XAxisDescriptionPlural != XAxisDescriptionPlural_DefaultValue) h.Add("xAxisDescriptionPlural",XAxisDescriptionPlural);
			if (XAxisDescriptionSingular != XAxisDescriptionSingular_DefaultValue) h.Add("xAxisDescriptionSingular",XAxisDescriptionSingular);
			if (YAxisDescriptionPlural != YAxisDescriptionPlural_DefaultValue) h.Add("yAxisDescriptionPlural",YAxisDescriptionPlural);
			if (YAxisDescriptionSingular != YAxisDescriptionSingular_DefaultValue) h.Add("yAxisDescriptionSingular",YAxisDescriptionSingular);
			

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
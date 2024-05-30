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
	public partial class YAxisDateTimeLabelFormats  : BaseObject
	{
		Hashtable h = new Hashtable();

		public YAxisDateTimeLabelFormats()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsDay Day { get; set; }
		private YAxisDateTimeLabelFormatsDay Day_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DayString { get; set; }
		private string DayString_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsHour Hour { get; set; }
		private YAxisDateTimeLabelFormatsHour Hour_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string HourString { get; set; }
		private string HourString_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsMillisecond Millisecond { get; set; }
		private YAxisDateTimeLabelFormatsMillisecond Millisecond_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MillisecondString { get; set; }
		private string MillisecondString_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsMinute Minute { get; set; }
		private YAxisDateTimeLabelFormatsMinute Minute_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MinuteString { get; set; }
		private string MinuteString_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsMonth Month { get; set; }
		private YAxisDateTimeLabelFormatsMonth Month_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MonthString { get; set; }
		private string MonthString_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsSecond Second { get; set; }
		private YAxisDateTimeLabelFormatsSecond Second_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SecondString { get; set; }
		private string SecondString_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsWeek Week { get; set; }
		private YAxisDateTimeLabelFormatsWeek Week_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string WeekString { get; set; }
		private string WeekString_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsYear Year { get; set; }
		private YAxisDateTimeLabelFormatsYear Year_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string YearString { get; set; }
		private string YearString_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Day != null) h.Add("day",Day.ToHashtable(highcharts));
			if (DayString != null) h.Add("day",DayString);
			if (Hour != null) h.Add("hour",Hour.ToHashtable(highcharts));
			if (HourString != null) h.Add("hour",HourString);
			if (Millisecond != null) h.Add("millisecond",Millisecond.ToHashtable(highcharts));
			if (MillisecondString != null) h.Add("millisecond",MillisecondString);
			if (Minute != null) h.Add("minute",Minute.ToHashtable(highcharts));
			if (MinuteString != null) h.Add("minute",MinuteString);
			if (Month != null) h.Add("month",Month.ToHashtable(highcharts));
			if (MonthString != null) h.Add("month",MonthString);
			if (Second != null) h.Add("second",Second.ToHashtable(highcharts));
			if (SecondString != null) h.Add("second",SecondString);
			if (Week != null) h.Add("week",Week.ToHashtable(highcharts));
			if (WeekString != null) h.Add("week",WeekString);
			if (Year != null) h.Add("year",Year.ToHashtable(highcharts));
			if (YearString != null) h.Add("year",YearString);
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
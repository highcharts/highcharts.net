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
	public partial class NavigatorYAxisDateTimeLabelFormats  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigatorYAxisDateTimeLabelFormats()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsDay Day { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DayString { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsHour Hour { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string HourString { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsMillisecond Millisecond { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MillisecondString { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsMinute Minute { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MinuteString { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsMonth Month { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MonthString { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsSecond Second { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SecondString { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsWeek Week { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string WeekString { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsYear Year { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string YearString { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Day != null) h.Add("day",Day.ToHashtable(highstock));
			if (DayString != null) h.Add("day",DayString);
			if (Hour != null) h.Add("hour",Hour.ToHashtable(highstock));
			if (HourString != null) h.Add("hour",HourString);
			if (Millisecond != null) h.Add("millisecond",Millisecond.ToHashtable(highstock));
			if (MillisecondString != null) h.Add("millisecond",MillisecondString);
			if (Minute != null) h.Add("minute",Minute.ToHashtable(highstock));
			if (MinuteString != null) h.Add("minute",MinuteString);
			if (Month != null) h.Add("month",Month.ToHashtable(highstock));
			if (MonthString != null) h.Add("month",MonthString);
			if (Second != null) h.Add("second",Second.ToHashtable(highstock));
			if (SecondString != null) h.Add("second",SecondString);
			if (Week != null) h.Add("week",Week.ToHashtable(highstock));
			if (WeekString != null) h.Add("week",WeekString);
			if (Year != null) h.Add("year",Year.ToHashtable(highstock));
			if (YearString != null) h.Add("year",YearString);
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
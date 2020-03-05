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
	public partial class YAxisDateTimeLabelFormats  : BaseObject
	{
		Hashtable h = new Hashtable();

		public YAxisDateTimeLabelFormats()
		{
			Day = Day_DefaultValue = new YAxisDateTimeLabelFormatsDay();
			DayString = DayString_DefaultValue = "null";
			Hour = Hour_DefaultValue = new YAxisDateTimeLabelFormatsHour();
			HourString = HourString_DefaultValue = "null";
			Millisecond = Millisecond_DefaultValue = new YAxisDateTimeLabelFormatsMillisecond();
			MillisecondString = MillisecondString_DefaultValue = "null";
			Minute = Minute_DefaultValue = new YAxisDateTimeLabelFormatsMinute();
			MinuteString = MinuteString_DefaultValue = "null";
			Month = Month_DefaultValue = new YAxisDateTimeLabelFormatsMonth();
			MonthString = MonthString_DefaultValue = "null";
			Second = Second_DefaultValue = new YAxisDateTimeLabelFormatsSecond();
			SecondString = SecondString_DefaultValue = "null";
			Week = Week_DefaultValue = new YAxisDateTimeLabelFormatsWeek();
			WeekString = WeekString_DefaultValue = "null";
			Year = Year_DefaultValue = new YAxisDateTimeLabelFormatsYear();
			YearString = YearString_DefaultValue = "null";
			
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
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Day.IsDirty()) h.Add("day",Day.ToHashtable());
			if (DayString != DayString_DefaultValue) h.Add("day",DayString);
			if (Hour.IsDirty()) h.Add("hour",Hour.ToHashtable());
			if (HourString != HourString_DefaultValue) h.Add("hour",HourString);
			if (Millisecond.IsDirty()) h.Add("millisecond",Millisecond.ToHashtable());
			if (MillisecondString != MillisecondString_DefaultValue) h.Add("millisecond",MillisecondString);
			if (Minute.IsDirty()) h.Add("minute",Minute.ToHashtable());
			if (MinuteString != MinuteString_DefaultValue) h.Add("minute",MinuteString);
			if (Month.IsDirty()) h.Add("month",Month.ToHashtable());
			if (MonthString != MonthString_DefaultValue) h.Add("month",MonthString);
			if (Second.IsDirty()) h.Add("second",Second.ToHashtable());
			if (SecondString != SecondString_DefaultValue) h.Add("second",SecondString);
			if (Week.IsDirty()) h.Add("week",Week.ToHashtable());
			if (WeekString != WeekString_DefaultValue) h.Add("week",WeekString);
			if (Year.IsDirty()) h.Add("year",Year.ToHashtable());
			if (YearString != YearString_DefaultValue) h.Add("year",YearString);
			

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
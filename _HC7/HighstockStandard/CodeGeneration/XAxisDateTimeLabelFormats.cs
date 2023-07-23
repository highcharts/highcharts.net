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
	public partial class XAxisDateTimeLabelFormats  : BaseObject
	{
		Hashtable h = new Hashtable();

		public XAxisDateTimeLabelFormats()
		{
			Day = Day_DefaultValue = new XAxisDateTimeLabelFormatsDay();
			DayString = DayString_DefaultValue = "null";
			Hour = Hour_DefaultValue = new XAxisDateTimeLabelFormatsHour();
			HourString = HourString_DefaultValue = "null";
			Millisecond = Millisecond_DefaultValue = new XAxisDateTimeLabelFormatsMillisecond();
			MillisecondString = MillisecondString_DefaultValue = "null";
			Minute = Minute_DefaultValue = new XAxisDateTimeLabelFormatsMinute();
			MinuteString = MinuteString_DefaultValue = "null";
			Month = Month_DefaultValue = new XAxisDateTimeLabelFormatsMonth();
			MonthString = MonthString_DefaultValue = "null";
			Second = Second_DefaultValue = new XAxisDateTimeLabelFormatsSecond();
			SecondString = SecondString_DefaultValue = "null";
			Week = Week_DefaultValue = new XAxisDateTimeLabelFormatsWeek();
			WeekString = WeekString_DefaultValue = "null";
			Year = Year_DefaultValue = new XAxisDateTimeLabelFormatsYear();
			YearString = YearString_DefaultValue = "null";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsDay Day { get; set; }
		private XAxisDateTimeLabelFormatsDay Day_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DayString { get; set; }
		private string DayString_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsHour Hour { get; set; }
		private XAxisDateTimeLabelFormatsHour Hour_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string HourString { get; set; }
		private string HourString_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsMillisecond Millisecond { get; set; }
		private XAxisDateTimeLabelFormatsMillisecond Millisecond_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MillisecondString { get; set; }
		private string MillisecondString_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsMinute Minute { get; set; }
		private XAxisDateTimeLabelFormatsMinute Minute_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MinuteString { get; set; }
		private string MinuteString_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsMonth Month { get; set; }
		private XAxisDateTimeLabelFormatsMonth Month_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MonthString { get; set; }
		private string MonthString_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsSecond Second { get; set; }
		private XAxisDateTimeLabelFormatsSecond Second_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SecondString { get; set; }
		private string SecondString_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsWeek Week { get; set; }
		private XAxisDateTimeLabelFormatsWeek Week_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string WeekString { get; set; }
		private string WeekString_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsYear Year { get; set; }
		private XAxisDateTimeLabelFormatsYear Year_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string YearString { get; set; }
		private string YearString_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Day.IsDirty(highstock)) h.Add("day",Day.ToHashtable(highstock));
			if (DayString != DayString_DefaultValue) h.Add("day",DayString);
			if (Hour.IsDirty(highstock)) h.Add("hour",Hour.ToHashtable(highstock));
			if (HourString != HourString_DefaultValue) h.Add("hour",HourString);
			if (Millisecond.IsDirty(highstock)) h.Add("millisecond",Millisecond.ToHashtable(highstock));
			if (MillisecondString != MillisecondString_DefaultValue) h.Add("millisecond",MillisecondString);
			if (Minute.IsDirty(highstock)) h.Add("minute",Minute.ToHashtable(highstock));
			if (MinuteString != MinuteString_DefaultValue) h.Add("minute",MinuteString);
			if (Month.IsDirty(highstock)) h.Add("month",Month.ToHashtable(highstock));
			if (MonthString != MonthString_DefaultValue) h.Add("month",MonthString);
			if (Second.IsDirty(highstock)) h.Add("second",Second.ToHashtable(highstock));
			if (SecondString != SecondString_DefaultValue) h.Add("second",SecondString);
			if (Week.IsDirty(highstock)) h.Add("week",Week.ToHashtable(highstock));
			if (WeekString != WeekString_DefaultValue) h.Add("week",WeekString);
			if (Year.IsDirty(highstock)) h.Add("year",Year.ToHashtable(highstock));
			if (YearString != YearString_DefaultValue) h.Add("year",YearString);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}
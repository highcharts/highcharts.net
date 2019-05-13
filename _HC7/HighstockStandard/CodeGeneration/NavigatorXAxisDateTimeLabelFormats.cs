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
	public partial class NavigatorXAxisDateTimeLabelFormats  : BaseObject
	{
		public NavigatorXAxisDateTimeLabelFormats()
		{
			Day = Day_DefaultValue = new NavigatorXAxisDateTimeLabelFormatsDay();
			Hour = Hour_DefaultValue = new NavigatorXAxisDateTimeLabelFormatsHour();
			Millisecond = Millisecond_DefaultValue = new NavigatorXAxisDateTimeLabelFormatsMillisecond();
			Minute = Minute_DefaultValue = new NavigatorXAxisDateTimeLabelFormatsMinute();
			Month = Month_DefaultValue = new NavigatorXAxisDateTimeLabelFormatsMonth();
			Second = Second_DefaultValue = new NavigatorXAxisDateTimeLabelFormatsSecond();
			Week = Week_DefaultValue = new NavigatorXAxisDateTimeLabelFormatsWeek();
			Year = Year_DefaultValue = new NavigatorXAxisDateTimeLabelFormatsYear();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public NavigatorXAxisDateTimeLabelFormatsDay Day { get; set; }
		private NavigatorXAxisDateTimeLabelFormatsDay Day_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorXAxisDateTimeLabelFormatsHour Hour { get; set; }
		private NavigatorXAxisDateTimeLabelFormatsHour Hour_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorXAxisDateTimeLabelFormatsMillisecond Millisecond { get; set; }
		private NavigatorXAxisDateTimeLabelFormatsMillisecond Millisecond_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorXAxisDateTimeLabelFormatsMinute Minute { get; set; }
		private NavigatorXAxisDateTimeLabelFormatsMinute Minute_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorXAxisDateTimeLabelFormatsMonth Month { get; set; }
		private NavigatorXAxisDateTimeLabelFormatsMonth Month_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorXAxisDateTimeLabelFormatsSecond Second { get; set; }
		private NavigatorXAxisDateTimeLabelFormatsSecond Second_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorXAxisDateTimeLabelFormatsWeek Week { get; set; }
		private NavigatorXAxisDateTimeLabelFormatsWeek Week_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorXAxisDateTimeLabelFormatsYear Year { get; set; }
		private NavigatorXAxisDateTimeLabelFormatsYear Year_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Day.IsDirty()) h.Add("day",Day.ToHashtable());
			if (Hour.IsDirty()) h.Add("hour",Hour.ToHashtable());
			if (Millisecond.IsDirty()) h.Add("millisecond",Millisecond.ToHashtable());
			if (Minute.IsDirty()) h.Add("minute",Minute.ToHashtable());
			if (Month.IsDirty()) h.Add("month",Month.ToHashtable());
			if (Second.IsDirty()) h.Add("second",Second.ToHashtable());
			if (Week.IsDirty()) h.Add("week",Week.ToHashtable());
			if (Year.IsDirty()) h.Add("year",Year.ToHashtable());
			

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
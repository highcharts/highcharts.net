using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class NavigatorYAxisDateTimeLabelFormats  : BaseObject
	{
		public NavigatorYAxisDateTimeLabelFormats()
		{
			Day = Day_DefaultValue = new NavigatorYAxisDateTimeLabelFormatsDay();
			Hour = Hour_DefaultValue = new NavigatorYAxisDateTimeLabelFormatsHour();
			Millisecond = Millisecond_DefaultValue = new NavigatorYAxisDateTimeLabelFormatsMillisecond();
			Minute = Minute_DefaultValue = new NavigatorYAxisDateTimeLabelFormatsMinute();
			Month = Month_DefaultValue = new NavigatorYAxisDateTimeLabelFormatsMonth();
			Second = Second_DefaultValue = new NavigatorYAxisDateTimeLabelFormatsSecond();
			Week = Week_DefaultValue = new NavigatorYAxisDateTimeLabelFormatsWeek();
			Year = Year_DefaultValue = new NavigatorYAxisDateTimeLabelFormatsYear();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsDay Day { get; set; }
		private NavigatorYAxisDateTimeLabelFormatsDay Day_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsHour Hour { get; set; }
		private NavigatorYAxisDateTimeLabelFormatsHour Hour_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsMillisecond Millisecond { get; set; }
		private NavigatorYAxisDateTimeLabelFormatsMillisecond Millisecond_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsMinute Minute { get; set; }
		private NavigatorYAxisDateTimeLabelFormatsMinute Minute_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsMonth Month { get; set; }
		private NavigatorYAxisDateTimeLabelFormatsMonth Month_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsSecond Second { get; set; }
		private NavigatorYAxisDateTimeLabelFormatsSecond Second_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsWeek Week { get; set; }
		private NavigatorYAxisDateTimeLabelFormatsWeek Week_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorYAxisDateTimeLabelFormatsYear Year { get; set; }
		private NavigatorYAxisDateTimeLabelFormatsYear Year_DefaultValue { get; set; }
		  

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
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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
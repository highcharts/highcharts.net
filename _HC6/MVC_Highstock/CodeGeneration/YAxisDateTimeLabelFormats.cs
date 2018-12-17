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
	public partial class YAxisDateTimeLabelFormats  : BaseObject
	{
		public YAxisDateTimeLabelFormats()
		{
			Day = Day_DefaultValue = new YAxisDateTimeLabelFormatsDay();
			Hour = Hour_DefaultValue = new YAxisDateTimeLabelFormatsHour();
			Millisecond = Millisecond_DefaultValue = new YAxisDateTimeLabelFormatsMillisecond();
			Minute = Minute_DefaultValue = new YAxisDateTimeLabelFormatsMinute();
			Month = Month_DefaultValue = new YAxisDateTimeLabelFormatsMonth();
			Second = Second_DefaultValue = new YAxisDateTimeLabelFormatsSecond();
			Week = Week_DefaultValue = new YAxisDateTimeLabelFormatsWeek();
			Year = Year_DefaultValue = new YAxisDateTimeLabelFormatsYear();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsDay Day { get; set; }
		private YAxisDateTimeLabelFormatsDay Day_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsHour Hour { get; set; }
		private YAxisDateTimeLabelFormatsHour Hour_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsMillisecond Millisecond { get; set; }
		private YAxisDateTimeLabelFormatsMillisecond Millisecond_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsMinute Minute { get; set; }
		private YAxisDateTimeLabelFormatsMinute Minute_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsMonth Month { get; set; }
		private YAxisDateTimeLabelFormatsMonth Month_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsSecond Second { get; set; }
		private YAxisDateTimeLabelFormatsSecond Second_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsWeek Week { get; set; }
		private YAxisDateTimeLabelFormatsWeek Week_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisDateTimeLabelFormatsYear Year { get; set; }
		private YAxisDateTimeLabelFormatsYear Year_DefaultValue { get; set; }
		  

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
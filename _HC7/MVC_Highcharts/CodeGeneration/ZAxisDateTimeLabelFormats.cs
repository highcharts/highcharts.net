using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class ZAxisDateTimeLabelFormats  : BaseObject
	{
		public ZAxisDateTimeLabelFormats()
		{
			Day = Day_DefaultValue = new ZAxisDateTimeLabelFormatsDay();
			Hour = Hour_DefaultValue = new ZAxisDateTimeLabelFormatsHour();
			Millisecond = Millisecond_DefaultValue = new ZAxisDateTimeLabelFormatsMillisecond();
			Minute = Minute_DefaultValue = new ZAxisDateTimeLabelFormatsMinute();
			Month = Month_DefaultValue = new ZAxisDateTimeLabelFormatsMonth();
			Second = Second_DefaultValue = new ZAxisDateTimeLabelFormatsSecond();
			Week = Week_DefaultValue = new ZAxisDateTimeLabelFormatsWeek();
			Year = Year_DefaultValue = new ZAxisDateTimeLabelFormatsYear();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public ZAxisDateTimeLabelFormatsDay Day { get; set; }
		private ZAxisDateTimeLabelFormatsDay Day_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ZAxisDateTimeLabelFormatsHour Hour { get; set; }
		private ZAxisDateTimeLabelFormatsHour Hour_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ZAxisDateTimeLabelFormatsMillisecond Millisecond { get; set; }
		private ZAxisDateTimeLabelFormatsMillisecond Millisecond_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ZAxisDateTimeLabelFormatsMinute Minute { get; set; }
		private ZAxisDateTimeLabelFormatsMinute Minute_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ZAxisDateTimeLabelFormatsMonth Month { get; set; }
		private ZAxisDateTimeLabelFormatsMonth Month_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ZAxisDateTimeLabelFormatsSecond Second { get; set; }
		private ZAxisDateTimeLabelFormatsSecond Second_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ZAxisDateTimeLabelFormatsWeek Week { get; set; }
		private ZAxisDateTimeLabelFormatsWeek Week_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ZAxisDateTimeLabelFormatsYear Year { get; set; }
		private ZAxisDateTimeLabelFormatsYear Year_DefaultValue { get; set; }
		  

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
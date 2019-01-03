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
	public partial class ChartParallelAxesDateTimeLabelFormats  : BaseObject
	{
		public ChartParallelAxesDateTimeLabelFormats()
		{
			Day = Day_DefaultValue = new ChartParallelAxesDateTimeLabelFormatsDay();
			Hour = Hour_DefaultValue = new ChartParallelAxesDateTimeLabelFormatsHour();
			Millisecond = Millisecond_DefaultValue = new ChartParallelAxesDateTimeLabelFormatsMillisecond();
			Minute = Minute_DefaultValue = new ChartParallelAxesDateTimeLabelFormatsMinute();
			Month = Month_DefaultValue = new ChartParallelAxesDateTimeLabelFormatsMonth();
			Second = Second_DefaultValue = new ChartParallelAxesDateTimeLabelFormatsSecond();
			Week = Week_DefaultValue = new ChartParallelAxesDateTimeLabelFormatsWeek();
			Year = Year_DefaultValue = new ChartParallelAxesDateTimeLabelFormatsYear();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsDay Day { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsDay Day_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsHour Hour { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsHour Hour_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsMillisecond Millisecond { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsMillisecond Millisecond_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsMinute Minute { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsMinute Minute_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsMonth Month { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsMonth Month_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsSecond Second { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsSecond Second_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsWeek Week { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsWeek Week_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsYear Year { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsYear Year_DefaultValue { get; set; }
		  

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
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
			Millisecond = Millisecond_DefaultValue = %H:%M:%S.%L;
			Second = Second_DefaultValue = %H:%M:%S;
			Minute = Minute_DefaultValue = %H:%M;
			Hour = Hour_DefaultValue = %H:%M;
			Day = Day_DefaultValue = %e. %b;
			Week = Week_DefaultValue = %e. %b;
			Month = Month_DefaultValue = %b '%y;
			Year = Year_DefaultValue = %Y;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsMillisecond Millisecond { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsMillisecond Millisecond_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsSecond Second { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsSecond Second_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsMinute Minute { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsMinute Minute_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsHour Hour { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsHour Hour_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsDay Day { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsDay Day_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsWeek Week { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsWeek Week_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsMonth Month { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsMonth Month_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesDateTimeLabelFormatsYear Year { get; set; }
		private ChartParallelAxesDateTimeLabelFormatsYear Year_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Millisecond != Millisecond_DefaultValue) h.Add("millisecond",Millisecond);
			if (Second != Second_DefaultValue) h.Add("second",Second);
			if (Minute != Minute_DefaultValue) h.Add("minute",Minute);
			if (Hour != Hour_DefaultValue) h.Add("hour",Hour);
			if (Day != Day_DefaultValue) h.Add("day",Day);
			if (Week != Week_DefaultValue) h.Add("week",Week);
			if (Month != Month_DefaultValue) h.Add("month",Month);
			if (Year != Year_DefaultValue) h.Add("year",Year);
			

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
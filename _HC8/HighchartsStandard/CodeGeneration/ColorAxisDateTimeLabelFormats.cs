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
	public partial class ColorAxisDateTimeLabelFormats  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColorAxisDateTimeLabelFormats()
		{
			Day = Day_DefaultValue = new ColorAxisDateTimeLabelFormatsDay();
			Hour = Hour_DefaultValue = new ColorAxisDateTimeLabelFormatsHour();
			Millisecond = Millisecond_DefaultValue = new ColorAxisDateTimeLabelFormatsMillisecond();
			Minute = Minute_DefaultValue = new ColorAxisDateTimeLabelFormatsMinute();
			Month = Month_DefaultValue = new ColorAxisDateTimeLabelFormatsMonth();
			Second = Second_DefaultValue = new ColorAxisDateTimeLabelFormatsSecond();
			Week = Week_DefaultValue = new ColorAxisDateTimeLabelFormatsWeek();
			Year = Year_DefaultValue = new ColorAxisDateTimeLabelFormatsYear();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public ColorAxisDateTimeLabelFormatsDay Day { get; set; }
		private ColorAxisDateTimeLabelFormatsDay Day_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColorAxisDateTimeLabelFormatsHour Hour { get; set; }
		private ColorAxisDateTimeLabelFormatsHour Hour_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColorAxisDateTimeLabelFormatsMillisecond Millisecond { get; set; }
		private ColorAxisDateTimeLabelFormatsMillisecond Millisecond_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColorAxisDateTimeLabelFormatsMinute Minute { get; set; }
		private ColorAxisDateTimeLabelFormatsMinute Minute_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColorAxisDateTimeLabelFormatsMonth Month { get; set; }
		private ColorAxisDateTimeLabelFormatsMonth Month_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColorAxisDateTimeLabelFormatsSecond Second { get; set; }
		private ColorAxisDateTimeLabelFormatsSecond Second_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColorAxisDateTimeLabelFormatsWeek Week { get; set; }
		private ColorAxisDateTimeLabelFormatsWeek Week_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColorAxisDateTimeLabelFormatsYear Year { get; set; }
		private ColorAxisDateTimeLabelFormatsYear Year_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

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
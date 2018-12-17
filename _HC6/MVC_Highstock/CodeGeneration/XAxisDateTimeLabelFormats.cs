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
	public partial class XAxisDateTimeLabelFormats  : BaseObject
	{
		public XAxisDateTimeLabelFormats()
		{
			Day = Day_DefaultValue = new XAxisDateTimeLabelFormatsDay();
			Hour = Hour_DefaultValue = new XAxisDateTimeLabelFormatsHour();
			Millisecond = Millisecond_DefaultValue = new XAxisDateTimeLabelFormatsMillisecond();
			Minute = Minute_DefaultValue = new XAxisDateTimeLabelFormatsMinute();
			Month = Month_DefaultValue = new XAxisDateTimeLabelFormatsMonth();
			Second = Second_DefaultValue = new XAxisDateTimeLabelFormatsSecond();
			Week = Week_DefaultValue = new XAxisDateTimeLabelFormatsWeek();
			Year = Year_DefaultValue = new XAxisDateTimeLabelFormatsYear();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsDay Day { get; set; }
		private XAxisDateTimeLabelFormatsDay Day_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsHour Hour { get; set; }
		private XAxisDateTimeLabelFormatsHour Hour_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsMillisecond Millisecond { get; set; }
		private XAxisDateTimeLabelFormatsMillisecond Millisecond_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsMinute Minute { get; set; }
		private XAxisDateTimeLabelFormatsMinute Minute_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsMonth Month { get; set; }
		private XAxisDateTimeLabelFormatsMonth Month_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsSecond Second { get; set; }
		private XAxisDateTimeLabelFormatsSecond Second_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsWeek Week { get; set; }
		private XAxisDateTimeLabelFormatsWeek Week_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public XAxisDateTimeLabelFormatsYear Year { get; set; }
		private XAxisDateTimeLabelFormatsYear Year_DefaultValue { get; set; }
		  

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
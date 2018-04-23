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
			Day = Day_DefaultValue = "%e. %b";
			Hour = Hour_DefaultValue = "%H:%M";
			Millisecond = Millisecond_DefaultValue = "%H:%M:%S.%L";
			Minute = Minute_DefaultValue = "%H:%M";
			Month = Month_DefaultValue = "%b '%y";
			Second = Second_DefaultValue = "%H:%M:%S";
			Week = Week_DefaultValue = "%e. %b";
			Year = Year_DefaultValue = "%Y";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Day { get; set; }
		private string Day_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Hour { get; set; }
		private string Hour_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Millisecond { get; set; }
		private string Millisecond_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Minute { get; set; }
		private string Minute_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Month { get; set; }
		private string Month_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Second { get; set; }
		private string Second_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Week { get; set; }
		private string Week_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Year { get; set; }
		private string Year_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Day != Day_DefaultValue) h.Add("day",Day);
			if (Hour != Hour_DefaultValue) h.Add("hour",Hour);
			if (Millisecond != Millisecond_DefaultValue) h.Add("millisecond",Millisecond);
			if (Minute != Minute_DefaultValue) h.Add("minute",Minute);
			if (Month != Month_DefaultValue) h.Add("month",Month);
			if (Second != Second_DefaultValue) h.Add("second",Second);
			if (Week != Week_DefaultValue) h.Add("week",Week);
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
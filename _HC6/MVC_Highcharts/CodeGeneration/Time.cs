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
	public partial class Time  : BaseObject
	{
		public Time()
		{
			Date = Date_DefaultValue = new DateTime();
			GetTimezoneOffset = GetTimezoneOffset_DefaultValue = "";
			Timezone = Timezone_DefaultValue = "undefined";
			TimezoneOffset = TimezoneOffset_DefaultValue = 0;
			UseUTC = UseUTC_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// A custom `Date` class for advanced date handling. For example,[JDate](https://github.com/tahajahangir/jdate) can be hooked in tohandle Jalali dates.
		/// </summary>
		public DateTime Date { get; set; }
		private DateTime Date_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback to return the time zone offset for a given datetime. Ittakes the timestamp in terms of milliseconds since January 1 1970,and returns the timezone offset in minutes. This provides a hookfor drawing time based charts in specific time zones using theirlocal DST crossover dates, with the help of external libraries.
		/// </summary>
		public string GetTimezoneOffset { get; set; }
		private string GetTimezoneOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// Requires [moment.js](http://momentjs.com/). If the timezone optionis specified, it creates a default[getTimezoneOffset](#time.getTimezoneOffset) function that looksup the specified timezone in moment.js. If moment.js is not included,this throws a Highcharts error in the console, but does not crash thechart.
		/// </summary>
		public string Timezone { get; set; }
		private string Timezone_DefaultValue { get; set; }
		 

		/// <summary>
		/// The timezone offset in minutes. Positive values are west, negativevalues are east of UTC, as in the ECMAScript[getTimezoneOffset](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/getTimezoneOffset)method. Use this to display UTC based data in a predefined time zone.
		/// </summary>
		public double? TimezoneOffset { get; set; }
		private double? TimezoneOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to use UTC time for axis scaling, tickmark placement andtime display in `Highcharts.dateFormat`. Advantages of using UTCis that the time displays equally regardless of the user agent'stime zone settings. Local time can be used when the data is loadedin real time or when correct Daylight Saving Time transitions arerequired.
		/// </summary>
		public bool? UseUTC { get; set; }
		private bool? UseUTC_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Date != Date_DefaultValue) h.Add("date",Date);
			if (GetTimezoneOffset != GetTimezoneOffset_DefaultValue) { h.Add("getTimezoneOffset",GetTimezoneOffset); Highcharts.AddFunction("TimeGetTimezoneOffset.getTimezoneOffset", GetTimezoneOffset); }  
			if (Timezone != Timezone_DefaultValue) h.Add("timezone",Timezone);
			if (TimezoneOffset != TimezoneOffset_DefaultValue) h.Add("timezoneOffset",TimezoneOffset);
			if (UseUTC != UseUTC_DefaultValue) h.Add("useUTC",UseUTC);
			

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
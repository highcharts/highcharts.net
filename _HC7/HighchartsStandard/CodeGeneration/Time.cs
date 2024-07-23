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
	public partial class Time  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Time()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// A custom `Date` class for advanced date handling. For example,[JDate](https://github.com/tahajahangir/jdate) can be hooked in tohandle Jalali dates.
		/// </summary>
		public DateTime Date { get; set; }
		 

		/// <summary>
		/// A callback to return the time zone offset for a given datetime. Ittakes the timestamp in terms of milliseconds since January 1 1970,and returns the timezone offset in minutes. This provides a hookfor drawing time based charts in specific time zones using theirlocal DST crossover dates, with the help of external libraries.This option is deprecated as of v11.4.1 and will be removed in afuture release. Use the [time.timezone](#time.timezone) optioninstead.
		/// </summary>
		public string GetTimezoneOffset { get; set; }
		 

		/// <summary>
		/// A named time zone. Supported time zone names rely on the browserimplementations, as described in the [mdndocs](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Intl/DateTimeFormat/DateTimeFormat#timezone).If the given time zone is not recognized by the browser, Highchartsprovides a warning and falls back to returning a 0 offset,corresponding to the UTC time zone.Until v11.2.0, this option depended on moment.js.
		/// </summary>
		public string Timezone { get; set; }
		 

		/// <summary>
		/// The timezone offset in minutes. Positive values are west, negativevalues are east of UTC, as in the ECMAScript[getTimezoneOffset](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/getTimezoneOffset)method. Use this to display UTC based data in a predefined time zone.This option is deprecated as of v11.4.1 and will be removed in afuture release. Use the [time.timezone](#time.timezone) optioninstead.
		/// </summary>
		public double? TimezoneOffset { get; set; }
		 

		/// <summary>
		/// Whether to use UTC time for axis scaling, tickmark placement andtime display in `Highcharts.dateFormat`. Advantages of using UTCis that the time displays equally regardless of the user agent'stime zone settings. Local time can be used when the data is loadedin real time or when correct Daylight Saving Time transitions arerequired.
		/// </summary>
		public bool? UseUTC { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Date != null) h.Add("date",Date);
			if (GetTimezoneOffset != null) { h.Add("getTimezoneOffset",GetTimezoneOffset); highcharts.AddFunction("getTimezoneOffset", GetTimezoneOffset); }  
			if (Timezone != null) h.Add("timezone",Timezone);
			if (TimezoneOffset != null) h.Add("timezoneOffset",TimezoneOffset);
			if (UseUTC != null) h.Add("useUTC",UseUTC);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}
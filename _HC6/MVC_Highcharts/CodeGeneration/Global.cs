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
	public partial class Global  : BaseObject
	{
		public Global()
		{
			VMLRadialGradientURL = VMLRadialGradientURL_DefaultValue = null;
			UseUTC = UseUTC_DefaultValue = true;
			GetTimezoneOffset = GetTimezoneOffset_DefaultValue = "";
			Timezone = Timezone_DefaultValue = "undefined";
			TimezoneOffset = TimezoneOffset_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// <p>Path to the pattern image required by VML browsers in order todraw radial gradients.</p>
		/// </summary>
		public string VMLRadialGradientURL { get; set; }
		private string VMLRadialGradientURL_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to use UTC time for axis scaling, tickmark placement andtime display in <code>Highcharts.dateFormat</code>. Advantages of using UTCis that the time displays equally regardless of the user agent&#39;stime zone settings. Local time can be used when the data is loadedin real time or when correct Daylight Saving Time transitions arerequired.</p>
		/// </summary>
		public bool? UseUTC { get; set; }
		private bool? UseUTC_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A callback to return the time zone offset for a given datetime. Ittakes the timestamp in terms of milliseconds since January 1 1970,and returns the timezone offset in minutes. This provides a hookfor drawing time based charts in specific time zones using theirlocal DST crossover dates, with the help of external libraries.</p>
		/// </summary>
		public string GetTimezoneOffset { get; set; }
		private string GetTimezoneOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Requires <a href="http://momentjs.com/">moment.js</a>. If the timezone optionis specified, it creates a default<a href="#global.getTimezoneOffset">getTimezoneOffset</a> function that looksup the specified timezone in moment.js. If moment.js is not included,this throws a Highcharts error in the console, but does not crash thechart.</p>
		/// </summary>
		public string Timezone { get; set; }
		private string Timezone_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The timezone offset in minutes. Positive values are west, negativevalues are east of UTC, as in the ECMAScript <a href="https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/getTimezoneOffset">getTimezoneOffset</a>method. Use this to display UTC based data in a predefined time zone.</p>
		/// </summary>
		public double? TimezoneOffset { get; set; }
		private double? TimezoneOffset_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (VMLRadialGradientURL != VMLRadialGradientURL_DefaultValue) h.Add("vMLRadialGradientURL",VMLRadialGradientURL);
			if (UseUTC != UseUTC_DefaultValue) h.Add("useUTC",UseUTC);
			if (GetTimezoneOffset != GetTimezoneOffset_DefaultValue) { h.Add("getTimezoneOffset",GetTimezoneOffset); Highcharts.AddFunction("GlobalGetTimezoneOffset.getTimezoneOffset", GetTimezoneOffset); }  
			if (Timezone != Timezone_DefaultValue) h.Add("timezone",Timezone);
			if (TimezoneOffset != TimezoneOffset_DefaultValue) h.Add("timezoneOffset",TimezoneOffset);
			

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
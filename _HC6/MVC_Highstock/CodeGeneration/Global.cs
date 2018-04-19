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
	public partial class Global  : BaseObject
	{
		public Global()
		{
			VMLRadialGradientURL = VMLRadialGradientURL_DefaultValue = "";
			UseUTC = UseUTC_DefaultValue = null;
			Date = Date_DefaultValue = null;
			GetTimezoneOffset = GetTimezoneOffset_DefaultValue = "";
			Timezone = Timezone_DefaultValue = "";
			TimezoneOffset = TimezoneOffset_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Path to the pattern image required by VML browsers in order todraw radial gradients.
		/// </summary>
		public string VMLRadialGradientURL { get; set; }
		private string VMLRadialGradientURL_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option is deprecated since v6.0.5. Instead, use[time.useUTC](#time.useUTC) that supports individual time settingsper chart.
		/// </summary>
		public bool? UseUTC { get; set; }
		private bool? UseUTC_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option is deprecated since v6.0.5. Instead, use[time.Date](#time.Date) that supports individual time settingsper chart.
		/// </summary>
		public Object Date { get; set; }
		private Object Date_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option is deprecated since v6.0.5. Instead, use[time.getTimezoneOffset](#time.getTimezoneOffset) that supportsindividual time settings per chart.
		/// </summary>
		public string GetTimezoneOffset { get; set; }
		private string GetTimezoneOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option is deprecated since v6.0.5. Instead, use[time.timezone](#time.timezone) that supports individual timesettings per chart.
		/// </summary>
		public string Timezone { get; set; }
		private string Timezone_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option is deprecated since v6.0.5. Instead, use[time.timezoneOffset](#time.timezoneOffset) that supports individualtime settings per chart.
		/// </summary>
		public double? TimezoneOffset { get; set; }
		private double? TimezoneOffset_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (VMLRadialGradientURL != VMLRadialGradientURL_DefaultValue) h.Add("vMLRadialGradientURL",VMLRadialGradientURL);
			if (UseUTC != UseUTC_DefaultValue) h.Add("useUTC",UseUTC);
			if (Date != Date_DefaultValue) h.Add("date",Date);
			if (GetTimezoneOffset != GetTimezoneOffset_DefaultValue) h.Add("getTimezoneOffset",GetTimezoneOffset);
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
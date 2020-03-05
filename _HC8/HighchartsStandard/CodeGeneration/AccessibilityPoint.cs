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
	public partial class AccessibilityPoint  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AccessibilityPoint()
		{
			DateFormat = DateFormat_DefaultValue = "";
			DateFormatter = DateFormatter_DefaultValue = "";
			DescriptionFormatter = DescriptionFormatter_DefaultValue = "";
			ValueDecimals = ValueDecimals_DefaultValue = null;
			ValuePrefix = ValuePrefix_DefaultValue = "";
			ValueSuffix = ValueSuffix_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Date format to use for points on datetime axes when describing themto screen reader users.Defaults to the same format as in tooltip.For an overview of the replacement codes, see[dateFormat](/class-reference/Highcharts#dateFormat).
		/// </summary>
		public string DateFormat { get; set; }
		private string DateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Formatter function to determine the date/time format used withpoints on datetime axes when describing them to screen reader users.Receives one argument, `point`, referring to the point to describe.Should return a date format string compatible with[dateFormat](/class-reference/Highcharts#dateFormat).
		/// </summary>
		public string DateFormatter { get; set; }
		private string DateFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Formatter function to use instead of the default for pointdescriptions.Receives one argument, `point`, referring to the point to describe.Should return a string with the description of the point for a screenreader user. If `false` is returned, the default formatter will beused for that point.
		/// </summary>
		public string DescriptionFormatter { get; set; }
		private string DescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decimals to use for the values in the point descriptions. Uses[tooltip.valueDecimals](#tooltip.valueDecimals) if not defined.
		/// </summary>
		public double? ValueDecimals { get; set; }
		private double? ValueDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// Prefix to add to the values in the point descriptions. Uses[tooltip.valuePrefix](#tooltip.valuePrefix) if not defined.
		/// </summary>
		public string ValuePrefix { get; set; }
		private string ValuePrefix_DefaultValue { get; set; }
		 

		/// <summary>
		/// Suffix to add to the values in the point descriptions. Uses[tooltip.valueSuffix](#tooltip.valueSuffix) if not defined.
		/// </summary>
		public string ValueSuffix { get; set; }
		private string ValueSuffix_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (DateFormat != DateFormat_DefaultValue) h.Add("dateFormat",DateFormat);
			if (DateFormatter != DateFormatter_DefaultValue) { h.Add("dateFormatter",DateFormatter); Highcharts.AddFunction("f8308bf6-2aa8-4abf-bb4b-eec6ae5c9e55.dateFormatter", DateFormatter); }  
			if (DescriptionFormatter != DescriptionFormatter_DefaultValue) { h.Add("descriptionFormatter",DescriptionFormatter); Highcharts.AddFunction("b1725d2e-92b6-4348-a60d-335fc17b0ce9.descriptionFormatter", DescriptionFormatter); }  
			if (ValueDecimals != ValueDecimals_DefaultValue) h.Add("valueDecimals",ValueDecimals);
			if (ValuePrefix != ValuePrefix_DefaultValue) h.Add("valuePrefix",ValuePrefix);
			if (ValueSuffix != ValueSuffix_DefaultValue) h.Add("valueSuffix",ValueSuffix);
			

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
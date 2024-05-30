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
	public partial class BellcurveSeriesAccessibilityPoint  : BaseObject
	{
		Hashtable h = new Hashtable();

		public BellcurveSeriesAccessibilityPoint()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Date format to use for points on datetime axes when describingthem to screen reader users.Defaults to the same format as in tooltip.For an overview of the replacement codes, see[dateFormat](/class-reference/Highcharts.Time#dateFormat).
		/// </summary>
		public string DateFormat { get; set; }
		private string DateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Formatter function to determine the date/time format used withpoints on datetime axes when describing them to screen readerusers. Receives one argument, `point`, referring to the pointto describe. Should return a date format string compatible with[dateFormat](/class-reference/Highcharts.Time#dateFormat).
		/// </summary>
		public string DateFormatter { get; set; }
		private string DateFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether or not to describe points with the value `null` toassistive technology, such as screen readers.
		/// </summary>
		public bool? DescribeNull { get; set; }
		private bool? DescribeNull_DefaultValue { get; set; }
		 

		/// <summary>
		/// A [format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)to use instead of the default for point descriptions.The context of the format string is the point instance.As opposed to [accessibility.point.valueDescriptionFormat](#accessibility.point.valueDescriptionFormat),this option replaces the whole description.
		/// </summary>
		public string DescriptionFormat { get; set; }
		private string DescriptionFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Formatter function to use instead of the default for pointdescriptions. Same as `accessibility.point.descriptionFormatter`, butapplies to a series instead of the whole chart.Note: Prefer using [accessibility.point.valueDescriptionFormat](#plotOptions.series.accessibility.point.valueDescriptionFormat)instead if possible, as default functionality such as describingannotations will be preserved.
		/// </summary>
		public string DescriptionFormatter { get; set; }
		private string DescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decimals to use for the values in the point descriptions. Uses[tooltip.valueDecimals](#tooltip.valueDecimals) if not defined.
		/// </summary>
		public double? ValueDecimals { get; set; }
		private double? ValueDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// Format to use for describing the values of data pointsto assistive technology - including screen readers.The point context is available as `{point}`.Other available context variables include `{index}`, `{value}`, and `{xDescription}`.Additionally, the series name, annotation info, anddescription added in `point.accessibility.description`is added by default if relevant. To override this, use the[accessibility.point.descriptionFormatter](#accessibility.point.descriptionFormatter)option.
		/// </summary>
		public string ValueDescriptionFormat { get; set; }
		private string ValueDescriptionFormat_DefaultValue { get; set; }
		 

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
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (DateFormat != null) h.Add("dateFormat",DateFormat);
			if (DateFormatter != null) { h.Add("dateFormatter",DateFormatter); highcharts.AddFunction("dateFormatter", DateFormatter); }  
			if (DescribeNull != null) h.Add("describeNull",DescribeNull);
			if (DescriptionFormat != null) h.Add("descriptionFormat",DescriptionFormat);
			if (DescriptionFormatter != null) { h.Add("descriptionFormatter",DescriptionFormatter); highcharts.AddFunction("descriptionFormatter", DescriptionFormatter); }  
			if (ValueDecimals != null) h.Add("valueDecimals",ValueDecimals);
			if (ValueDescriptionFormat != null) h.Add("valueDescriptionFormat",ValueDescriptionFormat);
			if (ValuePrefix != null) h.Add("valuePrefix",ValuePrefix);
			if (ValueSuffix != null) h.Add("valueSuffix",ValueSuffix);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}
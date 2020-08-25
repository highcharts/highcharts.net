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
	public partial class AccessibilitySeries  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AccessibilitySeries()
		{
			DescribeSingleSeries = DescribeSingleSeries_DefaultValue = false;
			DescriptionFormatter = DescriptionFormatter_DefaultValue = "";
			PointDescriptionEnabledThreshold = PointDescriptionEnabledThreshold_DefaultValue = 200;
			PointDescriptionEnabledThresholdBool = PointDescriptionEnabledThresholdBool_DefaultValue = null;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Whether or not to add series descriptions to charts with a singleseries.
		/// </summary>
		public bool? DescribeSingleSeries { get; set; }
		private bool? DescribeSingleSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// Formatter function to use instead of the default for seriesdescriptions. Receives one argument, `series`, referring to theseries to describe. Should return a string with the descriptionof the series for a screen reader user. If `false` is returned,the default formatter will be used for that series.
		/// </summary>
		public string DescriptionFormatter { get; set; }
		private string DescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains more points than this, we no longer exposeinformation about individual points to screen readers.Set to `false` to disable.
		/// </summary>
		public double? PointDescriptionEnabledThreshold { get; set; }
		private double? PointDescriptionEnabledThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains more points than this, we no longer exposeinformation about individual points to screen readers.Set to `false` to disable.
		/// </summary>
		public bool? PointDescriptionEnabledThresholdBool { get; set; }
		private bool? PointDescriptionEnabledThresholdBool_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (DescribeSingleSeries != DescribeSingleSeries_DefaultValue) h.Add("describeSingleSeries",DescribeSingleSeries);
			if (DescriptionFormatter != DescriptionFormatter_DefaultValue) { h.Add("descriptionFormatter",DescriptionFormatter); Highcharts.AddFunction("d3f45a9b-8563-4dc6-a081-ba7d752d632d.descriptionFormatter", DescriptionFormatter); }  
			if (PointDescriptionEnabledThreshold != PointDescriptionEnabledThreshold_DefaultValue) h.Add("pointDescriptionEnabledThreshold",PointDescriptionEnabledThreshold);
			if (PointDescriptionEnabledThresholdBool != PointDescriptionEnabledThresholdBool_DefaultValue) h.Add("pointDescriptionEnabledThreshold",PointDescriptionEnabledThresholdBool);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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
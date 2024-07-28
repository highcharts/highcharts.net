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
		}	
		

		/// <summary>
		/// Whether or not to add series descriptions to charts with a singleseries.
		/// </summary>
		public bool? DescribeSingleSeries { get; set; }
		 

		/// <summary>
		/// Format to use for describing the data series group to assistivetechnology - including screen readers.The series context and its subproperties are available under thevariable `{series}`, for example `{series.name}` for the seriesname, and `{series.points.length}` for the number of data points.The chart context and its subproperties are available under thevariable `{chart}`, for example `{chart.series.length}` for thenumber of series in the chart.`{seriesDescription}` refers to the automatic description of theseries type and number of points added by Highcharts by default.`{authorDescription}` refers to the description added in[series.description](#plotOptions.series.description) if one ispresent. `{axisDescription}` refers to the description added ifthe chart has multiple X or Y axes.Note that if [series.descriptionFormatter](#accessibility.series.descriptionFormatter)is declared it will take precedence, and this option will beoverridden.
		/// </summary>
		public string DescriptionFormat { get; set; }
		 

		/// <summary>
		/// Formatter function to use instead of the default for seriesdescriptions. Receives one argument, `series`, referring to theseries to describe. Should return a string with the descriptionof the series for a screen reader user. If `false` is returned,the default formatter will be used for that series.
		/// </summary>
		public string DescriptionFormatter { get; set; }
		 

		/// <summary>
		/// When a series contains more points than this, we no longer exposeinformation about individual points to screen readers.Set to `false` to disable.
		/// </summary>
		public double? PointDescriptionEnabledThreshold { get; set; }
		 

		/// <summary>
		/// When a series contains more points than this, we no longer exposeinformation about individual points to screen readers.Set to `false` to disable.
		/// </summary>
		public bool? PointDescriptionEnabledThresholdBool { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (DescribeSingleSeries != null) h.Add("describeSingleSeries",DescribeSingleSeries);
			if (DescriptionFormat != null) h.Add("descriptionFormat",DescriptionFormat);
			if (DescriptionFormatter != null) { h.Add("descriptionFormatter",DescriptionFormatter); highcharts.AddFunction("descriptionFormatter", DescriptionFormatter); }  
			if (PointDescriptionEnabledThreshold != null) h.Add("pointDescriptionEnabledThreshold",PointDescriptionEnabledThreshold);
			if (PointDescriptionEnabledThresholdBool != null) h.Add("pointDescriptionEnabledThreshold",PointDescriptionEnabledThresholdBool);
			if (CustomFields != null && CustomFields.Count > 0)
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
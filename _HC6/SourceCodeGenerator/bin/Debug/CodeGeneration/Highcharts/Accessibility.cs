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
	public partial class Accessibility  : BaseObject
	{
		public Accessibility()
		{
			Enabled = Enabled_DefaultValue = True;
			PointDescriptionThreshold = PointDescriptionThreshold_DefaultValue = False;
			DescribeSingleSeries = DescribeSingleSeries_DefaultValue = false;
			OnTableAnchorClick = OnTableAnchorClick_DefaultValue = "";
			PointDateFormat = PointDateFormat_DefaultValue = "";
			PointDateFormatter = PointDateFormatter_DefaultValue = "";
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			ScreenReaderSectionFormatter = ScreenReaderSectionFormatter_DefaultValue = "";
			SeriesDescriptionFormatter = SeriesDescriptionFormatter_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Enable accessibility features for the chart.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When a series contains more points than this, we no longer expose information about individual points to screen readers.</p><p>Set to <code>null</code> to disable.</p>
		/// </summary>
		public long? PointDescriptionThreshold { get; set; }
		private long? PointDescriptionThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether or not to add series descriptions to charts with a singleseries.
		/// </summary>
		public bool? DescribeSingleSeries { get; set; }
		private bool? DescribeSingleSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// Function to run upon clicking the "View as Data Table" link in thescreen reader region.By default Highcharts will insert and set focus to a data tablerepresentation of the chart.
		/// </summary>
		public string OnTableAnchorClick { get; set; }
		private string OnTableAnchorClick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Date format to use for points on datetime axes when describing themto screen reader users.Defaults to the same format as in tooltip.For an overview of the replacement codes, see[dateFormat](#Highcharts.dateFormat).
		/// </summary>
		public string PointDateFormat { get; set; }
		private string PointDateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Formatter function to determine the date/time format used withpoints on datetime axes when describing them to screen reader users.Receives one argument, `point`, referring to the point to describe.Should return a date format string compatible with[dateFormat](#Highcharts.dateFormat).
		/// </summary>
		public string PointDateFormatter { get; set; }
		private string PointDateFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Formatter function to use instead of the default for pointdescriptions.Receives one argument, `point`, referring to the point to describe.Should return a String with the description of the point for a screenreader user.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// A formatter function to create the HTML contents of the hidden screenreader information region. Receives one argument, `chart`, referringto the chart object. Should return a String with the HTML contentof the region.The link to view the chart as a data table will be addedautomatically after the custom HTML content.
		/// </summary>
		public string ScreenReaderSectionFormatter { get; set; }
		private string ScreenReaderSectionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Formatter function to use instead of the default for seriesdescriptions. Receives one argument, `series`, referring to theseries to describe. Should return a String with the description ofthe series for a screen reader user.
		/// </summary>
		public string SeriesDescriptionFormatter { get; set; }
		private string SeriesDescriptionFormatter_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (PointDescriptionThreshold != PointDescriptionThreshold_DefaultValue) h.Add("pointDescriptionThreshold",PointDescriptionThreshold);
			if (DescribeSingleSeries != DescribeSingleSeries_DefaultValue) h.Add("describeSingleSeries",DescribeSingleSeries);
			if (OnTableAnchorClick != OnTableAnchorClick_DefaultValue) h.Add("onTableAnchorClick",OnTableAnchorClick);
			if (PointDateFormat != PointDateFormat_DefaultValue) h.Add("pointDateFormat",PointDateFormat);
			if (PointDateFormatter != PointDateFormatter_DefaultValue) h.Add("pointDateFormatter",PointDateFormatter);
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) h.Add("pointDescriptionFormatter",PointDescriptionFormatter);
			if (ScreenReaderSectionFormatter != ScreenReaderSectionFormatter_DefaultValue) h.Add("screenReaderSectionFormatter",ScreenReaderSectionFormatter);
			if (SeriesDescriptionFormatter != SeriesDescriptionFormatter_DefaultValue) h.Add("seriesDescriptionFormatter",SeriesDescriptionFormatter);
			

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
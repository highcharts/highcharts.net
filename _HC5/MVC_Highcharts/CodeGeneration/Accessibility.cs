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
			DescribeSingleSeries = DescribeSingleSeries_DefaultValue = false;
			Enabled = Enabled_DefaultValue = true;
			KeyboardNavigation = KeyboardNavigation_DefaultValue = new AccessibilityKeyboardNavigation();
			OnTableAnchorClick = OnTableAnchorClick_DefaultValue = "";
			PointDateFormat = PointDateFormat_DefaultValue = null;
			PointDateFormatter = PointDateFormatter_DefaultValue = "";
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			PointDescriptionThreshold = PointDescriptionThreshold_DefaultValue = 30;
			ScreenReaderSectionFormatter = ScreenReaderSectionFormatter_DefaultValue = "";
			SeriesDescriptionFormatter = SeriesDescriptionFormatter_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Whether or not to add series descriptions to charts with a single series.
		/// </summary>
		public bool? DescribeSingleSeries { get; set; }
		private bool? DescribeSingleSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable accessibility features for the chart.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for keyboard navigation.
		/// </summary>
		public AccessibilityKeyboardNavigation KeyboardNavigation { get; set; }
		private AccessibilityKeyboardNavigation KeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Function to run upon clicking the "View as Data Table" link in the screen reader region.</p><p>By default Highcharts will insert and set focus to a data table representation of the chart.</p>
		/// </summary>
		public string OnTableAnchorClick { get; set; }
		private string OnTableAnchorClick_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Date format to use for points on datetime axes when describing them to screen reader users.</p><p>Defaults to the same format as in tooltip.</p><p>For an overview of the replacement codes, see <a href="#Highcharts.dateFormat">dateFormat</a>.</p>
		/// </summary>
		public string PointDateFormat { get; set; }
		private string PointDateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Formatter function to determine the date/time format used with points on datetime axes when describing them to screen reader users. Receives one argument, <code>point</code>, referring to the point to describe. Should return a date format string compatible with <a href="#Highcharts.dateFormat">dateFormat</a>.</p>
		/// </summary>
		public string PointDateFormatter { get; set; }
		private string PointDateFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Formatter function to use instead of the default for point descriptions. Receives one argument, <code>point</code>, referring to the point to describe. Should return a String with the description of the point for a screen reader user.</p>
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When a series contains more points than this, we no longer expose information about individual points to screen readers.</p><p>Set to <code>null</code> to disable.</p>
		/// </summary>
		public long? PointDescriptionThreshold { get; set; }
		private long? PointDescriptionThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A formatter function to create the HTML contents of the hidden screen reader information region. Receives one argument, <code>chart</code>, referring to the chart object. Should return a String with the HTML content of the region.</p><p>The link to view the chart as a data table will be added automatically after the custom HTML content.</p>
		/// </summary>
		public string ScreenReaderSectionFormatter { get; set; }
		private string ScreenReaderSectionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Formatter function to use instead of the default for series descriptions. Receives one argument, <code>series</code>, referring to the series to describe. Should return a String with the description of the series for a screen reader user.</p>
		/// </summary>
		public string SeriesDescriptionFormatter { get; set; }
		private string SeriesDescriptionFormatter_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (DescribeSingleSeries != DescribeSingleSeries_DefaultValue) h.Add("describeSingleSeries",DescribeSingleSeries);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (KeyboardNavigation.IsDirty()) h.Add("keyboardNavigation",KeyboardNavigation.ToHashtable());
			if (OnTableAnchorClick != OnTableAnchorClick_DefaultValue) { h.Add("onTableAnchorClick",OnTableAnchorClick); Highcharts.AddFunction("AccessibilityOnTableAnchorClick.onTableAnchorClick", OnTableAnchorClick); }  
			if (PointDateFormat != PointDateFormat_DefaultValue) h.Add("pointDateFormat",PointDateFormat);
			if (PointDateFormatter != PointDateFormatter_DefaultValue) { h.Add("pointDateFormatter",PointDateFormatter); Highcharts.AddFunction("AccessibilityPointDateFormatter.pointDateFormatter", PointDateFormatter); }  
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); Highcharts.AddFunction("AccessibilityPointDescriptionFormatter.pointDescriptionFormatter", PointDescriptionFormatter); }
            if (PointDescriptionThreshold != PointDescriptionThreshold_DefaultValue)
            {
                if (PointDescriptionThreshold != null)
                    h.Add("pointDescriptionThreshold", PointDescriptionThreshold);
                else
                    h.Add("pointDescriptionThreshold", false);
            }
			if (ScreenReaderSectionFormatter != ScreenReaderSectionFormatter_DefaultValue) { h.Add("screenReaderSectionFormatter",ScreenReaderSectionFormatter); Highcharts.AddFunction("AccessibilityScreenReaderSectionFormatter.screenReaderSectionFormatter", ScreenReaderSectionFormatter); }  
			if (SeriesDescriptionFormatter != SeriesDescriptionFormatter_DefaultValue) { h.Add("seriesDescriptionFormatter",SeriesDescriptionFormatter); Highcharts.AddFunction("AccessibilitySeriesDescriptionFormatter.seriesDescriptionFormatter", SeriesDescriptionFormatter); }  
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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
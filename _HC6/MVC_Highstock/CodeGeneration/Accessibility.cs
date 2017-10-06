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
	public partial class Accessibility  : BaseObject
	{
		public Accessibility()
		{
			Enabled = Enabled_DefaultValue = true;
			PointDescriptionThreshold = PointDescriptionThreshold_DefaultValue = 30;
			KeyboardNavigation = KeyboardNavigation_DefaultValue = new AccessibilityKeyboardNavigation();
			DescribeSingleSeries = DescribeSingleSeries_DefaultValue = false;
			OnTableAnchorClick = OnTableAnchorClick_DefaultValue = "";
			PointDateFormat = PointDateFormat_DefaultValue = null;
			PointDateFormatter = PointDateFormatter_DefaultValue = "";
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			ScreenReaderSectionFormatter = ScreenReaderSectionFormatter_DefaultValue = "";
			SeriesDescriptionFormatter = SeriesDescriptionFormatter_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// <p>Enable accessibility features for the chart.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When a series contains more points than this, we no longer expose information about individual points to screen readers.</p><p>Set to <code>null</code> to disable.</p>
		/// </summary>
		public long? PointDescriptionThreshold { get; set; }
		private long? PointDescriptionThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for keyboard navigation.</p>
		/// </summary>
		public AccessibilityKeyboardNavigation KeyboardNavigation { get; set; }
		private AccessibilityKeyboardNavigation KeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether or not to add series descriptions to charts with a singleseries.</p>
		/// </summary>
		public bool? DescribeSingleSeries { get; set; }
		private bool? DescribeSingleSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Function to run upon clicking the &quot;View as Data Table&quot; link in thescreen reader region.</p><p>By default Highcharts will insert and set focus to a data tablerepresentation of the chart.</p>
		/// </summary>
		public string OnTableAnchorClick { get; set; }
		private string OnTableAnchorClick_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Date format to use for points on datetime axes when describing themto screen reader users.</p><p>Defaults to the same format as in tooltip.</p><p>For an overview of the replacement codes, see<a href="#Highcharts.dateFormat">dateFormat</a>.</p>
		/// </summary>
		public string PointDateFormat { get; set; }
		private string PointDateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Formatter function to determine the date/time format used withpoints on datetime axes when describing them to screen reader users.Receives one argument, <code>point</code>, referring to the point to describe.Should return a date format string compatible with<a href="#Highcharts.dateFormat">dateFormat</a>.</p>
		/// </summary>
		public string PointDateFormatter { get; set; }
		private string PointDateFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Formatter function to use instead of the default for pointdescriptions.Receives one argument, <code>point</code>, referring to the point to describe.Should return a String with the description of the point for a screenreader user.</p>
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A formatter function to create the HTML contents of the hidden screenreader information region. Receives one argument, <code>chart</code>, referringto the chart object. Should return a String with the HTML contentof the region.</p><p>The link to view the chart as a data table will be addedautomatically after the custom HTML content.</p>
		/// </summary>
		public string ScreenReaderSectionFormatter { get; set; }
		private string ScreenReaderSectionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Formatter function to use instead of the default for seriesdescriptions. Receives one argument, <code>series</code>, referring to theseries to describe. Should return a String with the description ofthe series for a screen reader user.</p>
		/// </summary>
		public string SeriesDescriptionFormatter { get; set; }
		private string SeriesDescriptionFormatter_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (PointDescriptionThreshold != PointDescriptionThreshold_DefaultValue)
			{
				if (PointDescriptionThreshold != null)
					h.Add("pointDescriptionThreshold", PointDescriptionThreshold);
				else
					h.Add("pointDescriptionThreshold", false);
			}
			if (KeyboardNavigation.IsDirty()) h.Add("keyboardNavigation",KeyboardNavigation.ToHashtable());
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
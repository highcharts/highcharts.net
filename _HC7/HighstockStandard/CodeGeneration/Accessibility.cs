using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
			AddTableShortcut = AddTableShortcut_DefaultValue = true;
			AnnounceNewData = AnnounceNewData_DefaultValue = new AccessibilityAnnounceNewData();
			AxisRangeDateFormat = AxisRangeDateFormat_DefaultValue = "%Y-%m-%d %H:%M:%S";
			CustomComponents = CustomComponents_DefaultValue = new object();
			DescribeSingleSeries = DescribeSingleSeries_DefaultValue = false;
			Description = Description_DefaultValue = "";
			Enabled = Enabled_DefaultValue = true;
			HighContrastTheme = HighContrastTheme_DefaultValue = null;
			KeyboardNavigation = KeyboardNavigation_DefaultValue = new AccessibilityKeyboardNavigation();
			LandmarkVerbosity = LandmarkVerbosity_DefaultValue = AccessibilityLandmarkVerbosity.All;
			OnTableAnchorClick = OnTableAnchorClick_DefaultValue = "";
			PointDateFormat = PointDateFormat_DefaultValue = "";
			PointDateFormatter = PointDateFormatter_DefaultValue = "";
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			PointDescriptionThreshold = PointDescriptionThreshold_DefaultValue = 200;
			PointDescriptionThresholdBool = PointDescriptionThresholdBool_DefaultValue = null;
			PointNavigationThreshold = PointNavigationThreshold_DefaultValue = null;
			PointNavigationThresholdBool = PointNavigationThresholdBool_DefaultValue = null;
			PointValueDecimals = PointValueDecimals_DefaultValue = "";
			PointValuePrefix = PointValuePrefix_DefaultValue = "";
			PointValueSuffix = PointValueSuffix_DefaultValue = "";
			ScreenReaderSectionFormatter = ScreenReaderSectionFormatter_DefaultValue = "";
			SeriesDescriptionFormatter = SeriesDescriptionFormatter_DefaultValue = "";
			TypeDescription = TypeDescription_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Whether or not to add a shortcut button in the screen readerinformation region to show the data table.
		/// </summary>
		public bool? AddTableShortcut { get; set; }
		private bool? AddTableShortcut_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for announcing new data to screen reader users. Usefulfor dynamic data applications and drilldown.Keep in mind that frequent announcements will not be useful tousers, as they won't have time to explore the new data. For theseapplications, consider making snapshots of the data accessible, anddo the announcements in batches.
		/// </summary>
		public AccessibilityAnnounceNewData AnnounceNewData { get; set; }
		private AccessibilityAnnounceNewData AnnounceNewData_DefaultValue { get; set; }
		 

		/// <summary>
		/// Date format to use to describe range of datetime axes.For an overview of the replacement codes, see[dateFormat](/class-reference/Highcharts#dateFormat).
		/// </summary>
		public string AxisRangeDateFormat { get; set; }
		private string AxisRangeDateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// A hook for adding custom components to the accessibility module.Should be an object mapping component names to instances of classesinheriting from the Highcharts.AccessibilityComponent base class.Remember to add the component to the[keyboardNavigation.order](#accessibility.keyboardNavigation.order)for the keyboard navigation to be usable.
		/// </summary>
		public Object CustomComponents { get; set; }
		private Object CustomComponents_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether or not to add series descriptions to charts with a singleseries.
		/// </summary>
		public bool? DescribeSingleSeries { get; set; }
		private bool? DescribeSingleSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// A text description of the chart.**Note: Prefer using [caption](#caption.text) instead.**If the Accessibility module is loaded, this option is included bydefault as a long description of the chart in the hidden screenreader information region.Note: Since Highcharts now supports captions, it is preferred todefine the description there, as the caption benefits all users. Thecaption will be available to screen reader users. If this option isdefined instead, the caption is hidden from screen reader users.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable accessibility functionality for the chart.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Theme to apply to the chart when Windows High Contrast Mode isdetected.
		/// </summary>
		public Object HighContrastTheme { get; set; }
		private Object HighContrastTheme_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for keyboard navigation.
		/// </summary>
		public AccessibilityKeyboardNavigation KeyboardNavigation { get; set; }
		private AccessibilityKeyboardNavigation KeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Amount of landmarks/regions to create for screen reader users. Morelandmarks can make navigation with screen readers easier, but canbe distracting if there are lots of charts on the page. Three modesare available: - `all`: Adds regions for all series, legend, menu, information     region. - `one`: Adds a single landmark per chart. - `disabled`: No landmarks are added.
		/// </summary>
		public AccessibilityLandmarkVerbosity LandmarkVerbosity { get; set; }
		private AccessibilityLandmarkVerbosity LandmarkVerbosity_DefaultValue { get; set; }
		 

		/// <summary>
		/// Function to run upon clicking the "View as Data Table" link in thescreen reader region.By default Highcharts will insert and set focus to a data tablerepresentation of the chart.
		/// </summary>
		public string OnTableAnchorClick { get; set; }
		private string OnTableAnchorClick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Date format to use for points on datetime axes when describing themto screen reader users.Defaults to the same format as in tooltip.For an overview of the replacement codes, see[dateFormat](/class-reference/Highcharts#dateFormat).
		/// </summary>
		public string PointDateFormat { get; set; }
		private string PointDateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Formatter function to determine the date/time format used withpoints on datetime axes when describing them to screen reader users.Receives one argument, `point`, referring to the point to describe.Should return a date format string compatible with[dateFormat](/class-reference/Highcharts#dateFormat).
		/// </summary>
		public string PointDateFormatter { get; set; }
		private string PointDateFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Formatter function to use instead of the default for pointdescriptions.Receives one argument, `point`, referring to the point to describe.Should return a string with the description of the point for a screenreader user. If `false` is returned, the default formatter will beused for that point.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When a series contains more points than this, we no longer expose information about individual points to screen readers.</p><p>Set to <code>null</code> to disable.</p>
		/// </summary>
		public long? PointDescriptionThreshold { get; set; }
		private long? PointDescriptionThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains more points than this, we no longer exposeinformation about individual points to screen readers.Set to `false` to disable.
		/// </summary>
		public bool? PointDescriptionThresholdBool { get; set; }
		private bool? PointDescriptionThresholdBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains more points than this, we no longer allowkeyboard navigation for it.Set to `false` to disable.
		/// </summary>
		public double? PointNavigationThreshold { get; set; }
		private double? PointNavigationThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains more points than this, we no longer allowkeyboard navigation for it.Set to `false` to disable.
		/// </summary>
		public bool? PointNavigationThresholdBool { get; set; }
		private bool? PointNavigationThresholdBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decimals to use for the values in the point descriptions. Uses[tooltip.valueDecimals](#tooltip.valueDecimals) if not defined.
		/// </summary>
		public string PointValueDecimals { get; set; }
		private string PointValueDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// Prefix to add to the values in the point descriptions. Uses[tooltip.valuePrefix](#tooltip.valuePrefix) if not defined.
		/// </summary>
		public string PointValuePrefix { get; set; }
		private string PointValuePrefix_DefaultValue { get; set; }
		 

		/// <summary>
		/// Suffix to add to the values in the point descriptions. Uses[tooltip.valueSuffix](#tooltip.valueSuffix) if not defined.
		/// </summary>
		public string PointValueSuffix { get; set; }
		private string PointValueSuffix_DefaultValue { get; set; }
		 

		/// <summary>
		/// A formatter function to create the HTML contents of the hidden screenreader information region. Receives one argument, `chart`, referringto the chart object. Should return a string with the HTML contentof the region. By default this returns an automatic description ofthe chart.The button to view the chart as a data table will be addedautomatically after the custom HTML content if enabled.
		/// </summary>
		public string ScreenReaderSectionFormatter { get; set; }
		private string ScreenReaderSectionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Formatter function to use instead of the default for seriesdescriptions. Receives one argument, `series`, referring to theseries to describe. Should return a string with the description ofthe series for a screen reader user. If `false` is returned, thedefault formatter will be used for that series.
		/// </summary>
		public string SeriesDescriptionFormatter { get; set; }
		private string SeriesDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// A text description of the chart type.If the Accessibility module is loaded, this will be included in thedescription of the chart in the screen reader information region.Highcharts will by default attempt to guess the chart type, but formore complex charts it is recommended to specify this property forclarity.
		/// </summary>
		public string TypeDescription { get; set; }
		private string TypeDescription_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AddTableShortcut != AddTableShortcut_DefaultValue) h.Add("addTableShortcut",AddTableShortcut);
			if (AnnounceNewData.IsDirty()) h.Add("announceNewData",AnnounceNewData.ToHashtable());
			if (AxisRangeDateFormat != AxisRangeDateFormat_DefaultValue) h.Add("axisRangeDateFormat",AxisRangeDateFormat);
			if (CustomComponents != CustomComponents_DefaultValue) h.Add("customComponents",CustomComponents);
			if (DescribeSingleSeries != DescribeSingleSeries_DefaultValue) h.Add("describeSingleSeries",DescribeSingleSeries);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (HighContrastTheme != HighContrastTheme_DefaultValue) h.Add("highContrastTheme",HighContrastTheme);
			if (KeyboardNavigation.IsDirty()) h.Add("keyboardNavigation",KeyboardNavigation.ToHashtable());
			if (LandmarkVerbosity != LandmarkVerbosity_DefaultValue) h.Add("landmarkVerbosity", Highstock.FirstCharacterToLower(LandmarkVerbosity.ToString()));
			if (OnTableAnchorClick != OnTableAnchorClick_DefaultValue) { h.Add("onTableAnchorClick",OnTableAnchorClick); Highstock.AddFunction("AccessibilityOnTableAnchorClick.onTableAnchorClick", OnTableAnchorClick); }  
			if (PointDateFormat != PointDateFormat_DefaultValue) h.Add("pointDateFormat",PointDateFormat);
			if (PointDateFormatter != PointDateFormatter_DefaultValue) { h.Add("pointDateFormatter",PointDateFormatter); Highstock.AddFunction("AccessibilityPointDateFormatter.pointDateFormatter", PointDateFormatter); }  
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); Highstock.AddFunction("AccessibilityPointDescriptionFormatter.pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (PointDescriptionThreshold != PointDescriptionThreshold_DefaultValue)
			{
				if (PointDescriptionThreshold != null)
					h.Add("pointDescriptionThreshold", PointDescriptionThreshold);
				else
					h.Add("pointDescriptionThreshold", false);
			}
			if (PointDescriptionThresholdBool != PointDescriptionThresholdBool_DefaultValue) h.Add("pointDescriptionThreshold",PointDescriptionThresholdBool);
			if (PointNavigationThreshold != PointNavigationThreshold_DefaultValue) h.Add("pointNavigationThreshold",PointNavigationThreshold);
			if (PointNavigationThresholdBool != PointNavigationThresholdBool_DefaultValue) h.Add("pointNavigationThreshold",PointNavigationThresholdBool);
			if (PointValueDecimals != PointValueDecimals_DefaultValue) h.Add("pointValueDecimals",PointValueDecimals);
			if (PointValuePrefix != PointValuePrefix_DefaultValue) h.Add("pointValuePrefix",PointValuePrefix);
			if (PointValueSuffix != PointValueSuffix_DefaultValue) h.Add("pointValueSuffix",PointValueSuffix);
			if (ScreenReaderSectionFormatter != ScreenReaderSectionFormatter_DefaultValue) { h.Add("screenReaderSectionFormatter",ScreenReaderSectionFormatter); Highstock.AddFunction("AccessibilityScreenReaderSectionFormatter.screenReaderSectionFormatter", ScreenReaderSectionFormatter); }  
			if (SeriesDescriptionFormatter != SeriesDescriptionFormatter_DefaultValue) { h.Add("seriesDescriptionFormatter",SeriesDescriptionFormatter); Highstock.AddFunction("AccessibilitySeriesDescriptionFormatter.seriesDescriptionFormatter", SeriesDescriptionFormatter); }  
			if (TypeDescription != TypeDescription_DefaultValue) h.Add("typeDescription",TypeDescription);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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
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
	public partial class Accessibility  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Accessibility()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Options for announcing new data to screen reader users. Usefulfor dynamic data applications and drilldown.Keep in mind that frequent announcements will not be useful tousers, as they won't have time to explore the new data. For theseapplications, consider making snapshots of the data accessible, anddo the announcements in batches.
		/// </summary>
		public AccessibilityAnnounceNewData AnnounceNewData { get; set; }
		private AccessibilityAnnounceNewData AnnounceNewData_DefaultValue { get; set; }
		 

		/// <summary>
		/// A hook for adding custom components to the accessibility module.Should be an object mapping component names to instances of classesinheriting from the Highcharts.AccessibilityComponent base class.Remember to add the component to the[keyboardNavigation.order](#accessibility.keyboardNavigation.order)for the keyboard navigation to be usable.
		/// </summary>
		public Object CustomComponents { get; set; }
		private Object CustomComponents_DefaultValue { get; set; }
		 

		/// <summary>
		/// A text description of the chart.**Note: Prefer using [linkedDescription](#accessibility.linkedDescription)or [caption](#caption.text) instead.**If the Accessibility module is loaded, this option is included bydefault as a long description of the chart in the hidden screenreader information region.Note: Since Highcharts now supports captions and linked descriptions,it is preferred to define the description using those methods, as avisible caption/description benefits all users. If the`accessibility.description` option is defined, the linked descriptionis ignored, and the caption is hidden from screen reader users.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable accessibility functionality for the chart. For moreinformation on how to include these features, and why this isrecommended, see [Highcharts Accessibility](https://www.highcharts.com/docs/accessibility/accessibility-module).Highcharts will by default emit a warning to the console ifthe [accessibility module](https://code.highcharts.com/modules/accessibility.js)is not loaded. Setting this option to `false` will overrideand silence the warning.Once the module is loaded, setting this option to `false`will disable the module for this chart.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Controls how [highContrastTheme](#accessibility.highContrastTheme)is applied.The default option is `auto`, which applies the high contrast themethe user's system has a high contrast theme active.
		/// </summary>
		public string HighContrastMode { get; set; }
		private string HighContrastMode_DefaultValue { get; set; }
		 

		/// <summary>
		/// Theme to apply to the chart when Windows High Contrast Mode isdetected. By default, a high contrast theme matching the highcontrast system colors is used.
		/// </summary>
		public Object HighContrastTheme { get; set; }
		private Object HighContrastTheme_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for keyboard navigation.
		/// </summary>
		public AccessibilityKeyboardNavigation KeyboardNavigation { get; set; }
		private AccessibilityKeyboardNavigation KeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Amount of landmarks/regions to create for screen reader users. Morelandmarks can make navigation with screen readers easier, but canbe distracting if there are lots of charts on the page. Three modesare available: - `all`: Adds regions for all series, legend, information     region. - `one`: Adds a single landmark per chart. - `disabled`: No landmarks are added.
		/// </summary>
		public AccessibilityLandmarkVerbosity LandmarkVerbosity { get; set; }
		private AccessibilityLandmarkVerbosity LandmarkVerbosity_DefaultValue { get; set; }
		 

		/// <summary>
		/// Link the chart to an HTML element describing the contents of thechart.It is always recommended to describe charts using visible text, toimprove SEO as well as accessibility for users with disabilities.This option lets an HTML element with a description be linked to thechart, so that screen reader users can connect the two.By setting this option to a string, Highcharts runs the string as anHTML selector query on the entire document. If there is only a singlematch, this element is linked to the chart. The content of the linkedelement will be included in the chart description for screen readerusers.By default, the chart looks for an adjacent sibling element with the`highcharts-description` class.The feature can be disabled by setting the option to an empty string,or overridden by providing the[accessibility.description](#accessibility.description) option.Alternatively, the HTML element to link can be passed in directly asan HTML node.If you need the description to be part of the exported image,consider using the [caption](#caption) feature.If you need the description to be hidden visually, use the[accessibility.description](#accessibility.description) option.
		/// </summary>
		public string LinkedDescription { get; set; }
		private string LinkedDescription_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for descriptions of individual data points.
		/// </summary>
		public AccessibilityPoint Point { get; set; }
		private AccessibilityPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// Accessibility options for the screen reader information sectionsadded before and after the chart.
		/// </summary>
		public AccessibilityScreenReaderSection ScreenReaderSection { get; set; }
		private AccessibilityScreenReaderSection ScreenReaderSection_DefaultValue { get; set; }
		 

		/// <summary>
		/// Accessibility options global to all data series. Individual seriescan also have specific [accessibility options](#plotOptions.series.accessibility)set.
		/// </summary>
		public List<Series> Series { get; set; }
		private List<Series> Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// A text description of the chart type.If the Accessibility module is loaded, this will be included in thedescription of the chart in the screen reader information region.Highcharts will by default attempt to guess the chart type, but formore complex charts it is recommended to specify this property forclarity.
		/// </summary>
		public string TypeDescription { get; set; }
		private string TypeDescription_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (AnnounceNewData != null) h.Add("announceNewData",AnnounceNewData.ToHashtable(highcharts));
			if (CustomComponents != null) h.Add("customComponents",CustomComponents);
			if (Description != null) h.Add("description",Description);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (HighContrastMode != null) h.Add("highContrastMode",HighContrastMode);
			if (HighContrastTheme != null) h.Add("highContrastTheme",HighContrastTheme);
			if (KeyboardNavigation != null) h.Add("keyboardNavigation",KeyboardNavigation.ToHashtable(highcharts));
			if (LandmarkVerbosity != AccessibilityLandmarkVerbosity.Null) h.Add("landmarkVerbosity", highcharts.FirstCharacterToLower(LandmarkVerbosity.ToString()));
			if (LinkedDescription != null) h.Add("linkedDescription",LinkedDescription);
			if (Point != null) h.Add("point",Point.ToHashtable(highcharts));
			if (ScreenReaderSection != null) h.Add("screenReaderSection",ScreenReaderSection.ToHashtable(highcharts));
			if (Series != null) h.Add("series",Series);
			if (TypeDescription != null) h.Add("typeDescription",TypeDescription);
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
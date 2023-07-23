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
	public partial class PlotOptionsColumnAccessibility  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsColumnAccessibility()
		{
			Description = Description_DefaultValue = "";
			DescriptionFormat = DescriptionFormat_DefaultValue = "";
			Enabled = Enabled_DefaultValue = null;
			ExposeAsGroupOnly = ExposeAsGroupOnly_DefaultValue = null;
			KeyboardNavigation = KeyboardNavigation_DefaultValue = new PlotOptionsColumnAccessibilityKeyboardNavigation();
			Point = Point_DefaultValue = new PlotOptionsColumnAccessibilityPoint();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Provide a description of the series, announced to screen readers.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Format to use for describing the data series group to assistivetechnology - including screen readers.
		/// </summary>
		public string DescriptionFormat { get; set; }
		private string DescriptionFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable/disable accessibility functionality for a specific series.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Expose only the series element to screen readers, not its points.
		/// </summary>
		public bool? ExposeAsGroupOnly { get; set; }
		private bool? ExposeAsGroupOnly_DefaultValue { get; set; }
		 

		/// <summary>
		/// Keyboard navigation for a series
		/// </summary>
		public PlotOptionsColumnAccessibilityKeyboardNavigation KeyboardNavigation { get; set; }
		private PlotOptionsColumnAccessibilityKeyboardNavigation KeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point accessibility options for a series.
		/// </summary>
		public PlotOptionsColumnAccessibilityPoint Point { get; set; }
		private PlotOptionsColumnAccessibilityPoint Point_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (DescriptionFormat != DescriptionFormat_DefaultValue) h.Add("descriptionFormat",DescriptionFormat);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (ExposeAsGroupOnly != ExposeAsGroupOnly_DefaultValue) h.Add("exposeAsGroupOnly",ExposeAsGroupOnly);
			if (KeyboardNavigation.IsDirty(highcharts)) h.Add("keyboardNavigation",KeyboardNavigation.ToHashtable(highcharts));
			if (Point.IsDirty(highcharts)) h.Add("point",Point.ToHashtable(highcharts));
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
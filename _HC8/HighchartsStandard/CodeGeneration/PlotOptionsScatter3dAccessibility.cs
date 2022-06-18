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
	public partial class PlotOptionsScatter3dAccessibility  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsScatter3dAccessibility()
		{
			Description = Description_DefaultValue = "";
			Enabled = Enabled_DefaultValue = null;
			ExposeAsGroupOnly = ExposeAsGroupOnly_DefaultValue = null;
			KeyboardNavigation = KeyboardNavigation_DefaultValue = new PlotOptionsScatter3dAccessibilityKeyboardNavigation();
			Point = Point_DefaultValue = new PlotOptionsScatter3dAccessibilityPoint();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Provide a description of the series, announced to screen readers.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

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
		public PlotOptionsScatter3dAccessibilityKeyboardNavigation KeyboardNavigation { get; set; }
		private PlotOptionsScatter3dAccessibilityKeyboardNavigation KeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point accessibility options for a series.
		/// </summary>
		public PlotOptionsScatter3dAccessibilityPoint Point { get; set; }
		private PlotOptionsScatter3dAccessibilityPoint Point_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (ExposeAsGroupOnly != ExposeAsGroupOnly_DefaultValue) h.Add("exposeAsGroupOnly",ExposeAsGroupOnly);
			if (KeyboardNavigation.IsDirty(ref highcharts)) h.Add("keyboardNavigation",KeyboardNavigation.ToHashtable(ref highcharts));
			if (Point.IsDirty(ref highcharts)) h.Add("point",Point.ToHashtable(ref highcharts));
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}
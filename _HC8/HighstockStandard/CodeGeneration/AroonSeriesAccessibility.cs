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
	public partial class AroonSeriesAccessibility  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AroonSeriesAccessibility()
		{
			Description = Description_DefaultValue = "";
			Enabled = Enabled_DefaultValue = null;
			ExposeAsGroupOnly = ExposeAsGroupOnly_DefaultValue = null;
			KeyboardNavigation = KeyboardNavigation_DefaultValue = new AroonSeriesAccessibilityKeyboardNavigation();
			Point = Point_DefaultValue = new AroonSeriesAccessibilityPoint();
			
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
		public AroonSeriesAccessibilityKeyboardNavigation KeyboardNavigation { get; set; }
		private AroonSeriesAccessibilityKeyboardNavigation KeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point accessibility options for a series.
		/// </summary>
		public AroonSeriesAccessibilityPoint Point { get; set; }
		private AroonSeriesAccessibilityPoint Point_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (ExposeAsGroupOnly != ExposeAsGroupOnly_DefaultValue) h.Add("exposeAsGroupOnly",ExposeAsGroupOnly);
			if (KeyboardNavigation.IsDirty(highstock)) h.Add("keyboardNavigation",KeyboardNavigation.ToHashtable(highstock));
			if (Point.IsDirty(highstock)) h.Add("point",Point.ToHashtable(highstock));
			

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}
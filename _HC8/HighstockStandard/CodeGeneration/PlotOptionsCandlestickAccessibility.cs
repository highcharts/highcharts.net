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
	public partial class PlotOptionsCandlestickAccessibility  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsCandlestickAccessibility()
		{
			Description = Description_DefaultValue = "";
			Enabled = Enabled_DefaultValue = null;
			ExposeAsGroupOnly = ExposeAsGroupOnly_DefaultValue = null;
			KeyboardNavigation = KeyboardNavigation_DefaultValue = new PlotOptionsCandlestickAccessibilityKeyboardNavigation();
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			
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
		public PlotOptionsCandlestickAccessibilityKeyboardNavigation KeyboardNavigation { get; set; }
		private PlotOptionsCandlestickAccessibilityKeyboardNavigation KeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Formatter function to use instead of the default for pointdescriptions. Same as `accessibility.point.descriptionFormatter`, but fora single series.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (ExposeAsGroupOnly != ExposeAsGroupOnly_DefaultValue) h.Add("exposeAsGroupOnly",ExposeAsGroupOnly);
			if (KeyboardNavigation.IsDirty()) h.Add("keyboardNavigation",KeyboardNavigation.ToHashtable());
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); Highstock.AddFunction("PlotOptionsCandlestickAccessibilityPointDescriptionFormatter.pointDescriptionFormatter", PointDescriptionFormatter); }  
			

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
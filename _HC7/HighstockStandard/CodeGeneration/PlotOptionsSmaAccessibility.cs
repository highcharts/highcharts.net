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
	public partial class PlotOptionsSmaAccessibility  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSmaAccessibility()
		{
		}	
		

		/// <summary>
		/// Provide a description of the series, announced to screen readers.
		/// </summary>
		public string Description { get; set; }
		 

		/// <summary>
		/// Format to use for describing the data series group to assistivetechnology - including screen readers.
		/// </summary>
		public string DescriptionFormat { get; set; }
		 

		/// <summary>
		/// Enable/disable accessibility functionality for a specific series.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Expose only the series element to screen readers, not its points.
		/// </summary>
		public bool? ExposeAsGroupOnly { get; set; }
		 

		/// <summary>
		/// Keyboard navigation for a series
		/// </summary>
		public PlotOptionsSmaAccessibilityKeyboardNavigation KeyboardNavigation { get; set; }
		 

		/// <summary>
		/// Point accessibility options for a series.
		/// </summary>
		public PlotOptionsSmaAccessibilityPoint Point { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Description != null) h.Add("description",Description);
			if (DescriptionFormat != null) h.Add("descriptionFormat",DescriptionFormat);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (ExposeAsGroupOnly != null) h.Add("exposeAsGroupOnly",ExposeAsGroupOnly);
			if (KeyboardNavigation != null) h.Add("keyboardNavigation",KeyboardNavigation.ToHashtable(highstock));
			if (Point != null) h.Add("point",Point.ToHashtable(highstock));
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
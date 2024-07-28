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
	public partial class AccessibilityKeyboardNavigationFocusBorder  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AccessibilityKeyboardNavigationFocusBorder()
		{
		}	
		

		/// <summary>
		/// Enable/disable focus border for chart.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Hide the browser's default focus indicator.
		/// </summary>
		public bool? HideBrowserFocusOutline { get; set; }
		 

		/// <summary>
		/// Focus border margin around the elements.
		/// </summary>
		public double? Margin { get; set; }
		 

		/// <summary>
		/// Style options for the focus border drawn around elementswhile navigating through them. Note that some browsers inaddition draw their own borders for focused elements. Theseautomatic borders cannot be styled by Highcharts.In styled mode, the border is given the`.highcharts-focus-border` class.
		/// </summary>
		public Hashtable Style { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Enabled != null) h.Add("enabled",Enabled);
			if (HideBrowserFocusOutline != null) h.Add("hideBrowserFocusOutline",HideBrowserFocusOutline);
			if (Margin != null) h.Add("margin",Margin);
			if (Style != null) h.Add("style",Style);
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
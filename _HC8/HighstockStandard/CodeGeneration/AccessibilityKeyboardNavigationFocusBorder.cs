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
	public partial class AccessibilityKeyboardNavigationFocusBorder  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AccessibilityKeyboardNavigationFocusBorder()
		{
			Enabled = Enabled_DefaultValue = true;
			HideBrowserFocusOutline = HideBrowserFocusOutline_DefaultValue = true;
			Margin = Margin_DefaultValue = null;
			Style = Style_DefaultValue = new Hashtable();
			
		}	
		

		/// <summary>
		/// Enable/disable focus border for chart.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Hide the browser's default focus indicator.
		/// </summary>
		public bool? HideBrowserFocusOutline { get; set; }
		private bool? HideBrowserFocusOutline_DefaultValue { get; set; }
		 

		/// <summary>
		/// Focus border margin around the elements.
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// Style options for the focus border drawn around elementswhile navigating through them. Note that some browsers inaddition draw their own borders for focused elements. Theseautomatic borders can not be styled by Highcharts.In styled mode, the border is given the`.highcharts-focus-border` class.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (HideBrowserFocusOutline != HideBrowserFocusOutline_DefaultValue) h.Add("hideBrowserFocusOutline",HideBrowserFocusOutline);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}
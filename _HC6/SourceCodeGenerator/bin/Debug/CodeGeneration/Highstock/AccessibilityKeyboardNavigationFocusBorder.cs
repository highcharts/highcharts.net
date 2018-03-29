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
	public partial class AccessibilityKeyboardNavigationFocusBorder  : BaseObject
	{
		public AccessibilityKeyboardNavigationFocusBorder()
		{
			Enabled = Enabled_DefaultValue = true;
			HideBrowserFocusOutline = HideBrowserFocusOutline_DefaultValue = true;
			Style = Style_DefaultValue = new AccessibilityKeyboardNavigationFocusBorderStyle();
			Margin = Margin_DefaultValue = null;
			
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
		/// Style options for the focus border drawn around elements while navigating through them. Note that some browsers in addition draw their own borders for focused elements. Theseautomatic borders can not be styled by Highcharts.In styled mode, the border is given the `.highcharts-focus-border` class.
		/// </summary>
		public AccessibilityKeyboardNavigationFocusBorderStyle Style { get; set; }
		private AccessibilityKeyboardNavigationFocusBorderStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Focus border margin around the elements.
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (HideBrowserFocusOutline != HideBrowserFocusOutline_DefaultValue) h.Add("hideBrowserFocusOutline",HideBrowserFocusOutline);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			

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
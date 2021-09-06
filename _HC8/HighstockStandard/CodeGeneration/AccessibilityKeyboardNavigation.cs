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
	public partial class AccessibilityKeyboardNavigation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AccessibilityKeyboardNavigation()
		{
			Enabled = Enabled_DefaultValue = true;
			FocusBorder = FocusBorder_DefaultValue = new AccessibilityKeyboardNavigationFocusBorder();
			Order = Order_DefaultValue = new List<string>();
			SeriesNavigation = SeriesNavigation_DefaultValue = new AccessibilityKeyboardNavigationSeriesNavigation();
			WrapAround = WrapAround_DefaultValue = true;
			
		}	
		

		/// <summary>
		/// Enable keyboard navigation for the chart.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the focus border drawn around elements whilenavigating through them.
		/// </summary>
		public AccessibilityKeyboardNavigationFocusBorder FocusBorder { get; set; }
		private AccessibilityKeyboardNavigationFocusBorder FocusBorder_DefaultValue { get; set; }
		 

		/// <summary>
		/// Order of tab navigation in the chart. Determines which elementsare tabbed to first. Available elements are: `series`, `zoom`,`rangeSelector`, `chartMenu`, `legend` and `container`. Inaddition, any custom components can be added here. Adding`container` first in order will make the keyboard focus stop onthe chart container first, requiring the user to tab again toenter the chart.
		/// </summary>
		public List<string> Order { get; set; }
		private List<string> Order_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the keyboard navigation of data points and series.
		/// </summary>
		public AccessibilityKeyboardNavigationSeriesNavigation SeriesNavigation { get; set; }
		private AccessibilityKeyboardNavigationSeriesNavigation SeriesNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether or not to wrap around when reaching the end of arrow-keynavigation for an element in the chart.
		/// </summary>
		public bool? WrapAround { get; set; }
		private bool? WrapAround_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (FocusBorder.IsDirty(ref highstock)) h.Add("focusBorder",FocusBorder.ToHashtable(ref highstock));
			if (Order != Order_DefaultValue) h.Add("order",Order);
			if (SeriesNavigation.IsDirty(ref highstock)) h.Add("seriesNavigation",SeriesNavigation.ToHashtable(ref highstock));
			if (WrapAround != WrapAround_DefaultValue) h.Add("wrapAround",WrapAround);
			

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
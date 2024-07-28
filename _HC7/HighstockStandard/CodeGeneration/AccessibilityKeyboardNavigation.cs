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
		}	
		

		/// <summary>
		/// Enable keyboard navigation for the chart.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Options for the focus border drawn around elements whilenavigating through them.
		/// </summary>
		public AccessibilityKeyboardNavigationFocusBorder FocusBorder { get; set; }
		 

		/// <summary>
		/// Order of tab navigation in the chart. Determines which elementsare tabbed to first. Available elements are: `series`, `zoom`,`rangeSelector`, `navigator`, `chartMenu`, `legend` and `container`.In addition, any custom components can be added here. Adding`container` first in order will make the keyboard focus stop onthe chart container first, requiring the user to tab again toenter the chart.
		/// </summary>
		public List<string> Order { get; set; }
		 

		/// <summary>
		/// Options for the keyboard navigation of data points and series.
		/// </summary>
		public AccessibilityKeyboardNavigationSeriesNavigation SeriesNavigation { get; set; }
		 

		/// <summary>
		/// Whether or not to wrap around when reaching the end of arrow-keynavigation for an element in the chart.
		/// </summary>
		public bool? WrapAround { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Enabled != null) h.Add("enabled",Enabled);
			if (FocusBorder != null) h.Add("focusBorder",FocusBorder.ToHashtable(highstock));
			if (Order != null) h.Add("order",Order);
			if (SeriesNavigation != null) h.Add("seriesNavigation",SeriesNavigation.ToHashtable(highstock));
			if (WrapAround != null) h.Add("wrapAround",WrapAround);
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
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
	public partial class AccessibilityKeyboardNavigationSeriesNavigation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AccessibilityKeyboardNavigationSeriesNavigation()
		{
		}	
		

		/// <summary>
		/// Set the keyboard navigation mode for the chart. Can be"normal" or "serialize". In normal mode, left/right arrowkeys move between points in a series, while up/down arrowkeys move between series. Up/down navigation actsintelligently to figure out which series makes sense to moveto from any given point.In "serialize" mode, points are instead navigated as a singlelist. Left/right behaves as in "normal" mode. Up/down arrowkeys will behave like left/right. This can be useful forunifying navigation behavior with/without screen readersenabled.
		/// </summary>
		public AccessibilityKeyboardNavigationSeriesNavigationMode Mode { get; set; }
		 

		/// <summary>
		/// When a series contains more points than this, we no longerallow keyboard navigation for it.Set to `false` to disable.
		/// </summary>
		public double? PointNavigationEnabledThreshold { get; set; }
		 

		/// <summary>
		/// When a series contains more points than this, we no longerallow keyboard navigation for it.Set to `false` to disable.
		/// </summary>
		public bool? PointNavigationEnabledThresholdBool { get; set; }
		 

		/// <summary>
		/// Remember which point was focused even after navigating awayfrom the series, so that when navigating back to the seriesyou start at the last focused point.
		/// </summary>
		public bool? RememberPointFocus { get; set; }
		 

		/// <summary>
		/// Skip null points when navigating through points with thekeyboard.
		/// </summary>
		public bool? SkipNullPoints { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Mode != AccessibilityKeyboardNavigationSeriesNavigationMode.Null) h.Add("mode", highstock.FirstCharacterToLower(Mode.ToString()));
			if (PointNavigationEnabledThreshold != null) h.Add("pointNavigationEnabledThreshold",PointNavigationEnabledThreshold);
			if (PointNavigationEnabledThresholdBool != null) h.Add("pointNavigationEnabledThreshold",PointNavigationEnabledThresholdBool);
			if (RememberPointFocus != null) h.Add("rememberPointFocus",RememberPointFocus);
			if (SkipNullPoints != null) h.Add("skipNullPoints",SkipNullPoints);
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
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
			Mode = Mode_DefaultValue = AccessibilityKeyboardNavigationSeriesNavigationMode.Normal;
			PointNavigationEnabledThreshold = PointNavigationEnabledThreshold_DefaultValue = null;
			PointNavigationEnabledThresholdBool = PointNavigationEnabledThresholdBool_DefaultValue = false;
			RememberPointFocus = RememberPointFocus_DefaultValue = false;
			SkipNullPoints = SkipNullPoints_DefaultValue = true;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Set the keyboard navigation mode for the chart. Can be"normal" or "serialize". In normal mode, left/right arrowkeys move between points in a series, while up/down arrowkeys move between series. Up/down navigation actsintelligently to figure out which series makes sense to moveto from any given point.In "serialize" mode, points are instead navigated as a singlelist. Left/right behaves as in "normal" mode. Up/down arrowkeys will behave like left/right. This can be useful forunifying navigation behavior with/without screen readersenabled.
		/// </summary>
		public AccessibilityKeyboardNavigationSeriesNavigationMode Mode { get; set; }
		private AccessibilityKeyboardNavigationSeriesNavigationMode Mode_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains more points than this, we no longerallow keyboard navigation for it.Set to `false` to disable.
		/// </summary>
		public double? PointNavigationEnabledThreshold { get; set; }
		private double? PointNavigationEnabledThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains more points than this, we no longerallow keyboard navigation for it.Set to `false` to disable.
		/// </summary>
		public bool? PointNavigationEnabledThresholdBool { get; set; }
		private bool? PointNavigationEnabledThresholdBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// Remember which point was focused even after navigating awayfrom the series, so that when navigating back to the seriesyou start at the last focused point.
		/// </summary>
		public bool? RememberPointFocus { get; set; }
		private bool? RememberPointFocus_DefaultValue { get; set; }
		 

		/// <summary>
		/// Skip null points when navigating through points with thekeyboard.
		/// </summary>
		public bool? SkipNullPoints { get; set; }
		private bool? SkipNullPoints_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Mode != Mode_DefaultValue) h.Add("mode", highstock.FirstCharacterToLower(Mode.ToString()));
			if (PointNavigationEnabledThreshold != PointNavigationEnabledThreshold_DefaultValue) h.Add("pointNavigationEnabledThreshold",PointNavigationEnabledThreshold);
			if (PointNavigationEnabledThresholdBool != PointNavigationEnabledThresholdBool_DefaultValue) h.Add("pointNavigationEnabledThreshold",PointNavigationEnabledThresholdBool);
			if (RememberPointFocus != RememberPointFocus_DefaultValue) h.Add("rememberPointFocus",RememberPointFocus);
			if (SkipNullPoints != SkipNullPoints_DefaultValue) h.Add("skipNullPoints",SkipNullPoints);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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
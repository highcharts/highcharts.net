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
	public partial class Global  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Global()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// General theme for buttons. This applies to the zoom button, exportingcontext menu, map navigation, range selector buttons and custombuttons generated using the `SVGRenderer.button` function. However,each of these may be overridden with more specific options.
		/// </summary>
		public GlobalButtonTheme ButtonTheme { get; set; }
		 

		/// <summary>
		/// _Canvg rendering for Android 2.x is removed as of Highcharts 5.0\.Use the [libURL](#exporting.libURL) option to configure exporting._The URL to the additional file to lazy load for Android 2.x devices.These devices don't support SVG, so we download a helper file thatcontains [canvg](https://github.com/canvg/canvg), its dependencyrbcolor, and our own CanVG Renderer class. To avoid hotlinking toour site, you can install canvas-tools.js on your own server andchange this option accordingly.
		/// </summary>
		public string CanvasToolsURL { get; set; }
		 

		/// <summary>
		/// This option is deprecated since v6.0.5. Instead, use[time.Date](#time.Date) that supports individual time settingsper chart.
		/// </summary>
		public Object Date { get; set; }
		 

		/// <summary>
		/// This option is deprecated since v6.0.5. Instead, use[time.getTimezoneOffset](#time.getTimezoneOffset) that supportsindividual time settings per chart.
		/// </summary>
		public string GetTimezoneOffset { get; set; }
		 

		/// <summary>
		/// This option is deprecated since v6.0.5. Instead, use[time.timezone](#time.timezone) that supports individual timesettings per chart.
		/// </summary>
		public string Timezone { get; set; }
		 

		/// <summary>
		/// This option is deprecated since v6.0.5. Instead, use[time.timezoneOffset](#time.timezoneOffset) that supports individualtime settings per chart.
		/// </summary>
		public double? TimezoneOffset { get; set; }
		 

		/// <summary>
		/// This option is deprecated since v6.0.5. Instead, use[time.useUTC](#time.useUTC) that supports individual time settingsper chart.
		/// </summary>
		public bool? UseUTC { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ButtonTheme != null) h.Add("buttonTheme",ButtonTheme.ToHashtable(highcharts));
			if (CanvasToolsURL != null) h.Add("canvasToolsURL",CanvasToolsURL);
			if (Date != null) h.Add("date",Date);
			if (GetTimezoneOffset != null) h.Add("getTimezoneOffset",GetTimezoneOffset);
			if (Timezone != null) h.Add("timezone",Timezone);
			if (TimezoneOffset != null) h.Add("timezoneOffset",TimezoneOffset);
			if (UseUTC != null) h.Add("useUTC",UseUTC);
			if (CustomFields.Count > 0)
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
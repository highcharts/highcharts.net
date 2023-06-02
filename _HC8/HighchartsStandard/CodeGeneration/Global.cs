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
			CanvasToolsURL = CanvasToolsURL_DefaultValue = "";
			Date = Date_DefaultValue = null;
			GetTimezoneOffset = GetTimezoneOffset_DefaultValue = "";
			Timezone = Timezone_DefaultValue = "";
			TimezoneOffset = TimezoneOffset_DefaultValue = null;
			UseUTC = UseUTC_DefaultValue = null;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// _Canvg rendering for Android 2.x is removed as of Highcharts 5.0\.Use the [libURL](#exporting.libURL) option to configure exporting._The URL to the additional file to lazy load for Android 2.x devices.These devices don't support SVG, so we download a helper file thatcontains [canvg](https://github.com/canvg/canvg), its dependencyrbcolor, and our own CanVG Renderer class. To avoid hotlinking toour site, you can install canvas-tools.js on your own server andchange this option accordingly.
		/// </summary>
		public string CanvasToolsURL { get; set; }
		private string CanvasToolsURL_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option is deprecated since v6.0.5. Instead, use[time.Date](#time.Date) that supports individual time settingsper chart.
		/// </summary>
		public Object Date { get; set; }
		private Object Date_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option is deprecated since v6.0.5. Instead, use[time.getTimezoneOffset](#time.getTimezoneOffset) that supportsindividual time settings per chart.
		/// </summary>
		public string GetTimezoneOffset { get; set; }
		private string GetTimezoneOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option is deprecated since v6.0.5. Instead, use[time.timezone](#time.timezone) that supports individual timesettings per chart.
		/// </summary>
		public string Timezone { get; set; }
		private string Timezone_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option is deprecated since v6.0.5. Instead, use[time.timezoneOffset](#time.timezoneOffset) that supports individualtime settings per chart.
		/// </summary>
		public double? TimezoneOffset { get; set; }
		private double? TimezoneOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option is deprecated since v6.0.5. Instead, use[time.useUTC](#time.useUTC) that supports individual time settingsper chart.
		/// </summary>
		public bool? UseUTC { get; set; }
		private bool? UseUTC_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (CanvasToolsURL != CanvasToolsURL_DefaultValue) h.Add("canvasToolsURL",CanvasToolsURL);
			if (Date != Date_DefaultValue) h.Add("date",Date);
			if (GetTimezoneOffset != GetTimezoneOffset_DefaultValue) h.Add("getTimezoneOffset",GetTimezoneOffset);
			if (Timezone != Timezone_DefaultValue) h.Add("timezone",Timezone);
			if (TimezoneOffset != TimezoneOffset_DefaultValue) h.Add("timezoneOffset",TimezoneOffset);
			if (UseUTC != UseUTC_DefaultValue) h.Add("useUTC",UseUTC);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}
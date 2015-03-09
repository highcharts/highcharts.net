using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace HighSoft.Web.Mvc
{
	public partial class Global
	{
		public Global()
		{
			Date = Date_DefaultValue = null;
			VMLRadialGradientURL = VMLRadialGradientURL_DefaultValue = "http://code.highcharts.com/{version}/gfx/vml-radial-gradient.png";
			CanvasToolsURL = CanvasToolsURL_DefaultValue = "http://code.highcharts.com/{version}/modules/canvas-tools.js";
			TimezoneOffset = TimezoneOffset_DefaultValue = 0;
			UseUTC = UseUTC_DefaultValue = true;
			
		}	
		

		/// <summary>
		/// A custom <code>Date</code> class for advanced date handling. For example, <a href="https://github.com/tahajahangir/jdate">JDate</a> can be hooked in to handle Jalali dates.
		/// </summary>
		public Object Date { get; set; }
		private Object Date_DefaultValue { get; set; }
		 

		/// <summary>
		/// Path to the pattern image required by VML browsers in order to draw radial gradients.
		/// </summary>
		public string VMLRadialGradientURL { get; set; }
		private string VMLRadialGradientURL_DefaultValue { get; set; }
		 

		/// <summary>
		/// The URL to the additional file to lazy load for Android 2.x devices. These devices don't  support SVG, so we download a helper file that contains <a href="http://code.google.com/p/canvg/">canvg</a>, its dependency rbcolor, and our own CanVG Renderer class. To avoid hotlinking to our site, you can install canvas-tools.js on your own server and change this option accordingly.
		/// </summary>
		public string CanvasToolsURL { get; set; }
		private string CanvasToolsURL_DefaultValue { get; set; }
		 

		/// <summary>
		/// The timezone offset in minutes. Positive values are west, negative values are east of UTC, as in the ECMAScript <a href="https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/getTimezoneOffset">getTimezoneOffset</a> method. Use this to display UTC based data in a predefined time zone. 
		/// </summary>
		public double? TimezoneOffset { get; set; }
		private double? TimezoneOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to use UTC time for axis scaling, tickmark placement and time display in  <code>Highcharts.dateFormat</code>. Advantages of using UTC is that the time displays equally regardless of the user agent's time zone settings. Local time can be used when the data is loaded in real time or when correct Daylight Saving Time transitions are required.
		/// </summary>
		public bool? UseUTC { get; set; }
		private bool? UseUTC_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Date != Date_DefaultValue) h.Add("date",Date);
			if (VMLRadialGradientURL != VMLRadialGradientURL_DefaultValue) h.Add("vMLRadialGradientURL",VMLRadialGradientURL);
			if (CanvasToolsURL != CanvasToolsURL_DefaultValue) h.Add("canvasToolsURL",CanvasToolsURL);
			if (TimezoneOffset != TimezoneOffset_DefaultValue) h.Add("timezoneOffset",TimezoneOffset);
			if (UseUTC != UseUTC_DefaultValue) h.Add("useUTC",UseUTC);
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}
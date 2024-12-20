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
	public partial class ChartZooming  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartZooming()
		{
		}	
		

		/// <summary>
		/// Set a key to hold when dragging to zoom the chart. This is useful toavoid zooming while moving points. Should be set different than[chart.panKey](#chart.panKey).
		/// </summary>
		public ChartZoomingKey Key { get; set; }
		 

		/// <summary>
		/// The mouse wheel zoom is a feature included in Highcharts Stock, but is alsoavailable for Highcharts Core as a module. Zooming with the mouse wheel isenabled by default in Highcharts Stock. In Highcharts Core it is enabled if[chart.zooming.type](chart.zooming.type) is set. It can be disabled bysetting this option to `false`.
		/// </summary>
		public bool? MouseWheel { get; set; }
		 

		/// <summary>
		/// Equivalent to [type](#chart.zooming.type), but for multitouchgestures only. By default, the `pinchType` is the same as the`type` setting. However, pinching can be enabled separately insome cases, for example in stock charts where a mouse drag pans thechart, while pinching is enabled. When [tooltip.followTouchMove](#tooltip.followTouchMove) is true, pinchType only applies totwo-finger touches.
		/// </summary>
		public ChartZoomingPinchType PinchType { get; set; }
		 

		/// <summary>
		/// The button that appears after a selection zoom, allowing the userto reset zoom.
		/// </summary>
		public ChartZoomingResetButton ResetButton { get; set; }
		 

		/// <summary>
		/// Enables zooming by a single touch, in combination with[chart.zooming.type](#chart.zooming.type). When enabled, two-fingerpinch will still work as set up by [chart.zooming.pinchType](#chart.zooming.pinchType). However, `singleTouch` will interferewith touch-dragging the chart to read the tooltip. And especiallywhen vertical zooming is enabled, it will make it hard to scrollvertically on the page.
		/// </summary>
		public bool? SingleTouch { get; set; }
		 

		/// <summary>
		/// Decides in what dimensions the user can zoom by dragging the mouse.Can be one of `x`, `y` or `xy`.
		/// </summary>
		public ChartZoomingType Type { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Key != ChartZoomingKey.Null) h.Add("key", highcharts.FirstCharacterToLower(Key.ToString()));
			if (MouseWheel != null) h.Add("mouseWheel",MouseWheel);
			if (PinchType != ChartZoomingPinchType.Null) h.Add("pinchType", highcharts.FirstCharacterToLower(PinchType.ToString()));
			if (ResetButton != null) h.Add("resetButton",ResetButton.ToHashtable(highcharts));
			if (SingleTouch != null) h.Add("singleTouch",SingleTouch);
			if (Type != ChartZoomingType.Null) h.Add("type", highcharts.FirstCharacterToLower(Type.ToString()));
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
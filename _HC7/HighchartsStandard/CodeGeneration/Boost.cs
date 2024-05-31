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
	public partial class Boost  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Boost()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The chart will be boosted, if one of the series crosses its threshold and allthe series in the chart can be boosted.
		/// </summary>
		public bool? AllowForce { get; set; }
		 

		/// <summary>
		/// Debugging options for boost.Useful for benchmarking, and general timing.
		/// </summary>
		public BoostDebug Debug { get; set; }
		 

		/// <summary>
		/// Enable or disable boost on a chart.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// The pixel ratio for the WebGL content. If 0, the `window.devicePixelRatio` isused. This ensures sharp graphics on high DPI displays like Apple's Retina,as well as when a page is zoomed.The default is left at 1 for now, as this is a new feature that has thepotential to break existing setups. Over time, when it has been battletested, the intention is to set it to 0 by default.Another use case for this option is to set it to 2 in order to make exportedand upscaled charts render sharp.One limitation when using the `pixelRatio` is that the line width of graphsis scaled down. Since the Boost module currently can only render 1px linewidths, it is scaled down to a thin 0.5 pixels on a Retina display.
		/// </summary>
		public double? PixelRatio { get; set; }
		 

		/// <summary>
		/// Set the series threshold for when the boost should kick in globally.Setting to e.g. 20 will cause the whole chart to enter boost modeif there are 20 or more series active. When the chart is in boost mode,every series in it will be rendered to a common canvas. This offersa significant speed improvement in charts with a very highamount of series.
		/// </summary>
		public double? SeriesThreshold { get; set; }
		 

		/// <summary>
		/// Enable or disable GPU translations. GPU translations are faster than doingthe translation in JavaScript.This option may cause rendering issues with certain datasets.Namely, if your dataset has large numbers with small increments (such astimestamps), it won't work correctly. This is due to floating pointprecision.
		/// </summary>
		public bool? UseGPUTranslations { get; set; }
		 

		/// <summary>
		/// Enable or disable pre-allocation of vertex buffers.Enabling this will make it so that the binary data arrays required forstoring the series data will be allocated prior to transforming the datato a WebGL-compatible format.This saves a copy operation on the order of O(n) and so is significantly moreperformant. However, this is currently an experimental option, and may causevisual artifacts with some datasets.As such, care should be taken when using this setting to make sure thatit doesn't cause any rendering glitches with the given use-case.
		/// </summary>
		public bool? UsePreallocated { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (AllowForce != null) h.Add("allowForce",AllowForce);
			if (Debug != null) h.Add("debug",Debug.ToHashtable(highcharts));
			if (Enabled != null) h.Add("enabled",Enabled);
			if (PixelRatio != null) h.Add("pixelRatio",PixelRatio);
			if (SeriesThreshold != null) h.Add("seriesThreshold",SeriesThreshold);
			if (UseGPUTranslations != null) h.Add("useGPUTranslations",UseGPUTranslations);
			if (UsePreallocated != null) h.Add("usePreallocated",UsePreallocated);
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
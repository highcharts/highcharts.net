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
			AllowForce = AllowForce_DefaultValue = true;
			Debug = Debug_DefaultValue = new BoostDebug();
			Enabled = Enabled_DefaultValue = true;
			SeriesThreshold = SeriesThreshold_DefaultValue = null;
			UseGPUTranslations = UseGPUTranslations_DefaultValue = false;
			UsePreallocated = UsePreallocated_DefaultValue = false;
			
		}	
		

		/// <summary>
		/// If set to true, the whole chart will be boosted if one of the seriescrosses its threshold, and all the series can be boosted.
		/// </summary>
		public bool? AllowForce { get; set; }
		private bool? AllowForce_DefaultValue { get; set; }
		 

		/// <summary>
		/// Debugging options for boost.Useful for benchmarking, and general timing.
		/// </summary>
		public BoostDebug Debug { get; set; }
		private BoostDebug Debug_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable boost on a chart.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the series threshold for when the boost should kick in globally.Setting to e.g. 20 will cause the whole chart to enter boost modeif there are 20 or more series active. When the chart is in boost mode,every series in it will be rendered to a common canvas. This offersa significant speed improvment in charts with a very highamount of series.
		/// </summary>
		public double? SeriesThreshold { get; set; }
		private double? SeriesThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable GPU translations. GPU translations are faster than doingthe translation in JavaScript.This option may cause rendering issues with certain datasets.Namely, if your dataset has large numbers with small increments (such astimestamps), it won't work correctly. This is due to floating pointprecission.
		/// </summary>
		public bool? UseGPUTranslations { get; set; }
		private bool? UseGPUTranslations_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable pre-allocation of vertex buffers.Enabling this will make it so that the binary data arrays required forstoring the series data will be allocated prior to transforming the datato a WebGL-compatible format.This saves a copy operation on the order of O(n) and so is significantly moreperformant. However, this is currently an experimental option, and may causevisual artifacts with some datasets.As such, care should be taken when using this setting to make sure thatit doesn't cause any rendering glitches with the given use-case.
		/// </summary>
		public bool? UsePreallocated { get; set; }
		private bool? UsePreallocated_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (AllowForce != AllowForce_DefaultValue) h.Add("allowForce",AllowForce);
			if (Debug.IsDirty()) h.Add("debug",Debug.ToHashtable());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (SeriesThreshold != SeriesThreshold_DefaultValue) h.Add("seriesThreshold",SeriesThreshold);
			if (UseGPUTranslations != UseGPUTranslations_DefaultValue) h.Add("useGPUTranslations",UseGPUTranslations);
			if (UsePreallocated != UsePreallocated_DefaultValue) h.Add("usePreallocated",UsePreallocated);
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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
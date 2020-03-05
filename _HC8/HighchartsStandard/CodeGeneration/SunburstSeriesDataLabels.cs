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
	public partial class SunburstSeriesDataLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public SunburstSeriesDataLabels()
		{
			AllowOverlap = AllowOverlap_DefaultValue = true;
			Defer = Defer_DefaultValue = true;
			RotationMode = RotationMode_DefaultValue = SunburstSeriesDataLabelsRotationMode.Auto;
			Style = Style_DefaultValue = new SunburstSeriesDataLabelsStyle();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Defer { get; set; }
		private bool? Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decides how the data label will be rotated relative to the perimeterof the sunburst. Valid values are `auto`, `parallel` and`perpendicular`. When `auto`, the best fit will be computed for thepoint.The `series.rotation` option takes precedence over `rotationMode`.
		/// </summary>
		public SunburstSeriesDataLabelsRotationMode RotationMode { get; set; }
		private SunburstSeriesDataLabelsRotationMode RotationMode_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public SunburstSeriesDataLabelsStyle Style { get; set; }
		private SunburstSeriesDataLabelsStyle Style_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (RotationMode != RotationMode_DefaultValue) h.Add("rotationMode", Highcharts.FirstCharacterToLower(RotationMode.ToString()));
			if (Style != Style_DefaultValue) h.Add("style",Style);
			

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
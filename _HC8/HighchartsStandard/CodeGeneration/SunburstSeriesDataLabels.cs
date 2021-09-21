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
			Style = Style_DefaultValue = new Hashtable();
			
			CustomFields = new Hashtable();
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
		/// Decides how the data label will be rotated relative to theperimeter of the sunburst. Valid values are `auto`, `circular`,`parallel` and `perpendicular`. When `auto`, the best fit will becomputed for the point. The `circular` option works similiarto `auto`, but uses the `textPath` feature - labels are curved,resulting in a better layout, however multiple lines and`textOutline` are not supported.The `rotation` option takes precedence over `rotationMode`.
		/// </summary>
		public SunburstSeriesDataLabelsRotationMode RotationMode { get; set; }
		private SunburstSeriesDataLabelsRotationMode RotationMode_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (RotationMode != RotationMode_DefaultValue) h.Add("rotationMode", highcharts.FirstCharacterToLower(RotationMode.ToString()));
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}
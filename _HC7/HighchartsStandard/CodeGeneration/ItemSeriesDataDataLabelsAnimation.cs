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
	public partial class ItemSeriesDataDataLabelsAnimation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ItemSeriesDataDataLabelsAnimation()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The animation delay time in milliseconds. Set to `0` to render thedata labels immediately. As `undefined` inherits defer time from the[series.animation.defer](#plotOptions.series.animation.defer).
		/// </summary>
		public double? Defer { get; set; }
		private double? Defer_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Defer != null) h.Add("defer",Defer);
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
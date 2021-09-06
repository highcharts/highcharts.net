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
	public partial class DpoSeriesDataLabelsAnimation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public DpoSeriesDataLabelsAnimation()
		{
			Defer = Defer_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The animation delay time in milliseconds.Set to `0` renders dataLabel immediately.As `undefined` inherits defer time from the [series.animation.defer](#plotOptions.series.animation.defer).
		/// </summary>
		public double? Defer { get; set; }
		private double? Defer_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}
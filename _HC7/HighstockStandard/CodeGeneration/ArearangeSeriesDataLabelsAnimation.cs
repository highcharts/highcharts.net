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
	public partial class ArearangeSeriesDataLabelsAnimation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ArearangeSeriesDataLabelsAnimation()
		{
		}	
		

		/// <summary>
		/// The animation delay time in milliseconds. Set to `0` to render thedata labels immediately. As `undefined` inherits defer time from the[series.animation.defer](#plotOptions.series.animation.defer).
		/// </summary>
		public double? Defer { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Defer != null) h.Add("defer",Defer);
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
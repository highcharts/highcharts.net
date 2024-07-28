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
	public partial class PlotOptionsNatrStatesInactive  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsNatrStatesInactive()
		{
		}	
		

		/// <summary>
		/// Animation when not hovering over the marker.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Animation when not hovering over the marker.
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// Enable or disable the inactive state for a series
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Opacity of series elements (dataLabels, line, area).
		/// </summary>
		public double? Opacity { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Animation != null) h.Add("animation",Animation);
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Opacity != null) h.Add("opacity",Opacity);
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
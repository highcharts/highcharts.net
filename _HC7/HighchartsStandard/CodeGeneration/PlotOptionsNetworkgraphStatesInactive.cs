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
	public partial class PlotOptionsNetworkgraphStatesInactive  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsNetworkgraphStatesInactive()
		{
		}	
		

		/// <summary>
		/// Animation when not hovering over the node.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Animation when not hovering over the node.
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// Opacity of inactive links.
		/// </summary>
		public double? LinkOpacity { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Animation != null) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (LinkOpacity != null) h.Add("linkOpacity",LinkOpacity);
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
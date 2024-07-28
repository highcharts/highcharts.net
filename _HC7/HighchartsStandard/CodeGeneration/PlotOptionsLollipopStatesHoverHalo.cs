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
	public partial class PlotOptionsLollipopStatesHoverHalo  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsLollipopStatesHoverHalo()
		{
		}	
		

		/// <summary>
		/// A collection of SVG attributes to override the appearanceof the halo, for example `fill`, `stroke` and`stroke-width`.
		/// </summary>
		public Object Attributes { get; set; }
		 

		/// <summary>
		/// Opacity for the halo unless a specific fill is overriddenusing the `attributes` setting. Note that Highcharts isonly able to apply opacity to colors of hex or rgb(a)formats.
		/// </summary>
		public double? Opacity { get; set; }
		 

		/// <summary>
		/// The pixel size of the halo. For point markers this is theradius of the halo. For pie slices it is the width of thehalo outside the slice. For bubbles it defaults to 5 andis the width of the halo outside the bubble.
		/// </summary>
		public double? Size { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Attributes != null) h.Add("attributes",Attributes);
			if (Opacity != null) h.Add("opacity",Opacity);
			if (Size != null) h.Add("size",Size);
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
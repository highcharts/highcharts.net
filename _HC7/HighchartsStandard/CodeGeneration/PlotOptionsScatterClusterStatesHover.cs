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
	public partial class PlotOptionsScatterClusterStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsScatterClusterStatesHover()
		{
		}	
		

		/// <summary>
		/// The fill color of the cluster marker in hover state. When`undefined`, the series' or point's fillColor for normalstate is used.
		/// </summary>
		public Object FillColor { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (FillColor != null) h.Add("fillColor",FillColor);
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
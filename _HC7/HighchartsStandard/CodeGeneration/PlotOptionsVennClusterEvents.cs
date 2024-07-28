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
	public partial class PlotOptionsVennClusterEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsVennClusterEvents()
		{
		}	
		

		/// <summary>
		/// Fires when the cluster point is clicked and `drillToCluster` is enabled.One parameter, `event`, is passed to the function. The default actionis to zoom to the cluster points range. This can be preventedby calling `event.preventDefault()`.
		/// </summary>
		public string DrillToCluster { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (DrillToCluster != null) { h.Add("drillToCluster",DrillToCluster); highcharts.AddFunction("drillToCluster", DrillToCluster); }  
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
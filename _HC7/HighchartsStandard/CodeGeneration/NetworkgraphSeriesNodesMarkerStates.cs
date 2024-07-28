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
	public partial class NetworkgraphSeriesNodesMarkerStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NetworkgraphSeriesNodesMarkerStates()
		{
		}	
		

		/// <summary>
		/// The opposite state of a hover for a single point node.Applied to all not connected nodes to the hovered one.
		/// </summary>
		public NetworkgraphSeriesNodesMarkerStatesInactive Inactive { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Inactive != null) h.Add("inactive",Inactive.ToHashtable(highcharts));
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
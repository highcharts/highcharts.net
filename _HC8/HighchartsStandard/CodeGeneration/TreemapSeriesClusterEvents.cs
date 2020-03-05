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
	public partial class TreemapSeriesClusterEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public TreemapSeriesClusterEvents()
		{
			DrillToCluster = DrillToCluster_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Fires when the cluster point is clicked and `drillToCluster` is enabled.One parameter, `event`, is passed to the function. The default actionis to zoom to the cluster points range. This can be preventedby calling `event.preventDefault()`.
		/// </summary>
		public string DrillToCluster { get; set; }
		private string DrillToCluster_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (DrillToCluster != DrillToCluster_DefaultValue) { h.Add("drillToCluster",DrillToCluster); Highcharts.AddFunction("ba1f871d-c74e-42fa-8f3e-588c77b69359.drillToCluster", DrillToCluster); }  
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}
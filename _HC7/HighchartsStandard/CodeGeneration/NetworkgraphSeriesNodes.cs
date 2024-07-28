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
	public partial class NetworkgraphSeriesNodes  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NetworkgraphSeriesNodes()
		{
		}	
		

		/// <summary>
		/// The color of the auto generated node.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// The color index of the auto generated node, especially for use in styledmode.
		/// </summary>
		public double? ColorIndex { get; set; }
		 

		/// <summary>
		/// Individual data label for each node. The options are the same asthe ones for [series.networkgraph.dataLabels](#series.networkgraph.dataLabels).
		/// </summary>
		public NetworkgraphSeriesNodesDataLabels DataLabels { get; set; }
		 

		/// <summary>
		/// The id of the auto-generated node, referring to the `from` or `to` setting ofthe link.
		/// </summary>
		public string Id { get; set; }
		 

		/// <summary>
		/// Options for the node markers.
		/// </summary>
		public NetworkgraphSeriesNodesMarker Marker { get; set; }
		 

		/// <summary>
		/// Mass of the node. By default, each node has mass equal to it's marker radius. Mass is used to determine how two connected nodes should affecteach other:Attractive force is multiplied by the ratio of two connectednodes; if a big node has weights twice as the small one, then the small onewill move towards the big one twice faster than the big one to the small one.
		/// </summary>
		public double? Mass { get; set; }
		 

		/// <summary>
		/// The name to display for the node in data labels and tooltips. Use this whenthe name is different from the `id`. Where the id must be unique for eachnode, this is not necessary for the name.
		/// </summary>
		public string Name { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Color != null) h.Add("color",Color);
			if (ColorIndex != null) h.Add("colorIndex",ColorIndex);
			if (DataLabels != null) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (Id != null) h.Add("id",Id);
			if (Marker != null) h.Add("marker",Marker.ToHashtable(highcharts));
			if (Mass != null) h.Add("mass",Mass);
			if (Name != null) h.Add("name",Name);
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
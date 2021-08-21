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
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = new NetworkgraphSeriesNodesDataLabels();
			Id = Id_DefaultValue = "";
			Mass = Mass_DefaultValue = null;
			Name = Name_DefaultValue = "";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The color of the auto generated node.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color index of the auto generated node, especially for use in styledmode.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual data label for each node. The options are the same asthe ones for [series.networkgraph.dataLabels](#series.networkgraph.dataLabels).
		/// </summary>
		public NetworkgraphSeriesNodesDataLabels DataLabels { get; set; }
		private NetworkgraphSeriesNodesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// The id of the auto-generated node, refering to the `from` or `to` setting ofthe link.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mass of the node. By default, each node has mass equal to it's marker radius. Mass is used to determine how two connected nodes should affecteach other:Attractive force is multiplied by the ratio of two connectednodes; if a big node has weights twice as the small one, then the small onewill move towards the big one twice faster than the big one to the small one.
		/// </summary>
		public double? Mass { get; set; }
		private double? Mass_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name to display for the node in data labels and tooltips. Use this whenthe name is different from the `id`. Where the id must be unique for eachnode, this is not necessary for the name.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (DataLabels.IsDirty(ref highcharts)) h.Add("dataLabels",DataLabels.ToHashtable(ref highcharts));
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Mass != Mass_DefaultValue) h.Add("mass",Mass);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}
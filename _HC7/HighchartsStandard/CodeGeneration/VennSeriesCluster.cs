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
	public partial class VennSeriesCluster  : BaseObject
	{
		Hashtable h = new Hashtable();

		public VennSeriesCluster()
		{
		}	
		

		/// <summary>
		/// When set to `false` prevent cluster overlapping - this optionworks only when `layoutAlgorithm.type = "grid"`.
		/// </summary>
		public bool? AllowOverlap { get; set; }
		 

		/// <summary>
		/// Options for the cluster marker animation.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Options for the cluster marker animation.
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// Options for the cluster data labels.
		/// </summary>
		public VennSeriesClusterDataLabels DataLabels { get; set; }
		 

		/// <summary>
		/// Zoom the plot area to the cluster points range when a cluster is clicked.
		/// </summary>
		public bool? DrillToCluster { get; set; }
		 

		/// <summary>
		/// Whether to enable the marker-clusters module.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public VennSeriesClusterEvents Events { get; set; }
		 

		/// <summary>
		/// Options for layout algorithm. Inside thereare options to change the type of the algorithm, gridSize,distance or iterations.
		/// </summary>
		public VennSeriesClusterLayoutAlgorithm LayoutAlgorithm { get; set; }
		 

		/// <summary>
		/// Options for the cluster marker.
		/// </summary>
		public VennSeriesClusterMarker Marker { get; set; }
		 

		/// <summary>
		/// The minimum amount of points to be combined into a cluster.This value has to be greater or equal to 2.
		/// </summary>
		public double? MinimumClusterSize { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public VennSeriesClusterStates States { get; set; }
		 

		/// <summary>
		/// An array defining zones within marker clusters.In styled mode, the color zones are styled with the`.highcharts-cluster-zone-{n}` class, or customclassed from the `className`option.
		/// </summary>
		public List<VennSeriesClusterZone> Zones { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (AllowOverlap != null) h.Add("allowOverlap",AllowOverlap);
			if (Animation != null) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (DataLabels != null) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (DrillToCluster != null) h.Add("drillToCluster",DrillToCluster);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Events != null) h.Add("events",Events.ToHashtable(highcharts));
			if (LayoutAlgorithm != null) h.Add("layoutAlgorithm",LayoutAlgorithm.ToHashtable(highcharts));
			if (Marker != null) h.Add("marker",Marker.ToHashtable(highcharts));
			if (MinimumClusterSize != null) h.Add("minimumClusterSize",MinimumClusterSize);
			if (States != null) h.Add("states",States.ToHashtable(highcharts));
			if (Zones != null) h.Add("zones", HashifyList(highcharts,Zones));
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
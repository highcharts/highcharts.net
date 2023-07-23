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
	public partial class ScatterSeriesCluster  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ScatterSeriesCluster()
		{
			AllowOverlap = AllowOverlap_DefaultValue = true;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			AnimationBool = AnimationBool_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = new ScatterSeriesClusterDataLabels();
			DrillToCluster = DrillToCluster_DefaultValue = true;
			Enabled = Enabled_DefaultValue = false;
			Events = Events_DefaultValue = new ScatterSeriesClusterEvents();
			LayoutAlgorithm = LayoutAlgorithm_DefaultValue = new ScatterSeriesClusterLayoutAlgorithm();
			Marker = Marker_DefaultValue = new ScatterSeriesClusterMarker();
			MinimumClusterSize = MinimumClusterSize_DefaultValue = 2;
			States = States_DefaultValue = new ScatterSeriesClusterStates();
			Zones = Zones_DefaultValue = new List<ScatterSeriesClusterZone>();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// When set to `false` prevent cluster overlapping - this optionworks only when `layoutAlgorithm.type = "grid"`.
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the cluster marker animation.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the cluster marker animation.
		/// </summary>
		public bool? AnimationBool { get; set; }
		private bool? AnimationBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the cluster data labels.
		/// </summary>
		public ScatterSeriesClusterDataLabels DataLabels { get; set; }
		private ScatterSeriesClusterDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Zoom the plot area to the cluster points range when a cluster is clicked.
		/// </summary>
		public bool? DrillToCluster { get; set; }
		private bool? DrillToCluster_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to enable the marker-clusters module.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ScatterSeriesClusterEvents Events { get; set; }
		private ScatterSeriesClusterEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for layout algorithm. Inside thereare options to change the type of the algorithm, gridSize,distance or iterations.
		/// </summary>
		public ScatterSeriesClusterLayoutAlgorithm LayoutAlgorithm { get; set; }
		private ScatterSeriesClusterLayoutAlgorithm LayoutAlgorithm_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the cluster marker.
		/// </summary>
		public ScatterSeriesClusterMarker Marker { get; set; }
		private ScatterSeriesClusterMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum amount of points to be combined into a cluster.This value has to be greater or equal to 2.
		/// </summary>
		public double? MinimumClusterSize { get; set; }
		private double? MinimumClusterSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ScatterSeriesClusterStates States { get; set; }
		private ScatterSeriesClusterStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining zones within marker clusters.In styled mode, the color zones are styled with the`.highcharts-cluster-zone-{n}` class, or customclassed from the `className`option.
		/// </summary>
		public List<ScatterSeriesClusterZone> Zones { get; set; }
		private List<ScatterSeriesClusterZone> Zones_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (Animation.IsDirty(highstock)) h.Add("animation",Animation.ToJSON(highstock));
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (DataLabels.IsDirty(highstock)) h.Add("dataLabels",DataLabels.ToHashtable(highstock));
			if (DrillToCluster != DrillToCluster_DefaultValue) h.Add("drillToCluster",DrillToCluster);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Events.IsDirty(highstock)) h.Add("events",Events.ToHashtable(highstock));
			if (LayoutAlgorithm.IsDirty(highstock)) h.Add("layoutAlgorithm",LayoutAlgorithm.ToHashtable(highstock));
			if (Marker.IsDirty(highstock)) h.Add("marker",Marker.ToHashtable(highstock));
			if (MinimumClusterSize != MinimumClusterSize_DefaultValue) h.Add("minimumClusterSize",MinimumClusterSize);
			if (States.IsDirty(highstock)) h.Add("states",States.ToHashtable(highstock));
			if (Zones != Zones_DefaultValue) h.Add("zones", HashifyList(highstock,Zones));
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}
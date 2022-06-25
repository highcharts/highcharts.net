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
	public partial class PlotOptionsVectorCluster  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsVectorCluster()
		{
			AllowOverlap = AllowOverlap_DefaultValue = true;
			Animation = Animation_DefaultValue = new Animation();
			AnimationBool = AnimationBool_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = new PlotOptionsVectorClusterDataLabels();
			DrillToCluster = DrillToCluster_DefaultValue = true;
			Enabled = Enabled_DefaultValue = false;
			Events = Events_DefaultValue = new PlotOptionsVectorClusterEvents();
			LayoutAlgorithm = LayoutAlgorithm_DefaultValue = new PlotOptionsVectorClusterLayoutAlgorithm();
			Marker = Marker_DefaultValue = new PlotOptionsVectorClusterMarker();
			MinimumClusterSize = MinimumClusterSize_DefaultValue = 2;
			States = States_DefaultValue = new PlotOptionsVectorClusterStates();
			Zones = Zones_DefaultValue = new List<PlotOptionsVectorClusterZone>();
			
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
		public PlotOptionsVectorClusterDataLabels DataLabels { get; set; }
		private PlotOptionsVectorClusterDataLabels DataLabels_DefaultValue { get; set; }
		 

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
		public PlotOptionsVectorClusterEvents Events { get; set; }
		private PlotOptionsVectorClusterEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for layout algorithm. Inside thereare options to change the type of the algorithm, gridSize,distance or iterations.
		/// </summary>
		public PlotOptionsVectorClusterLayoutAlgorithm LayoutAlgorithm { get; set; }
		private PlotOptionsVectorClusterLayoutAlgorithm LayoutAlgorithm_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the cluster marker.
		/// </summary>
		public PlotOptionsVectorClusterMarker Marker { get; set; }
		private PlotOptionsVectorClusterMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum amount of points to be combined into a cluster.This value has to be greater or equal to 2.
		/// </summary>
		public double? MinimumClusterSize { get; set; }
		private double? MinimumClusterSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsVectorClusterStates States { get; set; }
		private PlotOptionsVectorClusterStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining zones within marker clusters.In styled mode, the color zones are styled with the`.highcharts-cluster-zone-{n}` class, or customclassed from the `className`option.
		/// </summary>
		public List<PlotOptionsVectorClusterZone> Zones { get; set; }
		private List<PlotOptionsVectorClusterZone> Zones_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (Animation.IsDirty(ref highcharts)) h.Add("animation",Animation.ToHashtable(ref highcharts));
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (DataLabels.IsDirty(ref highcharts)) h.Add("dataLabels",DataLabels.ToHashtable(ref highcharts));
			if (DrillToCluster != DrillToCluster_DefaultValue) h.Add("drillToCluster",DrillToCluster);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Events.IsDirty(ref highcharts)) h.Add("events",Events.ToHashtable(ref highcharts));
			if (LayoutAlgorithm.IsDirty(ref highcharts)) h.Add("layoutAlgorithm",LayoutAlgorithm.ToHashtable(ref highcharts));
			if (Marker.IsDirty(ref highcharts)) h.Add("marker",Marker.ToHashtable(ref highcharts));
			if (MinimumClusterSize != MinimumClusterSize_DefaultValue) h.Add("minimumClusterSize",MinimumClusterSize);
			if (States.IsDirty(ref highcharts)) h.Add("states",States.ToHashtable(ref highcharts));
			if (Zones != Zones_DefaultValue) h.Add("zones", HashifyList(ref highcharts,Zones));
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
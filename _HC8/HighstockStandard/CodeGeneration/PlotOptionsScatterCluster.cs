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
	public partial class PlotOptionsScatterCluster  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsScatterCluster()
		{
			AllowOverlap = AllowOverlap_DefaultValue = true;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			AnimationBool = AnimationBool_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = new PlotOptionsScatterClusterDataLabels();
			DrillToCluster = DrillToCluster_DefaultValue = true;
			Enabled = Enabled_DefaultValue = false;
			Events = Events_DefaultValue = new PlotOptionsScatterClusterEvents();
			LayoutAlgorithm = LayoutAlgorithm_DefaultValue = new PlotOptionsScatterClusterLayoutAlgorithm();
			Marker = Marker_DefaultValue = new PlotOptionsScatterClusterMarker();
			MinimumClusterSize = MinimumClusterSize_DefaultValue = 2;
			States = States_DefaultValue = new PlotOptionsScatterClusterStates();
			Zones = Zones_DefaultValue = new List<PlotOptionsScatterClusterZone>();
			
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
		public PlotOptionsScatterClusterDataLabels DataLabels { get; set; }
		private PlotOptionsScatterClusterDataLabels DataLabels_DefaultValue { get; set; }
		 

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
		public PlotOptionsScatterClusterEvents Events { get; set; }
		private PlotOptionsScatterClusterEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for layout algorithm. Inside thereare options to change the type of the algorithm, gridSize,distance or iterations.
		/// </summary>
		public PlotOptionsScatterClusterLayoutAlgorithm LayoutAlgorithm { get; set; }
		private PlotOptionsScatterClusterLayoutAlgorithm LayoutAlgorithm_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the cluster marker.
		/// </summary>
		public PlotOptionsScatterClusterMarker Marker { get; set; }
		private PlotOptionsScatterClusterMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum amount of points to be combined into a cluster.This value has to be greater or equal to 2.
		/// </summary>
		public double? MinimumClusterSize { get; set; }
		private double? MinimumClusterSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsScatterClusterStates States { get; set; }
		private PlotOptionsScatterClusterStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining zones within marker clusters.In styled mode, the color zones are styled with the`.highcharts-cluster-zone-{n}` class, or customclassed from the `className`option.
		/// </summary>
		public List<PlotOptionsScatterClusterZone> Zones { get; set; }
		private List<PlotOptionsScatterClusterZone> Zones_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (Animation.IsDirty(ref highstock)) h.Add("animation",Animation.ToJSON(ref highstock));
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (DataLabels.IsDirty(ref highstock)) h.Add("dataLabels",DataLabels.ToHashtable(ref highstock));
			if (DrillToCluster != DrillToCluster_DefaultValue) h.Add("drillToCluster",DrillToCluster);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Events.IsDirty(ref highstock)) h.Add("events",Events.ToHashtable(ref highstock));
			if (LayoutAlgorithm.IsDirty(ref highstock)) h.Add("layoutAlgorithm",LayoutAlgorithm.ToHashtable(ref highstock));
			if (Marker.IsDirty(ref highstock)) h.Add("marker",Marker.ToHashtable(ref highstock));
			if (MinimumClusterSize != MinimumClusterSize_DefaultValue) h.Add("minimumClusterSize",MinimumClusterSize);
			if (States.IsDirty(ref highstock)) h.Add("states",States.ToHashtable(ref highstock));
			if (Zones != Zones_DefaultValue) h.Add("zones", HashifyList(ref highstock,Zones));
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}
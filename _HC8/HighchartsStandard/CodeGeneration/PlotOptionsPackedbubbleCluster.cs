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
	public partial class PlotOptionsPackedbubbleCluster  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPackedbubbleCluster()
		{
			AllowOverlap = AllowOverlap_DefaultValue = true;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			DataLabels = DataLabels_DefaultValue = new PlotOptionsPackedbubbleClusterDataLabels();
			DrillToCluster = DrillToCluster_DefaultValue = true;
			Enabled = Enabled_DefaultValue = false;
			Events = Events_DefaultValue = new PlotOptionsPackedbubbleClusterEvents();
			LayoutAlgorithm = LayoutAlgorithm_DefaultValue = new PlotOptionsPackedbubbleClusterLayoutAlgorithm();
			Marker = Marker_DefaultValue = new PlotOptionsPackedbubbleClusterMarker();
			MinimumClusterSize = MinimumClusterSize_DefaultValue = 2;
			States = States_DefaultValue = new PlotOptionsPackedbubbleClusterStates();
			Zones = Zones_DefaultValue = new List<PlotOptionsPackedbubbleClusterZone>();
			
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
		/// Options for the cluster data labels.
		/// </summary>
		public PlotOptionsPackedbubbleClusterDataLabels DataLabels { get; set; }
		private PlotOptionsPackedbubbleClusterDataLabels DataLabels_DefaultValue { get; set; }
		 

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
		public PlotOptionsPackedbubbleClusterEvents Events { get; set; }
		private PlotOptionsPackedbubbleClusterEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for layout algorithm. Inside thereare options to change the type of the algorithm, gridSize,distance or iterations.
		/// </summary>
		public PlotOptionsPackedbubbleClusterLayoutAlgorithm LayoutAlgorithm { get; set; }
		private PlotOptionsPackedbubbleClusterLayoutAlgorithm LayoutAlgorithm_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the cluster marker.
		/// </summary>
		public PlotOptionsPackedbubbleClusterMarker Marker { get; set; }
		private PlotOptionsPackedbubbleClusterMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum amount of points to be combined into a cluster.This value has to be greater or equal to 2.
		/// </summary>
		public double? MinimumClusterSize { get; set; }
		private double? MinimumClusterSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPackedbubbleClusterStates States { get; set; }
		private PlotOptionsPackedbubbleClusterStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining zones within marker clusters.In styled mode, the color zones are styled with the`.highcharts-cluster-zone-{n}` class, or customclassed from the `className`option.
		/// </summary>
		public List<PlotOptionsPackedbubbleClusterZone> Zones { get; set; }
		private List<PlotOptionsPackedbubbleClusterZone> Zones_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (DrillToCluster != DrillToCluster_DefaultValue) h.Add("drillToCluster",DrillToCluster);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (LayoutAlgorithm.IsDirty()) h.Add("layoutAlgorithm",LayoutAlgorithm.ToHashtable());
			if (Marker != Marker_DefaultValue) h.Add("marker",Marker);
			if (MinimumClusterSize != MinimumClusterSize_DefaultValue) h.Add("minimumClusterSize",MinimumClusterSize);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Zones != Zones_DefaultValue) h.Add("zones", HashifyList(Zones));
			

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
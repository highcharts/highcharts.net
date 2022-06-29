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
	public partial class PlotOptionsPackedbubbleLayoutAlgorithm  : PlotOptionsSeries
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPackedbubbleLayoutAlgorithm()
		{
			BubblePadding = BubblePadding_DefaultValue = 5;
			DragBetweenSeries = DragBetweenSeries_DefaultValue = false;
			EnableSimulation = EnableSimulation_DefaultValue = true;
			Friction = Friction_DefaultValue = null;
			GravitationalConstant = GravitationalConstant_DefaultValue = null;
			InitialPositionRadius = InitialPositionRadius_DefaultValue = null;
			InitialPositions = InitialPositions_DefaultValue = null;
			Integration = Integration_DefaultValue = PlotOptionsPackedbubbleLayoutAlgorithmIntegration.Euler;
			LinkLength = LinkLength_DefaultValue = null;
			MaxIterations = MaxIterations_DefaultValue = 1000;
			MaxSpeed = MaxSpeed_DefaultValue = 5;
			ParentNodeLimit = ParentNodeLimit_DefaultValue = false;
			ParentNodeOptions = ParentNodeOptions_DefaultValue = new PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptions();
			SeriesInteraction = SeriesInteraction_DefaultValue = true;
			SplitSeries = SplitSeries_DefaultValue = "false";
			Type = Type_DefaultValue = PlotOptionsPackedbubbleLayoutAlgorithmType.ReingoldFruchterman;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The distance between two bubbles, when the algorithm starts totreat two bubbles as overlapping. The `bubblePadding` is also theexpected distance between all the bubbles on simulation end.
		/// </summary>
		public double? BubblePadding { get; set; }
		private double? BubblePadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// In case of split series, this option allows user to drag anddrop points between series, for changing point related series.
		/// </summary>
		public bool? DragBetweenSeries { get; set; }
		private bool? DragBetweenSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? EnableSimulation { get; set; }
		private bool? EnableSimulation_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Friction { get; set; }
		private double? Friction_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? GravitationalConstant { get; set; }
		private double? GravitationalConstant_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? InitialPositionRadius { get; set; }
		private double? InitialPositionRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// Initial layout algorithm for positioning nodes. Can be one ofthe built-in options ("circle", "random") or a function wherepositions should be set on each node (`this.nodes`) as`node.plotX` and `node.plotY`.
		/// </summary>
		public double? InitialPositions { get; set; }
		private double? InitialPositions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Integration type. Available options are `'euler'` and `'verlet'`.Integration determines how forces are applied on particles. InEuler integration, force is applied direct as`newPosition += velocity;`.In Verlet integration, new position is based on a previousposittion without velocity:`newPosition += previousPosition - newPosition`.Note that different integrations give different results as forcesare different.In Highcharts v7.0.x only `'euler'` integration was supported.
		/// </summary>
		public PlotOptionsPackedbubbleLayoutAlgorithmIntegration Integration { get; set; }
		private PlotOptionsPackedbubbleLayoutAlgorithmIntegration Integration_DefaultValue { get; set; }
		 

		/// <summary>
		/// Ideal length (px) of the link between two nodes. When notdefined, length is calculated as:`Math.pow(availableWidth * availableHeight / nodesLength, 0.4);`Note: Because of the algorithm specification, length of each linkmight be not exactly as specified.
		/// </summary>
		public double? LinkLength { get; set; }
		private double? LinkLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? MaxIterations { get; set; }
		private double? MaxIterations_DefaultValue { get; set; }
		 

		/// <summary>
		/// Max speed that node can get in one iteration. In terms ofsimulation, it's a maximum translation (in pixels) that a nodecan move (in both, x and y, dimensions). While `friction` isapplied on all nodes, max speed is applied only for nodes thatmove very fast, for example small or disconnected ones.
		/// </summary>
		public double? MaxSpeed { get; set; }
		private double? MaxSpeed_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether bubbles should interact with their parentNode to keepthem inside.
		/// </summary>
		public bool? ParentNodeLimit { get; set; }
		private bool? ParentNodeLimit_DefaultValue { get; set; }
		 

		/// <summary>
		/// Layout algorithm options for parent nodes.
		/// </summary>
		public PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptions ParentNodeOptions { get; set; }
		private PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptions ParentNodeOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether series should interact with each other or not. When`parentNodeLimit` is set to true, thi option should be set tofalse to avoid sticking points in wrong series parentNode.
		/// </summary>
		public bool? SeriesInteraction { get; set; }
		private bool? SeriesInteraction_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to split series into individual groups or to mix allseries together.
		/// </summary>
		public string SplitSeries { get; set; }
		private string SplitSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// Type of the algorithm used when positioning nodes.
		/// </summary>
		public PlotOptionsPackedbubbleLayoutAlgorithmType Type { get; set; }
		private PlotOptionsPackedbubbleLayoutAlgorithmType Type_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (BubblePadding != BubblePadding_DefaultValue) h.Add("bubblePadding",BubblePadding);
			if (DragBetweenSeries != DragBetweenSeries_DefaultValue) h.Add("dragBetweenSeries",DragBetweenSeries);
			if (EnableSimulation != EnableSimulation_DefaultValue) h.Add("enableSimulation",EnableSimulation);
			if (Friction != Friction_DefaultValue) h.Add("friction",Friction);
			if (GravitationalConstant != GravitationalConstant_DefaultValue) h.Add("gravitationalConstant",GravitationalConstant);
			if (InitialPositionRadius != InitialPositionRadius_DefaultValue) h.Add("initialPositionRadius",InitialPositionRadius);
			if (InitialPositions != InitialPositions_DefaultValue) h.Add("initialPositions",InitialPositions);
			if (Integration != Integration_DefaultValue) h.Add("integration", highcharts.FirstCharacterToLower(Integration.ToString()));
			if (LinkLength != LinkLength_DefaultValue) h.Add("linkLength",LinkLength);
			if (MaxIterations != MaxIterations_DefaultValue) h.Add("maxIterations",MaxIterations);
			if (MaxSpeed != MaxSpeed_DefaultValue) h.Add("maxSpeed",MaxSpeed);
			if (ParentNodeLimit != ParentNodeLimit_DefaultValue) h.Add("parentNodeLimit",ParentNodeLimit);
			if (ParentNodeOptions.IsDirty(ref highcharts)) h.Add("parentNodeOptions",ParentNodeOptions.ToHashtable(ref highcharts));
			if (SeriesInteraction != SeriesInteraction_DefaultValue) h.Add("seriesInteraction",SeriesInteraction);
			if (SplitSeries != SplitSeries_DefaultValue) h.Add("splitSeries",SplitSeries);
			if (Type != Type_DefaultValue) h.Add("type", highcharts.FirstCharacterToLower(Type.ToString()));
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
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
	public partial class PackedbubbleSeriesLayoutAlgorithm  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PackedbubbleSeriesLayoutAlgorithm()
		{
		}	
		

		/// <summary>
		/// The distance between two bubbles, when the algorithm starts totreat two bubbles as overlapping. The `bubblePadding` is also theexpected distance between all the bubbles on simulation end.
		/// </summary>
		public double? BubblePadding { get; set; }
		 

		/// <summary>
		/// In case of split series, this option allows user to drag anddrop points between series, for changing point related series.
		/// </summary>
		public bool? DragBetweenSeries { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? EnableSimulation { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Friction { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? GravitationalConstant { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? InitialPositionRadius { get; set; }
		 

		/// <summary>
		/// Initial layout algorithm for positioning nodes. Can be one ofthe built-in options ("circle", "random") or a function wherepositions should be set on each node (`this.nodes`) as`node.plotX` and `node.plotY`.
		/// </summary>
		public double? InitialPositions { get; set; }
		 

		/// <summary>
		/// Integration type. Available options are `'euler'` and `'verlet'`.Integration determines how forces are applied on particles. InEuler integration, force is applied direct as`newPosition += velocity;`.In Verlet integration, new position is based on a previousposition without velocity:`newPosition += previousPosition - newPosition`.Note that different integrations give different results as forcesare different.In Highcharts v7.0.x only `'euler'` integration was supported.
		/// </summary>
		public PackedbubbleSeriesLayoutAlgorithmIntegration Integration { get; set; }
		 

		/// <summary>
		/// Ideal length (px) of the link between two nodes. When notdefined, length is calculated as:`Math.pow(availableWidth * availableHeight / nodesLength, 0.4);`Note: Because of the algorithm specification, length of each linkmight be not exactly as specified.
		/// </summary>
		public double? LinkLength { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? MaxIterations { get; set; }
		 

		/// <summary>
		/// Max speed that node can get in one iteration. In terms ofsimulation, it's a maximum translation (in pixels) that a nodecan move (in both, x and y, dimensions). While `friction` isapplied on all nodes, max speed is applied only for nodes thatmove very fast, for example small or disconnected ones.
		/// </summary>
		public double? MaxSpeed { get; set; }
		 

		/// <summary>
		/// Whether bubbles should interact with their parentNode to keepthem inside.
		/// </summary>
		public bool? ParentNodeLimit { get; set; }
		 

		/// <summary>
		/// Layout algorithm options for parent nodes.
		/// </summary>
		public PackedbubbleSeriesLayoutAlgorithmParentNodeOptions ParentNodeOptions { get; set; }
		 

		/// <summary>
		/// Whether series should interact with each other or not. When`parentNodeLimit` is set to true, thi option should be set tofalse to avoid sticking points in wrong series parentNode.
		/// </summary>
		public bool? SeriesInteraction { get; set; }
		 

		/// <summary>
		/// Whether to split series into individual groups or to mix allseries together.
		/// </summary>
		public bool? SplitSeries { get; set; }
		 

		/// <summary>
		/// Type of the algorithm used when positioning nodes.
		/// </summary>
		public string Type { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (BubblePadding != null) h.Add("bubblePadding",BubblePadding);
			if (DragBetweenSeries != null) h.Add("dragBetweenSeries",DragBetweenSeries);
			if (EnableSimulation != null) h.Add("enableSimulation",EnableSimulation);
			if (Friction != null) h.Add("friction",Friction);
			if (GravitationalConstant != null) h.Add("gravitationalConstant",GravitationalConstant);
			if (InitialPositionRadius != null) h.Add("initialPositionRadius",InitialPositionRadius);
			if (InitialPositions != null) h.Add("initialPositions",InitialPositions);
			if (Integration != PackedbubbleSeriesLayoutAlgorithmIntegration.Null) h.Add("integration", highcharts.FirstCharacterToLower(Integration.ToString()));
			if (LinkLength != null) h.Add("linkLength",LinkLength);
			if (MaxIterations != null) h.Add("maxIterations",MaxIterations);
			if (MaxSpeed != null) h.Add("maxSpeed",MaxSpeed);
			if (ParentNodeLimit != null) h.Add("parentNodeLimit",ParentNodeLimit);
			if (ParentNodeOptions != null) h.Add("parentNodeOptions",ParentNodeOptions.ToHashtable(highcharts));
			if (SeriesInteraction != null) h.Add("seriesInteraction",SeriesInteraction);
			if (SplitSeries != null) h.Add("splitSeries",SplitSeries);
			if (Type != null) h.Add("type",Type);
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
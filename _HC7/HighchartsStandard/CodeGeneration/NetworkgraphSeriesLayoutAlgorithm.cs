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
	public partial class NetworkgraphSeriesLayoutAlgorithm  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NetworkgraphSeriesLayoutAlgorithm()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Approximation used to calculate repulsive forces affecting nodes.By default, when calculating net force, nodes are comparedagainst each other, which gives O(N^2) complexity. UsingBarnes-Hut approximation, we decrease this to O(N log N), but theresulting graph will have different layout. Barnes-Hutapproximation divides space into rectangles via quad tree, whereforces exerted on nodes are calculated directly for nearby cells,and for all others, cells are treated as a separate node withcenter of mass.
		/// </summary>
		public NetworkgraphSeriesLayoutAlgorithmApproximation Approximation { get; set; }
		 

		/// <summary>
		/// Attraction force applied on a node which is conected to anothernode by a link. Passed are two arguments:- `d` - which is current distance between two nodes- `k` - which is desired distance between two nodesIn `verlet` integration, defaults to:`function (d, k) { return (k - d) / d; }`
		/// </summary>
		public string AttractiveForce { get; set; }
		 

		/// <summary>
		/// Experimental. Enables live simulation of the algorithmimplementation. All nodes are animated as the forces applies onthem.
		/// </summary>
		public bool? EnableSimulation { get; set; }
		 

		/// <summary>
		/// Friction applied on forces to prevent nodes rushing to fast tothe desired positions.
		/// </summary>
		public double? Friction { get; set; }
		 

		/// <summary>
		/// Gravitational const used in the barycenter force of thealgorithm.
		/// </summary>
		public double? GravitationalConstant { get; set; }
		 

		/// <summary>
		/// When `initialPositions` are set to 'circle',`initialPositionRadius` is a distance from the center of circle,in which nodes are created.
		/// </summary>
		public double? InitialPositionRadius { get; set; }
		 

		/// <summary>
		/// Initial layout algorithm for positioning nodes. Can be one ofbuilt-in options ("circle", "random") or a function wherepositions should be set on each node (`this.nodes`) as`node.plotX` and `node.plotY`
		/// </summary>
		public double? InitialPositions { get; set; }
		 

		/// <summary>
		/// Integration type. Available options are `'euler'` and `'verlet'`.Integration determines how forces are applied on particles. InEuler integration, force is applied direct as`newPosition += velocity;`.In Verlet integration, new position is based on a previousposition without velocity:`newPosition += previousPosition - newPosition`.Note that different integrations give different results as forcesare different.In Highcharts v7.0.x only `'euler'` integration was supported.
		/// </summary>
		public NetworkgraphSeriesLayoutAlgorithmIntegration Integration { get; set; }
		 

		/// <summary>
		/// Ideal length (px) of the link between two nodes. When notdefined, length is calculated as:`Math.pow(availableWidth * availableHeight / nodesLength, 0.4);`Note: Because of the algorithm specification, length of each linkmight be not exactly as specified.
		/// </summary>
		public double? LinkLength { get; set; }
		 

		/// <summary>
		/// Max number of iterations before algorithm will stop. In general,algorithm should find positions sooner, but when rendering hugenumber of nodes, it is recommended to increase this value asfinding perfect graph positions can require more time.
		/// </summary>
		public double? MaxIterations { get; set; }
		 

		/// <summary>
		/// Verlet integration only.Max speed that node can get in one iteration. In terms ofsimulation, it's a maximum translation (in pixels) that node canmove (in both, x and y, dimensions). While `friction` is appliedon all nodes, max speed is applied only for nodes that move veryfast, for example small or disconnected ones.
		/// </summary>
		public double? MaxSpeed { get; set; }
		 

		/// <summary>
		/// Repulsive force applied on a node. Passed are two arguments:- `d` - which is current distance between two nodes- `k` - which is desired distance between two nodesIn `verlet` integration, defaults to:`function (d, k) { return (k - d) / d * (k > d ? 1 : 0) }`
		/// </summary>
		public string RepulsiveForce { get; set; }
		 

		/// <summary>
		/// Barnes-Hut approximation only.Deteremines when distance between cell and node is small enoughto calculate forces. Value of `theta` is compared directly withquotient `s / d`, where `s` is the size of the cell, and `d` isdistance between center of cell's mass and currently comparednode.
		/// </summary>
		public double? Theta { get; set; }
		 

		/// <summary>
		/// Type of the algorithm used when positioning nodes.
		/// </summary>
		public string Type { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Approximation != NetworkgraphSeriesLayoutAlgorithmApproximation.Null) h.Add("approximation", highcharts.FirstCharacterToLower(Approximation.ToString()));
			if (AttractiveForce != null) { h.Add("attractiveForce",AttractiveForce); highcharts.AddFunction("attractiveForce", AttractiveForce); }  
			if (EnableSimulation != null) h.Add("enableSimulation",EnableSimulation);
			if (Friction != null) h.Add("friction",Friction);
			if (GravitationalConstant != null) h.Add("gravitationalConstant",GravitationalConstant);
			if (InitialPositionRadius != null) h.Add("initialPositionRadius",InitialPositionRadius);
			if (InitialPositions != null) h.Add("initialPositions",InitialPositions);
			if (Integration != NetworkgraphSeriesLayoutAlgorithmIntegration.Null) h.Add("integration", highcharts.FirstCharacterToLower(Integration.ToString()));
			if (LinkLength != null) h.Add("linkLength",LinkLength);
			if (MaxIterations != null) h.Add("maxIterations",MaxIterations);
			if (MaxSpeed != null) h.Add("maxSpeed",MaxSpeed);
			if (RepulsiveForce != null) { h.Add("repulsiveForce",RepulsiveForce); highcharts.AddFunction("repulsiveForce", RepulsiveForce); }  
			if (Theta != null) h.Add("theta",Theta);
			if (Type != null) h.Add("type",Type);
			if (CustomFields.Count > 0)
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
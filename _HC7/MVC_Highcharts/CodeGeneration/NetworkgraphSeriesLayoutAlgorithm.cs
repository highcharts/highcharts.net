using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class NetworkgraphSeriesLayoutAlgorithm  : BaseObject
	{
		public NetworkgraphSeriesLayoutAlgorithm()
		{
			AttractiveForce = AttractiveForce_DefaultValue = "";
			EnableSimulation = EnableSimulation_DefaultValue = false;
			Friction = Friction_DefaultValue = null;
			GravitationalConstant = GravitationalConstant_DefaultValue = null;
			InitialPositions = InitialPositions_DefaultValue = NetworkgraphSeriesLayoutAlgorithmInitialPositions.Circle;
			LinkLength = LinkLength_DefaultValue = null;
			MaxIterations = MaxIterations_DefaultValue = 1000;
			RepulsiveForce = RepulsiveForce_DefaultValue = "";
			Type = Type_DefaultValue = NetworkgraphSeriesLayoutAlgorithmType.ReingoldFruchterman;
			
		}	
		

		/// <summary>
		/// Attraction force applied on a node which is conected to another nodeby a link. Passed are two arguments:- `d` - which is current distance between two nodes- `k` - which is desired distance between two nodes
		/// </summary>
		public string AttractiveForce { get; set; }
		private string AttractiveForce_DefaultValue { get; set; }
		 

		/// <summary>
		/// Experimental. Enables live simulation of the algorithmimplementation. All nodes are animated as the forces applies onthem.
		/// </summary>
		public bool? EnableSimulation { get; set; }
		private bool? EnableSimulation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Friction applied on forces to prevent nodes rushing to fast to thedesired positions.
		/// </summary>
		public double? Friction { get; set; }
		private double? Friction_DefaultValue { get; set; }
		 

		/// <summary>
		/// Gravitational const used in the barycenter force of the algorithm.
		/// </summary>
		public double? GravitationalConstant { get; set; }
		private double? GravitationalConstant_DefaultValue { get; set; }
		 

		/// <summary>
		/// Initial layout algorithm for positioning nodes. Can be one ofbuilt-in options ("circle", "random") or a function where positionsshould be set on each node (`this.nodes`) as `node.plotX` and`node.plotY`
		/// </summary>
		public NetworkgraphSeriesLayoutAlgorithmInitialPositions InitialPositions { get; set; }
		private NetworkgraphSeriesLayoutAlgorithmInitialPositions InitialPositions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Ideal length (px) of the link between two nodes. When not defined,length is calculated as:`Math.pow(availableWidth * availableHeight / nodesLength, 0.4);`Note: Because of the algorithm specification, length of each linkmight be not exactly as specified.
		/// </summary>
		public double? LinkLength { get; set; }
		private double? LinkLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// Max number of iterations before algorithm will stop. In general,algorithm should find positions sooner, but when rendering hugenumber of nodes, it is recommended to increase this value asfinding perfect graph positions can require more time.
		/// </summary>
		public double? MaxIterations { get; set; }
		private double? MaxIterations_DefaultValue { get; set; }
		 

		/// <summary>
		/// Repulsive force applied on a node. Passed are two arguments:- `d` - which is current distance between two nodes- `k` - which is desired distance between two nodes
		/// </summary>
		public string RepulsiveForce { get; set; }
		private string RepulsiveForce_DefaultValue { get; set; }
		 

		/// <summary>
		/// Type of the algorithm used when positioning nodes.
		/// </summary>
		public NetworkgraphSeriesLayoutAlgorithmType Type { get; set; }
		private NetworkgraphSeriesLayoutAlgorithmType Type_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AttractiveForce != AttractiveForce_DefaultValue) { h.Add("attractiveForce",AttractiveForce); Highcharts.AddFunction("NetworkgraphSeriesLayoutAlgorithmAttractiveForce.attractiveForce", AttractiveForce); }  
			if (EnableSimulation != EnableSimulation_DefaultValue) h.Add("enableSimulation",EnableSimulation);
			if (Friction != Friction_DefaultValue) h.Add("friction",Friction);
			if (GravitationalConstant != GravitationalConstant_DefaultValue) h.Add("gravitationalConstant",GravitationalConstant);
			if (InitialPositions != InitialPositions_DefaultValue) h.Add("initialPositions", Highcharts.FirstCharacterToLower(InitialPositions.ToString()));
			if (LinkLength != LinkLength_DefaultValue) h.Add("linkLength",LinkLength);
			if (MaxIterations != MaxIterations_DefaultValue) h.Add("maxIterations",MaxIterations);
			if (RepulsiveForce != RepulsiveForce_DefaultValue) { h.Add("repulsiveForce",RepulsiveForce); Highcharts.AddFunction("NetworkgraphSeriesLayoutAlgorithmRepulsiveForce.repulsiveForce", RepulsiveForce); }  
			if (Type != Type_DefaultValue) h.Add("type", Highcharts.FirstCharacterToLower(Type.ToString()));
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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
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
	public partial class PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptions()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Friction applied on forces to prevent nodes rushing to fast tothe desired positions.
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
		/// Initial layout algorithm for positioning nodes. Can be one ofbuilt-in options ("circle", "random") or a function wherepositions should be set on each node (`this.nodes`) as`node.plotX` and `node.plotY`
		/// </summary>
		public double? InitialPositions { get; set; }
		 

		/// <summary>
		/// Integration type. Available options are `'euler'` and `'verlet'`.Integration determines how forces are applied on particles. InEuler integration, force is applied direct as`newPosition += velocity;`.In Verlet integration, new position is based on a previousposition without velocity:`newPosition += previousPosition - newPosition`.Note that different integrations give different results as forcesare different.In Highcharts v7.0.x only `'euler'` integration was supported.
		/// </summary>
		public PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptionsIntegration Integration { get; set; }
		 

		/// <summary>
		/// Ideal length (px) of the link between two nodes. When notdefined, length is calculated as:`Math.pow(availableWidth * availableHeight / nodesLength, 0.4);`Note: Because of the algorithm specification, length of each linkmight be not exactly as specified.
		/// </summary>
		public double? LinkLength { get; set; }
		 

		/// <summary>
		/// Styling options for parentNodes markers. Similar toline.marker options.
		/// </summary>
		public PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptionsMarker Marker { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? MaxIterations { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? MaxSpeed { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? SeriesInteraction { get; set; }
		 

		/// <summary>
		/// Type of the algorithm used when positioning nodes.
		/// </summary>
		public string Type { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Friction != null) h.Add("friction",Friction);
			if (GravitationalConstant != null) h.Add("gravitationalConstant",GravitationalConstant);
			if (InitialPositionRadius != null) h.Add("initialPositionRadius",InitialPositionRadius);
			if (InitialPositions != null) h.Add("initialPositions",InitialPositions);
			if (Integration != PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptionsIntegration.Null) h.Add("integration", highcharts.FirstCharacterToLower(Integration.ToString()));
			if (LinkLength != null) h.Add("linkLength",LinkLength);
			if (Marker != null) h.Add("marker",Marker.ToHashtable(highcharts));
			if (MaxIterations != null) h.Add("maxIterations",MaxIterations);
			if (MaxSpeed != null) h.Add("maxSpeed",MaxSpeed);
			if (SeriesInteraction != null) h.Add("seriesInteraction",SeriesInteraction);
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
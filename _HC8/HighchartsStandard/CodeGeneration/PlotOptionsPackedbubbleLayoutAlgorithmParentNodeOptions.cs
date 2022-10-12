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
			Friction = Friction_DefaultValue = null;
			GravitationalConstant = GravitationalConstant_DefaultValue = null;
			InitialPositionRadius = InitialPositionRadius_DefaultValue = null;
			InitialPositions = InitialPositions_DefaultValue = null;
			Integration = Integration_DefaultValue = PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptionsIntegration.Euler;
			LinkLength = LinkLength_DefaultValue = null;
			Marker = Marker_DefaultValue = new PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptionsMarker();
			MaxIterations = MaxIterations_DefaultValue = 400;
			MaxSpeed = MaxSpeed_DefaultValue = 50;
			SeriesInteraction = SeriesInteraction_DefaultValue = true;
			Type = Type_DefaultValue = PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptionsType.ReingoldFruchterman;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Friction applied on forces to prevent nodes rushing to fast tothe desired positions.
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
		/// Initial layout algorithm for positioning nodes. Can be one ofbuilt-in options ("circle", "random") or a function wherepositions should be set on each node (`this.nodes`) as`node.plotX` and `node.plotY`
		/// </summary>
		public double? InitialPositions { get; set; }
		private double? InitialPositions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Integration type. Available options are `'euler'` and `'verlet'`.Integration determines how forces are applied on particles. InEuler integration, force is applied direct as`newPosition += velocity;`.In Verlet integration, new position is based on a previousposittion without velocity:`newPosition += previousPosition - newPosition`.Note that different integrations give different results as forcesare different.In Highcharts v7.0.x only `'euler'` integration was supported.
		/// </summary>
		public PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptionsIntegration Integration { get; set; }
		private PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptionsIntegration Integration_DefaultValue { get; set; }
		 

		/// <summary>
		/// Ideal length (px) of the link between two nodes. When notdefined, length is calculated as:`Math.pow(availableWidth * availableHeight / nodesLength, 0.4);`Note: Because of the algorithm specification, length of each linkmight be not exactly as specified.
		/// </summary>
		public double? LinkLength { get; set; }
		private double? LinkLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styling options for parentNodes markers. Similar toline.marker options.
		/// </summary>
		public PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptionsMarker Marker { get; set; }
		private PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptionsMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? MaxIterations { get; set; }
		private double? MaxIterations_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? MaxSpeed { get; set; }
		private double? MaxSpeed_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? SeriesInteraction { get; set; }
		private bool? SeriesInteraction_DefaultValue { get; set; }
		 

		/// <summary>
		/// Type of the algorithm used when positioning nodes.
		/// </summary>
		public PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptionsType Type { get; set; }
		private PlotOptionsPackedbubbleLayoutAlgorithmParentNodeOptionsType Type_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Friction != Friction_DefaultValue) h.Add("friction",Friction);
			if (GravitationalConstant != GravitationalConstant_DefaultValue) h.Add("gravitationalConstant",GravitationalConstant);
			if (InitialPositionRadius != InitialPositionRadius_DefaultValue) h.Add("initialPositionRadius",InitialPositionRadius);
			if (InitialPositions != InitialPositions_DefaultValue) h.Add("initialPositions",InitialPositions);
			if (Integration != Integration_DefaultValue) h.Add("integration", highcharts.FirstCharacterToLower(Integration.ToString()));
			if (LinkLength != LinkLength_DefaultValue) h.Add("linkLength",LinkLength);
			if (Marker.IsDirty(ref highcharts)) h.Add("marker",Marker.ToHashtable(ref highcharts));
			if (MaxIterations != MaxIterations_DefaultValue) h.Add("maxIterations",MaxIterations);
			if (MaxSpeed != MaxSpeed_DefaultValue) h.Add("maxSpeed",MaxSpeed);
			if (SeriesInteraction != SeriesInteraction_DefaultValue) h.Add("seriesInteraction",SeriesInteraction);
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

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}
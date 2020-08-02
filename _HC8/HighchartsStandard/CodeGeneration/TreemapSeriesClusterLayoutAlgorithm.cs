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
	public partial class TreemapSeriesClusterLayoutAlgorithm  : BaseObject
	{
		Hashtable h = new Hashtable();

		public TreemapSeriesClusterLayoutAlgorithm()
		{
			Distance = Distance_DefaultValue = "40";
			DistanceNumber = DistanceNumber_DefaultValue = null;
			GridSize = GridSize_DefaultValue = "50";
			GridSizeNumber = GridSizeNumber_DefaultValue = null;
			Iterations = Iterations_DefaultValue = null;
			KmeansThreshold = KmeansThreshold_DefaultValue = 100;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// When `type` is set to `kmeans`,`distance` is a maximum distance between point and cluster centerso that this point will be inside the cluster. The distanceis either a number defining pixels or a percentagedefining a percentage of the plot area width.
		/// </summary>
		public string Distance { get; set; }
		private string Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// When `type` is set to `kmeans`,`distance` is a maximum distance between point and cluster centerso that this point will be inside the cluster. The distanceis either a number defining pixels or a percentagedefining a percentage of the plot area width.
		/// </summary>
		public double? DistanceNumber { get; set; }
		private double? DistanceNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// When `type` is set to the `grid`,`gridSize` is a size of a grid square element either as a numberdefining pixels, or a percentage defining a percentageof the plot area width.
		/// </summary>
		public string GridSize { get; set; }
		private string GridSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// When `type` is set to the `grid`,`gridSize` is a size of a grid square element either as a numberdefining pixels, or a percentage defining a percentageof the plot area width.
		/// </summary>
		public double? GridSizeNumber { get; set; }
		private double? GridSizeNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// When `type` is set to `kmeans`,`iterations` are the number of iterations that this algorithm will berepeated to find clusters positions.
		/// </summary>
		public double? Iterations { get; set; }
		private double? Iterations_DefaultValue { get; set; }
		 

		/// <summary>
		/// When `type` is set to `undefined` and there are more visible pointsthan the kmeansThreshold the `grid` algorithm is used to findclusters, otherwise `kmeans`. It ensures good performance onlarge datasets and better clusters arrangement after the zoom.
		/// </summary>
		public double? KmeansThreshold { get; set; }
		private double? KmeansThreshold_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (DistanceNumber != DistanceNumber_DefaultValue) h.Add("distance",DistanceNumber);
			if (GridSize != GridSize_DefaultValue) h.Add("gridSize",GridSize);
			if (GridSizeNumber != GridSizeNumber_DefaultValue) h.Add("gridSize",GridSizeNumber);
			if (Iterations != Iterations_DefaultValue) h.Add("iterations",Iterations);
			if (KmeansThreshold != KmeansThreshold_DefaultValue) h.Add("kmeansThreshold",KmeansThreshold);
			h.Add("type","treemapclusterlayoutalgorithm");
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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
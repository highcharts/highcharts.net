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
	public partial class ScatterSeriesClusterLayoutAlgorithm  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ScatterSeriesClusterLayoutAlgorithm()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// When `type` is set to `kmeans`,`distance` is a maximum distance between point and cluster centerso that this point will be inside the cluster. The distanceis either a number defining pixels or a percentagedefining a percentage of the plot area width.
		/// </summary>
		public string Distance { get; set; }
		 

		/// <summary>
		/// When `type` is set to `kmeans`,`distance` is a maximum distance between point and cluster centerso that this point will be inside the cluster. The distanceis either a number defining pixels or a percentagedefining a percentage of the plot area width.
		/// </summary>
		public double? DistanceNumber { get; set; }
		 

		/// <summary>
		/// When `type` is set to the `grid`,`gridSize` is a size of a grid square element either as a numberdefining pixels, or a percentage defining a percentageof the plot area width.
		/// </summary>
		public string GridSize { get; set; }
		 

		/// <summary>
		/// When `type` is set to the `grid`,`gridSize` is a size of a grid square element either as a numberdefining pixels, or a percentage defining a percentageof the plot area width.
		/// </summary>
		public double? GridSizeNumber { get; set; }
		 

		/// <summary>
		/// When `type` is set to `kmeans`,`iterations` are the number of iterations that this algorithm will berepeated to find clusters positions.
		/// </summary>
		public double? Iterations { get; set; }
		 

		/// <summary>
		/// When `type` is set to `undefined` and there are more visible pointsthan the kmeansThreshold the `grid` algorithm is used to findclusters, otherwise `kmeans`. It ensures good performance onlarge datasets and better clusters arrangement after the zoom.
		/// </summary>
		public double? KmeansThreshold { get; set; }
		 

		/// <summary>
		/// Type of the algorithm used to combine points into a cluster.There are three available algorithms:1) `grid` - grid-based clustering technique. Points are assignedto squares of set size depending on their position on the plotarea. Points inside the grid square are combined into a cluster.The grid size can be controlled by `gridSize` property(grid size changes at certain zoom levels).2) `kmeans` - based on K-Means clustering technique. In thefirst step, points are divided using the grid method (distanceproperty is a grid size) to find the initial amount of clusters.Next, each point is classified by computing the distance betweeneach cluster center and that point. When the closest clusterdistance is lower than distance property set by a user the pointis added to this cluster otherwise is classified as `noise`. Thealgorithm is repeated until each cluster center not change itsprevious position more than one pixel. This technique is moreaccurate but also more time consuming than the `grid` algorithm,especially for big datasets.3) `optimizedKmeans` - based on K-Means clustering technique. Thisalgorithm uses k-means algorithm only on the chart initializationor when chart extremes have greater range than on initialization.When a chart is redrawn the algorithm checks only clustered pointsdistance from the cluster center and rebuild it when the point isspaced enough to be outside the cluster. It provides performanceimprovement and more stable clusters position yet can be used ratheron small and sparse datasets.By default, the algorithm depends on visible quantity of pointsand `kmeansThreshold`. When there are more visible points than the`kmeansThreshold` the `grid` algorithm is used, otherwise `kmeans`.The custom clustering algorithm can be added by assigning a callbackfunction as the type property. This function takes an array of`processedXData`, `processedYData`, `processedXData` indexes and`layoutAlgorithm` options as arguments and should return an objectwith grouped data.The algorithm should return an object like that:<pre>{ clusterId1: [{     x: 573,     y: 285,     index: 1 // point index in the data array }, {     x: 521,     y: 197,     index: 2 }], clusterId2: [{     ... }] ...}</pre>`clusterId` (example above - unique id of a cluster or noise)is an array of points belonging to a cluster. If thearray has only one point or fewer points than set in`cluster.minimumClusterSize` it won't be combined into a cluster.
		/// </summary>
		public string Type { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Distance != null) h.Add("distance",Distance);
			if (DistanceNumber != null) h.Add("distance",DistanceNumber);
			if (GridSize != null) h.Add("gridSize",GridSize);
			if (GridSizeNumber != null) h.Add("gridSize",GridSizeNumber);
			if (Iterations != null) h.Add("iterations",Iterations);
			if (KmeansThreshold != null) h.Add("kmeansThreshold",KmeansThreshold);
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
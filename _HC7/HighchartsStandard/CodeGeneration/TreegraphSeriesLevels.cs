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
	public partial class TreegraphSeriesLevels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public TreegraphSeriesLevels()
		{
		}	
		

		/// <summary>
		/// Can set a `borderColor` on all points which lies on the same level.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// Set the dash style of the border of all the point which lies on thelevel. See[plotOptions.scatter.dashStyle](#plotoptions.scatter.dashstyle)for possible options.
		/// </summary>
		public Hashtable BorderDashStyle { get; set; }
		 

		/// <summary>
		/// Can set the borderWidth on all points which lies on the same level.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// Set collapsed status for nodes level-wise.
		/// </summary>
		public bool? Collapsed { get; set; }
		 

		/// <summary>
		/// Can set a color on all points which lies on the same level.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// A configuration object to define how the color of a child varies fromthe parent's color. The variation is distributed among the childrenof node. For example when setting brightness, the brightness changewill range from the parent's original brightness on the first child,to the amount set in the `to` setting on the last node. This allows agradient-like color scheme that sets children out from each otherwhile highlighting the grouping on treemaps and sectors on sunburstcharts.
		/// </summary>
		public TreegraphSeriesLevelsColorVariation ColorVariation { get; set; }
		 

		/// <summary>
		/// Can set the options of dataLabels on each point which lies on thelevel.[plotOptions.treemap.dataLabels](#plotOptions.treemap.dataLabels) forpossible values.
		/// </summary>
		public TreegraphSeriesDataLabels DataLabels { get; set; }
		 

		/// <summary>
		/// Can set the layoutAlgorithm option on a specific level.
		/// </summary>
		public TreegraphSeriesLevelsLayoutAlgorithm LayoutAlgorithm { get; set; }
		 

		/// <summary>
		/// Can set the layoutStartingDirection option on a specific level.
		/// </summary>
		public TreegraphSeriesLevelsLayoutStartingDirection LayoutStartingDirection { get; set; }
		 

		/// <summary>
		/// Decides which level takes effect from the options set in the levelsobject.
		/// </summary>
		public double? Level { get; set; }
		 

		/// <summary>
		/// Set marker options for nodes at the level.
		/// </summary>
		public TreegraphSeriesLevelsMarker Marker { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderDashStyle != null) h.Add("borderDashStyle",BorderDashStyle);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (Collapsed != null) h.Add("collapsed",Collapsed);
			if (Color != null) h.Add("color",Color);
			if (ColorVariation != null) h.Add("colorVariation",ColorVariation.ToHashtable(highcharts));
			if (DataLabels != null) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (LayoutAlgorithm != TreegraphSeriesLevelsLayoutAlgorithm.Null) h.Add("layoutAlgorithm", highcharts.FirstCharacterToLower(LayoutAlgorithm.ToString()));
			if (LayoutStartingDirection != TreegraphSeriesLevelsLayoutStartingDirection.Null) h.Add("layoutStartingDirection", highcharts.FirstCharacterToLower(LayoutStartingDirection.ToString()));
			if (Level != null) h.Add("level",Level);
			if (Marker != null) h.Add("marker",Marker.ToHashtable(highcharts));
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
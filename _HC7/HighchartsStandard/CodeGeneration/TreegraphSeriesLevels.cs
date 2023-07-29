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
			BorderColor = BorderColor_DefaultValue = "";
			BorderDashStyle = BorderDashStyle_DefaultValue = new Hashtable();
			BorderWidth = BorderWidth_DefaultValue = null;
			Collapsed = Collapsed_DefaultValue = null;
			Color = Color_DefaultValue = "";
			ColorVariation = ColorVariation_DefaultValue = new TreegraphSeriesLevelsColorVariation();
			DataLabels = DataLabels_DefaultValue = new TreegraphSeriesDataLabels();
			LayoutAlgorithm = LayoutAlgorithm_DefaultValue = TreegraphSeriesLevelsLayoutAlgorithm.SliceAndDice;
			LayoutStartingDirection = LayoutStartingDirection_DefaultValue = TreegraphSeriesLevelsLayoutStartingDirection.Vertical;
			Level = Level_DefaultValue = null;
			Marker = Marker_DefaultValue = new TreegraphSeriesLevelsMarker();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Can set a `borderColor` on all points which lies on the same level.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the dash style of the border of all the point which lies on thelevel. See[plotOptions.scatter.dashStyle](#plotoptions.scatter.dashstyle)for possible options.
		/// </summary>
		public Hashtable BorderDashStyle { get; set; }
		private Hashtable BorderDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set the borderWidth on all points which lies on the same level.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set collapsed status for nodes level-wise.
		/// </summary>
		public bool? Collapsed { get; set; }
		private bool? Collapsed_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a color on all points which lies on the same level.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object to define how the color of a child varies fromthe parent's color. The variation is distributed among the childrenof node. For example when setting brightness, the brightness changewill range from the parent's original brightness on the first child,to the amount set in the `to` setting on the last node. This allows agradient-like color scheme that sets children out from each otherwhile highlighting the grouping on treemaps and sectors on sunburstcharts.
		/// </summary>
		public TreegraphSeriesLevelsColorVariation ColorVariation { get; set; }
		private TreegraphSeriesLevelsColorVariation ColorVariation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set the options of dataLabels on each point which lies on thelevel.[plotOptions.treemap.dataLabels](#plotOptions.treemap.dataLabels) forpossible values.
		/// </summary>
		public TreegraphSeriesDataLabels DataLabels { get; set; }
		private TreegraphSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set the layoutAlgorithm option on a specific level.
		/// </summary>
		public TreegraphSeriesLevelsLayoutAlgorithm LayoutAlgorithm { get; set; }
		private TreegraphSeriesLevelsLayoutAlgorithm LayoutAlgorithm_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set the layoutStartingDirection option on a specific level.
		/// </summary>
		public TreegraphSeriesLevelsLayoutStartingDirection LayoutStartingDirection { get; set; }
		private TreegraphSeriesLevelsLayoutStartingDirection LayoutStartingDirection_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decides which level takes effect from the options set in the levelsobject.
		/// </summary>
		public double? Level { get; set; }
		private double? Level_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set marker options for nodes at the level.
		/// </summary>
		public TreegraphSeriesLevelsMarker Marker { get; set; }
		private TreegraphSeriesLevelsMarker Marker_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderDashStyle != BorderDashStyle_DefaultValue) h.Add("borderDashStyle",BorderDashStyle);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Collapsed != Collapsed_DefaultValue) h.Add("collapsed",Collapsed);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorVariation.IsDirty(highcharts)) h.Add("colorVariation",ColorVariation.ToHashtable(highcharts));
			if (DataLabels.IsDirty(highcharts)) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (LayoutAlgorithm != LayoutAlgorithm_DefaultValue) h.Add("layoutAlgorithm", highcharts.FirstCharacterToLower(LayoutAlgorithm.ToString()));
			if (LayoutStartingDirection != LayoutStartingDirection_DefaultValue) h.Add("layoutStartingDirection", highcharts.FirstCharacterToLower(LayoutStartingDirection.ToString()));
			if (Level != Level_DefaultValue) h.Add("level",Level);
			if (Marker.IsDirty(highcharts)) h.Add("marker",Marker.ToHashtable(highcharts));
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
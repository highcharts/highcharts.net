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
	public partial class PlotOptionsTreemapLevels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTreemapLevels()
		{
			BorderColor = BorderColor_DefaultValue = "";
			BorderDashStyle = BorderDashStyle_DefaultValue = new Hashtable();
			BorderWidth = BorderWidth_DefaultValue = null;
			Color = Color_DefaultValue = "";
			ColorVariation = ColorVariation_DefaultValue = new PlotOptionsTreemapLevelsColorVariation();
			DataLabels = DataLabels_DefaultValue = new PlotOptionsTreemapDataLabels();
			LayoutAlgorithm = LayoutAlgorithm_DefaultValue = PlotOptionsTreemapLevelsLayoutAlgorithm.Null;
			LayoutStartingDirection = LayoutStartingDirection_DefaultValue = PlotOptionsTreemapLevelsLayoutStartingDirection.Null;
			Level = Level_DefaultValue = null;
			
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
		/// Can set a color on all points which lies on the same level.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object to define how the color of a child varies fromthe parent's color. The variation is distributed among the childrenof node. For example when setting brightness, the brightness changewill range from the parent's original brightness on the first child,to the amount set in the `to` setting on the last node. This allows agradient-like color scheme that sets children out from each otherwhile highlighting the grouping on treemaps and sectors on sunburstcharts.
		/// </summary>
		public PlotOptionsTreemapLevelsColorVariation ColorVariation { get; set; }
		private PlotOptionsTreemapLevelsColorVariation ColorVariation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set the options of dataLabels on each point which lies on thelevel.[plotOptions.treemap.dataLabels](#plotOptions.treemap.dataLabels) forpossible values.
		/// </summary>
		public PlotOptionsTreemapDataLabels DataLabels { get; set; }
		private PlotOptionsTreemapDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set the layoutAlgorithm option on a specific level.
		/// </summary>
		public PlotOptionsTreemapLevelsLayoutAlgorithm LayoutAlgorithm { get; set; }
		private PlotOptionsTreemapLevelsLayoutAlgorithm LayoutAlgorithm_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set the layoutStartingDirection option on a specific level.
		/// </summary>
		public PlotOptionsTreemapLevelsLayoutStartingDirection LayoutStartingDirection { get; set; }
		private PlotOptionsTreemapLevelsLayoutStartingDirection LayoutStartingDirection_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decides which level takes effect from the options set in the levelsobject.
		/// </summary>
		public double? Level { get; set; }
		private double? Level_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderDashStyle != BorderDashStyle_DefaultValue) h.Add("borderDashStyle",BorderDashStyle);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorVariation.IsDirty(highcharts)) h.Add("colorVariation",ColorVariation.ToHashtable(highcharts));
			if (DataLabels.IsDirty(highcharts)) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (LayoutAlgorithm != LayoutAlgorithm_DefaultValue) h.Add("layoutAlgorithm", highcharts.FirstCharacterToLower(LayoutAlgorithm.ToString()));
			if (LayoutStartingDirection != LayoutStartingDirection_DefaultValue) h.Add("layoutStartingDirection", highcharts.FirstCharacterToLower(LayoutStartingDirection.ToString()));
			if (Level != Level_DefaultValue) h.Add("level",Level);
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
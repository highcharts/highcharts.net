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
	public partial class PlotOptionsTreemapLevels  : BaseObject
	{
		public PlotOptionsTreemapLevels()
		{
			BorderColor = BorderColor_DefaultValue = "";
			BorderDashStyle = BorderDashStyle_DefaultValue = "";
			BorderWidth = BorderWidth_DefaultValue = null;
			Color = Color_DefaultValue = "";
			ColorVariation = ColorVariation_DefaultValue = new PlotOptionsTreemapLevelsColorVariation();
			DataLabels = DataLabels_DefaultValue = new PlotOptionsTreemapDataLabels();
			LayoutAlgorithm = LayoutAlgorithm_DefaultValue = PlotOptionsTreemapLevelsLayoutAlgorithm.Null;
			LayoutStartingDirection = LayoutStartingDirection_DefaultValue = PlotOptionsTreemapLevelsLayoutStartingDirection.Null;
			Level = Level_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Can set a `borderColor` on all points which lies on the same level.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the dash style of the border of all the point which lies on thelevel. See <a href"#plotoptions.scatter.dashstyle">plotOptions.scatter.dashStyle</a> for possible options.
		/// </summary>
		public string BorderDashStyle { get; set; }
		private string BorderDashStyle_DefaultValue { get; set; }
		 

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
		/// A configuration object to define how the color of a child varies from theparent's color. The variation is distributed among the children of node.For example when setting brightness, the brightness change will rangefrom the parent's original brightness on the first child, to the amountset in the `to` setting on the last node. This allows a gradient-likecolor scheme that sets children out from each other while highlightingthe grouping on treemaps and sectors on sunburst charts.
		/// </summary>
		public PlotOptionsTreemapLevelsColorVariation ColorVariation { get; set; }
		private PlotOptionsTreemapLevelsColorVariation ColorVariation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set the options of dataLabels on each point which lies on thelevel. [plotOptions.treemap.dataLabels](#plotOptions.treemap.dataLabels)for possible values.
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
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderDashStyle != BorderDashStyle_DefaultValue) h.Add("borderDashStyle",BorderDashStyle);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorVariation.IsDirty()) h.Add("colorVariation",ColorVariation.ToHashtable());
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (LayoutAlgorithm != LayoutAlgorithm_DefaultValue) h.Add("layoutAlgorithm", Highcharts.FirstCharacterToLower(LayoutAlgorithm.ToString()));
			if (LayoutStartingDirection != LayoutStartingDirection_DefaultValue) h.Add("layoutStartingDirection", Highcharts.FirstCharacterToLower(LayoutStartingDirection.ToString()));
			if (Level != Level_DefaultValue) h.Add("level",Level);
			

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
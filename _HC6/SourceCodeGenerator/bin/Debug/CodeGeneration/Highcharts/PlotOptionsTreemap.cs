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
	public partial class PlotOptionsTreemap  : BaseObject
	{
		public PlotOptionsTreemap()
		{
			ShowInLegend = ShowInLegend_DefaultValue = false;
			Tooltip = Tooltip_DefaultValue = null;
			IgnoreHiddenPoint = IgnoreHiddenPoint_DefaultValue = true;
			LayoutAlgorithm = LayoutAlgorithm_DefaultValue = "sliceAndDice";
			LayoutStartingDirection = LayoutStartingDirection_DefaultValue = "vertical";
			AlternateStartingDirection = AlternateStartingDirection_DefaultValue = false;
			LevelIsConstant = LevelIsConstant_DefaultValue = true;
			DrillUpButton = DrillUpButton_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = "#e6e6e6";
			BorderWidth = BorderWidth_DefaultValue = 1;
			Opacity = Opacity_DefaultValue = 0.15;
			States = States_DefaultValue = null;
			AllowDrillToNode = AllowDrillToNode_DefaultValue = false;
			CropThreshold = CropThreshold_DefaultValue = 300;
			InteractByLeaf = InteractByLeaf_DefaultValue = null;
			SortIndex = SortIndex_DefaultValue = null;
			Levels = Levels_DefaultValue = null;
			ShowInLegend = ShowInLegend_DefaultValue = false;
			DataLabels = DataLabels_DefaultValue = "";
			Enabled = Enabled_DefaultValue = True;
			Defer = Defer_DefaultValue = False;
			VerticalAlign = VerticalAlign_DefaultValue = middle;
			Formatter = Formatter_DefaultValue = "";
			Inside = Inside_DefaultValue = True;
			Tooltip = Tooltip_DefaultValue = "";
			HeaderFormat = HeaderFormat_DefaultValue = "";
			PointFormat = PointFormat_DefaultValue = <b>{point.name}</b>: {point.value}<br/>;
			IgnoreHiddenPoint = IgnoreHiddenPoint_DefaultValue = true;
			LayoutAlgorithm = LayoutAlgorithm_DefaultValue = "sliceAndDice";
			LayoutStartingDirection = LayoutStartingDirection_DefaultValue = "vertical";
			AlternateStartingDirection = AlternateStartingDirection_DefaultValue = false;
			LevelIsConstant = LevelIsConstant_DefaultValue = true;
			DrillUpButton = DrillUpButton_DefaultValue = "";
			Position = Position_DefaultValue = new Hashtable();
			Align = Align_DefaultValue = right;
			X = X_DefaultValue = -10;
			Y = Y_DefaultValue = 10;
			VerticalAlign = VerticalAlign_DefaultValue = top;
			BorderColor = BorderColor_DefaultValue = "#e6e6e6";
			BorderWidth = BorderWidth_DefaultValue = 1;
			Opacity = Opacity_DefaultValue = 0.15;
			States = States_DefaultValue = "";
			Hover = Hover_DefaultValue = "";
			BorderColor = BorderColor_DefaultValue = #999999;
			Brightness = Brightness_DefaultValue = null;
			Halo = Halo_DefaultValue = False;
			Opacity = Opacity_DefaultValue = 0.75;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			AllowDrillToNode = AllowDrillToNode_DefaultValue = false;
			CropThreshold = CropThreshold_DefaultValue = 300;
			InteractByLeaf = InteractByLeaf_DefaultValue = "";
			SortIndex = SortIndex_DefaultValue = null;
			Levels = Levels_DefaultValue = "";
			BorderColor = BorderColor_DefaultValue = "";
			BorderDashStyle = BorderDashStyle_DefaultValue = "";
			BorderWidth = BorderWidth_DefaultValue = null;
			Color = Color_DefaultValue = "";
			ColorVariation = ColorVariation_DefaultValue = "";
			Key = Key_DefaultValue = "";
			To = To_DefaultValue = null;
			LayoutAlgorithm = LayoutAlgorithm_DefaultValue = "";
			LayoutStartingDirection = LayoutStartingDirection_DefaultValue = "";
			Level = Level_DefaultValue = null;
			Enabled = Enabled_DefaultValue = True;
			Defer = Defer_DefaultValue = False;
			VerticalAlign = VerticalAlign_DefaultValue = middle;
			Formatter = Formatter_DefaultValue = "";
			Inside = Inside_DefaultValue = True;
			Hover = Hover_DefaultValue = "";
			BorderColor = BorderColor_DefaultValue = #999999;
			Brightness = Brightness_DefaultValue = null;
			Halo = Halo_DefaultValue = False;
			Opacity = Opacity_DefaultValue = 0.75;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			BorderColor = BorderColor_DefaultValue = #999999;
			Brightness = Brightness_DefaultValue = null;
			Opacity = Opacity_DefaultValue = 0.75;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			BorderColor = BorderColor_DefaultValue = #999999;
			Brightness = Brightness_DefaultValue = null;
			Opacity = Opacity_DefaultValue = 0.75;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			BorderColor = BorderColor_DefaultValue = #999999;
			Brightness = Brightness_DefaultValue = null;
			Opacity = Opacity_DefaultValue = 0.75;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			
		}	
		

		/// <summary>
		/// Whether to display this series type or specific series item in thelegend.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapTooltip Tooltip { get; set; }
		private PlotOptionsTreemapTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to ignore hidden points when the layout algorithm runs.If `false`, hidden points will leave open spaces.
		/// </summary>
		public bool? IgnoreHiddenPoint { get; set; }
		private bool? IgnoreHiddenPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option decides which algorithm is used for setting positionand dimensions of the points. Can be one of `sliceAndDice`, `stripes`, `squarified` or `strip`.
		/// </summary>
		public string LayoutAlgorithm { get; set; }
		private string LayoutAlgorithm_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines which direction the layout algorithm will start drawing. Possible values are "vertical" and "horizontal".
		/// </summary>
		public string LayoutStartingDirection { get; set; }
		private string LayoutStartingDirection_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enabling this option will make the treemap alternate the drawingdirection between vertical and horizontal. The next levels startingdirection will always be the opposite of the previous.
		/// </summary>
		public bool? AlternateStartingDirection { get; set; }
		private bool? AlternateStartingDirection_DefaultValue { get; set; }
		 

		/// <summary>
		/// Used together with the levels and allowDrillToNode options. Whenset to false the first level visible when drilling is consideredto be level one. Otherwise the level will be the same as the treestructure.
		/// </summary>
		public bool? LevelIsConstant { get; set; }
		private bool? LevelIsConstant_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the button appearing when drilling down in a treemap.
		/// </summary>
		public PlotOptionsTreemapDrillUpButton DrillUpButton { get; set; }
		private PlotOptionsTreemapDrillUpButton DrillUpButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each tree map item.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the border surrounding each tree map item.
		/// </summary>
		public PlotOptionsTreemapBorderWidth BorderWidth { get; set; }
		private PlotOptionsTreemapBorderWidth BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opacity of a point in treemap. When a point has children, thevisibility of the children is determined by the opacity.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsTreemapStates States { get; set; }
		private PlotOptionsTreemapStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// When enabled the user can click on a point which is a parent andzoom in on its children.
		/// </summary>
		public bool? AllowDrillToNode { get; set; }
		private bool? AllowDrillToNode_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the series contains less points than the crop threshold, allpoints are drawn, event if the points fall outside the visible plotarea at the current zoom. The advantage of drawing all points (includingmarkers and columns), is that animation is performed on updates.On the other hand, when the series contains more points than thecrop threshold, the series data is cropped to only contain pointsthat fall within the plot area. The advantage of cropping away invisiblepoints is to increase performance on large series.
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option decides if the user can interact with the parent nodesor just the leaf nodes. When this option is undefined, it will betrue by default. However when allowDrillToNode is true, then it willbe false by default.
		/// </summary>
		public bool? InteractByLeaf { get; set; }
		private bool? InteractByLeaf_DefaultValue { get; set; }
		 

		/// <summary>
		/// The sort index of the point inside the treemap level.
		/// </summary>
		public double? SortIndex { get; set; }
		private double? SortIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set options on specific levels. Takes precedence over series options,but not point options.
		/// </summary>
		public List<object> Levels { get; set; }
		private List<object> Levels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this series type or specific series item in thelegend.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapDataLabels DataLabels { get; set; }
		private PlotOptionsTreemapDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapEnabled Enabled { get; set; }
		private PlotOptionsTreemapEnabled Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapDefer Defer { get; set; }
		private PlotOptionsTreemapDefer Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsTreemapVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapFormatter Formatter { get; set; }
		private PlotOptionsTreemapFormatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapInside Inside { get; set; }
		private PlotOptionsTreemapInside Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapTooltip Tooltip { get; set; }
		private PlotOptionsTreemapTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapHeaderFormat HeaderFormat { get; set; }
		private PlotOptionsTreemapHeaderFormat HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapPointFormat PointFormat { get; set; }
		private PlotOptionsTreemapPointFormat PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to ignore hidden points when the layout algorithm runs.If `false`, hidden points will leave open spaces.
		/// </summary>
		public bool? IgnoreHiddenPoint { get; set; }
		private bool? IgnoreHiddenPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option decides which algorithm is used for setting positionand dimensions of the points. Can be one of `sliceAndDice`, `stripes`, `squarified` or `strip`.
		/// </summary>
		public string LayoutAlgorithm { get; set; }
		private string LayoutAlgorithm_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines which direction the layout algorithm will start drawing. Possible values are "vertical" and "horizontal".
		/// </summary>
		public string LayoutStartingDirection { get; set; }
		private string LayoutStartingDirection_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enabling this option will make the treemap alternate the drawingdirection between vertical and horizontal. The next levels startingdirection will always be the opposite of the previous.
		/// </summary>
		public bool? AlternateStartingDirection { get; set; }
		private bool? AlternateStartingDirection_DefaultValue { get; set; }
		 

		/// <summary>
		/// Used together with the levels and allowDrillToNode options. Whenset to false the first level visible when drilling is consideredto be level one. Otherwise the level will be the same as the treestructure.
		/// </summary>
		public bool? LevelIsConstant { get; set; }
		private bool? LevelIsConstant_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the button appearing when drilling down in a treemap.
		/// </summary>
		public PlotOptionsTreemapDrillUpButton DrillUpButton { get; set; }
		private PlotOptionsTreemapDrillUpButton DrillUpButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the button.
		/// </summary>
		public Hashtable Position { get; set; }
		private Hashtable Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal alignment of the button.
		/// </summary>
		public PlotOptionsTreemapAlign Align { get; set; }
		private PlotOptionsTreemapAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal offset of the button.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical offset of the button.
		/// </summary>
		public PlotOptionsTreemapY Y { get; set; }
		private PlotOptionsTreemapY Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the button.
		/// </summary>
		public PlotOptionsTreemapVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsTreemapVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each tree map item.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the border surrounding each tree map item.
		/// </summary>
		public PlotOptionsTreemapBorderWidth BorderWidth { get; set; }
		private PlotOptionsTreemapBorderWidth BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opacity of a point in treemap. When a point has children, thevisibility of the children is determined by the opacity.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsTreemapStates States { get; set; }
		private PlotOptionsTreemapStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the hovered series
		/// </summary>
		public PlotOptionsTreemapHover Hover { get; set; }
		private PlotOptionsTreemapHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the hovered state.
		/// </summary>
		public PlotOptionsTreemapBorderColor BorderColor { get; set; }
		private PlotOptionsTreemapBorderColor BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Brightness for the hovered point. Defaults to 0 if the heatmapseries is loaded, otherwise 0.1.
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapHalo Halo { get; set; }
		private PlotOptionsTreemapHalo Halo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opacity of a point in treemap. When a point has children,the visibility of the children is determined by the opacity.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow option for hovered state.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// When enabled the user can click on a point which is a parent andzoom in on its children.
		/// </summary>
		public bool? AllowDrillToNode { get; set; }
		private bool? AllowDrillToNode_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the series contains less points than the crop threshold, allpoints are drawn, event if the points fall outside the visible plotarea at the current zoom. The advantage of drawing all points (includingmarkers and columns), is that animation is performed on updates.On the other hand, when the series contains more points than thecrop threshold, the series data is cropped to only contain pointsthat fall within the plot area. The advantage of cropping away invisiblepoints is to increase performance on large series.
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option decides if the user can interact with the parent nodesor just the leaf nodes. When this option is undefined, it will betrue by default. However when allowDrillToNode is true, then it willbe false by default.
		/// </summary>
		public bool? InteractByLeaf { get; set; }
		private bool? InteractByLeaf_DefaultValue { get; set; }
		 

		/// <summary>
		/// The sort index of the point inside the treemap level.
		/// </summary>
		public double? SortIndex { get; set; }
		private double? SortIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set options on specific levels. Takes precedence over series options,but not point options.
		/// </summary>
		public List<object> Levels { get; set; }
		private List<object> Levels_DefaultValue { get; set; }
		 

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
		public PlotOptionsTreemapColorVariation ColorVariation { get; set; }
		private PlotOptionsTreemapColorVariation ColorVariation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The key of a color variation. Currently supports `brightness` only.
		/// </summary>
		public string Key { get; set; }
		private string Key_DefaultValue { get; set; }
		 

		/// <summary>
		/// The ending value of a color variation. The last sibling will receive thisvalue.
		/// </summary>
		public double? To { get; set; }
		private double? To_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set the layoutAlgorithm option on a specific level.
		/// </summary>
		public string LayoutAlgorithm { get; set; }
		private string LayoutAlgorithm_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set the layoutStartingDirection option on a specific level.
		/// </summary>
		public string LayoutStartingDirection { get; set; }
		private string LayoutStartingDirection_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decides which level takes effect from the options set in the levelsobject.
		/// </summary>
		public double? Level { get; set; }
		private double? Level_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapEnabled Enabled { get; set; }
		private PlotOptionsTreemapEnabled Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapDefer Defer { get; set; }
		private PlotOptionsTreemapDefer Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsTreemapVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapFormatter Formatter { get; set; }
		private PlotOptionsTreemapFormatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapInside Inside { get; set; }
		private PlotOptionsTreemapInside Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the hovered series
		/// </summary>
		public PlotOptionsTreemapHover Hover { get; set; }
		private PlotOptionsTreemapHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the hovered state.
		/// </summary>
		public PlotOptionsTreemapBorderColor BorderColor { get; set; }
		private PlotOptionsTreemapBorderColor BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Brightness for the hovered point. Defaults to 0 if the heatmapseries is loaded, otherwise 0.1.
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapHalo Halo { get; set; }
		private PlotOptionsTreemapHalo Halo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opacity of a point in treemap. When a point has children,the visibility of the children is determined by the opacity.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow option for hovered state.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the hovered state.
		/// </summary>
		public PlotOptionsTreemapBorderColor BorderColor { get; set; }
		private PlotOptionsTreemapBorderColor BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Brightness for the hovered point. Defaults to 0 if the heatmapseries is loaded, otherwise 0.1.
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opacity of a point in treemap. When a point has children,the visibility of the children is determined by the opacity.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow option for hovered state.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the hovered state.
		/// </summary>
		public PlotOptionsTreemapBorderColor BorderColor { get; set; }
		private PlotOptionsTreemapBorderColor BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Brightness for the hovered point. Defaults to 0 if the heatmapseries is loaded, otherwise 0.1.
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opacity of a point in treemap. When a point has children,the visibility of the children is determined by the opacity.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow option for hovered state.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the hovered state.
		/// </summary>
		public PlotOptionsTreemapBorderColor BorderColor { get; set; }
		private PlotOptionsTreemapBorderColor BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Brightness for the hovered point. Defaults to 0 if the heatmapseries is loaded, otherwise 0.1.
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opacity of a point in treemap. When a point has children,the visibility of the children is determined by the opacity.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow option for hovered state.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (IgnoreHiddenPoint != IgnoreHiddenPoint_DefaultValue) h.Add("ignoreHiddenPoint",IgnoreHiddenPoint);
			if (LayoutAlgorithm != LayoutAlgorithm_DefaultValue) h.Add("layoutAlgorithm",LayoutAlgorithm);
			if (LayoutStartingDirection != LayoutStartingDirection_DefaultValue) h.Add("layoutStartingDirection",LayoutStartingDirection);
			if (AlternateStartingDirection != AlternateStartingDirection_DefaultValue) h.Add("alternateStartingDirection",AlternateStartingDirection);
			if (LevelIsConstant != LevelIsConstant_DefaultValue) h.Add("levelIsConstant",LevelIsConstant);
			if (DrillUpButton.IsDirty()) h.Add("drillUpButton",DrillUpButton.ToHashtable());
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (AllowDrillToNode != AllowDrillToNode_DefaultValue) h.Add("allowDrillToNode",AllowDrillToNode);
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (InteractByLeaf != InteractByLeaf_DefaultValue) h.Add("interactByLeaf",InteractByLeaf);
			if (SortIndex != SortIndex_DefaultValue) h.Add("sortIndex",SortIndex);
			if (Levels.IsDirty()) h.Add("levels",Levels.ToHashtable());
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (IgnoreHiddenPoint != IgnoreHiddenPoint_DefaultValue) h.Add("ignoreHiddenPoint",IgnoreHiddenPoint);
			if (LayoutAlgorithm != LayoutAlgorithm_DefaultValue) h.Add("layoutAlgorithm",LayoutAlgorithm);
			if (LayoutStartingDirection != LayoutStartingDirection_DefaultValue) h.Add("layoutStartingDirection",LayoutStartingDirection);
			if (AlternateStartingDirection != AlternateStartingDirection_DefaultValue) h.Add("alternateStartingDirection",AlternateStartingDirection);
			if (LevelIsConstant != LevelIsConstant_DefaultValue) h.Add("levelIsConstant",LevelIsConstant);
			if (DrillUpButton.IsDirty()) h.Add("drillUpButton",DrillUpButton.ToHashtable());
			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Halo != Halo_DefaultValue) h.Add("halo",Halo);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (AllowDrillToNode != AllowDrillToNode_DefaultValue) h.Add("allowDrillToNode",AllowDrillToNode);
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (InteractByLeaf != InteractByLeaf_DefaultValue) h.Add("interactByLeaf",InteractByLeaf);
			if (SortIndex != SortIndex_DefaultValue) h.Add("sortIndex",SortIndex);
			if (Levels.IsDirty()) h.Add("levels",Levels.ToHashtable());
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderDashStyle != BorderDashStyle_DefaultValue) h.Add("borderDashStyle",BorderDashStyle);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorVariation.IsDirty()) h.Add("colorVariation",ColorVariation.ToHashtable());
			if (Key != Key_DefaultValue) h.Add("key",Key);
			if (To != To_DefaultValue) h.Add("to",To);
			if (LayoutAlgorithm != LayoutAlgorithm_DefaultValue) h.Add("layoutAlgorithm",LayoutAlgorithm);
			if (LayoutStartingDirection != LayoutStartingDirection_DefaultValue) h.Add("layoutStartingDirection",LayoutStartingDirection);
			if (Level != Level_DefaultValue) h.Add("level",Level);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Halo != Halo_DefaultValue) h.Add("halo",Halo);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			

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
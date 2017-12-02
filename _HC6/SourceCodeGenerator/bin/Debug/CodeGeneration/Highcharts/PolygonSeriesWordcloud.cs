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
	public partial class PolygonSeriesWordcloud  : BaseObject
	{
		public PolygonSeriesWordcloud()
		{
			Data = Data_DefaultValue = new List<SeriesPolygonWordcloudData>();
			Label = Label_DefaultValue = "";
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			Events = Events_DefaultValue = "";
			Point = Point_DefaultValue = "";
			TurboThreshold = TurboThreshold_DefaultValue = 1000;
			AnimationLimit = AnimationLimit_DefaultValue = null;
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			Cursor = Cursor_DefaultValue = "";
			Description = Description_DefaultValue = "undefined";
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			ExposeElementToA11y = ExposeElementToA11y_DefaultValue = null;
			Keys = Keys_DefaultValue = new List<string>();
			LinkedTo = LinkedTo_DefaultValue = "";
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			Selected = Selected_DefaultValue = false;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = "";
			Visible = Visible_DefaultValue = true;
			BorderRadius = BorderRadius_DefaultValue = 0;
			Marker = Marker_DefaultValue = true;
			CropThreshold = CropThreshold_DefaultValue = 50;
			States = States_DefaultValue = "";
			StickyTracking = StickyTracking_DefaultValue = False;
			BorderColor = BorderColor_DefaultValue = "#ffffff";
			Colors = Colors_DefaultValue = new List<string>();
			EdgeWidth = EdgeWidth_DefaultValue = 1;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			BorderWidth = BorderWidth_DefaultValue = 0;
			Clip = Clip_DefaultValue = False;
			ColorByPoint = ColorByPoint_DefaultValue = True;
			PlacementStrategy = PlacementStrategy_DefaultValue = center;
			Rotation = Rotation_DefaultValue = "";
			ShowInLegend = ShowInLegend_DefaultValue = False;
			Spiral = Spiral_DefaultValue = rectangular;
			Style = Style_DefaultValue = new Hashtable{{"fontFamily","Impact},{ sans-serif"}};
			Tooltip = Tooltip_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `wordcloud` seriestype, points can be given in the following ways:1.  An array of arrays with 2 values. In this case, the valuescorrespond to `name,weight`.  ```js    data: [        ['Lorem', 4],        ['Ipsum', 1]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.arearange.turboThreshold),this option is not available. ```js    data: [{        name: "Lorem",        weight: 4    }, {        name: "Ipsum",        weight: 1    }] ```
		/// </summary>
		public List<SeriesPolygonWordcloudData> Data { get; set; }
		private List<SeriesPolygonWordcloudData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.The series labels currently work with series types having a`graph` or an `area`.Requires the `series-label.js` module.
		/// </summary>
		public PolygonSeriesWordcloudLabel Label { get; set; }
		private PolygonSeriesWordcloudLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow this series' points to be selected by clicking on the graphic (columns, point markers, pie slices, map areas etc).
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// General event handlers for the series items. These event hooks can alsobe attached to the series at run time using the `Highcharts.addEvent`function.
		/// </summary>
		public PolygonSeriesWordcloudEvents Events { get; set; }
		private PolygonSeriesWordcloudEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public PolygonSeriesWordcloudPoint Point { get; set; }
		private PolygonSeriesWordcloudPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains a data array that is longer than this, onlyone dimensional arrays of numbers, or two dimensional arrays withx and y values are allowed. Also, only the first point is tested,and the rest are assumed to be the same format. This saves expensivedata checking and indexing in long series. Set it to `0` disable.
		/// </summary>
		public double? TurboThreshold { get; set; }
		private double? TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// For some series, there is a limit that shuts down initial animationby default when the total number of points in the chart is too high.For example, for a column chart and its derivatives, animation doesn'trun if there is more than 250 points totally. To disable this cap, set`animationLimit` to `Infinity`.
		/// </summary>
		public double? AnimationLimit { get; set; }
		private double? AnimationLimit_DefaultValue { get; set; }
		 

		/// <summary>
		/// A class name to apply to the series' graphical elements.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color of the series. In line type series it applies to theline and the point markers unless otherwise specified. In bar typeseries it applies to the bars unless a color is specified per point.The default value is pulled from the `options.colors` array.In styled mode, the color can be defined by the[colorIndex](#plotOptions.series.colorIndex) option. Also, the seriescolor can be set with the `.highcharts-series`, `.highcharts-color-{n}`,`.highcharts-{type}-series` or `.highcharts-series-{n}` class, orindividual classes given by the `className` option.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styled mode only. A specific color index to use for the series, so itsgraphic representations are given the class name `highcharts-color-{n}`.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.
		/// </summary>
		public string Cursor { get; set; }
		private string Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Requires the Accessibility module.A description of the series to add to the screen reader informationabout the series.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// By default, series are exposed to screen readers as regions. By enablingthis option, the series element itself will be exposed in the sameway as the data points. This is useful if the series is not usedas a grouping entity in the chart, but you still want to attach adescription to the series.Requires the Accessibility module.
		/// </summary>
		public bool? ExposeElementToA11y { get; set; }
		private bool? ExposeElementToA11y_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [id](#series.id) of another series to link to. Additionally,the value can be ":previous" to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// Same as [accessibility.pointDescriptionFormatter](#accessibility.pointDescriptionFormatter), but for an individual series. Overridesthe chart wide configuration.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If `showCheckbox` is true,the checkbox next to the series name in the legend will be checked for aselected series.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// If set to `True`, the accessibility module will skip past the pointsin this series for keyboard navigation.
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		private bool? SkipKeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// The corner radius of the border surrounding each column or bar.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to group non-stacked columns or to let them render independentof each other. Non-grouped columns will be laid out individuallyand overlap each other.
		/// </summary>
		public bool? Marker { get; set; }
		private bool? Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the series contains less points than the crop threshold, allpoints are drawn, event if the points fall outside the visible plotarea at the current zoom. The advantage of drawing all points (includingmarkers and columns), is that animation is performed on updates.On the other hand, when the series contains more points than thecrop threshold, the series data is cropped to only contain pointsthat fall within the plot area. The advantage of cropping away invisiblepoints is to increase performance on large series. .
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PolygonSeriesWordcloudStates States { get; set; }
		private PolygonSeriesWordcloudStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PolygonSeriesWordcloudStickyTracking StickyTracking { get; set; }
		private PolygonSeriesWordcloudStickyTracking StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each column or bar.In styled mode, the border stroke can be set with the `.highcharts-point`rule.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to apply insteadof the global [colors](#colors) when [colorByPoint](#plotOptions.column.colorByPoint) is true.
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// 3D columns only. The width of the colored edges.
		/// </summary>
		public double? EdgeWidth { get; set; }
		private double? EdgeWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PolygonSeriesWordcloudBorderWidth BorderWidth { get; set; }
		private PolygonSeriesWordcloudBorderWidth BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PolygonSeriesWordcloudClip Clip { get; set; }
		private PolygonSeriesWordcloudClip Clip_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using automatic point colors pulled from the `options.colors`collection, this option determines whether the chart should receiveone color per series or one color per point.
		/// </summary>
		public PolygonSeriesWordcloudColorByPoint ColorByPoint { get; set; }
		private PolygonSeriesWordcloudColorByPoint ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option decides which algorithm is used for placement, and rotationof a word. The choice of algorith is therefore a crucial part of theresulting layout of the wordcloud.It is possible for users to add their own custom placement strategiesfor use in word cloud. Read more about it in our[documentation](https://www.highcharts.com/docs/chart-and-series-types/word-cloud-series#custom-placement-strategies)
		/// </summary>
		public PolygonSeriesWordcloudPlacementStrategy PlacementStrategy { get; set; }
		private PolygonSeriesWordcloudPlacementStrategy PlacementStrategy_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rotation options for the words in the wordcloud.
		/// </summary>
		public PolygonSeriesWordcloudRotation Rotation { get; set; }
		private PolygonSeriesWordcloudRotation Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PolygonSeriesWordcloudShowInLegend ShowInLegend { get; set; }
		private PolygonSeriesWordcloudShowInLegend ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// Spiral used for placing a word after the inital position experienced acollision with either another word or the borders.It is possible for users to add their own custom spiralling algorithmsfor use in word cloud. Read more about it in our[documentation](https://www.highcharts.com/docs/chart-and-series-types/word-cloud-series#custom-spiralling-algorithm)
		/// </summary>
		public PolygonSeriesWordcloudSpiral Spiral { get; set; }
		private PolygonSeriesWordcloudSpiral Spiral_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the words.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PolygonSeriesWordcloudTooltip Tooltip { get; set; }
		private PolygonSeriesWordcloudTooltip Tooltip_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (AnimationLimit != AnimationLimit_DefaultValue) h.Add("animationLimit",AnimationLimit);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (ExposeElementToA11y != ExposeElementToA11y_DefaultValue) h.Add("exposeElementToA11y",ExposeElementToA11y);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) h.Add("pointDescriptionFormatter",PointDescriptionFormatter);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (Marker != Marker_DefaultValue) h.Add("marker",Marker);
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (EdgeWidth != EdgeWidth_DefaultValue) h.Add("edgeWidth",EdgeWidth);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Clip != Clip_DefaultValue) h.Add("clip",Clip);
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (PlacementStrategy != PlacementStrategy_DefaultValue) h.Add("placementStrategy",PlacementStrategy);
			if (Rotation.IsDirty()) h.Add("rotation",Rotation.ToHashtable());
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (Spiral != Spiral_DefaultValue) h.Add("spiral",Spiral);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			

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
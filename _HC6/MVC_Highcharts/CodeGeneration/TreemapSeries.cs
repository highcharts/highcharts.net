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
	public partial class TreemapSeries  : Series
	{
		public TreemapSeries()
		{
			AllowDrillToNode = AllowDrillToNode_DefaultValue = TreemapSeriesAllowDrillToNode.False;
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			AlternateStartingDirection = AlternateStartingDirection_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			AnimationLimit = AnimationLimit_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = "#e6e6e6";
			BorderWidth = BorderWidth_DefaultValue = 1;
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "null";
			ColorByPoint = ColorByPoint_DefaultValue = false;
			ColorIndex = ColorIndex_DefaultValue = null;
			Colors = Colors_DefaultValue = new List<string>();
			CropThreshold = CropThreshold_DefaultValue = 300;
			Cursor = Cursor_DefaultValue = TreemapSeriesCursor.Null;
			Data = Data_DefaultValue = new List<TreemapSeriesData>();
			DataLabels = DataLabels_DefaultValue = new TreemapSeriesDataLabels();
			Description = Description_DefaultValue = "undefined";
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			Events = Events_DefaultValue = new TreemapSeriesEvents();
			GetExtremesFromAll = GetExtremesFromAll_DefaultValue = false;
			Id = Id_DefaultValue = "";
			IgnoreHiddenPoint = IgnoreHiddenPoint_DefaultValue = true;
			Index = Index_DefaultValue = null;
			InteractByLeaf = InteractByLeaf_DefaultValue = null;
			Keys = Keys_DefaultValue = new List<string>();
			LayoutAlgorithm = LayoutAlgorithm_DefaultValue = TreemapSeriesLayoutAlgorithm.SliceAndDice;
			LayoutStartingDirection = LayoutStartingDirection_DefaultValue = TreemapSeriesLayoutStartingDirection.Vertical;
			LegendIndex = LegendIndex_DefaultValue = null;
			LevelIsConstant = LevelIsConstant_DefaultValue = TreemapSeriesLevelIsConstant.True;
			Levels = Levels_DefaultValue = new List<TreemapSeriesLevels>();
			LinkedTo = LinkedTo_DefaultValue = "";
			MaxPointWidth = MaxPointWidth_DefaultValue = null;
			Name = Name_DefaultValue = null;
			Opacity = Opacity_DefaultValue = 0.15;
			Point = Point_DefaultValue = new TreemapSeriesPoint();
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			ShowInLegend = ShowInLegend_DefaultValue = false;
			SortIndex = SortIndex_DefaultValue = null;
			States = States_DefaultValue = new TreemapSeriesStates();
			StickyTracking = StickyTracking_DefaultValue = true;
			Tooltip = Tooltip_DefaultValue = new TreemapSeriesTooltip();
			TurboThreshold = TurboThreshold_DefaultValue = 1000;
			Type = Type_DefaultValue = TreemapSeriesType.Null;
			Visible = Visible_DefaultValue = true;
			XAxis = XAxis_DefaultValue = "0";
			YAxis = YAxis_DefaultValue = "0";
			ZIndex = ZIndex_DefaultValue = null;
			ZoneAxis = ZoneAxis_DefaultValue = "y";
			Zones = Zones_DefaultValue = new List<TreemapSeriesZone>();
			
		}	
		

		/// <summary>
		/// When enabled the user can click on a point which is a parent and zoom in on its children.
		/// </summary>
		public TreemapSeriesAllowDrillToNode AllowDrillToNode { get; set; }
		private TreemapSeriesAllowDrillToNode AllowDrillToNode_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow this series' points to be selected by clicking on the markers, bars or pie slices.
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enabling this option will make the treemap alternate the drawing direction between vertical and horizontal.The next levels starting direction will always be the opposite of the previous.
		/// </summary>
		public bool? AlternateStartingDirection { get; set; }
		private bool? AlternateStartingDirection_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the initial animation when a series is displayed. The animation can also be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see <a href="#chart.animation">chart.animation</a> and the animation parameter under the API methods.The following properties are supported:</p><dl>  <dt>duration</dt>  <dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>A string reference to an easing function set on the <code>Math</code> object. See <a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-animation-easing/">the easing demo</a>.</dd></dl><p>Due to poor performance, animation is disabled in old IE browsers for column charts and polar charts.</p>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// For some series, there is a limit that shuts down initial animation by default when the total number of points in the chart is too high. For example, for a column chart and its derivatives, animation doesn't run if there is more than 250 points totally. To disable this cap, set <code>animationLimit</code> to <code>Infinity</code>.
		/// </summary>
		public double? AnimationLimit { get; set; }
		private double? AnimationLimit_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each tree map item.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the border surrounding each column or bar.</p><p>In <a href="http://www.highcharts.com/docs/chart-design-and-style/style-by-css">styled mode</a>, the stroke width can be set with the <code>.highcharts-point</code> rule.</p>
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A class name to apply to the series' graphical elements.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color of the series. In heat maps this color is rarely used, as we mostly use the color to denote the value of each point. Unless options are set in the <a href="#colorAxis">colorAxis</a>, the default value is pulled from the <a href="#colors">options.colors</a> array.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using automatic point colors pulled from the <code>options.colors</code> collection, this option determines whether the chart should receive  one color per series or one color per point.
		/// </summary>
		public bool? ColorByPoint { get; set; }
		private bool? ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// <a href="http://www.highcharts.com/docs/chart-design-and-style/style-by-css">Styled mode</a> only. A specific color index to use for the series, so its graphic representations are given the class name <code>highcharts-color-{n}</code>.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to apply instead of the global <a href="#colors">colors</a> when <a href="#plotOptions.column.colorByPoint">colorByPoint</a> is true.
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the series contains less points than the crop threshold, all points are drawn, event if the points fall outside the visible plot area at the current zoom. The advantage of drawing all points (including markers and columns), is that animation is performed on updates. On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area. The advantage of cropping away invisible points is to increase performance on large series.
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.
		/// </summary>
		public TreemapSeriesCursor Cursor { get; set; }
		private TreemapSeriesCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the <code>treemap</code> series type, points can be given in the following ways: <ol> <li>An array of numerical values. In this case, the numerical values will  be interpreted as <code>value</code> options.  Example:<pre>data: [0, 5, 3, 5]</pre> </li> <li><p>An array of objects with named values. The objects are point configuration objects as seen below. If the total number of data points exceeds the series' <a href='#series<treemap>.turboThreshold'>turboThreshold</a>, this option is not available.</p><pre>data: [{    value: 7,    name: "Point2",    color: "#00FF00"}, {    value: 2,    name: "Point1",    color: "#FF00FF"}]</pre></li> </ol>
		/// </summary>
		public List<TreemapSeriesData> Data { get; set; }
		private List<TreemapSeriesData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public TreemapSeriesDataLabels DataLabels { get; set; }
		private TreemapSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p><i>Requires Accessibility module</i></p><p>A description of the series to add to the screen reader information about the series.</p>
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public TreemapSeriesEvents Events { get; set; }
		private TreemapSeriesEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to use the Y extremes of the total chart width or only the zoomed area when zooming in on parts of the X axis. By default, the Y axis adjusts to the min and max of the visible data. Cartesian series only.
		/// </summary>
		public bool? GetExtremesFromAll { get; set; }
		private bool? GetExtremesFromAll_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the series. This can be used after render time to get a pointer to the series object through <code>chart.get()</code>.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to ignore hidden points when the layout algorithm runs. If <code>false</code>, hidden points will leave open spaces.
		/// </summary>
		public bool? IgnoreHiddenPoint { get; set; }
		private bool? IgnoreHiddenPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// The index of the series in the chart, affecting the internal index in the <code>chart.series</code> array, the visible Z index as well as the order in the legend.
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option decides if the user can interact with the parent nodes or just the leaf nodes. When this option is undefined, it will be true by default. However when allowDrillToNode is true, then it will be false by default.
		/// </summary>
		public bool? InteractByLeaf { get; set; }
		private bool? InteractByLeaf_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data point array. This makes it convenient to work with unstructured data arrays from different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option decides which algorithm is used for setting position and dimensions of the points. Can be one of <code>sliceAndDice</code>, <code>stripes</code>, <code>squarified</code> or <code>strip</code>. 
		/// </summary>
		public TreemapSeriesLayoutAlgorithm LayoutAlgorithm { get; set; }
		private TreemapSeriesLayoutAlgorithm LayoutAlgorithm_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines which direction the layout algorithm will start drawing. Possible values are "vertical" and "horizontal".
		/// </summary>
		public TreemapSeriesLayoutStartingDirection LayoutStartingDirection { get; set; }
		private TreemapSeriesLayoutStartingDirection LayoutStartingDirection_DefaultValue { get; set; }
		 

		/// <summary>
		/// The sequential index of the series in the legend.  <div class="demo">Try it:  <a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/series/legendindex/" target="_blank">Legend in opposite order</a> </div>.
		/// </summary>
		public double? LegendIndex { get; set; }
		private double? LegendIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Used together with the levels and allowDrillToNode options. When set to false the first level visible when drilling is considered to be level one. Otherwise the level will be the same as the tree structure.
		/// </summary>
		public TreemapSeriesLevelIsConstant LevelIsConstant { get; set; }
		private TreemapSeriesLevelIsConstant LevelIsConstant_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set options on specific levels. Takes precedence over series options, but not point options.
		/// </summary>
		public List<TreemapSeriesLevels> Levels { get; set; }
		private List<TreemapSeriesLevels> Levels_DefaultValue { get; set; }
		 

		/// <summary>
		/// The <a href="#series.id">id</a> of another series to link to. Additionally, the value can be ":previous" to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The maximum allowed pixel width for a column, translated to the height of a bar in a bar chart. This prevents the columns from becoming too wide when there is a small number of points in the chart.
		/// </summary>
		public double? MaxPointWidth { get; set; }
		private double? MaxPointWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the series as shown in the legend, tooltip etc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opacity of a point in treemap. When a point has children, the visibility of the children is determined by the opacity. 
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point
		/// </summary>
		public TreemapSeriesPoint Point { get; set; }
		private TreemapSeriesPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If <code>showCheckbox</code> is true, the checkbox next to the series name will be checked for a selected series.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allow selecting the series. The state of the checkbox is determined by the <code>selected</code> option.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		private bool? ShowCheckbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this series type or specific series item in the legend.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// The sort index of the point inside the treemap level. 
		/// </summary>
		public double? SortIndex { get; set; }
		private double? SortIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public TreemapSeriesStates States { get; set; }
		private TreemapSeriesStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When <code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the  tooltip will be hidden when moving the mouse between series. Defaults to true for line and area type series, but to false for columns, pies etc.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public TreemapSeriesTooltip Tooltip { get; set; }
		private TreemapSeriesTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed. Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Set it to <code>0</code> disable.
		/// </summary>
		public double? TurboThreshold { get; set; }
		private double? TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// The type of series. Can be one of <code>area</code>, <code>areaspline</code>, <code>bar</code>, <code>column</code>, <code>line</code>, <code>pie</code>, <code>scatter</code> or <code>spline</code>. From version 2.3, <code>arearange</code>, <code>areasplinerange</code> and <code>columnrange</code> are supported with the highcharts-more.js component.
		/// </summary>
		public TreemapSeriesType Type { get; set; }
		private TreemapSeriesType Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple x axes, this number defines which xAxis the particular series is connected to. It refers to either the <a href="#xAxis.id">axis id</a> or the index of the axis in the xAxis array, with 0 being the first.
		/// </summary>
		public string XAxis { get; set; }
		private string XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple y axes, this number defines which yAxis the particular series is connected to. It refers to either the <a href="#yAxis.id">axis id</a> or the index of the axis in the yAxis array, with 0 being the first.
		/// </summary>
		public string YAxis { get; set; }
		private string YAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// Define the visual z index of the series.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the Axis on which the zones are applied.
		/// </summary>
		public string ZoneAxis { get; set; }
		private string ZoneAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array defining zones within a series. Zones can be applied to the X axis, Y axis or Z axis for bubbles, according to the <code>zoneAxis</code> option.</p><p>In <a href="http://www.highcharts.com/docs/chart-design-and-style/style-by-css">styled mode</a>, the color zones are styled with the <code>.highcharts-zone-{n}</code> class, or custom classed from the <code>className</code> option (<a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/color-zones/">view live demo</a>).</p>
		/// </summary>
		public List<TreemapSeriesZone> Zones { get; set; }
		private List<TreemapSeriesZone> Zones_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllowDrillToNode != AllowDrillToNode_DefaultValue) h.Add("allowDrillToNode", Highcharts.FirstCharacterToLower(AllowDrillToNode.ToString()));
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (AlternateStartingDirection != AlternateStartingDirection_DefaultValue) h.Add("alternateStartingDirection",AlternateStartingDirection);
			if (Animation.IsDirty()) h.Add("animation",Animation.ToJSON());
			if (AnimationLimit != AnimationLimit_DefaultValue) h.Add("animationLimit",AnimationLimit);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (GetExtremesFromAll != GetExtremesFromAll_DefaultValue) h.Add("getExtremesFromAll",GetExtremesFromAll);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (IgnoreHiddenPoint != IgnoreHiddenPoint_DefaultValue) h.Add("ignoreHiddenPoint",IgnoreHiddenPoint);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (InteractByLeaf != InteractByLeaf_DefaultValue) h.Add("interactByLeaf",InteractByLeaf);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (LayoutAlgorithm != LayoutAlgorithm_DefaultValue) h.Add("layoutAlgorithm", Highcharts.FirstCharacterToLower(LayoutAlgorithm.ToString()));
			if (LayoutStartingDirection != LayoutStartingDirection_DefaultValue) h.Add("layoutStartingDirection", Highcharts.FirstCharacterToLower(LayoutStartingDirection.ToString()));
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (LevelIsConstant != LevelIsConstant_DefaultValue) h.Add("levelIsConstant", Highcharts.FirstCharacterToLower(LevelIsConstant.ToString()));
			if (Levels != Levels_DefaultValue) h.Add("levels", HashifyList(Levels));
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (MaxPointWidth != MaxPointWidth_DefaultValue) h.Add("maxPointWidth",MaxPointWidth);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow.IsDirty()) h.Add("shadow",Shadow.ToHashtable());
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SortIndex != SortIndex_DefaultValue) h.Add("sortIndex",SortIndex);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (Type != Type_DefaultValue) h.Add("type", Highcharts.FirstCharacterToLower(Type.ToString()));
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (Zones != Zones_DefaultValue) h.Add("zones", HashifyList(Zones));
			

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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class TreemapSeries
	{
		public TreemapSeries()
		{
			AllowDrillToNode = AllowDrillToNode_DefaultValue = TreemapSeriesAllowDrillToNode.False;
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			AlternateStartingDirection = AlternateStartingDirection_DefaultValue = TreemapSeriesAlternateStartingDirection.False;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			BorderColor = BorderColor_DefaultValue = "#E0E0E0";
			BorderWidth = BorderWidth_DefaultValue = 1;
			Color = Color_DefaultValue = "null";
			ColorByPoint = ColorByPoint_DefaultValue = false;
			Colors = Colors_DefaultValue = new List<string>();
			CropThreshold = CropThreshold_DefaultValue = 300;
			Cursor = Cursor_DefaultValue = TreemapSeriesCursor.Null;
			Data = Data_DefaultValue = new TreemapSeriesData();
			DataLabels = DataLabels_DefaultValue = new TreemapSeriesDataLabels();
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			Events = Events_DefaultValue = new TreemapSeriesEvents();
			Id = Id_DefaultValue = "";
			Index = Index_DefaultValue = null;
			InteractByLeaf = InteractByLeaf_DefaultValue = null;
			Keys = Keys_DefaultValue = new List<string>();
			LayoutAlgorithm = LayoutAlgorithm_DefaultValue = TreemapSeriesLayoutAlgorithm.SliceAndDice;
			LayoutStartingDirection = LayoutStartingDirection_DefaultValue = TreemapSeriesLayoutStartingDirection.Vertical;
			LegendIndex = LegendIndex_DefaultValue = null;
			LevelIsConstant = LevelIsConstant_DefaultValue = TreemapSeriesLevelIsConstant.True;
			Levels = Levels_DefaultValue = new TreemapSeriesLevels();
			LinkedTo = LinkedTo_DefaultValue = "";
			Name = Name_DefaultValue = null;
			Point = Point_DefaultValue = new TreemapSeriesPoint();
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			ShowInLegend = ShowInLegend_DefaultValue = false;
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
			Zones = Zones_DefaultValue = new TreemapSeriesZones();
			
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
		public TreemapSeriesAlternateStartingDirection AlternateStartingDirection { get; set; }
		private TreemapSeriesAlternateStartingDirection AlternateStartingDirection_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the initial animation when a series is displayed. The animation can also be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see <a href="#chart.animation">chart.animation</a> and the animation parameter under the API methods.The following properties are supported:</p><dl>  <dt>duration</dt>  <dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>When using jQuery as the general framework, the easing can be set to <code>linear</code> or<code>swing</code>. More easing functions are available with the use of jQuery plug-ins, most notablythe jQuery UI suite. See <a href="http://api.jquery.com/animate/">the jQuery docs</a>. When using MooTools as the general framework, use the property name <code>transition</code> instead of <code>easing</code>.</dd></dl><p>Due to poor performance, animation is disabled in old IE browsers for column charts and polar charts.</p>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each tree map item.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the border surrounding each column or bar.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

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
		public TreemapSeriesData Data { get; set; }
		private TreemapSeriesData Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public TreemapSeriesDataLabels DataLabels { get; set; }
		private TreemapSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

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
		/// An id for the series. This can be used after render time to get a pointer to the series object through <code>chart.get()</code>.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

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
		/// A custom mapping of data point array positions to respective object properties. For example, is the first key is <code>name</code>, the first item in a series.data array is interpreted as point.name.
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
		/// The sequential index of the series in the legend.  <div class="demo">Try it:  <a href="http://jsfiddle.net/gh/get/jquery/1.7.1/highslide-software/highcharts.com/tree/master/samples/highcharts/series/legendindex/" target="_blank">Legend in opposite order</a> </div>.
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
		public TreemapSeriesLevels Levels { get; set; }
		private TreemapSeriesLevels Levels_DefaultValue { get; set; }
		 

		/// <summary>
		/// The <a href="#series.id">id</a> of another series to link to. Additionally, the value can be ":previous" to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the series as shown in the legend, tooltip etc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

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
		/// An array defining zones within a series.
		/// </summary>
		public TreemapSeriesZones Zones { get; set; }
		private TreemapSeriesZones Zones_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllowDrillToNode != AllowDrillToNode_DefaultValue) h.Add("allowDrillToNode",AllowDrillToNode.ToString().ToLower());
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (AlternateStartingDirection != AlternateStartingDirection_DefaultValue) h.Add("alternateStartingDirection",AlternateStartingDirection.ToString().ToLower());
			if (Animation.IsDirty()) h.Add("animation",Animation.ToJSON());
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor.ToString().ToLower());
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (InteractByLeaf != InteractByLeaf_DefaultValue) h.Add("interactByLeaf",InteractByLeaf);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (LayoutAlgorithm != LayoutAlgorithm_DefaultValue) h.Add("layoutAlgorithm",LayoutAlgorithm.ToString().ToLower());
			if (LayoutStartingDirection != LayoutStartingDirection_DefaultValue) h.Add("layoutStartingDirection",LayoutStartingDirection.ToString().ToLower());
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (LevelIsConstant != LevelIsConstant_DefaultValue) h.Add("levelIsConstant",LevelIsConstant.ToString().ToLower());
			if (Levels.IsDirty()) h.Add("levels",Levels.ToHashtable());
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (Type != Type_DefaultValue) h.Add("type",Type.ToString().ToLower());
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (Zones.IsDirty()) h.Add("zones",Zones.ToHashtable());
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}
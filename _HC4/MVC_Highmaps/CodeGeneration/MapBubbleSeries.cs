using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Maps
{
	public partial class MapBubbleSeries  : Series
	{
		public MapBubbleSeries()
		{
			AllAreas = AllAreas_DefaultValue = true;
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			AnimationLimit = AnimationLimit_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = "silver";
			BorderWidth = BorderWidth_DefaultValue = 1;
			Color = Color_DefaultValue = "";
			Cursor = Cursor_DefaultValue = MapBubbleSeriesCursor.Null;
			Data = Data_DefaultValue = new List<MapBubbleSeriesData>();
			DataLabels = DataLabels_DefaultValue = new MapBubbleSeriesDataLabels();
			DisplayNegative = DisplayNegative_DefaultValue = true;
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			Events = Events_DefaultValue = new MapBubbleSeriesEvents();
			Id = Id_DefaultValue = "";
			Index = Index_DefaultValue = null;
			JoinBy = JoinBy_DefaultValue = null;
			LegendIndex = LegendIndex_DefaultValue = null;
			MapData = MapData_DefaultValue = new List<object>();
			MaxSize = MaxSize_DefaultValue = "20%";
			MinSize = MinSize_DefaultValue = "8";
			Name = Name_DefaultValue = null;
			NegativeColor = NegativeColor_DefaultValue = "null";
			Point = Point_DefaultValue = new MapBubbleSeriesPoint();
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			ShowInLegend = ShowInLegend_DefaultValue = true;
			SizeBy = SizeBy_DefaultValue = MapBubbleSeriesSizeBy.Area;
			SizeByAbsoluteValue = SizeByAbsoluteValue_DefaultValue = false;
			States = States_DefaultValue = new MapBubbleSeriesStates();
			StickyTracking = StickyTracking_DefaultValue = false;
			Tooltip = Tooltip_DefaultValue = new MapBubbleSeriesTooltip();
			Type = Type_DefaultValue = MapBubbleSeriesType.Null;
			Visible = Visible_DefaultValue = true;
			ZIndex = ZIndex_DefaultValue = null;
			ZMax = ZMax_DefaultValue = null;
			ZMin = ZMin_DefaultValue = null;
			ZThreshold = ZThreshold_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// Whether all areas of the map defined in <code>mapData</code> should be rendered. If <code>true</code>, areas which don't correspond to a data point, are rendered as <code>null</code> points. If <code>false</code>, those areas are skipped.
		/// </summary>
		public bool? AllAreas { get; set; }
		private bool? AllAreas_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow this series' points to be selected by clicking on the shapes. Selected points can be read through the <a href="#Chart.getSelectedPoints()">Chart.getSelectedPoints()</a> method.
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the initial animation when a series is displayed. The animation can also be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see <a href="#chart.animation">chart.animation</a> and the animation parameter under the API methods.The following properties are supported:</p><dl>  <dt>duration</dt>  <dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>A string reference to an easing function set on the <code>Math</code> object. See <a href="http://jsfiddle.net/gh/get/jquery/1.7.2/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-animation-easing/">the easing demo</a>.</dd></dl><p>Due to poor performance, animation is disabled in old IE browsers for map series, but enabled on mapbubble series.</p>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// For some series, there is a limit that shuts down initial animation by default when the total number of points in the chart is too high. For example, for a column chart and its derivatives, animation doesn't run if there is more than 250 points totally. To disable this cap, set <code>animationLimit</code> to <code>Infinity</code>.
		/// </summary>
		public double? AnimationLimit { get; set; }
		private double? AnimationLimit_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color of the map areas.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width of each map area.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color of the series. This color affects both the fill and the stroke of the bubble. For enhanced control, use <code>marker</code> options.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.
		/// </summary>
		public MapBubbleSeriesCursor Cursor { get; set; }
		private MapBubbleSeriesCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the <code>mapbubble</code> series type, points can be given in the following ways: <ol> <li>An array of numerical values. In this case, the numerical values will  be interpreted as <code>z</code> options.  Example:<pre>data: [0, 5, 3, 5]</pre> </li> <li><p>An array of objects with named values. The objects are point configuration objects as seen below. If the total number of data points exceeds the series' <a href='#series<mapbubble>.turboThreshold'>turboThreshold</a>, this option is not available.</p><pre>data: [{    z: 9,    name: "Point2",    color: "#00FF00"}, {    z: 10,    name: "Point1",    color: "#FF00FF"}]</pre></li> </ol>
		/// </summary>
		public List<MapBubbleSeriesData> Data { get; set; }
		private List<MapBubbleSeriesData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public MapBubbleSeriesDataLabels DataLabels { get; set; }
		private MapBubbleSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display negative sized bubbles. The threshold is given by the <a href="#plotOptions.bubble.zThreshold">zThreshold</a> option, and negative bubbles can be visualized by setting <a href="#plotOptions.bubble.negativeColor">negativeColor</a>.
		/// </summary>
		public bool? DisplayNegative { get; set; }
		private bool? DisplayNegative_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public MapBubbleSeriesEvents Events { get; set; }
		private MapBubbleSeriesEvents Events_DefaultValue { get; set; }
		 

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
		/// <p>What property to join the <code>mapData</code> to the value data. For example, if joinBy is "code", the mapData items with a specific code is merged into the data with the same code. For maps loaded from GeoJSON, the keys may be held in each point's <code>properties</code> object.</p><p>The joinBy option can also be an array of two values, where the first points to a key in the <code>mapData</code>, and the second points to another key in the <code>data</code>.</p><p>When joinBy is <code>null</code>, the map  items are joined by their position in the array, which performs much better in maps with many data points. This is the recommended option if you are printing more than a thousand data points and have a backend that can preprocess the data into a parallel array of the mapData.</p>
		/// </summary>
		public List<String> JoinBy { get; set; }
		private List<String> JoinBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// The sequential index of the series in the legend.
		/// </summary>
		public double? LegendIndex { get; set; }
		private double? LegendIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of objects containing a <code>path</code> definition and optionally a code or property to join in the data as per the <code>joinBy</code> option. 
		/// </summary>
		public List<object> MapData { get; set; }
		private List<object> MapData_DefaultValue { get; set; }
		 

		/// <summary>
		/// Maximum bubble size. Bubbles will automatically size between the <code>minSize</code> and <code>maxSize</code> to reflect the <code>z</code> value of each bubble. Can be either pixels (when no unit is given), or a percentage of the smallest one of the plot width and height. 
		/// </summary>
		public string MaxSize { get; set; }
		private string MaxSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Minimum bubble size. Bubbles will automatically size between the <code>minSize</code> and <code>maxSize</code> to reflect the <code>z</code> value of each bubble. Can be either pixels (when no unit is given), or a percentage of the smallest one of the plot width and height. 
		/// </summary>
		public string MinSize { get; set; }
		private string MinSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the series as shown in the legend, tooltip etc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a point's Z value is below the <a href="#plotOptions.bubble.zThreshold">zThreshold</a> setting, this color is used.
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point
		/// </summary>
		public MapBubbleSeriesPoint Point { get; set; }
		private MapBubbleSeriesPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If <code>showCheckbox</code> is true, the checkbox next to the series name will be checked for a selected series.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the shapes. The shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// If true, and the series has a unique legend item, a checkbox is displayed next to the legend item to allow selecting the series. The state of the checkbox is determined by the <code>selected</code> option. Note that if a colorAxis is defined, the color axis is represented in the legend, not the series.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		private bool? ShowCheckbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in the legend. Note that if a colorAxis is defined, the color axis is represented in the legend, not the series.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the bubble's value should be represented by the area or the width of the bubble. The default, <code>area</code>, corresponds best to the human perception of the size of each bubble. 
		/// </summary>
		public MapBubbleSeriesSizeBy SizeBy { get; set; }
		private MapBubbleSeriesSizeBy SizeBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this is true, the absolute value of z determines the size of the bubble. This means that with the default <code>zThreshold</code> of 0, a bubble of value -1 will have the same size as a bubble of value 1, while a bubble of value 0 will have a smaller size according to <code>minSize</code>.
		/// </summary>
		public bool? SizeByAbsoluteValue { get; set; }
		private bool? SizeByAbsoluteValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public MapBubbleSeriesStates States { get; set; }
		private MapBubbleSeriesStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When <code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the  tooltip will be hidden when moving the mouse between series. 
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level.
		/// </summary>
		public MapBubbleSeriesTooltip Tooltip { get; set; }
		private MapBubbleSeriesTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The type of series. Can be one of <code>area</code>, <code>areaspline</code>, <code>bar</code>, <code>column</code>, <code>line</code>, <code>pie</code>, <code>scatter</code> or <code>spline</code>. From version 2.3, <code>arearange</code>, <code>areasplinerange</code> and <code>columnrange</code> are supported with the highcharts-more.js component.
		/// </summary>
		public MapBubbleSeriesType Type { get; set; }
		private MapBubbleSeriesType Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// Define the z index of the series.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum for the Z value range. Defaults to the highest Z value in the data.
		/// </summary>
		public double? ZMax { get; set; }
		private double? ZMax_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum for the Z value range. Defaults to the lowest Z value in the data.
		/// </summary>
		public double? ZMin { get; set; }
		private double? ZMin_DefaultValue { get; set; }
		 

		/// <summary>
		/// When <a href="#plotOptions.bubble.displayNegative">displayNegative</a> is <code>false</code>, bubbles with lower Z values are skipped. When <code>displayNegative</code> is <code>true</code> and a <a href="#plotOptions.bubble.negativeColor">negativeColor</a> is given, points with lower Z is colored.
		/// </summary>
		public double? ZThreshold { get; set; }
		private double? ZThreshold_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllAreas != AllAreas_DefaultValue) h.Add("allAreas",AllAreas);
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (Animation.IsDirty()) h.Add("animation",Animation.ToJSON());
			if (AnimationLimit != AnimationLimit_DefaultValue) h.Add("animationLimit",AnimationLimit);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highmaps.FirstCharacterToLower(Cursor.ToString()));
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (DisplayNegative != DisplayNegative_DefaultValue) h.Add("displayNegative",DisplayNegative);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (JoinBy != JoinBy_DefaultValue) h.Add("joinBy",JoinBy);
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (MapData != MapData_DefaultValue) h.Add("mapData",MapData);
			if (MaxSize != MaxSize_DefaultValue) h.Add("maxSize",MaxSize);
			if (MinSize != MinSize_DefaultValue) h.Add("minSize",MinSize);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SizeBy != SizeBy_DefaultValue) h.Add("sizeBy", Highmaps.FirstCharacterToLower(SizeBy.ToString()));
			if (SizeByAbsoluteValue != SizeByAbsoluteValue_DefaultValue) h.Add("sizeByAbsoluteValue",SizeByAbsoluteValue);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (Type != Type_DefaultValue) h.Add("type", Highmaps.FirstCharacterToLower(Type.ToString()));
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (ZMax != ZMax_DefaultValue) h.Add("zMax",ZMax);
			if (ZMin != ZMin_DefaultValue) h.Add("zMin",ZMin);
			if (ZThreshold != ZThreshold_DefaultValue) h.Add("zThreshold",ZThreshold);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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
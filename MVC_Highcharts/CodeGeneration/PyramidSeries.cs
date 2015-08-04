using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highcharts.Web.Mvc
{
	public partial class PyramidSeries  : Series
	{
		public PyramidSeries()
		{
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			BorderColor = BorderColor_DefaultValue = "#FFFFFF";
			BorderWidth = BorderWidth_DefaultValue = 1;
			Center = Center_DefaultValue = new string[] { null, null };
			Colors = Colors_DefaultValue = new List<string>();
			Cursor = Cursor_DefaultValue = PyramidSeriesCursor.Null;
			Data = Data_DefaultValue = new List<PyramidSeriesData>();
			DataLabels = DataLabels_DefaultValue = new PyramidSeriesDataLabels();
			Depth = Depth_DefaultValue = 0;
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			Events = Events_DefaultValue = new PyramidSeriesEvents();
			Height = Height_DefaultValue = null;
			Id = Id_DefaultValue = "";
			Index = Index_DefaultValue = null;
			Keys = Keys_DefaultValue = new List<string>();
			LegendIndex = LegendIndex_DefaultValue = null;
			LinkedTo = LinkedTo_DefaultValue = "";
			MinSize = MinSize_DefaultValue = 80;
			Name = Name_DefaultValue = null;
			Point = Point_DefaultValue = new PyramidSeriesPoint();
			Reversed = Reversed_DefaultValue = true;
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShowInLegend = ShowInLegend_DefaultValue = false;
			SlicedOffset = SlicedOffset_DefaultValue = 10;
			States = States_DefaultValue = new PyramidSeriesStates();
			StickyTracking = StickyTracking_DefaultValue = false;
			Tooltip = Tooltip_DefaultValue = new PyramidSeriesTooltip();
			Type = Type_DefaultValue = PyramidSeriesType.Null;
			Visible = Visible_DefaultValue = true;
			Width = Width_DefaultValue = "90%";
			ZIndex = ZIndex_DefaultValue = null;
			ZoneAxis = ZoneAxis_DefaultValue = "y";
			Zones = Zones_DefaultValue = new PyramidSeriesZones();
			
		}	
		

		/// <summary>
		/// Allow this series' points to be selected by clicking on the markers, bars or pie slices.
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each slice.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the border surrounding each slice.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The center of the series. By default, it is centered in the middle of the plot area, so it fills the plot area height.
		/// </summary>
		public new string[] Center { get; set; }
		private new string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to use instead of the global <a href="#colors">colors</a>.
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.
		/// </summary>
		public PyramidSeriesCursor Cursor { get; set; }
		private PyramidSeriesCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the <code>pyramid</code> series type, points can be given in the following ways: <ol> <li>An array of numerical values. In this case, the numerical values will  be interpreted as <code>y</code> options.  Example:<pre>data: [0, 5, 3, 5]</pre> </li> <li><p>An array of objects with named values. The objects are point configuration objects as seen below. If the total number of data points exceeds the series' <a href='#series<pyramid>.turboThreshold'>turboThreshold</a>, this option is not available.</p><pre>data: [{    y: 6,    name: "Point2",    color: "#00FF00"}, {    y: 7,    name: "Point1",    color: "#FF00FF"}]</pre></li> </ol>
		/// </summary>
		public List<PyramidSeriesData> Data { get; set; }
		private List<PyramidSeriesData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PyramidSeriesDataLabels DataLabels { get; set; }
		private PyramidSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// The thickness of a 3D pie. Requires <code>highcharts-3d.js</code>
		/// </summary>
		public double? Depth { get; set; }
		private double? Depth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PyramidSeriesEvents Events { get; set; }
		private PyramidSeriesEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the funnel or pyramid. If it is a number it defines the pixel height, if it is a percentage string it is the percentage of the plot area height.
		/// </summary>
		public string Height { get; set; }
		private string Height_DefaultValue { get; set; }
		 

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
		/// A custom mapping of data point array positions to respective object properties. For example, is the first key is <code>name</code>, the first item in a series.data array is interpreted as point.name.
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

		/// <summary>
		/// The sequential index of the series in the legend.  <div class="demo">Try it:  <a href="http://jsfiddle.net/gh/get/jquery/1.7.1/highslide-software/highcharts.com/tree/master/samples/highcharts/series/legendindex/" target="_blank">Legend in opposite order</a> </div>.
		/// </summary>
		public double? LegendIndex { get; set; }
		private double? LegendIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The <a href="#series.id">id</a> of another series to link to. Additionally, the value can be ":previous" to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum size for a pie in response to auto margins. The pie will try to shrink to make room for data labels in side the plot area, but only to this size.
		/// </summary>
		public double? MinSize { get; set; }
		private double? MinSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the series as shown in the legend, tooltip etc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point
		/// </summary>
		public PyramidSeriesPoint Point { get; set; }
		private PyramidSeriesPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pyramid is reversed by default, as opposed to the funnel, which shares the layout engine, and is not reversed.
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

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
		/// Whether to display this particular series or series type in the legend. Since 2.1, pies are not shown in the legend by default.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// If a point is sliced, moved out from the center, how many pixels should  it be moved?.
		/// </summary>
		public double? SlicedOffset { get; set; }
		private double? SlicedOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PyramidSeriesStates States { get; set; }
		private PyramidSeriesStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When <code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the  tooltip will be hidden when moving the mouse between series.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level.
		/// </summary>
		public PyramidSeriesTooltip Tooltip { get; set; }
		private PyramidSeriesTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The type of series. Can be one of <code>area</code>, <code>areaspline</code>, <code>bar</code>, <code>column</code>, <code>line</code>, <code>pie</code>, <code>scatter</code> or <code>spline</code>. From version 2.3, <code>arearange</code>, <code>areasplinerange</code> and <code>columnrange</code> are supported with the highcharts-more.js component.
		/// </summary>
		public PyramidSeriesType Type { get; set; }
		private PyramidSeriesType Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the funnel compared to the width of the plot area, or the pixel width if it is a number.
		/// </summary>
		public string Width { get; set; }
		private string Width_DefaultValue { get; set; }
		 

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
		public PyramidSeriesZones Zones { get; set; }
		private PyramidSeriesZones Zones_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Depth != Depth_DefaultValue) h.Add("depth",Depth);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (MinSize != MinSize_DefaultValue) h.Add("minSize",MinSize);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SlicedOffset != SlicedOffset_DefaultValue) h.Add("slicedOffset",SlicedOffset);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (Type != Type_DefaultValue) h.Add("type", Highcharts.FirstCharacterToLower(Type.ToString()));
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (Zones.IsDirty()) h.Add("zones",Zones.ToHashtable());
			

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
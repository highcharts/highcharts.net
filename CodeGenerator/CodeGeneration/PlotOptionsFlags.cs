using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highstock.Web.Mvc
{
	public partial class PlotOptionsFlags  : BaseObject
	{
		public PlotOptionsFlags()
		{
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			Color = Color_DefaultValue = "";
			Colors = Colors_DefaultValue = new List<string>();
			CropThreshold = CropThreshold_DefaultValue = 50;
			Cursor = Cursor_DefaultValue = PlotOptionsFlagsCursor.Null;
			DataLabels = DataLabels_DefaultValue = new PlotOptionsFlagsDataLabels();
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			Events = Events_DefaultValue = new PlotOptionsFlagsEvents();
			Keys = Keys_DefaultValue = new List<string>();
			LegendIndex = LegendIndex_DefaultValue = 0;
			LineColor = LineColor_DefaultValue = "'black'";
			LineWidth = LineWidth_DefaultValue = 1;
			LinkedTo = LinkedTo_DefaultValue = "";
			OnSeries = OnSeries_DefaultValue = "undefined";
			Point = Point_DefaultValue = new PlotOptionsFlagsPoint();
			PointIntervalUnit = PointIntervalUnit_DefaultValue = PlotOptionsFlagsPointIntervalUnit.Null;
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			Shape = Shape_DefaultValue = PlotOptionsFlagsShape.Flag;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			ShowInLegend = ShowInLegend_DefaultValue = true;
			StackDistance = StackDistance_DefaultValue = 12;
			States = States_DefaultValue = new PlotOptionsFlagsStates();
			StickyTracking = StickyTracking_DefaultValue = true;
			Style = Style_DefaultValue = new NameValueCollection();
			Title = Title_DefaultValue = "A";
			Tooltip = Tooltip_DefaultValue = new PlotOptionsFlagsTooltip();
			UseHTML = UseHTML_DefaultValue = false;
			Visible = Visible_DefaultValue = true;
			Y = Y_DefaultValue = -30;
			ZoneAxis = ZoneAxis_DefaultValue = "y";
			Zones = Zones_DefaultValue = new PlotOptionsFlagsZones();
			
		}	
		

		/// <summary>
		/// Allow this series' points to be selected by clicking on the markers or bars.
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color of the series. In line type series it applies to the line and the point markers unless otherwise specified. In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the  <code>options.colors</code> array.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to apply instead of the global <a href="#colors">colors</a> when <a href="#plotOptions.column.colorByPoint">colorByPoint</a> is true.
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the series contains less points than the crop threshold, all points are drawn,  event if the points fall outside the visible plot area at the current zoom. The advantage of drawing all points (including markers and columns), is that animation is performed on updates. On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area. The advantage of cropping away invisible points is to increase performance on large series.  .
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.
		/// </summary>
		public PlotOptionsFlagsCursor Cursor { get; set; }
		private PlotOptionsFlagsCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsFlagsDataLabels DataLabels { get; set; }
		private PlotOptionsFlagsDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. When using shared tooltips  (default in stock charts), mouse tracking is not required. For large datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsFlagsEvents Events { get; set; }
		private PlotOptionsFlagsEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data point array. This makes it convenient to work with unstructured data arrays from different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

		/// <summary>
		/// The sequential index of the series within the legend.
		/// </summary>
		public double? LegendIndex { get; set; }
		private double? LegendIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the line/border of the flag. Defaults to <code>"black"</code>.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the candlestick line/border. Defaults to <code>1</code>.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The <a href="#series.id">id</a> of another series to link to. Additionally, the value can be ":previous" to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The id of the series that the flags should be drawn on. If no id is given, the flags are drawn on the x axis. Defaults to <code>undefined</code>.
		/// </summary>
		public string OnSeries { get; set; }
		private string OnSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point
		/// </summary>
		public PlotOptionsFlagsPoint Point { get; set; }
		private PlotOptionsFlagsPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// On datetime series, this allows for setting the <a href="plotOptions.series.pointInterval">pointInterval</a> to the two irregular time units, <code>month</code> and <code>year</code>. Combine it with <code>pointInterval</code> to draw quarters, 6 months, 10 years etc.
		/// </summary>
		public PlotOptionsFlagsPointIntervalUnit PointIntervalUnit { get; set; }
		private PlotOptionsFlagsPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If <code>showCheckbox</code> is true, the checkbox next to the series name in the legend will be checked for a selected series.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 1.1.7 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shape of the marker. Can be one of "flag", "circlepin", "squarepin", or an image on the format <code>url(/path-to-image.jpg)</code>. Individual shapes can also be set for each point.
		/// </summary>
		public PlotOptionsFlagsShape Shape { get; set; }
		private PlotOptionsFlagsShape Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allow selecting the series. The state of the checkbox is determined by the <code>selected</code> option.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		private bool? ShowCheckbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in the legend. The default value is <code>true</code> for standalone series, <code>false</code> for linked series.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// When multiple flags in the same series fall on the same value, this number determines the vertical offset between them.
		/// </summary>
		public double? StackDistance { get; set; }
		private double? StackDistance_DefaultValue { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsFlagsStates States { get; set; }
		private PlotOptionsFlagsStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip when not shared. When <code>stickyTracking</code> is false, the  tooltip will be hidden when moving the mouse between series. Defaults to true for line and area type series, but to false for columns, candlesticks etc.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text styles of the flag. Defaults to:<pre>style: {fontSize: '11px',fontWeight: 'bold',textAlign: 'center'}</pre>
		/// </summary>
		public NameValueCollection Style { get; set; }
		private NameValueCollection Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text to display on each flag. This can be defined on series level, or  individually for each point. Defaults to <code>"A"</code>.
		/// </summary>
		public string Title { get; set; }
		private string Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific tooltip options for flag series. Flag series tooltips are different from most other types in that a flag doesn't have a data value, so the tooltip rather displays the <code>text</code> option for each point.
		/// </summary>
		public PlotOptionsFlagsTooltip Tooltip { get; set; }
		private PlotOptionsFlagsTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to use HTML to render the flag texts. Using HTML allows for advanced formatting, images and reliable bi-directional text rendering. Note that exported images won't respect the HTML, and that HTML won't respect Z-index settings.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position of the top left corner of the flag relative to either the series (if onSeries is defined), or the x axis. Defaults to <code>-30</code>.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the Axis on which the zones are applied.
		/// </summary>
		public string ZoneAxis { get; set; }
		private string ZoneAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining zones within a series.
		/// </summary>
		public PlotOptionsFlagsZones Zones { get; set; }
		private PlotOptionsFlagsZones Zones_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highstock.FirstCharacterToLower(Cursor.ToString()));
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (OnSeries != OnSeries_DefaultValue) h.Add("onSeries",OnSeries);
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (PointIntervalUnit != PointIntervalUnit_DefaultValue) h.Add("pointIntervalUnit", Highstock.FirstCharacterToLower(PointIntervalUnit.ToString()));
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (Shape != Shape_DefaultValue) h.Add("shape", Highstock.FirstCharacterToLower(Shape.ToString()));
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (StackDistance != StackDistance_DefaultValue) h.Add("stackDistance",StackDistance);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Title != Title_DefaultValue) h.Add("title",Title);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (Y != Y_DefaultValue) h.Add("y",Y);
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
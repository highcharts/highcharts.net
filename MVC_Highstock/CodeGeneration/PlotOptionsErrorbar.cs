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
	public partial class PlotOptionsErrorbar  : BaseObject
	{
		public PlotOptionsErrorbar()
		{
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			Color = Color_DefaultValue = "#000000";
			ColorByPoint = ColorByPoint_DefaultValue = false;
			Colors = Colors_DefaultValue = new List<string>();
			Cursor = Cursor_DefaultValue = PlotOptionsErrorbarCursor.Null;
			Depth = Depth_DefaultValue = 25;
			EdgeColor = EdgeColor_DefaultValue = "";
			EdgeWidth = EdgeWidth_DefaultValue = 1;
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			Events = Events_DefaultValue = new PlotOptionsErrorbarEvents();
			GroupZPadding = GroupZPadding_DefaultValue = 1;
			LineWidth = LineWidth_DefaultValue = 1;
			LinkedTo = LinkedTo_DefaultValue = ":previous";
			NegativeColor = NegativeColor_DefaultValue = "null";
			Point = Point_DefaultValue = new PlotOptionsErrorbarPoint();
			PointInterval = PointInterval_DefaultValue = 1;
			PointPadding = PointPadding_DefaultValue = 0.1;
			PointPlacement = PointPlacement_DefaultValue = new PointPlacement();
			PointRange = PointRange_DefaultValue = null;
			PointStart = PointStart_DefaultValue = 0;
			PointWidth = PointWidth_DefaultValue = null;
			Selected = Selected_DefaultValue = false;
			States = States_DefaultValue = new PlotOptionsErrorbarStates();
			StemColor = StemColor_DefaultValue = "null";
			StemDashStyle = StemDashStyle_DefaultValue = PlotOptionsErrorbarStemDashStyle.Solid;
			StemWidth = StemWidth_DefaultValue = null;
			StickyTracking = StickyTracking_DefaultValue = true;
			Tooltip = Tooltip_DefaultValue = new PlotOptionsErrorbarTooltip();
			TurboThreshold = TurboThreshold_DefaultValue = 1000;
			Visible = Visible_DefaultValue = true;
			WhiskerColor = WhiskerColor_DefaultValue = "null";
			WhiskerLength = WhiskerLength_DefaultValue = "50%";
			WhiskerWidth = WhiskerWidth_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Allow this series' points to be selected by clicking on the markers, bars or pie slices.
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color of the bars. This can be overridden by <a href="#plotOptions.errorbar.stemColor">stemColor</a> and <a href="#plotOptions.errorbar.whiskerColor">whiskerColor</a> individually. 
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
		/// You can set the cursor to "pointer" if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.
		/// </summary>
		public PlotOptionsErrorbarCursor Cursor { get; set; }
		private PlotOptionsErrorbarCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Depth of the columns in a 3D column chart. Requires <code>highcharts-3d.js</code>.
		/// </summary>
		public double? Depth { get; set; }
		private double? Depth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 3D columns only. The color of the edges. Similar to <code>borderColor</code>, except it defaults to the same color as the column.
		/// </summary>
		public string EdgeColor { get; set; }
		private string EdgeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 3D columns only. The width of the colored edges.
		/// </summary>
		public double? EdgeWidth { get; set; }
		private double? EdgeWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsErrorbarEvents Events { get; set; }
		private PlotOptionsErrorbarEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// The spacing between columns on the Z Axis in a 3D chart. Requires <code>highcharts-3d.js</code>.
		/// </summary>
		public double? GroupZPadding { get; set; }
		private double? GroupZPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the line surrounding the box. If any of <a href="#plotOptions.boxplot.stemWidth">stemWidth</a>, <a href="#plotOptions.boxplot.medianWidth">medianWidth</a> or <a href="#plotOptions.boxplot.whiskerWidth">whiskerWidth</a> are <code>null</code>, the lineWidth also applies to these lines.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The parent series of the error bar. The default value links it to the previous series. Otherwise, use the id of the parent series.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color for the parts of the graph or points that are below the <a href="#plotOptions.series.threshold">threshold</a>.
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point
		/// </summary>
		public PlotOptionsErrorbarPoint Point { get; set; }
		private PlotOptionsErrorbarPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If no x values are given for the points in a series, pointInterval defines the interval of the x values. For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.</p>
		/// </summary>
		public double? PointInterval { get; set; }
		private double? PointInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding between each column or bar, in x axis units.
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Possible values: null, "on", "between".</p><p>In a column chart, when pointPlacement is "on", the point will not create any padding of the X axis. In a polar column chart this means that the first column points directly north. If the pointPlacement is "between", the columns will be laid out between ticks. This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.</p><p>Since Highcharts 3.0.2, the point placement can also be numeric, where 0 is on the axis value, -0.5 is between this value and the previous, and 0.5 is between this value and the next. Unlike the textual options, numeric point placement options won't affect axis padding.</p><p>Defaults to <code>null</code> in cartesian charts, <code>"between"</code> in polar charts.
		/// </summary>
		public PointPlacement PointPlacement { get; set; }
		private PointPlacement PointPlacement_DefaultValue { get; set; }
		 

		/// <summary>
		/// The X axis range that each point is valid for. This determines the width of the column. On a categorized axis, the range will be 1 by default (one category unit). On linear and datetime axes, the range will be computed as the distance between the two closest data points.
		/// </summary>
		public double? PointRange { get; set; }
		private double? PointRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// If no x values are given for the points in a series, pointStart defines on what value to start. For example, if a series contains one yearly value starting from 1945, set pointStart to 1945.
		/// </summary>
		public double? PointStart { get; set; }
		private double? PointStart_DefaultValue { get; set; }
		 

		/// <summary>
		/// A pixel value specifying a fixed width for each column or bar. When <code>null</code>, the width is calculated from the <code>pointPadding</code> and <code>groupPadding</code>.
		/// </summary>
		public double? PointWidth { get; set; }
		private double? PointWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If <code>showCheckbox</code> is true, the checkbox next to the series name will be checked for a selected series.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsErrorbarStates States { get; set; }
		private PlotOptionsErrorbarStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the stem, the vertical line extending from the box to the whiskers. If <code>null</code>, the series color is used.
		/// </summary>
		public string StemColor { get; set; }
		private string StemColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash style of the stem, the vertical line extending from the box to the whiskers.
		/// </summary>
		public PlotOptionsErrorbarStemDashStyle StemDashStyle { get; set; }
		private PlotOptionsErrorbarStemDashStyle StemDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the stem, the vertical line extending from the box to the whiskers. If <code>null</code>, the width is inherited from the <a href="#plotOptions.boxplot.lineWidth">lineWidth</a> option.
		/// </summary>
		public double? StemWidth { get; set; }
		private double? StemWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When <code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the  tooltip will be hidden when moving the mouse between series. Defaults to true for line and area type series, but to false for columns, pies etc.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level.
		/// </summary>
		public PlotOptionsErrorbarTooltip Tooltip { get; set; }
		private PlotOptionsErrorbarTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed. Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Set it to <code>0</code> disable.
		/// </summary>
		public double? TurboThreshold { get; set; }
		private double? TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the whiskers, the horizontal lines marking low and high values. When <code>null</code>, the general series color is used.
		/// </summary>
		public string WhiskerColor { get; set; }
		private string WhiskerColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the whiskers, the horizontal lines marking low and high values. It can be a numerical pixel value, or a percentage value of the box width. Set <code>0</code> to disable whiskers.
		/// </summary>
		public string WhiskerLength { get; set; }
		private string WhiskerLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line width of the whiskers, the horizontal lines marking low and high values. When <code>null</code>, the general <a href="#plotOptions.errorbar.lineWidth">lineWidth</a> applies.
		/// </summary>
		public double? WhiskerWidth { get; set; }
		private double? WhiskerWidth_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highstock.FirstCharacterToLower(Cursor.ToString()));
			if (Depth != Depth_DefaultValue) h.Add("depth",Depth);
			if (EdgeColor != EdgeColor_DefaultValue) h.Add("edgeColor",EdgeColor);
			if (EdgeWidth != EdgeWidth_DefaultValue) h.Add("edgeWidth",EdgeWidth);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (GroupZPadding != GroupZPadding_DefaultValue) h.Add("groupZPadding",GroupZPadding);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (PointInterval != PointInterval_DefaultValue) h.Add("pointInterval",PointInterval);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (PointPlacement.IsDirty()) h.Add("pointPlacement",PointPlacement.ToJSON());
			if (PointRange != PointRange_DefaultValue) h.Add("pointRange",PointRange);
			if (PointStart != PointStart_DefaultValue) h.Add("pointStart",PointStart);
			if (PointWidth != PointWidth_DefaultValue) h.Add("pointWidth",PointWidth);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StemColor != StemColor_DefaultValue) h.Add("stemColor",StemColor);
			if (StemDashStyle != StemDashStyle_DefaultValue) h.Add("stemDashStyle", Highstock.FirstCharacterToLower(StemDashStyle.ToString()));
			if (StemWidth != StemWidth_DefaultValue) h.Add("stemWidth",StemWidth);
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (WhiskerColor != WhiskerColor_DefaultValue) h.Add("whiskerColor",WhiskerColor);
			if (WhiskerLength != WhiskerLength_DefaultValue) h.Add("whiskerLength",WhiskerLength);
			if (WhiskerWidth != WhiskerWidth_DefaultValue) h.Add("whiskerWidth",WhiskerWidth);
			

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
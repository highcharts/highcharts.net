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
	public partial class PlotOptionsPie  : BaseObject
	{
		public PlotOptionsPie()
		{
			Center = Center_DefaultValue = new string[] { "50%", "50%" };
			Clip = Clip_DefaultValue = False;
			IgnoreHiddenPoint = IgnoreHiddenPoint_DefaultValue = true;
			Size = Size_DefaultValue = null;
			ShowInLegend = ShowInLegend_DefaultValue = False;
			SlicedOffset = SlicedOffset_DefaultValue = 10;
			StickyTracking = StickyTracking_DefaultValue = False;
			Tooltip = Tooltip_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = "#ffffff";
			BorderWidth = BorderWidth_DefaultValue = 1;
			States = States_DefaultValue = null;
			Colors = Colors_DefaultValue = new List<string>();
			EndAngle = EndAngle_DefaultValue = null;
			InnerSize = InnerSize_DefaultValue = "0";
			MinSize = MinSize_DefaultValue = 80;
			StartAngle = StartAngle_DefaultValue = 0;
			Events = Events_DefaultValue = null;
			Point = Point_DefaultValue = null;
			Depth = Depth_DefaultValue = 0;
			Center = Center_DefaultValue = new string[] { "50%", "50%" };
			Clip = Clip_DefaultValue = False;
			DataLabels = DataLabels_DefaultValue = "";
			Distance = Distance_DefaultValue = 30;
			Enabled = Enabled_DefaultValue = True;
			Formatter = Formatter_DefaultValue = "";
			X = X_DefaultValue = 0;
			ConnectorColor = ConnectorColor_DefaultValue = "{point.color}";
			ConnectorPadding = ConnectorPadding_DefaultValue = 5;
			ConnectorWidth = ConnectorWidth_DefaultValue = 1;
			SoftConnector = SoftConnector_DefaultValue = null;
			IgnoreHiddenPoint = IgnoreHiddenPoint_DefaultValue = true;
			Size = Size_DefaultValue = "";
			ShowInLegend = ShowInLegend_DefaultValue = False;
			SlicedOffset = SlicedOffset_DefaultValue = 10;
			StickyTracking = StickyTracking_DefaultValue = False;
			Tooltip = Tooltip_DefaultValue = "";
			FollowPointer = FollowPointer_DefaultValue = True;
			BorderColor = BorderColor_DefaultValue = "#ffffff";
			BorderWidth = BorderWidth_DefaultValue = 1;
			States = States_DefaultValue = "";
			Hover = Hover_DefaultValue = "";
			Brightness = Brightness_DefaultValue = 0.1;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			Colors = Colors_DefaultValue = new List<string>();
			EndAngle = EndAngle_DefaultValue = null;
			InnerSize = InnerSize_DefaultValue = "0";
			MinSize = MinSize_DefaultValue = 80;
			StartAngle = StartAngle_DefaultValue = 0;
			Events = Events_DefaultValue = "";
			CheckboxClick = CheckboxClick_DefaultValue = "";
			LegendItemClick = LegendItemClick_DefaultValue = "";
			Point = Point_DefaultValue = "";
			Events = Events_DefaultValue = "";
			LegendItemClick = LegendItemClick_DefaultValue = "";
			Depth = Depth_DefaultValue = 0;
			Distance = Distance_DefaultValue = 30;
			Enabled = Enabled_DefaultValue = True;
			Formatter = Formatter_DefaultValue = "";
			X = X_DefaultValue = 0;
			ConnectorColor = ConnectorColor_DefaultValue = "{point.color}";
			ConnectorPadding = ConnectorPadding_DefaultValue = 5;
			ConnectorWidth = ConnectorWidth_DefaultValue = 1;
			SoftConnector = SoftConnector_DefaultValue = null;
			Brightness = Brightness_DefaultValue = 0.1;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			
		}	
		

		/// <summary>
		/// The center of the pie chart relative to the plot area. Can be percentagesor pixel values. The default behaviour (as of 3.0) is to centerthe pie so that all slices and data labels are within the plot area.As a consequence, the pie may actually jump around in a chart withdynamic values, as the data labels move. In that case, the centershould be explicitly set, for example to `["50%", "50%"]`.
		/// </summary>
		public string[] Center { get; set; }
		private string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieClip Clip { get; set; }
		private PlotOptionsPieClip Clip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Equivalent to [chart.ignoreHiddenSeries](#chart.ignoreHiddenSeries),this option tells whether the series shall be redrawn as if thehidden point were `null`.The default value changed from `false` to `true` with Highcharts3.0.
		/// </summary>
		public bool? IgnoreHiddenPoint { get; set; }
		private bool? IgnoreHiddenPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// The diameter of the pie relative to the plot area. Can be a percentageor pixel value. Pixel values are given as integers. The defaultbehaviour (as of 3.0) is to scale to the plot area and give roomfor data labels within the plot area. As a consequence, the sizeof the pie may vary when points are updated and data labels morearound. In that case it is best to set a fixed value, for example`"75%"`.
		/// </summary>
		public string Size { get; set; }
		private string Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in thelegend. Since 2.1, pies are not shown in the legend by default.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// If a point is sliced, moved out from the center, how many pixelsshould it be moved?.
		/// </summary>
		public double? SlicedOffset { get; set; }
		private double? SlicedOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` eventon a series isn't triggered until the mouse moves over another series,or out of the plot area. When false, the `mouseOut` event on aseries is triggered when the mouse leaves the area around the series'graph or markers. This also implies the tooltip. When `stickyTracking`is false and `tooltip.shared` is false, the tooltip will be hiddenwhen moving the mouse between series.
		/// </summary>
		public PlotOptionsPieStickyTracking StickyTracking { get; set; }
		private PlotOptionsPieStickyTracking StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieTooltip Tooltip { get; set; }
		private PlotOptionsPieTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each slice. When `null`, theborder takes the same color as the slice fill. This can be usedtogether with a `borderWidth` to fill drawing gaps created by antialiazingartefacts in borderless pies.In styled mode, the border stroke is given in the `.highcharts-point` class.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the border surrounding each slice.When setting the border width to 0, there may be small gaps betweenthe slices due to SVG antialiasing artefacts. To work around this,keep the border width at 0.5 or 1, but set the `borderColor` to`null` instead.In styled mode, the border stroke width is given in the `.highcharts-point` class.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieStates States { get; set; }
		private PlotOptionsPieStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to use insteadof the global [colors](#colors).
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// The end angle of the pie in degrees where 0 is top and 90 is right.Defaults to `startAngle` plus 360.
		/// </summary>
		public double? EndAngle { get; set; }
		private double? EndAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The size of the inner diameter for the pie. A size greater than 0renders a donut chart. Can be a percentage or pixel value. Percentagesare relative to the pie size. Pixel values are given as integers.Note: in Highcharts < 4.1.2, the percentage was relative to the plotarea, not the pie size.
		/// </summary>
		public string InnerSize { get; set; }
		private string InnerSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum size for a pie in response to auto margins. The pie willtry to shrink to make room for data labels in side the plot area, but only to this size.
		/// </summary>
		public double? MinSize { get; set; }
		private double? MinSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The start angle of the pie slices in degrees where 0 is top and 90right.
		/// </summary>
		public double? StartAngle { get; set; }
		private double? StartAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieEvents Events { get; set; }
		private PlotOptionsPieEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPiePoint Point { get; set; }
		private PlotOptionsPiePoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// The thickness of a 3D pie. Requires `highcharts-3d.js`
		/// </summary>
		public double? Depth { get; set; }
		private double? Depth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The center of the pie chart relative to the plot area. Can be percentagesor pixel values. The default behaviour (as of 3.0) is to centerthe pie so that all slices and data labels are within the plot area.As a consequence, the pie may actually jump around in a chart withdynamic values, as the data labels move. In that case, the centershould be explicitly set, for example to `["50%", "50%"]`.
		/// </summary>
		public string[] Center { get; set; }
		private string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieClip Clip { get; set; }
		private PlotOptionsPieClip Clip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieDataLabels DataLabels { get; set; }
		private PlotOptionsPieDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance of the data label from the pie's edge. Negative numbersput the data label on top of the pie slices. Connectors are onlyshown for data labels outside the pie.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the data labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieFormatter Formatter { get; set; }
		private PlotOptionsPieFormatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to render the connector as a soft arc or a line with sharpbreak.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the line connecting the data label to the pie slice.The default color is the same as the point's color.In styled mode, the connector stroke is given in the`.highcharts-data-label-connector` class.
		/// </summary>
		public string ConnectorColor { get; set; }
		private string ConnectorColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance from the data label to the connector.
		/// </summary>
		public double? ConnectorPadding { get; set; }
		private double? ConnectorPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the line connecting the data label to the pie slice.In styled mode, the connector stroke width is given in the`.highcharts-data-label-connector` class.
		/// </summary>
		public double? ConnectorWidth { get; set; }
		private double? ConnectorWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to render the connector as a soft arc or a line with sharpbreak.
		/// </summary>
		public double? SoftConnector { get; set; }
		private double? SoftConnector_DefaultValue { get; set; }
		 

		/// <summary>
		/// Equivalent to [chart.ignoreHiddenSeries](#chart.ignoreHiddenSeries),this option tells whether the series shall be redrawn as if thehidden point were `null`.The default value changed from `false` to `true` with Highcharts3.0.
		/// </summary>
		public bool? IgnoreHiddenPoint { get; set; }
		private bool? IgnoreHiddenPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// The diameter of the pie relative to the plot area. Can be a percentageor pixel value. Pixel values are given as integers. The defaultbehaviour (as of 3.0) is to scale to the plot area and give roomfor data labels within the plot area. As a consequence, the sizeof the pie may vary when points are updated and data labels morearound. In that case it is best to set a fixed value, for example`"75%"`.
		/// </summary>
		public string Size { get; set; }
		private string Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in thelegend. Since 2.1, pies are not shown in the legend by default.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// If a point is sliced, moved out from the center, how many pixelsshould it be moved?.
		/// </summary>
		public double? SlicedOffset { get; set; }
		private double? SlicedOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` eventon a series isn't triggered until the mouse moves over another series,or out of the plot area. When false, the `mouseOut` event on aseries is triggered when the mouse leaves the area around the series'graph or markers. This also implies the tooltip. When `stickyTracking`is false and `tooltip.shared` is false, the tooltip will be hiddenwhen moving the mouse between series.
		/// </summary>
		public PlotOptionsPieStickyTracking StickyTracking { get; set; }
		private PlotOptionsPieStickyTracking StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieTooltip Tooltip { get; set; }
		private PlotOptionsPieTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieFollowPointer FollowPointer { get; set; }
		private PlotOptionsPieFollowPointer FollowPointer_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each slice. When `null`, theborder takes the same color as the slice fill. This can be usedtogether with a `borderWidth` to fill drawing gaps created by antialiazingartefacts in borderless pies.In styled mode, the border stroke is given in the `.highcharts-point` class.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the border surrounding each slice.When setting the border width to 0, there may be small gaps betweenthe slices due to SVG antialiasing artefacts. To work around this,keep the border width at 0.5 or 1, but set the `borderColor` to`null` instead.In styled mode, the border stroke width is given in the `.highcharts-point` class.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieStates States { get; set; }
		private PlotOptionsPieStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieHover Hover { get; set; }
		private PlotOptionsPieHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// How much to brighten the point on interaction. Requires the maincolor to be defined in hex or rgb(a) format.In styled mode, the hover brightness is by default replacedby a fill-opacity given in the `.highcharts-point-hover` class.
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to use insteadof the global [colors](#colors).
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// The end angle of the pie in degrees where 0 is top and 90 is right.Defaults to `startAngle` plus 360.
		/// </summary>
		public double? EndAngle { get; set; }
		private double? EndAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The size of the inner diameter for the pie. A size greater than 0renders a donut chart. Can be a percentage or pixel value. Percentagesare relative to the pie size. Pixel values are given as integers.Note: in Highcharts < 4.1.2, the percentage was relative to the plotarea, not the pie size.
		/// </summary>
		public string InnerSize { get; set; }
		private string InnerSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum size for a pie in response to auto margins. The pie willtry to shrink to make room for data labels in side the plot area, but only to this size.
		/// </summary>
		public double? MinSize { get; set; }
		private double? MinSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The start angle of the pie slices in degrees where 0 is top and 90right.
		/// </summary>
		public double? StartAngle { get; set; }
		private double? StartAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieEvents Events { get; set; }
		private PlotOptionsPieEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the checkbox next to the point name in the legend is clicked.One parameter, event, is passed to the function. The state of thecheckbox is found by event.checked. The checked item is found byevent.item. Return false to prevent the default action which is totoggle the select state of the series.
		/// </summary>
		public string CheckboxClick { get; set; }
		private string CheckboxClick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Not applicable to pies, as the legend item is per point. See point.events.
		/// </summary>
		public string LegendItemClick { get; set; }
		private string LegendItemClick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPiePoint Point { get; set; }
		private PlotOptionsPiePoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieEvents Events { get; set; }
		private PlotOptionsPieEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the legend item belonging to the pie point (slice) isclicked. The `this` keyword refers to the point itself. One parameter,`event`, is passed to the function, containing common event information. Thedefault action is to toggle the visibility of the point. This can beprevented by calling `event.preventDefault()`.
		/// </summary>
		public string LegendItemClick { get; set; }
		private string LegendItemClick_DefaultValue { get; set; }
		 

		/// <summary>
		/// The thickness of a 3D pie. Requires `highcharts-3d.js`
		/// </summary>
		public double? Depth { get; set; }
		private double? Depth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance of the data label from the pie's edge. Negative numbersput the data label on top of the pie slices. Connectors are onlyshown for data labels outside the pie.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the data labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPieFormatter Formatter { get; set; }
		private PlotOptionsPieFormatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to render the connector as a soft arc or a line with sharpbreak.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the line connecting the data label to the pie slice.The default color is the same as the point's color.In styled mode, the connector stroke is given in the`.highcharts-data-label-connector` class.
		/// </summary>
		public string ConnectorColor { get; set; }
		private string ConnectorColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance from the data label to the connector.
		/// </summary>
		public double? ConnectorPadding { get; set; }
		private double? ConnectorPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the line connecting the data label to the pie slice.In styled mode, the connector stroke width is given in the`.highcharts-data-label-connector` class.
		/// </summary>
		public double? ConnectorWidth { get; set; }
		private double? ConnectorWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to render the connector as a soft arc or a line with sharpbreak.
		/// </summary>
		public double? SoftConnector { get; set; }
		private double? SoftConnector_DefaultValue { get; set; }
		 

		/// <summary>
		/// How much to brighten the point on interaction. Requires the maincolor to be defined in hex or rgb(a) format.In styled mode, the hover brightness is by default replacedby a fill-opacity given in the `.highcharts-point-hover` class.
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (Clip != Clip_DefaultValue) h.Add("clip",Clip);
			if (IgnoreHiddenPoint != IgnoreHiddenPoint_DefaultValue) h.Add("ignoreHiddenPoint",IgnoreHiddenPoint);
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SlicedOffset != SlicedOffset_DefaultValue) h.Add("slicedOffset",SlicedOffset);
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (EndAngle != EndAngle_DefaultValue) h.Add("endAngle",EndAngle);
			if (InnerSize != InnerSize_DefaultValue) h.Add("innerSize",InnerSize);
			if (MinSize != MinSize_DefaultValue) h.Add("minSize",MinSize);
			if (StartAngle != StartAngle_DefaultValue) h.Add("startAngle",StartAngle);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (Depth != Depth_DefaultValue) h.Add("depth",Depth);
			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (Clip != Clip_DefaultValue) h.Add("clip",Clip);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (X != X_DefaultValue) h.Add("x",X);
			if (ConnectorColor != ConnectorColor_DefaultValue) h.Add("connectorColor",ConnectorColor);
			if (ConnectorPadding != ConnectorPadding_DefaultValue) h.Add("connectorPadding",ConnectorPadding);
			if (ConnectorWidth != ConnectorWidth_DefaultValue) h.Add("connectorWidth",ConnectorWidth);
			if (SoftConnector != SoftConnector_DefaultValue) h.Add("softConnector",SoftConnector);
			if (IgnoreHiddenPoint != IgnoreHiddenPoint_DefaultValue) h.Add("ignoreHiddenPoint",IgnoreHiddenPoint);
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SlicedOffset != SlicedOffset_DefaultValue) h.Add("slicedOffset",SlicedOffset);
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (FollowPointer != FollowPointer_DefaultValue) h.Add("followPointer",FollowPointer);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (EndAngle != EndAngle_DefaultValue) h.Add("endAngle",EndAngle);
			if (InnerSize != InnerSize_DefaultValue) h.Add("innerSize",InnerSize);
			if (MinSize != MinSize_DefaultValue) h.Add("minSize",MinSize);
			if (StartAngle != StartAngle_DefaultValue) h.Add("startAngle",StartAngle);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (CheckboxClick != CheckboxClick_DefaultValue) h.Add("checkboxClick",CheckboxClick);
			if (LegendItemClick != LegendItemClick_DefaultValue) h.Add("legendItemClick",LegendItemClick);
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (LegendItemClick != LegendItemClick_DefaultValue) h.Add("legendItemClick",LegendItemClick);
			if (Depth != Depth_DefaultValue) h.Add("depth",Depth);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (X != X_DefaultValue) h.Add("x",X);
			if (ConnectorColor != ConnectorColor_DefaultValue) h.Add("connectorColor",ConnectorColor);
			if (ConnectorPadding != ConnectorPadding_DefaultValue) h.Add("connectorPadding",ConnectorPadding);
			if (ConnectorWidth != ConnectorWidth_DefaultValue) h.Add("connectorWidth",ConnectorWidth);
			if (SoftConnector != SoftConnector_DefaultValue) h.Add("softConnector",SoftConnector);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
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
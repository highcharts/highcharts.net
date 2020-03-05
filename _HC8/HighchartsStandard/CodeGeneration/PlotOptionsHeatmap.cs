using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class PlotOptionsHeatmap  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsHeatmap()
		{
			Accessibility = Accessibility_DefaultValue = new PlotOptionsHeatmapAccessibility();
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			BoostBlending = BoostBlending_DefaultValue = PlotOptionsHeatmapBoostBlending.Undefined;
			BoostThreshold = BoostThreshold_DefaultValue = 5000;
			BorderWidth = BorderWidth_DefaultValue = 0;
			ClassName = ClassName_DefaultValue = "";
			Clip = Clip_DefaultValue = true;
			Cluster = Cluster_DefaultValue = new PlotOptionsHeatmapCluster();
			Color = Color_DefaultValue = "";
			ColorAxis = ColorAxis_DefaultValue = "0";
			ColorIndex = ColorIndex_DefaultValue = null;
			ColorKey = ColorKey_DefaultValue = "value";
			Colsize = Colsize_DefaultValue = 1;
			CropThreshold = CropThreshold_DefaultValue = 300;
			Cursor = Cursor_DefaultValue = PlotOptionsHeatmapCursor.Null;
			DataLabels = DataLabels_DefaultValue = new PlotOptionsHeatmapDataLabels();
			DataSorting = DataSorting_DefaultValue = new PlotOptionsHeatmapDataSorting();
			Description = Description_DefaultValue = "";
			DragDrop = DragDrop_DefaultValue = new PlotOptionsHeatmapDragDrop();
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			Events = Events_DefaultValue = new PlotOptionsHeatmapEvents();
			IncludeInDataExport = IncludeInDataExport_DefaultValue = null;
			Jitter = Jitter_DefaultValue = new PlotOptionsHeatmapJitter();
			Keys = Keys_DefaultValue = new List<string>();
			Label = Label_DefaultValue = new PlotOptionsHeatmapLabel();
			LinkedTo = LinkedTo_DefaultValue = "";
			NegativeColor = NegativeColor_DefaultValue = "";
			NullColor = NullColor_DefaultValue = "#f7f7f7";
			Opacity = Opacity_DefaultValue = 1;
			Point = Point_DefaultValue = new PlotOptionsHeatmapPoint();
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			PointPadding = PointPadding_DefaultValue = 0;
			Rowsize = Rowsize_DefaultValue = 1;
			Selected = Selected_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			ShowInLegend = ShowInLegend_DefaultValue = null;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			States = States_DefaultValue = new PlotOptionsHeatmapStates();
			StickyTracking = StickyTracking_DefaultValue = true;
			Tooltip = Tooltip_DefaultValue = new PlotOptionsHeatmapTooltip();
			TurboThreshold = TurboThreshold_DefaultValue = 1000;
			Visible = Visible_DefaultValue = true;
			ZoneAxis = ZoneAxis_DefaultValue = "y";
			Zones = Zones_DefaultValue = new List<PlotOptionsHeatmapZone>();
			
		}	
		

		/// <summary>
		/// Accessibility options for a series.
		/// </summary>
		public PlotOptionsHeatmapAccessibility Accessibility { get; set; }
		private PlotOptionsHeatmapAccessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow this series' points to be selected by clicking on the graphic(columns, point markers, pie slices, map areas etc).The selected points can be handled by point select and unselectevents, or collectively by the [getSelectedPoints](Highcharts.Chart#getSelectedPoints) function.And alternative way of selecting points is through dragging.
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// Animation is disabled by default on the heatmap series.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sets the color blending in the boost module.
		/// </summary>
		public PlotOptionsHeatmapBoostBlending BoostBlending { get; set; }
		private PlotOptionsHeatmapBoostBlending BoostBlending_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the point threshold for when a series should enter boost mode.Setting it to e.g. 2000 will cause the series to enter boost mode when thereare 2000 or more points in the series.To disable boosting on the series, set the `boostThreshold` to 0. Setting itto 1 will force boosting.Note that the [cropThreshold](plotOptions.series.cropThreshold) also affectsthis setting. When zooming in on a series that has fewer points than the`cropThreshold`, all points are rendered although outside the visible plotarea, and the `boostThreshold` won't take effect.
		/// </summary>
		public double? BoostThreshold { get; set; }
		private double? BoostThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width for each heat map item.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// An additional class name to apply to the series' graphical elements.This option does not replace default class names of the graphicalelement.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Disable this option to allow series rendering in the whole plottingarea.**Note:** Clipping should be always enabled when[chart.zoomType](#chart.zoomType) is set
		/// </summary>
		public bool? Clip { get; set; }
		private bool? Clip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for marker clusters, the concept of sampling the datavalues into larger blocks in order to ease readability andincrease performance of the JavaScript charts.Note: marker clusters module is not working with `boost`and `draggable-points` modules.The marker clusters feature requires the marker-clusters.jsfile to be loaded, found in the modules directory of the downloadpackage, or online at [code.highcharts.com/modules/marker-clusters.js](code.highcharts.com/modules/marker-clusters.js).
		/// </summary>
		public PlotOptionsHeatmapCluster Cluster { get; set; }
		private PlotOptionsHeatmapCluster Cluster_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color of the series. In heat maps this color is rarely used,as we mostly use the color to denote the value of each point. Unlessoptions are set in the [colorAxis](#colorAxis), the default valueis pulled from the [options.colors](#colors) array.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple color axes, this number defines whichcolorAxis the particular series is connected to. It refers toeither the{@link #colorAxis.id|axis id}or the index of the axis in the colorAxis array, with 0 being thefirst. Set this option to false to prevent a series from connectingto the default color axis.Since v7.2.0 the option can also be an axis id or an axis indexinstead of a boolean flag.
		/// </summary>
		public string ColorAxis { get; set; }
		private string ColorAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styled mode only. A specific color index to use for the series, soits graphic representations are given the class name`highcharts-color-{n}`.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ColorKey { get; set; }
		private string ColorKey_DefaultValue { get; set; }
		 

		/// <summary>
		/// The column size - how many X axis units each column in the heatmapshould span.
		/// </summary>
		public double? Colsize { get; set; }
		private double? Colsize_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the series contains less points than the crop threshold, allpoints are drawn, even if the points fall outside the visible plotarea at the current zoom. The advantage of drawing all points(including markers and columns), is that animation is performed onupdates. On the other hand, when the series contains more points thanthe crop threshold, the series data is cropped to only contain pointsthat fall within the plot area. The advantage of cropping awayinvisible points is to increase performance on large series.
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.In styled mode, the series cursor can be set with the same classesas listed under [series.color](#plotOptions.series.color).
		/// </summary>
		public PlotOptionsHeatmapCursor Cursor { get; set; }
		private PlotOptionsHeatmapCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapDataLabels DataLabels { get; set; }
		private PlotOptionsHeatmapDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the series data sorting.
		/// </summary>
		public PlotOptionsHeatmapDataSorting DataSorting { get; set; }
		private PlotOptionsHeatmapDataSorting DataSorting_DefaultValue { get; set; }
		 

		/// <summary>
		/// A description of the series to add to the screen reader informationabout the series.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// The draggable-points module allows points to be moved around or modified inthe chart. In addition to the options mentioned under the `dragDrop` APIstructure, the module fires three events,[point.dragStart](plotOptions.series.point.events.dragStart),[point.drag](plotOptions.series.point.events.drag) and[point.drop](plotOptions.series.point.events.drop).
		/// </summary>
		public PlotOptionsHeatmapDragDrop DragDrop { get; set; }
		private PlotOptionsHeatmapDragDrop DragDrop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// General event handlers for the series items. These event hooks canalso be attached to the series at run time using the`Highcharts.addEvent` function.
		/// </summary>
		public PlotOptionsHeatmapEvents Events { get; set; }
		private PlotOptionsHeatmapEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// When set to `false` will prevent the series data from being included inany form of data export.Since version 6.0.0 until 7.1.0 the option was existing undocumentedas `includeInCSVExport`.
		/// </summary>
		public bool? IncludeInDataExport { get; set; }
		private bool? IncludeInDataExport_DefaultValue { get; set; }
		 

		/// <summary>
		/// Apply a jitter effect for the rendered markers. When plottingdiscrete values, a little random noise may help telling the pointsapart. The jitter setting applies a random displacement of up to `n`axis units in either direction. So for example on a horizontal Xaxis, setting the `jitter.x` to 0.24 will render the point in arandom position between 0.24 units to the left and 0.24 units to theright of the true axis position. On a category axis, setting it to0.5 will fill up the bin and make the data appear continuous.When rendered on top of a box plot or a column series, a jitter valueof 0.24 will correspond to the underlying series' default[groupPadding](https://api.highcharts.com/highcharts/plotOptions.column.groupPadding)and [pointPadding](https://api.highcharts.com/highcharts/plotOptions.column.pointPadding)settings.
		/// </summary>
		public PlotOptionsHeatmapJitter Jitter { get; set; }
		private PlotOptionsHeatmapJitter Jitter_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

		/// <summary>
		/// Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.The series labels currently work with series types having a`graph` or an `area`.
		/// </summary>
		public PlotOptionsHeatmapLabel Label { get; set; }
		private PlotOptionsHeatmapLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [id](#series.id) of another series to link to. Additionally,the value can be ":previous" to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.If master series uses data sorting and linked series does not haveits own sorting definition, the linked series will be sorted in thesame order as the master one.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color for the parts of the graph or points that are below the[threshold](#plotOptions.series.threshold). Note that `zones` takesprecedence over the negative color. Using `negativeColor` isequivalent to applying a zone with value of 0.
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color applied to null points. In styled mode, a general CSS classis applied instead.
		/// </summary>
		public string NullColor { get; set; }
		private string NullColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Opacity of a series parts: line, fill (e.g. area) and dataLabels.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public PlotOptionsHeatmapPoint Point { get; set; }
		private PlotOptionsHeatmapPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// Same as[accessibility.pointDescriptionFormatter](#accessibility.pointDescriptionFormatter),but for an individual series. Overrides the chart wide configuration.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding between the points in the heatmap.
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The row size - how many Y axis units each heatmap row should span.
		/// </summary>
		public double? Rowsize { get; set; }
		private double? Rowsize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If `showCheckbox` is true,the checkbox next to the series name in the legend will be checkedfor a selected series.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allowselecting the series. The state of the checkbox is determined bythe `selected` option.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		private bool? ShowCheckbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in thelegend. Standalone series are shown in legend by default, and linkedseries are not. Since v7.2.0 it is possible to show series that usecolorAxis by setting this option to `true`.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// If set to `true`, the accessibility module will skip past the pointsin this series for keyboard navigation.
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		private bool? SkipKeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapStates States { get; set; }
		private PlotOptionsHeatmapStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` event on aseries isn't triggered until the mouse moves over another series, orout of the plot area. When false, the `mouseOut` event on a series istriggered when the mouse leaves the area around the series' graph ormarkers. This also implies the tooltip when not shared. When`stickyTracking` is false and `tooltip.shared` is false, the tooltipwill be hidden when moving the mouse between series. Defaults to truefor line and area type series, but to false for columns, pies etc.**Note:** The boost module will force this option because oftechnical limitations.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapTooltip Tooltip { get; set; }
		private PlotOptionsHeatmapTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains a data array that is longer than this, onlyone dimensional arrays of numbers, or two dimensional arrays withx and y values are allowed. Also, only the first point is tested,and the rest are assumed to be the same format. This saves expensivedata checking and indexing in long series. Set it to `0` disable.Note:In boost mode turbo threshold is forced. Only array of numbers ortwo dimensional arrays are allowed.
		/// </summary>
		public double? TurboThreshold { get; set; }
		private double? TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the Axis on which the zones are applied.
		/// </summary>
		public string ZoneAxis { get; set; }
		private string ZoneAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining zones within a series. Zones can be applied to theX axis, Y axis or Z axis for bubbles, according to the `zoneAxis`option. The zone definitions have to be in ascending order regardingto the value.In styled mode, the color zones are styled with the`.highcharts-zone-{n}` class, or custom classed from the `className`option([view live demo](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/color-zones/)).
		/// </summary>
		public List<PlotOptionsHeatmapZone> Zones { get; set; }
		private List<PlotOptionsHeatmapZone> Zones_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Accessibility.IsDirty()) h.Add("accessibility",Accessibility.ToHashtable());
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (BoostBlending != BoostBlending_DefaultValue) h.Add("boostBlending", Highcharts.FirstCharacterToLower(BoostBlending.ToString()));
			if (BoostThreshold != BoostThreshold_DefaultValue) h.Add("boostThreshold",BoostThreshold);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Clip != Clip_DefaultValue) h.Add("clip",Clip);
			if (Cluster.IsDirty()) h.Add("cluster",Cluster.ToHashtable());
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorAxis != ColorAxis_DefaultValue) h.Add("colorAxis",ColorAxis);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (ColorKey != ColorKey_DefaultValue) h.Add("colorKey",ColorKey);
			if (Colsize != Colsize_DefaultValue) h.Add("colsize",Colsize);
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (DataSorting != DataSorting_DefaultValue) h.Add("dataSorting",DataSorting);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (DragDrop.IsDirty()) h.Add("dragDrop",DragDrop.ToHashtable());
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (IncludeInDataExport != IncludeInDataExport_DefaultValue) h.Add("includeInDataExport",IncludeInDataExport);
			if (Jitter.IsDirty()) h.Add("jitter",Jitter.ToHashtable());
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (NullColor != NullColor_DefaultValue) h.Add("nullColor",NullColor);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); Highcharts.AddFunction("f550d6d4-e30a-4b31-a6fa-b64479dfb99e.pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (Rowsize != Rowsize_DefaultValue) h.Add("rowsize",Rowsize);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (Zones != Zones_DefaultValue) h.Add("zones", HashifyList(Zones));
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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
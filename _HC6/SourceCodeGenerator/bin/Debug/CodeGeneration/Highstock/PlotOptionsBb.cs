using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptionsBb  : BaseObject
	{
		public PlotOptionsBb()
		{
			BottomLine = BottomLine_DefaultValue = new PlotOptionsBbBottomLine();
			TopLine = TopLine_DefaultValue = new PlotOptionsBbTopLine();
			BoostThreshold = BoostThreshold_DefaultValue = 5000;
			GapSize = GapSize_DefaultValue = 0;
			GapUnit = GapUnit_DefaultValue = PlotOptionsBbGapUnit.Relative;
			Label = Label_DefaultValue = new PlotOptionsBbLabel();
			DataGrouping = DataGrouping_DefaultValue = new PlotOptionsBbDataGrouping();
			LineWidth = LineWidth_DefaultValue = 2;
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Events = Events_DefaultValue = new PlotOptionsBbEvents();
			Marker = Marker_DefaultValue = new PlotOptionsBbMarker();
			Point = Point_DefaultValue = new PlotOptionsBbPoint();
			DataLabels = DataLabels_DefaultValue = new PlotOptionsBbDataLabels();
			CropThreshold = CropThreshold_DefaultValue = 300;
			SoftThreshold = SoftThreshold_DefaultValue = true;
			States = States_DefaultValue = new PlotOptionsBbStates();
			StickyTracking = StickyTracking_DefaultValue = true;
			TurboThreshold = TurboThreshold_DefaultValue = 1000;
			FindNearestPointBy = FindNearestPointBy_DefaultValue = PlotOptionsBbFindNearestPointBy.X;
			AnimationLimit = AnimationLimit_DefaultValue = null;
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			ConnectNulls = ConnectNulls_DefaultValue = false;
			Cursor = Cursor_DefaultValue = PlotOptionsBbCursor.Null;
			DashStyle = DashStyle_DefaultValue = PlotOptionsBbDashStyle.Solid;
			Description = Description_DefaultValue = "undefined";
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			ExposeElementToA11y = ExposeElementToA11y_DefaultValue = null;
			GetExtremesFromAll = GetExtremesFromAll_DefaultValue = false;
			Linecap = Linecap_DefaultValue = PlotOptionsBbLinecap.Round;
			LinkedTo = LinkedTo_DefaultValue = "";
			NegativeColor = NegativeColor_DefaultValue = "null";
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShowInLegend = ShowInLegend_DefaultValue = true;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			Step = Step_DefaultValue = PlotOptionsBbStep.Null;
			Threshold = Threshold_DefaultValue = 0;
			Visible = Visible_DefaultValue = true;
			ZoneAxis = ZoneAxis_DefaultValue = "y";
			Tooltip = Tooltip_DefaultValue = new PlotOptionsBbTooltip();
			Zones = Zones_DefaultValue = new List<PlotOptionsBbZone>();
			CompareStart = CompareStart_DefaultValue = false;
			BorderWidth = BorderWidth_DefaultValue = 1;
			Name = Name_DefaultValue = "SMA (14)";
			Params = Params_DefaultValue = new PlotOptionsBbParams();
			
		}	
		

		/// <summary>
		/// Bottom line options.
		/// </summary>
		public PlotOptionsBbBottomLine BottomLine { get; set; }
		private PlotOptionsBbBottomLine BottomLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Top line options.
		/// </summary>
		public PlotOptionsBbTopLine TopLine { get; set; }
		private PlotOptionsBbTopLine TopLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the point threshold for when a series should enter boost mode.Setting it to e.g. 2000 will cause the series to enter boost mode when thereare 2000 or more points in the series.To disable boosting on the series, set the `boostThreshold` to 0. Setting itto 1 will force boosting.Requires `modules/boost.js`.
		/// </summary>
		public double? BoostThreshold { get; set; }
		private double? BoostThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines when to display a gap in the graph, together with the `gapUnit`option.When the `gapUnit` is `relative` (default), a gap size of 5 meansthat if the distance between two points is greater than five timesthat of the two closest points, the graph will be broken.When the `gapUnit` is `value`, the gap is based on absolute axis values,which on a datetime axis is milliseconds.In practice, this option is most often used to visualize gaps intime series. In a stock chart, intraday data is available for daytimehours, while gaps will appear in nights and weekends.
		/// </summary>
		public double? GapSize { get; set; }
		private double? GapSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Together with `gapSize`, this option defines where to draw gaps in the graph.
		/// </summary>
		public PlotOptionsBbGapUnit GapUnit { get; set; }
		private PlotOptionsBbGapUnit GapUnit_DefaultValue { get; set; }
		 

		/// <summary>
		/// Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.The series labels currently work with series types having a`graph` or an `area`.Requires the `series-label.js` module.
		/// </summary>
		public PlotOptionsBbLabel Label { get; set; }
		private PlotOptionsBbLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// Data grouping is the concept of sampling the data values into largerblocks in order to ease readability and increase performance of theJavaScript charts. Highstock by default applies data grouping whenthe points become closer than a certain pixel value, determined bythe `groupPixelWidth` option.If data grouping is applied, the grouping information of groupedpoints can be read from the [Point.dataGroup](#Point.dataGroup).
		/// </summary>
		public PlotOptionsBbDataGrouping DataGrouping { get; set; }
		private PlotOptionsBbDataGrouping DataGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel with of the graph line.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow this series' points to be selected by clicking on the graphic (columns, point markers, pie slices, map areas etc).
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allowselecting the series. The state of the checkbox is determined bythe `selected` option.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		private bool? ShowCheckbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods. Thefollowing properties are supported:<dl><dt>duration</dt><dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>A string reference to an easing function set on the `Math` object.See the _Custom easing function_ demo below.</dd></dl>Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// General event handlers for the series items. These event hooks can alsobe attached to the series at run time using the `Highcharts.addEvent`function.
		/// </summary>
		public PlotOptionsBbEvents Events { get; set; }
		private PlotOptionsBbEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the point markers of line-like series. Properties like`fillColor`, `lineColor` and `lineWidth` define the visual appearanceof the markers. Other series types, like column series, don't havemarkers, but have visual options on the series level instead.In styled mode, the markers can be styled with the `.highcharts-point`,`.highcharts-point-hover` and `.highcharts-point-select`class names.
		/// </summary>
		public PlotOptionsBbMarker Marker { get; set; }
		private PlotOptionsBbMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public PlotOptionsBbPoint Point { get; set; }
		private PlotOptionsBbPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the series data labels, appearing next to each datapoint.In styled mode, the data labels can be styled wtih the `.highcharts-data-label-box` and `.highcharts-data-label` class names ([see example](http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/series-datalabels)).
		/// </summary>
		public PlotOptionsBbDataLabels DataLabels { get; set; }
		private PlotOptionsBbDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the series contains less points than the crop threshold, allpoints are drawn, even if the points fall outside the visible plotarea at the current zoom. The advantage of drawing all points (includingmarkers and columns), is that animation is performed on updates.On the other hand, when the series contains more points than thecrop threshold, the series data is cropped to only contain pointsthat fall within the plot area. The advantage of cropping away invisiblepoints is to increase performance on large series.
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this is true, the series will not cause the Y axis to crossthe zero plane (or [threshold](#plotOptions.series.threshold) option)unless the data actually crosses the plane.For example, if `softThreshold` is `false`, a series of 0, 1, 2,3 will make the Y axis show negative values according to the `minPadding`option. If `softThreshold` is `true`, the Y axis starts at 0.
		/// </summary>
		public bool? SoftThreshold { get; set; }
		private bool? SoftThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsBbStates States { get; set; }
		private PlotOptionsBbStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` eventon a series isn't triggered until the mouse moves over another series,or out of the plot area. When false, the `mouseOut` event on aseries is triggered when the mouse leaves the area around the series'graph or markers. This also implies the tooltip when not shared. When`stickyTracking` is false and `tooltip.shared` is false, the tooltip willbe hidden when moving the mouse between series. Defaults to true for lineand area type series, but to false for columns, pies etc.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains a data array that is longer than this, onlyone dimensional arrays of numbers, or two dimensional arrays withx and y values are allowed. Also, only the first point is tested,and the rest are assumed to be the same format. This saves expensivedata checking and indexing in long series. Set it to `0` disable.
		/// </summary>
		public double? TurboThreshold { get; set; }
		private double? TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Determines whether the series should look for the nearest pointin both dimensions or just the x-dimension when hovering the series.Defaults to `'xy'` for scatter series and `'x'` for most otherseries. If the data has duplicate x-values, it is recommended toset this to `'xy'` to allow hovering over all points.Applies only to series types using nearest neighbor search (notdirect hover) for tooltip.
		/// </summary>
		public PlotOptionsBbFindNearestPointBy FindNearestPointBy { get; set; }
		private PlotOptionsBbFindNearestPointBy FindNearestPointBy_DefaultValue { get; set; }
		 

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
		/// Whether to connect a graph line across null points, or render a gapbetween the two points on either side of the null.
		/// </summary>
		public bool? ConnectNulls { get; set; }
		private bool? ConnectNulls_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.
		/// </summary>
		public PlotOptionsBbCursor Cursor { get; set; }
		private PlotOptionsBbCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A name for the dash style to use for the graph, or for some series typesthe outline of each shape. The value for the `dashStyle` include:*   Solid*   ShortDash*   ShortDot*   ShortDashDot*   ShortDashDotDot*   Dot*   Dash*   LongDash*   DashDot*   LongDashDot*   LongDashDotDot
		/// </summary>
		public PlotOptionsBbDashStyle DashStyle { get; set; }
		private PlotOptionsBbDashStyle DashStyle_DefaultValue { get; set; }
		 

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
		/// Whether to use the Y extremes of the total chart width or only thezoomed area when zooming in on parts of the X axis. By default, theY axis adjusts to the min and max of the visible data. Cartesianseries only.
		/// </summary>
		public bool? GetExtremesFromAll { get; set; }
		private bool? GetExtremesFromAll_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line cap used for line ends and line joins on the graph.
		/// </summary>
		public PlotOptionsBbLinecap Linecap { get; set; }
		private PlotOptionsBbLinecap Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [id](#series.id) of another series to link to. Additionally,the value can be ":previous" to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color for the parts of the graph or points that are below the[threshold](#plotOptions.series.threshold).
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

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
		/// Whether to apply a drop shadow to the graph line. Since 2.3 the shadowcan be an object configuration containing `color`, `offsetX`, `offsetY`, `opacity` and `width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in the legend.The default value is `true` for standalone series, `false` for linkedseries.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// If set to `True`, the accessibility module will skip past the pointsin this series for keyboard navigation.
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		private bool? SkipKeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply steps to the line. Possible values are `left`, `center`and `right`.
		/// </summary>
		public PlotOptionsBbStep Step { get; set; }
		private PlotOptionsBbStep Step_DefaultValue { get; set; }
		 

		/// <summary>
		/// The threshold, also called zero level or base level. For line typeseries this is only used in conjunction with[negativeColor](#plotOptions.series.negativeColor).
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		 

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
		/// A configuration object for the tooltip rendering of each single series.Properties are inherited from [tooltip](#tooltip), but only thefollowing properties can be defined on a series level.
		/// </summary>
		public PlotOptionsBbTooltip Tooltip { get; set; }
		private PlotOptionsBbTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array defining zones within a series. Zones can be applied tothe X axis, Y axis or Z axis for bubbles, according to the `zoneAxis`option.In styled mode, the color zones are styled with the `.highcharts-zone-{n}` class, or custom classed from the `className` option ([viewlive demo](http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/color-zones/)).
		/// </summary>
		public List<PlotOptionsBbZone> Zones { get; set; }
		private List<PlotOptionsBbZone> Zones_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines if comparisson should start from the first point within the visiblerange or should start from the first point <b>before</b> the range.In other words, this flag determines if first point within the visible rangewill have 0% (`compareStart=true`) or should have been already calculatedaccording to the previous point (`compareStart=false`).
		/// </summary>
		public bool? CompareStart { get; set; }
		private bool? CompareStart_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width of each map area.In styled mode, the border stroke width is given in the `.highcharts-point` class.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The series name.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBbParams Params { get; set; }
		private PlotOptionsBbParams Params_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BottomLine.IsDirty()) h.Add("bottomLine",BottomLine.ToHashtable());
			if (TopLine.IsDirty()) h.Add("topLine",TopLine.ToHashtable());
			if (BoostThreshold != BoostThreshold_DefaultValue) h.Add("boostThreshold",BoostThreshold);
			if (GapSize != GapSize_DefaultValue) h.Add("gapSize",GapSize);
			if (GapUnit != GapUnit_DefaultValue) h.Add("gapUnit", Highstock.FirstCharacterToLower(GapUnit.ToString()));
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (DataGrouping.IsDirty()) h.Add("dataGrouping",DataGrouping.ToHashtable());
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (SoftThreshold != SoftThreshold_DefaultValue) h.Add("softThreshold",SoftThreshold);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (FindNearestPointBy != FindNearestPointBy_DefaultValue) h.Add("findNearestPointBy", Highstock.FirstCharacterToLower(FindNearestPointBy.ToString()));
			if (AnimationLimit != AnimationLimit_DefaultValue) h.Add("animationLimit",AnimationLimit);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (ConnectNulls != ConnectNulls_DefaultValue) h.Add("connectNulls",ConnectNulls);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highstock.FirstCharacterToLower(Cursor.ToString()));
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", Highstock.FirstCharacterToLower(DashStyle.ToString()));
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (ExposeElementToA11y != ExposeElementToA11y_DefaultValue) h.Add("exposeElementToA11y",ExposeElementToA11y);
			if (GetExtremesFromAll != GetExtremesFromAll_DefaultValue) h.Add("getExtremesFromAll",GetExtremesFromAll);
			if (Linecap != Linecap_DefaultValue) h.Add("linecap", Highstock.FirstCharacterToLower(Linecap.ToString()));
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); Highstock.AddFunction("PlotOptionsBbPointDescriptionFormatter.pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Step != Step_DefaultValue) h.Add("step", Highstock.FirstCharacterToLower(Step.ToString()));
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (Zones != Zones_DefaultValue) h.Add("zones", HashifyList(Zones));
			if (CompareStart != CompareStart_DefaultValue) h.Add("compareStart",CompareStart);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Params.IsDirty()) h.Add("params",Params.ToHashtable());
			

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
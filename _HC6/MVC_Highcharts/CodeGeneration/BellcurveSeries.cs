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
	public partial class BellcurveSeries  : Series
	{
		public BellcurveSeries()
		{
			Id = Id_DefaultValue = null;
			Index = Index_DefaultValue = null;
			LegendIndex = LegendIndex_DefaultValue = null;
			Name = Name_DefaultValue = null;
			Stack = Stack_DefaultValue = "null";
			Type = Type_DefaultValue = BellcurveSeriesType.Null;
			XAxis = XAxis_DefaultValue = new List<XAxis>();
			YAxis = YAxis_DefaultValue = new List<YAxis>();
			ZIndex = ZIndex_DefaultValue = null;
			Intervals = Intervals_DefaultValue = null;
			PointsInInterval = PointsInInterval_DefaultValue = null;
			Marker = Marker_DefaultValue = new BellcurveSeriesMarker();
			SoftThreshold = SoftThreshold_DefaultValue = false;
			Threshold = Threshold_DefaultValue = 0;
			FillColor = FillColor_DefaultValue = null;
			FillOpacity = FillOpacity_DefaultValue = null;
			LineColor = LineColor_DefaultValue = "null";
			NegativeFillColor = NegativeFillColor_DefaultValue = null;
			TrackByArea = TrackByArea_DefaultValue = false;
			Linecap = Linecap_DefaultValue = BellcurveSeriesLinecap.Round;
			Label = Label_DefaultValue = new BellcurveSeriesLabel();
			LineWidth = LineWidth_DefaultValue = 2;
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Events = Events_DefaultValue = new BellcurveSeriesEvents();
			Point = Point_DefaultValue = new BellcurveSeriesPoint();
			DataLabels = DataLabels_DefaultValue = new BellcurveSeriesDataLabels();
			CropThreshold = CropThreshold_DefaultValue = 300;
			States = States_DefaultValue = new BellcurveSeriesStates();
			StickyTracking = StickyTracking_DefaultValue = null;
			TurboThreshold = TurboThreshold_DefaultValue = 1000;
			FindNearestPointBy = FindNearestPointBy_DefaultValue = BellcurveSeriesFindNearestPointBy.X;
			AnimationLimit = AnimationLimit_DefaultValue = null;
			ClassName = ClassName_DefaultValue = null;
			Color = Color_DefaultValue = null;
			ColorIndex = ColorIndex_DefaultValue = null;
			Cursor = Cursor_DefaultValue = BellcurveSeriesCursor.Null;
			DashStyle = DashStyle_DefaultValue = BellcurveSeriesDashStyle.Solid;
			Description = Description_DefaultValue = "undefined";
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			ExposeElementToA11y = ExposeElementToA11y_DefaultValue = null;
			GetExtremesFromAll = GetExtremesFromAll_DefaultValue = false;
			Keys = Keys_DefaultValue = new List<string>();
			LinkedTo = LinkedTo_DefaultValue = null;
			NegativeColor = NegativeColor_DefaultValue = "null";
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			PointPlacement = PointPlacement_DefaultValue = new PointPlacement();
			PointStart = PointStart_DefaultValue = 0;
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShowInLegend = ShowInLegend_DefaultValue = true;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			Visible = Visible_DefaultValue = true;
			ZoneAxis = ZoneAxis_DefaultValue = "y";
			Tooltip = Tooltip_DefaultValue = new BellcurveSeriesTooltip();
			Zones = Zones_DefaultValue = new BellcurveSeriesZone();
			ConnectEnds = ConnectEnds_DefaultValue = null;
			BoostThreshold = BoostThreshold_DefaultValue = 5000;
			ConnectNulls = ConnectNulls_DefaultValue = false;
			PointInterval = PointInterval_DefaultValue = 1;
			PointIntervalUnit = PointIntervalUnit_DefaultValue = BellcurveSeriesPointIntervalUnit.Null;
			Stacking = Stacking_DefaultValue = BellcurveSeriesStacking.Null;
			Step = Step_DefaultValue = BellcurveSeriesStep.Null;
			
		}	
		

		/// <summary>
		/// <p>An id for the series. This can be used after render time to get apointer to the series object through <code>chart.get()</code>.</p>
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The index of the series in the chart, affecting the internal indexin the <code>chart.series</code> array, the visible Z index as well as the orderin the legend.</p>
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The sequential index of the series in the legend.</p>
		/// </summary>
		public double? LegendIndex { get; set; }
		private double? LegendIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The name of the series as shown in the legend, tooltip etc.</p>
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>This option allows grouping series in a stacked chart. The stackoption can be a string or a number or anything else, as long as thegrouped series&#39; stack options match each other.</p>
		/// </summary>
		public string Stack { get; set; }
		private string Stack_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The type of series, for example <code>line</code> or <code>column</code>.</p>
		/// </summary>
		public BellcurveSeriesType Type { get; set; }
		private BellcurveSeriesType Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When using dual or multiple x axes, this number defines which xAxisthe particular series is connected to. It refers to either the <a href="#xAxis.id">axisid</a> or the index of the axis in the xAxis array, with0 being the first.</p>
		/// </summary>
		public List<XAxis> XAxis { get; set; }
		private List<XAxis> XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When using dual or multiple y axes, this number defines which yAxisthe particular series is connected to. It refers to either the <a href="#yAxis.id">axisid</a> or the index of the axis in the yAxis array, with0 being the first.</p>
		/// </summary>
		public List<YAxis> YAxis { get; set; }
		private List<YAxis> YAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Define the visual z index of the series.</p>
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>This option allows to define the length of the bell curve. A unit of thelength of the bell curve is standard deviation.</p>
		/// </summary>
		public double? Intervals { get; set; }
		private double? Intervals_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Defines how many points should be plotted within 1 interval. See <code>plotOptions.bellcurve.intervals</code>.</p>
		/// </summary>
		public double? PointsInInterval { get; set; }
		private double? PointsInInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the point markers of line-like series. Properties like<code>fillColor</code>, <code>lineColor</code> and <code>lineWidth</code> define the visual appearanceof the markers. Other series types, like column series, don&#39;t havemarkers, but have visual options on the series level instead.</p><p>In styled mode, the markers can be styled with the <code>.highcharts-point</code>,<code>.highcharts-point-hover</code> and <code>.highcharts-point-select</code>class names.</p>
		/// </summary>
		public BellcurveSeriesMarker Marker { get; set; }
		private BellcurveSeriesMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When this is true, the series will not cause the Y axis to crossthe zero plane (or <a href="#plotOptions.series.threshold">threshold</a> option)unless the data actually crosses the plane.</p><p>For example, if <code>softThreshold</code> is <code>false</code>, a series of 0, 1, 2,3 will make the Y axis show negative values according to the <code>minPadding</code>option. If <code>softThreshold</code> is <code>true</code>, the Y axis starts at 0.</p>
		/// </summary>
		public bool? SoftThreshold { get; set; }
		private bool? SoftThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The Y axis value to serve as the base for the area, for distinguishingbetween values above and below a threshold. If <code>null</code>, the areabehaves like a line series with fill between the graph and the Yaxis minimum.</p>
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fill color or gradient for the area. When <code>null</code>, the series&#39; <code>color</code>is used with the series&#39; <code>fillOpacity</code>.</p>
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fill opacity for the area. When you set an explicit <code>fillColor</code>,the <code>fillOpacity</code> is not applied. Instead, you should define theopacity in the <code>fillColor</code> with an rgba color definition. The <code>fillOpacity</code>setting, also the default setting, overrides the alpha componentof the <code>color</code> setting.</p>
		/// </summary>
		public double? FillOpacity { get; set; }
		private double? FillOpacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A separate color for the graph line. By default the line takes the<code>color</code> of the series, but the lineColor setting allows setting aseparate color for the line without altering the <code>fillColor</code>.</p>
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A separate color for the negative part of the area.</p>
		/// </summary>
		public string NegativeFillColor { get; set; }
		private string NegativeFillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether the whole area or just the line should respond to mouseovertooltips and other mouse or touch events.</p>
		/// </summary>
		public bool? TrackByArea { get; set; }
		private bool? TrackByArea_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The SVG value used for the <code>stroke-linecap</code> and <code>stroke-linejoin</code>of a line graph. Round means that lines are rounded in the ends andbends.</p>
		/// </summary>
		public BellcurveSeriesLinecap Linecap { get; set; }
		private BellcurveSeriesLinecap Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.</p><p>The series labels currently work with series types having a<code>graph</code> or an <code>area</code>.</p><p>Requires the <code>series-label.js</code> module.</p>
		/// </summary>
		public BellcurveSeriesLabel Label { get; set; }
		private BellcurveSeriesLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Pixel with of the graph line.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Allow this series&#39; points to be selected by clicking on the graphic (columns, point markers, pie slices, map areas etc).</p>
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If true, a checkbox is displayed next to the legend item to allowselecting the series. The state of the checkbox is determined bythe <code>selected</code> option.</p>
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		private bool? ShowCheckbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see <a href="#chart.animation">chart.animation</a> and the animation parameter under the API methods. Thefollowing properties are supported:</p><dl><dt>duration</dt><dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>A string reference to an easing function set on the <code>Math</code> object.See the <em>Custom easing function</em> demo below.</dd></dl><p>Due to poor performance, animation is disabled in old IE browsersfor several chart types.</p>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>General event handlers for the series items. These event hooks can alsobe attached to the series at run time using the <code>Highcharts.addEvent</code>function.</p>
		/// </summary>
		public BellcurveSeriesEvents Events { get; set; }
		private BellcurveSeriesEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Properties for each single point.</p>
		/// </summary>
		public BellcurveSeriesPoint Point { get; set; }
		private BellcurveSeriesPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the series data labels, appearing next to each datapoint.</p><p>In styled mode, the data labels can be styled wtih the <code>.highcharts-data-label-box</code> and <code>.highcharts-data-label</code> class names (<a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/series-datalabels">see example</a>).</p>
		/// </summary>
		public BellcurveSeriesDataLabels DataLabels { get; set; }
		private BellcurveSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When the series contains less points than the crop threshold, allpoints are drawn, even if the points fall outside the visible plotarea at the current zoom. The advantage of drawing all points (includingmarkers and columns), is that animation is performed on updates.On the other hand, when the series contains more points than thecrop threshold, the series data is cropped to only contain pointsthat fall within the plot area. The advantage of cropping away invisiblepoints is to increase performance on large series.</p>
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A wrapper object for all the series options in specific states.</p>
		/// </summary>
		public BellcurveSeriesStates States { get; set; }
		private BellcurveSeriesStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Sticky tracking of mouse events. When true, the <code>mouseOut</code> eventon a series isn&#39;t triggered until the mouse moves over another series,or out of the plot area. When false, the <code>mouseOut</code> event on aseries is triggered when the mouse leaves the area around the series&#39;graph or markers. This also implies the tooltip when not shared. When<code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the tooltip willbe hidden when moving the mouse between series. Defaults to true for lineand area type series, but to false for columns, pies etc.</p>
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When a series contains a data array that is longer than this, onlyone dimensional arrays of numbers, or two dimensional arrays withx and y values are allowed. Also, only the first point is tested,and the rest are assumed to be the same format. This saves expensivedata checking and indexing in long series. Set it to <code>0</code> disable.</p>
		/// </summary>
		public double? TurboThreshold { get; set; }
		private double? TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Determines whether the series should look for the nearest pointin both dimensions or just the x-dimension when hovering the series.Defaults to <code>&#39;xy&#39;</code> for scatter series and <code>&#39;x&#39;</code> for most otherseries. If the data has duplicate x-values, it is recommended toset this to <code>&#39;xy&#39;</code> to allow hovering over all points.</p><p>Applies only to series types using nearest neighbor search (notdirect hover) for tooltip.</p>
		/// </summary>
		public BellcurveSeriesFindNearestPointBy FindNearestPointBy { get; set; }
		private BellcurveSeriesFindNearestPointBy FindNearestPointBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For some series, there is a limit that shuts down initial animationby default when the total number of points in the chart is too high.For example, for a column chart and its derivatives, animation doesn&#39;trun if there is more than 250 points totally. To disable this cap, set<code>animationLimit</code> to <code>Infinity</code>.</p>
		/// </summary>
		public double? AnimationLimit { get; set; }
		private double? AnimationLimit_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A class name to apply to the series&#39; graphical elements.</p>
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The main color of the series. In line type series it applies to theline and the point markers unless otherwise specified. In bar typeseries it applies to the bars unless a color is specified per point.The default value is pulled from the <code>options.colors</code> array.</p><p>In styled mode, the color can be defined by the<a href="#plotOptions.series.colorIndex">colorIndex</a> option. Also, the seriescolor can be set with the <code>.highcharts-series</code>, <code>.highcharts-color-{n}</code>,<code>.highcharts-{type}-series</code> or <code>.highcharts-series-{n}</code> class, orindividual classes given by the <code>className</code> option.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Styled mode only. A specific color index to use for the series, so itsgraphic representations are given the class name <code>highcharts-color-{n}</code>.</p>
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>You can set the cursor to &quot;pointer&quot; if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.</p>
		/// </summary>
		public BellcurveSeriesCursor Cursor { get; set; }
		private BellcurveSeriesCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A name for the dash style to use for the graph, or for some series typesthe outline of each shape. The value for the <code>dashStyle</code> include:</p><ul><li>Solid</li><li>ShortDash</li><li>ShortDot</li><li>ShortDashDot</li><li>ShortDashDotDot</li><li>Dot</li><li>Dash</li><li>LongDash</li><li>DashDot</li><li>LongDashDot</li><li>LongDashDotDot</li></ul>
		/// </summary>
		public BellcurveSeriesDashStyle DashStyle { get; set; }
		private BellcurveSeriesDashStyle DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Requires the Accessibility module.</p><p>A description of the series to add to the screen reader informationabout the series.</p>
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.</p>
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>By default, series are exposed to screen readers as regions. By enablingthis option, the series element itself will be exposed in the sameway as the data points. This is useful if the series is not usedas a grouping entity in the chart, but you still want to attach adescription to the series.</p><p>Requires the Accessibility module.</p>
		/// </summary>
		public bool? ExposeElementToA11y { get; set; }
		private bool? ExposeElementToA11y_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to use the Y extremes of the total chart width or only thezoomed area when zooming in on parts of the X axis. By default, theY axis adjusts to the min and max of the visible data. Cartesianseries only.</p>
		/// </summary>
		public bool? GetExtremesFromAll { get; set; }
		private bool? GetExtremesFromAll_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.</p>
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The <a href="#series.id">id</a> of another series to link to. Additionally,the value can be &quot;:previous&quot; to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.</p>
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color for the parts of the graph or points that are below the<a href="#plotOptions.series.threshold">threshold</a>.</p>
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Same as <a href="#accessibility.pointDescriptionFormatter">accessibility.pointDescriptionFormatter</a>, but for an individual series. Overridesthe chart wide configuration.</p>
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Possible values: <code>null</code>, <code>&quot;on&quot;</code>, <code>&quot;between&quot;</code>.</p><p>In a column chart, when pointPlacement is <code>&quot;on&quot;</code>, the point willnot create any padding of the X axis. In a polar column chart thismeans that the first column points directly north. If the pointPlacementis <code>&quot;between&quot;</code>, the columns will be laid out between ticks. Thisis useful for example for visualising an amount between two pointsin time or in a certain sector of a polar chart.</p><p>Since Highcharts 3.0.2, the point placement can also be numeric,where 0 is on the axis value, -0.5 is between this value and theprevious, and 0.5 is between this value and the next. Unlike thetextual options, numeric point placement options won&#39;t affect axispadding.</p><p>Note that pointPlacement needs a <a href="#plotOptions.series.pointRange">pointRange</a> to work. For column series this is computed, but forline-type series it needs to be set.</p><p>Defaults to <code>null</code> in cartesian charts, <code>&quot;between&quot;</code> in polar charts.</p>
		/// </summary>
		public PointPlacement PointPlacement { get; set; }
		private PointPlacement PointPlacement_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If no x values are given for the points in a series, pointStart defineson what value to start. For example, if a series contains one yearlyvalue starting from 1945, set pointStart to 1945.</p>
		/// </summary>
		public double? PointStart { get; set; }
		private double? PointStart_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to select the series initially. If <code>showCheckbox</code> is true,the checkbox next to the series name in the legend will be checked for aselected series.</p>
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to apply a drop shadow to the graph line. Since 2.3 the shadowcan be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.</p>
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to display this particular series or series type in the legend.The default value is <code>true</code> for standalone series, <code>false</code> for linkedseries.</p>
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If set to <code>True</code>, the accessibility module will skip past the pointsin this series for keyboard navigation.</p>
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		private bool? SkipKeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Set the initial visibility of the series.</p>
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Defines the Axis on which the zones are applied.</p>
		/// </summary>
		public string ZoneAxis { get; set; }
		private string ZoneAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A configuration object for the tooltip rendering of each single series.Properties are inherited from <a href="#tooltip">tooltip</a>, but only thefollowing properties can be defined on a series level.</p>
		/// </summary>
		public BellcurveSeriesTooltip Tooltip { get; set; }
		private BellcurveSeriesTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array defining zones within a series. Zones can be applied tothe X axis, Y axis or Z axis for bubbles, according to the <code>zoneAxis</code>option.</p><p>In styled mode, the color zones are styled with the <code>.highcharts-zone-{n}</code> class, or custom classed from the <code>className</code> option (<a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/color-zones/">viewlive demo</a>).</p>
		/// </summary>
		public BellcurveSeriesZone Zones { get; set; }
		private BellcurveSeriesZone Zones_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Polar charts only. Whether to connect the ends of a line series plotacross the extremes.</p>
		/// </summary>
		public bool? ConnectEnds { get; set; }
		private bool? ConnectEnds_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Set the point threshold for when a series should enter boost mode.</p><p>Setting it to e.g. 2000 will cause the series to enter boost mode when thereare 2000 or more points in the series.</p><p>To disable boosting on the series, set the <code>boostThreshold</code> to 0. Setting itto 1 will force boosting.</p><p>Requires <code>modules/boost.js</code>.</p>
		/// </summary>
		public double? BoostThreshold { get; set; }
		private double? BoostThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to connect a graph line across null points, or render a gapbetween the two points on either side of the null.</p>
		/// </summary>
		public bool? ConnectNulls { get; set; }
		private bool? ConnectNulls_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If no x values are given for the points in a series, <code>pointInterval</code>defines the interval of the x values. For example, if a series containsone value every decade starting from year 0, set <code>pointInterval</code> to<code>10</code>. In true <code>datetime</code> axes, the <code>pointInterval</code> is set inmilliseconds.</p><p>It can be also be combined with <code>pointIntervalUnit</code> to draw irregulartime intervals.</p>
		/// </summary>
		public double? PointInterval { get; set; }
		private double? PointInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>On datetime series, this allows for setting the<a href="#plotOptions.series.pointInterval">pointInterval</a> to irregular time units, <code>day</code>, <code>month</code> and <code>year</code>. A day is usually the same as 24 hours,but <code>pointIntervalUnit</code> also takes the DST crossover into considerationwhen dealing with local time. Combine this option with <code>pointInterval</code>to draw weeks, quarters, 6 months, 10 years etc.</p>
		/// </summary>
		public BellcurveSeriesPointIntervalUnit PointIntervalUnit { get; set; }
		private BellcurveSeriesPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to stack the values of each series on top of each other.Possible values are <code>null</code> to disable, <code>&quot;normal&quot;</code> to stack by value or<code>&quot;percent&quot;</code>. When stacking is enabled, data must be sorted in ascendingX order. A special stacking option is with the streamgraph series type,where the stacking option is set to <code>&quot;stream&quot;</code>.</p>
		/// </summary>
		public BellcurveSeriesStacking Stacking { get; set; }
		private BellcurveSeriesStacking Stacking_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to apply steps to the line. Possible values are <code>left</code>, <code>center</code>and <code>right</code>.</p>
		/// </summary>
		public BellcurveSeriesStep Step { get; set; }
		private BellcurveSeriesStep Step_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Stack != Stack_DefaultValue) h.Add("stack",Stack);
			if (Type != Type_DefaultValue) h.Add("type", Highcharts.FirstCharacterToLower(Type.ToString()));
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis", HashifyList(XAxis));
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis", HashifyList(YAxis));
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (Intervals != Intervals_DefaultValue) h.Add("intervals",Intervals);
			if (PointsInInterval != PointsInInterval_DefaultValue) h.Add("pointsInInterval",PointsInInterval);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (SoftThreshold != SoftThreshold_DefaultValue) h.Add("softThreshold",SoftThreshold);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (FillOpacity != FillOpacity_DefaultValue) h.Add("fillOpacity",FillOpacity);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (NegativeFillColor != NegativeFillColor_DefaultValue) h.Add("negativeFillColor",NegativeFillColor);
			if (TrackByArea != TrackByArea_DefaultValue) h.Add("trackByArea",TrackByArea);
			if (Linecap != Linecap_DefaultValue) h.Add("linecap", Highcharts.FirstCharacterToLower(Linecap.ToString()));
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (FindNearestPointBy != FindNearestPointBy_DefaultValue) h.Add("findNearestPointBy", Highcharts.FirstCharacterToLower(FindNearestPointBy.ToString()));
			if (AnimationLimit != AnimationLimit_DefaultValue) h.Add("animationLimit",AnimationLimit);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", Highcharts.FirstCharacterToLower(DashStyle.ToString()));
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (ExposeElementToA11y != ExposeElementToA11y_DefaultValue) h.Add("exposeElementToA11y",ExposeElementToA11y);
			if (GetExtremesFromAll != GetExtremesFromAll_DefaultValue) h.Add("getExtremesFromAll",GetExtremesFromAll);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); Highcharts.AddFunction("BellcurveSeriesPointDescriptionFormatter.pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (PointPlacement != PointPlacement_DefaultValue) h.Add("pointPlacement",PointPlacement);
			if (PointStart != PointStart_DefaultValue) h.Add("pointStart",PointStart);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (Zones.IsDirty()) h.Add("zones",Zones.ToHashtable());
			if (ConnectEnds != ConnectEnds_DefaultValue) h.Add("connectEnds",ConnectEnds);
			if (BoostThreshold != BoostThreshold_DefaultValue) h.Add("boostThreshold",BoostThreshold);
			if (ConnectNulls != ConnectNulls_DefaultValue) h.Add("connectNulls",ConnectNulls);
			if (PointInterval != PointInterval_DefaultValue) h.Add("pointInterval",PointInterval);
			if (PointIntervalUnit != PointIntervalUnit_DefaultValue) h.Add("pointIntervalUnit", Highcharts.FirstCharacterToLower(PointIntervalUnit.ToString()));
			if (Stacking != Stacking_DefaultValue) h.Add("stacking", Highcharts.FirstCharacterToLower(Stacking.ToString()));
			if (Step != Step_DefaultValue) h.Add("step", Highcharts.FirstCharacterToLower(Step.ToString()));
			

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
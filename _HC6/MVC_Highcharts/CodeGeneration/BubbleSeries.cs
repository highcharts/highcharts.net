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
	public partial class BubbleSeries  : Series
	{
		public BubbleSeries()
		{
			Data = Data_DefaultValue = new List<BubbleSeriesData>();
			Id = Id_DefaultValue = null;
			Index = Index_DefaultValue = null;
			LegendIndex = LegendIndex_DefaultValue = null;
			Name = Name_DefaultValue = null;
			Type = Type_DefaultValue = BubbleSeriesType.Null;
			XAxis = XAxis_DefaultValue = new List<XAxis>();
			YAxis = YAxis_DefaultValue = new List<YAxis>();
			ZIndex = ZIndex_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = new BubbleSeriesDataLabels();
			Marker = Marker_DefaultValue = new BubbleSeriesMarker();
			MinSize = MinSize_DefaultValue = "8";
			MaxSize = MaxSize_DefaultValue = "20%";
			SoftThreshold = SoftThreshold_DefaultValue = false;
			States = States_DefaultValue = new BubbleSeriesStates();
			Tooltip = Tooltip_DefaultValue = new BubbleSeriesTooltip();
			TurboThreshold = TurboThreshold_DefaultValue = null;
			ZThreshold = ZThreshold_DefaultValue = 0;
			ZoneAxis = ZoneAxis_DefaultValue = "z";
			DisplayNegative = DisplayNegative_DefaultValue = true;
			NegativeColor = NegativeColor_DefaultValue = "null";
			SizeBy = SizeBy_DefaultValue = BubbleSeriesSizeBy.Area;
			SizeByAbsoluteValue = SizeByAbsoluteValue_DefaultValue = false;
			ZMax = ZMax_DefaultValue = null;
			ZMin = ZMin_DefaultValue = null;
			LineWidth = LineWidth_DefaultValue = 0;
			FindNearestPointBy = FindNearestPointBy_DefaultValue = BubbleSeriesFindNearestPointBy.Xy;
			StickyTracking = StickyTracking_DefaultValue = false;
			Linecap = Linecap_DefaultValue = BubbleSeriesLinecap.Round;
			BoostThreshold = BoostThreshold_DefaultValue = 5000;
			Label = Label_DefaultValue = new BubbleSeriesLabel();
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Events = Events_DefaultValue = new BubbleSeriesEvents();
			Point = Point_DefaultValue = new BubbleSeriesPoint();
			CropThreshold = CropThreshold_DefaultValue = 300;
			AnimationLimit = AnimationLimit_DefaultValue = null;
			ClassName = ClassName_DefaultValue = null;
			Color = Color_DefaultValue = null;
			ColorIndex = ColorIndex_DefaultValue = null;
			ConnectNulls = ConnectNulls_DefaultValue = false;
			Cursor = Cursor_DefaultValue = BubbleSeriesCursor.Null;
			DashStyle = DashStyle_DefaultValue = BubbleSeriesDashStyle.Solid;
			Description = Description_DefaultValue = "undefined";
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			ExposeElementToA11y = ExposeElementToA11y_DefaultValue = null;
			GetExtremesFromAll = GetExtremesFromAll_DefaultValue = false;
			Keys = Keys_DefaultValue = new List<string>();
			LinkedTo = LinkedTo_DefaultValue = null;
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			PointInterval = PointInterval_DefaultValue = 1;
			PointIntervalUnit = PointIntervalUnit_DefaultValue = BubbleSeriesPointIntervalUnit.Null;
			PointPlacement = PointPlacement_DefaultValue = new PointPlacement();
			PointStart = PointStart_DefaultValue = 0;
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShowInLegend = ShowInLegend_DefaultValue = true;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			Stacking = Stacking_DefaultValue = BubbleSeriesStacking.Null;
			Step = Step_DefaultValue = BubbleSeriesStep.Null;
			Threshold = Threshold_DefaultValue = 0;
			Visible = Visible_DefaultValue = true;
			Zones = Zones_DefaultValue = new BubbleSeriesZone();
			ConnectEnds = ConnectEnds_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>An array of data points for the series. For the <code>bubble</code> series type,points can be given in the following ways:</p><ol><li><p>An array of arrays with 3 or 2 values. In this case, the valuescorrespond to <code>x,y,z</code>. If the first value is a string, it is appliedas the name of the point, and the <code>x</code> value is inferred. The <code>x</code>value can also be omitted, in which case the inner arrays shouldbe of length 2. Then the <code>x</code> value is automatically calculated,either starting at 0 and incremented by 1, or from <code>pointStart</code> and<code>pointInterval</code> given in the series options.</p><pre><code class="lang-js">data: [    [0, 1, 2],    [1, 5, 5],    [2, 0, 2]]</code></pre></li><li><p>An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series&#39; <a href="#series.bubble.turboThreshold">turboThreshold</a>,this option is not available.</p><pre><code class="lang-js">data: [{    x: 1,    y: 1,    z: 1,    name: &quot;Point2&quot;,    color: &quot;#00FF00&quot;}, {    x: 1,    y: 5,    z: 4,    name: &quot;Point1&quot;,    color: &quot;#FF00FF&quot;}]</code></pre></li></ol>
		/// </summary>
		public List<BubbleSeriesData> Data { get; set; }
		private List<BubbleSeriesData> Data_DefaultValue { get; set; }
		 

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
		/// <p>The type of series, for example <code>line</code> or <code>column</code>.</p>
		/// </summary>
		public BubbleSeriesType Type { get; set; }
		private BubbleSeriesType Type_DefaultValue { get; set; }
		 

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
		/// <p>Options for the series data labels, appearing next to each datapoint.</p><p>In styled mode, the data labels can be styled wtih the <code>.highcharts-data-label-box</code> and <code>.highcharts-data-label</code> class names (<a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/series-datalabels">see example</a>).</p>
		/// </summary>
		public BubbleSeriesDataLabels DataLabels { get; set; }
		private BubbleSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the point markers of line-like series. Properties like<code>fillColor</code>, <code>lineColor</code> and <code>lineWidth</code> define the visual appearanceof the markers. Other series types, like column series, don&#39;t havemarkers, but have visual options on the series level instead.</p><p>In styled mode, the markers can be styled with the <code>.highcharts-point</code>, <code>.highcharts-point-hover</code> and <code>.highcharts-point-select</code>class names.</p>
		/// </summary>
		public BubbleSeriesMarker Marker { get; set; }
		private BubbleSeriesMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Minimum bubble size. Bubbles will automatically size between the<code>minSize</code> and <code>maxSize</code> to reflect the <code>z</code> value of each bubble.Can be either pixels (when no unit is given), or a percentage ofthe smallest one of the plot width and height.</p>
		/// </summary>
		public string MinSize { get; set; }
		private string MinSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Maximum bubble size. Bubbles will automatically size between the<code>minSize</code> and <code>maxSize</code> to reflect the <code>z</code> value of each bubble.Can be either pixels (when no unit is given), or a percentage ofthe smallest one of the plot width and height.</p>
		/// </summary>
		public string MaxSize { get; set; }
		private string MaxSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When this is true, the series will not cause the Y axis to crossthe zero plane (or <a href="#plotOptions.series.threshold">threshold</a> option)unless the data actually crosses the plane.</p><p>For example, if <code>softThreshold</code> is <code>false</code>, a series of 0, 1, 2,3 will make the Y axis show negative values according to the <code>minPadding</code>option. If <code>softThreshold</code> is <code>true</code>, the Y axis starts at 0.</p>
		/// </summary>
		public bool? SoftThreshold { get; set; }
		private bool? SoftThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A wrapper object for all the series options in specific states.</p>
		/// </summary>
		public BubbleSeriesStates States { get; set; }
		private BubbleSeriesStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A configuration object for the tooltip rendering of each singleseries. Properties are inherited from <a class="internal">#tooltip</a>.Overridable properties are <code>headerFormat</code>, <code>pointFormat</code>, <code>yDecimals</code>,<code>xDateFormat</code>, <code>yPrefix</code> and <code>ySuffix</code>. Unlike other series, ina scatter plot the series.name by default shows in the headerFormatand point.x and point.y in the pointFormat.</p>
		/// </summary>
		public BubbleSeriesTooltip Tooltip { get; set; }
		private BubbleSeriesTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When a series contains a data array that is longer than this, onlyone dimensional arrays of numbers, or two dimensional arrays withx and y values are allowed. Also, only the first point is tested,and the rest are assumed to be the same format. This saves expensivedata checking and indexing in long series. Set it to <code>0</code> disable.</p>
		/// </summary>
		public double? TurboThreshold { get; set; }
		private double? TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When <a href="#plotOptions.bubble.displayNegative">displayNegative</a> is <code>false</code>,bubbles with lower Z values are skipped. When <code>displayNegative</code>is <code>true</code> and a <a href="#plotOptions.bubble.negativeColor">negativeColor</a>is given, points with lower Z is colored.</p>
		/// </summary>
		public double? ZThreshold { get; set; }
		private double? ZThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Defines the Axis on which the zones are applied.</p>
		/// </summary>
		public string ZoneAxis { get; set; }
		private string ZoneAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to display negative sized bubbles. The threshold is givenby the <a href="#plotOptions.bubble.zThreshold">zThreshold</a> option, and negativebubbles can be visualized by setting <a href="#plotOptions.bubble.negativeColor">negativeColor</a>.</p>
		/// </summary>
		public bool? DisplayNegative { get; set; }
		private bool? DisplayNegative_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When a point&#39;s Z value is below the <a href="#plotOptions.bubble.zThreshold">zThreshold</a> setting, this color is used.</p>
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether the bubble&#39;s value should be represented by the area or thewidth of the bubble. The default, <code>area</code>, corresponds best to thehuman perception of the size of each bubble.</p>
		/// </summary>
		public BubbleSeriesSizeBy SizeBy { get; set; }
		private BubbleSeriesSizeBy SizeBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When this is true, the absolute value of z determines the size ofthe bubble. This means that with the default <code>zThreshold</code> of 0, abubble of value -1 will have the same size as a bubble of value 1,while a bubble of value 0 will have a smaller size according to<code>minSize</code>.</p>
		/// </summary>
		public bool? SizeByAbsoluteValue { get; set; }
		private bool? SizeByAbsoluteValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The minimum for the Z value range. Defaults to the highest Z valuein the data.</p>
		/// </summary>
		public double? ZMax { get; set; }
		private double? ZMax_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The minimum for the Z value range. Defaults to the lowest Z valuein the data.</p>
		/// </summary>
		public double? ZMin { get; set; }
		private double? ZMin_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the line connecting the data points.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Determines whether the series should look for the nearest pointin both dimensions or just the x-dimension when hovering the series.Defaults to <code>&#39;xy&#39;</code> for scatter series and <code>&#39;x&#39;</code> for most otherseries. If the data has duplicate x-values, it is recommended toset this to <code>&#39;xy&#39;</code> to allow hovering over all points.</p><p>Applies only to series types using nearest neighbor search (notdirect hover) for tooltip.</p>
		/// </summary>
		public BubbleSeriesFindNearestPointBy FindNearestPointBy { get; set; }
		private BubbleSeriesFindNearestPointBy FindNearestPointBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Sticky tracking of mouse events. When true, the <code>mouseOut</code> eventon a series isn&#39;t triggered until the mouse moves over another series,or out of the plot area. When false, the <code>mouseOut</code> event on a seriesis triggered when the mouse leaves the area around the series&#39; graphor markers. This also implies the tooltip. When <code>stickyTracking</code>is false and <code>tooltip.shared</code> is false, the tooltip will be hiddenwhen moving the mouse between series.</p>
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The SVG value used for the <code>stroke-linecap</code> and <code>stroke-linejoin</code>of a line graph. Round means that lines are rounded in the ends andbends.</p>
		/// </summary>
		public BubbleSeriesLinecap Linecap { get; set; }
		private BubbleSeriesLinecap Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Set the point threshold for when a series should enter boost mode.</p><p>Setting it to e.g. 2000 will cause the series to enter boost mode when thereare 2000 or more points in the series.</p><p>To disable boosting on the series, set the <code>boostThreshold</code> to 0. Setting itto 1 will force boosting.</p><p>Requires <code>modules/boost.js</code>.</p>
		/// </summary>
		public double? BoostThreshold { get; set; }
		private double? BoostThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.</p><p>The series labels currently work with series types having a<code>graph</code> or an <code>area</code>.</p><p>Requires the <code>series-label.js</code> module.</p>
		/// </summary>
		public BubbleSeriesLabel Label { get; set; }
		private BubbleSeriesLabel Label_DefaultValue { get; set; }
		 

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
		public BubbleSeriesEvents Events { get; set; }
		private BubbleSeriesEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Properties for each single point.</p>
		/// </summary>
		public BubbleSeriesPoint Point { get; set; }
		private BubbleSeriesPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When the series contains less points than the crop threshold, allpoints are drawn, even if the points fall outside the visible plotarea at the current zoom. The advantage of drawing all points (includingmarkers and columns), is that animation is performed on updates.On the other hand, when the series contains more points than thecrop threshold, the series data is cropped to only contain pointsthat fall within the plot area. The advantage of cropping away invisiblepoints is to increase performance on large series.</p>
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

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
		/// <p>Whether to connect a graph line across null points, or render a gapbetween the two points on either side of the null.</p>
		/// </summary>
		public bool? ConnectNulls { get; set; }
		private bool? ConnectNulls_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>You can set the cursor to &quot;pointer&quot; if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.</p>
		/// </summary>
		public BubbleSeriesCursor Cursor { get; set; }
		private BubbleSeriesCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A name for the dash style to use for the graph, or for some series typesthe outline of each shape. The value for the <code>dashStyle</code> include:</p><ul><li>Solid</li><li>ShortDash</li><li>ShortDot</li><li>ShortDashDot</li><li>ShortDashDotDot</li><li>Dot</li><li>Dash</li><li>LongDash</li><li>DashDot</li><li>LongDashDot</li><li>LongDashDotDot</li></ul>
		/// </summary>
		public BubbleSeriesDashStyle DashStyle { get; set; }
		private BubbleSeriesDashStyle DashStyle_DefaultValue { get; set; }
		 

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
		/// <p>Same as <a href="#accessibility.pointDescriptionFormatter">accessibility.pointDescriptionFormatter</a>, but for an individual series. Overridesthe chart wide configuration.</p>
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If no x values are given for the points in a series, <code>pointInterval</code>defines the interval of the x values. For example, if a series containsone value every decade starting from year 0, set <code>pointInterval</code> to<code>10</code>. In true <code>datetime</code> axes, the <code>pointInterval</code> is set inmilliseconds.</p><p>It can be also be combined with <code>pointIntervalUnit</code> to draw irregulartime intervals.</p>
		/// </summary>
		public double? PointInterval { get; set; }
		private double? PointInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>On datetime series, this allows for setting the<a href="#plotOptions.series.pointInterval">pointInterval</a> to irregular time units, <code>day</code>, <code>month</code> and <code>year</code>. A day is usually the same as 24 hours,but <code>pointIntervalUnit</code> also takes the DST crossover into considerationwhen dealing with local time. Combine this option with <code>pointInterval</code>to draw weeks, quarters, 6 months, 10 years etc.</p>
		/// </summary>
		public BubbleSeriesPointIntervalUnit PointIntervalUnit { get; set; }
		private BubbleSeriesPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }
		 

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
		/// <p>Whether to stack the values of each series on top of each other.Possible values are <code>null</code> to disable, <code>&quot;normal&quot;</code> to stack by value or<code>&quot;percent&quot;</code>. When stacking is enabled, data must be sorted in ascendingX order. A special stacking option is with the streamgraph series type,where the stacking option is set to <code>&quot;stream&quot;</code>.</p>
		/// </summary>
		public BubbleSeriesStacking Stacking { get; set; }
		private BubbleSeriesStacking Stacking_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to apply steps to the line. Possible values are <code>left</code>, <code>center</code>and <code>right</code>.</p>
		/// </summary>
		public BubbleSeriesStep Step { get; set; }
		private BubbleSeriesStep Step_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The threshold, also called zero level or base level. For line typeseries this is only used in conjunction with<a href="#plotOptions.series.negativeColor">negativeColor</a>.</p>
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Set the initial visibility of the series.</p>
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array defining zones within a series. Zones can be applied tothe X axis, Y axis or Z axis for bubbles, according to the <code>zoneAxis</code>option.</p><p>In styled mode, the color zones are styled with the <code>.highcharts-zone-{n}</code> class, or custom classed from the <code>className</code> option (<a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/color-zones/">viewlive demo</a>).</p>
		/// </summary>
		public BubbleSeriesZone Zones { get; set; }
		private BubbleSeriesZone Zones_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Polar charts only. Whether to connect the ends of a line series plotacross the extremes.</p>
		/// </summary>
		public bool? ConnectEnds { get; set; }
		private bool? ConnectEnds_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Type != Type_DefaultValue) h.Add("type", Highcharts.FirstCharacterToLower(Type.ToString()));
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (MinSize != MinSize_DefaultValue) h.Add("minSize",MinSize);
			if (MaxSize != MaxSize_DefaultValue) h.Add("maxSize",MaxSize);
			if (SoftThreshold != SoftThreshold_DefaultValue) h.Add("softThreshold",SoftThreshold);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (ZThreshold != ZThreshold_DefaultValue) h.Add("zThreshold",ZThreshold);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (DisplayNegative != DisplayNegative_DefaultValue) h.Add("displayNegative",DisplayNegative);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (SizeBy != SizeBy_DefaultValue) h.Add("sizeBy", Highcharts.FirstCharacterToLower(SizeBy.ToString()));
			if (SizeByAbsoluteValue != SizeByAbsoluteValue_DefaultValue) h.Add("sizeByAbsoluteValue",SizeByAbsoluteValue);
			if (ZMax != ZMax_DefaultValue) h.Add("zMax",ZMax);
			if (ZMin != ZMin_DefaultValue) h.Add("zMin",ZMin);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (FindNearestPointBy != FindNearestPointBy_DefaultValue) h.Add("findNearestPointBy", Highcharts.FirstCharacterToLower(FindNearestPointBy.ToString()));
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Linecap != Linecap_DefaultValue) h.Add("linecap", Highcharts.FirstCharacterToLower(Linecap.ToString()));
			if (BoostThreshold != BoostThreshold_DefaultValue) h.Add("boostThreshold",BoostThreshold);
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (AnimationLimit != AnimationLimit_DefaultValue) h.Add("animationLimit",AnimationLimit);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (ConnectNulls != ConnectNulls_DefaultValue) h.Add("connectNulls",ConnectNulls);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", Highcharts.FirstCharacterToLower(DashStyle.ToString()));
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (ExposeElementToA11y != ExposeElementToA11y_DefaultValue) h.Add("exposeElementToA11y",ExposeElementToA11y);
			if (GetExtremesFromAll != GetExtremesFromAll_DefaultValue) h.Add("getExtremesFromAll",GetExtremesFromAll);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); Highcharts.AddFunction("BubbleSeriesPointDescriptionFormatter.pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (PointInterval != PointInterval_DefaultValue) h.Add("pointInterval",PointInterval);
			if (PointIntervalUnit != PointIntervalUnit_DefaultValue) h.Add("pointIntervalUnit", Highcharts.FirstCharacterToLower(PointIntervalUnit.ToString()));
			if (PointPlacement != PointPlacement_DefaultValue) h.Add("pointPlacement",PointPlacement);
			if (PointStart != PointStart_DefaultValue) h.Add("pointStart",PointStart);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Stacking != Stacking_DefaultValue) h.Add("stacking", Highcharts.FirstCharacterToLower(Stacking.ToString()));
			if (Step != Step_DefaultValue) h.Add("step", Highcharts.FirstCharacterToLower(Step.ToString()));
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (Zones.IsDirty()) h.Add("zones",Zones.ToHashtable());
			if (ConnectEnds != ConnectEnds_DefaultValue) h.Add("connectEnds",ConnectEnds);
			

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
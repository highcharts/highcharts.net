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
	public partial class FunnelSeries  : Series
	{
		public FunnelSeries()
		{
			Data = Data_DefaultValue = new List<FunnelSeriesData>();
			Id = Id_DefaultValue = null;
			Index = Index_DefaultValue = null;
			LegendIndex = LegendIndex_DefaultValue = null;
			Name = Name_DefaultValue = null;
			Type = Type_DefaultValue = FunnelSeriesType.Null;
			ZIndex = ZIndex_DefaultValue = null;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Center = Center_DefaultValue = new string[] { "50%", "50%" };
			Width = Width_DefaultValue = "90%";
			NeckWidth = NeckWidth_DefaultValue = "30%";
			Height = Height_DefaultValue = "100%";
			NeckHeight = NeckHeight_DefaultValue = "25%";
			Reversed = Reversed_DefaultValue = false;
			DataLabels = DataLabels_DefaultValue = new FunnelSeriesDataLabels();
			States = States_DefaultValue = new FunnelSeriesStates();
			Clip = Clip_DefaultValue = null;
			IgnoreHiddenPoint = IgnoreHiddenPoint_DefaultValue = true;
			ShowInLegend = ShowInLegend_DefaultValue = null;
			SlicedOffset = SlicedOffset_DefaultValue = 10;
			StickyTracking = StickyTracking_DefaultValue = null;
			Tooltip = Tooltip_DefaultValue = new FunnelSeriesTooltip();
			BorderColor = BorderColor_DefaultValue = "#ffffff";
			BorderWidth = BorderWidth_DefaultValue = 1;
			Colors = Colors_DefaultValue = new List<string>();
			EndAngle = EndAngle_DefaultValue = null;
			InnerSize = InnerSize_DefaultValue = "0";
			MinSize = MinSize_DefaultValue = 80;
			StartAngle = StartAngle_DefaultValue = 0;
			Events = Events_DefaultValue = new FunnelSeriesEvents();
			Point = Point_DefaultValue = new FunnelSeriesPoint();
			Depth = Depth_DefaultValue = 0;
			Linecap = Linecap_DefaultValue = FunnelSeriesLinecap.Round;
			Label = Label_DefaultValue = new FunnelSeriesLabel();
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			ClassName = ClassName_DefaultValue = null;
			Color = Color_DefaultValue = null;
			ColorIndex = ColorIndex_DefaultValue = null;
			Cursor = Cursor_DefaultValue = FunnelSeriesCursor.Null;
			Description = Description_DefaultValue = "undefined";
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			ExposeElementToA11y = ExposeElementToA11y_DefaultValue = null;
			Keys = Keys_DefaultValue = new List<string>();
			LinkedTo = LinkedTo_DefaultValue = null;
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			Visible = Visible_DefaultValue = true;
			BoostThreshold = BoostThreshold_DefaultValue = 5000;
			LineWidth = LineWidth_DefaultValue = 2;
			Marker = Marker_DefaultValue = new FunnelSeriesMarker();
			CropThreshold = CropThreshold_DefaultValue = 300;
			SoftThreshold = SoftThreshold_DefaultValue = true;
			TurboThreshold = TurboThreshold_DefaultValue = 1000;
			FindNearestPointBy = FindNearestPointBy_DefaultValue = FunnelSeriesFindNearestPointBy.X;
			AnimationLimit = AnimationLimit_DefaultValue = null;
			ConnectNulls = ConnectNulls_DefaultValue = false;
			DashStyle = DashStyle_DefaultValue = FunnelSeriesDashStyle.Solid;
			GetExtremesFromAll = GetExtremesFromAll_DefaultValue = false;
			NegativeColor = NegativeColor_DefaultValue = "null";
			PointInterval = PointInterval_DefaultValue = 1;
			PointIntervalUnit = PointIntervalUnit_DefaultValue = FunnelSeriesPointIntervalUnit.Null;
			PointPlacement = PointPlacement_DefaultValue = new PointPlacement();
			PointStart = PointStart_DefaultValue = 0;
			Stacking = Stacking_DefaultValue = FunnelSeriesStacking.Null;
			Step = Step_DefaultValue = FunnelSeriesStep.Null;
			Threshold = Threshold_DefaultValue = 0;
			ZoneAxis = ZoneAxis_DefaultValue = "y";
			Zones = Zones_DefaultValue = new FunnelSeriesZone();
			ConnectEnds = ConnectEnds_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>An array of data points for the series. For the <code>funnel</code> series type,points can be given in the following ways:</p><ol><li><p>An array of numerical values. In this case, the numerical valueswill be interpreted as <code>y</code> options. Example:</p><pre><code class="lang-js">data: [0, 5, 3, 5]</code></pre></li><li><p>An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series&#39; <a href="#series.funnel.turboThreshold">turboThreshold</a>,this option is not available.</p><pre><code class="lang-js">data: [{    y: 3,    name: &quot;Point2&quot;,    color: &quot;#00FF00&quot;}, {    y: 1,    name: &quot;Point1&quot;,    color: &quot;#FF00FF&quot;}]</code></pre></li></ol>
		/// </summary>
		public List<FunnelSeriesData> Data { get; set; }
		private List<FunnelSeriesData> Data_DefaultValue { get; set; }
		 

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
		public FunnelSeriesType Type { get; set; }
		private FunnelSeriesType Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Define the visual z index of the series.</p>
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Initial animation is by default disabled for the funnel chart.</p>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The center of the series. By default, it is centered in the middleof the plot area, so it fills the plot area height.</p>
		/// </summary>
		public string[] Center { get; set; }
		private string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the funnel compared to the width of the plot area,or the pixel width if it is a number.</p>
		/// </summary>
		public string Width { get; set; }
		private string Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the neck, the lower part of the funnel. A number definespixel width, a percentage string defines a percentage of the plotarea width.</p>
		/// </summary>
		public string NeckWidth { get; set; }
		private string NeckWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The height of the funnel or pyramid. If it is a number it definesthe pixel height, if it is a percentage string it is the percentageof the plot area height.</p>
		/// </summary>
		public string Height { get; set; }
		private string Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The height of the neck, the lower part of the funnel. A number definespixel width, a percentage string defines a percentage of the plotarea height.</p>
		/// </summary>
		public string NeckHeight { get; set; }
		private string NeckHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A reversed funnel has the widest area down. A reversed funnel withno neck width and neck height is a pyramid.</p>
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the series data labels, appearing next to each datapoint.</p><p>In styled mode, the data labels can be styled wtih the <code>.highcharts-data-label-box</code> and <code>.highcharts-data-label</code> class names (<a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/series-datalabels">see example</a>).</p>
		/// </summary>
		public FunnelSeriesDataLabels DataLabels { get; set; }
		private FunnelSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the series states.</p>
		/// </summary>
		public FunnelSeriesStates States { get; set; }
		private FunnelSeriesStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Clip { get; set; }
		private bool? Clip_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Equivalent to <a href="#chart.ignoreHiddenSeries">chart.ignoreHiddenSeries</a>,this option tells whether the series shall be redrawn as if thehidden point were <code>null</code>.</p><p>The default value changed from <code>false</code> to <code>true</code> with Highcharts3.0.</p>
		/// </summary>
		public bool? IgnoreHiddenPoint { get; set; }
		private bool? IgnoreHiddenPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to display this particular series or series type in thelegend. Since 2.1, pies are not shown in the legend by default.</p>
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If a point is sliced, moved out from the center, how many pixelsshould it be moved?.</p>
		/// </summary>
		public double? SlicedOffset { get; set; }
		private double? SlicedOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Sticky tracking of mouse events. When true, the <code>mouseOut</code> eventon a series isn&#39;t triggered until the mouse moves over another series,or out of the plot area. When false, the <code>mouseOut</code> event on aseries is triggered when the mouse leaves the area around the series&#39;graph or markers. This also implies the tooltip. When <code>stickyTracking</code>is false and <code>tooltip.shared</code> is false, the tooltip will be hiddenwhen moving the mouse between series.</p>
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A configuration object for the tooltip rendering of each single series.Properties are inherited from <a href="#tooltip">tooltip</a>, but only thefollowing properties can be defined on a series level.</p>
		/// </summary>
		public FunnelSeriesTooltip Tooltip { get; set; }
		private FunnelSeriesTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the border surrounding each slice. When <code>null</code>, theborder takes the same color as the slice fill. This can be usedtogether with a <code>borderWidth</code> to fill drawing gaps created by antialiazingartefacts in borderless pies.</p><p>In styled mode, the border stroke is given in the <code>.highcharts-point</code> class.</p>
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the border surrounding each slice.</p><p>When setting the border width to 0, there may be small gaps betweenthe slices due to SVG antialiasing artefacts. To work around this,keep the border width at 0.5 or 1, but set the <code>borderColor</code> to<code>null</code> instead.</p><p>In styled mode, the border stroke width is given in the <code>.highcharts-point</code> class.</p>
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A series specific or series type specific color set to use insteadof the global <a href="#colors">colors</a>.</p>
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The end angle of the pie in degrees where 0 is top and 90 is right.Defaults to <code>startAngle</code> plus 360.</p>
		/// </summary>
		public double? EndAngle { get; set; }
		private double? EndAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The size of the inner diameter for the pie. A size greater than 0renders a donut chart. Can be a percentage or pixel value. Percentagesare relative to the pie size. Pixel values are given as integers.</p><p>Note: in Highcharts &lt; 4.1.2, the percentage was relative to the plotarea, not the pie size.</p>
		/// </summary>
		public string InnerSize { get; set; }
		private string InnerSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The minimum size for a pie in response to auto margins. The pie willtry to shrink to make room for data labels in side the plot area, but only to this size.</p>
		/// </summary>
		public double? MinSize { get; set; }
		private double? MinSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The start angle of the pie slices in degrees where 0 is top and 90right.</p>
		/// </summary>
		public double? StartAngle { get; set; }
		private double? StartAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>General event handlers for the series items. These event hooks can alsobe attached to the series at run time using the <code>Highcharts.addEvent</code>function.</p>
		/// </summary>
		public FunnelSeriesEvents Events { get; set; }
		private FunnelSeriesEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Properties for each single point.</p>
		/// </summary>
		public FunnelSeriesPoint Point { get; set; }
		private FunnelSeriesPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The thickness of a 3D pie. Requires <code>highcharts-3d.js</code></p>
		/// </summary>
		public double? Depth { get; set; }
		private double? Depth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The SVG value used for the <code>stroke-linecap</code> and <code>stroke-linejoin</code>of a line graph. Round means that lines are rounded in the ends andbends.</p>
		/// </summary>
		public FunnelSeriesLinecap Linecap { get; set; }
		private FunnelSeriesLinecap Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.</p><p>The series labels currently work with series types having a<code>graph</code> or an <code>area</code>.</p><p>Requires the <code>series-label.js</code> module.</p>
		/// </summary>
		public FunnelSeriesLabel Label { get; set; }
		private FunnelSeriesLabel Label_DefaultValue { get; set; }
		 

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
		public FunnelSeriesCursor Cursor { get; set; }
		private FunnelSeriesCursor Cursor_DefaultValue { get; set; }
		 

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
		/// <p>Set the point threshold for when a series should enter boost mode.</p><p>Setting it to e.g. 2000 will cause the series to enter boost mode when thereare 2000 or more points in the series.</p><p>To disable boosting on the series, set the <code>boostThreshold</code> to 0. Setting itto 1 will force boosting.</p><p>Requires <code>modules/boost.js</code>.</p>
		/// </summary>
		public double? BoostThreshold { get; set; }
		private double? BoostThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Pixel with of the graph line.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the point markers of line-like series. Properties like<code>fillColor</code>, <code>lineColor</code> and <code>lineWidth</code> define the visual appearanceof the markers. Other series types, like column series, don&#39;t havemarkers, but have visual options on the series level instead.</p><p>In styled mode, the markers can be styled with the <code>.highcharts-point</code>,<code>.highcharts-point-hover</code> and <code>.highcharts-point-select</code>class names.</p>
		/// </summary>
		public FunnelSeriesMarker Marker { get; set; }
		private FunnelSeriesMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When the series contains less points than the crop threshold, allpoints are drawn, even if the points fall outside the visible plotarea at the current zoom. The advantage of drawing all points (includingmarkers and columns), is that animation is performed on updates.On the other hand, when the series contains more points than thecrop threshold, the series data is cropped to only contain pointsthat fall within the plot area. The advantage of cropping away invisiblepoints is to increase performance on large series.</p>
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When this is true, the series will not cause the Y axis to crossthe zero plane (or <a href="#plotOptions.series.threshold">threshold</a> option)unless the data actually crosses the plane.</p><p>For example, if <code>softThreshold</code> is <code>false</code>, a series of 0, 1, 2,3 will make the Y axis show negative values according to the <code>minPadding</code>option. If <code>softThreshold</code> is <code>true</code>, the Y axis starts at 0.</p>
		/// </summary>
		public bool? SoftThreshold { get; set; }
		private bool? SoftThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When a series contains a data array that is longer than this, onlyone dimensional arrays of numbers, or two dimensional arrays withx and y values are allowed. Also, only the first point is tested,and the rest are assumed to be the same format. This saves expensivedata checking and indexing in long series. Set it to <code>0</code> disable.</p>
		/// </summary>
		public double? TurboThreshold { get; set; }
		private double? TurboThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Determines whether the series should look for the nearest pointin both dimensions or just the x-dimension when hovering the series.Defaults to <code>&#39;xy&#39;</code> for scatter series and <code>&#39;x&#39;</code> for most otherseries. If the data has duplicate x-values, it is recommended toset this to <code>&#39;xy&#39;</code> to allow hovering over all points.</p><p>Applies only to series types using nearest neighbor search (notdirect hover) for tooltip.</p>
		/// </summary>
		public FunnelSeriesFindNearestPointBy FindNearestPointBy { get; set; }
		private FunnelSeriesFindNearestPointBy FindNearestPointBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For some series, there is a limit that shuts down initial animationby default when the total number of points in the chart is too high.For example, for a column chart and its derivatives, animation doesn&#39;trun if there is more than 250 points totally. To disable this cap, set<code>animationLimit</code> to <code>Infinity</code>.</p>
		/// </summary>
		public double? AnimationLimit { get; set; }
		private double? AnimationLimit_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to connect a graph line across null points, or render a gapbetween the two points on either side of the null.</p>
		/// </summary>
		public bool? ConnectNulls { get; set; }
		private bool? ConnectNulls_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A name for the dash style to use for the graph, or for some series typesthe outline of each shape. The value for the <code>dashStyle</code> include:</p><ul><li>Solid</li><li>ShortDash</li><li>ShortDot</li><li>ShortDashDot</li><li>ShortDashDotDot</li><li>Dot</li><li>Dash</li><li>LongDash</li><li>DashDot</li><li>LongDashDot</li><li>LongDashDotDot</li></ul>
		/// </summary>
		public FunnelSeriesDashStyle DashStyle { get; set; }
		private FunnelSeriesDashStyle DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to use the Y extremes of the total chart width or only thezoomed area when zooming in on parts of the X axis. By default, theY axis adjusts to the min and max of the visible data. Cartesianseries only.</p>
		/// </summary>
		public bool? GetExtremesFromAll { get; set; }
		private bool? GetExtremesFromAll_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color for the parts of the graph or points that are below the<a href="#plotOptions.series.threshold">threshold</a>.</p>
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If no x values are given for the points in a series, <code>pointInterval</code>defines the interval of the x values. For example, if a series containsone value every decade starting from year 0, set <code>pointInterval</code> to<code>10</code>. In true <code>datetime</code> axes, the <code>pointInterval</code> is set inmilliseconds.</p><p>It can be also be combined with <code>pointIntervalUnit</code> to draw irregulartime intervals.</p>
		/// </summary>
		public double? PointInterval { get; set; }
		private double? PointInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>On datetime series, this allows for setting the<a href="#plotOptions.series.pointInterval">pointInterval</a> to irregular time units, <code>day</code>, <code>month</code> and <code>year</code>. A day is usually the same as 24 hours,but <code>pointIntervalUnit</code> also takes the DST crossover into considerationwhen dealing with local time. Combine this option with <code>pointInterval</code>to draw weeks, quarters, 6 months, 10 years etc.</p>
		/// </summary>
		public FunnelSeriesPointIntervalUnit PointIntervalUnit { get; set; }
		private FunnelSeriesPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }
		 

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
		/// <p>Whether to stack the values of each series on top of each other.Possible values are <code>null</code> to disable, <code>&quot;normal&quot;</code> to stack by value or<code>&quot;percent&quot;</code>. When stacking is enabled, data must be sorted in ascendingX order. A special stacking option is with the streamgraph series type,where the stacking option is set to <code>&quot;stream&quot;</code>.</p>
		/// </summary>
		public FunnelSeriesStacking Stacking { get; set; }
		private FunnelSeriesStacking Stacking_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to apply steps to the line. Possible values are <code>left</code>, <code>center</code>and <code>right</code>.</p>
		/// </summary>
		public FunnelSeriesStep Step { get; set; }
		private FunnelSeriesStep Step_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The threshold, also called zero level or base level. For line typeseries this is only used in conjunction with<a href="#plotOptions.series.negativeColor">negativeColor</a>.</p>
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Defines the Axis on which the zones are applied.</p>
		/// </summary>
		public string ZoneAxis { get; set; }
		private string ZoneAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array defining zones within a series. Zones can be applied tothe X axis, Y axis or Z axis for bubbles, according to the <code>zoneAxis</code>option.</p><p>In styled mode, the color zones are styled with the <code>.highcharts-zone-{n}</code> class, or custom classed from the <code>className</code> option (<a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/color-zones/">viewlive demo</a>).</p>
		/// </summary>
		public FunnelSeriesZone Zones { get; set; }
		private FunnelSeriesZone Zones_DefaultValue { get; set; }
		 

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
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (NeckWidth != NeckWidth_DefaultValue) h.Add("neckWidth",NeckWidth);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (NeckHeight != NeckHeight_DefaultValue) h.Add("neckHeight",NeckHeight);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Clip != Clip_DefaultValue) h.Add("clip",Clip);
			if (IgnoreHiddenPoint != IgnoreHiddenPoint_DefaultValue) h.Add("ignoreHiddenPoint",IgnoreHiddenPoint);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SlicedOffset != SlicedOffset_DefaultValue) h.Add("slicedOffset",SlicedOffset);
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (EndAngle != EndAngle_DefaultValue) h.Add("endAngle",EndAngle);
			if (InnerSize != InnerSize_DefaultValue) h.Add("innerSize",InnerSize);
			if (MinSize != MinSize_DefaultValue) h.Add("minSize",MinSize);
			if (StartAngle != StartAngle_DefaultValue) h.Add("startAngle",StartAngle);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (Depth != Depth_DefaultValue) h.Add("depth",Depth);
			if (Linecap != Linecap_DefaultValue) h.Add("linecap", Highcharts.FirstCharacterToLower(Linecap.ToString()));
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (ExposeElementToA11y != ExposeElementToA11y_DefaultValue) h.Add("exposeElementToA11y",ExposeElementToA11y);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); Highcharts.AddFunction("FunnelSeriesPointDescriptionFormatter.pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (BoostThreshold != BoostThreshold_DefaultValue) h.Add("boostThreshold",BoostThreshold);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (SoftThreshold != SoftThreshold_DefaultValue) h.Add("softThreshold",SoftThreshold);
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (FindNearestPointBy != FindNearestPointBy_DefaultValue) h.Add("findNearestPointBy", Highcharts.FirstCharacterToLower(FindNearestPointBy.ToString()));
			if (AnimationLimit != AnimationLimit_DefaultValue) h.Add("animationLimit",AnimationLimit);
			if (ConnectNulls != ConnectNulls_DefaultValue) h.Add("connectNulls",ConnectNulls);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", Highcharts.FirstCharacterToLower(DashStyle.ToString()));
			if (GetExtremesFromAll != GetExtremesFromAll_DefaultValue) h.Add("getExtremesFromAll",GetExtremesFromAll);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (PointInterval != PointInterval_DefaultValue) h.Add("pointInterval",PointInterval);
			if (PointIntervalUnit != PointIntervalUnit_DefaultValue) h.Add("pointIntervalUnit", Highcharts.FirstCharacterToLower(PointIntervalUnit.ToString()));
			if (PointPlacement != PointPlacement_DefaultValue) h.Add("pointPlacement",PointPlacement);
			if (PointStart != PointStart_DefaultValue) h.Add("pointStart",PointStart);
			if (Stacking != Stacking_DefaultValue) h.Add("stacking", Highcharts.FirstCharacterToLower(Stacking.ToString()));
			if (Step != Step_DefaultValue) h.Add("step", Highcharts.FirstCharacterToLower(Step.ToString()));
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
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
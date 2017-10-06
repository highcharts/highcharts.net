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
	public partial class PlotOptionsFlags  : BaseObject
	{
		public PlotOptionsFlags()
		{
			PointRange = PointRange_DefaultValue = "undefined";
			Shape = Shape_DefaultValue = PlotOptionsFlagsShape.Flag;
			StackDistance = StackDistance_DefaultValue = 12;
			TextAlign = TextAlign_DefaultValue = PlotOptionsFlagsTextAlign.Center;
			Tooltip = Tooltip_DefaultValue = new PlotOptionsFlagsTooltip();
			Y = Y_DefaultValue = -30;
			FillColor = FillColor_DefaultValue = null;
			LineWidth = LineWidth_DefaultValue = 1;
			States = States_DefaultValue = new PlotOptionsFlagsStates();
			Style = Style_DefaultValue = new Hashtable();
			OnSeries = OnSeries_DefaultValue = "undefined";
			OnKey = OnKey_DefaultValue = PlotOptionsFlagsOnKey.Y;
			Title = Title_DefaultValue = "'A'";
			UseHTML = UseHTML_DefaultValue = false;
			LineColor = LineColor_DefaultValue = "#000000";
			Crisp = Crisp_DefaultValue = true;
			GroupPadding = GroupPadding_DefaultValue = 0.2;
			MinPointLength = MinPointLength_DefaultValue = 0;
			CropThreshold = CropThreshold_DefaultValue = 50;
			DataLabels = DataLabels_DefaultValue = new PlotOptionsFlagsDataLabels();
			SoftThreshold = SoftThreshold_DefaultValue = null;
			StickyTracking = StickyTracking_DefaultValue = null;
			Colors = Colors_DefaultValue = new List<string>();
			Grouping = Grouping_DefaultValue = true;
			MaxPointWidth = MaxPointWidth_DefaultValue = null;
			BoostThreshold = BoostThreshold_DefaultValue = 5000;
			Label = Label_DefaultValue = new PlotOptionsFlagsLabel();
			NavigatorOptions = NavigatorOptions_DefaultValue = null;
			ShowInNavigator = ShowInNavigator_DefaultValue = null;
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			Events = Events_DefaultValue = new PlotOptionsFlagsEvents();
			Point = Point_DefaultValue = new PlotOptionsFlagsPoint();
			FindNearestPointBy = FindNearestPointBy_DefaultValue = PlotOptionsFlagsFindNearestPointBy.X;
			AnimationLimit = AnimationLimit_DefaultValue = null;
			ClassName = ClassName_DefaultValue = null;
			Color = Color_DefaultValue = null;
			ColorIndex = ColorIndex_DefaultValue = null;
			Cursor = Cursor_DefaultValue = PlotOptionsFlagsCursor.Null;
			Description = Description_DefaultValue = "undefined";
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			ExposeElementToA11y = ExposeElementToA11y_DefaultValue = null;
			GetExtremesFromAll = GetExtremesFromAll_DefaultValue = false;
			Keys = Keys_DefaultValue = new List<string>();
			LinkedTo = LinkedTo_DefaultValue = null;
			NegativeColor = NegativeColor_DefaultValue = "null";
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = null;
			PointInterval = PointInterval_DefaultValue = 1;
			PointIntervalUnit = PointIntervalUnit_DefaultValue = PlotOptionsFlagsPointIntervalUnit.Null;
			PointPlacement = PointPlacement_DefaultValue = new PointPlacement();
			PointStart = PointStart_DefaultValue = 0;
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShowInLegend = ShowInLegend_DefaultValue = true;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			Stacking = Stacking_DefaultValue = PlotOptionsFlagsStacking.Null;
			Visible = Visible_DefaultValue = true;
			ZoneAxis = ZoneAxis_DefaultValue = "y";
			Zones = Zones_DefaultValue = new PlotOptionsFlagsZone();
			Compare = Compare_DefaultValue = "undefined";
			CompareStart = CompareStart_DefaultValue = null;
			CompareBase = CompareBase_DefaultValue = PlotOptionsFlagsCompareBase.Min;
			
		}	
		

		/// <summary>
		/// <p>The id of the series that the flags should be drawn on. If no idis given, the flags are drawn on the x axis.</p>
		/// </summary>
		public string PointRange { get; set; }
		private string PointRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The shape of the marker. Can be one of &quot;flag&quot;, &quot;circlepin&quot;, &quot;squarepin&quot;,or an image on the format <code>url(/path-to-image.jpg)</code>. Individualshapes can also be set for each point.</p>
		/// </summary>
		public PlotOptionsFlagsShape Shape { get; set; }
		private PlotOptionsFlagsShape Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When multiple flags in the same series fall on the same value, thisnumber determines the vertical offset between them.</p>
		/// </summary>
		public double? StackDistance { get; set; }
		private double? StackDistance_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Text alignment for the text inside the flag.</p>
		/// </summary>
		public PlotOptionsFlagsTextAlign TextAlign { get; set; }
		private PlotOptionsFlagsTextAlign TextAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Specific tooltip options for flag series. Flag series tooltips aredifferent from most other types in that a flag doesn&#39;t have a datavalue, so the tooltip rather displays the <code>text</code> option for eachpoint.</p>
		/// </summary>
		public PlotOptionsFlagsTooltip Tooltip { get; set; }
		private PlotOptionsFlagsTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The y position of the top left corner of the flag relative to eitherthe series (if onSeries is defined), or the x axis. Defaults to<code>-30</code>.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The fill color for the flags.</p>
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel width of the flag&#39;s line/border.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A wrapper object for all the series options in specific states.</p>
		/// </summary>
		public PlotOptionsFlagsStates States { get; set; }
		private PlotOptionsFlagsStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The text styles of the flag.</p><p>In styled mode, the styles are set in the <code>.highcharts-flag-series .highcharts-point</code> rule.</p>
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The id of the series that the flags should be drawn on. If no idis given, the flags are drawn on the x axis.</p>
		/// </summary>
		public string OnSeries { get; set; }
		private string OnSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>In case the flag is placed on a series, on what point key to placeit. Line and columns have one key, <code>y</code>. In range or OHLC-type series,however, the flag can optionally be placed on the <code>open</code>, <code>high</code>, <code>low</code> or <code>close</code> key.</p>
		/// </summary>
		public PlotOptionsFlagsOnKey OnKey { get; set; }
		private PlotOptionsFlagsOnKey OnKey_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The text to display on each flag. This can be defined on series level, or individually for each point. Defaults to <code>&quot;A&quot;</code>.</p>
		/// </summary>
		public string Title { get; set; }
		private string Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to use HTML to render the flag texts. Using HTML allows foradvanced formatting, images and reliable bi-directional text rendering.Note that exported images won&#39;t respect the HTML, and that HTMLwon&#39;t respect Z-index settings.</p>
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the line/border of the flag.</p><p>In styled mode, the stroke is set in the <code>.highcharts-flag-series.highcharts-point</code> rule.</p>
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When true, each column edge is rounded to its nearest pixel in orderto render sharp on screen. In some cases, when there are a lot ofdensely packed columns, this leads to visible difference in columnwidths or distance between columns. In these cases, setting <code>crisp</code>to <code>false</code> may look better, even though each column is renderedblurry.</p>
		/// </summary>
		public bool? Crisp { get; set; }
		private bool? Crisp_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Padding between each value groups, in x axis units.</p>
		/// </summary>
		public double? GroupPadding { get; set; }
		private double? GroupPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The minimal height for a column or width for a bar. By default,0 values are not shown. To visualize a 0 (or close to zero) point,set the minimal point length to a pixel value like 3. In stackedcolumn charts, minPointLength might not be respected for tightlypacked values.</p>
		/// </summary>
		public double? MinPointLength { get; set; }
		private double? MinPointLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When the series contains less points than the crop threshold, allpoints are drawn, event if the points fall outside the visible plotarea at the current zoom. The advantage of drawing all points (includingmarkers and columns), is that animation is performed on updates.On the other hand, when the series contains more points than thecrop threshold, the series data is cropped to only contain pointsthat fall within the plot area. The advantage of cropping away invisiblepoints is to increase performance on large series. .</p>
		/// </summary>
		public double? CropThreshold { get; set; }
		private double? CropThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the series data labels, appearing next to each datapoint.</p><p>In styled mode, the data labels can be styled wtih the <code>.highcharts-data-label-box</code> and <code>.highcharts-data-label</code> class names (<a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/series-datalabels">see example</a>).</p>
		/// </summary>
		public PlotOptionsFlagsDataLabels DataLabels { get; set; }
		private PlotOptionsFlagsDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When this is true, the series will not cause the Y axis to crossthe zero plane (or <a href="#plotOptions.series.threshold">threshold</a> option)unless the data actually crosses the plane.</p><p>For example, if <code>softThreshold</code> is <code>false</code>, a series of 0, 1, 2,3 will make the Y axis show negative values according to the <code>minPadding</code>option. If <code>softThreshold</code> is <code>true</code>, the Y axis starts at 0.</p>
		/// </summary>
		public bool? SoftThreshold { get; set; }
		private bool? SoftThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Sticky tracking of mouse events. When true, the <code>mouseOut</code> eventon a series isn&#39;t triggered until the mouse moves over another series,or out of the plot area. When false, the <code>mouseOut</code> event on aseries is triggered when the mouse leaves the area around the series&#39;graph or markers. This also implies the tooltip when not shared. When<code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the tooltip willbe hidden when moving the mouse between series. Defaults to true for lineand area type series, but to false for columns, pies etc.</p>
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A series specific or series type specific color set to apply insteadof the global <a href="#colors">colors</a> when <a href="#plotOptions.column.colorByPoint">colorByPoint</a> is true.</p>
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to group non-stacked columns or to let them render independentof each other. Non-grouped columns will be laid out individuallyand overlap each other.</p>
		/// </summary>
		public bool? Grouping { get; set; }
		private bool? Grouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The maximum allowed pixel width for a column, translated to the heightof a bar in a bar chart. This prevents the columns from becomingtoo wide when there is a small number of points in the chart.</p>
		/// </summary>
		public double? MaxPointWidth { get; set; }
		private double? MaxPointWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Set the point threshold for when a series should enter boost mode.</p><p>Setting it to e.g. 2000 will cause the series to enter boost modewhen there are 2000 or more points in the series.</p><p>Requires <code>modules/boost.js</code>.</p>
		/// </summary>
		public double? BoostThreshold { get; set; }
		private double? BoostThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.</p><p>The series labels currently work with series types having a<code>graph</code> or an <code>area</code>.</p><p>Requires the <code>series-label.js</code> module.</p>
		/// </summary>
		public PlotOptionsFlagsLabel Label { get; set; }
		private PlotOptionsFlagsLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the corresponding navigator series if <code>showInNavigator</code>is <code>true</code> for this series. Available options are the same as anyseries, documented at <a href="#plotOptions.series">plotOptions</a> and<a href="#series">series</a>.</p><p>These options are merged with options in <a href="#navigator.series">navigator.series</a>, and will take precedence if the same option is defined bothplaces.</p>
		/// </summary>
		public Object NavigatorOptions { get; set; }
		private Object NavigatorOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether or not to show the series in the navigator. Takes precedenceover <a href="#navigator.baseSeries">navigator.baseSeries</a> if defined.</p>
		/// </summary>
		public bool? ShowInNavigator { get; set; }
		private bool? ShowInNavigator_DefaultValue { get; set; }
		 

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
		/// <p>General event handlers for the series items. These event hooks can alsobe attached to the series at run time using the <code>Highcharts.addEvent</code>function.</p>
		/// </summary>
		public PlotOptionsFlagsEvents Events { get; set; }
		private PlotOptionsFlagsEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Properties for each single point.</p>
		/// </summary>
		public PlotOptionsFlagsPoint Point { get; set; }
		private PlotOptionsFlagsPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Determines whether the series should look for the nearest pointin both dimensions or just the x-dimension when hovering the series.Defaults to <code>&#39;xy&#39;</code> for scatter series and <code>&#39;x&#39;</code> for most otherseries. If the data has duplicate x-values, it is recommended toset this to <code>&#39;xy&#39;</code> to allow hovering over all points.</p><p>Applies only to series types using nearest neighbor search (notdirect hover) for tooltip.</p>
		/// </summary>
		public PlotOptionsFlagsFindNearestPointBy FindNearestPointBy { get; set; }
		private PlotOptionsFlagsFindNearestPointBy FindNearestPointBy_DefaultValue { get; set; }
		 

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
		public PlotOptionsFlagsCursor Cursor { get; set; }
		private PlotOptionsFlagsCursor Cursor_DefaultValue { get; set; }
		 

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
		public Array.<String> Keys { get; set; }
		private Array.<String> Keys_DefaultValue { get; set; }
		 

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
		public function PointDescriptionFormatter { get; set; }
		private function PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If no x values are given for the points in a series, <code>pointInterval</code>defines the interval of the x values. For example, if a series containsone value every decade starting from year 0, set <code>pointInterval</code> to<code>10</code>. In true <code>datetime</code> axes, the <code>pointInterval</code> is set inmilliseconds.</p><p>It can be also be combined with <code>pointIntervalUnit</code> to draw irregulartime intervals.</p>
		/// </summary>
		public double? PointInterval { get; set; }
		private double? PointInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>On datetime series, this allows for setting the<a href="#plotOptions.series.pointInterval">pointInterval</a> to irregular time units, <code>day</code>, <code>month</code> and <code>year</code>. A day is usually the same as 24 hours,but <code>pointIntervalUnit</code> also takes the DST crossover into considerationwhen dealing with local time. Combine this option with <code>pointInterval</code>to draw weeks, quarters, 6 months, 10 years etc.</p>
		/// </summary>
		public PlotOptionsFlagsPointIntervalUnit PointIntervalUnit { get; set; }
		private PlotOptionsFlagsPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }
		 

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
		public PlotOptionsFlagsStacking Stacking { get; set; }
		private PlotOptionsFlagsStacking Stacking_DefaultValue { get; set; }
		 

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
		/// <p>An array defining zones within a series. Zones can be applied tothe X axis, Y axis or Z axis for bubbles, according to the <code>zoneAxis</code>option.</p><p>In styled mode, the color zones are styled with the <code>.highcharts-zone-{n}</code> class, or custom classed from the <code>className</code> option (<a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/color-zones/">viewlive demo</a>).</p>
		/// </summary>
		public PlotOptionsFlagsZone Zones { get; set; }
		private PlotOptionsFlagsZone Zones_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Compare the values of the series against the first non-null, non-zero value in the visible range. The y axis will show percentageor absolute change depending on whether <code>compare</code> is set to <code>&quot;percent&quot;</code>or <code>&quot;value&quot;</code>. When this is applied to multiple series, it allowscomparing the development of the series against each other.</p>
		/// </summary>
		public string Compare { get; set; }
		private string Compare_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Defines if comparisson should start from the first point within the visiblerange or should start from the first point <b>before</b> the range.In other words, this flag determines if first point within the visible rangewill have 0% (base) or should have been already calculated according to theprevious point.</p>
		/// </summary>
		public bool? CompareStart { get; set; }
		private bool? CompareStart_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When <a href="#plotOptions.series.compare">compare</a> is <code>percent</code>, this optiondictates whether to use 0 or 100 as the base of comparison.</p>
		/// </summary>
		public PlotOptionsFlagsCompareBase CompareBase { get; set; }
		private PlotOptionsFlagsCompareBase CompareBase_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (PointRange != PointRange_DefaultValue) h.Add("pointRange",PointRange);
			if (Shape != Shape_DefaultValue) h.Add("shape", Highstock.FirstCharacterToLower(Shape.ToString()));
			if (StackDistance != StackDistance_DefaultValue) h.Add("stackDistance",StackDistance);
			if (TextAlign != TextAlign_DefaultValue) h.Add("textAlign", Highstock.FirstCharacterToLower(TextAlign.ToString()));
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (OnSeries != OnSeries_DefaultValue) h.Add("onSeries",OnSeries);
			if (OnKey != OnKey_DefaultValue) h.Add("onKey", Highstock.FirstCharacterToLower(OnKey.ToString()));
			if (Title != Title_DefaultValue) h.Add("title",Title);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (Crisp != Crisp_DefaultValue) h.Add("crisp",Crisp);
			if (GroupPadding != GroupPadding_DefaultValue) h.Add("groupPadding",GroupPadding);
			if (MinPointLength != MinPointLength_DefaultValue) h.Add("minPointLength",MinPointLength);
			if (CropThreshold != CropThreshold_DefaultValue) h.Add("cropThreshold",CropThreshold);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (SoftThreshold != SoftThreshold_DefaultValue) h.Add("softThreshold",SoftThreshold);
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (Grouping != Grouping_DefaultValue) h.Add("grouping",Grouping);
			if (MaxPointWidth != MaxPointWidth_DefaultValue) h.Add("maxPointWidth",MaxPointWidth);
			if (BoostThreshold != BoostThreshold_DefaultValue) h.Add("boostThreshold",BoostThreshold);
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (NavigatorOptions != NavigatorOptions_DefaultValue) h.Add("navigatorOptions",NavigatorOptions);
			if (ShowInNavigator != ShowInNavigator_DefaultValue) h.Add("showInNavigator",ShowInNavigator);
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (FindNearestPointBy != FindNearestPointBy_DefaultValue) h.Add("findNearestPointBy", Highstock.FirstCharacterToLower(FindNearestPointBy.ToString()));
			if (AnimationLimit != AnimationLimit_DefaultValue) h.Add("animationLimit",AnimationLimit);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highstock.FirstCharacterToLower(Cursor.ToString()));
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (ExposeElementToA11y != ExposeElementToA11y_DefaultValue) h.Add("exposeElementToA11y",ExposeElementToA11y);
			if (GetExtremesFromAll != GetExtremesFromAll_DefaultValue) h.Add("getExtremesFromAll",GetExtremesFromAll);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) h.Add("pointDescriptionFormatter",PointDescriptionFormatter);
			if (PointInterval != PointInterval_DefaultValue) h.Add("pointInterval",PointInterval);
			if (PointIntervalUnit != PointIntervalUnit_DefaultValue) h.Add("pointIntervalUnit", Highstock.FirstCharacterToLower(PointIntervalUnit.ToString()));
			if (PointPlacement.IsDirty())
				if (PointPlacement.Value.HasValue)
					h.Add("pointPlacement", PointPlacement.Value);
				else
					h.Add("pointPlacement", PointPlacement.ToJSON());
			if (PointStart != PointStart_DefaultValue) h.Add("pointStart",PointStart);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow.IsDirty()) h.Add("shadow",Shadow.ToHashtable());
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Stacking != Stacking_DefaultValue) h.Add("stacking", Highstock.FirstCharacterToLower(Stacking.ToString()));
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (ZoneAxis != ZoneAxis_DefaultValue) h.Add("zoneAxis",ZoneAxis);
			if (Zones.IsDirty()) h.Add("zones",Zones.ToHashtable());
			if (Compare != Compare_DefaultValue) h.Add("compare",Compare);
			if (CompareStart != CompareStart_DefaultValue) h.Add("compareStart",CompareStart);
			if (CompareBase != CompareBase_DefaultValue) h.Add("compareBase", Highstock.FirstCharacterToLower(CompareBase.ToString()));
			

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
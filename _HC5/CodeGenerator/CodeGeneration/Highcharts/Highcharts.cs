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
	public partial class Highcharts  : BaseObject
	{
		public Highcharts()
		{
			Accessibility = Accessibility_DefaultValue = new Accessibility();
			Chart = Chart_DefaultValue = new Chart();
			Colors = Colors_DefaultValue = new List<string>();
			Credits = Credits_DefaultValue = new Credits();
			Data = Data_DefaultValue = new Data();
			Defs = Defs_DefaultValue = null;
			Drilldown = Drilldown_DefaultValue = new Drilldown();
			Exporting = Exporting_DefaultValue = new Exporting();
			Global = Global_DefaultValue = new Global();
			Labels = Labels_DefaultValue = new Labels();
			Lang = Lang_DefaultValue = new Lang();
			Legend = Legend_DefaultValue = new Legend();
			Loading = Loading_DefaultValue = new Loading();
			Navigation = Navigation_DefaultValue = new Navigation();
			NoData = NoData_DefaultValue = new NoData();
			Pane = Pane_DefaultValue = new Pane();
			PlotOptions = PlotOptions_DefaultValue = new PlotOptions();
			Responsive = Responsive_DefaultValue = new Responsive();
			Series = Series_DefaultValue = new List<Series>();
			AreaSeries = AreaSeries_DefaultValue = new AreaSeries();
			ArearangeSeries = ArearangeSeries_DefaultValue = new ArearangeSeries();
			AreasplineSeries = AreasplineSeries_DefaultValue = new AreasplineSeries();
			AreasplinerangeSeries = AreasplinerangeSeries_DefaultValue = new AreasplinerangeSeries();
			BarSeries = BarSeries_DefaultValue = new BarSeries();
			BoxplotSeries = BoxplotSeries_DefaultValue = new BoxplotSeries();
			BubbleSeries = BubbleSeries_DefaultValue = new BubbleSeries();
			ColumnSeries = ColumnSeries_DefaultValue = new ColumnSeries();
			ColumnrangeSeries = ColumnrangeSeries_DefaultValue = new ColumnrangeSeries();
			ErrorbarSeries = ErrorbarSeries_DefaultValue = new ErrorbarSeries();
			FunnelSeries = FunnelSeries_DefaultValue = new FunnelSeries();
			GaugeSeries = GaugeSeries_DefaultValue = new GaugeSeries();
			HeatmapSeries = HeatmapSeries_DefaultValue = new HeatmapSeries();
			LineSeries = LineSeries_DefaultValue = new LineSeries();
			PieSeries = PieSeries_DefaultValue = new PieSeries();
			PolygonSeries = PolygonSeries_DefaultValue = new PolygonSeries();
			PyramidSeries = PyramidSeries_DefaultValue = new PyramidSeries();
			ScatterSeries = ScatterSeries_DefaultValue = new ScatterSeries();
			SolidgaugeSeries = SolidgaugeSeries_DefaultValue = new SolidgaugeSeries();
			SplineSeries = SplineSeries_DefaultValue = new SplineSeries();
			TreemapSeries = TreemapSeries_DefaultValue = new TreemapSeries();
			WaterfallSeries = WaterfallSeries_DefaultValue = new WaterfallSeries();
			Subtitle = Subtitle_DefaultValue = new Subtitle();
			Title = Title_DefaultValue = new Title();
			Tooltip = Tooltip_DefaultValue = new Tooltip();
			XAxis = XAxis_DefaultValue = new List<XAxis>();
			YAxis = YAxis_DefaultValue = new List<YAxis>();
			ZAxis = ZAxis_DefaultValue = new ZAxis();
			ColorAxis = ColorAxis_DefaultValue = new ColorAxis();
			Stops = Stops_DefaultValue = null;
			Min = Min_DefaultValue = null;
			Max = Max_DefaultValue = null;
			StartOnTick = StartOnTick_DefaultValue = false;
			EndOnTick = EndOnTick_DefaultValue = false;
			MinColor = MinColor_DefaultValue = null;
			MaxColor = MaxColor_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Options for configuring accessibility for the chart. Requires the <a href="//code.highcharts.com/modules/accessibility.js">accessibility module</a> to be loaded. For a description of the module and information on its features, see <a href="http://www.highcharts.com/docs/chart-concepts/accessibility">Highcharts Accessibility</a>.</p>
		/// </summary>
		public Accessibility Accessibility { get; set; }
		private Accessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options regarding the chart area and plot area as well as general chart options.
		/// </summary>
		public Chart Chart { get; set; }
		private Chart Chart_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array containing the default colors for the chart's series. When all colors are used, new colors are pulled from the start again. Defaults to:<pre>colors: ['#7cb5ec', '#434348', '#90ed7d', '#f7a35c', '#8085e9',    '#f15c80', '#e4d354', '#2b908f', '#f45b5b', '#91e8e1']</pre>Default colors can also be set on a series or series.type basis, see <a href="#plotOptions.column.colors">column.colors</a>, <a href="#plotOptions.pie.colors">pie.colors</a>.</p><p>In <a href="http://www.highcharts.com/docs/chart-design-and-style/style-by-css">styled mode</a>, the colors option doesn't exist. Instead, colors are defined in CSS and applied either through series or point class names, or through the <a href="#chart.colorCount">chart.colorCount</a> option.</p><h3>Legacy</h3><p>In Highcharts 3.x, the default colors were:<pre>colors: ['#2f7ed8', '#0d233a', '#8bbc21', '#910000', '#1aadce',    '#492970', '#f28f43', '#77a1e5', '#c42525', '#a6c96a']</pre></p><p>In Highcharts 2.x, the default colors were:<pre>colors: ['#4572A7', '#AA4643', '#89A54E', '#80699B', '#3D96AE',    '#DB843D', '#92A8CD', '#A47D7C', '#B5CA92']</pre></p>
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// Highchart by default puts a credits label in the lower right corner of the chart.This can be changed using these options.
		/// </summary>
		public Credits Credits { get; set; }
		private Credits Credits_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The Data module provides a simplified interface for adding data to a chart from sources like CVS, HTML tables or grid views. See also the <a href="http://www.highcharts.com/docs/working-with-data/data-module">tutorial article on the Data module</a>.</p><p>It requires the <code>modules/data.js</code> file to be loaded.</p><p>Please note that the default way of adding data in Highcharts, without the need of a module, is through the <a href="#series.data">series.data</a> option.</p>
		/// </summary>
		public Data Data { get; set; }
		private Data Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// <a href="http://www.highcharts.com/docs/chart-design-and-style/style-by-css">Styled mode</a> only. Configuration object for adding SVG definitions for reusable elements. See <a href="http://www.highcharts.com/docs/chart-design-and-style/gradients-shadows-and-patterns">gradients, shadows and patterns</a> for more information and code examples.
		/// </summary>
		public Object Defs { get; set; }
		private Object Defs_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for drill down, the concept of inspecting increasingly high resolution data through clicking on chart items like columns or pie slices.</p><p>The drilldown feature requires the <code>drilldown.js</code> file to be loaded, found in the <code>modules</code> directory of the download package, or online at <a href="http://code.highcharts.com/modules/drilldown.js">code.highcharts.com/modules/drilldown.js</a>.</p>
		/// </summary>
		public Drilldown Drilldown { get; set; }
		private Drilldown Drilldown_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the exporting module. For an overview on the matter, see <a href="http://www.highcharts.com/docs/export-module/export-module-overview">the docs</a>.
		/// </summary>
		public Exporting Exporting { get; set; }
		private Exporting Exporting_DefaultValue { get; set; }
		 

		/// <summary>
		/// Global options that don't apply to each chart. These options, like the <code>lang</code>options, must be set using the <code>Highcharts.setOptions</code> method.<pre>Highcharts.setOptions({global: {useUTC: false}});</pre>
		/// </summary>
		public Global Global { get; set; }
		private Global Global_DefaultValue { get; set; }
		 

		/// <summary>
		/// HTML labels that can be positioned anywhere in the chart area.
		/// </summary>
		public Labels Labels { get; set; }
		private Labels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Language object. The language object is global and it can'tbe set on each chart initiation. Instead, use <code>Highcharts.setOptions</code> toset it before any chart is initiated. <pre>Highcharts.setOptions({lang: {months: ['Janvier', 'Février', 'Mars', 'Avril', 'Mai', 'Juin',  'Juillet', 'Août', 'Septembre', 'Octobre', 'Novembre', 'Décembre'],weekdays: ['Dimanche', 'Lundi', 'Mardi', 'Mercredi', 'Jeudi', 'Vendredi', 'Samedi']}});</pre>
		/// </summary>
		public Lang Lang { get; set; }
		private Lang Lang_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The legend is a box containing a symbol and name for each series item or point item in the chart. Each series (or points in case of pie charts) is represented by a symbol and its name in the legend.</p><p>It is also possible to override the symbol creator function and create <a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/studies/legend-custom-symbol/">custom legend symbols</a>.</p>
		/// </summary>
		public Legend Legend { get; set; }
		private Legend Legend_DefaultValue { get; set; }
		 

		/// <summary>
		/// The loading options control the appearance of the loading screen that covers the plot area on chart operations. This screen only appears after an explicit callto <code>chart.showLoading()</code>. It is a utility for developers to communicateto the end user that something is going on, for example while retrieving new datavia an XHR connection. The "Loading..." text itself is not part of this configurationobject, but part of the <code>lang</code> object.
		/// </summary>
		public Loading Loading { get; set; }
		private Loading Loading_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of options for buttons and menus appearing in the exporting module.
		/// </summary>
		public Navigation Navigation { get; set; }
		private Navigation Navigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for displaying a message like "No data to display". This feature requires the file <code>no-data-to-display.js</code> to be loaded in the page. The actual text to display is set in the <a href="#lang.noData">lang.noData</a> option.
		/// </summary>
		public NoData NoData { get; set; }
		private NoData NoData_DefaultValue { get; set; }
		 

		/// <summary>
		/// Applies only to polar charts and angular gauges. This configuration object holds general options for the combined X and Y axes set. Each xAxis or yAxis can reference the pane by index.
		/// </summary>
		public Pane Pane { get; set; }
		private Pane Pane_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The plotOptions is a wrapper object for config objects for each series type.The config objects for each series can also be overridden for each series item as given in the series array.</p><p>Configuration options for the series are given in three levels. Optionsfor all series in a chart are given in the <a class="internal" href="#plotOptions.series">plotOptions.series</a> object. Then options for all seriesof a specific type are given in the plotOptions of that type, for example plotOptions.line.Next, options for one single series are given in <a class="internal" href="#series">the series array</a>.</p>
		/// </summary>
		public PlotOptions PlotOptions { get; set; }
		private PlotOptions PlotOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allows setting a set of rules to apply for different screen or chart sizes. Each rule specifies additional chart options.
		/// </summary>
		public Responsive Responsive { get; set; }
		private Responsive Responsive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The actual series to append to the chart. In addition to the members listed below, any member of the <code>plotOptions</code> for that specifictype of plot can be added to a series individually. For example, even though a general<code>lineWidth</code> is specified in <code>plotOptions.series</code>, an individual<code>lineWidth</code> can be specified for each series.
		/// </summary>
		public List<Series> Series { get; set; }
		private List<Series> Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>area</code> series. If the <a href="#series<area>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.area">plotOptions.area</a>.</p>
		/// </summary>
		public AreaSeries AreaSeries { get; set; }
		private AreaSeries AreaSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>arearange</code> series. If the <a href="#series<arearange>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.arearange">plotOptions.arearange</a>.</p>
		/// </summary>
		public ArearangeSeries ArearangeSeries { get; set; }
		private ArearangeSeries ArearangeSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>areaspline</code> series. If the <a href="#series<areaspline>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.areaspline">plotOptions.areaspline</a>.</p>
		/// </summary>
		public AreasplineSeries AreasplineSeries { get; set; }
		private AreasplineSeries AreasplineSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>areasplinerange</code> series. If the <a href="#series<areasplinerange>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.areasplinerange">plotOptions.areasplinerange</a>.</p>
		/// </summary>
		public AreasplinerangeSeries AreasplinerangeSeries { get; set; }
		private AreasplinerangeSeries AreasplinerangeSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>bar</code> series. If the <a href="#series<bar>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.bar">plotOptions.bar</a>.</p>
		/// </summary>
		public BarSeries BarSeries { get; set; }
		private BarSeries BarSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>boxplot</code> series. If the <a href="#series<boxplot>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.boxplot">plotOptions.boxplot</a>.</p>
		/// </summary>
		public BoxplotSeries BoxplotSeries { get; set; }
		private BoxplotSeries BoxplotSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>bubble</code> series. If the <a href="#series<bubble>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.bubble">plotOptions.bubble</a>.</p>
		/// </summary>
		public BubbleSeries BubbleSeries { get; set; }
		private BubbleSeries BubbleSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>column</code> series. If the <a href="#series<column>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.column">plotOptions.column</a>.</p>
		/// </summary>
		public ColumnSeries ColumnSeries { get; set; }
		private ColumnSeries ColumnSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>columnrange</code> series. If the <a href="#series<columnrange>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.columnrange">plotOptions.columnrange</a>.</p>
		/// </summary>
		public ColumnrangeSeries ColumnrangeSeries { get; set; }
		private ColumnrangeSeries ColumnrangeSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>errorbar</code> series. If the <a href="#series<errorbar>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.errorbar">plotOptions.errorbar</a>.</p>
		/// </summary>
		public ErrorbarSeries ErrorbarSeries { get; set; }
		private ErrorbarSeries ErrorbarSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>funnel</code> series. If the <a href="#series<funnel>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.funnel">plotOptions.funnel</a>.</p>
		/// </summary>
		public FunnelSeries FunnelSeries { get; set; }
		private FunnelSeries FunnelSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>gauge</code> series. If the <a href="#series<gauge>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.gauge">plotOptions.gauge</a>.</p>
		/// </summary>
		public GaugeSeries GaugeSeries { get; set; }
		private GaugeSeries GaugeSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>heatmap</code> series. If the <a href="#series<heatmap>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.heatmap">plotOptions.heatmap</a>.</p>
		/// </summary>
		public HeatmapSeries HeatmapSeries { get; set; }
		private HeatmapSeries HeatmapSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>line</code> series. If the <a href="#series<line>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.line">plotOptions.line</a>.</p>
		/// </summary>
		public LineSeries LineSeries { get; set; }
		private LineSeries LineSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>pie</code> series. If the <a href="#series<pie>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.pie">plotOptions.pie</a>.</p>
		/// </summary>
		public PieSeries PieSeries { get; set; }
		private PieSeries PieSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>polygon</code> series. If the <a href="#series<polygon>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.polygon">plotOptions.polygon</a>.</p>
		/// </summary>
		public PolygonSeries PolygonSeries { get; set; }
		private PolygonSeries PolygonSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>pyramid</code> series. If the <a href="#series<pyramid>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.pyramid">plotOptions.pyramid</a>.</p>
		/// </summary>
		public PyramidSeries PyramidSeries { get; set; }
		private PyramidSeries PyramidSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>scatter</code> series. If the <a href="#series<scatter>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.scatter">plotOptions.scatter</a>.</p>
		/// </summary>
		public ScatterSeries ScatterSeries { get; set; }
		private ScatterSeries ScatterSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>solidgauge</code> series. If the <a href="#series<solidgauge>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.solidgauge">plotOptions.solidgauge</a>.</p>
		/// </summary>
		public SolidgaugeSeries SolidgaugeSeries { get; set; }
		private SolidgaugeSeries SolidgaugeSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>spline</code> series. If the <a href="#series<spline>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.spline">plotOptions.spline</a>.</p>
		/// </summary>
		public SplineSeries SplineSeries { get; set; }
		private SplineSeries SplineSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>treemap</code> series. If the <a href="#series<treemap>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.treemap">plotOptions.treemap</a>.</p>
		/// </summary>
		public TreemapSeries TreemapSeries { get; set; }
		private TreemapSeries TreemapSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>waterfall</code> series. If the <a href="#series<waterfall>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.waterfall">plotOptions.waterfall</a>.</p>
		/// </summary>
		public WaterfallSeries WaterfallSeries { get; set; }
		private WaterfallSeries WaterfallSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// The chart's subtitle
		/// </summary>
		public Subtitle Subtitle { get; set; }
		private Subtitle Subtitle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The chart's main title.
		/// </summary>
		public Title Title { get; set; }
		private Title Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the tooltip that appears when the user hovers over a series or point.
		/// </summary>
		public Tooltip Tooltip { get; set; }
		private Tooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The X axis or category axis. Normally this is the horizontal axis, though if the chart is inverted this is the vertical axis. In case of multiple axes, the xAxisnode is an array of configuration objects.</p><p>See <a class="internal" href="#Axis">the Axis object</a> for programmaticaccess to the axis.</p>
		/// </summary>
		public List<XAxis> XAxis { get; set; }
		private List<XAxis> XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The Y axis or value axis. Normally this is the vertical axis, though if the chart is inverted this is the horizontal axis. In case of multiple axes, the yAxisnode is an array of configuration objects.</p><p>See <a class="internal" href="#Axis">the Axis object</a> for programmaticaccess to the axis.</p>
		/// </summary>
		public List<YAxis> YAxis { get; set; }
		private List<YAxis> YAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The Z axis or depth axis for 3D plots.</p><p>See <a class="internal" href="#Axis">the Axis object</a> for programmaticaccess to the axis.</p>
		/// </summary>
		public ZAxis ZAxis { get; set; }
		private ZAxis ZAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColorAxis ColorAxis { get; set; }
		private ColorAxis ColorAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<Stop> Stops { get; set; }
		private List<Stop> Stops_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Min { get; set; }
		private double? Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Max { get; set; }
		private double? Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? StartOnTick { get; set; }
		private bool? StartOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? EndOnTick { get; set; }
		private bool? EndOnTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MinColor { get; set; }
		private string MinColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MaxColor { get; set; }
		private string MaxColor_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Accessibility.IsDirty()) h.Add("accessibility",Accessibility.ToHashtable());
			if (Chart.IsDirty()) h.Add("chart",Chart.ToHashtable());
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (Credits.IsDirty()) h.Add("credits",Credits.ToHashtable());
			if (Data.IsDirty()) h.Add("Data_DefaultValue",Data.ToHashtable());
			if (Defs != Defs_DefaultValue) h.Add("defs",Defs);
			if (Drilldown.IsDirty()) h.Add("drilldown",Drilldown.ToHashtable());
			if (Exporting.IsDirty()) h.Add("exporting",Exporting.ToHashtable());
			if (Global.IsDirty()) h.Add("global",Global.ToHashtable());
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (Lang.IsDirty()) h.Add("lang",Lang.ToHashtable());
			if (Legend.IsDirty()) h.Add("legend",Legend.ToHashtable());
			if (Loading.IsDirty()) h.Add("loading",Loading.ToHashtable());
			if (Navigation.IsDirty()) h.Add("navigation",Navigation.ToHashtable());
			if (NoData.IsDirty()) h.Add("noData",NoData.ToHashtable());
			if (Pane.IsDirty()) h.Add("pane",Pane.ToHashtable());
			if (PlotOptions.IsDirty()) h.Add("plotOptions",PlotOptions.ToHashtable());
			if (Responsive.IsDirty()) h.Add("responsive",Responsive.ToHashtable());
			if (Series != Series_DefaultValue) h.Add("series",Series);
			if (AreaSeries.IsDirty()) h.Add("areaSeries",AreaSeries.ToHashtable());
			if (ArearangeSeries.IsDirty()) h.Add("arearangeSeries",ArearangeSeries.ToHashtable());
			if (AreasplineSeries.IsDirty()) h.Add("areasplineSeries",AreasplineSeries.ToHashtable());
			if (AreasplinerangeSeries.IsDirty()) h.Add("areasplinerangeSeries",AreasplinerangeSeries.ToHashtable());
			if (BarSeries.IsDirty()) h.Add("barSeries",BarSeries.ToHashtable());
			if (BoxplotSeries.IsDirty()) h.Add("boxplotSeries",BoxplotSeries.ToHashtable());
			if (BubbleSeries.IsDirty()) h.Add("bubbleSeries",BubbleSeries.ToHashtable());
			if (ColumnSeries.IsDirty()) h.Add("columnSeries",ColumnSeries.ToHashtable());
			if (ColumnrangeSeries.IsDirty()) h.Add("columnrangeSeries",ColumnrangeSeries.ToHashtable());
			if (ErrorbarSeries.IsDirty()) h.Add("errorbarSeries",ErrorbarSeries.ToHashtable());
			if (FunnelSeries.IsDirty()) h.Add("funnelSeries",FunnelSeries.ToHashtable());
			if (GaugeSeries.IsDirty()) h.Add("gaugeSeries",GaugeSeries.ToHashtable());
			if (HeatmapSeries.IsDirty()) h.Add("heatmapSeries",HeatmapSeries.ToHashtable());
			if (LineSeries.IsDirty()) h.Add("lineSeries",LineSeries.ToHashtable());
			if (PieSeries.IsDirty()) h.Add("pieSeries",PieSeries.ToHashtable());
			if (PolygonSeries.IsDirty()) h.Add("polygonSeries",PolygonSeries.ToHashtable());
			if (PyramidSeries.IsDirty()) h.Add("pyramidSeries",PyramidSeries.ToHashtable());
			if (ScatterSeries.IsDirty()) h.Add("scatterSeries",ScatterSeries.ToHashtable());
			if (SolidgaugeSeries.IsDirty()) h.Add("solidgaugeSeries",SolidgaugeSeries.ToHashtable());
			if (SplineSeries.IsDirty()) h.Add("splineSeries",SplineSeries.ToHashtable());
			if (TreemapSeries.IsDirty()) h.Add("treemapSeries",TreemapSeries.ToHashtable());
			if (WaterfallSeries.IsDirty()) h.Add("waterfallSeries",WaterfallSeries.ToHashtable());
			if (Subtitle.IsDirty()) h.Add("subtitle",Subtitle.ToHashtable());
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis", HashifyList(XAxis));
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis", HashifyList(YAxis));
			if (ZAxis.IsDirty()) h.Add("zAxis",ZAxis.ToHashtable());
			if (ColorAxis.IsDirty()) h.Add("colorAxis",ColorAxis.ToHashtable());
			if (Stops != Stops_DefaultValue) h.Add("stops", HashifyList(Stops));
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (StartOnTick != StartOnTick_DefaultValue) h.Add("startOnTick",StartOnTick);
			if (EndOnTick != EndOnTick_DefaultValue) h.Add("endOnTick",EndOnTick);
			if (MinColor != MinColor_DefaultValue) h.Add("minColor",MinColor);
			if (MaxColor != MaxColor_DefaultValue) h.Add("maxColor",MaxColor);
			

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
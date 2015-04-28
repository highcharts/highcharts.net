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
	public partial class Highcharts
	{
		public Highcharts()
		{
			Chart = Chart_DefaultValue = new Chart();
			Colors = Colors_DefaultValue = new List<string>();
			Credits = Credits_DefaultValue = new Credits();
			Data = Data_DefaultValue = new Data();
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
			Series = Series_DefaultValue = new List<Series>();
			Series<area> = Series<area>_DefaultValue = new AreaSeries();
			Series<arearange> = Series<arearange>_DefaultValue = new ArearangeSeries();
			Series<areaspline> = Series<areaspline>_DefaultValue = new AreasplineSeries();
			Series<areasplinerange> = Series<areasplinerange>_DefaultValue = new AreasplinerangeSeries();
			Series<bar> = Series<bar>_DefaultValue = new BarSeries();
			Series<boxplot> = Series<boxplot>_DefaultValue = new BoxplotSeries();
			Series<bubble> = Series<bubble>_DefaultValue = new BubbleSeries();
			Series<column> = Series<column>_DefaultValue = new ColumnSeries();
			Series<columnrange> = Series<columnrange>_DefaultValue = new ColumnRangeSeries();
			Series<errorbar> = Series<errorbar>_DefaultValue = new ErrorbarSeries();
			Series<funnel> = Series<funnel>_DefaultValue = new FunnelSeries();
			Series<gauge> = Series<gauge>_DefaultValue = new GaugeSeries();
			Series<heatmap> = Series<heatmap>_DefaultValue = new HeatmapSeries();
			Series<line> = Series<line>_DefaultValue = new LineSeries();
			Series<pie> = Series<pie>_DefaultValue = new PieSeries();
			Series<polygon> = Series<polygon>_DefaultValue = new PloygonSeries();
			Series<pyramid> = Series<pyramid>_DefaultValue = new PyramidSeries();
			Series<scatter> = Series<scatter>_DefaultValue = new ScatterSeries();
			Series<solidgauge> = Series<solidgauge>_DefaultValue = new SolidgaugeSeries();
			Series<spline> = Series<spline>_DefaultValue = new SplineSeries();
			Series<treemap> = Series<treemap>_DefaultValue = new TreemapSeries();
			Series<waterfall> = Series<waterfall>_DefaultValue = new WaterfallSeries();
			Subtitle = Subtitle_DefaultValue = new Subtitle();
			Title = Title_DefaultValue = new Title();
			Tooltip = Tooltip_DefaultValue = new Tooltip();
			XAxis = XAxis_DefaultValue = new XAxis();
			YAxis = YAxis_DefaultValue = new YAxis();
			
		}	
		

		/// <summary>
		/// Options regarding the chart area and plot area as well as general chart options.
		/// </summary>
		public Chart Chart { get; set; }
		private Chart Chart_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array containing the default colors for the chart's series. When all colors are used, new colors are pulled from the start again. Defaults to:<pre>colors: ['#7cb5ec', '#434348', '#90ed7d', '#f7a35c', '#8085e9',    '#f15c80', '#e4d354', '#2b908f', '#f45b5b', '#91e8e1']</pre>Default colors can also be set on a series or series.type basis, see <a href="#plotOptions.column.colors">column.colors</a>, <a href="#plotOptions.pie.colors">pie.colors</a>.</p><h3>Legacy</h3><p>In Highcharts 3.x, the default colors were:<pre>colors: ['#2f7ed8', '#0d233a', '#8bbc21', '#910000', '#1aadce',    '#492970', '#f28f43', '#77a1e5', '#c42525', '#a6c96a']</pre></p><p>In Highcharts 2.x, the default colors were:<pre>colors: ['#4572A7', '#AA4643', '#89A54E', '#80699B', '#3D96AE',    '#DB843D', '#92A8CD', '#A47D7C', '#B5CA92']</pre></p>
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
		/// Language object. The language object is global and it can'tbe set on each chart initiation. Instead, use <code>Highcharts.setOptions</code> toset it before any chart is initiated. <pre>Highcharts.setOptions({lang: {months: ['Janvier', 'F�vrier', 'Mars', 'Avril', 'Mai', 'Juin',  'Juillet', 'Ao�t', 'Septembre', 'Octobre', 'Novembre', 'D�cembre'],weekdays: ['Dimanche', 'Lundi', 'Mardi', 'Mercredi', 'Jeudi', 'Vendredi', 'Samedi']}});</pre>
		/// </summary>
		public Lang Lang { get; set; }
		private Lang Lang_DefaultValue { get; set; }
		 

		/// <summary>
		/// The legend is a box containing a symbol and name for each series itemor point item in the chart.
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
		/// The actual series to append to the chart. In addition to the members listed below, any member of the <code>plotOptions</code> for that specifictype of plot can be added to a series individually. For example, even though a general<code>lineWidth</code> is specified in <code>plotOptions.series</code>, an individual<code>lineWidth</code> can be specified for each series.
		/// </summary>
		public List<Series> Series { get; set; }
		private List<Series> Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>area</code> series. If the <a href="#series<area>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.area">plotOptions.area</a>.</p>
		/// </summary>
		public AreaSeries Series<area> { get; set; }
		private AreaSeries Series<area>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>arearange</code> series. If the <a href="#series<arearange>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.arearange">plotOptions.arearange</a>.</p>
		/// </summary>
		public ArearangeSeries Series<arearange> { get; set; }
		private ArearangeSeries Series<arearange>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>areaspline</code> series. If the <a href="#series<areaspline>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.areaspline">plotOptions.areaspline</a>.</p>
		/// </summary>
		public AreasplineSeries Series<areaspline> { get; set; }
		private AreasplineSeries Series<areaspline>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>areasplinerange</code> series. If the <a href="#series<areasplinerange>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.areasplinerange">plotOptions.areasplinerange</a>.</p>
		/// </summary>
		public AreasplinerangeSeries Series<areasplinerange> { get; set; }
		private AreasplinerangeSeries Series<areasplinerange>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>bar</code> series. If the <a href="#series<bar>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.bar">plotOptions.bar</a>.</p>
		/// </summary>
		public BarSeries Series<bar> { get; set; }
		private BarSeries Series<bar>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>boxplot</code> series. If the <a href="#series<boxplot>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.boxplot">plotOptions.boxplot</a>.</p>
		/// </summary>
		public BoxplotSeries Series<boxplot> { get; set; }
		private BoxplotSeries Series<boxplot>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>bubble</code> series. If the <a href="#series<bubble>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.bubble">plotOptions.bubble</a>.</p>
		/// </summary>
		public BubbleSeries Series<bubble> { get; set; }
		private BubbleSeries Series<bubble>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>column</code> series. If the <a href="#series<column>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.column">plotOptions.column</a>.</p>
		/// </summary>
		public ColumnSeries Series<column> { get; set; }
		private ColumnSeries Series<column>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>columnrange</code> series. If the <a href="#series<columnrange>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.columnrange">plotOptions.columnrange</a>.</p>
		/// </summary>
		public ColumnRangeSeries Series<columnrange> { get; set; }
		private ColumnRangeSeries Series<columnrange>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>errorbar</code> series. If the <a href="#series<errorbar>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.errorbar">plotOptions.errorbar</a>.</p>
		/// </summary>
		public ErrorbarSeries Series<errorbar> { get; set; }
		private ErrorbarSeries Series<errorbar>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>funnel</code> series. If the <a href="#series<funnel>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.funnel">plotOptions.funnel</a>.</p>
		/// </summary>
		public FunnelSeries Series<funnel> { get; set; }
		private FunnelSeries Series<funnel>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>gauge</code> series. If the <a href="#series<gauge>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.gauge">plotOptions.gauge</a>.</p>
		/// </summary>
		public GaugeSeries Series<gauge> { get; set; }
		private GaugeSeries Series<gauge>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>heatmap</code> series. If the <a href="#series<heatmap>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.heatmap">plotOptions.heatmap</a>.</p>
		/// </summary>
		public HeatmapSeries Series<heatmap> { get; set; }
		private HeatmapSeries Series<heatmap>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>line</code> series. If the <a href="#series<line>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.line">plotOptions.line</a>.</p>
		/// </summary>
		public LineSeries Series<line> { get; set; }
		private LineSeries Series<line>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>pie</code> series. If the <a href="#series<pie>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.pie">plotOptions.pie</a>.</p>
		/// </summary>
		public PieSeries Series<pie> { get; set; }
		private PieSeries Series<pie>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>polygon</code> series. If the <a href="#series<polygon>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.polygon">plotOptions.polygon</a>.</p>
		/// </summary>
		public PloygonSeries Series<polygon> { get; set; }
		private PloygonSeries Series<polygon>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>pyramid</code> series. If the <a href="#series<pyramid>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.pyramid">plotOptions.pyramid</a>.</p>
		/// </summary>
		public PyramidSeries Series<pyramid> { get; set; }
		private PyramidSeries Series<pyramid>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>scatter</code> series. If the <a href="#series<scatter>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.scatter">plotOptions.scatter</a>.</p>
		/// </summary>
		public ScatterSeries Series<scatter> { get; set; }
		private ScatterSeries Series<scatter>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>solidgauge</code> series. If the <a href="#series<solidgauge>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.solidgauge">plotOptions.solidgauge</a>.</p>
		/// </summary>
		public SolidgaugeSeries Series<solidgauge> { get; set; }
		private SolidgaugeSeries Series<solidgauge>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>spline</code> series. If the <a href="#series<spline>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.spline">plotOptions.spline</a>.</p>
		/// </summary>
		public SplineSeries Series<spline> { get; set; }
		private SplineSeries Series<spline>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>treemap</code> series. If the <a href="#series<treemap>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.treemap">plotOptions.treemap</a>.</p>
		/// </summary>
		public TreemapSeries Series<treemap> { get; set; }
		private TreemapSeries Series<treemap>_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>waterfall</code> series. If the <a href="#series<waterfall>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.waterfall">plotOptions.waterfall</a>.</p>
		/// </summary>
		public WaterfallSeries Series<waterfall> { get; set; }
		private WaterfallSeries Series<waterfall>_DefaultValue { get; set; }
		 

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
		/// <p>The X axis or category axis. Normally this is the horizontal axis, though if the chart is inverted this is the vertical axis. In case of multiple axes, the xAxisnode is an array of configuration objects.</p><p>See <a class="internal" href="#axis.object">the Axis object</a> for programmaticaccess to the axis.</p>
		/// </summary>
		public XAxis XAxis { get; set; }
		private XAxis XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The Y axis or value axis. Normally this is the vertical axis, though if the chart is inverted this is the horizontal axis. In case of multiple axes, the yAxisnode is an array of configuration objects.</p><p>See <a class="internal" href="#axis.object">the Axis object</a> for programmaticaccess to the axis.</p>
		/// </summary>
		public YAxis YAxis { get; set; }
		private YAxis YAxis_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Chart.IsDirty()) h.Add("chart",Chart.ToHashtable());
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (Credits.IsDirty()) h.Add("credits",Credits.ToHashtable());
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
			if (Series<area>.IsDirty()) h.Add("series<area>",Series<area>.ToHashtable());
			if (Series<arearange>.IsDirty()) h.Add("series<arearange>",Series<arearange>.ToHashtable());
			if (Series<areaspline>.IsDirty()) h.Add("series<areaspline>",Series<areaspline>.ToHashtable());
			if (Series<areasplinerange>.IsDirty()) h.Add("series<areasplinerange>",Series<areasplinerange>.ToHashtable());
			if (Series<bar>.IsDirty()) h.Add("series<bar>",Series<bar>.ToHashtable());
			if (Series<boxplot>.IsDirty()) h.Add("series<boxplot>",Series<boxplot>.ToHashtable());
			if (Series<bubble>.IsDirty()) h.Add("series<bubble>",Series<bubble>.ToHashtable());
			if (Series<column>.IsDirty()) h.Add("series<column>",Series<column>.ToHashtable());
			if (Series<columnrange>.IsDirty()) h.Add("series<columnrange>",Series<columnrange>.ToHashtable());
			if (Series<errorbar>.IsDirty()) h.Add("series<errorbar>",Series<errorbar>.ToHashtable());
			if (Series<funnel>.IsDirty()) h.Add("series<funnel>",Series<funnel>.ToHashtable());
			if (Series<gauge>.IsDirty()) h.Add("series<gauge>",Series<gauge>.ToHashtable());
			if (Series<heatmap>.IsDirty()) h.Add("series<heatmap>",Series<heatmap>.ToHashtable());
			if (Series<line>.IsDirty()) h.Add("series<line>",Series<line>.ToHashtable());
			if (Series<pie>.IsDirty()) h.Add("series<pie>",Series<pie>.ToHashtable());
			if (Series<polygon>.IsDirty()) h.Add("series<polygon>",Series<polygon>.ToHashtable());
			if (Series<pyramid>.IsDirty()) h.Add("series<pyramid>",Series<pyramid>.ToHashtable());
			if (Series<scatter>.IsDirty()) h.Add("series<scatter>",Series<scatter>.ToHashtable());
			if (Series<solidgauge>.IsDirty()) h.Add("series<solidgauge>",Series<solidgauge>.ToHashtable());
			if (Series<spline>.IsDirty()) h.Add("series<spline>",Series<spline>.ToHashtable());
			if (Series<treemap>.IsDirty()) h.Add("series<treemap>",Series<treemap>.ToHashtable());
			if (Series<waterfall>.IsDirty()) h.Add("series<waterfall>",Series<waterfall>.ToHashtable());
			if (Subtitle.IsDirty()) h.Add("subtitle",Subtitle.ToHashtable());
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (XAxis.IsDirty()) h.Add("xAxis",XAxis.ToHashtable());
			if (YAxis.IsDirty()) h.Add("yAxis",YAxis.ToHashtable());
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}
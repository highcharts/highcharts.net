using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Maps
{
	public partial class Highmaps  : BaseObject
	{
		public Highmaps()
		{
			Chart = Chart_DefaultValue = new Chart();
			ColorAxis = ColorAxis_DefaultValue = new ColorAxis();
			Colors = Colors_DefaultValue = new List<string>();
			Credits = Credits_DefaultValue = new Credits();
			Drilldown = Drilldown_DefaultValue = new Drilldown();
			Exporting = Exporting_DefaultValue = new Exporting();
			Global = Global_DefaultValue = new Global();
			Labels = Labels_DefaultValue = new Labels();
			Lang = Lang_DefaultValue = new Lang();
			Legend = Legend_DefaultValue = new Legend();
			Loading = Loading_DefaultValue = new Loading();
			MapNavigation = MapNavigation_DefaultValue = new MapNavigation();
			Navigation = Navigation_DefaultValue = new Navigation();
			PlotOptions = PlotOptions_DefaultValue = new PlotOptions();
			Series = Series_DefaultValue = new List<Series>();
			HeatmapSeries = HeatmapSeries_DefaultValue = new HeatmapSeries();
			MapSeries = MapSeries_DefaultValue = new MapSeries();
			MapBubbleSeries = MapBubbleSeries_DefaultValue = new MapBubbleSeries();
			MapLineSeries = MapLineSeries_DefaultValue = new MapLineSeries();
			MapPointSeries = MapPointSeries_DefaultValue = new MapPointSeries();
			Subtitle = Subtitle_DefaultValue = new Subtitle();
			Title = Title_DefaultValue = new Title();
			Tooltip = Tooltip_DefaultValue = new Tooltip();
			XAxis = XAxis_DefaultValue = new List<XAxis>();
			YAxis = YAxis_DefaultValue = new List<YAxis>();
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
		/// Options regarding the chart area and plot area as well as general chart options.
		/// </summary>
		public Chart Chart { get; set; }
		private Chart Chart_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A color axis for choropleth mapping. Visually, the color axis will appear as a gradient or as separate items inside the legend, depending on whether the axis is scalar or based on data classes.</p><p>For supported color formats, see the <a href="http://www.highcharts.com/docs/chart-design-and-style/colors">docs article about colors</a>.</p><p>A scalar color axis is represented by a gradient. The colors either range between the <a href="#colorAxis.minColor">minColor</a> and the <a href="#colorAxis.maxColor">maxColor</a>, or for more fine grained control the colors can be defined in <a href="#colorAxis.stops">stops</a>. Often times, the color axis needs to be adjusted to get the right color spread for the data. In addition to stops, consider using a logarithmic <a href="#colorAxis.type">axis type</a>, or setting <a href="#colorAxis.min">min</a> and <a href="#colorAxis.max">max</a> to avoid the colors being determined by outliers.</p><p>When <a href="#colorAxis.dataClasses">dataClasses</a> are used, the ranges are subdivided into separate classes like categories based on their values. This can be used for ranges between two values, but also for a true category. However, when your data is categorized, it may be as convenient to add each category to a separate series.</p><p>See <a href="#Axis">the Axis object</a> for programmatic access to the axis.</p>
		/// </summary>
		public ColorAxis ColorAxis { get; set; }
		private ColorAxis ColorAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array containing the default colors for the chart's series. When all colors are used, new colors are pulled from the start again. Defaults to:<pre>colors: ['#7cb5ec', '#434348', '#90ed7d', '#f7a35c', '#8085e9',    '#f15c80', '#e4d354', '#8085e8', '#8d4653', '#91e8e1']</pre></p>
		/// </summary>
		public Colors Colors { get; set; }
		private Colors Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// Highchart by default puts a credits label in the lower right corner of the chart.This can be changed using these options.
		/// </summary>
		public Credits Credits { get; set; }
		private Credits Credits_DefaultValue { get; set; }
		 

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
		/// The legend is a box containing explanations for the different elements of a chart. A Highmaps legend by default contains one legend item per series, but if a colorAxis is defined, the axis will be displayed in the legen. Either as a gradient, or as multiple legend items for dataClasses.
		/// </summary>
		public Legend Legend { get; set; }
		private Legend Legend_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The loading options control the appearance of the loading screen that covers the plot area on chart operations. This screen only appears after an explicit callto <code>chart.showLoading()</code>. It is a utility for developers to communicateto the end user that something is going on, for example while retrieving new datavia an XHR connection. The "Loading..." text itself is not part of this configurationobject, but part of the <code>lang</code> object.</p><p>For demo cases, see the <a href="/highcharts/#loading">loading configuration object for basic Highcharts</a>.</p>
		/// </summary>
		public Loading Loading { get; set; }
		private Loading Loading_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A collection of options for zooming and panning in a map.</p>
		/// </summary>
		public MapNavigation MapNavigation { get; set; }
		private MapNavigation MapNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A collection of options for buttons and menus appearing in the exporting module.</p><p>The examples below point to basic Highcharts demos, but the syntax for Highmaps are the exact same.</p>
		/// </summary>
		public Navigation Navigation { get; set; }
		private Navigation Navigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The plotOptions is a wrapper object for config objects for each series type.The config objects for each series can also be overridden for each series item as given in the series array.</p><p>Configuration options for the series are given in three levels. Optionsfor all series in a chart are given in the <a class="internal" href="#plotOptions.series">plotOptions.series</a> object. Then options for all seriesof a specific type are given in the plotOptions of that type, for example plotOptions.line.Next, options for one single series are given in <a class="internal" href="#series">the series array</a>.</p>
		/// </summary>
		public PlotOptions PlotOptions { get; set; }
		private PlotOptions PlotOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The actual series to append to the chart. In addition to the members listed below, any member of the <code>plotOptions</code> for that specifictype of plot can be added to a series individually. 
		/// </summary>
		public List<Series> Series { get; set; }
		private List<Series> Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>heatmap</code> series. If the <a href="#series<heatmap>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.heatmap">plotOptions.heatmap</a>.</p>
		/// </summary>
		public HeatmapSeries HeatmapSeries { get; set; }
		private HeatmapSeries HeatmapSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>map</code> series. If the <a href="#series<map>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.map">plotOptions.map</a>.</p>
		/// </summary>
		public MapSeries MapSeries { get; set; }
		private MapSeries MapSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>mapbubble</code> series. If the <a href="#series<mapbubble>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.mapbubble">plotOptions.mapbubble</a>.</p>
		/// </summary>
		public MapBubbleSeries MapBubbleSeries { get; set; }
		private MapBubbleSeries MapBubbleSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>mapline</code> series. If the <a href="#series<mapline>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.mapline">plotOptions.mapline</a>.</p>
		/// </summary>
		public MapLineSeries MapLineSeries { get; set; }
		private MapLineSeries MapLineSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>mappoint</code> series. If the <a href="#series<mappoint>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.mappoint">plotOptions.mappoint</a>.</p>
		/// </summary>
		public MapPointSeries MapPointSeries { get; set; }
		private MapPointSeries MapPointSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// The chart's subtitle. This can be used both to display a subtitle below the main title, and to display random text anywhere in the chart. The subtitle can be updated after chart initialization through the <code>Chart.setTitle()</code> method.
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
		/// <p>The X axis. A Highcharts map has hidden X and Y axes to control layout of the shapes and features like zooming and panning. Zooming is in effect the same as setting the extremes of one of the axes, and Highmaps is set up to make the other axis zoom the same amount.</p><p>Highmaps uses the coordinate system of the map points' path configurations.</p><p>See <a class="internal" href="#Axis">the Axis object</a> for programmatic access to the axis.</p>
		/// </summary>
		public List<XAxis> XAxis { get; set; }
		private List<XAxis> XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The Y axis. A Highcharts map has hidden X and Y axes to control layout of the shapes and features like zooming and panning. Zooming is in effect the same as setting the extremes of one of the axes, and Highmaps is set up to make the other axis zoom the same amount.</p><p>Highmaps uses the coordinate system of the map points' path configurations.</p><p>See <a class="internal" href="#Axis">the Axis object</a> for programmatic access to the axis.</p>
		/// </summary>
		public List<YAxis> YAxis { get; set; }
		private List<YAxis> YAxis_DefaultValue { get; set; }
		 

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

			if (Chart.IsDirty()) h.Add("chart",Chart.ToHashtable());
			if (ColorAxis.IsDirty()) h.Add("colorAxis",ColorAxis.ToHashtable());
			if (Colors.IsDirty()) h.Add("colors",Colors.ToHashtable());
			if (Credits.IsDirty()) h.Add("credits",Credits.ToHashtable());
			if (Drilldown.IsDirty()) h.Add("drilldown",Drilldown.ToHashtable());
			if (Exporting.IsDirty()) h.Add("exporting",Exporting.ToHashtable());
			if (Global.IsDirty()) h.Add("global",Global.ToHashtable());
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (Lang.IsDirty()) h.Add("lang",Lang.ToHashtable());
			if (Legend.IsDirty()) h.Add("legend",Legend.ToHashtable());
			if (Loading.IsDirty()) h.Add("loading",Loading.ToHashtable());
			if (MapNavigation.IsDirty()) h.Add("mapNavigation",MapNavigation.ToHashtable());
			if (Navigation.IsDirty()) h.Add("navigation",Navigation.ToHashtable());
			if (PlotOptions.IsDirty()) h.Add("plotOptions",PlotOptions.ToHashtable());
			if (Series != Series_DefaultValue) h.Add("series",Series);
			if (HeatmapSeries.IsDirty()) h.Add("heatmapSeries",HeatmapSeries.ToHashtable());
			if (MapSeries.IsDirty()) h.Add("mapSeries",MapSeries.ToHashtable());
			if (MapBubbleSeries.IsDirty()) h.Add("mapBubbleSeries",MapBubbleSeries.ToHashtable());
			if (MapLineSeries.IsDirty()) h.Add("mapLineSeries",MapLineSeries.ToHashtable());
			if (MapPointSeries.IsDirty()) h.Add("mapPointSeries",MapPointSeries.ToHashtable());
			if (Subtitle.IsDirty()) h.Add("subtitle",Subtitle.ToHashtable());
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis", HashifyList(XAxis));
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis", HashifyList(YAxis));
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highstock.Web.Mvc
{
	public partial class Highstock  : BaseObject
	{
		public Highstock()
		{
			Chart = Chart_DefaultValue = new Chart();
			Colors = Colors_DefaultValue = new List<string>();
			Credits = Credits_DefaultValue = new Credits();
			Exporting = Exporting_DefaultValue = new Exporting();
			Global = Global_DefaultValue = new Global();
			Labels = Labels_DefaultValue = new Labels();
			Lang = Lang_DefaultValue = new Lang();
			Legend = Legend_DefaultValue = new Legend();
			Loading = Loading_DefaultValue = new Loading();
			Navigation = Navigation_DefaultValue = new Navigation();
			Navigator = Navigator_DefaultValue = new Navigator();
			PlotOptions = PlotOptions_DefaultValue = new PlotOptions();
			RangeSelector = RangeSelector_DefaultValue = new RangeSelector();
			Scrollbar = Scrollbar_DefaultValue = new Scrollbar();
			Series = Series_DefaultValue = new List<Series>();
			AreaSeries = AreaSeries_DefaultValue = new AreaSeries();
			ArearangeSeries = ArearangeSeries_DefaultValue = new ArearangeSeries();
			AreasplineSeries = AreasplineSeries_DefaultValue = new AreasplineSeries();
			AreasplinerangeSeries = AreasplinerangeSeries_DefaultValue = new AreasplinerangeSeries();
			CandleStickSeries = CandleStickSeries_DefaultValue = new CandleStickSeries();
			ColumnSeries = ColumnSeries_DefaultValue = new ColumnSeries();
			ColumnrangeSeries = ColumnrangeSeries_DefaultValue = new ColumnrangeSeries();
			FlagsSeries = FlagsSeries_DefaultValue = new FlagsSeries();
			LineSeries = LineSeries_DefaultValue = new LineSeries();
			OhlcSeries = OhlcSeries_DefaultValue = new OhlcSeries();
			PolygonSeries = PolygonSeries_DefaultValue = new PolygonSeries();
			ScatterSeries = ScatterSeries_DefaultValue = new ScatterSeries();
			SplineSeries = SplineSeries_DefaultValue = new SplineSeries();
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
		/// <p>An array containing the default colors for the chart's series. When all colors are used, new colors are pulled from the start again. Defaults to:<pre>colors: ['#7cb5ec', '#434348', '#90ed7d', '#f7a35c', '#8085e9',    '#f15c80', '#e4d354', '#8085e8', '#8d4653', '#91e8e1']</pre>Default colors can also be set on a series or series.type basis, see <a href="#plotOptions.column.colors">column.colors</a>.</p><h3>Legacy</h3><p>In Highstock 1.3.x, the default colors were:<pre>colors: ['#2f7ed8', '#0d233a', '#8bbc21', '#910000', '#1aadce',    '#492970', '#f28f43', '#77a1e5', '#c42525', '#a6c96a']</pre></p><p>Prior to 1.3, the default colors were:<pre>colors: ['#4572A7', '#AA4643', '#89A54E', '#80699B', '#3D96AE',    '#DB843D', '#92A8CD', '#A47D7C', '#B5CA92']</pre></p>
		/// </summary>
		public Colors Colors { get; set; }
		private Colors Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// Highchart by default puts a credits label in the lower right corner of the chart.This can be changed using these options.
		/// </summary>
		public Credits Credits { get; set; }
		private Credits Credits_DefaultValue { get; set; }
		 

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
		/// The navigator is a small series below the main series, displaying a view of the entire data set. It provides tools to zoom in and out on parts of thedata as well as panning across the dataset.
		/// </summary>
		public Navigator Navigator { get; set; }
		private Navigator Navigator_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The plotOptions is a wrapper object for config objects for each series type.The config objects for each series can also be overridden for each series item as given in the series array.</p><p>Configuration options for the series are given in three levels. Optionsfor all series in a chart are given in the <a class="internal" href="#plotOptions.series">plotOptions.series</a> object. Then options for all seriesof a specific type are given in the plotOptions of that type, for example plotOptions.line.Next, options for one single series are given in <a class="internal" href="#series">the series array</a>.</p>
		/// </summary>
		public PlotOptions PlotOptions { get; set; }
		private PlotOptions PlotOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The range selector is a tool for selecting ranges to display within the chart. It providesbuttons to select preconfigured ranges in the chart, like 1 day, 1 week, 1 month etc. Italso provides input boxes where min and max dates can be manually input.
		/// </summary>
		public RangeSelector RangeSelector { get; set; }
		private RangeSelector RangeSelector_DefaultValue { get; set; }
		 

		/// <summary>
		/// The scrollbar is a means of panning over the X axis of a chart.
		/// </summary>
		public Scrollbar Scrollbar { get; set; }
		private Scrollbar Scrollbar_DefaultValue { get; set; }
		 

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
		/// <p>A <code>candlestick</code> series. If the <a href="#series<candlestick>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.candlestick">plotOptions.candlestick</a>.</p>
		/// </summary>
		public CandleStickSeries CandleStickSeries { get; set; }
		private CandleStickSeries CandleStickSeries_DefaultValue { get; set; }
		 

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
		/// <p>A <code>flags</code> series. If the <a href="#series<flags>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.flags">plotOptions.flags</a>.</p>
		/// </summary>
		public FlagsSeries FlagsSeries { get; set; }
		private FlagsSeries FlagsSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>line</code> series. If the <a href="#series<line>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.line">plotOptions.line</a>.</p>
		/// </summary>
		public LineSeries LineSeries { get; set; }
		private LineSeries LineSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>ohlc</code> series. If the <a href="#series<ohlc>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.ohlc">plotOptions.ohlc</a>.</p>
		/// </summary>
		public OhlcSeries OhlcSeries { get; set; }
		private OhlcSeries OhlcSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>polygon</code> series. If the <a href="#series<polygon>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.polygon">plotOptions.polygon</a>.</p>
		/// </summary>
		public PolygonSeries PolygonSeries { get; set; }
		private PolygonSeries PolygonSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>scatter</code> series. If the <a href="#series<scatter>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.scatter">plotOptions.scatter</a>.</p>
		/// </summary>
		public ScatterSeries ScatterSeries { get; set; }
		private ScatterSeries ScatterSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>spline</code> series. If the <a href="#series<spline>.type">type</a> option is not specified, it is inherited from <a href="#chart.type">chart.type</a>.</p><p>For options that apply to multiple series, it is recommended to add them to the <a href="#pointOptions.series">pointOptions.series</a> options structure. To apply to all series of this specific type, apply it to <a href="#plotOptions.spline">plotOptions.spline</a>.</p>
		/// </summary>
		public SplineSeries SplineSeries { get; set; }
		private SplineSeries SplineSeries_DefaultValue { get; set; }
		 

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
		/// <p>The Y axis or value axis. In case of multiple axes, the yAxisnode is an array of configuration objects.</p><p>See <a class="internal" href="#axis.object">the Axis object</a> for programmaticaccess to the axis.</p>
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
			if (Colors.IsDirty()) h.Add("colors",Colors.ToHashtable());
			if (Credits.IsDirty()) h.Add("credits",Credits.ToHashtable());
			if (Exporting.IsDirty()) h.Add("exporting",Exporting.ToHashtable());
			if (Global.IsDirty()) h.Add("global",Global.ToHashtable());
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (Lang.IsDirty()) h.Add("lang",Lang.ToHashtable());
			if (Legend.IsDirty()) h.Add("legend",Legend.ToHashtable());
			if (Loading.IsDirty()) h.Add("loading",Loading.ToHashtable());
			if (Navigation.IsDirty()) h.Add("navigation",Navigation.ToHashtable());
			if (Navigator.IsDirty()) h.Add("navigator",Navigator.ToHashtable());
			if (PlotOptions.IsDirty()) h.Add("plotOptions",PlotOptions.ToHashtable());
			if (RangeSelector.IsDirty()) h.Add("rangeSelector",RangeSelector.ToHashtable());
			if (Scrollbar.IsDirty()) h.Add("scrollbar",Scrollbar.ToHashtable());
			if (Series != Series_DefaultValue) h.Add("series",Series);
			if (AreaSeries.IsDirty()) h.Add("areaSeries",AreaSeries.ToHashtable());
			if (ArearangeSeries.IsDirty()) h.Add("arearangeSeries",ArearangeSeries.ToHashtable());
			if (AreasplineSeries.IsDirty()) h.Add("areasplineSeries",AreasplineSeries.ToHashtable());
			if (AreasplinerangeSeries.IsDirty()) h.Add("areasplinerangeSeries",AreasplinerangeSeries.ToHashtable());
			if (CandleStickSeries.IsDirty()) h.Add("candleStickSeries",CandleStickSeries.ToHashtable());
			if (ColumnSeries.IsDirty()) h.Add("columnSeries",ColumnSeries.ToHashtable());
			if (ColumnrangeSeries.IsDirty()) h.Add("columnrangeSeries",ColumnrangeSeries.ToHashtable());
			if (FlagsSeries.IsDirty()) h.Add("flagsSeries",FlagsSeries.ToHashtable());
			if (LineSeries.IsDirty()) h.Add("lineSeries",LineSeries.ToHashtable());
			if (OhlcSeries.IsDirty()) h.Add("ohlcSeries",OhlcSeries.ToHashtable());
			if (PolygonSeries.IsDirty()) h.Add("polygonSeries",PolygonSeries.ToHashtable());
			if (ScatterSeries.IsDirty()) h.Add("scatterSeries",ScatterSeries.ToHashtable());
			if (SplineSeries.IsDirty()) h.Add("splineSeries",SplineSeries.ToHashtable());
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
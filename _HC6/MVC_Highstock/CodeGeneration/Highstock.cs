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
	public partial class Highstock  : BaseObject
	{
		public Highstock()
		{
			PlotOptions = PlotOptions_DefaultValue = new PlotOptions();
			Series = Series_DefaultValue = new List<Series>();
			Accessibility = Accessibility_DefaultValue = new Accessibility();
			Chart = Chart_DefaultValue = new Chart();
			Legend = Legend_DefaultValue = new Legend();
			Defs = Defs_DefaultValue = new Defs();
			Annotations = Annotations_DefaultValue = new Annotations();
			Boost = Boost_DefaultValue = new Boost();
			YAxis = YAxis_DefaultValue = new List<YAxis>();
			Lang = Lang_DefaultValue = new Lang();
			Drilldown = Drilldown_DefaultValue = new Drilldown();
			Exporting = Exporting_DefaultValue = new Exporting();
			Navigation = Navigation_DefaultValue = new Navigation();
			NoData = NoData_DefaultValue = new NoData();
			Global = Global_DefaultValue = new Global();
			XAxis = XAxis_DefaultValue = new List<XAxis>();
			Navigator = Navigator_DefaultValue = new Navigator();
			Colors = Colors_DefaultValue = new List<string>();
			Title = Title_DefaultValue = new Title();
			Subtitle = Subtitle_DefaultValue = new Subtitle();
			Labels = Labels_DefaultValue = new Labels();
			Loading = Loading_DefaultValue = new Loading();
			Tooltip = Tooltip_DefaultValue = new Tooltip();
			Credits = Credits_DefaultValue = new Credits();
			RangeSelector = RangeSelector_DefaultValue = new RangeSelector();
			Responsive = Responsive_DefaultValue = new Responsive();
			Scrollbar = Scrollbar_DefaultValue = new Scrollbar();
			Pane = Pane_DefaultValue = new Pane();
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
		/// <p>The plotOptions is a wrapper object for config objects for each seriestype. The config objects for each series can also be overridden foreach series item as given in the series array.</p><p>Configuration options for the series are given in three levels. Optionsfor all series in a chart are given in the <a href="#plotOptions.series">plotOptions.series</a> object. Then options for all series of a specific type aregiven in the plotOptions of that type, for example plotOptions.line.Next, options for one single series are given in <a href="#series">the series array</a>.</p>
		/// </summary>
		public PlotOptions PlotOptions { get; set; }
		private PlotOptions PlotOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<Series> Series { get; set; }
		private List<Series> Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for configuring accessibility for the chart. Requires the<a href="//code.highcharts.com/modules/accessibility.js">accessibility module</a> to be loaded. For a description of the module and informationon its features, see <a href="http://www.highcharts.com/docs/chart-concepts/accessibility">Highcharts Accessibility</a>.</p>
		/// </summary>
		public Accessibility Accessibility { get; set; }
		private Accessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options regarding the chart area and plot area as well as generalchart options.</p>
		/// </summary>
		public Chart Chart { get; set; }
		private Chart Chart_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The legend is a box containing a symbol and name for each seriesitem or point item in the chart. Each series (or points in caseof pie charts) is represented by a symbol and its name in the legend.</p><p>It is possible to override the symbol creator function andcreate <a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/studies/legend-custom-symbol/">custom legend symbols</a>.</p>
		/// </summary>
		public Legend Legend { get; set; }
		private Legend Legend_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Styled mode only. Configuration object for adding SVG definitions forreusable elements. See <a href="http://www.highcharts.com/docs/chart-design-and-style/gradients-shadows-and-patterns">gradients, shadows and patterns</a> for more information and code examples.</p>
		/// </summary>
		public Defs Defs { get; set; }
		private Defs Defs_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for configuring annotations, for example labels, arrows or shapes. Annotations can be tied to points, axis coordinates or chartpixel coordinates.</p>
		/// </summary>
		public Annotations Annotations { get; set; }
		private Annotations Annotations_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the Boost module. The Boost module allows certain series typesto be rendered by WebGL instead of the default SVG. This allows hundreds ofthousands of data points to be rendered in milliseconds. In addition to theWebGL rendering it saves time by skipping processing and inspection of thedata wherever possible.</p><p>In addition to the global <code>boost</code> option, each series has a<a href="#plotOptions.series.boostThreshold">boostThreshold</a> that defines when theboost should kick in.</p><p>Requires the <code>modules/boost.js</code> module.</p>
		/// </summary>
		public Boost Boost { get; set; }
		private Boost Boost_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>This option set extends the defaultOptions for Y axes.</p>
		/// </summary>
		public List<YAxis> YAxis { get; set; }
		private List<YAxis> YAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Language object. The language object is global and it can&#39;t be seton each chart initiation. Instead, use <code>Highcharts.setOptions</code> toset it before any chart is initialized.</p><pre>Highcharts.setOptions({    lang: {        months: [            'Janvier', 'Février', 'Mars', 'Avril',            'Mai', 'Juin', 'Juillet', 'Août',            'Septembre', 'Octobre', 'Novembre', 'Décembre'        ],        weekdays: [            'Dimanche', 'Lundi', 'Mardi', 'Mercredi',            'Jeudi', 'Vendredi', 'Samedi'        ]    }});</pre>
		/// </summary>
		public Lang Lang { get; set; }
		private Lang Lang_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for drill down, the concept of inspecting increasingly high resolution data through clicking on chart items like columns or pie slices.</p><p>The drilldown feature requires the drilldown.js file to be loaded, found in the modules directory of the download package, or online at (code.highcharts.com/modules/drilldown.js)[code.highcharts.com/modules/drilldown.js].</p>
		/// </summary>
		public Drilldown Drilldown { get; set; }
		private Drilldown Drilldown_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the exporting module. For an overview on the matter, see <a href="http://www.highcharts.com/docs/export-module/export-module-overview">the docs</a>.</p>
		/// </summary>
		public Exporting Exporting { get; set; }
		private Exporting Exporting_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A collection of options for buttons and menus appearing in the exporting module.</p>
		/// </summary>
		public Navigation Navigation { get; set; }
		private Navigation Navigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for displaying a message like &quot;No data to display&quot;. This feature requires the file no-data-to-display.js to be loaded in the page. The actual text to display is set in the lang.noData option.</p>
		/// </summary>
		public NoData NoData { get; set; }
		private NoData NoData_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Global options that don&#39;t apply to each chart. These options, likethe <code>lang</code> options, must be set using the <code>Highcharts.setOptions</code>method.</p><pre>Highcharts.setOptions({    global: {        useUTC: false    }});</pre>
		/// </summary>
		public Global Global { get; set; }
		private Global Global_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options to render axis in 3 dimensions.</p>
		/// </summary>
		public List<XAxis> XAxis { get; set; }
		private List<XAxis> XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The navigator is a small series below the main series, displayinga view of the entire data set. It provides tools to zoom in andout on parts of the data as well as panning across the dataset.</p>
		/// </summary>
		public Navigator Navigator { get; set; }
		private Navigator Navigator_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array containing the default colors for the chart&#39;s series. Whenall colors are used, new colors are pulled from the start again.</p><p>Default colors can also be set on a series or series.type basis,see <a href="#plotOptions.column.colors">column.colors</a>, <a href="#plotOptions.pie.colors">pie.colors</a>.</p><p>In styled mode, the colors option doesn&#39;t exist. Instead, colorsare defined in CSS and applied either through series or point classnames, or through the <a href="#chart.colorCount">chart.colorCount</a> option.</p><h3 id="legacy">Legacy</h3><p>In Highcharts 3.x, the default colors were:</p><pre>colors: ['#2f7ed8', '#0d233a', '#8bbc21', '#910000', '#1aadce',     '#492970', '#f28f43', '#77a1e5', '#c42525', '#a6c96a']</pre> <p>In Highcharts 2.x, the default colors were:</p><pre>colors: ['#4572A7', '#AA4643', '#89A54E', '#80699B', '#3D96AE',    '#DB843D', '#92A8CD', '#A47D7C', '#B5CA92']</pre>
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The chart&#39;s main title.</p>
		/// </summary>
		public Title Title { get; set; }
		private Title Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The chart&#39;s subtitle. This can be used both to display a subtitle belowthe main title, and to display random text anywhere in the chart. Thesubtitle can be updated after chart initialization through the <code>Chart.setTitle</code> method.</p>
		/// </summary>
		public Subtitle Subtitle { get; set; }
		private Subtitle Subtitle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>HTML labels that can be positioned anywhere in the chart area.</p>
		/// </summary>
		public Labels Labels { get; set; }
		private Labels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The loading options control the appearance of the loading screenthat covers the plot area on chart operations. This screen onlyappears after an explicit call to <code>chart.showLoading()</code>. It is autility for developers to communicate to the end user that somethingis going on, for example while retrieving new data via an XHR connection.The &quot;Loading...&quot; text itself is not part of this configurationobject, but part of the <code>lang</code> object.</p>
		/// </summary>
		public Loading Loading { get; set; }
		private Loading Loading_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the tooltip that appears when the user hovers over aseries or point.</p>
		/// </summary>
		public Tooltip Tooltip { get; set; }
		private Tooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Highchart by default puts a credits label in the lower right cornerof the chart. This can be changed using these options.</p>
		/// </summary>
		public Credits Credits { get; set; }
		private Credits Credits_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The range selector is a tool for selecting ranges to display withinthe chart. It provides buttons to select preconfigured ranges inthe chart, like 1 day, 1 week, 1 month etc. It also provides inputboxes where min and max dates can be manually input.</p>
		/// </summary>
		public RangeSelector RangeSelector { get; set; }
		private RangeSelector RangeSelector_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Allows setting a set of rules to apply for different screen or chartsizes. Each rule specifies additional chart options.</p>
		/// </summary>
		public Responsive Responsive { get; set; }
		private Responsive Responsive_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The scrollbar is a means of panning over the X axis of a stock chart.</p><p>In styled mode, all the presentational options for thescrollbar are replaced by the classes <code>.highcharts-scrollbar-thumb</code>,<code>.highcharts-scrollbar-arrow</code>, <code>.highcharts-scrollbar-button</code>,<code>.highcharts-scrollbar-rifles</code> and <code>.highcharts-scrollbar-track</code>.</p>
		/// </summary>
		public Scrollbar Scrollbar { get; set; }
		private Scrollbar Scrollbar_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pane serves as a container for axes and backgrounds for circular gauges and polar charts.</p>
		/// </summary>
		public Pane Pane { get; set; }
		private Pane Pane_DefaultValue { get; set; }
		 

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

			if (PlotOptions.IsDirty()) h.Add("plotOptions",PlotOptions.ToHashtable());
			if (Series != Series_DefaultValue) h.Add("series",Series);
			if (Accessibility.IsDirty()) h.Add("accessibility",Accessibility.ToHashtable());
			if (Chart.IsDirty()) h.Add("chart",Chart.ToHashtable());
			if (Legend.IsDirty()) h.Add("legend",Legend.ToHashtable());
			if (Defs.IsDirty()) h.Add("defs",Defs.ToHashtable());
			if (Annotations.IsDirty()) h.Add("annotations",Annotations.ToHashtable());
			if (Boost.IsDirty()) h.Add("boost",Boost.ToHashtable());
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis", HashifyList(YAxis));
			if (Lang.IsDirty()) h.Add("lang",Lang.ToHashtable());
			if (Drilldown.IsDirty()) h.Add("drilldown",Drilldown.ToHashtable());
			if (Exporting.IsDirty()) h.Add("exporting",Exporting.ToHashtable());
			if (Navigation.IsDirty()) h.Add("navigation",Navigation.ToHashtable());
			if (NoData.IsDirty()) h.Add("noData",NoData.ToHashtable());
			if (Global.IsDirty()) h.Add("global",Global.ToHashtable());
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis", HashifyList(XAxis));
			if (Navigator.IsDirty()) h.Add("navigator",Navigator.ToHashtable());
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (Subtitle.IsDirty()) h.Add("subtitle",Subtitle.ToHashtable());
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (Loading.IsDirty()) h.Add("loading",Loading.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (Credits.IsDirty()) h.Add("credits",Credits.ToHashtable());
			if (RangeSelector.IsDirty()) h.Add("rangeSelector",RangeSelector.ToHashtable());
			if (Responsive.IsDirty()) h.Add("responsive",Responsive.ToHashtable());
			if (Scrollbar.IsDirty()) h.Add("scrollbar",Scrollbar.ToHashtable());
			if (Pane.IsDirty()) h.Add("pane",Pane.ToHashtable());
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
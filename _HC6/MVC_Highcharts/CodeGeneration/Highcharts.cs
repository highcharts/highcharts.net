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
			PlotOptions = PlotOptions_DefaultValue = "";
			Series = Series_DefaultValue = new List<Series>();
			Defs = Defs_DefaultValue = "";
			Annotations = Annotations_DefaultValue = new List<Annotations>();
			Boost = Boost_DefaultValue = "";
			Data = Data_DefaultValue = new Data();
			YAxis = YAxis_DefaultValue = new List<YAxis>();
			Lang = Lang_DefaultValue = "";
			Drilldown = Drilldown_DefaultValue = "";
			Chart = Chart_DefaultValue = "";
			Exporting = Exporting_DefaultValue = "";
			Navigation = Navigation_DefaultValue = "";
			KeyboardNavigation = KeyboardNavigation_DefaultValue = "";
			Legend = Legend_DefaultValue = "";
			NoData = NoData_DefaultValue = "";
			Global = Global_DefaultValue = "";
			Accessibility = Accessibility_DefaultValue = "";
			XAxis = XAxis_DefaultValue = new List<XAxis>();
			Colors = Colors_DefaultValue = new List<string>();
			Title = Title_DefaultValue = "";
			Subtitle = Subtitle_DefaultValue = "";
			Labels = Labels_DefaultValue = "";
			Loading = Loading_DefaultValue = "";
			Tooltip = Tooltip_DefaultValue = "";
			Credits = Credits_DefaultValue = "";
			Responsive = Responsive_DefaultValue = "";
			Pane = Pane_DefaultValue = "";
			ColorAxis = ColorAxis_DefaultValue = "";
			ZAxis = ZAxis_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// The plotOptions is a wrapper object for config objects for each seriestype. The config objects for each series can also be overridden foreach series item as given in the series array.Configuration options for the series are given in three levels. Optionsfor all series in a chart are given in the [plotOptions.series](#plotOptions.series) object. Then options for all series of a specific type aregiven in the plotOptions of that type, for example plotOptions.line.Next, options for one single series are given in [the series array](#series).
		/// </summary>
		public HighchartsPlotOptions PlotOptions { get; set; }
		private HighchartsPlotOptions PlotOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<Series> Series { get; set; }
		private List<Series> Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styled mode only. Configuration object for adding SVG definitions forreusable elements. See [gradients, shadows and patterns](http://www.highcharts.com/docs/chart-design-and-style/gradients-shadows-and-patterns) for more information and code examples.
		/// </summary>
		public HighchartsDefs Defs { get; set; }
		private HighchartsDefs Defs_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for configuring annotations, for example labels, arrows or shapes. Annotations can be tied to points, axis coordinates or chartpixel coordinates.
		/// </summary>
		public List<Annotations> Annotations { get; set; }
		private List<Annotations> Annotations_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the Boost module. The Boost module allows certain series typesto be rendered by WebGL instead of the default SVG. This allows hundreds ofthousands of data points to be rendered in milliseconds. In addition to theWebGL rendering it saves time by skipping processing and inspection of thedata wherever possible. This introduces some limitations to what features areavailable in Boost mode. See [the docs](https://www.highcharts.com/docs/advanced-chart-features/boost-module)for details.In addition to the global `boost` option, each series has a[boostThreshold](#plotOptions.series.boostThreshold) that defines when theboost should kick in.Requires the `modules/boost.js` module.
		/// </summary>
		public HighchartsBoost Boost { get; set; }
		private HighchartsBoost Boost_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Data module provides a simplified interface for adding data toa chart from sources like CVS, HTML tables or grid views. See alsothe [tutorial article on the Data module](http://www.highcharts.com/docs/working-with-data/data-module).It requires the `modules/data.js` file to be loaded.Please note that the default way of adding data in Highcharts, withoutthe need of a module, is through the [series.data](#series.data)option.
		/// </summary>
		public Data Data { get; set; }
		private Data Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Y axis or value axis. Normally this is the vertical axis,though if the chart is inverted this is the horizontal axis.In case of multiple axes, the yAxis node is an array ofconfiguration objects.See [the Axis object](#Axis) for programmatic access to the axis.
		/// </summary>
		public List<YAxis> YAxis { get; set; }
		private List<YAxis> YAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// Language object. The language object is global and it can't be seton each chart initiation. Instead, use `Highcharts.setOptions` toset it before any chart is initialized.<pre>Highcharts.setOptions({    lang: {        months: [            'Janvier', 'Février', 'Mars', 'Avril',            'Mai', 'Juin', 'Juillet', 'Août',            'Septembre', 'Octobre', 'Novembre', 'Décembre'        ],        weekdays: [            'Dimanche', 'Lundi', 'Mardi', 'Mercredi',            'Jeudi', 'Vendredi', 'Samedi'        ]    }});</pre>
		/// </summary>
		public HighchartsLang Lang { get; set; }
		private HighchartsLang Lang_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for drill down, the concept of inspecting increasingly high resolution data through clicking on chart items like columns or pie slices.The drilldown feature requires the drilldown.js file to be loaded, found in the modules directory of the download package, or online at (code.highcharts.com/modules/drilldown.js)[code.highcharts.com/modules/drilldown.js].
		/// </summary>
		public HighchartsDrilldown Drilldown { get; set; }
		private HighchartsDrilldown Drilldown_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options regarding the chart area and plot area as well as generalchart options.
		/// </summary>
		public HighchartsChart Chart { get; set; }
		private HighchartsChart Chart_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the exporting module. For an overview on the matter, see [the docs](http://www.highcharts.com/docs/export-module/export-module-overview).
		/// </summary>
		public HighchartsExporting Exporting { get; set; }
		private HighchartsExporting Exporting_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of options for buttons and menus appearing in the exporting module.
		/// </summary>
		public HighchartsNavigation Navigation { get; set; }
		private HighchartsNavigation Navigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public HighchartsKeyboardNavigation KeyboardNavigation { get; set; }
		private HighchartsKeyboardNavigation KeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The legend is a box containing a symbol and name for each seriesitem or point item in the chart. Each series (or points in caseof pie charts) is represented by a symbol and its name in the legend. It is possible to override the symbol creator function andcreate [custom legend symbols](http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/studies/legend-custom-symbol/).
		/// </summary>
		public HighchartsLegend Legend { get; set; }
		private HighchartsLegend Legend_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for displaying a message like "No data to display". This feature requires the file no-data-to-display.js to be loaded in the page. The actual text to display is set in the lang.noData option.
		/// </summary>
		public HighchartsNoData NoData { get; set; }
		private HighchartsNoData NoData_DefaultValue { get; set; }
		 

		/// <summary>
		/// Global options that don't apply to each chart. These options, likethe `lang` options, must be set using the `Highcharts.setOptions`method.<pre>Highcharts.setOptions({    global: {        useUTC: false    }});</pre>
		/// </summary>
		public HighchartsGlobal Global { get; set; }
		private HighchartsGlobal Global_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for configuring accessibility for the chart. Requires the[accessibility module](//code.highcharts.com/modules/accessibility.js) to be loaded. For a description of the module and informationon its features, see [Highcharts Accessibility](http://www.highcharts.com/docs/chart-concepts/accessibility).
		/// </summary>
		public HighchartsAccessibility Accessibility { get; set; }
		private HighchartsAccessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// The X axis or category axis. Normally this is the horizontal axis,though if the chart is inverted this is the vertical axis. In case ofmultiple axes, the xAxis node is an array of configuration objects.See [the Axis object](#Axis) for programmatic access to the axis.
		/// </summary>
		public List<XAxis> XAxis { get; set; }
		private List<XAxis> XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array containing the default colors for the chart's series. Whenall colors are used, new colors are pulled from the start again.Default colors can also be set on a series or series.type basis,see [column.colors](#plotOptions.column.colors), [pie.colors](#plotOptions.pie.colors).In styled mode, the colors option doesn't exist. Instead, colorsare defined in CSS and applied either through series or point classnames, or through the [chart.colorCount](#chart.colorCount) option.### LegacyIn Highcharts 3.x, the default colors were:<pre>colors: ['#2f7ed8', '#0d233a', '#8bbc21', '#910000', '#1aadce',     '#492970', '#f28f43', '#77a1e5', '#c42525', '#a6c96a']</pre> In Highcharts 2.x, the default colors were:<pre>colors: ['#4572A7', '#AA4643', '#89A54E', '#80699B', '#3D96AE',    '#DB843D', '#92A8CD', '#A47D7C', '#B5CA92']</pre>
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// The chart's main title.
		/// </summary>
		public HighchartsTitle Title { get; set; }
		private HighchartsTitle Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// The chart's subtitle. This can be used both to display a subtitle belowthe main title, and to display random text anywhere in the chart. Thesubtitle can be updated after chart initialization through the `Chart.setTitle` method.
		/// </summary>
		public HighchartsSubtitle Subtitle { get; set; }
		private HighchartsSubtitle Subtitle_DefaultValue { get; set; }
		 

		/// <summary>
		/// HTML labels that can be positioned anywhere in the chart area.
		/// </summary>
		public HighchartsLabels Labels { get; set; }
		private HighchartsLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// The loading options control the appearance of the loading screenthat covers the plot area on chart operations. This screen onlyappears after an explicit call to `chart.showLoading()`. It is autility for developers to communicate to the end user that somethingis going on, for example while retrieving new data via an XHR connection.The "Loading..." text itself is not part of this configurationobject, but part of the `lang` object.
		/// </summary>
		public HighchartsLoading Loading { get; set; }
		private HighchartsLoading Loading_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the tooltip that appears when the user hovers over aseries or point.
		/// </summary>
		public HighchartsTooltip Tooltip { get; set; }
		private HighchartsTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Highchart by default puts a credits label in the lower right cornerof the chart. This can be changed using these options.
		/// </summary>
		public HighchartsCredits Credits { get; set; }
		private HighchartsCredits Credits_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allows setting a set of rules to apply for different screen or chartsizes. Each rule specifies additional chart options.
		/// </summary>
		public HighchartsResponsive Responsive { get; set; }
		private HighchartsResponsive Responsive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pane serves as a container for axes and backgrounds for circular gauges and polar charts.
		/// </summary>
		public HighchartsPane Pane { get; set; }
		private HighchartsPane Pane_DefaultValue { get; set; }
		 

		/// <summary>
		/// A color axis for choropleth maps and heat maps. Visually, the color axiswill appear as a gradient or as separate items inside the legend,depending on whether the axis is scalar or based on data classes.For supported color formats, see the [docs article about colors](http://www.highcharts.com/docs/chart-design-and-style/colors).A scalar color axis is represented by a gradient. The colors either rangebetween the [minColor](#colorAxis.minColor) and the [maxColor](#colorAxis.maxColor),or for more fine grained control the colors can bedefined in [stops](#colorAxis.stops). Often times, the color axis needsto be adjusted to get the right color spread for the data. In addition tostops, consider using a logarithmic [axis type](#colorAxis.type), orsetting [min](#colorAxis.min) and [max](#colorAxis.max) to avoid thecolors being determined by outliers.When [dataClasses](#colorAxis.dataClasses) are used, the ranges aresubdivided into separate classes like categories based on their values.This can be used for ranges between two values, but also for a truecategory. However, when your data is categorized, it may be as convenientto add each category to a separate series.See [the Axis object](#Axis) for programmatic access to the axis.
		/// </summary>
		public HighchartsColorAxis ColorAxis { get; set; }
		private HighchartsColorAxis ColorAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z axis or depth axis for 3D plots.See [the Axis object](#Axis) for programmatic access to the axis.
		/// </summary>
		public HighchartsZAxis ZAxis { get; set; }
		private HighchartsZAxis ZAxis_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (PlotOptions != PlotOptions_DefaultValue) h.Add("plotOptions",PlotOptions);
			if (Series != Series_DefaultValue) h.Add("series", HashifyList(Series));
			if (Defs != Defs_DefaultValue) h.Add("defs",Defs);
			if (Annotations != Annotations_DefaultValue) h.Add("annotations", HashifyList(Annotations));
			if (Boost != Boost_DefaultValue) h.Add("boost",Boost);
			if (Data.IsDirty()) h.Add("data",Data.ToHashtable());
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis", HashifyList(YAxis));
			if (Lang != Lang_DefaultValue) h.Add("lang",Lang);
			if (Drilldown != Drilldown_DefaultValue) h.Add("drilldown",Drilldown);
			if (Chart != Chart_DefaultValue) h.Add("chart",Chart);
			if (Exporting != Exporting_DefaultValue) h.Add("exporting",Exporting);
			if (Navigation != Navigation_DefaultValue) h.Add("navigation",Navigation);
			if (KeyboardNavigation != KeyboardNavigation_DefaultValue) h.Add("keyboardNavigation",KeyboardNavigation);
			if (Legend != Legend_DefaultValue) h.Add("legend",Legend);
			if (NoData != NoData_DefaultValue) h.Add("noData",NoData);
			if (Global != Global_DefaultValue) h.Add("global",Global);
			if (Accessibility != Accessibility_DefaultValue) h.Add("accessibility",Accessibility);
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis", HashifyList(XAxis));
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (Title != Title_DefaultValue) h.Add("title",Title);
			if (Subtitle != Subtitle_DefaultValue) h.Add("subtitle",Subtitle);
			if (Labels != Labels_DefaultValue) h.Add("labels",Labels);
			if (Loading != Loading_DefaultValue) h.Add("loading",Loading);
			if (Tooltip != Tooltip_DefaultValue) h.Add("tooltip",Tooltip);
			if (Credits != Credits_DefaultValue) h.Add("credits",Credits);
			if (Responsive != Responsive_DefaultValue) h.Add("responsive",Responsive);
			if (Pane != Pane_DefaultValue) h.Add("pane",Pane);
			if (ColorAxis != ColorAxis_DefaultValue) h.Add("colorAxis",ColorAxis);
			if (ZAxis != ZAxis_DefaultValue) h.Add("zAxis",ZAxis);
			

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
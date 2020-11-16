using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class Highstock  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Highstock()
		{
			Accessibility = Accessibility_DefaultValue = new Accessibility();
			Annotations = Annotations_DefaultValue = new List<Annotations>();
			Boost = Boost_DefaultValue = new Boost();
			Caption = Caption_DefaultValue = new Caption();
			Chart = Chart_DefaultValue = new Chart();
			ColorAxis = ColorAxis_DefaultValue = new ColorAxis();
			Colors = Colors_DefaultValue = new List<string>();
			Credits = Credits_DefaultValue = new Credits();
			Data = Data_DefaultValue = new Data();
			Defs = Defs_DefaultValue = new Defs();
			Exporting = Exporting_DefaultValue = new Exporting();
			Global = Global_DefaultValue = new Global();
			Labels = Labels_DefaultValue = new Labels();
			Lang = Lang_DefaultValue = new Lang();
			Legend = Legend_DefaultValue = new Legend();
			Loading = Loading_DefaultValue = new Loading();
			Navigation = Navigation_DefaultValue = new Navigation();
			Navigator = Navigator_DefaultValue = new Navigator();
			NoData = NoData_DefaultValue = new NoData();
			PlotOptions = PlotOptions_DefaultValue = new PlotOptions();
			RangeSelector = RangeSelector_DefaultValue = new RangeSelector();
			Responsive = Responsive_DefaultValue = new Responsive();
			Scrollbar = Scrollbar_DefaultValue = new Scrollbar();
			Series = Series_DefaultValue = new List<Series>();
			StockTools = StockTools_DefaultValue = new StockTools();
			Subtitle = Subtitle_DefaultValue = new Subtitle();
			Time = Time_DefaultValue = new Time();
			Title = Title_DefaultValue = new Title();
			Tooltip = Tooltip_DefaultValue = new Tooltip();
			XAxis = XAxis_DefaultValue = new List<XAxis>();
			YAxis = YAxis_DefaultValue = new List<YAxis>();
			
		}	
		

		/// <summary>
		/// Options for configuring accessibility for the chart. Requires the[accessibility module](https://code.highcharts.com/modules/accessibility.js)to be loaded. For a description of the module and informationon its features, see[Highcharts Accessibility](https://www.highcharts.com/docs/accessibility/accessibility-module).
		/// </summary>
		public Accessibility Accessibility { get; set; }
		private Accessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// A basic type of an annotation. It allows to add custom labelsor shapes. The items  can be tied to points, axis coordinatesor chart pixel coordinates.
		/// </summary>
		public List<Annotations> Annotations { get; set; }
		private List<Annotations> Annotations_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Boost Boost { get; set; }
		private Boost Boost_DefaultValue { get; set; }
		 

		/// <summary>
		/// The chart's caption, which will render below the chart and will be partof exported charts. The caption can be updated after chart initializationthrough the `Chart.update` or `Chart.caption.update` methods.
		/// </summary>
		public Caption Caption { get; set; }
		private Caption Caption_DefaultValue { get; set; }
		 

		/// <summary>
		/// General options for the chart.
		/// </summary>
		public Chart Chart { get; set; }
		private Chart Chart_DefaultValue { get; set; }
		 

		/// <summary>
		/// A color axis for series. Visually, the coloraxis will appear as a gradient or as separate items inside thelegend, depending on whether the axis is scalar or based on dataclasses.For supported color formats, see the[docs article about colors](https://www.highcharts.com/docs/chart-design-and-style/colors).A scalar color axis is represented by a gradient. The colors eitherrange between the [minColor](#colorAxis.minColor) and the[maxColor](#colorAxis.maxColor), or for more fine grained control thecolors can be defined in [stops](#colorAxis.stops). Often times, thecolor axis needs to be adjusted to get the right color spread for thedata. In addition to stops, consider using a logarithmic[axis type](#colorAxis.type), or setting [min](#colorAxis.min) and[max](#colorAxis.max) to avoid the colors being determined byoutliers.When [dataClasses](#colorAxis.dataClasses) are used, the ranges aresubdivided into separate classes like categories based on theirvalues. This can be used for ranges between two values, but also fora true category. However, when your data is categorized, it may be asconvenient to add each category to a separate series.Color axis does not work with: `sankey`, `sunburst`, `dependencywheel`,`networkgraph`, `wordcloud`, `venn`, `gauge` and `solidgauge` seriestypes.Since v7.2.0 `colorAxis` can also be an array of options objects.See [the Axis object](/class-reference/Highcharts.Axis) forprogrammatic access to the axis.
		/// </summary>
		public ColorAxis ColorAxis { get; set; }
		private ColorAxis ColorAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array containing the default colors for the chart's series. Whenall colors are used, new colors are pulled from the start again.Default colors can also be set on a series or series.type basis,see [column.colors](#plotOptions.column.colors),[pie.colors](#plotOptions.pie.colors).In styled mode, the colors option doesn't exist. Instead, colorsare defined in CSS and applied either through series or point classnames, or through the [chart.colorCount](#chart.colorCount) option.### LegacyIn Highcharts 3.x, the default colors were:```jscolors: ['#2f7ed8', '#0d233a', '#8bbc21', '#910000', '#1aadce',        '#492970', '#f28f43', '#77a1e5', '#c42525', '#a6c96a']```In Highcharts 2.x, the default colors were:```jscolors: ['#4572A7', '#AA4643', '#89A54E', '#80699B', '#3D96AE',        '#DB843D', '#92A8CD', '#A47D7C', '#B5CA92']```
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// Highchart by default puts a credits label in the lower right cornerof the chart. This can be changed using these options.
		/// </summary>
		public Credits Credits { get; set; }
		private Credits Credits_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Data module provides a simplified interface for adding data toa chart from sources like CVS, HTML tables or grid views. See alsothe [tutorial article on the Data module](https://www.highcharts.com/docs/working-with-data/data-module).It requires the `modules/data.js` file to be loaded.Please note that the default way of adding data in Highcharts, withoutthe need of a module, is through the [series._type_.data](#series.line.data)option.
		/// </summary>
		public Data Data { get; set; }
		private Data Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for configuring markers for annotations.An example of the arrow marker:<pre>{  arrow: {    id: 'arrow',    tagName: 'marker',    refY: 5,    refX: 5,    markerWidth: 10,    markerHeight: 10,    children: [{      tagName: 'path',      attrs: {        d: 'M 0 0 L 10 5 L 0 10 Z',        strokeWidth: 0      }    }]  }}</pre>
		/// </summary>
		public Defs Defs { get; set; }
		private Defs Defs_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the exporting module. For an overview on the matter, see[the docs](https://www.highcharts.com/docs/export-module/export-module-overview).
		/// </summary>
		public Exporting Exporting { get; set; }
		private Exporting Exporting_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Global Global { get; set; }
		private Global Global_DefaultValue { get; set; }
		 

		/// <summary>
		/// HTML labels that can be positioned anywhere in the chart area.This option is deprecated since v7.1.2. Instead, use[annotations](#annotations) that support labels.
		/// </summary>
		public Labels Labels { get; set; }
		private Labels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Language object. The language object is global and it can't be seton each chart initialization. Instead, use `Highcharts.setOptions` toset it before any chart is initialized.```jsHighcharts.setOptions({    lang: {        months: [            'Janvier', 'Février', 'Mars', 'Avril',            'Mai', 'Juin', 'Juillet', 'Août',            'Septembre', 'Octobre', 'Novembre', 'Décembre'        ],        weekdays: [            'Dimanche', 'Lundi', 'Mardi', 'Mercredi',            'Jeudi', 'Vendredi', 'Samedi'        ]    }});```
		/// </summary>
		public Lang Lang { get; set; }
		private Lang Lang_DefaultValue { get; set; }
		 

		/// <summary>
		/// The legend is a box containing a symbol and name for each seriesitem or point item in the chart. Each series (or points in caseof pie charts) is represented by a symbol and its name in the legend.It is possible to override the symbol creator function and create[custom legend symbols](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/studies/legend-custom-symbol/).
		/// </summary>
		public Legend Legend { get; set; }
		private Legend Legend_DefaultValue { get; set; }
		 

		/// <summary>
		/// The loading options control the appearance of the loading screenthat covers the plot area on chart operations. This screen onlyappears after an explicit call to `chart.showLoading()`. It is autility for developers to communicate to the end user that somethingis going on, for example while retrieving new data via an XHR connection.The "Loading..." text itself is not part of this configurationobject, but part of the `lang` object.
		/// </summary>
		public Loading Loading { get; set; }
		private Loading Loading_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of options for buttons and menus appearing in the exportingmodule.
		/// </summary>
		public Navigation Navigation { get; set; }
		private Navigation Navigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The navigator is a small series below the main series, displayinga view of the entire data set. It provides tools to zoom in andout on parts of the data as well as panning across the dataset.
		/// </summary>
		public Navigator Navigator { get; set; }
		private Navigator Navigator_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for displaying a message like "No data to display".This feature requires the file no-data-to-display.js to be loaded in thepage. The actual text to display is set in the lang.noData option.
		/// </summary>
		public NoData NoData { get; set; }
		private NoData NoData_DefaultValue { get; set; }
		 

		/// <summary>
		/// The plotOptions is a wrapper object for config objects for each seriestype. The config objects for each series can also be overridden foreach series item as given in the series array.Configuration options for the series are given in three levels. Optionsfor all series in a chart are given in the [plotOptions.series](#plotOptions.series) object. Then options for all series of a specifictype are given in the plotOptions of that type, for example`plotOptions.line`. Next, options for one single series are given in[the series array](#series).
		/// </summary>
		public PlotOptions PlotOptions { get; set; }
		private PlotOptions PlotOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The range selector is a tool for selecting ranges to display withinthe chart. It provides buttons to select preconfigured ranges inthe chart, like 1 day, 1 week, 1 month etc. It also provides inputboxes where min and max dates can be manually input.
		/// </summary>
		public RangeSelector RangeSelector { get; set; }
		private RangeSelector RangeSelector_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allows setting a set of rules to apply for different screen or chartsizes. Each rule specifies additional chart options.
		/// </summary>
		public Responsive Responsive { get; set; }
		private Responsive Responsive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The scrollbar is a means of panning over the X axis of a stock chart.Scrollbars can  also be applied to other types of axes.Another approach to scrollable charts is the [chart.scrollablePlotArea](https://api.highcharts.com/highcharts/chart.scrollablePlotArea) option thatis especially suitable for simpler cartesian charts on mobile.In styled mode, all the presentational options for thescrollbar are replaced by the classes `.highcharts-scrollbar-thumb`,`.highcharts-scrollbar-arrow`, `.highcharts-scrollbar-button`,`.highcharts-scrollbar-rifles` and `.highcharts-scrollbar-track`.
		/// </summary>
		public Scrollbar Scrollbar { get; set; }
		private Scrollbar Scrollbar_DefaultValue { get; set; }
		 

		/// <summary>
		/// Series options for specific data and the data itself. In TypeScript youhave to cast the series options to specific series types, to get allpossible options for a series.
		/// </summary>
		public List<Series> Series { get; set; }
		private List<Series> Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// Configure the stockTools gui strings in the chart. Requires the[stockTools module]() to be loaded. For a description of the moduleand information on its features, see [Highcharts StockTools]().
		/// </summary>
		public StockTools StockTools { get; set; }
		private StockTools StockTools_DefaultValue { get; set; }
		 

		/// <summary>
		/// The chart's subtitle. This can be used both to display a subtitle belowthe main title, and to display random text anywhere in the chart. Thesubtitle can be updated after chart initialization through the`Chart.setTitle` method.
		/// </summary>
		public Subtitle Subtitle { get; set; }
		private Subtitle Subtitle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Time options that can apply globally or to individual charts. Thesesettings affect how `datetime` axes are laid out, how tooltips areformatted, how series[pointIntervalUnit](#plotOptions.series.pointIntervalUnit) works and howthe Highstock range selector handles time.The common use case is that all charts in the same Highcharts objectshare the same time settings, in which case the global settings are setusing `setOptions`.```js// Apply time settings globallyHighcharts.setOptions({    time: {        timezone: 'Europe/London'    }});// Apply time settings by instancevar chart = Highcharts.chart('container', {    time: {        timezone: 'America/New_York'    },    series: [{        data: [1, 4, 3, 5]    }]});// Use the Time objectconsole.log(       'Current time in New York',       chart.time.dateFormat('%Y-%m-%d %H:%M:%S', Date.now()));```Since v6.0.5, the time options were moved from the `global` obect to the`time` object, and time options can be set on each individual chart.
		/// </summary>
		public Time Time { get; set; }
		private Time Time_DefaultValue { get; set; }
		 

		/// <summary>
		/// The chart's main title.
		/// </summary>
		public Title Title { get; set; }
		private Title Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the tooltip that appears when the user hovers over aseries or point.
		/// </summary>
		public Tooltip Tooltip { get; set; }
		private Tooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The X axis or category axis. Normally this is the horizontal axis,though if the chart is inverted this is the vertical axis. In case ofmultiple axes, the xAxis node is an array of configuration objects.See the [Axis class](/class-reference/Highcharts.Axis) for programmaticaccess to the axis.
		/// </summary>
		public List<XAxis> XAxis { get; set; }
		private List<XAxis> XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Y axis or value axis. Normally this is the vertical axis,though if the chart is inverted this is the horizontal axis.In case of multiple axes, the yAxis node is an array ofconfiguration objects.See [the Axis object](/class-reference/Highcharts.Axis) for programmaticaccess to the axis.
		/// </summary>
		public List<YAxis> YAxis { get; set; }
		private List<YAxis> YAxis_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Accessibility.IsDirty()) h.Add("accessibility",Accessibility.ToHashtable());
			if (Annotations != Annotations_DefaultValue) h.Add("annotations", HashifyList(Annotations));
			if (Boost.IsDirty()) h.Add("boost",Boost.ToHashtable());
			if (Caption.IsDirty()) h.Add("caption",Caption.ToHashtable());
			if (Chart.IsDirty()) h.Add("chart",Chart.ToHashtable());
			if (ColorAxis.IsDirty()) h.Add("colorAxis",ColorAxis.ToHashtable());
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (Credits.IsDirty()) h.Add("credits",Credits.ToHashtable());
			if (Data.IsDirty()) h.Add("data",Data.ToHashtable());
			if (Defs.IsDirty()) h.Add("defs",Defs.ToHashtable());
			if (Exporting.IsDirty()) h.Add("exporting",Exporting.ToHashtable());
			if (Global.IsDirty()) h.Add("global",Global.ToHashtable());
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (Lang.IsDirty()) h.Add("lang",Lang.ToHashtable());
			if (Legend.IsDirty()) h.Add("legend",Legend.ToHashtable());
			if (Loading.IsDirty()) h.Add("loading",Loading.ToHashtable());
			if (Navigation.IsDirty()) h.Add("navigation",Navigation.ToHashtable());
			if (Navigator.IsDirty()) h.Add("navigator",Navigator.ToHashtable());
			if (NoData.IsDirty()) h.Add("noData",NoData.ToHashtable());
			if (PlotOptions.IsDirty()) h.Add("plotOptions",PlotOptions.ToHashtable());
			if (RangeSelector.IsDirty()) h.Add("rangeSelector",RangeSelector.ToHashtable());
			if (Responsive.IsDirty()) h.Add("responsive",Responsive.ToHashtable());
			if (Scrollbar.IsDirty()) h.Add("scrollbar",Scrollbar.ToHashtable());
			if (Series != Series_DefaultValue) h.Add("series", HashifyList(Series));
			if (StockTools.IsDirty()) h.Add("stockTools",StockTools.ToHashtable());
			if (Subtitle.IsDirty()) h.Add("subtitle",Subtitle.ToHashtable());
			if (Time.IsDirty()) h.Add("time",Time.ToHashtable());
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis", HashifyList(XAxis));
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis", HashifyList(YAxis));
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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
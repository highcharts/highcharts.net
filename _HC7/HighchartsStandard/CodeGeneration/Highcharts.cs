using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class Highcharts  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Highcharts()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Options for configuring accessibility for the chart. Requires the[accessibility module](https://code.highcharts.com/modules/accessibility.js)to be loaded. For a description of the module and informationon its features, see[Highcharts Accessibility](https://www.highcharts.com/docs/accessibility/accessibility-module).
		/// </summary>
		public Accessibility Accessibility { get; set; }
		 

		/// <summary>
		/// A basic type of an annotation. It allows to add custom labelsor shapes. The items can be tied to points, axis coordinatesor chart pixel coordinates.
		/// </summary>
		public List<Annotations> Annotations { get; set; }
		 

		/// <summary>
		/// Options for the Boost module. The Boost module allows certain series typesto be rendered by WebGL instead of the default SVG. This allows hundreds ofthousands of data points to be rendered in milliseconds. In addition to theWebGL rendering it saves time by skipping processing and inspection of thedata wherever possible. This introduces some limitations to what features areavailable in boost mode. See [the docs](https://www.highcharts.com/docs/advanced-chart-features/boost-module) fordetails.In addition to the global `boost` option, each series has a[boostThreshold](#plotOptions.series.boostThreshold) that defines when theboost should kick in.Requires the `modules/boost.js` module.
		/// </summary>
		public Boost Boost { get; set; }
		 

		/// <summary>
		/// The chart's caption, which will render below the chart and will be partof exported charts. The caption can be updated after chart initializationthrough the `Chart.update` or `Chart.caption.update` methods.
		/// </summary>
		public Caption Caption { get; set; }
		 

		/// <summary>
		/// General options for the chart.
		/// </summary>
		public Chart Chart { get; set; }
		 

		/// <summary>
		/// A color axis for series. Visually, the coloraxis will appear as a gradient or as separate items inside thelegend, depending on whether the axis is scalar or based on dataclasses.For supported color formats, see the[docs article about colors](https://www.highcharts.com/docs/chart-design-and-style/colors).A scalar color axis is represented by a gradient. The colors eitherrange between the [minColor](#colorAxis.minColor) and the[maxColor](#colorAxis.maxColor), or for more fine grained control thecolors can be defined in [stops](#colorAxis.stops). Often times, thecolor axis needs to be adjusted to get the right color spread for thedata. In addition to stops, consider using a logarithmic[axis type](#colorAxis.type), or setting [min](#colorAxis.min) and[max](#colorAxis.max) to avoid the colors being determined byoutliers.When [dataClasses](#colorAxis.dataClasses) are used, the ranges aresubdivided into separate classes like categories based on theirvalues. This can be used for ranges between two values, but also fora true category. However, when your data is categorized, it may be asconvenient to add each category to a separate series.Color axis does not work with: `sankey`, `sunburst`, `dependencywheel`,`networkgraph`, `wordcloud`, `venn`, `gauge` and `solidgauge` seriestypes.Since v7.2.0 `colorAxis` can also be an array of options objects.See [the Axis object](/class-reference/Highcharts.Axis) forprogrammatic access to the axis.
		/// </summary>
		public ColorAxis ColorAxis { get; set; }
		 

		/// <summary>
		/// An array containing the default colors for the chart's series. Whenall colors are used, new colors are pulled from the start again.Default colors can also be set on a series or series.type basis,see [column.colors](#plotOptions.column.colors),[pie.colors](#plotOptions.pie.colors).In styled mode, the colors option doesn't exist. Instead, colorsare defined in CSS and applied either through series or point classnames, or through the [chart.colorCount](#chart.colorCount) option.
		/// </summary>
		public List<string> Colors { get; set; }
		 

		/// <summary>
		/// Highchart by default puts a credits label in the lower right cornerof the chart. This can be changed using these options.
		/// </summary>
		public Credits Credits { get; set; }
		 

		/// <summary>
		/// The Data module provides a simplified interface for adding data toa chart from sources like CVS, HTML tables or grid views. See alsothe [tutorial article on the Data module](https://www.highcharts.com/docs/working-with-data/data-module).It requires the `modules/data.js` file to be loaded.Please note that the default way of adding data in Highcharts, withoutthe need of a module, is through the [series._type_.data](#series.line.data)option.
		/// </summary>
		public Data Data { get; set; }
		 

		/// <summary>
		/// Options for configuring markers for annotations.An example of the arrow marker:<pre>{  arrow: {    id: 'arrow',    tagName: 'marker',    refY: 5,    refX: 5,    markerWidth: 10,    markerHeight: 10,    children: [{      tagName: 'path',      attrs: {        d: 'M 0 0 L 10 5 L 0 10 Z',        'stroke-width': 0      }    }]  }}</pre>
		/// </summary>
		public Object Defs { get; set; }
		 

		/// <summary>
		/// Options for drill down, the concept of inspecting increasingly highresolution data through clicking on chart items like columns or pie slices.The drilldown feature requires the drilldown.js file to be loaded,found in the modules directory of the download package, or online at[code.highcharts.com/modules/drilldown.js](https://code.highcharts.com/modules/drilldown.js).
		/// </summary>
		public Drilldown Drilldown { get; set; }
		 

		/// <summary>
		/// Options for the exporting module. For an overview on the matter, see[the docs](https://www.highcharts.com/docs/export-module/export-module-overview).
		/// </summary>
		public Exporting Exporting { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Global Global { get; set; }
		 

		/// <summary>
		/// Language object. The language object is global and it can't be seton each chart initialization. Instead, use `Highcharts.setOptions` toset it before any chart is initialized.```jsHighcharts.setOptions({    lang: {        months: [            'Janvier', 'Février', 'Mars', 'Avril',            'Mai', 'Juin', 'Juillet', 'Août',            'Septembre', 'Octobre', 'Novembre', 'Décembre'        ],        weekdays: [            'Dimanche', 'Lundi', 'Mardi', 'Mercredi',            'Jeudi', 'Vendredi', 'Samedi'        ]    }});```
		/// </summary>
		public Lang Lang { get; set; }
		 

		/// <summary>
		/// The legend is a box containing a symbol and name for each seriesitem or point item in the chart. Each series (or points in caseof pie charts) is represented by a symbol and its name in the legend.It is possible to override the symbol creator function and create[custom legend symbols](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/studies/legend-custom-symbol/).
		/// </summary>
		public Legend Legend { get; set; }
		 

		/// <summary>
		/// The loading options control the appearance of the loading screenthat covers the plot area on chart operations. This screen onlyappears after an explicit call to `chart.showLoading()`. It is autility for developers to communicate to the end user that somethingis going on, for example while retrieving new data via an XHR connection.The "Loading..." text itself is not part of this configurationobject, but part of the `lang` object.
		/// </summary>
		public Loading Loading { get; set; }
		 

		/// <summary>
		/// A collection of options for buttons and menus appearing in the exportingmodule or in Stock Tools.
		/// </summary>
		public Navigation Navigation { get; set; }
		 

		/// <summary>
		/// Options for displaying a message like "No data to display".This feature requires the file no-data-to-display.js to be loaded in thepage. The actual text to display is set in the lang.noData option.
		/// </summary>
		public NoData NoData { get; set; }
		 

		/// <summary>
		/// The pane serves as a container for axes and backgrounds for circulargauges and polar charts.
		/// </summary>
		public Pane Pane { get; set; }
		 

		/// <summary>
		/// The plotOptions is a wrapper object for config objects for each seriestype. The config objects for each series can also be overridden foreach series item as given in the series array.Configuration options for the series are given in three levels. Optionsfor all series in a chart are given in the [plotOptions.series](#plotOptions.series) object. Then options for all series of a specifictype are given in the plotOptions of that type, for example`plotOptions.line`. Next, options for one single series are given in[the series array](#series).
		/// </summary>
		public PlotOptions PlotOptions { get; set; }
		 

		/// <summary>
		/// Allows setting a set of rules to apply for different screen or chartsizes. Each rule specifies additional chart options.
		/// </summary>
		public Responsive Responsive { get; set; }
		 

		/// <summary>
		/// Series options for specific data and the data itself. In TypeScript youhave to cast the series options to specific series types, to get allpossible options for a series.
		/// </summary>
		public List<Series> Series { get; set; }
		 

		/// <summary>
		/// Options for configuring sonification and audio charts. Requires the[sonification module](https://code.highcharts.com/modules/sonification.js)to be loaded.
		/// </summary>
		public Sonification Sonification { get; set; }
		 

		/// <summary>
		/// The chart's subtitle. This can be used both to display a subtitle belowthe main title, and to display random text anywhere in the chart. Thesubtitle can be updated after chart initialization through the`Chart.setTitle` method.
		/// </summary>
		public Subtitle Subtitle { get; set; }
		 

		/// <summary>
		/// Time options that can apply globally or to individual charts. Thesesettings affect how `datetime` axes are laid out, how tooltips areformatted, how series[pointIntervalUnit](#plotOptions.series.pointIntervalUnit) works and howthe Highcharts Stock range selector handles time.The common use case is that all charts in the same Highcharts objectshare the same time settings, in which case the global settings are setusing `setOptions`.```js// Apply time settings globallyHighcharts.setOptions({    time: {        timezone: 'Europe/London'    }});// Apply time settings by instancelet chart = Highcharts.chart('container', {    time: {        timezone: 'America/New_York'    },    series: [{        data: [1, 4, 3, 5]    }]});// Use the Time objectconsole.log(       'Current time in New York',       chart.time.dateFormat('%Y-%m-%d %H:%M:%S', Date.now()));```Since v6.0.5, the time options were moved from the `global` object to the`time` object, and time options can be set on each individual chart.
		/// </summary>
		public Time Time { get; set; }
		 

		/// <summary>
		/// The chart's main title.
		/// </summary>
		public Title Title { get; set; }
		 

		/// <summary>
		/// Options for the tooltip that appears when the user hovers over aseries or point.
		/// </summary>
		public Tooltip Tooltip { get; set; }
		 

		/// <summary>
		/// The X axis or category axis. Normally this is the horizontal axis,though if the chart is inverted this is the vertical axis. In case ofmultiple axes, the xAxis node is an array of configuration objects.See the [Axis class](/class-reference/Highcharts.Axis) for programmaticaccess to the axis.
		/// </summary>
		public List<XAxis> XAxis { get; set; }
		 

		/// <summary>
		/// The Y axis or value axis. Normally this is the vertical axis,though if the chart is inverted this is the horizontal axis.In case of multiple axes, the yAxis node is an array ofconfiguration objects.See [the Axis object](/class-reference/Highcharts.Axis) for programmaticaccess to the axis.
		/// </summary>
		public List<YAxis> YAxis { get; set; }
		 

		/// <summary>
		/// The Z axis or depth axis for 3D plots.See the [Axis class](/class-reference/Highcharts.Axis) for programmaticaccess to the axis.
		/// </summary>
		public ZAxis ZAxis { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (Annotations != null) h.Add("annotations", HashifyList(highcharts,Annotations));
			if (Boost != null) h.Add("boost",Boost.ToHashtable(highcharts));
			if (Caption != null) h.Add("caption",Caption.ToHashtable(highcharts));
			if (Chart != null) h.Add("chart",Chart.ToHashtable(highcharts));
			if (ColorAxis != null) h.Add("colorAxis",ColorAxis.ToHashtable(highcharts));
			if (Colors != null) h.Add("colors",Colors);
			if (Credits != null) h.Add("credits",Credits.ToHashtable(highcharts));
			if (Data != null) h.Add("data",Data.ToHashtable(highcharts));
			if (Defs != null) h.Add("defs",Defs);
			if (Drilldown != null) h.Add("drilldown",Drilldown.ToHashtable(highcharts));
			if (Exporting != null) h.Add("exporting",Exporting.ToHashtable(highcharts));
			if (Global != null) h.Add("global",Global.ToHashtable(highcharts));
			if (Lang != null) h.Add("lang",Lang.ToHashtable(highcharts));
			if (Legend != null) h.Add("legend",Legend.ToHashtable(highcharts));
			if (Loading != null) h.Add("loading",Loading.ToHashtable(highcharts));
			if (Navigation != null) h.Add("navigation",Navigation.ToHashtable(highcharts));
			if (NoData != null) h.Add("noData",NoData.ToHashtable(highcharts));
			if (Pane != null) h.Add("pane",Pane.ToHashtable(highcharts));
			if (PlotOptions != null) h.Add("plotOptions",PlotOptions.ToHashtable(highcharts));
			if (Responsive != null) h.Add("responsive",Responsive.ToHashtable(highcharts));
			if (Series != null) h.Add("series", HashifyList(highcharts,Series));
			if (Sonification != null) h.Add("sonification",Sonification.ToHashtable(highcharts));
			if (Subtitle != null) h.Add("subtitle",Subtitle.ToHashtable(highcharts));
			if (Time != null) h.Add("time",Time.ToHashtable(highcharts));
			if (Title != null) h.Add("title",Title.ToHashtable(highcharts));
			if (Tooltip != null) h.Add("tooltip",Tooltip.ToHashtable(highcharts));
			if (XAxis != null) h.Add("xAxis", HashifyList(highcharts,XAxis));
			if (YAxis != null) h.Add("yAxis", HashifyList(highcharts,YAxis));
			if (ZAxis != null) h.Add("zAxis",ZAxis.ToHashtable(highcharts));
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}
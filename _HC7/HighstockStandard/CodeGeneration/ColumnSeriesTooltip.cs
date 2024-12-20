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
	public partial class ColumnSeriesTooltip  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColumnSeriesTooltip()
		{
		}	
		

		/// <summary>
		/// How many decimals to show for the `point.change`or the `point.cumulativeSum` value when the `series.compare`or the `series.cumulative` option is set.This is overridable in each series' tooltip options object.
		/// </summary>
		public double? ChangeDecimals { get; set; }
		 

		/// <summary>
		/// The HTML of the cluster point's in the tooltip. Works only withmarker-clusters module and analogously to[pointFormat](#tooltip.pointFormat).The cluster tooltip can be also formatted using`tooltip.formatter` callback function and `point.isCluster` flag.
		/// </summary>
		public string ClusterFormat { get; set; }
		 

		/// <summary>
		/// For series on datetime axes, the date format in the tooltip'sheader will by default be guessed based on the closest data points.This member gives the default string representations used foreach unit. For an overview of the replacement codes, see[dateFormat](/class-reference/Highcharts.Time#dateFormat).
		/// </summary>
		public Hashtable DateTimeLabelFormats { get; set; }
		 

		/// <summary>
		/// Distance from point to tooltip in pixels.
		/// </summary>
		public double? Distance { get; set; }
		 

		/// <summary>
		/// Whether the tooltip should follow the mouse as it moves acrosscolumns, pie slices and other point types with an extent.By default it behaves this way for pie, polygon, map, sankeyand wordcloud series by override in the `plotOptions`for those series types.Does not apply if [split](#tooltip.split) is `true`.For touch moves to behave the same way, [followTouchMove](#tooltip.followTouchMove) must be `true` also.
		/// </summary>
		public bool? FollowPointer { get; set; }
		 

		/// <summary>
		/// Whether the tooltip should update as the finger moves on a touchdevice. If this is `true` and [chart.panning](#chart.panning) isset,`followTouchMove` will take over one-finger touches, so the userneeds to use two fingers for zooming and panning.Note the difference to [followPointer](#tooltip.followPointer) thatonly defines the _position_ of the tooltip. If `followPointer` isfalse in for example a column series, the tooltip will show above orbelow the column, but as `followTouchMove` is true, the tooltip willjump from column to column as the user swipes across the plot area.
		/// </summary>
		public bool? FollowTouchMove { get; set; }
		 

		/// <summary>
		/// A string to append to the tooltip format.
		/// </summary>
		public string FooterFormat { get; set; }
		 

		/// <summary>
		/// A [format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)for the whole shared tooltip. When format strings are a requirement,it is usually more convenient to use `headerFormat`, `pointFormat`and `footerFormat`, but the `format` option allows combining theminto one setting.The context of the format string is the same as that of the`tooltip.formatter` callback.
		/// </summary>
		public string Format { get; set; }
		 

		/// <summary>
		/// The HTML of the tooltip header line. Variables are enclosed bycurly brackets. Available variables are `point.key`, `series.name`,`series.color` and other members from the `point` and `series`objects. The `point.key` variable contains the category name, xvalue or datetime string depending on the type of axis. For datetimeaxes, the `point.key` date format can be set using`tooltip.xDateFormat`.
		/// </summary>
		public string HeaderFormat { get; set; }
		 

		/// <summary>
		/// The HTML of the null point's line in the tooltip. Works analogouslyto [pointFormat](#tooltip.pointFormat).
		/// </summary>
		public string NullFormat { get; set; }
		 

		/// <summary>
		/// Callback function to format the text of the tooltip forvisible null points.Works analogously to [formatter](#tooltip.formatter).
		/// </summary>
		public string NullFormatter { get; set; }
		 

		/// <summary>
		/// The HTML of the point's line in the tooltip. Variables are enclosedby curly brackets. Available variables are `point.x`, `point.y`,`series.name` and `series.color` and other properties on the sameform. Furthermore, `point.y` can be extended by the`tooltip.valuePrefix` and `tooltip.valueSuffix` variables. This canalso be overridden for each series, which makes it a good hook fordisplaying units.In styled mode, the dot is colored by a class name ratherthan the point color.
		/// </summary>
		public string PointFormat { get; set; }
		 

		/// <summary>
		/// A callback function for formatting the HTML output for a single pointin the tooltip. Like the `pointFormat` string, but with moreflexibility.
		/// </summary>
		public string PointFormatter { get; set; }
		 

		/// <summary>
		/// How many decimals to show in each series' y value. This isoverridable in each series' tooltip options object. The default is topreserve all decimals.
		/// </summary>
		public double? ValueDecimals { get; set; }
		 

		/// <summary>
		/// A string to prepend to each series' y value. Overridable in eachseries' tooltip options object.
		/// </summary>
		public string ValuePrefix { get; set; }
		 

		/// <summary>
		/// A string to append to each series' y value. Overridable in eachseries' tooltip options object.
		/// </summary>
		public string ValueSuffix { get; set; }
		 

		/// <summary>
		/// The format for the date in the tooltip header if the X axis is adatetime axis. The default is a best guess based on the smallestdistance between points in the chart.
		/// </summary>
		public string XDateFormat { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ChangeDecimals != null) h.Add("changeDecimals",ChangeDecimals);
			if (ClusterFormat != null) h.Add("clusterFormat",ClusterFormat);
			if (DateTimeLabelFormats != null) h.Add("dateTimeLabelFormats",DateTimeLabelFormats);
			if (Distance != null) h.Add("distance",Distance);
			if (FollowPointer != null) h.Add("followPointer",FollowPointer);
			if (FollowTouchMove != null) h.Add("followTouchMove",FollowTouchMove);
			if (FooterFormat != null) h.Add("footerFormat",FooterFormat);
			if (Format != null) h.Add("format",Format);
			if (HeaderFormat != null) h.Add("headerFormat",HeaderFormat);
			if (NullFormat != null) h.Add("nullFormat",NullFormat);
			if (NullFormatter != null) { h.Add("nullFormatter",NullFormatter); highstock.AddFunction("nullFormatter", NullFormatter); }  
			if (PointFormat != null) h.Add("pointFormat",PointFormat);
			if (PointFormatter != null) { h.Add("pointFormatter",PointFormatter); highstock.AddFunction("pointFormatter", PointFormatter); }  
			if (ValueDecimals != null) h.Add("valueDecimals",ValueDecimals);
			if (ValuePrefix != null) h.Add("valuePrefix",ValuePrefix);
			if (ValueSuffix != null) h.Add("valueSuffix",ValueSuffix);
			if (XDateFormat != null) h.Add("xDateFormat",XDateFormat);
			if (CustomFields != null && CustomFields.Count > 0)
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
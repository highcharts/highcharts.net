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
	public partial class PlotOptionsColumnrangeDataGrouping  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsColumnrangeDataGrouping()
		{
		}	
		

		/// <summary>
		/// Specifies how the points should be located on the X axis inside the group.Points that are extremes can be set separately. Available options:- `start` places the point at the beginning of the group(e.g. range 00:00:00 - 23:59:59 -> 00:00:00)- `middle` places the point in the middle of the group(e.g. range 00:00:00 - 23:59:59 -> 12:00:00)- `end` places the point at the end of the group(e.g. range 00:00:00 - 23:59:59 -> 23:59:59)
		/// </summary>
		public string Anchor { get; set; }
		 

		/// <summary>
		/// The method of approximation inside a group. When for example 30 daysare grouped into one month, this determines what value should representthe group. Possible values are "average", "averages", "open", "high","low", "close" and "sum". For OHLC and candlestick series the approximationis "ohlc" by default, which finds the open, high, low and close valueswithin all the grouped data. For ranges, the approximation is "range",which finds the low and high values. For multi-dimensional data,like ranges and OHLC, "averages" will compute the average for eachdimension.Custom aggregate methods can be added by assigning a callback functionas the approximation. This function takes a numeric array as theargument and should return a single numeric value or `null`. Notethat the numeric array will never contain null values, only truenumbers. Instead, if null values are present in the raw data, thenumeric array will have an `.hasNulls` property set to `true`. Forsingle-value data sets the data is available in the first argumentof the callback function. For OHLC data sets, all the open valuesare in the first argument, all high values in the second etc.Since v4.2.7, grouping meta data is available in the approximationcallback from `this.dataGroupInfo`. It can be used to extract informationfrom the raw data.Defaults to `average` for line-type series, `sum` for columns, `range`for range series, `hlc` for HLC, and `ohlc` for OHLC and candlestick.
		/// </summary>
		public string Approximation { get; set; }
		 

		/// <summary>
		/// Datetime formats for the header of the tooltip in a stock chart.The format can vary within a chart depending on the currently selectedtime range and the current data grouping.The default formats are:```js{    millisecond: [        '%A, %e %b, %H:%M:%S.%L', '%A, %e %b, %H:%M:%S.%L', '-%H:%M:%S.%L'    ],    second: ['%A, %e %b, %H:%M:%S', '%A, %e %b, %H:%M:%S', '-%H:%M:%S'],    minute: ['%A, %e %b, %H:%M', '%A, %e %b, %H:%M', '-%H:%M'],    hour: ['%A, %e %b, %H:%M', '%A, %e %b, %H:%M', '-%H:%M'],    day: ['%A, %e %b %Y', '%A, %e %b', '-%A, %e %b %Y'],    week: ['Week from %A, %e %b %Y', '%A, %e %b', '-%A, %e %b %Y'],    month: ['%B %Y', '%B', '-%B %Y'],    year: ['%Y', '%Y', '-%Y']}```For each of these array definitions, the first item is the formatused when the active time span is one unit. For instance, if thecurrent data applies to one week, the first item of the week arrayis used. The second and third items are used when the active timespan is more than two units. For instance, if the current data appliesto two weeks, the second and third item of the week array are used, and applied to the start and end date of the time span.
		/// </summary>
		public Hashtable DateTimeLabelFormats { get; set; }
		 

		/// <summary>
		/// Enable or disable data grouping.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Specifies how the first grouped point is positioned on the xAxis.If firstAnchor and/or lastAnchor are defined, then those options takeprecedence over anchor for the first and/or last grouped points.Available options:-`start` places the point at the beginning of the group(e.g. range 00:00:00 - 23:59:59 -> 00:00:00)-`middle` places the point in the middle of the group(e.g. range 00:00:00 - 23:59:59 -> 12:00:00)-`end` places the point at the end of the group(e.g. range 00:00:00 - 23:59:59 -> 23:59:59)-`firstPoint` the first point in the group(e.g. points at 00:13, 00:35, 00:59 -> 00:13)-`lastPoint` the last point in the group(e.g. points at 00:13, 00:35, 00:59 -> 00:59)
		/// </summary>
		public string FirstAnchor { get; set; }
		 

		/// <summary>
		/// When data grouping is forced, it runs no matter how small the intervalsare. This can be handy for example when the sum should be calculatedfor values appearing at random times within each hour.
		/// </summary>
		public bool? Forced { get; set; }
		 

		/// <summary>
		/// By default only points within the visible range are grouped. Enabling thisoption will force data grouping to calculate all grouped points for a givendataset. That option prevents for example a column series from calculatinga grouped point partially. The effect is similar to[Series.getExtremesFromAll](#plotOptions.series.getExtremesFromAll) but doesnot affect yAxis extremes.
		/// </summary>
		public bool? GroupAll { get; set; }
		 

		/// <summary>
		/// The approximate pixel width of each group. If for example a serieswith 30 points is displayed over a 600 pixel wide plot area, no groupingis performed. If however the series contains so many points thatthe spacing is less than the groupPixelWidth, Highcharts will tryto group it into appropriate groups so that each is more or lesstwo pixels wide. If multiple series with different group pixel widthsare drawn on the same x axis, all series will take the greatest width.For example, line series have 2px default group width, while columnseries have 10px. If combined, both the line and the column willhave 10px by default.
		/// </summary>
		public double? GroupPixelWidth { get; set; }
		 

		/// <summary>
		/// Specifies how the last grouped point is positioned on the xAxis.If firstAnchor and/or lastAnchor are defined, then those options takeprecedence over anchor for the first and/or last grouped points.Available options:-`start` places the point at the beginning of the group(e.g. range 00:00:00 - 23:59:59 -> 00:00:00)-`middle` places the point in the middle of the group(e.g. range 00:00:00 - 23:59:59 -> 12:00:00)-`end` places the point at the end of the group(e.g. range 00:00:00 - 23:59:59 -> 23:59:59)-`firstPoint` the first point in the group(e.g. points at 00:13, 00:35, 00:59 -> 00:13)-`lastPoint` the last point in the group(e.g. points at 00:13, 00:35, 00:59 -> 00:59)
		/// </summary>
		public string LastAnchor { get; set; }
		 

		/// <summary>
		/// Normally, a group is indexed by the start of that group, so for examplewhen 30 daily values are grouped into one month, that month's x valuewill be the 1st of the month. This apparently shifts the data tothe left. When the smoothed option is true, this is compensated for.The data is shifted to the middle of the group, and min and maxvalues are preserved. Internally, this is used in the Navigator series.
		/// </summary>
		public bool? Smoothed { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Anchor != null) h.Add("anchor",Anchor);
			if (Approximation != null) { h.Add("approximation",Approximation); highstock.AddFunction("approximation", Approximation); }  
			if (DateTimeLabelFormats != null) h.Add("dateTimeLabelFormats",DateTimeLabelFormats);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (FirstAnchor != null) h.Add("firstAnchor",FirstAnchor);
			if (Forced != null) h.Add("forced",Forced);
			if (GroupAll != null) h.Add("groupAll",GroupAll);
			if (GroupPixelWidth != null) h.Add("groupPixelWidth",GroupPixelWidth);
			if (LastAnchor != null) h.Add("lastAnchor",LastAnchor);
			if (Smoothed != null) h.Add("smoothed",Smoothed);
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
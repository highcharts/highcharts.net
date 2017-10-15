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
	public partial class AreaSeriesIkhDataGrouping  : BaseObject
	{
		public AreaSeriesIkhDataGrouping()
		{
			Approximation = Approximation_DefaultValue = AreaSeriesIkhDataGroupingApproximation.Average;
			DateTimeLabelFormats = DateTimeLabelFormats_DefaultValue = null;
			Enabled = Enabled_DefaultValue = true;
			Forced = Forced_DefaultValue = false;
			GroupPixelWidth = GroupPixelWidth_DefaultValue = 2;
			Smoothed = Smoothed_DefaultValue = false;
			
		}	
		

		/// <summary>
		/// <p>The method of approximation inside a group. When for example 30 daysare grouped into one month, this determines what value should representthe group. Possible values are &quot;average&quot;, &quot;averages&quot;, &quot;open&quot;, &quot;high&quot;,&quot;low&quot;, &quot;close&quot; and &quot;sum&quot;. For OHLC and candlestick series the approximationis &quot;ohlc&quot; by default, which finds the open, high, low and close valueswithin all the grouped data. For ranges, the approximation is &quot;range&quot;,which finds the low and high values. For multi-dimensional data,like ranges and OHLC, &quot;averages&quot; will compute the average for eachdimension.</p><p>Custom aggregate methods can be added by assigning a callback functionas the approximation. This function takes a numeric array as theargument and should return a single numeric value or <code>null</code>. Notethat the numeric array will never contain null values, only truenumbers. Instead, if null values are present in the raw data, thenumeric array will have an <code>.hasNulls</code> property set to <code>true</code>. Forsingle-value data sets the data is available in the first argumentof the callback function. For OHLC data sets, all the open valuesare in the first argument, all high values in the second etc.</p><p>Since v4.2.7, grouping meta data is available in the approximationcallback from <code>this.dataGroupInfo</code>. It can be used to extract informationfrom the raw data.</p><p>Defaults to <code>average</code> for line-type series, <code>sum</code> for columns, <code>range</code>for range series and <code>ohlc</code> for OHLC and candlestick.</p>
		/// </summary>
		public AreaSeriesIkhDataGroupingApproximation Approximation { get; set; }
		private AreaSeriesIkhDataGroupingApproximation Approximation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Datetime formats for the header of the tooltip in a stock chart.The format can vary within a chart depending on the currently selectedtime range and the current data grouping.</p><p>The default formats are:</p><pre>{    millisecond: ['%A, %b %e, %H:%M:%S.%L', '%A, %b %e, %H:%M:%S.%L', '-%H:%M:%S.%L'],    second: ['%A, %b %e, %H:%M:%S', '%A, %b %e, %H:%M:%S', '-%H:%M:%S'],    minute: ['%A, %b %e, %H:%M', '%A, %b %e, %H:%M', '-%H:%M'],    hour: ['%A, %b %e, %H:%M', '%A, %b %e, %H:%M', '-%H:%M'],    day: ['%A, %b %e, %Y', '%A, %b %e', '-%A, %b %e, %Y'],    week: ['Week from %A, %b %e, %Y', '%A, %b %e', '-%A, %b %e, %Y'],    month: ['%B %Y', '%B', '-%B %Y'],    year: ['%Y', '%Y', '-%Y']}</pre><p>For each of these array definitions, the first item is the formatused when the active time span is one unit. For instance, if thecurrent data applies to one week, the first item of the week arrayis used. The second and third items are used when the active timespan is more than two units. For instance, if the current data appliesto two weeks, the second and third item of the week array are used, and applied to the start and end date of the time span.</p>
		/// </summary>
		public Object DateTimeLabelFormats { get; set; }
		private Object DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable data grouping.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When data grouping is forced, it runs no matter how small the intervalsare. This can be handy for example when the sum should be calculatedfor values appearing at random times within each hour.</p>
		/// </summary>
		public bool? Forced { get; set; }
		private bool? Forced_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The approximate pixel width of each group. If for example a serieswith 30 points is displayed over a 600 pixel wide plot area, no groupingis performed. If however the series contains so many points thatthe spacing is less than the groupPixelWidth, Highcharts will tryto group it into appropriate groups so that each is more or lesstwo pixels wide. If multiple series with different group pixel widthsare drawn on the same x axis, all series will take the greatest width.For example, line series have 2px default group width, while columnseries have 10px. If combined, both the line and the column willhave 10px by default.</p>
		/// </summary>
		public double? GroupPixelWidth { get; set; }
		private double? GroupPixelWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Normally, a group is indexed by the start of that group, so for examplewhen 30 daily values are grouped into one month, that month&#39;s x valuewill be the 1st of the month. This apparently shifts the data tothe left. When the smoothed option is true, this is compensated for.The data is shifted to the middle of the group, and min and maxvalues are preserved. Internally, this is used in the Navigator series.</p>
		/// </summary>
		public bool? Smoothed { get; set; }
		private bool? Smoothed_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Approximation != Approximation_DefaultValue) h.Add("approximation", Highstock.FirstCharacterToLower(Approximation.ToString()));
			if (DateTimeLabelFormats != DateTimeLabelFormats_DefaultValue) h.Add("dateTimeLabelFormats",DateTimeLabelFormats);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Forced != Forced_DefaultValue) h.Add("forced",Forced);
			if (GroupPixelWidth != GroupPixelWidth_DefaultValue) h.Add("groupPixelWidth",GroupPixelWidth);
			if (Smoothed != Smoothed_DefaultValue) h.Add("smoothed",Smoothed);
			

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
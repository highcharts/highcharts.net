using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Highstock
{
	public partial class PlotOptionsSplineDataGrouping  : BaseObject
	{
		public PlotOptionsSplineDataGrouping()
		{
			Approximation = Approximation_DefaultValue = "";
			DateTimeLabelFormats = DateTimeLabelFormats_DefaultValue = new NameValueCollection();
			Enabled = Enabled_DefaultValue = true;
			Forced = Forced_DefaultValue = false;
			GroupPixelWidth = GroupPixelWidth_DefaultValue = 2;
			Smoothed = Smoothed_DefaultValue = false;
			
		}	
		

		/// <summary>
		/// <p>The method of approximation inside a group. When for example 30 days are grouped into one month, this determines what value should represent the group. Possible values are "average", "open", "high", "low", "close" and "sum". For OHLC and candlestick series the approximation is "ohlc" by default, which finds the  open, high, low and close values within all the grouped data. For ranges, the approximation is "range", which finds the low and high values.</p>  <p>Custom aggregate methods can be added by assigning a callback function as the approximation. This function takes a numeric array as the argument and should return a single numeric value or <code>null</code>. Note that the numeric array will never contain null values, only true numbers. Instead, if null values are present in the raw data, the numeric array will have an <code>.hasNulls</code> property set to <code>true</code>. For single-value data sets the data is available in the first argument of the callback function. For OHLC data sets, all the open values are in the first argument, all high values in the second etc.</p><p>Defaults to <code>average</code> for line-type series, <code>sum</code> for columns, <code>range</code> for range series and <code>ohlc</code> for OHLC and candlestick.
		/// </summary>
		public string Approximation { get; set; }
		private string Approximation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Datetime formats for the header of the tooltip in a stock chart. The format can vary within a chart depending on the currently selected time range and the current data grouping.</p><p>The default formats are: </p><pre>{   millisecond: ['%A, %b %e, %H:%M:%S.%L', '%A, %b %e, %H:%M:%S.%L', '-%H:%M:%S.%L'],   second: ['%A, %b %e, %H:%M:%S', '%A, %b %e, %H:%M:%S', '-%H:%M:%S'],   minute: ['%A, %b %e, %H:%M', '%A, %b %e, %H:%M', '-%H:%M'],   hour: ['%A, %b %e, %H:%M', '%A, %b %e, %H:%M', '-%H:%M'],   day: ['%A, %b %e, %Y', '%A, %b %e', '-%A, %b %e, %Y'],   week: ['Week from %A, %b %e, %Y', '%A, %b %e', '-%A, %b %e, %Y'],   month: ['%B %Y', '%B', '-%B %Y'],   year: ['%Y', '%Y', '-%Y']}</pre><p>For each of these array definitions, the first item is the format used when the active time span is one unit. For instance, if the current data applies to one week, the first item of the week array is used. The second and third items are used when the active time span is more than two units. For instance, if the current data applies to two weeks, the second and third item of the week array are used, and applied to the start and end date of the time span.</p>
		/// </summary>
		public NameValueCollection DateTimeLabelFormats { get; set; }
		private NameValueCollection DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable data grouping. Defaults to <code>true</code>.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// When data grouping is forced, it runs no matter how small the intervals are. This can be handy for example when the sum should be calculated for values appearing at random times within each hour. Defaults to <code>false</code>.
		/// </summary>
		public bool? Forced { get; set; }
		private bool? Forced_DefaultValue { get; set; }
		 

		/// <summary>
		/// The approximate pixel width of each group. If for example a series with 30 points is displayed over a 600 pixel wide plot area, no grouping is performed. If however the series contains so many points that the spacing is less than the  groupPixelWidth, Highcharts will try to group it into appropriate groups so that each is more or less two pixels wide. If multiple series with different group pixel widths are drawn on the same x axis, all series will take the greatest width. For example, line series have 2px default group width, while column series have 10px. If combined, both the line and the column will have 10px by default.  Defaults to <code>2</code>.
		/// </summary>
		public double? GroupPixelWidth { get; set; }
		private double? GroupPixelWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Normally, a group is indexed by the start of that group, so for example when 30 daily values are grouped into one month, that month's x value will be the 1st of  the month. This apparently shifts the data to the left. When the smoothed option is true, this is compensated for. The data is shifted to the middle of the group, and min and max values are preserved. Internally, this is used in the Navigator series. Defaults to <code>false</code>.
		/// </summary>
		public bool? Smoothed { get; set; }
		private bool? Smoothed_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Approximation != Approximation_DefaultValue) { h.Add("approximation",Approximation); Highstock.AddFunction("PlotOptionsSplineDataGroupingApproximation.approximation", Approximation); }  
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
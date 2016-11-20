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
	public partial class Series  : BaseObject
	{
		public Series()
		{
			Data = Data_DefaultValue = new List<SeriesData>();
			Id = Id_DefaultValue = "";
			Index = Index_DefaultValue = null;
			LegendIndex = LegendIndex_DefaultValue = null;
			Name = Name_DefaultValue = null;
			Stack = Stack_DefaultValue = "null";
			Type = Type_DefaultValue = SeriesType.Null;
			XAxis = XAxis_DefaultValue = "0";
			YAxis = YAxis_DefaultValue = "0";
			ZIndex = ZIndex_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// An array of data points for the series. The series object is expecting the points to be ordered from low to high.  The reason for this is to increase performance. While in many cases the data is fetched from a server, it's also more convenient to sort on the server and thereby save on client resources.    The points can be given in three ways:<ol><li>A list of numerical values. In this case, the numerical values will be interpreted as y values, and x values will be automatically calculated, either starting at 0 and incrementing by 1, or from <code>pointStart</code> and <code>pointInterval</code> given in the plotOptions. This option is not available for series types with more than one value per point, like area range or OHLC. Example:<pre>data: [0, 5, 3, 5]</pre> </li> <li><p>A list of arrays with two values. In this case, the first value is the x value and the second is the y value. If the first value is a string, it is applied as the name of the point, and the x value is incremented following the above rules.</p> <p>For series with more than one value per point, like range or OHLC, the arrays will be interpreted as <code>[x, low, high]</code> or <code>[x, open, high, low, close]</code>. In these cases, the X value can be skipped altogether to make use of <code>pointStart</code> and <code>pointRange</code>.</p> Example:<pre>data: [[5, 2], [6, 3], [8, 2]]</pre></li><li><p>A list of object with named values. In this case the objects arepoint configuration objects as seen under <a href="#point">options.point</a>.</p><p>Range series values are given by <code>low</code> and <code>high</code>, while candlestick/OHLC values are given by <code>open</code>, <code>high</code>, <code>low</code>, <code>close</code>.</p> Example:<pre>data: [{name: 'Point 1',color: '#00FF00',y: 0}, {name: 'Point 2',color: '#FF00FF',y: 5}]</pre></li> </ol><p> In turbo mode, when working with series longer than <a class="internal" href="#plotOptions.series.turboThreshold"> turboThreshold</a> (1000 points by default), only one- or two dimensional arrays of numbers are allowed. The first value is tested, and we assume that all the rest are defined the same way.</p><p>Note data must be sorted by X in order for the tooltip positioning and data grouping to work.</p>
		/// </summary>
		public List<SeriesData> Data { get; set; }
		private List<SeriesData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the series. This can be used after render time to get a pointer to the series object through <code>chart.get()</code>.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// The index of the series in the chart, affecting the internal index in the <code>chart.series</code> array, the visible Z index as well as the order in the legend.
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// The sequential index of the series in the legend.  <div class="demo">Try it:  <a href="http://jsfiddle.net/gh/get/jquery/2/highcharts/highcharts/tree/master/samples/highcharts/series/legendindex/" target="_blank">Legend in opposite order</a> </div>.
		/// </summary>
		public double? LegendIndex { get; set; }
		private double? LegendIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the series as shown in the legend, tooltip etc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option allows grouping series in a stacked chart. The stack option can be a string  or a number or anything else, as long as the grouped series' stack options match each other.
		/// </summary>
		public string Stack { get; set; }
		private string Stack_DefaultValue { get; set; }
		 

		/// <summary>
		/// The type of series. Can be one of <code>area</code>, <code>areaspline</code>, <code>bar</code>, <code>column</code>, <code>line</code>, <code>pie</code>, <code>scatter</code>, <code>spline</code>, <code>candlestick</code> or <code>ohlc</code>. From version 1.1.7, <code>arearange</code>, <code>areasplinerange</code> and <code>columnrange</code> are supported with the highcharts-more.js component.
		/// </summary>
		public SeriesType Type { get; set; }
		private SeriesType Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple x axes, this number defines which xAxis the particular series is connected to. It refers to either the <a href="#xAxis.id">axis id</a> or the index of the axis in the xAxis array, with 0 being the first.
		/// </summary>
		public string XAxis { get; set; }
		private string XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using dual or multiple y axes, this number defines which yAxis the particular series is connected to. It refers to either the <a href="#yAxis.id">axis id</a> or the index of the axis in the yAxis array, with 0 being the first.
		/// </summary>
		public string YAxis { get; set; }
		private string YAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// Define the visual z index of the series.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Stack != Stack_DefaultValue) h.Add("stack",Stack);
			if (Type != Type_DefaultValue) h.Add("type", Highstock.FirstCharacterToLower(Type.ToString()));
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			

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
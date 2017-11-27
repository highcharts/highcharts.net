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
	public partial class SeriesBoxplot  : BaseObject
	{
		public SeriesBoxplot()
		{
			Data = Data_DefaultValue = new List<SeriesBoxplotData>();
			Data = Data_DefaultValue = new List<SeriesBoxplotData>();
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			Median = Median_DefaultValue = null;
			Q1 = Q1_DefaultValue = null;
			Q3 = Q3_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesBoxplotData>();
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			Median = Median_DefaultValue = null;
			Q1 = Q1_DefaultValue = null;
			Q3 = Q3_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesBoxplotData>();
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			Median = Median_DefaultValue = null;
			Q1 = Q1_DefaultValue = null;
			Q3 = Q3_DefaultValue = null;
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			Median = Median_DefaultValue = null;
			Q1 = Q1_DefaultValue = null;
			Q3 = Q3_DefaultValue = null;
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			Median = Median_DefaultValue = null;
			Q1 = Q1_DefaultValue = null;
			Q3 = Q3_DefaultValue = null;
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			Median = Median_DefaultValue = null;
			Q1 = Q1_DefaultValue = null;
			Q3 = Q3_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `boxplot` seriestype, points can be given in the following ways:1.  An array of arrays with 6 or 5 values. In this case, the valuescorrespond to `x,low,q1,median,q3,high`. If the first value is astring, it is applied as the name of the point, and the `x` valueis inferred. The `x` value can also be omitted, in which case theinner arrays should be of length 5\. Then the `x` value is automaticallycalculated, either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 3, 0, 10, 3, 5],        [1, 7, 8, 7, 2, 9],        [2, 6, 9, 5, 1, 3]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.boxplot.turboThreshold),this option is not available. ```js    data: [{        x: 1,        low: 4,        q1: 9,        median: 9,        q3: 1,        high: 10,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        low: 5,        q1: 7,        median: 3,        q3: 6,        high: 2,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesBoxplotData> Data { get; set; }
		private List<SeriesBoxplotData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `boxplot` seriestype, points can be given in the following ways:1.  An array of arrays with 6 or 5 values. In this case, the valuescorrespond to `x,low,q1,median,q3,high`. If the first value is astring, it is applied as the name of the point, and the `x` valueis inferred. The `x` value can also be omitted, in which case theinner arrays should be of length 5\. Then the `x` value is automaticallycalculated, either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 3, 0, 10, 3, 5],        [1, 7, 8, 7, 2, 9],        [2, 6, 9, 5, 1, 3]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.boxplot.turboThreshold),this option is not available. ```js    data: [{        x: 1,        low: 4,        q1: 9,        median: 9,        q3: 1,        high: 10,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        low: 5,        q1: 7,        median: 3,        q3: 6,        high: 2,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesBoxplotData> Data { get; set; }
		private List<SeriesBoxplotData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `high` value for each data point, signifying the highest valuein the sample set. The top whisker is drawn here.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `low` value for each data point, signifying the lowest valuein the sample set. The bottom whisker is drawn here.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// The median for each data point. This is drawn as a line through themiddle area of the box.
		/// </summary>
		public double? Median { get; set; }
		private double? Median_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lower quartile for each data point. This is the bottom of thebox.
		/// </summary>
		public double? Q1 { get; set; }
		private double? Q1_DefaultValue { get; set; }
		 

		/// <summary>
		/// The higher quartile for each data point. This is the top of the box.
		/// </summary>
		public double? Q3 { get; set; }
		private double? Q3_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `boxplot` seriestype, points can be given in the following ways:1.  An array of arrays with 6 or 5 values. In this case, the valuescorrespond to `x,low,q1,median,q3,high`. If the first value is astring, it is applied as the name of the point, and the `x` valueis inferred. The `x` value can also be omitted, in which case theinner arrays should be of length 5\. Then the `x` value is automaticallycalculated, either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 3, 0, 10, 3, 5],        [1, 7, 8, 7, 2, 9],        [2, 6, 9, 5, 1, 3]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.boxplot.turboThreshold),this option is not available. ```js    data: [{        x: 1,        low: 4,        q1: 9,        median: 9,        q3: 1,        high: 10,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        low: 5,        q1: 7,        median: 3,        q3: 6,        high: 2,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesBoxplotData> Data { get; set; }
		private List<SeriesBoxplotData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `high` value for each data point, signifying the highest valuein the sample set. The top whisker is drawn here.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `low` value for each data point, signifying the lowest valuein the sample set. The bottom whisker is drawn here.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// The median for each data point. This is drawn as a line through themiddle area of the box.
		/// </summary>
		public double? Median { get; set; }
		private double? Median_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lower quartile for each data point. This is the bottom of thebox.
		/// </summary>
		public double? Q1 { get; set; }
		private double? Q1_DefaultValue { get; set; }
		 

		/// <summary>
		/// The higher quartile for each data point. This is the top of the box.
		/// </summary>
		public double? Q3 { get; set; }
		private double? Q3_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `boxplot` seriestype, points can be given in the following ways:1.  An array of arrays with 6 or 5 values. In this case, the valuescorrespond to `x,low,q1,median,q3,high`. If the first value is astring, it is applied as the name of the point, and the `x` valueis inferred. The `x` value can also be omitted, in which case theinner arrays should be of length 5\. Then the `x` value is automaticallycalculated, either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 3, 0, 10, 3, 5],        [1, 7, 8, 7, 2, 9],        [2, 6, 9, 5, 1, 3]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.boxplot.turboThreshold),this option is not available. ```js    data: [{        x: 1,        low: 4,        q1: 9,        median: 9,        q3: 1,        high: 10,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        low: 5,        q1: 7,        median: 3,        q3: 6,        high: 2,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesBoxplotData> Data { get; set; }
		private List<SeriesBoxplotData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `high` value for each data point, signifying the highest valuein the sample set. The top whisker is drawn here.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `low` value for each data point, signifying the lowest valuein the sample set. The bottom whisker is drawn here.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// The median for each data point. This is drawn as a line through themiddle area of the box.
		/// </summary>
		public double? Median { get; set; }
		private double? Median_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lower quartile for each data point. This is the bottom of thebox.
		/// </summary>
		public double? Q1 { get; set; }
		private double? Q1_DefaultValue { get; set; }
		 

		/// <summary>
		/// The higher quartile for each data point. This is the top of the box.
		/// </summary>
		public double? Q3 { get; set; }
		private double? Q3_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `high` value for each data point, signifying the highest valuein the sample set. The top whisker is drawn here.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `low` value for each data point, signifying the lowest valuein the sample set. The bottom whisker is drawn here.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// The median for each data point. This is drawn as a line through themiddle area of the box.
		/// </summary>
		public double? Median { get; set; }
		private double? Median_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lower quartile for each data point. This is the bottom of thebox.
		/// </summary>
		public double? Q1 { get; set; }
		private double? Q1_DefaultValue { get; set; }
		 

		/// <summary>
		/// The higher quartile for each data point. This is the top of the box.
		/// </summary>
		public double? Q3 { get; set; }
		private double? Q3_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `high` value for each data point, signifying the highest valuein the sample set. The top whisker is drawn here.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `low` value for each data point, signifying the lowest valuein the sample set. The bottom whisker is drawn here.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// The median for each data point. This is drawn as a line through themiddle area of the box.
		/// </summary>
		public double? Median { get; set; }
		private double? Median_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lower quartile for each data point. This is the bottom of thebox.
		/// </summary>
		public double? Q1 { get; set; }
		private double? Q1_DefaultValue { get; set; }
		 

		/// <summary>
		/// The higher quartile for each data point. This is the top of the box.
		/// </summary>
		public double? Q3 { get; set; }
		private double? Q3_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `high` value for each data point, signifying the highest valuein the sample set. The top whisker is drawn here.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `low` value for each data point, signifying the lowest valuein the sample set. The bottom whisker is drawn here.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// The median for each data point. This is drawn as a line through themiddle area of the box.
		/// </summary>
		public double? Median { get; set; }
		private double? Median_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lower quartile for each data point. This is the bottom of thebox.
		/// </summary>
		public double? Q1 { get; set; }
		private double? Q1_DefaultValue { get; set; }
		 

		/// <summary>
		/// The higher quartile for each data point. This is the top of the box.
		/// </summary>
		public double? Q3 { get; set; }
		private double? Q3_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (Median != Median_DefaultValue) h.Add("median",Median);
			if (Q1 != Q1_DefaultValue) h.Add("q1",Q1);
			if (Q3 != Q3_DefaultValue) h.Add("q3",Q3);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (Median != Median_DefaultValue) h.Add("median",Median);
			if (Q1 != Q1_DefaultValue) h.Add("q1",Q1);
			if (Q3 != Q3_DefaultValue) h.Add("q3",Q3);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (Median != Median_DefaultValue) h.Add("median",Median);
			if (Q1 != Q1_DefaultValue) h.Add("q1",Q1);
			if (Q3 != Q3_DefaultValue) h.Add("q3",Q3);
			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (Median != Median_DefaultValue) h.Add("median",Median);
			if (Q1 != Q1_DefaultValue) h.Add("q1",Q1);
			if (Q3 != Q3_DefaultValue) h.Add("q3",Q3);
			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (Median != Median_DefaultValue) h.Add("median",Median);
			if (Q1 != Q1_DefaultValue) h.Add("q1",Q1);
			if (Q3 != Q3_DefaultValue) h.Add("q3",Q3);
			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (Median != Median_DefaultValue) h.Add("median",Median);
			if (Q1 != Q1_DefaultValue) h.Add("q1",Q1);
			if (Q3 != Q3_DefaultValue) h.Add("q3",Q3);
			

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
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
	public partial class SeriesAreasplinerange  : BaseObject
	{
		public SeriesAreasplinerange()
		{
			Data = Data_DefaultValue = new List<SeriesAreasplinerangeData>();
			Data = Data_DefaultValue = new List<SeriesAreasplinerangeData>();
			Data = Data_DefaultValue = new List<SeriesAreasplinerangeData>();
			Data = Data_DefaultValue = new List<SeriesAreasplinerangeData>();
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `areasplinerange`series type, points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,low,high`. If the first value is a string, it isapplied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 0, 5],        [1, 9, 1],        [2, 5, 2]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.areasplinerange.turboThreshold), this option is not available. ```js    data: [{        x: 1,        low: 5,        high: 0,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        low: 4,        high: 1,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesAreasplinerangeData> Data { get; set; }
		private List<SeriesAreasplinerangeData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `areasplinerange`series type, points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,low,high`. If the first value is a string, it isapplied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 0, 5],        [1, 9, 1],        [2, 5, 2]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.areasplinerange.turboThreshold), this option is not available. ```js    data: [{        x: 1,        low: 5,        high: 0,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        low: 4,        high: 1,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesAreasplinerangeData> Data { get; set; }
		private List<SeriesAreasplinerangeData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `areasplinerange`series type, points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,low,high`. If the first value is a string, it isapplied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 0, 5],        [1, 9, 1],        [2, 5, 2]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.areasplinerange.turboThreshold), this option is not available. ```js    data: [{        x: 1,        low: 5,        high: 0,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        low: 4,        high: 1,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesAreasplinerangeData> Data { get; set; }
		private List<SeriesAreasplinerangeData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `areasplinerange`series type, points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,low,high`. If the first value is a string, it isapplied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 0, 5],        [1, 9, 1],        [2, 5, 2]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.areasplinerange.turboThreshold), this option is not available. ```js    data: [{        x: 1,        low: 5,        high: 0,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        low: 4,        high: 1,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesAreasplinerangeData> Data { get; set; }
		private List<SeriesAreasplinerangeData> Data_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Data.Any()) h.Add("data",HashifyList(Data));
			

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
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
	public partial class SeriesWindbarb  : BaseObject
	{
		public SeriesWindbarb()
		{
			Data = Data_DefaultValue = new List<SeriesWindbarbData>();
			Data = Data_DefaultValue = new List<SeriesWindbarbData>();
			Value = Value_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesWindbarbData>();
			Value = Value_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesWindbarbData>();
			Value = Value_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Value = Value_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Value = Value_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Value = Value_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `windbarb` series type,points can be given in the following ways:1.  An array of arrays with 3 values. In this case, the values correspondto `x,value,direction`. If the first value is a string, it is applied asthe name of the point, and the `x` value is inferred. ```js    data: [        [Date.UTC(2017, 0, 1, 0), 3.3, 90],        [Date.UTC(2017, 0, 1, 1), 12.1, 180],        [Date.UTC(2017, 0, 1, 2), 11.1, 270]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.area.turboThreshold),this option is not available. ```js    data: [{        x: Date.UTC(2017, 0, 1, 0),        value: 12.1,        direction: 90    }, {        x: Date.UTC(2017, 0, 1, 1),        value: 11.1,        direction: 270    }] ```
		/// </summary>
		public List<SeriesWindbarbData> Data { get; set; }
		private List<SeriesWindbarbData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `windbarb` series type,points can be given in the following ways:1.  An array of arrays with 3 values. In this case, the values correspondto `x,value,direction`. If the first value is a string, it is applied asthe name of the point, and the `x` value is inferred. ```js    data: [        [Date.UTC(2017, 0, 1, 0), 3.3, 90],        [Date.UTC(2017, 0, 1, 1), 12.1, 180],        [Date.UTC(2017, 0, 1, 2), 11.1, 270]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.area.turboThreshold),this option is not available. ```js    data: [{        x: Date.UTC(2017, 0, 1, 0),        value: 12.1,        direction: 90    }, {        x: Date.UTC(2017, 0, 1, 1),        value: 11.1,        direction: 270    }] ```
		/// </summary>
		public List<SeriesWindbarbData> Data { get; set; }
		private List<SeriesWindbarbData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind speed in meters per second.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `windbarb` series type,points can be given in the following ways:1.  An array of arrays with 3 values. In this case, the values correspondto `x,value,direction`. If the first value is a string, it is applied asthe name of the point, and the `x` value is inferred. ```js    data: [        [Date.UTC(2017, 0, 1, 0), 3.3, 90],        [Date.UTC(2017, 0, 1, 1), 12.1, 180],        [Date.UTC(2017, 0, 1, 2), 11.1, 270]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.area.turboThreshold),this option is not available. ```js    data: [{        x: Date.UTC(2017, 0, 1, 0),        value: 12.1,        direction: 90    }, {        x: Date.UTC(2017, 0, 1, 1),        value: 11.1,        direction: 270    }] ```
		/// </summary>
		public List<SeriesWindbarbData> Data { get; set; }
		private List<SeriesWindbarbData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind speed in meters per second.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `windbarb` series type,points can be given in the following ways:1.  An array of arrays with 3 values. In this case, the values correspondto `x,value,direction`. If the first value is a string, it is applied asthe name of the point, and the `x` value is inferred. ```js    data: [        [Date.UTC(2017, 0, 1, 0), 3.3, 90],        [Date.UTC(2017, 0, 1, 1), 12.1, 180],        [Date.UTC(2017, 0, 1, 2), 11.1, 270]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.area.turboThreshold),this option is not available. ```js    data: [{        x: Date.UTC(2017, 0, 1, 0),        value: 12.1,        direction: 90    }, {        x: Date.UTC(2017, 0, 1, 1),        value: 11.1,        direction: 270    }] ```
		/// </summary>
		public List<SeriesWindbarbData> Data { get; set; }
		private List<SeriesWindbarbData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind speed in meters per second.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind speed in meters per second.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind speed in meters per second.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind speed in meters per second.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The wind direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			

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
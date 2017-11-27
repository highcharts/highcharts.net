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
	public partial class SeriesVariwide  : BaseObject
	{
		public SeriesVariwide()
		{
			Data = Data_DefaultValue = new List<SeriesVariwideData>();
			Data = Data_DefaultValue = new List<SeriesVariwideData>();
			Z = Z_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesVariwideData>();
			Z = Z_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesVariwideData>();
			Z = Z_DefaultValue = null;
			Z = Z_DefaultValue = null;
			Z = Z_DefaultValue = null;
			Z = Z_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `variwide` series type,points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,z`. If the first value is a string, it is appliedas the name of the point, and the `x` value is inferred. The `x`value can also be omitted, in which case the inner arrays shouldbe of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart` and`pointInterval` given in the series options. ```js    data: [        [0, 1, 2],        [1, 5, 5],        [2, 0, 2]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.variwide.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 1,        z: 1,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 5,        z: 4,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesVariwideData> Data { get; set; }
		private List<SeriesVariwideData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `variwide` series type,points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,z`. If the first value is a string, it is appliedas the name of the point, and the `x` value is inferred. The `x`value can also be omitted, in which case the inner arrays shouldbe of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart` and`pointInterval` given in the series options. ```js    data: [        [0, 1, 2],        [1, 5, 5],        [2, 0, 2]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.variwide.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 1,        z: 1,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 5,        z: 4,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesVariwideData> Data { get; set; }
		private List<SeriesVariwideData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The relative width for each column. The widths are distributed so they sum up to the X axis length.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `variwide` series type,points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,z`. If the first value is a string, it is appliedas the name of the point, and the `x` value is inferred. The `x`value can also be omitted, in which case the inner arrays shouldbe of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart` and`pointInterval` given in the series options. ```js    data: [        [0, 1, 2],        [1, 5, 5],        [2, 0, 2]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.variwide.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 1,        z: 1,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 5,        z: 4,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesVariwideData> Data { get; set; }
		private List<SeriesVariwideData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The relative width for each column. The widths are distributed so they sum up to the X axis length.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `variwide` series type,points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,z`. If the first value is a string, it is appliedas the name of the point, and the `x` value is inferred. The `x`value can also be omitted, in which case the inner arrays shouldbe of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart` and`pointInterval` given in the series options. ```js    data: [        [0, 1, 2],        [1, 5, 5],        [2, 0, 2]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.variwide.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 1,        z: 1,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 5,        z: 4,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesVariwideData> Data { get; set; }
		private List<SeriesVariwideData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The relative width for each column. The widths are distributed so they sum up to the X axis length.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// The relative width for each column. The widths are distributed so they sum up to the X axis length.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// The relative width for each column. The widths are distributed so they sum up to the X axis length.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// The relative width for each column. The widths are distributed so they sum up to the X axis length.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			

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
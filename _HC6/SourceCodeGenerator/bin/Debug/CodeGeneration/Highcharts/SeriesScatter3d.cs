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
	public partial class SeriesScatter3d  : BaseObject
	{
		public SeriesScatter3d()
		{
			Data = Data_DefaultValue = new List<SeriesScatter3dData>();
			Data = Data_DefaultValue = new List<SeriesScatter3dData>();
			Z = Z_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesScatter3dData>();
			Z = Z_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesScatter3dData>();
			Z = Z_DefaultValue = null;
			Z = Z_DefaultValue = null;
			Z = Z_DefaultValue = null;
			Z = Z_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `scatter3d` seriestype, points can be given in the following ways:1.  An array of arrays with 3 values. In this case, the values correspondto `x,y,z`. If the first value is a string, it is applied as the nameof the point, and the `x` value is inferred. ```js    data: [        [0, 0, 1],        [1, 8, 7],        [2, 9, 2]    ] ```3.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.scatter3d.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 2,        z: 24,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 4,        z: 12,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesScatter3dData> Data { get; set; }
		private List<SeriesScatter3dData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `scatter3d` seriestype, points can be given in the following ways:1.  An array of arrays with 3 values. In this case, the values correspondto `x,y,z`. If the first value is a string, it is applied as the nameof the point, and the `x` value is inferred. ```js    data: [        [0, 0, 1],        [1, 8, 7],        [2, 9, 2]    ] ```3.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.scatter3d.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 2,        z: 24,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 4,        z: 12,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesScatter3dData> Data { get; set; }
		private List<SeriesScatter3dData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The z value for each data point.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `scatter3d` seriestype, points can be given in the following ways:1.  An array of arrays with 3 values. In this case, the values correspondto `x,y,z`. If the first value is a string, it is applied as the nameof the point, and the `x` value is inferred. ```js    data: [        [0, 0, 1],        [1, 8, 7],        [2, 9, 2]    ] ```3.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.scatter3d.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 2,        z: 24,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 4,        z: 12,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesScatter3dData> Data { get; set; }
		private List<SeriesScatter3dData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The z value for each data point.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `scatter3d` seriestype, points can be given in the following ways:1.  An array of arrays with 3 values. In this case, the values correspondto `x,y,z`. If the first value is a string, it is applied as the nameof the point, and the `x` value is inferred. ```js    data: [        [0, 0, 1],        [1, 8, 7],        [2, 9, 2]    ] ```3.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.scatter3d.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 2,        z: 24,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 4,        z: 12,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesScatter3dData> Data { get; set; }
		private List<SeriesScatter3dData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The z value for each data point.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// The z value for each data point.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// The z value for each data point.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// The z value for each data point.
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
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
	public partial class SeriesVector  : BaseObject
	{
		public SeriesVector()
		{
			Data = Data_DefaultValue = new List<SeriesVectorData>();
			Data = Data_DefaultValue = new List<SeriesVectorData>();
			Length = Length_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesVectorData>();
			Length = Length_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesVectorData>();
			Length = Length_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Length = Length_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Length = Length_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Length = Length_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `vector` series type,points can be given in the following ways:1.  An array of arrays with 4 values. In this case, the values correspondto `x,y,length,direction`. If the first value is a string, it is applied asthe name of the point, and the `x` value is inferred. ```js    data: [        [0, 0, 10, 90],        [0, 1, 5, 180],        [1, 1, 2, 270]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.area.turboThreshold),this option is not available. ```js    data: [{        x: 0,        y: 0,        name: "Point2",        length: 10,        direction: 90    }, {        x: 1,        y: 1,        name: "Point1",        direction: 270    }] ```
		/// </summary>
		public List<SeriesVectorData> Data { get; set; }
		private List<SeriesVectorData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `vector` series type,points can be given in the following ways:1.  An array of arrays with 4 values. In this case, the values correspondto `x,y,length,direction`. If the first value is a string, it is applied asthe name of the point, and the `x` value is inferred. ```js    data: [        [0, 0, 10, 90],        [0, 1, 5, 180],        [1, 1, 2, 270]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.area.turboThreshold),this option is not available. ```js    data: [{        x: 0,        y: 0,        name: "Point2",        length: 10,        direction: 90    }, {        x: 1,        y: 1,        name: "Point1",        direction: 270    }] ```
		/// </summary>
		public List<SeriesVectorData> Data { get; set; }
		private List<SeriesVectorData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the vector. The rendered length will relate to the`vectorLength` setting.
		/// </summary>
		public double? Length { get; set; }
		private double? Length_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vector direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `vector` series type,points can be given in the following ways:1.  An array of arrays with 4 values. In this case, the values correspondto `x,y,length,direction`. If the first value is a string, it is applied asthe name of the point, and the `x` value is inferred. ```js    data: [        [0, 0, 10, 90],        [0, 1, 5, 180],        [1, 1, 2, 270]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.area.turboThreshold),this option is not available. ```js    data: [{        x: 0,        y: 0,        name: "Point2",        length: 10,        direction: 90    }, {        x: 1,        y: 1,        name: "Point1",        direction: 270    }] ```
		/// </summary>
		public List<SeriesVectorData> Data { get; set; }
		private List<SeriesVectorData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the vector. The rendered length will relate to the`vectorLength` setting.
		/// </summary>
		public double? Length { get; set; }
		private double? Length_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vector direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `vector` series type,points can be given in the following ways:1.  An array of arrays with 4 values. In this case, the values correspondto `x,y,length,direction`. If the first value is a string, it is applied asthe name of the point, and the `x` value is inferred. ```js    data: [        [0, 0, 10, 90],        [0, 1, 5, 180],        [1, 1, 2, 270]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.area.turboThreshold),this option is not available. ```js    data: [{        x: 0,        y: 0,        name: "Point2",        length: 10,        direction: 90    }, {        x: 1,        y: 1,        name: "Point1",        direction: 270    }] ```
		/// </summary>
		public List<SeriesVectorData> Data { get; set; }
		private List<SeriesVectorData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the vector. The rendered length will relate to the`vectorLength` setting.
		/// </summary>
		public double? Length { get; set; }
		private double? Length_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vector direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the vector. The rendered length will relate to the`vectorLength` setting.
		/// </summary>
		public double? Length { get; set; }
		private double? Length_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vector direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the vector. The rendered length will relate to the`vectorLength` setting.
		/// </summary>
		public double? Length { get; set; }
		private double? Length_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vector direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the vector. The rendered length will relate to the`vectorLength` setting.
		/// </summary>
		public double? Length { get; set; }
		private double? Length_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vector direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Length != Length_DefaultValue) h.Add("length",Length);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Length != Length_DefaultValue) h.Add("length",Length);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Length != Length_DefaultValue) h.Add("length",Length);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Length != Length_DefaultValue) h.Add("length",Length);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Length != Length_DefaultValue) h.Add("length",Length);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Length != Length_DefaultValue) h.Add("length",Length);
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
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
	public partial class SeriesTilemap  : BaseObject
	{
		public SeriesTilemap()
		{
			Data = Data_DefaultValue = new List<SeriesTilemapData>();
			Data = Data_DefaultValue = new List<SeriesTilemapData>();
			Data = Data_DefaultValue = new List<SeriesTilemapData>();
			Data = Data_DefaultValue = new List<SeriesTilemapData>();
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `tilemap` seriestype, points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,value`. If the first value is a string, it isapplied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 9, 7],        [1, 10, 4],        [2, 6, 3]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.tilemap.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 3,        value: 10,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 7,        value: 10,        name: "Point1",        color: "#FF00FF"    }] ```Note that for some [tileShapes](#plotOptions.tilemap.tileShape) the gridcoordinates are offset.
		/// </summary>
		public List<SeriesTilemapData> Data { get; set; }
		private List<SeriesTilemapData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `tilemap` seriestype, points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,value`. If the first value is a string, it isapplied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 9, 7],        [1, 10, 4],        [2, 6, 3]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.tilemap.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 3,        value: 10,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 7,        value: 10,        name: "Point1",        color: "#FF00FF"    }] ```Note that for some [tileShapes](#plotOptions.tilemap.tileShape) the gridcoordinates are offset.
		/// </summary>
		public List<SeriesTilemapData> Data { get; set; }
		private List<SeriesTilemapData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `tilemap` seriestype, points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,value`. If the first value is a string, it isapplied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 9, 7],        [1, 10, 4],        [2, 6, 3]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.tilemap.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 3,        value: 10,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 7,        value: 10,        name: "Point1",        color: "#FF00FF"    }] ```Note that for some [tileShapes](#plotOptions.tilemap.tileShape) the gridcoordinates are offset.
		/// </summary>
		public List<SeriesTilemapData> Data { get; set; }
		private List<SeriesTilemapData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `tilemap` seriestype, points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,value`. If the first value is a string, it isapplied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 9, 7],        [1, 10, 4],        [2, 6, 3]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.tilemap.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 3,        value: 10,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 7,        value: 10,        name: "Point1",        color: "#FF00FF"    }] ```Note that for some [tileShapes](#plotOptions.tilemap.tileShape) the gridcoordinates are offset.
		/// </summary>
		public List<SeriesTilemapData> Data { get; set; }
		private List<SeriesTilemapData> Data_DefaultValue { get; set; }
		  

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
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
	public partial class SeriesHeatmap  : BaseObject
	{
		public SeriesHeatmap()
		{
			Data = Data_DefaultValue = new List<SeriesHeatmapData>();
			Data = Data_DefaultValue = new List<SeriesHeatmapData>();
			Color = Color_DefaultValue = "";
			Value = Value_DefaultValue = null;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			PointPadding = PointPadding_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesHeatmapData>();
			Color = Color_DefaultValue = "";
			Value = Value_DefaultValue = null;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			PointPadding = PointPadding_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesHeatmapData>();
			Color = Color_DefaultValue = "";
			Value = Value_DefaultValue = null;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			PointPadding = PointPadding_DefaultValue = null;
			Color = Color_DefaultValue = "";
			Value = Value_DefaultValue = null;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			PointPadding = PointPadding_DefaultValue = null;
			Color = Color_DefaultValue = "";
			Value = Value_DefaultValue = null;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			PointPadding = PointPadding_DefaultValue = null;
			Color = Color_DefaultValue = "";
			Value = Value_DefaultValue = null;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			PointPadding = PointPadding_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `heatmap` seriestype, points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,value`. If the first value is a string, it isapplied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 9, 7],        [1, 10, 4],        [2, 6, 3]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.heatmap.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 3,        value: 10,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 7,        value: 10,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesHeatmapData> Data { get; set; }
		private List<SeriesHeatmapData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `heatmap` seriestype, points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,value`. If the first value is a string, it isapplied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 9, 7],        [1, 10, 4],        [2, 6, 3]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.heatmap.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 3,        value: 10,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 7,        value: 10,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesHeatmapData> Data { get; set; }
		private List<SeriesHeatmapData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the point. In heat maps the point color is rarely setexplicitly, as we use the color to denote the `value`. Options forthis are set in the [colorAxis](#colorAxis) configuration.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a color controled by optionsas set in the [colorAxis](#colorAxis) configuration.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x value of the point. For datetime axes,the X value is the timestamp in milliseconds since 1970.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y value of the point.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point padding for a single point.
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `heatmap` seriestype, points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,value`. If the first value is a string, it isapplied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 9, 7],        [1, 10, 4],        [2, 6, 3]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.heatmap.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 3,        value: 10,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 7,        value: 10,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesHeatmapData> Data { get; set; }
		private List<SeriesHeatmapData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the point. In heat maps the point color is rarely setexplicitly, as we use the color to denote the `value`. Options forthis are set in the [colorAxis](#colorAxis) configuration.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a color controled by optionsas set in the [colorAxis](#colorAxis) configuration.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x value of the point. For datetime axes,the X value is the timestamp in milliseconds since 1970.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y value of the point.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point padding for a single point.
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `heatmap` seriestype, points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,value`. If the first value is a string, it isapplied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 9, 7],        [1, 10, 4],        [2, 6, 3]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.heatmap.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 3,        value: 10,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 7,        value: 10,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesHeatmapData> Data { get; set; }
		private List<SeriesHeatmapData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the point. In heat maps the point color is rarely setexplicitly, as we use the color to denote the `value`. Options forthis are set in the [colorAxis](#colorAxis) configuration.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a color controled by optionsas set in the [colorAxis](#colorAxis) configuration.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x value of the point. For datetime axes,the X value is the timestamp in milliseconds since 1970.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y value of the point.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point padding for a single point.
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the point. In heat maps the point color is rarely setexplicitly, as we use the color to denote the `value`. Options forthis are set in the [colorAxis](#colorAxis) configuration.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a color controled by optionsas set in the [colorAxis](#colorAxis) configuration.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x value of the point. For datetime axes,the X value is the timestamp in milliseconds since 1970.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y value of the point.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point padding for a single point.
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the point. In heat maps the point color is rarely setexplicitly, as we use the color to denote the `value`. Options forthis are set in the [colorAxis](#colorAxis) configuration.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a color controled by optionsas set in the [colorAxis](#colorAxis) configuration.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x value of the point. For datetime axes,the X value is the timestamp in milliseconds since 1970.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y value of the point.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point padding for a single point.
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the point. In heat maps the point color is rarely setexplicitly, as we use the color to denote the `value`. Options forthis are set in the [colorAxis](#colorAxis) configuration.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a color controled by optionsas set in the [colorAxis](#colorAxis) configuration.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x value of the point. For datetime axes,the X value is the timestamp in milliseconds since 1970.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y value of the point.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point padding for a single point.
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			

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
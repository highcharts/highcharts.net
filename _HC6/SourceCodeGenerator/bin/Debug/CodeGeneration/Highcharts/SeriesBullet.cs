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
	public partial class SeriesBullet  : BaseObject
	{
		public SeriesBullet()
		{
			Data = Data_DefaultValue = new List<SeriesBulletData>();
			Data = Data_DefaultValue = new List<SeriesBulletData>();
			Target = Target_DefaultValue = null;
			TargetOptions = TargetOptions_DefaultValue = "";
			Data = Data_DefaultValue = new List<SeriesBulletData>();
			Target = Target_DefaultValue = null;
			TargetOptions = TargetOptions_DefaultValue = "";
			Data = Data_DefaultValue = new List<SeriesBulletData>();
			Target = Target_DefaultValue = null;
			TargetOptions = TargetOptions_DefaultValue = "";
			Target = Target_DefaultValue = null;
			TargetOptions = TargetOptions_DefaultValue = "";
			Target = Target_DefaultValue = null;
			TargetOptions = TargetOptions_DefaultValue = "";
			Target = Target_DefaultValue = null;
			TargetOptions = TargetOptions_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `bullet` series type,points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,target`. If the first value is a string,it is applied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 40, 75],        [1, 50, 50],        [2, 60, 40]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.bullet.turboThreshold),this option is not available. ```js    data: [{        x: 0,        y: 40,        target: 75,        name: "Point1",        color: "#00FF00"    }, {        x: 1,        y: 60,        target: 40,        name: "Point2",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesBulletData> Data { get; set; }
		private List<SeriesBulletData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `bullet` series type,points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,target`. If the first value is a string,it is applied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 40, 75],        [1, 50, 50],        [2, 60, 40]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.bullet.turboThreshold),this option is not available. ```js    data: [{        x: 0,        y: 40,        target: 75,        name: "Point1",        color: "#00FF00"    }, {        x: 1,        y: 60,        target: 40,        name: "Point2",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesBulletData> Data { get; set; }
		private List<SeriesBulletData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The target value of a point.
		/// </summary>
		public double? Target { get; set; }
		private double? Target_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual target options for each point.
		/// </summary>
		public SeriesBulletTargetOptions TargetOptions { get; set; }
		private SeriesBulletTargetOptions TargetOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `bullet` series type,points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,target`. If the first value is a string,it is applied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 40, 75],        [1, 50, 50],        [2, 60, 40]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.bullet.turboThreshold),this option is not available. ```js    data: [{        x: 0,        y: 40,        target: 75,        name: "Point1",        color: "#00FF00"    }, {        x: 1,        y: 60,        target: 40,        name: "Point2",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesBulletData> Data { get; set; }
		private List<SeriesBulletData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The target value of a point.
		/// </summary>
		public double? Target { get; set; }
		private double? Target_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual target options for each point.
		/// </summary>
		public SeriesBulletTargetOptions TargetOptions { get; set; }
		private SeriesBulletTargetOptions TargetOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `bullet` series type,points can be given in the following ways:1.  An array of arrays with 3 or 2 values. In this case, the valuescorrespond to `x,y,target`. If the first value is a string,it is applied as the name of the point, and the `x` value is inferred.The `x` value can also be omitted, in which case the inner arraysshould be of length 2\. Then the `x` value is automatically calculated,either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. ```js    data: [        [0, 40, 75],        [1, 50, 50],        [2, 60, 40]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.bullet.turboThreshold),this option is not available. ```js    data: [{        x: 0,        y: 40,        target: 75,        name: "Point1",        color: "#00FF00"    }, {        x: 1,        y: 60,        target: 40,        name: "Point2",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesBulletData> Data { get; set; }
		private List<SeriesBulletData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The target value of a point.
		/// </summary>
		public double? Target { get; set; }
		private double? Target_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual target options for each point.
		/// </summary>
		public SeriesBulletTargetOptions TargetOptions { get; set; }
		private SeriesBulletTargetOptions TargetOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The target value of a point.
		/// </summary>
		public double? Target { get; set; }
		private double? Target_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual target options for each point.
		/// </summary>
		public SeriesBulletTargetOptions TargetOptions { get; set; }
		private SeriesBulletTargetOptions TargetOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The target value of a point.
		/// </summary>
		public double? Target { get; set; }
		private double? Target_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual target options for each point.
		/// </summary>
		public SeriesBulletTargetOptions TargetOptions { get; set; }
		private SeriesBulletTargetOptions TargetOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The target value of a point.
		/// </summary>
		public double? Target { get; set; }
		private double? Target_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual target options for each point.
		/// </summary>
		public SeriesBulletTargetOptions TargetOptions { get; set; }
		private SeriesBulletTargetOptions TargetOptions_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Target != Target_DefaultValue) h.Add("target",Target);
			if (TargetOptions != TargetOptions_DefaultValue) h.Add("targetOptions",TargetOptions);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Target != Target_DefaultValue) h.Add("target",Target);
			if (TargetOptions != TargetOptions_DefaultValue) h.Add("targetOptions",TargetOptions);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Target != Target_DefaultValue) h.Add("target",Target);
			if (TargetOptions != TargetOptions_DefaultValue) h.Add("targetOptions",TargetOptions);
			if (Target != Target_DefaultValue) h.Add("target",Target);
			if (TargetOptions != TargetOptions_DefaultValue) h.Add("targetOptions",TargetOptions);
			if (Target != Target_DefaultValue) h.Add("target",Target);
			if (TargetOptions != TargetOptions_DefaultValue) h.Add("targetOptions",TargetOptions);
			if (Target != Target_DefaultValue) h.Add("target",Target);
			if (TargetOptions != TargetOptions_DefaultValue) h.Add("targetOptions",TargetOptions);
			

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
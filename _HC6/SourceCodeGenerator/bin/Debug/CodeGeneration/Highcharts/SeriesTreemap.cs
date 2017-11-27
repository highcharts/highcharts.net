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
	public partial class SeriesTreemap  : BaseObject
	{
		public SeriesTreemap()
		{
			Data = Data_DefaultValue = new List<SeriesTreemapData>();
			Data = Data_DefaultValue = new List<SeriesTreemapData>();
			Parent = Parent_DefaultValue = "undefined";
			Value = Value_DefaultValue = null;
			ColorValue = ColorValue_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesTreemapData>();
			Parent = Parent_DefaultValue = "undefined";
			Value = Value_DefaultValue = null;
			ColorValue = ColorValue_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesTreemapData>();
			Parent = Parent_DefaultValue = "undefined";
			Value = Value_DefaultValue = null;
			ColorValue = ColorValue_DefaultValue = null;
			Parent = Parent_DefaultValue = "undefined";
			Value = Value_DefaultValue = null;
			ColorValue = ColorValue_DefaultValue = null;
			Parent = Parent_DefaultValue = "undefined";
			Value = Value_DefaultValue = null;
			ColorValue = ColorValue_DefaultValue = null;
			Parent = Parent_DefaultValue = "undefined";
			Value = Value_DefaultValue = null;
			ColorValue = ColorValue_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `treemap` seriestype, points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `value` options. Example: ```js data: [0, 5, 3, 5] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.treemap.turboThreshold),this option is not available. ```js    data: [{        value: 9,        name: "Point2",        color: "#00FF00"    }, {        value: 6,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesTreemapData> Data { get; set; }
		private List<SeriesTreemapData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `treemap` seriestype, points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `value` options. Example: ```js data: [0, 5, 3, 5] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.treemap.turboThreshold),this option is not available. ```js    data: [{        value: 9,        name: "Point2",        color: "#00FF00"    }, {        value: 6,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesTreemapData> Data { get; set; }
		private List<SeriesTreemapData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// Only for treemap. Use this option to build a tree structure. Thevalue should be the id of the point which is the parent. If no pointshas a matching id, or this option is undefined, then the parent willbe set to the root.
		/// </summary>
		public string Parent { get; set; }
		private string Parent_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a relative area of the pointin the treemap.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// Serves a purpose only if a `colorAxis` object is defined in the chartoptions. This value will decide which color the point gets from thescale of the colorAxis.
		/// </summary>
		public double? ColorValue { get; set; }
		private double? ColorValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `treemap` seriestype, points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `value` options. Example: ```js data: [0, 5, 3, 5] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.treemap.turboThreshold),this option is not available. ```js    data: [{        value: 9,        name: "Point2",        color: "#00FF00"    }, {        value: 6,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesTreemapData> Data { get; set; }
		private List<SeriesTreemapData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// Only for treemap. Use this option to build a tree structure. Thevalue should be the id of the point which is the parent. If no pointshas a matching id, or this option is undefined, then the parent willbe set to the root.
		/// </summary>
		public string Parent { get; set; }
		private string Parent_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a relative area of the pointin the treemap.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// Serves a purpose only if a `colorAxis` object is defined in the chartoptions. This value will decide which color the point gets from thescale of the colorAxis.
		/// </summary>
		public double? ColorValue { get; set; }
		private double? ColorValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `treemap` seriestype, points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `value` options. Example: ```js data: [0, 5, 3, 5] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.treemap.turboThreshold),this option is not available. ```js    data: [{        value: 9,        name: "Point2",        color: "#00FF00"    }, {        value: 6,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesTreemapData> Data { get; set; }
		private List<SeriesTreemapData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// Only for treemap. Use this option to build a tree structure. Thevalue should be the id of the point which is the parent. If no pointshas a matching id, or this option is undefined, then the parent willbe set to the root.
		/// </summary>
		public string Parent { get; set; }
		private string Parent_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a relative area of the pointin the treemap.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// Serves a purpose only if a `colorAxis` object is defined in the chartoptions. This value will decide which color the point gets from thescale of the colorAxis.
		/// </summary>
		public double? ColorValue { get; set; }
		private double? ColorValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// Only for treemap. Use this option to build a tree structure. Thevalue should be the id of the point which is the parent. If no pointshas a matching id, or this option is undefined, then the parent willbe set to the root.
		/// </summary>
		public string Parent { get; set; }
		private string Parent_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a relative area of the pointin the treemap.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// Serves a purpose only if a `colorAxis` object is defined in the chartoptions. This value will decide which color the point gets from thescale of the colorAxis.
		/// </summary>
		public double? ColorValue { get; set; }
		private double? ColorValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// Only for treemap. Use this option to build a tree structure. Thevalue should be the id of the point which is the parent. If no pointshas a matching id, or this option is undefined, then the parent willbe set to the root.
		/// </summary>
		public string Parent { get; set; }
		private string Parent_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a relative area of the pointin the treemap.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// Serves a purpose only if a `colorAxis` object is defined in the chartoptions. This value will decide which color the point gets from thescale of the colorAxis.
		/// </summary>
		public double? ColorValue { get; set; }
		private double? ColorValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// Only for treemap. Use this option to build a tree structure. Thevalue should be the id of the point which is the parent. If no pointshas a matching id, or this option is undefined, then the parent willbe set to the root.
		/// </summary>
		public string Parent { get; set; }
		private string Parent_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a relative area of the pointin the treemap.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// Serves a purpose only if a `colorAxis` object is defined in the chartoptions. This value will decide which color the point gets from thescale of the colorAxis.
		/// </summary>
		public double? ColorValue { get; set; }
		private double? ColorValue_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Parent != Parent_DefaultValue) h.Add("parent",Parent);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (ColorValue != ColorValue_DefaultValue) h.Add("colorValue",ColorValue);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Parent != Parent_DefaultValue) h.Add("parent",Parent);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (ColorValue != ColorValue_DefaultValue) h.Add("colorValue",ColorValue);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Parent != Parent_DefaultValue) h.Add("parent",Parent);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (ColorValue != ColorValue_DefaultValue) h.Add("colorValue",ColorValue);
			if (Parent != Parent_DefaultValue) h.Add("parent",Parent);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (ColorValue != ColorValue_DefaultValue) h.Add("colorValue",ColorValue);
			if (Parent != Parent_DefaultValue) h.Add("parent",Parent);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (ColorValue != ColorValue_DefaultValue) h.Add("colorValue",ColorValue);
			if (Parent != Parent_DefaultValue) h.Add("parent",Parent);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (ColorValue != ColorValue_DefaultValue) h.Add("colorValue",ColorValue);
			

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
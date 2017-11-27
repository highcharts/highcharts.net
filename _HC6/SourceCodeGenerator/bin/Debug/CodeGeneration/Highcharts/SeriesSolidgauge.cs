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
	public partial class SeriesSolidgauge  : BaseObject
	{
		public SeriesSolidgauge()
		{
			Data = Data_DefaultValue = new List<SeriesSolidgaugeData>();
			Data = Data_DefaultValue = new List<SeriesSolidgaugeData>();
			InnerRadius = InnerRadius_DefaultValue = null;
			Radius = Radius_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesSolidgaugeData>();
			InnerRadius = InnerRadius_DefaultValue = null;
			Radius = Radius_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesSolidgaugeData>();
			InnerRadius = InnerRadius_DefaultValue = null;
			Radius = Radius_DefaultValue = null;
			InnerRadius = InnerRadius_DefaultValue = null;
			Radius = Radius_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `solidgauge` seriestype, points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. Example: ```js data: [0, 5, 3, 5] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.solidgauge.turboThreshold),this option is not available. ```js    data: [{        y: 5,        name: "Point2",        color: "#00FF00"    }, {        y: 7,        name: "Point1",        color: "#FF00FF"    }] ```The typical gauge only contains a single data value.
		/// </summary>
		public List<SeriesSolidgaugeData> Data { get; set; }
		private List<SeriesSolidgaugeData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `solidgauge` seriestype, points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. Example: ```js data: [0, 5, 3, 5] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.solidgauge.turboThreshold),this option is not available. ```js    data: [{        y: 5,        name: "Point2",        color: "#00FF00"    }, {        y: 7,        name: "Point1",        color: "#FF00FF"    }] ```The typical gauge only contains a single data value.
		/// </summary>
		public List<SeriesSolidgaugeData> Data { get; set; }
		private List<SeriesSolidgaugeData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `solidgauge` seriestype, points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. Example: ```js data: [0, 5, 3, 5] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.solidgauge.turboThreshold),this option is not available. ```js    data: [{        y: 5,        name: "Point2",        color: "#00FF00"    }, {        y: 7,        name: "Point1",        color: "#FF00FF"    }] ```The typical gauge only contains a single data value.
		/// </summary>
		public List<SeriesSolidgaugeData> Data { get; set; }
		private List<SeriesSolidgaugeData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `solidgauge` seriestype, points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. Example: ```js data: [0, 5, 3, 5] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.solidgauge.turboThreshold),this option is not available. ```js    data: [{        y: 5,        name: "Point2",        color: "#00FF00"    }, {        y: 7,        name: "Point1",        color: "#FF00FF"    }] ```The typical gauge only contains a single data value.
		/// </summary>
		public List<SeriesSolidgaugeData> Data { get; set; }
		private List<SeriesSolidgaugeData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			

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
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
	public partial class SeriesGauge  : BaseObject
	{
		public SeriesGauge()
		{
			Data = Data_DefaultValue = new List<SeriesGaugeData>();
			Data = Data_DefaultValue = new List<SeriesGaugeData>();
			Data = Data_DefaultValue = new List<SeriesGaugeData>();
			Data = Data_DefaultValue = new List<SeriesGaugeData>();
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `gauge` series type,points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. Example: ```js data: [0, 5, 3, 5] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.gauge.turboThreshold),this option is not available. ```js    data: [{    y: 6,    name: "Point2",    color: "#00FF00"}, {    y: 8,    name: "Point1",    color: "#FF00FF"}]</pre>The typical gauge only contains a single data value.
		/// </summary>
		public List<SeriesGaugeData> Data { get; set; }
		private List<SeriesGaugeData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `gauge` series type,points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. Example: ```js data: [0, 5, 3, 5] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.gauge.turboThreshold),this option is not available. ```js    data: [{    y: 6,    name: "Point2",    color: "#00FF00"}, {    y: 8,    name: "Point1",    color: "#FF00FF"}]</pre>The typical gauge only contains a single data value.
		/// </summary>
		public List<SeriesGaugeData> Data { get; set; }
		private List<SeriesGaugeData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `gauge` series type,points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. Example: ```js data: [0, 5, 3, 5] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.gauge.turboThreshold),this option is not available. ```js    data: [{    y: 6,    name: "Point2",    color: "#00FF00"}, {    y: 8,    name: "Point1",    color: "#FF00FF"}]</pre>The typical gauge only contains a single data value.
		/// </summary>
		public List<SeriesGaugeData> Data { get; set; }
		private List<SeriesGaugeData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `gauge` series type,points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. Example: ```js data: [0, 5, 3, 5] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.gauge.turboThreshold),this option is not available. ```js    data: [{    y: 6,    name: "Point2",    color: "#00FF00"}, {    y: 8,    name: "Point1",    color: "#FF00FF"}]</pre>The typical gauge only contains a single data value.
		/// </summary>
		public List<SeriesGaugeData> Data { get; set; }
		private List<SeriesGaugeData> Data_DefaultValue { get; set; }
		  

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
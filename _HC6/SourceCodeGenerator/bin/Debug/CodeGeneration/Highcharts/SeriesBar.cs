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
	public partial class SeriesBar  : BaseObject
	{
		public SeriesBar()
		{
			Data = Data_DefaultValue = new List<SeriesBarData>();
			Data = Data_DefaultValue = new List<SeriesBarData>();
			Data = Data_DefaultValue = new List<SeriesBarData>();
			Data = Data_DefaultValue = new List<SeriesBarData>();
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `bar` series type,points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. The `x` values will be automaticallycalculated, either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. If the axis hascategories, these will be used. Example: ```js data: [0, 5, 3, 5] ```2.  An array of arrays with 2 values. In this case, the values correspondto `x,y`. If the first value is a string, it is applied as the nameof the point, and the `x` value is inferred. ```js    data: [        [0, 5],        [1, 10],        [2, 3]    ] ```3.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.bar.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 1,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 10,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesBarData> Data { get; set; }
		private List<SeriesBarData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `bar` series type,points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. The `x` values will be automaticallycalculated, either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. If the axis hascategories, these will be used. Example: ```js data: [0, 5, 3, 5] ```2.  An array of arrays with 2 values. In this case, the values correspondto `x,y`. If the first value is a string, it is applied as the nameof the point, and the `x` value is inferred. ```js    data: [        [0, 5],        [1, 10],        [2, 3]    ] ```3.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.bar.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 1,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 10,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesBarData> Data { get; set; }
		private List<SeriesBarData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `bar` series type,points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. The `x` values will be automaticallycalculated, either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. If the axis hascategories, these will be used. Example: ```js data: [0, 5, 3, 5] ```2.  An array of arrays with 2 values. In this case, the values correspondto `x,y`. If the first value is a string, it is applied as the nameof the point, and the `x` value is inferred. ```js    data: [        [0, 5],        [1, 10],        [2, 3]    ] ```3.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.bar.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 1,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 10,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesBarData> Data { get; set; }
		private List<SeriesBarData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `bar` series type,points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. The `x` values will be automaticallycalculated, either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. If the axis hascategories, these will be used. Example: ```js data: [0, 5, 3, 5] ```2.  An array of arrays with 2 values. In this case, the values correspondto `x,y`. If the first value is a string, it is applied as the nameof the point, and the `x` value is inferred. ```js    data: [        [0, 5],        [1, 10],        [2, 3]    ] ```3.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.bar.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 1,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 10,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesBarData> Data { get; set; }
		private List<SeriesBarData> Data_DefaultValue { get; set; }
		  

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
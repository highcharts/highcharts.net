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
	public partial class SeriesWaterfall  : BaseObject
	{
		public SeriesWaterfall()
		{
			Data = Data_DefaultValue = new List<SeriesWaterfallData>();
			Data = Data_DefaultValue = new List<SeriesWaterfallData>();
			IsIntermediateSum = IsIntermediateSum_DefaultValue = false;
			IsSum = IsSum_DefaultValue = false;
			Data = Data_DefaultValue = new List<SeriesWaterfallData>();
			IsIntermediateSum = IsIntermediateSum_DefaultValue = false;
			IsSum = IsSum_DefaultValue = false;
			Data = Data_DefaultValue = new List<SeriesWaterfallData>();
			IsIntermediateSum = IsIntermediateSum_DefaultValue = false;
			IsSum = IsSum_DefaultValue = false;
			IsIntermediateSum = IsIntermediateSum_DefaultValue = false;
			IsSum = IsSum_DefaultValue = false;
			IsIntermediateSum = IsIntermediateSum_DefaultValue = false;
			IsSum = IsSum_DefaultValue = false;
			IsIntermediateSum = IsIntermediateSum_DefaultValue = false;
			IsSum = IsSum_DefaultValue = false;
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `waterfall` seriestype, points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. The `x` values will be automaticallycalculated, either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. If the axis hascategories, these will be used. Example: ```js data: [0, 5, 3, 5] ```2.  An array of arrays with 2 values. In this case, the values correspondto `x,y`. If the first value is a string, it is applied as the nameof the point, and the `x` value is inferred. ```js    data: [        [0, 7],        [1, 8],        [2, 3]    ] ```3.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.waterfall.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 8,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 8,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesWaterfallData> Data { get; set; }
		private List<SeriesWaterfallData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `waterfall` seriestype, points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. The `x` values will be automaticallycalculated, either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. If the axis hascategories, these will be used. Example: ```js data: [0, 5, 3, 5] ```2.  An array of arrays with 2 values. In this case, the values correspondto `x,y`. If the first value is a string, it is applied as the nameof the point, and the `x` value is inferred. ```js    data: [        [0, 7],        [1, 8],        [2, 3]    ] ```3.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.waterfall.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 8,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 8,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesWaterfallData> Data { get; set; }
		private List<SeriesWaterfallData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the points acts as a summary column forthe values added or substracted since the last intermediate sum,or since the start of the series. The `y` value is ignored.
		/// </summary>
		public bool? IsIntermediateSum { get; set; }
		private bool? IsIntermediateSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the point display the total sum acrossthe entire series. The `y` value is ignored.
		/// </summary>
		public bool? IsSum { get; set; }
		private bool? IsSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `waterfall` seriestype, points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. The `x` values will be automaticallycalculated, either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. If the axis hascategories, these will be used. Example: ```js data: [0, 5, 3, 5] ```2.  An array of arrays with 2 values. In this case, the values correspondto `x,y`. If the first value is a string, it is applied as the nameof the point, and the `x` value is inferred. ```js    data: [        [0, 7],        [1, 8],        [2, 3]    ] ```3.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.waterfall.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 8,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 8,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesWaterfallData> Data { get; set; }
		private List<SeriesWaterfallData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the points acts as a summary column forthe values added or substracted since the last intermediate sum,or since the start of the series. The `y` value is ignored.
		/// </summary>
		public bool? IsIntermediateSum { get; set; }
		private bool? IsIntermediateSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the point display the total sum acrossthe entire series. The `y` value is ignored.
		/// </summary>
		public bool? IsSum { get; set; }
		private bool? IsSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `waterfall` seriestype, points can be given in the following ways:1.  An array of numerical values. In this case, the numerical valueswill be interpreted as `y` options. The `x` values will be automaticallycalculated, either starting at 0 and incremented by 1, or from `pointStart`and `pointInterval` given in the series options. If the axis hascategories, these will be used. Example: ```js data: [0, 5, 3, 5] ```2.  An array of arrays with 2 values. In this case, the values correspondto `x,y`. If the first value is a string, it is applied as the nameof the point, and the `x` value is inferred. ```js    data: [        [0, 7],        [1, 8],        [2, 3]    ] ```3.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.waterfall.turboThreshold),this option is not available. ```js    data: [{        x: 1,        y: 8,        name: "Point2",        color: "#00FF00"    }, {        x: 1,        y: 8,        name: "Point1",        color: "#FF00FF"    }] ```
		/// </summary>
		public List<SeriesWaterfallData> Data { get; set; }
		private List<SeriesWaterfallData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the points acts as a summary column forthe values added or substracted since the last intermediate sum,or since the start of the series. The `y` value is ignored.
		/// </summary>
		public bool? IsIntermediateSum { get; set; }
		private bool? IsIntermediateSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the point display the total sum acrossthe entire series. The `y` value is ignored.
		/// </summary>
		public bool? IsSum { get; set; }
		private bool? IsSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the points acts as a summary column forthe values added or substracted since the last intermediate sum,or since the start of the series. The `y` value is ignored.
		/// </summary>
		public bool? IsIntermediateSum { get; set; }
		private bool? IsIntermediateSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the point display the total sum acrossthe entire series. The `y` value is ignored.
		/// </summary>
		public bool? IsSum { get; set; }
		private bool? IsSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the points acts as a summary column forthe values added or substracted since the last intermediate sum,or since the start of the series. The `y` value is ignored.
		/// </summary>
		public bool? IsIntermediateSum { get; set; }
		private bool? IsIntermediateSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the point display the total sum acrossthe entire series. The `y` value is ignored.
		/// </summary>
		public bool? IsSum { get; set; }
		private bool? IsSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the points acts as a summary column forthe values added or substracted since the last intermediate sum,or since the start of the series. The `y` value is ignored.
		/// </summary>
		public bool? IsIntermediateSum { get; set; }
		private bool? IsIntermediateSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the point display the total sum acrossthe entire series. The `y` value is ignored.
		/// </summary>
		public bool? IsSum { get; set; }
		private bool? IsSum_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (IsIntermediateSum != IsIntermediateSum_DefaultValue) h.Add("isIntermediateSum",IsIntermediateSum);
			if (IsSum != IsSum_DefaultValue) h.Add("isSum",IsSum);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (IsIntermediateSum != IsIntermediateSum_DefaultValue) h.Add("isIntermediateSum",IsIntermediateSum);
			if (IsSum != IsSum_DefaultValue) h.Add("isSum",IsSum);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (IsIntermediateSum != IsIntermediateSum_DefaultValue) h.Add("isIntermediateSum",IsIntermediateSum);
			if (IsSum != IsSum_DefaultValue) h.Add("isSum",IsSum);
			if (IsIntermediateSum != IsIntermediateSum_DefaultValue) h.Add("isIntermediateSum",IsIntermediateSum);
			if (IsSum != IsSum_DefaultValue) h.Add("isSum",IsSum);
			if (IsIntermediateSum != IsIntermediateSum_DefaultValue) h.Add("isIntermediateSum",IsIntermediateSum);
			if (IsSum != IsSum_DefaultValue) h.Add("isSum",IsSum);
			if (IsIntermediateSum != IsIntermediateSum_DefaultValue) h.Add("isIntermediateSum",IsIntermediateSum);
			if (IsSum != IsSum_DefaultValue) h.Add("isSum",IsSum);
			

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
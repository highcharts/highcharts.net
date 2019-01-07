using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PackedbubbleSeries  : Series
	{
		public PackedbubbleSeries()
		{
			Data = Data_DefaultValue = new List<PackedbubbleSeriesData>();
			Marker = Marker_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `packedbubble` series type,points can be given in the following ways:1. An array of `value` values.   ```js   data: [5, 1, 20]   ```2. An array of objects with named values. The objects are point configuration   objects as seen below. If the total number of data points exceeds the   series' [turboThreshold](#series.packedbubble.turboThreshold), this option   is not available.   ```js   data: [{       value: 1,       name: "Point2",       color: "#00FF00"   }, {       value: 5,       name: "Point1",       color: "#FF00FF"   }]   ```
		/// </summary>
		public List<PackedbubbleSeriesData> Data { get; set; }
		private List<PackedbubbleSeriesData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Marker { get; set; }
		private string Marker_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Marker != Marker_DefaultValue) h.Add("marker",Marker);
			

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
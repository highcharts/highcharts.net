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
	public partial class SeriesWordcloud  : BaseObject
	{
		public SeriesWordcloud()
		{
			Data = Data_DefaultValue = new List<SeriesWordcloudData>();
			Data = Data_DefaultValue = new List<SeriesWordcloudData>();
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `wordcloud` seriestype, points can be given in the following ways:1.  An array of arrays with 2 values. In this case, the valuescorrespond to `name,weight`.  ```js    data: [        ['Lorem', 4],        ['Ipsum', 1]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.arearange.turboThreshold),this option is not available. ```js    data: [{        name: "Lorem",        weight: 4    }, {        name: "Ipsum",        weight: 1    }] ```
		/// </summary>
		public List<SeriesWordcloudData> Data { get; set; }
		private List<SeriesWordcloudData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `wordcloud` seriestype, points can be given in the following ways:1.  An array of arrays with 2 values. In this case, the valuescorrespond to `name,weight`.  ```js    data: [        ['Lorem', 4],        ['Ipsum', 1]    ] ```2.  An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.arearange.turboThreshold),this option is not available. ```js    data: [{        name: "Lorem",        weight: 4    }, {        name: "Ipsum",        weight: 1    }] ```
		/// </summary>
		public List<SeriesWordcloudData> Data { get; set; }
		private List<SeriesWordcloudData> Data_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

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
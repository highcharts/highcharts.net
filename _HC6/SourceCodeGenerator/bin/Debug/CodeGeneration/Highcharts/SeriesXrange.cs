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
	public partial class SeriesXrange  : BaseObject
	{
		public SeriesXrange()
		{
			Data = Data_DefaultValue = new List<SeriesXrangeData>();
			Data = Data_DefaultValue = new List<SeriesXrangeData>();
			Data = Data_DefaultValue = new List<SeriesXrangeData>();
			Data = Data_DefaultValue = new List<SeriesXrangeData>();
			
		}	
		

		/// <summary>
		/// An array of data points for the series. For the `xrange` series type,points can be given in the following ways:1.  An array of objects with named values. The objects are pointconfiguration objects as seen below. ```js    data: [{        x: Date.UTC(2017, 0, 1),        x2: Date.UTC(2017, 0, 3),        name: "Test",        y: 0,        color: "#00FF00"    }, {        x: Date.UTC(2017, 0, 4),        x2: Date.UTC(2017, 0, 5),        name: "Deploy",        y: 1,        color: "#FF0000"    }] ```
		/// </summary>
		public List<SeriesXrangeData> Data { get; set; }
		private List<SeriesXrangeData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `xrange` series type,points can be given in the following ways:1.  An array of objects with named values. The objects are pointconfiguration objects as seen below. ```js    data: [{        x: Date.UTC(2017, 0, 1),        x2: Date.UTC(2017, 0, 3),        name: "Test",        y: 0,        color: "#00FF00"    }, {        x: Date.UTC(2017, 0, 4),        x2: Date.UTC(2017, 0, 5),        name: "Deploy",        y: 1,        color: "#FF0000"    }] ```
		/// </summary>
		public List<SeriesXrangeData> Data { get; set; }
		private List<SeriesXrangeData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `xrange` series type,points can be given in the following ways:1.  An array of objects with named values. The objects are pointconfiguration objects as seen below. ```js    data: [{        x: Date.UTC(2017, 0, 1),        x2: Date.UTC(2017, 0, 3),        name: "Test",        y: 0,        color: "#00FF00"    }, {        x: Date.UTC(2017, 0, 4),        x2: Date.UTC(2017, 0, 5),        name: "Deploy",        y: 1,        color: "#FF0000"    }] ```
		/// </summary>
		public List<SeriesXrangeData> Data { get; set; }
		private List<SeriesXrangeData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `xrange` series type,points can be given in the following ways:1.  An array of objects with named values. The objects are pointconfiguration objects as seen below. ```js    data: [{        x: Date.UTC(2017, 0, 1),        x2: Date.UTC(2017, 0, 3),        name: "Test",        y: 0,        color: "#00FF00"    }, {        x: Date.UTC(2017, 0, 4),        x2: Date.UTC(2017, 0, 5),        name: "Deploy",        y: 1,        color: "#FF0000"    }] ```
		/// </summary>
		public List<SeriesXrangeData> Data { get; set; }
		private List<SeriesXrangeData> Data_DefaultValue { get; set; }
		  

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
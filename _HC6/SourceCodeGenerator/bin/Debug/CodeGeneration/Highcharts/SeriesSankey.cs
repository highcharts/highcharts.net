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
	public partial class SeriesSankey  : BaseObject
	{
		public SeriesSankey()
		{
			Nodes = Nodes_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesSankeyData>();
			Nodes = Nodes_DefaultValue = "";
			Id = Id_DefaultValue = "";
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesSankeyData>();
			From = From_DefaultValue = "";
			To = To_DefaultValue = "";
			Outgoing = Outgoing_DefaultValue = false;
			Weight = Weight_DefaultValue = null;
			Nodes = Nodes_DefaultValue = "";
			Id = Id_DefaultValue = "";
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesSankeyData>();
			From = From_DefaultValue = "";
			To = To_DefaultValue = "";
			Outgoing = Outgoing_DefaultValue = false;
			Weight = Weight_DefaultValue = null;
			Nodes = Nodes_DefaultValue = "";
			Id = Id_DefaultValue = "";
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesSankeyData>();
			From = From_DefaultValue = "";
			To = To_DefaultValue = "";
			Outgoing = Outgoing_DefaultValue = false;
			Weight = Weight_DefaultValue = null;
			From = From_DefaultValue = "";
			To = To_DefaultValue = "";
			Outgoing = Outgoing_DefaultValue = false;
			Weight = Weight_DefaultValue = null;
			From = From_DefaultValue = "";
			To = To_DefaultValue = "";
			Outgoing = Outgoing_DefaultValue = false;
			Weight = Weight_DefaultValue = null;
			From = From_DefaultValue = "";
			To = To_DefaultValue = "";
			Outgoing = Outgoing_DefaultValue = false;
			Weight = Weight_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// A collection of options for the individual nodes. The nodes in a sankey diagram are auto-generated instances of `Highcharts.Point`, but options canbe applied here and linked by the `id`.
		/// </summary>
		public List<object> Nodes { get; set; }
		private List<object> Nodes_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `sankey` series type,points can be given in the following way:An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.area.turboThreshold),this option is not available. ```js    data: [{        from: 'Category1',        to: 'Category2',        weight: 2    }, {        from: 'Category1',        to: 'Category3',        weight: 5    }] ```
		/// </summary>
		public List<SeriesSankeyData> Data { get; set; }
		private List<SeriesSankeyData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of options for the individual nodes. The nodes in a sankey diagram are auto-generated instances of `Highcharts.Point`, but options canbe applied here and linked by the `id`.
		/// </summary>
		public List<object> Nodes { get; set; }
		private List<object> Nodes_DefaultValue { get; set; }
		 

		/// <summary>
		/// The id of the auto-generated node, refering to the `from` or `to` setting ofthe link.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the auto generated node.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color index of the auto generated node, especially for use in styledmode.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `sankey` series type,points can be given in the following way:An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.area.turboThreshold),this option is not available. ```js    data: [{        from: 'Category1',        to: 'Category2',        weight: 2    }, {        from: 'Category1',        to: 'Category3',        weight: 5    }] ```
		/// </summary>
		public List<SeriesSankeyData> Data { get; set; }
		private List<SeriesSankeyData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs from.
		/// </summary>
		public string From { get; set; }
		private string From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs to.
		/// </summary>
		public string To { get; set; }
		private string To_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the link goes out of the system.
		/// </summary>
		public bool? Outgoing { get; set; }
		private bool? Outgoing_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weight of the link.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of options for the individual nodes. The nodes in a sankey diagram are auto-generated instances of `Highcharts.Point`, but options canbe applied here and linked by the `id`.
		/// </summary>
		public List<object> Nodes { get; set; }
		private List<object> Nodes_DefaultValue { get; set; }
		 

		/// <summary>
		/// The id of the auto-generated node, refering to the `from` or `to` setting ofthe link.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the auto generated node.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color index of the auto generated node, especially for use in styledmode.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `sankey` series type,points can be given in the following way:An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.area.turboThreshold),this option is not available. ```js    data: [{        from: 'Category1',        to: 'Category2',        weight: 2    }, {        from: 'Category1',        to: 'Category3',        weight: 5    }] ```
		/// </summary>
		public List<SeriesSankeyData> Data { get; set; }
		private List<SeriesSankeyData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs from.
		/// </summary>
		public string From { get; set; }
		private string From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs to.
		/// </summary>
		public string To { get; set; }
		private string To_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the link goes out of the system.
		/// </summary>
		public bool? Outgoing { get; set; }
		private bool? Outgoing_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weight of the link.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of options for the individual nodes. The nodes in a sankey diagram are auto-generated instances of `Highcharts.Point`, but options canbe applied here and linked by the `id`.
		/// </summary>
		public List<object> Nodes { get; set; }
		private List<object> Nodes_DefaultValue { get; set; }
		 

		/// <summary>
		/// The id of the auto-generated node, refering to the `from` or `to` setting ofthe link.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the auto generated node.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color index of the auto generated node, especially for use in styledmode.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `sankey` series type,points can be given in the following way:An array of objects with named values. The objects are pointconfiguration objects as seen below. If the total number of datapoints exceeds the series' [turboThreshold](#series.area.turboThreshold),this option is not available. ```js    data: [{        from: 'Category1',        to: 'Category2',        weight: 2    }, {        from: 'Category1',        to: 'Category3',        weight: 5    }] ```
		/// </summary>
		public List<SeriesSankeyData> Data { get; set; }
		private List<SeriesSankeyData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs from.
		/// </summary>
		public string From { get; set; }
		private string From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs to.
		/// </summary>
		public string To { get; set; }
		private string To_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the link goes out of the system.
		/// </summary>
		public bool? Outgoing { get; set; }
		private bool? Outgoing_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weight of the link.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs from.
		/// </summary>
		public string From { get; set; }
		private string From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs to.
		/// </summary>
		public string To { get; set; }
		private string To_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the link goes out of the system.
		/// </summary>
		public bool? Outgoing { get; set; }
		private bool? Outgoing_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weight of the link.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs from.
		/// </summary>
		public string From { get; set; }
		private string From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs to.
		/// </summary>
		public string To { get; set; }
		private string To_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the link goes out of the system.
		/// </summary>
		public bool? Outgoing { get; set; }
		private bool? Outgoing_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weight of the link.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs from.
		/// </summary>
		public string From { get; set; }
		private string From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs to.
		/// </summary>
		public string To { get; set; }
		private string To_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the link goes out of the system.
		/// </summary>
		public bool? Outgoing { get; set; }
		private bool? Outgoing_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weight of the link.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Nodes.IsDirty()) h.Add("nodes",Nodes.ToHashtable());
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (Nodes.IsDirty()) h.Add("nodes",Nodes.ToHashtable());
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (From != From_DefaultValue) h.Add("from",From);
			if (To != To_DefaultValue) h.Add("to",To);
			if (Outgoing != Outgoing_DefaultValue) h.Add("outgoing",Outgoing);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			if (Nodes.IsDirty()) h.Add("nodes",Nodes.ToHashtable());
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (From != From_DefaultValue) h.Add("from",From);
			if (To != To_DefaultValue) h.Add("to",To);
			if (Outgoing != Outgoing_DefaultValue) h.Add("outgoing",Outgoing);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			if (Nodes.IsDirty()) h.Add("nodes",Nodes.ToHashtable());
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (From != From_DefaultValue) h.Add("from",From);
			if (To != To_DefaultValue) h.Add("to",To);
			if (Outgoing != Outgoing_DefaultValue) h.Add("outgoing",Outgoing);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			if (From != From_DefaultValue) h.Add("from",From);
			if (To != To_DefaultValue) h.Add("to",To);
			if (Outgoing != Outgoing_DefaultValue) h.Add("outgoing",Outgoing);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			if (From != From_DefaultValue) h.Add("from",From);
			if (To != To_DefaultValue) h.Add("to",To);
			if (Outgoing != Outgoing_DefaultValue) h.Add("outgoing",Outgoing);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			if (From != From_DefaultValue) h.Add("from",From);
			if (To != To_DefaultValue) h.Add("to",To);
			if (Outgoing != Outgoing_DefaultValue) h.Add("outgoing",Outgoing);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			

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
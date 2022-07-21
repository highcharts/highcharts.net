using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class WilliamsrSeriesOnPoint  : BaseObject
	{
		Hashtable h = new Hashtable();

		public WilliamsrSeriesOnPoint()
		{
			ConnectorOptions = ConnectorOptions_DefaultValue = new WilliamsrSeriesOnPointConnectorOptions();
			Id = Id_DefaultValue = "";
			Position = Position_DefaultValue = new Hashtable();
			
		}	
		

		/// <summary>
		/// Options for the connector in the _Series on point_ feature.In styled mode, the connector can be styled with the`.highcharts-connector-seriesonpoint` class name.
		/// </summary>
		public WilliamsrSeriesOnPointConnectorOptions ConnectorOptions { get; set; }
		private WilliamsrSeriesOnPointConnectorOptions ConnectorOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `id` of the point that we connect the series to. Only points with a given`plotX` and `plotY` values and map points are valid.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options allowing to set a position and an offset of the series in the_Series on point_ feature.
		/// </summary>
		public Hashtable Position { get; set; }
		private Hashtable Position_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ConnectorOptions.IsDirty(ref highstock)) h.Add("connectorOptions",ConnectorOptions.ToHashtable(ref highstock));
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Position != Position_DefaultValue) h.Add("position",Position);
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}